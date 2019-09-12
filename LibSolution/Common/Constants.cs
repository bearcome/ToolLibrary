using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Constants
    {
        #region 正则表达式

        /// <summary>
        /// 手机号 
        /// </summary>
        public const string Mobile_Regex = @"^[1]+[3,9]+\d{9}$";

        /// <summary>
        /// 国内座机号  (0511-4405222、021-87888822)
        /// </summary>
        public const string Telephone_Regex = @"^0\d{2,3}-\d{7,8}$";

        /// <summary>
        /// 身份证 
        /// </summary>
        public const string ChineseID_Regex = @"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$";

        /// <summary>
        /// 邮箱 
        /// </summary>
        public const string Email_Regex = @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

        /// <summary>
        /// MAC地址 
        /// </summary>
        public const string MAC_Regex = @"^([0-9a-fA-F]{2})(([/\s:-][0-9a-fA-F]{2}){5})$";

        /// <summary>
        /// 弱密码 (以字母开头，长度在6~18之间，只能包含字母、数字和下划线)
        /// </summary>
        public const string WeakPassword_Regex = @"^[a-zA-Z]\w{5,17}$";

        /// <summary>
        /// 强密码(必须包含大小写字母和数字的组合，不能使用特殊字符，长度在8-10之间)
        /// </summary>
        public const string StrongPassword_Regex = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,10}$";


        #endregion


    }
}
