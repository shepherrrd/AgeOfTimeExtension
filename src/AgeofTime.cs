namespace AgeOfTime;

public static class AgeOfTime 
{
    public static string AgeofTime(this DateTimeOffset date)
    {
        DateTime now = DateTime.Now;
        TimeSpan timeSincePost = date - now ;
       // return Math.Round(timeSincePost.TotalDays).ToString();
        if (Math.Round(timeSincePost.TotalDays) >= 365)
        {
            int years = (int) Math.Round(timeSincePost.TotalDays / 365);
            return $"{years} year{(years > 1 ? "s" : "")} ago";
        }
        else if (Math.Round(timeSincePost.TotalDays) >= 30)
        {
            int months = (int)Math.Round((timeSincePost.TotalDays / 30));
            return $"{months} month{(months > 1 ? "s" : "")} ago";
        }
        else if (Math.Round(timeSincePost.TotalDays) >= 7)
        {
            int weeks = (int)Math.Round((timeSincePost.TotalDays / 7));
            return $"{weeks} week{(weeks > 1 ? "s" : "")} ago";
        }
        else if (Math.Round(timeSincePost.TotalDays) >= 1)
        {
            int days = (int)Math.Round(timeSincePost.TotalDays);
            return $"{days} day{(days > 1 ? "s" : "")} ago";
        }
        else if (Math.Round(timeSincePost.TotalHours) >= 1)
        {
            int hours = (int) Math.Round(timeSincePost.TotalHours);
            return $"{hours} hour{(hours > 1 ? "s" : "")} ago";
        }
        else if (Math.Round(timeSincePost.TotalMinutes) >= 1)
        {
            int minutes = (int)Math.Round(timeSincePost.TotalMinutes);
            return $"{minutes} minute{(minutes > 1 ? "s" : "")} ago";
        }
        else
        {
            int seconds = (int)Math.Round(timeSincePost.TotalSeconds);
            return $"{seconds} second{(seconds > 1 ? "s" : "")} ago";
        }

    }
    public static string AgeofTime(this DateTime date)
    {
        DateTime now = DateTime.Now;

        TimeSpan timeSincePost = date - now  ;

        if (Math.Round(timeSincePost.TotalDays) >= 365)
        {
            int years = (int)Math.Round(timeSincePost.TotalDays / 365);
            return $"{years} year{(years > 1 ? "s" : "")} ago";
        }
        else if (Math.Round(timeSincePost.TotalDays) >= 30)
        {
            int months = (int)(Math.Round(timeSincePost.TotalDays) / 30);
            return $"{months} month{(months > 1 ? "s" : "")} ago";
        }
        else if (Math.Round(timeSincePost.TotalDays) >= 7)
        {
            int weeks = (int)Math.Round(timeSincePost.TotalDays / 7);
            return $"{weeks} week{(weeks > 1 ? "s" : "")} ago";
        }
        else if (Math.Round(timeSincePost.TotalDays)  >= 1)
        {
            int days = (int)Math.Round(timeSincePost.TotalDays);
            return $"{days} day{(days > 1 ? "s" : "")} ago";
        }
        else if (Math.Round(timeSincePost.TotalHours) >= 1)
        {
            int hours = (int)Math.Round(timeSincePost.TotalHours);
            return $"{hours} hour{(hours > 1 ? "s" : "")} ago";
        }
        else if (Math.Round(timeSincePost.TotalMinutes) >= 1)
        {
            int minutes = (int)Math.Round(timeSincePost.TotalMinutes);
            return $"{minutes} minute{(minutes > 1 ? "s" : "")} ago";
        }
        else
        {
            int seconds = (int)Math.Round(timeSincePost.TotalSeconds);
            return $"{seconds} second{(seconds > 1 ? "s" : "")} ago";
        }
    }
}