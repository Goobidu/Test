
// See https://aka.ms/new-console-template for more information
var lines = new List<string>();
using (StreamReader sr = new StreamReader("input.txt"))
{
    string line;
    int count = 0;
    while ((line = sr.ReadLine()) != null)
    {
        string[] parts = line.Split(';');

        for (int i = 0; i < parts.Length; i++)
        {
            if (parts[i] == " true")
            {
                count++;
            }
        }
        
    }
    using (StreamWriter writer = new StreamWriter("output.txt"))
    {
        writer.Write(DateTime.Now.ToString() + ";" + count);
    }

}