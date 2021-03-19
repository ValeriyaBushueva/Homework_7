namespace Homework_7
{
    public partial class FormTask
    {
        private Doubler doubler;

        private void MakeNumberGame_Start()
        {
            doubler = new Doubler();
        }

        private void MakeNumberGame_AddOne()
        {
            doubler.AddOne();
            Update();
        }

        private void MakeNumberGame_MultiplyBy2()
        {
            doubler.Multiply2();
            Update();
        }
        
        // private void MakeNumberGame_Reset()
        // {
        //     doubler.Multiply2();
        //     Update();
        // }
        //
        // private void MakeNumberGame_Reset()
        // {
        //     doubler.Multiply2();
        //     Update();
        // }
    }
}