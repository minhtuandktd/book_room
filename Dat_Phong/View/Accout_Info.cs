using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dat_Phong;
using Dat_Phong.Model;
namespace Dat_Phong.View
{
    public partial class Account_Info : Form
    {
        
        public Account_Info()
        {
            InitializeComponent();
        }

        private void Account_Info_Load(object sender, EventArgs e)
        {
            pictureEdit1.Image = Image.FromFile(Form1.account.ItemArray[4].ToString());
            LbBirthday.Text= (((DateTime)Form1.account.ItemArray[3]).ToShortDateString()).ToString();
            LbFirstname.Text = Form1.account.ItemArray[1].ToString();
            LbLastname.Text = Form1.account.ItemArray[2].ToString();
            tbxEmail.Text = Form1.account.ItemArray[10].ToString();
            tbxAddress.Text = Form1.account.ItemArray[5].ToString();
            tbxPhone_number.Text = Form1.account.ItemArray[7].ToString();
            LbID_card.Text= Form1.account.ItemArray[11].ToString();
            LbRFID.Text = Form1.account.ItemArray[12].ToString();
            if ((string)Form1.account.ItemArray[6] == "0") cBxFemale.Checked = true;
            if ((string)Form1.account.ItemArray[6] == "1") cBxMale.Checked = true;
            // nếu cả 2 ô ko check => giới tính thứ 3, nên khong dùng bool được 
            string query_make_app, query_attend;
            query_make_app = "SELECT * FROM dbo.book_room_schedule WHERE dbo.book_room_schedule.Id_person_book='" + LoginForm.ID_USER + "'";
            query_attend = "SELECT * FROM dbo.book_room_schedule WHERE dbo.book_room_schedule.Id in (Select Id_book_room_schedule FROM dbo.list_person_attend WHERE Id_person_attend='" + LoginForm.ID_USER + "')";
            DataTable TbMakeApp = DataProvider.Instance.ExecuteQuery(query_make_app);
            DataTable TbAttend = DataProvider.Instance.ExecuteQuery(query_attend);
            DataTable Tbroom;
            string str_search_room = "SELECT name FROM dbo.room WHERE dbo.room.Id = ";

            foreach (DataRow item in TbMakeApp.Rows)
            {
                Tbroom = DataProvider.Instance.ExecuteQuery(str_search_room + item[1].ToString());
                Button btn = new Button() { Width = 440, Height = 90, TextAlign = ContentAlignment.TopLeft };
                btn.Text = "mã cuộc họp : " + item[0].ToString() + " \nphòng            : " + Tbroom.Rows[0].ItemArray[0] + " \ntiêu đề           : " + item[7] + " \ntừ                   : " + (((DateTime)(item[2])).ToShortTimeString().ToString()) + "  đến: " + (((DateTime)(item[3])).ToShortTimeString().ToString()) + "  ngày " + (((DateTime)(item[2])).ToShortDateString().ToString());
                //btn.Click += btn_Click;
                btn.Tag = item;
                btn.BackColor = Color.LightSkyBlue;
                FLP_make.Controls.Add(btn);
            }
            foreach (DataRow item in TbAttend.Rows)
            {
                Tbroom = DataProvider.Instance.ExecuteQuery(str_search_room + item[1].ToString());
                Button btn2 = new Button() { Width = FLP_attend.Size.Width, Height = 90, TextAlign = ContentAlignment.TopLeft };
                btn2.Text = "mã cuộc họp : " + item[0].ToString() + " \nphòng            : " + Tbroom.Rows[0].ItemArray[0] + " \ntiêu đề           : " + item[7] + " \ntừ                   : " + (((DateTime)(item[2])).ToShortTimeString().ToString()) + "  đến: " + (((DateTime)(item[3])).ToShortTimeString().ToString()) + "  ngày " + (((DateTime)(item[2])).ToShortDateString().ToString());
                //btn.Click += btn_Click;
                btn2.Tag = item;
                btn2.BackColor = Color.LightSkyBlue;
                FLP_attend.Controls.Add(btn2);

            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string strUpdate = "UPDATE dbo.person SET address ='" + tbxAddress.Text + "',email = '" + tbxEmail.Text+ "',phone_number='" + tbxPhone_number.Text + "'  WHERE Id = '" + LoginForm.ID_USER + "'";
            DataProvider.Instance.ExecuteQuery(strUpdate);
            MessageBox.Show("update complete (((:", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

