namespace smcs.frontend.frm
{
    partial class frmRemoveOperation
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
            this.cmuListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCancelItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.lstOpr = new System.Windows.Forms.ListView();
            this.hdrId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrTS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrOpr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrTrg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrUsr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmuListView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmuListView
            // 
            this.cmuListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCancelItem});
            this.cmuListView.Name = "cmuWholeForm";
            this.cmuListView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmuListView.Size = new System.Drawing.Size(116, 26);
            // 
            // tsmiCancelItem
            // 
            this.tsmiCancelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiCancelItem.Name = "tsmiCancelItem";
            this.tsmiCancelItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmiCancelItem.Size = new System.Drawing.Size(115, 22);
            this.tsmiCancelItem.Text = "لغو";
            this.tsmiCancelItem.Click += new System.EventHandler(this.tsmiCancelItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.cmbSearch);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbSearch
            // 
            this.cmbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSearch.Location = new System.Drawing.Point(3, 30);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(708, 34);
            this.cmbSearch.TabIndex = 24;
            this.cmbSearch.TextChanged += new System.EventHandler(this.cmbSearch_TextChanged);
            this.cmbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbSearch_KeyUp);
            // 
            // lstOpr
            // 
            this.lstOpr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOpr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrId,
            this.hdrTS,
            this.hdrOpr,
            this.hdrTrg,
            this.hdrUsr,
            this.hdrDesc});
            this.lstOpr.ContextMenuStrip = this.cmuListView;
            this.lstOpr.FullRowSelect = true;
            this.lstOpr.HideSelection = false;
            this.lstOpr.Location = new System.Drawing.Point(3, 70);
            this.lstOpr.MultiSelect = false;
            this.lstOpr.Name = "lstOpr";
            this.lstOpr.Size = new System.Drawing.Size(708, 473);
            this.lstOpr.TabIndex = 2;
            this.lstOpr.UseCompatibleStateImageBehavior = false;
            this.lstOpr.View = System.Windows.Forms.View.Details;
            // 
            // hdrId
            // 
            this.hdrId.DisplayIndex = 5;
            this.hdrId.Text = "ردیف";
            this.hdrId.Width = 50;
            // 
            // hdrTS
            // 
            this.hdrTS.DisplayIndex = 4;
            this.hdrTS.Text = "تاریخ‌وزمان اِعمال";
            this.hdrTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hdrTS.Width = 200;
            // 
            // hdrOpr
            // 
            this.hdrOpr.DisplayIndex = 3;
            this.hdrOpr.Text = "نوع‌عملیات";
            this.hdrOpr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hdrOpr.Width = 100;
            // 
            // hdrTrg
            // 
            this.hdrTrg.DisplayIndex = 2;
            this.hdrTrg.Text = "تاریخ‌هدف";
            this.hdrTrg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hdrTrg.Width = 100;
            // 
            // hdrUsr
            // 
            this.hdrUsr.DisplayIndex = 1;
            this.hdrUsr.Text = "متصدی";
            this.hdrUsr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hdrUsr.Width = 100;
            // 
            // hdrDesc
            // 
            this.hdrDesc.DisplayIndex = 0;
            this.hdrDesc.Text = "توضیحات";
            this.hdrDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hdrDesc.Width = 150;
            // 
            // frmRemoveOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 543);
            this.Controls.Add(this.lstOpr);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Samim", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmRemoveOperation";
            this.Text = "لغو عملیات";
            this.cmuListView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmuListView;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.ListView lstOpr;
        private System.Windows.Forms.ColumnHeader hdrId;
        private System.Windows.Forms.ColumnHeader hdrTS;
        private System.Windows.Forms.ColumnHeader hdrOpr;
        private System.Windows.Forms.ColumnHeader hdrTrg;
        private System.Windows.Forms.ColumnHeader hdrUsr;
        private System.Windows.Forms.ColumnHeader hdrDesc;
    }
}