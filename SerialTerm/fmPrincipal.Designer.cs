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
            this.pnInput = new System.Windows.Forms.Panel();
            this.cbLineEnd = new System.Windows.Forms.ComboBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkClearOnOpen = new System.Windows.Forms.CheckBox();
            this.chkPrependTimestamp = new System.Windows.Forms.CheckBox();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.NumericUpDown();
            this.pnOutput = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.pnAdvanced.SuspendLayout();
            this.pnInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).BeginInit();
            this.pnOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(12, 24);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(74, 21);
            this.cbPorts.TabIndex = 0;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(9, 9);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(55, 13);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Serial Port";
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
            this.cbBaudrate.Size = new System.Drawing.Size(74, 21);
            this.cbBaudrate.TabIndex = 2;
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(195, 9);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(71, 36);
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
            this.pnAdvanced.Visible = false;
            // 
            // lblHandshaking
            // 
            this.lblHandshaking.AutoSize = true;
            this.lblHandshaking.Location = new System.Drawing.Point(221, -1);
            this.lblHandshaking.Name = "lblHandshaking";
            this.lblHandshaking.Size = new System.Drawing.Size(70, 13);
            this.lblHandshaking.TabIndex = 15;
            this.lblHandshaking.Text = "Handshaking";
            // 
            // cbHandshake
            // 
            this.cbHandshake.FormattingEnabled = true;
            this.cbHandshake.Location = new System.Drawing.Point(224, 15);
            this.cbHandshake.Name = "cbHandshake";
            this.cbHandshake.Size = new System.Drawing.Size(125, 21);
            this.cbHandshake.TabIndex = 14;
            // 
            // lblStopbits
            // 
            this.lblStopbits.AutoSize = true;
            this.lblStopbits.Location = new System.Drawing.Point(140, 0);
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
            this.cbStopbits.Size = new System.Drawing.Size(75, 21);
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
            this.btnToggleAdvanced.Location = new System.Drawing.Point(272, 9);
            this.btnToggleAdvanced.Name = "btnToggleAdvanced";
            this.btnToggleAdvanced.Size = new System.Drawing.Size(28, 35);
            this.btnToggleAdvanced.TabIndex = 6;
            this.btnToggleAdvanced.UseVisualStyleBackColor = true;
            this.btnToggleAdvanced.Click += new System.EventHandler(this.btnToggleAdvanced_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::SerialTerm.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(84, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnInput
            // 
            this.pnInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnInput.Controls.Add(this.cbLineEnd);
            this.pnInput.Controls.Add(this.lblInput);
            this.pnInput.Controls.Add(this.txtInput);
            this.pnInput.Enabled = false;
            this.pnInput.Location = new System.Drawing.Point(13, 339);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(648, 40);
            this.pnInput.TabIndex = 9;
            // 
            // cbLineEnd
            // 
            this.cbLineEnd.FormattingEnabled = true;
            this.cbLineEnd.Location = new System.Drawing.Point(524, 8);
            this.cbLineEnd.Name = "cbLineEnd";
            this.cbLineEnd.Size = new System.Drawing.Size(116, 21);
            this.cbLineEnd.TabIndex = 10;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(1, 12);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 10;
            this.lblInput.Text = "&Input";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(38, 9);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(480, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(4, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkClearOnOpen
            // 
            this.chkClearOnOpen.AutoSize = true;
            this.chkClearOnOpen.Location = new System.Drawing.Point(85, 254);
            this.chkClearOnOpen.Name = "chkClearOnOpen";
            this.chkClearOnOpen.Size = new System.Drawing.Size(107, 17);
            this.chkClearOnOpen.TabIndex = 2;
            this.chkClearOnOpen.Text = "Clear on connect";
            this.chkClearOnOpen.UseVisualStyleBackColor = true;
            // 
            // chkPrependTimestamp
            // 
            this.chkPrependTimestamp.AutoSize = true;
            this.chkPrependTimestamp.Location = new System.Drawing.Point(524, 256);
            this.chkPrependTimestamp.Name = "chkPrependTimestamp";
            this.chkPrependTimestamp.Size = new System.Drawing.Size(116, 17);
            this.chkPrependTimestamp.TabIndex = 3;
            this.chkPrependTimestamp.Text = "Prepend timestamp";
            this.chkPrependTimestamp.UseVisualStyleBackColor = true;
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(349, 255);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(67, 13);
            this.lblTimeout.TabIndex = 5;
            this.lblTimeout.Text = "Timeout (ms)";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtTimeout.Location = new System.Drawing.Point(418, 253);
            this.txtTimeout.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(100, 20);
            this.txtTimeout.TabIndex = 6;
            this.txtTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // pnOutput
            // 
            this.pnOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnOutput.Controls.Add(this.txtTimeout);
            this.pnOutput.Controls.Add(this.lblTimeout);
            this.pnOutput.Controls.Add(this.chkPrependTimestamp);
            this.pnOutput.Controls.Add(this.chkClearOnOpen);
            this.pnOutput.Controls.Add(this.btnClear);
            this.pnOutput.Controls.Add(this.txtOutput);
            this.pnOutput.Location = new System.Drawing.Point(13, 53);
            this.pnOutput.Name = "pnOutput";
            this.pnOutput.Size = new System.Drawing.Size(647, 280);
            this.pnOutput.TabIndex = 8;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Control;
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(637, 244);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Enter += new System.EventHandler(this.txtOutput_Enter);
            // 
            // fmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 382);
            this.Controls.Add(this.pnInput);
            this.Controls.Add(this.pnOutput);
            this.Controls.Add(this.pnAdvanced);
            this.Controls.Add(this.btnToggleAdvanced);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.lblBaudate);
            this.Controls.Add(this.cbBaudrate);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cbPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fmPrincipal";
            this.Text = "SerialTerm - Disconnected";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmPrincipal_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmPrincipal_KeyDown);
            this.pnAdvanced.ResumeLayout(false);
            this.pnAdvanced.PerformLayout();
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).EndInit();
            this.pnOutput.ResumeLayout(false);
            this.pnOutput.PerformLayout();
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
        private System.Windows.Forms.Panel pnInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cbLineEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkClearOnOpen;
        private System.Windows.Forms.CheckBox chkPrependTimestamp;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.NumericUpDown txtTimeout;
        private System.Windows.Forms.Panel pnOutput;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

