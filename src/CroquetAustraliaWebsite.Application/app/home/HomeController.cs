﻿using System.Threading.Tasks;
using System.Web.Mvc;
using Casper.Domain.Features.BlogPosts;
using Casper.Domain.Infrastructure;
using CroquetAustraliaWebsite.Application.App.Infrastructure;
using CroquetAustraliaWebsite.Library.Content;

namespace CroquetAustraliaWebsite.Application.App.home
{
    [RoutePrefix("")]
    public class HomeController : ApplicationController
    {
        private readonly IBlogPostRepository _blogPostRepository;
        private readonly IMarkdownTransformer _markdownTransformer;

        public HomeController(IBlogPostRepository blogPostRepository, IMarkdownTransformer markdownTransformer)
        {
            _blogPostRepository = blogPostRepository;
            _markdownTransformer = markdownTransformer;
        }

        [Route("")]
        public async Task<ViewResult> Index()
        {
            var blogPosts = await _blogPostRepository.FindPublishedBlogPostsAsync(new Pagination(1, 10));
            var viewModel = new IndexViewModel(blogPosts, _markdownTransformer);

            return View(viewModel);
        }
    }
}