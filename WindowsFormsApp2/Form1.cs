using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StudentInformation
{
    public partial class Form1 : Form
    {
        int namecount = 0;
        int seccount = 0;
        int epcount = 0;
        int r_ep = 1749001;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection
        ("server =DESKTOP-5HVM8JU\\SQLEXPRESS;database=students;integrated security=true");

        public Form1()
        {
            InitializeComponent();
        }

        private void Apply(object sender, EventArgs e)
        {
            con.Open();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                cmd = new SqlCommand("insert into info values(@a,@b,@c)", con);
                cmd.Parameters.AddWithValue("@a", textBox1.Text);
                cmd.Parameters.AddWithValue("@b", textBox2.Text);
                cmd.Parameters.AddWithValue("@c", Convert.ToInt32(textBox3.Text));

            }
            else
            {
                MessageBox.Show("enter complete data");
                return;
            }
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                //MessageBox.Show("EP number:"+textBox3.Text+" is already used.enter correct EP");
            }
            textBox1.Text = textBox2.Text = textBox3.Text = null;
            con.Close();
        }

        private void DeleteSQLData(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from info", con);
            cmd.ExecuteNonQuery();
            RemoveListviewData();
            r_ep = 1749000;
            con.Close();
        }

        private void Searching(object sender, EventArgs e)
        {
            con.Open();
            if (comboBox1.SelectedItem.ToString() == "NAME")
            {
                cmd = new SqlCommand("select * from info where name = @name", con);
                cmd.Parameters.AddWithValue("@name", textBox4.Text);
            }
            else if (comboBox1.SelectedItem.ToString() == "SECTION")
            {
                cmd = new SqlCommand("select * from info where sec = @sec", con);
                cmd.Parameters.AddWithValue("@sec", textBox4.Text);
            }
            else if (comboBox1.SelectedItem.ToString() == "EP NUMBER")
            {
                cmd = new SqlCommand("select * from info where ep = @name", con);
                cmd.Parameters.AddWithValue("@name", textBox4.Text);
            }

            SqlDataReader r = cmd.ExecuteReader();
            RemoveListviewData();
            ListViewItem l;
            while (r.Read())
            {
                l = new ListViewItem(r.GetString(0));
                l.SubItems.Add(r.GetString(1));
                l.SubItems.Add(r.GetInt32(2).ToString());
                listView1.Items.Add(l);
            }
            if (!r.Read())
            {
                MessageBox.Show("result not found");
            }
            con.Close();
            r.Close();
        }

        private void DeleteRow(object sender, MouseEventArgs e)
        {
            con.Open();
            int ind=0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem a = listView1.Items[i];
                if (a.Selected)
                {
                    ind = i;
                    break;
                }
            }
            ListViewItem l = listView1.Items[ind];
            string s = l.SubItems[2].Text;
            cmd = new SqlCommand("delete from info where ep = @a", con);
            cmd.Parameters.AddWithValue("@a", s);
            cmd.ExecuteNonQuery();
            con.Close();
            RemoveListviewData();
            ShowSQLData();
        }

        private void Show(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ShowSQLData();
        }

        private void GenerateRandomData(object sender, EventArgs e)
        {
            string r_name = RandomString(10);
            con.Open();
            cmd=new SqlCommand("insert into info values(@name,'a',@ep)",con);
            cmd.Parameters.AddWithValue("@name", r_name);
            cmd.Parameters.AddWithValue("@ep", r_ep);
            try {
                cmd.ExecuteNonQuery(); }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("EP number:"+r_ep+" already exist.enter correct EP");
            }
            con.Close();
            RemoveListviewData();
            ShowSQLData();
            r_ep++;
            }

        public void ShowSQLData()
        {
            con.Open();
            ListViewItem l;
            cmd = new SqlCommand("select * from info", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                l = new ListViewItem(reader.GetString(0));
                l.SubItems.Add(reader.GetString(1).ToUpper());
                l.SubItems.Add(reader.GetInt32(2).ToString());
                listView1.Items.Add(l);
            }
            con.Close();
            reader.Close();
            return;
        }

        public void RemoveListviewData()
        {
            foreach (ListViewItem a in listView1.Items)
            {
                a.Remove();
            }
            return;
        }

        public string RandomString(int length)
        {
            Random r = new Random();
            string c = "abcdefghijklmnopqrstuvwxyz";
            string result = null;
            for (int i = 0; i < length; i++)
            {
                result += c[r.Next(25)];
            }
            return result;
        }

        private void Sorting(object sender, ColumnClickEventArgs e)
        {
            RemoveListviewData();
            if (e.Column == 0)
            {
                if (namecount==0)
                {
                    SQLSort("name",false);
                    namecount = 1;
                }
                else
                {
                    SQLSort("sec", true);
                    namecount = 0;
                }
            }
            else if (e.Column == 1)
            {
                if (seccount == 0)
                {
                    SQLSort("sec", false);
                    seccount = 1;
                }
                else
                {
                    SQLSort("sec", true);
                    seccount = 0;
                }
            }
            else if (e.Column==2)
            {
                if (epcount == 0)
                {
                    SQLSort("ep", false);
                    epcount = 1;
                }
                else
                {
                    SQLSort("ep", true);
                    epcount = 0;
                }
            }
        }

        public void SQLSort(string s,bool order_desc)
        {

            ListViewItem l;
            con.Open();
            if (!order_desc)
                cmd = new SqlCommand("select * from info order by " + s, con);
            else if (order_desc)
                cmd = new SqlCommand("select * from info order by "+s+ " desc", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                l = new ListViewItem(reader.GetString(0));
                l.SubItems.Add(reader.GetString(1).ToUpper());
                l.SubItems.Add(reader.GetInt32(2).ToString());
                listView1.Items.Add(l);
            }
            con.Close();
            reader.Close();
            return;
        }
    }
}
