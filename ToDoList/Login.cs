﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySQLConnectionString connStr; 
        MySQLDBConnection mySQLDB;
        SELECT select;

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            select.Select(User.TableName, "user = '" + TBName.Text + "' and pass ='" + TBPass.Text + "'");
            if (select.TableToList(0) != null)
            {
                User loginUser = new User(select.TableToList(0));
                ToDo toDo = new ToDo(loginUser.Id);
                toDo.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Не правильное имя пользователя или пароль.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            connStr = new MySQLConnectionString("localhost", "root", "root", "testDb");
            mySQLDB = new MySQLDBConnection(connStr);
            select = new SELECT(mySQLDB);
           /* User test = new User("test", "test", "2020-01-01");
            INSERT insert = new INSERT(mySQLDB);
            insert.Insert(test);*/
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MySQLConnectionString connStr = 
        //        new MySQLConnectionString("localhost", "root", "root", "testDb");

        //    MySQLDBConnection mySQLDB = new MySQLDBConnection(connStr);

        //    SELECT select = new SELECT(mySQLDB);
        //    User test = new User();
        //    test.getDataFromList(select.select("logins","id=2"));
        //    MessageBox.Show(test.Id + " " + test.UserName + " " + test.Date);

        //}
    }
}
