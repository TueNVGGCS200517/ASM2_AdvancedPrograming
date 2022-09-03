using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_1651
{
    public class Cake : ConfectioneryStore
    {
        public string NameCake { get; set; }
        public float PriceCake { get; set; }

        public Cake() : base()
        { }

        public Cake(string nameCake, float priceCake)
        {
            NameCake = nameCake;
            PriceCake = priceCake;
        }

        public override void InputInfo()
        {
            try
            {
                base.InputInfo();
                Console.Write("\nInput Name Cake: ");
                NameCake = Console.ReadLine();
                Console.Write("\nInput Price Cake: ");
                PriceCake = Convert.ToSingle(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("\n- Name Cake: " + NameCake);
            Console.WriteLine("\n- Price Cake: " + PriceCake);
        }
    }
}
