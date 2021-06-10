namespace Traffic_Light
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
            this.status_lbl = new System.Windows.Forms.Label();
            this.connect_btn = new System.Windows.Forms.Button();
            this.stopbit_list = new System.Windows.Forms.ComboBox();
            this.StopBit = new System.Windows.Forms.Label();
            this.parity_list = new System.Windows.Forms.ComboBox();
            this.Parity = new System.Windows.Forms.Label();
            this.baudrate_list = new System.Windows.Forms.ComboBox();
            this.Baudrate = new System.Windows.Forms.Label();
            this.datasize_list = new System.Windows.Forms.ComboBox();
            this.DataSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.com_list = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.t_XA = new System.Windows.Forms.TextBox();
            this.t_VA = new System.Windows.Forms.TextBox();
            this.t_VB = new System.Windows.Forms.TextBox();
            this.t_XB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.set_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.XA = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.VA = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.DA = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.label6 = new System.Windows.Forms.Label();
            this.DB = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.VB = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.XB = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lbl.Location = new System.Drawing.Point(29, 249);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(41, 13);
            this.status_lbl.TabIndex = 23;
            this.status_lbl.Text = "label2";
            this.status_lbl.Visible = false;
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(140, 244);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 22;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // stopbit_list
            // 
            this.stopbit_list.FormattingEnabled = true;
            this.stopbit_list.Location = new System.Drawing.Point(94, 203);
            this.stopbit_list.Name = "stopbit_list";
            this.stopbit_list.Size = new System.Drawing.Size(121, 21);
            this.stopbit_list.TabIndex = 21;
            // 
            // StopBit
            // 
            this.StopBit.AutoSize = true;
            this.StopBit.Location = new System.Drawing.Point(29, 203);
            this.StopBit.Name = "StopBit";
            this.StopBit.Size = new System.Drawing.Size(41, 13);
            this.StopBit.TabIndex = 20;
            this.StopBit.Text = "StopBit";
            // 
            // parity_list
            // 
            this.parity_list.FormattingEnabled = true;
            this.parity_list.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.parity_list.Location = new System.Drawing.Point(94, 156);
            this.parity_list.Name = "parity_list";
            this.parity_list.Size = new System.Drawing.Size(121, 21);
            this.parity_list.TabIndex = 19;
            // 
            // Parity
            // 
            this.Parity.AutoSize = true;
            this.Parity.Location = new System.Drawing.Point(29, 159);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(33, 13);
            this.Parity.TabIndex = 18;
            this.Parity.Text = "Parity";
            // 
            // baudrate_list
            // 
            this.baudrate_list.FormattingEnabled = true;
            this.baudrate_list.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.baudrate_list.Location = new System.Drawing.Point(94, 70);
            this.baudrate_list.Name = "baudrate_list";
            this.baudrate_list.Size = new System.Drawing.Size(121, 21);
            this.baudrate_list.TabIndex = 17;
            // 
            // Baudrate
            // 
            this.Baudrate.AutoSize = true;
            this.Baudrate.Location = new System.Drawing.Point(29, 73);
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(50, 13);
            this.Baudrate.TabIndex = 16;
            this.Baudrate.Text = "Baudrate";
            // 
            // datasize_list
            // 
            this.datasize_list.FormattingEnabled = true;
            this.datasize_list.Items.AddRange(new object[] {
            "7",
            "8"});
            this.datasize_list.Location = new System.Drawing.Point(94, 112);
            this.datasize_list.Name = "datasize_list";
            this.datasize_list.Size = new System.Drawing.Size(121, 21);
            this.datasize_list.TabIndex = 15;
            // 
            // DataSize
            // 
            this.DataSize.AutoSize = true;
            this.DataSize.Location = new System.Drawing.Point(29, 115);
            this.DataSize.Name = "DataSize";
            this.DataSize.Size = new System.Drawing.Size(50, 13);
            this.DataSize.TabIndex = 14;
            this.DataSize.Text = "DataSize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "COM_Port";
            // 
            // com_list
            // 
            this.com_list.FormattingEnabled = true;
            this.com_list.Location = new System.Drawing.Point(94, 26);
            this.com_list.Name = "com_list";
            this.com_list.Size = new System.Drawing.Size(121, 21);
            this.com_list.TabIndex = 12;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // t_XA
            // 
            this.t_XA.Location = new System.Drawing.Point(61, 9);
            this.t_XA.Name = "t_XA";
            this.t_XA.Size = new System.Drawing.Size(120, 20);
            this.t_XA.TabIndex = 24;
            // 
            // t_VA
            // 
            this.t_VA.Location = new System.Drawing.Point(61, 35);
            this.t_VA.Name = "t_VA";
            this.t_VA.Size = new System.Drawing.Size(120, 20);
            this.t_VA.TabIndex = 25;
            // 
            // t_VB
            // 
            this.t_VB.Location = new System.Drawing.Point(62, 87);
            this.t_VB.Name = "t_VB";
            this.t_VB.Size = new System.Drawing.Size(120, 20);
            this.t_VB.TabIndex = 27;
            // 
            // t_XB
            // 
            this.t_XB.Location = new System.Drawing.Point(62, 61);
            this.t_XB.Name = "t_XB";
            this.t_XB.Size = new System.Drawing.Size(120, 20);
            this.t_XB.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "TXA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "TVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "TXB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "TVB";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // set_btn
            // 
            this.set_btn.Location = new System.Drawing.Point(16, 120);
            this.set_btn.Name = "set_btn";
            this.set_btn.Size = new System.Drawing.Size(165, 21);
            this.set_btn.TabIndex = 29;
            this.set_btn.Text = "SET";
            this.set_btn.UseVisualStyleBackColor = true;
            this.set_btn.Click += new System.EventHandler(this.set_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.set_btn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.t_VB);
            this.panel1.Controls.Add(this.t_XB);
            this.panel1.Controls.Add(this.t_VA);
            this.panel1.Controls.Add(this.t_XA);
            this.panel1.Location = new System.Drawing.Point(32, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 149);
            this.panel1.TabIndex = 30;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.XB,
            this.VB,
            this.DB,
            this.DA,
            this.VA,
            this.XA,
            this.rectangleShape1,
            this.rectangleShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 450);
            this.shapeContainer1.TabIndex = 31;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(386, 28);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(64, 195);
            // 
            // XA
            // 
            this.XA.BackColor = System.Drawing.SystemColors.Control;
            this.XA.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.XA.Location = new System.Drawing.Point(401, 40);
            this.XA.Name = "XA";
            this.XA.Size = new System.Drawing.Size(34, 34);
            // 
            // VA
            // 
            this.VA.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.VA.Location = new System.Drawing.Point(401, 83);
            this.VA.Name = "VA";
            this.VA.Size = new System.Drawing.Size(34, 34);
            // 
            // DA
            // 
            this.DA.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.DA.Location = new System.Drawing.Point(401, 127);
            this.DA.Name = "DA";
            this.DA.Size = new System.Drawing.Size(34, 34);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "00";
            // 
            // DB
            // 
            this.DB.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.DB.Location = new System.Drawing.Point(501, 128);
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(34, 34);
            // 
            // VB
            // 
            this.VB.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.VB.Location = new System.Drawing.Point(501, 84);
            this.VB.Name = "VB";
            this.VB.Size = new System.Drawing.Size(34, 34);
            // 
            // XB
            // 
            this.XB.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.XB.Location = new System.Drawing.Point(501, 41);
            this.XB.Name = "XB";
            this.XB.Size = new System.Drawing.Size(34, 34);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(486, 29);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(64, 195);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.stopbit_list);
            this.Controls.Add(this.StopBit);
            this.Controls.Add(this.parity_list);
            this.Controls.Add(this.Parity);
            this.Controls.Add(this.baudrate_list);
            this.Controls.Add(this.Baudrate);
            this.Controls.Add(this.datasize_list);
            this.Controls.Add(this.DataSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_list);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.ComboBox stopbit_list;
        private System.Windows.Forms.Label StopBit;
        private System.Windows.Forms.ComboBox parity_list;
        private System.Windows.Forms.Label Parity;
        private System.Windows.Forms.ComboBox baudrate_list;
        private System.Windows.Forms.Label Baudrate;
        private System.Windows.Forms.ComboBox datasize_list;
        private System.Windows.Forms.Label DataSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_list;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox t_XA;
        private System.Windows.Forms.TextBox t_VA;
        private System.Windows.Forms.TextBox t_VB;
        private System.Windows.Forms.TextBox t_XB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button set_btn;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape XA;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape XB;
        private Microsoft.VisualBasic.PowerPacks.OvalShape VB;
        private Microsoft.VisualBasic.PowerPacks.OvalShape DB;
        private Microsoft.VisualBasic.PowerPacks.OvalShape DA;
        private Microsoft.VisualBasic.PowerPacks.OvalShape VA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

