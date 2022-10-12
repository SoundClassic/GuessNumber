namespace Guess_Number
{
    partial class InterfaceGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Hint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.Button();
            this.GuessNum = new System.Windows.Forms.Button();
            this.MakeNumber = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ResultGame = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ProgressGame = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Attempts = new System.Windows.Forms.TextBox();
            this.Interval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.TextBox();
            this.Sign = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AskQuestion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.level);
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.GuessNum);
            this.groupBox1.Controls.Add(this.MakeNumber);
            this.groupBox1.Controls.Add(this.NewGame);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Hint);
            this.groupBox2.Location = new System.Drawing.Point(20, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 110);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подсказка";
            // 
            // Hint
            // 
            this.Hint.AutoSize = true;
            this.Hint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hint.Location = new System.Drawing.Point(7, 34);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(50, 22);
            this.Hint.TabIndex = 0;
            this.Hint.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Уровень игры:";
            // 
            // level
            // 
            this.level.FormattingEnabled = true;
            this.level.Location = new System.Drawing.Point(198, 110);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(163, 34);
            this.level.TabIndex = 4;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(20, 449);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(341, 59);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GuessNum
            // 
            this.GuessNum.Location = new System.Drawing.Point(20, 250);
            this.GuessNum.Name = "GuessNum";
            this.GuessNum.Size = new System.Drawing.Size(341, 59);
            this.GuessNum.TabIndex = 2;
            this.GuessNum.Text = "Игра компьютера";
            this.GuessNum.UseVisualStyleBackColor = true;
            this.GuessNum.Click += new System.EventHandler(this.GuessNum_Click);
            // 
            // MakeNumber
            // 
            this.MakeNumber.Location = new System.Drawing.Point(20, 170);
            this.MakeNumber.Name = "MakeNumber";
            this.MakeNumber.Size = new System.Drawing.Size(341, 59);
            this.MakeNumber.TabIndex = 1;
            this.MakeNumber.Text = "Компьютер, загадай число";
            this.MakeNumber.UseVisualStyleBackColor = true;
            this.MakeNumber.Click += new System.EventHandler(this.MakeNumber_Click);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(20, 30);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(341, 59);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "Новая игра";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(399, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(771, 528);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вопросы и ответы";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ResultGame);
            this.groupBox6.Location = new System.Drawing.Point(419, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(334, 197);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Результат игры";
            // 
            // ResultGame
            // 
            this.ResultGame.Location = new System.Drawing.Point(17, 34);
            this.ResultGame.Multiline = true;
            this.ResultGame.Name = "ResultGame";
            this.ResultGame.ReadOnly = true;
            this.ResultGame.Size = new System.Drawing.Size(295, 145);
            this.ResultGame.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ProgressGame);
            this.groupBox5.Location = new System.Drawing.Point(20, 250);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(733, 272);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ход игры";
            // 
            // ProgressGame
            // 
            this.ProgressGame.Location = new System.Drawing.Point(24, 41);
            this.ProgressGame.Multiline = true;
            this.ProgressGame.Name = "ProgressGame";
            this.ProgressGame.ReadOnly = true;
            this.ProgressGame.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ProgressGame.Size = new System.Drawing.Size(687, 217);
            this.ProgressGame.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Attempts);
            this.groupBox4.Controls.Add(this.Interval);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Num);
            this.groupBox4.Controls.Add(this.Sign);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.AskQuestion);
            this.groupBox4.Location = new System.Drawing.Point(20, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 197);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Задать вопрос";
            // 
            // Attempts
            // 
            this.Attempts.Location = new System.Drawing.Point(284, 40);
            this.Attempts.Name = "Attempts";
            this.Attempts.ReadOnly = true;
            this.Attempts.Size = new System.Drawing.Size(66, 34);
            this.Attempts.TabIndex = 6;
            // 
            // Interval
            // 
            this.Interval.Location = new System.Drawing.Point(141, 40);
            this.Interval.Name = "Interval";
            this.Interval.ReadOnly = true;
            this.Interval.Size = new System.Drawing.Size(136, 34);
            this.Interval.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Интервал:";
            // 
            // Num
            // 
            this.Num.Enabled = false;
            this.Num.Location = new System.Drawing.Point(250, 90);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(100, 34);
            this.Num.TabIndex = 3;
            // 
            // Sign
            // 
            this.Sign.FormattingEnabled = true;
            this.Sign.Location = new System.Drawing.Point(120, 90);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(121, 34);
            this.Sign.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Число";
            // 
            // AskQuestion
            // 
            this.AskQuestion.Location = new System.Drawing.Point(24, 136);
            this.AskQuestion.Name = "AskQuestion";
            this.AskQuestion.Size = new System.Drawing.Size(330, 43);
            this.AskQuestion.TabIndex = 0;
            this.AskQuestion.Text = "Задать вопрос";
            this.AskQuestion.UseVisualStyleBackColor = true;
            this.AskQuestion.Click += new System.EventHandler(this.AskQuestion_Click);
            // 
            // InterfaceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "InterfaceGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Отгадай задуманное число\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GuessNum;
        private System.Windows.Forms.Button MakeNumber;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox level;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Hint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button AskQuestion;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox ProgressGame;
        private System.Windows.Forms.TextBox ResultGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.ComboBox Sign;
        private System.Windows.Forms.TextBox Interval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Attempts;
    }
}

