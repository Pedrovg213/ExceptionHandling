using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

         RoomNumber = _roomNumber;
         CheckIn = _checkIn;
         CheckOut = _checkOut;
      }


      public string UpdateDates( DateTime _checkIn , DateTime _checkOut ) {

         DateTime now = DateTime.Now;
         if ( _checkIn < now || _checkOut < now ) {
            return "Reservation dates to uptades must be future dates.";
         } 
         if ( _checkOut <= _checkIn ) {
            return "Check out date must be after check in date." ;
         }

         CheckIn = _checkIn;
         CheckOut = _checkOut;

         return null;
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
