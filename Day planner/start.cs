using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static System.Console;

namespace Day_planner
{
    class start
    {
        public void begin()
        {
            int page = 0;
            WriteLine("Напоминание на 07.11");
            WriteLine("->1. Сделать практические");
            WriteLine("2. Дочитать книгу 'Возвышение Хоруса'");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        page--;
                        if (page == -1)
                        {
                            page = 0;
                        }
                        if (page == 0)
                        {
                            Console.Clear();
                            WriteLine("Напоминание на 07.11");
                            WriteLine("->1. Сделать практические");
                            WriteLine("2. Дочитать книгу 'Возвышение Хоруса'");
                        }
                        else if (page == 1)
                        {
                            Console.Clear();
                            WriteLine("Напоминание на 08.11");
                            WriteLine("->1. Поиграть в Warhammer total war 2");
                            WriteLine("2. Пострадать от того на сколько я туп");
                        }
                        else if (page == 2)
                        {
                            Console.Clear();
                            WriteLine("Напоминание на 09.11");
                            WriteLine("->1. Еще раз офигеть насколько проста обывателськая жизнь и на сколько сложна для не обывателей");
                            WriteLine("2. Поиграть, папралельно слушая лекцию, будто я типо умный");
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        page++;
                        if (page == 3)
                        {
                            page = 2;
                        }
                        if (page == 0)
                        {
                            Console.Clear();
                            WriteLine("Напоминание на 07.11");
                            WriteLine("->1. Сделать практические");
                            WriteLine("2. Дочитать книгу 'Возвышение Хоруса'");
                        }
                        else if (page == 1)
                        {
                            Console.Clear();
                            WriteLine("Напоминание на 08.11");
                            WriteLine("->1. Поиграть в Warhammer total war 2");
                            WriteLine("2. Пострадать от того на сколько я туп");
                        }
                        else if (page == 2)
                        {
                            Console.Clear();
                            WriteLine("Напоминание на 09.11");
                            WriteLine("->1. Еще раз офигеть насколько проста обывателськая жизнь и на сколько сложна для не обывателей");
                            WriteLine("2. Поиграть, папралельно слушая лекцию, будто я типо умный");
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (page)
                        {
                            case 0:
                                RunmainMenu();
                                break;
                            case 1:
                                RunsecondMenu();
                                break;
                            case 2:
                                RunthirdMenu();
                                break;
                        }
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.DownArrow:
                        if (page == 0)
                        {
                            RunmainMenu();
                        }
                        else if (page == 1)
                        {
                            RunsecondMenu();
                        }
                        else if (page == 2)
                        {
                            RunthirdMenu();
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (page == 0)
                        {
                            RunmainMenu();
                        }
                        else if (page == 1)
                        {
                            RunsecondMenu();
                        }
                        else if (page == 2)
                        {
                            RunthirdMenu();
                        }
                        break;
                }
            }

        }
        private void RunmainMenu()
        {
            while (true)
            {
                string start = "Напоминание на 07.11";
                string[] options = { "1. Сделать практические", "2. Дочитать книгу 'Возвышение Хоруса'" };
                Menu mainMenu = new Menu(start, options);
                int Index = mainMenu.strelocki();
                switch (Index)
                {
                    case 0:
                        Opisanie1();
                        break;
                    case 1:
                        Opisanie2();
                        break;
                } 
            }
        }
        private void RunsecondMenu()
        {
            while (true)
            {
                string start = "Напоминание на 08.11";
                string[] options = { "1. Поиграть в Warhammer total war 2", "2. Пострадать от того на сколько я туп" };
                Menu mainMenu = new Menu(start, options);
                int Index = mainMenu.strelocki();
                switch (Index)
                {
                    case 0:
                        Opisanie3();
                        break;
                    case 1:
                        Opisanie4();
                        break;
                    default:
                        break;
                }
            }
        }
        private void RunthirdMenu()
        {
            while (true)
            {
                string start = "Напоминание на 09.11";
                string[] options = { "1. Еще раз офигеть насколько проста обывателськая жизнь и на сколько сложна для не обывателей", "2. Поиграть, папралельно слушая лекцию, будто я типо умный" };
                Menu mainMenu = new Menu(start, options);
                int Index = mainMenu.strelocki();
                switch (Index)
                {
                    case 0:
                        Opisanie5();
                        break;
                    case 1:
                        Opisanie6();
                        break;
                    default:
                        break;
                }
            }
        }
        private void Opisanie1()
        {
            string start = "Напоминание на 07.11.22 по поводу практических работ";
            string[] options = { "Выполнить практические по: Программированию(((, Дис.математике, Выс.математике", "Сделать до 09.11.22", "Время: 18:00"};
            Menu opis1 = new Menu(start, options);
            int index = opis1.strelocki();
            Clear();
            begin();
        }
        private void Opisanie2()
        {
            string start = "Напоминание на 07.11.22 по прочтению книги";
            string[] options = { "Дочитать первую книгу из цикла 'Возвышение Хоруса'", "Сделать до 10.11.22", "Время: 16:00" };
            Menu opis1 = new Menu(start, options);
            int index = opis1.strelocki();
            Clear();
            begin();
        }
        private void Opisanie3()
        {
            string start = "Напоминание на 08.11.22 по поводу игры";
            string[] options = { "Поиграть в новый Warhhamer Total War 2 и начать кампанию за скавенов", "Сделать до 08.11.22", "Время: 21:00" };
            Menu opis1 = new Menu(start, options);
            int index = opis1.strelocki();
            Clear();
            begin();
        }
        private void Opisanie4()
        {
            string start = "Напоминание на 08.11.22 о том насколько наша вселенная неоднозначна, как и твое стремление достич чего то большего, слабак";
            string[] options = { "Подумай о себе, о других, вспомни цель и так и оставайся тольок помнить ее, но не следовать ею", "Сделай ", "Время: 23:59" };
            Menu opis1 = new Menu(start, options);
            int index = opis1.strelocki();
            Clear();
            begin();
        }
        private void Opisanie5()
        {
            string start = "Напоминание на 09.11.22 не забудь опять подумать над очередной ерундой";
            string[] options = { "Подумай над этим, лошара", "Сделать до 09.11.22", "Время: 9:12" };
            Menu opis1 = new Menu(start, options);
            int index = opis1.strelocki();
            Clear();
            begin();
        }
        private void Opisanie6()
        {
            string start = "Напоминание на 09.11.22 по поводу паралельного самообмана по поводу того, что ты усваивашь все на лету";
            string[] options = { "Включи какого нибудь утопию или даже 'Математика без ху%!ни' раз ты не хочешь разбираться в теме самомстоятельно", "Включить пока играешь", "Время: 19:00" };
            Menu opis1 = new Menu(start, options);
            int index = opis1.strelocki();
            Clear();
            begin();
        }
    }
}
