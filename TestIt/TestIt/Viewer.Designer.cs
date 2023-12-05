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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.funcIdFeed = new System.Windows.Forms.TextBox();
            this.funcIdText = new System.Windows.Forms.Label();
            this.userStoryButton = new System.Windows.Forms.Button();
            this.otsikko = new System.Windows.Forms.Label();
            this.priorityFeed = new System.Windows.Forms.TextBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Taulukko)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.userStory.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priorityLabel);
            this.groupBox1.Controls.Add(this.priorityFeed);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.text_label1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(207, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 123);
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
            this.groupBox2.Text = "Remove";
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
            this.userStory.Size = new System.Drawing.Size(207, 177);
            this.userStory.TabIndex = 9;
            this.userStory.TabStop = false;
            this.userStory.Text = "UserStory";
            this.userStory.Visible = false;
            this.userStory.Enter += new System.EventHandler(this.userStory_Enter);
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
            this.userStoryButton.Size = new System.Drawing.Size(106, 23);
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
            // priorityFeed
            // 
            this.priorityFeed.Location = new System.Drawing.Point(75, 61);
            this.priorityFeed.Name = "priorityFeed";
            this.priorityFeed.Size = new System.Drawing.Size(100, 20);
            this.priorityFeed.TabIndex = 7;
            this.priorityFeed.Visible = false;
            this.priorityFeed.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(22, 61);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(38, 13);
            this.priorityLabel.TabIndex = 8;
            this.priorityLabel.Text = "Priority";
            this.priorityLabel.Visible = false;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1150, 891);
            this.Controls.Add(this.otsikko);
            this.Controls.Add(this.userStory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Taulukko);
            this.Controls.Add(this.button1);
            this.Name = "Viewer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Taulukko)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.userStory.ResumeLayout(false);
            this.userStory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Taulukko;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}