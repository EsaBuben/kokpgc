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
        private string[] status_list = {"to be tested","currently under testing","results reported","accepted"};
        BindingSource bindingSource = new BindingSource();
        DataObjectType curry = DataObjectType.Project;
        public Viewer()
        {
            InitializeComponent();
            valitutPalat = new int[7];
            bindingSource.DataSource = Controller.Listaa(curry);
            Taulukko.DataSource = bindingSource;
            this.userDropDown.Items.AddRange(Controller.Listaa(DataObjectType.User).ToArray());
            this.statusDrop.Items.AddRange(status_list);
            otsikko.Text = curry.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (curry > 0)
            curry--;
            if (curry == DataObjectType.Functionality)
            {
                otsikko.Text = curry.ToString();
                addBox.Text = "Add " + curry.ToString();
                bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
                Taulukko.DataSource = bindingSource;
                userStory.Visible = true;
                priorityFeed.Visible = false;
                priorityLabel.Visible = false;
                statusDrop.Visible = false;
                statusLabel.Visible = false;
                respoUser.Visible = false;
            }
            else if (curry == DataObjectType.Test)
            {
                otsikko.Text = curry.ToString();
                addBox.Text = "Add " + curry.ToString();
                userStory.Visible = false;
                priorityFeed.Visible = true;
                priorityLabel.Visible = true;
                changeStatus.Visible = true;
                statusDrop.Visible = false;
                statusLabel.Visible = false;
                respoUser.Visible = true;
                bindingSource.DataSource = Controller.Listaa(valitutPalat[2],curry);
                Taulukko.DataSource = bindingSource;
            }
            else if (curry == DataObjectType.Result)
            {
                otsikko.Text = curry.ToString();
                addBox.Text = "Add " + curry.ToString();
                statusLabel.Visible = true;
                statusDrop.Visible = true;
                respoUser.Visible = false;
                bindingSource.DataSource = Controller.Listaa(valitutPalat[3],curry);
                Taulukko.DataSource = bindingSource;
            }
            else
            {
                otsikko.Text = curry.ToString();
                addBox.Text = "Add " + curry.ToString();
                projectIdFeed.Text = "";
                userStory.Visible = false;
                priorityFeed.Visible = false;
                priorityLabel.Visible = false;
                changeStatus.Visible = false;
                statusDrop.Visible = false;
                statusLabel.Visible = false;
                respoUser.Visible = false;
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
                addBox.Text = "Add " + curry.ToString();
                userStory.Visible = false;
                priorityFeed.Visible = false;
                priorityLabel.Visible = false;
                changeStatus.Visible = false;
                if (curry == DataObjectType.Functionality)
                {
                    projectIdFeed.Text = valitutPalat[(int)curry].ToString();
                    userStory.Visible = true;
                }

                if (curry == DataObjectType.Test)
                {
                    //priority
                    priorityFeed.Visible = true;
                    priorityLabel.Visible = true;
                    changeStatus.Visible= true;
                    respoUser.Visible = true;
                    //responsibility
                    this.projectUserDropDown.Items.Clear();
                    this.projectUserDropDown.Items.AddRange(Controller.getProjectUsers(valitutPalat[1]).ToArray());

                }
                if (curry == DataObjectType.Result)
                {
                    statusDrop.Visible = true;
                    statusLabel.Visible = true;
                    respoUser.Visible= false;
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
                    //Console.WriteLine(statusDrop.SelectedIndex);
                    if(!(userDropDown.SelectedIndex < 0 )){
                      Object selected_obj = userDropDown.SelectedItem;
                      Result result = new Result();
                      result.Comment = text_label1.Text;
                      result.Ref_test_id = valitutPalat[(int)curry];
                      result.Ref_user_id = ((User)selected_obj).UserID;
                      if(!(statusDrop.SelectedIndex < 0 )){
                        result.setStatus(statusDrop.SelectedIndex);
                      }else{
                        result.setStatus((int)ResultStatus.to_be_tested);
                      }
                      this.juttu = result;
                      Controller.AddNew(this.juttu, DataObjectType.Result);
                    }else{
                      MessageBox.Show("No user selected, plz slcd usr :C");
                    }
                    break;
                default:
                    break;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Controller.RemoveItem(Convert.ToInt32(textBox1.Text), curry);

            if (curry == DataObjectType.Project)
            {
                bindingSource.DataSource = Controller.Listaa(curry);
                Taulukko.DataSource = bindingSource;
                textBox1.Text = "";
            }
            else
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
        private void updtAddBox_Click(object sender, EventArgs e)
        {
            if (curry == DataObjectType.Project)
            {
                this.juttu = new Project(text_label1.Text, Convert.ToInt32(updateIdFeed.Text));
                Controller.Update(this.juttu, DataObjectType.Project);
                bindingSource.DataSource = Controller.Listaa(curry);
                Taulukko.DataSource = bindingSource;
            }
            else if (curry == DataObjectType.Functionality)
            {
                Functionality abba = new Functionality(text_label1.Text);
                abba.FunctionalityID = Convert.ToInt32(updateIdFeed.Text);
                this.juttu = abba;
                Controller.Update(this.juttu, DataObjectType.Functionality);
                bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
                Taulukko.DataSource = bindingSource;
            }
            else if (curry == DataObjectType.Test)
            {
                this.juttu = new Test(text_label1.Text, Convert.ToInt32(priorityFeed.Text), valitutPalat[(int)curry], Convert.ToInt32(updateIdFeed.Text));
                Controller.Update(this.juttu, DataObjectType.Test);
                bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
                Taulukko.DataSource = bindingSource;
                priorityFeed.Text = "";
            }
            text_label1.Text = "";
            updateIdFeed.Text = "";

        }
        private void updateUserstory_Click(object sender, EventArgs e)
        {
            this.juttu = new UserStory(Convert.ToInt32(funcIdFeed.Text), givenFeed.Text, whenFeed.Text, thenFeed.Text);
            Controller.Update(this.juttu, DataObjectType.UserStory);
            bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
            Taulukko.DataSource = bindingSource;
            funcIdFeed.Text = "";
            givenFeed.Text = "";
            whenFeed.Text = "";
            thenFeed.Text = "";
        }
        private void removeUsrStryButton_Click(object sender, EventArgs e)
        {
            Controller.RemoveItem(Convert.ToInt32(funcIdFeed.Text), DataObjectType.UserStory);
            bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
            Taulukko.DataSource = bindingSource;
            funcIdFeed.Text = "";
            givenFeed.Text = "";
            whenFeed.Text = "";
            thenFeed.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //add user
            User user = new User();
            user.UserName = userNameFeed.Text;
            Controller.AddNew(user, DataObjectType.User);
            userNameFeed.Text = "";
            //if labela are labelb not embty
            if (!(projectIdFeed.Text == "" || rooliFeed.Text == ""))
            {
                ProjectRole pr = new ProjectRole();
                pr.Ref_user_id = user.UserID;
                pr.Ref_proj_id = Convert.ToInt32(projectIdFeed.Text);
                pr.Role = rooliFeed.Text;
                Controller.AddNew(pr, DataObjectType.ProjectRole);
                rooliFeed.Text = "";
            }
            this.userDropDown.Items.Clear();
            projectUserDropDown.Items.Clear();
            projectUserDropDown.Items.AddRange(Controller.getProjectUsers(valitutPalat[1]).ToArray());
            this.userDropDown.Items.AddRange(Controller.Listaa(DataObjectType.User).ToArray());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Object selected_obj = userDropDown.SelectedItem;
            Controller.RemoveItem(((User)selected_obj).UserID, DataObjectType.User);
            userDropDown.Items.Remove(selected_obj);
            userDropDown.SelectedIndex = userDropDown.Items.Count - 1;
            this.userDropDown.Items.Clear();
            this.userDropDown.Items.AddRange(Controller.Listaa(DataObjectType.User).ToArray());
            userDropDown.Text = "";

        }

        private void add_to_test_click(object sender, EventArgs e)
        {
            //add responsible user to test
            Object selected_obj = projectUserDropDown.SelectedItem;
            User user = (User)selected_obj;
            Controller.SetResponsibleUser(user, Convert.ToInt32(testIdFeed.Text));
            this.projectUserDropDown.Items.Clear();
            this.projectUserDropDown.Items.AddRange(Controller.Listaa(DataObjectType.User).ToArray());
            testIdFeed.Text = "";
            projectUserDropDown.Text = "";
            bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
            Taulukko.DataSource = bindingSource;

        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            //Read instructions by id
            int testID = Convert.ToInt32(instID.Text);
            Object instructions = Controller.Listaa(testID, DataObjectType.Instructions);
            Instructions.Text = ((Instructions)instructions).InstructionText;
            instID.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //add instructions to test
            int testID = Convert.ToInt32(instID.Text);
            string comment = instrCom.Text;
            Object instructions = new Instructions(testID, comment);
            Controller.AddNew(instructions, DataObjectType.Instructions);
            instID.Text = "";
            instrCom.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //update instructions
            int testID = Convert.ToInt32(instID.Text);
            string comment = instrCom.Text;
            Object instructions = new Instructions(testID, comment);
            Controller.Update(instructions, DataObjectType.Instructions);
            instID.Text = "";
            instrCom.Text = "";

        }












        //private void button4_Click(object sender, EventArgs e)
        //{
        //    //add user
        //    User user = new User();
        //    user.UserName = text_label1.Text;
        //    Controller.AddNew(user, DataObjectType.User);
        //    text_label1.Text = "";
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    //remove user
        //    Object selected_obj = projectUserDropDown.SelectedItem;
        //    Controller.RemoveItem(((User)selected_obj).UserID, DataObjectType.User);
        //    projectUserDropDown.Items.Remove(selected_obj);
        //    projectUserDropDown.SelectedIndex = projectUserDropDown.Items.Count - 1;

        //}
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





        private void AddResponsibleUser(object sender, EventArgs e){

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{}



        private void userDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void projectUserDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void projectUserBox_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        
    }
}
