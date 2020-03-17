using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dat_Phong.Model;
using Calendar;
using Dat_Phong.View;
namespace Dat_Phong
{
    public partial class Form1 : Form
    {
        List<Appointment> m_Appointments = new List<Appointment>();
        public Form1()
        {
            InitializeComponent();
            CbxTheme.SelectedIndex = 1;
            dayView1.StartDate = DateTime.Now;
        }
        public static string str_image;
        public static DataRow account;
        public static Appointment app_tem;
        public static bool creat_app;
        private static int ma_phong;
        private void Form1_Load(object sender, EventArgs e)
        {
            string queryAccount = "SELECT * FROM dbo.person WHere dbo.person.Id=" + LoginForm.ID_USER;
            DataTable arrAccount = DataProvider.Instance.ExecuteQuery(queryAccount);
            str_image = arrAccount.Rows[0].ItemArray[4].ToString();
            account = arrAccount.Rows[0];
            pictureBox1.Image = Image.FromFile(arrAccount.Rows[0].ItemArray[4].ToString());

            LbName.Text = "Hello " + arrAccount.Rows[0].ItemArray[1].ToString();

            string queryListSizeOfRoom = "SELECT distinct size FROM dbo.room";
            DataTable arrSizeRoom = new DataTable();
            arrSizeRoom = DataProvider.Instance.ExecuteQuery(queryListSizeOfRoom);
            DataRow allRoom = arrSizeRoom.NewRow();
            allRoom["size"] = "All";
            arrSizeRoom.Rows.InsertAt(allRoom, 0);
            CbxSize.DataSource = arrSizeRoom;
            CbxSize.DisplayMember = "size";
        }
        void dayView1_NewAppointment(object sender, NewAppointmentEventArgs args)
        {
            Appointment m_Appointment = new Appointment();

            m_Appointment.StartDate = args.StartDate;
            m_Appointment.EndDate = args.EndDate;
            m_Appointment.Title = args.Title;
            m_Appointments.Add(m_Appointment);
        }

        private void dayView1_MouseMove(object sender, MouseEventArgs e)
        {
            LbPosition.Text = dayView1.GetTimeAt(e.X, e.Y).ToString();
            if (dayView1.SelectedAppointment != null)
            {
                LbStart.Text = dayView1.SelectedAppointment.StartDate.ToString();
                LbEnd.Text = dayView1.SelectedAppointment.EndDate.ToString();
            }
        }

        private void dayView1_ResolveAppointments(object sender, ResolveAppointmentsEventArgs args)
        {
            List<Appointment> m_Apps = new List<Appointment>();

            foreach (Appointment m_App in m_Appointments)
                if ((m_App.StartDate >= args.StartDate) &&
                    (m_App.StartDate <= args.EndDate))
                    m_Apps.Add(m_App);

            args.Appointments = m_Apps;

        }

        private void TrBrDayToShow_Scroll(object sender, EventArgs e)
        {
            dayView1.DaysToShow = TrBrDayToShow.Value;
        }

        private void TrBrZoom_Scroll(object sender, EventArgs e)
        {
            dayView1.HalfHourHeight = TrBrZoom.Value;
        }

        private void CalendarChanged(object sender, EventArgs e)
        {
            dayView1.StartDate = calendarControl1.SelectionStart;
        }

