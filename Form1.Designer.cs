namespace RadioScanner.NET
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.freqDataTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tx_frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.call = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_ServicesSelector = new System.Windows.Forms.CheckedListBox();
            this.txt_DbQuery = new System.Windows.Forms.TextBox();
            this.chk_ModulationSelector = new System.Windows.Forms.CheckedListBox();
            this.chk_Location = new System.Windows.Forms.CheckedListBox();
            this.txt_FreqFrom = new System.Windows.Forms.TextBox();
            this.txt_FreqTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Frequency = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grp_Modulation = new System.Windows.Forms.GroupBox();
            this.grp_Signal = new System.Windows.Forms.GroupBox();
            this.grp_Service = new System.Windows.Forms.GroupBox();
            this.grp_SqlQuery = new System.Windows.Forms.GroupBox();
            this.btn_doQuery = new System.Windows.Forms.Button();
            this.grp_Pager = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_PageNumber = new System.Windows.Forms.TextBox();
            this.btn_LastPage = new System.Windows.Forms.Button();
            this.btn_NextPage = new System.Windows.Forms.Button();
            this.btn_PrevPage = new System.Windows.Forms.Button();
            this.btn_FirstPage = new System.Windows.Forms.Button();
            this.pan_Details = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.label_Confirmations = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.RichTextBox();
            this.label_Owner = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_Call = new System.Windows.Forms.Label();
            this.label_RadioService = new System.Windows.Forms.Label();
            this.label_Signal = new System.Windows.Forms.Label();
            this.label_Modulation = new System.Windows.Forms.Label();
            this.label_DateLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_RX = new System.Windows.Forms.Label();
            this.label_TX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.freqDataTable)).BeginInit();
            this.panel_Frequency.SuspendLayout();
            this.grp_Modulation.SuspendLayout();
            this.grp_Signal.SuspendLayout();
            this.grp_Service.SuspendLayout();
            this.grp_SqlQuery.SuspendLayout();
            this.grp_Pager.SuspendLayout();
            this.pan_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // freqDataTable
            // 
            this.freqDataTable.AllowUserToAddRows = false;
            this.freqDataTable.AllowUserToDeleteRows = false;
            this.freqDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.freqDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.freqDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.freqDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tx_frequency,
            this.location,
            this.modulation,
            this.signal,
            this.service,
            this.owner,
            this.call});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.freqDataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.freqDataTable.Location = new System.Drawing.Point(12, 261);
            this.freqDataTable.MultiSelect = false;
            this.freqDataTable.Name = "freqDataTable";
            this.freqDataTable.ReadOnly = true;
            this.freqDataTable.RowHeadersVisible = false;
            this.freqDataTable.RowHeadersWidth = 5;
            this.freqDataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.freqDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.freqDataTable.Size = new System.Drawing.Size(760, 281);
            this.freqDataTable.TabIndex = 0;
            this.freqDataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.freqDataTable_CellClick);
            this.freqDataTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.freqDataTable_ColumnHeaderMouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // tx_frequency
            // 
            this.tx_frequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tx_frequency.DataPropertyName = "tx_frequency";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.tx_frequency.DefaultCellStyle = dataGridViewCellStyle2;
            this.tx_frequency.FillWeight = 90F;
            this.tx_frequency.HeaderText = "Частота";
            this.tx_frequency.Name = "tx_frequency";
            this.tx_frequency.ReadOnly = true;
            this.tx_frequency.Width = 106;
            // 
            // location
            // 
            this.location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "Местоположение";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.Width = 180;
            // 
            // modulation
            // 
            this.modulation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.modulation.DataPropertyName = "modulation";
            this.modulation.HeaderText = "Модуляция";
            this.modulation.Name = "modulation";
            this.modulation.ReadOnly = true;
            this.modulation.Width = 129;
            // 
            // signal
            // 
            this.signal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.signal.DataPropertyName = "signal";
            this.signal.HeaderText = "Сигнал";
            this.signal.Name = "signal";
            this.signal.ReadOnly = true;
            this.signal.Width = 95;
            // 
            // service
            // 
            this.service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.service.DataPropertyName = "radio_service";
            this.service.HeaderText = "Служба";
            this.service.Name = "service";
            this.service.ReadOnly = true;
            this.service.Width = 97;
            // 
            // owner
            // 
            this.owner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.owner.DataPropertyName = "owner";
            this.owner.HeaderText = "Принадлежность";
            this.owner.Name = "owner";
            this.owner.ReadOnly = true;
            this.owner.Width = 181;
            // 
            // call
            // 
            this.call.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.call.DataPropertyName = "call";
            this.call.HeaderText = "Позывной";
            this.call.Name = "call";
            this.call.ReadOnly = true;
            this.call.Width = 118;
            // 
            // chk_ServicesSelector
            // 
            this.chk_ServicesSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_ServicesSelector.FormattingEnabled = true;
            this.chk_ServicesSelector.Location = new System.Drawing.Point(5, 18);
            this.chk_ServicesSelector.Name = "chk_ServicesSelector";
            this.chk_ServicesSelector.Size = new System.Drawing.Size(243, 109);
            this.chk_ServicesSelector.TabIndex = 2;
            // 
            // txt_DbQuery
            // 
            this.txt_DbQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_DbQuery.Location = new System.Drawing.Point(12, 22);
            this.txt_DbQuery.Name = "txt_DbQuery";
            this.txt_DbQuery.Size = new System.Drawing.Size(419, 26);
            this.txt_DbQuery.TabIndex = 1;
            // 
            // chk_ModulationSelector
            // 
            this.chk_ModulationSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_ModulationSelector.FormattingEnabled = true;
            this.chk_ModulationSelector.Location = new System.Drawing.Point(5, 18);
            this.chk_ModulationSelector.Name = "chk_ModulationSelector";
            this.chk_ModulationSelector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_ModulationSelector.Size = new System.Drawing.Size(243, 109);
            this.chk_ModulationSelector.TabIndex = 3;
            // 
            // chk_Location
            // 
            this.chk_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_Location.FormattingEnabled = true;
            this.chk_Location.Location = new System.Drawing.Point(5, 18);
            this.chk_Location.Name = "chk_Location";
            this.chk_Location.Size = new System.Drawing.Size(243, 109);
            this.chk_Location.TabIndex = 4;
            // 
            // txt_FreqFrom
            // 
            this.txt_FreqFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_FreqFrom.Location = new System.Drawing.Point(38, 15);
            this.txt_FreqFrom.Name = "txt_FreqFrom";
            this.txt_FreqFrom.Size = new System.Drawing.Size(80, 34);
            this.txt_FreqFrom.TabIndex = 7;
            this.txt_FreqFrom.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // txt_FreqTo
            // 
            this.txt_FreqTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_FreqTo.Location = new System.Drawing.Point(147, 16);
            this.txt_FreqTo.Name = "txt_FreqTo";
            this.txt_FreqTo.Size = new System.Drawing.Size(80, 34);
            this.txt_FreqTo.TabIndex = 8;
            this.txt_FreqTo.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(120, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "до:";
            // 
            // panel_Frequency
            // 
            this.panel_Frequency.Controls.Add(this.label7);
            this.panel_Frequency.Controls.Add(this.label6);
            this.panel_Frequency.Controls.Add(this.button14);
            this.panel_Frequency.Controls.Add(this.button10);
            this.panel_Frequency.Controls.Add(this.button11);
            this.panel_Frequency.Controls.Add(this.button12);
            this.panel_Frequency.Controls.Add(this.button6);
            this.panel_Frequency.Controls.Add(this.button7);
            this.panel_Frequency.Controls.Add(this.button8);
            this.panel_Frequency.Controls.Add(this.button9);
            this.panel_Frequency.Controls.Add(this.button5);
            this.panel_Frequency.Controls.Add(this.button4);
            this.panel_Frequency.Controls.Add(this.button3);
            this.panel_Frequency.Controls.Add(this.button2);
            this.panel_Frequency.Controls.Add(this.label1);
            this.panel_Frequency.Controls.Add(this.txt_FreqFrom);
            this.panel_Frequency.Controls.Add(this.txt_FreqTo);
            this.panel_Frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_Frequency.Location = new System.Drawing.Point(12, 12);
            this.panel_Frequency.Name = "panel_Frequency";
            this.panel_Frequency.Size = new System.Drawing.Size(760, 58);
            this.panel_Frequency.TabIndex = 2;
            this.panel_Frequency.TabStop = false;
            this.panel_Frequency.Text = "Частота";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(229, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "МГц";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "От:";
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(264, 15);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 35);
            this.button14.TabIndex = 27;
            this.button14.Text = "X";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(714, 15);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 35);
            this.button10.TabIndex = 23;
            this.button10.Text = ",";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(673, 15);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 35);
            this.button11.TabIndex = 22;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(632, 15);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 35);
            this.button12.TabIndex = 21;
            this.button12.Text = "8";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(593, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 20;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(552, 15);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 19;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(511, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 35);
            this.button8.TabIndex = 18;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(470, 15);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 35);
            this.button9.TabIndex = 17;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(428, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 14;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(387, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(346, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(305, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grp_Modulation
            // 
            this.grp_Modulation.Controls.Add(this.chk_ModulationSelector);
            this.grp_Modulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grp_Modulation.Location = new System.Drawing.Point(12, 70);
            this.grp_Modulation.Name = "grp_Modulation";
            this.grp_Modulation.Size = new System.Drawing.Size(253, 133);
            this.grp_Modulation.TabIndex = 7;
            this.grp_Modulation.TabStop = false;
            this.grp_Modulation.Text = "Модуляция";
            // 
            // grp_Signal
            // 
            this.grp_Signal.Controls.Add(this.chk_Location);
            this.grp_Signal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grp_Signal.Location = new System.Drawing.Point(266, 70);
            this.grp_Signal.Name = "grp_Signal";
            this.grp_Signal.Size = new System.Drawing.Size(253, 133);
            this.grp_Signal.TabIndex = 8;
            this.grp_Signal.TabStop = false;
            this.grp_Signal.Text = "Регион";
            // 
            // grp_Service
            // 
            this.grp_Service.Controls.Add(this.chk_ServicesSelector);
            this.grp_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grp_Service.Location = new System.Drawing.Point(520, 70);
            this.grp_Service.Name = "grp_Service";
            this.grp_Service.Size = new System.Drawing.Size(253, 133);
            this.grp_Service.TabIndex = 9;
            this.grp_Service.TabStop = false;
            this.grp_Service.Text = "Служба радиосвязи";
            // 
            // grp_SqlQuery
            // 
            this.grp_SqlQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_SqlQuery.Controls.Add(this.btn_doQuery);
            this.grp_SqlQuery.Controls.Add(this.txt_DbQuery);
            this.grp_SqlQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grp_SqlQuery.Location = new System.Drawing.Point(12, 203);
            this.grp_SqlQuery.Name = "grp_SqlQuery";
            this.grp_SqlQuery.Size = new System.Drawing.Size(507, 56);
            this.grp_SqlQuery.TabIndex = 10;
            this.grp_SqlQuery.TabStop = false;
            this.grp_SqlQuery.Text = "Запрос";
            // 
            // btn_doQuery
            // 
            this.btn_doQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_doQuery.Location = new System.Drawing.Point(433, 17);
            this.btn_doQuery.Name = "btn_doQuery";
            this.btn_doQuery.Size = new System.Drawing.Size(70, 35);
            this.btn_doQuery.TabIndex = 16;
            this.btn_doQuery.Text = "Запрос";
            this.btn_doQuery.UseVisualStyleBackColor = true;
            this.btn_doQuery.Click += new System.EventHandler(this.btn_doQuery_Click);
            // 
            // grp_Pager
            // 
            this.grp_Pager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Pager.Controls.Add(this.button1);
            this.grp_Pager.Controls.Add(this.txt_PageNumber);
            this.grp_Pager.Controls.Add(this.btn_LastPage);
            this.grp_Pager.Controls.Add(this.btn_NextPage);
            this.grp_Pager.Controls.Add(this.btn_PrevPage);
            this.grp_Pager.Controls.Add(this.btn_FirstPage);
            this.grp_Pager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grp_Pager.Location = new System.Drawing.Point(520, 203);
            this.grp_Pager.Name = "grp_Pager";
            this.grp_Pager.Size = new System.Drawing.Size(251, 56);
            this.grp_Pager.TabIndex = 17;
            this.grp_Pager.TabStop = false;
            this.grp_Pager.Text = "Страница";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(212, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 34;
            this.button1.Tag = "Последняя";
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_PageNumber
            // 
            this.txt_PageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_PageNumber.Location = new System.Drawing.Point(145, 18);
            this.txt_PageNumber.Name = "txt_PageNumber";
            this.txt_PageNumber.Size = new System.Drawing.Size(66, 34);
            this.txt_PageNumber.TabIndex = 33;
            this.txt_PageNumber.Leave += new System.EventHandler(this.txt_PageNumber_Leave);
            // 
            // btn_LastPage
            // 
            this.btn_LastPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LastPage.Location = new System.Drawing.Point(109, 17);
            this.btn_LastPage.Name = "btn_LastPage";
            this.btn_LastPage.Size = new System.Drawing.Size(35, 35);
            this.btn_LastPage.TabIndex = 15;
            this.btn_LastPage.Tag = "Последняя";
            this.btn_LastPage.Text = ">>";
            this.btn_LastPage.UseVisualStyleBackColor = true;
            this.btn_LastPage.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_NextPage
            // 
            this.btn_NextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_NextPage.Location = new System.Drawing.Point(74, 17);
            this.btn_NextPage.Name = "btn_NextPage";
            this.btn_NextPage.Size = new System.Drawing.Size(35, 35);
            this.btn_NextPage.TabIndex = 14;
            this.btn_NextPage.Text = ">";
            this.btn_NextPage.UseVisualStyleBackColor = true;
            this.btn_NextPage.Click += new System.EventHandler(this.button21_Click);
            // 
            // btn_PrevPage
            // 
            this.btn_PrevPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_PrevPage.Location = new System.Drawing.Point(39, 17);
            this.btn_PrevPage.Name = "btn_PrevPage";
            this.btn_PrevPage.Size = new System.Drawing.Size(35, 35);
            this.btn_PrevPage.TabIndex = 13;
            this.btn_PrevPage.Text = "<";
            this.btn_PrevPage.UseVisualStyleBackColor = true;
            this.btn_PrevPage.Click += new System.EventHandler(this.button22_Click);
            // 
            // btn_FirstPage
            // 
            this.btn_FirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_FirstPage.Location = new System.Drawing.Point(4, 17);
            this.btn_FirstPage.Name = "btn_FirstPage";
            this.btn_FirstPage.Size = new System.Drawing.Size(35, 35);
            this.btn_FirstPage.TabIndex = 12;
            this.btn_FirstPage.Text = "<<";
            this.btn_FirstPage.UseVisualStyleBackColor = true;
            this.btn_FirstPage.Click += new System.EventHandler(this.button23_Click);
            // 
            // pan_Details
            // 
            this.pan_Details.BackColor = System.Drawing.SystemColors.Control;
            this.pan_Details.Controls.Add(this.button13);
            this.pan_Details.Controls.Add(this.label_Confirmations);
            this.pan_Details.Controls.Add(this.label_Description);
            this.pan_Details.Controls.Add(this.label_Owner);
            this.pan_Details.Controls.Add(this.label8);
            this.pan_Details.Controls.Add(this.label5);
            this.pan_Details.Controls.Add(this.label13);
            this.pan_Details.Controls.Add(this.label12);
            this.pan_Details.Controls.Add(this.label11);
            this.pan_Details.Controls.Add(this.label9);
            this.pan_Details.Controls.Add(this.label_Call);
            this.pan_Details.Controls.Add(this.label_RadioService);
            this.pan_Details.Controls.Add(this.label_Signal);
            this.pan_Details.Controls.Add(this.label_Modulation);
            this.pan_Details.Controls.Add(this.label_DateLocation);
            this.pan_Details.Controls.Add(this.label4);
            this.pan_Details.Controls.Add(this.label_RX);
            this.pan_Details.Controls.Add(this.label_TX);
            this.pan_Details.Controls.Add(this.label2);
            this.pan_Details.Location = new System.Drawing.Point(1, 421);
            this.pan_Details.Name = "pan_Details";
            this.pan_Details.Size = new System.Drawing.Size(785, 548);
            this.pan_Details.TabIndex = 18;
            this.pan_Details.Visible = false;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(603, 483);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(162, 55);
            this.button13.TabIndex = 6;
            this.button13.Text = "Закрыть";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label_Confirmations
            // 
            this.label_Confirmations.AutoSize = true;
            this.label_Confirmations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Confirmations.ForeColor = System.Drawing.Color.Green;
            this.label_Confirmations.Location = new System.Drawing.Point(18, 496);
            this.label_Confirmations.Name = "label_Confirmations";
            this.label_Confirmations.Size = new System.Drawing.Size(295, 24);
            this.label_Confirmations.TabIndex = 5;
            this.label_Confirmations.Text = "Приём подтверждён 120 раз";
            // 
            // label_Description
            // 
            this.label_Description.BackColor = System.Drawing.SystemColors.Control;
            this.label_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Description.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_Description.DetectUrls = false;
            this.label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Description.ForeColor = System.Drawing.Color.Green;
            this.label_Description.Location = new System.Drawing.Point(19, 318);
            this.label_Description.Name = "label_Description";
            this.label_Description.ReadOnly = true;
            this.label_Description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.label_Description.Size = new System.Drawing.Size(746, 154);
            this.label_Description.TabIndex = 4;
            this.label_Description.Text = resources.GetString("label_Description.Text");
            // 
            // label_Owner
            // 
            this.label_Owner.AutoSize = true;
            this.label_Owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Owner.ForeColor = System.Drawing.Color.Green;
            this.label_Owner.Location = new System.Drawing.Point(15, 13);
            this.label_Owner.MaximumSize = new System.Drawing.Size(750, 0);
            this.label_Owner.MinimumSize = new System.Drawing.Size(750, 0);
            this.label_Owner.Name = "label_Owner";
            this.label_Owner.Size = new System.Drawing.Size(750, 24);
            this.label_Owner.TabIndex = 3;
            this.label_Owner.Text = "железная дорога московский вокзал служба формирования и отправки составов";
            this.label_Owner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(17, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(422, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Описание и комментарии принимавшего:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(15, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Позывной:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(15, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 24);
            this.label13.TabIndex = 3;
            this.label13.Text = "Служба радиосвязи:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(15, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Тип сигнала:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(15, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Модуляция:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(15, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(305, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Дата и место наблюдения:";
            // 
            // label_Call
            // 
            this.label_Call.AutoSize = true;
            this.label_Call.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Call.ForeColor = System.Drawing.Color.Green;
            this.label_Call.Location = new System.Drawing.Point(140, 228);
            this.label_Call.MaximumSize = new System.Drawing.Size(650, 200);
            this.label_Call.Name = "label_Call";
            this.label_Call.Size = new System.Drawing.Size(619, 40);
            this.label_Call.TabIndex = 3;
            this.label_Call.Text = "Рапира, 90, Инженер,Ястреб, Нева, Арго, Вега, Плутон, Спутник, Урал, 40, Скит, Ок" +
    "о, Марс, Лидер и др";
            // 
            // label_RadioService
            // 
            this.label_RadioService.AutoSize = true;
            this.label_RadioService.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_RadioService.ForeColor = System.Drawing.Color.Green;
            this.label_RadioService.Location = new System.Drawing.Point(237, 192);
            this.label_RadioService.Name = "label_RadioService";
            this.label_RadioService.Size = new System.Drawing.Size(423, 25);
            this.label_RadioService.TabIndex = 3;
            this.label_RadioService.Text = "Стандартных частот и сигналов времени";
            // 
            // label_Signal
            // 
            this.label_Signal.AutoSize = true;
            this.label_Signal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Signal.ForeColor = System.Drawing.Color.Green;
            this.label_Signal.Location = new System.Drawing.Point(182, 162);
            this.label_Signal.Name = "label_Signal";
            this.label_Signal.Size = new System.Drawing.Size(359, 25);
            this.label_Signal.TabIndex = 3;
            this.label_Signal.Text = "Тоновые посылки каждую секунду";
            // 
            // label_Modulation
            // 
            this.label_Modulation.AutoSize = true;
            this.label_Modulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Modulation.ForeColor = System.Drawing.Color.Green;
            this.label_Modulation.Location = new System.Drawing.Point(179, 131);
            this.label_Modulation.Name = "label_Modulation";
            this.label_Modulation.Size = new System.Drawing.Size(353, 25);
            this.label_Modulation.TabIndex = 3;
            this.label_Modulation.Text = "ВБП начала спект. радиовещания";
            // 
            // label_DateLocation
            // 
            this.label_DateLocation.AutoSize = true;
            this.label_DateLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DateLocation.ForeColor = System.Drawing.Color.Green;
            this.label_DateLocation.Location = new System.Drawing.Point(318, 100);
            this.label_DateLocation.Name = "label_DateLocation";
            this.label_DateLocation.Size = new System.Drawing.Size(456, 25);
            this.label_DateLocation.TabIndex = 3;
            this.label_DateLocation.Text = "10 марта 2010 Pittsburgh, Pennsylvania, USA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(422, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Приём:";
            // 
            // label_RX
            // 
            this.label_RX.AutoSize = true;
            this.label_RX.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_RX.ForeColor = System.Drawing.Color.Green;
            this.label_RX.Location = new System.Drawing.Point(528, 49);
            this.label_RX.Name = "label_RX";
            this.label_RX.Size = new System.Drawing.Size(191, 37);
            this.label_RX.TabIndex = 1;
            this.label_RX.Text = "2.3312 МГц";
            // 
            // label_TX
            // 
            this.label_TX.AutoSize = true;
            this.label_TX.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TX.ForeColor = System.Drawing.Color.Green;
            this.label_TX.Location = new System.Drawing.Point(187, 49);
            this.label_TX.Name = "label_TX";
            this.label_TX.Size = new System.Drawing.Size(191, 37);
            this.label_TX.TabIndex = 1;
            this.label_TX.Text = "2.3312 МГц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(42, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Передача:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 548);
            this.Controls.Add(this.pan_Details);
            this.Controls.Add(this.grp_Pager);
            this.Controls.Add(this.grp_SqlQuery);
            this.Controls.Add(this.grp_Service);
            this.Controls.Add(this.grp_Signal);
            this.Controls.Add(this.grp_Modulation);
            this.Controls.Add(this.panel_Frequency);
            this.Controls.Add(this.freqDataTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База радиочастот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.freqDataTable)).EndInit();
            this.panel_Frequency.ResumeLayout(false);
            this.panel_Frequency.PerformLayout();
            this.grp_Modulation.ResumeLayout(false);
            this.grp_Signal.ResumeLayout(false);
            this.grp_Service.ResumeLayout(false);
            this.grp_SqlQuery.ResumeLayout(false);
            this.grp_SqlQuery.PerformLayout();
            this.grp_Pager.ResumeLayout(false);
            this.grp_Pager.PerformLayout();
            this.pan_Details.ResumeLayout(false);
            this.pan_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView freqDataTable;
        private System.Windows.Forms.TextBox txt_DbQuery;
        private System.Windows.Forms.CheckedListBox chk_ServicesSelector;
        private System.Windows.Forms.CheckedListBox chk_ModulationSelector;
        private System.Windows.Forms.CheckedListBox chk_Location;
        private System.Windows.Forms.TextBox txt_FreqFrom;
        private System.Windows.Forms.TextBox txt_FreqTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox panel_Frequency;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grp_Modulation;
        private System.Windows.Forms.GroupBox grp_Signal;
        private System.Windows.Forms.GroupBox grp_Service;
        private System.Windows.Forms.GroupBox grp_SqlQuery;
        private System.Windows.Forms.Button btn_doQuery;
        private System.Windows.Forms.GroupBox grp_Pager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_PageNumber;
        private System.Windows.Forms.Button btn_LastPage;
        private System.Windows.Forms.Button btn_NextPage;
        private System.Windows.Forms.Button btn_PrevPage;
        private System.Windows.Forms.Button btn_FirstPage;
        private System.Windows.Forms.Panel pan_Details;
        private System.Windows.Forms.Label label_Owner;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_DateLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_RX;
        private System.Windows.Forms.Label label_TX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_RadioService;
        private System.Windows.Forms.Label label_Signal;
        private System.Windows.Forms.Label label_Modulation;
        private System.Windows.Forms.RichTextBox label_Description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Confirmations;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label_Call;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tx_frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulation;
        private System.Windows.Forms.DataGridViewTextBoxColumn signal;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn call;
    }
}

