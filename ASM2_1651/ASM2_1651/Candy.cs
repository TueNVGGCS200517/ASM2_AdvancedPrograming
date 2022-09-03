using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_1651
{
    public class Candy : ConfectioneryStore
    {
        public string NameCandy { get; set; }
        public float PriceCandy { get; set; }

        public Candy() : base()
        { }

        public Candy(string nameCandy, float priceCandy)
        {
            NameCandy = nameCandy;
            PriceCandy = priceCandy;
        }

        public override void InputInfo()
        {
            try
            {
                base.InputInfo();
                Console.Write("\nInput Name Candy: ");
                NameCandy = Console.ReadLine();
                Console.Write("\nInput Price Candy: ");
                PriceCandy = Convert.ToSingle(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("\n- Name Candy: " + NameCandy);
            Console.WriteLine("\n- Price Candy: " + PriceCandy);
        }
    }
}
