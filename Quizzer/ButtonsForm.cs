using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quizzer;

namespace Quizzer
{
    public partial class ButtonsForm : Form
    {
           //Instances
            Mainform mf;
            Connection connect = new Connection(); // creating an instance of Connection Class 


            //Variables
             public string DBlocation; // stores the database file location if it is as a file ;



        public ButtonsForm(Mainform mf1)
        { // Constructor 
            InitializeComponent();

            mf = mf1;
        }


        public void  GetDbaseLocation()// Function to get Database location when Auto-connect fails ; 
        {
            OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";



            if (open.ShowDialog() == DialogResult.OK)
            {
                DBlocation = open.FileName;
            }
        }
     

        private void bt_settings_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings(this);
            Settings.MdiParent = mf;
            Settings.Show();
        }

        private void bt_quiz_Click(object sender, EventArgs e)
        {
            Quiz Q = new Quiz(this);
            Q.MdiParent = mf;
            Q.Show();
        }
    }
}
