using System;

namespace Prototype02.Entities.Exceptions {
   internal class DomainExceptions : ApplicationException {

      public DomainExceptions( string _message ) :
         base( _message ) {
      }
   }
}
