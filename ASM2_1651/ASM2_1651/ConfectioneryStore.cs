using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_1651
{
    public abstract class ConfectioneryStore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public ConfectioneryStore()
        { }

        public ConfectioneryStore(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        public virtual void InputInfo()
        {
            try
            {
                Console.Write("\nInput Id: ");
                Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nInput Name: ");
                Name = Console.ReadLine();
                Console.Write("\nInput Type: ");
                Type = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("\n- Id product: " + Id);
            Console.WriteLine("\n- Name product: " + Name);
            Console.WriteLine("\n- Type product: " + Type);
        }
    }

}
