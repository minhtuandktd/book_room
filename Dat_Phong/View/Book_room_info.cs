using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar;
using Dat_Phong.Model;
namespace Dat_Phong.View
{
    public partial class Book_room_info : Form
    {
        private static Appointment ap=Form1.app_tem;
        public Book_room_info()
        {
            InitializeComponent();
            if (Form1.creat_app == true)
            {
                string format = "yyyy-MM-dd HH:mm:ss";
                string insert = "INSERT INTO dbo.book_room_schedule (Id_room, start_time, end_time,Id_person_book, border,color,title) VALUES (" + ap.ID_room + ",'" + ap.StartDate.ToString(format) + "','" + ap.EndDate.ToString(format) + "'," + LoginForm.ID_USER + "," + ap.BorderColor.ToArgb() + "," + ap.Color.ToArgb() + ",'" + ap.Title + "')";

                DataProvider.Instance.ExecuteQuery(insert);

                LbId_book_room.Text = Form1.app_tem.Id.ToString();
                tbxStart.Text = Form1.app_tem.StartDate.ToShortTimeString().ToString();
                tbxEnd.Text = Form1.app_tem.EndDate.ToShortTimeString().ToString();
                tbxDay.Text = Form1.app_tem.StartDate.ToShortDateString().ToString();
                tbxTitle.Text = Form1.app_tem.Title.ToString();
                //load phan them
            }
            else
            {
                LbId_book_room.Text = Form1.app_tem.Id.ToString();
                tbxStart.Text = Form1.app_tem.StartDate.ToShortTimeString().ToString();
                tbxEnd.Text = Form1.app_tem.EndDate.ToShortTimeString().ToString();
                tbxDay.Text = Form1.app_tem.StartDate.ToShortDateString().ToString();
                tbxTitle.Text = Form1.app_tem.Title.ToString();
                //load phan thong tin da co

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            ap = Form1.app_tem;
            string format = "yyyy-MM-dd HH:mm:ss";
            //string insert = "INSERT into dbo.book_room_schedule VALUES (" + LbId_book_room.Text + "," + ap.ID_room + ",'" + ap.StartDate.ToString(format) + "','" + ap.EndDate.ToString(format) + "'," + LoginForm.ID_USER + "," + ap.BorderColor.ToArgb() + "," + ap.Color.ToArgb() + ",'" + tbxTitle.Text + "')";
            string strUpdate = "UPDATE dbo.book_room_schedule SET start_time ='" + ap.StartDate.ToString(format) + "',end_time='" + ap.EndDate.ToString(format) + "',border = " + ap.BorderColor.ToArgb() + ",color = " + ap.Color.ToArgb() + ",title='" + tbxTitle.Text + "' WHERE Id ='" + ap.Id + "'";
            if (Form1.creat_app == true)
            {
               // DataProvider.Instance.ExecuteQuery(insert);
            }
            else
            {
                DataProvider.Instance.ExecuteQuery(strUpdate);
            }
            MessageBox.Show(" Đã gửi thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBorder_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = Form1.app_tem.BorderColor;

            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Form1.app_tem.BorderColor = colorDialog1.Color;
            }

        }

        private void btnShading_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = Form1.app_tem.Color;

            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Form1.app_tem.Color = colorDialog1.Color;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox2.Hide();
            }
            else
            {
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox2.Visible=true;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }
        private DataTable TB_query;
        private void btnFind_Click(object sender, EventArgs e)
        {
            FLP_not_attend.Controls.Clear();
            
            if ((checkBox1.Checked == true)&(checkBox2.Checked == false))
            {
                //FLP_not_attend=;
                string query_by_name = "SELECT * FROM dbo.person WHERE dbo.person.first_name='"+tbxName.Text+"'";
                TB_query = DataProvider.Instance.ExecuteQuery(query_by_name);
                foreach (DataRow item in TB_query.Rows)
                {
                    add_to_FLP_not_attend(item);
                }
                cbxAddID.DataSource = TB_query;
                cbxAddID.DisplayMember = "Id";

            }
            else if (checkBox2.Checked == true)
            {
                string query_by_full_name = "SELECT * FROM dbo.person WHERE dbo.person.first_name='" + tbxName.Text + "' AND dbo.person.last_name='"+tbx_lastname.Text+"'";
                TB_query = DataProvider.Instance.ExecuteQuery(query_by_full_name);
                foreach (DataRow item in TB_query.Rows)
                {
                    add_to_FLP_not_attend(item);
                }
                cbxAddID.DataSource = TB_query;
                cbxAddID.DisplayMember = "Id";
            }
            else if (checkBox3.Checked == true)
            {
                string query_by_full_name = "SELECT * FROM dbo.person WHERE dbo.person.first_name='" + tbxName.Text + "' AND dbo.person.last_name='" + tbx_lastname.Text + "'";
                TB_query = DataProvider.Instance.ExecuteQuery(query_by_full_name);
                foreach (DataRow item in TB_query.Rows)
                {
                    add_to_FLP_not_attend(item);
                }
            }
            else if (checkBox4.Checked == true)
            {
                string query_by_full_name = "SELECT * FROM dbo.person WHERE dbo.person.first_name='" + tbxName.Text + "' AND dbo.person.last_name='" + tbx_lastname.Text + "'";
                TB_query = DataProvider.Instance.ExecuteQuery(query_by_full_name);
                foreach (DataRow item in TB_query.Rows)
                {
                    add_to_FLP_not_attend(item);
                }
            }
            if ( TB_query.Rows.Count == 0) btnAdd.Hide(); else btnAdd.Visible = true;
        }

