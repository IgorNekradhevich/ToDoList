using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class User
    {
        public string Id { get; private set; }
        public string UserName { get;  set; }
        public string Pass { private get;  set; }
        public string Date { get;  set; }
        static public  string TableName = "logins";
        public List<string> ColumnNames { get; private set; }

        private void SetColumnNames()
        {
            ColumnNames = new List<string>();
            ColumnNames.Add("id");
            ColumnNames.Add("user");
            ColumnNames.Add("pass");
            ColumnNames.Add("regDate");
        }
        public User  ( string UserName, string Password, string RegDate)
        {
            this.UserName = UserName;
            Pass = Password;
            Date= RegDate ;
            SetColumnNames();
        }

        public User(List<string> UserData) 
        {
            getDataFromList(UserData);
            SetColumnNames(); 
        }
        public void getDataFromList(List<string> UserData)
        {
            UserName = UserData[1];
            Pass = UserData[2];
            Date = UserData[3];
            Id = UserData[0];
          
        }
    }
}
