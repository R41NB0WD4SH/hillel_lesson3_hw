namespace Hillel_Lesson3_HW;

public class UI
{

    public static void ShowMainMenu()
    {
        Console.WriteLine("-=-=-=-=- Computer Configurator -=-=-=-=-");

        Console.WriteLine("1 - Show Computer Configuration");
        Console.WriteLine("2 - Add Component");
        Console.WriteLine("3 - Remove Component");
        Console.WriteLine();
        Console.WriteLine("0 - Exit");
    }
    
    public static void ShowAddMenu()
    {
        Console.WriteLine("-=-=-=-=- Add Menu -=-=-=-=-");
        Console.WriteLine();
        Console.WriteLine("What would you like to add?");

        Console.WriteLine("1 - Processor");
        Console.WriteLine("2 - RAM");
        Console.WriteLine("3 - HDD");
    }

    public static void ShowRemoveMenu()
    {
        Console.WriteLine("-=-=-=-=- Remove Menu -=-=-=-=-");
        Console.WriteLine();
        // Console.WriteLine("What would you like to remove?");
        //
        // Console.WriteLine("1 - Processor");
        // Console.WriteLine("2 - RAM");
        // Console.WriteLine("3 - HDD");
    }

    public static void ShowProcessorRemoveMenu()
    {
        Console.WriteLine("Choose Processor to Remove");
        Console.WriteLine();
        
    }

    public static void ShowProcessorMenu()
    {
        Console.WriteLine("Choose a processor");
        Console.WriteLine();
        Console.WriteLine("1 - Intel");
        Console.WriteLine();
        Console.WriteLine("9 - Back");
    }

    public static void ShowRAMMenu()
    {
        Console.WriteLine("Choose RAM");
        Console.WriteLine();
        Console.WriteLine("1 - Kingston, 4196 MB");
        Console.WriteLine("2 - Kingston, 8092 MB");
        Console.WriteLine("3 - HyperX, 4196 MB");
        Console.WriteLine("4 - HyperX, 8092 MB");
        Console.WriteLine();
        Console.WriteLine("9 - Back");
    }

    public static void ShowHDDMenu()
    {
        Console.WriteLine("Choose HDD");
        Console.WriteLine();
        Console.WriteLine("1 - Western Digital, 1 TB");
        Console.WriteLine("2 - Western Digital, 2 TB");
        Console.WriteLine();
        Console.WriteLine("9 - Back");
    }

    public static void ShowPressAnyKey()
    {
        Console.WriteLine("Press any key to return...");
    }

    public static void ShowAddedTitle()
    {
        Console.WriteLine("Added");
    }
    

    public static void ShowConfiguration(Computer computer)
    {
        ShowProcessor(computer);
        ShowAllRAMs(computer);
        ShowAllHDDs(computer);
    }
    
    
    public static void ShowProcessor(Computer computer)
    {
        if (computer.Processor == null)
        {
            Console.WriteLine("Empty processor slot");
        }
        else
        {
            Console.WriteLine("Processor: {0}", computer.Processor.Manufacter);
        }
    }

    
    public static void ShowAllRAMs(Computer computer)
    {
        for (int i = 0; i < computer.RAMs.Length; i++)
        {
            if (computer.RAMs[i] == null)
            {
                Console.WriteLine("Empty RAM Slot");
            }
            else
            {
                ShowRAM(computer.RAMs[i]);
            }
        }
    }
    public static void ShowRAM(RAM RAM)
    {
        Console.WriteLine("RAM: {0}, {1}", RAM.Manufacter, RAM.Capacity);
    }
    

    public static void ShowAllHDDs(Computer computer)
    {
        for (int i = 0; i < computer.HDDs.Length; i++)
        {
            if (computer.HDDs[i] == null)
            {
                Console.WriteLine("Empty HDD Slot");
            }
            else
            {
                ShowHDD(computer.HDDs[i]);
            }
        }
    }

    public static void ShowHDD(HDD HDD)
    {
        Console.WriteLine("HDD: {0}, {1}", HDD.Manufacter, HDD.Capacity);
    }

    
}