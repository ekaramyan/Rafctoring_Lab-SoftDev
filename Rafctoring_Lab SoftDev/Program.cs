using System;

namespace Rafctoring_Lab_SoftDev
{
    class Program

    {
        static void Main(string[] args)

        {
            Console.WriteLine("Задание №1"); // Начало первого задания

            Console.WriteLine("Введите число с минимум одним числом после ЗАПЯТОЙ");
            double double_x = Convert.ToDouble(Console.ReadLine());
            int x = (int)((double_x - (int)double_x) * 10);
            Console.WriteLine(x); // основная формула

            Console.WriteLine($"Искомое число : {x}"); // Конец первого задания




            Console.WriteLine("\n\nЗадание №2");                                // Начало второго задания

            Console.WriteLine("Сколько прошло секунд? : ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            int hours = seconds / 3600;
            int minutes = seconds / 60 - 60 * hours;                                    //часы перевести в секунды и результат разделить на 60(для перевода из секунд в минуты)

            Console.WriteLine($"Прошло {hours} часа (ов) , {minutes} минут(ы)");
            // Конец второго задания





            Console.WriteLine("\n\nЗадание №3");                                // Начало третьего задания

            double corner;
            Console.WriteLine("Введите количество часов (желательно от 0 до 11) : ");
            int time_hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество минут (желательно от 0 до 59) : ");
            int time_minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество секунд (желательно от 0 до 59) : ");
            int time_seconds = Convert.ToInt32(Console.ReadLine());

            corner = (time_seconds + (time_minutes * 60) + (time_hours * 3600)) * 0.0083333;                                           // Расчет градусной меры угла, 0.008(333) количество градусов на секунду



            Console.WriteLine($"Угол между начальным и текущим положениями часовой стрелки равен {corner}\"");                     // Вывод градусной меры угла
                                                                                                                                   // Конец третьего задания








            Console.WriteLine("\n\nЗадание №4");                                // Начало четвертого задания

            Console.WriteLine("Введите значение первой переменной : ");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение второй переменной : ");
            int var2 = Convert.ToInt32(Console.ReadLine());

            var2 = var1 + var2;                                    // Работа с переменными
            var1 = var2 - var1;
            var2 = var2 - var1;

            Console.WriteLine($"Совершаем обмен значениями и получаем :" +
                $" \nпервая переменная: {var1};" +
                $" \nвторая переменная: {var2}");
            // Конец четвертого задания 






            Console.WriteLine("\n\nЗадание №5");                                // Начало пятого задания

            Console.WriteLine("Длина катета номер 1 : ");
            int kat_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длина катета номер 2 : ");
            int kat_2 = Convert.ToInt32(Console.ReadLine());
            int Gipotenuza = (int)(Math.Sqrt((kat_1 * kat_1) + (kat_2 * kat_2)));

            double Space = (kat_1 * kat_2) / 2;                                                 // Расчет площади и периметра
            int Perimeter = (int)(kat_1 + kat_2 + Gipotenuza);

            Console.WriteLine($"S = {Space}, P = {Perimeter}\n\n");
            // Конец 5 задания  





            Console.WriteLine("Задание №6");                                // Начало шестого задания

            Console.WriteLine("Введите четырехзначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = (num % 10 + (num % 100) / 10 + (num % 1000 - num % 100) / 100 + (num - num % 1000) / 1000);
            Console.WriteLine($"Произведение цифр в нем = {result}");
            // Конец шестого задания

        }
    }
}