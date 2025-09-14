using System;
using Delegates;

delegate void MyDelegate(string message);
class Program
{
    static void PrintMessage(string message) => Console.WriteLine(message);

    static void SayHi() => Console.WriteLine("Hi!");
    static void SayBye() => Console.WriteLine("Bye!");

    delegate void Notify();

    static void Main()
    {
        #region basic delegate
        //MyDelegate del = PrintMessage;
        //del("Hello from delegate!");
        #endregion

        #region built-in delegate + linq
        //// Action: no return
        //Action<string> greet = name => Console.WriteLine($"Hello {name}!");
        //greet("Alice");

        //// Func: returns a value
        //Func<int, int, int> add = (a,b) => a + b;
        //Console.WriteLine(add(3, 5));

        //// Predicate: returns bool
        //Predicate<int> isEven = x => x % 2 == 0;
        //Console.WriteLine(isEven(4));

        //int[] numbers = { 1, 2, 3, 4, 5, 6 };

        //var evens = numbers.Where(n => n % 2 == 0);
        //Console.WriteLine(string.Join(", ", evens));
        #endregion

        #region Multicast delegate
        //Notify del = SayHi;
        //del += SayBye; // add another handler
        //del(); // both arre called
        #endregion

        #region Event
        //var downloader = new Downloader();

        //downloader.DownloadCompleted += (s, e) =>
        //{
        //    Console.WriteLine("Download finished!");
        //};

        //downloader.StartDownload();
        #endregion

        #region Mini project downloader
        #endregion
    }
}
