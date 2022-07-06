using System;
using System.Globalization;
using Prototype02.Entities;
using Prototype02.Entities.Exceptions;

namespace Prototype02 {
   internal class Program {
      static void Main( string[ ] args ) {
         try {

            // Inputs
            Console.WriteLine( "Enter account data:" );
            // number
            Console.Write( "Number: " );
            int accountNumber = int.Parse(Console.ReadLine());
            // holder
            Console.Write( "Holder: " );
            string holder = Console.ReadLine();
            // initial Balance
            Console.Write( "Inicial Balance: $" );
            double iniBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // withdraw limit
            Console.Write( "Withdraw limit: $" );
            double wdLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            // Instantiation
            Account account = new Account(accountNumber, holder, iniBalance, wdLimit);

            // Updating
            Console.Write( "Enter amount for withdraw: $" );
            double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.WithDraw( withDraw );

            // Output
            Console.WriteLine( "New Balance: $" + account.Balance.ToString( "F2" , CultureInfo.InvariantCulture ) );

         } catch ( DomainExceptions de ) {

            Console.WriteLine( "Withdraw error: " + de.Message );
         }
      }
   }
}
