namespace Hillel_Lesson3_HW;

public class AddProcessorMenu
{
    public static void Add_Processor_Menu()
    {
        UI.ShowProcessorMenu();
        
        int choice = BL.GetNumber();

        switch (choice)
        {
            case 1:
                Devices.computer.AddDevice(Devices.processor);
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