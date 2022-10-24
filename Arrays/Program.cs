using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int weapon = 4;

            string[] weaponName;
            weaponName = new string[5];

            weaponName[0] = "Pistol";
            weaponName[1] = "Shot Gun";
            weaponName[2] = "Spreader";
            weaponName[3] = "Laser";
            weaponName[4] = "Rocket Launcher";

            int[] ammo;
            ammo = new int[5];

            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 50;
            ammo[3] = 25;
            ammo[4] = 4;

            weapon = 2;

            Console.WriteLine("Current weapon name: " + weaponName[weapon]);
            Console.WriteLine("Weapon Ammo: " + ammo[weapon]);
            Console.ReadKey(true);
        }
    }
}
