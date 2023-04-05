using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Player
    {
        public string Name { get; set; }
        public void Attack()
        {
            Console.WriteLine("Player attacked");
        }
    }
}
