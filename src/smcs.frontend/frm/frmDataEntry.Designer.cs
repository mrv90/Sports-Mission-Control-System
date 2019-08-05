namespace smcs.frontend.frm
{
    partial class frmDataEntry
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
            this.gbxUpper = new System.Windows.Forms.GroupBox();
            this.mtxtNtioSearch = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnOldAgnt = new System.Windows.Forms.RadioButton();
            this.rbtnModfAgnt = new System.Windows.Forms.RadioButton();
            this.rbtnNewAgnt = new System.Windows.Forms.RadioButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tslblStatus = new System.Windows.Forms.ToolStripLabel();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.ckhKeepOpenWindow = new System.Windows.Forms.CheckBox();
            this.btnGenRpt = new System.Windows.Forms.Button();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.gbxLower = new System.Windows.Forms.GroupBox();
            this.mtxtPersCode = new System.Windows.Forms.MaskedTextBox();
            this.txtEmgNum = new System.Windows.Forms.MaskedTextBox();
            this.txtCntcNum = new System.Windows.Forms.MaskedTextBox();
            this.txtOrdrBy = new System.Windows.Forms.TextBox();
            this.cmbOffc = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.cmbSprt = new System.Windows.Forms.ComboBox();
            this.dPickDteOfRecp = new System.Windows.Forms.DateTimePicker();
            this.dPickDteOfDisp = new System.Windows.Forms.DateTimePicker();
            this.txtFthrName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbRank = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxUpper.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.gbxLower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxUpper
            // 
            this.gbxUpper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxUpper.Controls.Add(this.mtxtNtioSearch);
            this.gbxUpper.Controls.Add(this.label6);
            this.gbxUpper.Controls.Add(this.rbtnOldAgnt);
            this.gbxUpper.Controls.Add(this.rbtnModfAgnt);
            this.gbxUpper.Controls.Add(this.rbtnNewAgnt);
            this.gbxUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxUpper.Location = new System.Drawing.Point(0, 0);
            this.gbxUpper.Name = "gbxUpper";
            this.gbxUpper.Size = new System.Drawing.Size(624, 92);
            this.gbxUpper.TabIndex = 3;
            this.gbxUpper.TabStop = false;
            this.gbxUpper.Text = "عملیات";
            // 
            // mtxtNtioSearch
            // 
            this.mtxtNtioSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtNtioSearch.Location = new System.Drawing.Point(4, 57);
            this.mtxtNtioSearch.Mask = "000-000-0000";
            this.mtxtNtioSearch.Name = "mtxtNtioSearch";
            this.mtxtNtioSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtNtioSearch.Size = new System.Drawing.Size(616, 32);
            this.mtxtNtioSearch.TabIndex = 19;
            this.mtxtNtioSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtNtioSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtNtioSearch_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Samim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(528, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "درج‌کدملی‌برای:";
            // 
            // rbtnOldAgnt
            // 
            this.rbtnOldAgnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnOldAgnt.AutoSize = true;
            this.rbtnOldAgnt.Font = new System.Drawing.Font("Samim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOldAgnt.Location = new System.Drawing.Point(83, 22);
            this.rbtnOldAgnt.Name = "rbtnOldAgnt";
            this.rbtnOldAgnt.Size = new System.Drawing.Size(123, 29);
            this.rbtnOldAgnt.TabIndex = 2;
            this.rbtnOldAgnt.Text = "ثبت(از‌سوابق):";
            this.rbtnOldAgnt.UseVisualStyleBackColor = true;
            // 
            // rbtnModfAgnt
            // 
            this.rbtnModfAgnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnModfAgnt.AutoSize = true;
            this.rbtnModfAgnt.Font = new System.Drawing.Font("Samim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnModfAgnt.Location = new System.Drawing.Point(212, 22);
            this.rbtnModfAgnt.Name = "rbtnModfAgnt";
            this.rbtnModfAgnt.Size = new System.Drawing.Size(174, 29);
            this.rbtnModfAgnt.TabIndex = 1;
            this.rbtnModfAgnt.Text = "تغییر|بروزرسانی‌مامور؛";
            this.rbtnModfAgnt.UseVisualStyleBackColor = true;
            // 
            // rbtnNewAgnt
            // 
            this.rbtnNewAgnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnNewAgnt.AutoSize = true;
            this.rbtnNewAgnt.Checked = true;
            this.rbtnNewAgnt.Font = new System.Drawing.Font("Samim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNewAgnt.Location = new System.Drawing.Point(392, 22);
            this.rbtnNewAgnt.Name = "rbtnNewAgnt";
            this.rbtnNewAgnt.Size = new System.Drawing.Size(130, 29);
            this.rbtnNewAgnt.TabIndex = 0;
            this.rbtnNewAgnt.TabStop = true;
            this.rbtnNewAgnt.Text = "ثبت‌مامور‌جدید؛";
            this.rbtnNewAgnt.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(624, 557);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(624, 557);
            this.toolStripContainer1.TabIndex = 33;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblStatus});
            this.toolStrip.Location = new System.Drawing.Point(0, 532);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(624, 25);
            this.toolStrip.TabIndex = 34;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tslblStatus
            // 
            this.tslblStatus.Name = "tslblStatus";
            this.tslblStatus.Size = new System.Drawing.Size(0, 22);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoEllipsis = true;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(236, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 25);
            this.label21.TabIndex = 30;
            this.label21.Text = "آدرس:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "توضیحات:";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnApply.Location = new System.Drawing.Point(187, 349);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(104, 106);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "ثبت";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearAll.Font = new System.Drawing.Font("Samim", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(102, 416);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(79, 39);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "عملیات جدید";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // ckhKeepOpenWindow
            // 
            this.ckhKeepOpenWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckhKeepOpenWindow.AutoSize = true;
            this.ckhKeepOpenWindow.Font = new System.Drawing.Font("Samim", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckhKeepOpenWindow.Location = new System.Drawing.Point(7, 355);
            this.ckhKeepOpenWindow.Name = "ckhKeepOpenWindow";
            this.ckhKeepOpenWindow.Size = new System.Drawing.Size(89, 21);
            this.ckhKeepOpenWindow.TabIndex = 16;
            this.ckhKeepOpenWindow.Text = "بازماندن پنجره";
            this.ckhKeepOpenWindow.UseVisualStyleBackColor = true;
            this.ckhKeepOpenWindow.CheckedChanged += new System.EventHandler(this.ckhKeepOpenWindow_CheckedChanged);
            // 
            // btnGenRpt
            // 
            this.btnGenRpt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenRpt.Enabled = false;
            this.btnGenRpt.Font = new System.Drawing.Font("Samim", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenRpt.Location = new System.Drawing.Point(102, 349);
            this.btnGenRpt.Name = "btnGenRpt";
            this.btnGenRpt.Size = new System.Drawing.Size(79, 61);
            this.btnGenRpt.TabIndex = 15;
            this.btnGenRpt.Text = "چاپ گزارش";
            this.btnGenRpt.UseVisualStyleBackColor = true;
            this.btnGenRpt.Click += new System.EventHandler(this.btnGenRpt_Click);
            // 
            // txtAddr
            // 
            this.txtAddr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddr.Font = new System.Drawing.Font("Samim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr.Location = new System.Drawing.Point(3, 60);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(288, 148);
            this.txtAddr.TabIndex = 12;
            this.txtAddr.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddr_Validating);
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Font = new System.Drawing.Font("Samim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(7, 241);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(284, 102);
            this.txtDesc.TabIndex = 13;
            // 
            // gbxLower
            // 
            this.gbxLower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxLower.Controls.Add(this.mtxtPersCode);
            this.gbxLower.Controls.Add(this.txtEmgNum);
            this.gbxLower.Controls.Add(this.txtCntcNum);
            this.gbxLower.Controls.Add(this.txtOrdrBy);
            this.gbxLower.Controls.Add(this.cmbOffc);
            this.gbxLower.Controls.Add(this.cmbUnit);
            this.gbxLower.Controls.Add(this.cmbSprt);
            this.gbxLower.Controls.Add(this.dPickDteOfRecp);
            this.gbxLower.Controls.Add(this.dPickDteOfDisp);
            this.gbxLower.Controls.Add(this.txtFthrName);
            this.gbxLower.Controls.Add(this.txtName);
            this.gbxLower.Controls.Add(this.cmbRank);
            this.gbxLower.Controls.Add(this.label17);
            this.gbxLower.Controls.Add(this.label15);
            this.gbxLower.Controls.Add(this.label22);
            this.gbxLower.Controls.Add(this.label16);
            this.gbxLower.Controls.Add(this.label20);
            this.gbxLower.Controls.Add(this.label2);
            this.gbxLower.Controls.Add(this.label4);
            this.gbxLower.Controls.Add(this.label12);
            this.gbxLower.Controls.Add(this.label11);
            this.gbxLower.Controls.Add(this.label3);
            this.gbxLower.Controls.Add(this.label9);
            this.gbxLower.Controls.Add(this.label10);
            this.gbxLower.Controls.Add(this.txtDesc);
            this.gbxLower.Controls.Add(this.txtAddr);
            this.gbxLower.Controls.Add(this.btnGenRpt);
            this.gbxLower.Controls.Add(this.ckhKeepOpenWindow);
            this.gbxLower.Controls.Add(this.btnClearAll);
            this.gbxLower.Controls.Add(this.btnApply);
            this.gbxLower.Controls.Add(this.label1);
            this.gbxLower.Controls.Add(this.label21);
            this.gbxLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxLower.Location = new System.Drawing.Point(0, 92);
            this.gbxLower.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbxLower.Name = "gbxLower";
            this.gbxLower.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbxLower.Size = new System.Drawing.Size(624, 465);
            this.gbxLower.TabIndex = 4;
            this.gbxLower.TabStop = false;
            // 
            // mtxtPersCode
            // 
            this.mtxtPersCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtPersCode.Location = new System.Drawing.Point(296, 315);
            this.mtxtPersCode.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtPersCode.Mask = "00-00-00-00000";
            this.mtxtPersCode.Name = "mtxtPersCode";
            this.mtxtPersCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtPersCode.Size = new System.Drawing.Size(226, 32);
            this.mtxtPersCode.TabIndex = 8;
            this.mtxtPersCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtPersCode.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtPersCode_Validating);
            // 
            // txtEmgNum
            // 
            this.txtEmgNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmgNum.Location = new System.Drawing.Point(296, 423);
            this.txtEmgNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmgNum.Mask = "(0999) 000-0000";
            this.txtEmgNum.Name = "txtEmgNum";
            this.txtEmgNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmgNum.Size = new System.Drawing.Size(226, 32);
            this.txtEmgNum.TabIndex = 11;
            this.txtEmgNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmgNum.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtEmgNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmgNum_Validating);
            // 
            // txtCntcNum
            // 
            this.txtCntcNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCntcNum.Location = new System.Drawing.Point(297, 387);
            this.txtCntcNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtCntcNum.Mask = "(0999) 000-0000";
            this.txtCntcNum.Name = "txtCntcNum";
            this.txtCntcNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCntcNum.Size = new System.Drawing.Size(226, 32);
            this.txtCntcNum.TabIndex = 10;
            this.txtCntcNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCntcNum.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCntcNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtCntcNum_Validating);
            // 
            // txtOrdrBy
            // 
            this.txtOrdrBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrdrBy.Location = new System.Drawing.Point(296, 351);
            this.txtOrdrBy.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrdrBy.Name = "txtOrdrBy";
            this.txtOrdrBy.Size = new System.Drawing.Size(227, 32);
            this.txtOrdrBy.TabIndex = 9;
            this.txtOrdrBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOrdrBy.Validating += new System.ComponentModel.CancelEventHandler(this.txtOrdrBy_Validating);
            // 
            // cmbOffc
            // 
            this.cmbOffc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOffc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOffc.FormattingEnabled = true;
            this.cmbOffc.Location = new System.Drawing.Point(296, 278);
            this.cmbOffc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOffc.Name = "cmbOffc";
            this.cmbOffc.Size = new System.Drawing.Size(226, 33);
            this.cmbOffc.TabIndex = 7;
            this.cmbOffc.Validating += new System.ComponentModel.CancelEventHandler(this.cmbOffc_Validating);
            // 
            // cmbUnit
            // 
            this.cmbUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(296, 132);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(226, 33);
            this.cmbUnit.TabIndex = 3;
            this.cmbUnit.Validating += new System.ComponentModel.CancelEventHandler(this.cmbUnit_Validating);
            // 
            // cmbSprt
            // 
            this.cmbSprt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSprt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSprt.FormattingEnabled = true;
            this.cmbSprt.Location = new System.Drawing.Point(296, 241);
            this.cmbSprt.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSprt.Name = "cmbSprt";
            this.cmbSprt.Size = new System.Drawing.Size(226, 33);
            this.cmbSprt.TabIndex = 6;
            this.cmbSprt.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSprt_Validating);
            // 
            // dPickDteOfRecp
            // 
            this.dPickDteOfRecp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dPickDteOfRecp.Location = new System.Drawing.Point(296, 205);
            this.dPickDteOfRecp.Margin = new System.Windows.Forms.Padding(2);
            this.dPickDteOfRecp.Name = "dPickDteOfRecp";
            this.dPickDteOfRecp.Size = new System.Drawing.Size(226, 32);
            this.dPickDteOfRecp.TabIndex = 5;
            // 
            // dPickDteOfDisp
            // 
            this.dPickDteOfDisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dPickDteOfDisp.Location = new System.Drawing.Point(296, 169);
            this.dPickDteOfDisp.Margin = new System.Windows.Forms.Padding(2);
            this.dPickDteOfDisp.Name = "dPickDteOfDisp";
            this.dPickDteOfDisp.Size = new System.Drawing.Size(226, 32);
            this.dPickDteOfDisp.TabIndex = 4;
            this.dPickDteOfDisp.Validating += new System.ComponentModel.CancelEventHandler(this.dPickDteOfDisp_Validating);
            // 
            // txtFthrName
            // 
            this.txtFthrName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFthrName.Location = new System.Drawing.Point(296, 96);
            this.txtFthrName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFthrName.Name = "txtFthrName";
            this.txtFthrName.Size = new System.Drawing.Size(226, 32);
            this.txtFthrName.TabIndex = 2;
            this.txtFthrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFthrName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFthrName_Validating);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(296, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 32);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // cmbRank
            // 
            this.cmbRank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRank.DisplayMember = "Idzzz";
            this.cmbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRank.FormattingEnabled = true;
            this.cmbRank.Location = new System.Drawing.Point(296, 23);
            this.cmbRank.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(226, 33);
            this.cmbRank.TabIndex = 0;
            this.cmbRank.Validating += new System.ComponentModel.CancelEventHandler(this.cmbRank_Validating);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoEllipsis = true;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(529, 351);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 25);
            this.label17.TabIndex = 80;
            this.label17.Text = "بنابه‌دستور:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoEllipsis = true;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(529, 426);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 25);
            this.label15.TabIndex = 78;
            this.label15.Text = "ش‌اضطراری:";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoEllipsis = true;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(529, 390);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 25);
            this.label22.TabIndex = 79;
            this.label22.Text = "ش‌تماس:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(529, 99);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 25);
            this.label16.TabIndex = 75;
            this.label16.Text = "نام‌پدر:";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoEllipsis = true;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(529, 318);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 25);
            this.label20.TabIndex = 72;
            this.label20.Text = "کدپرسنلی:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "تاریخ‌پذیرش:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 68;
            this.label4.Text = "تاریخ‌اعزام:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(529, 281);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 25);
            this.label12.TabIndex = 66;
            this.label12.Text = "قسمت:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoEllipsis = true;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(529, 244);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 25);
            this.label11.TabIndex = 64;
            this.label11.Text = "رشته‌ورزشی:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "یگان:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 77;
            this.label9.Text = "نام‌و‌نشان:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(529, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 25);
            this.label10.TabIndex = 60;
            this.label10.Text = "درجه:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClearAll;
            this.ClientSize = new System.Drawing.Size(624, 557);
            this.Controls.Add(this.gbxLower);
            this.Controls.Add(this.gbxUpper);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Samim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmDataEntry";
            this.Text = "ثبت/بروزرسانی";
            this.gbxUpper.ResumeLayout(false);
            this.gbxUpper.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.gbxLower.ResumeLayout(false);
            this.gbxLower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUpper;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RadioButton rbtnModfAgnt;
        public System.Windows.Forms.RadioButton rbtnNewAgnt;
        public System.Windows.Forms.RadioButton rbtnOldAgnt;
        private System.Windows.Forms.MaskedTextBox mtxtNtioSearch;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel tslblStatus;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.CheckBox ckhKeepOpenWindow;
        private System.Windows.Forms.Button btnGenRpt;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.GroupBox gbxLower;
        private System.Windows.Forms.MaskedTextBox mtxtPersCode;
        private System.Windows.Forms.MaskedTextBox txtEmgNum;
        private System.Windows.Forms.MaskedTextBox txtCntcNum;
        private System.Windows.Forms.TextBox txtOrdrBy;
        private System.Windows.Forms.ComboBox cmbOffc;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.ComboBox cmbSprt;
        private System.Windows.Forms.DateTimePicker dPickDteOfRecp;
        private System.Windows.Forms.DateTimePicker dPickDteOfDisp;
        private System.Windows.Forms.TextBox txtFthrName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbRank;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}