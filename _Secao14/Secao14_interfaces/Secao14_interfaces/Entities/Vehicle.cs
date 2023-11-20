
namespace Secao14_interfaces.Entities
{
    public class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model ?? throw new ArgumentNullException(nameof(model));
        }
    }
}
