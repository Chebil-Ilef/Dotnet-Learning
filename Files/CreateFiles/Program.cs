// Creating and Deleting Files

const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream
using (StreamWriter sw = File.CreateText(filename)) {
    sw.WriteLine("This is a new file");
}

// TODO: Determine if a file exists
const string filename1 = "TestFile1.txt";
Console.WriteLine($"{File.Exists(filename1)}");

if (File.Exists(filename1)) {
    File.Delete(filename1);
}
else {
  using (StreamWriter sw = File.CreateText(filename1)) {
    sw.WriteLine("This is a new file");
  }
}

Console.WriteLine($"{File.Exists(filename1)}");