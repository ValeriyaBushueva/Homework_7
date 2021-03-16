namespace Homework_7
{
    partial class Form1
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
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.lblNumber.Location = new System.Drawing.Point(122, 90);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 38);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            // 
            // lblGoal
            // 
            this.lblGoal.Location = new System.Drawing.Point(105, 63);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(62, 27);
            this.lblGoal.TabIndex = 4;
            this.lblGoal.Text = "Цель";
            this.lblGoal.Click += new System.EventHandler(this.lblGoal_Click);
            // 
            // lblGoalText
            // 
            this.lblGoalText.Location = new System.Drawing.Point(3, 63);
            this.lblGoalText.Name = "lblGoalText";
            this.lblGoalText.Size = new System.Drawing.Size(96, 27);
            this.lblGoalText.TabIndex = 5;
            this.lblGoalText.Text = "Победная цифра:";
            this.lblGoalText.UseMnemonic = false;
            // 
            // lblStepsCount
            // 
            this.lblStepsCount.Location = new System.Drawing.Point(114, 128);
            this.lblStepsCount.Name = "lblStepsCount";
            this.lblStepsCount.Size = new System.Drawing.Size(45, 22);
            this.lblStepsCount.TabIndex = 6;
            this.lblStepsCount.Text = "0";
            this.lblStepsCount.Click += new System.EventHandler(this.label3_Click);
            // 
            // menu_start
            // 
            this.menu_start.Location = new System.Drawing.Point(3, 0);
            this.menu_start.Name = "menu_start";
            this.menu_start.Size = new System.Drawing.Size(76, 25);
            this.menu_start.TabIndex = 8;
            this.menu_start.Text = "Старт";
            this.menu_start.UseVisualStyleBackColor = true;
            this.menu_start.Click += new System.EventHandler(this.menuStart_Click);
            // 
            // menu_stop
            // 
            this.menu_stop.Location = new System.Drawing.Point(93, -1);
            this.menu_stop.Name = "menu_stop";
            this.menu_stop.Size = new System.Drawing.Size(76, 27);
            this.menu_stop.TabIndex = 9;
            this.menu_stop.Text = "Стоп";
            this.menu_stop.UseVisualStyleBackColor = true;
            this.menu_stop.Click += new System.EventHandler(this.menuStop_Click);
            // 
            // menu_cancel
            // 
            this.menu_cancel.Location = new System.Drawing.Point(182, -1);
            this.menu_cancel.Name = "menu_cancel";
            this.menu_cancel.Size = new System.Drawing.Size(106, 26);
            this.menu_cancel.TabIndex = 10;
            this.menu_cancel.Text = "Отменить шаг";
            this.menu_cancel.UseVisualStyleBackColor = true;
            this.menu_cancel.Click += new System.EventHandler(this.menuCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menu_cancel);
            this.panel1.Controls.Add(this.menu_stop);
            this.panel1.Controls.Add(this.menu_start);
            this.panel1.Controls.Add(this.lblStepsCount);
            this.panel1.Controls.Add(this.lblGoalText);
            this.panel1.Controls.Add(this.lblGoal);
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 324);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.btnCommand2);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnCommand1);
            this.groupBox1.Location = new System.Drawing.Point(243, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 64);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Шаги:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Текущая цифра:";
            this.label1.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

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