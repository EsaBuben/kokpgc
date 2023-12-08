namespace TestIt
{
    partial class Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Taulukko = new System.Windows.Forms.DataGridView();
            this.addBox = new System.Windows.Forms.GroupBox();
            this.updtAddBox = new System.Windows.Forms.Button();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityFeed = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.text_label1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.whenFeed = new System.Windows.Forms.TextBox();
            this.givenFeed = new System.Windows.Forms.TextBox();
            this.When = new System.Windows.Forms.Label();
            this.Given = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Then = new System.Windows.Forms.Label();
            this.thenFeed = new System.Windows.Forms.TextBox();
            this.userStory = new System.Windows.Forms.GroupBox();
            this.removeUsrStryButton = new System.Windows.Forms.Button();
            this.updateUserstory = new System.Windows.Forms.Button();
            this.funcIdFeed = new System.Windows.Forms.TextBox();
            this.funcIdText = new System.Windows.Forms.Label();
            this.userStoryButton = new System.Windows.Forms.Button();
            this.otsikko = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rooliLabel = new System.Windows.Forms.Label();
            this.projectIdFeed = new System.Windows.Forms.TextBox();
            this.rooliFeed = new System.Windows.Forms.TextBox();
            this.userNameFeed = new System.Windows.Forms.TextBox();
            this.chooseUserBox = new System.Windows.Forms.GroupBox();
            this.userButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.userDropDown = new System.Windows.Forms.ComboBox();
            this.projectUserBox = new System.Windows.Forms.GroupBox();
            this.testIdFeed = new System.Windows.Forms.TextBox();
            this.testIDLabel = new System.Windows.Forms.Label();
            this.addToTest = new System.Windows.Forms.Button();
            this.projectUserLabel = new System.Windows.Forms.Label();
            this.projectUserDropDown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Taulukko)).BeginInit();
            this.addBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.userStory.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.chooseUserBox.SuspendLayout();
            this.projectUserBox.SuspendLayout();
            this.SuspendLayout();
            //
            // button1
            //
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(32, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sometimes you want to go back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // Taulukko
            //
            this.Taulukko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Taulukko.Cursor = System.Windows.Forms.Cursors.Default;
            this.Taulukko.Location = new System.Drawing.Point(244, 98);
            this.Taulukko.Margin = new System.Windows.Forms.Padding(2);
            this.Taulukko.Name = "Taulukko";
            this.Taulukko.RowHeadersWidth = 62;
            this.Taulukko.RowTemplate.Height = 28;
            this.Taulukko.Size = new System.Drawing.Size(895, 190);
            this.Taulukko.TabIndex = 1;
            this.Taulukko.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            //
            // addBox
            //
            this.addBox.Controls.Add(this.label3);
            this.addBox.Controls.Add(this.textBox2);
            this.addBox.Controls.Add(this.updtAddBox);
            this.addBox.Controls.Add(this.priorityLabel);
            this.addBox.Controls.Add(this.priorityFeed);
            this.addBox.Controls.Add(this.button2);
            this.addBox.Controls.Add(this.text_label1);
            this.addBox.Controls.Add(this.label1);
            this.addBox.Location = new System.Drawing.Point(32, 98);
            this.addBox.Margin = new System.Windows.Forms.Padding(2);
            this.addBox.Name = "addBox";
            this.addBox.Padding = new System.Windows.Forms.Padding(2);
            this.addBox.Size = new System.Drawing.Size(207, 161);
            this.addBox.TabIndex = 2;
            this.addBox.TabStop = false;
            this.addBox.Text = "Add Project";
            //
            // updtAddBox
            //
            this.updtAddBox.Location = new System.Drawing.Point(115, 133);
            this.updtAddBox.Margin = new System.Windows.Forms.Padding(2);
            this.updtAddBox.Name = "updtAddBox";
            this.updtAddBox.Size = new System.Drawing.Size(63, 24);
            this.updtAddBox.TabIndex = 9;
            this.updtAddBox.Text = "Update";
            this.updtAddBox.UseVisualStyleBackColor = true;
            this.updtAddBox.Click += new System.EventHandler(this.updtAddBox_Click);
            //
            // priorityLabel
            //
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(19, 54);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(38, 13);
            this.priorityLabel.TabIndex = 8;
            this.priorityLabel.Text = "Priority";
            this.priorityLabel.Visible = false;
            //
            // priorityFeed
            //
            this.priorityFeed.Location = new System.Drawing.Point(75, 54);
            this.priorityFeed.Name = "priorityFeed";
            this.priorityFeed.Size = new System.Drawing.Size(100, 20);
            this.priorityFeed.TabIndex = 7;
            this.priorityFeed.Visible = false;
            this.priorityFeed.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(22, 133);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // text_label1
            //
            this.text_label1.Location = new System.Drawing.Point(75, 23);
            this.text_label1.Margin = new System.Windows.Forms.Padding(2);
            this.text_label1.Name = "text_label1";
            this.text_label1.Size = new System.Drawing.Size(100, 20);
            this.text_label1.TabIndex = 3;
            this.text_label1.TextChanged += new System.EventHandler(this.text_label1_TextChanged);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nimi:";
            //
            // whenFeed
            //
            this.whenFeed.Location = new System.Drawing.Point(81, 84);
            this.whenFeed.Margin = new System.Windows.Forms.Padding(2);
            this.whenFeed.Name = "whenFeed";
            this.whenFeed.Size = new System.Drawing.Size(100, 20);
            this.whenFeed.TabIndex = 5;
            this.whenFeed.TextChanged += new System.EventHandler(this.text_label3_TextChanged);
            //
            // givenFeed
            //
            this.givenFeed.Location = new System.Drawing.Point(81, 53);
            this.givenFeed.Margin = new System.Windows.Forms.Padding(2);
            this.givenFeed.Name = "givenFeed";
            this.givenFeed.Size = new System.Drawing.Size(100, 20);
            this.givenFeed.TabIndex = 4;
            this.givenFeed.TextChanged += new System.EventHandler(this.text_label2_TextChanged);
            //
            // When
            //
            this.When.AutoSize = true;
            this.When.Location = new System.Drawing.Point(19, 84);
            this.When.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.When.Name = "When";
            this.When.Size = new System.Drawing.Size(36, 13);
            this.When.TabIndex = 2;
            this.When.Text = "When";
            //
            // Given
            //
            this.Given.AutoSize = true;
            this.Given.Location = new System.Drawing.Point(19, 53);
            this.Given.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Given.Name = "Given";
            this.Given.Size = new System.Drawing.Size(35, 13);
            this.Given.TabIndex = 1;
            this.Given.Text = "Given";
            this.Given.Click += new System.EventHandler(this.label2_Click);
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(32, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 84);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Project, Functonality";
            //
            // button3
            //
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(7, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "REMOVE (IRREVERSIBLE)";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // textBox1
            //
            this.textBox1.Location = new System.Drawing.Point(81, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID to remove";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            //
            // Then
            //
            this.Then.AutoSize = true;
            this.Then.Location = new System.Drawing.Point(19, 116);
            this.Then.Name = "Then";
            this.Then.Size = new System.Drawing.Size(32, 13);
            this.Then.TabIndex = 7;
            this.Then.Text = "Then";
            //
            // thenFeed
            //
            this.thenFeed.Location = new System.Drawing.Point(81, 116);
            this.thenFeed.Name = "thenFeed";
            this.thenFeed.Size = new System.Drawing.Size(100, 20);
            this.thenFeed.TabIndex = 8;
            //
            // userStory
            //
            this.userStory.Controls.Add(this.removeUsrStryButton);
            this.userStory.Controls.Add(this.updateUserstory);
            this.userStory.Controls.Add(this.funcIdFeed);
            this.userStory.Controls.Add(this.funcIdText);
            this.userStory.Controls.Add(this.userStoryButton);
            this.userStory.Controls.Add(this.givenFeed);
            this.userStory.Controls.Add(this.thenFeed);
            this.userStory.Controls.Add(this.When);
            this.userStory.Controls.Add(this.Given);
            this.userStory.Controls.Add(this.Then);
            this.userStory.Controls.Add(this.whenFeed);
            this.userStory.Location = new System.Drawing.Point(32, 354);
            this.userStory.Name = "userStory";
            this.userStory.Size = new System.Drawing.Size(207, 203);
            this.userStory.TabIndex = 9;
            this.userStory.TabStop = false;
            this.userStory.Text = "UserStory";
            this.userStory.Visible = false;
            this.userStory.Enter += new System.EventHandler(this.userStory_Enter);
            //
            // removeUsrStryButton
            //
            this.removeUsrStryButton.Location = new System.Drawing.Point(25, 174);
            this.removeUsrStryButton.Name = "removeUsrStryButton";
            this.removeUsrStryButton.Size = new System.Drawing.Size(92, 23);
            this.removeUsrStryButton.TabIndex = 13;
            this.removeUsrStryButton.Text = "Remove";
            this.removeUsrStryButton.UseVisualStyleBackColor = true;
            //
            // updateUserstory
            //
            this.updateUserstory.Location = new System.Drawing.Point(115, 145);
            this.updateUserstory.Name = "updateUserstory";
            this.updateUserstory.Size = new System.Drawing.Size(86, 23);
            this.updateUserstory.TabIndex = 12;
            this.updateUserstory.Text = "Update";
            this.updateUserstory.UseVisualStyleBackColor = true;
            //
            // funcIdFeed
            //
            this.funcIdFeed.Location = new System.Drawing.Point(109, 20);
            this.funcIdFeed.Name = "funcIdFeed";
            this.funcIdFeed.Size = new System.Drawing.Size(72, 20);
            this.funcIdFeed.TabIndex = 11;
            //
            // funcIdText
            //
            this.funcIdText.AutoSize = true;
            this.funcIdText.Location = new System.Drawing.Point(22, 20);
            this.funcIdText.Name = "funcIdText";
            this.funcIdText.Size = new System.Drawing.Size(80, 13);
            this.funcIdText.TabIndex = 10;
            this.funcIdText.Text = "Functionality ID";
            //
            // userStoryButton
            //
            this.userStoryButton.Location = new System.Drawing.Point(22, 145);
            this.userStoryButton.Name = "userStoryButton";
            this.userStoryButton.Size = new System.Drawing.Size(92, 23);
            this.userStoryButton.TabIndex = 9;
            this.userStoryButton.Text = "Add UserStory";
            this.userStoryButton.UseVisualStyleBackColor = true;
            this.userStoryButton.Click += new System.EventHandler(this.userStoryButton_Click);
            //
            // otsikko
            //
            this.otsikko.AutoSize = true;
            this.otsikko.Font = new System.Drawing.Font("Bradley Hand ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otsikko.Location = new System.Drawing.Point(238, 52);
            this.otsikko.Name = "otsikko";
            this.otsikko.Size = new System.Drawing.Size(95, 34);
            this.otsikko.TabIndex = 10;
            this.otsikko.Text = "Project";
            this.otsikko.Click += new System.EventHandler(this.label2_Click_1);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Käyttäjä:";
            //
            // addUserButton
            //
            this.addUserButton.Location = new System.Drawing.Point(12, 125);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 13;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.button4_Click);
            //
            // removeUserButton
            //
            this.removeUserButton.Location = new System.Drawing.Point(109, 125);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(92, 23);
            this.removeUserButton.TabIndex = 14;
            this.removeUserButton.Text = "Remove User";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.button5_Click);
            //
            // groupBox3
            //
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rooliLabel);
            this.groupBox3.Controls.Add(this.projectIdFeed);
            this.groupBox3.Controls.Add(this.rooliFeed);
            this.groupBox3.Controls.Add(this.userNameFeed);
            this.groupBox3.Controls.Add(this.removeUserButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.addUserButton);
            this.groupBox3.Location = new System.Drawing.Point(245, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 154);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lisää käyttäjä";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Project ID:";
            //
            // rooliLabel
            //
            this.rooliLabel.AutoSize = true;
            this.rooliLabel.Location = new System.Drawing.Point(9, 56);
            this.rooliLabel.Name = "rooliLabel";
            this.rooliLabel.Size = new System.Drawing.Size(34, 13);
            this.rooliLabel.TabIndex = 18;
            this.rooliLabel.Text = "Rooli:";
            this.rooliLabel.Click += new System.EventHandler(this.label3_Click);
            //
            // projectIdFeed
            //
            this.projectIdFeed.Location = new System.Drawing.Point(81, 82);
            this.projectIdFeed.Name = "projectIdFeed";
            this.projectIdFeed.Size = new System.Drawing.Size(100, 20);
            this.projectIdFeed.TabIndex = 17;
            //
            // rooliFeed
            //
            this.rooliFeed.Location = new System.Drawing.Point(81, 56);
            this.rooliFeed.Name = "rooliFeed";
            this.rooliFeed.Size = new System.Drawing.Size(100, 20);
            this.rooliFeed.TabIndex = 16;
            //
            // userNameFeed
            //
            this.userNameFeed.Location = new System.Drawing.Point(81, 30);
            this.userNameFeed.Name = "userNameFeed";
            this.userNameFeed.Size = new System.Drawing.Size(100, 20);
            this.userNameFeed.TabIndex = 15;
            //
            // chooseUserBox
            //
            this.chooseUserBox.Controls.Add(this.userButton);
            this.chooseUserBox.Controls.Add(this.userLabel);
            this.chooseUserBox.Controls.Add(this.userDropDown);
            this.chooseUserBox.Location = new System.Drawing.Point(942, 4);
            this.chooseUserBox.Name = "chooseUserBox";
            this.chooseUserBox.Size = new System.Drawing.Size(196, 89);
            this.chooseUserBox.TabIndex = 16;
            this.chooseUserBox.TabStop = false;
            this.chooseUserBox.Text = "Valitse käyttäjä";
            //
            // userButton
            //
            this.userButton.Location = new System.Drawing.Point(10, 49);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(75, 23);
            this.userButton.TabIndex = 2;
            this.userButton.Text = "Poista valittu käyttäjä";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.button5_Click);
            //
            // userLabel
            //
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(7, 20);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(48, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Käyttäjä:";
            //
            // userDropDown
            //
            this.userDropDown.FormattingEnabled = true;
            this.userDropDown.Location = new System.Drawing.Point(69, 17);
            this.userDropDown.Name = "userDropDown";
            this.userDropDown.Size = new System.Drawing.Size(121, 21);
            this.userDropDown.TabIndex = 0;
            this.userDropDown.Text = "- Choose user -";
            //
            // projectUserBox
            //
            this.projectUserBox.Controls.Add(this.testIdFeed);
            this.projectUserBox.Controls.Add(this.testIDLabel);
            this.projectUserBox.Controls.Add(this.addToTest);
            this.projectUserBox.Controls.Add(this.projectUserLabel);
            this.projectUserBox.Controls.Add(this.projectUserDropDown);
            this.projectUserBox.Location = new System.Drawing.Point(479, 327);
            this.projectUserBox.Name = "projectUserBox";
            this.projectUserBox.Size = new System.Drawing.Size(206, 143);
            this.projectUserBox.TabIndex = 17;
            this.projectUserBox.TabStop = false;
            this.projectUserBox.Text = "Vastuu henkilö";
            //
            // testIdFeed
            //
            this.testIdFeed.Location = new System.Drawing.Point(69, 49);
            this.testIdFeed.Margin = new System.Windows.Forms.Padding(2);
            this.testIdFeed.Name = "testIdFeed";
            this.testIdFeed.Size = new System.Drawing.Size(100, 20);
            this.testIdFeed.TabIndex = 5;
            //
            // testIDLabel
            //
            this.testIDLabel.AutoSize = true;
            this.testIDLabel.Location = new System.Drawing.Point(7, 49);
            this.testIDLabel.Name = "testIDLabel";
            this.testIDLabel.Size = new System.Drawing.Size(45, 13);
            this.testIDLabel.TabIndex = 3;
            this.testIDLabel.Text = "Test ID:";
            //
            // addToTest
            //
            this.addToTest.Location = new System.Drawing.Point(10, 102);
            this.addToTest.Name = "addToTest";
            this.addToTest.Size = new System.Drawing.Size(98, 23);
            this.addToTest.TabIndex = 2;
            this.addToTest.Text = "Add user to test";
            this.addToTest.UseVisualStyleBackColor = true;
            //
            // projectUserLabel
            //
            this.projectUserLabel.AutoSize = true;
            this.projectUserLabel.Location = new System.Drawing.Point(7, 20);
            this.projectUserLabel.Name = "projectUserLabel";
            this.projectUserLabel.Size = new System.Drawing.Size(48, 13);
            this.projectUserLabel.TabIndex = 1;
            this.projectUserLabel.Text = "Käyttäjä:";
            //
            // projectUserDropDown
            //
            this.projectUserDropDown.FormattingEnabled = true;
            this.projectUserDropDown.Location = new System.Drawing.Point(69, 17);
            this.projectUserDropDown.Name = "projectUserDropDown";
            this.projectUserDropDown.Size = new System.Drawing.Size(121, 21);
            this.projectUserDropDown.TabIndex = 0;
            this.projectUserDropDown.Text = "- Choose user -";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id to Update";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            //
            // textBox2
            //
            this.textBox2.Location = new System.Drawing.Point(91, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            //
            // Viewer
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1150, 749);
            this.Controls.Add(this.projectUserBox);
            this.Controls.Add(this.chooseUserBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.otsikko);
            this.Controls.Add(this.userStory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.Taulukko);
            this.Controls.Add(this.button1);
            this.Name = "Viewer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Taulukko)).EndInit();
            this.addBox.ResumeLayout(false);
            this.addBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.userStory.ResumeLayout(false);
            this.userStory.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.chooseUserBox.ResumeLayout(false);
            this.chooseUserBox.PerformLayout();
            this.projectUserBox.ResumeLayout(false);
            this.projectUserBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Taulukko;
        private System.Windows.Forms.GroupBox addBox;
        private System.Windows.Forms.TextBox whenFeed;
        private System.Windows.Forms.TextBox givenFeed;
        private System.Windows.Forms.TextBox text_label1;
        private System.Windows.Forms.Label When;
        private System.Windows.Forms.Label Given;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox thenFeed;
        private System.Windows.Forms.Label Then;
        private System.Windows.Forms.GroupBox userStory;
        private System.Windows.Forms.Button userStoryButton;
        private System.Windows.Forms.Label funcIdText;
        private System.Windows.Forms.TextBox funcIdFeed;
        private System.Windows.Forms.Label otsikko;
        private System.Windows.Forms.TextBox priorityFeed;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox userNameFeed;
        private System.Windows.Forms.Label rooliLabel;
        private System.Windows.Forms.TextBox projectIdFeed;
        private System.Windows.Forms.TextBox rooliFeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox chooseUserBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ComboBox userDropDown;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.GroupBox projectUserBox;
        private System.Windows.Forms.Button addToTest;
        private System.Windows.Forms.Label projectUserLabel;
        private System.Windows.Forms.ComboBox projectUserDropDown;
        private System.Windows.Forms.TextBox testIdFeed;
        private System.Windows.Forms.Label testIDLabel;
        private System.Windows.Forms.Button updateUserstory;
        private System.Windows.Forms.Button updtAddBox;
        private System.Windows.Forms.Button removeUsrStryButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}
