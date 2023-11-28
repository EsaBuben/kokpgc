using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestIt
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
            //listBox1.Items.AddRange(Controller.Listaa().ToArray());
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
