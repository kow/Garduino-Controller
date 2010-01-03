namespace PCComm
{
    partial class frmMain
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
            this.cmdClose = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.temperature = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.light = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.moisturedisplay1 = new System.Windows.Forms.Label();
            this.temperaturelong = new ZedGraph.ZedGraphControl();
            this.temperatureshort = new ZedGraph.ZedGraphControl();
            this.moisturelong1 = new ZedGraph.ZedGraphControl();
            this.lightlong = new ZedGraph.ZedGraphControl();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.moistureshort1 = new ZedGraph.ZedGraphControl();
            this.lightshort = new ZedGraph.ZedGraphControl();
            this.moisturedisplay2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moisturedisplay3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(1087, 6);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(100, 23);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "Close Port";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cmdSend);
            this.GroupBox1.Controls.Add(this.txtSend);
            this.GroupBox1.Controls.Add(this.rtbDisplay);
            this.GroupBox1.Location = new System.Drawing.Point(338, 686);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(330, 111);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Serial Port Debug";
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(246, 81);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(75, 22);
            this.cmdSend.TabIndex = 5;
            this.cmdSend.Text = "Send";
            this.cmdSend.UseVisualStyleBackColor = true;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(6, 83);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(234, 20);
            this.txtSend.TabIndex = 4;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(7, 19);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(315, 58);
            this.rtbDisplay.TabIndex = 3;
            this.rtbDisplay.Text = "";
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(981, 6);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(100, 23);
            this.cmdOpen.TabIndex = 8;
            this.cmdOpen.Text = "Open Port";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.Location = new System.Drawing.Point(179, 6);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(44, 31);
            this.temperature.TabIndex = 9;
            this.temperature.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Temperature:";
            // 
            // light
            // 
            this.light.AutoSize = true;
            this.light.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.light.Location = new System.Drawing.Point(82, 201);
            this.light.Name = "light";
            this.light.Size = new System.Drawing.Size(44, 31);
            this.light.TabIndex = 11;
            this.light.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 31);
            this.label8.TabIndex = 12;
            this.label8.Text = "Light:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(6, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 30);
            this.label9.TabIndex = 13;
            this.label9.Text = "Moisture 1:";
            // 
            // moisturedisplay1
            // 
            this.moisturedisplay1.AutoSize = true;
            this.moisturedisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moisturedisplay1.Location = new System.Drawing.Point(150, 396);
            this.moisturedisplay1.Name = "moisturedisplay1";
            this.moisturedisplay1.Size = new System.Drawing.Size(44, 31);
            this.moisturedisplay1.TabIndex = 14;
            this.moisturedisplay1.Text = "00";
            // 
            // temperaturelong
            // 
            this.temperaturelong.Location = new System.Drawing.Point(12, 40);
            this.temperaturelong.Name = "temperaturelong";
            this.temperaturelong.ScrollGrace = 0D;
            this.temperaturelong.ScrollMaxX = 0D;
            this.temperaturelong.ScrollMaxY = 0D;
            this.temperaturelong.ScrollMaxY2 = 0D;
            this.temperaturelong.ScrollMinX = 0D;
            this.temperaturelong.ScrollMinY = 0D;
            this.temperaturelong.ScrollMinY2 = 0D;
            this.temperaturelong.Size = new System.Drawing.Size(850, 158);
            this.temperaturelong.TabIndex = 15;
            // 
            // temperatureshort
            // 
            this.temperatureshort.Location = new System.Drawing.Point(868, 40);
            this.temperatureshort.Name = "temperatureshort";
            this.temperatureshort.ScrollGrace = 0D;
            this.temperatureshort.ScrollMaxX = 0D;
            this.temperatureshort.ScrollMaxY = 0D;
            this.temperatureshort.ScrollMaxY2 = 0D;
            this.temperatureshort.ScrollMinX = 0D;
            this.temperatureshort.ScrollMinY = 0D;
            this.temperatureshort.ScrollMinY2 = 0D;
            this.temperatureshort.Size = new System.Drawing.Size(319, 158);
            this.temperatureshort.TabIndex = 16;
            // 
            // moisturelong1
            // 
            this.moisturelong1.Location = new System.Drawing.Point(6, 430);
            this.moisturelong1.Name = "moisturelong1";
            this.moisturelong1.ScrollGrace = 0D;
            this.moisturelong1.ScrollMaxX = 0D;
            this.moisturelong1.ScrollMaxY = 0D;
            this.moisturelong1.ScrollMaxY2 = 0D;
            this.moisturelong1.ScrollMinX = 0D;
            this.moisturelong1.ScrollMinY = 0D;
            this.moisturelong1.ScrollMinY2 = 0D;
            this.moisturelong1.Size = new System.Drawing.Size(849, 163);
            this.moisturelong1.TabIndex = 17;
            // 
            // lightlong
            // 
            this.lightlong.Location = new System.Drawing.Point(11, 235);
            this.lightlong.Name = "lightlong";
            this.lightlong.ScrollGrace = 0D;
            this.lightlong.ScrollMaxX = 0D;
            this.lightlong.ScrollMaxY = 0D;
            this.lightlong.ScrollMaxY2 = 0D;
            this.lightlong.ScrollMinX = 0D;
            this.lightlong.ScrollMinY = 0D;
            this.lightlong.ScrollMinY2 = 0D;
            this.lightlong.Size = new System.Drawing.Size(850, 160);
            this.lightlong.TabIndex = 18;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(224, 689);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(26, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Port";
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(256, 686);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(76, 21);
            this.cboPort.TabIndex = 19;
            // 
            // moistureshort1
            // 
            this.moistureshort1.Location = new System.Drawing.Point(863, 430);
            this.moistureshort1.Name = "moistureshort1";
            this.moistureshort1.ScrollGrace = 0D;
            this.moistureshort1.ScrollMaxX = 0D;
            this.moistureshort1.ScrollMaxY = 0D;
            this.moistureshort1.ScrollMaxY2 = 0D;
            this.moistureshort1.ScrollMinX = 0D;
            this.moistureshort1.ScrollMinY = 0D;
            this.moistureshort1.ScrollMinY2 = 0D;
            this.moistureshort1.Size = new System.Drawing.Size(319, 163);
            this.moistureshort1.TabIndex = 24;
            // 
            // lightshort
            // 
            this.lightshort.Location = new System.Drawing.Point(868, 235);
            this.lightshort.Name = "lightshort";
            this.lightshort.ScrollGrace = 0D;
            this.lightshort.ScrollMaxX = 0D;
            this.lightshort.ScrollMaxY = 0D;
            this.lightshort.ScrollMaxY2 = 0D;
            this.lightshort.ScrollMinX = 0D;
            this.lightshort.ScrollMinY = 0D;
            this.lightshort.ScrollMinY2 = 0D;
            this.lightshort.Size = new System.Drawing.Size(319, 160);
            this.lightshort.TabIndex = 25;
            // 
            // moisturedisplay2
            // 
            this.moisturedisplay2.AutoSize = true;
            this.moisturedisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moisturedisplay2.Location = new System.Drawing.Point(389, 397);
            this.moisturedisplay2.Name = "moisturedisplay2";
            this.moisturedisplay2.Size = new System.Drawing.Size(44, 31);
            this.moisturedisplay2.TabIndex = 27;
            this.moisturedisplay2.Text = "00";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(247, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Moisture 2:";
            // 
            // moisturedisplay3
            // 
            this.moisturedisplay3.AutoSize = true;
            this.moisturedisplay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moisturedisplay3.Location = new System.Drawing.Point(645, 399);
            this.moisturedisplay3.Name = "moisturedisplay3";
            this.moisturedisplay3.Size = new System.Drawing.Size(44, 31);
            this.moisturedisplay3.TabIndex = 31;
            this.moisturedisplay3.Text = "00";
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(505, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Moisture 3:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 649);
            this.Controls.Add(this.moisturedisplay3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.moisturedisplay2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lightshort);
            this.Controls.Add(this.moistureshort1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.lightlong);
            this.Controls.Add(this.moisturelong1);
            this.Controls.Add(this.temperatureshort);
            this.Controls.Add(this.temperaturelong);
            this.Controls.Add(this.moisturedisplay1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.light);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.cmdOpen);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garduino Controller";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label light;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label moisturedisplay1;
        private ZedGraph.ZedGraphControl temperaturelong;
        private ZedGraph.ZedGraphControl temperatureshort;
        private ZedGraph.ZedGraphControl moisturelong1;
        private ZedGraph.ZedGraphControl lightlong;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox cboPort;
        private ZedGraph.ZedGraphControl moistureshort1;
        private ZedGraph.ZedGraphControl lightshort;
        private System.Windows.Forms.Label moisturedisplay2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label moisturedisplay3;
        private System.Windows.Forms.Label label5;
    }
}