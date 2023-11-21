using System;
using System.Globalization;
using Secao14_interfaces.Entities;
using Secao14_interfaces.Services;

namespace Secao14_interfaces // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();

            Console.WriteLine("Pickup: (dd/M/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Return: (dd/M/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per hours: ");
            double perHour = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter price per day: ");
            double perDay = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(perHour, perDay, new BrazilTaxService());
            
            rentalService.ProcessInvoice(carRental);
            
            Console.WriteLine("INVOICE: ");
            Console.WriteLine("Basic payment: "+ carRental.Invoice.BasicPayment);
            Console.WriteLine( "Tax: "+ carRental.Invoice.Tax);
            Console.WriteLine("Total payment: "+ carRental.Invoice.TotalPayment);

        }
    }
}