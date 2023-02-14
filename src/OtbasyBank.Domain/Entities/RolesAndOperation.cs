using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class RolesAndOperation
    {
        public int ViewId { get; set; }
        public string? RoleCode { get; set; }
        public string? RoleName { get; set; }
        public string? RoleDesc { get; set; }
        public string? OperationModule { get; set; }
        public string? OperationName { get; set; }
        public string? OperationDesc { get; set; }
        public string? ActionName { get; set; }
        public DateTime? RoleCd { get; set; }
        public string? RoleCb { get; set; }
        public DateTime? OperationCd { get; set; }
        public string? OperationCb { get; set; }
        public int? RoleId { get; set; }
        public int? OperationId { get; set; }
        public int? ActionId { get; set; }
        public int? RoleOperationId { get; set; }
    }
}
