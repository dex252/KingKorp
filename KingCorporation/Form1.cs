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

        private void AllHide()
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
            label1.Text = "";
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Это худшее, что я когда-либо делал =( Целесообразней было бы занести все функции и их индексы в массив с последующим анализом

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
                    Requests4();
                    break;
                case 4:
                    Requests5();
                    break;
                case 5:
                    Requests6();
                    break;
                case 6:
                    Requests7();
                    break;
                case 7://8
                    Requests8();
                    break;
                case 8:
                    Requests9();
                    break;
                case 9:
                    Requests10();
                    break;
                case 10:
                    Requests11();
                    break;
                case 11:
                    Requests12();
                    break;
                case 12:
                    Requests13();
                    break;
                case 13:
                    Requests14();
                    break;
                case 14:
                    Requests15();
                    break;
                case 15:
                    Requests16();
                    break;
                case 16:
                    Requests17();
                    break;
                case 17:
                    Requests18();
                    break;
                case 18:
                    Requests19();
                    break;
                case 19:
                    Requests20();
                    break;
                case 20:
                    Requests21();
                    break;
                case 21:
                    Requests22();
                    break;
                case 22:
                    Requests23();
                    break;
                case 23:
                    Requests24();
                    break;
                case 24:
                    Requests25();
                    break;
                case 25:
                    Requests26();
                    break;
                case 26:
                    Requests27();
                    break;
                case 27:
                    Requests28();
                    break;
                case 28:
                    Requests29();
                    break;
                case 29:
                    Requests30();
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

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select [location_id] from [DEPARTMENT] group by [location_id]";
            label1.Text = "select [location_id] from [DEPARTMENT] group by [location_id]";
            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

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

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select [last_name],  cast (NULLIF([commission],0)*100/[salary] as decimal (16, 2))  from [EMPLOYEE] ";
            label1.Text = "select [last_name],  cast (NULLIF([commission],0)*100/[salary] as decimal (16, 2))  from [EMPLOYEE]";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

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

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select concat (LEFT ([first_name],1), '.',[middle_initial], '.',[last_name])  from [EMPLOYEE] ";
            label1.Text = "select concat (LEFT ([first_name],1), '.',[middle_initial], '.',[last_name])  from [EMPLOYEE] ";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

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

        private void Requests4()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT [total], CEILING ([total]), FLOOR([total]), ROUND([total], -1) FROM [SALES_ORDER]";

            label1.Text = "SELECT [total], CEILING ([total]), FLOOR([total]), ROUND([total], -1) FROM [SALES_ORDER]";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += (sqlReader[0]).ToString() + "         " + (sqlReader[1]).ToString() + "          " + (sqlReader[2]).ToString() + "          " + (sqlReader[3]).ToString();
                        text += "" + "\n";
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

        private void Requests5()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT [last_name] FROM [EMPLOYEE] WHERE ([salary] < [commission])";
            label1.Text = "SELECT[last_name] FROM[EMPLOYEE] WHERE([salary] < [commission])";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += (sqlReader[0]).ToString();
                        text += "" + "\n";
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

        private void Requests6()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT [last_name] FROM [EMPLOYEE] WHERE [last_name] LIKE 'S%'";
            label1.Text = "SELECT [last_name] FROM [EMPLOYEE] WHERE [last_name] LIKE 'S%'";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += (sqlReader[0]).ToString();
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

        private void Requests7()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select [first_name] from [EMPLOYEE] where ([job_id] != 671 AND [department_id] != 13)";
            label1.Text = "select [first_name] from [EMPLOYEE] where ([job_id] != 671 AND [department_id] != 13)";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

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

        private void Requests8()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "select [last_name] from [EMPLOYEE] INNER JOIN [JOB] ON ([EMPLOYEE].[job_id] = [JOB].[job_id]) WHERE ( ([JOB].[job_id] = 670) or ([JOB].[job_id] = 671) )";
            label1.Text = "select [last_name] from [EMPLOYEE] INNER JOIN [JOB] ON ([EMPLOYEE].[job_id] = [JOB].[job_id]) WHERE ( ([JOB].[job_id] = 670) or ([JOB].[job_id] = 671) )";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

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

        private void Requests9()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT [last_name] FROM [EMPLOYEE] WHERE ([last_name] LIKE 'MAR%' AND LEN([last_name]) = 6)";
            label1.Text = "Выбрать всех сотрудников, имена которых состоят из 6 букв и начинаются на 'MAR'. ";
            label1.Text += "\n" + "\n";
            label1.Text += "SELECT [last_name] FROM [EMPLOYEE] WHERE ([last_name] LIKE 'MAR%' AND LEN([last_name]) = 6)";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

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

        private void Requests10()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT [last_name], [hire_date] FROM [EMPLOYEE] WHERE [hire_date]  >= '19850415'";
            label1.Text = "Выбрать фамилии всех сотрудников, которые поступили на работу после 15 апреля 1985 года. ";
            label1.Text += "\n" + "\n";
            label1.Text += "SELECT [last_name], [hire_date] FROM [EMPLOYEE] WHERE [hire_date]  >= '19850415'";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += (sqlReader[0]).ToString() + "         " + (sqlReader[1]).ToString();
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

        private void Requests11()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT [last_name], YEAR([hire_date]) FROM [EMPLOYEE] WHERE YEAR([hire_date])  = '1985'";
            label1.Text = "Выбрать фамилии всех сотрудников, которые поступили на работу в 1985 году.";
            label1.Text += "\n" + "\n";
            label1.Text += "SELECT [last_name], YEAR([hire_date]) FROM [EMPLOYEE] WHERE YEAR([hire_date])  = '1985'";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += (sqlReader[0]).ToString() + "         " + (sqlReader[1]).ToString();
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

        private void Requests12()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT [last_name], (datediff(yyyy, [hire_date], getdate())) FROM [EMPLOYEE]";
            label1.Text = "Для каждого сотрудника выбрать количество полных лет работы в фирме. ";
            label1.Text += "\n" + "\n";
            label1.Text += "SELECT [last_name], (datediff(yyyy, [hire_date], getdate())) FROM [EMPLOYEE]";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += (sqlReader[0]).ToString() + "         " + (sqlReader[1]).ToString();
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

        private void Requests13()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM [EMPLOYEE] WHERE [commission] != 0";
            label1.Text = "Выбрать количество сотрудников, получающих комиссионные. ";
            label1.Text += "\n" + "\n";
            label1.Text += "SELECT COUNT(*) FROM [EMPLOYEE] WHERE [commission] != 0";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += (sqlReader[0]).ToString();
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

        private void Requests14()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT COUNT([total]), SUM([total]) FROM [SALES_ORDER] WHERE [customer_id] = 104";
            label1.Text = "Выбрать количество и общую сумму сделок, совершенных с покупателем, код которого - 104. ";
            label1.Text += "\n" + "\n";
            label1.Text += "SELECT COUNT([total]), SUM([total]) FROM [SALES_ORDER] WHERE [customer_id] = 104";

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() + "         " + sqlReader[1].ToString();
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

        private void Requests15()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT (SELECT [function] FROM [JOB] WHERE [job_id] = [EMPLOYEE].[job_id]), FLOOR(AVG([salary])) FROM [EMPLOYEE] GROUP BY [job_id]";

            label1.Text = "Выбрать среднюю зарплату по каждой должности. ";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() + "         " + sqlReader[1].ToString();
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

        private void Requests16()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT (SELECT [function] FROM [JOB] WHERE [job_id] = 670), FLOOR(AVG([salary])) FROM [EMPLOYEE] WHERE [job_id]=670";

            label1.Text = "Выбрать среднюю зарплату продавцов (код должности - 670).";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() + "         " + sqlReader[1].ToString();
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

        private void Requests17()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
           
            command.CommandText = "SELECT [job_id], FLOOR(AVG([salary])) FROM [EMPLOYEE] WHERE (([job_id]=670) or ([job_id]=667)) GROUP BY [job_id]";

            label1.Text = "Выбрать средние зарплаты продавцов (код должности - 670) и клерков (код должности - 667).";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() + "         " + sqlReader[1].ToString();
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

        private void Requests18()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT [product_id], COUNT([product_id]) FROM [ITEM] GROUP BY [product_id] HAVING COUNT([product_id]) < 10";


            label1.Text = "Выбрать коды продуктов, по которым было совершено меньше 10 продаж.";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() + "         " + sqlReader[1].ToString();
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

        private void Requests19()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT MAX([salary]), [department_id] FROM [EMPLOYEE] WHERE ([job_id]=670) GROUP BY [department_id]";

            label1.Text = "Выбрать максимальную зарплату продавцов (код должности - 670) по каждому отделу.";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() + "         " + sqlReader[1].ToString();
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

        private void Requests20()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT [last_name], [first_name] FROM [EMPLOYEE] ORDER BY [last_name], [first_name]";

            label1.Text = "Выбрать список сотрудников фирмы в алфавитном порядке.";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() + "         " + sqlReader[1].ToString();
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

        private void Requests21()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT [department_id], [name], (SELECT [regional_group] FROM [LOCATION] WHERE [location_id]=[DEPARTMENT].[location_id]) FROM [DEPARTMENT]";
           
            label1.Text = "Выбрать всю информацию о каждом отделе и месте его расположения.";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() + "         " + sqlReader[1].ToString() + "         " + sqlReader[2].ToString();
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

        private void Requests22()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT (SELECT [regional_group] FROM [LOCATION] WHERE [location_id]=(SELECT [location_id] FROM [DEPARTMENT] WHERE [department_id]=[EMPLOYEE].[department_id])), [last_name], (SELECT [function] FROM [JOB] WHERE [job_id]=[EMPLOYEE].[job_id]) FROM [EMPLOYEE] ORDER BY EMPLOYEE.department_id DESC";

            label1.Text = "Выбрать список фамилий сотрудников по городам, где они работают, с указанием для каждого его должности.";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() + "         " + sqlReader[1].ToString() + "         " + sqlReader[2].ToString();
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

        private void Requests23()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT [name] FROM [CUSTOMER] WHERE [salesperson_id]=(SELECT [employee_id] FROM [EMPLOYEE] WHERE [last_name]='TURNER')";

            label1.Text = "Выбрать всех покупателей, с которыми работает продавец TURNER.";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString();
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

        private void Requests24()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT [last_name] FROM [EMPLOYEE] WHERE (SELECT COUNT([salesperson_id]) FROM [CUSTOMER] WHERE [salesperson_id]=[EMPLOYEE].[employee_id])=0";

            label1.Text = "Выбрать сотрудников, которые не закреплены за конкретным заказчиком.";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString();
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

        private void Requests25()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT [EMPLOYEE].[last_name], [CUSTOMER].[name] FROM [EMPLOYEE],[CUSTOMER] WHERE (SELECT COUNT([salesperson_id]) FROM [CUSTOMER] WHERE [salesperson_id]=[EMPLOYEE].[employee_id])>1 AND [employee_id]=[salesperson_id] ORDER BY [EMPLOYEE].[employee_id]";

            label1.Text = "Выбрать имена продавцов, которые работают более чем с одним покупателем и названия покупателей, которых они обслуживают.";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() +"    "+ sqlReader[1].ToString();
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

        private void Requests26()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT SUM([total]) FROM [ITEM] WHERE " +
                "([order_id] IN (SELECT [order_id] FROM [SALES_ORDER] WHERE " +
                "([customer_id] IN (SELECT [customer_id] FROM [CUSTOMER] WHERE " +
                "([salesperson_id] IN (SELECT [employee_id] FROM [EMPLOYEE] WHERE " +
                "[EMPLOYEE].[last_name]='TURNER'))))))";

            label1.Text = "Выбрать сумму всех продаж, которые обеспечил продавец TURNER.";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString();
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

        private void Requests27()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            //1ый - выборка по лету 1990, 2ой = выборка по теннису 3 - id по датам 4(SUM)
            command.CommandText = "SELECT [total] FROM [ITEM] WHERE (([order_id] IN (SELECT [order_id] FROM [SALES_ORDER] WHERE ([order_date]>='1990.06.01 0:00:00' AND [order_date]<'1990.09.01 0:00:00'))) AND ([product_id] IN (SELECT [product_id] FROM [PRODUCT] WHERE [description] LIKE '%TENNIS%')))";
            // command.CommandText = "SELECT [total] FROM [ITEM] WHERE ([order_id] IN (SELECT [order_id] FROM [SALES_ORDER] WHERE ([order_date]>='1990.06.01 0:00:00' AND [order_date]<'1990.09.01 0:00:00')))";
            // command.CommandText = "SELECT [total] FROM [ITEM] WHERE ([product_id] IN (SELECT [product_id] FROM [PRODUCT] WHERE [description] LIKE '%TENNIS%'))";
            // command.CommandText = "SELECT [order_id] FROM [SALES_ORDER] WHERE ([order_date] >= '1990.06.01 0:00:00' AND [order_date] < '1990.09.01 0:00:00')";
            // command.CommandText = "SELECT SUM([total]) FROM [ITEM] WHERE (([order_id] IN (SELECT [order_id] FROM [SALES_ORDER] WHERE ([order_date]>='1990.06.01 0:00:00' AND [order_date]<'1990.09.01 0:00:00'))) AND ([product_id] IN (SELECT [product_id] FROM [PRODUCT] WHERE [description] LIKE '%TENNIS%')))";

            label1.Text = "Выбрать сумму всех продаж товаров, связанных с теннисом, за лето 1990г.";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString();
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

        private void Requests28()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT [first_name], [last_name], [salary] FROM [EMPLOYEE] WHERE [hire_date]=(SELECT MAX([hire_date]) FROM [EMPLOYEE]) OR [hire_date]= (SELECT MIN([hire_date]) FROM [EMPLOYEE])";

            label1.Text = " Выбрать имена и зарплаты самого старого и самого молодого сотрудника фирмы. ('Возраст' сотрудника определять по дате его поступления на работу в фирму). ";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() + "    " + sqlReader[1].ToString() + "    " + sqlReader[2].ToString();
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

        private void Requests29()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT  [first_name], [last_name], FLOOR([salary]-(SELECT AVG([salary]) FROM [EMPLOYEE])) FROM [EMPLOYEE]";

            label1.Text = "Для каждого продавца вывести разность между его зарплатой и средней зарплатой продавцов в фирме. ";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() + "  " + sqlReader[1].ToString() + "     " + sqlReader[2].ToString();
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

        private void Requests30()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            //Первый вариант - с middle_initial, т.к. однофомильцев нет, проверить - смена 1 на 0 в having
            command.CommandText = "SELECT [first_name], [middle_initial], [last_name] FROM [EMPLOYEE] WHERE [middle_initial] IN (SELECT [middle_initial] FROM [EMPLOYEE] GROUP BY [middle_initial] HAVING COUNT(*) > 3)";
            command.CommandText = "SELECT [first_name], [middle_initial], [last_name] FROM [EMPLOYEE] WHERE [last_name] IN (SELECT [last_name] FROM [EMPLOYEE] GROUP BY [last_name] HAVING COUNT(*) > 1)";

            label1.Text = "(*)Вывести имена, средние инициалы и фамилии всех однофамильцев. ";
            label1.Text += "\n" + "\n";
            label1.Text += command.CommandText;

            try
            {
                SqlDataReader sqlReader = null;
                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        text += sqlReader[0].ToString() + "   " + sqlReader[1].ToString() + "   " + sqlReader[2].ToString();
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