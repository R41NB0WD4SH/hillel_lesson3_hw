namespace Hillel_Lesson3_HW;

public class AddRAMMenu
{
    public static void Add_RAM_Menu()
    {
        UI.ShowRAMMenu();
        
        int choice = BL.GetNumber();

        switch (choice)
        {
            case 1:
                Devices.computer.AddDevice(Devices.ram1);
                UI.ShowAddedTitle();
                UI.ShowPressAnyKey();
                Console.ReadKey();
                break;
            case 2:
                Devices.computer.AddDevice(Devices.ram2);
                UI.ShowAddedTitle();
                UI.ShowPressAnyKey();
                Console.ReadKey();
                break;
            case 3:
                Devices.computer.AddDevice(Devices.ram3);
                UI.ShowAddedTitle();
                UI.ShowPressAnyKey();
                Console.ReadKey();
                break;
            case 4:
                Devices.computer.AddDevice(Devices.ram4);
                UI.ShowAddedTitle();
                UI.ShowPressAnyKey();
                Console.ReadKey();
                break;
            case 9:
                AddMenu.Add_Menu();
                break;
            default:
                Devices.computer.AddDevice(Devices.processor);
                break;
        }
    }
}