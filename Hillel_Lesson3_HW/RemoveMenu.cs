namespace Hillel_Lesson3_HW;

public class RemoveMenu
{
    public static void Remove_Menu()
    {
        UI.ShowRemoveMenu();
        
        UI.ShowConfiguration(Devices.computer);
        
        
        int choice = BL.GetNumber();

        switch (choice)
        {
            case 1:
                Console.Clear();
                Devices.computer.Processor.RemoveProcessor(Devices.computer);
                break;
            case 2:
                Devices.computer.RAMs[choice - 2].EjectRAM(Devices.computer, choice - 2);
                break;
            case 3:
                Devices.computer.RAMs[choice - 2].EjectRAM(Devices.computer, choice - 2);
                break;
            case 4:
                Devices.computer.RAMs[choice - 2].EjectRAM(Devices.computer, choice - 2);
                break;
            case 5:
                Devices.computer.RAMs[choice - 2].EjectRAM(Devices.computer, choice - 2);
                break;
            case 6:
                Devices.computer.HDDs[choice - 6].RemoveHDD(Devices.computer, choice - 6);
                break;
            case 7:
                Devices.computer.HDDs[choice - 6].RemoveHDD(Devices.computer, choice - 6);
                break;
            case 9:
                AddMenu.Add_Menu();
                break;
            default:
                Devices.computer.AddDevice(Devices.hdd1);
                break;
        }

        Console.ReadKey();
    }
}