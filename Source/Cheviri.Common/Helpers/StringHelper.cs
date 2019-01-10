﻿using System;
using System.Diagnostics;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Cheviri.Common.Helpers
{
    public static class StringHelper
    {
        public static bool IsAlphabeticalOrUnderscore(this string text)
        {
            var isAlphabetical = new Regex(@"[a-z_]+");

            var isValidated = isAlphabetical.IsMatch(text);
            return isValidated;
        }

        public static bool IsValidPassword(this string text)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");

            var isValidated = hasNumber.IsMatch(text)
                              && hasUpperChar.IsMatch(text)
                              && text.Length > 7;
            return isValidated;
        }

        public static bool IsEmail(this string text)
        {
            try
            {
                var mailAddress = new MailAddress(text);
                return mailAddress.Address == text;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsNotEmail(this string text)
        {
            return !IsEmail(text);
        }

        public static bool IsUid(this string text)
        {
            var isValid = Guid.TryParse(text, out Guid uid);
            return isValid;
        }

        public static bool IsNotUid(this string text)
        {
            return !IsUid(text);
        }

        public static void ValidateUid(this string text)
        {
            if (IsUid(text))
            {
                return;
            }

            var method = new StackTrace().GetFrame(1).GetMethod();

            throw new ArgumentException($"the uid is not valid > {text} [{method.DeclaringType}.{method.Name}]");
        }

        public static string GetNewUid()
        {
            var uid = Guid.NewGuid().ToString("N").ToUpper();
            return uid;
        }

        public static bool IsEmpty(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        public static bool IsNotEmpty(this string text)
        {
            return !IsEmpty(text);
        }

        public static bool IsUrl(this string text)
        {
            var result = Uri.TryCreate(text, UriKind.Absolute, out var uriResult)
                         && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            return result;
        }

        public static bool IsNotUrl(this string text)
        {
            return !IsUrl(text);
        }
    }
}