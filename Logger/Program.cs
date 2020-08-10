using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();

            logger.Log("Application Initialized...");

            logger.Log("Hello My name is:");
            logger.Log("Robert");
        }
    }
}