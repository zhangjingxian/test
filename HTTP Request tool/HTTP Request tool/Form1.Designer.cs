namespace HTTP_Request_tool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPostData = new System.Windows.Forms.Label();
            this.txtPostData = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboMode);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "URL设置";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(649, 24);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(60, 35);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "提交方式";
            // 
            // cboMode
            // 
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.cboMode.Location = new System.Drawing.Point(475, 33);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(80, 20);
            this.cboMode.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            ":80"});
            this.comboBox3.Location = new System.Drawing.Point(205, 32);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(74, 20);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "192.168.2.166"});
            this.comboBox2.Location = new System.Drawing.Point(92, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(107, 20);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "http://"});
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "主机名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "协议";
            // 
            // lblPostData
            // 
            this.lblPostData.AutoSize = true;
            this.lblPostData.Location = new System.Drawing.Point(3, 83);
            this.lblPostData.Name = "lblPostData";
            this.lblPostData.Size = new System.Drawing.Size(65, 12);
            this.lblPostData.TabIndex = 10;
            this.lblPostData.Text = "Post Data:";
            // 
            // txtPostData
            // 
            this.txtPostData.Location = new System.Drawing.Point(5, 115);
            this.txtPostData.Multiline = true;
            this.txtPostData.Name = "txtPostData";
            this.txtPostData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPostData.Size = new System.Drawing.Size(179, 229);
            this.txtPostData.TabIndex = 11;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(205, 80);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(559, 330);
            this.txtLog.TabIndex = 12;
            this.txtLog.WordWrap = false;
            // 
            // comboBox4
            // 
            this.comboBox4.AllowDrop = true;
            this.comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "/login",
            "/logout",
            "/",
            "/dashboard"});
            this.comboBox4.Location = new System.Drawing.Point(285, 32);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(184, 20);
            this.comboBox4.TabIndex = 11;
            this.comboBox4.Leave += new System.EventHandler(this.comboBox4_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtPostData);
            this.Controls.Add(this.lblPostData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "";//"http请求工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblPostData;
        private System.Windows.Forms.TextBox txtPostData;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

