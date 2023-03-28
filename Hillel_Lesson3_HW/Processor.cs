namespace Hillel_Lesson3_HW;

public class Processor : IComponent, IUnpluggable
{
    private string _manufacter;

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
    

    public Processor(string manufacter)
    {
        _manufacter = manufacter;
    }
    
    public Processor()
    {
        
    }
    
    ~Processor()
    {
        
    }
    

    public void RemoveProcessor(Computer computer)
    {
        computer.Processor = null;
        Console.WriteLine("Removed");
        Console.ReadKey();
    }

    public void AddDevice(IComponent device)
    {
        
    }
}