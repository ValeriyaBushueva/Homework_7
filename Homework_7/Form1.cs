﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace Homework_7
{

    public partial class Form1 : Form
    {
       Doubler doubler;
        public Form1()
        {
            doubler = new Doubler();
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            lblNumber.Text = "0";
            btnReset.Text = "Сброс";
            this.Text = "Удвоитель";
            lblGoal.Visible = false;
            lblGoalText.Visible = false;
            lblStepsCount.Text = "0";
        }

        //Обновление формы
        public void Update()
        {
            lblNumber.Text = doubler.Value.ToString();
            lblStepsCount.Text = doubler.Steps.ToString();
            this.Refresh();
            if (lblGoal.Visible)
                if (doubler.CheckGoal())
                {
                    MessageBox.Show($"Поздравляем, вы достигли заданного числа за {doubler.Steps} ходов");
                    lblGoal.Visible = false;
                    lblGoalText.Visible = false;
                    doubler.Reset();
                }

        }

        //Увеличение текущего значения на единицу
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            doubler.Increment();
            Update();
        }

        //Увеличение текущего значения вдвое
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            doubler.Double();
            Update();
        }

        //Сброс текущего значения и счётчика
        private void btnReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            Update();
        }

        //Начинает игру
        private void menuStart_Click(object sender, EventArgs e)
        {
            doubler.GetGoal();
            MessageBox.Show($"Получите значение: {doubler.Goal}");
            lblGoal.Visible = true;
            lblGoalText.Visible = true;
            lblGoal.Text = doubler.Goal.ToString();
            doubler.Reset();
            Update();
        }

        //Прекращает игру
        private void menuStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("СТОП ИГРА!");
            lblGoal.Visible = false;
            lblGoalText.Visible = false;
        }

        //Отменяет последнее действие, кроме сброса
       
        private void menuCancel_Click(object sender, EventArgs e)
        {
            doubler.CheckStack();
            

            Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void lblGoal_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}

