using Microsoft.ApplicationBlocks.Data;
using Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frm_Calendar_Master : Form
    {
        
        public frm_Calendar_Master()
        {
            InitializeComponent();
            setcombobox();
            cb_Dept.SelectedIndexChanged += cb_Dept_SelectedIndexChanged;
            cb_Team.SelectedIndexChanged += cb_Squad_SelectedIndexChanged;
        }
        DateTime date = DateTime.Today;
        String timeNowStr = DateTime.Now.ToString("HHmm");
        DataTable Table_Holiday;
        DataTable Table_Holiday_Per;
        DataTable Table_Personal;
        DataTable Table_Activity;
        int refreshTime = 10;
        List<FlowLayoutPanel> listCell;

        private void frm_Calendar_Master_Load(object sender, EventArgs e)
        {
            String dateStr = date.ToString("yyyy/MM/dd");
            // Console.WriteLine(date);

            #region 抓現在時間，控制捲軸初始位置
            int timeNow = Int16.Parse(timeNowStr);
            Label timeSection = new Label();
            // dateToday.Text = dateStr;
            // Console.WriteLine(timeNow / 100);    //檢查現在時間
            // 判斷現在時間點決定捲軸Y位置
            if (timeNow / 100 < 8)
            {
                timeSection = section9_10;
            }
            else if (timeNow / 100 > 21)
            {
                timeSection = section20_21;
            }
            else
            {
                switch (timeNow / 100)
                {
                    case 8:
                        timeSection = section9_10;
                        break;
                    case 9:
                        timeSection = section9_10;
                        break;
                    case 10:
                        timeSection = section10_11;
                        break;
                    case 11:
                        timeSection = section11_12;
                        break;
                    case 12:
                        timeSection = section12_13;
                        break;
                    case 13:
                        timeSection = section13_14;
                        break;
                    case 14:
                        timeSection = section14_15;
                        break;
                    case 15:
                        timeSection = section15_16;
                        break;
                    case 16:
                        timeSection = section16_17;
                        break;
                    case 17:
                        timeSection = section17_18;
                        break;
                    case 18:
                        timeSection = section18_19;
                        break;
                    case 19:
                        timeSection = section19_20;
                        break;
                    case 20:
                        timeSection = section20_21;
                        break;
                    case 21:
                        timeSection = section20_21;
                        break;
                }
            }

            #endregion

            #region initial tab2
            lb_wd1.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd ddd");
            lb_wd2.Text = dateTimePicker2.Value.AddDays(1).ToString("yyyy/MM/dd ddd");
            lb_wd3.Text = dateTimePicker2.Value.AddDays(2).ToString("yyyy/MM/dd ddd");
            lb_wd4.Text = dateTimePicker2.Value.AddDays(3).ToString("yyyy/MM/dd ddd");
            lb_wd5.Text = dateTimePicker2.Value.AddDays(4).ToString("yyyy/MM/dd ddd");
            lb_wd6.Text = dateTimePicker2.Value.AddDays(5).ToString("yyyy/MM/dd ddd");
            lb_wd7.Text = dateTimePicker2.Value.AddDays(6).ToString("yyyy/MM/dd ddd");

            List<FlowLayoutPanel> flowLayoutPanels = new List<FlowLayoutPanel>();
            #endregion


            listCell = new List<FlowLayoutPanel>
                {
                    Cell9, Cell10, Cell11, Cell12, Cell13, Cell14,
                    Cell15, Cell16, Cell17, Cell18, Cell19, Cell20
                };


            RefreshTable();

            #region refresh form
            timer1.Interval = (refreshTime * 1000); // 60 secs
            timer1.Start();
            #endregion

            

        }
        private void TimerTick(object sender, EventArgs e)
        {
            RefreshTable();
            timer1.Interval = (refreshTime * 1000); // 60 secs
            timer1.Start();
        }

        private void refresh()
        {
            try
            {
                String connStr = "";
                SqlConnection cnn;               
                connStr = "Data Source=" + Global.strProgramIP + ";Initial Catalog=" + Global.strProgramDB + ";User ID=" + Global.strProgramUser + ";Password=" + Global.strProgramPass + ";";
                cnn = new SqlConnection(connStr);

                cnn.Open();

                Table_Holiday = SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_EYHoliday").Tables[0];

                Table_Holiday_Per = SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_Holiday_ByAgentDate", new object[] { agentid(), DateTime.Parse(DateTimePicker1.Value.ToString()).ToString("yyyyMMdd") }).Tables[0];

                //Table_Personal = SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_PersonalActivity_ByAgentDate", new object[] { agentid(), DateTime.Parse(DateTimePicker1.Value.ToString()).ToString("yyyyMMdd") }).Tables[0];

                //Table_Activity = SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_Activity_ByAgentDate", new object[] { agentid(), DateTime.Parse(DateTimePicker1.Value.ToString()).ToString("yyyyMMdd") }).Tables[0];

                Table_Personal = SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_PersonalActivity_ByAgentDate2", new object[] { agentid(), DateTime.Parse(DateTimePicker1.Value.ToString()).ToString("yyyyMMdd"), /*Global.strAgentID*/AgentID.Text }).Tables[0];

                Table_Activity = SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_Activity_ByAgentDate2", new object[] { agentid(), DateTime.Parse(DateTimePicker1.Value.ToString()).ToString("yyyyMMdd"),/*Global.strAgentID*/ AgentID.Text }).Tables[0];

                refreshTime = Convert.ToInt32(SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_RefreshTime").Tables[0].Rows[0][0].ToString());

                cnn.Close();

            }
            catch
            {
                MessageBox.Show("Connection failed!");
                this.Close();
            }
        }

        private void RefreshTable()
        {
            refresh();
            EnableSection();
            if (DayOffOrNot(DateTimePicker1.Value, Table_Holiday))
            {
                backcolor();
                EnableTable();
                SectionOffOrNot(DateTimePicker1.Value, Table_Holiday_Per, Table_Personal, Table_Activity);
            }
            else
            {
                DisableTable();
            }

        }
        private void backcolor()
        {

            switch (int.Parse(DateTime.Now.ToString("HH")))
            {
                case 8:
                case 9:
                    listCell[0].BackColor = Color.LightYellow;
                    section9_10.BackColor = Color.LightYellow;
                    break;
                case 10:
                    listCell[1].BackColor = Color.LightYellow;
                    section10_11.BackColor = Color.LightYellow;
                    break;
                case 11:
                    listCell[2].BackColor = Color.LightYellow;
                    section11_12.BackColor = Color.LightYellow;
                    break;
                case 12:
                    listCell[3].BackColor = Color.LightYellow;
                    section12_13.BackColor = Color.LightYellow;
                    break;
                case 13:
                    listCell[4].BackColor = Color.LightYellow;
                    section13_14.BackColor = Color.LightYellow;
                    break;
                case 14:
                    listCell[5].BackColor = Color.LightYellow;
                    section14_15.BackColor = Color.LightYellow;
                    break;
                case 15:
                    listCell[6].BackColor = Color.LightYellow;
                    section15_16.BackColor = Color.LightYellow;
                    break;
                case 16:
                    listCell[7].BackColor = Color.LightYellow;
                    section16_17.BackColor = Color.LightYellow;
                    break;
                case 17:
                    listCell[8].BackColor = Color.LightYellow;
                    section17_18.BackColor = Color.LightYellow;
                    break;
                case 18:
                    listCell[9].BackColor = Color.LightYellow;
                    section18_19.BackColor = Color.LightYellow;
                    break;
                case 19:
                    listCell[10].BackColor = Color.LightYellow;
                    section19_20.BackColor = Color.LightYellow;
                    break;
                case 20:
                case 21:
                    listCell[11].BackColor = Color.LightYellow;
                    section20_21.BackColor = Color.LightYellow;
                    break;
                default:
                    listCell[0].BackColor = Color.LightYellow;
                    section9_10.BackColor = Color.LightYellow;
                    break;
            }
         }
        private void EnableSection()
        {
            for (int i = 0; i < 12; i++)
            {
                listCell[i].BackColor = Color.Transparent;
                listCell[i].Enabled = true;
                listCell[i].Controls.Clear();
            }
            IEnumerable<Label> list = tableLayoutPanel1.Controls.OfType<Label>();
            foreach (Label rb in list)
            {
                rb.BackColor = Color.Transparent;
            }
        }
        private void EnableTable()
        {
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.Enabled = true;
        }
        private void DisableTable()
        {
            tableLayoutPanel1.BackColor = Color.DimGray;
            tableLayoutPanel1.AutoScrollPosition = new Point(0, 0);
            tableLayoutPanel1.Enabled = false;
        }
        private bool DayOffOrNot(DateTime DateToday, DataTable Table)
        {
            foreach (DataRow row in Table.Rows)
            {
                string HolidayDate = row[1].ToString();
                if (DateToday.ToString("yyyy-MM-dd") == DateTime.Parse( HolidayDate).ToString("yyyy-MM-dd"))
                {
                    Console.WriteLine("table disabled");
                    LabelDayOff.Visible = true;
                    LabelDayOff.Text = row[0].ToString();
                    //MessageBox.Show("公休日");
                    return false;
                }
                else if (row == Table.Rows[Table.Rows.Count - 1])
                {
                    EnableTable();
                    LabelDayOff.Visible = false;
                }
            }
            return true;
        }

        private void SectionOffOrNot(DateTime DateToday, DataTable Table1, DataTable Table2, DataTable Table3)
        {

            foreach (DataRow row in Table1.Rows)
            {
                DateTime startTime = (DateTime)row["StartTime"];
                DateTime endTime = (DateTime)row["EndTime"];
                String OffDate = startTime.ToShortDateString();
                if (DateToday.ToShortDateString() == OffDate)
                {
                    String temp = startTime.ToString("HH");
                    int start = Int32.Parse(temp);
                    temp = endTime.ToString("HH");
                    int end = Int32.Parse(temp);
                    DisableSection(start, end, listCell, row["Desc"].ToString(), row["ColorName"].ToString(), row["ForeColor"].ToString());
                    break;
                }
            }
            foreach (DataRow row in Table2.Rows)
            {
                DateTime startTime = (DateTime)row["StartTime"];
                DateTime endTime = (DateTime)row["EndTime"];
                String OffDate = startTime.ToShortDateString();
                if (DateToday.ToShortDateString() == OffDate)
                {
                    String temp = startTime.ToString("HH");
                    int start = Int32.Parse(temp);
                    temp = endTime.ToString("HH");
                    int end = Int32.Parse(temp);
                    DisableSection1(start, end, listCell, row["Desc"].ToString(), row["ColorName"].ToString(), row["ForeColor"].ToString(), row);
                }
            }
            foreach (DataRow row in Table3.Rows)
            {
                DateTime startTime = (DateTime)row["StartTime"];
                DateTime endTime = (DateTime)row["EndTime"];
                String OffDate = startTime.ToShortDateString();
                if (DateToday.ToShortDateString() == OffDate)
                {
                    String temp = startTime.ToString("HH");
                    int start = Int32.Parse(temp);
                    temp = endTime.ToString("HH");
                    int end = Int32.Parse(temp);
                    DisableSection1(start, end, listCell, row["Desc"].ToString(), row["ColorName"].ToString(), row["ForeColor"].ToString(), row);
                }
            }
        }

        private void DisableSection(int Start, int End, List<FlowLayoutPanel> listCell, string str,string BackColor,string ForeColor)
        {
            Console.WriteLine(Start);
            for (int i = Start; i < End; i++)
            {
                Label EventName = new System.Windows.Forms.Label();
                //Button EventName = new Button();
                EventName.Text = str;
                EventName.BackColor = Color.FromName(BackColor);
                EventName.ForeColor= Color.FromName(ForeColor);
                // listCell[i - 9].BackColor = Color.Pink;
                // listCell[i - 9].BackColor = Color.FromName(color);
                // listCell[i - 9].Enabled = false;
                listCell[i - 9].Controls.Add(EventName);
                //listCell[i - 9].ContextMenuStrip = day_busy_MenuStrip;
            }
        }

        private void DisableSection1(int Start, int End, List<FlowLayoutPanel> listCell, String str, string BackColor, string ForeColor, DataRow dataRow)
        {
            Console.WriteLine(Start);
            if (Start == End)
            {
                //Label EventName = new System.Windows.Forms.Label();
                Button EventName = new Button();
                EventName.Text = str;
                EventName.AutoSize = true;
                //20201005 暫時隱藏 正式環境有新動作
                EventName.Click += (sender, e) => buttonclick(dataRow);
                //20201005
                EventName.BackColor = Color.FromName(BackColor);
                EventName.ForeColor = Color.FromName(ForeColor);
                if (Start == 8)
                {
                    //listCell[0].BackColor = Color.Pink;
                    //listCell[0].BackColor = Color.FromName(color);
                    // listCell[i - 9].Enabled = false;
                    listCell[0].Controls.Add(EventName);
                    //listCell[0].ContextMenuStrip = day_busy_MenuStrip;

                }
                else
                {
                    //listCell[Start - 9].BackColor = Color.Pink;
                    //listCell[Start - 9].BackColor = Color.FromName(color);
                    // listCell[i - 9].Enabled = false;
                    listCell[Start - 9].Controls.Add(EventName);
                    //listCell[Start - 9].ContextMenuStrip = day_busy_MenuStrip;

                }
            }
            else
            {
                for (int i = Start; i < End; i++)
                {
                    //Label EventName = new System.Windows.Forms.Label();
                    Button EventName = new Button();
                    EventName.Text = str;
                    EventName.AutoSize = true;
                    //20201005 暫時隱藏 正式環境有新動作
                    EventName.Click += (sender, e) => buttonclick(dataRow);
                    //20201005
                    EventName.BackColor= Color.FromName(BackColor);
                    EventName.ForeColor = Color.FromName(ForeColor);
                    if (Start == 8)
                    {
                        //listCell[0].BackColor = Color.Pink;
                        //listCell[0].BackColor = Color.FromName(color);
                        // listCell[i - 9].Enabled = false;
                        listCell[0].Controls.Add(EventName);
                        //listCell[0].ContextMenuStrip = day_busy_MenuStrip;
                    }
                    else
                    {
                        //listCell[i - 9].BackColor = Color.Pink;
                        //listCell[i - 9].BackColor = Color.FromName(color);
                        // listCell[i - 9].Enabled = false;
                        listCell[i - 9].Controls.Add(EventName);
                        //listCell[i - 9].ContextMenuStrip = day_busy_MenuStrip;
                    }
                }
            }
        }
        private void Button_PrevDay_Click(object sender, EventArgs e)
        {
            DateTimePicker1.Value = DateTimePicker1.Value.AddDays(-1);
            // Console.WriteLine(dateTimePicker1.Value.ToString());
        }

        private void Button_NextDay_Click(object sender, EventArgs e)
        {
            DateTimePicker1.Value = DateTimePicker1.Value.AddDays(1);
        }

        private void day_add_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            frm_Calendar_Add frm_Calendar_Add = new frm_Calendar_Add(this);
            frm_Calendar_Add.ShowDialog();
            RefreshTable();
            timer1.Interval = (refreshTime * 1000);
            timer1.Start();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            RefreshTable();
            timer1.Interval = (refreshTime * 1000);
            timer1.Start();
        }
        public string agentid()
        {
            string rts = AgentID.Text;
            if (cb_Agent.SelectedValue.ToString() != "")
            {
                rts = cb_Agent.SelectedValue.ToString();
            }
            return rts;
        }


        private void buttonclick(DataRow dataRow)
        {
            timer1.Stop();
            frm_Calendar_Revise frm_Calendar_Revise = new frm_Calendar_Revise(this, dataRow);
            DialogResult result = frm_Calendar_Revise.ShowDialog();
            if (result == DialogResult.Yes)
            {
                RefreshTable();
            }
            timer1.Interval = (refreshTime * 1000);
            timer1.Start();
        }
        private void bt_Re_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            setcombobox();
            timer1.Interval = (refreshTime * 1000);
            timer1.Start();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (true)
            {   //關閉按鈕動作
                //e.Cancel = true;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            RefreshTable();
            timer1.Interval = (refreshTime * 1000);
            timer1.Start();
        }
        bool comboboxck = true;
        private void SetComboBox_SubDept()
        {
            try
            {
                String connStr = "";
                SqlConnection cnn;                
                connStr = "Data Source=" + Global.strProgramIP + ";Initial Catalog=" + Global.strProgramDB + ";User ID=" + Global.strProgramUser + ";Password=" + Global.strProgramPass + ";";
                cnn = new SqlConnection(connStr);
                cnn.Open();
                String sAgentID = AgentID.Text;
                DataSet dsAgent = SqlHelper.ExecuteDataset(cnn, "xsp_AgentOrder_AgentList", new object[] { sAgentID });
                #region SubDept
                var vSubDept = (from o in dsAgent.Tables[0].AsEnumerable()
                                orderby o["SubDept_ID"].ToString()
                                where o["SubDept_ID"] != DBNull.Value
                                select new { SubDept_ID = o["SubDept_ID"].ToString(), SubDept = o["SubDept"].ToString() }).Distinct().ToList();
                vSubDept.Insert(0, new { SubDept_ID = "", SubDept = "全選" });
                cb_Dept.DataSource = vSubDept;
                cb_Dept.ValueMember = "SubDept_ID";
                cb_Dept.DisplayMember = "SubDept";
                var SubDept1 = (from o in dsAgent.Tables[0].AsEnumerable()
                                orderby o["SubDept_ID"].ToString()
                                where o["SubDept_ID"] != DBNull.Value
                                select new { SubDept_ID = o["SubDept_ID"].ToString(), AgentID = o["Agent_ID"].ToString() }).Distinct().ToList();
                if ( comboboxck)
                {
                    cb_Dept.SelectedValue = SubDept1.Where(a => a.AgentID == sAgentID).Select(a => a.SubDept_ID).DefaultIfEmpty("").FirstOrDefault();
                }
                #endregion
                cnn.Close();

            }
            catch
            {
                MessageBox.Show("Connection failed!");
                this.Close();
            }
        }
        private void SetComboBox_Squad()
        {

            String connStr = "";
            SqlConnection cnn;            
            connStr = "Data Source=" + Global.strProgramIP + ";Initial Catalog=" + Global.strProgramDB + ";User ID=" + Global.strProgramUser + ";Password=" + Global.strProgramPass + ";";
            cnn = new SqlConnection(connStr);
            cnn.Open();
            String sAgentID = AgentID.Text;
            DataSet dsAgent = SqlHelper.ExecuteDataset(cnn, "xsp_AgentOrder_AgentList", new object[] { sAgentID });
            string SubDept_ID = cb_Dept.SelectedValue.ToString();
            #region Squad
            var vSquad = (from o in dsAgent.Tables[0].AsEnumerable()
                          orderby o["TeamID"].ToString()
                          where o["TeamID"] != DBNull.Value && o["SubDept_ID"].ToString().Contains(SubDept_ID)
                          select new { TeamID = o["TeamID"].ToString(), TeamName = o["TeamName"].ToString() }).Distinct().ToList();
            vSquad.Insert(0, new { TeamID = "", TeamName = "全選" });
            cb_Team.DataSource = vSquad;
            cb_Team.ValueMember = "TeamID";
            cb_Team.DisplayMember = "TeamName";
            var vSquad1 = (from o in dsAgent.Tables[0].AsEnumerable()
                           orderby o["TeamID"].ToString()
                           where o["TeamID"] != DBNull.Value && o["SubDept_ID"].ToString().Contains(SubDept_ID)
                           select new { TeamID = o["TeamID"].ToString(), AgentID = o["Agent_ID"].ToString() }).Distinct().ToList();
            if ( comboboxck)
            {
                cb_Team.SelectedValue = vSquad1.Where(a => a.AgentID == sAgentID).Select(a => a.TeamID).DefaultIfEmpty("").FirstOrDefault();
            }
            #endregion

            cnn.Close();
        }
        private void SetComboBox_Agent()
        {
            String connStr = "";
            SqlConnection cnn;            
            connStr = "Data Source=" + Global.strProgramIP + ";Initial Catalog=" + Global.strProgramDB + ";User ID=" + Global.strProgramUser + ";Password=" + Global.strProgramPass + ";";
            cnn = new SqlConnection(connStr);

            cnn.Open();
            String sAgentID = AgentID.Text;
            DataSet dsAgent = SqlHelper.ExecuteDataset(cnn, "xsp_AgentOrder_AgentList", new object[] { sAgentID });
            string SubDept_ID = cb_Dept.SelectedValue.ToString();
            string TeamID = cb_Team.SelectedValue.ToString();
            #region AgentID
            var vAgent = (from o in dsAgent.Tables[0].AsEnumerable()
                          orderby o["Agent_ID"].ToString()
                          where o["TeamID"].ToString().Contains(TeamID) && o["SubDept_ID"].ToString().Contains(SubDept_ID)
                          select new { AgentID = o["Agent_ID"].ToString(), AgentName = o["Account_Name"].ToString() }).Distinct().ToList();
            cb_Agent.DataSource = vAgent;
            cb_Agent.ValueMember = "AgentID";
            cb_Agent.DisplayMember = "AgentName";
            if (comboboxck)
            {
                string ck = vAgent.Where(a => a.AgentID == sAgentID).Select(a => a.AgentID).DefaultIfEmpty("").FirstOrDefault();
                if (ck == "")
                {
                    cb_Agent.SelectedIndex = 0;
                }
                else
                {
                    cb_Agent.SelectedValue = ck;
                }
            }
            #endregion

            cnn.Close();
            
        }

        private void setcombobox()
        {
            SetComboBox_SubDept();
            SetComboBox_Squad();
            SetComboBox_Agent();
            //comboboxck = false;
        }

        private void cb_Dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetComboBox_Squad();
        }

        private void cb_Squad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetComboBox_Agent();
        }

    }
}
