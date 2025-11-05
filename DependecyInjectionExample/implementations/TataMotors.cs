using DependecyInjectionExample.Models;
using DependecyInjectionExample.repository;

namespace DependecyInjectionExample.implementations
{
    public class TataMotors : IEngine
    {
        public Engine  EngineFunctionality()
        {
            Engine engine = new Engine()
            {
                Name = "Test",
                Description = "Tata Engine it is"
            };
            return engine;
        }
    }
}
