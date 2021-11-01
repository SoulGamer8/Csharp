using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class HumanComparer
    {

        public int Compare(User h1, User h2)
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
