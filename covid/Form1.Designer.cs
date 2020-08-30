namespace covid
{
    partial class Covid
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Covid));
            this.Check = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lConfirmed = new System.Windows.Forms.Label();
            this.lpais = new System.Windows.Forms.Label();
            this.lDeath = new System.Windows.Forms.Label();
            this.lActive = new System.Windows.Forms.Label();
            this.lPs = new System.Windows.Forms.Label();
            this.lCd = new System.Windows.Forms.Label();
            this.lDd = new System.Windows.Forms.Label();
            this.lAct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lRd = new System.Windows.Forms.Label();
            this.Cases = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.error = new System.Windows.Forms.Label();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RestoreWindow = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Maximize = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.MenuSideBar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SideBarWrapper = new System.Windows.Forms.Panel();
            this.SideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SideBarLine = new Bunifu.Framework.UI.BunifuSeparator();
            this.CovidIcon2 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SideBarCurve = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelChartCurve = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Cases)).BeginInit();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBar)).BeginInit();
            this.SideBarWrapper.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CovidIcon2)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.PanelChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(165)))));
            this.Check.FlatAppearance.BorderSize = 5;
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check.ForeColor = System.Drawing.Color.White;
            this.Check.Location = new System.Drawing.Point(552, 99);
            this.Check.Margin = new System.Windows.Forms.Padding(4);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(161, 68);
            this.Check.TabIndex = 0;
            this.Check.Text = "REVISAR";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.button1_Click);
            // 
            // Datos
            // 
            this.Datos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Datos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Datos.FormattingEnabled = true;
            this.Datos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Datos.Items.AddRange(new object[] {
            "afghanistan",
            "albania",
            "algeria",
            "andorra",
            "angola",
            "antigua-and-barbuda",
            "argentina",
            "armenia",
            "australia",
            "austria",
            "azerbaijan",
            "bahamas",
            "bahrain",
            "bangladesh",
            "barbados",
            "belarus",
            "belgium",
            "belize",
            "benin",
            "bhutan",
            "bolivia",
            "bosnia-and-herzegovina",
            "botswana",
            "brazil",
            "brunei",
            "bulgaria",
            "burkina-faso",
            "burundi",
            "cambodia",
            "cameroon",
            "canada",
            "cape-verde",
            "central-african-republic",
            "chad",
            "chile",
            "china",
            "colombia",
            "comoros",
            "congo-brazzaville",
            "congo-kinshasa",
            "costa-rica",
            "croatia",
            "cuba",
            "cyprus",
            "czech-republic",
            "cote-divoire",
            "denmark",
            "djibouti",
            "dominica",
            "dominican-republic",
            "ecuador",
            "egypt",
            "el-salvador",
            "equatorial-guinea",
            "eritrea",
            "estonia",
            "ethiopia",
            "fiji",
            "finland",
            "france",
            "gabon",
            "gambia",
            "georgia",
            "germany",
            "ghana",
            "greece",
            "grenada",
            "guatemala",
            "guinea",
            "guinea-bissau",
            "guyana",
            "haiti",
            "holy-see-vatican-city-state",
            "honduras",
            "hungary",
            "iceland",
            "india",
            "indonesia",
            "iran",
            "iraq",
            "ireland",
            "israel",
            "italy",
            "jamaica",
            "japan",
            "jordan",
            "kazakhstan",
            "kenya",
            "korea-south",
            "kuwait",
            "kyrgyzstan",
            "lao-pdr",
            "latvia",
            "lebanon",
            "lesotho",
            "liberia",
            "libya",
            "liechtenstein",
            "lithuania",
            "luxembourg",
            "macedonia",
            "madagascar",
            "malawi",
            "malaysia",
            "maldives",
            "mali",
            "malta",
            "mauritania",
            "mauritius",
            "mexico",
            "moldova",
            "monaco",
            "mongolia",
            "montenegro",
            "morocco",
            "mozambique",
            "myanmar",
            "namibia",
            "nepal",
            "netherlands",
            "new-zealand",
            "nicaragua",
            "niger",
            "nigeria",
            "norway",
            "oman",
            "pakistan",
            "palestine",
            "panama",
            "papua-new-guinea",
            "paraguay",
            "peru",
            "philippines",
            "poland",
            "portugal",
            "qatar",
            "kosovo",
            "romania",
            "russia",
            "rwanda",
            "saint-kitts-and-nevis",
            "saint-lucia",
            "saint-vincent-and-the-grenadines",
            "san-marino",
            "sao-tome-and-principe",
            "saudi-arabia",
            "senegal",
            "serbia",
            "seychelles",
            "sierra-leone",
            "singapore",
            "slovakia",
            "slovenia",
            "somalia",
            "south-africa",
            "south-sudan",
            "spain",
            "sri-lanka",
            "sudan",
            "suriname",
            "swaziland",
            "sweden",
            "switzerland",
            "syria",
            "taiwan",
            "tajikistan",
            "tanzania",
            "thailand",
            "timor-leste",
            "togo",
            "trinidad-and-tobago",
            "tunisia",
            "turkey",
            "uganda",
            "ukraine",
            "united-arab-emirates",
            "united-kingdom",
            "united-states",
            "uruguay",
            "uzbekistan",
            "venezuela",
            "vietnam",
            "western-sahara",
            "yemen",
            "zambia",
            "zimbabwe"});
            this.Datos.Location = new System.Drawing.Point(174, 99);
            this.Datos.Margin = new System.Windows.Forms.Padding(4);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(287, 24);
            this.Datos.TabIndex = 3;
            this.Datos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(426, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "ESTADÍSTICAS MUNDIALES SOBRE EL COVID-19";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lConfirmed
            // 
            this.lConfirmed.AutoSize = true;
            this.lConfirmed.BackColor = System.Drawing.Color.Transparent;
            this.lConfirmed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConfirmed.ForeColor = System.Drawing.Color.White;
            this.lConfirmed.Location = new System.Drawing.Point(4, 268);
            this.lConfirmed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lConfirmed.Name = "lConfirmed";
            this.lConfirmed.Size = new System.Drawing.Size(208, 23);
            this.lConfirmed.TabIndex = 5;
            this.lConfirmed.Text = "CASOS CONFIRMADOS:";
            // 
            // lpais
            // 
            this.lpais.AutoSize = true;
            this.lpais.BackColor = System.Drawing.Color.Transparent;
            this.lpais.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpais.ForeColor = System.Drawing.Color.White;
            this.lpais.Location = new System.Drawing.Point(117, 42);
            this.lpais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lpais.Name = "lpais";
            this.lpais.Size = new System.Drawing.Size(65, 23);
            this.lpais.TabIndex = 6;
            this.lpais.Text = "PAÍS:";
            // 
            // lDeath
            // 
            this.lDeath.AutoSize = true;
            this.lDeath.BackColor = System.Drawing.Color.Transparent;
            this.lDeath.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDeath.ForeColor = System.Drawing.Color.White;
            this.lDeath.Location = new System.Drawing.Point(4, 344);
            this.lDeath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDeath.Name = "lDeath";
            this.lDeath.Size = new System.Drawing.Size(142, 23);
            this.lDeath.TabIndex = 7;
            this.lDeath.Text = "FALLECIDOS: ";
            // 
            // lActive
            // 
            this.lActive.AutoSize = true;
            this.lActive.BackColor = System.Drawing.Color.Transparent;
            this.lActive.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lActive.ForeColor = System.Drawing.Color.White;
            this.lActive.Location = new System.Drawing.Point(4, 419);
            this.lActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lActive.Name = "lActive";
            this.lActive.Size = new System.Drawing.Size(164, 23);
            this.lActive.TabIndex = 8;
            this.lActive.Text = "CASOS ACTIVOS:";
            // 
            // lPs
            // 
            this.lPs.BackColor = System.Drawing.Color.Transparent;
            this.lPs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPs.ForeColor = System.Drawing.Color.White;
            this.lPs.Location = new System.Drawing.Point(215, 37);
            this.lPs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPs.Name = "lPs";
            this.lPs.Size = new System.Drawing.Size(205, 28);
            this.lPs.TabIndex = 9;
            this.lPs.Click += new System.EventHandler(this.lPs_Click);
            // 
            // lCd
            // 
            this.lCd.BackColor = System.Drawing.Color.Transparent;
            this.lCd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCd.ForeColor = System.Drawing.Color.White;
            this.lCd.Location = new System.Drawing.Point(258, 268);
            this.lCd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCd.Name = "lCd";
            this.lCd.Size = new System.Drawing.Size(246, 28);
            this.lCd.TabIndex = 10;
            this.lCd.Click += new System.EventHandler(this.label7_Click);
            // 
            // lDd
            // 
            this.lDd.BackColor = System.Drawing.Color.Transparent;
            this.lDd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDd.ForeColor = System.Drawing.Color.White;
            this.lDd.Location = new System.Drawing.Point(180, 344);
            this.lDd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDd.Name = "lDd";
            this.lDd.Size = new System.Drawing.Size(246, 28);
            this.lDd.TabIndex = 11;
            // 
            // lAct
            // 
            this.lAct.BackColor = System.Drawing.Color.Transparent;
            this.lAct.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAct.ForeColor = System.Drawing.Color.White;
            this.lAct.Location = new System.Drawing.Point(215, 419);
            this.lAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAct.Name = "lAct";
            this.lAct.Size = new System.Drawing.Size(246, 28);
            this.lAct.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 485);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "RECUPERADOS:";
            // 
            // lRd
            // 
            this.lRd.BackColor = System.Drawing.Color.Transparent;
            this.lRd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRd.ForeColor = System.Drawing.Color.White;
            this.lRd.Location = new System.Drawing.Point(194, 485);
            this.lRd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRd.Name = "lRd";
            this.lRd.Size = new System.Drawing.Size(246, 28);
            this.lRd.TabIndex = 14;
            this.lRd.Click += new System.EventHandler(this.lRd_Click);
            // 
            // Cases
            // 
            this.Cases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Cases.BorderlineWidth = 0;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Cases.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.TitleForeColor = System.Drawing.Color.White;
            this.Cases.Legends.Add(legend1);
            this.Cases.Location = new System.Drawing.Point(4, 280);
            this.Cases.Margin = new System.Windows.Forms.Padding(4);
            this.Cases.Name = "Cases";
            series1.BorderWidth = 7;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(165)))));
            series1.EmptyPointStyle.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "CASOS ACTIVOS";
            series1.YValuesPerPoint = 2;
            this.Cases.Series.Add(series1);
            this.Cases.Size = new System.Drawing.Size(751, 391);
            this.Cases.TabIndex = 15;
            this.Cases.Text = "Covid_Cases";
            this.Cases.Click += new System.EventHandler(this.Cases_Click);
            // 
            // error
            // 
            this.error.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.error.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(152, 141);
            this.error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error.Name = "error";
            this.error.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.error.Size = new System.Drawing.Size(345, 26);
            this.error.TabIndex = 16;
            this.error.Text = "*POR FAVOR SELECCIONE UN PAÍS*";
            this.error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error.Visible = false;
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.bunifuSeparator1);
            this.MenuTop.Controls.Add(this.pictureBox1);
            this.MenuTop.Controls.Add(this.RestoreWindow);
            this.MenuTop.Controls.Add(this.Minimize);
            this.MenuTop.Controls.Add(this.Maximize);
            this.MenuTop.Controls.Add(this.Exit);
            this.MenuTop.Controls.Add(this.MenuSideBar);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.panel2);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Margin = new System.Windows.Forms.Padding(4);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1400, 88);
            this.MenuTop.TabIndex = 17;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 54);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1400, 21);
            this.bunifuSeparator1.TabIndex = 20;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1165, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // RestoreWindow
            // 
            this.RestoreWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreWindow.Image = ((System.Drawing.Image)(resources.GetObject("RestoreWindow.Image")));
            this.RestoreWindow.Location = new System.Drawing.Point(1296, 15);
            this.RestoreWindow.Margin = new System.Windows.Forms.Padding(4);
            this.RestoreWindow.Name = "RestoreWindow";
            this.RestoreWindow.Size = new System.Drawing.Size(40, 35);
            this.RestoreWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RestoreWindow.TabIndex = 23;
            this.RestoreWindow.TabStop = false;
            this.RestoreWindow.Visible = false;
            this.RestoreWindow.Click += new System.EventHandler(this.RestoreWindow_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(1248, 15);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(40, 35);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 22;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.Image = ((System.Drawing.Image)(resources.GetObject("Maximize.Image")));
            this.Maximize.Location = new System.Drawing.Point(1296, 15);
            this.Maximize.Margin = new System.Windows.Forms.Padding(4);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(40, 35);
            this.Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximize.TabIndex = 21;
            this.Maximize.TabStop = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1344, 15);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(40, 35);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 20;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MenuSideBar
            // 
            this.MenuSideBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MenuSideBar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSideBar.Image")));
            this.MenuSideBar.Location = new System.Drawing.Point(368, 13);
            this.MenuSideBar.Margin = new System.Windows.Forms.Padding(4);
            this.MenuSideBar.Name = "MenuSideBar";
            this.MenuSideBar.Size = new System.Drawing.Size(50, 50);
            this.MenuSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSideBar.TabIndex = 17;
            this.MenuSideBar.TabStop = false;
            this.MenuSideBar.Click += new System.EventHandler(this.MenuSideBar_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 959);
            this.panel2.TabIndex = 18;
            // 
            // SideBarWrapper
            // 
            this.SideBarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideBarWrapper.Controls.Add(this.SideBar);
            this.SideBarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarWrapper.Location = new System.Drawing.Point(0, 88);
            this.SideBarWrapper.Margin = new System.Windows.Forms.Padding(4);
            this.SideBarWrapper.Name = "SideBarWrapper";
            this.SideBarWrapper.Size = new System.Drawing.Size(571, 812);
            this.SideBarWrapper.TabIndex = 20;
            this.SideBarWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBarWrapper_Paint);
            // 
            // SideBar
            // 
            this.SideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBar.BackgroundImage")));
            this.SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar.Controls.Add(this.lConfirmed);
            this.SideBar.Controls.Add(this.lpais);
            this.SideBar.Controls.Add(this.lDeath);
            this.SideBar.Controls.Add(this.SideBarLine);
            this.SideBar.Controls.Add(this.lRd);
            this.SideBar.Controls.Add(this.CovidIcon2);
            this.SideBar.Controls.Add(this.lAct);
            this.SideBar.Controls.Add(this.lActive);
            this.SideBar.Controls.Add(this.lCd);
            this.SideBar.Controls.Add(this.lDd);
            this.SideBar.Controls.Add(this.lPs);
            this.SideBar.Controls.Add(this.label2);
            this.SideBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(165)))));
            this.SideBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(165)))));
            this.SideBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(165)))));
            this.SideBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideBar.Location = new System.Drawing.Point(35, 4);
            this.SideBar.Margin = new System.Windows.Forms.Padding(4);
            this.SideBar.Name = "SideBar";
            this.SideBar.Quality = 10;
            this.SideBar.Size = new System.Drawing.Size(520, 762);
            this.SideBar.TabIndex = 24;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // SideBarLine
            // 
            this.SideBarLine.BackColor = System.Drawing.Color.Transparent;
            this.SideBarLine.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.SideBarLine.LineThickness = 1;
            this.SideBarLine.Location = new System.Drawing.Point(0, 85);
            this.SideBarLine.Margin = new System.Windows.Forms.Padding(5);
            this.SideBarLine.Name = "SideBarLine";
            this.SideBarLine.Size = new System.Drawing.Size(520, 12);
            this.SideBarLine.TabIndex = 17;
            this.SideBarLine.Transparency = 255;
            this.SideBarLine.Vertical = false;
            // 
            // CovidIcon2
            // 
            this.CovidIcon2.BackColor = System.Drawing.Color.Transparent;
            this.CovidIcon2.Image = ((System.Drawing.Image)(resources.GetObject("CovidIcon2.Image")));
            this.CovidIcon2.Location = new System.Drawing.Point(38, 26);
            this.CovidIcon2.Margin = new System.Windows.Forms.Padding(4);
            this.CovidIcon2.Name = "CovidIcon2";
            this.CovidIcon2.Size = new System.Drawing.Size(59, 50);
            this.CovidIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CovidIcon2.TabIndex = 19;
            this.CovidIcon2.TabStop = false;
            // 
            // Wrapper
            // 
            this.Wrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.PanelChart);
            this.Wrapper.ForeColor = System.Drawing.Color.Black;
            this.Wrapper.Location = new System.Drawing.Point(571, 88);
            this.Wrapper.Margin = new System.Windows.Forms.Padding(4);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(829, 1000);
            this.Wrapper.TabIndex = 21;
            // 
            // PanelChart
            // 
            this.PanelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.PanelChart.Controls.Add(this.label3);
            this.PanelChart.Controls.Add(this.Datos);
            this.PanelChart.Controls.Add(this.error);
            this.PanelChart.Controls.Add(this.Check);
            this.PanelChart.Controls.Add(this.Cases);
            this.PanelChart.Location = new System.Drawing.Point(23, 7);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(768, 759);
            this.PanelChart.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(72, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(612, 42);
            this.label3.TabIndex = 24;
            this.label3.Text = "SELECCIONE UN PAÍS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SideBarCurve
            // 
            this.SideBarCurve.ElipseRadius = 7;
            this.SideBarCurve.TargetControl = this.SideBar;
            // 
            // PanelChartCurve
            // 
            this.PanelChartCurve.ElipseRadius = 7;
            this.PanelChartCurve.TargetControl = this.PanelChart;
            // 
            // Covid
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SideBarWrapper);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Covid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid-19";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cases)).EndInit();
            this.MenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBar)).EndInit();
            this.SideBarWrapper.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CovidIcon2)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.PanelChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.ComboBox Datos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lConfirmed;
        private System.Windows.Forms.Label lpais;
        private System.Windows.Forms.Label lDeath;
        private System.Windows.Forms.Label lActive;
        private System.Windows.Forms.Label lPs;
        private System.Windows.Forms.Label lCd;
        private System.Windows.Forms.Label lDd;
        private System.Windows.Forms.Label lAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lRd;
        private System.Windows.Forms.DataVisualization.Charting.Chart Cases;
        public System.Windows.Forms.Label error;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SideBarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.PictureBox RestoreWindow;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Maximize;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox MenuSideBar;
        private Bunifu.Framework.UI.BunifuGradientPanel SideBar;
        private System.Windows.Forms.PictureBox CovidIcon2;
        private Bunifu.Framework.UI.BunifuSeparator SideBarLine;
        private System.Windows.Forms.Panel PanelChart;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse SideBarCurve;
        private Bunifu.Framework.UI.BunifuElipse PanelChartCurve;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}

