using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quizzer
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            //axWindowsMediaPlayer1.URL = @"C:\Users\Ahmed\Downloads\Video.mp4";
            ButtonsForm BF = new ButtonsForm(this);
            BF.MdiParent = this;
            BF.Show();
        }

       
    }
}
