using System;
using System.IO;
using System.Collections.Generic;

namespace Ex_7A_C_Military_Unit_Implementing_Inheritance
{
    class Program
    {
        static void Main()
        {
            string Mission="";

            // Create a new Soldier object
            Personnel Soldier = new Personnel();
            // Creates a new Vehicle object
            Vehicles drives = new Vehicles();
            //Calls the uniform and branch of service object
            Console.WriteLine("They are in the "+ Soldier.BranchOfService + " and all wear "+ Soldier.uniform);
            Console.WriteLine("Would you like to send them on a mission?");
            Console.WriteLine("\n");
            Mission = Console.ReadLine();
            Console.WriteLine("\n");
            switch (Mission)
            {
                   case "yes":
                        Missions Quest = new Missions();
                        break;

                    case "no":
                        Console.WriteLine("All the soldiers are staying home and playing XBox then.");
                        break;

                    default:
                    Console.WriteLine("Please input yes or no");
                        break;
                        
            }
            Console.WriteLine("\n");
        }

        /* Write your parent classes first. These will be the classes you will subclass to create the appropriate objects. 
         * For example, you might have a personnel class, a weapons class, a missions class, and a vehicles class. */

        public class DoD // DoD Parent or Base Class
        {
            public string uniform="Cammo";
            
        }

        /* If you chose to implement Option 2 in the first part, in this part, implement the appropriate subclasses. 
        * For example, if one of your parent classes is Weapon, in this class you may elect to implement SmallCaliberWeapon, 
        * IndirectFireWeapon, and DirectFireWeapon. */

        public class Army : DoD // Army inheriting uniform fields from the DoD
        {
            public string BranchOfService = "Army";

        }
        
        public class Personnel : Army // Personnel inheriting from Army and DoD
        {
            string Name;
            string Age;
            int HeightInInches;
            int WeightInPounds;
            //uniform="Desert";

            public Personnel() // Constructor for Personnel
            {
                int count = 0;
                int numSoldiers;
                string VehicleType = "";

                // Instantiate a random name generator using datetime as a seed.
                Random rand = new Random(DateTime.Now.Second); 
                // Questions user how many soldiers they would like to add to their platoon.
                Console.WriteLine("How many soldiers would you like to recruit?");
                // Reads the users response and converts if from a string to an integer
                numSoldiers = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n"); // Line break
                //Lets the user know how many soldiers have been added to their unit after personnel runs n times per user request. 
                Console.WriteLine("You have new Soldier(s) in your unit with the following details: ");
                //Continues to add soldiers to the platoon until the number of Soldiers the user requested reaches 0.
                while (numSoldiers > 0)
                {
                    // Assigns a random name to new personnel
                    string[] NameList = { "Bob", "Eric", "Jonesy", "Tom", "Smith", "Fred", "Richard", "Caleb", "Frank", "Danny", "Anthony", "Chris" };
                    string rName = NameList[rand.Next(NameList.Length)];
                    Console.WriteLine("Name :" + rName);
                    Name = rName;

                    // Assigns a random age to new personnel
                    string[] AgeList = { "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36" };
                    string rAge = AgeList[rand.Next(AgeList.Length)];
                    Console.WriteLine("Age :" + rAge);
                    Age = rAge;

                    // Assigns a random height to new personnel
                    string[] HeightList = { "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78" };
                    string rHeight = HeightList[rand.Next(HeightList.Length)];
                    Console.WriteLine("Height :" + rHeight + " inches");
                    Age = rHeight;

                    // Assigns a random weight to new personnel
                    string[] WeightList = { "175", "180", "185", "190", "195", "200", "205", "210", "215", "220", "225", "230", "235", "240", "245", "250", "255", "260", "265" };
                    string rWeight = WeightList[rand.Next(WeightList.Length)];
                    Console.WriteLine("Weight :" + rWeight + " lbs");
                    Age = rWeight;

                    // Assigns a random vehicle to each person
                    string[] VehicleList = { "Humm-V", "POV", "TANK", "C-130", "FMTV", "LMTV" };
                    string rVehicle = VehicleList[rand.Next(VehicleList.Length)];
                    Console.WriteLine("Drives :" + rVehicle);
                    VehicleType = rVehicle;

                    // Assigns each person a random weapon
                    string[] WeaponList = { "9mm Pistol", "40 Caliber Pistol", "45 Caliber Pistol", "M16-A2 Rifle", "M4 Rifle", "M203 Rocket Launcher", "M249 SAW Machine Gun", "Gatling Machine Gun", "Hand Grenades" };
                    string rWeapon = WeaponList[rand.Next(WeaponList.Length)];
                    Console.WriteLine("Carries :" + rWeapon);
                    Console.WriteLine("\n");
                    numSoldiers--;
                    count++;

                    
                }
                
                Console.WriteLine("You now have " + count + " soldiers in your Platoon.");
            }
        }

 
         public class Vehicles
         {

            public Vehicles()
            {

            }

            private Vehicles(string VehicleType)
            {
                string drives = "";
                switch (VehicleType)
                {
                    case "POV":
                        drives = "POV";
                        break;
                    case "TANK":
                        drives = "TANK";
                        break;
                    case "LMTV":
                        drives = "LMTV";
                        break;
                    case "FMTV":
                        drives = "FMTV";
                        break;
                    default:
                        Console.WriteLine("They fly to work");
                        drives = "C-130";
                        break;
                        Console.WriteLine("\n");
                }
            }
         }

        class Missions
        {
            Random rand = new Random(DateTime.Now.Second);
            public Missions()
            {
                string Location;

                // Assigns a random location to for the platoon to do their mission
                string[] LocationList = { "Kuwait", "Quatar", "Iraq", "Serbia", "S.Korea", "Afghanistan" };
                string rLocation = LocationList[rand.Next(LocationList.Length)];
                Location = rLocation;
                Console.WriteLine("Your platoon deploys to "+ Location);

                
                // Randomly chooses whether the mission was successful or not
                string[] SuccessList = {"yes", "no"};
                string rSuccess = SuccessList[rand.Next(SuccessList.Length)];
                //SuccessList = rSuccess;
                
                switch (rSuccess)
                {
                    case "yes":
                        Console.WriteLine("Your troops were successful and all came home safely");
                        break;

                    case "no":
                        Console.WriteLine("Your troops failed their mission and died... sorry");
                        break;
                    default:
                        Console.WriteLine("Please input yes or no");
                        break;
                }
                

            }

           
        }

    }

}
