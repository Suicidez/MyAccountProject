using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAccount.Models.MasterModels
{
    public class mstUser
    {
        [Key]
        [Column(Order = 1)]
        public int RunningId { get; set; }
        [Key]
        [Column(Order = 2)]
        public string UserId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> IsPermission { get; set; }
        public Nullable<int> isCompany { get; set; }
        public Nullable<int> isActive { get; set; }
        public Nullable<int> LoginTimes { get; set; }
        public Nullable<int> isLock { get; set; }
        public Nullable<int> isTrial { get; set; }
        public Nullable<System.DateTime> StartTrial { get; set; }
        public Nullable<System.DateTime> EndTrial { get; set; }
        public Nullable<int> CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    }
}