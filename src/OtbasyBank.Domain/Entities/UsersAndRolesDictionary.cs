using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class UsersAndRolesDictionary
    {
        public int ViewId { get; set; }
        public long? UserId { get; set; }
        public string? UserLogin { get; set; }
        public int? UserStatus { get; set; }
        public int? UserType { get; set; }
        public string? OperationModule { get; set; }
        public string? OperationName { get; set; }
        public DateTime? OperationCd { get; set; }
        public string? OperationCb { get; set; }
        public string? OperationDesc { get; set; }
        public string? ActionName { get; set; }
        public string? RoleCode { get; set; }
        public string? RoleName { get; set; }
        public DateTime? RoleCd { get; set; }
        public string? RoleDesc { get; set; }
        public string? RoleCb { get; set; }
        public DateTime? AccessedUserCd { get; set; }
        public string? AccessedUserCb { get; set; }
        public string? AccessedUserJob { get; set; }
        public string? AccessedUserDesc { get; set; }
        public DateTime? RoleOperationCd { get; set; }
        public string? RoleOperationDesc { get; set; }
        public int? RoleOperationId { get; set; }
        public int? RoleId { get; set; }
        public int? ActionId { get; set; }
        public int? OperationId { get; set; }
        public DateTime? AccessEd { get; set; }
        public bool? AccessType { get; set; }
    }
}
