namespace Graph
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gunaPanelLayout = new Guna.UI2.WinForms.Guna2Panel();
            drawTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            drawTTable = new TabPage();
            drawPolygonGbtn = new Guna.UI2.WinForms.Guna2Button();
            drawEllipseGbtn = new Guna.UI2.WinForms.Guna2Button();
            circleGbtn = new Guna.UI2.WinForms.Guna2Button();
            rectangleGbtn = new Guna.UI2.WinForms.Guna2Button();
            lineGbtn = new Guna.UI2.WinForms.Guna2Button();
            animationTp = new TabPage();
            mdiTabPage = new TabPage();
            kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            tSLTime = new ToolStripLabel();
            axWMPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStrMItem = new ToolStripMenuItem();
            exitToolSMItem = new ToolStripMenuItem();
            lightTimer = new System.Windows.Forms.Timer(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            pathToolStripMenuItem = new ToolStripMenuItem();
            timerPresent = new System.Windows.Forms.Timer(components);
            gunaPanelLayout.SuspendLayout();
            drawTabControl.SuspendLayout();
            drawTTable.SuspendLayout();
            mdiTabPage.SuspendLayout();
            kryptonToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWMPlayer).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gunaPanelLayout
            // 
            gunaPanelLayout.Controls.Add(drawTabControl);
            gunaPanelLayout.CustomizableEdges = customizableEdges11;
            gunaPanelLayout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gunaPanelLayout.Location = new Point(12, 12);
            gunaPanelLayout.Name = "gunaPanelLayout";
            gunaPanelLayout.ShadowDecoration.CustomizableEdges = customizableEdges12;
            gunaPanelLayout.Size = new Size(776, 426);
            gunaPanelLayout.TabIndex = 0;
            // 
            // drawTabControl
            // 
            drawTabControl.Alignment = TabAlignment.Left;
            drawTabControl.Controls.Add(drawTTable);
            drawTabControl.Controls.Add(animationTp);
            drawTabControl.Controls.Add(mdiTabPage);
            drawTabControl.ItemSize = new Size(180, 40);
            drawTabControl.Location = new Point(3, 3);
            drawTabControl.Name = "drawTabControl";
            drawTabControl.SelectedIndex = 0;
            drawTabControl.Size = new Size(770, 421);
            drawTabControl.TabButtonHoverState.BorderColor = Color.Empty;
            drawTabControl.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            drawTabControl.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            drawTabControl.TabButtonHoverState.ForeColor = Color.White;
            drawTabControl.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            drawTabControl.TabButtonIdleState.BorderColor = Color.Empty;
            drawTabControl.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            drawTabControl.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            drawTabControl.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            drawTabControl.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            drawTabControl.TabButtonSelectedState.BorderColor = Color.Empty;
            drawTabControl.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            drawTabControl.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            drawTabControl.TabButtonSelectedState.ForeColor = Color.White;
            drawTabControl.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            drawTabControl.TabButtonSize = new Size(180, 40);
            drawTabControl.TabIndex = 0;
            drawTabControl.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            // 
            // drawTTable
            // 
            drawTTable.Controls.Add(drawPolygonGbtn);
            drawTTable.Controls.Add(drawEllipseGbtn);
            drawTTable.Controls.Add(circleGbtn);
            drawTTable.Controls.Add(rectangleGbtn);
            drawTTable.Controls.Add(lineGbtn);
            drawTTable.Location = new Point(184, 4);
            drawTTable.Name = "drawTTable";
            drawTTable.Padding = new Padding(3);
            drawTTable.Size = new Size(582, 413);
            drawTTable.TabIndex = 0;
            drawTTable.Text = "Vẽ hình";
            drawTTable.UseVisualStyleBackColor = true;
            drawTTable.Paint += drawTTable_Paint;
            // 
            // drawPolygonGbtn
            // 
            drawPolygonGbtn.BorderRadius = 20;
            drawPolygonGbtn.CustomizableEdges = customizableEdges1;
            drawPolygonGbtn.DisabledState.BorderColor = Color.DarkGray;
            drawPolygonGbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            drawPolygonGbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            drawPolygonGbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            drawPolygonGbtn.Font = new Font("Times New Roman", 12F);
            drawPolygonGbtn.ForeColor = Color.White;
            drawPolygonGbtn.Location = new Point(448, 38);
            drawPolygonGbtn.Name = "drawPolygonGbtn";
            drawPolygonGbtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            drawPolygonGbtn.Size = new Size(99, 60);
            drawPolygonGbtn.TabIndex = 7;
            drawPolygonGbtn.Text = "Đa giác";
            drawPolygonGbtn.Click += drawPolygonGbtn_Click;
            // 
            // drawEllipseGbtn
            // 
            drawEllipseGbtn.BorderRadius = 20;
            drawEllipseGbtn.CustomizableEdges = customizableEdges3;
            drawEllipseGbtn.DisabledState.BorderColor = Color.DarkGray;
            drawEllipseGbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            drawEllipseGbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            drawEllipseGbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            drawEllipseGbtn.Font = new Font("Times New Roman", 12F);
            drawEllipseGbtn.ForeColor = Color.White;
            drawEllipseGbtn.Location = new Point(343, 38);
            drawEllipseGbtn.Name = "drawEllipseGbtn";
            drawEllipseGbtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            drawEllipseGbtn.Size = new Size(99, 60);
            drawEllipseGbtn.TabIndex = 6;
            drawEllipseGbtn.Text = "Ellipse";
            drawEllipseGbtn.Click += drawEllipseGbtn_Click;
            // 
            // circleGbtn
            // 
            circleGbtn.BorderRadius = 20;
            circleGbtn.CustomizableEdges = customizableEdges5;
            circleGbtn.DisabledState.BorderColor = Color.DarkGray;
            circleGbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            circleGbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            circleGbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            circleGbtn.Font = new Font("Times New Roman", 12F);
            circleGbtn.ForeColor = Color.White;
            circleGbtn.Location = new Point(238, 38);
            circleGbtn.Name = "circleGbtn";
            circleGbtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            circleGbtn.Size = new Size(99, 60);
            circleGbtn.TabIndex = 5;
            circleGbtn.Text = "Hình tròn";
            circleGbtn.Click += circleGbtn_Click;
            // 
            // rectangleGbtn
            // 
            rectangleGbtn.BorderRadius = 20;
            rectangleGbtn.CustomizableEdges = customizableEdges7;
            rectangleGbtn.DisabledState.BorderColor = Color.DarkGray;
            rectangleGbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            rectangleGbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            rectangleGbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            rectangleGbtn.Font = new Font("Times New Roman", 12F);
            rectangleGbtn.ForeColor = Color.White;
            rectangleGbtn.Location = new Point(133, 38);
            rectangleGbtn.Name = "rectangleGbtn";
            rectangleGbtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            rectangleGbtn.Size = new Size(99, 60);
            rectangleGbtn.TabIndex = 4;
            rectangleGbtn.Text = "Hình chữ nhật";
            rectangleGbtn.Click += rectangleGbtn_Click;
            // 
            // lineGbtn
            // 
            lineGbtn.BorderRadius = 20;
            lineGbtn.CustomizableEdges = customizableEdges9;
            lineGbtn.DisabledState.BorderColor = Color.DarkGray;
            lineGbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            lineGbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lineGbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lineGbtn.Font = new Font("Times New Roman", 12F);
            lineGbtn.ForeColor = Color.White;
            lineGbtn.Location = new Point(28, 38);
            lineGbtn.Name = "lineGbtn";
            lineGbtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            lineGbtn.Size = new Size(99, 60);
            lineGbtn.TabIndex = 3;
            lineGbtn.Text = "Đường thẳng";
            lineGbtn.Click += lineGbtn_Click_1;
            // 
            // animationTp
            // 
            animationTp.Location = new Point(184, 4);
            animationTp.Name = "animationTp";
            animationTp.Padding = new Padding(3);
            animationTp.Size = new Size(582, 413);
            animationTp.TabIndex = 2;
            animationTp.Text = "Animation";
            animationTp.UseVisualStyleBackColor = true;
            animationTp.Paint += animationTp_Paint;
            // 
            // mdiTabPage
            // 
            mdiTabPage.Controls.Add(kryptonToolStrip1);
            mdiTabPage.Controls.Add(axWMPlayer);
            mdiTabPage.Controls.Add(menuStrip1);
            mdiTabPage.Location = new Point(184, 4);
            mdiTabPage.Name = "mdiTabPage";
            mdiTabPage.Padding = new Padding(3);
            mdiTabPage.Size = new Size(582, 413);
            mdiTabPage.TabIndex = 3;
            mdiTabPage.Text = "MDI";
            mdiTabPage.UseVisualStyleBackColor = true;
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.Font = new Font("Segoe UI", 9F);
            kryptonToolStrip1.ImageScalingSize = new Size(20, 20);
            kryptonToolStrip1.Items.AddRange(new ToolStripItem[] { tSLTime });
            kryptonToolStrip1.Location = new Point(3, 31);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.Size = new Size(576, 25);
            kryptonToolStrip1.TabIndex = 2;
            kryptonToolStrip1.Text = "kryptonToolStrip1";
            // 
            // tSLTime
            // 
            tSLTime.Name = "tSLTime";
            tSLTime.Size = new Size(42, 22);
            tSLTime.Text = "Time";
            // 
            // axWMPlayer
            // 
            axWMPlayer.Enabled = true;
            axWMPlayer.Location = new Point(6, 61);
            axWMPlayer.Name = "axWMPlayer";
            axWMPlayer.OcxState = (AxHost.State)resources.GetObject("axWMPlayer.OcxState");
            axWMPlayer.Size = new Size(573, 346);
            axWMPlayer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(576, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStrMItem, exitToolSMItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStrMItem
            // 
            openToolStrMItem.Name = "openToolStrMItem";
            openToolStrMItem.Size = new Size(224, 26);
            openToolStrMItem.Text = "Open";
            openToolStrMItem.Click += openToolStrMItem_Click;
            // 
            // exitToolSMItem
            // 
            exitToolSMItem.Name = "exitToolSMItem";
            exitToolSMItem.Size = new Size(224, 26);
            exitToolSMItem.Text = "Exit";
            exitToolSMItem.Click += exitToolSMItem_Click;
            // 
            // lightTimer
            // 
            lightTimer.Tick += lightTimer_Tick;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // pathToolStripMenuItem
            // 
            pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            pathToolStripMenuItem.Size = new Size(128, 26);
            pathToolStripMenuItem.Text = "Path";
            // 
            // timerPresent
            // 
            timerPresent.Tick += timerPresent_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gunaPanelLayout);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gunaPanelLayout.ResumeLayout(false);
            drawTabControl.ResumeLayout(false);
            drawTTable.ResumeLayout(false);
            mdiTabPage.ResumeLayout(false);
            mdiTabPage.PerformLayout();
            kryptonToolStrip1.ResumeLayout(false);
            kryptonToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWMPlayer).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gunaPanelLayout;
        private Guna.UI2.WinForms.Guna2TabControl drawTabControl;
        private TabPage drawTTable;
        private Guna.UI2.WinForms.Guna2Button drawPolygonGbtn;
        private Guna.UI2.WinForms.Guna2Button drawEllipseGbtn;
        private Guna.UI2.WinForms.Guna2Button circleGbtn;
        private Guna.UI2.WinForms.Guna2Button rectangleGbtn;
        private Guna.UI2.WinForms.Guna2Button lineGbtn;
        private TabPage animationTp;
        private System.Windows.Forms.Timer lightTimer;
        private TabPage mdiTabPage;
        private AxWMPLib.AxWindowsMediaPlayer axWMPlayer;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem pathToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private ToolStripLabel tSLTime;
        private System.Windows.Forms.Timer timerPresent;
        private ToolStripMenuItem openToolStrMItem;
        private ToolStripMenuItem exitToolSMItem;
    }
}
