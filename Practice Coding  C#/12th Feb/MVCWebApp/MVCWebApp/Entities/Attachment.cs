//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWebApp.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attachment
    {
        public int AttachmentId { get; set; }
        public int ArticleId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
    
        public virtual Article Article { get; set; }
    }
}
