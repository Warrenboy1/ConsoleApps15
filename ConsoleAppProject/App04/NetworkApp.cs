using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private readonly NewsFeed news = new NewsFeed();


        /// <summary>
        /// Display Menu to be used for App04
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("Social Network");


            string[] choices = new string[]
            {
                "Post Message", "Post Image", "Remove Post",
                "Display All Posts", "Display By Author",
                "Display By Date", "Add Comment", "Like Or Unlike Post",  "Quit"
            };

            bool wantToQuit = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                int choice = ConsoleHelper.SelectChoice("", choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: RemovePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayAllByAuthor(); break;
                    case 6: DisplayByDate(); break;
                    case 7: AddComment(); break;
                    case 8: LikeOrUnlikePost(); break;
                    case 9: wantToQuit = true; break;

                }
            } while (!wantToQuit);
        }

        /// <summary>
        /// Like or Unlike A Post by selecting the ID related
        /// </summary>
        private void LikeOrUnlikePost()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(" Please Type in the ID for the Post to like or dislike");
            int id = int.Parse(Console.ReadLine());
            news.FindPostById(id);

            string[] like = new string[]
            {
                "Like Post", "Unlike Post"
            };

            int choice = ConsoleHelper.SelectChoice("", like);

            switch (choice)
            {
                case 1: news.FindLikePost(id); break;
                case 2: news.FindUnLikePost(id); break;
            
            }
        }

        /// <summary>
        /// Add a comment to the post using ID
        /// </summary>
        private void AddComment()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(" Please Enter the comment youd like to add to the post");

            string comment = Console.ReadLine();
            news.AddComment(comment);
        }

        /// <summary>
        /// Search for Posts Display via date
        /// </summary>
        private void DisplayByDate()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(" Please Enter the Date using this format 'dd/MM/yyyy' > ");

            string dt = Console.ReadLine();

            news.FindPostByDate(dt);
        }

        /// <summary>
        /// Display Posts By Author Name
        /// </summary>
        private void DisplayAllByAuthor()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(" Please enter AUTHOR name > ");

            string author = Console.ReadLine();

            news.FindPostByAuthor(author);
        }

        /// <summary>
        /// Post A Message onto the feed
        /// </summary>
        public void PostMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleHelper.OutputTitle("Posting a message");

            string author = InputName();

            Console.Write(" Please enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle(" You have posted this message:");
            post.Display();
        }

        /// <summary>
        /// Input Name which becomes the author
        /// </summary>
        /// <returns></returns>
        private string InputName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(" Please enter your name > ");
            string author = Console.ReadLine();

            return author;
        }

        /// <summary>
        /// Post Image Onto Feed
        /// </summary>
        private void PostImage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleHelper.OutputTitle("Posting an Image/Photo");

            string author = InputName();

            Console.Write(" Please enter your image filename > ");
            string filename = Console.ReadLine();

            Console.Write(" Please enter your image capion > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("You have posted an image");
            post.Display();

        }

        /// <summary>
        /// Display all Posts within the feed
        /// </summary>
        private void DisplayAll()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            news.Display();
        }

        /// <summary>
        /// Removes a Post depending on ID
        /// </summary>
        private void RemovePost()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleHelper.OutputTitle($"Removing a Post");
            int id = (int)ConsoleHelper.InputNumber(" Please enter the post id > ");
            news.RemovePost(id);
        }
    }
}
