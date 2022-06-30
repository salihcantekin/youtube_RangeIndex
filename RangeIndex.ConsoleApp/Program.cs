

var numbers = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Range r = new Range(2, 5);
r = Range.StartAt(6);
r = Range.EndAt(4);




//Index index = Index.FromEnd(1);
//index = new Index(numbers.Length - 1);

//var first = numbers[^2];

var rangeArr = numbers[r];


rangeArr = numbers[2..3];


foreach (var arrItem in rangeArr)
{
    Console.WriteLine(arrItem);
}

Console.ReadLine();



