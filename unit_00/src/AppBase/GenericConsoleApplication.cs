using System;

namespace AppBase
{
    /// <summary>Provides a generic application base for unit 00.</summary>
    public abstract class GenericConsoleApplication
    {
        protected int Value;

        /// <summary>Method performs all initialization and work with user, while attempting to solve the problem.</summary>
        public void Run()
        {
            Console.WriteLine("Welcome to unit 00 - demo application environment.");
            var result = false;
            while (!result)
            {
                ReadIntValue();
                result = AttemptToSolve();
            }
        }

        private void ReadIntValue()
        {
            var result = false;
            while (!result)
            {
                Console.WriteLine("Please enter integer value below.");
                var userInput = Console.ReadLine();
                result = int.TryParse(userInput, out var number);
                if (result)
                {
                    Value = number;
                }
                else
                {
                    Console.WriteLine("Attempted parsing and conversion of '{0}' failed. Value must be an integer", userInput);
                }
            }
        }

        private bool AttemptToSolve()
        {
            try
            {
                Solve();
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Attempt to solve problem failed due to: {0}.", exception.Message);
                Console.WriteLine("Performing attempt to correct current situation. Initiating restart of user input.");
                return false;
            }
        }

        /// <summary>Override this method to solve the problem.</summary>
        protected abstract void Solve();
    }
}
