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
            this.Task1_ResetButton = new System.Windows.Forms.Button();
            this.Task1_Multiply2Button = new System.Windows.Forms.Button();
            this.Task1_AddOneButton = new System.Windows.Forms.Button();
            this.Task1_CurrentNumberLabel = new System.Windows.Forms.Label();
            this.Task1_TargetLabel = new System.Windows.Forms.Label();
            this.lblGoalText = new System.Windows.Forms.Label();
            this.Task1_StepsCountLabel = new System.Windows.Forms.Label();
            this.Task1_StartButton = new System.Windows.Forms.Button();
            this.Task1_StopButton = new System.Windows.Forms.Button();
            this.Task1_CancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStepText = new System.Windows.Forms.Label();
            this.Task2_TextBox = new System.Windows.Forms.TextBox();
            this.lblStepCount = new System.Windows.Forms.Label();
            this.Task2_CheckButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Task1_ResetButton
            // 
            this.Task1_ResetButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.Task1_ResetButton.Location = new System.Drawing.Point(91, 25);
            this.Task1_ResetButton.Name = "Task1_ResetButton";
            this.Task1_ResetButton.Size = new System.Drawing.Size(83, 27);
            this.Task1_ResetButton.TabIndex = 0;
            this.Task1_ResetButton.Text = "Сброс";
            this.Task1_ResetButton.UseVisualStyleBackColor = false;
            this.Task1_ResetButton.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Task1_Multiply2Button
            // 
            this.Task1_Multiply2Button.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.Task1_Multiply2Button.Location = new System.Drawing.Point(2, 25);
            this.Task1_Multiply2Button.Name = "Task1_Multiply2Button";
            this.Task1_Multiply2Button.Size = new System.Drawing.Size(83, 26);
            this.Task1_Multiply2Button.TabIndex = 1;
            this.Task1_Multiply2Button.Text = "*2\r\n";
            this.Task1_Multiply2Button.UseVisualStyleBackColor = false;
            this.Task1_Multiply2Button.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // Task1_AddOneButton
            // 
            this.Task1_AddOneButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.Task1_AddOneButton.Location = new System.Drawing.Point(180, 24);
            this.Task1_AddOneButton.Name = "Task1_AddOneButton";
            this.Task1_AddOneButton.Size = new System.Drawing.Size(83, 29);
            this.Task1_AddOneButton.TabIndex = 2;
            this.Task1_AddOneButton.Text = "+1";
            this.Task1_AddOneButton.UseVisualStyleBackColor = false;
            this.Task1_AddOneButton.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // Task1_CurrentNumberLabel
            // 
            this.Task1_CurrentNumberLabel.Location = new System.Drawing.Point(138, 89);
            this.Task1_CurrentNumberLabel.Name = "Task1_CurrentNumberLabel";
            this.Task1_CurrentNumberLabel.Size = new System.Drawing.Size(47, 16);
            this.Task1_CurrentNumberLabel.TabIndex = 3;
            this.Task1_CurrentNumberLabel.Text = "0";
            // 
            // Task1_TargetLabel
            // 
            this.Task1_TargetLabel.Location = new System.Drawing.Point(121, 62);
            this.Task1_TargetLabel.Name = "Task1_TargetLabel";
            this.Task1_TargetLabel.Size = new System.Drawing.Size(62, 27);
            this.Task1_TargetLabel.TabIndex = 4;
            this.Task1_TargetLabel.Text = "Цель";
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
            // Task1_StepsCountLabel
            // 
            this.Task1_StepsCountLabel.Location = new System.Drawing.Point(138, 113);
            this.Task1_StepsCountLabel.Name = "Task1_StepsCountLabel";
            this.Task1_StepsCountLabel.Size = new System.Drawing.Size(45, 14);
            this.Task1_StepsCountLabel.TabIndex = 6;
            this.Task1_StepsCountLabel.Text = "0";
            // 
            // Task1_StartButton
            // 
            this.Task1_StartButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.Task1_StartButton.Location = new System.Drawing.Point(3, 0);
            this.Task1_StartButton.Name = "Task1_StartButton";
            this.Task1_StartButton.Size = new System.Drawing.Size(76, 25);
            this.Task1_StartButton.TabIndex = 8;
            this.Task1_StartButton.Text = "Старт";
            this.Task1_StartButton.UseVisualStyleBackColor = false;
            this.Task1_StartButton.Click += new System.EventHandler(this.menuStart_Click);
            // 
            // Task1_StopButton
            // 
            this.Task1_StopButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.Task1_StopButton.Location = new System.Drawing.Point(93, -1);
            this.Task1_StopButton.Name = "Task1_StopButton";
            this.Task1_StopButton.Size = new System.Drawing.Size(76, 27);
            this.Task1_StopButton.TabIndex = 9;
            this.Task1_StopButton.Text = "Стоп";
            this.Task1_StopButton.UseVisualStyleBackColor = false;
            this.Task1_StopButton.Click += new System.EventHandler(this.menuStop_Click);
            // 
            // Task1_CancelButton
            // 
            this.Task1_CancelButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.Task1_CancelButton.Location = new System.Drawing.Point(182, -1);
            this.Task1_CancelButton.Name = "Task1_CancelButton";
            this.Task1_CancelButton.Size = new System.Drawing.Size(106, 26);
            this.Task1_CancelButton.TabIndex = 10;
            this.Task1_CancelButton.Text = "Отменить шаг";
            this.Task1_CancelButton.UseVisualStyleBackColor = false;
            this.Task1_CancelButton.Click += new System.EventHandler(this.menuCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Task1_CancelButton);
            this.panel1.Controls.Add(this.Task1_StopButton);
            this.panel1.Controls.Add(this.Task1_StartButton);
            this.panel1.Location = new System.Drawing.Point(97, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 177);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.Task1_Multiply2Button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Task1_ResetButton);
            this.groupBox1.Controls.Add(this.Task1_AddOneButton);
            this.groupBox1.Controls.Add(this.Task1_CurrentNumberLabel);
            this.groupBox1.Controls.Add(this.Task1_TargetLabel);
            this.groupBox1.Controls.Add(this.Task1_StepsCountLabel);
            this.groupBox1.Controls.Add(this.lblGoalText);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 138);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущая игра";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Шаги:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Текущая цифра:";
            this.label1.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStepText);
            this.panel2.Controls.Add(this.Task2_TextBox);
            this.panel2.Controls.Add(this.lblStepCount);
            this.panel2.Controls.Add(this.Task2_CheckButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(97, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 93);
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
            // Task2_TextBox
            // 
            this.Task2_TextBox.Location = new System.Drawing.Point(6, 29);
            this.Task2_TextBox.Name = "Task2_TextBox";
            this.Task2_TextBox.Size = new System.Drawing.Size(79, 20);
            this.Task2_TextBox.TabIndex = 3;
            // 
            // lblStepCount
            // 
            this.lblStepCount.Location = new System.Drawing.Point(99, 27);
            this.lblStepCount.Name = "lblStepCount";
            this.lblStepCount.Size = new System.Drawing.Size(98, 22);
            this.lblStepCount.TabIndex = 2;
            this.lblStepCount.Text = "0";
            // 
            // Task2_CheckButton
            // 
            this.Task2_CheckButton.Location = new System.Drawing.Point(3, 55);
            this.Task2_CheckButton.Name = "Task2_CheckButton";
            this.Task2_CheckButton.Size = new System.Drawing.Size(93, 28);
            this.Task2_CheckButton.TabIndex = 1;
            this.Task2_CheckButton.Text = "Проверить!";
            this.Task2_CheckButton.UseVisualStyleBackColor = true;
            this.Task2_CheckButton.Click += new System.EventHandler(this.btnCheck_Click);
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
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(395, 331);
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

        private System.Windows.Forms.TextBox Task2_TextBox;

        private System.Windows.Forms.Label lblStepCount;

        private System.Windows.Forms.Button Task2_CheckButton;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button Task1_AddOneButton;
        private System.Windows.Forms.Button Task1_Multiply2Button;
        private System.Windows.Forms.Button Task1_ResetButton;
        private System.Windows.Forms.Label Task1_TargetLabel;
        private System.Windows.Forms.Label lblGoalText;
        private System.Windows.Forms.Label Task1_CurrentNumberLabel;
        private System.Windows.Forms.Label Task1_StepsCountLabel;
        private System.Windows.Forms.Button Task1_CancelButton;
        private System.Windows.Forms.Button Task1_StartButton;
        private System.Windows.Forms.Button Task1_StopButton;
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button Menu;

        #endregion
    }
}