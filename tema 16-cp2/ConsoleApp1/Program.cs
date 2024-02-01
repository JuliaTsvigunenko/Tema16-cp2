using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1.Ввести две даты и определить количество дней между ними.

            ////сначала вводим 1ую дату
            //Console.Write("Введите первую дату: ");
            //DateTime oneDate = DateTime.Parse(Console.ReadLine());

            ////потом вводим 2ую дату
            //Console.Write("Введите вторую дату: ");
            //DateTime twoDate = DateTime.Parse(Console.ReadLine());

            //// Мы высчитываем разницу (Difference)
            //// TimeSpan используется для представления временной разницы между этими датами. Когда мы вычитаем одну дату из другой
            //TimeSpan timeDifference = oneDate - twoDate;

            //Console.WriteLine($"Количество дней между датами: {timeDifference.Days}");


            ////2.Определить, сколько дней осталось до конца месяца.

            //Console.WriteLine($"До конца месяца осталось: {DateTime.DaysInMonth(oneDate.Year, oneDate.Month) - oneDate.Day} дней");



            //3.Ввести свою дату рождения.
            DateTime birthday = new DateTime(2006, 05, 19);

            // Определить:


            // a). день недели, в котором вы родились;

            Console.WriteLine($"День недели, в котором родился человек: {birthday.DayOfWeek}");


            //b). порядковый номер дня рождения в году;

            // Получаем порядковый номер дня в году
            int dayOfYear = birthday.DayOfYear;

            Console.WriteLine($"Порядковый номер дня рождения в году: {dayOfYear}");

            //c). является ли ваш год рождения високосным;

            int yearToCheck = 2006;

            //DateTime.IsLeapYear(yearToCheck) - это статический метод класса DateTime, который определяет, является ли указанный год високосным.
            //Метод возвращает true, если год високосный, и false в противном случае.
            //bool isLeapYear -это переменная типа bool(логический тип), которой присваивается результат вызова метода IsLeapYear.

            bool isLeapYear = DateTime.IsLeapYear(yearToCheck);

            if (isLeapYear)
            {
                Console.WriteLine($"{yearToCheck} год является високосным.");
            }
            else
            {
                Console.WriteLine($"{yearToCheck} год не является високосным.");
            }


            //вот с этого момента разобраться

            //e). количество полных лет;

            int age = DateTime.Now.Year - DateTime.Now.Month - birthday.Year;
            Console.WriteLine($"Количество полных лет: {age}");


            //f).  сколько дней осталось от сегодняшней даты до вашего ближайшего дня рождения(если день рождения сегодня, то вывести 0)
            TimeSpan a = birthday - DateTime.Now;
            Console.WriteLine($"До ближайшего ДР осталось {a} дней: ");


            Console.ReadKey();













        }
    }
}
