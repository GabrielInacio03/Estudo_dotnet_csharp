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
       public void UpdateReservation(DateTime checkInd, DateTime checkOut)
       {
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
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