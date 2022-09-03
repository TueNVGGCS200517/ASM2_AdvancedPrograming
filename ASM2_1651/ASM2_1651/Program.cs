using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_1651
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConfectioneryStoreManagement Con = new ConfectioneryStoreManagement();
            int option = 0;
            do
            {
                option = Con.Menu();
                switch (option)
                {
                    case 1:
                        Con.AddNew();
                        break;
                    case 2:
                        Con.ShowAll();
                        break;
                    case 3:
                        Console.WriteLine("Input ID: ");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        Con.SearchbyConfectioneryStore(Id);
                        break;
                    case 4:
                        Console.WriteLine("Input ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Con.DeletebyConfectioneryStore(id);
                        break;
                    case 5:
                        Console.WriteLine("Input ID: ");
                        int iD = Convert.ToInt32(Console.ReadLine());
                        Con.UpdatebyConfectioneryStore(iD);
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;
                }

            } while (option != 6);
        }
    }

}
