using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestIt
{
    public partial class Viewer : Form
    {
        private Object juttu = new Object();
        int valitutPalat;
        BindingSource bindingSource = new BindingSource();
        DataObjectType curry = DataObjectType.Project;


        public Viewer()
        {
            InitializeComponent();
            bindingSource.DataSource = Controller.Listaa(curry);
            Taulukko.DataSource = bindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (curry > 0)
            curry--;
            bindingSource.DataSource = Controller.Listaa(curry);
            Taulukko.DataSource = bindingSource;
            if (curry == DataObjectType.Functionality)
            {
                userStory.Visible = true;
            }
            else userStory.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            curry++;
            valitutPalat = (int)Taulukko[1, e.RowIndex].Value;
            bindingSource.DataSource = Controller.Listaa(valitutPalat, curry);
            if (curry == DataObjectType.Functionality)
            {
                userStory.Visible = true;
            }
            else userStory.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (curry)
            {
                case DataObjectType.Project:
                    this.juttu = new Project(text_label1.Text);
                    Controller.AddNew(this.juttu, DataObjectType.Project);
                    MessageBox.Show("Project " + ((Project)this.juttu).ProjectName + " has been added");
                    text_label1.Text = "";
                    bindingSource.DataSource = Controller.Listaa(curry);
                    Taulukko.DataSource = bindingSource;
                    break;
                case DataObjectType.Functionality:
                    this.juttu = new Functionality(text_label1.Text, valitutPalat);
                    Controller.AddNew(this.juttu, DataObjectType.Functionality);
                    MessageBox.Show("Functionality " + ((Functionality)this.juttu).FunctionalityName + " has been added");
                    text_label1.Text = "";
                    bindingSource.DataSource = Controller.Listaa(valitutPalat, curry);
                    Taulukko.DataSource = bindingSource;
                    break;
                case DataObjectType.Test:

                    break;
                case DataObjectType.Result:
                    break;
                case DataObjectType.User:
                    break;
                default:
                    break;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Controller.RemoveItem(Convert.ToInt32(textBox1.Text), curry);
            bindingSource.DataSource = Controller.Listaa(curry);
            Taulukko.DataSource = bindingSource;
            textBox1.Text = "";
        }
        private void userStoryButton_Click(object sender, EventArgs e)
        {
            this.juttu = new UserStory(Convert.ToInt32(funcIdFeed.Text), givenFeed.Text, whenFeed.Text, thenFeed.Text);
            Controller.AddNew(this.juttu, DataObjectType.UserStory);
            bindingSource.DataSource = Controller.Listaa(valitutPalat, curry);
            Taulukko.DataSource = bindingSource;
            funcIdFeed.Text = "";
            givenFeed.Text = "";
            whenFeed.Text = "";
            thenFeed.Text = "";
            
        }
        private void Viewer_Load(object sender, EventArgs e)
        {

        }

        private void text_label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_label2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_label3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userStory_Enter(object sender, EventArgs e)
        {

        }
    }
}
