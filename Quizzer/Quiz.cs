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
    public partial class Quiz : Form
    {
        //Instances
        ButtonsForm bf;
        Connection connect = new Connection();


        //Variables
        DataTable dt;
        DataTable dt_team;
        object picture;
        
        int count = 0; //count for timer
        int CountDown = 40; // Countdown 
        int QuestionID;  // will be used to store in database if a team answers a question correct or wrong ;
        int QuestionCounter = 0; // used as row index for new question
        int TeamID = 0;  // the team from which the question is being asked
        int TeamIterations = 0; // starts from 0 - N-1 (N = no. of teams ) and then come backs to 0 when the 1st team is questioned 
        int teamCount =0; //Total number of teams 
        int AudienceQuestion = 1; // Number of question to be asked from Audiences ; 
        int CorrectAnswer; // Stores the ID of correct Answer (1,2,3,4);
        int SelectedAnswer;

        int OptionCount = 2;

        bool Option3 = false;
        bool Option4 = false;

        bool IsTimeUp =false;

        bool GoToNextQuestion = false;// 

        public Quiz(ButtonsForm bf1)
        {
            InitializeComponent();
            bf = bf1;
            DBConnect();
           
            
            
            
        }


        private void Quiz_Load(object sender, EventArgs e)
        {
            GetQuestions();
            GetTeams();
            CreateTeamLabels();
            MediaPlayer.Visible = false;
            MediaPlayer.Size = new System.Drawing.Size(473, 288);
            OptionsClickableStateChanger(false);
        }


        private void bt_start_Click(object sender, EventArgs e)
        {
            Reseter();
            AskQuestion();
            bt_start.Visible = false;
            OptionsClickableStateChanger(true);
            
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


        private void OptionsChecker()
        {

            //Creating Options if there are more than 2 choices ( max 4 ) 
            if (dt.Rows[QuestionCounter].ItemArray[4].ToString() != "")
            {
                OptionsControlAdder(121, 640, 111, 618, 3);
                Option3 = true;
            }

            if ((dt.Rows[QuestionCounter].ItemArray[5].ToString() != "") && (dt.Rows[QuestionCounter].ItemArray[4].ToString() == ""))
            {
                OptionsControlAdder(121, 640, 111, 618, 4);
                //OptionsControlAdder(660, 640, 652, 618, 4);
                Option4 = true;
            }
            else if ((dt.Rows[QuestionCounter].ItemArray[5].ToString() != ""))
            {
                OptionsControlAdder(660, 640, 652, 618, 4);
                Option4 = true;
            }
            
        }

        private void OptionsControlAdder(int XLabel,int YLabel,int XPicture,int YPicture , int n)
        {

            Label lOption = new Label();
            lOption.Location = new Point(XLabel, YLabel);
            lOption.Name = "lb_option"+n;
            lOption.Click += lb_option1_Click;
            lOption.Font = new Font("PF BeauSans Pro", 12, FontStyle.Regular);

            PictureBox POption = new PictureBox();
            POption.Location = new Point(XPicture, YPicture);
            POption.Name = "Picturebox"+n;
            POption.Size = pictureBox1.Size;
            POption.MouseHover += pictureBox4_MouseHover;
            POption.MouseClick += pictureBox4_Click;
            POption.MouseLeave += pictureBox4_MouseLeave;

            POption.BackgroundImage = global::Quizzer.Properties.Resources.DefaultBack;

            OptionCount++;

            this.Controls.Add(lOption);
            this.Controls.Add(POption);
            
        }

        private void GetQuestions()
        {
            //Select  from  
            dt = connect.CustomSelect("Questions.Question_ID,Questions.Question_Text,Questions.Question_Answer,Questions.Question_OptionA,Questions.Question_OptionB,Questions.Question_OptionC,Questions.Media_Type,Questions.Media_Location,Category_Main.Category_Order,Category_Main.Category_Name", "Questions, Category_Main", "where Category_Main.Category_ID = Questions.Category_ID and Question_Asked = 0 Order by Category_Order;");
            QuestionID = Convert.ToInt32(dt.Rows[QuestionCounter].ItemArray[0].ToString());
            //AnswerRandomizer();

            //OptionsChecker();

           
            
            
        }
        private void GetTeams()
        {
            dt_team = connect.CustomSelect("Team_ID,Team_Name", "Team_Main", "");
            try
            {
                TeamID = Convert.ToInt32(dt_team.Rows[TeamIterations].ItemArray[0].ToString());
                teamCount = dt_team.Rows.Count;
            }
            catch
            {
            }

        }



        private void CreateTeamLabels()
        {
            if (dt_team.Rows.Count == 0)
            {
                this.Teams.Controls.Remove(lb_team1);
                this.Teams.Controls.Remove(lb_teamscore1);
            }

            else
            {
                lb_team1.Text = dt_team.Rows[0].ItemArray[1].ToString();
                lb_team1.Name = "lb_team" + dt_team.Rows[0].ItemArray[0].ToString();
                lb_teamscore1.Name = "lb_teamscore" + dt_team.Rows[0].ItemArray[0].ToString();


                int TeamLabelY = 80;  // 30 + 20  , there is already a label at 30 so giving 20 pixels space and gonna add 20 for every x=3 
                int TeamScoreLabelY = 99;   // 49+20   , same reason as aboves x= 107

                

                for (int i = 2; i <= dt_team.Rows.Count ; i++)
                {
                    Label lTeam = new Label();
                    Label lScore = new Label();

                    lTeam.Name = "lb_team" + dt_team.Rows[i-1].ItemArray[0].ToString();

                    lScore.Name = "lb_teamscore" + dt_team.Rows[i - 1].ItemArray[0].ToString();

                    lTeam.Text = dt_team.Rows[i - 1].ItemArray[1].ToString();
                    lScore.Text = "0";

                    lScore.Font = lTeam.Font = new Font("Monotype Corsiva", 11 ,FontStyle.Italic);
                    lTeam.Location = new Point(3, TeamLabelY);
                    lScore.Location = new Point(107, TeamScoreLabelY);
                    TeamLabelY += 50; TeamScoreLabelY += 50;
                    this.Teams.Controls.Add(lTeam);
                    this.Teams.Controls.Add(lScore);


                }
            }
        }





        private void AskQuestion()
        {
            try
            {
                MediaDelegate();
                OptionsChecker();
                AnswerRandomizer();
                lb_question.Text = dt.Rows[QuestionCounter].ItemArray[1].ToString();
                lb_round.Text = dt.Rows[QuestionCounter].ItemArray[9].ToString();
                QuestionCounter++;

                if(Teams.Visible==true)
                {
                    string n = dt.Rows[QuestionCounter-1].ItemArray[9].ToString();
                    if (n == dt.Rows[dt.Rows.Count-1].ItemArray[9].ToString())
                        Teams.Visible = false;
                }


                //Showing which team's question it is or is it an audience question
                if (TeamIterations < teamCount)
                {
                    lb_questioned.Visible = true;
                    var Label = new Control[1];
                    Label = this.Controls.Find("lb_team" + TeamID, true);

                    lb_questioned.Text = Label[0].Text;

                    if (lb_questioned.ForeColor != Color.DeepSkyBlue)
                        lb_questioned.ForeColor = Color.DeepSkyBlue;
                    else
                        lb_questioned.ForeColor = Color.SteelBlue;
                }
                else
                {
                    lb_questioned.Text = "Audience Question";
                    lb_questioned.ForeColor = Color.Gold;
                }


            }
            catch
            {
                if (QuestionCounter >= dt.Rows.Count)
                {
                    MessageBox.Show("Questions Over");
                }
            }
        }


        // If any question has any media , this functions handles how to display it
        private void MediaDelegate()
        {
            // 6 = type , 7= location
            //Questions.Question_ID,Questions.Question_Text,Questions.Question_Answer,Questions.Question_OptionA,Questions.Question_OptionB,Questions.Question_OptionC,Questions.Media_Type,Questions.Media_Location,Category_Main.Category_ID,Category_Main.Category_Name", "Questions, Category_Main", "where Category_Main.Category_ID = Questions.Category_ID and Question_Asked = 0 Order by Category_ID;");
            string media = dt.Rows[QuestionCounter].ItemArray[6].ToString();
            if (media == "Image")
            {
                pb_answer.Location = new Point(448, 247);
                pb_answer.Size = new System.Drawing.Size(326, 259);
                pb_answer.ImageLocation = dt.Rows[QuestionCounter].ItemArray[7].ToString();
            }
            else if (media == "Video")
            {
                MediaPlayer.Visible = true;
                MediaPlayer.URL = pb_answer.ImageLocation = dt.Rows[QuestionCounter].ItemArray[7].ToString();
                MediaPlayer.Ctlcontrols.stop();
                
            }

        }


        private void AnswerRandomizer()
        {
            try
            {
                int n;  // will be used to temporarily store the Random Int and assign ;
                int[] Array = Randomizer().ToArray();
                //Random rnd = new Random();
                var label = new Control[1];
                int count = 6;
                if (!Option3 && !Option4)
                    count = 4;
                else if (!Option3 || !Option4)
                    count = 5;
                for (int i = 2; i < count; i++)
                {
                    
                    n = Array[i - 2];
                    if (n==3 && !Option3)
                        continue;
                    if (n == 4 && !Option4)
                        continue;
                    if (!Option3 && i == 4)
                        i = 5;
                    
                    if (i == 2)
                        CorrectAnswer = n;
                    label = this.Controls.Find("lb_option" + n, true);
                    label[0].Text = dt.Rows[QuestionCounter].ItemArray[i].ToString();
                    
                }
                
            }
            catch
            {
              
            }

        }


        private List<int> Randomizer()
        {
            List<int> list = new List<int>();
            int val;
            Random r;
            int IntialCount = 1;
            int count = 4;
            if (!Option3 && !Option4) 
            count = 2;
            else if (!Option3 || !Option4)
                count = 3;
            //int maxRandomValue = 4;

            while (IntialCount <= count)
            {
                r = new Random();
                val = r.Next(1,5);
                if (val != 3  || (val == 3 && Option3) || (val == 4 && Option4))
                {
                    if (val != 4 || (val == 3 && Option3) || (val == 4 && Option4))
                    {
                        if (!list.Contains(val))
                        {
                            list.Add(val);
                            IntialCount++;
                        }
                    }
                }

            }
            return list;
            
        }



        //Hover event for all the Picture boxes
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {

            ((System.Windows.Forms.Control)(sender)).BackgroundImage = global::Quizzer.Properties.Resources.HoverBack;
        }
        //Leave event for all the Picture Boxes
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            ((System.Windows.Forms.Control)(sender)).BackgroundImage = global::Quizzer.Properties.Resources.DefaultBack;
        }



        private void OptionsClickableStateChanger(bool change)
        {
            var PictureBoxArray = new Control[4];
            //disabling all the picture boxes so they dont respond to events
            for (int i = 1; i <= 4; i++)
            {
                try
                {
                    PictureBoxArray = this.Controls.Find("pictureBox" + i, true);
                    PictureBoxArray[0].Enabled = change;
                }
                catch
                {

                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //QuestionTimer.Stop();

            OptionsClickableStateChanger(false);

            picture = sender;
            int length = ((System.Windows.Forms.Control)(picture)).Name.Length;
            SelectedAnswer = Convert.ToInt32(((System.Windows.Forms.Control)(picture)).Name.Substring(length - 1, 1));

            ((System.Windows.Forms.Control)(picture)).Enabled = true;
            timer_pb.Start();  //Suspense 
            

           
            
        }

        private bool AnswerChecker(int option)
        {
            if (option == CorrectAnswer)
                return true;
            else
                return false;
            
        }
        private void AnswerPicture(bool answer)
        {
            CountDown = 10;
            GoToNextQuestion = true;
            MediaPlayer.Visible = false;
            pb_answer.Location = new Point(448, 247);
            pb_answer.Size = new System.Drawing.Size(326, 259);
            if (answer)
            {
                pb_answer.BackgroundImage = global::Quizzer.Properties.Resources.AnswerCorrect;

                if (!IsTimeUp && TeamIterations<teamCount) // if TeamIterations >= team count , it means that the question is audience question so then no score is added 
                {
                    var Label = new Control[1];
                    Label = this.Controls.Find("lb_teamscore" + TeamID, true);

                    int score = Convert.ToInt32(Label[0].Text);
                    Label[0].Text = (score + 10).ToString();
                }

            }
            else
            {
                try
                {
                    pb_answer.BackgroundImage = global::Quizzer.Properties.Resources.AnswerWrong;

                    var Picture = new Control[1];
                    Picture = this.Controls.Find("pictureBox" + CorrectAnswer, true);
                    Picture[0].BackgroundImage = global::Quizzer.Properties.Resources.CorrectBack;
                }
                catch
                {
                    //Nothing to catch ,error happens when user clicks an option when the quiz is not started
                }

            }

            TeamIterations++;
            if (TeamIterations == teamCount && AudienceQuestion == 0)
                TeamIterations = 0;
            else if (TeamIterations == teamCount + AudienceQuestion)
                TeamIterations = 0;
            try
            {
                TeamID = Convert.ToInt32(dt_team.Rows[TeamIterations].ItemArray[0].ToString());
            }
            catch
            { }
            OptionsClickableStateChanger(true);
            bt_start.Visible = true;
        }

        private void timer_pb_Tick(object sender , EventArgs e)
        {
            
            
            bool back = false;

            if(count%2 ==0)
            back = true;

                if(back)
                ((System.Windows.Forms.Control)(picture)).BackgroundImage = global::Quizzer.Properties.Resources.CorrectBack;
                else
                    ((System.Windows.Forms.Control)(picture)).BackgroundImage = global::Quizzer.Properties.Resources.WrongBack;
                back = false;
                count++;
                if (count > 10 && count < 20)
                    timer_pb.Interval = 200;
                if (count > 20 && count < 30)
                    timer_pb.Interval = 400;
                if (count > 30 )
                    timer_pb.Interval = 600;
                if (count > 25)
                {
                    ((System.Windows.Forms.Control)(picture)).BackgroundImage = global::Quizzer.Properties.Resources.DefaultBack;
                    count = 0;
                    timer_pb.Stop();
                    timer_pb.Interval = 100;
                    AnswerPicture(AnswerChecker(SelectedAnswer));

                }
                
        } // timer end



        private void Reseter()
        {
            lb_time.Visible = false;
            QuestionTimer.Stop();
            pb_answer.BackgroundImage = null;
            pb_answer.Location = new Point(124, 376);
            pb_answer.Size = new  System.Drawing.Size(63, 47);
            MediaPlayer.URL = "";
            MediaPlayer.Visible = false;
            //MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused;
            MediaPlayer.Visible = false;

            if (Option3)
                OptionsDeleter(3);
            if (Option4)
                OptionsDeleter(4);
            Option3 = Option4 = false;
        }

        //Delete the choice when reseting so there wont be any empty choice boxes for the next question! 
        private void OptionsDeleter(int n)
        {
            var Label = new Control[1];
            var Picture = new Control[1];
            Label = this.Controls.Find("lb_option"+n, true);
            Picture = this.Controls.Find("pictureBox"+n, true);
            this.Controls.Remove(Label[0]);
            this.Controls.Remove(Picture[0]);
        }


        private void lb_option1_Click(object sender, EventArgs e)
        {
            int length =((System.Windows.Forms.Control)(sender)).Name.Length;

            string label = ((System.Windows.Forms.Control)(sender)).Name.Substring(length - 1,1);

            if (label == "1")
                sender = pictureBox1;
            else if (label == "2")
                sender = pictureBox2;
            else if (label == "3")
            {
                var pbox = new Control[1];
                pbox = this.Controls.Find("pictureBox3", true);
                sender = pbox[0];

            }
            else if (label == "4")
            {
                var pbox = new Control[1];
                pbox = this.Controls.Find("pictureBox4", true);
                sender = pbox[0];

            }
            
            
            pictureBox4_Click(sender, e);
        }

        private void bt_timer_Click(object sender, EventArgs e)
        {
            CountDown = 40;
            QuestionTimer.Start();
        }

        private void QuestionTimer_Tick(object sender, EventArgs e)
        {

            lb_time.Visible = true;
            if (!GoToNextQuestion)
            {
                if (CountDown > 10)
                {
                    lb_time.Text = (CountDown - 10).ToString();
                    IsTimeUp = false ;
                    CountDown--;
                }
                else if (CountDown <= 10 && CountDown >= 0)
                {
                    lb_time.Text = "Time Up! :( ";
                    IsTimeUp = false;
                    CountDown--;
                }
                else if (CountDown <= 0)
                {
                    IsTimeUp = true;
                    CountDown--;
                }
                else if (CountDown <= -10)
                {
                    bt_start.PerformClick();
                }
            }
            else
            {
                CountDown--;
                if (CountDown <= 0)
                {
                    GoToNextQuestion = false;
                    QuestionTimer.Stop();
                    bt_start.PerformClick();
                }
            }

        }

        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //MediaPlayer.windowlessVideo = true;
                MediaPlayer.Visible = false;
                MediaPlayer.Location = new Point(0, 0);
                MediaPlayer.Size = new System.Drawing.Size(473, 288);
                MediaPlayer.stretchToFit = false; ;
                MediaPlayer.Visible = true;
            }

            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded || MediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                //MediaPlayer.Dispose();
                //MediaPlayer.fullScreen = false;
                MediaPlayer.URL = "";
                MediaPlayer.Location = new Point(401, 218);
                MediaPlayer.Size = new System.Drawing.Size(473, 288);
                
                //MessageBox.Show("Yo");
            }
            
        }

        
        
    }
}
