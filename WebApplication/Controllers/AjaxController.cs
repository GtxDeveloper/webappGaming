using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using System.Text.Json;
using WebApplication.Entities;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class AjaxController : Controller
    {
        private GamePortalDbContext _gamePortalDb = new GamePortalDbContext(new DbContextOptions<GamePortalDbContext>());

        private CommentModel _commentModel;
        private PostsModel _postsModel;

        public AjaxController()
        {
            _commentModel = new CommentModel(_gamePortalDb);
            _postsModel = new PostsModel(_gamePortalDb);
        }
        public IActionResult Index()
        {
            return Json("{'error': 404}");
        }

        [HttpGet]
        public JsonResult GetAllComments()
        {
            int postId = -1;
            var pageParams = HttpContext.Request.Query;
            if (pageParams.Keys.Contains("postId"))
            {
                postId = int.Parse(pageParams["postId"]);
                if (postId >= 1)
                {
                    JsonSerializerOptions jso = new JsonSerializerOptions();
                    jso.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
                    return Json(_commentModel.GetCommentsTreeByPostId(postId), jso);
                }
            }
            return Json("{'error': 404, 'message':'Post not found'}");
        }

        [HttpPost]
        public JsonResult SaveComment(int? parentId, string visitorName, string visitorEmail, string text, int postId)
        {
            // 1. Получаем
            // 2. Проверяем на валидность входящие данные
            // 3. Сохраняем в бд
            // 4. отправляем ответ: успех/неудача

            if(_commentModel.AddComment(new Comment() {PostId = postId, ParentId = parentId, VisitorEmail = visitorEmail, VisitorName = visitorName, Text = text })) {
                return Json("{\"status\":\"succsess\"}");
            } else
            {
                return Json("{\"status\":\"error\"}");
            }
        }

        [HttpGet]
        public JsonResult GetLastPosts()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Json(_postsModel.GetLastPosts(4), jso);
        }
    }
}
