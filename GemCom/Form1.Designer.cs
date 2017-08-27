namespace GemCom
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Button_Transmit_Data = new System.Windows.Forms.Button();
            this.Button_Receive_Data = new System.Windows.Forms.Button();
            this.ComboBox_Standard_Baudrates = new System.Windows.Forms.ComboBox();
            this.ComboBox_Available_SerialPorts = new System.Windows.Forms.ComboBox();
            this.Label_Available_Ports = new System.Windows.Forms.Label();
            this.Label_Baudrate = new System.Windows.Forms.Label();
            this.RichTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.GroupBox_Serial_Transmit = new System.Windows.Forms.GroupBox();
            this.GroupBox_SeriaL_Receive = new System.Windows.Forms.GroupBox();
            this.GroupBox_Serial_Settings = new System.Windows.Forms.GroupBox();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.Button_Disconnect = new System.Windows.Forms.Button();
            this.Label_COM_Status = new System.Windows.Forms.Label();
            this.GroupBox_Commands = new System.Windows.Forms.GroupBox();
            this.COMport = new System.IO.Ports.SerialPort(this.components);
            this.GroupBox_Serial_Transmit.SuspendLayout();
            this.GroupBox_SeriaL_Receive.SuspendLayout();
            this.GroupBox_Serial_Settings.SuspendLayout();
            this.GroupBox_Commands.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Transmit_Data
            // 
            this.Button_Transmit_Data.Location = new System.Drawing.Point(43, 30);
            this.Button_Transmit_Data.Name = "Button_Transmit_Data";
            this.Button_Transmit_Data.Size = new System.Drawing.Size(105, 31);
            this.Button_Transmit_Data.TabIndex = 0;
            this.Button_Transmit_Data.Text = "Transmit";
            this.Button_Transmit_Data.UseVisualStyleBackColor = true;
            this.Button_Transmit_Data.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button_Receive_Data
            // 
            this.Button_Receive_Data.Location = new System.Drawing.Point(56, 30);
            this.Button_Receive_Data.Name = "Button_Receive_Data";
            this.Button_Receive_Data.Size = new System.Drawing.Size(105, 30);
            this.Button_Receive_Data.TabIndex = 1;
            this.Button_Receive_Data.Text = "Receive";
            this.Button_Receive_Data.UseVisualStyleBackColor = true;
            // 
            // ComboBox_Standard_Baudrates
            // 
            this.ComboBox_Standard_Baudrates.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.ComboBox_Standard_Baudrates.FormattingEnabled = true;
            this.ComboBox_Standard_Baudrates.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.ComboBox_Standard_Baudrates.Location = new System.Drawing.Point(83, 25);
            this.ComboBox_Standard_Baudrates.Name = "ComboBox_Standard_Baudrates";
            this.ComboBox_Standard_Baudrates.Size = new System.Drawing.Size(136, 21);
            this.ComboBox_Standard_Baudrates.TabIndex = 2;
            this.ComboBox_Standard_Baudrates.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Standard_Baudrates_SelectionChangeCommitted);
            // 
            // ComboBox_Available_SerialPorts
            // 
            this.ComboBox_Available_SerialPorts.FormattingEnabled = true;
            this.ComboBox_Available_SerialPorts.Location = new System.Drawing.Point(336, 25);
            this.ComboBox_Available_SerialPorts.Name = "ComboBox_Available_SerialPorts";
            this.ComboBox_Available_SerialPorts.Size = new System.Drawing.Size(157, 21);
            this.ComboBox_Available_SerialPorts.TabIndex = 4;
            this.ComboBox_Available_SerialPorts.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Available_SerialPorts_SelectionChangeCommitted);
            // 
            // Label_Available_Ports
            // 
            this.Label_Available_Ports.AutoSize = true;
            this.Label_Available_Ports.Location = new System.Drawing.Point(253, 28);
            this.Label_Available_Ports.Name = "Label_Available_Ports";
            this.Label_Available_Ports.Size = new System.Drawing.Size(77, 13);
            this.Label_Available_Ports.TabIndex = 5;
            this.Label_Available_Ports.Text = "Available Ports";
            // 
            // Label_Baudrate
            // 
            this.Label_Baudrate.AutoSize = true;
            this.Label_Baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Baudrate.Location = new System.Drawing.Point(27, 28);
            this.Label_Baudrate.Name = "Label_Baudrate";
            this.Label_Baudrate.Size = new System.Drawing.Size(50, 13);
            this.Label_Baudrate.TabIndex = 6;
            this.Label_Baudrate.Text = "Baudrate";
            // 
            // RichTextBox_Log
            // 
            this.RichTextBox_Log.Location = new System.Drawing.Point(47, 265);
            this.RichTextBox_Log.Name = "RichTextBox_Log";
            this.RichTextBox_Log.Size = new System.Drawing.Size(540, 223);
            this.RichTextBox_Log.TabIndex = 8;
            this.RichTextBox_Log.Text = "";
            // 
            // GroupBox_Serial_Transmit
            // 
            this.GroupBox_Serial_Transmit.Controls.Add(this.Button_Transmit_Data);
            this.GroupBox_Serial_Transmit.Location = new System.Drawing.Point(47, 83);
            this.GroupBox_Serial_Transmit.Name = "GroupBox_Serial_Transmit";
            this.GroupBox_Serial_Transmit.Size = new System.Drawing.Size(188, 176);
            this.GroupBox_Serial_Transmit.TabIndex = 9;
            this.GroupBox_Serial_Transmit.TabStop = false;
            this.GroupBox_Serial_Transmit.Text = "Serial Transmit";
            this.GroupBox_Serial_Transmit.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GroupBox_SeriaL_Receive
            // 
            this.GroupBox_SeriaL_Receive.Controls.Add(this.Button_Receive_Data);
            this.GroupBox_SeriaL_Receive.Location = new System.Drawing.Point(383, 83);
            this.GroupBox_SeriaL_Receive.Name = "GroupBox_SeriaL_Receive";
            this.GroupBox_SeriaL_Receive.Size = new System.Drawing.Size(204, 176);
            this.GroupBox_SeriaL_Receive.TabIndex = 10;
            this.GroupBox_SeriaL_Receive.TabStop = false;
            this.GroupBox_SeriaL_Receive.Text = "Serial Receive";
            // 
            // GroupBox_Serial_Settings
            // 
            this.GroupBox_Serial_Settings.Controls.Add(this.ComboBox_Available_SerialPorts);
            this.GroupBox_Serial_Settings.Controls.Add(this.Label_Baudrate);
            this.GroupBox_Serial_Settings.Controls.Add(this.ComboBox_Standard_Baudrates);
            this.GroupBox_Serial_Settings.Controls.Add(this.Label_Available_Ports);
            this.GroupBox_Serial_Settings.Location = new System.Drawing.Point(47, 13);
            this.GroupBox_Serial_Settings.Name = "GroupBox_Serial_Settings";
            this.GroupBox_Serial_Settings.Size = new System.Drawing.Size(540, 64);
            this.GroupBox_Serial_Settings.TabIndex = 11;
            this.GroupBox_Serial_Settings.TabStop = false;
            this.GroupBox_Serial_Settings.Text = "Serial Settings";
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(25, 77);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(90, 27);
            this.Button_Connect.TabIndex = 12;
            this.Button_Connect.Text = "Connect";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // Button_Disconnect
            // 
            this.Button_Disconnect.Location = new System.Drawing.Point(25, 110);
            this.Button_Disconnect.Name = "Button_Disconnect";
            this.Button_Disconnect.Size = new System.Drawing.Size(90, 27);
            this.Button_Disconnect.TabIndex = 13;
            this.Button_Disconnect.Text = "Disconnect";
            this.Button_Disconnect.UseVisualStyleBackColor = true;
            this.Button_Disconnect.Click += new System.EventHandler(this.Button_Disconnect_Click);
            // 
            // Label_COM_Status
            // 
            this.Label_COM_Status.AutoSize = true;
            this.Label_COM_Status.Location = new System.Drawing.Point(53, 45);
            this.Label_COM_Status.Name = "Label_COM_Status";
            this.Label_COM_Status.Size = new System.Drawing.Size(35, 13);
            this.Label_COM_Status.TabIndex = 14;
            this.Label_COM_Status.Text = "label1";
            this.Label_COM_Status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GroupBox_Commands
            // 
            this.GroupBox_Commands.Controls.Add(this.Label_COM_Status);
            this.GroupBox_Commands.Controls.Add(this.Button_Connect);
            this.GroupBox_Commands.Controls.Add(this.Button_Disconnect);
            this.GroupBox_Commands.Location = new System.Drawing.Point(242, 83);
            this.GroupBox_Commands.Name = "GroupBox_Commands";
            this.GroupBox_Commands.Size = new System.Drawing.Size(135, 176);
            this.GroupBox_Commands.TabIndex = 15;
            this.GroupBox_Commands.TabStop = false;
            this.GroupBox_Commands.Text = "Commands";
            // 
            // COMport
            // 
            this.COMport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.COMport_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 525);
            this.Controls.Add(this.GroupBox_Commands);
            this.Controls.Add(this.GroupBox_SeriaL_Receive);
            this.Controls.Add(this.GroupBox_Serial_Transmit);
            this.Controls.Add(this.RichTextBox_Log);
            this.Controls.Add(this.GroupBox_Serial_Settings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_Serial_Transmit.ResumeLayout(false);
            this.GroupBox_SeriaL_Receive.ResumeLayout(false);
            this.GroupBox_Serial_Settings.ResumeLayout(false);
            this.GroupBox_Serial_Settings.PerformLayout();
            this.GroupBox_Commands.ResumeLayout(false);
            this.GroupBox_Commands.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Transmit_Data;
        private System.Windows.Forms.Button Button_Receive_Data;
        private System.Windows.Forms.ComboBox ComboBox_Standard_Baudrates;
        private System.Windows.Forms.ComboBox ComboBox_Available_SerialPorts;
        private System.Windows.Forms.Label Label_Available_Ports;
        private System.Windows.Forms.Label Label_Baudrate;
        private System.Windows.Forms.RichTextBox RichTextBox_Log;
        private System.Windows.Forms.GroupBox GroupBox_Serial_Transmit;
        private System.Windows.Forms.GroupBox GroupBox_SeriaL_Receive;
        private System.Windows.Forms.GroupBox GroupBox_Serial_Settings;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.Button Button_Disconnect;
        private System.Windows.Forms.Label Label_COM_Status;
        private System.Windows.Forms.GroupBox GroupBox_Commands;
        private System.IO.Ports.SerialPort COMport;
    }
}

