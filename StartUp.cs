namespace GenericArrayCreator;

public class StartUp
{
    static void Main(string[] args)
    {
        string[] strings = ArrayCreator.Create(5, "Peter");
        int[] integers = ArrayCreator.Create(10, 33);
    }

}
