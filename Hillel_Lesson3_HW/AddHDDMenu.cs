namespace Hillel_Lesson3_HW;

public class AddHDDMenu
{
    public static void Add_HDD_Menu()
    {
        UI.ShowHDDMenu();
        
        int choice = BL.GetNumber();

        switch (choice)
        {
            case 1:
                Devices.computer.AddDevice(Devices.hdd1);
                UI.ShowAddedTitle();
                UI.ShowPressAnyKey();
                Console.ReadKey();
                break;
            case 2:
                Devices.computer.AddDevice(Devices.hdd2);
                break;
            case 9:
                AddMenu.Add_Menu();
                break;
            default:
                Devices.computer.AddDevice(Devices.hdd1);
                break;
        }
    }
}