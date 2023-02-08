using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_P_JoshuaHooper
{
    public class CarOwner
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }


        public CarOwner()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Make = string.Empty;
            Model = string.Empty;
            Year = 0;
            Color = string.Empty;
        }

        public override string ToString()
        {
            string carOwnerStr = ($"First Name: {FirstName}\n" +
                                    $"Last Name: {LastName}\n" +
                                    $"Make: {Make}\n" +
                                    $"Model: {Model}\n" +
                                    $"Year: {Year.ToString()}\n" +
                                    $"Color: {Color}\n");

            return carOwnerStr;
        }
    }
}
