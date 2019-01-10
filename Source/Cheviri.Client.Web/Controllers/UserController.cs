﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

using Cheviri.Client.Web.Helpers;
using Cheviri.Client.Web.Models;
using Cheviri.Common.Helpers;

namespace Cheviri.Client.Web.Controllers
{
    public class UserController : BaseController
    {
        [HttpGet, AllowAnonymous]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpGet, AllowAnonymous]
        public IActionResult ValidateEmail(string email, string token)
        {
            return View();
        }

        [HttpGet, AllowAnonymous]
        public IActionResult ValidateEmailDone()
        {
            return View();
        }

        [HttpGet, AllowAnonymous]
        public IActionResult LogOn()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOff()
        {
            await HttpContext.SignOutAsync();
            return RedirectToHome();
        }

        [HttpGet, AllowAnonymous]
        public IActionResult DemandPasswordReset()
        {
            return View();
        }

        [HttpGet, AllowAnonymous]
        public IActionResult DemandPasswordResetDone()
        {
            return View();
        }

        [HttpGet, AllowAnonymous]
        public IActionResult PasswordReset(string email, string token)
        {
            return View();
        }

        [HttpGet, AllowAnonymous]
        public IActionResult PasswordResetDone()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Profile(string id)
        {
            if (id.IsNotUid())
            {
                return RedirectToAccessDenied();
            }

            return View();
        }

        [HttpGet]
        public IActionResult LoginLogs()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ChangePasswordDone()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Invite()
        {
            return View();
        }

        [HttpGet]
        public IActionResult InviteDone()
        {
            return View();
        }

        [HttpGet, AllowAnonymous]
        public IActionResult AcceptInvite(string email, string token)
        {
            return View();
        }

        [HttpGet, AllowAnonymous]
        public IActionResult AcceptInviteDone()
        {
            return View();
        }
    }
}
