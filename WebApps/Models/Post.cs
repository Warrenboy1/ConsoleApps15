﻿using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.ComponentModel.DataAnnotations;


namespace WebApps.Models
{
    [Serializable]
    public class Post
    {
        // Primary Key
        public int PostId { get; set; }

        private int likes;

        // private readonly List<String> comments;
        
        // username of the post's author
        [StringLength(20), Required]
        public String Username { get; set; }

        public DateTime Timestamp { get; set; }
        public string Timeday { get; }

        /// <summary>
        /// 
        /// </summary>
        public Post()
        {

            Timestamp = DateTime.Now;
            Timeday = Timestamp.ToShortDateString();

            likes = 0;
        }

        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }

    }
}
