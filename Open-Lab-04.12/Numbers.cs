using System;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] numbers)
        {
            int v = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                v = v ^ numbers[i];
            }
            return v;
        }
    }
}
