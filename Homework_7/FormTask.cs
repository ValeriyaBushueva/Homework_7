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


        
    }
}

