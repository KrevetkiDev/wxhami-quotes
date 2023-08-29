
using Quotes;

string path = @"C:\Users\d1810\Документы\котировки\ABBV-IQFeed-SMART-Stocks-Minute-Trade(1).txt";
List<Bar> barlist = new List<Bar>();

TaskOne();

void TaskOne()
{
    List<string> newBarList = new List<string>();
    barlist = Parser.GetParseArray(path);
    Bar barr = new Bar();
    var days = barlist.GroupBy(day => barr.Date);
 
    
    File.WriteAllLines(@"C:\Users\d1810\Документы\котировки\новый файл.txt", newBarList);

}

