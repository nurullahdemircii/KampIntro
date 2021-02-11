using System;
using System.Collections.Generic;
using System.Text;

namespace L005_OOP3
{
    class RecourseManager
    {
        // Method injection
        public void RecourseDoIt(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calc();
            loggerService.Log();
        }
        public void MakeCreditPrenotification(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calc();
            }
        }
    }
}
