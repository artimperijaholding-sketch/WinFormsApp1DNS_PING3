namespace WinFormsApp1DNS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGetIp = new Button();
            textBoxIpAddress = new TextBox();
            textBoxHostName = new TextBox();
            listBoxAddresses = new ListBox();
            buttonGetHost = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelHostName = new Label();
            buttonPing = new Button();
            button1 = new Button();
            buttonGet = new Button();
            textBoxOutput = new TextBox();
            buttonPing3 = new Button();
            textBoxPing = new TextBox();
            SuspendLayout();
            // 
            // buttonGetIp
            // 
            buttonGetIp.Location = new Point(110, 10);
            buttonGetIp.Name = "buttonGetIp";
            buttonGetIp.Size = new Size(75, 23);
            buttonGetIp.TabIndex = 0;
            buttonGetIp.Text = "Get Ip";
            buttonGetIp.UseVisualStyleBackColor = true;
            buttonGetIp.Click += buttonGetIp_Click;
            // 
            // textBoxIpAddress
            // 
            textBoxIpAddress.Location = new Point(27, 294);
            textBoxIpAddress.Name = "textBoxIpAddress";
            textBoxIpAddress.Size = new Size(158, 23);
            textBoxIpAddress.TabIndex = 1;
            // 
            // textBoxHostName
            // 
            textBoxHostName.Location = new Point(27, 35);
            textBoxHostName.Name = "textBoxHostName";
            textBoxHostName.Size = new Size(158, 23);
            textBoxHostName.TabIndex = 2;
            // 
            // listBoxAddresses
            // 
            listBoxAddresses.FormattingEnabled = true;
            listBoxAddresses.Location = new Point(27, 91);
            listBoxAddresses.Name = "listBoxAddresses";
            listBoxAddresses.Size = new Size(158, 169);
            listBoxAddresses.TabIndex = 3;
            // 
            // buttonGetHost
            // 
            buttonGetHost.Location = new Point(28, 323);
            buttonGetHost.Name = "buttonGetHost";
            buttonGetHost.Size = new Size(75, 23);
            buttonGetHost.TabIndex = 4;
            buttonGetHost.Text = "Get Host";
            buttonGetHost.UseVisualStyleBackColor = true;
            buttonGetHost.Click += buttonGetHost_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 14);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "Host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 73);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 6;
            label2.Text = "IP Addresses";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 276);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 7;
            label3.Text = "IP";
            // 
            // labelHostName
            // 
            labelHostName.AutoSize = true;
            labelHostName.Location = new Point(147, 327);
            labelHostName.Name = "labelHostName";
            labelHostName.Size = new Size(38, 15);
            labelHostName.TabIndex = 8;
            labelHostName.Text = "label4";
            // 
            // buttonPing
            // 
            buttonPing.Location = new Point(539, 268);
            buttonPing.Name = "buttonPing";
            buttonPing.Size = new Size(75, 23);
            buttonPing.TabIndex = 9;
            buttonPing.Text = "Ping host with steps";
            buttonPing.UseVisualStyleBackColor = true;
            buttonPing.Click += buttonPing_Click;
            // 
            // button1
            // 
            button1.Location = new Point(483, 10);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 10;
            button1.Text = "Sites Universitet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonGet
            // 
            buttonGet.Location = new Point(539, 175);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(75, 23);
            buttonGet.TabIndex = 11;
            buttonGet.Text = "GET";
            buttonGet.UseVisualStyleBackColor = true;
            buttonGet.Click += buttonGet_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(207, 176);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(298, 124);
            textBoxOutput.TabIndex = 12;
            // 
            // buttonPing3
            // 
            buttonPing3.Location = new Point(207, 14);
            buttonPing3.Name = "buttonPing3";
            buttonPing3.Size = new Size(75, 23);
            buttonPing3.TabIndex = 13;
            buttonPing3.Text = "Ping 3";
            buttonPing3.UseVisualStyleBackColor = true;
            buttonPing3.Click += buttonPing3_Click;
            // 
            // textBoxPing
            // 
            textBoxPing.Location = new Point(207, 43);
            textBoxPing.Multiline = true;
            textBoxPing.Name = "textBoxPing";
            textBoxPing.ScrollBars = ScrollBars.Vertical;
            textBoxPing.Size = new Size(310, 126);
            textBoxPing.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 355);
            Controls.Add(textBoxPing);
            Controls.Add(buttonPing3);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonGet);
            Controls.Add(button1);
            Controls.Add(buttonPing);
            Controls.Add(labelHostName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonGetHost);
            Controls.Add(listBoxAddresses);
            Controls.Add(textBoxHostName);
            Controls.Add(textBoxIpAddress);
            Controls.Add(buttonGetIp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGetIp;
        private TextBox textBoxIpAddress;
        private TextBox textBoxHostName;
        private ListBox listBoxAddresses;
        private Button buttonGetHost;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelHostName;
        private Button buttonPing;
        private Button button1;
        private Button buttonGet;
        private TextBox textBoxOutput;
        private Button buttonPing3;
        private TextBox textBoxPing;
    }
}
