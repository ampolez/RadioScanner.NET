using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioScanner.NET
{
    public partial class Form1 : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=frequency.db;Version=3;Read Only=True;");
        private Control _lastFocusedControl;
        private string mainSqlQuery = "SELECT id, tx_frequency, location, modulation, signal, radio_service, owner, call FROM freq ",
                       userSqlQuery = string.Empty;

        private int rowsPerPage = 100,
                    totalRows = 0,
                    totalPagesInQuery = 0,
                    currentPage = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\frequency.db"))
            {
                MessageBox.Show("Не найден файл frequency.db!", "Ошибка SQLite", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
            m_dbConnection.Open();           
            
            freqDataTable.Anchor =
                        AnchorStyles.Bottom |
                        AnchorStyles.Right |
                        AnchorStyles.Top |
                        AnchorStyles.Left;           
            panel_Frequency.Anchor = AnchorStyles.Top |
                        AnchorStyles.Right |
                        AnchorStyles.Top |
                        AnchorStyles.Left;
            pan_Details.Location = new Point(
                this.ClientSize.Width / 2 - pan_Details.Size.Width / 2,
                this.ClientSize.Height / 2 - pan_Details.Size.Height / 2);
            pan_Details.Anchor = AnchorStyles.None;

            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT 1  FROM freq", m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Файл frequency.db повреждён!", "Ошибка SQLite", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            PopulateCheckboxList(chk_ServicesSelector, "radio_service");
            PopulateCheckboxList(chk_Location, "location");
            PopulateCheckboxList(chk_ModulationSelector, "modulation");
            getDataTable();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_dbConnection.Close();
        }

        // Обработка запроса к БД, построение таблицы данных расчет количества страниц в таблице
        private void getDataTable(int pageNumber = -1)
        {
            DataTable resultQuery = new DataTable();

            string currentSqlQuery = mainSqlQuery;
            if (userSqlQuery != string.Empty)
                currentSqlQuery = userSqlQuery;

            btn_FirstPage.Enabled = btn_PrevPage.Enabled = true;
            btn_LastPage.Enabled = btn_NextPage.Enabled = true;

            if (pageNumber < 0)
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
                    cmd.CommandText = currentSqlQuery;
                    cmd.CommandType = CommandType.Text;
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.HasRows)
                    {
                        reader.Read();
                        totalRows = reader.StepCount;
                    }
                    pageNumber = 1;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\nЗапрос: " + currentSqlQuery, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("Файл БД frequency.db отсутствует или повреждён!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    m_dbConnection.Close();
                    Application.Exit();                    
                }
            }
            string limitQuery = " LIMIT " + (pageNumber - 1) * rowsPerPage + "," + rowsPerPage + ";";
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(currentSqlQuery + limitQuery, m_dbConnection);
                da.Fill(resultQuery);
                freqDataTable.DataSource = resultQuery;
                currentPage = pageNumber;
            }
            catch (Exception err)
            {
                if (pageNumber >= 0)
                {
                    MessageBox.Show(err.Message + "\nЗапрос: " + currentSqlQuery + limitQuery, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            totalPagesInQuery = totalRows / rowsPerPage;
            if (totalRows % rowsPerPage > 0)
            {
                totalPagesInQuery++;
            }

            txt_PageNumber.Text = pageNumber.ToString();
            grp_Pager.Text = "Страница " + pageNumber.ToString() + " из " + totalPagesInQuery.ToString();

            if (currentPage == 1)
            {
                btn_FirstPage.Enabled = btn_PrevPage.Enabled = false;
            }
            if (currentPage == totalPagesInQuery)
            {
                btn_LastPage.Enabled = btn_NextPage.Enabled = false;
            }

            colorDataTable();
        }

        // Получаем все поля из БД для конкретного значения частоты
        private void getItemFullData(int id)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM freq WHERE id='" + id + "' LIMIT 1;", m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    label_Modulation.Text = reader["modulation"].ToString();
                    label_DateLocation.Text = reader["date"].ToString() + " " + reader["location"].ToString();
                    label_Confirmations.Text = "Приём подтверждён " + reader["confirmations"].ToString() + " раз";
                    label_Description.Text = reader["description"].ToString();
                    label_RadioService.Text = reader["radio_service"].ToString();
                    label_TX.Text = reader["tx_frequency"].ToString() + " МГц";
                    if (reader["rx_frequency"].ToString().Length > 0 )
                    {
                        label_RX.Text = reader["rx_frequency"].ToString() + " МГц";
                    }
                    else
                    {
                        label_RX.Text = "Не установлен";
                    }
                    label_Signal.Text = reader["signal"].ToString();
                    label_Owner.Text = reader["owner"].ToString();
                    label_Call.Text = reader["call"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Показываем панель с подробностями
        private void button13_Click(object sender, EventArgs e)
        {
            pan_Details.Visible = false;
        }

        // Набивка чекбокс-списков (фильтр-селекторов) данными из базы
        private void PopulateCheckboxList(CheckedListBox ListToPopulate, string DbParameter)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT DISTINCT " + DbParameter + " FROM freq ORDER by " + DbParameter + " ASC", m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                int counter = 0;
                while (reader.Read())
                {
                    if (reader[DbParameter].ToString().Length > 0)
                    {
                        ListToPopulate.Items.Insert(counter, reader[DbParameter].ToString());
                        counter++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка БД2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Построение условия для запроса из значений указанного фильтра-селекторов
        private string GetSelectionQuery(CheckedListBox SelectorsList, string DbParameter)
        {
            string result = "";
            foreach (var item in SelectorsList.CheckedItems)
            {
                if (result.Length > 0)
                    result += "OR ";
                result += DbParameter + " = '" + item.ToString() + "' ";
            }
            if (result.Length > 0)
            {
                result = "(" + result + ")";
            }
            return result;
        }

        // Построение тела запроса из всех фильтров-селекторов
        private void makeSqlQuery(string customQuery = "")
        {
            if (customQuery != string.Empty)
            {
                userSqlQuery = customQuery;
            }
            else
            {
                string sub_MOD = GetSelectionQuery(chk_ModulationSelector, "modulation"),
                       sub_SIG = GetSelectionQuery(chk_ServicesSelector, "radio_service"),
                       sub_SRV = GetSelectionQuery(chk_Location, "location"),
                       selectorsQuery = string.Empty;

                if (txt_FreqFrom.Text.Length > 0)
                {
                    selectorsQuery += "tx_frequency >= '" + txt_FreqFrom.Text + "'";
                }
                if (txt_FreqTo.Text.Length > 0)
                {
                    if (selectorsQuery.Length > 0)
                    {
                        selectorsQuery += " AND ";
                    }
                    selectorsQuery += "tx_frequency <= '" + txt_FreqTo.Text + "'";
                }
                if (selectorsQuery.Length > 0)
                {
                    selectorsQuery = "(" + selectorsQuery + ")";
                }

                if (sub_MOD.Length > 0)
                {
                    if (selectorsQuery.Length > 0)
                    {
                        selectorsQuery += " AND ";
                    }
                    selectorsQuery += sub_MOD;
                }
                if (sub_SIG.Length > 0)
                {
                    if (selectorsQuery.Length > 0)
                    {
                        selectorsQuery += " AND ";
                    }
                    selectorsQuery += sub_SIG;
                }
                if (sub_SRV.Length > 0)
                {
                    if (selectorsQuery.Length > 0)
                    {
                        selectorsQuery += " AND ";
                    }
                    selectorsQuery += sub_SRV;
                }
                if (selectorsQuery.Length > 0)
                {
                    userSqlQuery = mainSqlQuery + " WHERE " + selectorsQuery;
                }
                else
                {
                    userSqlQuery = mainSqlQuery;
                }
            }
            getDataTable(-1);
        }

        // Перестановка элементов формы при изменении размеров окна
        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            int form_width = this.Width;
            int form_height = this.Height;
            int grp_width = form_width / 3 - 13;
            grp_Modulation.Width = grp_Service.Width = grp_Signal.Width = grp_width;
            grp_Signal.Left = grp_width + 13;
            grp_Service.Left = 2 * grp_width + 14;
            grp_SqlQuery.Width = form_width - grp_Pager.Width - 42;
            chk_ModulationSelector.Width = grp_Modulation.Width - 9;
            chk_Location.Width = grp_Signal.Width - 9;
            chk_ServicesSelector.Width = grp_Service.Width - 9;
            btn_doQuery.Left = form_width - grp_Pager.Width - btn_doQuery.Width - 45;
            txt_DbQuery.Width = btn_doQuery.Left - 15;
            pan_Details.Location = new Point(
                this.ClientSize.Width / 2 - pan_Details.Size.Width / 2,
                this.ClientSize.Height / 2 - pan_Details.Size.Height / 2);
            pan_Details.Anchor = AnchorStyles.None;
        }

        // Отправка пользовательского SQL-запроса 
        private void btn_doQuery_Click(object sender, EventArgs e)
        {
            makeSqlQuery(txt_DbQuery.Text);
        }

        // Функция раскраски таблицы с данными
        private void colorDataTable()
        {
            int row_counter = 0;
            Color row_color = Color.Azure;

            foreach (DataGridViewRow row in freqDataTable.Rows)
            {
                if (row_counter % 2 == 0)
                {
                    row_color = Color.LightGoldenrodYellow;
                }
                else
                {
                    row_color = Color.LightGreen;
                }
                row.DefaultCellStyle.BackColor = row_color;
                row_counter++;
            }

        }

        // Событие по клику на ячейку - получаем id выбранного ряда и отправляем запрос на полные данные по частоте
        private void freqDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // если клик не пришелся на заголовок столбца, то показываем панель с подробностями
            if (e.RowIndex != -1)
            {
                int selectedrowindex = freqDataTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = freqDataTable.Rows[selectedrowindex];
                getItemFullData(Convert.ToInt32(freqDataTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString()));
                pan_Details.Visible = true;
            }
        }

        // Обработка события сортировки встроенными средствами DataTable (раскрашивание таблицы)
        private void freqDataTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            colorDataTable();
        }


        #region Нажатия на кнопки управления значениями

        private void button2_Click(object sender, EventArgs e)
        {
            if (_lastFocusedControl != null)
            {
                _lastFocusedControl.Text += "0";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            _lastFocusedControl = (Control)sender;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_lastFocusedControl != null)
            {
                _lastFocusedControl.Text += "1";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_lastFocusedControl != null)
            {
                _lastFocusedControl.Text += "2";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_lastFocusedControl != null)
            {
                _lastFocusedControl.Text += "3";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_lastFocusedControl != null)
            {
                _lastFocusedControl.Text += "4";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_lastFocusedControl != null)
            {
                _lastFocusedControl.Text += "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_lastFocusedControl != null)
            {
                _lastFocusedControl.Text += "6";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_lastFocusedControl != null)
            {
                _lastFocusedControl.Text += "7";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (_lastFocusedControl != null)
            {
                _lastFocusedControl.Text += "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_lastFocusedControl != null)
            {
                _lastFocusedControl.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (_lastFocusedControl != null)
            {
                _lastFocusedControl.Text += ".";
            }
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            _lastFocusedControl.Text = "";
        }
        #endregion

        #region Выбор элементов для управления цифровыми кнопками

        private void textBox3_Leave(object sender, EventArgs e)
        {
            _lastFocusedControl = (Control)sender;
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            _lastFocusedControl = (Control)sender;
        }
        private void txt_PageNumber_Leave(object sender, EventArgs e)
        {
            _lastFocusedControl = (Control)sender;
        }
        #endregion

        #region Кнопки переключения страниц

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_PageNumber.Text == "")
            {
                txt_PageNumber.Text = currentPage.ToString();
            }
            getDataTable(Convert.ToInt32(txt_PageNumber.Text));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPagesInQuery)
            {
                currentPage++;
                getDataTable(currentPage);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                getDataTable(currentPage);
            } 
        }

        private void button20_Click(object sender, EventArgs e)
        {
            getDataTable(totalPagesInQuery);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            getDataTable(1);
        }
        #endregion

    }
}
