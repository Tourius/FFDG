using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace AdventureBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Introduction adventureStart = new Introduction();
            adventureStart.Title();
            adventureStart.StartGameScreen();
            var choice = adventureStart.UserChoice();
            Console.Clear();
            int PageNum = 0;
            if (choice==1)
            {
                Console.WriteLine("set page number to 1");
                PageNum = 1;
            }
            else if (choice==2)
            {
                Console.WriteLine("Save function needs to call page number");
            }
            else if (choice == 0)
            {
                Environment.Exit(0);
            }
            Story adventureMid = new Story();
            adventureMid.Page(PageNum);

        }
    }
}
