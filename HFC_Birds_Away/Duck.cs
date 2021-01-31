using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HFC_Birds_Away
{
    class Bird
    {
        public string Name { get; set; }

        public void Fly(string destination)
        {
            Console.WriteLine($"Flap flap flap, {this} is flying to {destination}");
        }

        public override string ToString()
        {
            return $"A bird named {Name}";
        }

        public static void FlyAway(List<Bird> flock, string destination)
        {
            foreach (Bird bird in flock)
            {
                bird.Fly(destination);
            }
        }

    }



    class Duck : Bird
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

    
        public enum KindOfDuck
        {
            Mallard,
            Muscovy,
            Loon,
            Peking
        }
        public override string ToString()
        {
            return $"A {Size}\" {Kind}";
        }


    }


    enum SortCriteria
    {
        SizeThenKind,
        KindThenSize,
    }

    class DuckComparer: IComparer<Duck>
    {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;

    public int Compare(Duck x, Duck y)
        {
            if (SortBy == SortCriteria.SizeThenKind)
            {
                if (x.Size > y.Size)
                    return 1;
                else if (x.Size < y.Size)
                    return -1;
                else
                    return 0;
            }
            else if (SortBy == SortCriteria.KindThenSize)
            {
                if (x.Kind > y.Kind)
                    return 1;
                else if (x.Kind < y.Kind)
                    return -1;
                else
                    return 0;
            }
            //This superfulous else statement allows us to add new things to compare in the future.
            else 
                return 0;
        }
    }
}
