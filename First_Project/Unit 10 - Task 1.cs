using System;
using System.IO;

Console.WriteLine("Please input a path to a text file: ");
string filePath = Console.ReadLine();
if (!File.Exists(filePath))
{
    Console.WriteLine("The file does not exist. Please check the path!");
    return;
}

try
{
    int wordCount = 0;
    int sentenceCount = 0;
    string[] firstThreelines = new string[3];
    int lineIndex = 0;

    using(StreamReader sr = new StreamReader(filePath))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            string[] words = line.Split(new char[] { ' ', '\t', '.', ',', ';', ':', '!', '?', '-', '—', '(', ')', '[', ']', '"', '\'' }, StringSplitOptions.RemoveEmptyEntries);
            wordCount += words.Length;

            sentenceCount += line.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

            if(lineIndex < 3)
            {
                firstThreelines[lineIndex] = line;
                lineIndex++;
            }
        }
    }

    string output = @"C:\document\output.txt";
    using(StreamWriter sw = new StreamWriter(output))
    {
        sw.WriteLine($"Number of words: {wordCount}");
        sw.WriteLine($"Number of sentences: {sentenceCount}");
        sw.WriteLine("The first three sentences of the text are: ");
        foreach(string firstLine in firstThreelines)
        {
            if (!string.IsNullOrEmpty(firstLine))
            {
                sw.WriteLine(firstLine);
            }
        }
                
    }
    Console.WriteLine($"The operation is complete! The results are stored in {output}");
}
catch(Exception ex)
{
    Console.WriteLine($"There was a problem: {ex.Message}");
}