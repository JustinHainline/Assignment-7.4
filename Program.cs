namespace Assignment_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parkingSystem = new ParkingSystem(1, 1, 0);
            Console.WriteLine(parkingSystem.AddCar(1)); // true (1 available slot for a big car)
            Console.WriteLine(parkingSystem.AddCar(2)); // true (1 available slot for a medium car)
            Console.WriteLine(parkingSystem.AddCar(3)); // false (no available slot for a small car)
            Console.WriteLine(parkingSystem.AddCar(1)); // false (no available slot for a big car, already occupied)

        }
        public class ParkingSystem
        {
            private int[] slots; // Array to store available slots for each car type

            public ParkingSystem(int big, int medium, int small)
            {
                slots = new int[] { big, medium, small };
            }

            public bool AddCar(int carType)
            {
                if (carType < 1 || carType > 3)
                {
                    // Invalid car type
                    return false;
                }

                if (slots[carType - 1] > 0)
                {
                    // Space available for the specified car type
                    slots[carType - 1]--;
                    return true;
                }

                // No space available
                return false;
            }
        }

    }
}
