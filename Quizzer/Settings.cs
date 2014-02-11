﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quizzer
{
    public partial class Settings : Form
    {
        //instances
        Connection connect = new Connection();
        ButtonsForm bf;
        
        //Variables
        DataTable dt;
        bool FormLoaded = false;
        string mediaType;

        //Specific Record Related Variables | Will be used to perform Updating and Deletion etc
        int QuestionID = 0;

        public Settings(ButtonsForm bf1)
        {
            InitializeComponent();
            bf = bf1;
            DBConnect();
            rb_none.Checked = true;
        }


        private void CategoryCBFiller()
        {
            dt =connect.CustomSelect("Category_Name", "Category_Main", "");
            cb_category.DataSource = dt;
            cb_category.DisplayMember = "Category_Name";

        }


        private void DBConnect() // Connects to the Database
        {
            int state = connect.ConnectDBase(bf.DBlocation);
            if (state == 0)
            {
                bf.GetDbaseLocation();
                connect.ConnectDBase(bf.DBlocation);
            }
        }

        private void bt_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(rb_image.Checked ==true)
                open.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";

            else  if (rb_video.Checked ==true)
                open.Filter = "Video Files (MP4,WMV,FLV,3GP)|*.MP4;*.WMV;*.FLV;*.3GP";
            
            if (open.ShowDialog() == DialogResult.OK)
            {
                lb_media.Text = open.FileName;
                lb_media.Visible = true;
            }
        }



      

        private void rb_none_CheckedChanged(object sender, EventArgs e)
        {
            bt_browse.Visible = false;
            mediaType = "None";
        }

        private void rb_image_CheckedChanged(object sender, EventArgs e)
        {
            bt_browse.Visible = true;
            mediaType = "Image";
        }

        private void rb_video_CheckedChanged(object sender, EventArgs e)
        {
            bt_browse.Visible = true;
            mediaType = "Video";
        }


        /// <summary>
        /// Loads all the existing questions to the Form from the Database so the user can edit them if needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_Load(object sender, EventArgs e)
        {
            ListUpdate();
            FormLoaded = true;
        }

        /// <summary>
        /// Connects to the database and gets the question list and shows it in the list box 
        /// </summary>
        private void ListUpdate()
        {
            dt = connect.CustomSelect("Question_ID \"ID\" ,Question_Text \"Question\" , Question_Answer \"Answer\" , Question_OptionA \"B\",Question_OptionB \"C\" , Question_OptionC \"D\",Media_Type \"Media\", Media_Location \"Location\" ,Category_Main.Category_Name \"Category\"", "Questions,Category_Main ", "where Category_Main.Category_ID = Questions.Category_ID");
            list_questions.DataSource = dt;
            list_questions.DisplayMember = "Question";
        }

        /// <summary>
        /// Adds new question to the Database and updates the List
        /// </summary>
        private void bt_add_Click(object sender, EventArgs e)
        {
            connect.CustomInsertion("Questions", "Question_Asked,Question_Text,Question_Answer,Question_OptionA,Question_OptionB,Question_OptionC,Category_ID,Media_Type,Media_Location", "0,'"+tb_question.Text+"','"+tb_answer.Text+"','"+tb_optiona.Text+"','"+tb_optionb.Text+"','"+tb_optionc.Text+"',(Select Category_ID from Category_Main where Category_Name = '"+cb_category.Text+"'),'"+mediaType+"','"+lb_media.Text+"'");
            ListUpdate();
        }

        private void list_questions_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                if (FormLoaded)
                {
                    DataRow[] R;
                    R = dt.Select("Question = '" + list_questions.Text + "'");
                    QuestionID = Convert.ToInt16(R[0].ItemArray[0].ToString());
                    tb_question.Text = R[0].ItemArray[1].ToString();
                    tb_answer.Text = R[0].ItemArray[2].ToString();
                    tb_optiona.Text = R[0].ItemArray[3].ToString();
                    tb_optionb.Text = R[0].ItemArray[4].ToString();
                    tb_optionc.Text = R[0].ItemArray[5].ToString();

                    if (R[0].ItemArray[6].ToString() == "None")
                        rb_none.Checked = true;
                    if (R[0].ItemArray[6].ToString() == "Image")
                        rb_image.Checked = true;
                    if (R[0].ItemArray[6].ToString() == "Video")
                        rb_video.Checked = true;

                    lb_media.Text = R[0].ItemArray[7].ToString();
                    lb_media.Visible = true;
                    
                    string s = R[0].ItemArray[8].ToString();
                    s = s.Substring(0, s.Length-1);
                    cb_category.SelectedIndex = cb_category.FindStringExact(s);
                    
                    //cb_category.DropDownStyle = ComboBoxStyle.DropDownList;
                }
           
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (QuestionID != 0)
            {
                if(connect.CustomNonQuery("Delete from Questions where Question_ID = " + QuestionID + "  ") > 0)
                ListUpdate();
                Clearer();
            }
        }

        private void Clearer()
        {
            cb_category.Text = "";
            tb_answer.Text = "";
            tb_optiona.Text = "";
            tb_optionb.Text = "";
            tb_optionc.Text = "";
            tb_question.Text = "";
            rb_none.Checked = true;
            lb_media.Text = "";
            QuestionID = 0;
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            Clearer();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (QuestionID != 0)
            {
                if(connect.CustomNonQuery("Update Questions Set Question_text = '" + tb_question.Text + "' ,  Question_Answer = '" + tb_answer.Text + "'  ,  Question_OptionA = '" + tb_optiona.Text + "' , Question_OptionB = '" + tb_optionb.Text + "' , Question_OptionC = '" + tb_optionc.Text + "' , Category_ID  = (Select Category_ID from Category_Main where Category_Name = '" + cb_category.Text + "') , Media_Type = '" + mediaType + "' , Media_Location = '" + lb_media.Text + "'  where Question_ID = " + QuestionID + "") >0)
                    MessageBox.Show("Update Successfull ^_^ ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListUpdate();
                
            }

        }
    }
}