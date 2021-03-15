
namespace UniversalUnlockTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.CHECK_FRP = new Guna.UI.WinForms.GunaCheckBox();
            this.CHECK_FORMATSAFE = new Guna.UI.WinForms.GunaCheckBox();
            this.CHECK_FORMAT = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.COM_MODEL = new Guna.UI.WinForms.GunaComboBox();
            this.COM_BRAND = new Guna.UI.WinForms.GunaComboBox();
            this.BTN_UNLOCK = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.CHECK_DOWNLOAD = new Guna.UI.WinForms.GunaCheckBox();
            this.CHECK_ERASEDOWNLOAD = new Guna.UI.WinForms.GunaCheckBox();
            this.CHECK_PART = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TXT_AUTH = new System.Windows.Forms.TextBox();
            this.TXT_SCATTER = new System.Windows.Forms.TextBox();
            this.TXT_DA = new System.Windows.Forms.TextBox();
            this.GroupBoxUSB = new Guna.UI.WinForms.GunaGroupBox();
            this.CHECK_BYPASSAUTH = new Guna.UI.WinForms.GunaCheckBox();
            this.CHECK_UART = new Guna.UI.WinForms.GunaCheckBox();
            this.CHECK_BROM = new Guna.UI.WinForms.GunaCheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.BGW_LOAD = new System.ComponentModel.BackgroundWorker();
            this.ProgressBar1 = new Guna.UI.WinForms.GunaProgressBar();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.BGW_WRITE = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBoxUSB.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.Default;
            this.tabPane1.AllowHtmlDraw = true;
            this.tabPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.tabPane1.Appearance.Options.UseBackColor = true;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Location = new System.Drawing.Point(3, -1);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage3,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(1055, 487);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1055, 487);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.SelectedPageIndexChanged += new System.EventHandler(this.tabPane1_SelectedPageIndexChanged);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.Caption = "Unlocked";
            this.tabNavigationPage1.Controls.Add(this.gunaGroupBox1);
            this.tabNavigationPage1.Controls.Add(this.gunaLabel2);
            this.tabNavigationPage1.Controls.Add(this.gunaLabel1);
            this.tabNavigationPage1.Controls.Add(this.COM_MODEL);
            this.tabNavigationPage1.Controls.Add(this.COM_BRAND);
            this.tabNavigationPage1.Controls.Add(this.BTN_UNLOCK);
            this.tabNavigationPage1.ImageOptions.Image = global::UniversalUnlockTool.Properties.Resources1.lock_20px;
            this.tabNavigationPage1.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Size = new System.Drawing.Size(1055, 453);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.CHECK_FRP);
            this.gunaGroupBox1.Controls.Add(this.CHECK_FORMATSAFE);
            this.gunaGroupBox1.Controls.Add(this.CHECK_FORMAT);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.LineTop = 15;
            this.gunaGroupBox1.Location = new System.Drawing.Point(44, 33);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(473, 75);
            this.gunaGroupBox1.TabIndex = 5;
            this.gunaGroupBox1.Text = "Option";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(0, 0);
            // 
            // CHECK_FRP
            // 
            this.CHECK_FRP.BaseColor = System.Drawing.Color.Transparent;
            this.CHECK_FRP.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_FRP.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_FRP.FillColor = System.Drawing.Color.White;
            this.CHECK_FRP.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECK_FRP.Location = new System.Drawing.Point(133, 20);
            this.CHECK_FRP.Name = "CHECK_FRP";
            this.CHECK_FRP.Radius = 1;
            this.CHECK_FRP.Size = new System.Drawing.Size(82, 20);
            this.CHECK_FRP.TabIndex = 2;
            this.CHECK_FRP.Text = "FRP Reset";
            this.CHECK_FRP.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.CHECK_FRP.CheckedChanged += new System.EventHandler(this.CHECK_FRP_CheckedChanged);
            // 
            // CHECK_FORMATSAFE
            // 
            this.CHECK_FORMATSAFE.BaseColor = System.Drawing.Color.Transparent;
            this.CHECK_FORMATSAFE.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_FORMATSAFE.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_FORMATSAFE.FillColor = System.Drawing.Color.White;
            this.CHECK_FORMATSAFE.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECK_FORMATSAFE.Location = new System.Drawing.Point(3, 46);
            this.CHECK_FORMATSAFE.Name = "CHECK_FORMATSAFE";
            this.CHECK_FORMATSAFE.Radius = 1;
            this.CHECK_FORMATSAFE.Size = new System.Drawing.Size(130, 20);
            this.CHECK_FORMATSAFE.TabIndex = 1;
            this.CHECK_FORMATSAFE.Text = "FormatData - SAFE";
            this.CHECK_FORMATSAFE.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.CHECK_FORMATSAFE.CheckedChanged += new System.EventHandler(this.CHECK_FORMATSAFE_CheckedChanged);
            // 
            // CHECK_FORMAT
            // 
            this.CHECK_FORMAT.BaseColor = System.Drawing.Color.Transparent;
            this.CHECK_FORMAT.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_FORMAT.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_FORMAT.FillColor = System.Drawing.Color.White;
            this.CHECK_FORMAT.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECK_FORMAT.Location = new System.Drawing.Point(3, 23);
            this.CHECK_FORMAT.Name = "CHECK_FORMAT";
            this.CHECK_FORMAT.Radius = 1;
            this.CHECK_FORMAT.Size = new System.Drawing.Size(93, 20);
            this.CHECK_FORMAT.TabIndex = 0;
            this.CHECK_FORMAT.Text = "FormatData";
            this.CHECK_FORMAT.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.CHECK_FORMAT.CheckedChanged += new System.EventHandler(this.CHECK_FORMAT_CheckedChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(-3, 8);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(47, 16);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Brand :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(186, 8);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(49, 16);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Model :";
            // 
            // COM_MODEL
            // 
            this.COM_MODEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.COM_MODEL.BaseColor = System.Drawing.Color.LightGray;
            this.COM_MODEL.BorderColor = System.Drawing.Color.Silver;
            this.COM_MODEL.BorderSize = 1;
            this.COM_MODEL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.COM_MODEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COM_MODEL.FocusedColor = System.Drawing.Color.Empty;
            this.COM_MODEL.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold);
            this.COM_MODEL.ForeColor = System.Drawing.Color.Black;
            this.COM_MODEL.FormattingEnabled = true;
            this.COM_MODEL.Location = new System.Drawing.Point(235, 5);
            this.COM_MODEL.Name = "COM_MODEL";
            this.COM_MODEL.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.COM_MODEL.OnHoverItemForeColor = System.Drawing.Color.White;
            this.COM_MODEL.Size = new System.Drawing.Size(282, 22);
            this.COM_MODEL.TabIndex = 2;
            // 
            // COM_BRAND
            // 
            this.COM_BRAND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.COM_BRAND.BaseColor = System.Drawing.Color.LightGray;
            this.COM_BRAND.BorderColor = System.Drawing.Color.Silver;
            this.COM_BRAND.BorderSize = 1;
            this.COM_BRAND.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.COM_BRAND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COM_BRAND.FocusedColor = System.Drawing.Color.Empty;
            this.COM_BRAND.Font = new System.Drawing.Font("Microsoft Tai Le", 8F);
            this.COM_BRAND.ForeColor = System.Drawing.Color.Black;
            this.COM_BRAND.FormattingEnabled = true;
            this.COM_BRAND.Items.AddRange(new object[] {
            "OPPO_GENERIC",
            "REALME_GENERIC"});
            this.COM_BRAND.Location = new System.Drawing.Point(44, 5);
            this.COM_BRAND.Name = "COM_BRAND";
            this.COM_BRAND.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.COM_BRAND.OnHoverItemForeColor = System.Drawing.Color.White;
            this.COM_BRAND.Size = new System.Drawing.Size(136, 22);
            this.COM_BRAND.TabIndex = 1;
            this.COM_BRAND.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // BTN_UNLOCK
            // 
            this.BTN_UNLOCK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_UNLOCK.Animated = true;
            this.BTN_UNLOCK.AnimationHoverSpeed = 0.07F;
            this.BTN_UNLOCK.AnimationSpeed = 0.03F;
            this.BTN_UNLOCK.BaseColor = System.Drawing.Color.White;
            this.BTN_UNLOCK.BorderColor = System.Drawing.Color.Silver;
            this.BTN_UNLOCK.BorderSize = 1;
            this.BTN_UNLOCK.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BTN_UNLOCK.CheckedBorderColor = System.Drawing.Color.Black;
            this.BTN_UNLOCK.CheckedForeColor = System.Drawing.Color.White;
            this.BTN_UNLOCK.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BTN_UNLOCK.CheckedImage")));
            this.BTN_UNLOCK.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BTN_UNLOCK.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_UNLOCK.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.BTN_UNLOCK.ForeColor = System.Drawing.Color.Black;
            this.BTN_UNLOCK.Image = global::UniversalUnlockTool.Properties.Resources1.icons8_job_32;
            this.BTN_UNLOCK.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_UNLOCK.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_UNLOCK.Location = new System.Drawing.Point(432, 409);
            this.BTN_UNLOCK.Name = "BTN_UNLOCK";
            this.BTN_UNLOCK.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.BTN_UNLOCK.OnHoverBorderColor = System.Drawing.Color.DimGray;
            this.BTN_UNLOCK.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_UNLOCK.OnHoverImage = null;
            this.BTN_UNLOCK.OnHoverLineColor = System.Drawing.Color.Silver;
            this.BTN_UNLOCK.OnPressedColor = System.Drawing.Color.DimGray;
            this.BTN_UNLOCK.Size = new System.Drawing.Size(85, 28);
            this.BTN_UNLOCK.TabIndex = 0;
            this.BTN_UNLOCK.Text = "Unlock";
            this.BTN_UNLOCK.Click += new System.EventHandler(this.BTN_UNLOCK_Click);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Activation";
            this.tabNavigationPage2.Controls.Add(this.gunaLabel4);
            this.tabNavigationPage2.Controls.Add(this.textBox1);
            this.tabNavigationPage2.Controls.Add(this.gunaAdvenceButton2);
            this.tabNavigationPage2.ImageOptions.Image = global::UniversalUnlockTool.Properties.Resources1.checkmark_20px;
            this.tabNavigationPage2.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Size = new System.Drawing.Size(1055, 453);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(8, 13);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(82, 16);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "ActivateKey :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(90, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 20);
            this.textBox1.TabIndex = 2;
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.Animated = true;
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Silver;
            this.gunaAdvenceButton2.BorderSize = 1;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Image = global::UniversalUnlockTool.Properties.Resources1.icons8_registered_trademark_32;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(432, 37);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.Silver;
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(85, 28);
            this.gunaAdvenceButton2.TabIndex = 1;
            this.gunaAdvenceButton2.Text = "Activate ";
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Flash";
            this.tabNavigationPage3.Controls.Add(this.gunaGroupBox2);
            this.tabNavigationPage3.Controls.Add(this.CHECK_PART);
            this.tabNavigationPage3.Controls.Add(this.label3);
            this.tabNavigationPage3.Controls.Add(this.label2);
            this.tabNavigationPage3.Controls.Add(this.label1);
            this.tabNavigationPage3.Controls.Add(this.dataGridView1);
            this.tabNavigationPage3.Controls.Add(this.gunaAdvenceButton1);
            this.tabNavigationPage3.Controls.Add(this.TXT_AUTH);
            this.tabNavigationPage3.Controls.Add(this.TXT_SCATTER);
            this.tabNavigationPage3.Controls.Add(this.TXT_DA);
            this.tabNavigationPage3.ImageOptions.Image = global::UniversalUnlockTool.Properties.Resources1.icons8_download_16;
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1055, 453);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.BorderSize = 1;
            this.gunaGroupBox2.Controls.Add(this.CHECK_DOWNLOAD);
            this.gunaGroupBox2.Controls.Add(this.CHECK_ERASEDOWNLOAD);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.LineTop = 0;
            this.gunaGroupBox2.Location = new System.Drawing.Point(194, 402);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(187, 42);
            this.gunaGroupBox2.TabIndex = 9;
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(14, 8);
            // 
            // CHECK_DOWNLOAD
            // 
            this.CHECK_DOWNLOAD.BaseColor = System.Drawing.Color.Transparent;
            this.CHECK_DOWNLOAD.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_DOWNLOAD.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_DOWNLOAD.FillColor = System.Drawing.Color.White;
            this.CHECK_DOWNLOAD.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECK_DOWNLOAD.Location = new System.Drawing.Point(3, 2);
            this.CHECK_DOWNLOAD.Name = "CHECK_DOWNLOAD";
            this.CHECK_DOWNLOAD.Radius = 1;
            this.CHECK_DOWNLOAD.Size = new System.Drawing.Size(112, 20);
            this.CHECK_DOWNLOAD.TabIndex = 3;
            this.CHECK_DOWNLOAD.Text = "Download Only";
            this.CHECK_DOWNLOAD.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            // 
            // CHECK_ERASEDOWNLOAD
            // 
            this.CHECK_ERASEDOWNLOAD.BaseColor = System.Drawing.Color.Transparent;
            this.CHECK_ERASEDOWNLOAD.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_ERASEDOWNLOAD.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_ERASEDOWNLOAD.FillColor = System.Drawing.Color.White;
            this.CHECK_ERASEDOWNLOAD.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECK_ERASEDOWNLOAD.Location = new System.Drawing.Point(3, 21);
            this.CHECK_ERASEDOWNLOAD.Name = "CHECK_ERASEDOWNLOAD";
            this.CHECK_ERASEDOWNLOAD.Radius = 1;
            this.CHECK_ERASEDOWNLOAD.Size = new System.Drawing.Size(124, 20);
            this.CHECK_ERASEDOWNLOAD.TabIndex = 1;
            this.CHECK_ERASEDOWNLOAD.Text = "Erase before flash";
            this.CHECK_ERASEDOWNLOAD.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            // 
            // CHECK_PART
            // 
            this.CHECK_PART.AutoSize = true;
            this.CHECK_PART.Location = new System.Drawing.Point(10, 101);
            this.CHECK_PART.Name = "CHECK_PART";
            this.CHECK_PART.Size = new System.Drawing.Size(15, 14);
            this.CHECK_PART.TabIndex = 8;
            this.CHECK_PART.UseVisualStyleBackColor = true;
            this.CHECK_PART.CheckedChanged += new System.EventHandler(this.CHECK_PART_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(484, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Auth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(471, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "scatter";
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(493, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(521, 300);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Partition Name";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Image";
            this.Column2.Name = "Column2";
            this.Column2.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Start Address";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "End Address";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.HeaderText = "Index";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Visible = false;
            this.Column6.Width = 5;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Directory";
            this.Column7.Name = "Column7";
            this.Column7.Width = 140;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaAdvenceButton1.Animated = true;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Silver;
            this.gunaAdvenceButton1.BorderSize = 1;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Image = global::UniversalUnlockTool.Properties.Resources1.icons8_job_32;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(432, 416);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Silver;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(85, 28);
            this.gunaAdvenceButton1.TabIndex = 3;
            this.gunaAdvenceButton1.Text = "Flash";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // TXT_AUTH
            // 
            this.TXT_AUTH.BackColor = System.Drawing.SystemColors.Control;
            this.TXT_AUTH.Location = new System.Drawing.Point(0, 47);
            this.TXT_AUTH.Multiline = true;
            this.TXT_AUTH.Name = "TXT_AUTH";
            this.TXT_AUTH.Size = new System.Drawing.Size(521, 18);
            this.TXT_AUTH.TabIndex = 2;
            // 
            // TXT_SCATTER
            // 
            this.TXT_SCATTER.BackColor = System.Drawing.SystemColors.Control;
            this.TXT_SCATTER.Location = new System.Drawing.Point(0, 25);
            this.TXT_SCATTER.Multiline = true;
            this.TXT_SCATTER.Name = "TXT_SCATTER";
            this.TXT_SCATTER.Size = new System.Drawing.Size(521, 18);
            this.TXT_SCATTER.TabIndex = 1;
            // 
            // TXT_DA
            // 
            this.TXT_DA.BackColor = System.Drawing.SystemColors.Control;
            this.TXT_DA.Location = new System.Drawing.Point(0, 3);
            this.TXT_DA.Multiline = true;
            this.TXT_DA.Name = "TXT_DA";
            this.TXT_DA.Size = new System.Drawing.Size(521, 18);
            this.TXT_DA.TabIndex = 0;
            // 
            // GroupBoxUSB
            // 
            this.GroupBoxUSB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBoxUSB.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxUSB.BaseColor = System.Drawing.Color.Transparent;
            this.GroupBoxUSB.BorderColor = System.Drawing.Color.Gainsboro;
            this.GroupBoxUSB.BorderSize = 1;
            this.GroupBoxUSB.Controls.Add(this.CHECK_BYPASSAUTH);
            this.GroupBoxUSB.Controls.Add(this.CHECK_UART);
            this.GroupBoxUSB.Controls.Add(this.CHECK_BROM);
            this.GroupBoxUSB.LineColor = System.Drawing.Color.Gainsboro;
            this.GroupBoxUSB.LineTop = 0;
            this.GroupBoxUSB.Location = new System.Drawing.Point(3, 437);
            this.GroupBoxUSB.Name = "GroupBoxUSB";
            this.GroupBoxUSB.Size = new System.Drawing.Size(187, 42);
            this.GroupBoxUSB.TabIndex = 6;
            this.GroupBoxUSB.TextLocation = new System.Drawing.Point(14, 8);
            // 
            // CHECK_BYPASSAUTH
            // 
            this.CHECK_BYPASSAUTH.BaseColor = System.Drawing.Color.Transparent;
            this.CHECK_BYPASSAUTH.Checked = true;
            this.CHECK_BYPASSAUTH.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_BYPASSAUTH.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_BYPASSAUTH.FillColor = System.Drawing.Color.White;
            this.CHECK_BYPASSAUTH.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECK_BYPASSAUTH.Location = new System.Drawing.Point(90, 21);
            this.CHECK_BYPASSAUTH.Name = "CHECK_BYPASSAUTH";
            this.CHECK_BYPASSAUTH.Radius = 1;
            this.CHECK_BYPASSAUTH.Size = new System.Drawing.Size(98, 20);
            this.CHECK_BYPASSAUTH.TabIndex = 4;
            this.CHECK_BYPASSAUTH.Text = "BypassAUTH";
            this.CHECK_BYPASSAUTH.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            // 
            // CHECK_UART
            // 
            this.CHECK_UART.BaseColor = System.Drawing.Color.Transparent;
            this.CHECK_UART.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_UART.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_UART.FillColor = System.Drawing.Color.White;
            this.CHECK_UART.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECK_UART.Location = new System.Drawing.Point(3, 2);
            this.CHECK_UART.Name = "CHECK_UART";
            this.CHECK_UART.Radius = 1;
            this.CHECK_UART.Size = new System.Drawing.Size(60, 20);
            this.CHECK_UART.TabIndex = 3;
            this.CHECK_UART.Text = "UART";
            this.CHECK_UART.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.CHECK_UART.CheckedChanged += new System.EventHandler(this.CHECK_UART_CheckedChanged);
            // 
            // CHECK_BROM
            // 
            this.CHECK_BROM.BaseColor = System.Drawing.Color.Transparent;
            this.CHECK_BROM.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_BROM.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CHECK_BROM.FillColor = System.Drawing.Color.White;
            this.CHECK_BROM.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECK_BROM.Location = new System.Drawing.Point(3, 21);
            this.CHECK_BROM.Name = "CHECK_BROM";
            this.CHECK_BROM.Radius = 1;
            this.CHECK_BROM.Size = new System.Drawing.Size(81, 20);
            this.CHECK_BROM.TabIndex = 1;
            this.CHECK_BROM.Text = "BromUSB";
            this.CHECK_BROM.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.CHECK_BROM.CheckedChanged += new System.EventHandler(this.CHECK_BROM_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(526, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(532, 445);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 485);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1058, 1);
            this.gunaPanel1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1058, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Tai Le", 6.5F);
            this.lbl_status.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_status.Size = new System.Drawing.Size(0, 17);
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BGW_LOAD
            // 
            this.BGW_LOAD.WorkerReportsProgress = true;
            this.BGW_LOAD.WorkerSupportsCancellation = true;
            this.BGW_LOAD.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_LOAD_DoWork);
            this.BGW_LOAD.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGW_LOAD_ProgressChanged);
            this.BGW_LOAD.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_LOAD_RunWorkerCompleted);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar1.BorderColor = System.Drawing.Color.Transparent;
            this.ProgressBar1.BorderSize = 1;
            this.ProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.ProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.ProgressBar1.Location = new System.Drawing.Point(0, 482);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.ProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.ProgressBar1.Size = new System.Drawing.Size(1057, 10);
            this.ProgressBar1.TabIndex = 5;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = global::UniversalUnlockTool.Properties.Resources1.lock_30px1;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(1007, 441);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaTransfarantPictureBox1.TabIndex = 2;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // BGW_WRITE
            // 
            this.BGW_WRITE.WorkerReportsProgress = true;
            this.BGW_WRITE.WorkerSupportsCancellation = true;
            this.BGW_WRITE.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_WRITE_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 505);
            this.Controls.Add(this.GroupBoxUSB);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaTransfarantPictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tabPane1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UniversalUnlockTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBoxUSB.ResumeLayout(false);
            this.GroupBoxUSB.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton BTN_UNLOCK;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Guna.UI.WinForms.GunaComboBox COM_BRAND;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox COM_MODEL;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.ComponentModel.BackgroundWorker BGW_LOAD;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaCheckBox CHECK_FORMATSAFE;
        private Guna.UI.WinForms.GunaCheckBox CHECK_FORMAT;
        private Guna.UI.WinForms.GunaCheckBox CHECK_FRP;
        private Guna.UI.WinForms.GunaGroupBox GroupBoxUSB;
        private Guna.UI.WinForms.GunaCheckBox CHECK_UART;
        private Guna.UI.WinForms.GunaCheckBox CHECK_BROM;
        public Guna.UI.WinForms.GunaProgressBar ProgressBar1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox TXT_DA;
        private System.Windows.Forms.TextBox TXT_AUTH;
        private System.Windows.Forms.TextBox TXT_SCATTER;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        public System.Windows.Forms.ToolStripStatusLabel lbl_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox CHECK_PART;
        private System.ComponentModel.BackgroundWorker BGW_WRITE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Guna.UI.WinForms.GunaCheckBox CHECK_BYPASSAUTH;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaCheckBox CHECK_DOWNLOAD;
        private Guna.UI.WinForms.GunaCheckBox CHECK_ERASEDOWNLOAD;
    }
}

