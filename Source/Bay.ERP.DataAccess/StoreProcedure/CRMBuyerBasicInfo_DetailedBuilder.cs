// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Apr-2013, 04:34:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMBuyerBasicInfo_DetailedBuilder : IEntityBuilder<CRMBuyerBasicInfo_DetailedEntity>
    {
        IList<CRMBuyerBasicInfo_DetailedEntity> IEntityBuilder<CRMBuyerBasicInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMBuyerBasicInfo_DetailedEntity> CRMBuyerBasicInfo_DetailedEntityList = new List<CRMBuyerBasicInfo_DetailedEntity>();

            while (reader.Read())
            {
                CRMBuyerBasicInfo_DetailedEntityList.Add(((IEntityBuilder<CRMBuyerBasicInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CRMBuyerBasicInfo_DetailedEntityList.Count > 0) ? CRMBuyerBasicInfo_DetailedEntityList : null;
        }

        CRMBuyerBasicInfo_DetailedEntity IEntityBuilder<CRMBuyerBasicInfo_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUYERBASICINFOID = 0;
            const Int32 FLD_BUYERTYPEID = 1;
            const Int32 FLD_CONTACTFULLNAME = 2;
            const Int32 FLD_MOBILENO = 3;
            const Int32 FLD_LANDPHONE = 4;
            const Int32 FLD_PRESENTADDRESS = 5;
            const Int32 FLD_EMAIL = 6;
            const Int32 FLD_INTERESTEDLANDLOCATIONID = 7;
            const Int32 FLD_CITYID = 8;
            const Int32 FLD_AREANEEDEDFROM = 9;
            const Int32 FLD_AREANEEDEDTO = 10;
            const Int32 FLD_PARKINGNEEDED = 11;
            const Int32 FLD_AREAUNITID = 12;
            const Int32 FLD_TOILETNEEDED = 13;
            const Int32 FLD_UNITNEEDED = 14;
            const Int32 FLD_ADVERTISEWAYID = 15;
            const Int32 FLD_LEADGENERATEDBYEMPLOYEEID = 16;
            const Int32 FLD_LEADMANAGEDBYONEEMPLOYEEID = 17;
            const Int32 FLD_LEADMANAGEDBYTWOEMPLOYEEID = 18;
            const Int32 FLD_LEADCONVERSIONDATE = 19;
            const Int32 FLD_PROSPECTFORPROJECT = 20;
            const Int32 FLD_REMARKS = 21;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 22;
            const Int32 FLD_IP = 23;
            const Int32 FLD_CREATEDATE = 24;
            const Int32 FLD_CRMMDBUYERTYPENAME = 25;
            const Int32 FLD_CRMMDLANDLOCATIONNAME = 26;
            const Int32 FLD_MDCITYNAME = 27;
            const Int32 FLD_CRMMDAREAUNITNAME = 28;
            const Int32 FLD_CRMMDADVERTISEWAYNAME = 29;
            const Int32 FLD_LEADGENERATEDBYMEMBERFULLNAME = 30;
            const Int32 FLD_LEADMANAGEDBYONEMEMBERFULLNAME = 31;
            const Int32 FLD_LEADMANAGEDBYTWOMEMBERFULLNAME = 32;
            const Int32 FLD_CREATEDBYMEMBERFULLNAME = 33;
            const Int32 FLD_BDPROJECTPROJECTNAME = 34;
            const Int32 FLD_IMAGEURL = 35;
            const Int32 FLD_COMPANYNAME = 36;
            const Int32 FLD_ROWNUMBER = 37;

            CRMBuyerBasicInfo_DetailedEntity cRMBuyerBasicInfo_DetailedEntity = new CRMBuyerBasicInfo_DetailedEntity();

            cRMBuyerBasicInfo_DetailedEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            cRMBuyerBasicInfo_DetailedEntity.BuyerTypeID = reader.GetInt64(FLD_BUYERTYPEID);
            cRMBuyerBasicInfo_DetailedEntity.ContactFullName = reader.GetString(FLD_CONTACTFULLNAME);
            cRMBuyerBasicInfo_DetailedEntity.MobileNo = reader.GetString(FLD_MOBILENO);
            if (reader.IsDBNull(FLD_LANDPHONE)) { cRMBuyerBasicInfo_DetailedEntity.LandPhone = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.LandPhone = reader.GetString(FLD_LANDPHONE); }
            if (reader.IsDBNull(FLD_PRESENTADDRESS)) { cRMBuyerBasicInfo_DetailedEntity.PresentAddress = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.PresentAddress = reader.GetString(FLD_PRESENTADDRESS); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMBuyerBasicInfo_DetailedEntity.Email = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_INTERESTEDLANDLOCATIONID)) { cRMBuyerBasicInfo_DetailedEntity.InterestedLandLocationID = null; } else { cRMBuyerBasicInfo_DetailedEntity.InterestedLandLocationID = reader.GetInt64(FLD_INTERESTEDLANDLOCATIONID); }
            if (reader.IsDBNull(FLD_CITYID)) { cRMBuyerBasicInfo_DetailedEntity.CityID = null; } else { cRMBuyerBasicInfo_DetailedEntity.CityID = reader.GetInt64(FLD_CITYID); }
            if (reader.IsDBNull(FLD_AREANEEDEDFROM)) { cRMBuyerBasicInfo_DetailedEntity.AreaNeededFrom = null; } else { cRMBuyerBasicInfo_DetailedEntity.AreaNeededFrom = reader.GetDecimal(FLD_AREANEEDEDFROM); }
            if (reader.IsDBNull(FLD_AREANEEDEDTO)) { cRMBuyerBasicInfo_DetailedEntity.AreaNeededTo = null; } else { cRMBuyerBasicInfo_DetailedEntity.AreaNeededTo = reader.GetDecimal(FLD_AREANEEDEDTO); }
            if (reader.IsDBNull(FLD_PARKINGNEEDED)) { cRMBuyerBasicInfo_DetailedEntity.ParkingNeeded = null; } else { cRMBuyerBasicInfo_DetailedEntity.ParkingNeeded = reader.GetDecimal(FLD_PARKINGNEEDED); }
            if (reader.IsDBNull(FLD_AREAUNITID)) { cRMBuyerBasicInfo_DetailedEntity.AreaUnitID = null; } else { cRMBuyerBasicInfo_DetailedEntity.AreaUnitID = reader.GetInt64(FLD_AREAUNITID); }
            if (reader.IsDBNull(FLD_TOILETNEEDED)) { cRMBuyerBasicInfo_DetailedEntity.ToiletNeeded = null; } else { cRMBuyerBasicInfo_DetailedEntity.ToiletNeeded = reader.GetDecimal(FLD_TOILETNEEDED); }
            if (reader.IsDBNull(FLD_UNITNEEDED)) { cRMBuyerBasicInfo_DetailedEntity.UnitNeeded = null; } else { cRMBuyerBasicInfo_DetailedEntity.UnitNeeded = reader.GetDecimal(FLD_UNITNEEDED); }
            if (reader.IsDBNull(FLD_ADVERTISEWAYID)) { cRMBuyerBasicInfo_DetailedEntity.AdvertiseWayID = null; } else { cRMBuyerBasicInfo_DetailedEntity.AdvertiseWayID = reader.GetInt64(FLD_ADVERTISEWAYID); }
            if (reader.IsDBNull(FLD_LEADGENERATEDBYEMPLOYEEID)) { cRMBuyerBasicInfo_DetailedEntity.LeadGeneratedByEmployeeID = null; } else { cRMBuyerBasicInfo_DetailedEntity.LeadGeneratedByEmployeeID = reader.GetInt64(FLD_LEADGENERATEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYONEEMPLOYEEID)) { cRMBuyerBasicInfo_DetailedEntity.LeadManagedByOneEmployeeID = null; } else { cRMBuyerBasicInfo_DetailedEntity.LeadManagedByOneEmployeeID = reader.GetInt64(FLD_LEADMANAGEDBYONEEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYTWOEMPLOYEEID)) { cRMBuyerBasicInfo_DetailedEntity.LeadManagedByTwoEmployeeID = null; } else { cRMBuyerBasicInfo_DetailedEntity.LeadManagedByTwoEmployeeID = reader.GetInt64(FLD_LEADMANAGEDBYTWOEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADCONVERSIONDATE)) { cRMBuyerBasicInfo_DetailedEntity.LeadConversionDate = null; } else { cRMBuyerBasicInfo_DetailedEntity.LeadConversionDate = reader.GetDateTime(FLD_LEADCONVERSIONDATE); }
            if (reader.IsDBNull(FLD_PROSPECTFORPROJECT)) { cRMBuyerBasicInfo_DetailedEntity.ProspectForProject = null; } else { cRMBuyerBasicInfo_DetailedEntity.ProspectForProject = reader.GetInt64(FLD_PROSPECTFORPROJECT); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMBuyerBasicInfo_DetailedEntity.Remarks = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMBuyerBasicInfo_DetailedEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_IP)) { cRMBuyerBasicInfo_DetailedEntity.IP = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.IP = reader.GetString(FLD_IP); }
            cRMBuyerBasicInfo_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_CRMMDBUYERTYPENAME)) { cRMBuyerBasicInfo_DetailedEntity.CRMMDBuyerTypeName = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.CRMMDBuyerTypeName = reader.GetString(FLD_CRMMDBUYERTYPENAME); }
            if (reader.IsDBNull(FLD_CRMMDLANDLOCATIONNAME)) { cRMBuyerBasicInfo_DetailedEntity.CRMMDLandLocationName = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.CRMMDLandLocationName = reader.GetString(FLD_CRMMDLANDLOCATIONNAME); }
            if (reader.IsDBNull(FLD_MDCITYNAME)) { cRMBuyerBasicInfo_DetailedEntity.MDCityName = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.MDCityName = reader.GetString(FLD_MDCITYNAME); }
            if (reader.IsDBNull(FLD_CRMMDAREAUNITNAME)) { cRMBuyerBasicInfo_DetailedEntity.CRMMDAreaUnitName = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.CRMMDAreaUnitName = reader.GetString(FLD_CRMMDAREAUNITNAME); }
            if (reader.IsDBNull(FLD_CRMMDADVERTISEWAYNAME)) { cRMBuyerBasicInfo_DetailedEntity.CRMMDAdvertiseWayName = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.CRMMDAdvertiseWayName = reader.GetString(FLD_CRMMDADVERTISEWAYNAME); }
            if (reader.IsDBNull(FLD_LEADGENERATEDBYMEMBERFULLNAME)) { cRMBuyerBasicInfo_DetailedEntity.LeadGeneratedByMemberFullName = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.LeadGeneratedByMemberFullName = reader.GetString(FLD_LEADGENERATEDBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYONEMEMBERFULLNAME)) { cRMBuyerBasicInfo_DetailedEntity.LeadManagedByOneMemberFullName = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.LeadManagedByOneMemberFullName = reader.GetString(FLD_LEADMANAGEDBYONEMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYTWOMEMBERFULLNAME)) { cRMBuyerBasicInfo_DetailedEntity.LeadManagedByTwoMemberFullName = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.LeadManagedByTwoMemberFullName = reader.GetString(FLD_LEADMANAGEDBYTWOMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_CREATEDBYMEMBERFULLNAME)) { cRMBuyerBasicInfo_DetailedEntity.CreatedByMemberFullName = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.CreatedByMemberFullName = reader.GetString(FLD_CREATEDBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { cRMBuyerBasicInfo_DetailedEntity.BDProjectProjectName = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_IMAGEURL)) { cRMBuyerBasicInfo_DetailedEntity.ImageUrl = String.Empty; } else { cRMBuyerBasicInfo_DetailedEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }
            cRMBuyerBasicInfo_DetailedEntity.CompanyName = reader.GetString(FLD_COMPANYNAME);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cRMBuyerBasicInfo_DetailedEntity.RowNumber = null; } else { cRMBuyerBasicInfo_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cRMBuyerBasicInfo_DetailedEntity;
        }
    }
}
