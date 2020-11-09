﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDoList: ITable
    {
        public string Id { get; private set; }
        public string UserId { get; private set; }
        public string Name { get; set; }
        public string Note { private get; set; }
        public string DeadLine { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Url { get; set; }

        static public string TableName = "todolist";
        public List<string> ColumnNames;

        public List<string> GetColumnNames()
        {
            return ColumnNames;
        }
        public string GetTableName()
        {
            return TableName;
        }

        public List<string> GetData()
        {
            List<string> userData = new List<string>();
            if (Id == null)
                Id = "NULL";
            userData.Add(Id);
            userData.Add(UserId);
            userData.Add(Name);
            userData.Add(Note);
            userData.Add(DeadLine);
            userData.Add(Status);
            userData.Add(Priority);
            userData.Add(Url);
            return userData;
        }


        private void SetColumnNames()
        {
            ColumnNames = new List<string>();
            ColumnNames.Add("id");
            ColumnNames.Add("userId");
            ColumnNames.Add("name");
            ColumnNames.Add("note");
            ColumnNames.Add("deadLine");
            ColumnNames.Add("status");
            ColumnNames.Add("priority");
            ColumnNames.Add("url");
        }

        public ToDoList(
               // string Id,
                string UserId,
                string Name,
                string Note,
                string DeadLine,
                string Status,
                string Priority,
                string Url
            )
        {
           // this.Id = Id;
            this.UserId = UserId;
            this.Name = Name;
            this.Note = Note;
            this.DeadLine = DeadLine;
            this.Status = Status;
            this.Priority= Priority;
            this.Url= Url;

            SetColumnNames();
        }

        public ToDoList (List<string> UserData)
        {
            GetDataFromList(UserData);
            SetColumnNames();
        }
        public void GetDataFromList(List<string> UserData)
        {
            this.Id = UserData[0];
            this.UserId = UserData[1];
            this.Name = UserData[2];
            this.Note = UserData[3];
            this.DeadLine = UserData[4];
            this.Status = UserData[5];
            this.Priority = UserData[6];
            this.Url = UserData[7];

        }
    }
}
