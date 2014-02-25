namespace Quizzer
{
    partial class Settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_clear = new System.Windows.Forms.Button();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.list_questions = new System.Windows.Forms.ListBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.lb_media = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_browse = new System.Windows.Forms.Button();
            this.rb_video = new System.Windows.Forms.RadioButton();
            this.rb_image = new System.Windows.Forms.RadioButton();
            this.rb_none = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_optionc = new System.Windows.Forms.TextBox();
            this.tb_optionb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_optiona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_deleteteam = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_team = new System.Windows.Forms.TextBox();
            this.list_teams = new System.Windows.Forms.ListBox();
            this.bt_addteam = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.list_rounds = new System.Windows.Forms.ListBox();
            this.bt_up = new System.Windows.Forms.Button();
            this.bt_addcategory = new System.Windows.Forms.Button();
            this.tb_category = new System.Windows.Forms.TextBox();
            this.bt_deletec = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_clear);
            this.panel1.Controls.Add(this.cb_category);
            this.panel1.Controls.Add(this.list_questions);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.lb_media);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tb_optionc);
            this.panel1.Controls.Add(this.tb_optionb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_optiona);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_answer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_question);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 369);
            this.panel1.TabIndex = 0;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(390, 4);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 8;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // cb_category
            // 
            this.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(228, 4);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(156, 21);
            this.cb_category.TabIndex = 7;
            // 
            // list_questions
            // 
            this.list_questions.FormattingEnabled = true;
            this.list_questions.Location = new System.Drawing.Point(13, 295);
            this.list_questions.Name = "list_questions";
            this.list_questions.Size = new System.Drawing.Size(453, 69);
            this.list_questions.TabIndex = 6;
            this.list_questions.SelectedIndexChanged += new System.EventHandler(this.list_questions_SelectedIndexChanged);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(96, 261);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 5;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(130, 232);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 5;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(49, 232);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 5;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // lb_media
            // 
            this.lb_media.AutoSize = true;
            this.lb_media.Location = new System.Drawing.Point(4, 105);
            this.lb_media.Name = "lb_media";
            this.lb_media.Size = new System.Drawing.Size(92, 13);
            this.lb_media.TabIndex = 4;
            this.lb_media.Text = " Media Location : ";
            this.lb_media.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_browse);
            this.panel3.Controls.Add(this.rb_video);
            this.panel3.Controls.Add(this.rb_image);
            this.panel3.Controls.Add(this.rb_none);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(263, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 98);
            this.panel3.TabIndex = 0;
            // 
            // bt_browse
            // 
            this.bt_browse.Location = new System.Drawing.Point(123, 57);
            this.bt_browse.Name = "bt_browse";
            this.bt_browse.Size = new System.Drawing.Size(75, 23);
            this.bt_browse.TabIndex = 3;
            this.bt_browse.Text = "Browse";
            this.bt_browse.UseVisualStyleBackColor = true;
            this.bt_browse.Visible = false;
            this.bt_browse.Click += new System.EventHandler(this.bt_browse_Click);
            // 
            // rb_video
            // 
            this.rb_video.AutoSize = true;
            this.rb_video.Location = new System.Drawing.Point(6, 72);
            this.rb_video.Name = "rb_video";
            this.rb_video.Size = new System.Drawing.Size(52, 17);
            this.rb_video.TabIndex = 2;
            this.rb_video.TabStop = true;
            this.rb_video.Text = "Video";
            this.rb_video.UseVisualStyleBackColor = true;
            this.rb_video.CheckedChanged += new System.EventHandler(this.rb_video_CheckedChanged);
            // 
            // rb_image
            // 
            this.rb_image.AutoSize = true;
            this.rb_image.Location = new System.Drawing.Point(6, 49);
            this.rb_image.Name = "rb_image";
            this.rb_image.Size = new System.Drawing.Size(54, 17);
            this.rb_image.TabIndex = 2;
            this.rb_image.TabStop = true;
            this.rb_image.Text = "Image";
            this.rb_image.UseVisualStyleBackColor = true;
            this.rb_image.CheckedChanged += new System.EventHandler(this.rb_image_CheckedChanged);
            // 
            // rb_none
            // 
            this.rb_none.AutoSize = true;
            this.rb_none.Location = new System.Drawing.Point(6, 26);
            this.rb_none.Name = "rb_none";
            this.rb_none.Size = new System.Drawing.Size(51, 17);
            this.rb_none.TabIndex = 2;
            this.rb_none.TabStop = true;
            this.rb_none.Text = "None";
            this.rb_none.UseVisualStyleBackColor = true;
            this.rb_none.CheckedChanged += new System.EventHandler(this.rb_none_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Media : ";
            // 
            // tb_optionc
            // 
            this.tb_optionc.Location = new System.Drawing.Point(96, 200);
            this.tb_optionc.Name = "tb_optionc";
            this.tb_optionc.Size = new System.Drawing.Size(131, 20);
            this.tb_optionc.TabIndex = 3;
            // 
            // tb_optionb
            // 
            this.tb_optionb.Location = new System.Drawing.Point(96, 174);
            this.tb_optionb.Name = "tb_optionb";
            this.tb_optionb.Size = new System.Drawing.Size(131, 20);
            this.tb_optionb.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Option :";
            // 
            // tb_optiona
            // 
            this.tb_optiona.Location = new System.Drawing.Point(96, 148);
            this.tb_optiona.Name = "tb_optiona";
            this.tb_optiona.Size = new System.Drawing.Size(131, 20);
            this.tb_optiona.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Option :";
            // 
            // tb_answer
            // 
            this.tb_answer.Location = new System.Drawing.Point(96, 122);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(131, 20);
            this.tb_answer.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Option : ";
            // 
            // tb_question
            // 
            this.tb_question.Location = new System.Drawing.Point(96, 33);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.Size = new System.Drawing.Size(339, 69);
            this.tb_question.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Correct Answer :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Category :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a question : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_deleteteam);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tb_team);
            this.panel2.Controls.Add(this.list_teams);
            this.panel2.Controls.Add(this.bt_addteam);
            this.panel2.Location = new System.Drawing.Point(12, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 144);
            this.panel2.TabIndex = 0;
            // 
            // bt_deleteteam
            // 
            this.bt_deleteteam.Location = new System.Drawing.Point(396, 118);
            this.bt_deleteteam.Name = "bt_deleteteam";
            this.bt_deleteteam.Size = new System.Drawing.Size(75, 23);
            this.bt_deleteteam.TabIndex = 7;
            this.bt_deleteteam.Text = "Delete";
            this.bt_deleteteam.UseVisualStyleBackColor = true;
            this.bt_deleteteam.Visible = false;
            this.bt_deleteteam.Click += new System.EventHandler(this.bt_deleteteam_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Insert a Team : ";
            // 
            // tb_team
            // 
            this.tb_team.Location = new System.Drawing.Point(13, 50);
            this.tb_team.Name = "tb_team";
            this.tb_team.Size = new System.Drawing.Size(131, 20);
            this.tb_team.TabIndex = 3;
            // 
            // list_teams
            // 
            this.list_teams.FormattingEnabled = true;
            this.list_teams.Location = new System.Drawing.Point(269, 15);
            this.list_teams.Name = "list_teams";
            this.list_teams.Size = new System.Drawing.Size(202, 95);
            this.list_teams.TabIndex = 6;
            this.list_teams.SelectedIndexChanged += new System.EventHandler(this.list_teams_SelectedIndexChanged);
            // 
            // bt_addteam
            // 
            this.bt_addteam.Location = new System.Drawing.Point(150, 47);
            this.bt_addteam.Name = "bt_addteam";
            this.bt_addteam.Size = new System.Drawing.Size(75, 23);
            this.bt_addteam.TabIndex = 5;
            this.bt_addteam.Text = "Add";
            this.bt_addteam.UseVisualStyleBackColor = true;
            this.bt_addteam.Click += new System.EventHandler(this.bt_addteam_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bt_up);
            this.panel4.Controls.Add(this.tb_category);
            this.panel4.Controls.Add(this.list_rounds);
            this.panel4.Controls.Add(this.bt_deletec);
            this.panel4.Controls.Add(this.bt_addcategory);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(12, 537);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 209);
            this.panel4.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Categories by Order : ";
            // 
            // list_rounds
            // 
            this.list_rounds.FormattingEnabled = true;
            this.list_rounds.Location = new System.Drawing.Point(8, 57);
            this.list_rounds.Name = "list_rounds";
            this.list_rounds.Size = new System.Drawing.Size(463, 147);
            this.list_rounds.TabIndex = 1;
            this.list_rounds.SelectedIndexChanged += new System.EventHandler(this.list_rounds_SelectedIndexChanged);
            // 
            // bt_up
            // 
            this.bt_up.Location = new System.Drawing.Point(304, 31);
            this.bt_up.Name = "bt_up";
            this.bt_up.Size = new System.Drawing.Size(43, 23);
            this.bt_up.TabIndex = 2;
            this.bt_up.Text = "Up";
            this.bt_up.UseVisualStyleBackColor = true;
            this.bt_up.Click += new System.EventHandler(this.bt_up_Click);
            // 
            // bt_addcategory
            // 
            this.bt_addcategory.Location = new System.Drawing.Point(146, 11);
            this.bt_addcategory.Name = "bt_addcategory";
            this.bt_addcategory.Size = new System.Drawing.Size(75, 23);
            this.bt_addcategory.TabIndex = 5;
            this.bt_addcategory.Text = "Add";
            this.bt_addcategory.UseVisualStyleBackColor = true;
            this.bt_addcategory.Click += new System.EventHandler(this.bt_addcategory_Click);
            // 
            // tb_category
            // 
            this.tb_category.Location = new System.Drawing.Point(9, 14);
            this.tb_category.Name = "tb_category";
            this.tb_category.Size = new System.Drawing.Size(131, 20);
            this.tb_category.TabIndex = 3;
            // 
            // bt_deletec
            // 
            this.bt_deletec.Location = new System.Drawing.Point(399, 11);
            this.bt_deletec.Name = "bt_deletec";
            this.bt_deletec.Size = new System.Drawing.Size(75, 23);
            this.bt_deletec.TabIndex = 5;
            this.bt_deletec.Text = "Delete";
            this.bt_deletec.UseVisualStyleBackColor = true;
            this.bt_deletec.Visible = false;
            this.bt_deletec.Click += new System.EventHandler(this.bt_deletec_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 750);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_media;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_browse;
        private System.Windows.Forms.RadioButton rb_video;
        private System.Windows.Forms.RadioButton rb_image;
        private System.Windows.Forms.RadioButton rb_none;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_optionc;
        private System.Windows.Forms.TextBox tb_optionb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_optiona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.ListBox list_questions;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_team;
        private System.Windows.Forms.ListBox list_teams;
        private System.Windows.Forms.Button bt_addteam;
        private System.Windows.Forms.Button bt_deleteteam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bt_up;
        private System.Windows.Forms.TextBox tb_category;
        private System.Windows.Forms.ListBox list_rounds;
        private System.Windows.Forms.Button bt_addcategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_deletec;
    }
}