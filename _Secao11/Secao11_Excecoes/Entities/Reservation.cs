using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Secao11_Excecoes.Entities
{
   public class Reservation
   {
      public int RoomNumber { get; set; }
      public DateTime CheckIn { get; set; }
      public DateTime CheckOut { get; set; }

      public Reservation(){}
      public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
      {
         this.RoomNumber = roomNumber;
         this.CheckIn = checkIn;
         this.CheckOut = checkOut;
      }
      public int Duration()
      {
         TimeSpan duration = CheckOut.Subtract(CheckIn); //diferença entre as datas
         return (int)duration.TotalDays;
      }
      public string UpdateReservation(DateTime checkIn, DateTime checkOut)
      {
         DateTime now = DateTime.Now;
         if(checkIn < now || checkOut < now)
         {
            return "Error in reservation: Reservation FAIL Dates";
         }else if(checkOut <= checkIn)
         {
            return "Error in reservation: Reservation FAIL Dates checkOut <= checkIn";
         }

         this.CheckIn = checkIn;
         this.CheckOut = checkOut;

         return null;
      }
      public override string ToString()
      {
         return "Room "
            + RoomNumber
            + ", check-in: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", check-out: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " nights";
      }
   }
}