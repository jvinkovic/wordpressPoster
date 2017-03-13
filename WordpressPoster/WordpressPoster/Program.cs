using System;
using System.Windows.Forms;

namespace WordpressPoster
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WordpressPoster());
        }

        /*
        static void Main(string[] args)
        {
            var post = new Post
            {
                PostType = "page", // "post" or "page"
                Title = "test page by app",
                Content = "some content...",
                PublishDateTime = DateTime.UtcNow,
                Status = "publish" // "draft" or "publish"
                ,
            };

            var customFields = new[]
            {
                new CustomField
                {
                    Key= "my_custom_field", Value="My Custom Value"
                },
                new CustomField
                {
                    Key = "another_custom_field", Value = "Yet another"
                }
            };

            post.CustomFields = customFields;

            var cfg = new WordPressSiteConfig
            {
                BaseUrl = ConfigurationSettings.AppSettings["WordPressBaseUrl"],
                BlogId = int.Parse(ConfigurationSettings.AppSettings["WordPressBlogId"]),
                Username = ConfigurationSettings.AppSettings["WordPressUsername"],
                Password = ConfigurationSettings.AppSettings["WordPressPassword"]
            };

            using (var client = new WordPressClient(cfg))
            {
                var id = client.NewPost(post);
                Console.WriteLine(id);
            }

            Console.ReadLine();
        }
        */
    }
}