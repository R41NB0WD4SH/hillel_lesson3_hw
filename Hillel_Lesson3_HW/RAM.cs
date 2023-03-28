namespace Hillel_Lesson3_HW;

public class RAM : IComponent, IEjectable
{
    private string _manufacter;
    private int _capacity;
    
    public string Manufacter
    {
        get
        {
            return _manufacter;
        }
        set
        {
            _manufacter = value;
        }
    }

    public int Capacity
    {
        get
        {
            return _capacity;
        }
        set
        {
            _capacity = value;
        }
    }


    public RAM(string manufacter, int capacity)
    {
        _manufacter = manufacter;
        _capacity = capacity;
    }

    public void AddDevice(IComponent device)
    {
        
    }

    public void EjectRAM(Computer computer, int slot)
    {
        computer.RAMs[slot] = null;
        Console.WriteLine("Removed");
        UI.ShowPressAnyKey();
        Console.ReadKey();
    }
}