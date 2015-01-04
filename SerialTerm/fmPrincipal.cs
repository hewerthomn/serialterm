using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SerialTerm
{
    public partial class fmPrincipal : Form
    {
        SerialPort _conn;
        Boolean _continue;
        Thread readThread;
        
        public fmPrincipal()
        {
            InitializeComponent();

            ScanPorts();
            ListBaudRates();
            ListDataBits();
            ListParity();
            ListStopBits();
            ListHandshaking();
            ListLinefeed();
        }

        private void OpenConn()
        {
            readThread = new Thread(ReadText);

            String port = cbPorts.Text;
            int baudRate = int.Parse(cbBaudrate.Text);
            int dataBits = 8;
            int timeout = 500;
            Parity parity = Parity.None;
            StopBits stopBits = StopBits.One;
            Handshake handshake = Handshake.None;

            if (pnAdvanced.Visible)
            {
                dataBits = int.Parse(cbDatabits.Text);
                parity = getParity();
                stopBits = getStopBits();
                handshake = getHandshake();
            }

            timeout = (int)txtTimeout.Value;

            _conn = new SerialPort(port, baudRate, parity, dataBits, stopBits);
            _conn.Handshake = handshake;
            _conn.ReadTimeout = timeout;
            _conn.WriteTimeout = timeout;

            try
            {
                ChangeTitle("Opening...");
                ChangeToggleButton("Opening...", false);
                Thread.Sleep(500);

                _conn.Open();
                _continue = true;

                OnOpenConn();
                
                readThread.Start();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to open.");
                CloseConn();
            }
        }
        private void CloseConn()
        {
            _continue = false;
            try
            {
                readThread.Suspend();
            }
            catch { }
            
            if (IsConnected())
            {
                _conn.Close();
            }

            _conn = null;

            OnCloseConn();
        }

        private void OnOpenConn()
        {
            ChangeTitle(String.Format("Connected in {0} @ {1}", _conn.PortName, _conn.BaudRate));
            ChangeToggleButton("Cl&ose", true);

            PortsEnabled(false);
            BaudrateEnabled(false);
            PanelInputEnabled(true);
            PanelAdvancedEnabled(false);

            if (chkClearOnOpen.Checked)
            {
                ClearOutput();
            }

            SetOutput(new string('-', 100));
            String message = String.Format("Connected in port {0} at {1}.", _conn.PortName, _conn.BaudRate);
            SetOutput(message);

        }

        private void OnCloseConn()
        {
            ChangeTitle("Disconnected");
            ChangeToggleButton("&Open", true);

            PortsEnabled(true);
            BaudrateEnabled(true);
            PanelInputEnabled(false);
            PanelAdvancedEnabled(true);

            SetOutput("Closed");
            SetOutput(new string('-', 100));
        }

        private void ReadText()
        {
            while(_continue)
            {
                try
                {
                    string message = _conn.ReadLine();
                    SetOutput(message);
                }                
                catch (Exception) { }
            }
        }

        private void SendText()
        {
            if (IsConnected())
            {
                string input = txtInput.Text;
                txtInput.Clear();
                
                if ("quit".Equals(input))
                {
                    _continue = false;
                }
                else
                {
                    string linefeed = getLinefeed(); ;
                    _conn.NewLine = linefeed;
                    
                    _conn.WriteLine(input);
                }
            }
        }

        private bool IsConnected()
        {
            return (_conn != null && _conn.IsOpen);
        }
        
        private void ScanPorts()
        {
            List<String> allPorts = new List<string>();
            foreach (String portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                allPorts.Add(portName);
            }

            cbPorts.Items.Clear();
            cbPorts.Items.AddRange(allPorts.ToArray());

            if (cbPorts.Items.Count > 0)
            {
                cbPorts.SelectedIndex = 0;
            }
        }

        #region Events
        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (IsConnected())
            {
                CloseConn();
            }
            else
            {
                OpenConn();
            }
        }

        private void btnToggleAdvanced_Click(object sender, EventArgs e)
        {
            pnAdvanced.Visible = !pnAdvanced.Visible;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ScanPorts();
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendText();
            }
        }

        private void txtOutput_Enter(object sender, EventArgs e)
        {
            fmPrincipal.ActiveForm.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOutput();
        }

        private void fmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConn();
        }

        private void fmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyData != (Keys.RButton | Keys.ShiftKey | Keys.Alt))
            {
                switch (e.KeyCode)
                {
                    case Keys.C:
                        ClearOutput();
                        break;

                    case Keys.I:
                        txtInput.Focus();
                        break;

                    case Keys.O:
                        btnToggle_Click(null, null);
                        break;
                }
            }
        }
        #endregion

        #region Delegates

        delegate void PortsEnabledCallback(bool enabled);
        private void PortsEnabled(bool enabled)
        {
            if(this.cbPorts.InvokeRequired)
            {
                PortsEnabledCallback d = new PortsEnabledCallback(PortsEnabled);
                this.Invoke(d, new object[] { enabled });
            }
            else
            {
                this.cbPorts.Enabled = enabled;
            }
        }

        delegate void BaudrateEnabledCallback(bool enabled);
        private void BaudrateEnabled(bool enabled)
        {
            if (this.cbBaudrate.InvokeRequired)
            {
                BaudrateEnabledCallback d = new BaudrateEnabledCallback(BaudrateEnabled);
                this.Invoke(d, new object[] { enabled });
            }
            else
            {
                this.cbBaudrate.Enabled = enabled;
            }
        }

        delegate void PanelAdvancedEnabledCallback(bool enabled);
        private void PanelAdvancedEnabled(bool enabled)
        {
            if (this.pnAdvanced.InvokeRequired)
            {
                PanelAdvancedEnabledCallback d = new PanelAdvancedEnabledCallback(PanelAdvancedEnabled);
                this.Invoke(d, new object[] { enabled });
            }
            else
            {
                this.pnAdvanced.Enabled = enabled;
            }
        }

        delegate void PanelInputEnabledCallback(bool enabled);
        private void PanelInputEnabled(bool enabled)
        {
            if (this.pnInput.InvokeRequired)
            {
                PanelInputEnabledCallback d = new PanelInputEnabledCallback(PanelInputEnabled);
                this.Invoke(d, new object[] { enabled });
            }
            else
            {
                this.pnInput.Enabled = enabled;
            }
        }

        delegate void SetOutputCallback(string text);
        private void SetOutput(string text)
        {
            if(this.txtOutput.InvokeRequired)
            {
                SetOutputCallback d = new SetOutputCallback(SetOutput);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if(chkPrependTimestamp.Checked)
                {
                    text = string.Format("{0}: {1}", DateTime.Now, text);
                }

                this.txtOutput.AppendText(text + "\r\n");
            }
        }

        delegate void ClearOutputCallback();
        private void ClearOutput()
        {
            if (this.txtOutput.InvokeRequired)
            {
                ClearOutputCallback d = new ClearOutputCallback(ClearOutput);
                this.Invoke(d);
            }
            else
            {
                this.txtOutput.Clear();
            }
        }

        delegate void ChangeToggleButtonCallback(string text, bool enabled = true);
        private void ChangeToggleButton(string text, bool enabled = true)
        {
            if (this.btnToggle.InvokeRequired)
            {
                ChangeToggleButtonCallback d = new ChangeToggleButtonCallback(ChangeToggleButton);
                this.Invoke(d, new object[] { text, enabled });
            }
            else
            {
                this.btnToggle.Text = text;
                this.btnToggle.Enabled = enabled;
            }
        }

        delegate void ChangeTitleCallback(string text);
        private void ChangeTitle(string text)
        {
            if(this.InvokeRequired)
            {
                ChangeTitleCallback d = new ChangeTitleCallback(ChangeTitle);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Text = String.Format("SerialTerm - {0}", text);
            }
        }
        #endregion

        #region List ComboBox
        private void ListBaudRates()
        {
            List<String> baudrates = new List<string>();
            baudrates.Add("4800");
            baudrates.Add("9600");
            baudrates.Add("14400");
            baudrates.Add("19200");
            baudrates.Add("28800");
            baudrates.Add("38400");
            baudrates.Add("56000");
            baudrates.Add("57600");
            baudrates.Add("115200");

            cbBaudrate.Items.AddRange(baudrates.ToArray());
            cbBaudrate.SelectedIndex = 0;
        }

        private void ListDataBits()
        {
            List<String> bits = new List<String>();
            bits.Add("5");
            bits.Add("6");
            bits.Add("7");
            bits.Add("8");

            cbDatabits.Items.AddRange(bits.ToArray());
            cbDatabits.SelectedIndex = bits.Count() - 1;
        }

        private void ListParity()
        {
            List<String> parities = new List<String>();
            parities.Add(Parity.None.ToString());
            parities.Add(Parity.Odd.ToString());
            parities.Add(Parity.Even.ToString());
            parities.Add(Parity.Mark.ToString());
            parities.Add(Parity.Space.ToString());

            cbParity.Items.AddRange(parities.ToArray());
            cbParity.SelectedIndex = 0;
        }

        private void ListHandshaking()
        {
            List<String> hands = new List<String>();
            hands.Add(Handshake.None.ToString());
            hands.Add(Handshake.RequestToSend.ToString());
            hands.Add(Handshake.XOnXOff.ToString());
            hands.Add(Handshake.RequestToSendXOnXOff.ToString());

            cbHandshake.Items.AddRange(hands.ToArray());
            cbHandshake.SelectedIndex = 0;
        }

        private void ListStopBits()
        {
            List<String> stop = new List<String>();
            stop.Add(StopBits.One.ToString());
            stop.Add(StopBits.OnePointFive.ToString());
            stop.Add(StopBits.Two.ToString());
            stop.Add(StopBits.None.ToString());

            cbStopbits.Items.AddRange(stop.ToArray());
            cbStopbits.SelectedIndex = 0;
        }

        private void ListLinefeed()
        {
            cbLineEnd.Items.Add("No End Line");
            cbLineEnd.Items.Add("New line");
            cbLineEnd.Items.Add("Carriage return");
            cbLineEnd.Items.Add("Both NL and CR");

            cbLineEnd.SelectedIndex = 3;
        }
        #endregion

        #region Get/Set
        private Parity getParity()
        {
            String parity = cbParity.Text;
            switch (parity)
            {
                default:
                case "None": return Parity.None;
                case "Odd": return Parity.Odd;
                case "Even": return Parity.Even;
                case "Mark": return Parity.Mark;
                case "Space": return Parity.Space;
            }
        }

        private StopBits getStopBits()
        {
            String stopBits = cbStopbits.Text;
            switch (stopBits)
            {
                default:
                case "One": return StopBits.One;
                case "OnePointFive": return StopBits.OnePointFive;
                case "Two": return StopBits.Two;
                case "None": return StopBits.None;
            }
        }

        private Handshake getHandshake()
        {
            String handshake = cbHandshake.Text;
            switch (handshake)
            {
                default:
                case "None": return Handshake.None;
                case "RequestToSend": return Handshake.RequestToSend;
                case "RequestToSendXOnXOff": return Handshake.RequestToSendXOnXOff;
                case "XOnXOff": return Handshake.XOnXOff;
            }
        }

        private String getLinefeed()
        {
            string linefeed = cbLineEnd.Text;
            switch(linefeed)
            {
                default:
                case "No End Line": return "\0";
                case "New line": return "\n";
                case "Carriage return": return "\r";
                case "Both NL and CR": return "\n\r";
            }
        }
        #endregion
    }
}
