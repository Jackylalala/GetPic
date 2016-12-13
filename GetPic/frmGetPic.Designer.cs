namespace GetPic
{
    partial class frmGetPic
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDst = new System.Windows.Forms.Button();
            this.txtDst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bgdWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDelJpg = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGifInterval = new System.Windows.Forms.TextBox();
            this.chkGifLoop = new System.Windows.Forms.CheckBox();
            this.chkGif = new System.Windows.Forms.CheckBox();
            this.cboPollutants = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.radPointMap = new System.Windows.Forms.RadioButton();
            this.radContourMap = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStart.Location = new System.Drawing.Point(29, 294);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(172, 43);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy年MM月dd日 HH:mm";
            this.dtpStart.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(122, 60);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(233, 25);
            this.dtpStart.TabIndex = 3;
            this.dtpStart.Value = new System.DateTime(2015, 1, 12, 0, 0, 0, 0);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy年MM月dd日 HH:mm";
            this.dtpEnd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(122, 96);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(233, 25);
            this.dtpEnd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(76, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(82, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "End:";
            // 
            // btnDst
            // 
            this.btnDst.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDst.Location = new System.Drawing.Point(341, 27);
            this.btnDst.Name = "btnDst";
            this.btnDst.Size = new System.Drawing.Size(36, 24);
            this.btnDst.TabIndex = 11;
            this.btnDst.Text = "...";
            this.btnDst.UseVisualStyleBackColor = true;
            this.btnDst.Click += new System.EventHandler(this.btnDst_Click);
            // 
            // txtDst
            // 
            this.txtDst.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDst.Location = new System.Drawing.Point(144, 27);
            this.txtDst.Name = "txtDst";
            this.txtDst.ReadOnly = true;
            this.txtDst.Size = new System.Drawing.Size(191, 25);
            this.txtDst.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(26, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destination path:";
            // 
            // bgdWorker
            // 
            this.bgdWorker.WorkerReportsProgress = true;
            this.bgdWorker.WorkerSupportsCancellation = true;
            this.bgdWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgdWorker_DoWork);
            this.bgdWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgdWorker_ProgressChanged);
            this.bgdWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgdWorker_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.tsslblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(428, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(29, 17);
            this.tsslblStatus.Text = "Idle";
            this.tsslblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(55, 20);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDelJpg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGifInterval);
            this.groupBox1.Controls.Add(this.chkGifLoop);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(29, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 82);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animated Gif Setting";
            // 
            // chkDelJpg
            // 
            this.chkDelJpg.AutoSize = true;
            this.chkDelJpg.Enabled = false;
            this.chkDelJpg.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkDelJpg.Location = new System.Drawing.Point(237, 42);
            this.chkDelJpg.Name = "chkDelJpg";
            this.chkDelJpg.Size = new System.Drawing.Size(114, 21);
            this.chkDelJpg.TabIndex = 22;
            this.chkDelJpg.Text = "Delete jpg files";
            this.chkDelJpg.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(194, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(26, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Interval:";
            // 
            // txtGifInterval
            // 
            this.txtGifInterval.Enabled = false;
            this.txtGifInterval.Location = new System.Drawing.Point(88, 29);
            this.txtGifInterval.MaxLength = 5;
            this.txtGifInterval.Name = "txtGifInterval";
            this.txtGifInterval.Size = new System.Drawing.Size(100, 25);
            this.txtGifInterval.TabIndex = 19;
            this.txtGifInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGifInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGifInterval_KeyPress);
            // 
            // chkGifLoop
            // 
            this.chkGifLoop.AutoSize = true;
            this.chkGifLoop.Enabled = false;
            this.chkGifLoop.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkGifLoop.Location = new System.Drawing.Point(237, 15);
            this.chkGifLoop.Name = "chkGifLoop";
            this.chkGifLoop.Size = new System.Drawing.Size(69, 21);
            this.chkGifLoop.TabIndex = 18;
            this.chkGifLoop.Text = "Repeat";
            this.chkGifLoop.UseVisualStyleBackColor = true;
            // 
            // chkGif
            // 
            this.chkGif.AutoSize = true;
            this.chkGif.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkGif.Location = new System.Drawing.Point(32, 177);
            this.chkGif.Name = "chkGif";
            this.chkGif.Size = new System.Drawing.Size(106, 21);
            this.chkGif.TabIndex = 17;
            this.chkGif.Text = "Animated Gif";
            this.chkGif.UseVisualStyleBackColor = true;
            this.chkGif.CheckedChanged += new System.EventHandler(this.chkGif_CheckedChanged);
            // 
            // cboPollutants
            // 
            this.cboPollutants.DisplayMember = "1";
            this.cboPollutants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPollutants.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboPollutants.FormattingEnabled = true;
            this.cboPollutants.Items.AddRange(new object[] {
            "SO2",
            "CO",
            "O3",
            "PM10",
            "PM2.5",
            "NO2"});
            this.cboPollutants.Location = new System.Drawing.Point(284, 175);
            this.cboPollutants.Name = "cboPollutants";
            this.cboPollutants.Size = new System.Drawing.Size(121, 25);
            this.cboPollutants.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(212, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Pollutant:";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.Location = new System.Drawing.Point(233, 294);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(172, 43);
            this.btnStop.TabIndex = 20;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // radPointMap
            // 
            this.radPointMap.AutoSize = true;
            this.radPointMap.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radPointMap.Location = new System.Drawing.Point(94, 136);
            this.radPointMap.Name = "radPointMap";
            this.radPointMap.Size = new System.Drawing.Size(89, 21);
            this.radPointMap.TabIndex = 21;
            this.radPointMap.TabStop = true;
            this.radPointMap.Text = "Point Map";
            this.radPointMap.UseVisualStyleBackColor = true;
            // 
            // radContourMap
            // 
            this.radContourMap.AutoSize = true;
            this.radContourMap.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radContourMap.Location = new System.Drawing.Point(226, 136);
            this.radContourMap.Name = "radContourMap";
            this.radContourMap.Size = new System.Drawing.Size(108, 21);
            this.radContourMap.TabIndex = 22;
            this.radContourMap.TabStop = true;
            this.radContourMap.Text = "Contour Map";
            this.radContourMap.UseVisualStyleBackColor = true;
            // 
            // frmGetPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 404);
            this.Controls.Add(this.radContourMap);
            this.Controls.Add(this.radPointMap);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboPollutants);
            this.Controls.Add(this.chkGif);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDst);
            this.Controls.Add(this.txtDst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmGetPic";
            this.Text = "GetPic";
            this.Load += new System.EventHandler(this.frmGetPic_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDst;
        private System.Windows.Forms.TextBox txtDst;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker bgdWorker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGifInterval;
        private System.Windows.Forms.CheckBox chkGifLoop;
        private System.Windows.Forms.CheckBox chkGif;
        private System.Windows.Forms.ComboBox cboPollutants;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chkDelJpg;
        private System.Windows.Forms.RadioButton radPointMap;
        private System.Windows.Forms.RadioButton radContourMap;
    }
}

