using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using WebApplication.Common;
using WebApplication.Entities;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class AdminController : Controller
    {
        private GamePortalDbContext _gamePortalDb;
        private OptionsModel _optionsModel;
        private UserInfoModel _userInfoModel;
        private UserModel _userModel;
        private ChangePasswordRequestModel _changePasswordRequestModel;

        private IWebHostEnvironment _iWEbHostEnviroment;
        public AdminController(IWebHostEnvironment webHostEnvironment)
        {
            _iWEbHostEnviroment = webHostEnvironment;
            _gamePortalDb = new GamePortalDbContext(new DbContextOptions<GamePortalDbContext>());
            _optionsModel = new OptionsModel(_gamePortalDb);
            _userInfoModel = new UserInfoModel(_gamePortalDb);
            _userModel = new UserModel(_gamePortalDb);
            _changePasswordRequestModel = new ChangePasswordRequestModel(_gamePortalDb);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult Options()
        {
            return View(_optionsModel.GetOptions());
        }

        [Authorize]
        [HttpGet]
        public IActionResult UpdateOption(int Id)
        {
            Option updateOpt = _optionsModel.GetOptionById(Id);
            return View(updateOpt);
        }

        [Authorize]
        [HttpPost]
        public IActionResult UpdateOption(Option updatedOption)
        {
            if (_optionsModel.UpdateOption(updatedOption))
            {
                return RedirectToAction("Options", "Admin");
            }
            else
            {
                var errModel = new ErrorViewModel();
                errModel.ErrorMessage = "Изменение опции прошло неуспешно";
                return View("MessageInfo", errModel);
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult RemoveOption(int Id)
        {
            Option removeOpt = _optionsModel.GetOptionById(Id);
            var errModel = new ErrorViewModel();
            if (removeOpt != null)
            {
                if (removeOpt.IsSystem)
                {

                    errModel.ErrorMessage = "Удаление системной опции запрещено";
                    return View("MessageInfo", errModel);
                }
                if (_optionsModel.RemoveOption(removeOpt))
                {
                    return RedirectToAction("Options", "Admin");
                }
                else
                {
                    errModel.ErrorMessage = "Ошибка удаления опции";
                    return View("MessageInfo", errModel);
                }
            }
            else
            {
                errModel.ErrorMessage = "Невозможно идентифицировать опцию";
                return View("MessageInfo", errModel);
            }
        }


        [Authorize]
        [HttpGet]
        public IActionResult CreateOption()
        {
            return View();
        }


        [Authorize]
        [HttpPost]
        public IActionResult CreateOption(Option option)
        {
            if (_optionsModel.AddOption(option))
            {
                return RedirectToAction("Options", "Admin");
            }
            else
            {
                var errModel = new ErrorViewModel();
                errModel.ErrorMessage = "Ошибка добавления новой опции";
                return View("MessageInfo", errModel);
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult Profile()
        {
            UserInfo userInfo = _userInfoModel.GetUserInfoByLogin(User.Identity.Name);
            return View("Profile", userInfo);
        }

        [Authorize]
        [HttpGet]
        public IActionResult EditProfile()
        {
            return View("EditProfile", _userInfoModel.GetUserInfoByLogin(User.Identity.Name));
        }
        
        [Authorize]
        [HttpGet]
        public IActionResult SecurityProfile()
        {
            return View("SecurityProfile", _userInfoModel.GetUserInfoByLogin(User.Identity.Name));
        }
        
        [Authorize]
        [HttpPost]
        public IActionResult UpdateProfileInfo(UserInfo userInfo, string login)
        {
            var errModel = new ErrorViewModel();
            var userInf = _userInfoModel.UserInfo(userInfo.Id);

            if(userInf.User.Login.ToLower() != login.ToLower())
            {
                
                _userModel.ChangeLogin(userInf.User.Id, login);     // реализовать замену логина пользователя
            }

           if(_userInfoModel.ChangeInfo(userInfo))                  // реализовать информацию пользователя
            {
                return RedirectToAction("Profile", "Admin");
            } else
            {
                errModel.ErrorMessage = "обновление пользовательских данных неуспешно";
                return View("MessageInfo", errModel);
            }
        }

        [Authorize]
        [HttpPost]
        public IActionResult UploadAvatar(IFormFile avatar)
        {
            var errModel = new ErrorViewModel();
            if (avatar != null && avatar.FileName != "")
            {
                long imgSize = avatar.Length;
                string ext = Path.GetExtension(avatar.FileName).ToLower();

                if (imgSize > 120 * 1024)
                {
                    errModel.ErrorMessage = "Нет доступа к файлу";
                    return View("MessageInfo", errModel);
                }
                if (ext == ".jpg" || ext == ".png" || ext == ".gif" || ext == ".jpeg" || ext == ".jfif" || ext == ".webp")
                {
                    string path = "/admin/media/avatars/";
                    string absDestPath = _iWEbHostEnviroment.WebRootPath + path + User.Identity.Name + ext;

                    using (var fileStream = new FileStream(absDestPath, FileMode.Create))
                    {
                        avatar.CopyTo(fileStream);

                        if (_userInfoModel.ChangeAvatar(path + User.Identity.Name + ext, User.Identity.Name)) {
                            return RedirectToAction("Profile", "Admin");
                        } else
                        {
                            errModel.ErrorMessage = "Смена аватарки прошла неуспешно";
                            return View("MessageInfo", errModel);
                        }
                    }
                }
                else
                {
                    errModel.ErrorMessage = "Файл имеет недопустимый формат";
                    return View("MessageInfo", errModel);
                }
            }
            errModel.ErrorMessage = "Нет доступа к файлу";
            return View("MessageInfo", errModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult PreChangePassword(string newPassword, string email, string oldPassword)
        {
            if(newPassword != null && oldPassword == _userInfoModel.GetUserInfoByLogin(User.Identity.Name).User.Password) 
            {
                var request = new ChangePasswordRequest
                {
                    RequestTime = DateTime.Now,
                    Status = RequestStatus.Active,
                    UserId = _userInfoModel.GetUserInfoByLogin(User.Identity.Name).UserId,
                    Hash = SecurePasswordHasher.Hash(newPassword)
                };

                _changePasswordRequestModel.AddRequest(request);

                EmailSender.SendEmail(email, $"https://localhost:44325/admin/changePassword?hash={request.Hash}");

                var errModel = new ErrorViewModel();

                errModel.ErrorMessage = "Mail sended";

                return View("MessageInfo", errModel );
            }

            return RedirectToAction("SecurityProfile");
        }

        [HttpGet]
        public IActionResult ChangePassword() 
        {
            var pageParams = HttpContext.Request.Query;

            if (pageParams.Keys.Contains("hash"))
            {
                var hash = pageParams["hash"];
                

                var request = _changePasswordRequestModel.GetRequestByHash(hash);

                _userModel.ChangePassword(request.UserId, hash);

            }

            return RedirectToAction("SecurityProfile");
        }
    }
}
