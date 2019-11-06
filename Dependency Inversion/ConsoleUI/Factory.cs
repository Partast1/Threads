using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class Factory
    {
        public static Person CreatePerson()
        {
            return new Person();
        }
        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessage());
        }
        public static IMessageSender CreateMessage()
        {
            return new Emailer();
        }
        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}
