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
            this.lstOpr = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstOpr
            // 
            this.lstOpr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOpr.FormattingEnabled = true;
            this.lstOpr.ItemHeight = 26;
            this.lstOpr.Location = new System.Drawing.Point(0, 0);
            this.lstOpr.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lstOpr.MultiColumn = true;
            this.lstOpr.Name = "lstOpr";
            this.lstOpr.Size = new System.Drawing.Size(761, 416);
            this.lstOpr.TabIndex = 0;
            // 
            // frmRemoveOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 416);
            this.Controls.Add(this.lstOpr);
            this.Font = new System.Drawing.Font("Samim", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmRemoveOperation";
            this.Text = "frmRemoveOperation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOpr;
    }
}