using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1

            string FullName = ("Князев Василий Иванович");
            byte Age = (32);
            string Email = ("kzvil01@mail.ru");
            double Programming_scores = (99.9);
            double Math_scores = (76);
            double Physics_scores = (84.6);
            Console.WriteLine($" ФИО: {FullName} \n Возраст: {Age} \n Email: {Email} " +
                $"\n Баллы по программированию: {Programming_scores}  " +
                $"\n Баллы по математике: {Math_scores}  " +
                $"\n Баллы по физике: {Physics_scores}");
            Console.ReadKey();


            // Задание 2

            double Score_total = (Programming_scores + Math_scores + Physics_scores);
            Console.WriteLine($" \n Всего баллов: {Score_total}");
            Console.ReadKey();
            double Arithmetic_mean = (Score_total / 3);
            string A_mean = Arithmetic_mean.ToString("#.#");
            Console.WriteLine($" Средний балл: {A_mean}");
            Console.ReadKey();

        }
    }
}
