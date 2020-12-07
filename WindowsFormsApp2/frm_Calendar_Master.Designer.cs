namespace WindowsFormsApp2
{
    partial class frm_Calendar_Master
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
            this.components = new System.ComponentModel.Container();
            this.DayOrWeek = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Re = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_Agent = new System.Windows.Forms.ComboBox();
            this.cb_Team = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Dept = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Button_PrevDay = new System.Windows.Forms.Button();
            this.AgentID = new System.Windows.Forms.TextBox();
            this.LabelDayOff = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Button_NextDay = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.section10_11 = new System.Windows.Forms.Label();
            this.section11_12 = new System.Windows.Forms.Label();
            this.section12_13 = new System.Windows.Forms.Label();
            this.section13_14 = new System.Windows.Forms.Label();
            this.section14_15 = new System.Windows.Forms.Label();
            this.section16_17 = new System.Windows.Forms.Label();
            this.section15_16 = new System.Windows.Forms.Label();
            this.section17_18 = new System.Windows.Forms.Label();
            this.section18_19 = new System.Windows.Forms.Label();
            this.section19_20 = new System.Windows.Forms.Label();
            this.section20_21 = new System.Windows.Forms.Label();
            this.section9_10 = new System.Windows.Forms.Label();
            this.Cell9 = new System.Windows.Forms.FlowLayoutPanel();
            this.NewTaskMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewTaskItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cell10 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell11 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell12 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell13 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell14 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell15 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell16 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell17 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell18 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell19 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell20 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_wd1 = new System.Windows.Forms.Label();
            this.lb_wd2 = new System.Windows.Forms.Label();
            this.lb_wd3 = new System.Windows.Forms.Label();
            this.lb_wd4 = new System.Windows.Forms.Label();
            this.lb_wd5 = new System.Windows.Forms.Label();
            this.lb_wd6 = new System.Windows.Forms.Label();
            this.lb_wd7 = new System.Windows.Forms.Label();
            this.CellWeekday1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CellWeekday2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CellWeekday3 = new System.Windows.Forms.FlowLayoutPanel();
            this.CellWeekday4 = new System.Windows.Forms.FlowLayoutPanel();
            this.CellWeekday5 = new System.Windows.Forms.FlowLayoutPanel();
            this.CellWeekday6 = new System.Windows.Forms.FlowLayoutPanel();
            this.CellWeekday7 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_Re1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_Agent1 = new System.Windows.Forms.ComboBox();
            this.cb_Team1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Dept1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.Button_LastWeek = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Button_NextWeek = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DayOrWeek.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.NewTaskMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DayOrWeek
            // 
            this.DayOrWeek.Controls.Add(this.tabPage1);
            this.DayOrWeek.Controls.Add(this.tabPage2);
            this.DayOrWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DayOrWeek.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DayOrWeek.Location = new System.Drawing.Point(0, 0);
            this.DayOrWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DayOrWeek.Name = "DayOrWeek";
            this.DayOrWeek.SelectedIndex = 0;
            this.DayOrWeek.Size = new System.Drawing.Size(1177, 551);
            this.DayOrWeek.TabIndex = 2;
            this.DayOrWeek.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.DayOrWeek_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1169, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "每日";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_Re);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Button_PrevDay);
            this.panel1.Controls.Add(this.AgentID);
            this.panel1.Controls.Add(this.LabelDayOff);
            this.panel1.Controls.Add(this.DateTimePicker1);
            this.panel1.Controls.Add(this.Button_NextDay);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 118);
            this.panel1.TabIndex = 1;
            // 
            // bt_Re
            // 
            this.bt_Re.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Re.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Re.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Re.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_Re.Location = new System.Drawing.Point(744, 2);
            this.bt_Re.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Re.Name = "bt_Re";
            this.bt_Re.Size = new System.Drawing.Size(100, 49);
            this.bt_Re.TabIndex = 44;
            this.bt_Re.Text = "刷新";
            this.bt_Re.UseVisualStyleBackColor = false;
            this.bt_Re.Click += new System.EventHandler(this.bt_Re_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cb_Agent);
            this.panel2.Controls.Add(this.cb_Team);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cb_Dept);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(9, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 58);
            this.panel2.TabIndex = 43;
            // 
            // cb_Agent
            // 
            this.cb_Agent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_Agent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Agent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Agent.FormattingEnabled = true;
            this.cb_Agent.Location = new System.Drawing.Point(615, 9);
            this.cb_Agent.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Agent.Name = "cb_Agent";
            this.cb_Agent.Size = new System.Drawing.Size(219, 33);
            this.cb_Agent.TabIndex = 39;
            // 
            // cb_Team
            // 
            this.cb_Team.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_Team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Team.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Team.FormattingEnabled = true;
            this.cb_Team.Location = new System.Drawing.Point(336, 9);
            this.cb_Team.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Team.Name = "cb_Team";
            this.cb_Team.Size = new System.Drawing.Size(219, 33);
            this.cb_Team.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(564, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "業務";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(284, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "小隊";
            // 
            // cb_Dept
            // 
            this.cb_Dept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Dept.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Dept.FormattingEnabled = true;
            this.cb_Dept.Location = new System.Drawing.Point(56, 9);
            this.cb_Dept.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Dept.Name = "cb_Dept";
            this.cb_Dept.Size = new System.Drawing.Size(219, 33);
            this.cb_Dept.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "部門";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(843, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Button_PrevDay
            // 
            this.Button_PrevDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_PrevDay.AutoSize = true;
            this.Button_PrevDay.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.Button_PrevDay.Location = new System.Drawing.Point(213, 2);
            this.Button_PrevDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_PrevDay.Name = "Button_PrevDay";
            this.Button_PrevDay.Size = new System.Drawing.Size(61, 44);
            this.Button_PrevDay.TabIndex = 1;
            this.Button_PrevDay.Text = "<<";
            this.Button_PrevDay.UseVisualStyleBackColor = true;
            this.Button_PrevDay.Click += new System.EventHandler(this.Button_PrevDay_Click);
            // 
            // AgentID
            // 
            this.AgentID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AgentID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgentID.Location = new System.Drawing.Point(603, 5);
            this.AgentID.Margin = new System.Windows.Forms.Padding(4);
            this.AgentID.MaxLength = 6;
            this.AgentID.Name = "AgentID";
            this.AgentID.Size = new System.Drawing.Size(132, 39);
            this.AgentID.TabIndex = 4;
            this.AgentID.Text = "103270";
            // 
            // LabelDayOff
            // 
            this.LabelDayOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelDayOff.AutoSize = true;
            this.LabelDayOff.Enabled = false;
            this.LabelDayOff.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelDayOff.Location = new System.Drawing.Point(13, 6);
            this.LabelDayOff.Name = "LabelDayOff";
            this.LabelDayOff.Size = new System.Drawing.Size(188, 38);
            this.LabelDayOff.TabIndex = 3;
            this.LabelDayOff.Text = "labelDayOff";
            this.LabelDayOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDayOff.Visible = false;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DateTimePicker1.Location = new System.Drawing.Point(276, 4);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(237, 41);
            this.DateTimePicker1.TabIndex = 2;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // Button_NextDay
            // 
            this.Button_NextDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_NextDay.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.Button_NextDay.Location = new System.Drawing.Point(520, 2);
            this.Button_NextDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_NextDay.Name = "Button_NextDay";
            this.Button_NextDay.Size = new System.Drawing.Size(57, 44);
            this.Button_NextDay.TabIndex = 1;
            this.Button_NextDay.Text = ">>";
            this.Button_NextDay.UseVisualStyleBackColor = true;
            this.Button_NextDay.Click += new System.EventHandler(this.Button_NextDay_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.section10_11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.section11_12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.section12_13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.section13_14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.section14_15, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.section16_17, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.section15_16, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.section17_18, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.section18_19, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.section19_20, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.section20_21, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.section9_10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cell9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cell10, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cell11, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Cell12, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Cell13, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Cell14, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Cell15, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Cell16, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Cell17, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.Cell18, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.Cell19, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.Cell20, 1, 11);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 129);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1161, 381);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // section10_11
            // 
            this.section10_11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section10_11.AutoSize = true;
            this.section10_11.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.section10_11.Location = new System.Drawing.Point(4, 106);
            this.section10_11.Name = "section10_11";
            this.section10_11.Size = new System.Drawing.Size(181, 104);
            this.section10_11.TabIndex = 1;
            this.section10_11.Text = "10:00 - 11:00";
            this.section10_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section11_12
            // 
            this.section11_12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section11_12.AutoSize = true;
            this.section11_12.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.section11_12.Location = new System.Drawing.Point(4, 211);
            this.section11_12.Name = "section11_12";
            this.section11_12.Size = new System.Drawing.Size(181, 104);
            this.section11_12.TabIndex = 1;
            this.section11_12.Text = "11:00 - 12:00";
            this.section11_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section12_13
            // 
            this.section12_13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section12_13.AutoSize = true;
            this.section12_13.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.section12_13.Location = new System.Drawing.Point(4, 316);
            this.section12_13.Name = "section12_13";
            this.section12_13.Size = new System.Drawing.Size(181, 104);
            this.section12_13.TabIndex = 1;
            this.section12_13.Text = "12:00 - 13:00";
            this.section12_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section13_14
            // 
            this.section13_14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section13_14.AutoSize = true;
            this.section13_14.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.section13_14.Location = new System.Drawing.Point(4, 421);
            this.section13_14.Name = "section13_14";
            this.section13_14.Size = new System.Drawing.Size(181, 104);
            this.section13_14.TabIndex = 1;
            this.section13_14.Text = "13:00 - 14:00";
            this.section13_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section14_15
            // 
            this.section14_15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section14_15.AutoSize = true;
            this.section14_15.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.section14_15.Location = new System.Drawing.Point(4, 526);
            this.section14_15.Name = "section14_15";
            this.section14_15.Size = new System.Drawing.Size(181, 104);
            this.section14_15.TabIndex = 1;
            this.section14_15.Text = "14:00 - 15:00";
            this.section14_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section16_17
            // 
            this.section16_17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section16_17.AutoSize = true;
            this.section16_17.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.section16_17.Location = new System.Drawing.Point(4, 736);
            this.section16_17.Name = "section16_17";
            this.section16_17.Size = new System.Drawing.Size(181, 104);
            this.section16_17.TabIndex = 1;
            this.section16_17.Text = "16:00 - 17:00";
            this.section16_17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section15_16
            // 
            this.section15_16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section15_16.AutoSize = true;
            this.section15_16.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.section15_16.Location = new System.Drawing.Point(4, 631);
            this.section15_16.Name = "section15_16";
            this.section15_16.Size = new System.Drawing.Size(181, 104);
            this.section15_16.TabIndex = 1;
            this.section15_16.Text = "15:00 - 16:00";
            this.section15_16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section17_18
            // 
            this.section17_18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section17_18.AutoSize = true;
            this.section17_18.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.section17_18.Location = new System.Drawing.Point(4, 841);
            this.section17_18.Name = "section17_18";
            this.section17_18.Size = new System.Drawing.Size(181, 104);
            this.section17_18.TabIndex = 1;
            this.section17_18.Text = "17:00 - 18:00";
            this.section17_18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section18_19
            // 
            this.section18_19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section18_19.AutoSize = true;
            this.section18_19.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.section18_19.Location = new System.Drawing.Point(4, 946);
            this.section18_19.Name = "section18_19";
            this.section18_19.Size = new System.Drawing.Size(181, 104);
            this.section18_19.TabIndex = 1;
            this.section18_19.Text = "18:00 - 19:00";
            this.section18_19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section19_20
            // 
            this.section19_20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section19_20.AutoSize = true;
            this.section19_20.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.section19_20.Location = new System.Drawing.Point(4, 1051);
            this.section19_20.Name = "section19_20";
            this.section19_20.Size = new System.Drawing.Size(181, 104);
            this.section19_20.TabIndex = 1;
            this.section19_20.Text = "19:00 - 20:00";
            this.section19_20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section20_21
            // 
            this.section20_21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section20_21.AutoSize = true;
            this.section20_21.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.section20_21.Location = new System.Drawing.Point(4, 1156);
            this.section20_21.Name = "section20_21";
            this.section20_21.Size = new System.Drawing.Size(181, 104);
            this.section20_21.TabIndex = 1;
            this.section20_21.Text = "20:00 - 21:00";
            this.section20_21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section9_10
            // 
            this.section9_10.AutoSize = true;
            this.section9_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.section9_10.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.section9_10.Location = new System.Drawing.Point(4, 1);
            this.section9_10.Name = "section9_10";
            this.section9_10.Size = new System.Drawing.Size(181, 104);
            this.section9_10.TabIndex = 1;
            this.section9_10.Text = "9:00 - 10:00";
            this.section9_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell9
            // 
            this.Cell9.AutoScroll = true;
            this.Cell9.AutoSize = true;
            this.Cell9.ContextMenuStrip = this.NewTaskMenu;
            this.Cell9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell9.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cell9.Location = new System.Drawing.Point(192, 3);
            this.Cell9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell9.MinimumSize = new System.Drawing.Size(865, 100);
            this.Cell9.Name = "Cell9";
            this.Cell9.Size = new System.Drawing.Size(944, 100);
            this.Cell9.TabIndex = 2;
            // 
            // NewTaskMenu
            // 
            this.NewTaskMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NewTaskMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTaskItem});
            this.NewTaskMenu.Name = "NewTaskMenu";
            this.NewTaskMenu.Size = new System.Drawing.Size(139, 44);
            // 
            // NewTaskItem
            // 
            this.NewTaskItem.AutoSize = false;
            this.NewTaskItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.NewTaskItem.Name = "NewTaskItem";
            this.NewTaskItem.Size = new System.Drawing.Size(210, 40);
            this.NewTaskItem.Text = "新增";
            this.NewTaskItem.Click += new System.EventHandler(this.NewTaskItem_Click);
            // 
            // Cell10
            // 
            this.Cell10.AutoScroll = true;
            this.Cell10.AutoSize = true;
            this.Cell10.ContextMenuStrip = this.NewTaskMenu;
            this.Cell10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell10.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cell10.Location = new System.Drawing.Point(192, 108);
            this.Cell10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell10.MinimumSize = new System.Drawing.Size(865, 100);
            this.Cell10.Name = "Cell10";
            this.Cell10.Size = new System.Drawing.Size(944, 100);
            this.Cell10.TabIndex = 3;
            // 
            // Cell11
            // 
            this.Cell11.AutoScroll = true;
            this.Cell11.AutoSize = true;
            this.Cell11.ContextMenuStrip = this.NewTaskMenu;
            this.Cell11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell11.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cell11.Location = new System.Drawing.Point(192, 213);
            this.Cell11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell11.MinimumSize = new System.Drawing.Size(865, 100);
            this.Cell11.Name = "Cell11";
            this.Cell11.Size = new System.Drawing.Size(944, 100);
            this.Cell11.TabIndex = 4;
            // 
            // Cell12
            // 
            this.Cell12.AutoScroll = true;
            this.Cell12.AutoSize = true;
            this.Cell12.ContextMenuStrip = this.NewTaskMenu;
            this.Cell12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell12.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cell12.Location = new System.Drawing.Point(192, 318);
            this.Cell12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell12.MinimumSize = new System.Drawing.Size(865, 100);
            this.Cell12.Name = "Cell12";
            this.Cell12.Size = new System.Drawing.Size(944, 100);
            this.Cell12.TabIndex = 5;
            // 
            // Cell13
            // 
            this.Cell13.AutoScroll = true;
            this.Cell13.AutoSize = true;
            this.Cell13.ContextMenuStrip = this.NewTaskMenu;
            this.Cell13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell13.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cell13.Location = new System.Drawing.Point(192, 423);
            this.Cell13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell13.MinimumSize = new System.Drawing.Size(865, 100);
            this.Cell13.Name = "Cell13";
            this.Cell13.Size = new System.Drawing.Size(944, 100);
            this.Cell13.TabIndex = 6;
            // 
            // Cell14
            // 
            this.Cell14.AutoScroll = true;
            this.Cell14.AutoSize = true;
            this.Cell14.ContextMenuStrip = this.NewTaskMenu;
            this.Cell14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell14.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cell14.Location = new System.Drawing.Point(192, 528);
            this.Cell14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell14.MinimumSize = new System.Drawing.Size(865, 100);
            this.Cell14.Name = "Cell14";
            this.Cell14.Size = new System.Drawing.Size(944, 100);
            this.Cell14.TabIndex = 7;
            // 
            // Cell15
            // 
            this.Cell15.AutoScroll = true;
            this.Cell15.AutoSize = true;
            this.Cell15.ContextMenuStrip = this.NewTaskMenu;
            this.Cell15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell15.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cell15.Location = new System.Drawing.Point(192, 633);
            this.Cell15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell15.MinimumSize = new System.Drawing.Size(865, 100);
            this.Cell15.Name = "Cell15";
            this.Cell15.Size = new System.Drawing.Size(944, 100);
            this.Cell15.TabIndex = 8;
            // 
            // Cell16
            // 
            this.Cell16.AutoScroll = true;
            this.Cell16.AutoSize = true;
            this.Cell16.ContextMenuStrip = this.NewTaskMenu;
            this.Cell16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell16.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cell16.Location = new System.Drawing.Point(192, 738);
            this.Cell16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell16.MinimumSize = new System.Drawing.Size(865, 100);
            this.Cell16.Name = "Cell16";
            this.Cell16.Size = new System.Drawing.Size(944, 100);
            this.Cell16.TabIndex = 9;
            // 
            // Cell17
            // 
            this.Cell17.AutoScroll = true;
            this.Cell17.AutoSize = true;
            this.Cell17.ContextMenuStrip = this.NewTaskMenu;
            this.Cell17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell17.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cell17.Location = new System.Drawing.Point(192, 843);
            this.Cell17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell17.MinimumSize = new System.Drawing.Size(865, 100);
            this.Cell17.Name = "Cell17";
            this.Cell17.Size = new System.Drawing.Size(944, 100);
            this.Cell17.TabIndex = 10;
            // 
            // Cell18
            // 
            this.Cell18.AutoScroll = true;
            this.Cell18.AutoSize = true;
            this.Cell18.ContextMenuStrip = this.NewTaskMenu;
            this.Cell18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell18.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cell18.Location = new System.Drawing.Point(192, 948);
            this.Cell18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell18.MinimumSize = new System.Drawing.Size(865, 100);
            this.Cell18.Name = "Cell18";
            this.Cell18.Size = new System.Drawing.Size(944, 100);
            this.Cell18.TabIndex = 11;
            // 
            // Cell19
            // 
            this.Cell19.AutoScroll = true;
            this.Cell19.AutoSize = true;
            this.Cell19.ContextMenuStrip = this.NewTaskMenu;
            this.Cell19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell19.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cell19.Location = new System.Drawing.Point(192, 1053);
            this.Cell19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell19.MinimumSize = new System.Drawing.Size(865, 100);
            this.Cell19.Name = "Cell19";
            this.Cell19.Size = new System.Drawing.Size(944, 100);
            this.Cell19.TabIndex = 12;
            // 
            // Cell20
            // 
            this.Cell20.AutoScroll = true;
            this.Cell20.AutoSize = true;
            this.Cell20.ContextMenuStrip = this.NewTaskMenu;
            this.Cell20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell20.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cell20.Location = new System.Drawing.Point(192, 1158);
            this.Cell20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell20.MinimumSize = new System.Drawing.Size(865, 100);
            this.Cell20.Name = "Cell20";
            this.Cell20.Size = new System.Drawing.Size(944, 100);
            this.Cell20.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1169, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "每週";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lb_wd1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_wd2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_wd3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_wd4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_wd5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_wd6, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_wd7, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.CellWeekday1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.CellWeekday2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.CellWeekday3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.CellWeekday4, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.CellWeekday5, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.CellWeekday6, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.CellWeekday7, 6, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 127);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1163, 390);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lb_wd1
            // 
            this.lb_wd1.AutoSize = true;
            this.lb_wd1.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lb_wd1.Location = new System.Drawing.Point(4, 1);
            this.lb_wd1.Name = "lb_wd1";
            this.lb_wd1.Size = new System.Drawing.Size(142, 34);
            this.lb_wd1.TabIndex = 0;
            this.lb_wd1.Text = "weekday1";
            // 
            // lb_wd2
            // 
            this.lb_wd2.AutoSize = true;
            this.lb_wd2.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lb_wd2.Location = new System.Drawing.Point(177, 1);
            this.lb_wd2.Name = "lb_wd2";
            this.lb_wd2.Size = new System.Drawing.Size(142, 34);
            this.lb_wd2.TabIndex = 0;
            this.lb_wd2.Text = "weekday2";
            // 
            // lb_wd3
            // 
            this.lb_wd3.AutoSize = true;
            this.lb_wd3.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lb_wd3.Location = new System.Drawing.Point(350, 1);
            this.lb_wd3.Name = "lb_wd3";
            this.lb_wd3.Size = new System.Drawing.Size(142, 34);
            this.lb_wd3.TabIndex = 0;
            this.lb_wd3.Text = "weekday3";
            // 
            // lb_wd4
            // 
            this.lb_wd4.AutoSize = true;
            this.lb_wd4.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lb_wd4.Location = new System.Drawing.Point(523, 1);
            this.lb_wd4.Name = "lb_wd4";
            this.lb_wd4.Size = new System.Drawing.Size(142, 34);
            this.lb_wd4.TabIndex = 0;
            this.lb_wd4.Text = "weekday4";
            // 
            // lb_wd5
            // 
            this.lb_wd5.AutoSize = true;
            this.lb_wd5.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lb_wd5.Location = new System.Drawing.Point(696, 1);
            this.lb_wd5.Name = "lb_wd5";
            this.lb_wd5.Size = new System.Drawing.Size(142, 34);
            this.lb_wd5.TabIndex = 0;
            this.lb_wd5.Text = "weekday5";
            // 
            // lb_wd6
            // 
            this.lb_wd6.AutoSize = true;
            this.lb_wd6.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lb_wd6.Location = new System.Drawing.Point(869, 1);
            this.lb_wd6.Name = "lb_wd6";
            this.lb_wd6.Size = new System.Drawing.Size(142, 34);
            this.lb_wd6.TabIndex = 0;
            this.lb_wd6.Text = "weekday6";
            // 
            // lb_wd7
            // 
            this.lb_wd7.AutoSize = true;
            this.lb_wd7.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lb_wd7.Location = new System.Drawing.Point(1042, 1);
            this.lb_wd7.Name = "lb_wd7";
            this.lb_wd7.Size = new System.Drawing.Size(142, 34);
            this.lb_wd7.TabIndex = 0;
            this.lb_wd7.Text = "weekday7";
            // 
            // CellWeekday1
            // 
            this.CellWeekday1.AutoScroll = true;
            this.CellWeekday1.AutoSize = true;
            this.CellWeekday1.Location = new System.Drawing.Point(4, 39);
            this.CellWeekday1.MinimumSize = new System.Drawing.Size(166, 325);
            this.CellWeekday1.Name = "CellWeekday1";
            this.CellWeekday1.Size = new System.Drawing.Size(166, 325);
            this.CellWeekday1.TabIndex = 1;
            // 
            // CellWeekday2
            // 
            this.CellWeekday2.AutoScroll = true;
            this.CellWeekday2.AutoSize = true;
            this.CellWeekday2.Location = new System.Drawing.Point(177, 39);
            this.CellWeekday2.MinimumSize = new System.Drawing.Size(166, 325);
            this.CellWeekday2.Name = "CellWeekday2";
            this.CellWeekday2.Size = new System.Drawing.Size(166, 325);
            this.CellWeekday2.TabIndex = 2;
            // 
            // CellWeekday3
            // 
            this.CellWeekday3.AutoScroll = true;
            this.CellWeekday3.AutoSize = true;
            this.CellWeekday3.Location = new System.Drawing.Point(350, 39);
            this.CellWeekday3.MinimumSize = new System.Drawing.Size(166, 325);
            this.CellWeekday3.Name = "CellWeekday3";
            this.CellWeekday3.Size = new System.Drawing.Size(166, 325);
            this.CellWeekday3.TabIndex = 3;
            // 
            // CellWeekday4
            // 
            this.CellWeekday4.AutoScroll = true;
            this.CellWeekday4.AutoSize = true;
            this.CellWeekday4.Location = new System.Drawing.Point(523, 39);
            this.CellWeekday4.MinimumSize = new System.Drawing.Size(166, 325);
            this.CellWeekday4.Name = "CellWeekday4";
            this.CellWeekday4.Size = new System.Drawing.Size(166, 325);
            this.CellWeekday4.TabIndex = 4;
            // 
            // CellWeekday5
            // 
            this.CellWeekday5.AutoScroll = true;
            this.CellWeekday5.AutoSize = true;
            this.CellWeekday5.Location = new System.Drawing.Point(696, 39);
            this.CellWeekday5.MinimumSize = new System.Drawing.Size(166, 325);
            this.CellWeekday5.Name = "CellWeekday5";
            this.CellWeekday5.Size = new System.Drawing.Size(166, 325);
            this.CellWeekday5.TabIndex = 5;
            // 
            // CellWeekday6
            // 
            this.CellWeekday6.AutoScroll = true;
            this.CellWeekday6.AutoSize = true;
            this.CellWeekday6.Location = new System.Drawing.Point(869, 39);
            this.CellWeekday6.MinimumSize = new System.Drawing.Size(166, 325);
            this.CellWeekday6.Name = "CellWeekday6";
            this.CellWeekday6.Size = new System.Drawing.Size(166, 325);
            this.CellWeekday6.TabIndex = 6;
            // 
            // CellWeekday7
            // 
            this.CellWeekday7.AutoScroll = true;
            this.CellWeekday7.AutoSize = true;
            this.CellWeekday7.Location = new System.Drawing.Point(1042, 39);
            this.CellWeekday7.MinimumSize = new System.Drawing.Size(166, 325);
            this.CellWeekday7.Name = "CellWeekday7";
            this.CellWeekday7.Size = new System.Drawing.Size(166, 325);
            this.CellWeekday7.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bt_Re1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.Button_LastWeek);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.Button_NextWeek);
            this.panel3.Location = new System.Drawing.Point(3, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1163, 118);
            this.panel3.TabIndex = 2;
            // 
            // bt_Re1
            // 
            this.bt_Re1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Re1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Re1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Re1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_Re1.Location = new System.Drawing.Point(744, 2);
            this.bt_Re1.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Re1.Name = "bt_Re1";
            this.bt_Re1.Size = new System.Drawing.Size(100, 49);
            this.bt_Re1.TabIndex = 44;
            this.bt_Re1.Text = "刷新";
            this.bt_Re1.UseVisualStyleBackColor = false;
            this.bt_Re1.Click += new System.EventHandler(this.bt_Re_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.cb_Agent1);
            this.panel4.Controls.Add(this.cb_Team1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cb_Dept1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnSearch1);
            this.panel4.Location = new System.Drawing.Point(9, 55);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1147, 58);
            this.panel4.TabIndex = 43;
            // 
            // cb_Agent1
            // 
            this.cb_Agent1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_Agent1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Agent1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Agent1.FormattingEnabled = true;
            this.cb_Agent1.Location = new System.Drawing.Point(615, 9);
            this.cb_Agent1.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Agent1.Name = "cb_Agent1";
            this.cb_Agent1.Size = new System.Drawing.Size(219, 33);
            this.cb_Agent1.TabIndex = 39;
            // 
            // cb_Team1
            // 
            this.cb_Team1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_Team1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Team1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Team1.FormattingEnabled = true;
            this.cb_Team1.Location = new System.Drawing.Point(336, 9);
            this.cb_Team1.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Team1.Name = "cb_Team1";
            this.cb_Team1.Size = new System.Drawing.Size(219, 33);
            this.cb_Team1.TabIndex = 44;
            this.cb_Team1.SelectedIndexChanged += new System.EventHandler(this.cb_Squad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(564, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "業務";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(284, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "小隊";
            // 
            // cb_Dept1
            // 
            this.cb_Dept1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_Dept1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Dept1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Dept1.FormattingEnabled = true;
            this.cb_Dept1.Location = new System.Drawing.Point(56, 9);
            this.cb_Dept1.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Dept1.Name = "cb_Dept1";
            this.cb_Dept1.Size = new System.Drawing.Size(219, 33);
            this.cb_Dept1.TabIndex = 41;
            this.cb_Dept1.SelectedIndexChanged += new System.EventHandler(this.cb_Dept_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "部門";
            // 
            // btnSearch1
            // 
            this.btnSearch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch1.Location = new System.Drawing.Point(843, 10);
            this.btnSearch1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(100, 36);
            this.btnSearch1.TabIndex = 40;
            this.btnSearch1.Text = "查詢";
            this.btnSearch1.UseVisualStyleBackColor = false;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Button_LastWeek
            // 
            this.Button_LastWeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_LastWeek.AutoSize = true;
            this.Button_LastWeek.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.Button_LastWeek.Location = new System.Drawing.Point(213, 2);
            this.Button_LastWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_LastWeek.Name = "Button_LastWeek";
            this.Button_LastWeek.Size = new System.Drawing.Size(61, 44);
            this.Button_LastWeek.TabIndex = 1;
            this.Button_LastWeek.Text = "<<";
            this.Button_LastWeek.UseVisualStyleBackColor = true;
            this.Button_LastWeek.Click += new System.EventHandler(this.Button_LastWeek_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(603, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 39);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "103270";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(13, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "labelDayOff";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker2.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker2.Location = new System.Drawing.Point(276, 4);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(237, 41);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Button_NextWeek
            // 
            this.Button_NextWeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_NextWeek.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.Button_NextWeek.Location = new System.Drawing.Point(520, 2);
            this.Button_NextWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_NextWeek.Name = "Button_NextWeek";
            this.Button_NextWeek.Size = new System.Drawing.Size(57, 44);
            this.Button_NextWeek.TabIndex = 1;
            this.Button_NextWeek.Text = ">>";
            this.Button_NextWeek.UseVisualStyleBackColor = true;
            this.Button_NextWeek.Click += new System.EventHandler(this.Button_NextWeek_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // frm_Calendar_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 551);
            this.Controls.Add(this.DayOrWeek);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Calendar_Master";
            this.Text = "行事曆";
            this.Load += new System.EventHandler(this.frm_Calendar_Master_Load);
            this.DayOrWeek.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.NewTaskMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl DayOrWeek;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelDayOff;
        public System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Button Button_NextDay;
        private System.Windows.Forms.Button Button_PrevDay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label section10_11;
        private System.Windows.Forms.Label section11_12;
        private System.Windows.Forms.Label section12_13;
        private System.Windows.Forms.Label section13_14;
        private System.Windows.Forms.Label section14_15;
        private System.Windows.Forms.Label section16_17;
        private System.Windows.Forms.Label section15_16;
        private System.Windows.Forms.Label section17_18;
        private System.Windows.Forms.Label section18_19;
        private System.Windows.Forms.Label section19_20;
        private System.Windows.Forms.Label section20_21;
        private System.Windows.Forms.Label section9_10;
        private System.Windows.Forms.FlowLayoutPanel Cell9;
        private System.Windows.Forms.FlowLayoutPanel Cell10;
        private System.Windows.Forms.FlowLayoutPanel Cell11;
        private System.Windows.Forms.FlowLayoutPanel Cell12;
        private System.Windows.Forms.FlowLayoutPanel Cell13;
        private System.Windows.Forms.FlowLayoutPanel Cell14;
        private System.Windows.Forms.FlowLayoutPanel Cell15;
        private System.Windows.Forms.FlowLayoutPanel Cell16;
        private System.Windows.Forms.FlowLayoutPanel Cell17;
        private System.Windows.Forms.FlowLayoutPanel Cell18;
        private System.Windows.Forms.FlowLayoutPanel Cell19;
        private System.Windows.Forms.FlowLayoutPanel Cell20;
        private System.Windows.Forms.TextBox AgentID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_Team;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Dept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cb_Agent;
        private System.Windows.Forms.Button bt_Re;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_Re1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_Agent1;
        private System.Windows.Forms.ComboBox cb_Team1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Dept1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Button Button_LastWeek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Button_NextWeek;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_wd1;
        private System.Windows.Forms.Label lb_wd2;
        private System.Windows.Forms.Label lb_wd3;
        private System.Windows.Forms.Label lb_wd4;
        private System.Windows.Forms.Label lb_wd5;
        private System.Windows.Forms.Label lb_wd6;
        private System.Windows.Forms.Label lb_wd7;
        private System.Windows.Forms.ContextMenuStrip NewTaskMenu;
        private System.Windows.Forms.ToolStripMenuItem NewTaskItem;
        private System.Windows.Forms.FlowLayoutPanel CellWeekday1;
        private System.Windows.Forms.FlowLayoutPanel CellWeekday2;
        private System.Windows.Forms.FlowLayoutPanel CellWeekday3;
        private System.Windows.Forms.FlowLayoutPanel CellWeekday4;
        private System.Windows.Forms.FlowLayoutPanel CellWeekday5;
        private System.Windows.Forms.FlowLayoutPanel CellWeekday6;
        private System.Windows.Forms.FlowLayoutPanel CellWeekday7;
    }
}