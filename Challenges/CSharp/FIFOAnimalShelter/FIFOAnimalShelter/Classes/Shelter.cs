using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;
using StacksAndQueues;

namespace FIFOAnimalShelter.Classes
{
    public class Shelter 
    {
        private StacksAndQueues.Queue<Animal> TheShelter = new StacksAndQueues.Queue<Animal>();
        public Animal Front { get; set; }

        /// <summary>
        /// Add a new animal to the shelter
        /// </summary>
        /// <param name="pet">Pet to be added</param>
        public void Enqueue(Animal pet)
        {
            TheShelter.Enqueue(pet);
            Front = TheShelter.Peek();
        }

        /// <summary>
        /// Removes an animal of specified type from the shelter.
        /// </summary>
        /// <param name="type">Type of pet desired</param>
        /// <returns>First pet in Shelter of specified type.</returns>
        public Animal Dequeue(string type)
        {

            StacksAndQueues.Queue<Animal> Temp = TheShelter;
            while(!Temp.IsEmpty())
            {
                if(Temp.Peek().Species == type)
                {
                    Animal result = Temp.Dequeue();
                    TheShelter = Temp;
                    return result;
                }
                else
                {
                    Temp.Dequeue();
                }
            }
            return TheShelter.Dequeue();
        }

    }
}
