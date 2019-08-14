namespace COMP123_S2019_FinalTestC.Views
{
    partial class CharacterGenerationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterGenerationForm));
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CharacterSheetPage = new System.Windows.Forms.TabPage();
            this.CharecterMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharecterToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.SkillsPage = new System.Windows.Forms.TabPage();
            this.SkillsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.DriveLabel = new System.Windows.Forms.Label();
            this.ArtLabel = new System.Windows.Forms.Label();
            this.AnimalLabel = new System.Windows.Forms.Label();
            this.GenerateSkillsButton = new System.Windows.Forms.Button();
            this.AbilityPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SocialStandingDataLabel = new System.Windows.Forms.Label();
            this.EducationDataLabel = new System.Windows.Forms.Label();
            this.IntellectDataLabel = new System.Windows.Forms.Label();
            this.EnduranceDataLabel = new System.Windows.Forms.Label();
            this.DexterityDataLabel = new System.Windows.Forms.Label();
            this.SocialStandingLabel = new System.Windows.Forms.Label();
            this.EducationLabel = new System.Windows.Forms.Label();
            this.IntellectLabel = new System.Windows.Forms.Label();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.GenerateAbilitiesButton = new System.Windows.Forms.Button();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.IdentityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.label6 = new System.Windows.Forms.Label();
            this.CharacterSheetPage.SuspendLayout();
            this.CharecterMenuStrip.SuspendLayout();
            this.CharecterToolStrip.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SkillsPage.SuspendLayout();
            this.SkillsTableLayoutPanel.SuspendLayout();
            this.AbilityPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.IdentityTableLayoutPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(405, 352);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(88, 47);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(10, 352);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(88, 47);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CharacterSheetPage
            // 
            this.CharacterSheetPage.Controls.Add(this.CharecterToolStrip);
            this.CharacterSheetPage.Controls.Add(this.tableLayoutPanel3);
            this.CharacterSheetPage.Controls.Add(this.CharecterMenuStrip);
            this.CharacterSheetPage.Location = new System.Drawing.Point(4, 33);
            this.CharacterSheetPage.Margin = new System.Windows.Forms.Padding(2);
            this.CharacterSheetPage.Name = "CharacterSheetPage";
            this.CharacterSheetPage.Size = new System.Drawing.Size(495, 298);
            this.CharacterSheetPage.TabIndex = 3;
            this.CharacterSheetPage.Text = "Character Sheet";
            this.CharacterSheetPage.UseVisualStyleBackColor = true;
            // 
            // CharecterMenuStrip
            // 
            this.CharecterMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.CharecterMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CharecterMenuStrip.Name = "CharecterMenuStrip";
            this.CharecterMenuStrip.Size = new System.Drawing.Size(495, 24);
            this.CharecterMenuStrip.TabIndex = 0;
            this.CharecterMenuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // CharecterToolStrip
            // 
            this.CharecterToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.helpToolStripButton});
            this.CharecterToolStrip.Location = new System.Drawing.Point(0, 24);
            this.CharecterToolStrip.Name = "CharecterToolStrip";
            this.CharecterToolStrip.Size = new System.Drawing.Size(495, 25);
            this.CharecterToolStrip.TabIndex = 1;
            this.CharecterToolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 52);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(481, 200);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "Identity";
            // 
            // SkillsPage
            // 
            this.SkillsPage.Controls.Add(this.SkillsTableLayoutPanel);
            this.SkillsPage.Location = new System.Drawing.Point(4, 33);
            this.SkillsPage.Margin = new System.Windows.Forms.Padding(2);
            this.SkillsPage.Name = "SkillsPage";
            this.SkillsPage.Size = new System.Drawing.Size(495, 298);
            this.SkillsPage.TabIndex = 2;
            this.SkillsPage.Text = "Skills";
            this.SkillsPage.UseVisualStyleBackColor = true;
            // 
            // SkillsTableLayoutPanel
            // 
            this.SkillsTableLayoutPanel.ColumnCount = 4;
            this.SkillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SkillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SkillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SkillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SkillsTableLayoutPanel.Controls.Add(this.GenerateSkillsButton, 2, 3);
            this.SkillsTableLayoutPanel.Controls.Add(this.AnimalLabel, 0, 0);
            this.SkillsTableLayoutPanel.Controls.Add(this.ArtLabel, 1, 0);
            this.SkillsTableLayoutPanel.Controls.Add(this.DriveLabel, 2, 0);
            this.SkillsTableLayoutPanel.Controls.Add(this.LanguageLabel, 3, 0);
            this.SkillsTableLayoutPanel.Location = new System.Drawing.Point(9, 4);
            this.SkillsTableLayoutPanel.Name = "SkillsTableLayoutPanel";
            this.SkillsTableLayoutPanel.RowCount = 4;
            this.SkillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SkillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SkillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SkillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SkillsTableLayoutPanel.Size = new System.Drawing.Size(478, 279);
            this.SkillsTableLayoutPanel.TabIndex = 0;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LanguageLabel.Location = new System.Drawing.Point(360, 0);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(115, 69);
            this.LanguageLabel.TabIndex = 0;
            this.LanguageLabel.Text = "Animal";
            // 
            // DriveLabel
            // 
            this.DriveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DriveLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DriveLabel.Location = new System.Drawing.Point(241, 0);
            this.DriveLabel.Name = "DriveLabel";
            this.DriveLabel.Size = new System.Drawing.Size(113, 69);
            this.DriveLabel.TabIndex = 0;
            this.DriveLabel.Text = "Drive";
            // 
            // ArtLabel
            // 
            this.ArtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArtLabel.Location = new System.Drawing.Point(122, 0);
            this.ArtLabel.Name = "ArtLabel";
            this.ArtLabel.Size = new System.Drawing.Size(113, 69);
            this.ArtLabel.TabIndex = 0;
            this.ArtLabel.Text = "Art";
            // 
            // AnimalLabel
            // 
            this.AnimalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnimalLabel.Location = new System.Drawing.Point(3, 0);
            this.AnimalLabel.Name = "AnimalLabel";
            this.AnimalLabel.Size = new System.Drawing.Size(113, 69);
            this.AnimalLabel.TabIndex = 0;
            this.AnimalLabel.Text = "Animal";
            // 
            // GenerateSkillsButton
            // 
            this.GenerateSkillsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkillsTableLayoutPanel.SetColumnSpan(this.GenerateSkillsButton, 2);
            this.GenerateSkillsButton.Location = new System.Drawing.Point(240, 209);
            this.GenerateSkillsButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateSkillsButton.Name = "GenerateSkillsButton";
            this.GenerateSkillsButton.Size = new System.Drawing.Size(236, 68);
            this.GenerateSkillsButton.TabIndex = 3;
            this.GenerateSkillsButton.Text = "Generate Skills";
            this.GenerateSkillsButton.UseVisualStyleBackColor = true;
            this.GenerateSkillsButton.Click += new System.EventHandler(this.GenerateSkillsButton_Click);
            // 
            // AbilityPage
            // 
            this.AbilityPage.Controls.Add(this.tableLayoutPanel1);
            this.AbilityPage.Location = new System.Drawing.Point(4, 33);
            this.AbilityPage.Margin = new System.Windows.Forms.Padding(2);
            this.AbilityPage.Name = "AbilityPage";
            this.AbilityPage.Padding = new System.Windows.Forms.Padding(2);
            this.AbilityPage.Size = new System.Drawing.Size(495, 298);
            this.AbilityPage.TabIndex = 1;
            this.AbilityPage.Text = "Abilities";
            this.AbilityPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.StrengthDataLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DexterityLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StrengthLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GenerateAbilitiesButton, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.EnduranceLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IntellectLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EducationLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SocialStandingLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.DexterityDataLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EnduranceDataLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.IntellectDataLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EducationDataLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.SocialStandingDataLabel, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(483, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SocialStandingDataLabel
            // 
            this.SocialStandingDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialStandingDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SocialStandingDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SocialStandingDataLabel.Location = new System.Drawing.Point(171, 180);
            this.SocialStandingDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SocialStandingDataLabel.Name = "SocialStandingDataLabel";
            this.SocialStandingDataLabel.Size = new System.Drawing.Size(92, 36);
            this.SocialStandingDataLabel.TabIndex = 12;
            this.SocialStandingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EducationDataLabel
            // 
            this.EducationDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EducationDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EducationDataLabel.Location = new System.Drawing.Point(171, 144);
            this.EducationDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EducationDataLabel.Name = "EducationDataLabel";
            this.EducationDataLabel.Size = new System.Drawing.Size(92, 36);
            this.EducationDataLabel.TabIndex = 11;
            this.EducationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IntellectDataLabel
            // 
            this.IntellectDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntellectDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntellectDataLabel.Location = new System.Drawing.Point(171, 108);
            this.IntellectDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntellectDataLabel.Name = "IntellectDataLabel";
            this.IntellectDataLabel.Size = new System.Drawing.Size(92, 36);
            this.IntellectDataLabel.TabIndex = 10;
            this.IntellectDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnduranceDataLabel
            // 
            this.EnduranceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnduranceDataLabel.Location = new System.Drawing.Point(171, 72);
            this.EnduranceDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnduranceDataLabel.Name = "EnduranceDataLabel";
            this.EnduranceDataLabel.Size = new System.Drawing.Size(92, 36);
            this.EnduranceDataLabel.TabIndex = 9;
            this.EnduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DexterityDataLabel
            // 
            this.DexterityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DexterityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DexterityDataLabel.Location = new System.Drawing.Point(171, 36);
            this.DexterityDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DexterityDataLabel.Name = "DexterityDataLabel";
            this.DexterityDataLabel.Size = new System.Drawing.Size(92, 36);
            this.DexterityDataLabel.TabIndex = 8;
            this.DexterityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SocialStandingLabel
            // 
            this.SocialStandingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialStandingLabel.Location = new System.Drawing.Point(2, 180);
            this.SocialStandingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SocialStandingLabel.Name = "SocialStandingLabel";
            this.SocialStandingLabel.Size = new System.Drawing.Size(165, 36);
            this.SocialStandingLabel.TabIndex = 5;
            this.SocialStandingLabel.Text = "Social Standing";
            this.SocialStandingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EducationLabel
            // 
            this.EducationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationLabel.Location = new System.Drawing.Point(2, 144);
            this.EducationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EducationLabel.Name = "EducationLabel";
            this.EducationLabel.Size = new System.Drawing.Size(165, 36);
            this.EducationLabel.TabIndex = 4;
            this.EducationLabel.Text = "Education";
            this.EducationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IntellectLabel
            // 
            this.IntellectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectLabel.Location = new System.Drawing.Point(2, 108);
            this.IntellectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntellectLabel.Name = "IntellectLabel";
            this.IntellectLabel.Size = new System.Drawing.Size(165, 36);
            this.IntellectLabel.TabIndex = 3;
            this.IntellectLabel.Text = "Intellect";
            this.IntellectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceLabel.Location = new System.Drawing.Point(2, 72);
            this.EnduranceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(165, 36);
            this.EnduranceLabel.TabIndex = 7;
            this.EnduranceLabel.Text = "Endurance";
            this.EnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateAbilitiesButton
            // 
            this.GenerateAbilitiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.GenerateAbilitiesButton, 2);
            this.GenerateAbilitiesButton.Location = new System.Drawing.Point(267, 254);
            this.GenerateAbilitiesButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateAbilitiesButton.Name = "GenerateAbilitiesButton";
            this.GenerateAbilitiesButton.Size = new System.Drawing.Size(214, 36);
            this.GenerateAbilitiesButton.TabIndex = 2;
            this.GenerateAbilitiesButton.Text = "Generate Abilities";
            this.GenerateAbilitiesButton.UseVisualStyleBackColor = true;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabel.Location = new System.Drawing.Point(2, 0);
            this.StrengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(165, 36);
            this.StrengthLabel.TabIndex = 2;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityLabel.Location = new System.Drawing.Point(2, 36);
            this.DexterityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(165, 36);
            this.DexterityLabel.TabIndex = 6;
            this.DexterityLabel.Text = "Dexterity";
            this.DexterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(171, 0);
            this.StrengthDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(92, 36);
            this.StrengthDataLabel.TabIndex = 2;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.IdentityTableLayoutPanel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 33);
            this.IdentityPage.Margin = new System.Windows.Forms.Padding(2);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(2);
            this.IdentityPage.Size = new System.Drawing.Size(495, 298);
            this.IdentityPage.TabIndex = 0;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // IdentityTableLayoutPanel
            // 
            this.IdentityTableLayoutPanel.ColumnCount = 4;
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameLabel, 0, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.GenerateNameButton, 2, 3);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameLabel, 0, 1);
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameDataLabel, 1, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameDataLabel, 1, 1);
            this.IdentityTableLayoutPanel.Location = new System.Drawing.Point(5, 5);
            this.IdentityTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.IdentityTableLayoutPanel.Name = "IdentityTableLayoutPanel";
            this.IdentityTableLayoutPanel.RowCount = 4;
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.Size = new System.Drawing.Size(486, 241);
            this.IdentityTableLayoutPanel.TabIndex = 0;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.LastNameDataLabel, 3);
            this.LastNameDataLabel.Location = new System.Drawing.Point(123, 60);
            this.LastNameDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(361, 60);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.FirstNameDataLabel, 3);
            this.FirstNameDataLabel.Location = new System.Drawing.Point(123, 0);
            this.FirstNameDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(361, 60);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.Location = new System.Drawing.Point(2, 60);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(117, 60);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateNameButton
            // 
            this.GenerateNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTableLayoutPanel.SetColumnSpan(this.GenerateNameButton, 2);
            this.GenerateNameButton.Location = new System.Drawing.Point(244, 182);
            this.GenerateNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(240, 57);
            this.GenerateNameButton.TabIndex = 1;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            this.GenerateNameButton.Click += new System.EventHandler(this.GenerateNameButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.Location = new System.Drawing.Point(2, 0);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(117, 60);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilityPage);
            this.MainTabControl.Controls.Add(this.SkillsPage);
            this.MainTabControl.Controls.Add(this.CharacterSheetPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(503, 335);
            this.MainTabControl.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 50);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ability";
            // 
            // CharacterGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(503, 408);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainTabControl);
            this.MainMenuStrip = this.CharecterMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CharacterGenerationForm";
            this.Text = "Character Generator";
            this.CharacterSheetPage.ResumeLayout(false);
            this.CharacterSheetPage.PerformLayout();
            this.CharecterMenuStrip.ResumeLayout(false);
            this.CharecterMenuStrip.PerformLayout();
            this.CharecterToolStrip.ResumeLayout(false);
            this.CharecterToolStrip.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.SkillsPage.ResumeLayout(false);
            this.SkillsTableLayoutPanel.ResumeLayout(false);
            this.AbilityPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.IdentityTableLayoutPanel.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.OpenFileDialog CharacterSheetOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog CharacterSheetSaveFileDialog;
        private System.Windows.Forms.TabPage CharacterSheetPage;
        private System.Windows.Forms.ToolStrip CharecterToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip CharecterMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage SkillsPage;
        private System.Windows.Forms.TableLayoutPanel SkillsTableLayoutPanel;
        private System.Windows.Forms.Button GenerateSkillsButton;
        private System.Windows.Forms.Label AnimalLabel;
        private System.Windows.Forms.Label ArtLabel;
        private System.Windows.Forms.Label DriveLabel;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.TabPage AbilityPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Button GenerateAbilitiesButton;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Label IntellectLabel;
        private System.Windows.Forms.Label EducationLabel;
        private System.Windows.Forms.Label SocialStandingLabel;
        private System.Windows.Forms.Label DexterityDataLabel;
        private System.Windows.Forms.Label EnduranceDataLabel;
        private System.Windows.Forms.Label IntellectDataLabel;
        private System.Windows.Forms.Label EducationDataLabel;
        private System.Windows.Forms.Label SocialStandingDataLabel;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TableLayoutPanel IdentityTableLayoutPanel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.TabControl MainTabControl;
    }
}