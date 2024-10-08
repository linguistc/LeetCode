public class Solution {
    public int DaysBetweenDates(string date1, string date2) {
        //Parsing
        var dt1 = DateTime.Parse(date1);
        var dt2 = DateTime.Parse(date2);

        //TimeSpan object
        var timeSpan = dt1 - dt2;

        //Day property
        var daysDiff = timeSpan.Days;

        return daysDiff < 0 ? -daysDiff : daysDiff;

        //return Math.Abs(daysDiff);
    }
}