
using System.Globalization;
using Quotes;

string path = @"C:\Users\d1810\Документы\котировки\ABBV-IQFeed-SMART-Stocks-Minute-Trade(1).txt";
List<Bar> barlist = new List<Bar>();

TaskOne();

void TaskOne()
{
    List<string> newBarList = new List<string>();
    barlist = Parser.GetParseArray(path);
    var barsGroupedByDate = barlist.GroupBy(bar => bar.Date);
    foreach (var group in barsGroupedByDate)
    {
       string max = group.Max(bar => bar.High).ToString();
       string min = group.Min(bar => bar.Low).ToString();
       var symbol = group.FirstOrDefault().Symbol;
       var description = group.FirstOrDefault().Description;
       var date = group.FirstOrDefault().Date.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
       string[] allLines = { max, min, symbol, description, date };
       string finishTezt = string.Join(" ", allLines);
       newBarList.Add(finishTezt);
    }
    
    File.WriteAllLines(@"C:\Users\d1810\Документы\котировки\новый файл.txt", newBarList);

}

