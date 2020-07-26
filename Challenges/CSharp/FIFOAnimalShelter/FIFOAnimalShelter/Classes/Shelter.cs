using System;
using System.Linq.Expressions;
using System.Text;
using StacksAndQueues;

namespace FIFOAnimalShelter.Classes
{
    public class Shelter
    {
        public Queue<Animal> Animals { get; set; }

        public Shelter()
        {
            Animals = new Queue<Animal>();
        }

        public void Enqueue(Animal animal)
        {
            Animals.Enqueue(animal);
        }

        public Animal Dequeue(string type)
        {
            Animal frontTemp = Animals.Peek();
            Animal result = null;
            do
            {
                Animal dequeued = Animals.Dequeue();
                if(result == null && dequeued.Species == type)
                {
                    result = dequeued;
                    if (Animals.IsEmpty()) return result;
                }else
                {
                    Animals.Enqueue(dequeued);
                }
            } while (Animals.Peek() != frontTemp);
            return result;
        }
    }
}