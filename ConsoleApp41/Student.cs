using System;

namespace ConsoleApp41
{
    class Student
    {
        private int[] _grade;
        public int[] Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                int counter = 0;
                int[] _grade = new int[value.Length - counter];
                for (int i = 0, j = 0; i < value.Length; i++)
                {
                    if (value[i] % 2 == 0)
                    {
                        _grade[j] = value[i];
                        j++;
                        Console.WriteLine(_grade[j - 1]);
                    }
                    else
                    {
                        counter++;
                    }
                }
            }
        }
   }
}
