using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.NOT.DependenceInjection.MySamples
{
    public class ReceptionService
    {
        private string name;

        public string Greeting(string name) => $"Hello, {name}!";
    }
}
