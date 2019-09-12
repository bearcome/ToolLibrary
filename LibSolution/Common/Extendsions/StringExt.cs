using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Common.Extendsions
{
    public static class StringExt
    {
        /// <summary>
        /// 手机号   验证 
        /// </summary>
        /// <param name="strVal"></param>
        /// <returns></returns>
        public static bool IsMobileValid(this string strVal)
        {
            if (string.IsNullOrEmpty(strVal)) {
                return false;
            }

            Regex regex = new Regex(Constants.Mobile_Regex);
            return regex.IsMatch(strVal);
        }


        /// <summary>
        /// 座机电话    格式验证
        /// </summary>
        /// <param name="strVal"></param>
        /// <returns></returns>
        public static bool IsTelephoneValid(this string strVal)
        {
            if (string.IsNullOrEmpty(strVal))
            {
                return false;
            }

            Regex regex = new Regex(Constants.Telephone_Regex);
            return regex.IsMatch(strVal);
        }

        /// <summary>
        /// 身份证号    格式验证
        /// </summary>
        /// <param name="strVal"></param>
        /// <returns></returns>
        public static bool IsChineseIDValid(this string strVal)
        {
            if (string.IsNullOrEmpty(strVal))
            {
                return false;
            }

            Regex regex = new Regex(Constants.ChineseID_Regex);
            return regex.IsMatch(strVal);
        }


        /// <summary>
        /// 邮箱    格式验证
        /// </summary>
        /// <param name="strVal"></param>
        /// <returns></returns>
        public static bool IsEmailValid(this string strVal)
        {
            if (string.IsNullOrEmpty(strVal))
            {
                return false;
            }

            Regex regex = new Regex(Constants.Email_Regex);
            return regex.IsMatch(strVal);
        }

        /// <summary>
        /// MAC地址    格式验证
        /// </summary>
        /// <param name="strVal"></param>
        /// <returns></returns>
        public static bool IsMacValid(this string strVal)
        {
            if (string.IsNullOrEmpty(strVal))
            {
                return false;
            }

            Regex regex = new Regex(Constants.MAC_Regex);
            return regex.IsMatch(strVal);
        }


        /// <summary>
        ///弱密码    格式验证
        /// </summary>
        /// <param name="strVal"></param>
        /// <returns></returns>
        public static bool IsPasswordWeakValid(this string strVal)
        {
            if (string.IsNullOrEmpty(strVal))
            {
                return false;
            }

            Regex regex = new Regex(Constants.WeakPassword_Regex);
            return regex.IsMatch(strVal);
        }

        /// <summary>
        ///弱密码    格式验证
        /// </summary>
        /// <param name="strVal"></param>
        /// <returns></returns>
        public static bool IsPasswordStrongValid(this string strVal)
        {
            if (string.IsNullOrEmpty(strVal))
            {
                return false;
            }

            Regex regex = new Regex(Constants.StrongPassword_Regex);
            return regex.IsMatch(strVal);
        }

    }
}
