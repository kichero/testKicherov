using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using PleasantRustle.Properties;

namespace PleasantRustle
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }
        static int canger = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            Item();

        }
        string qwe = "select* from view1";
        private void Item()
        {
            

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conectDB"].ConnectionString);
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(qwe, sqlConnection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            int count = dataSet.Tables[0].Rows.Count;
            ListItem[] listItem = new ListItem[count];

            int min = 10 * (canger - 1);
            int max = 10 * canger;
            for (int i = min; i < max; i++)
            {
                listItem[i] = new ListItem();
                listItem[i].NameAgent = dataSet.Tables[0].Rows[i][0].ToString();
                listItem[i].Type = dataSet.Tables[0].Rows[i][1].ToString();
                listItem[i].NomebrPhone = dataSet.Tables[0].Rows[i][2].ToString();
                listItem[i].Priority = dataSet.Tables[0].Rows[i][3].ToString();
                string str = dataSet.Tables[0].Rows[i][4].ToString();
                listItem[i].Icon = Image.FromFile(str);

                if (flowLayoutPanel1.Controls.Count < 0)
                    flowLayoutPanel1.Controls.Clear();
                else
                    flowLayoutPanel1.Controls.Add(listItem[i]);

            }


        }




        public void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                    sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conectDB"].ConnectionString);
                    sqlConnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select* from view1 Order by Priority ASC", sqlConnection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    int count = dataSet.Tables[0].Rows.Count;
                    ListItem[] listItem = new ListItem[count];
                    for (int i = 0; i < listItem.Length; i++)
                    {
                        listItem[i] = new ListItem();
                        listItem[i].NameAgent = dataSet.Tables[0].Rows[i][0].ToString();
                        listItem[i].Type = dataSet.Tables[0].Rows[i][1].ToString();
                        listItem[i].NomebrPhone = dataSet.Tables[0].Rows[i][2].ToString();
                        listItem[i].Priority = dataSet.Tables[0].Rows[i][3].ToString();
                        string str = dataSet.Tables[0].Rows[i][4].ToString();
                        listItem[i].Icon = Image.FromFile(str);



                        flowLayoutPanel1.Controls.Add(listItem[i]);

                    }
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    flowLayoutPanel1.Controls.Clear();
                    sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conectDB"].ConnectionString);
                    sqlConnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select* from view1 Order by Priority DESC", sqlConnection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    int count = dataSet.Tables[0].Rows.Count;
                    ListItem[] listItem = new ListItem[count];
                    for (int i = 0; i < listItem.Length; i++)
                    {
                        listItem[i] = new ListItem();
                        listItem[i].NameAgent = dataSet.Tables[0].Rows[i][0].ToString();
                        listItem[i].Type = dataSet.Tables[0].Rows[i][1].ToString();
                        listItem[i].NomebrPhone = dataSet.Tables[0].Rows[i][2].ToString();
                        listItem[i].Priority = dataSet.Tables[0].Rows[i][3].ToString();
                        string str = dataSet.Tables[0].Rows[i][4].ToString();
                        listItem[i].Icon = Image.FromFile(str);



                        flowLayoutPanel1.Controls.Add(listItem[i]);

                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                    sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conectDB"].ConnectionString);
                    sqlConnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from view1 order by Title ASC", sqlConnection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    int count = dataSet.Tables[0].Rows.Count;
                    ListItem[] listItem = new ListItem[count];
                    for (int i = 0; i < listItem.Length; i++)
                    {
                        listItem[i] = new ListItem();
                        listItem[i].NameAgent = dataSet.Tables[0].Rows[i][0].ToString();
                        listItem[i].Type = dataSet.Tables[0].Rows[i][1].ToString();
                        listItem[i].NomebrPhone = dataSet.Tables[0].Rows[i][2].ToString();
                        listItem[i].Priority = dataSet.Tables[0].Rows[i][3].ToString();
                        string str = dataSet.Tables[0].Rows[i][4].ToString();
                        listItem[i].Icon = Image.FromFile(str);



                        flowLayoutPanel1.Controls.Add(listItem[i]);

                    }
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    flowLayoutPanel1.Controls.Clear();

                    sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conectDB"].ConnectionString);
                    sqlConnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from view1 order by Title ASC", sqlConnection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    int count = dataSet.Tables[0].Rows.Count;
                    ListItem[] listItem = new ListItem[count];
                    for (int i = 0; i < listItem.Length; i++)
                    {
                        listItem[i] = new ListItem();
                        listItem[i].NameAgent = dataSet.Tables[0].Rows[i][0].ToString();
                        listItem[i].Type = dataSet.Tables[0].Rows[i][1].ToString();
                        listItem[i].NomebrPhone = dataSet.Tables[0].Rows[i][2].ToString();
                        listItem[i].Priority = dataSet.Tables[0].Rows[i][3].ToString();
                        string str = dataSet.Tables[0].Rows[i][4].ToString();
                        listItem[i].Icon = Image.FromFile(str);


                        flowLayoutPanel1.Controls.Add(listItem[i]);

                        if (comboBox2.SelectedIndex == 1)
                        {
                            flowLayoutPanel1.Controls.Clear();
                            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conectDB"].ConnectionString);
                            sqlConnection.Open();
                            SqlDataAdapter adapter1 = new SqlDataAdapter("select * from view1 order by Title DESC", sqlConnection);
                            DataSet dataSet1 = new DataSet();
                            adapter.Fill(dataSet1);
                            int count1 = dataSet1.Tables[0].Rows.Count;
                            ListItem[] listItem1 = new ListItem[count];
                            for (int i1 = 0; i1 < listItem1.Length; i1++)
                            {
                                listItem1[i1] = new ListItem();
                                listItem1[i1].NameAgent = dataSet1.Tables[0].Rows[i1][0].ToString();
                                listItem1[i1].Type = dataSet1.Tables[0].Rows[i1][1].ToString();
                                listItem1[i1].NomebrPhone = dataSet1.Tables[0].Rows[i1][2].ToString();
                                listItem1[i1].Priority = dataSet1.Tables[0].Rows[i1][3].ToString();
                                string str1 = dataSet1.Tables[0].Rows[i1][4].ToString();
                                listItem1[i1].Icon = Image.FromFile(str1);
                                flowLayoutPanel1.Controls.Add(listItem[i1]);
                            }

                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            qwe = "select* from view1 where Title like'%"+textBox1.Text+ "%'";
            Item();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (canger < 10)
            {
                canger--;
                Item();
            }
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (canger > 0)
            {
                canger++;
                Item();
            }
        }
    }
}
