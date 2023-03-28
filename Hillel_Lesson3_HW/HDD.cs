namespace Hillel_Lesson3_HW;

public class HDD : IComponent, IRemovable
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


    public HDD(string manufacter, int capacity)
    {
        _manufacter = manufacter;
        _capacity = capacity;
    }

    public void AddDevice(IComponent device)
    {
        
    }

    public void RemoveHDD(Computer computer, int slot)
    {
        computer.HDDs[slot] = null;
        Console.WriteLine("Removed");
        UI.ShowPressAnyKey();
        Console.ReadKey();
    }
}