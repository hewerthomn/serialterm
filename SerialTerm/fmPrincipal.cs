using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialTerm
{
    public partial class fmPrincipal : Form
    {
        public fmPrincipal()
        {
            InitializeComponent();

            ScanPorts();
            ListBaudRates();
            ListDataBits();
            ListParity();
            ListStopBits();
            ListHandshaking();
        }

        private void btnToggleAdvanced_Click(object sender, EventArgs e)
        {
            pnAdvanced.Visible = !pnAdvanced.Visible;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ScanPorts();
        }

        private void ScanPorts()
        {
            List<String> allPorts = new List<string>();
            foreach (String portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                allPorts.Add(portName);
            }

            cbPorts.Items.AddRange(allPorts.ToArray());
            if (cbPorts.Items.Count > 0)
            {
                cbPorts.SelectedIndex = 0;
            }
        }

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
            List<Parity> parities = new List<Parity>();
            parities.Add(Parity.None);
            parities.Add(Parity.Odd);
            parities.Add(Parity.Even);
            parities.Add(Parity.Mark);
            parities.Add(Parity.Space);

            cbParity.Items.Add(parities.ToArray());
            cbParity.SelectedIndex = 0;
        }

        private void ListHandshaking()
        {
            List<Handshake> hands = new List<Handshake>();
            hands.Add(Handshake.None);
            hands.Add(Handshake.RequestToSend);
            hands.Add(Handshake.XOnXOff);
            hands.Add(Handshake.RequestToSendXOnXOff);

            cbHandshake.Items.Add(hands.ToArray());
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

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if(true)
            {
                OpenConn();
            }
            else
            {
                CloseConn();
            }
        }

        private void OpenConn()
        {

        }

        private void CloseConn()
        {
            
        }
    }
}
