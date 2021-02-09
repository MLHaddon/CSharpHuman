using System;
using HumanProject.Models;

namespace HumanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Human one = new Human("Mike");
            Human two = new Human("Michael");
            one.Attack(two);
            one.Attack(two);
        }
    }
}
