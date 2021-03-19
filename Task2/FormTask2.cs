using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework_7;

namespace Task2
{
    public partial class FormTask2 : Form
    {
        randNumber rnum;
        int max;

        public FormTask2()
        {
            InitializeComponent();
            max = 100;
            rnum = new randNumber(max);
            // btnCheck.Text = "Проверить";
            // this.Text = "Угадай число";
            // lblStepCount.Text = "0";
            // tboxUserAnswer.Text = $"Введите число от 0 до {max}:";
            // lblStepText.Text = "Счёт ходов:";
            // MessageBox.Show("Вводите в поле число пока не угадаете. Нажимайте кнопку \"Проверить\" " +
            //                 "чтобы узнать результат попытки. ", "Правила");
            //
            // tboxUserAnswer.Visible = false;
            // f2 = new Form2();
            // f2.Show();

        }

        private void btnCheck_Click(object sender, EventArgs e)
            {
               //  bool check;
               // //MessageBox.Show(rnum.CheckValue(out check, int.Parse(tboxUserAnswer.Text)));
               //  if (check)
               //  {
               //      rnum.Reset(max);
               //      MessageBox.Show($"Игра началась заново.\nВведите число от 0 до {max}:");
               //  }
               //  Update1();
            }

            void Update1()
            {
                //lblStepCount.Text = rnum.Steps.ToString();
                this.Refresh();
            }
        
    }
}