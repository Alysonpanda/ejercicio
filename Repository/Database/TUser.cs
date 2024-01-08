using Repository.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Database
{

    /// <summary>
    /// 用戶表
    /// </summary>
    public class TUser:CD
    {

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }


        /// <summary>
        /// 使用者姓名
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 密碼
        /// </summary>
        public string Password { get; set; }


        /// <summary>
        /// 電話
        /// </summary>
        public string Phone { get; set; }


        /// <summary>
        ///信箱
        /// </summary>
        public string Email { get; set; }


    }
}
