//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC5HomeworkWeek1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class 客戶聯絡人
    {
        public int Id { get; set; }
        public int 客戶Id { get; set; }
        public string 職稱 { get; set; }
        public string 姓名 { get; set; }
        public string Email { get; set; }
        public string 手機 { get; set; }
        public string 電話 { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
