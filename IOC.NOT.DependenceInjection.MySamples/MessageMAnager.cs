using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.NOT.DependenceInjection.MySamples
{
    public class MessageMAnager
    {
        public string HelloMessage(string name)
        {
            var receptionService = new ReceptionService();
            return receptionService.Greeting(name);
        }
    }
}
