using StaticClass;

OutputFormatter.FormatMessage("Create a new instance", 1);
OutputFormatter.FormatMessage("Update instance", 2);
OutputFormatter.FormatMessage("Delete instance", 3);


OutputFormatter.FormatMessageWithHeading("Create a new instance", 1, "Instance Management");
OutputFormatter.FormatMessage("Update instance", 2);
OutputFormatter.FormatMessage("Delete instance", 3);

Demo demo = new Demo();
demo.Increase();
demo.Decrease();
demo.Increase();
demo.Increase();
demo.Increase();
demo.Decrease();

Console.WriteLine("Demo: "+ demo.GetCounter());

Demo demo2 = new Demo();
demo2.Increase();
demo2.Increase();
demo2.Decrease();
Console.WriteLine("Demo2:" + demo2.GetCounter());