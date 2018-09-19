using System;
using System.Collections.Generic;
using System.Text;
using UpdatePrism.ApplicationServices.Interfaces;

namespace UpdatePrism.ApplicationServices
{
    public class CurrentDateService : ICurrentDateService
    {
        public string GetCurrentDate()
        {
            return System.DateTime.Now.ToString();
        }
    }
}
