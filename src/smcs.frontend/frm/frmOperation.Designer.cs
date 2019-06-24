namespace smcs.frontend.frm
{
    partial class frmOperation
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
            this.cmbOprType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstMarkedDates = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDaysCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectDate = new System.Windows.Forms.Button();
            this.lblPickUntil = new System.Windows.Forms.Label();
            this.lblPickFrom = new System.Windows.Forms.Label();
            this.dPickUntil = new System.Windows.Forms.DateTimePicker();
            this.dPickFrom = new System.Windows.Forms.DateTimePicker();
            this.rbtnTimespan = new System.Windows.Forms.RadioButton();
            this.rbtnSingleDay = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstMarkedAgnts = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAgentCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectAgent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSearchAgnts = new System.Windows.Forms.ComboBox();
            this.rbtnWholeOffice = new System.Windows.Forms.RadioButton();
            this.rbtnSingleAgent = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.chkGenRpt = new System.Windows.Forms.CheckBox();
            this.tspRemAgnt = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuWholeForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cmuWholeForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOprType
            // 
            this.cmbOprType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOprType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOprType.FormattingEnabled = true;
            this.cmbOprType.Location = new System.Drawing.Point(6, 61);
            this.cmbOprType.Name = "cmbOprType";
            this.cmbOprType.Size = new System.Drawing.Size(328, 33);
            this.cmbOprType.TabIndex = 0;
            this.cmbOprType.SelectedIndexChanged += new System.EventHandler(this.cmbOprType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lstMarkedDates);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblDaysCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSelectDate);
            this.groupBox1.Controls.Add(this.lblPickUntil);
            this.groupBox1.Controls.Add(this.lblPickFrom);
            this.groupBox1.Controls.Add(this.dPickUntil);
            this.groupBox1.Controls.Add(this.dPickFrom);
            this.groupBox1.Controls.Add(this.rbtnTimespan);
            this.groupBox1.Controls.Add(this.rbtnSingleDay);
            this.groupBox1.Location = new System.Drawing.Point(352, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 422);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تقویم هدف";
            // 
            // lstMarkedDates
            // 
            this.lstMarkedDates.FormattingEnabled = true;
            this.lstMarkedDates.ItemHeight = 25;
            this.lstMarkedDates.Location = new System.Drawing.Point(6, 282);
            this.lstMarkedDates.Name = "lstMarkedDates";
            this.lstMarkedDates.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstMarkedDates.Size = new System.Drawing.Size(328, 129);
            this.lstMarkedDates.TabIndex = 16;
            this.lstMarkedDates.SelectedIndexChanged += new System.EventHandler(this.lstMarkedDates_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "تاریخ‌های انتخاب شده:";
            // 
            // lblDaysCount
            // 
            this.lblDaysCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDaysCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDaysCount.Location = new System.Drawing.Point(6, 201);
            this.lblDaysCount.Name = "lblDaysCount";
            this.lblDaysCount.Size = new System.Drawing.Size(209, 25);
            this.lblDaysCount.TabIndex = 15;
            this.lblDaysCount.Text = "0";
            this.lblDaysCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "روز انتخاب‌شده:";
            // 
            // btnSelectDate
            // 
            this.btnSelectDate.Font = new System.Drawing.Font("Samim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDate.Location = new System.Drawing.Point(6, 154);
            this.btnSelectDate.Name = "btnSelectDate";
            this.btnSelectDate.Size = new System.Drawing.Size(79, 33);
            this.btnSelectDate.TabIndex = 4;
            this.btnSelectDate.Text = "+";
            this.btnSelectDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectDate.UseVisualStyleBackColor = true;
            this.btnSelectDate.Click += new System.EventHandler(this.btnSelectDate_Click);
            // 
            // lblPickUntil
            // 
            this.lblPickUntil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPickUntil.AutoSize = true;
            this.lblPickUntil.Enabled = false;
            this.lblPickUntil.Location = new System.Drawing.Point(274, 120);
            this.lblPickUntil.Name = "lblPickUntil";
            this.lblPickUntil.Size = new System.Drawing.Size(60, 25);
            this.lblPickUntil.TabIndex = 4;
            this.lblPickUntil.Text = "تا تاریخ:";
            // 
            // lblPickFrom
            // 
            this.lblPickFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPickFrom.AutoSize = true;
            this.lblPickFrom.Location = new System.Drawing.Point(259, 77);
            this.lblPickFrom.Name = "lblPickFrom";
            this.lblPickFrom.Size = new System.Drawing.Size(75, 25);
            this.lblPickFrom.TabIndex = 3;
            this.lblPickFrom.Text = "در مورخه:";
            // 
            // dPickUntil
            // 
            this.dPickUntil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dPickUntil.Enabled = false;
            this.dPickUntil.Location = new System.Drawing.Point(6, 116);
            this.dPickUntil.Name = "dPickUntil";
            this.dPickUntil.Size = new System.Drawing.Size(247, 32);
            this.dPickUntil.TabIndex = 3;
            // 
            // dPickFrom
            // 
            this.dPickFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dPickFrom.Location = new System.Drawing.Point(6, 72);
            this.dPickFrom.Name = "dPickFrom";
            this.dPickFrom.Size = new System.Drawing.Size(247, 32);
            this.dPickFrom.TabIndex = 2;
            // 
            // rbtnTimespan
            // 
            this.rbtnTimespan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnTimespan.AutoSize = true;
            this.rbtnTimespan.Location = new System.Drawing.Point(150, 31);
            this.rbtnTimespan.Name = "rbtnTimespan";
            this.rbtnTimespan.Size = new System.Drawing.Size(89, 29);
            this.rbtnTimespan.TabIndex = 1;
            this.rbtnTimespan.Text = "بازه‌زمانی.";
            this.rbtnTimespan.UseVisualStyleBackColor = true;
            this.rbtnTimespan.CheckedChanged += new System.EventHandler(this.rbtnTimespan_CheckedChanged);
            // 
            // rbtnSingleDay
            // 
            this.rbtnSingleDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnSingleDay.AutoSize = true;
            this.rbtnSingleDay.Checked = true;
            this.rbtnSingleDay.Location = new System.Drawing.Point(253, 31);
            this.rbtnSingleDay.Name = "rbtnSingleDay";
            this.rbtnSingleDay.Size = new System.Drawing.Size(76, 29);
            this.rbtnSingleDay.TabIndex = 0;
            this.rbtnSingleDay.TabStop = true;
            this.rbtnSingleDay.Text = "یک‌روز؛";
            this.rbtnSingleDay.UseVisualStyleBackColor = true;
            this.rbtnSingleDay.CheckedChanged += new System.EventHandler(this.rbtnSingleDay_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstMarkedAgnts);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblAgentCount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSelectAgent);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbOprType);
            this.groupBox2.Controls.Add(this.cmbSearchAgnts);
            this.groupBox2.Controls.Add(this.rbtnWholeOffice);
            this.groupBox2.Controls.Add(this.rbtnSingleAgent);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 422);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملیات";
            // 
            // lstMarkedAgnts
            // 
            this.lstMarkedAgnts.DisplayMember = "Name";
            this.lstMarkedAgnts.FormattingEnabled = true;
            this.lstMarkedAgnts.ItemHeight = 25;
            this.lstMarkedAgnts.Location = new System.Drawing.Point(0, 282);
            this.lstMarkedAgnts.Name = "lstMarkedAgnts";
            this.lstMarkedAgnts.Size = new System.Drawing.Size(334, 129);
            this.lstMarkedAgnts.TabIndex = 16;
            this.lstMarkedAgnts.ValueMember = "Id";
            this.lstMarkedAgnts.SelectedIndexChanged += new System.EventHandler(this.lstMarkedAgnts_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "اشخاص موردنظر:";
            // 
            // lblAgentCount
            // 
            this.lblAgentCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAgentCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAgentCount.Location = new System.Drawing.Point(6, 201);
            this.lblAgentCount.Name = "lblAgentCount";
            this.lblAgentCount.Size = new System.Drawing.Size(186, 25);
            this.lblAgentCount.TabIndex = 15;
            this.lblAgentCount.Text = "0";
            this.lblAgentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "نفرات انتخاب‌شده:";
            // 
            // btnSelectAgent
            // 
            this.btnSelectAgent.Font = new System.Drawing.Font("Samim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAgent.Location = new System.Drawing.Point(6, 151);
            this.btnSelectAgent.Name = "btnSelectAgent";
            this.btnSelectAgent.Size = new System.Drawing.Size(79, 33);
            this.btnSelectAgent.TabIndex = 4;
            this.btnSelectAgent.Text = "+";
            this.btnSelectAgent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectAgent.UseVisualStyleBackColor = true;
            this.btnSelectAgent.Click += new System.EventHandler(this.btnSelectAgent_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "نوع‌:";
            // 
            // cmbSearchAgnts
            // 
            this.cmbSearchAgnts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearchAgnts.AutoCompleteCustomSource.AddRange(new string[] {
            "علی ",
            "اکبر",
            "کاظم"});
            this.cmbSearchAgnts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearchAgnts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchAgnts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchAgnts.FormattingEnabled = true;
            this.cmbSearchAgnts.Location = new System.Drawing.Point(91, 151);
            this.cmbSearchAgnts.Name = "cmbSearchAgnts";
            this.cmbSearchAgnts.Size = new System.Drawing.Size(243, 33);
            this.cmbSearchAgnts.TabIndex = 3;
            this.cmbSearchAgnts.SelectedIndexChanged += new System.EventHandler(this.cmbSearchAgnts_SelectedIndexChanged);
            // 
            // rbtnWholeOffice
            // 
            this.rbtnWholeOffice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnWholeOffice.AutoSize = true;
            this.rbtnWholeOffice.Location = new System.Drawing.Point(114, 116);
            this.rbtnWholeOffice.Name = "rbtnWholeOffice";
            this.rbtnWholeOffice.Size = new System.Drawing.Size(99, 29);
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
            this.rbtnSingleAgent.Location = new System.Drawing.Point(219, 116);
            this.rbtnSingleAgent.Name = "rbtnSingleAgent";
            this.rbtnSingleAgent.Size = new System.Drawing.Size(104, 29);
            this.rbtnSingleAgent.TabIndex = 1;
            this.rbtnSingleAgent.TabStop = true;
            this.rbtnSingleAgent.Text = "مامور‌منفرد؛";
            this.rbtnSingleAgent.UseVisualStyleBackColor = true;
            this.rbtnSingleAgent.CheckedChanged += new System.EventHandler(this.rbtnSingleAgent_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 440);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(106, 48);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "اعمال";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearAll.Location = new System.Drawing.Point(363, 440);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(106, 48);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "عملیات جدید";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // chkGenRpt
            // 
            this.chkGenRpt.AutoSize = true;
            this.chkGenRpt.Checked = true;
            this.chkGenRpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenRpt.Font = new System.Drawing.Font("Samim", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGenRpt.Location = new System.Drawing.Point(613, 451);
            this.chkGenRpt.Name = "chkGenRpt";
            this.chkGenRpt.Size = new System.Drawing.Size(79, 21);
            this.chkGenRpt.TabIndex = 1;
            this.chkGenRpt.Text = "ایجاد گزارش";
            this.chkGenRpt.UseVisualStyleBackColor = true;
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
            // cmuWholeForm
            // 
            this.cmuWholeForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspRemAgnt});
            this.cmuWholeForm.Name = "cmuWholeForm";
            this.cmuWholeForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmuWholeForm.Size = new System.Drawing.Size(124, 26);
            // 
            // frmOperation
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClearAll;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.chkGenRpt);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Samim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmOperation";
            this.Text = "گردش‌کار";
            this.Load += new System.EventHandler(this.frmOperation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cmuWholeForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOprType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectDate;
        private System.Windows.Forms.Label lblPickUntil;
        private System.Windows.Forms.Label lblPickFrom;
        private System.Windows.Forms.DateTimePicker dPickUntil;
        private System.Windows.Forms.DateTimePicker dPickFrom;
        private System.Windows.Forms.RadioButton rbtnTimespan;
        private System.Windows.Forms.RadioButton rbtnSingleDay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSearchAgnts;
        private System.Windows.Forms.RadioButton rbtnWholeOffice;
        private System.Windows.Forms.RadioButton rbtnSingleAgent;
        private System.Windows.Forms.Button btnSelectAgent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAgentCount;
        private System.Windows.Forms.Label lblDaysCount;
        private System.Windows.Forms.CheckBox chkGenRpt;
        private System.Windows.Forms.ListBox lstMarkedDates;
        public System.Windows.Forms.ListBox lstMarkedAgnts;
        private System.Windows.Forms.ToolStripMenuItem tspRemAgnt;
        private System.Windows.Forms.ContextMenuStrip cmuWholeForm;
    }
}