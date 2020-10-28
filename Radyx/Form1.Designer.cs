namespace Radyx
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WebHook = new System.Windows.Forms.TabPage();
            this.status = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.animaTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.animaTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainP = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Track = new MetroFramework.Controls.MetroLabel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.RegularStartup = new MetroFramework.Controls.MetroCheckBox();
            this.CopyStealer = new MetroFramework.Controls.MetroCheckBox();
            this.PumpFile = new MetroFramework.Controls.MetroCheckBox();
            this.Trace = new MetroFramework.Controls.MetroCheckBox();
            this.HideFile = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.IconPath = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.url = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.ProxyPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.WebHook.SuspendLayout();
            this.MainP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.ProxyPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebHook
            // 
            this.WebHook.AllowDrop = true;
            this.WebHook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.WebHook.Controls.Add(this.status);
            this.WebHook.Controls.Add(this.metroButton3);
            this.WebHook.Controls.Add(this.metroLabel7);
            this.WebHook.Controls.Add(this.metroLabel6);
            this.WebHook.Controls.Add(this.animaTextBox4);
            this.WebHook.Controls.Add(this.animaTextBox3);
            this.WebHook.Controls.Add(this.listView2);
            this.WebHook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WebHook.Location = new System.Drawing.Point(4, 38);
            this.WebHook.Name = "WebHook";
            this.WebHook.Size = new System.Drawing.Size(867, 343);
            this.WebHook.TabIndex = 1;
            this.WebHook.Text = "Account Checker";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(515, 96);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 0);
            this.status.Style = MetroFramework.MetroColorStyle.Red;
            this.status.TabIndex = 18;
            this.status.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(515, 54);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(188, 36);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton3.TabIndex = 17;
            this.metroButton3.Text = "Check Account";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(143, 87);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(70, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Password :";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(156, 46);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "GrowID :";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // animaTextBox4
            // 
            // 
            // 
            // 
            this.animaTextBox4.CustomButton.Image = null;
            this.animaTextBox4.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.animaTextBox4.CustomButton.Name = "";
            this.animaTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.animaTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.animaTextBox4.CustomButton.TabIndex = 1;
            this.animaTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.animaTextBox4.CustomButton.UseSelectable = true;
            this.animaTextBox4.CustomButton.Visible = false;
            this.animaTextBox4.Lines = new string[0];
            this.animaTextBox4.Location = new System.Drawing.Point(222, 43);
            this.animaTextBox4.MaxLength = 32767;
            this.animaTextBox4.Name = "animaTextBox4";
            this.animaTextBox4.PasswordChar = '\0';
            this.animaTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.animaTextBox4.SelectedText = "";
            this.animaTextBox4.SelectionLength = 0;
            this.animaTextBox4.SelectionStart = 0;
            this.animaTextBox4.ShortcutsEnabled = true;
            this.animaTextBox4.Size = new System.Drawing.Size(270, 23);
            this.animaTextBox4.TabIndex = 14;
            this.animaTextBox4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.animaTextBox4.UseSelectable = true;
            this.animaTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.animaTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // animaTextBox3
            // 
            // 
            // 
            // 
            this.animaTextBox3.CustomButton.Image = null;
            this.animaTextBox3.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.animaTextBox3.CustomButton.Name = "";
            this.animaTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.animaTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.animaTextBox3.CustomButton.TabIndex = 1;
            this.animaTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.animaTextBox3.CustomButton.UseSelectable = true;
            this.animaTextBox3.CustomButton.Visible = false;
            this.animaTextBox3.Lines = new string[0];
            this.animaTextBox3.Location = new System.Drawing.Point(222, 87);
            this.animaTextBox3.MaxLength = 32767;
            this.animaTextBox3.Name = "animaTextBox3";
            this.animaTextBox3.PasswordChar = '\0';
            this.animaTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.animaTextBox3.SelectedText = "";
            this.animaTextBox3.SelectionLength = 0;
            this.animaTextBox3.SelectionStart = 0;
            this.animaTextBox3.ShortcutsEnabled = true;
            this.animaTextBox3.Size = new System.Drawing.Size(270, 23);
            this.animaTextBox3.TabIndex = 13;
            this.animaTextBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.animaTextBox3.UseSelectable = true;
            this.animaTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.animaTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.Black;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.listView2.ForeColor = System.Drawing.Color.White;
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(125, 139);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(622, 182);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GrowID";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "World Locks";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gems";
            this.columnHeader4.Width = 133;
            // 
            // MainP
            // 
            this.MainP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.MainP.Controls.Add(this.metroLabel5);
            this.MainP.Controls.Add(this.pictureBox1);
            this.MainP.Controls.Add(this.groupBox2);
            this.MainP.Controls.Add(this.metroLabel2);
            this.MainP.Controls.Add(this.listBox1);
            this.MainP.Controls.Add(this.metroLabel3);
            this.MainP.Controls.Add(this.metroButton2);
            this.MainP.Controls.Add(this.IconPath);
            this.MainP.Controls.Add(this.metroButton1);
            this.MainP.Controls.Add(this.metroLabel1);
            this.MainP.Controls.Add(this.url);
            this.MainP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainP.HorizontalScrollbarBarColor = true;
            this.MainP.HorizontalScrollbarHighlightOnWheel = false;
            this.MainP.HorizontalScrollbarSize = 10;
            this.MainP.Location = new System.Drawing.Point(4, 38);
            this.MainP.Name = "MainP";
            this.MainP.Size = new System.Drawing.Size(867, 343);
            this.MainP.TabIndex = 0;
            this.MainP.Text = "Main Page";
            this.MainP.UseCustomBackColor = true;
            this.MainP.UseCustomForeColor = true;
            this.MainP.UseStyleColors = true;
            this.MainP.VerticalScrollbarBarColor = true;
            this.MainP.VerticalScrollbarHighlightOnWheel = false;
            this.MainP.VerticalScrollbarSize = 9;
            this.MainP.Click += new System.EventHandler(this.MainP_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel5.Location = new System.Drawing.Point(621, 192);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(105, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Life is Beatiful!";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(530, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Track);
            this.groupBox2.Controls.Add(this.metroTrackBar1);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.RegularStartup);
            this.groupBox2.Controls.Add(this.CopyStealer);
            this.groupBox2.Controls.Add(this.PumpFile);
            this.groupBox2.Controls.Add(this.Trace);
            this.groupBox2.Controls.Add(this.HideFile);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(255, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 251);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // Track
            // 
            this.Track.AutoSize = true;
            this.Track.Location = new System.Drawing.Point(147, 207);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(38, 19);
            this.Track.Style = MetroFramework.MetroColorStyle.Red;
            this.Track.TabIndex = 14;
            this.Track.Text = "1 MB";
            this.Track.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Enabled = false;
            this.metroTrackBar1.Location = new System.Drawing.Point(11, 190);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(179, 23);
            this.metroTrackBar1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTrackBar1.TabIndex = 10;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTrackBar1.UseCustomBackColor = true;
            this.metroTrackBar1.Value = 1;
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel4.Location = new System.Drawing.Point(60, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Settings : ";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // RegularStartup
            // 
            this.RegularStartup.Checked = true;
            this.RegularStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RegularStartup.Cursor = System.Windows.Forms.Cursors.Default;
            this.RegularStartup.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.RegularStartup.Location = new System.Drawing.Point(22, 39);
            this.RegularStartup.Name = "RegularStartup";
            this.RegularStartup.Size = new System.Drawing.Size(147, 23);
            this.RegularStartup.Style = MetroFramework.MetroColorStyle.Yellow;
            this.RegularStartup.TabIndex = 0;
            this.RegularStartup.Text = "Add To Startup";
            this.RegularStartup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RegularStartup.UseCustomBackColor = true;
            this.RegularStartup.UseSelectable = true;
            this.RegularStartup.UseStyleColors = true;
            this.RegularStartup.CheckedChanged += new System.EventHandler(this.RegularStartup_CheckedChanged);
            // 
            // CopyStealer
            // 
            this.CopyStealer.Checked = true;
            this.CopyStealer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CopyStealer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CopyStealer.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.CopyStealer.Location = new System.Drawing.Point(22, 68);
            this.CopyStealer.Name = "CopyStealer";
            this.CopyStealer.Size = new System.Drawing.Size(96, 23);
            this.CopyStealer.Style = MetroFramework.MetroColorStyle.Yellow;
            this.CopyStealer.TabIndex = 2;
            this.CopyStealer.Text = "CopyStealer";
            this.CopyStealer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CopyStealer.UseCustomBackColor = true;
            this.CopyStealer.UseSelectable = true;
            this.CopyStealer.UseStyleColors = true;
            // 
            // PumpFile
            // 
            this.PumpFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.PumpFile.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.PumpFile.Location = new System.Drawing.Point(22, 158);
            this.PumpFile.Name = "PumpFile";
            this.PumpFile.Size = new System.Drawing.Size(147, 26);
            this.PumpFile.Style = MetroFramework.MetroColorStyle.Yellow;
            this.PumpFile.TabIndex = 9;
            this.PumpFile.Text = "Pump File";
            this.PumpFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PumpFile.UseCustomBackColor = true;
            this.PumpFile.UseSelectable = true;
            this.PumpFile.UseStyleColors = true;
            this.PumpFile.CheckedChanged += new System.EventHandler(this.PumpFile_CheckedChanged);
            // 
            // Trace
            // 
            this.Trace.Cursor = System.Windows.Forms.Cursors.Default;
            this.Trace.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.Trace.Location = new System.Drawing.Point(22, 97);
            this.Trace.Name = "Trace";
            this.Trace.Size = new System.Drawing.Size(147, 23);
            this.Trace.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Trace.TabIndex = 1;
            this.Trace.Text = "Trace Save Dat";
            this.Trace.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Trace.UseCustomBackColor = true;
            this.Trace.UseSelectable = true;
            this.Trace.UseStyleColors = true;
            this.Trace.CheckedChanged += new System.EventHandler(this.metroCheckBox2_CheckedChanged);
            // 
            // HideFile
            // 
            this.HideFile.Checked = true;
            this.HideFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HideFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.HideFile.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.HideFile.Location = new System.Drawing.Point(22, 126);
            this.HideFile.Name = "HideFile";
            this.HideFile.Size = new System.Drawing.Size(147, 26);
            this.HideFile.Style = MetroFramework.MetroColorStyle.Yellow;
            this.HideFile.TabIndex = 3;
            this.HideFile.Text = "Hide Stealer";
            this.HideFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HideFile.UseCustomBackColor = true;
            this.HideFile.UseSelectable = true;
            this.HideFile.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Logs : ";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 224);
            this.listBox1.TabIndex = 7;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(490, 221);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Icon:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(806, 220);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(34, 24);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "...";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // IconPath
            // 
            // 
            // 
            // 
            this.IconPath.CustomButton.Image = null;
            this.IconPath.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.IconPath.CustomButton.Name = "";
            this.IconPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.IconPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IconPath.CustomButton.TabIndex = 1;
            this.IconPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IconPath.CustomButton.UseSelectable = true;
            this.IconPath.CustomButton.Visible = false;
            this.IconPath.Lines = new string[0];
            this.IconPath.Location = new System.Drawing.Point(530, 220);
            this.IconPath.MaxLength = 32767;
            this.IconPath.Name = "IconPath";
            this.IconPath.PasswordChar = '\0';
            this.IconPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IconPath.SelectedText = "";
            this.IconPath.SelectionLength = 0;
            this.IconPath.SelectionStart = 0;
            this.IconPath.ShortcutsEnabled = true;
            this.IconPath.Size = new System.Drawing.Size(270, 23);
            this.IconPath.TabIndex = 4;
            this.IconPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IconPath.UseSelectable = true;
            this.IconPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IconPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(509, 253);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(319, 33);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Build";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Webhook Url : ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // url
            // 
            // 
            // 
            // 
            this.url.CustomButton.Image = null;
            this.url.CustomButton.Location = new System.Drawing.Point(698, 1);
            this.url.CustomButton.Name = "";
            this.url.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.url.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.url.CustomButton.TabIndex = 1;
            this.url.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.url.CustomButton.UseSelectable = true;
            this.url.CustomButton.Visible = false;
            this.url.Lines = new string[0];
            this.url.Location = new System.Drawing.Point(118, 37);
            this.url.MaxLength = 32767;
            this.url.Name = "url";
            this.url.PasswordChar = '\0';
            this.url.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.url.SelectedText = "";
            this.url.SelectionLength = 0;
            this.url.SelectionStart = 0;
            this.url.ShortcutsEnabled = true;
            this.url.Size = new System.Drawing.Size(720, 23);
            this.url.TabIndex = 1;
            this.url.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.url.UseSelectable = true;
            this.url.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.url.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.MainP);
            this.metroTabControl1.Controls.Add(this.WebHook);
            this.metroTabControl1.Controls.Add(this.ProxyPage);
            this.metroTabControl1.Location = new System.Drawing.Point(14, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(875, 385);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            this.metroTabControl1.Click += new System.EventHandler(this.metroTabControl1_Click);
            // 
            // ProxyPage
            // 
            this.ProxyPage.Controls.Add(this.metroLabel9);
            this.ProxyPage.Controls.Add(this.listBox2);
            this.ProxyPage.Controls.Add(this.metroButton5);
            this.ProxyPage.Controls.Add(this.metroButton4);
            this.ProxyPage.HorizontalScrollbarBarColor = true;
            this.ProxyPage.HorizontalScrollbarHighlightOnWheel = false;
            this.ProxyPage.HorizontalScrollbarSize = 10;
            this.ProxyPage.Location = new System.Drawing.Point(4, 38);
            this.ProxyPage.Name = "ProxyPage";
            this.ProxyPage.Size = new System.Drawing.Size(867, 343);
            this.ProxyPage.Style = MetroFramework.MetroColorStyle.Black;
            this.ProxyPage.TabIndex = 2;
            this.ProxyPage.Text = "Proxy Page";
            this.ProxyPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProxyPage.UseStyleColors = true;
            this.ProxyPage.VerticalScrollbarBarColor = true;
            this.ProxyPage.VerticalScrollbarHighlightOnWheel = false;
            this.ProxyPage.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(108, 35);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(69, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "Features : ";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.ForeColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(108, 57);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(603, 182);
            this.listBox2.TabIndex = 9;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(108, 266);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(288, 36);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton5.TabIndex = 3;
            this.metroButton5.Text = "Disable AAP";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(417, 266);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(294, 36);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton4.TabIndex = 2;
            this.metroButton4.Text = "Enable AAP";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 469);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(21, 60, 21, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "RadyxBuilder v1.0";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.WebHook.ResumeLayout(false);
            this.WebHook.PerformLayout();
            this.MainP.ResumeLayout(false);
            this.MainP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.ProxyPage.ResumeLayout(false);
            this.ProxyPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage WebHook;
        private MetroFramework.Controls.MetroTabPage MainP;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox url;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroCheckBox Trace;
        private MetroFramework.Controls.MetroCheckBox RegularStartup;
        private MetroFramework.Controls.MetroTextBox IconPath;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox HideFile;
        private MetroFramework.Controls.MetroCheckBox CopyStealer;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroCheckBox PumpFile;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel Track;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroTabPage ProxyPage;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.ListBox listBox2;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox animaTextBox4;
        private MetroFramework.Controls.MetroTextBox animaTextBox3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel status;
    }
}

