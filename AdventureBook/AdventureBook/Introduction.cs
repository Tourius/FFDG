using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml;


namespace AdventureBook
{
    class Introduction
    {

        public void Title()
        {
            Console.WriteLine("Welcome to this Fantasy Fight Adventure book." +
                              "\nThis book was programmed by Joshua Wheeler." +
                              "\nI used to play texted base computer game and adventure books as a kid" +
                              "\nI spent hundreds of hours trying to kill goblins in both." +
                              "\nSo I thought when I was looking for my first project it would be a" +
                              "\nfun idea to try and recreate the books in a text based computer game." +
                              "\nI hope you enjoy playing this game and good luck!");
            Thread.Sleep(10000);
            Console.Clear();
        }

        public void StartGameScreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("BOOK TITTLE");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome Adventure.......");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("To start a new game click N");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("To go to saved games click S");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("To close the game click Esc");
        }

        public int UserChoice()
        {
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey(true);
                if (cki.Key.ToString() == "N")
                {
                    return 1;
                }
                if (cki.Key.ToString() == "S")
                {
                    return 2;
                }
                if (cki.Key.ToString() == "Escape")
                {
                    return 0;
                }
            } while (cki.Key != ConsoleKey.N || cki.Key != ConsoleKey.S || cki.Key != ConsoleKey.Escape);
            return 0;
        }
    }



}
