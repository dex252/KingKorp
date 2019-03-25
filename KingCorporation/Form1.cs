using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingCorporation
{
    public partial class Form1 : Form
    {
        public SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kingCorporationDataSet8.SALES_ORDER". При необходимости она может быть перемещена или удалена.
            this.sALES_ORDERTableAdapter.Fill(this.kingCorporationDataSet8.SALES_ORDER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kingCorporationDataSet7.PRODUCT". При необходимости она может быть перемещена или удалена.
            this.pRODUCTTableAdapter.Fill(this.kingCorporationDataSet7.PRODUCT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kingCorporationDataSet6.PRICE". При необходимости она может быть перемещена или удалена.
            this.pRICETableAdapter.Fill(this.kingCorporationDataSet6.PRICE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kingCorporationDataSet5.LOCATION". При необходимости она может быть перемещена или удалена.
            this.lOCATIONTableAdapter.Fill(this.kingCorporationDataSet5.LOCATION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kingCorporationDataSet4.JOB". При необходимости она может быть перемещена или удалена.
            this.jOBTableAdapter.Fill(this.kingCorporationDataSet4.JOB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kingCorporationDataSet3.ITEM". При необходимости она может быть перемещена или удалена.
            this.iTEMTableAdapter.Fill(this.kingCorporationDataSet3.ITEM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kingCorporationDataSet2.EMPLOYEE". При необходимости она может быть перемещена или удалена.
            this.eMPLOYEETableAdapter.Fill(this.kingCorporationDataSet2.EMPLOYEE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kingCorporationDataSet1.DEPARTMENT". При необходимости она может быть перемещена или удалена.
            this.dEPARTMENTTableAdapter.Fill(this.kingCorporationDataSet1.DEPARTMENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kingCorporationDataSet.CUSTOMER". При необходимости она может быть перемещена или удалена.
            this.cUSTOMERTableAdapter.Fill(this.kingCorporationDataSet.CUSTOMER);

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AllHide();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (!dataGridView1.Visible) dataGridView1.Visible = true;
                    break;
                case 1:
                    if (!dataGridView2.Visible) dataGridView2.Visible = true;
                    break;
                case 2:
                    if (!dataGridView3.Visible) dataGridView3.Visible = true;
                    break;
                case 3:
                    if (!dataGridView4.Visible) dataGridView4.Visible = true;
                    break;
                case 4:
                    if (!dataGridView5.Visible) dataGridView5.Visible = true;
                    break;
                case 5:
                    if (!dataGridView6.Visible) dataGridView6.Visible = true;
                    break;
                case 6:
                    if (!dataGridView7.Visible) dataGridView7.Visible = true;
                    break;
                case 7:
                    if (!dataGridView8.Visible) dataGridView8.Visible = true;
                    break;
                case 8:
                    if (!dataGridView9.Visible) dataGridView9.Visible = true;
                    break;
            }
        }

        void AllHide()
        {
            if (dataGridView1.Visible) dataGridView1.Visible = false;
            if (dataGridView2.Visible) dataGridView2.Visible = false;
            if (dataGridView3.Visible) dataGridView3.Visible = false;
            if (dataGridView4.Visible) dataGridView4.Visible = false;
            if (dataGridView5.Visible) dataGridView5.Visible = false;
            if (dataGridView6.Visible) dataGridView6.Visible = false;
            if (dataGridView7.Visible) dataGridView7.Visible = false;
            if (dataGridView8.Visible) dataGridView8.Visible = false;
            if (dataGridView9.Visible) dataGridView9.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    Requests1();
                    break;
                case 1:
                    Requests2();
                    break;
                case 2:
                    Requests3();
                    break;
                case 3:
                   
                    break;
                case 4:
                   
                    break;
                case 5:
                    
                    break;
                case 6:
                   
                    break;
                case 7:
                    
                    break;
                case 8:
                   
                    break;
            }
        }

        private void Requests1()
        {
            // SELECT* FROM `table` GROUP BY name WHERE[Code] = @Code
            //  command.Parameters.AddWithValue("Code", textBox9.Text);
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand сommand = sqlConnection.CreateCommand();
            сommand.CommandText = "select [location_id] from [DEPARTMENT] group by [location_id]";
            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = сommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0];
                        text += "\n";
                    }

                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }

                    richTextBox1.Text = text;
                }
                catch
                {
                    MessageBox.Show("Что то пошло не так при считывании записей.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Что то пошло не так.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Requests2()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand сommand = sqlConnection.CreateCommand();
            сommand.CommandText = "select [last_name],  cast (NULLIF([commission],0)*100/[salary] as decimal (16, 2))  from [EMPLOYEE] ";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = сommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0] + " " + sqlReader[1];
                        text += "\n";
                    }

                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }

                    richTextBox1.Text = text;
                }
                catch
                {
                    MessageBox.Show("Что то пошло не так при считывании записей.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Что то пошло не так.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Requests3()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand сommand = sqlConnection.CreateCommand();
            сommand.CommandText = "select concat (LEFT ([first_name],1), '.',[middle_initial], '.',[last_name])  from [EMPLOYEE] ";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = сommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0];//+""+ sqlReader[1] + sqlReader[2];
                        text += "\n";
                    }

                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }

                    richTextBox1.Text = text;
                }
                catch
                {
                    MessageBox.Show("Что то пошло не так при считывании записей.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Что то пошло не так.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}