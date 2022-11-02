using System;

namespace MindsetCalculator.Utilities
{
    class Utils
    {
        public bool Contains<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                T v = array[i];
                if (v!.Equals(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}