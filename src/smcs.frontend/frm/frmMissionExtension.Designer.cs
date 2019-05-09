namespace smcs.frontend.frm
{
    partial class frmMissionExtension
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPickUntil = new System.Windows.Forms.Label();
            this.btnSelAllNotExt = new System.Windows.Forms.Button();
            this.lblLastExtDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNotExtendedCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dPickUntil = new System.Windows.Forms.DateTimePicker();
            this.btnSelAgOrOfc = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.rbtnWholeOffice = new System.Windows.Forms.RadioButton();
            this.rbtnSingleAgent = new System.Windows.Forms.RadioButton();
            this.lblAgentCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstMarkedAgnts = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkGenRpt = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.cmuWholeForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tspRemAgnt = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cmuWholeForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPickUntil);
            this.groupBox2.Controls.Add(this.btnSelAllNotExt);
            this.groupBox2.Controls.Add(this.lblLastExtDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblNotExtendedCount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dPickUntil);
            this.groupBox2.Controls.Add(this.btnSelAgOrOfc);
            this.groupBox2.Controls.Add(this.cmbSearch);
            this.groupBox2.Controls.Add(this.rbtnWholeOffice);
            this.groupBox2.Controls.Add(this.rbtnSingleAgent);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(277, 428);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملیات";
            // 
            // lblPickUntil
            // 
            this.lblPickUntil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPickUntil.AutoSize = true;
            this.lblPickUntil.Location = new System.Drawing.Point(62, 29);
            this.lblPickUntil.Name = "lblPickUntil";
            this.lblPickUntil.Size = new System.Drawing.Size(206, 26);
            this.lblPickUntil.TabIndex = 6;
            this.lblPickUntil.Text = "تا تاریخ: (آخرین تاریخ موجه)";
            // 
            // btnSelAllNotExt
            // 
            this.btnSelAllNotExt.Location = new System.Drawing.Point(7, 234);
            this.btnSelAllNotExt.Name = "btnSelAllNotExt";
            this.btnSelAllNotExt.Size = new System.Drawing.Size(256, 48);
            this.btnSelAllNotExt.TabIndex = 17;
            this.btnSelAllNotExt.Text = "انتخاب‌نفرات‌تمدید‌نشده‌تا‌این‌تاریخ";
            this.btnSelAllNotExt.UseVisualStyleBackColor = true;
            this.btnSelAllNotExt.Click += new System.EventHandler(this.btnSelAllNotExt_Click);
            // 
            // lblLastExtDate
            // 
            this.lblLastExtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastExtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastExtDate.Location = new System.Drawing.Point(7, 195);
            this.lblLastExtDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastExtDate.Name = "lblLastExtDate";
            this.lblLastExtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLastExtDate.Size = new System.Drawing.Size(256, 26);
            this.lblLastExtDate.TabIndex = 15;
            this.lblLastExtDate.Text = "-";
            this.lblLastExtDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "تاریخ آخرین تمدید:";
            // 
            // lblNotExtendedCount
            // 
            this.lblNotExtendedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotExtendedCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNotExtendedCount.Location = new System.Drawing.Point(7, 130);
            this.lblNotExtendedCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotExtendedCount.Name = "lblNotExtendedCount";
            this.lblNotExtendedCount.Size = new System.Drawing.Size(256, 26);
            this.lblNotExtendedCount.TabIndex = 15;
            this.lblNotExtendedCount.Text = "0";
            this.lblNotExtendedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "نفرات بدون تمدید:";
            // 
            // dPickUntil
            // 
            this.dPickUntil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dPickUntil.Location = new System.Drawing.Point(7, 58);
            this.dPickUntil.Name = "dPickUntil";
            this.dPickUntil.Size = new System.Drawing.Size(256, 34);
            this.dPickUntil.TabIndex = 5;
            this.dPickUntil.ValueChanged += new System.EventHandler(this.dPickUntil_ValueChanged);
            // 
            // btnSelAgOrOfc
            // 
            this.btnSelAgOrOfc.Font = new System.Drawing.Font("Samim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelAgOrOfc.Location = new System.Drawing.Point(7, 377);
            this.btnSelAgOrOfc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSelAgOrOfc.Name = "btnSelAgOrOfc";
            this.btnSelAgOrOfc.Size = new System.Drawing.Size(99, 36);
            this.btnSelAgOrOfc.TabIndex = 4;
            this.btnSelAgOrOfc.Text = "+";
            this.btnSelAgOrOfc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelAgOrOfc.UseVisualStyleBackColor = true;
            this.btnSelAgOrOfc.Click += new System.EventHandler(this.btnSelAgOrWhlOfc_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "علی ",
            "اکبر",
            "کاظم"});
            this.cmbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(7, 337);
            this.cmbSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(256, 34);
            this.cmbSearch.TabIndex = 3;
            // 
            // rbtnWholeOffice
            // 
            this.rbtnWholeOffice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnWholeOffice.AutoSize = true;
            this.rbtnWholeOffice.Location = new System.Drawing.Point(39, 297);
            this.rbtnWholeOffice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbtnWholeOffice.Name = "rbtnWholeOffice";
            this.rbtnWholeOffice.Size = new System.Drawing.Size(104, 30);
            this.rbtnWholeOffice.TabIndex = 2;
            this.rbtnWholeOffice.TabStop = true;
            this.rbtnWholeOffice.Text = "کل‌قسمت.";
            this.rbtnWholeOffice.UseVisualStyleBackColor = true;
            this.rbtnWholeOffice.CheckedChanged += new System.EventHandler(this.rbtnWholeOffice_CheckedChanged);
            // 
            // rbtnSingleAgent
            // 
            this.rbtnSingleAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnSingleAgent.AutoSize = true;
            this.rbtnSingleAgent.Checked = true;
            this.rbtnSingleAgent.Location = new System.Drawing.Point(155, 297);
            this.rbtnSingleAgent.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbtnSingleAgent.Name = "rbtnSingleAgent";
            this.rbtnSingleAgent.Size = new System.Drawing.Size(108, 30);
            this.rbtnSingleAgent.TabIndex = 1;
            this.rbtnSingleAgent.TabStop = true;
            this.rbtnSingleAgent.Text = "مامور‌منفرد؛";
            this.rbtnSingleAgent.UseVisualStyleBackColor = true;
            this.rbtnSingleAgent.CheckedChanged += new System.EventHandler(this.rbtnSingleAgent_CheckedChanged);
            // 
            // lblAgentCount
            // 
            this.lblAgentCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAgentCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAgentCount.Location = new System.Drawing.Point(9, 324);
            this.lblAgentCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAgentCount.Name = "lblAgentCount";
            this.lblAgentCount.Size = new System.Drawing.Size(146, 26);
            this.lblAgentCount.TabIndex = 15;
            this.lblAgentCount.Text = "0";
            this.lblAgentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "نفرات انتخاب‌شده:";
            // 
            // lstMarkedAgnts
            // 
            this.lstMarkedAgnts.ContextMenuStrip = this.cmuWholeForm;
            this.lstMarkedAgnts.DisplayMember = "Name";
            this.lstMarkedAgnts.FormattingEnabled = true;
            this.lstMarkedAgnts.ItemHeight = 26;
            this.lstMarkedAgnts.Location = new System.Drawing.Point(9, 29);
            this.lstMarkedAgnts.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lstMarkedAgnts.Name = "lstMarkedAgnts";
            this.lstMarkedAgnts.Size = new System.Drawing.Size(297, 290);
            this.lstMarkedAgnts.TabIndex = 16;
            this.lstMarkedAgnts.ValueMember = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkGenRpt);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.lstMarkedAgnts);
            this.groupBox1.Controls.Add(this.lblAgentCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(284, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 428);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اشخاص موردنظر";
            // 
            // chkGenRpt
            // 
            this.chkGenRpt.AutoSize = true;
            this.chkGenRpt.Checked = true;
            this.chkGenRpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenRpt.Font = new System.Drawing.Font("Samim", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGenRpt.Location = new System.Drawing.Point(222, 394);
            this.chkGenRpt.Name = "chkGenRpt";
            this.chkGenRpt.Size = new System.Drawing.Size(79, 21);
            this.chkGenRpt.TabIndex = 18;
            this.chkGenRpt.Text = "ایجاد گزارش";
            this.chkGenRpt.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(9, 365);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(116, 48);
            this.btnApply.TabIndex = 17;
            this.btnApply.Text = "اعمال";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cmuWholeForm
            // 
            this.cmuWholeForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspRemAgnt});
            this.cmuWholeForm.Name = "cmuWholeForm";
            this.cmuWholeForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmuWholeForm.Size = new System.Drawing.Size(124, 26);
            // 
            // tspRemAgnt
            // 
            this.tspRemAgnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspRemAgnt.Name = "tspRemAgnt";
            this.tspRemAgnt.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tspRemAgnt.Size = new System.Drawing.Size(123, 22);
            this.tspRemAgnt.Text = "حذف";
            this.tspRemAgnt.Click += new System.EventHandler(this.tspRem_Click);
            // 
            // frmMissionExtension
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Samim", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMissionExtension";
            this.Text = "تمدید ماموریت";
            this.Load += new System.EventHandler(this.frmMissionExtension_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmuWholeForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstMarkedAgnts;
        private System.Windows.Forms.Label lblAgentCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelAgOrOfc;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.RadioButton rbtnWholeOffice;
        private System.Windows.Forms.RadioButton rbtnSingleAgent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPickUntil;
        private System.Windows.Forms.DateTimePicker dPickUntil;
        private System.Windows.Forms.Label lblNotExtendedCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblLastExtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkGenRpt;
        private System.Windows.Forms.Button btnSelAllNotExt;
        private System.Windows.Forms.ContextMenuStrip cmuWholeForm;
        private System.Windows.Forms.ToolStripMenuItem tspRemAgnt;
    }
}