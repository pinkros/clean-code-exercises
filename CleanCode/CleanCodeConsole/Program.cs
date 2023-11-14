using CleanCodeMethods;

var godless = new GodlessTesting();

Console.WriteLine("This is test for testing AddString");

if (godless.AddStrings_ReturnOneString())
{
    Console.WriteLine("Wahoo, the test succeded! \\o/");
}

else
{
    Console.WriteLine("nooo, it failed T_T");
}

