using System;
using System.Runtime.Serialization;

namespace Console_Test.CustomClasses
{

    /// <summary>
    /// Example of a Serializable class representing an animal
    /// </summary>
    [Serializable]
    public class Animal : ISerializable
    {
        //Access Limits
        //public - protected - private
        // {get; set;} automatically defines getters and setters for the field
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Sound { get; set; }
        public int Id { get; set; }

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
            Height = 0;
            Weight = 0;
            Sound = "NoSound";
            Name = "NoName";
            count++;
        }

        public Animal(string name)
        {
            this.name = name;
            Height = 0;
            Weight = 0;
            Sound = "NoSound";
        }

        public Animal(double height, double weight, string name)
        {
            Height = height;
            Weight = weight;
            Sound = "NoSound";
            this.name = name;
        }

        public Animal(double height, double weight, string sound, string name)
        {
            Height = height;
            Weight = weight;
            Sound = sound;
            this.name = name;
            count++;
        }

        public Animal(SerializationInfo info, StreamingContext context)
        {
            Id = (int) info.GetValue("Id", typeof(int));
            Name = (string) info.GetValue("Name", typeof(string));
            Height = (double) info.GetValue("Height", typeof(double));
            Weight = (double) info.GetValue("Weight", typeof(double));
            Sound = (string) info.GetValue("Sound", typeof(string));
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

        /// <summary>
        /// Method that serializes the object data
        /// </summary>
        /// <param name="info">Holds Key-Value Pairs for the data in your context</param>
        /// <param name="context">Holds additional information</param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Name", name);
            info.AddValue("Height", Height);
            info.AddValue("Weight", Weight);
            info.AddValue("Sound", Sound);
        }
    }
}
