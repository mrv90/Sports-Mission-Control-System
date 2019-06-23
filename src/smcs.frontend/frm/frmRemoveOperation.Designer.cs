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
            this.lstOpr = new System.Windows.Forms.ListView();
            this.hdrApplyDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrEnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrAgName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrTrgtDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmuListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tspRemHistItm = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpd = new System.Windows.Forms.Button();
            this.cmuListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOpr
            // 
            this.lstOpr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOpr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrApplyDT,
            this.hdrEnt,
            this.hdrAgName,
            this.hdrTrgtDT,
            this.hdrDesc});
            this.lstOpr.ContextMenuStrip = this.cmuListView;
            this.lstOpr.Location = new System.Drawing.Point(0, 1);
            this.lstOpr.MultiSelect = false;
            this.lstOpr.Name = "lstOpr";
            this.lstOpr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstOpr.Size = new System.Drawing.Size(569, 493);
            this.lstOpr.TabIndex = 0;
            this.lstOpr.UseCompatibleStateImageBehavior = false;
            this.lstOpr.View = System.Windows.Forms.View.Details;
            // 
            // hdrApplyDT
            // 
            this.hdrApplyDT.Text = "تاریخ ثبت";
            this.hdrApplyDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hdrApplyDT.Width = 95;
            // 
            // hdrEnt
            // 
            this.hdrEnt.Text = "ن‌عملیات";
            this.hdrEnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hdrEnt.Width = 104;
            // 
            // hdrAgName
            // 
            this.hdrAgName.Text = "نام مامور";
            this.hdrAgName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hdrAgName.Width = 91;
            // 
            // hdrTrgtDT
            // 
            this.hdrTrgtDT.Text = "تاریخ هدف";
            this.hdrTrgtDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hdrTrgtDT.Width = 111;
            // 
            // hdrDesc
            // 
            this.hdrDesc.Text = "توضیحات";
            this.hdrDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hdrDesc.Width = 160;
            // 
            // cmuListView
            // 
            this.cmuListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspRemHistItm});
            this.cmuListView.Name = "cmuWholeForm";
            this.cmuListView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmuListView.Size = new System.Drawing.Size(181, 48);
            // 
            // tspRemHistItm
            // 
            this.tspRemHistItm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspRemHistItm.Name = "tspRemHistItm";
            this.tspRemHistItm.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tspRemHistItm.Size = new System.Drawing.Size(180, 22);
            this.tspRemHistItm.Text = "حذف";
            this.tspRemHistItm.Click += new System.EventHandler(this.tspRemHistItm_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpd.Location = new System.Drawing.Point(0, 500);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(569, 36);
            this.btnUpd.TabIndex = 1;
            this.btnUpd.Text = "بروزرسانی";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // frmRemoveOperation
            // 
            this.AcceptButton = this.btnUpd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 536);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.lstOpr);
            this.Font = new System.Drawing.Font("Samim", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmRemoveOperation";
            this.Text = "لغو گردشکار";
            this.Load += new System.EventHandler(this.frmRemoveOperation_Load);
            this.cmuListView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstOpr;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.ColumnHeader hdrEnt;
        private System.Windows.Forms.ColumnHeader hdrApplyDT;
        private System.Windows.Forms.ColumnHeader hdrAgName;
        private System.Windows.Forms.ColumnHeader hdrTrgtDT;
        private System.Windows.Forms.ColumnHeader hdrDesc;
        private System.Windows.Forms.ContextMenuStrip cmuListView;
        private System.Windows.Forms.ToolStripMenuItem tspRemHistItm;
    }
}