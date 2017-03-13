namespace WordpressPoster
{
    partial class WordpressPoster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordpressPoster));
            this.cbPostPage = new System.Windows.Forms.ComboBox();
            this.btnDoIt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDraftPublish = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cbPostPage
            // 
            this.cbPostPage.FormattingEnabled = true;
            this.cbPostPage.Items.AddRange(new object[] {
            "post",
            "page"});
            this.cbPostPage.Location = new System.Drawing.Point(39, 58);
            this.cbPostPage.Name = "cbPostPage";
            this.cbPostPage.Size = new System.Drawing.Size(145, 21);
            this.cbPostPage.TabIndex = 0;
            // 
            // btnDoIt
            // 
            this.btnDoIt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDoIt.Enabled = false;
            this.btnDoIt.Location = new System.Drawing.Point(0, 433);
            this.btnDoIt.Name = "btnDoIt";
            this.btnDoIt.Size = new System.Drawing.Size(449, 23);
            this.btnDoIt.TabIndex = 1;
            this.btnDoIt.Text = "DO IT";
            this.btnDoIt.UseVisualStyleBackColor = true;
            this.btnDoIt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type";
            // 
            // cbDraftPublish
            // 
            this.cbDraftPublish.FormattingEnabled = true;
            this.cbDraftPublish.Items.AddRange(new object[] {
            "publish",
            "draft"});
            this.cbDraftPublish.Location = new System.Drawing.Point(291, 58);
            this.cbDraftPublish.Name = "cbDraftPublish";
            this.cbDraftPublish.Size = new System.Drawing.Size(152, 21);
            this.cbDraftPublish.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Content";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(39, 95);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(404, 20);
            this.tbTitle.TabIndex = 7;
            this.tbTitle.TextChanged += new System.EventHandler(this.checkAllTBs);
            // 
            // tbContent
            // 
            this.tbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContent.Location = new System.Drawing.Point(9, 134);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(434, 293);
            this.tbContent.TabIndex = 8;
            this.tbContent.Text = "This is some test text for the content.\r\n\r\nMade possible by excrucio:\r\nhttp://www" +
    ".fiverr.com/users/excrucio/\r\n";
            this.tbContent.TextChanged += new System.EventHandler(this.checkAllTBs);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "URL";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(39, 6);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(144, 20);
            this.tbUser.TabIndex = 12;
            this.tbUser.TextChanged += new System.EventHandler(this.checkAllTBs);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(224, 6);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(219, 20);
            this.tbURL.TabIndex = 13;
            this.tbURL.TextChanged += new System.EventHandler(this.checkAllTBs);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(39, 32);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(144, 20);
            this.tbPass.TabIndex = 16;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.checkAllTBs);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 456);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDraftPublish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoIt);
            this.Controls.Add(this.cbPostPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(465, 270);
            this.Name = "Demo";
            this.Text = "Wordpress Poster";
            this.Load += new System.EventHandler(this.Demo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPostPage;
        private System.Windows.Forms.Button btnDoIt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDraftPublish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tbPass;
    }
}