
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (weekDay == 0)
{
    Console.WriteLine("it`s Sunday!");
}
else if (weekDay == 1)
{
    Console.WriteLine("it`s Monday!");
}
else if (weekDay == 2)
{
    Console.WriteLine("it`s Tuesday!");
}
else if (weekDay == 3)
{
    Console.WriteLine("it`s Wednesday!");
}
else if (weekDay == 4)
{
    Console.WriteLine("it`s Thursday!");
}
else if (weekDay == 5)
{
    Console.WriteLine("it`s Friday!");
}
else
{
    Console.WriteLine("it`s Saturday!");
}

Console.WriteLine("Have a nice day!");

