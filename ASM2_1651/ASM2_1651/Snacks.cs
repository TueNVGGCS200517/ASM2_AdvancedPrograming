using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_1651
{
    public class Snacks : ConfectioneryStore
    {
        public string NameSnacks { get; set; }
        public float PriceSnacks { get; set; }

        public Snacks() : base()
        { }

        public Snacks(string nameSnacks, float priceSnacks)
        {
            NameSnacks = nameSnacks;
            PriceSnacks = priceSnacks;
        }

        public override void InputInfo()
        {
            try
            {
                base.InputInfo();
                Console.Write("\nInput Name Snacks: ");
                NameSnacks = Console.ReadLine();
                Console.Write("\nInput Price Snacks: ");
                PriceSnacks = Convert.ToSingle(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("\n- Name Snacks: " + NameSnacks);
            Console.WriteLine("\n- Price Snacks: " + PriceSnacks);
        }
    }
}
