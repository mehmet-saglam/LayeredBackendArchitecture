using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //SOLID 
    // S: Single Responsibility Principle
    // O: Open/Closed Principle
    // L: Liskov Substitution Principle
    // I: Interface Segregation Principle
    // D: Dependency Inversion Principle
        class Program
    {
        static void Main(string[] args)
        {
           ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);

            }







        }
    }
}