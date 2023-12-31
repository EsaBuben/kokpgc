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
        private User chosenOne = new User();
        public Viewer()
        {
            InitializeComponent();
            valitutPalat = new int[7];
            bindingSource.DataSource = Controller.Listaa(curry);
            Taulukko.DataSource = bindingSource;
            this.userDropDown.Items.AddRange(Controller.Listaa(DataObjectType.User).ToArray());
            this.statusDrop.Items.AddRange(status_list);
            this.comboBox1.Items.AddRange(status_list);
            otsikko.Text = curry.ToString();
        }

        //Back button
        private void button1_Click(object sender, EventArgs e)
        {
            if (curry > 0)
            curry--;
            if (curry == DataObjectType.Functionality)
            {
                otsikko.Text = curry.ToString();
                addBox.Text = "Add " + curry.ToString();
                groupBox2.Text = "Remove " + curry.ToString();
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
                groupBox2.Text = "Remove " + curry.ToString();
                userStory.Visible = false;
                priorityFeed.Visible = true;
                priorityLabel.Visible = true;
                changeStatus.Visible = true;
                statusDrop.Visible = false;
                statusLabel.Visible = false;
                respoUser.Visible = true;
                instBox.Visible = true;
                Instructions.Visible = true;
                bindingSource.DataSource = Controller.Listaa(valitutPalat[2],curry);
                Taulukko.DataSource = bindingSource;
            }
            else if (curry == DataObjectType.Result)
            {
                otsikko.Text = curry.ToString();
                addBox.Text = "Add " + curry.ToString();
                groupBox2.Text = "Remove " + curry.ToString();
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
                groupBox2.Text = "Remove " + curry.ToString();
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

        //Taulukossa eteneminen
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
                groupBox2.Text = "Remove " + curry.ToString();
                userStory.Visible = false;
                priorityFeed.Visible = false;
                priorityLabel.Visible = false;
                changeStatus.Visible = false;
                Instructions.Visible = false;
                instBox.Visible = false;
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
                    Instructions.Visible = true;
                    instBox.Visible = true;
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

        //Add box Add button
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
                        if (statusDrop.SelectedIndex.Equals((int)ResultStatus.accepted))
                        {
                            if (chosenOne.UserID.Equals(Controller.GetResponsibleUser(valitutPalat[(int)curry])))
                            {
                                result.setStatus(statusDrop.SelectedIndex);
                                this.juttu = result;
                                Controller.AddNew(this.juttu, DataObjectType.Result);
                                bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
                                Taulukko.DataSource = bindingSource;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("You are not responsible for this test");
                                break;
                            }

                        } else if (!(statusDrop.SelectedIndex < 0 )){
                          result.setStatus(statusDrop.SelectedIndex);
                      }else{
                        result.setStatus((int)ResultStatus.to_be_tested);
                      }
                      this.juttu = result;
                      Controller.AddNew(this.juttu, DataObjectType.Result);
                        bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
                        Taulukko.DataSource = bindingSource;
                    }
                    else{
                      MessageBox.Show("No user selected, plz slcd usr :C");
                    }
                    break;
                default:
                    break;
            }
        }

        //Add box Remove button
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

        //Add box Update button
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

        //UserStory box Add userstory button
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
            }else if(curry == DataObjectType.Result){

                if(!(statusDrop.SelectedIndex < 0 )){
                  Result result = new Result();
                  result.Comment = text_label1.Text;
                  result.ID = Convert.ToInt32(updateIdFeed.Text);
                  result.setStatus(statusDrop.SelectedIndex);
                  this.juttu = result;
                    if (statusDrop.SelectedIndex.Equals((int)ResultStatus.accepted))
                    {
                        if (chosenOne.UserID.Equals(Controller.GetResponsibleUser(valitutPalat[(int)curry])))
                        {
                            Controller.Update(this.juttu, DataObjectType.Result);
                            bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
                            Taulukko.DataSource = bindingSource;
                        } else
                        {
                            MessageBox.Show("You are not responsible for this test");
                        }

                    }
                  Controller.Update(this.juttu, DataObjectType.Result);
                  bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
                  Taulukko.DataSource = bindingSource;
              }else{
                MessageBox.Show("No status selected :C");
              }

            }
            text_label1.Text = "";
            updateIdFeed.Text = "";

        }

        //UserStory box Update userstory button
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

        //UserStory box Remove userstory button
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

        //Add user box add user button
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

        //Choose user Remove selected user button
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

        //Responsible user Add user to test button
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

        //instructions buttons
        private void button5_Click_1(object sender, EventArgs e)
        {
            //Read instructions by id
            int testID = Convert.ToInt32(instID.Text);
            Instructions.Items.Clear();
            Instructions.Items.AddRange(Controller.Listaa(testID, DataObjectType.Instructions).ToArray());
            instID.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //add instructions to test
            int testID = Convert.ToInt32(instID.Text);
            string comment = instrCom.Text;
            Object instructions = new Instructions(testID, comment);
            Controller.AddNew(instructions, DataObjectType.Instructions);
            Instructions.Items.Clear();
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
            Instructions.Items.Clear();
            Instructions.Items.AddRange(Controller.Listaa(testID, DataObjectType.Instructions).ToArray());
            instID.Text = "";
            instrCom.Text = "";
        }
        private void RemoInst_Click(object sender, EventArgs e)
        {
            //Remove instructions
            int testID = Convert.ToInt32(instID.Text);
            Controller.RemoveItem(testID, DataObjectType.Instructions);
            Instructions.Items.Clear();
            instID.Text = "";

        }

        //Show Chart button
        private void button8_Click(object sender, EventArgs e)
        {
            if (chart.Visible.Equals(false))
            {
                chart.Visible = true;
                chart.DataSource = Controller.CountAccepted();
                chart.Series["Series1"].XValueMember = "user_name";
                chart.Series["Series1"].YValueMembers = "count";
                chart.DataBind();
            }
            else
            {
                chart.DataSource = null;
                chart.Visible = false;
            }
        }
        private void changestatus_test_click(object sender, EventArgs e){
          //change status
          if(!(userDropDown.SelectedIndex < 0 )){
            Object selected_obj = userDropDown.SelectedItem;
            Result result = new Result();
            result.Comment = textBox2.Text;
            result.Ref_test_id = Convert.ToInt32(textBox3.Text);
            result.Ref_user_id = ((User)selected_obj).UserID;
            if(!(comboBox1.SelectedIndex < 0 )){
              result.setStatus(comboBox1.SelectedIndex);
            }else{
              result.setStatus((int)ResultStatus.to_be_tested);
            }
            this.juttu = result;
            Controller.AddNew(this.juttu, DataObjectType.Result);
          }else{
            MessageBox.Show("No user selected, plz slcd usr :C");
          }
        }

        public void removeRole_click(object sender, EventArgs e){
          //remove projectrole basen on ref user id, ref project id
          ProjectRole pr = new ProjectRole();
          pr.Ref_user_id = Convert.ToInt32(userNameFeed.Text);
          pr.Ref_proj_id = Convert.ToInt32(projectIdFeed.Text);
          pr.Role = rooliFeed.Text;
          Controller.RemoveProjectRole(pr);
          userNameFeed.Text="";
          rooliFeed.Text="";
          projectIdFeed.Text="";
          MessageBox.Show("Removed ROLE D:");
        }

        public void updateRole_click(object sender, EventArgs e){
            //update projectrole role basen on ref user id, ref project id
          ProjectRole pr = new ProjectRole();
          pr.Ref_user_id = Convert.ToInt32(userNameFeed.Text);
          pr.Ref_proj_id = Convert.ToInt32(projectIdFeed.Text);
          pr.Role = rooliFeed.Text;
          Controller.Update(pr, DataObjectType.ProjectRole);
          userNameFeed.Text="";
          rooliFeed.Text="";
          projectIdFeed.Text="";
          MessageBox.Show("Updated ROLE :D");
        }

        public void removeResponsibleUser(object sender, EventArgs e){
            //remove responsible
            //set user id to -1
            //this is checked in TestGateway SelectAll
            User user = new User();
            user.UserID = -1;
            Controller.SetResponsibleUser(user, Convert.ToInt32(testIdFeed.Text));
            bindingSource.DataSource = Controller.Listaa(valitutPalat[(int)curry], curry);
            Taulukko.DataSource = bindingSource;
        }
        private void signin_Click(object sender, EventArgs e)
        {
            chosenOne = (User)userDropDown.SelectedItem;
            signedAs.Text = "Signed in as : " + chosenOne.UserName + " " + chosenOne.UserID;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            string stringi = "";
            foreach (string comment in Controller.GetComment(chosenOne.UserID))
            {
                stringi += comment + "\n";
            }
            MessageBox.Show(stringi);
        }
        private void AddRole_Click(object sender, EventArgs e)
        {
            ProjectRole pr = new ProjectRole();
            pr.Ref_user_id = Convert.ToInt32(userNameFeed.Text);
            pr.Ref_proj_id = Convert.ToInt32(projectIdFeed.Text);
            pr.Role = rooliFeed.Text;
            Controller.AddNew(pr, DataObjectType.ProjectRole);
            userNameFeed.Text = "";
            rooliFeed.Text = "";
            projectIdFeed.Text = "";
            MessageBox.Show("New ROLE :D");
        }

        private void NameUpdate_Click(object sender, EventArgs e)
        {
            //update chosenOne user name
            chosenOne.UserName = NameText.Text;
            Controller.Update(chosenOne, DataObjectType.User);
            NameText.Text = "";
            signedAs.Text = "Signed in as : " + chosenOne.UserName + " " + chosenOne.UserID;
            userDropDown.Text = chosenOne.UserName;
            userDropDown.Items.Clear();
            userDropDown.Items.AddRange(Controller.Listaa(DataObjectType.User).ToArray());

        }



        //ROSKIA


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


    }
}
