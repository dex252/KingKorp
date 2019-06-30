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
                case 30:
                    Requests31();
                    break;
                case 31:
                    Requests32();
                    break;
                case 32:
                    Requests33();
                    break;
                case 33:
                    Requests34();
                    break;
                //case 34:
                //    Requests35();
                //    break;
                case 35:
                    Requests36();
                    break;
                case 36:
                    Requests37();
                    break;
                case 37:
                    Requests38();
                    break;
                case 38:
                    Requests39();
                    break;
                case 39:
                    Requests40();
                    break;
                case 40:
                    Requests41();
                    break;
                case 41:
                    Requests42();
                    break;
                case 42:
                    Requests43();
                    break;
                //case 43:
                //    Requests44();
                //    break;
                //case 44:
                //    Requests45();
                //    break;
                //case 45:
                //    Requests46();
                //    break;
                case 46:
                    Requests47();
                    break;
                //case 47:
                //    Requests48();
                //    break;
                case 48:
                    Requests49();
                    break;
                    //case 49:
                    //    Request50();
                    //    break;

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
                        text += sqlReader[0].ToString() + "    " + sqlReader[1].ToString();
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

        private void Requests31()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            //НЕ округлял!
            command.CommandText = "SELECT [department_id],(SELECT [name] FROM [DEPARTMENT] WHERE [department_id]=[EMPLOYEE].[department_id]), CONCAT(100/(SELECT count(*) FROM [EMPLOYEE])*count([employee_id]), '% people'), CONCAT(100/(SELECT sum([salary]) FROM [EMPLOYEE])*sum([salary]), '% salary') FROM [EMPLOYEE] GROUP BY [department_id]";
            label1.Text = "Для каждого отдела выбрать процент, который составляют сотрудники отдела от общего числа сотрудников фирмы," +
                " и процент, который составляет зарплата отдела от общей зарплаты фирмы. ";
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
                        text += sqlReader[0].ToString() + "   " + sqlReader[1].ToString() + "   " + sqlReader[2].ToString() + "   " + sqlReader[3].ToString();
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

        private void Requests32()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            //НЕ округлял!
            command.CommandText = "SELECT [employee_id], [last_name], [first_name], [department_id], [manager_id] FROM [EMPLOYEE] WHERE " +
                "([employee_id] IN (SELECT [manager_id] FROM [EMPLOYEE] WHERE [employee_id] IN (SELECT [manager_id] FROM [EMPLOYEE])))";
            label1.Text = "Выбрать фамилии начальников тех отделов, которые имеют разветвленную структуру" +
                " (т.е. тех начальников, у прямых подчиненных которых есть свои подчиненные). . ";
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
                        text += sqlReader[0].ToString() + "   " + sqlReader[1].ToString() + "   " + sqlReader[2].ToString() + "   " + sqlReader[3].ToString() + "  |  " + sqlReader[4].ToString();
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

        private void Requests33()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            //Не работает тут max, долго мучался
            command.CommandText = "SELECT [department_id], [name]," +
                " (SELECT SUM([total]) from [SALES_ORDER] WHERE [customer_id] IN (SELECT [customer_id] from [CUSTOMER] WHERE [salesperson_id] IN (SELECT [employee_id] FROM [EMPLOYEE] WHERE [department_id]=[DEPARTMENT].[department_id]))) AS price, " +
                "(SELECT [regional_group] FROM [LOCATION] WHERE [location_id]=[DEPARTMENT].[location_id]) FROM [DEPARTMENT]" +
                "ORDER BY [price] DESC";
            label1.Text = " Выбрать названия отдела, заключившего сделки на самую большую сумму, и города, в котором он находится";
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
                        text += sqlReader[0].ToString() + "   " + sqlReader[1].ToString() + "   " + sqlReader[2].ToString() + "   " + sqlReader[3].ToString();
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

        private void Requests34()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "select (select description from PRODUCT where product_id=ITEM.product_id), (select ship_date from SALES_ORDER where order_id=ITEM.order_id), actual_price from ITEM where (actual_price/100*75<(select list_price from PRICE where product_id=(select product_id from PRODUCT where product_id=ITEM.product_id) and (start_date < (select order_date from SALES_ORDER where order_id=ITEM.order_id) ) and (end_date > (select order_date from SALES_ORDER where order_id=ITEM.order_id) ))) order by product_id";
            label1.Text = "Выбрать название товара, дату продажи, цену продажи для всех случаев, когда товары продавались ниже, чем за 75% их объявленной цены";
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

        private void Requests35()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            //возвращает несколько значений!? - переделать
            command.CommandText = "select (total-quantity*(actual_price-(select list_price from PRICE where product_id=(select DISTINCT product_id from PRODUCT where product_id=ITEM.product_id) and (start_date<(select DISTINCT order_date from SALES_ORDER where order_id=(select DISTINCT order_id from ITEM where product_id=(select DISTINCT  product_id from PRODUCT where product_id=PRICE.product_id)))) and (end_date>(select DISTINCT order_date from SALES_ORDER where order_id=(select DISTINCT order_id from ITEM where product_id=(select DISTINCT product_id from PRODUCT where product_id=PRICE.product_id))))  ))) from ITEM where order_id in (select order_id from SALES_ORDER where customer_id=(select customer_id from CUSTOMER where name='STADIUM SPORTS') and (order_date>= '19890101') and (order_date<'19900101'))";
            label1.Text = "Выбрать общую сумму скидок, предоставленных покупателю STADIUM SPORTS в 1989г";
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

        private void Requests36()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "select last_name as name1, first_name, (select last_name from EMPLOYEE as emp2 where employee_id=emp1.manager_id) from EMPLOYEE as emp1";
            label1.Text = "Выбрать список сотрудников фирмы с указанием фамилии непосредственного начальника каждого";
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
                        text += sqlReader[0].ToString() + "   " + sqlReader[1].ToString() + "             |        " + sqlReader[2].ToString();
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

        private void Requests37()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "select last_name, round(salary - (select avg(salary) from EMPLOYEE as emp2 where job_id=emp1.job_id),6), (select [function] from JOB where job_id=emp1.job_id) from EMPLOYEE as emp1 order by emp1.job_id desc";
            label1.Text = "Для каждого сотрудника вывести разность между его зарплатой и средней зарплатой сотрудников, выполняющих те же функции";
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

        private void Requests38()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "select (select description from PRODUCT where product_id=ITEM.product_id), quantity, (select ship_date from SALES_ORDER where order_id=ITEM.order_id) from ITEM INNER JOIN SALES_ORDER ON ITEM.order_id=SALES_ORDER.order_id where product_id=(select product_id from PRODUCT where description='DUNK BASKETBALL INDOOR') order by SALES_ORDER.order_id";
            label1.Text = "Вывести таблицу распределения объема продаж товара DUNK BASKETBALL INDOOR по годам";
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

        private void Requests39()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "select last_name, first_name, (salary+commission) from EMPLOYEE where (salary+commission>=2000)";
            label1.Text = " Выбрать фамилии тех сотрудников, у которых суммарный доход (зарплата + комиссионные) больше 2000";
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

        private void Requests40()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "select DISTINCT (select description from PRODUCT where product_id=ITEM.product_id) from ITEM where (select list_price from PRICE where product_id=(select product_id from PRODUCT where product_id=ITEM.product_id) and start_date=(select min(start_date) from PRICE as p2 where p2.product_id=PRICE.product_id and start_date<='19891115') )/100*115>= (select list_price from PRICE where product_id=(select product_id from PRODUCT where product_id=ITEM.product_id) and end_date=(select max(end_date) from PRICE as p3 where p3.product_id=PRICE.product_id) )";
            label1.Text = "Выбрать названия товаров, для которых нынешняя цена увеличилась по сравнению с ценой на 15 декабря 1989г. более, чем на 15%";
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

        private void Requests41()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = " select employee_id, first_name, last_name, salary, (select avg(salary) from EMPLOYEE as emp2 where emp2.job_id=EMPLOYEE.job_id)  from EMPLOYEE where salary > (select avg(salary) from EMPLOYEE as emp2 where emp2.job_id=EMPLOYEE.job_id) order by employee_id";
            label1.Text = " Выбрать имена и коды отдела для сотрудников, у которых зарплата выше средней по отделу (без учета комиссионных).";
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
                        text += sqlReader[0].ToString() + "   " + sqlReader[1].ToString() + "   " + sqlReader[2].ToString() + "        avf(job)=" + sqlReader[3].ToString();
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

        private void Requests42()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = " select top 10 first_name, last_name, salary from EMPLOYEE order by salary desc";
            label1.Text = "Выбрать имена и зарплаты 10 самых высокооплачиваемых сотрудников фирмы (без учета комиссионных).";
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

        private void Requests43()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "SELECT avg(salary), (datediff(mm, [hire_date], getdate())) FROM [EMPLOYEE] group by (datediff(mm, [hire_date], getdate()))";
            label1.Text = " Выбрать данные для построения графика зависимости средней зарплаты рядового служащего от срока работы в фирме (с точностью до месяца).";
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
                        text += sqlReader[0].ToString() + "   " + sqlReader[1].ToString();
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

        private void Requests44()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "";
            label1.Text = "Выбрать продукты в порядке увеличения их прибыльности. Прибыль определяется как относительная разность между реальной ценой продаже и минимальной ценой.";
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
                        text += sqlReader[0].ToString() + "   " + sqlReader[1].ToString();
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

        private void Requests47()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "select last_name, first_name from EMPLOYEE as e1 where employee_id=(select manager_id from EMPLOYEE as e2 where last_name='ADAMS') or employee_id=(select manager_id from EMPLOYEE as e4 where employee_id=(select manager_id from EMPLOYEE as e3 where last_name='ADAMS')) or employee_id=(select manager_id from EMPLOYEE as e5 where employee_id=(select manager_id from EMPLOYEE as e4 where employee_id=(select manager_id from EMPLOYEE as e3 where last_name='ADAMS')))";
            label1.Text = "Выбрать среднюю зарплату всех подчиненных JONES.";
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
                        text += sqlReader[0].ToString() + "    " + sqlReader[1].ToString();
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


        private void Requests49()
        {
            string text = "";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slava\source\repos\KingCorporation\KingCorporation\KingCorporation.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = "select avg(salary) from EMPLOYEE as e1 where manager_id=(select employee_id from EMPLOYEE as e2 where last_name='JONES')";
            label1.Text = "Выбрать среднюю зарплату всех подчиненных JONES.";
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







    }
}