        private void CbxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxTheme.SelectedItem.ToString() == "Office 11")
            {
                dayView1.Renderer = new Office11Renderer();
            }
            else
            {
                dayView1.Renderer = new Office12Renderer();
            }
        }

        private void CbxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Appointments.RemoveRange(0, m_Appointments.Count);
            string querylistEvent;
            string selectedRoom = (string)(((System.Data.DataRowView)CbxRoom.SelectedItem).Row.ItemArray)[0];
            string query_info_room = "SELECT Id FROM dbo.room WHERE dbo.room.name = '" + selectedRoom + "'";
            DataTable arr_room_info = DataProvider.Instance.ExecuteQuery(query_info_room);
            ma_phong = (int)(arr_room_info.Rows[0].ItemArray[0]);
            querylistEvent = "SELECT * from dbo.book_room_schedule WHERE dbo.book_room_schedule.Id_room ='" + ma_phong + "'";
            List<book_room_schedule> Book_room_schedule_List = new List<book_room_schedule>();
            DataTable EventTable = DataProvider.Instance.ExecuteQuery(querylistEvent);
            foreach (DataRow item in EventTable.Rows)
            {
                //book_room_schedule book_room = new book_room_schedule(item);
                //Book_room_schedule_List.Add(book_room);

                Appointment m_Appointment = new Appointment();
                m_Appointment.Id = (int)item[0];
                m_Appointment.ID_room = (int)item[1];
                m_Appointment.StartDate = (DateTime)item[2];
                m_Appointment.EndDate = (DateTime)item[3];

                m_Appointment.BorderColor = Color.FromArgb((int)item[5]);
                m_Appointment.Color = Color.FromArgb((int)item[6]);
                m_Appointment.Title = item[7].ToString();
                if ((int)item[4] == LoginForm.ID_USER)
                {
                    m_Appointment.Locked = false;
                }
                else
                {
                    m_Appointment.Locked = true;
                }
                m_Appointments.Add(m_Appointment);

            }
        }

        private void CbxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryListRoomSameSize;
            string selectedRoomSize = (string)(((System.Data.DataRowView)CbxSize.SelectedItem).Row.ItemArray)[0];
            if (selectedRoomSize == "All")
            {
                queryListRoomSameSize = "SELECT name from dbo.room";
            }
            else
            {
                queryListRoomSameSize = "SELECT name FROM dbo.room where dbo.room.size='" + selectedRoomSize + "'";
            }

            DataTable ListOfRoomSameSize = DataProvider.Instance.ExecuteQuery(queryListRoomSameSize);
            CbxRoom.DataSource = ListOfRoomSameSize;
            CbxRoom.DisplayMember = "name";
        }

        private void BtnBorder_Click(object sender, EventArgs e)
        {
            if (dayView1.SelectedAppointment != null)
            {
                colorDialog1.Color = dayView1.SelectedAppointment.BorderColor;

                if (colorDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    dayView1.SelectedAppointment.BorderColor = colorDialog1.Color;
                }
            }
        }

        private void BtnShading_Click(object sender, EventArgs e)
        {
            if (dayView1.SelectedAppointment != null)
            {
                colorDialog1.Color = dayView1.SelectedAppointment.Color;

                if (colorDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    dayView1.SelectedAppointment.Color = colorDialog1.Color;
                }
            }
        }

        private void BtnCreat_Click(object sender, EventArgs e)
        {
            DateTime begin = dayView1.SelectionStart;
            DateTime end = dayView1.SelectionEnd;
            bool a = false;
            creat_app = true;
            if (LbStart.Text == "[...]") a = true;
            if (dayView1.SelectedAppointment != null)
            {
                a = true;
            }
            else
                foreach (Appointment app in m_Appointments)
                    if (((DateTime.Compare(begin, app.StartDate) > 0) & (DateTime.Compare(begin, app.EndDate) < 0)) | ((DateTime.Compare(end, app.StartDate) > 0) & (DateTime.Compare(end, app.EndDate) < 0)) | ((DateTime.Compare(begin, app.StartDate) < 0) & (DateTime.Compare(end, app.EndDate) > 0)))
                    {
                        a = true;
                        break;
                    }

            if (a == false)
            {
                Appointment m_App = new Appointment();
                m_App.StartDate = begin;
                m_App.EndDate = end;
                m_App.BorderColor = Color.Red;
                m_Appointments.Add(m_App);
                dayView1.SelectedAppointment = m_App;
                dayView1.Invalidate();
                string querybook = "SELECT Id from dbo.book_room_schedule ";
                DataTable tbl_Id_book = DataProvider.Instance.ExecuteQuery(querybook);
                m_App.Title = "New";
                m_App.Id = (int)tbl_Id_book.Rows[tbl_Id_book.Rows.Count - 1].ItemArray[0] + 1;
                m_App.ID_room = ma_phong;
                app_tem = m_App;
                Book_room_info dlg_book = new Book_room_info();
                dlg_book.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không cho phép chèn lên nhau", "Chú ý ! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if ((dayView1.SelectedAppointment != null))
            {
                if (dayView1.SelectedAppointment.Locked == false)
                {
                    if (MessageBox.Show("Chắc chắn muốn xóa", "Delete Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        int index = dayView1.SelectedAppointment.Id;
                        string cmd_delete = "DELETE FROM dbo.list_person_attend WHERE Id_book_room_schedule = '" + index + "'";
                        DataProvider.Instance.ExecuteNonQuery(cmd_delete);
                        cmd_delete = "DELETE FROM dbo.book_room_schedule WHERE Id = '" + index + "'";
                        DataProvider.Instance.ExecuteNonQuery(cmd_delete);
                        m_Appointments.Remove(dayView1.SelectedAppointment);
                        dayView1.Invalidate();
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dayView1_SelectionChanged(object sender, EventArgs e)
        {
            LbStart.Text = dayView1.SelectionStart.ToString();
            LbEnd.Text = dayView1.SelectionEnd.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if ((dayView1.SelectedAppointment != null))
            {
                if (dayView1.SelectedAppointment.Locked == false)
                {
                    creat_app = false;
                    app_tem = dayView1.SelectedAppointment;
                    Book_room_info dlg_book = new Book_room_info();
                    dlg_book.ShowDialog();
                }
            }
            
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
                    Account_Info dlg_info = new Account_Info();
                    dlg_info.ShowDialog();
        }
    }
}
