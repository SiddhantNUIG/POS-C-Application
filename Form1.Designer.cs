namespace Kandoi_SiddhantKumar_Assignment5_MS806
{
    partial class TeamBuilder
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EventLocationGroupBox1 = new System.Windows.Forms.GroupBox();
            this.LocationListBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EventListBox1 = new System.Windows.Forms.ListBox();
            this.MealOptionsListBox1 = new System.Windows.Forms.ListBox();
            this.lodgingFeesLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.registrationFeeLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.eventsLabel = new System.Windows.Forms.Label();
            this.ExitButton1 = new System.Windows.Forms.Button();
            this.CompleteOrderButton1 = new System.Windows.Forms.Button();
            this.ClearButton1 = new System.Windows.Forms.Button();
            this.AddToCartButton1 = new System.Windows.Forms.Button();
            this.locationCountPanel = new System.Windows.Forms.Panel();
            this.TotalItemCostValueLabel1 = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.NumberOfPlacesTextBox1 = new System.Windows.Forms.TextBox();
            this.PlacesInStockLabel = new System.Windows.Forms.Label();
            this.locationEventLabel = new System.Windows.Forms.Label();
            this.AvailablePlacesLabel1 = new System.Windows.Forms.Label();
            this.LocationPlacesLabel1 = new System.Windows.Forms.Label();
            this.LocationAvailableListbox1 = new System.Windows.Forms.ListBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.GenerateDetailedReportButton = new System.Windows.Forms.Button();
            this.BookingDetailsPanel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalBookingAmountAnsLabel1 = new System.Windows.Forms.Label();
            this.TotalBookingAmountLabel1 = new System.Windows.Forms.Label();
            this.addedBookingDetailsLabel = new System.Windows.Forms.Label();
            this.BookingListBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.EventLocationGroupBox1.SuspendLayout();
            this.locationCountPanel.SuspendLayout();
            this.BookingDetailsPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kandoi_SiddhantKumar_Assignment5_MS806.Properties.Resources.Assignment5_company;
            this.pictureBox1.InitialImage = global::Kandoi_SiddhantKumar_Assignment5_MS806.Properties.Resources.Assignment5_company;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 184);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // EventLocationGroupBox1
            // 
            this.EventLocationGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.EventLocationGroupBox1.Controls.Add(this.LocationListBox1);
            this.EventLocationGroupBox1.Controls.Add(this.label1);
            this.EventLocationGroupBox1.Controls.Add(this.EventListBox1);
            this.EventLocationGroupBox1.Controls.Add(this.MealOptionsListBox1);
            this.EventLocationGroupBox1.Controls.Add(this.lodgingFeesLabel);
            this.EventLocationGroupBox1.Controls.Add(this.locationLabel);
            this.EventLocationGroupBox1.Controls.Add(this.registrationFeeLabel);
            this.EventLocationGroupBox1.Controls.Add(this.daysLabel);
            this.EventLocationGroupBox1.Controls.Add(this.eventsLabel);
            this.EventLocationGroupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLocationGroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EventLocationGroupBox1.Location = new System.Drawing.Point(84, 217);
            this.EventLocationGroupBox1.Name = "EventLocationGroupBox1";
            this.EventLocationGroupBox1.Size = new System.Drawing.Size(1141, 358);
            this.EventLocationGroupBox1.TabIndex = 8;
            this.EventLocationGroupBox1.TabStop = false;
            this.EventLocationGroupBox1.Text = "Please select event and location to proceed";
            // 
            // LocationListBox1
            // 
            this.LocationListBox1.BackColor = System.Drawing.Color.LightCyan;
            this.LocationListBox1.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationListBox1.FormattingEnabled = true;
            this.LocationListBox1.ItemHeight = 20;
            this.LocationListBox1.Items.AddRange(new object[] {
            "Cork\t\t\t\t€250",
            "Dublin\t\t\t\t€165",
            "Galway\t\t\t\t€225",
            "Belmullet\t\t\t\t€305",
            "Belfast\t\t\t\t€95"});
            this.LocationListBox1.Location = new System.Drawing.Point(711, 117);
            this.LocationListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.LocationListBox1.Name = "LocationListBox1";
            this.LocationListBox1.Size = new System.Drawing.Size(402, 104);
            this.LocationListBox1.TabIndex = 22;
            this.LocationListBox1.SelectedIndexChanged += new System.EventHandler(this.LocationListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Meal Options";
            // 
            // EventListBox1
            // 
            this.EventListBox1.BackColor = System.Drawing.Color.LightCyan;
            this.EventListBox1.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListBox1.FormattingEnabled = true;
            this.EventListBox1.ItemHeight = 20;
            this.EventListBox1.Items.AddRange(new object[] {
            "Murder Mystery Weekend\t\t2\t€600",
            "CSI Weekend\t\t\t3\t€1,000",
            "The Great Outdoors\t                \t4           €1,500",
            "The Chase\t\t\t                 6            €1,800",
            "Digital Refresh\t\t\t2\t€599",
            "Action Photography\t       \t               5              €999",
            "Team Ryder Cup\t\t\t3\t€619",
            "Abseiling\t\t\t\t2\t€499",
            "War Games\t\t\t6\t€1,999",
            "Find Wally\t\t\t5\t€799"});
            this.EventListBox1.Location = new System.Drawing.Point(7, 117);
            this.EventListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.EventListBox1.Name = "EventListBox1";
            this.EventListBox1.Size = new System.Drawing.Size(490, 204);
            this.EventListBox1.TabIndex = 21;
            this.EventListBox1.SelectedIndexChanged += new System.EventHandler(this.EventListBox1_SelectedIndexChanged);
            // 
            // MealOptionsListBox1
            // 
            this.MealOptionsListBox1.BackColor = System.Drawing.Color.LightCyan;
            this.MealOptionsListBox1.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealOptionsListBox1.FormattingEnabled = true;
            this.MealOptionsListBox1.ItemHeight = 20;
            this.MealOptionsListBox1.Items.AddRange(new object[] {
            "Full Meal    €49.50",
            "Half Meal   €37.50",
            "Breakfast   €12",
            "No Meal     €0"});
            this.MealOptionsListBox1.Location = new System.Drawing.Point(521, 117);
            this.MealOptionsListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.MealOptionsListBox1.Name = "MealOptionsListBox1";
            this.MealOptionsListBox1.Size = new System.Drawing.Size(173, 84);
            this.MealOptionsListBox1.TabIndex = 11;
            this.MealOptionsListBox1.SelectedIndexChanged += new System.EventHandler(this.MealOptionsListBox1_SelectedIndexChanged);
            // 
            // lodgingFeesLabel
            // 
            this.lodgingFeesLabel.AutoSize = true;
            this.lodgingFeesLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodgingFeesLabel.Location = new System.Drawing.Point(894, 76);
            this.lodgingFeesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lodgingFeesLabel.Name = "lodgingFeesLabel";
            this.lodgingFeesLabel.Size = new System.Drawing.Size(166, 21);
            this.lodgingFeesLabel.TabIndex = 10;
            this.lodgingFeesLabel.Text = "Lodging Fees Per Day";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(707, 76);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(69, 21);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location";
            // 
            // registrationFeeLabel
            // 
            this.registrationFeeLabel.AutoSize = true;
            this.registrationFeeLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationFeeLabel.Location = new System.Drawing.Point(351, 76);
            this.registrationFeeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrationFeeLabel.Name = "registrationFeeLabel";
            this.registrationFeeLabel.Size = new System.Drawing.Size(128, 21);
            this.registrationFeeLabel.TabIndex = 8;
            this.registrationFeeLabel.Text = "Registration Fee";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(233, 76);
            this.daysLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(44, 21);
            this.daysLabel.TabIndex = 7;
            this.daysLabel.Text = "Days";
            // 
            // eventsLabel
            // 
            this.eventsLabel.AutoSize = true;
            this.eventsLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsLabel.Location = new System.Drawing.Point(34, 76);
            this.eventsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(49, 21);
            this.eventsLabel.TabIndex = 6;
            this.eventsLabel.Text = "Event";
            // 
            // ExitButton1
            // 
            this.ExitButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton1.Location = new System.Drawing.Point(1617, 147);
            this.ExitButton1.Name = "ExitButton1";
            this.ExitButton1.Size = new System.Drawing.Size(109, 34);
            this.ExitButton1.TabIndex = 15;
            this.ExitButton1.Text = "&Exit";
            this.ExitButton1.UseVisualStyleBackColor = true;
            this.ExitButton1.Click += new System.EventHandler(this.ExitButton1_Click);
            // 
            // CompleteOrderButton1
            // 
            this.CompleteOrderButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CompleteOrderButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteOrderButton1.Location = new System.Drawing.Point(1264, 658);
            this.CompleteOrderButton1.Name = "CompleteOrderButton1";
            this.CompleteOrderButton1.Size = new System.Drawing.Size(177, 34);
            this.CompleteOrderButton1.TabIndex = 14;
            this.CompleteOrderButton1.Text = "&Complete Order";
            this.CompleteOrderButton1.UseVisualStyleBackColor = true;
            this.CompleteOrderButton1.Click += new System.EventHandler(this.CompleteOrderButton1_Click);
            // 
            // ClearButton1
            // 
            this.ClearButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClearButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton1.Location = new System.Drawing.Point(1617, 86);
            this.ClearButton1.Name = "ClearButton1";
            this.ClearButton1.Size = new System.Drawing.Size(109, 34);
            this.ClearButton1.TabIndex = 13;
            this.ClearButton1.Text = "&Clear";
            this.ClearButton1.UseVisualStyleBackColor = true;
            this.ClearButton1.Click += new System.EventHandler(this.ClearButton1_Click);
            // 
            // AddToCartButton1
            // 
            this.AddToCartButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddToCartButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartButton1.Location = new System.Drawing.Point(1264, 600);
            this.AddToCartButton1.Name = "AddToCartButton1";
            this.AddToCartButton1.Size = new System.Drawing.Size(177, 34);
            this.AddToCartButton1.TabIndex = 16;
            this.AddToCartButton1.Text = "&Add To Booking";
            this.AddToCartButton1.UseVisualStyleBackColor = true;
            this.AddToCartButton1.Click += new System.EventHandler(this.AddToCartButton1_Click);
            // 
            // locationCountPanel
            // 
            this.locationCountPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locationCountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.locationCountPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationCountPanel.Controls.Add(this.TotalItemCostValueLabel1);
            this.locationCountPanel.Controls.Add(this.TotalCostLabel);
            this.locationCountPanel.Controls.Add(this.NumberOfPlacesTextBox1);
            this.locationCountPanel.Controls.Add(this.PlacesInStockLabel);
            this.locationCountPanel.Controls.Add(this.locationEventLabel);
            this.locationCountPanel.Controls.Add(this.AvailablePlacesLabel1);
            this.locationCountPanel.Controls.Add(this.LocationPlacesLabel1);
            this.locationCountPanel.Controls.Add(this.LocationAvailableListbox1);
            this.locationCountPanel.Controls.Add(this.QuantityLabel);
            this.locationCountPanel.Location = new System.Drawing.Point(1054, 213);
            this.locationCountPanel.Margin = new System.Windows.Forms.Padding(4);
            this.locationCountPanel.Name = "locationCountPanel";
            this.locationCountPanel.Size = new System.Drawing.Size(607, 362);
            this.locationCountPanel.TabIndex = 19;
            // 
            // TotalItemCostValueLabel1
            // 
            this.TotalItemCostValueLabel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.TotalItemCostValueLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalItemCostValueLabel1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemCostValueLabel1.ForeColor = System.Drawing.Color.Black;
            this.TotalItemCostValueLabel1.Location = new System.Drawing.Point(367, 292);
            this.TotalItemCostValueLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalItemCostValueLabel1.Name = "TotalItemCostValueLabel1";
            this.TotalItemCostValueLabel1.Size = new System.Drawing.Size(178, 51);
            this.TotalItemCostValueLabel1.TabIndex = 8;
            this.TotalItemCostValueLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.TotalCostLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLabel.Location = new System.Drawing.Point(139, 304);
            this.TotalCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(172, 27);
            this.TotalCostLabel.TabIndex = 7;
            this.TotalCostLabel.Text = "Item Event Cost:";
            // 
            // NumberOfPlacesTextBox1
            // 
            this.NumberOfPlacesTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPlacesTextBox1.Location = new System.Drawing.Point(428, 212);
            this.NumberOfPlacesTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.NumberOfPlacesTextBox1.Name = "NumberOfPlacesTextBox1";
            this.NumberOfPlacesTextBox1.Size = new System.Drawing.Size(69, 30);
            this.NumberOfPlacesTextBox1.TabIndex = 26;
            this.NumberOfPlacesTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfPlacesTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberOfPlacesTextBox1_MouseClick);
            this.NumberOfPlacesTextBox1.TextChanged += new System.EventHandler(this.NumberOfPlacesTextBox1_TextChanged);
            // 
            // PlacesInStockLabel
            // 
            this.PlacesInStockLabel.AutoSize = true;
            this.PlacesInStockLabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.PlacesInStockLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacesInStockLabel.Location = new System.Drawing.Point(4, 14);
            this.PlacesInStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlacesInStockLabel.Name = "PlacesInStockLabel";
            this.PlacesInStockLabel.Size = new System.Drawing.Size(164, 27);
            this.PlacesInStockLabel.TabIndex = 25;
            this.PlacesInStockLabel.Text = "Places In Stock:";
            // 
            // locationEventLabel
            // 
            this.locationEventLabel.AutoSize = true;
            this.locationEventLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationEventLabel.Location = new System.Drawing.Point(31, 55);
            this.locationEventLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationEventLabel.Name = "locationEventLabel";
            this.locationEventLabel.Size = new System.Drawing.Size(49, 21);
            this.locationEventLabel.TabIndex = 24;
            this.locationEventLabel.Text = "Event";
            // 
            // AvailablePlacesLabel1
            // 
            this.AvailablePlacesLabel1.AutoSize = true;
            this.AvailablePlacesLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailablePlacesLabel1.Location = new System.Drawing.Point(374, 55);
            this.AvailablePlacesLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvailablePlacesLabel1.Name = "AvailablePlacesLabel1";
            this.AvailablePlacesLabel1.Size = new System.Drawing.Size(123, 21);
            this.AvailablePlacesLabel1.TabIndex = 21;
            this.AvailablePlacesLabel1.Text = "Available Places";
            // 
            // LocationPlacesLabel1
            // 
            this.LocationPlacesLabel1.AutoSize = true;
            this.LocationPlacesLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationPlacesLabel1.Location = new System.Drawing.Point(233, 55);
            this.LocationPlacesLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocationPlacesLabel1.Name = "LocationPlacesLabel1";
            this.LocationPlacesLabel1.Size = new System.Drawing.Size(69, 21);
            this.LocationPlacesLabel1.TabIndex = 19;
            this.LocationPlacesLabel1.Text = "Location";
            // 
            // LocationAvailableListbox1
            // 
            this.LocationAvailableListbox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.LocationAvailableListbox1.Enabled = false;
            this.LocationAvailableListbox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationAvailableListbox1.FormattingEnabled = true;
            this.LocationAvailableListbox1.ItemHeight = 21;
            this.LocationAvailableListbox1.Location = new System.Drawing.Point(4, 79);
            this.LocationAvailableListbox1.Margin = new System.Windows.Forms.Padding(4);
            this.LocationAvailableListbox1.Name = "LocationAvailableListbox1";
            this.LocationAvailableListbox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LocationAvailableListbox1.Size = new System.Drawing.Size(592, 88);
            this.LocationAvailableListbox1.TabIndex = 18;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.QuantityLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(30, 197);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(358, 54);
            this.QuantityLabel.TabIndex = 17;
            this.QuantityLabel.Text = "Enter the number of Places\r\n   for the chosen Event and location:";
            // 
            // GenerateDetailedReportButton
            // 
            this.GenerateDetailedReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateDetailedReportButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateDetailedReportButton.Location = new System.Drawing.Point(1264, 716);
            this.GenerateDetailedReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateDetailedReportButton.Name = "GenerateDetailedReportButton";
            this.GenerateDetailedReportButton.Size = new System.Drawing.Size(177, 40);
            this.GenerateDetailedReportButton.TabIndex = 13;
            this.GenerateDetailedReportButton.Text = "&Generate Report";
            this.GenerateDetailedReportButton.UseVisualStyleBackColor = true;
            this.GenerateDetailedReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // BookingDetailsPanel1
            // 
            this.BookingDetailsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BookingDetailsPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookingDetailsPanel1.Controls.Add(this.label5);
            this.BookingDetailsPanel1.Controls.Add(this.label4);
            this.BookingDetailsPanel1.Controls.Add(this.label3);
            this.BookingDetailsPanel1.Controls.Add(this.label2);
            this.BookingDetailsPanel1.Controls.Add(this.TotalBookingAmountAnsLabel1);
            this.BookingDetailsPanel1.Controls.Add(this.TotalBookingAmountLabel1);
            this.BookingDetailsPanel1.Controls.Add(this.addedBookingDetailsLabel);
            this.BookingDetailsPanel1.Controls.Add(this.BookingListBox1);
            this.BookingDetailsPanel1.Location = new System.Drawing.Point(584, 600);
            this.BookingDetailsPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.BookingDetailsPanel1.Name = "BookingDetailsPanel1";
            this.BookingDetailsPanel1.Size = new System.Drawing.Size(584, 384);
            this.BookingDetailsPanel1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Event Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Number of Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Event";
            // 
            // TotalBookingAmountAnsLabel1
            // 
            this.TotalBookingAmountAnsLabel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.TotalBookingAmountAnsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalBookingAmountAnsLabel1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBookingAmountAnsLabel1.ForeColor = System.Drawing.Color.Black;
            this.TotalBookingAmountAnsLabel1.Location = new System.Drawing.Point(376, 319);
            this.TotalBookingAmountAnsLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalBookingAmountAnsLabel1.Name = "TotalBookingAmountAnsLabel1";
            this.TotalBookingAmountAnsLabel1.Size = new System.Drawing.Size(149, 38);
            this.TotalBookingAmountAnsLabel1.TabIndex = 29;
            this.TotalBookingAmountAnsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalBookingAmountLabel1
            // 
            this.TotalBookingAmountLabel1.AutoSize = true;
            this.TotalBookingAmountLabel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.TotalBookingAmountLabel1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBookingAmountLabel1.Location = new System.Drawing.Point(97, 325);
            this.TotalBookingAmountLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalBookingAmountLabel1.Name = "TotalBookingAmountLabel1";
            this.TotalBookingAmountLabel1.Size = new System.Drawing.Size(235, 27);
            this.TotalBookingAmountLabel1.TabIndex = 28;
            this.TotalBookingAmountLabel1.Text = "Total Booking Amount : ";
            // 
            // addedBookingDetailsLabel
            // 
            this.addedBookingDetailsLabel.AutoSize = true;
            this.addedBookingDetailsLabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.addedBookingDetailsLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedBookingDetailsLabel.Location = new System.Drawing.Point(4, 14);
            this.addedBookingDetailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addedBookingDetailsLabel.Name = "addedBookingDetailsLabel";
            this.addedBookingDetailsLabel.Size = new System.Drawing.Size(225, 27);
            this.addedBookingDetailsLabel.TabIndex = 25;
            this.addedBookingDetailsLabel.Text = "Added Booking Details:";
            // 
            // BookingListBox1
            // 
            this.BookingListBox1.BackColor = System.Drawing.Color.LightCyan;
            this.BookingListBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingListBox1.FormattingEnabled = true;
            this.BookingListBox1.ItemHeight = 21;
            this.BookingListBox1.Location = new System.Drawing.Point(4, 101);
            this.BookingListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.BookingListBox1.Name = "BookingListBox1";
            this.BookingListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.BookingListBox1.Size = new System.Drawing.Size(574, 193);
            this.BookingListBox1.TabIndex = 18;
            // 
            // TeamBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1881, 1055);
            this.Controls.Add(this.BookingDetailsPanel1);
            this.Controls.Add(this.GenerateDetailedReportButton);
            this.Controls.Add(this.locationCountPanel);
            this.Controls.Add(this.AddToCartButton1);
            this.Controls.Add(this.ExitButton1);
            this.Controls.Add(this.CompleteOrderButton1);
            this.Controls.Add(this.ClearButton1);
            this.Controls.Add(this.EventLocationGroupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TeamBuilder";
            this.Text = "Team Builder v2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamBuilder_FormClosing);
            this.Load += new System.EventHandler(this.TeamBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.EventLocationGroupBox1.ResumeLayout(false);
            this.EventLocationGroupBox1.PerformLayout();
            this.locationCountPanel.ResumeLayout(false);
            this.locationCountPanel.PerformLayout();
            this.BookingDetailsPanel1.ResumeLayout(false);
            this.BookingDetailsPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox EventLocationGroupBox1;
        private System.Windows.Forms.Button CompleteOrderButton1;
        private System.Windows.Forms.Button ExitButton1;
        private System.Windows.Forms.Button ClearButton1;
        private System.Windows.Forms.Button AddToCartButton1;
        private System.Windows.Forms.Label eventsLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label registrationFeeLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label lodgingFeesLabel;
        private System.Windows.Forms.ListBox MealOptionsListBox1;
        private System.Windows.Forms.Panel locationCountPanel;
        private System.Windows.Forms.Label PlacesInStockLabel;
        private System.Windows.Forms.Label locationEventLabel;
        private System.Windows.Forms.Label AvailablePlacesLabel1;
        private System.Windows.Forms.Label LocationPlacesLabel1;
        private System.Windows.Forms.ListBox LocationAvailableListbox1;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox NumberOfPlacesTextBox1;
        private System.Windows.Forms.Button GenerateDetailedReportButton;
        private System.Windows.Forms.Label TotalItemCostValueLabel1;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.ListBox EventListBox1;
        private System.Windows.Forms.Panel BookingDetailsPanel1;
        private System.Windows.Forms.Label addedBookingDetailsLabel;
        private System.Windows.Forms.ListBox BookingListBox1;
        private System.Windows.Forms.Label TotalBookingAmountAnsLabel1;
        private System.Windows.Forms.Label TotalBookingAmountLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LocationListBox1;
    }
}

