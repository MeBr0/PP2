using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelBook
{
    public partial class Main : Form
    {
        MySqlConnection connection;
        MySqlDataAdapter adapter;
        MySqlCommandBuilder builder;
        DataTable table;
        BindingSource binding;

        int pageNum;
        int pageSize;

        public Main()
        {
            InitializeComponent();
            pageNum = 1;
            pageSize = 14;
            Connect();
            SelectAll();
        }

        private void CreateClick(object sender, EventArgs e)
        {
            string name = nameText.Text;

            string number = numberText.Text;

            if (Check(name, number))
            {
                string currentDate = DateTime.Today.ToShortDateString();

                string _name = "'" + name + "'";

                string[] values = currentDate.Split('.');
                string date = values[2] + "-" + values[1] + "-" + values[0];

                string _date = "'" + date + "'";
                string _number = "'" + number + "'";

                DoIt("INSERT INTO telbook(`Id`, `Name`, `Date`, `TelNumber`) " +
                     "VALUES (' ', " + _name + "," + _date + "," + _number + ")");

                SelectAll();
                
                MessageBox.Show("Contact with name " + name + " and with number " + number + 
                    " successfully created");
            }

            else
            {
                MessageBox.Show("Name or Number is not valid");
            }
        }

        private void LeftClick(object sender, EventArgs e)
        {
            if (pageNum != 1)
                pageNum--;

            SelectAll();
        }

        private void RightClick(object sender, EventArgs e)
        {
            if (grid.DisplayedRowCount(true) > 1)
                pageNum++;

            SelectAll();
        }

        private bool Check(string name, string number)
        {
            bool isValid = true;

            if (number.Length != 11) isValid = false;

            else if (name.Length < 3) isValid = false;

            return isValid;
        }

        private void Search(object sender, EventArgs e)
        {
            string text = search.Text;

            if (text == "") return;

            connection.Open();

            DoIt("SELECT * FROM telbook WHERE Name = '" + text + "'");

            connection.Close();
        }

        private void SaveClick(object sender, EventArgs e)
        {
            adapter.Update(table);
        }
        
        private void DeleteClick(object sender, EventArgs e)
        {
            string msg = grid.SelectedRows[0].ToString();

            bool qwe = false;
            string q = "";

            for (int i = 0; i < msg.Length; ++i)
            {
                if (msg[i] == '}') qwe = false;

                if (qwe)
                {
                    q = q + msg[i];
                }

                if (msg[i] == '=') qwe = true;
            }

            int index = int.Parse(q);

            index++;

            DoIt("DELETE FROM telbook WHERE ID = " + index.ToString());
        }

        private void SortClickAsc(object sender, EventArgs e)
        {
            connection.Open();

            DoIt("SELECT * FROM telbook ORDER BY Date ASC");

            connection.Close();
        }

        private void SortClickDesc(object sender, EventArgs e)
        {
            connection.Open();

            DoIt("SELECT * FROM telbook ORDER BY Date DESC");

            connection.Close();
        }

        private void Connect()
        {
            connection = new MySqlConnection(
                "SERVER=127.0.0.1; SslMode=none;" +
                "DATABASE = contacts;" +
                "UID = root;" +
                "PASSWORD = ");
        }

        private void SelectAll()
        {
            connection.Open();

            DoIt("SELECT * FROM telbook WHERE Id BETWEEN " + ((pageNum - 1) * pageSize + 1).ToString()
                + " AND " + (pageNum * pageSize).ToString());

            connection.Close();
        }

        private void DoIt(string msg)
        {
            adapter = new MySqlDataAdapter(msg, connection);
            builder = new MySqlCommandBuilder(adapter);

            if(!msg.Contains("INSERT")) 
            {
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.DeleteCommand = builder.GetUpdateCommand();
                adapter.InsertCommand = builder.GetUpdateCommand();
            }

            table = new DataTable();
            adapter.Fill(table);

            binding = new BindingSource();
            binding.DataSource = table;

            grid.DataSource = binding;
        }
    }
}
