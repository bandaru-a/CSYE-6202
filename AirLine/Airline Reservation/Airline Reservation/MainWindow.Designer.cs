namespace Airline_Reservation
{
    partial class MainWindow
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnBookedHistory = new System.Windows.Forms.Button();
            this.btnflights = new System.Windows.Forms.Button();
            this.tabControl1 = new Airline_Reservation.MyTab();
            this.tabBookTicket = new System.Windows.Forms.TabPage();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnBookAnotherTicket = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtBoxFare = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgPassenger = new System.Windows.Forms.DataGridView();
            this.comBoxClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxDepartureTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxArrivalTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxFlightId = new System.Windows.Forms.TextBox();
            this.lblFlightId = new System.Windows.Forms.Label();
            this.txtBoxTicketNo = new System.Windows.Forms.TextBox();
            this.lblTicketNo = new System.Windows.Forms.Label();
            this.comBoxDestination = new System.Windows.Forms.ComboBox();
            this.lblDestiation = new System.Windows.Forms.Label();
            this.cmboxSource = new System.Windows.Forms.ComboBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.tabBookedHistory = new System.Windows.Forms.TabPage();
            this.btnUnbookPassener = new System.Windows.Forms.Button();
            this.btnUnBookTicket = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgPassengers = new System.Windows.Forms.DataGridView();
            this.dgTickets = new System.Windows.Forms.DataGridView();
            this.tabFlightsInfo = new System.Windows.Forms.TabPage();
            this.btnPassengers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdateFlight = new System.Windows.Forms.Button();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.dgFlights = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBookTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPassenger)).BeginInit();
            this.tabBookedHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTickets)).BeginInit();
            this.tabFlightsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.PeachPuff;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(231, 779);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBookTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookTicket.Location = new System.Drawing.Point(0, 76);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(231, 40);
            this.btnBookTicket.TabIndex = 1;
            this.btnBookTicket.Text = "Book Ticket";
            this.btnBookTicket.UseVisualStyleBackColor = false;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblGreeting);
            this.panel1.Location = new System.Drawing.Point(232, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 60);
            this.panel1.TabIndex = 3;
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(963, 7);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(40, 17);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello";
            // 
            // btnBookedHistory
            // 
            this.btnBookedHistory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBookedHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookedHistory.Location = new System.Drawing.Point(0, 122);
            this.btnBookedHistory.Name = "btnBookedHistory";
            this.btnBookedHistory.Size = new System.Drawing.Size(231, 40);
            this.btnBookedHistory.TabIndex = 4;
            this.btnBookedHistory.Text = "Booked History";
            this.btnBookedHistory.UseVisualStyleBackColor = false;
            this.btnBookedHistory.Click += new System.EventHandler(this.btnBookedHistory_Click);
            // 
            // btnflights
            // 
            this.btnflights.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnflights.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnflights.Location = new System.Drawing.Point(-1, 168);
            this.btnflights.Name = "btnflights";
            this.btnflights.Size = new System.Drawing.Size(231, 40);
            this.btnflights.TabIndex = 5;
            this.btnflights.Text = "Flights";
            this.btnflights.UseVisualStyleBackColor = false;
            this.btnflights.Click += new System.EventHandler(this.btnflights_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBookTicket);
            this.tabControl1.Controls.Add(this.tabBookedHistory);
            this.tabControl1.Controls.Add(this.tabFlightsInfo);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(238, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1144, 712);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 6;
            // 
            // tabBookTicket
            // 
            this.tabBookTicket.BackColor = System.Drawing.Color.Goldenrod;
            this.tabBookTicket.Controls.Add(this.btnCalculate);
            this.tabBookTicket.Controls.Add(this.btnBookAnotherTicket);
            this.tabBookTicket.Controls.Add(this.btnOK);
            this.tabBookTicket.Controls.Add(this.txtBoxFare);
            this.tabBookTicket.Controls.Add(this.label6);
            this.tabBookTicket.Controls.Add(this.btnRemove);
            this.tabBookTicket.Controls.Add(this.dgPassenger);
            this.tabBookTicket.Controls.Add(this.comBoxClass);
            this.tabBookTicket.Controls.Add(this.label4);
            this.tabBookTicket.Controls.Add(this.txtBoxDepartureTime);
            this.tabBookTicket.Controls.Add(this.label3);
            this.tabBookTicket.Controls.Add(this.txtBoxArrivalTime);
            this.tabBookTicket.Controls.Add(this.label2);
            this.tabBookTicket.Controls.Add(this.txtBoxFlightId);
            this.tabBookTicket.Controls.Add(this.lblFlightId);
            this.tabBookTicket.Controls.Add(this.txtBoxTicketNo);
            this.tabBookTicket.Controls.Add(this.lblTicketNo);
            this.tabBookTicket.Controls.Add(this.comBoxDestination);
            this.tabBookTicket.Controls.Add(this.lblDestiation);
            this.tabBookTicket.Controls.Add(this.cmboxSource);
            this.tabBookTicket.Controls.Add(this.lblSource);
            this.tabBookTicket.Location = new System.Drawing.Point(4, 25);
            this.tabBookTicket.Name = "tabBookTicket";
            this.tabBookTicket.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookTicket.Size = new System.Drawing.Size(1136, 683);
            this.tabBookTicket.TabIndex = 1;
            this.tabBookTicket.Text = "Book Ticket";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 631);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(148, 23);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate Fare";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnBookAnotherTicket
            // 
            this.btnBookAnotherTicket.Location = new System.Drawing.Point(709, 620);
            this.btnBookAnotherTicket.Name = "btnBookAnotherTicket";
            this.btnBookAnotherTicket.Size = new System.Drawing.Size(177, 34);
            this.btnBookAnotherTicket.TabIndex = 22;
            this.btnBookAnotherTicket.Text = "Book Another Ticket";
            this.btnBookAnotherTicket.UseVisualStyleBackColor = true;
            this.btnBookAnotherTicket.Click += new System.EventHandler(this.btnBookAnotherTicket_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(577, 623);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 34);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtBoxFare
            // 
            this.txtBoxFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFare.Location = new System.Drawing.Point(308, 628);
            this.txtBoxFare.Name = "txtBoxFare";
            this.txtBoxFare.ReadOnly = true;
            this.txtBoxFare.Size = new System.Drawing.Size(156, 26);
            this.txtBoxFare.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(217, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Fare";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(25, 335);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgPassenger
            // 
            this.dgPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPassenger.Location = new System.Drawing.Point(132, 206);
            this.dgPassenger.Name = "dgPassenger";
            this.dgPassenger.RowTemplate.Height = 24;
            this.dgPassenger.Size = new System.Drawing.Size(754, 398);
            this.dgPassenger.TabIndex = 15;
            // 
            // comBoxClass
            // 
            this.comBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxClass.FormattingEnabled = true;
            this.comBoxClass.Location = new System.Drawing.Point(496, 94);
            this.comBoxClass.Name = "comBoxClass";
            this.comBoxClass.Size = new System.Drawing.Size(156, 28);
            this.comBoxClass.TabIndex = 14;
            this.comBoxClass.SelectedIndexChanged += new System.EventHandler(this.comBoxClass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Class :";
            // 
            // txtBoxDepartureTime
            // 
            this.txtBoxDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDepartureTime.Location = new System.Drawing.Point(536, 151);
            this.txtBoxDepartureTime.Name = "txtBoxDepartureTime";
            this.txtBoxDepartureTime.ReadOnly = true;
            this.txtBoxDepartureTime.Size = new System.Drawing.Size(213, 26);
            this.txtBoxDepartureTime.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Departure Time";
            // 
            // txtBoxArrivalTime
            // 
            this.txtBoxArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxArrivalTime.Location = new System.Drawing.Point(132, 148);
            this.txtBoxArrivalTime.Name = "txtBoxArrivalTime";
            this.txtBoxArrivalTime.ReadOnly = true;
            this.txtBoxArrivalTime.Size = new System.Drawing.Size(213, 26);
            this.txtBoxArrivalTime.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Arrival time";
            // 
            // txtBoxFlightId
            // 
            this.txtBoxFlightId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFlightId.Location = new System.Drawing.Point(132, 96);
            this.txtBoxFlightId.Name = "txtBoxFlightId";
            this.txtBoxFlightId.ReadOnly = true;
            this.txtBoxFlightId.Size = new System.Drawing.Size(213, 26);
            this.txtBoxFlightId.TabIndex = 8;
            this.txtBoxFlightId.Text = " ";
            // 
            // lblFlightId
            // 
            this.lblFlightId.AutoSize = true;
            this.lblFlightId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightId.Location = new System.Drawing.Point(32, 96);
            this.lblFlightId.Name = "lblFlightId";
            this.lblFlightId.Size = new System.Drawing.Size(68, 20);
            this.lblFlightId.TabIndex = 7;
            this.lblFlightId.Text = "Flight Id";
            // 
            // txtBoxTicketNo
            // 
            this.txtBoxTicketNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTicketNo.Location = new System.Drawing.Point(134, 31);
            this.txtBoxTicketNo.Name = "txtBoxTicketNo";
            this.txtBoxTicketNo.ReadOnly = true;
            this.txtBoxTicketNo.Size = new System.Drawing.Size(244, 26);
            this.txtBoxTicketNo.TabIndex = 6;
            // 
            // lblTicketNo
            // 
            this.lblTicketNo.AutoSize = true;
            this.lblTicketNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketNo.Location = new System.Drawing.Point(32, 33);
            this.lblTicketNo.Name = "lblTicketNo";
            this.lblTicketNo.Size = new System.Drawing.Size(95, 20);
            this.lblTicketNo.TabIndex = 5;
            this.lblTicketNo.Text = "Ticket No : ";
            // 
            // comBoxDestination
            // 
            this.comBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxDestination.FormattingEnabled = true;
            this.comBoxDestination.Location = new System.Drawing.Point(764, 27);
            this.comBoxDestination.Name = "comBoxDestination";
            this.comBoxDestination.Size = new System.Drawing.Size(150, 28);
            this.comBoxDestination.TabIndex = 3;
            this.comBoxDestination.SelectedValueChanged += new System.EventHandler(this.comBoxDestination_SelectedValueChanged);
            // 
            // lblDestiation
            // 
            this.lblDestiation.AutoSize = true;
            this.lblDestiation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestiation.Location = new System.Drawing.Point(659, 31);
            this.lblDestiation.Name = "lblDestiation";
            this.lblDestiation.Size = new System.Drawing.Size(99, 20);
            this.lblDestiation.TabIndex = 2;
            this.lblDestiation.Text = "Destination:";
            // 
            // cmboxSource
            // 
            this.cmboxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxSource.FormattingEnabled = true;
            this.cmboxSource.Location = new System.Drawing.Point(496, 31);
            this.cmboxSource.Name = "cmboxSource";
            this.cmboxSource.Size = new System.Drawing.Size(156, 28);
            this.cmboxSource.TabIndex = 1;
            this.cmboxSource.SelectedValueChanged += new System.EventHandler(this.cmboxSource_SelectedValueChanged);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(392, 31);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(72, 20);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source :";
            // 
            // tabBookedHistory
            // 
            this.tabBookedHistory.BackColor = System.Drawing.Color.Goldenrod;
            this.tabBookedHistory.Controls.Add(this.btnUnbookPassener);
            this.tabBookedHistory.Controls.Add(this.btnUnBookTicket);
            this.tabBookedHistory.Controls.Add(this.label8);
            this.tabBookedHistory.Controls.Add(this.label7);
            this.tabBookedHistory.Controls.Add(this.label5);
            this.tabBookedHistory.Controls.Add(this.dgPassengers);
            this.tabBookedHistory.Controls.Add(this.dgTickets);
            this.tabBookedHistory.Location = new System.Drawing.Point(4, 25);
            this.tabBookedHistory.Name = "tabBookedHistory";
            this.tabBookedHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookedHistory.Size = new System.Drawing.Size(1136, 683);
            this.tabBookedHistory.TabIndex = 1;
            this.tabBookedHistory.Text = "Booked History";
            // 
            // btnUnbookPassener
            // 
            this.btnUnbookPassener.Location = new System.Drawing.Point(648, 602);
            this.btnUnbookPassener.Name = "btnUnbookPassener";
            this.btnUnbookPassener.Size = new System.Drawing.Size(191, 43);
            this.btnUnbookPassener.TabIndex = 6;
            this.btnUnbookPassener.Text = "UnBook Passenger";
            this.btnUnbookPassener.UseVisualStyleBackColor = true;
            this.btnUnbookPassener.Click += new System.EventHandler(this.btnUnbookPassener_Click);
            // 
            // btnUnBookTicket
            // 
            this.btnUnBookTicket.Location = new System.Drawing.Point(55, 611);
            this.btnUnBookTicket.Name = "btnUnBookTicket";
            this.btnUnBookTicket.Size = new System.Drawing.Size(133, 43);
            this.btnUnBookTicket.TabIndex = 5;
            this.btnUnBookTicket.Text = "UnBook Ticket";
            this.btnUnBookTicket.UseVisualStyleBackColor = true;
            this.btnUnBookTicket.Click += new System.EventHandler(this.btnUnBookTicket_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(644, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Passengers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tickets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(545, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Booked History";
            // 
            // dgPassengers
            // 
            this.dgPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPassengers.Location = new System.Drawing.Point(648, 86);
            this.dgPassengers.Name = "dgPassengers";
            this.dgPassengers.RowTemplate.Height = 24;
            this.dgPassengers.Size = new System.Drawing.Size(466, 492);
            this.dgPassengers.TabIndex = 1;
            // 
            // dgTickets
            // 
            this.dgTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTickets.Location = new System.Drawing.Point(51, 86);
            this.dgTickets.Name = "dgTickets";
            this.dgTickets.RowTemplate.Height = 24;
            this.dgTickets.Size = new System.Drawing.Size(570, 492);
            this.dgTickets.TabIndex = 0;
            this.dgTickets.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // tabFlightsInfo
            // 
            this.tabFlightsInfo.BackColor = System.Drawing.Color.Goldenrod;
            this.tabFlightsInfo.Controls.Add(this.btnPassengers);
            this.tabFlightsInfo.Controls.Add(this.label1);
            this.tabFlightsInfo.Controls.Add(this.button2);
            this.tabFlightsInfo.Controls.Add(this.button1);
            this.tabFlightsInfo.Controls.Add(this.btnUpdateFlight);
            this.tabFlightsInfo.Controls.Add(this.btnDeleteFlight);
            this.tabFlightsInfo.Controls.Add(this.btnAddFlight);
            this.tabFlightsInfo.Controls.Add(this.dgFlights);
            this.tabFlightsInfo.Location = new System.Drawing.Point(4, 25);
            this.tabFlightsInfo.Name = "tabFlightsInfo";
            this.tabFlightsInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlightsInfo.Size = new System.Drawing.Size(1136, 683);
            this.tabFlightsInfo.TabIndex = 0;
            this.tabFlightsInfo.Text = "Flights";
            // 
            // btnPassengers
            // 
            this.btnPassengers.Location = new System.Drawing.Point(20, 211);
            this.btnPassengers.Name = "btnPassengers";
            this.btnPassengers.Size = new System.Drawing.Size(114, 40);
            this.btnPassengers.TabIndex = 7;
            this.btnPassengers.Text = "Passengers";
            this.btnPassengers.UseVisualStyleBackColor = true;
            this.btnPassengers.Click += new System.EventHandler(this.btnPassengers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Flights Information";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Fare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crew";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateFlight
            // 
            this.btnUpdateFlight.Location = new System.Drawing.Point(20, 409);
            this.btnUpdateFlight.Name = "btnUpdateFlight";
            this.btnUpdateFlight.Size = new System.Drawing.Size(114, 40);
            this.btnUpdateFlight.TabIndex = 3;
            this.btnUpdateFlight.Text = "Update Flight";
            this.btnUpdateFlight.UseVisualStyleBackColor = true;
            this.btnUpdateFlight.Visible = false;
            this.btnUpdateFlight.Click += new System.EventHandler(this.btnUpdateFlight_Click);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.Location = new System.Drawing.Point(20, 342);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(114, 40);
            this.btnDeleteFlight.TabIndex = 2;
            this.btnDeleteFlight.Text = "Delete Flight";
            this.btnDeleteFlight.UseVisualStyleBackColor = true;
            this.btnDeleteFlight.Visible = false;
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Location = new System.Drawing.Point(20, 276);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(114, 40);
            this.btnAddFlight.TabIndex = 1;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Visible = false;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // dgFlights
            // 
            this.dgFlights.AllowUserToAddRows = false;
            this.dgFlights.AllowUserToDeleteRows = false;
            this.dgFlights.AllowUserToOrderColumns = true;
            this.dgFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFlights.Location = new System.Drawing.Point(158, 76);
            this.dgFlights.Name = "dgFlights";
            this.dgFlights.RowTemplate.Height = 24;
            this.dgFlights.Size = new System.Drawing.Size(955, 601);
            this.dgFlights.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1382, 779);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnflights);
            this.Controls.Add(this.btnBookedHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBookTicket);
            this.Controls.Add(this.splitter1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabBookTicket.ResumeLayout(false);
            this.tabBookTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPassenger)).EndInit();
            this.tabBookedHistory.ResumeLayout(false);
            this.tabBookedHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTickets)).EndInit();
            this.tabFlightsInfo.ResumeLayout(false);
            this.tabFlightsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlights)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBookedHistory;
        private System.Windows.Forms.Button btnflights;
        private Airline_Reservation.MyTab tabControl1;
        private System.Windows.Forms.TabPage tabFlightsInfo;
        private System.Windows.Forms.TabPage tabBookedHistory;
        private System.Windows.Forms.TabPage tabBookTicket;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.DataGridView dgFlights;
        private System.Windows.Forms.Button btnUpdateFlight;
        private System.Windows.Forms.Button btnDeleteFlight;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxDestination;
        private System.Windows.Forms.Label lblDestiation;
        private System.Windows.Forms.ComboBox cmboxSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtBoxTicketNo;
        private System.Windows.Forms.Label lblTicketNo;
        private System.Windows.Forms.TextBox txtBoxDepartureTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxArrivalTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxFlightId;
        private System.Windows.Forms.Label lblFlightId;
        private System.Windows.Forms.ComboBox comBoxClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgPassenger;
        private System.Windows.Forms.Button btnBookAnotherTicket;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtBoxFare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnPassengers;
        private System.Windows.Forms.DataGridView dgPassengers;
        private System.Windows.Forms.DataGridView dgTickets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnBookTicket;
        private System.Windows.Forms.Button btnUnbookPassener;

    }
}