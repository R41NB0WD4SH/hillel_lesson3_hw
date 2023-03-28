namespace Hillel_Lesson3_HW;

public class Computer : IComponent, IDisposable
{
    private Processor _processor;
    private RAM[] _rams = new RAM[4];
    private HDD[] _hdds = new HDD[2];



    public Processor Processor
    {
        get
        {
            return _processor;
        }
        set
        {
            _processor = value;
        }
    }

    public RAM[] RAMs
    {
        get
        {
            return _rams;
        }
        set
        {
            _rams = value;
        }
    }

    public HDD[] HDDs
    {
        get
        {
            return _hdds;
        }
        set
        {
            _hdds = value;
        }
    }

    public void AddProcessor(Processor processor)
    {
        _processor = processor;
    }

    public void AddRAM(RAM RAM)
    {
        for (int i = 0; i < _rams.Length; i++)
        {
            if (_rams[i] == null)
            {
                _rams[i] = RAM;

                break;
            }
        }
    }

    public void AddHDD(HDD HDD)
    {
        for (int i = 0; i < _hdds.Length; i++)
        {
            if (_hdds[i] == null)
            {
                _hdds[i] = HDD;

                break;
            }
        }
    }

    public void AddDevice(IComponent source)
    {
        IComponent device;

        switch (source)
        {
        case Hillel_Lesson3_HW.Processor:
            AddProcessor(source as Processor);
            break;
        case RAM:
            AddRAM(source as RAM);
            break;
        case HDD:
            AddHDD(source as HDD);
            break;
        default:
            break;
        }
    }


    public void Dispose()
    {
        Devices.computer.Processor.RemoveProcessor(Devices.computer);

        for (int i = 0; i < Devices.computer.RAMs.Length; i++)
        {
            Devices.computer.RAMs[i].EjectRAM(Devices.computer, i);
        }

        for (int i = 0; i < Devices.computer.HDDs.Length; i++)
        {
            Devices.computer.HDDs[i].RemoveHDD(Devices.computer, i);
        }
    }
}