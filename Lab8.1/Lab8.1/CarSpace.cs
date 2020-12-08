using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lab8._1
{
    class CarSpace
    {
        private List<Car> Cars { get; }
        public CarSpace()
        {
            Cars = new List<Car>();
        }
        public void AddCar(Car vehicle)
        {
            Cars.Add(vehicle);
        }
        public void RemoveCar(Car vehicle)
        {
            foreach (var i in Cars.ToArray())
                if (vehicle == i)
                {
                    Cars.Remove(i);
                    return;
                }
        }
        public IEnumerable<Car> GetCars(Car vehicle)
        {
            LinkedList<Car> choise = new LinkedList<Car>();

            foreach (var car_i in Cars)
            {
                if (vehicle.name != "0" && car_i.name != vehicle.name)
                    continue;

                else if (vehicle.color != "0" && car_i.color != vehicle.color)
                    continue;

                else if (vehicle.speed != 0 && car_i.speed != vehicle.speed)
                    continue;

                else if (vehicle.year != 0 && car_i.year != vehicle.year)
                    continue;

                choise.AddFirst(car_i);
            }
            return choise;
        }
        public override string ToString()
        {
            if (Cars.Count() < 0)
                return "Empty!";
            else
            {
                StringBuilder vehicles = new StringBuilder();
                for (int i = 0; i < Cars.Count(); i++)
                {
                    vehicles.Append($"Namber car {i + 1}:\n{Cars[i]}");
                }
                return vehicles.ToString();
            }
        }
    }
}
