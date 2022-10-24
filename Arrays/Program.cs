using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static int weapon;
        static string[] weaponName = new string[5];
        static int[] weaponShotCount = new int[5];

        static int[] ammo = new int[5];

        static int[] maxAmmo = new int[5];

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            weapon = 4;

            weaponName[0] = "Pistol";
            weaponName[1] = "Shot Gun";
            weaponName[2] = "Spreader";
            weaponName[3] = "Laser";
            weaponName[4] = "Rocket Launcher";

            weaponShotCount[0] = -1;
            weaponShotCount[1] = -1;
            weaponShotCount[2] = -3;
            weaponShotCount[3] = -2;
            weaponShotCount[4] = -1;

            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 50;
            ammo[3] = 25;
            ammo[4] = 4;

            maxAmmo[0] = 6;
            maxAmmo[1] = 2;
            maxAmmo[2] = 50;
            maxAmmo[3] = 25;
            maxAmmo[4] = 4;

            weapon = 4;
            Fire();
            Fire();
            Fire();
            Fire();

            Console.WriteLine("Current weapon name: " + weaponName[weapon]);
            Console.WriteLine("Weapon Ammo: " + ammo[weapon]);
            Reload();
            Console.WriteLine("Current weapon name: " + weaponName[weapon]);
            Console.WriteLine("Weapon Ammo: " + ammo[weapon]);
            Console.ReadKey(true);
        }

        static void Fire()
        {
            ammo[weapon] += weaponShotCount[weapon];
        }

        static void Reload()
        {
            ammo[weapon] = maxAmmo[weapon];
        }
    }

    

    
}
