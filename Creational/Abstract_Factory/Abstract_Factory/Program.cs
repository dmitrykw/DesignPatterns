using Abstract_Factory.Factorys;
using Abstract_Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int selected_product = -1;
                int selected_product_type = -1;

                Console.WriteLine("Wath do you wanna get?");
                Console.WriteLine("0. Chair");
                Console.WriteLine("1. Sofa");
                Console.WriteLine("2. Table");
                Console.WriteLine("Select Number");

                int.TryParse(Console.ReadLine(), out selected_product);

                Console.WriteLine("Wath type of the do you wanna get?");
                Console.WriteLine("0. Regular");
                Console.WriteLine("1. Modern");
                Console.WriteLine("2. Antique");
                Console.WriteLine("Select Number");
                int.TryParse(Console.ReadLine(), out selected_product_type);

                IFactory factory;
                IProduct product;

                switch (selected_product_type)
                {
                    case 1:
                        factory = new ModernFactory();
                        break;
                    case 2:
                        factory = new AntiqueFactory();
                        break;

                    default:
                        factory = new RegularFactory();
                        break;

                }

                switch (selected_product)
                {
                    case 1:
                        product = factory.CreatewSofa();
                        break;
                    case 2:
                        product = factory.CreateTable();
                        break;
                    default:
                        product = factory.CreateChair();
                        break;
                }

                Console.WriteLine(product.GetName());
                Console.ReadLine();
            } while (true);
        }
    }
}
