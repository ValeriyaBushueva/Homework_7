namespace Homework_7
{
    partial class FormTask
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblGoalText = new System.Windows.Forms.Label();
            this.lblStepsCount = new System.Windows.Forms.Label();
            this.menu_start = new System.Windows.Forms.Button();
            this.menu_stop = new System.Windows.Forms.Button();
            this.menu_cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStepText = new System.Windows.Forms.Label();
            this.tboxUserAnswer = new System.Windows.Forms.TextBox();
            this.lblStepCount = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.btnReset.Location = new System.Drawing.Point(91, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 27);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.btnCommand2.Location = new System.Drawing.Point(2, 25);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(83, 26);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "*2\r\n";
            this.btnCommand2.UseVisualStyleBackColor = false;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnCommand1
            // 
            this.btnCommand1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.btnCommand1.Location = new System.Drawing.Point(180, 24);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(83, 29);
            this.btnCommand1.TabIndex = 2;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = false;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(138, 89);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 38);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            // 
            // lblGoal
            // 
            this.lblGoal.Location = new System.Drawing.Point(121, 62);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(62, 27);
            this.lblGoal.TabIndex = 4;
            this.lblGoal.Text = "Цель";
            // 
            // lblGoalText
            // 
            this.lblGoalText.Location = new System.Drawing.Point(19, 62);
            this.lblGoalText.Name = "lblGoalText";
            this.lblGoalText.Size = new System.Drawing.Size(96, 27);
            this.lblGoalText.TabIndex = 5;
            this.lblGoalText.Text = "Победная цифра:";
            this.lblGoalText.UseMnemonic = false;
            // 
            // lblStepsCount
            // 
            this.lblStepsCount.Location = new System.Drawing.Point(130, 127);
            this.lblStepsCount.Name = "lblStepsCount";
            this.lblStepsCount.Size = new System.Drawing.Size(45, 22);
            this.lblStepsCount.TabIndex = 6;
            this.lblStepsCount.Text = "0";
            // 
            // menu_start
            // 
            this.menu_start.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.menu_start.Location = new System.Drawing.Point(3, 0);
            this.menu_start.Name = "menu_start";
            this.menu_start.Size = new System.Drawing.Size(76, 25);
            this.menu_start.TabIndex = 8;
            this.menu_start.Text = "Старт";
            this.menu_start.UseVisualStyleBackColor = false;
            this.menu_start.Click += new System.EventHandler(this.menuStart_Click);
            // 
            // menu_stop
            // 
            this.menu_stop.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.menu_stop.Location = new System.Drawing.Point(93, -1);
            this.menu_stop.Name = "menu_stop";
            this.menu_stop.Size = new System.Drawing.Size(76, 27);
            this.menu_stop.TabIndex = 9;
            this.menu_stop.Text = "Стоп";
            this.menu_stop.UseVisualStyleBackColor = false;
            this.menu_stop.Click += new System.EventHandler(this.menuStop_Click);
            // 
            // menu_cancel
            // 
            this.menu_cancel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.menu_cancel.Location = new System.Drawing.Point(182, -1);
            this.menu_cancel.Name = "menu_cancel";
            this.menu_cancel.Size = new System.Drawing.Size(106, 26);
            this.menu_cancel.TabIndex = 10;
            this.menu_cancel.Text = "Отменить шаг";
            this.menu_cancel.UseVisualStyleBackColor = false;
            this.menu_cancel.Click += new System.EventHandler(this.menuCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.menu_cancel);
            this.panel1.Controls.Add(this.menu_stop);
            this.panel1.Controls.Add(this.menu_start);
            this.panel1.Location = new System.Drawing.Point(97, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 213);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.btnCommand2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnCommand1);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.lblGoal);
            this.groupBox1.Controls.Add(this.lblStepsCount);
            this.groupBox1.Controls.Add(this.lblGoalText);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 167);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущая игра";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Шаги:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Текущая цифра:";
            this.label1.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStepText);
            this.panel2.Controls.Add(this.tboxUserAnswer);
            this.panel2.Controls.Add(this.lblStepCount);
            this.panel2.Controls.Add(this.btnCheck);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(97, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 93);
            this.panel2.TabIndex = 8;
            // 
            // lblStepText
            // 
            this.lblStepText.Location = new System.Drawing.Point(99, 9);
            this.lblStepText.Name = "lblStepText";
            this.lblStepText.Size = new System.Drawing.Size(89, 18);
            this.lblStepText.TabIndex = 4;
            this.lblStepText.Text = "Счет ходов:";
            // 
            // tboxUserAnswer
            // 
            this.tboxUserAnswer.Location = new System.Drawing.Point(6, 29);
            this.tboxUserAnswer.Name = "tboxUserAnswer";
            this.tboxUserAnswer.Size = new System.Drawing.Size(79, 20);
            this.tboxUserAnswer.TabIndex = 3;
            // 
            // lblStepCount
            // 
            this.lblStepCount.Location = new System.Drawing.Point(99, 27);
            this.lblStepCount.Name = "lblStepCount";
            this.lblStepCount.Size = new System.Drawing.Size(98, 22);
            this.lblStepCount.TabIndex = 2;
            this.lblStepCount.Text = "0";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(3, 55);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(93, 28);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Проверить!";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Угадай число!";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "TASK 1:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(7, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "TASK 2:";
            // 
            // FormTask1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(502, 331);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FormTask";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label lblStepText;

        private System.Windows.Forms.TextBox tboxUserAnswer;

        private System.Windows.Forms.Label lblStepCount;

        private System.Windows.Forms.Button btnCheck;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblGoalText;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblStepsCount;
        private System.Windows.Forms.Button menu_cancel;
        private System.Windows.Forms.Button menu_start;
        private System.Windows.Forms.Button menu_stop;
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button Menu;

        #endregion
    }
}