using System;
using System.IO;
using System.Windows.Forms;
using WordPressSharp;
using WordPressSharp.Models;

namespace WordpressPoster
{
    public partial class WordpressPoster : Form
    {
        public WordpressPoster()
        {
            InitializeComponent();
        }

        private void Demo_Load(object sender, EventArgs e)
        {
            cbDraftPublish.SelectedIndex = 0;
            cbPostPage.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnDoIt.Enabled = false;

            string type = cbPostPage.SelectedItem.ToString();
            string statuts = cbDraftPublish.SelectedItem.ToString();

            string title = tbTitle.Text;
            string content = tbContent.Text;

            MakeItHappen(type, statuts, title, content);

            btnDoIt.Enabled = true;
        }

        private void MakeItHappen(string type, string statuts, string title, string content)
        {
            try
            {
                if (string.IsNullOrEmpty(tbUser.Text) || string.IsNullOrEmpty(tbPass.Text) || string.IsNullOrEmpty(tbURL.Text)
                        || string.IsNullOrEmpty(tbTitle.Text) || string.IsNullOrEmpty(tbContent.Text))
                {
                    MessageBox.Show("Check inputs!");
                    return;
                }

                var post = new Post
                {
                    PostType = type, // "post" or "page"
                    Title = title,
                    Content = content,
                    PublishDateTime = DateTime.UtcNow,
                    Status = statuts // "draft" or "publish"
                };

                var cfg = new WordPressSiteConfig
                {
                    BaseUrl = tbURL.Text.Trim(),
                    BlogId = 1,
                    Username = tbUser.Text,
                    Password = tbPass.Text
                };

                using (var client = new WordPressClient(cfg))
                {
                    string idstr = client.NewPost(post);
                    int id = 0;

                    if (int.TryParse(idstr, out id) && id > 0)
                    {
                        MessageBox.Show("Success!");
                    }
                    else
                    {
                        MessageBox.Show("Failed!");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured. Check log for details.");
                File.WriteAllText("log.log", e.ToString());
            }
        }

        private void checkAllTBs(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUser.Text) && !string.IsNullOrEmpty(tbPass.Text) && !string.IsNullOrEmpty(tbURL.Text)
                        && !string.IsNullOrEmpty(tbTitle.Text) && !string.IsNullOrEmpty(tbContent.Text))
            {
                btnDoIt.Enabled = true;
            }
            else
            {
                btnDoIt.Enabled = false;
            }
        }
    }
}