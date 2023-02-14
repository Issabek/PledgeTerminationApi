using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class BankServiceObjectInfo
    {
        public int Id { get; set; }
        public string CityName { get; set; } = null!;
        public string? ExternalSiteId { get; set; }
        public string? DepartmentName { get; set; }
        public string? WorkTime { get; set; }
        public string Address { get; set; } = null!;
        public string GeoPosition { get; set; } = null!;
        public string ObjectTypeName { get; set; } = null!;
        public string? Lat { get; set; }
        public string? Lon { get; set; }
        public string? BpmCityCode { get; set; }
        public string? BpmCityName { get; set; }
        public int? ExternalSiteCityId { get; set; }
        public string? BpmDepCode { get; set; }
        public string? BpmBranchCode { get; set; }
        public string? CityNameKaz { get; set; }
        public string? DepartmentNameKaz { get; set; }
        public string? WorkTimeKaz { get; set; }
        public string? AddressKaz { get; set; }
        public string? ServicesList { get; set; }
        public string? ServicesListKaz { get; set; }
    }
}
