using System.Collections.Generic;

namespace ClassStudent
{
    
    class HumanComparer : IComparer<Human>
    {
        public int Compare(Human h1, Human h2)
        {
            if (h1.Surname.ToCharArray()[0] > h2.Surname.ToCharArray()[0])
                return 1;
            else if (h1.Surname.ToCharArray()[0] < h2.Surname.ToCharArray()[0])
                return -1;
            else
                return 0;
        }
    }
   
}