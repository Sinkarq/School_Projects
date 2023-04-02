static class Program
{ 
    /*
      New implementation: src/libraries/System.Private.CoreLib/src/System/IO/File.cs
      Link: https://github.com/dotnet/runtime/commit/cf49643711ad8aa4685a8054286c1348cef6e1d8
      
      
      Old: https://github.com/dotnet/runtime/blob/release/6.0/src/libraries/System.Private.CoreLib/src/System/IO/File.cs
    */
    
    
    static void Main()
    {
        var path = @"C:\Users\Public\Documents\test.txt";

        var numbers = File.ReadAllLines(path);
        
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        var newNums = numbers.Where(x => int.Parse(x) < 10);
        
        File.WriteAllLines(path, newNums);
    }
}