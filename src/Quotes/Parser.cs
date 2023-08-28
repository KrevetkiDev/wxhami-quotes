namespace Quotes;

public class Parser
{
    List<Bar> GetParseArray(string path)
    {
        string pathh = path;
        var text = File.ReadAllLines(pathh);
        List<Bar> barArray = null;
        
        foreach (var line in text)
        {
            var splitedLine = line.Split(","); 
            Bar bar = new Bar();
                bar.Symbol = splitedLine[0];
                bar.Description = splitedLine[1];
                bar.Date = DateOnly.Parse(splitedLine[2]);
                bar.Time = DateOnly.Parse(splitedLine[3]);
                bar.Open = double.Parse(splitedLine[4]);
                bar.High = double.Parse(splitedLine[5]);
                bar.Low = double.Parse(splitedLine[6]);
                bar.Close = double.Parse(splitedLine[7]);
                bar.TotalVolume = int.Parse(splitedLine[8]);
                barArray.Add(bar);
        }

        return barArray;
    }
}