using System;
using Prototype01.Entities.Exceptions;

namespace Prototype01.Entities {
   internal class Reservation {

      public int RoomNumber {
         get; set;
      }
      public DateTime CheckIn {
         get; set;
      }
      public DateTime CheckOut {
         get; set;
      }


      public Reservation( ) {
      }
      public Reservation( int _roomNumber , DateTime _checkIn , DateTime _checkOut ) {

         if ( _checkOut <= _checkIn ) {
            throw new DomainException( "Check out date must be after check in date." );
         }

         RoomNumber = _roomNumber;
         CheckIn = _checkIn;
         CheckOut = _checkOut;
      }


      public void UpdateDates( DateTime _checkIn , DateTime _checkOut ) {

         DateTime now = DateTime.Now;
         if ( _checkIn < now || _checkOut < now ) {
            throw new DomainException( "Reservation dates to uptades must be future dates." );
         }
         if ( _checkOut <= _checkIn ) {
            throw new DomainException( "Check out date must be after check in date." );
         }

         CheckIn = _checkIn;
         CheckOut = _checkOut;
      }
      public int Duration( ) {

         TimeSpan duration = CheckOut.Subtract(CheckIn);

         return ( int )duration.TotalDays;
      }


      public override string ToString( ) {

         return $"Room: {RoomNumber}, " +
            $"CheckIn: {CheckIn.ToString( "dd/MM/yyyy" )}, " +
            $"CheckOut: {CheckOut.ToString( "dd/MM/yyyy" )}, " +
            $"Duration: {Duration()} nights.";
      }
   }
}
