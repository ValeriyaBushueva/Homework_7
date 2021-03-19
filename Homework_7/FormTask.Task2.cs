using System;
using System.Windows.Forms;

namespace Homework_7
{
    public partial class FormTask
    {
        private GuessNumber guessNumber;

        private string task2Text;
        
        private void GuessNumberGame_Start()
        {
            guessNumber = new GuessNumber(100);
        }
        
        private void Task2_TextBox_TextChanged(object sender, EventArgs e)
        {
            task2Text = ((TextBox) sender).Text;
        }

        private void Task2_CheckButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(task2Text, out int result))
            {
                MessageBox.Show("Вы ввели что-то непохожее на число! Введите число!");
                return;
            }

            MessageBox.Show(guessNumber.CheckValue(out bool checkResult, result));

            if (checkResult)
            {
                guessNumber.Reset(100);
            }
            else
            {
                Task2_SepsLabel.Text = guessNumber.Steps.ToString();
                this.Refresh();
            }
        }
    }
}