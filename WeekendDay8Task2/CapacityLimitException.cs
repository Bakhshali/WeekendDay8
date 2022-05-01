using System;
using System.Collections.Generic;
using System.Text;

namespace WeekendDay8Task2
{
    class CapacityLimitException:Exception
    {
        private string _message;

        public override string Message => _message;

        public CapacityLimitException(string message)
        {
            _message = message;
        }
    }
}
