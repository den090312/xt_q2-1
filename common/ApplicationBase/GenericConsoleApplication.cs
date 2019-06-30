using System;

namespace ApplicationBase
{
    /// <summary>Provides a generic application base for unit 00.</summary>
    public abstract class GenericConsoleApplication
    {
        /// <summary>Method performs all initialization and work with user, while attempting to solve the problem.</summary>
        public abstract void Run();

        protected int ReadIntValue()
        {
            while (true)
            {
                Console.WriteLine("Please enter integer value below.");
                var userInput = Console.ReadLine();
                var result = int.TryParse(userInput, out var number);
                if (result)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Attempted parsing and conversion of '{0}' failed. Value must be an integer", userInput);
                }
            }
        }

        protected bool AttemptToSolve()
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
