using ParameterModifier;

var demo = new Demo();

int average = demo.Average(10, 20);
int average2 = demo.Average(10, 20, 30, 40, 30, 90);


int x = 10;
demo.Test1(ref x);
Console.WriteLine(x);

int y = 20;
demo.Test3(out y);
Console.WriteLine(y);