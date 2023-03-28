using System;
using System.Threading.Channels;

namespace Hillel_Lesson3_HW;

public class BL
{


    
    
    
    
    
    

    public static int GetNumber()
    {
        int type = BL.ParseInt(Console.ReadLine());

        return type;
    }


    public static int ParseInt(string numberStr)
    {
        int number;

        bool a = Int32.TryParse(numberStr, out number);

        return number;
    }
    

}