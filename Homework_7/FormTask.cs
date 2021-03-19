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
            Task1_AddOneButton.Text = "+1";
            Task1_Multiply2Button.Text = "x2";
            Task1_CurrentNumberLabel.Text = "0";
            Task1_ResetButton.Text = "Сброс";
            this.Text = "Удвоитель";
            Task1_TargetLabel.Visible = false;
            lblGoalText.Visible = false;
            Task1_StepsCountLabel.Text = "0";
            groupBox1.Hide();
            MakeNumberGame_Start();
            
            // Task 2
            GuessNumberGame_Start();
        }

        

        //Обновление формы
        public void Update()
        {
            Task1_CurrentNumberLabel.Text = doubler.Value.ToString();
            Task1_StepsCountLabel.Text = doubler.Steps.ToString();
            this.Refresh();
            if (Task1_TargetLabel.Visible)
                if (doubler.CheckGoal())
                {
                    MessageBox.Show($"Поздравляем, вы достигли заданного числа за {doubler.Steps} ходов");
                    Task1_TargetLabel.Visible = false;
                    lblGoalText.Visible = false;
                    doubler.Reset();
                }

        }

        //Увеличение текущего значения на единицу
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            MakeNumberGame_AddOne();
        }

        //Увеличение текущего значения вдвое
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            MakeNumberGame_MultiplyBy2();
        }

        //Сброс текущего значения и счётчика
        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        //Начинает игру
        private void menuStart_Click(object sender, EventArgs e)
        {
            doubler.GetGoal();
            groupBox1.Show();
            MessageBox.Show($"Получите значение: {doubler.Goal}");
            Task1_TargetLabel.Visible = true;
            lblGoalText.Visible = true;
            Task1_TargetLabel.Text = doubler.Goal.ToString();
            doubler.Reset();
            Update();
        }

        //Прекращает игру
        private void menuStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("СТОП ИГРА!");
            groupBox1.Hide();
            Task1_TargetLabel.Visible = false;
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

