namespace FamilyTree.UI
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnYearlyReport = new System.Windows.Forms.Button();
            this.panelSubMemberDeaths = new System.Windows.Forms.Panel();
            this.btnAddMemberDeath = new System.Windows.Forms.Button();
            this.btnListMemberDeath = new System.Windows.Forms.Button();
            this.btnMemberDeath = new System.Windows.Forms.Button();
            this.btnAddMemberAchivement = new System.Windows.Forms.Button();
            this.panelSubMember = new System.Windows.Forms.Panel();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnListMembers = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSubMemberDeaths.SuspendLayout();
            this.panelSubMember.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panelSideMenu.Controls.Add(this.pictureBox2);
            this.panelSideMenu.Controls.Add(this.btnYearlyReport);
            this.panelSideMenu.Controls.Add(this.panelSubMemberDeaths);
            this.panelSideMenu.Controls.Add(this.btnMemberDeath);
            this.panelSideMenu.Controls.Add(this.btnAddMemberAchivement);
            this.panelSideMenu.Controls.Add(this.panelSubMember);
            this.panelSideMenu.Controls.Add(this.btnMembers);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(196, 490);
            this.panelSideMenu.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(161, 459);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 31);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnYearlyReport
            // 
            this.btnYearlyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnYearlyReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYearlyReport.FlatAppearance.BorderSize = 0;
            this.btnYearlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearlyReport.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearlyReport.ForeColor = System.Drawing.Color.White;
            this.btnYearlyReport.Location = new System.Drawing.Point(0, 341);
            this.btnYearlyReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYearlyReport.Name = "btnYearlyReport";
            this.btnYearlyReport.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnYearlyReport.Size = new System.Drawing.Size(196, 37);
            this.btnYearlyReport.TabIndex = 16;
            this.btnYearlyReport.Text = "Báo cáo năm";
            this.btnYearlyReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYearlyReport.UseVisualStyleBackColor = false;
            this.btnYearlyReport.Click += new System.EventHandler(this.btnYearlyReport_Click);
            // 
            // panelSubMemberDeaths
            // 
            this.panelSubMemberDeaths.BackColor = System.Drawing.Color.LightGreen;
            this.panelSubMemberDeaths.Controls.Add(this.btnAddMemberDeath);
            this.panelSubMemberDeaths.Controls.Add(this.btnListMemberDeath);
            this.panelSubMemberDeaths.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMemberDeaths.Location = new System.Drawing.Point(0, 276);
            this.panelSubMemberDeaths.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSubMemberDeaths.Name = "panelSubMemberDeaths";
            this.panelSubMemberDeaths.Size = new System.Drawing.Size(196, 65);
            this.panelSubMemberDeaths.TabIndex = 14;
            // 
            // btnAddMemberDeath
            // 
            this.btnAddMemberDeath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddMemberDeath.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMemberDeath.FlatAppearance.BorderSize = 0;
            this.btnAddMemberDeath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMemberDeath.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMemberDeath.ForeColor = System.Drawing.Color.White;
            this.btnAddMemberDeath.Location = new System.Drawing.Point(0, 32);
            this.btnAddMemberDeath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMemberDeath.Name = "btnAddMemberDeath";
            this.btnAddMemberDeath.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnAddMemberDeath.Size = new System.Drawing.Size(196, 32);
            this.btnAddMemberDeath.TabIndex = 20;
            this.btnAddMemberDeath.Text = "Ghi nhận kết thúc";
            this.btnAddMemberDeath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMemberDeath.UseVisualStyleBackColor = false;
            this.btnAddMemberDeath.Click += new System.EventHandler(this.btnAddMemberDeath_Click);
            // 
            // btnListMemberDeath
            // 
            this.btnListMemberDeath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnListMemberDeath.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListMemberDeath.FlatAppearance.BorderSize = 0;
            this.btnListMemberDeath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListMemberDeath.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMemberDeath.ForeColor = System.Drawing.Color.White;
            this.btnListMemberDeath.Location = new System.Drawing.Point(0, 0);
            this.btnListMemberDeath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListMemberDeath.Name = "btnListMemberDeath";
            this.btnListMemberDeath.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnListMemberDeath.Size = new System.Drawing.Size(196, 32);
            this.btnListMemberDeath.TabIndex = 18;
            this.btnListMemberDeath.Text = "Danh sách kết thúc";
            this.btnListMemberDeath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListMemberDeath.UseVisualStyleBackColor = false;
            this.btnListMemberDeath.Click += new System.EventHandler(this.btnListMemberDeath_Click);
            // 
            // btnMemberDeath
            // 
            this.btnMemberDeath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnMemberDeath.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberDeath.FlatAppearance.BorderSize = 0;
            this.btnMemberDeath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberDeath.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberDeath.ForeColor = System.Drawing.Color.White;
            this.btnMemberDeath.Location = new System.Drawing.Point(0, 239);
            this.btnMemberDeath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMemberDeath.Name = "btnMemberDeath";
            this.btnMemberDeath.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnMemberDeath.Size = new System.Drawing.Size(196, 37);
            this.btnMemberDeath.TabIndex = 13;
            this.btnMemberDeath.Text = "Kết thúc";
            this.btnMemberDeath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberDeath.UseVisualStyleBackColor = false;
            this.btnMemberDeath.Click += new System.EventHandler(this.btnMemberDeath_Click);
            // 
            // btnAddMemberAchivement
            // 
            this.btnAddMemberAchivement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddMemberAchivement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMemberAchivement.FlatAppearance.BorderSize = 0;
            this.btnAddMemberAchivement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMemberAchivement.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMemberAchivement.ForeColor = System.Drawing.Color.White;
            this.btnAddMemberAchivement.Location = new System.Drawing.Point(0, 202);
            this.btnAddMemberAchivement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMemberAchivement.Name = "btnAddMemberAchivement";
            this.btnAddMemberAchivement.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAddMemberAchivement.Size = new System.Drawing.Size(196, 37);
            this.btnAddMemberAchivement.TabIndex = 12;
            this.btnAddMemberAchivement.Text = "Ghi nhận thành tích";
            this.btnAddMemberAchivement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMemberAchivement.UseVisualStyleBackColor = false;
            this.btnAddMemberAchivement.Click += new System.EventHandler(this.btnAddMemberAchivement_Click);
            // 
            // panelSubMember
            // 
            this.panelSubMember.BackColor = System.Drawing.Color.LightGreen;
            this.panelSubMember.Controls.Add(this.btnAddMember);
            this.panelSubMember.Controls.Add(this.btnListMembers);
            this.panelSubMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMember.Location = new System.Drawing.Point(0, 137);
            this.panelSubMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSubMember.Name = "panelSubMember";
            this.panelSubMember.Size = new System.Drawing.Size(196, 65);
            this.panelSubMember.TabIndex = 11;
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Location = new System.Drawing.Point(0, 32);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnAddMember.Size = new System.Drawing.Size(196, 32);
            this.btnAddMember.TabIndex = 18;
            this.btnAddMember.Text = "Tiếp nhận thành viên";
            this.btnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnListMembers
            // 
            this.btnListMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnListMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListMembers.FlatAppearance.BorderSize = 0;
            this.btnListMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListMembers.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMembers.ForeColor = System.Drawing.Color.White;
            this.btnListMembers.Location = new System.Drawing.Point(0, 0);
            this.btnListMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListMembers.Name = "btnListMembers";
            this.btnListMembers.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnListMembers.Size = new System.Drawing.Size(196, 32);
            this.btnListMembers.TabIndex = 17;
            this.btnListMembers.Text = "Danh sách thành viên";
            this.btnListMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListMembers.UseVisualStyleBackColor = false;
            this.btnListMembers.Click += new System.EventHandler(this.btnListMembers_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.Location = new System.Drawing.Point(0, 100);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnMembers.Size = new System.Drawing.Size(196, 37);
            this.btnMembers.TabIndex = 10;
            this.btnMembers.Text = "Thành viên";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 19);
            this.panel1.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.AllowAnimations = true;
            this.btnSearch.AllowMouseEffects = true;
            this.btnSearch.AllowToggling = false;
            this.btnSearch.AnimationSpeed = 200;
            this.btnSearch.AutoGenerateColors = false;
            this.btnSearch.AutoRoundBorders = false;
            this.btnSearch.AutoSizeLeftIcon = true;
            this.btnSearch.AutoSizeRightIcon = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackColor1 = System.Drawing.Color.LightPink;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.ButtonText = "Tìm kiếm";
            this.btnSearch.ButtonTextMarginLeft = 0;
            this.btnSearch.ColorContrastOnClick = 45;
            this.btnSearch.ColorContrastOnHover = 45;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSearch.CustomizableEdges = borderEdges1;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSearch.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSearch.IconMarginLeft = 11;
            this.btnSearch.IconPadding = 10;
            this.btnSearch.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSearch.IconSize = 25;
            this.btnSearch.IdleBorderColor = System.Drawing.Color.MediumOrchid;
            this.btnSearch.IdleBorderRadius = 1;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleFillColor = System.Drawing.Color.LightPink;
            this.btnSearch.IdleIconLeftImage = null;
            this.btnSearch.IdleIconRightImage = null;
            this.btnSearch.IndicateFocus = false;
            this.btnSearch.Location = new System.Drawing.Point(138, -1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.OnDisabledState.BorderRadius = 1;
            this.btnSearch.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnDisabledState.BorderThickness = 1;
            this.btnSearch.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.OnDisabledState.IconLeftImage = null;
            this.btnSearch.OnDisabledState.IconRightImage = null;
            this.btnSearch.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSearch.onHoverState.BorderRadius = 1;
            this.btnSearch.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.onHoverState.BorderThickness = 1;
            this.btnSearch.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSearch.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.onHoverState.IconLeftImage = null;
            this.btnSearch.onHoverState.IconRightImage = null;
            this.btnSearch.OnIdleState.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btnSearch.OnIdleState.BorderRadius = 1;
            this.btnSearch.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnIdleState.BorderThickness = 1;
            this.btnSearch.OnIdleState.FillColor = System.Drawing.Color.LightPink;
            this.btnSearch.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnIdleState.IconLeftImage = null;
            this.btnSearch.OnIdleState.IconRightImage = null;
            this.btnSearch.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSearch.OnPressedState.BorderRadius = 1;
            this.btnSearch.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnPressedState.BorderThickness = 1;
            this.btnSearch.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSearch.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnPressedState.IconLeftImage = null;
            this.btnSearch.OnPressedState.IconRightImage = null;
            this.btnSearch.Size = new System.Drawing.Size(58, 21);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.TextMarginLeft = 0;
            this.btnSearch.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSearch.UseDefaultRadiusAndThickness = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(196, 20);
            this.tbSearch.TabIndex = 8;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(196, 81);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Moccasin;
            this.panelChildForm.Controls.Add(this.pbClose);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(196, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(578, 490);
            this.panelChildForm.TabIndex = 1;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.White;
            this.pbClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbClose.BackgroundImage")));
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbClose.Location = new System.Drawing.Point(554, 3);
            this.pbClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(22, 24);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 14;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 490);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeScreen";
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSubMemberDeaths.ResumeLayout(false);
            this.panelSubMember.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnMemberDeath;
        private System.Windows.Forms.Button btnAddMemberAchivement;
        private System.Windows.Forms.Panel panelSubMember;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnYearlyReport;
        private System.Windows.Forms.Panel panelSubMemberDeaths;
        private System.Windows.Forms.Button btnListMemberDeath;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnListMembers;
        private System.Windows.Forms.Button btnAddMemberDeath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearch;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}