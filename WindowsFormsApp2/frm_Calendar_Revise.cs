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
    public partial class frm_Calendar_Revise : Form
    {
        frm_Calendar_Master Calendar_Master;
        DataRow dataRow;
        List<Data_P> data_P = new List<Data_P>();
        List<Data_A> data_A = new List<Data_A>();

        public frm_Calendar_Revise(frm_Calendar_Master frm_Calendar_Master, DataRow row)
        {
            InitializeComponent();
            Calendar_Master = frm_Calendar_Master;
            dataRow = row;
            string Type = dataRow[6].ToString();

            if (Type == "P")
            {
                data_P.Add(new Data_P()
                {
                    事件 = dataRow["EventName"].ToString(),
                    開始時間 = dataRow["StartTime"].ToString(),
                    結束時間 = dataRow["EndTime"].ToString(),
                    發起者 = dataRow["Initiator"].ToString(),
                    描述 = dataRow["Description"].ToString(),
                    地點 = dataRow["Location"].ToString()
                });
                CreateTable(2, 6, Type);
            }
            else if (Type == "A")
            {
                data_A.Add(new Data_A()
                {
                    事件 = dataRow["Desc"].ToString(),
                    開始時間 = dataRow["StartTime"].ToString(),
                    結束時間 = dataRow["EndTime"].ToString(),
                    客戶ID = dataRow["CustomerID"].ToString(),
                    客戶姓名 = dataRow["CustomerName"].ToString(),
                    配出時間 = dataRow["AssignTime"].ToString(),
                    狀態 = dataRow["StatusDesc"].ToString()
                });
                CreateTable(2, 7, Type);
            }

            if (dataRow["Editable"].ToString() != "1")
            {
                //Bt_Delete.Visible = false;
                //Bt_Re.Visible = false;
            }

        }
        public class Data_P
        {
            public string 事件 { get; set; }
            public string 開始時間 { get; set; }
            public string 結束時間 { get; set; }
            public string 發起者{ get; set; }
            public string 描述 { get; set; }
            public string 地點 { get; set; }

        }

        public class Data_A
        {
            public string 事件 { get; set; }
            public string 開始時間 { get; set; }
            public string 結束時間 { get; set; }
            public string 客戶ID { get; set; }
            public string 客戶姓名 { get; set; }
            public string 配出時間 { get; set; }
            public string 狀態 { get; set; }

        }

        private void CreateTable(int cc,int rc,string Type)
        {
            CreateColumn(cc);
            CreateRow(rc);
            CreateContent(cc,rc, Type);
        }
        private void InitDynamicTable()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
        }
        private void CreateColumn(int cc)
        {
            //int ColumnCount = int.Parse(txtColumnCount.Text.Trim());
            int ColumnCount = cc;
            tableLayoutPanel1.ColumnCount = ColumnCount;
            for (int i = 0; i < ColumnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            }
        }

        private void CreateRow(int rc)
        {
            //int RowCount = int.Parse(txtRowCount.Text.Trim());
            int RowCount = rc;
            tableLayoutPanel1.RowCount = RowCount;
            for (int i = 0; i < RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            }
        }

        private void CreateContent(int cc,int rc, string Type)
        {
            int ColumnCount = cc;
            int RowCount = rc;
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {

                    if (Type == "P")
                    {
                        if (j == 0)
                        {
                            Label ExampleLabel = new Label();
                            switch (i)
                            {
                                case 0:
                                    ExampleLabel.Text = "事件";
                                    break;
                                case 1:
                                    ExampleLabel.Text = "開始時間";
                                    break;
                                case 2:
                                    ExampleLabel.Text = "結束時間";
                                    break;
                                case 3:
                                    ExampleLabel.Text = "發起者";
                                    break;
                                case 4:
                                    ExampleLabel.Text = "描述";
                                    break;
                                case 5:
                                    ExampleLabel.Text = "地點";
                                    break;
                            }
                            ExampleLabel.Name = "Lab_" + i;
                            ExampleLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                            ExampleLabel.AutoSize = true;
                            ExampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            tableLayoutPanel1.Controls.Add(ExampleLabel);
                            tableLayoutPanel1.SetCellPosition(ExampleLabel, new TableLayoutPanelCellPosition(j, i));
                        }
                        else
                        {
                            TextBox ExampleTextBox = new TextBox();
                            DateTimePicker dateTimePicker = new DateTimePicker();
                            bool dt = false;
                            ExampleTextBox.Enabled = false;
                            switch (i)
                            {
                                case 0:
                                    ExampleTextBox.Text = data_P[0].事件;
                                    ExampleTextBox.Name = "TB_Desc";
                                    break;
                                case 1:
                                    //ExampleTextBox.Text = data_P[0].開始時間;
                                    //ExampleTextBox.Name = "TB_StartTime";
                                    //ExampleTextBox.Enabled = true;
                                    dateTimePicker.Text=DateTime.Parse(data_P[0].開始時間).ToString("HH:mm");
                                    dateTimePicker.Name = "DTP_StartTime";
                                    if (dataRow["Editable"].ToString() != "1")
                                    {
                                        dateTimePicker.Enabled = false;
                                    }
                                    dt = true;
                                    break;
                                case 2:
                                    //ExampleTextBox.Text = data_P[0].結束時間;
                                    //ExampleTextBox.Name = "TB_EndTime";
                                    //ExampleTextBox.Enabled = true;
                                    dateTimePicker.Text = DateTime.Parse(data_P[0].結束時間).ToString("HH:mm");
                                    dateTimePicker.Name = "DTP_EndTime";
                                    if (dataRow["Editable"].ToString() != "1")
                                    {
                                        dateTimePicker.Enabled = false;
                                    }
                                    dt = true;
                                    break;
                                case 3:
                                    ExampleTextBox.Text = data_P[0].發起者;
                                    ExampleTextBox.Name = "TB_Initiator";
                                    break;
                                case 4:
                                    ExampleTextBox.Text = data_P[0].描述;
                                    ExampleTextBox.Name = "TB_Description";
                                    ExampleTextBox.Enabled = true;
                                    break;
                                case 5:
                                    ExampleTextBox.Text = data_P[0].地點;
                                    ExampleTextBox.Name = "TB_Location";
                                    break;
                            }
                            if (dt)
                            {
                                dateTimePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                                dateTimePicker.AutoSize = true;
                                dateTimePicker.CustomFormat = "HH:mm";
                                dateTimePicker.Format = DateTimePickerFormat.Custom;
                                dateTimePicker.ShowUpDown = true;
                                tableLayoutPanel1.Controls.Add(dateTimePicker);
                            }
                            else
                            {
                                ExampleTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                                ExampleTextBox.AutoSize = true;
                                ExampleTextBox.Multiline = true;
                                tableLayoutPanel1.Controls.Add(ExampleTextBox);
                            }


                            tableLayoutPanel1.SetCellPosition(ExampleTextBox, new TableLayoutPanelCellPosition(j, i));
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            Label ExampleLabel = new Label();
                            switch (i)
                            {
                                case 0:
                                    ExampleLabel.Text = "事件";
                                    break;
                                case 1:
                                    ExampleLabel.Text = "開始時間";
                                    break;
                                case 2:
                                    ExampleLabel.Text = "結束時間";
                                    break;
                                case 3:
                                    ExampleLabel.Text = "客戶ID";
                                    break;
                                case 4:
                                    ExampleLabel.Text = "客戶名稱";
                                    break;
                                case 5:
                                    ExampleLabel.Text = "配出時間";
                                    break;
                                case 6:
                                    ExampleLabel.Text = "狀態";
                                    break;
                            }
                            ExampleLabel.Name = "Lab_" + i;
                            ExampleLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                            ExampleLabel.AutoSize = true;
                            ExampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            tableLayoutPanel1.Controls.Add(ExampleLabel);
                            tableLayoutPanel1.SetCellPosition(ExampleLabel, new TableLayoutPanelCellPosition(j, i));
                        }
                        else
                        {
                            TextBox ExampleTextBox = new TextBox();
                            ExampleTextBox.Enabled = false;
                            DateTimePicker dateTimePicker = new DateTimePicker();
                            bool dt = false;
                            switch (i)
                            {
                                case 0:
                                    ExampleTextBox.Text = data_A[0].事件;
                                    ExampleTextBox.Name = "TB_Desc";
                                    break;
                                case 1:
                                    //ExampleTextBox.Text = data_A[0].開始時間;
                                    //ExampleTextBox.Name = "TB_StartTime";
                                    //ExampleTextBox.Enabled = true;
                                    dateTimePicker.Text = DateTime.Parse(data_A[0].開始時間).ToString("HH:mm");
                                    dateTimePicker.Name = "DTP_StartTime";
                                    if (dataRow["Editable"].ToString() != "1")
                                    {
                                        dateTimePicker.Enabled = false;
                                    }
                                    dt = true;
                                    break;
                                case 2:
                                    //ExampleTextBox.Text = data_A[0].結束時間;
                                    //ExampleTextBox.Name = "TB_EndTime";
                                    //ExampleTextBox.Enabled = true;
                                    dateTimePicker.Text = DateTime.Parse(data_A[0].結束時間).ToString("HH:mm");
                                    dateTimePicker.Name = "DTP_EndTime";
                                    if (dataRow["Editable"].ToString() != "1")
                                    {
                                        dateTimePicker.Enabled = false;
                                    }
                                    dt = true;
                                    break;
                                case 3:
                                    ExampleTextBox.Text = data_A[0].客戶ID;
                                    ExampleTextBox.Name = "TB_CustomerID";
                                    break;
                                case 4:
                                    ExampleTextBox.Text = data_A[0].客戶姓名;
                                    ExampleTextBox.Name = "TB_CustomerName";
                                    break;
                                case 5:
                                    ExampleTextBox.Text = DateTime.Parse(data_A[0].配出時間).ToString("yyyy/MM/dd HH:mm:ss"); 
                                    ExampleTextBox.Name = "TB_AssignTime";
                                    break;
                                case 6:
                                    ExampleTextBox.Text = data_A[0].狀態;
                                    ExampleTextBox.Name = "TB_StatusDesc";
                                    break;
                            }

                            if (dt)
                            {
                                dateTimePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                                dateTimePicker.AutoSize = true;
                                dateTimePicker.CustomFormat = "HH:mm";
                                dateTimePicker.Format = DateTimePickerFormat.Custom;
                                dateTimePicker.ShowUpDown = true;
                                tableLayoutPanel1.Controls.Add(dateTimePicker);
                            }
                            else
                            {
                                ExampleTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                                ExampleTextBox.AutoSize = true;
                                ExampleTextBox.Multiline = true;
                                tableLayoutPanel1.Controls.Add(ExampleTextBox);
                            }

                            tableLayoutPanel1.SetCellPosition(ExampleTextBox, new TableLayoutPanelCellPosition(j, i));
                        }
                    }

                     
                }
            }
        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪除嗎?", "確認視窗", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            int ActivityID = int.Parse(dataRow["ActivityID"].ToString());
            string st = "";
            string et = "";
            string Desc = "";
            string Type = dataRow["ActivityType"].ToString();
            IEnumerable<TextBox> list = tableLayoutPanel1.Controls.OfType<TextBox>();
            IEnumerable<DateTimePicker> listdtp = tableLayoutPanel1.Controls.OfType<DateTimePicker>();
            foreach (DateTimePicker rb in listdtp)
            {
                if (rb.Name == "DTP_StartTime")
                {
                    st +=  rb.Text;
                }
                else if (rb.Name == "DTP_EndTime")
                {
                    et +=  rb.Text;
                }
            }
            if (Type == "P")
            {
                foreach (TextBox rb in list)
                {
                    if (rb.Name == "TB_Description")
                    {
                        Desc = rb.Text;
                    }
                }

            }
                Inpute("D", Type, ActivityID, st, et, Desc);
                MessageBox.Show("刪除成功");
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void Bt_Re_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要修改嗎?", "確認視窗", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int ActivityID = int.Parse( dataRow["ActivityID"].ToString());
                string st = "";
                string et = "";
                string Desc = "";
                string Type = dataRow["ActivityType"].ToString();
                IEnumerable<TextBox> list = tableLayoutPanel1.Controls.OfType<TextBox>();
                IEnumerable<DateTimePicker> listdtp = tableLayoutPanel1.Controls.OfType<DateTimePicker>();
                foreach (DateTimePicker rb in listdtp)
                {
                    if (rb.Name == "DTP_StartTime")
                    {
                        st +=  rb.Text;
                    }
                    else if (rb.Name == "DTP_EndTime")
                    {
                        et +=  rb.Text;
                    }
                }
                if (Type == "P")
                {
                    foreach (TextBox rb in list)
                    {
                        if (rb.Name == "TB_Description")
                        {
                            Desc = rb.Text;
                        }
                    }

                }
                TimeSpan allsecound = DateTime.Parse(et) - DateTime.Parse(st);
                int min = int.Parse( dataRow["MinutesLimit"].ToString());
                if (allsecound.TotalMinutes >= min)
                {
                    Inpute("U", Type, ActivityID, st, et, Desc);
                    MessageBox.Show("修改成功");
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("請確認時間是否正確");
                }
                   
            }
        }


        public void Inpute(string sw,string type,int activityid, string starttime,string endtime,string desc)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet sa = new DataSet();
            try
            {
                {                   
                    string connStr = "Data Source=" + Global.strProgramIP + ";Initial Catalog=" + Global.strProgramDB + ";User ID=" + Global.strProgramUser + ";Password=" + Global.strProgramPass + ";";
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "xsp_Calendar_Update_ByAgentType";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Sw", SqlDbType.NVarChar).Value = sw;
                        cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = type;
                        cmd.Parameters.Add("@ActivityID", SqlDbType.Int).Value = activityid;
                        cmd.Parameters.Add("@StartTime", SqlDbType.VarChar).Value = starttime;
                        cmd.Parameters.Add("@EndTime", SqlDbType.VarChar).Value = endtime;
                        cmd.Parameters.Add("@Desc", SqlDbType.NVarChar).Value = desc;
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
