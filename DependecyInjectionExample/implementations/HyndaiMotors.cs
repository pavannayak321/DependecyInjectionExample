using DependecyInjectionExample.Models;
using DependecyInjectionExample.repository;

namespace DependecyInjectionExample.implementations
{
    public class HyndaiMotors : IEngine
    {
        public Engine EngineFunctionality()
        {
            Engine engine = new Engine()
            {
                Name = "Hyndai",
                Description = "Hyundai Motor Functionality"
            };
            return engine;
        }
    }
}
