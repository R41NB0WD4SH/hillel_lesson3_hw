namespace Hillel_Lesson3_HW;

public class AddMenu
{
    public static void Add_Menu()
    {
        UI.ShowAddMenu();
        
        int choice = BL.GetNumber();

        switch (choice)
        {
            case 1:
                Console.Clear();
                AddProcessorMenu.Add_Processor_Menu();
                break;
            case 2:
                Console.Clear();
                AddRAMMenu.Add_RAM_Menu();
                break;
            case 3:
                Console.Clear();
                AddHDDMenu.Add_HDD_Menu();
                break;
            default:
                    break;
        }







    }
}