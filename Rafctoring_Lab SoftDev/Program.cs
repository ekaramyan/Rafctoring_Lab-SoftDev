using System;

namespace Rafctoring_Lab_SoftDev
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] source = { "-4", "-3", "-2", "-1", "0", "1", "2", "3", "4" };
            string destination = null;
            for (int i = 0; i < 3; i++)
                destination += source[i];
        }
    }
}
