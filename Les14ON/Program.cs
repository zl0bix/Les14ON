//using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les14ON
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            List<string> book = new List<string>();
            List<string> page = new List<string>();
            string strTemp = "";
            string isExit = "exit";
            bool isSpin = true;

           while (isSpin)
            {
                goToReturne:
                Console.Write("Введите слово -> ");
                strTemp = Console.ReadLine();

                if (strTemp.ToLower() == isExit)
                {
                    isSpin = false;
                    continue;
                }

                if(book.Count == 0)
                {
                    Console.WriteLine("Словарь пуст!!! слово---- " + strTemp + " ----добавленно!!!");
                    book.Add(strTemp);
                    Console.Write("Добавте для вашего слова---- " + strTemp + " ----перевод -> ");
                    strTemp = "";
                    strTemp = Console.ReadLine();
                    page.Add(strTemp);
                    strTemp = "";
                }
                else
                {
                    for (int i = 0; i < book.Count; i++)
                    {
                        if (book[i] == strTemp)
                        {
                            Console.WriteLine("Такое слово есть\n----слово---- " + book[i] + " ----и непосредственно его перевод---- " + page[i] + " ----");
                            strTemp = "";
                            goto goToReturne;
                        }
                    }

                    Console.Write("Слово---- " + strTemp + " ----добавленно " + " Пожалуйста довавте перевод -> ");
                    book.Add(strTemp); 
                    strTemp = "";
                    strTemp = Console.ReadLine();
                    page.Add(strTemp);
                    strTemp = "";

                }
            }Console.Clear();
            Console.WriteLine("\n\n\n\n\n\t\t\t\t");
            Console.WriteLine(strTemp);           
        }

    }
}

