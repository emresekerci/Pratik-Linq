using System.Threading.Channels;

Random random = new Random();
List<int> numbers = new List<int>();

// -50 ile 50 arasında rastgele sayı eklememizi sağlayan kod bloğu.
for (int i = 0; i < 10; i++)
{
    numbers.Add(random.Next(-50, 51));
}

Console.WriteLine("Rastgele oluşturulan sayılar:");
numbers.ForEach(num => Console.WriteLine(num + " "));
Console.WriteLine("-------------------------------------------");


// Çift olan sayılar
var evenNumbers = numbers.Where(n => n % 2 == 0);
Console.WriteLine("Çift sayılar:");
evenNumbers.ToList().ForEach(num => Console.Write(num + " "));
Console.WriteLine();

// Tek olan sayılar
var oddNumbers = numbers.Where(n => n % 2 != 0);
Console.WriteLine("Tek sayılar:");
oddNumbers.ToList().ForEach(num => Console.Write(num + " "));
Console.WriteLine();

// Negatif sayılar
var negativeNumbers = numbers.Where(n => n < 0);
Console.WriteLine("Negatif sayılar:");
negativeNumbers.ToList().ForEach(num => Console.Write(num + " "));
Console.WriteLine();

// Pozitif sayılar
var positiveNumbers = numbers.Where(n => n > 0);
Console.WriteLine("Pozitif sayılar:");
positiveNumbers.ToList().ForEach(num => Console.Write(num + " "));
Console.WriteLine();

// 15'ten büyük ve 22'den küçük sayılar
var rangeNumbers = numbers.Where(n => n > 15 && n < 22);
Console.WriteLine("15'ten büyük ve 22'den küçük sayılar:");
rangeNumbers.ToList().ForEach(num => Console.Write(num + " "));
Console.WriteLine();

// Listedeki her bir sayının karesi
var squaredNumbers = numbers.Select(n => n * n).ToList();
Console.WriteLine("Listedeki sayıların kareleri:");
squaredNumbers.ForEach(num => Console.Write(num + " "));
Console.WriteLine();