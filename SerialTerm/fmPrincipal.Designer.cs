namespace SerialTerm
{
    partial class fmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblBaudate = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.btnToggle = new System.Windows.Forms.Button();
            this.pnAdvanced = new System.Windows.Forms.Panel();
            this.lblHandshaking = new System.Windows.Forms.Label();
            this.cbHandshake = new System.Windows.Forms.ComboBox();
            this.lblStopbits = new System.Windows.Forms.Label();
            this.cbStopbits = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.lblDatabits = new System.Windows.Forms.Label();
            this.cbDatabits = new System.Windows.Forms.ComboBox();
            this.btnToggleAdvanced = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.ckClearOnOpen = new System.Windows.Forms.CheckBox();
            this.chkPrependTimestamp = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pnAdvanced.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(35, 23);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(74, 21);
            this.cbPorts.TabIndex = 0;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(9, 4);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port";
            // 
            // lblBaudate
            // 
            this.lblBaudate.AutoSize = true;
            this.lblBaudate.Location = new System.Drawing.Point(115, 9);
            this.lblBaudate.Name = "lblBaudate";
            this.lblBaudate.Size = new System.Drawing.Size(53, 13);
            this.lblBaudate.TabIndex = 3;
            this.lblBaudate.Text = "Baud rate";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Location = new System.Drawing.Point(115, 24);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(89, 21);
            this.cbBaudrate.TabIndex = 2;
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(210, 22);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(56, 23);
            this.btnToggle.TabIndex = 4;
            this.btnToggle.Text = "&Open";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // pnAdvanced
            // 
            this.pnAdvanced.Controls.Add(this.lblHandshaking);
            this.pnAdvanced.Controls.Add(this.cbHandshake);
            this.pnAdvanced.Controls.Add(this.lblStopbits);
            this.pnAdvanced.Controls.Add(this.cbStopbits);
            this.pnAdvanced.Controls.Add(this.lblParity);
            this.pnAdvanced.Controls.Add(this.cbParity);
            this.pnAdvanced.Controls.Add(this.lblDatabits);
            this.pnAdvanced.Controls.Add(this.cbDatabits);
            this.pnAdvanced.Location = new System.Drawing.Point(306, 6);
            this.pnAdvanced.Name = "pnAdvanced";
            this.pnAdvanced.Size = new System.Drawing.Size(354, 42);
            this.pnAdvanced.TabIndex = 7;
            // 
            // lblHandshaking
            // 
            this.lblHandshaking.AutoSize = true;
            this.lblHandshaking.Location = new System.Drawing.Point(235, -1);
            this.lblHandshaking.Name = "lblHandshaking";
            this.lblHandshaking.Size = new System.Drawing.Size(70, 13);
            this.lblHandshaking.TabIndex = 15;
            this.lblHandshaking.Text = "Handshaking";
            // 
            // cbHandshake
            // 
            this.cbHandshake.FormattingEnabled = true;
            this.cbHandshake.Location = new System.Drawing.Point(235, 15);
            this.cbHandshake.Name = "cbHandshake";
            this.cbHandshake.Size = new System.Drawing.Size(109, 21);
            this.cbHandshake.TabIndex = 14;
            // 
            // lblStopbits
            // 
            this.lblStopbits.AutoSize = true;
            this.lblStopbits.Location = new System.Drawing.Point(143, 0);
            this.lblStopbits.Name = "lblStopbits";
            this.lblStopbits.Size = new System.Drawing.Size(48, 13);
            this.lblStopbits.TabIndex = 13;
            this.lblStopbits.Text = "Stop bits";
            // 
            // cbStopbits
            // 
            this.cbStopbits.FormattingEnabled = true;
            this.cbStopbits.Location = new System.Drawing.Point(143, 16);
            this.cbStopbits.Name = "cbStopbits";
            this.cbStopbits.Size = new System.Drawing.Size(86, 21);
            this.cbStopbits.TabIndex = 12;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(58, 0);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(33, 13);
            this.lblParity.TabIndex = 11;
            this.lblParity.Text = "Parity";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(58, 16);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(79, 21);
            this.cbParity.TabIndex = 10;
            // 
            // lblDatabits
            // 
            this.lblDatabits.AutoSize = true;
            this.lblDatabits.Location = new System.Drawing.Point(3, 0);
            this.lblDatabits.Name = "lblDatabits";
            this.lblDatabits.Size = new System.Drawing.Size(49, 13);
            this.lblDatabits.TabIndex = 9;
            this.lblDatabits.Text = "Data bits";
            // 
            // cbDatabits
            // 
            this.cbDatabits.FormattingEnabled = true;
            this.cbDatabits.Location = new System.Drawing.Point(3, 16);
            this.cbDatabits.Name = "cbDatabits";
            this.cbDatabits.Size = new System.Drawing.Size(49, 21);
            this.cbDatabits.TabIndex = 8;
            // 
            // btnToggleAdvanced
            // 
            this.btnToggleAdvanced.BackgroundImage = global::SerialTerm.Properties.Resources.gear;
            this.btnToggleAdvanced.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnToggleAdvanced.Location = new System.Drawing.Point(272, 21);
            this.btnToggleAdvanced.Name = "btnToggleAdvanced";
            this.btnToggleAdvanced.Size = new System.Drawing.Size(28, 23);
            this.btnToggleAdvanced.TabIndex = 6;
            this.btnToggleAdvanced.UseVisualStyleBackColor = true;
            this.btnToggleAdvanced.Click += new System.EventHandler(this.btnToggleAdvanced_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::SerialTerm.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(10, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkPrependTimestamp);
            this.panel1.Controls.Add(this.ckClearOnOpen);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtOutput);
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 297);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.lblInput);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(12, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 27);
            this.panel2.TabIndex = 9;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(641, 264);
            this.txtOutput.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 273);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // ckClearOnOpen
            // 
            this.ckClearOnOpen.AutoSize = true;
            this.ckClearOnOpen.Location = new System.Drawing.Point(84, 277);
            this.ckClearOnOpen.Name = "ckClearOnOpen";
            this.ckClearOnOpen.Size = new System.Drawing.Size(107, 17);
            this.ckClearOnOpen.TabIndex = 2;
            this.ckClearOnOpen.Text = "Clear on connect";
            this.ckClearOnOpen.UseVisualStyleBackColor = true;
            // 
            // chkPrependTimestamp
            // 
            this.chkPrependTimestamp.AutoSize = true;
            this.chkPrependTimestamp.Location = new System.Drawing.Point(528, 279);
            this.chkPrependTimestamp.Name = "chkPrependTimestamp";
            this.chkPrependTimestamp.Size = new System.Drawing.Size(116, 17);
            this.chkPrependTimestamp.TabIndex = 3;
            this.chkPrependTimestamp.Text = "Prepend timestamp";
            this.chkPrependTimestamp.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(3, 6);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 10;
            this.lblInput.Text = "Input";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(544, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(101, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // fmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 382);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnAdvanced);
            this.Controls.Add(this.btnToggleAdvanced);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.lblBaudate);
            this.Controls.Add(this.cbBaudrate);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cbPorts);
            this.Name = "fmPrincipal";
            this.Text = "SerialTerm - Disconnected";
            this.pnAdvanced.ResumeLayout(false);
            this.pnAdvanced.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblBaudate;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnToggleAdvanced;
        private System.Windows.Forms.Panel pnAdvanced;
        private System.Windows.Forms.Label lblHandshaking;
        private System.Windows.Forms.ComboBox cbHandshake;
        private System.Windows.Forms.Label lblStopbits;
        private System.Windows.Forms.ComboBox cbStopbits;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label lblDatabits;
        private System.Windows.Forms.ComboBox cbDatabits;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ckClearOnOpen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.CheckBox chkPrependTimestamp;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

