﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyam.Blog
{
    public static class BlogKeys
    {
        // Global
        public const string SiteName = nameof(SiteName);
        public const string SiteDescription = nameof(SiteDescription);
        public const string SiteIntro = nameof(SiteIntro);
        public const string Navbar = nameof(Navbar);

        // Document
        public const string Title = nameof(Title);
        public const string Lead = nameof(Lead);
        public const string Published = nameof(Published);
        public const string Tags = nameof(Tags);
        public const string ShowInNavbar = nameof(ShowInNavbar);

        // Document (generated by pipelines)
        public const string Excerpt = nameof(Excerpt);
        public const string Content = nameof(Content);
        public const string Posts = nameof(Posts);
        public const string Tag = nameof(Tag);

        // ViewData
        public const string PostListDocuments = nameof(PostListDocuments);
    }
}
