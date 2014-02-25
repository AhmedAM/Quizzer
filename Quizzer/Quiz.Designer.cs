namespace Quizzer
{
    partial class Quiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.lb_option1 = new System.Windows.Forms.Label();
            this.lb_option2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_pb = new System.Windows.Forms.Timer(this.components);
            this.pb_answer = new System.Windows.Forms.PictureBox();
            this.pb_question = new System.Windows.Forms.PictureBox();
            this.lb_question = new System.Windows.Forms.Label();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lb_team1 = new System.Windows.Forms.Label();
            this.lb_teamscore1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Teams = new System.Windows.Forms.Panel();
            this.bt_start = new System.Windows.Forms.Button();
            this.QuestionTimer = new System.Windows.Forms.Timer(this.components);
            this.bt_timer = new System.Windows.Forms.Button();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_questioned = new System.Windows.Forms.Label();
            this.lb_round = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_answer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.Teams.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_option1
            // 
            this.lb_option1.AutoSize = true;
            this.lb_option1.BackColor = System.Drawing.Color.Transparent;
            this.lb_option1.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_option1.ForeColor = System.Drawing.Color.Black;
            this.lb_option1.Location = new System.Drawing.Point(121, 531);
            this.lb_option1.Name = "lb_option1";
            this.lb_option1.Size = new System.Drawing.Size(0, 19);
            this.lb_option1.TabIndex = 1;
            this.lb_option1.Click += new System.EventHandler(this.lb_option1_Click);
            // 
            // lb_option2
            // 
            this.lb_option2.AutoSize = true;
            this.lb_option2.BackColor = System.Drawing.Color.Transparent;
            this.lb_option2.Font = new System.Drawing.Font("PF BeauSans Pro XThin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_option2.ForeColor = System.Drawing.Color.Black;
            this.lb_option2.Location = new System.Drawing.Point(660, 531);
            this.lb_option2.Name = "lb_option2";
            this.lb_option2.Size = new System.Drawing.Size(0, 18);
            this.lb_option2.TabIndex = 2;
            this.lb_option2.Click += new System.EventHandler(this.lb_option1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(652, 512);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(438, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 512);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // timer_pb
            // 
            this.timer_pb.Tick += new System.EventHandler(this.timer_pb_Tick);
            // 
            // pb_answer
            // 
            this.pb_answer.ErrorImage = null;
            this.pb_answer.Location = new System.Drawing.Point(44, 376);
            this.pb_answer.Name = "pb_answer";
            this.pb_answer.Size = new System.Drawing.Size(63, 47);
            this.pb_answer.TabIndex = 2;
            this.pb_answer.TabStop = false;
            // 
            // pb_question
            // 
            this.pb_question.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_question.BackgroundImage")));
            this.pb_question.Location = new System.Drawing.Point(41, 56);
            this.pb_question.Name = "pb_question";
            this.pb_question.Size = new System.Drawing.Size(1082, 114);
            this.pb_question.TabIndex = 2;
            this.pb_question.TabStop = false;
            // 
            // lb_question
            // 
            this.lb_question.AutoSize = true;
            this.lb_question.BackColor = System.Drawing.Color.White;
            this.lb_question.Font = new System.Drawing.Font("PF BeauSans Pro XThin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_question.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_question.Location = new System.Drawing.Point(52, 70);
            this.lb_question.Name = "lb_question";
            this.lb_question.Size = new System.Drawing.Size(35, 18);
            this.lb_question.TabIndex = 3;
            this.lb_question.Text = "Q : ";
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(401, 218);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(473, 288);
            this.MediaPlayer.TabIndex = 4;
            this.MediaPlayer.Visible = false;
            this.MediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MediaPlayer_PlayStateChange);
            // 
            // lb_team1
            // 
            this.lb_team1.AutoSize = true;
            this.lb_team1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team1.Location = new System.Drawing.Point(3, 30);
            this.lb_team1.Name = "lb_team1";
            this.lb_team1.Size = new System.Drawing.Size(56, 17);
            this.lb_team1.TabIndex = 0;
            this.lb_team1.Text = "Team A :";
            // 
            // lb_teamscore1
            // 
            this.lb_teamscore1.AutoSize = true;
            this.lb_teamscore1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_teamscore1.Location = new System.Drawing.Point(107, 49);
            this.lb_teamscore1.Name = "lb_teamscore1";
            this.lb_teamscore1.Size = new System.Drawing.Size(15, 17);
            this.lb_teamscore1.TabIndex = 1;
            this.lb_teamscore1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scores:";
            // 
            // Teams
            // 
            this.Teams.Controls.Add(this.label1);
            this.Teams.Controls.Add(this.lb_teamscore1);
            this.Teams.Controls.Add(this.lb_team1);
            this.Teams.Location = new System.Drawing.Point(1129, 12);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(225, 749);
            this.Teams.TabIndex = 5;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(12, 733);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 6;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // QuestionTimer
            // 
            this.QuestionTimer.Interval = 1000;
            this.QuestionTimer.Tick += new System.EventHandler(this.QuestionTimer_Tick);
            // 
            // bt_timer
            // 
            this.bt_timer.Location = new System.Drawing.Point(578, 733);
            this.bt_timer.Name = "bt_timer";
            this.bt_timer.Size = new System.Drawing.Size(75, 23);
            this.bt_timer.TabIndex = 7;
            this.bt_timer.Text = "Timer";
            this.bt_timer.UseVisualStyleBackColor = true;
            this.bt_timer.Click += new System.EventHandler(this.bt_timer_Click);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(604, 171);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(49, 43);
            this.lb_time.TabIndex = 8;
            this.lb_time.Text = "30";
            // 
            // lb_questioned
            // 
            this.lb_questioned.AutoSize = true;
            this.lb_questioned.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_questioned.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_questioned.Location = new System.Drawing.Point(872, 14);
            this.lb_questioned.Name = "lb_questioned";
            this.lb_questioned.Size = new System.Drawing.Size(76, 33);
            this.lb_questioned.TabIndex = 9;
            this.lb_questioned.Text = "label2";
            this.lb_questioned.Visible = false;
            // 
            // lb_round
            // 
            this.lb_round.AutoSize = true;
            this.lb_round.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_round.Location = new System.Drawing.Point(35, 14);
            this.lb_round.Name = "lb_round";
            this.lb_round.Size = new System.Drawing.Size(82, 36);
            this.lb_round.TabIndex = 10;
            this.lb_round.Text = "label2";
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lb_round);
            this.Controls.Add(this.lb_questioned);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.bt_timer);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.lb_question);
            this.Controls.Add(this.pb_question);
            this.Controls.Add(this.pb_answer);
            this.Controls.Add(this.lb_option2);
            this.Controls.Add(this.lb_option1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_answer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.Teams.ResumeLayout(false);
            this.Teams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_option1;
        private System.Windows.Forms.Label lb_option2;
        private System.Windows.Forms.Timer timer_pb;
        private System.Windows.Forms.PictureBox pb_answer;
        private System.Windows.Forms.PictureBox pb_question;
        private System.Windows.Forms.Label lb_question;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Label lb_team1;
        private System.Windows.Forms.Label lb_teamscore1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Teams;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Timer QuestionTimer;
        private System.Windows.Forms.Button bt_timer;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_questioned;
        private System.Windows.Forms.Label lb_round;
    }
}