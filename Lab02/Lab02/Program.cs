using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Member[] members = new Member[5];

            Member m1 = new Member()
            {
                FirstName = "Andre",
                LastName = "Hoong",
                Age = 23
            };

            Member m2 = new Member()
            {
                FirstName = "Slick",
                LastName = "Hoss",
                Age = 23
            };

            Member m3 = new Member()
            {
                FirstName = "Jeremy",
                LastName = "Cross",
                Age = 23
            };

            Member m4 = new Member()
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 23
            };

            Member m5 = new Member()
            {
                FirstName = "Cascade",
                LastName = "Optical",
                Age = 23
            };

            members[0] = m1;
            members[1] = m2;
            members[2] = m3;
            members[3] = m4;
            members[4] = m5;


            UI utility = new UI();
            utility.displayMemberArray(members);
        }
    }
}
