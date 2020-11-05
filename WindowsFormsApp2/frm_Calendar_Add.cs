using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using WindowsFormsApp2;
using Microsoft.ApplicationBlocks.Data;

namespace Order
{
    public partial class frm_Calendar_Add : Form
    {
        frm_Calendar_Master Calendar_Master;
        public frm_Calendar_Add(frm_Calendar_Master frm_Calendar_Master)
        {
            InitializeComponent();
            setEventTypeList();
            Calendar_Master = frm_Calendar_Master;
        }



        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_confirm_Click(object sender, EventArgs e)
        {

            string EventID = EventTypeList.SelectedValue.ToString();
            string ActivityDate = DateTime.Parse(startDatePicker.Value.ToString()).ToString("yyyyMMdd");
            //string StartTime = DateTime.Parse(startTimePicker.Value.TimeOfDay.ToString()).ToString("HH:mm");
            //string EndTime = DateTime.Parse(endTimePicker.Value.TimeOfDay.ToString()).ToString("HH:mm");
            string StartTime = DateTime.Parse(startTimePicker.Value.TimeOfDay.ToString()).ToString("HH:mm");
            string EndTime = DateTime.Parse(endTimePicker.Value.TimeOfDay.ToString()).ToString("HH:mm");
            string EventName = EventTypeList.Text;
            string Descriprion = NoteTextBox.Text;
            string UserID = Calendar_Master.agentid();
            string Location = "";
            int EduID = 0;
            string ModifyID = Calendar_Master.agentid();
            string ExecType = "C";
            int ActivityID = 0;
            TimeSpan allsecound = DateTime.Parse(endTimePicker.Value.TimeOfDay.ToString())- DateTime.Parse(startTimePicker.Value.TimeOfDay.ToString());
            if (allsecound.TotalSeconds >=600 && EventName != "請選擇")
            {
                Calendar_PersonalActivity(EventID, EventName, ActivityDate, StartTime, EndTime, UserID, Descriprion, Location, EduID, ModifyID, ExecType, ActivityID);
                this.Close();
            }
            else
            {
                MessageBox.Show("請確認資料是否正確");
            }
        }

        private void Calendar_PersonalActivity(string EventID,string EventName,string ActivityDate ,string StartTime,string EndTime,string UserID,string Descriprion,string Location, int EduID, string ModifyID,string ExecType ,int ActivityID)
        {
            try
            {
                String connStr = "";
                SqlConnection cnn;               
                connStr = "Data Source=" + Global.strProgramIP + ";Initial Catalog=" + Global.strProgramDB + ";User ID=" + Global.strProgramUser + ";Password=" + Global.strProgramPass + ";";
                cnn = new SqlConnection(connStr);

                cnn.Open();
                
                DataSet dsEvent = SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_PersonalActivity_Insert", new object[] { EventID, EventName, ActivityDate, StartTime, EndTime, UserID, Descriprion,  Location, EduID, ModifyID, ExecType, ActivityID });
                string dscc = dsEvent.Tables[0].Rows[0]["ActivityID"].ToString();
                if (dscc == "")
                {
                    ExecType = "I";
                    SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_PersonalActivity_Insert", new object[] { EventID, EventName, ActivityDate, StartTime, EndTime, UserID, Descriprion, Location, EduID, ModifyID, ExecType, ActivityID });
                    this.Close();
                }
                else
                {
                    ExecType = "U";
                    SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_PersonalActivity_Insert", new object[] { EventID, EventName, ActivityDate, StartTime, EndTime, UserID, Descriprion, Location, EduID, ModifyID, ExecType, ActivityID });
                    this.Close();
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("{0} \r\n發生錯誤: {1} \r\n在程式: {2}\r\n錯誤資訊: {3}", DateTime.Now.ToString(), ex.Message, ex.Source, ex.StackTrace));
            }

        }

        private void setEventTypeList()
        {
            try
            {
                String connStr = "";
                SqlConnection cnn;                
                connStr = "Data Source=" + Global.strProgramIP + ";Initial Catalog=" + Global.strProgramDB + ";User ID=" + Global.strProgramUser + ";Password=" + Global.strProgramPass + ";";
                cnn = new SqlConnection(connStr);

                cnn.Open();
                DataSet dsEvent = SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_EventSet_PersonSelect");
                DataRow drEvent = dsEvent.Tables[0].NewRow();
                drEvent["EventName"] = "請選擇";
                drEvent["EventID"] = "0";
                drEvent["Priority"] = 0;
                dsEvent.Tables[0].Rows.InsertAt(drEvent, 0);
                var vEvent = (from o in dsEvent.Tables[0].AsEnumerable()
                              orderby o["Priority"].ToString()
                              select new { EventID = o["EventID"], EventName = o["EventName"] }).Distinct();

                EventTypeList.DataSource = vEvent.ToArray();
                EventTypeList.ValueMember = "EventID";
                EventTypeList.DisplayMember = "EventName";
                EventTypeList.SelectedIndex = 0;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("{0} \r\n發生錯誤: {1} \r\n在程式: {2}\r\n錯誤資訊: {3}", DateTime.Now.ToString(), ex.Message, ex.Source, ex.StackTrace));
            }

        }

        private void Form_add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Update();
        }
    }
}
