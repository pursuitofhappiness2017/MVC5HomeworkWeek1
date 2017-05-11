namespace MVC5HomeworkWeek1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(客戶資料概要MetaData))]
    public partial class 客戶資料概要
    {
    }
    
    public partial class 客戶資料概要MetaData
    {
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }
        public Nullable<int> 客戶銀行總數 { get; set; }
        public Nullable<int> 客戶聯絡人總數 { get; set; }
    }
}
