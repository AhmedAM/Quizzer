namespace Quizzer
{
    partial class ButtonsForm
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
            this.bt_quiz = new System.Windows.Forms.Button();
            this.bt_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_quiz
            // 
            this.bt_quiz.Location = new System.Drawing.Point(71, 102);
            this.bt_quiz.Name = "bt_quiz";
            this.bt_quiz.Size = new System.Drawing.Size(275, 223);
            this.bt_quiz.TabIndex = 0;
            this.bt_quiz.Text = "Quiz";
            this.bt_quiz.UseVisualStyleBackColor = true;
            this.bt_quiz.Click += new System.EventHandler(this.bt_quiz_Click);
            // 
            // bt_settings
            // 
            this.bt_settings.Location = new System.Drawing.Point(480, 102);
            this.bt_settings.Name = "bt_settings";
            this.bt_settings.Size = new System.Drawing.Size(275, 223);
            this.bt_settings.TabIndex = 0;
            this.bt_settings.Text = "Settings";
            this.bt_settings.UseVisualStyleBackColor = true;
            this.bt_settings.Click += new System.EventHandler(this.bt_settings_Click);
            // 
            // ButtonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 438);
            this.Controls.Add(this.bt_settings);
            this.Controls.Add(this.bt_quiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ButtonsForm";
            this.Text = "ButtonsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_quiz;
        private System.Windows.Forms.Button bt_settings;
    }
}