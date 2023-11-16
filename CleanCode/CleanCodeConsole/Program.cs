using CleanCodeMethods;

var godless = new GodlessTesting();

Console.WriteLine("This is test for testing RandomHundredInts");

if (godless.RandomHundredInts_ReturnsExpectedList())
{
    Console.WriteLine("Wahoo, the test succeded! \\o/");
}

else
{
    Console.WriteLine("nooo, it failed T_T");
}

