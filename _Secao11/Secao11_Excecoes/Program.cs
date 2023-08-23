using System;
using System.IO;
using Secao11_Excecoes.Entities;
namespace Secao11_Excecoes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {                
            System.Console.WriteLine("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <= checkIn)
            {
                //System.Console.WriteLine("A data do Check-Out deve ser Maior do que a de Check-In");
                throw new Exception("A data do Check-Out deve ser Maior do que a de Check-In");
            }
            else{
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                System.Console.WriteLine($"Reservation: {reservation}");

                System.Console.WriteLine();
                System.Console.WriteLine("Vamos Atualizar Os dados da reserva: ");
                System.Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                System.Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateReservation(checkIn, checkOut);
            }
            
        }
    }
}