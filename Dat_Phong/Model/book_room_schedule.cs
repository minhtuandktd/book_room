using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Dat_Phong.Model
{
    class book_room_schedule
    {
        private
            int Id, Id_room, Id_person_book, border, color;
            DateTime start_time, end_time;
            string title;
        public book_room_schedule(int Id, int Id_room, DateTime start_time, DateTime end_time, int Id_person_book, int border, int color, string title)
        {
            this.ID = Id;
            this.ID_room = Id_room;
            this.Start_time = start_time;
            this.End_time = end_time;
            this.ID_person_book = Id_person_book;
            this.Border = border;
            this.Color = color;
            this.Title = title;
        }

        public book_room_schedule(DataRow row)
        {
            this.ID = (int)row["Id"]; ;
            this.ID_room = (int)row["Id_room"]; ;
            this.Start_time = (DateTime)row["start_time"] ; ;
            this.End_time = (DateTime)row["end_time"]; ;
            this.ID_person_book = (int)row["Id_person_book"]; ;
            this.Border = (int)row["border"]; ;
            this.Color = (int)row["color"]; ;
            this.Title = row["title"].ToString(); ;
        }
        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        
        public int ID_room
        {
            get { return Id_room; }
            set { Id_room = value; }
        }

        public int ID_person_book
        {
            get { return Id_person_book; }
            set { Id_person_book = value; }
        }

        public int Border 
        {
            get { return border; }
            set { border = value; }
        }

        public int Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public DateTime Start_time
        {
            get { return start_time; }
            set { start_time = value; }
        }

        public DateTime End_time
        {
            get { return end_time; }
            set { end_time = value; }
        }
        //public List<book_room_schedule> LoadBook_room_schedule()
        //{
        //    List<book_room_schedule> Book_room_schedule_List = new List<book_room_schedule>();

        //    DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetDriverList");

        //    foreach (DataRow item in data.Rows)
        //    {
        //        Driver driver = new Driver(item);
        //        DriverList.Add(driver);
        //    }

        //    return DriverList;

        //}

        //public bool InsertDriver(string name, string phone, string dob, string homeTown, string carType, string carNumber, string status, string charge)
        //{
        //    string query = string.Format("insert into dbo.Driver ( name,phone,dob,homeTown,carType,carNumber,status,charge) values  ( N'{0}', N'{1}', N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", name, phone, dob, homeTown, carType, carNumber, status, charge);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}

        //public bool UpdateDriver(int id, string name, string phone, string dob, string homeTown, string carType, string carNumber, string status, string charge)
        //{
        //    string query = string.Format("update dbo.Driver set name = N'{0}',phone = N'{1}',dob=N'{2}',homeTown=N'{3}',carType=N'{4}',carNumber=N'{5}',status=N'{6}',charge= N'{7}' where id = {8}", name, phone, dob, homeTown, carType, carNumber, status, charge, id);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}

        //public bool DeleteDriver(int id)
        //{
        //    string query = string.Format("update dbo.Driver set status=N'Đã nghỉ hưu' where id={0}", id);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;

        //}
        //public bool UpdateCostRate(int level1, int level2, int level3, int level4)
        //{
        //    string query = string.Format("update dbo.CostRate set level1={0},level2={1},level3={2},level4={3}", level1, level2, level3, level4);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}

        //public DataTable GetTripByDate(DateTime checkIn, DateTime checkOut)
        //{
        //    return DataProvider.Instance.ExecuteQuery("exec USP_GetTripByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        //}

        //public int GetNumTripByDate(DateTime checkIn, DateTime checkOut)
        //{
        //    return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumTripByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        //}

        //public int GetSumCostTripByDate(DateTime checkIn, DateTime checkOut)
        //{
        //    return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetSumCostTripByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        //}
        //public bool UpdateAccount(string displayName, string newPass)
        //{
        //    int result = DataProvider.Instance.ExecuteNonQuery(string.Format(("update dbo.Account set DisplayName=N'{0}',PassWord=N'{1}'"), displayName, newPass));

        //    return result > 0;
        //}

        //public string GetPassWord()
        //{
        //    return (String)DataProvider.Instance.ExecuteScalar("select PassWord from dbo.Account");
        //}

    }
}
