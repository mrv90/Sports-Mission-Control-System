namespace smcs.frontend.frm
{
    partial class frmSignatureDefinition
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
            this.btnApply = new System.Windows.Forms.Button();
            this.txtJouniorBoss = new System.Windows.Forms.TextBox();
            this.lblJouniorBoss = new System.Windows.Forms.Label();
            this.txtBoss = new System.Windows.Forms.TextBox();
            this.lblBoss = new System.Windows.Forms.Label();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.txtJouniorBoss);
            this.groupBox1.Controls.Add(this.lblJouniorBoss);
            this.groupBox1.Controls.Add(this.txtBoss);
            this.groupBox1.Controls.Add(this.lblBoss);
            this.groupBox1.Controls.Add(this.txtManager);
            this.groupBox1.Controls.Add(this.lblManager);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(405, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 154);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(116, 48);
            this.btnApply.TabIndex = 18;
            this.btnApply.Text = "اعمال";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtJouniorBoss
            // 
            this.txtJouniorBoss.Location = new System.Drawing.Point(12, 104);
            this.txtJouniorBoss.Name = "txtJouniorBoss";
            this.txtJouniorBoss.Size = new System.Drawing.Size(191, 34);
            this.txtJouniorBoss.TabIndex = 1;
            // 
            // lblJouniorBoss
            // 
            this.lblJouniorBoss.AutoSize = true;
            this.lblJouniorBoss.Location = new System.Drawing.Point(300, 107);
            this.lblJouniorBoss.Name = "lblJouniorBoss";
            this.lblJouniorBoss.Size = new System.Drawing.Size(96, 26);
            this.lblJouniorBoss.TabIndex = 0;
            this.lblJouniorBoss.Text = "ف گر ورزش:";
            // 
            // txtBigBoss
            // 
            this.txtBoss.Location = new System.Drawing.Point(12, 64);
            this.txtBoss.Name = "txtBigBoss";
            this.txtBoss.Size = new System.Drawing.Size(191, 34);
            this.txtBoss.TabIndex = 1;
            // 
            // lblBigBoss
            // 
            this.lblBoss.AutoSize = true;
            this.lblBoss.Location = new System.Drawing.Point(238, 67);
            this.lblBoss.Name = "lblBigBoss";
            this.lblBoss.Size = new System.Drawing.Size(158, 26);
            this.lblBoss.TabIndex = 0;
            this.lblBoss.Text = "رئیس دایره مسابقات:";
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(12, 24);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(191, 34);
            this.txtManager.TabIndex = 1;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(209, 27);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(187, 26);
            this.lblManager.TabIndex = 0;
            this.lblManager.Text = "مدیریت تربیت‌بدنی نزاجا:";
            // 
            // frmSignatureDefinition
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 214);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Samim", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSignatureDefinition";
            this.Text = "سلسله مراتب دستور";
            this.Load += new System.EventHandler(this.frmSignatureDefinition_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtJouniorBoss;
        private System.Windows.Forms.Label lblJouniorBoss;
        private System.Windows.Forms.TextBox txtBoss;
        private System.Windows.Forms.Label lblBoss;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Button btnApply;
    }
}