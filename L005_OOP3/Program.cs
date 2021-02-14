using System;
using System.Collections.Generic;

namespace L005_OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelFinanceCreditManager = new PersonelFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager buildCreditManager = new BuildCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService messageLoggerService = new MessageLoggerService();

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.RecourseDoIt(personelFinanceCreditManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>
            {
                personelFinanceCreditManager,
                transportCreditManager,
                buildCreditManager
            };

            //recourseManager.MakeCreditPrenotification(credits);

            Console.WriteLine("GitHub Değişiklikleri Push Kontrolü");

            Console.ReadLine();
            //
        }
    }
}
