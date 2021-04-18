using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Warren Frank-Danvers
    ///  version 0.2
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Warren";
        private readonly List<Post> posts;

        ///<summary>
        /// Construct an empty news feed. alongside Pre-made Posts for testing purposes
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();
            MessagePost post = new MessagePost(AUTHOR, "Cats are the Best. :D");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "Photo1.jpg", "Purple Cat");
            AddPhotoPost(photoPost);
        }

        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            ConsoleHelper.OutputTitle("Displaying all posts");
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine($"\t\t");   // empty line between posts
            }
            ConsoleHelper.OutputTitle("All Posts Displayed");
        }

        /// <summary>
        /// Remove the Post using id from the news feed.
        /// </summary>
        /// <param name="id"></param>
        public void RemovePost(int id)
        {
            Post post = FindPostById(id);

            if (post == null)
            {
                Console.WriteLine($"    \nPost with ID = {id} does not exist\n");
            }
            else
            {
                Console.WriteLine($"    \nThe following Post {id} has been removed\n");

                if(post is MessagePost mp)
                {
                    mp.Display();
                }
                else if(post is PhotoPost pp)
                {
                    pp.Display();
                }

                posts.Remove(post);
            }
        }

        /// <summary>
        /// Find Post by inputing id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Post FindPostById(int id)
        {
            foreach(Post post in posts)
            {
                if(post.PostId == id)
                {
                    return post;
                }
            }
            return null;
        }

        /// <summary>
        /// Search for post via inputing Author Name
        /// </summary>
        /// <param name="author"></param>
        public void FindPostByAuthor(string author)
        {
            foreach (Post post in posts)
            {
                if(post.Username == author)
                {
                    post.Display();
                    Console.WriteLine($"\n");
                }
            }
        }

        /// <summary>
        /// Find Post By inputing Date of publish using format 'dd/MM/yyyy'
        /// </summary>
        /// <param name="Timestamp"></param>
        public void FindPostByDate(string Timestamp)
        {
            foreach (Post post in posts)
            {
                if(post.Timeday == Timestamp)
                {
                    post.Display();
                    Console.WriteLine($"\n");
                }
            }
        }

        /// <summary>
        /// Like Post using Id
        /// </summary>
        /// <param name="id"></param>
        public void FindLikePost(int id)
        {
            foreach (Post post in posts)
            {
                if (post.PostId == id)
                {
                    post.Like();
                    post.Display();
                    Console.WriteLine($"\n");
                }
            }
        }

        /// <summary>
        /// Unlike Post using Id
        /// </summary>
        /// <param name="id"></param>
        public void FindUnLikePost(int id)
        {
            foreach (Post post in posts)
            {
                if (post.PostId == id)
                {
                    post.Unlike();
                    post.Display();
                    Console.WriteLine($"\n");
                }
            }
        }

        /// <summary>
        /// Add Comment using Id
        /// </summary>
        /// <param name="comment"></param>
        public void AddComment(string comment)
        {
            Console.WriteLine(" Input The ID");
            int id = int.Parse(Console.ReadLine());
            foreach (Post post in posts)
            {
                if (post.PostId == id)
                {
                    post.AddComment(comment);
                    post.Display();
                    Console.WriteLine($"\n");
                }
            }
        }
    }

}
