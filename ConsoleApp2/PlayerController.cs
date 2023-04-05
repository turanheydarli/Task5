using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PlayerController
    {
        private Weapon _weapon;
        private Player _player;

        public PlayerController(Player player)
        {

            _player = player;
        }

        public void EquipWeapon(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            if(_weapon == null)
            {
                Console.WriteLine("Senin silahin yoxdur");
                return;
            }

            _player.Attack();
        }
    }
}
