using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Car myCar = new Car("Mitshubshi", "Outlander", 2.0, 2020, 12330);

            myCar.OnMove += (lightColor) => Console.WriteLine($"shuqnishanis feria {lightColor}, unda waxvide");
            myCar.OnStop += (lightColor) => Console.WriteLine($"shuqnishanis feria {lightColor}, unda gacherede");
            myCar.OnReady += (lightColor) => Console.WriteLine($"shuqnishanis feria {lightColor}, moemzade");

   

            TrafficLights currentLight = TrafficLights.Green;


            switch (currentLight)

            {


                case TrafficLights.Green:


                    myCar.Move(currentLight.ToString());


                    break;

                case TrafficLights.Yellow:

                    myCar.Ready(currentLight.ToString());

                    break;

                case TrafficLights.Red:

                    myCar.Stop(currentLight.ToString());

                    break;
            }




        }



        public enum TrafficLights

        {

            Green,

            Yellow,
            Red
        }




        public class Car
        {




            public event Action<string> OnMove;

            public event Action<string> OnStop;

            public event Action<string> OnReady;







            public string Manufacturer { get; set; }

            public string Model { get; set; }

            public double EngineCapacity { get; set; }

            public int YearOfRelease { get; set; }

            public int Mileage { get; set; }





            public Car(string manufacturer, string model, double engineCapacity, int yearOfRelease, int mileage)

            {
                Manufacturer = manufacturer;


                Model = model;


                EngineCapacity = engineCapacity;


                YearOfRelease = yearOfRelease;


                Mileage = mileage;

            }








            public void Move(string lightColor)

            {
                Console.WriteLine($"shuqnishanis feria {lightColor}         unda waxvide ");


                OnMove?.Invoke(lightColor);

            }

            public void Stop(string lightColor)
            {
                Console.WriteLine($"shuqnishanis feria {lightColor}    unda gacherede ");
                OnStop?.Invoke(lightColor);
            }

            public void Ready(string lightColor)
            {
                Console.WriteLine($"shuqnishanis feria {lightColor},  moemzade");
                OnReady?.Invoke(lightColor);
            }







        }




















    }

}