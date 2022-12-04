// See https://aka.ms/new-console-template for more information
using AdventOfCode;

Console.WriteLine("Hello, World!");

var input = await File.ReadAllTextAsync("./data.txt");


var inventory = new ElvesItemsInventory(input);


Console.WriteLine("Calories of elf with max calories:");
Console.WriteLine(inventory.CaloriesOfElveWithMaxCalories());
Console.WriteLine();

Console.WriteLine("Sum of Calories of 3 elves with biggest calories");
Console.WriteLine(inventory.SumOfCaloriesOfNElvesWithBiggestCalories(3));