        private void add_to_FLP_not_attend (DataRow item )
        {
            Button btn = new Button() { Width = 200, Height = 90, TextAlign = ContentAlignment.TopLeft };
            btn.Text = "ID :" + item[0].ToString() + "\nHọ : " + item[2].ToString() + "\ntên : " + item[1].ToString() + "\n CMT : " + item[11] + "\nngày sinh : " + (((DateTime)(item[3])).ToShortDateString().ToString());
            btn.Tag = item;
            btn.BackColor = Color.LightSkyBlue;
            FLP_not_attend.Controls.Add(btn);
        }
        private void add_to_FLP_attend(DataRow item)
        {
            Button btn = new Button() { Width = 250, Height = 90, TextAlign = ContentAlignment.TopLeft };
            btn.Text = "ID :" + item[0].ToString() + "\nHọ : " + item[2].ToString() + "\ntên : " + item[1].ToString() + "\n CMT : " + item[11] + "\nngày sinh : " + (((DateTime)(item[3])).ToShortDateString().ToString());
            btn.Tag = item[0];
            btn.BackColor = Color.LightSkyBlue;
            btn.Click += btn_Click;
            FLP_Attend.Controls.Add(btn);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            int ID_person = (int)((DataRowView)(cbxAddID.SelectedItem)).Row.ItemArray[0];
            string query_check = "SELECT ID FROM dbo.list_person_attend WHERE dbo.list_person_attend.Id_book_room_schedule ='" + Form1.app_tem.Id + "' and dbo.list_person_attend.Id_person_attend ='" + ID_person + "'";
            if(DataProvider.Instance.ExecuteQuery(query_check).Rows.Count==0)
            {
                MessageBox.Show("Thêm thành công");
                string query_insert = "INSERT INTO dbo.list_person_attend (Id_book_room_schedule,Id_person_attend)Values (" + Form1.app_tem.Id + "," + ID_person + ")";
                DataProvider.Instance.ExecuteQuery(query_insert);
                FLP_Attend.Controls.Clear();
                string query = "SELECT * FROM dbo.person WHERE dbo.person.Id in (SELECT Id_person_attend FROM dbo.list_person_attend WHERE dbo.list_person_attend.Id_book_room_schedule ='" + Form1.app_tem.Id + "')";
                DataTable TB = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in TB.Rows)
                {
                    add_to_FLP_attend(item);
                }
            }
            else
            {
                MessageBox.Show("Đã thêm trước đó");
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            int ID_person_Delete = (int)(sender as Button).Tag;
            if (MessageBox.Show("Bạn muốn xóa người này?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                string query_remove = "DELETE FROM dbo.list_person_attend WHERE Id_book_room_schedule = '" + Form1.app_tem.Id + "' AND Id_person_attend='" + ID_person_Delete + "'";
                DataProvider.Instance.ExecuteQuery(query_remove);
            }
        }

        private void Book_room_info_Load(object sender, EventArgs e)
        {

        }
    }
}
