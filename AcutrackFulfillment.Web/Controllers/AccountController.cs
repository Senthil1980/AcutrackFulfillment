using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcutrackFulfillment.Infrastructure.Identity;
using AcutrackFulfillment.Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace com.Acutrack.Fulfillment.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    //[Authorize(IdentityServerConstants.LocalApi.PolicyName)]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
      //  private readonly IEmailSender _emailSender;
       // private readonly IAppLogger<AccountController> _logger;
       // private readonly UrlEncoder _urlEncoder;


        private const string AuthenicatorUriFormat = "otpauth://totp/{0}:{1}?secret={2}&issuer={0}&digits=6";
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
          
        }
        [TempData]
        public string StatusMessage { get; set; }



        [HttpGet]
        public  void MyAccount()
        {
            //var user = await _userManager.GetUserAsync(User);
            //if (user == null)
            //{
            //    throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            //}

            //var model = new IndexViewModel
            //{
            //    Username = user.UserName,
            //    Email = user.Email,
            //    PhoneNumber = user.PhoneNumber,
            //    IsEmailConfirmed = user.EmailConfirmed,
            //    StatusMessage = StatusMessage
            //};

            // return View(model);
        }
    }
}