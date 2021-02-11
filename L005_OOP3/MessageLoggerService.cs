using System;
using System.Collections.Generic;
using System.Text;

namespace L005_OOP3
{
    class MessageLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Mesaja Loglandı.");
        }
    }
}
