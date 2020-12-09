using System;
using System.IO;
using System.Linq;

Console.WriteLine($"🎅 should be on {File.ReadAllText("data.txt").Select(c => c == '(' ? 1 : -1).Sum()}");