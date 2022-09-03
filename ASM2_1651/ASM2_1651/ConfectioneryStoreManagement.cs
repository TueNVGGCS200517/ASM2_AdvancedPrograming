using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_1651
{
    public class ConfectioneryStoreManagement
    {
        private List<ConfectioneryStore> list { get; set; }

        public ConfectioneryStoreManagement()
        {
            list = new List<ConfectioneryStore>();
        }

        public void AddNew()
        {
            Console.WriteLine("What type of Confectionery do you want?");
            Console.WriteLine("1. Candy\n2. Snacks\n3. Cake");
            Console.Write("Please enter your option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            ConfectioneryStore Con = null;
            switch (option)
            {
                case 1:
                    Con = new Candy();
                    break;
                case 2:
                    Con = new Snacks();
                    break;
                case 3:
                    Con = new Cake();
                    break;
                default:
                    break;
            }
            Con.InputInfo();
            list.Add(Con);
        }

        public void ShowAll()
        {
            foreach (var Con in list)
            {
                Con.ShowInfo();
            }
        }

        public void SearchbyConfectioneryStore(int id)
        {
            foreach (var Con in list)
            {
                if (Con.Id == id)
                {
                    Con.ShowInfo();
                    return;
                }
            }
            Console.WriteLine("\nNot found");
        }

        public void DeletebyConfectioneryStore(int id)
        {
            foreach (var Con in list)
            {
                if (Con.Id == id)
                {
                    list.Remove(Con);
                    return;
                }
            }
            Console.WriteLine("\nNot Found");
        }

        public void UpdatebyConfectioneryStore(int id)
        {
            foreach (var Con in list)
            {
                if (Con.Id == id)
                {
                    if (Con is Candy)
                    {
                        Candy Ca = Con as Candy;
                        try
                        {
                            Console.Write("\nInput Name: ");
                            Ca.Name = Console.ReadLine();
                            Console.Write("\nInput Price Candy: ");
                            Ca.PriceCandy = Convert.ToSingle(Console.ReadLine());
                            Console.Write("\nInput Type: ");
                            Ca.Type = Console.ReadLine();
                            
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                    else if (Con is Snacks)
                    {
                        Snacks S = Con as Snacks;
                        try
                        {
                            Console.Write("\nInput Name: ");
                            S.Name = Console.ReadLine();
                            Console.Write("\nInput Price Snacks: ");
                            S.PriceSnacks = Convert.ToSingle(Console.ReadLine());
                            Console.Write("\nInput Type: ");
                            S.Type = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                    else if (Con is Cake)
                    {
                        Cake C = Con as Cake;
                        try
                        {
                            Console.Write("\nInput Name: ");
                            C.Name = Console.ReadLine();
                            Console.Write("\nInput Price Cake: ");
                            C.PriceCake = Convert.ToSingle(Console.ReadLine());
                            Console.Write("\nInput Type: ");
                            C.Type = Console.ReadLine();
                            
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                }
            }
        }

        public int Menu()
        {
            int option = 0;
            Console.WriteLine("1. Add New\n2. Show All\n3. Search by ConfectioneryStore\n4. Delete by ConfectioneryStore\n5. Update ConfectioneryStore\n6. Exit");
            Console.Write("Please enter your option: ");
            option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
    }

}