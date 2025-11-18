public class ParameterDemo
{
    //With ref parameter
    public void Increase(ref int number)
    {
        number += 10;
    }

    //With out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Aaditya Sigdel"; 
    }

    //With params keyword
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}
