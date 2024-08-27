using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using WebApplication.Common;
using WebApplication.Entities;
using WebApplication.Models;
using WebApplication.ViewModel;

namespace WebApplication.Controllers
{
    public class BlogController : Controller
    {
        private GamePortalDbContext _gamePortalDb = new GamePortalDbContext(new DbContextOptions<GamePortalDbContext>());

        private TagsModel _tagsModel;
        private CategoryModel _categoryModel;
        private PlatformsModel _platformsModel;
        private BlogIndexModel _blogIndexModel;
        private PostsModel _postsModel;
        private GenresModel _genresModel;
        public BlogController()
        {
            _tagsModel = new TagsModel(_gamePortalDb);
            _categoryModel = new CategoryModel(_gamePortalDb);
            _platformsModel = new PlatformsModel(_gamePortalDb);
            _postsModel = new PostsModel(_gamePortalDb);
            _genresModel = new GenresModel(_gamePortalDb);
            
            _blogIndexModel = new BlogIndexModel();
            _blogIndexModel.PaginateHelper = new PaginateHelper();
            _blogIndexModel.PaginateHelper.CountPosts = _postsModel.GetPostCount();
            _blogIndexModel.PaginateHelper.CountPages =
               (int)System.Math.Ceiling(((double)_blogIndexModel.PaginateHelper.CountPosts / (double)_blogIndexModel.PaginateHelper.PostsPerPage));
        }

        [HttpGet]
        public IActionResult Index()
        {
            var pageParams = HttpContext.Request.Query;
            int pageNumber = -1;
            if (pageParams.Keys.Contains("currPage"))
            {
                pageNumber = Convert.ToInt32(pageParams["currPage"]);
                if(pageNumber >= 1 && pageNumber <= _blogIndexModel.PaginateHelper.CountPages)
                {
                    _blogIndexModel.PaginateHelper.IndexCurrentPage = pageNumber;
                }
            }
            if(pageNumber != -1)
            {
                _blogIndexModel.Posts = _postsModel.GetPosts(
                    _blogIndexModel.PaginateHelper.PostsPerPage,
                    _blogIndexModel.PaginateHelper.PostsPerPage * (pageNumber - 1)
                );
            } else
            {
                _blogIndexModel.Posts = _postsModel.GetPosts();
            }
            

            _blogIndexModel.Tags = _tagsModel.GetTags();
            _blogIndexModel.Categories = _categoryModel.GetParentCategories();
            _blogIndexModel.Platforms = _platformsModel.GetPlatforms();
            _blogIndexModel.Genres = _genresModel.GetGenres();


            return View(_blogIndexModel);
        }
        public IActionResult GetPosts()
        {
            var pageParams = HttpContext.Request.Query;
            if (pageParams.Keys.Contains("tag"))
            {
                _blogIndexModel.Posts = _postsModel.FilteredPostsByTag(pageParams["tag"]);
            }
            else if (pageParams.Keys.Contains("genre"))
            {
                _blogIndexModel.Posts = _postsModel.FilteredPostsByGenre(pageParams["genre"]);
            }
            else if (pageParams.Keys.Contains("category"))
            {
                _blogIndexModel.Posts = _postsModel.FilteredPostsByCategory(pageParams["category"]);
            }
            else if (pageParams.Keys.Contains("platform"))
            {
                _blogIndexModel.Posts = _postsModel.FilteredPostsByPlatform(pageParams["platform"]);
            }
            _blogIndexModel.Tags = _tagsModel.GetTags();
            _blogIndexModel.Categories = _categoryModel.GetParentCategories();
            _blogIndexModel.Platforms = _platformsModel.GetPlatforms();
            _blogIndexModel.Genres = _genresModel.GetGenres();

            return View("Index", _blogIndexModel);          // Рендерим посты определенной категории/типа
        }

        public IActionResult OnePost()
        {
            BlogOnePostModel blogOnePostModel = new BlogOnePostModel();
            var pageParams = HttpContext.Request.Query;

            if (pageParams.Keys.Contains("postSlug"))
            {
                blogOnePostModel.Post = _postsModel.GetPostBySlug(pageParams["postSlug"]);
                blogOnePostModel.Tags = _tagsModel.GetTagsByPostId(blogOnePostModel.Post.Id);

                return View("OnePost", blogOnePostModel);
            }
            return RedirectToAction("Error");
        }
    }
}
