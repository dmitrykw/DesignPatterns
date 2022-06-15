using FactoryMethod.Factories;
using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <AbstractFactory> factories = new List <AbstractFactory>() {
                new TablesFactory("My new Table"),
                new ChairsFactory("My new Chair"),
                new SofaFactory("My new Sofa")
            };

            factories.ForEach((factory) => {             
                IProduct product =  factory.CreateProduct(factory.GetType().ToString());
                Console.WriteLine($"Created the product '{product.Name}' by factory: '{product.Description}'");
            });

          
            
            Console.ReadLine();
        }
    }
}
