using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace btbuoi4.Models
{
    public class User
    {
        [Required(ErrorMessage = "Tên người dùng không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên người dùng phải từ 3 đến 50 ký tự")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Xác nhận mật khẩu không được để trống")]
        [Compare("Password", ErrorMessage = "Mật khẩu xác nhận không khớp")]
        public string ConfirmPassword { get; set; }
    }
    public class Users : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
