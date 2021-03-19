using System;
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

    public partial class FormTask : Form
    {
       
       //Task2
       
        public FormTask()
        {
            //Task1
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            lblNumber.Text = "0";
            btnReset.Text = "Сброс";
            this.Text = "Удвоитель";
            lblGoal.Visible = false;
            lblGoalText.Visible = false;
            lblStepsCount.Text = "0";
            groupBox1.Hide();
            MakeNumberGame_Start();
            
            // Task 2
            GuessNumberGame_Start();
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
            doubler.AddOne();
            Update();
        }

        //Увеличение текущего значения вдвое
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            doubler.Multiply2();
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
            groupBox1.Show();
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
            groupBox1.Hide();
            lblGoal.Visible = false;
            lblGoalText.Visible = false;
        }

        //Отменяет последнее действие, кроме сброса
       
        private void menuCancel_Click(object sender, EventArgs e)
        {
            doubler.CheckStack();
            

            Update();
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}

