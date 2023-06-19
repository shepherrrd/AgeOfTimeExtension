namespace AgeOfTime;

public static class AgeOfTime 
{
    public static string AgeofTime(this DateTimeOffset date)
    {
        DateTime now = DateTime.Now;
        TimeSpan timeSincePost = ( date - now ) ;
      
        if (timeSincePost.TotalDays >= 365)
        {
            int years = (int)(timeSincePost.TotalDays / 365);
            return $"{years} year{(years > 1 ? "s" : "")} ago";
        }
        else if (timeSincePost.TotalDays >= 30)
        {
            int months = (int)(timeSincePost.TotalDays / 30);
            return $"{months} month{(months > 1 ? "s" : "")} ago";
        }
        else if (timeSincePost.TotalDays >= 7)
        {
            int weeks = (int)(timeSincePost.TotalDays / 7);
            return $"{weeks} week{(weeks > 1 ? "s" : "")} ago";
        }
        else if (timeSincePost.TotalDays >= 1)
        {
            int days = (int)timeSincePost.TotalDays;
            return $"{days} day{(days > 1 ? "s" : "")} ago";
        }
        else if (timeSincePost.TotalHours >= 1)
        {
            int hours = (int)timeSincePost.TotalHours;
            return $"{hours} hour{(hours > 1 ? "s" : "")} ago";
        }
        else if (timeSincePost.TotalMinutes >= 1)
        {
            int minutes = (int)timeSincePost.TotalMinutes;
            return $"{minutes} minute{(minutes > 1 ? "s" : "")} ago";
        }
        else
        {
            int seconds = (int)timeSincePost.TotalSeconds;
            return $"{seconds} second{(seconds > 1 ? "s" : "")} ago";
        }

    }
    public static string AgeofTime(this DateTime date)
    {
        DateTime now = DateTime.Now;
   TimeSpan timeSincePost = ( date - now ) ;

        if (timeSincePost.TotalDays >= 365)
        {
            int years = (int)(timeSincePost.TotalDays / 365);
            return $"{years} year{(years > 1 ? "s" : "")} ago";
        }
        else if (timeSincePost.TotalDays >= 30)
        {
            int months = (int)(timeSincePost.TotalDays / 30);
            return $"{months} month{(months > 1 ? "s" : "")} ago";
        }
        else if (timeSincePost.TotalDays >= 7)
        {
            int weeks = (int)(timeSincePost.TotalDays / 7);
            return $"{weeks} week{(weeks > 1 ? "s" : "")} ago";
        }
        else if (timeSincePost.TotalDays >= 1)
        {
            int days = (int)timeSincePost.TotalDays;
            return $"{days} day{(days > 1 ? "s" : "")} ago";
        }
        else if (timeSincePost.TotalHours >= 1)
        {
            int hours = (int)timeSincePost.TotalHours;
            return $"{hours} hour{(hours > 1 ? "s" : "")} ago";
        }
        else if (timeSincePost.TotalMinutes >= 1)
        {
            int minutes = (int)timeSincePost.TotalMinutes;
            return $"{minutes} minute{(minutes > 1 ? "s" : "")} ago";
        }
        else
        {
            int seconds = (int)timeSincePost.TotalSeconds;
            return $"{seconds} second{(seconds > 1 ? "s" : "")} ago";
        }
    }
}