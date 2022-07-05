using System;
using Prototype01.Entities;

namespace Prototype01 {
   internal class Program {
      static void Main( string[ ] args ) {

         // Inputs
         // room number
         Console.Write( "Room Number: " );
         int roomNumber = int.Parse(Console.ReadLine());
         // check in
         Console.Write( "Check in date (dd/mm/yyyy): " );
         DateTime checkIn = DateTime.Parse(Console.ReadLine());
         // check out
         Console.Write( "Check out date (dd/mm/yyyy): " );
         DateTime checkOut = DateTime.Parse(Console.ReadLine());

         if ( checkOut <= checkIn ) {
            Console.WriteLine( "Reservation Error: Check date out must be after check in date." );
         } else {
            // Instantiation
            Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
            Console.WriteLine( reservation );

            // Update
            Console.WriteLine( "Enter the data to uptade reservation:" );
            // check in
            Console.Write( "Check in date (dd/mm/yyyy): " );
            checkIn = DateTime.Parse( Console.ReadLine() );
            // check out
            Console.Write( "Check out date (dd/mm/yyyy): " );
            checkOut = DateTime.Parse( Console.ReadLine() );

            DateTime now = DateTime.Now;
            if ( checkIn < now || checkOut < now ) {
               Console.WriteLine( "Reservation Error: Reservation dates to uptades must be future dates." );
            } else if ( checkOut <= checkIn ) {
               Console.WriteLine( "Reservation Error: Check date out must be after check in date." );
            } else {
               reservation.UpdateDates( checkIn , checkOut );
               Console.WriteLine( reservation );
            }
         }
      }
   }
}
