using Microsoft.EntityFrameworkCore;
using Repository.Bases;
using Repository.Database.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Database
{

    /// <summary>
    /// 產品表
    /// </summary>
    public class TProduct :CUD_User
    {
        /// <summary>
        /// 品名
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 數量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 價格
        /// </summary>
        
        [Precision(10, 2)]
        public decimal Price { get; set; }

        /// <summary>
        /// 是否上架
        /// </summary>
        public bool IsShow { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        public string? Remarks { get; set; }

    }
}
