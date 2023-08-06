// Example file for parsing numerical data from strings

string[] NumStrs = {"  1 ", " 1.45  ", "-100", "5e+04 "};

int testint;
float testfloat;
bool result;

// TODO: The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful
foreach (string str in NumStrs) {
  try{
    testfloat = float.Parse(str);
    Console.WriteLine($"Parsed number {str} to float {testfloat}");
    testint = int.Parse(str);
    Console.WriteLine($"Parsed number {str} to int {testint}");
  }
    catch (FormatException ex) {
        Console.WriteLine($"Failed to parse {str} : {ex.Message}\n"); 
    }
}

// TODO: The TryParse method returns 'true' if the parse is successful

result = int.TryParse(NumStrs[0], out testint);
Console.WriteLine($"TryParse result for {NumStrs[0]} is {result} and int value is {testint}");

result = float.TryParse(NumStrs[1], out testfloat);
Console.WriteLine($"TryParse result for {NumStrs[1]} is {result} and float value is {testfloat}");

result = float.TryParse(NumStrs[2], out testfloat);
Console.WriteLine($"TryParse result for {NumStrs[2]} is {result} and float value is {testfloat}");