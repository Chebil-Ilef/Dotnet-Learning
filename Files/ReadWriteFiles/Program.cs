// Reading and Writing data from and to files

// Make sure the example file exists
const string filename = "TestFile.txt";

// TODO 1: WriteAllText overwrites a file with the given content
if (!File.Exists(filename)) {
    File.WriteAllText(filename, "This is a new file");
} 

// TODO 3: AppendAllText adds text to an existing file
File.AppendAllText(filename, " , This is more text");

// TODO 4: A FileStream can be opened and written to until closed
using (StreamWriter sw = File.AppendText(filename)) {
    sw.WriteLine("");
    sw.WriteLine("This is even more text");
    sw.WriteLine("and more");
    sw.WriteLine("and more");
}

// TODO 2: ReadAllText reads all the content from a file
if (File.Exists(filename)) {
    string content = File.ReadAllText(filename);
    Console.WriteLine(content);
}
