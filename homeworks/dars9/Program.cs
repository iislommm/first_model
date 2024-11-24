
using _9dars.Servises;
using dars9.model;
using System.ComponentModel.Design;


namespace dars9
{
    public class Program
    {

        static void Main(string[] args)
        {
            FrontEnd();
        }

        public static void FrontEnd()
        {

            var postAdress = new PostServis();
            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. GetById");
                Console.WriteLine("6. Get Most Viewed post");
                Console.WriteLine("7. Get Most Liked Post");
                Console.WriteLine("8. Get Post By Comment");
                Console.WriteLine("9. Get Most Commented Post");
                Console.WriteLine("10.Add Like to post");
                Console.WriteLine("11. Add Comment to post");
                Console.WriteLine("12. Add viewer name to post");
                Console.Write("Choose : ");
                var opinion = int.Parse(Console.ReadLine());
                if (opinion == 1)
                {
                    var time = DateTime.Now;
                    Console.WriteLine(time);
                    var post = new Post();
                    Console.Write("Add amount of likes : ");
                    post.Likes = int.Parse(Console.ReadLine());
                    Console.Write("Add owner's name : ");
                    post.OwnerName = (Console.ReadLine());
                    Console.Write("Add posted time : ");
                    post.PostedTime = DateTime.Parse(Console.ReadLine());
                    Console.Write("Add describtion ");
                    post.Describtion = Console.ReadLine();
                    Console.Write("Add type : ");
                    post.Type = Console.ReadLine();
                    postAdress.AddNewPost(post);
                }
                else if (opinion == 2)
                {
                    var posts = postAdress.GetAllPosts();
                    foreach (var post in posts)
                    {
                        Console.WriteLine(post);
                    }
                }
                else if (opinion == 3)
                {

                    var time = DateTime.Now;
                    Console.WriteLine();
                    var post = new Post();
                    Console.WriteLine("Enter id to update : ");
                    var id = Guid.Parse(Console.ReadLine());
                    Console.Write("Add amount of likes : ");
                    post.Likes = int.Parse(Console.ReadLine());
                    Console.Write("Add owner's name : ");
                    post.OwnerName = (Console.ReadLine());
                    Console.Write("Add posted time : ");
                    post.PostedTime = DateTime.Parse(Console.ReadLine());
                    Console.Write("Add describtion ");
                    post.Describtion = Console.ReadLine();
                    Console.Write("Add type : ");
                    post.Type = Console.ReadLine();
                    postAdress.AddNewPost(post);
                }
                else if (opinion == 4)
                {
                    Console.WriteLine("Enter id to update : ");
                    var id = Guid.Parse(Console.ReadLine());
                    var result = postAdress.DeletePost(id);
                    Console.WriteLine(result);
                }
                else if (opinion == 5)
                {
                    Console.WriteLine("Enter Id to get ");
                    var id = Guid.Parse(Console.ReadLine());
                    Post post = postAdress.GetByPostId(id);
                    var result = post;
                }
                else if (opinion == 6)
                {
                    var mostViewedPost = postAdress.GetMostViewedPost();
                    Console.WriteLine(mostViewedPost);
                }
                else if (opinion == 7)
                {
                    var mostLikedPost = postAdress.GetMostLikedPost();
                    Console.WriteLine(mostLikedPost);
                }
                else if (opinion == 8)
                {
                    var mostCommentedPost = postAdress.GetMostCommentedPost();
                    Console.WriteLine(mostCommentedPost);
                }
                else if (opinion == 9)
                {
                    var comment = postAdress.GetPostsByComment();
                }
                else if (opinion == 10)
                {
                    var like = postAdress.AddLike();
                    Console.WriteLine(like);
                }
                else if (opinion == 11)
                {
                    var comment = postAdress.AddComment();
                    Console.WriteLine(comment);
                }
                else if (opinion == 12)
                {
                    var viewrName = postAdress.AddViewerNameToPost();
                    Console.WriteLine(viewrName);
                }
                Console.ReadKey();
                Console.Clear();
            }
                       
        }

        private static object AddNewPost(string? post)
        {
            throw new NotImplementedException();
        }
    }
}
