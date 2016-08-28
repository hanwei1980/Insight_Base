//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insight.Base.Common.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYS_User()
        {
            this.SYS_Allot_Record = new HashSet<SYS_Allot_Record>();
            this.SYS_Allot_Record1 = new HashSet<SYS_Allot_Record>();
            this.SYS_Code_Allot = new HashSet<SYS_Code_Allot>();
            this.SYS_Code_Allot1 = new HashSet<SYS_Code_Allot>();
            this.SYS_Code_Scheme = new HashSet<SYS_Code_Scheme>();
            this.SYS_ModuleParam = new HashSet<SYS_ModuleParam>();
            this.SYS_Organization = new HashSet<SYS_Organization>();
            this.SYS_OrgMember = new HashSet<SYS_OrgMember>();
            this.SYS_OrgMember1 = new HashSet<SYS_OrgMember>();
            this.SYS_Role = new HashSet<SYS_Role>();
            this.SYS_Role_Action = new HashSet<SYS_Role_Action>();
            this.SYS_Role_Data = new HashSet<SYS_Role_Data>();
            this.SYS_Role_Member = new HashSet<SYS_Role_Member>();
            this.SYS_UserGroupMember = new HashSet<SYS_UserGroupMember>();
            this.SYS_UserGroup = new HashSet<SYS_UserGroup>();
            this.SYS_UserGroupMember1 = new HashSet<SYS_UserGroupMember>();
        }
    
        public System.Guid ID { get; set; }
        public long SN { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string PayPassword { get; set; }
        public string OpenId { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public bool BuiltIn { get; set; }
        public bool Validity { get; set; }
        public System.Guid CreatorUserId { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Allot_Record> SYS_Allot_Record { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Allot_Record> SYS_Allot_Record1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Code_Allot> SYS_Code_Allot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Code_Allot> SYS_Code_Allot1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Code_Scheme> SYS_Code_Scheme { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_ModuleParam> SYS_ModuleParam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Organization> SYS_Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_OrgMember> SYS_OrgMember { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_OrgMember> SYS_OrgMember1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Role> SYS_Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Role_Action> SYS_Role_Action { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Role_Data> SYS_Role_Data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Role_Member> SYS_Role_Member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_UserGroupMember> SYS_UserGroupMember { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_UserGroup> SYS_UserGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_UserGroupMember> SYS_UserGroupMember1 { get; set; }
    }
}
