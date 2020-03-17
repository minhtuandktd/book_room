using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dat_Phong.Model
{
    class person_Info
    {
        private
        int Id;
        string first_name, last_name, avatar, address, sex, phone_number, username, password, email, ID_card, RFID;
        DateTime date_of_birth;
        public person_Info()
        { }
        public person_Info(int Id, string first_name, string last_name, DateTime date_of_birth, string avatar, string address, string sex, string phone_number, string username, string password, string job, string ID_card , string RFID)
        {
            this.ID = Id;
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Date_of_birth = date_of_birth;
            this.Avatar = avatar;
            this.Address = address;
            this.Sex = sex;
            this.Phone_number = phone_number;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.ID_Card = ID_card;
            this.RFId = RFID;
            


        }

        public person_Info(DataRow row)
        {
            this.ID = (int)row["Id"];
            this.First_name = row["first_name"].ToString(); 
            this.Last_name = row["last_name"].ToString();
            this.Date_of_birth = (DateTime)row["date_of_birth"]; 
            this.Avatar = row["avatar"].ToString(); 
            this.Address = row["address"].ToString(); 
            this.Sex = row["sex"].ToString(); 
            this.Phone_number = row["phone_number"].ToString(); 
            this.Username = row["username"].ToString(); 
            this.Password = row["password"].ToString(); 
            this.Email = row["email"].ToString(); 
            this.ID_Card = row["ID_card"].ToString(); 
            this.RFId = row["RFID"].ToString(); 
            
        }
        public int ID
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public DateTime Date_of_birth
        {
            get { return date_of_birth; }
            set { date_of_birth = value; }
        }

        public string Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Phone_number
        {
            get { return phone_number; }
            set { phone_number = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string ID_Card
        {
            get { return ID_card; }
            set { ID_card = value; }
        }
        public string RFId
        {
            get { return RFID; }
            set { RFID = value; }
        }
    }
}
