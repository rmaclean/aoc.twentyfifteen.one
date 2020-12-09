using System;
using System.IO;
using System.Linq;

var data = File.ReadAllText("data.txt");
var level = 0;
var charIndex = 0;
foreach (var c in data)
{
    charIndex++;
    level += c == '(' ? 1 : -1;
    if (level < 0)
    {
        Console.WriteLine($"🎅 enters the basement at {charIndex}");
        return;
    }
}

