using System.Globalization;

namespace Quotes;

public static class Parser
{
    public static List<Bar> GetParseArray(string path)
    {
        var text = File.ReadAllLines(path);
        List<Bar> barArray = new List<Bar>();

        foreach (var line in text)
        {
            if (line == text[0])
            {
                continue;
            }
            
            var splitedLine = line.Split(","); 
            Bar bar = new Bar();
                bar.Symbol = splitedLine[0];
                bar.Description = splitedLine[1];
                bar.Date = DateOnly.Parse(splitedLine[2]);
                bar.Time = TimeOnly.Parse(splitedLine[3]);
                bar.Open = double.Parse(splitedLine[4], CultureInfo.InvariantCulture);
                bar.High = double.Parse(splitedLine[5], CultureInfo.InvariantCulture);
                bar.Low = double.Parse(splitedLine[6], CultureInfo.InvariantCulture);
                bar.Close = double.Parse(splitedLine[7], CultureInfo.InvariantCulture);
                bar.TotalVolume = int.Parse(splitedLine[8], CultureInfo.InvariantCulture);
            
            barArray.Add(bar);
                
        }

        return barArray;
    }
}