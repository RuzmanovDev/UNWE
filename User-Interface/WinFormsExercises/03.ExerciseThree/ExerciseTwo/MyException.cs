using System;
using System.Windows.Forms;

namespace ExerciseTwo
{
    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
            MessageBox.Show("User defined exception: " + message);
        }
    }
}
