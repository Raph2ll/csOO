using System;

namespace ex15.Entities.Exceptions {
    class DomainException : ApplicationException {

        public DomainException(string message) : base(message) {
        }
    }
}