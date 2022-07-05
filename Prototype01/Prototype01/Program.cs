using System;
using Prototype01.Entities;
using Prototype01.Entities.Exceptions;

namespace Prototype01 {
   internal class Program {
      static void Main( string[ ] args ) {

         try {
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

            // Instantiation
            Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
            Console.WriteLine( reservation );
            Console.WriteLine();

            // Update
            Console.WriteLine( "Enter the data to uptade reservation:" );
            // check in
            Console.Write( "Check in date (dd/mm/yyyy): " );
            checkIn = DateTime.Parse( Console.ReadLine() );
            // check out
            Console.Write( "Check out date (dd/mm/yyyy): " );
            checkOut = DateTime.Parse( Console.ReadLine() );

            reservation.UpdateDates( checkIn , checkOut );

            Console.WriteLine( reservation );
         } catch ( DomainException de ) {

            Console.WriteLine( "Error in reservation: " + de.Message );
         } catch ( FormatException fe ) {

            Console.WriteLine( "Format error: " + fe.Message );
         } catch ( Exception e ) {

            Console.WriteLine( "Unexpected error: " + e.Message );
         }
      }
   }
}