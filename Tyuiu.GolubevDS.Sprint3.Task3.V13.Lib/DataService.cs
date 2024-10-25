namespace Tyuiu.GolubevDS.Sprint3.Task3.V13.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task3V13
{
    public int ConvertStringToInt(string value)
    {
        string digits = ""; 

        foreach (char c in value) 
        {
            if (char.IsDigit(c)) 
            {
                digits += c; 
            }
        }

        
        if (int.TryParse(digits, out int result))
        {
            return result; 
        }

      
        return 0;
    }
}
