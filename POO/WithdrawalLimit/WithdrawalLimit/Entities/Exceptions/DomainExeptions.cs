using System;

namespace WithdrawalLimit.Entities
{
    class DomainExeptions : ApplicationException
    {
        public DomainExeptions(string message) : base(message) { }
    }
}       