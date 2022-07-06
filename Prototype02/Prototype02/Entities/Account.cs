using Prototype02.Entities.Exceptions;

namespace Prototype02.Entities {
   internal class Account {

      public int Number {
         get; private set;
      }
      public string Holder {
         get; private set;
      }
      public double WithDrawLimit {
         get; private set;
      }
      public double Balance {
         get; private set;
      }


      public Account( ) {
      }
      public Account( int _number , string _holder , double _balance , double _withdrawLimit ) {

         Number = _number;
         Holder = _holder;
         WithDrawLimit = _withdrawLimit;
         Balance = _balance;
      }


      public void Deposit( double _amount ) {

         Balance += _amount;
      }
      public void WithDraw( double _amount ) {

         // Exceptions
         if ( _amount > Balance )
            throw new DomainExceptions( "Not enough balance." );
         if ( _amount > WithDrawLimit )
            throw new DomainExceptions( "The amount exceeds withdraw limit." );

         Balance -= _amount;
      }
   }
}
