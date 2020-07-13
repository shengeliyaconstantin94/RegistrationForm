namespace Registration_on_course
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label student_nameLabel;
            System.Windows.Forms.Label student_lastnameLabel;
            System.Windows.Forms.Label student_birthdateLabel;
            System.Windows.Forms.Label student_averagegradeLabel;
            System.Windows.Forms.Label student_privilegesLabel;
            System.Windows.Forms.Label student_semesterpriseLabel;
            System.Windows.Forms.Label student_telephoneLabel;
            System.Windows.Forms.Label student_groupLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_profileDataSet = new Registration_on_course.Students_profileDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.student_nameTextBox = new System.Windows.Forms.TextBox();
            this.student_lastnameTextBox = new System.Windows.Forms.TextBox();
            this.student_birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.student_averagegradeTextBox = new System.Windows.Forms.TextBox();
            this.student_privilegesComboBox = new System.Windows.Forms.ComboBox();
            this.student_semesterpriseTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableTableAdapter = new Registration_on_course.Students_profileDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Registration_on_course.Students_profileDataSetTableAdapters.TableAdapterManager();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.students_profileDataSet1 = new Registration_on_course.Students_profileDataSet1();
            this.studBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studTableAdapter = new Registration_on_course.Students_profileDataSet1TableAdapters.StudTableAdapter();
            this.tableAdapterManager1 = new Registration_on_course.Students_profileDataSet1TableAdapters.TableAdapterManager();
            this.studDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_groupTextBox = new System.Windows.Forms.TextBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new Registration_on_course.Students_profileDataSet1TableAdapters.TeachersTableAdapter();
            this.teachersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            student_nameLabel = new System.Windows.Forms.Label();
            student_lastnameLabel = new System.Windows.Forms.Label();
            student_birthdateLabel = new System.Windows.Forms.Label();
            student_averagegradeLabel = new System.Windows.Forms.Label();
            student_privilegesLabel = new System.Windows.Forms.Label();
            student_semesterpriseLabel = new System.Windows.Forms.Label();
            student_telephoneLabel = new System.Windows.Forms.Label();
            student_groupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_profileDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_profileDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // student_nameLabel
            // 
            student_nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            student_nameLabel.AutoSize = true;
            student_nameLabel.Location = new System.Drawing.Point(167, 542);
            student_nameLabel.Name = "student_nameLabel";
            student_nameLabel.Size = new System.Drawing.Size(29, 13);
            student_nameLabel.TabIndex = 15;
            student_nameLabel.Text = "Имя";
            // 
            // student_lastnameLabel
            // 
            student_lastnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            student_lastnameLabel.AutoSize = true;
            student_lastnameLabel.Location = new System.Drawing.Point(167, 568);
            student_lastnameLabel.Name = "student_lastnameLabel";
            student_lastnameLabel.Size = new System.Drawing.Size(56, 13);
            student_lastnameLabel.TabIndex = 17;
            student_lastnameLabel.Text = "Фамилия";
            // 
            // student_birthdateLabel
            // 
            student_birthdateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            student_birthdateLabel.AutoSize = true;
            student_birthdateLabel.Location = new System.Drawing.Point(167, 595);
            student_birthdateLabel.Name = "student_birthdateLabel";
            student_birthdateLabel.Size = new System.Drawing.Size(86, 13);
            student_birthdateLabel.TabIndex = 19;
            student_birthdateLabel.Text = "Дата рождения";
            student_birthdateLabel.Click += new System.EventHandler(this.student_birthdateLabel_Click);
            // 
            // student_averagegradeLabel
            // 
            student_averagegradeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            student_averagegradeLabel.AutoSize = true;
            student_averagegradeLabel.Location = new System.Drawing.Point(167, 620);
            student_averagegradeLabel.Name = "student_averagegradeLabel";
            student_averagegradeLabel.Size = new System.Drawing.Size(89, 13);
            student_averagegradeLabel.TabIndex = 21;
            student_averagegradeLabel.Text = "Средняя оценка";
            // 
            // student_privilegesLabel
            // 
            student_privilegesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            student_privilegesLabel.AutoSize = true;
            student_privilegesLabel.Location = new System.Drawing.Point(167, 646);
            student_privilegesLabel.Name = "student_privilegesLabel";
            student_privilegesLabel.Size = new System.Drawing.Size(45, 13);
            student_privilegesLabel.TabIndex = 23;
            student_privilegesLabel.Text = "Льготы";
            student_privilegesLabel.Click += new System.EventHandler(this.student_privilegesLabel_Click);
            // 
            // student_semesterpriseLabel
            // 
            student_semesterpriseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            student_semesterpriseLabel.AutoSize = true;
            student_semesterpriseLabel.Location = new System.Drawing.Point(167, 673);
            student_semesterpriseLabel.Name = "student_semesterpriseLabel";
            student_semesterpriseLabel.Size = new System.Drawing.Size(94, 13);
            student_semesterpriseLabel.TabIndex = 25;
            student_semesterpriseLabel.Text = "Цена за семестр";
            // 
            // student_telephoneLabel
            // 
            student_telephoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            student_telephoneLabel.AutoSize = true;
            student_telephoneLabel.Location = new System.Drawing.Point(167, 699);
            student_telephoneLabel.Name = "student_telephoneLabel";
            student_telephoneLabel.Size = new System.Drawing.Size(52, 13);
            student_telephoneLabel.TabIndex = 27;
            student_telephoneLabel.Text = "Телефон";
            // 
            // student_groupLabel
            // 
            student_groupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            student_groupLabel.AutoSize = true;
            student_groupLabel.Location = new System.Drawing.Point(920, 572);
            student_groupLabel.Name = "student_groupLabel";
            student_groupLabel.Size = new System.Drawing.Size(42, 13);
            student_groupLabel.TabIndex = 33;
            student_groupLabel.Text = "Группа";
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(143, 221);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(286, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.students_profileDataSet;
            // 
            // students_profileDataSet
            // 
            this.students_profileDataSet.DataSetName = "Students_profileDataSet";
            this.students_profileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // student_nameTextBox
            // 
            this.student_nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.student_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "student_name", true));
            this.student_nameTextBox.Location = new System.Drawing.Point(287, 539);
            this.student_nameTextBox.Name = "student_nameTextBox";
            this.student_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_nameTextBox.TabIndex = 16;
            // 
            // student_lastnameTextBox
            // 
            this.student_lastnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.student_lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "student_lastname", true));
            this.student_lastnameTextBox.Location = new System.Drawing.Point(287, 565);
            this.student_lastnameTextBox.Name = "student_lastnameTextBox";
            this.student_lastnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_lastnameTextBox.TabIndex = 18;
            // 
            // student_birthdateDateTimePicker
            // 
            this.student_birthdateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.student_birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource, "student_birthdate", true));
            this.student_birthdateDateTimePicker.Location = new System.Drawing.Point(287, 591);
            this.student_birthdateDateTimePicker.Name = "student_birthdateDateTimePicker";
            this.student_birthdateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.student_birthdateDateTimePicker.TabIndex = 20;
            // 
            // student_averagegradeTextBox
            // 
            this.student_averagegradeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.student_averagegradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "student_averagegrade", true));
            this.student_averagegradeTextBox.Location = new System.Drawing.Point(287, 617);
            this.student_averagegradeTextBox.Name = "student_averagegradeTextBox";
            this.student_averagegradeTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_averagegradeTextBox.TabIndex = 22;
            // 
            // student_privilegesComboBox
            // 
            this.student_privilegesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.student_privilegesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "student_privileges", true));
            this.student_privilegesComboBox.FormattingEnabled = true;
            this.student_privilegesComboBox.Items.AddRange(new object[] {
            "Нет",
            "Первая группа",
            "Вторая группа"});
            this.student_privilegesComboBox.Location = new System.Drawing.Point(287, 643);
            this.student_privilegesComboBox.Name = "student_privilegesComboBox";
            this.student_privilegesComboBox.Size = new System.Drawing.Size(200, 21);
            this.student_privilegesComboBox.TabIndex = 24;
            this.student_privilegesComboBox.SelectedIndexChanged += new System.EventHandler(this.student_privilegesComboBox_SelectedIndexChanged);
            // 
            // student_semesterpriseTextBox
            // 
            this.student_semesterpriseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.student_semesterpriseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "student_semesterprise", true));
            this.student_semesterpriseTextBox.Enabled = false;
            this.student_semesterpriseTextBox.Location = new System.Drawing.Point(287, 670);
            this.student_semesterpriseTextBox.Name = "student_semesterpriseTextBox";
            this.student_semesterpriseTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_semesterpriseTextBox.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(247, 738);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Добавить студента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(587, 531);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(598, 722);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Добавить фото";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1061, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 32;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Registration_on_course.Students_profileDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(284, 692);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBox1.TabIndex = 33;
            // 
            // students_profileDataSet1
            // 
            this.students_profileDataSet1.DataSetName = "Students_profileDataSet1";
            this.students_profileDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studBindingSource
            // 
            this.studBindingSource.DataMember = "Stud";
            this.studBindingSource.DataSource = this.students_profileDataSet1;
            // 
            // studTableAdapter
            // 
            this.studTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.StudTableAdapter = this.studTableAdapter;
            this.tableAdapterManager1.TeachersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Registration_on_course.Students_profileDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studDataGridView
            // 
            this.studDataGridView.AutoGenerateColumns = false;
            this.studDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.studDataGridView.DataSource = this.studBindingSource;
            this.studDataGridView.Location = new System.Drawing.Point(12, 28);
            this.studDataGridView.Name = "studDataGridView";
            this.studDataGridView.Size = new System.Drawing.Size(1043, 220);
            this.studDataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "student_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "student_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "student_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "student_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "student_lastname";
            this.dataGridViewTextBoxColumn3.HeaderText = "student_lastname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "student_birthdate";
            this.dataGridViewTextBoxColumn4.HeaderText = "student_birthdate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "student_averagegrade";
            this.dataGridViewTextBoxColumn5.HeaderText = "student_averagegrade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "student_privileges";
            this.dataGridViewTextBoxColumn6.HeaderText = "student_privileges";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "student_semesterprise";
            this.dataGridViewTextBoxColumn7.HeaderText = "student_semesterprise";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "student_photo";
            this.dataGridViewImageColumn1.HeaderText = "student_photo";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "student_telephone";
            this.dataGridViewTextBoxColumn8.HeaderText = "student_telephone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "student_group";
            this.dataGridViewTextBoxColumn9.HeaderText = "student_group";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // student_groupTextBox
            // 
            this.student_groupTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.student_groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studBindingSource, "student_group", true));
            this.student_groupTextBox.Enabled = false;
            this.student_groupTextBox.Location = new System.Drawing.Point(923, 595);
            this.student_groupTextBox.Name = "student_groupTextBox";
            this.student_groupTextBox.Size = new System.Drawing.Size(100, 20);
            this.student_groupTextBox.TabIndex = 34;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.students_profileDataSet1;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // teachersDataGridView
            // 
            this.teachersDataGridView.AutoGenerateColumns = false;
            this.teachersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.teachersDataGridView.DataSource = this.teachersBindingSource;
            this.teachersDataGridView.Location = new System.Drawing.Point(12, 254);
            this.teachersDataGridView.Name = "teachersDataGridView";
            this.teachersDataGridView.Size = new System.Drawing.Size(451, 96);
            this.teachersDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "teacher_id";
            this.dataGridViewTextBoxColumn10.HeaderText = "teacher_id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "teacher_name";
            this.dataGridViewTextBoxColumn11.HeaderText = "teacher_name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "studyform";
            this.dataGridViewTextBoxColumn12.HeaderText = "studyform";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "gruop";
            this.dataGridViewTextBoxColumn13.HeaderText = "gruop";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(805, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Удалить запись";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1016, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 37;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(760, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Введите ID студента, которое хотите удалить";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(907, 487);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 39;
            this.textBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(759, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Для подтверждения удаления введите фамилию учащегося";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 785);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.teachersDataGridView);
            this.Controls.Add(student_groupLabel);
            this.Controls.Add(this.student_groupTextBox);
            this.Controls.Add(this.studDataGridView);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(student_nameLabel);
            this.Controls.Add(this.student_nameTextBox);
            this.Controls.Add(student_lastnameLabel);
            this.Controls.Add(this.student_lastnameTextBox);
            this.Controls.Add(student_birthdateLabel);
            this.Controls.Add(this.student_birthdateDateTimePicker);
            this.Controls.Add(student_averagegradeLabel);
            this.Controls.Add(this.student_averagegradeTextBox);
            this.Controls.Add(student_privilegesLabel);
            this.Controls.Add(this.student_privilegesComboBox);
            this.Controls.Add(student_semesterpriseLabel);
            this.Controls.Add(this.student_semesterpriseTextBox);
            this.Controls.Add(student_telephoneLabel);
            this.Controls.Add(this.tableBindingNavigator);
            this.Name = "Form1";
            this.Text = "Запись на гурсы графического дизайна";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_profileDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_profileDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Students_profileDataSet students_profileDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Students_profileDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Students_profileDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox student_nameTextBox;
        private System.Windows.Forms.TextBox student_lastnameTextBox;
        private System.Windows.Forms.DateTimePicker student_birthdateDateTimePicker;
        private System.Windows.Forms.TextBox student_averagegradeTextBox;
        private System.Windows.Forms.ComboBox student_privilegesComboBox;
        private System.Windows.Forms.TextBox student_semesterpriseTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private Students_profileDataSet1 students_profileDataSet1;
        private System.Windows.Forms.BindingSource studBindingSource;
        private Students_profileDataSet1TableAdapters.StudTableAdapter studTableAdapter;
        private Students_profileDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView studDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox student_groupTextBox;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private Students_profileDataSet1TableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridView teachersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}

