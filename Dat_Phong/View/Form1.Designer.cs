namespace Dat_Phong
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
            Calendar.DrawTool drawTool1 = new Calendar.DrawTool();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dayView1 = new Calendar.DayView();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnCreat = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbEnd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LbStart = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LbPosition = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxSize = new System.Windows.Forms.ComboBox();
            this.pnlAccout = new System.Windows.Forms.Panel();
            this.LbName = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnEditInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TrBrZoom = new System.Windows.Forms.TrackBar();
            this.TrBrDayToShow = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxRoom = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbxTheme = new System.Windows.Forms.ComboBox();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.PnlBackground = new System.Windows.Forms.Panel();
            this.PnlDayView = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PnlControl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlAccout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBrZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBrDayToShow)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            this.PnlBackground.SuspendLayout();
            this.PnlDayView.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayView1
            // 
            drawTool1.DayView = this.dayView1;
            this.dayView1.ActiveTool = drawTool1;
            this.dayView1.AllowInplaceEditing = false;
            this.dayView1.AllowNew = false;
            this.dayView1.DaysToShow = 5;
            this.dayView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayView1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dayView1.Location = new System.Drawing.Point(0, 0);
            this.dayView1.Name = "dayView1";
            this.dayView1.SelectedAppointment = null;
            this.dayView1.SelectionEnd = new System.DateTime(((long)(0)));
            this.dayView1.SelectionStart = new System.DateTime(((long)(0)));
            this.dayView1.Size = new System.Drawing.Size(858, 255);
            this.dayView1.StartDate = new System.DateTime(((long)(0)));
            this.dayView1.TabIndex = 10;
            this.dayView1.Text = "dayView1";
            this.dayView1.SelectionChanged += new System.EventHandler(this.dayView1_SelectionChanged);
            this.dayView1.ResolveAppointments += new Calendar.ResolveAppointmentsEventHandler(this.dayView1_ResolveAppointments);
            this.dayView1.NewAppointment += new Calendar.NewAppointmentEventHandler(this.dayView1_NewAppointment);
            this.dayView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dayView1_MouseMove);
            // 
            // PnlControl
            // 
            this.PnlControl.Controls.Add(this.panel2);
            this.PnlControl.Controls.Add(this.panel1);
            this.PnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PnlControl.Location = new System.Drawing.Point(0, 0);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(858, 263);
            this.PnlControl.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pnlAccout);
            this.panel2.Controls.Add(this.TrBrZoom);
            this.panel2.Controls.Add(this.TrBrDayToShow);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CbxRoom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(253, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 263);
            this.panel2.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnCreat);
            this.flowLayoutPanel1.Controls.Add(this.BtnEdit);
            this.flowLayoutPanel1.Controls.Add(this.BtnDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(140, 175);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 88);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // BtnCreat
            // 
            this.BtnCreat.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnCreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnCreat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCreat.Location = new System.Drawing.Point(3, 3);
            this.BtnCreat.Name = "BtnCreat";
            this.BtnCreat.Size = new System.Drawing.Size(100, 35);
            this.BtnCreat.TabIndex = 20;
            this.BtnCreat.Text = "Creat";
            this.BtnCreat.UseVisualStyleBackColor = false;
            this.BtnCreat.Click += new System.EventHandler(this.BtnCreat_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEdit.Location = new System.Drawing.Point(109, 3);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 35);
            this.BtnEdit.TabIndex = 23;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Location = new System.Drawing.Point(215, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 35);
            this.BtnDelete.TabIndex = 24;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.LbEnd);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.LbStart);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.LbPosition);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.CbxSize);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 263);
            this.panel3.TabIndex = 21;
            // 
            // LbEnd
            // 
            this.LbEnd.AutoSize = true;
            this.LbEnd.Location = new System.Drawing.Point(6, 245);
            this.LbEnd.Name = "LbEnd";
            this.LbEnd.Size = new System.Drawing.Size(22, 13);
            this.LbEnd.TabIndex = 23;
            this.LbEnd.Text = "[...]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(6, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "End:";
            // 
            // LbStart
            // 
            this.LbStart.AutoSize = true;
            this.LbStart.Location = new System.Drawing.Point(6, 209);
            this.LbStart.Name = "LbStart";
            this.LbStart.Size = new System.Drawing.Size(22, 13);
            this.LbStart.TabIndex = 23;
            this.LbStart.Text = "[...]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(6, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Start:";
            // 
            // LbPosition
            // 
            this.LbPosition.AutoSize = true;
            this.LbPosition.Location = new System.Drawing.Point(6, 173);
            this.LbPosition.Name = "LbPosition";
            this.LbPosition.Size = new System.Drawing.Size(22, 13);
            this.LbPosition.TabIndex = 23;
            this.LbPosition.Text = "[...]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Zoom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "DaysToShow :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Size :";
            // 
            // CbxSize
            // 
            this.CbxSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSize.FormattingEnabled = true;
            this.CbxSize.Location = new System.Drawing.Point(12, 36);
            this.CbxSize.Name = "CbxSize";
            this.CbxSize.Size = new System.Drawing.Size(105, 21);
            this.CbxSize.TabIndex = 19;
            this.CbxSize.SelectedIndexChanged += new System.EventHandler(this.CbxSize_SelectedIndexChanged);
            // 
            // pnlAccout
            // 
            this.pnlAccout.Controls.Add(this.LbName);
            this.pnlAccout.Controls.Add(this.BtnExit);
            this.pnlAccout.Controls.Add(this.BtnEditInfo);
            this.pnlAccout.Controls.Add(this.pictureBox1);
            this.pnlAccout.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAccout.Location = new System.Drawing.Point(470, 0);
            this.pnlAccout.Name = "pnlAccout";
            this.pnlAccout.Size = new System.Drawing.Size(135, 263);
            this.pnlAccout.TabIndex = 20;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Location = new System.Drawing.Point(7, 141);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(0, 13);
            this.LbName.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExit.Location = new System.Drawing.Point(17, 215);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(100, 35);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnEditInfo
            // 
            this.BtnEditInfo.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnEditInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditInfo.Location = new System.Drawing.Point(17, 175);
            this.BtnEditInfo.Name = "BtnEditInfo";
            this.BtnEditInfo.Size = new System.Drawing.Size(100, 35);
            this.BtnEditInfo.TabIndex = 1;
            this.BtnEditInfo.Text = "Info";
            this.BtnEditInfo.UseVisualStyleBackColor = false;
            this.BtnEditInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dat_Phong.Properties.Resources.nobody1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TrBrZoom
            // 
            this.TrBrZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrBrZoom.Location = new System.Drawing.Point(145, 124);
            this.TrBrZoom.Maximum = 40;
            this.TrBrZoom.Minimum = 8;
            this.TrBrZoom.Name = "TrBrZoom";
            this.TrBrZoom.Size = new System.Drawing.Size(278, 45);
            this.TrBrZoom.TabIndex = 16;
            this.TrBrZoom.Value = 18;
            this.TrBrZoom.Scroll += new System.EventHandler(this.TrBrZoom_Scroll);
            // 
            // TrBrDayToShow
            // 
            this.TrBrDayToShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrBrDayToShow.Location = new System.Drawing.Point(145, 73);
            this.TrBrDayToShow.Maximum = 31;
            this.TrBrDayToShow.Minimum = 1;
            this.TrBrDayToShow.Name = "TrBrDayToShow";
            this.TrBrDayToShow.Size = new System.Drawing.Size(278, 45);
            this.TrBrDayToShow.TabIndex = 15;
            this.TrBrDayToShow.Value = 3;
            this.TrBrDayToShow.Scroll += new System.EventHandler(this.TrBrDayToShow_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(153, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Room :";
            // 
            // CbxRoom
            // 
            this.CbxRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxRoom.FormattingEnabled = true;
            this.CbxRoom.Location = new System.Drawing.Point(156, 33);
            this.CbxRoom.Name = "CbxRoom";
            this.CbxRoom.Size = new System.Drawing.Size(246, 21);
            this.CbxRoom.TabIndex = 13;
            this.CbxRoom.SelectedIndexChanged += new System.EventHandler(this.CbxRoom_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CbxTheme);
            this.panel1.Controls.Add(this.calendarControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 263);
            this.panel1.TabIndex = 13;
            // 
            // CbxTheme
            // 
            this.CbxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTheme.FormattingEnabled = true;
            this.CbxTheme.Items.AddRange(new object[] {
            "Office 11",
            "Office 12"});
            this.CbxTheme.Location = new System.Drawing.Point(6, 238);
            this.CbxTheme.Name = "CbxTheme";
            this.CbxTheme.Size = new System.Drawing.Size(121, 21);
            this.CbxTheme.TabIndex = 19;
            this.CbxTheme.SelectedIndexChanged += new System.EventHandler(this.CbxTheme_SelectedIndexChanged);
            // 
            // calendarControl1
            // 
            this.calendarControl1.Appearance.BackColor = System.Drawing.Color.LawnGreen;
            this.calendarControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.calendarControl1.Appearance.Options.UseBackColor = true;
            this.calendarControl1.CalendarAppearance.DayCellSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.calendarControl1.CalendarAppearance.DayCellSelected.Options.UseBackColor = true;
            this.calendarControl1.CalendarAppearance.DayCellToday.BackColor = System.Drawing.Color.Red;
            this.calendarControl1.CalendarAppearance.DayCellToday.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calendarControl1.CalendarAppearance.DayCellToday.Options.UseBackColor = true;
            // 
            // 
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.calendarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarControl1.Location = new System.Drawing.Point(0, 0);
            this.calendarControl1.MinValue = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.ShowWeekNumbers = true;
            this.calendarControl1.Size = new System.Drawing.Size(253, 227);
            this.calendarControl1.TabIndex = 14;
            this.calendarControl1.SelectionChanged += new System.EventHandler(this.CalendarChanged);
            // 
            // PnlBackground
            // 
            this.PnlBackground.Controls.Add(this.PnlDayView);
            this.PnlBackground.Controls.Add(this.PnlControl);
            this.PnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBackground.Location = new System.Drawing.Point(0, 0);
            this.PnlBackground.Name = "PnlBackground";
            this.PnlBackground.Size = new System.Drawing.Size(858, 518);
            this.PnlBackground.TabIndex = 2;
            // 
            // PnlDayView
            // 
            this.PnlDayView.Controls.Add(this.dayView1);
            this.PnlDayView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDayView.Location = new System.Drawing.Point(0, 263);
            this.PnlDayView.Name = "PnlDayView";
            this.PnlDayView.Size = new System.Drawing.Size(858, 255);
            this.PnlDayView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 518);
            this.Controls.Add(this.PnlBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlControl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlAccout.ResumeLayout(false);
            this.pnlAccout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBrZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBrDayToShow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.PnlBackground.ResumeLayout(false);
            this.PnlDayView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlControl;
        private System.Windows.Forms.Panel PnlBackground;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar TrBrZoom;
        private System.Windows.Forms.TrackBar TrBrDayToShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CbxTheme;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private System.Windows.Forms.Panel pnlAccout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnEditInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxSize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnCreat;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LbEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LbStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Panel PnlDayView;
        private Calendar.DayView dayView1;
    }
}

