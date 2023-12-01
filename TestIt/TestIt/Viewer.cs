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
            curry--;
            bindingSource.DataSource = Controller.Listaa(curry);
            Taulukko.DataSource = bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            curry++;
            valitutPalat = (int)Taulukko[1, e.RowIndex].Value;
            bindingSource.DataSource = Controller.Listaa(valitutPalat, curry);
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
            //if (DataObjectType.Project == curry)
            //{
            //    Project proge = new Project(text_label1.Text);
            //    Controller.AddNew(proge, DataObjectType.Project);
            //    MessageBox.Show("Project " + proge.ProjectName + " has been added");
            //    text_label1.Text = "";
            //    bindingSource.DataSource = Controller.Listaa(DataObjectType.Project);
            //    Taulukko.DataSource = bindingSource;
            //} else if (DataObjectType.Functionality == curry)
            //{
            //    Functionality funky = new Functionality(text_label1.Text);
            //    Controller.AddNew(funky, DataObjectType.Functionality);
            //    MessageBox.Show("Functionality " + funky.FunctionalityName + " has been added");
            //    text_label1.Text = "";
            //} else if (DataObjectType.Test == curry)
            //{

            //}
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Controller.RemoveItem(Convert.ToInt32(textBox1.Text), DataObjectType.Project);
            bindingSource.DataSource = Controller.Listaa(DataObjectType.Project);
            Taulukko.DataSource = bindingSource;
            textBox1.Text = "";
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





        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (textBox1.Text == "" || textBox1.Text == " ")
        //    {
        //        MessageBox.Show("Please enter a project name.");
        //        return;
        //    }
        //    Project proge = Controller.Kutsu(textBox1.Text);
        //    listBox1.Items.Add(proge.ProjectID + ", " + proge.ProjectName);
        //    textBox1.Text = "";
        //    MessageBox.Show("Project " + proge.ProjectName + " has been added");

        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}


    }
}
