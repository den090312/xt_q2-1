using System;

namespace ApplicationBase
{
    public abstract class IntReader : GenericConsoleApplication
    {
        protected int Value;

        public override void Run()
        {
            PrintIntro();
            var result = false;
            while (!result)
            {
                Value = ReadIntValue();
                result = AttemptToSolve();
            }
        }

        protected virtual void PrintIntro()
        {
            Console.WriteLine("Welcome to unit 00 - demo application environment.");
        }
    }
}