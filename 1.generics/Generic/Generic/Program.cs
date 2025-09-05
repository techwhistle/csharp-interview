//using Generic;

//var intBox = new IntBox()
//{
//    Value = 1
//};

//var stringBox = new StringBox()
//{
//    Value = "string"
//};

//Console.WriteLine("int box value: " + intBox.Value);
//Console.WriteLine("string box value: " + stringBox.Value);

//var genericIntBox = new Box<int>()
//{
//    Value = 2
//};

//var genericStringBox = new Box<string>()
//{
//    Value = "generic string"
//};

//Console.WriteLine("generic int box value: " + genericIntBox.Value);
//Console.WriteLine("generic string box value: " + genericStringBox.Value);


// generic method
static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}

// ex1:T is int
int x = 5, y = 10;
Console.WriteLine($"old value: x = {x}, y = {y}");
Swap(ref x, ref y);
Console.WriteLine($"new value: x = {x}, y = {y}");

// ex2:T is string
string first = "Alice", second = "Bob";
Console.WriteLine($"old value: first  = {first}, second = {second}");
Swap(ref first, ref second); // also works
Console.WriteLine($"new value: first  = {first}, second = {second}");
