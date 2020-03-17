using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dat_Phong.Model;
namespace Dat_Phong.View
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public static int ID_USER = 0;
        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string queryLogin = "SELECT * FROM dbo.person WHere dbo.person.username='" + txtUser.Text+"'And password='"+txtPass.Text + "'";
            DataTable arrlogin = DataProvider.Instance.ExecuteQuery(queryLogin);
            if (arrlogin.Rows.Count==1)
            {
                foreach (DataRow item in arrlogin.Rows)
                {
                    //global_var.accout =  new person_Info(item);
                    person_Info accout = new person_Info(item);
                    ID_USER = (int)item[0];
                    this.Close();
                   
                }
            }
            else
            {
                LbIncorrect.Visible = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                 txtPass.UseSystemPasswordChar = false;
            else txtPass.UseSystemPasswordChar = true;
        }
    }
}
