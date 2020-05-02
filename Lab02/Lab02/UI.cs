using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class UI
    {
        public  void displayMemberArray (Member[] members)
        {
            Console.WriteLine("FirstName \tLastName \t AgeYears \tAgeDecades\n----------------------------------------------------------");
            foreach (Member m in members)
            {
                Console.WriteLine(string.Format("{0, -15} {1, 9} {2, 9} {3, 21:N1}", m.FirstName, m.LastName, m.Age, m.AgeInDecades()));
            }

            Console.ReadKey();
        }
    }
}
