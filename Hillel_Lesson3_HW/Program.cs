using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Hillel_Lesson3_HW
{

    class Programm
    {
        
        
        static void Main(string[] args)
        {

            int exit = 1;
            do
            {
                Console.Clear();
                
                UI.ShowMainMenu();

                int choice = BL.GetNumber();


                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        UI.ShowConfiguration(Devices.computer);
                        UI.ShowPressAnyKey();
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        AddMenu.Add_Menu();
                        break;
                    case 3:
                        Console.Clear();
                        RemoveMenu.Remove_Menu();
                        break;
                    case 0:
                        exit = 0;
                        break;

                    default:
                        break;
                }
            } while (exit != 0);

            Devices.computer.Dispose();
            
            Console.ReadKey();

        }
    }
    

}