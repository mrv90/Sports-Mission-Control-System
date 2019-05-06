namespace smcs.frontend
{
    partial class frmMain
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.BasicDataMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.قسمتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.signatureDefinitionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.dataEntryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateOperationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeOperationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.missionExtensionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.آمارکلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آمارتفکیکشدهروزانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ملاحضاتروزانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آمارقسمتهابرایتابلوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.مرخصیمامورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشنهستمامورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مستثنیازآمارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.آمارمامورینقسمتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آمارمامورینیگانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.مامورینمستثناازآمارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تمدیدماموریتToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.پایانماموریتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.برنامهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لاگتغییراتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Samim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BasicDataMenu,
            this.OperationsMenu,
            this.ReportMenu,
            this.برنامهToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.mainMenu.Size = new System.Drawing.Size(780, 37);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // BasicDataMenu
            // 
            this.BasicDataMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.قسمتToolStripMenuItem,
            this.toolStripSeparator6,
            this.signatureDefinitionMenuItem});
            this.BasicDataMenu.Name = "BasicDataMenu";
            this.BasicDataMenu.Size = new System.Drawing.Size(103, 29);
            this.BasicDataMenu.Text = "داده‌های پایه";
            // 
            // قسمتToolStripMenuItem
            // 
            this.قسمتToolStripMenuItem.Name = "قسمتToolStripMenuItem";
            this.قسمتToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.قسمتToolStripMenuItem.Text = "رشته|قسمت";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(216, 6);
            // 
            // signatureDefinitionMenuItem
            // 
            this.signatureDefinitionMenuItem.Name = "signatureDefinitionMenuItem";
            this.signatureDefinitionMenuItem.Size = new System.Drawing.Size(219, 30);
            this.signatureDefinitionMenuItem.Text = "سلسله مراتب دستور";
            this.signatureDefinitionMenuItem.Click += new System.EventHandler(this.signatureDefinitionMenuItem_Click);
            // 
            // OperationsMenu
            // 
            this.OperationsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchMenuItem,
            this.toolStripSeparator8,
            this.dataEntryMenuItem,
            this.operationMenuItem,
            this.terminateOperationMenuItem,
            this.toolStripSeparator2,
            this.removeOperationMenuItem,
            this.toolStripSeparator1,
            this.missionExtensionMenuItem});
            this.OperationsMenu.Name = "OperationsMenu";
            this.OperationsMenu.Size = new System.Drawing.Size(69, 29);
            this.OperationsMenu.Text = "عملیات";
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.Size = new System.Drawing.Size(184, 30);
            this.searchMenuItem.Text = "جستجو";
            this.searchMenuItem.Click += new System.EventHandler(this.serchMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(181, 6);
            // 
            // dataEntryMenuItem
            // 
            this.dataEntryMenuItem.Name = "dataEntryMenuItem";
            this.dataEntryMenuItem.Size = new System.Drawing.Size(184, 30);
            this.dataEntryMenuItem.Text = "پذیرش|ویرایش";
            this.dataEntryMenuItem.Click += new System.EventHandler(this.dataEntryMenuItem_Click);
            // 
            // operationMenuItem
            // 
            this.operationMenuItem.Name = "operationMenuItem";
            this.operationMenuItem.Size = new System.Drawing.Size(184, 30);
            this.operationMenuItem.Text = "گردش‌کار";
            this.operationMenuItem.Click += new System.EventHandler(this.operationMenuItem_Click);
            // 
            // terminateOperationMenuItem
            // 
            this.terminateOperationMenuItem.Name = "terminateOperationMenuItem";
            this.terminateOperationMenuItem.Size = new System.Drawing.Size(184, 30);
            this.terminateOperationMenuItem.Text = "پایان";
            this.terminateOperationMenuItem.Click += new System.EventHandler(this.terminateOperationMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // removeOperationMenuItem
            // 
            this.removeOperationMenuItem.Name = "removeOperationMenuItem";
            this.removeOperationMenuItem.Size = new System.Drawing.Size(184, 30);
            this.removeOperationMenuItem.Text = "لغو عملیات";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // missionExtensionMenuItem
            // 
            this.missionExtensionMenuItem.Name = "missionExtensionMenuItem";
            this.missionExtensionMenuItem.Size = new System.Drawing.Size(184, 30);
            this.missionExtensionMenuItem.Text = "تمدید ماموریت";
            this.missionExtensionMenuItem.Click += new System.EventHandler(this.missionExtensionMenuItem_Click);
            // 
            // ReportMenu
            // 
            this.ReportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.آمارکلیToolStripMenuItem,
            this.آمارتفکیکشدهروزانهToolStripMenuItem,
            this.ملاحضاتروزانهToolStripMenuItem,
            this.آمارقسمتهابرایتابلوToolStripMenuItem,
            this.toolStripSeparator3,
            this.مرخصیمامورToolStripMenuItem,
            this.گزارشنهستمامورToolStripMenuItem,
            this.مستثنیازآمارToolStripMenuItem,
            this.toolStripSeparator4,
            this.آمارمامورینقسمتToolStripMenuItem,
            this.آمارمامورینیگانToolStripMenuItem,
            this.toolStripSeparator5,
            this.مامورینمستثناازآمارToolStripMenuItem,
            this.تمدیدماموریتToolStripMenuItem1,
            this.پایانماموریتToolStripMenuItem});
            this.ReportMenu.Name = "ReportMenu";
            this.ReportMenu.Size = new System.Drawing.Size(65, 29);
            this.ReportMenu.Text = "گزارش";
            // 
            // آمارکلیToolStripMenuItem
            // 
            this.آمارکلیToolStripMenuItem.Name = "آمارکلیToolStripMenuItem";
            this.آمارکلیToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.آمارکلیToolStripMenuItem.Text = "آمار کلی";
            // 
            // آمارتفکیکشدهروزانهToolStripMenuItem
            // 
            this.آمارتفکیکشدهروزانهToolStripMenuItem.Name = "آمارتفکیکشدهروزانهToolStripMenuItem";
            this.آمارتفکیکشدهروزانهToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.آمارتفکیکشدهروزانهToolStripMenuItem.Text = "آمار به تفکیک قسمت";
            // 
            // ملاحضاتروزانهToolStripMenuItem
            // 
            this.ملاحضاتروزانهToolStripMenuItem.Name = "ملاحضاتروزانهToolStripMenuItem";
            this.ملاحضاتروزانهToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.ملاحضاتروزانهToolStripMenuItem.Text = "ملاحضات";
            // 
            // آمارقسمتهابرایتابلوToolStripMenuItem
            // 
            this.آمارقسمتهابرایتابلوToolStripMenuItem.Name = "آمارقسمتهابرایتابلوToolStripMenuItem";
            this.آمارقسمتهابرایتابلوToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.آمارقسمتهابرایتابلوToolStripMenuItem.Text = "آمار قسمت‌ها (تابلو)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // مرخصیمامورToolStripMenuItem
            // 
            this.مرخصیمامورToolStripMenuItem.Name = "مرخصیمامورToolStripMenuItem";
            this.مرخصیمامورToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.مرخصیمامورToolStripMenuItem.Text = "مرخصی";
            // 
            // گزارشنهستمامورToolStripMenuItem
            // 
            this.گزارشنهستمامورToolStripMenuItem.Name = "گزارشنهستمامورToolStripMenuItem";
            this.گزارشنهستمامورToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.گزارشنهستمامورToolStripMenuItem.Text = "نهست";
            // 
            // مستثنیازآمارToolStripMenuItem
            // 
            this.مستثنیازآمارToolStripMenuItem.Name = "مستثنیازآمارToolStripMenuItem";
            this.مستثنیازآمارToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.مستثنیازآمارToolStripMenuItem.Text = "مستثنی‌ از آمار";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // آمارمامورینقسمتToolStripMenuItem
            // 
            this.آمارمامورینقسمتToolStripMenuItem.Name = "آمارمامورینقسمتToolStripMenuItem";
            this.آمارمامورینقسمتToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.آمارمامورینقسمتToolStripMenuItem.Text = "آمار مامورین قسمت";
            // 
            // آمارمامورینیگانToolStripMenuItem
            // 
            this.آمارمامورینیگانToolStripMenuItem.Name = "آمارمامورینیگانToolStripMenuItem";
            this.آمارمامورینیگانToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.آمارمامورینیگانToolStripMenuItem.Text = "آمار مامورین یگان";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // مامورینمستثناازآمارToolStripMenuItem
            // 
            this.مامورینمستثناازآمارToolStripMenuItem.Name = "مامورینمستثناازآمارToolStripMenuItem";
            this.مامورینمستثناازآمارToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.مامورینمستثناازآمارToolStripMenuItem.Text = "مامورین مستثنا از آمار";
            // 
            // تمدیدماموریتToolStripMenuItem1
            // 
            this.تمدیدماموریتToolStripMenuItem1.Name = "تمدیدماموریتToolStripMenuItem1";
            this.تمدیدماموریتToolStripMenuItem1.Size = new System.Drawing.Size(224, 30);
            this.تمدیدماموریتToolStripMenuItem1.Text = "تمدید ماموریت";
            // 
            // پایانماموریتToolStripMenuItem
            // 
            this.پایانماموریتToolStripMenuItem.Name = "پایانماموریتToolStripMenuItem";
            this.پایانماموریتToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.پایانماموریتToolStripMenuItem.Text = "پایان ماموریت";
            // 
            // برنامهToolStripMenuItem
            // 
            this.برنامهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.لاگتغییراتToolStripMenuItem});
            this.برنامهToolStripMenuItem.Name = "برنامهToolStripMenuItem";
            this.برنامهToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.برنامهToolStripMenuItem.Text = "برنامه";
            // 
            // لاگتغییراتToolStripMenuItem
            // 
            this.لاگتغییراتToolStripMenuItem.Name = "لاگتغییراتToolStripMenuItem";
            this.لاگتغییراتToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.لاگتغییراتToolStripMenuItem.Text = "لاگ تغییرات";
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVersion.Font = new System.Drawing.Font("Samim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(0, 37);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(780, 25);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "v0.10-13970928";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Samim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(11, 19);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(138, 24);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "امیر‌رحمتی";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Samim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(153, 18);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(622, 24);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "کاربر گرامی خوش آمدید!";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 528);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Samim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem OperationsMenu;
        private System.Windows.Forms.ToolStripMenuItem searchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missionExtensionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportMenu;
        private System.Windows.Forms.ToolStripMenuItem آمارکلیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem آمارتفکیکشدهروزانهToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem مرخصیمامورToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشنهستمامورToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem آمارمامورینقسمتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem آمارمامورینیگانToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem تمدیدماموریتToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BasicDataMenu;
        private System.Windows.Forms.ToolStripMenuItem قسمتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ملاحضاتروزانهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem آمارقسمتهابرایتابلوToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem مامورینمستثناازآمارToolStripMenuItem;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem برنامهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لاگتغییراتToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem dataEntryMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem پایانماموریتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signatureDefinitionMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem removeOperationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateOperationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مستثنیازآمارToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

