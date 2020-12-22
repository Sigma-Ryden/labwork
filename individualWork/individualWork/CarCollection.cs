using System;
using System.Collections.Generic;


namespace individualWork
{
    class CarCollection
    {
        private readonly List<Cars> carsCollection = new List<Cars>();
        public void AddCars(Cars cars)
        {
            carsCollection.Add(cars);
        }
        public List<int> FindCar(Cars cars)
        {
            List<int> carsFinded = new List<int>();
            carsFinded.Clear();

            for (int i = 0; i < carsCollection.Count; i++)
            {
                if (cars.Colors != null)
                {
                    bool colorTrue = false;
                    for (int j = 0; j < carsCollection[i].Colors.Count; j++)
                    {
                        if (carsCollection[i].Colors[j] == cars.Colors[0])
                        {
                            colorTrue = true;
                            break;
                        }
                    }
                    if (!colorTrue) continue;
                }

                if (cars.Year != 0 && (carsCollection[i].Year != cars.Year)) continue;
                if (cars.Price != 0 && (carsCollection[i].Price != cars.Price)) continue;
                if ((cars.Model != string.Empty) && (carsCollection[i].Model != cars.Model)) continue;

                carsFinded.Add(i);
            }
            return carsFinded;
        }
        public void PrintInfoCars()
        {
            for (int i = 0; i < carsCollection.Count; i++) Console.WriteLine(carsCollection[i]);
        }
        public void PrintInfoCars(List<int> carsNumber)
        {
            if (carsNumber.Count == 0) Console.WriteLine("We don't have such a car!");

            foreach (var cars in carsNumber) Console.WriteLine(carsCollection[cars]);
        }
    }
}
