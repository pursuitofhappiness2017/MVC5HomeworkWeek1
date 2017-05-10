using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5HomeworkWeek1.Models.ViewModels
{
    public class ClientSummaryViewModel
    {
        public int Id { get; set; }

        /// <summary>
        /// 客戶名稱
        /// </summary>
        public int Name { get; set; }

        /// <summary>
        /// 聯絡人數量
        /// </summary>
        public int ContactTotal { get; set; }

        /// <summary>
        /// 銀行帳戶數量
        /// </summary>
        public int AccountTotal { get; set; }
    }
}