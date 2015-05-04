//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrackedFile
    {
        public TrackedFile()
        {
            this.SearchJobs = new HashSet<SearchJob>();
            this.Categories = new HashSet<Category>();
            this.ShrinkJobs = new HashSet<ShrinkJob>();
            this.ReductionLogs = new HashSet<ReductionLog>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullPath { get; set; }
        public Nullable<long> Length { get; set; }
        public string Extension { get; set; }
        public string PreHash { get; set; }
        public string MD5 { get; set; }
        public string SHA1 { get; set; }
        public string SHA256 { get; set; }
        public bool TrackForUpdates { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastSeen { get; set; }
        public int TrackedFolderId { get; set; }
    
        public virtual TrackedFolder TrackedFolder { get; set; }
        public virtual ICollection<SearchJob> SearchJobs { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<ShrinkJob> ShrinkJobs { get; set; }
        public virtual ICollection<ReductionLog> ReductionLogs { get; set; }
    }
}
