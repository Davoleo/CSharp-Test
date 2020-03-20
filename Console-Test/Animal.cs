using System;

namespace Console_Test
{
    class Animal
    {
        //Access Limits
        //public - protected - private
        // {get; set;} automatically defines getters and setters for the field
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Sound { get; set; }
        private string name;

        //custom getters/setters (properties)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Constructors
        //The default constructor has no parameters
        public Animal()
        {
            this.Height = 0;
            this.Weight = 0;
            this.Sound = "NoSound";
            this.Name = "NoName";
            count++;
        }

        public Animal(double height, double weight, string sound, string name)
        {
            this.Height = height;
            this.Weight = weight;
            this.Sound = sound;
            this.Name = name;
            count++;
        }

        //Static fields and methods - common between instances of this class
        private static int count = 0;
        public static int GetCount() {
            return count;
        }

        //Overrides a method in the superclass (needs the override keyword)
        public override string ToString()
        {
            return String.Format("{0} is {1} meters tall, weighs {2} kg and makes this sound: {3}", name, Height,
                Weight, Sound);
        }
    }
}
