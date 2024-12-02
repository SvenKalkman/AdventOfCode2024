using System.Collections.Generic;

string filePath = "data.txt";
string[] lines = File.ReadAllLines(filePath);
var splits = lines.Select(x => x.Split("   ")).ToList();

var firstList = splits.Select(x => int.Parse(x[0])).OrderBy(x => x).ToList();
var secondList = splits.Select(x => int.Parse(x[1])).OrderBy(x => x).ToList();

int totalDist = firstList.Select((x, i) => Math.Abs(x - secondList[i])).Sum();
int similarity = firstList.Select((x, i) => x * secondList.Count(y => (x == y))).Sum();

Console.WriteLine($"total distance: {totalDist}, similarity: {similarity}");
Console.ReadLine();