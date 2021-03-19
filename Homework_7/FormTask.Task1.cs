using System;
using System.Windows.Forms;

namespace Homework_7
{
    public partial class FormTask
    {
        private Doubler doublerGameCore;

        private void MakeNumberGame_Start()
        {
            doublerGameCore = new Doubler();
        }

        private void Task1_StartButton_Click(object sender, EventArgs e)
        {
            doublerGameCore.GetGoal();                                    
            groupBox1.Show();                                     
            MessageBox.Show($"Получите значение: {doublerGameCore.Goal}");
            Task1_TargetLabel.Visible = true;                     
            lblGoalText.Visible = true;                           
            Task1_TargetLabel.Text = doublerGameCore.Goal.ToString();     
            doublerGameCore.Reset();                                      
            Task1_UpdateGame();     
        }

        private void Task1_StopButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("СТОП ИГРА!");     
            groupBox1.Hide();                  
            Task1_TargetLabel.Visible = false; 
            lblGoalText.Visible = false;       
        }

        private void Task1_CancelButton_Click(object sender, EventArgs e)
        {
            doublerGameCore.CheckStack();
            Task1_UpdateGame();
        }

        private void Task1_AddOneButton_Click(object sender, EventArgs e)
        {
            doublerGameCore.AddOne();
            Task1_UpdateGame();
        }
        
        private void Task1_Multiply2Button_Click(object sender, EventArgs e)
        {
            doublerGameCore.Multiply2();
            Task1_UpdateGame();
        }

        private void Task1_ResetButton_Click(object sender, EventArgs e)
        {
            doublerGameCore.Reset();
            Task1_UpdateGame();
        }
        
        public void Task1_UpdateGame()
        {
            Task1_CurrentNumberLabel.Text = doublerGameCore.Value.ToString();
            Task1_StepsCountLabel.Text = doublerGameCore.Steps.ToString();
            this.Refresh();
            if (Task1_TargetLabel.Visible)
                if (doublerGameCore.CheckGoal())
                {
                    MessageBox.Show($"Поздравляем, вы достигли заданного числа за {doublerGameCore.Steps} ходов");
                    Task1_TargetLabel.Visible = false;
                    lblGoalText.Visible = false;
                    doublerGameCore.Reset();
                }
        }
    }
}