using System;

namespace Console_Test.ElectronicDevice
{
    class Television : IElettronicDevice
    {
        public int Volume { get; set; }

        public void On()
        {
            Console.WriteLine("The TV has been turned On");
        }

        public void Off()
        {
            Console.WriteLine("The TV has been turned Off");
        }

        public void VolumeUp()
        {
            if (Volume < 100)
                Volume++;

            Console.WriteLine($"The TV Volume is now {Volume}");
        }

        public void VolumeDown()
        {
            if (Volume > 0)
                Volume--;

            Console.WriteLine($"The TV Volume is now {Volume}");
        }
    }
}
