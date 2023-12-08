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
        int[] valitutPalat;
        BindingSource bindingSource = new BindingSource();
        DataObjectType curry = DataObjectType.Project;

        public Viewer()
        {
            InitializeComponent();
            valitutPalat = new int[7];
            bindingSource.DataSource = Controller.Listaa(curry);
            Taulukko.DataSource = bindingSource;
            this.userDropDown.Items.AddRange(Controller.Listaa(DataObjectType.User).ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (curry > 0)
            curry--;
            if (curry == DataObjectType.Functionality)
            {
                otsikko.Text = curry.ToString();
                bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
                Taulukko.DataSource = bindingSource;
                userStory.Visible = true;
            }
            else
            {
                otsikko.Text = curry.ToString();
                userStory.Visible = false;
                bindingSource.DataSource = Controller.Listaa(curry);
                Taulukko.DataSource = bindingSource;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Älä vittu klikkaa siitä");
            }
            else
            {
                curry++;
                valitutPalat[(int)curry] = (int)Taulukko[1, e.RowIndex].Value;
                bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
                otsikko.Text = curry.ToString();
                userStory.Visible = false;
                priorityFeed.Visible = false;
                priorityLabel.Visible = false;
                if (curry == DataObjectType.Functionality)
                {
                    userStory.Visible = true;
                }

                if (curry == DataObjectType.Test)
                {
                    //priority
                    priorityFeed.Visible = true;
                    priorityLabel.Visible = true;
                    //responsibility
                    this.projectUserDropDown.Items.AddRange(Controller.getProjectUsers(valitutPalat[1]).ToArray());

                }
            }
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
                    this.juttu = new Functionality(text_label1.Text, valitutPalat[(int)curry]);
                    Controller.AddNew(this.juttu, DataObjectType.Functionality);
                    MessageBox.Show("Functionality " + ((Functionality)this.juttu).FunctionalityName + " has been added");
                    text_label1.Text = "";
                    bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
                    Taulukko.DataSource = bindingSource;
                    break;
                case DataObjectType.Test:
                    this.juttu = new Test(text_label1.Text, Convert.ToInt32(priorityFeed.Text), valitutPalat[(int)curry]);
                    Controller.AddNew(this.juttu, DataObjectType.Test);
                    MessageBox.Show("Test " + ((Test)this.juttu).Name + " has been added");
                    text_label1.Text = "";
                    priorityFeed.Text = "";
                    bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
                    Taulukko.DataSource = bindingSource;

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
            bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
            Taulukko.DataSource = bindingSource;
            textBox1.Text = "";
        }
        private void userStoryButton_Click(object sender, EventArgs e)
        {
            this.juttu = new UserStory(Convert.ToInt32(funcIdFeed.Text), givenFeed.Text, whenFeed.Text, thenFeed.Text);
            Controller.AddNew(this.juttu, DataObjectType.UserStory);
            bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          //add user
          User user = new User();
          user.UserName = text_label1.Text;
          Controller.AddNew(user, DataObjectType.User);
          text_label1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
          //remove user
          Object selected_obj = projectUserDropDown.SelectedItem;
          Controller.RemoveItem(((User)selected_obj).UserID, DataObjectType.User);
          projectUserDropDown.Items.Remove(selected_obj);
          projectUserDropDown.SelectedIndex = projectUserDropDown.Items.Count - 1;

        }

        private void AddResponsibleUser(object sender, EventArgs e){

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void updtAddBox_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
