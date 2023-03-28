namespace Hillel_Lesson3_HW;

public class Devices
{
    public static Computer computer = new Computer();
    
    public static Processor processor = new Processor("Intel");

    public static RAM ram1 = new RAM("KingSton", 4192);
    public static RAM ram2 = new RAM("Kingston", 8096);
    public static RAM ram3 = new RAM("HyperX", 4192);
    public static RAM ram4 = new RAM("HyperX", 8096);

    public static HDD hdd1 = new HDD("Western Digital", 1);
    public static HDD hdd2 = new HDD("Western Digital", 2);
}