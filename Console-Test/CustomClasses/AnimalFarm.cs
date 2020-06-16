using System.Collections;
using System.Collections.Generic;

namespace Console_Test.CustomClasses
{
    class AnimalFarm : IEnumerable
    {

        private List<Animal> animals = new List<Animal>();

        public AnimalFarm()
        { }

        public AnimalFarm(List<Animal> animals)
        {
            this.animals = animals;
        }

        /// <summary>
        /// INDEXER : Allows to access things in a class just like an array
        /// </summary>
        public Animal this[int index]
        {
            get => animals[index];
            set => animals.Insert(index, value);
        }

        public int Count => animals.Count;

        public IEnumerator GetEnumerator()
        {
            return animals.GetEnumerator();
        }
    }
}
