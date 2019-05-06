namespace smcs.frontend.frm
{
    partial class frmTerminateMission
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxtNtioSearch = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPickUntil = new System.Windows.Forms.Label();
            this.dPickUntil = new System.Windows.Forms.DateTimePicker();
            this.AbsNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.offDayNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAgntName = new System.Windows.Forms.Label();
            this.lblRecpDate = new System.Windows.Forms.Label();
            this.lblOffc = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.chkGenRpt = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offDayNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.offDayNum);
            this.groupBox1.Controls.Add(this.AbsNum);
            this.groupBox1.Controls.Add(this.lblPickUntil);
            this.groupBox1.Controls.Add(this.dPickUntil);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mtxtNtioSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkGenRpt);
            this.groupBox2.Controls.Add(this.btnApply);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblOffc);
            this.groupBox2.Controls.Add(this.lblRecpDate);
            this.groupBox2.Controls.Add(this.lblAgntName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 192);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // mtxtNtioSearch
            // 
            this.mtxtNtioSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtNtioSearch.Location = new System.Drawing.Point(11, 30);
            this.mtxtNtioSearch.Mask = "000-000-0000";
            this.mtxtNtioSearch.Name = "mtxtNtioSearch";
            this.mtxtNtioSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtNtioSearch.Size = new System.Drawing.Size(227, 34);
            this.mtxtNtioSearch.TabIndex = 0;
            this.mtxtNtioSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtNtioSearch.TextChanged += new System.EventHandler(this.mtxtNtioSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Samim", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "حضوردریگان:";
            // 
            // lblPickUntil
            // 
            this.lblPickUntil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPickUntil.AutoSize = true;
            this.lblPickUntil.Enabled = false;
            this.lblPickUntil.Location = new System.Drawing.Point(244, 33);
            this.lblPickUntil.Name = "lblPickUntil";
            this.lblPickUntil.Size = new System.Drawing.Size(66, 26);
            this.lblPickUntil.TabIndex = 23;
            this.lblPickUntil.Text = "کد ملی:";
            // 
            // dPickUntil
            // 
            this.dPickUntil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dPickUntil.Enabled = false;
            this.dPickUntil.Location = new System.Drawing.Point(12, 128);
            this.dPickUntil.Name = "dPickUntil";
            this.dPickUntil.Size = new System.Drawing.Size(227, 34);
            this.dPickUntil.TabIndex = 1;
            // 
            // AbsNum
            // 
            this.AbsNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AbsNum.Location = new System.Drawing.Point(12, 79);
            this.AbsNum.Name = "AbsNum";
            this.AbsNum.Size = new System.Drawing.Size(51, 34);
            this.AbsNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "تعداد مرخصی:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "تعداد نهست:";
            // 
            // offDayNum
            // 
            this.offDayNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.offDayNum.Location = new System.Drawing.Point(186, 79);
            this.offDayNum.Name = "offDayNum";
            this.offDayNum.Size = new System.Drawing.Size(51, 34);
            this.offDayNum.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(265, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "نام مامور:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(239, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "تاریخ پذیرش:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(277, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "قسمت:";
            // 
            // lblAgntName
            // 
            this.lblAgntName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgntName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAgntName.Enabled = false;
            this.lblAgntName.Location = new System.Drawing.Point(11, 31);
            this.lblAgntName.Name = "lblAgntName";
            this.lblAgntName.Size = new System.Drawing.Size(227, 26);
            this.lblAgntName.TabIndex = 23;
            this.lblAgntName.Text = "-";
            this.lblAgntName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecpDate
            // 
            this.lblRecpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecpDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecpDate.Enabled = false;
            this.lblRecpDate.Location = new System.Drawing.Point(11, 64);
            this.lblRecpDate.Name = "lblRecpDate";
            this.lblRecpDate.Size = new System.Drawing.Size(227, 26);
            this.lblRecpDate.TabIndex = 23;
            this.lblRecpDate.Text = "-";
            this.lblRecpDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOffc
            // 
            this.lblOffc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOffc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOffc.Enabled = false;
            this.lblOffc.Location = new System.Drawing.Point(11, 96);
            this.lblOffc.Name = "lblOffc";
            this.lblOffc.Size = new System.Drawing.Size(227, 26);
            this.lblOffc.TabIndex = 23;
            this.lblOffc.Text = "-";
            this.lblOffc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApply.Location = new System.Drawing.Point(11, 133);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(106, 48);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "اعمال";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chkGenRpt
            // 
            this.chkGenRpt.AutoSize = true;
            this.chkGenRpt.Checked = true;
            this.chkGenRpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenRpt.Font = new System.Drawing.Font("Samim", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGenRpt.Location = new System.Drawing.Point(259, 149);
            this.chkGenRpt.Name = "chkGenRpt";
            this.chkGenRpt.Size = new System.Drawing.Size(79, 21);
            this.chkGenRpt.TabIndex = 2;
            this.chkGenRpt.Text = "ایجاد گزارش";
            this.chkGenRpt.UseVisualStyleBackColor = true;
            // 
            // frmTerminateMission
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Samim", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmTerminateMission";
            this.Text = "پایان";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offDayNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtxtNtioSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AbsNum;
        private System.Windows.Forms.Label lblPickUntil;
        private System.Windows.Forms.DateTimePicker dPickUntil;
        private System.Windows.Forms.NumericUpDown offDayNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOffc;
        private System.Windows.Forms.Label lblRecpDate;
        private System.Windows.Forms.Label lblAgntName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox chkGenRpt;
    }
}