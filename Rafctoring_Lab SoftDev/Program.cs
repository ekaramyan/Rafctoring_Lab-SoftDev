using System;

namespace Rafctoring_Lab_SoftDev
{
    class Program

    {
        static void Main(string[] args)

        {
            Console.WriteLine("Задание №1"); // Начало первого задания

            Console.WriteLine("Введите число с минимум одним числом после ЗАПЯТОЙ");


            Decimal varib = Convert.ToDecimal(Console.ReadLine());
            int zn = (int)((varib - (int)varib) * 10); // основная формула


            Console.WriteLine($"Искомое число : {zn}"); // Конец первого задания




            Console.WriteLine("\n\nЗадание №2");                                // Начало второго задания

            int hours, minutes;

            Console.WriteLine("Сколько прошло секунд? : ");
            int sec = Convert.ToInt32(Console.ReadLine());

            hours = (sec / (60 * 60));
            minutes = (sec - hours * 60 * 60) / 60;                                        //часы перевести в секунды и результат разделить на 60(для перевода из секунд в минуты)


            Console.WriteLine($"Прошло {hours} часа (ов) , {minutes} минут(ы)");
            // Конец второго задания





            Console.WriteLine("\n\nЗадание №3");                                // Начало третьего задания

            double corner;
            Console.WriteLine("Введите количество часов (желательно от 0 до 11) : ");
            int time_hours = Convert.ToInt32(Console.ReadLine());
            if (time_hours <= 11)
            {
            }
            else if (time_hours > 11)
            {
                Console.WriteLine("Слишком большое значение");
                Environment.Exit(0);
            }
            else if (time_hours < 0)
            {
                Console.WriteLine("Слишком маленькое значение");
                Environment.Exit(0);
            }
            else { Console.WriteLine("Буквы Нельзя!!!"); }

            Console.WriteLine("Введите количество минут (желательно от 0 до 59) : ");
            int time_minutes = Convert.ToInt32(Console.ReadLine());
            if (time_minutes <= 59)
            {
            }
            else if (time_minutes > 59)
            {
                Console.WriteLine("Слишком большое значение");
                Environment.Exit(0);
            }
            else if (time_minutes < 0)
            {
                Console.WriteLine("Слишком маленькое значение");
                Environment.Exit(0);
            }
            else { Console.WriteLine("Буквы Нельзя!!!"); }

            Console.WriteLine("Введите количество секунд (желательно от 0 до 59) : ");
            int time_seconds = Convert.ToInt32(Console.ReadLine());
            if (time_seconds <= 59)
            {
            }
            else if (time_seconds > 59)
            {
                Console.WriteLine("Слишком большое значение");
                Environment.Exit(0);
            }
            else if (time_seconds < 0)
            {
                Console.WriteLine("Слишком маленькое значение");
                Environment.Exit(0);
            }
            else { Console.WriteLine("Буквы Нельзя!!!"); }

            corner = (time_seconds + (time_minutes * 60) + (time_hours * 3600)) * 0.0083333;                                           // Расчет градусной меры угла, 0.008(333) количество градусов на секунду



            Console.WriteLine($"Угол между начальным и текущим положениями часовой стрелки равен {corner}\"");                     // Вывод градусной меры угла
                                                                                                                                   // Конец третьего задания








            Console.WriteLine("\n\nЗадание №4");                                // Начало четвертого задания

            Console.WriteLine("Введите значение первой переменной : ");
            int varib_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение второй переменной : ");
            int varib_2 = Convert.ToInt32(Console.ReadLine());


            varib_2 = varib_1 + varib_2;                                    // Работа с переменными
            varib_1 = varib_2 - varib_1;
            varib_2 = varib_2 - varib_1;


            Console.WriteLine($"Совершаем обмен значениями и получаем :" +
                $" \nпервая переменная: {varib_1};" +
                $" \nвторая переменная: {varib_2}");
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

            int thousands = num / 1000;                                   // Формулы для нахождения тысяч, сотен, десятков и единиц в числе
            int hundreds = num / 100 - thousands * 10;
            int dozens = num / 10 - thousands * 100 - hundreds * 10;
            int units = num - thousands * 1000 - hundreds * 100 - dozens * 10;

            int compos = thousands * hundreds * dozens * units;
            Console.WriteLine($"Произведение цифр в нем = {compos}");
            // Конец шестого задания

        }
    }
}