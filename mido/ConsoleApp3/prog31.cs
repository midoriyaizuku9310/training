using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class prog31
    {
        static void Main()
        {
            person p1 = new person();
            person p2 = new person();

            p1.setDetails(1, "mido", "japan",22);
            p2.setDetails(2, "beidou", "japan",27);

            p1.getDetails();
            p2.getDetails();


        }

    }
}
