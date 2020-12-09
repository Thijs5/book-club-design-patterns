using System;

namespace MakingBread.Solution.Models
{
    public abstract class Bread
    {
        // The template method
        public void Make()
        {
            MixIngredients();
            Bake();
            FinishOff();
            Slice();
        }

        protected abstract void MixIngredients();

        protected abstract void Bake();

        protected virtual void Slice()
        {
            Console.WriteLine("Slicing the " + GetType().Name + " bread!");
        }

        // Hook operation
        protected virtual void FinishOff()
        {
        }
    }
}