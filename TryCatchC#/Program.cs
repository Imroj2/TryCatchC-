class Program
{
    static void Main()
    {
        try
        {
            //code might throw an exception
            int result = 10 / int.Parse("0");
        }
        catch (DivideByZeroException ex)
        {
            //Handle specific exception
            Console.WriteLine("Error:" + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Error:" + ex.Message);
        }
    }
}