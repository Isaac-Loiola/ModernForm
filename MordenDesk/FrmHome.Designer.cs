namespace MordenDesk
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btnHam = new PictureBox();
            flpSidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            flpMenu = new FlowLayoutPanel();
            panel3 = new Panel();
            btnMenu = new Button();
            panel7 = new Panel();
            btnSubMenu01 = new Button();
            panel6 = new Panel();
            btnSubMenu02 = new Button();
            btnSetting = new Panel();
            btnSettings = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sideBarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            flpSidebar.SuspendLayout();
            panel2.SuspendLayout();
            flpMenu.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            btnSetting.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 43);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(876, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 16);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 2;
            label1.Text = "MORDERN FORM";
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(12, 10);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(36, 26);
            btnHam.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // flpSidebar
            // 
            flpSidebar.BackColor = Color.Black;
            flpSidebar.Controls.Add(panel2);
            flpSidebar.Controls.Add(flpMenu);
            flpSidebar.Controls.Add(btnSetting);
            flpSidebar.Controls.Add(panel4);
            flpSidebar.Controls.Add(panel5);
            flpSidebar.Dock = DockStyle.Left;
            flpSidebar.Location = new Point(0, 43);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Size = new Size(193, 554);
            flpSidebar.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 15);
            panel2.Margin = new Padding(0, 15, 0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 42);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Mont Heavy DEMO", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(3, 0);
            button1.Name = "button1";
            button1.Size = new Size(187, 42);
            button1.TabIndex = 3;
            button1.Text = "             DashBoard";
            button1.UseVisualStyleBackColor = false;
            // 
            // flpMenu
            // 
            flpMenu.BackColor = Color.Black;
            flpMenu.Controls.Add(panel3);
            flpMenu.Controls.Add(panel7);
            flpMenu.Controls.Add(panel6);
            flpMenu.Location = new Point(0, 57);
            flpMenu.Margin = new Padding(0);
            flpMenu.Name = "flpMenu";
            flpMenu.Size = new Size(187, 42);
            flpMenu.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(btnMenu);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 42);
            panel3.TabIndex = 2;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Black;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Mont Heavy DEMO", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(3, 0);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(187, 42);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "             Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += button2_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaptionText;
            panel7.Controls.Add(btnSubMenu01);
            panel7.Location = new Point(0, 42);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(190, 42);
            panel7.TabIndex = 2;
            // 
            // btnSubMenu01
            // 
            btnSubMenu01.BackColor = Color.Black;
            btnSubMenu01.FlatAppearance.BorderSize = 0;
            btnSubMenu01.FlatStyle = FlatStyle.Flat;
            btnSubMenu01.Font = new Font("Mont Heavy DEMO", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubMenu01.ForeColor = Color.White;
            btnSubMenu01.Image = (Image)resources.GetObject("btnSubMenu01.Image");
            btnSubMenu01.Location = new Point(-6, -1);
            btnSubMenu01.Margin = new Padding(0);
            btnSubMenu01.Name = "btnSubMenu01";
            btnSubMenu01.Size = new Size(202, 42);
            btnSubMenu01.TabIndex = 3;
            btnSubMenu01.Text = "             Sub menu";
            btnSubMenu01.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Controls.Add(btnSubMenu02);
            panel6.Location = new Point(0, 84);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(190, 42);
            panel6.TabIndex = 2;
            // 
            // btnSubMenu02
            // 
            btnSubMenu02.BackColor = Color.Black;
            btnSubMenu02.FlatAppearance.BorderSize = 0;
            btnSubMenu02.FlatStyle = FlatStyle.Flat;
            btnSubMenu02.Font = new Font("Mont Heavy DEMO", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubMenu02.ForeColor = Color.White;
            btnSubMenu02.Image = (Image)resources.GetObject("btnSubMenu02.Image");
            btnSubMenu02.Location = new Point(0, 0);
            btnSubMenu02.Margin = new Padding(0);
            btnSubMenu02.Name = "btnSubMenu02";
            btnSubMenu02.Size = new Size(190, 42);
            btnSubMenu02.TabIndex = 3;
            btnSubMenu02.Text = "             Sub menu";
            btnSubMenu02.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = SystemColors.ActiveCaptionText;
            btnSetting.Controls.Add(btnSettings);
            btnSetting.Location = new Point(0, 99);
            btnSetting.Margin = new Padding(0);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(190, 42);
            btnSetting.TabIndex = 2;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Black;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Mont Heavy DEMO", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new Point(3, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(187, 42);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "             Settings";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(button3);
            panel4.Location = new Point(0, 141);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 42);
            panel4.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Mont Heavy DEMO", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(190, 42);
            button3.TabIndex = 3;
            button3.Text = "             About";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(button4);
            panel5.Location = new Point(0, 183);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(190, 42);
            panel5.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Mont Heavy DEMO", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(190, 42);
            button4.TabIndex = 3;
            button4.Text = "             Logout";
            button4.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 1;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sideBarTransition
            // 
            sideBarTransition.Interval = 10;
            sideBarTransition.Tick += sideBarTransition_Tick;
            // 
            // FrmHome
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1015, 597);
            Controls.Add(flpSidebar);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            flpSidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flpMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            btnSetting.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnHam;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flpSidebar;
        private Panel panel2;
        private Button button1;
        private Panel btnSetting;
        private Button btnSettings;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private FlowLayoutPanel flpMenu;
        private Panel panel3;
        private Button btnMenu;
        private Panel panel6;
        private Button btnSubMenu02;
        private Panel panel7;
        private Button btnSubMenu01;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sideBarTransition;
    }
}
