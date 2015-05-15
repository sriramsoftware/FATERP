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
    internal sealed class CRMLandBasicInfo_DetailedBuilder : IEntityBuilder<CRMLandBasicInfo_DetailedEntity>
    {
        IList<CRMLandBasicInfo_DetailedEntity> IEntityBuilder<CRMLandBasicInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMLandBasicInfo_DetailedEntity> CRMLandBasicInfo_DetailedEntityList = new List<CRMLandBasicInfo_DetailedEntity>();

            while (reader.Read())
            {
                CRMLandBasicInfo_DetailedEntityList.Add(((IEntityBuilder<CRMLandBasicInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CRMLandBasicInfo_DetailedEntityList.Count > 0) ? CRMLandBasicInfo_DetailedEntityList : null;
        }

        CRMLandBasicInfo_DetailedEntity IEntityBuilder<CRMLandBasicInfo_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_LANDBASICINFOID = 0;
            const Int32 FLD_LANDOWNERTYPEID = 1;
            const Int32 FLD_CONTACTFULLNAME = 2;
            const Int32 FLD_MOBILENO = 3;
            const Int32 FLD_LANDPHONE = 4;
            const Int32 FLD_PRESENTADDRESS = 5;
            const Int32 FLD_EMAIL = 6;
            const Int32 FLD_INTERESTEDLANDLOCATIONID = 7;
            const Int32 FLD_CITYID = 8;
            const Int32 FLD_LANDAREA1 = 9;
            const Int32 FLD_AREAUNITID1 = 10;
            const Int32 FLD_LANDAREA2 = 11;
            const Int32 FLD_AREAUNITID2 = 12;
            const Int32 FLD_PLOTNUMBER = 13;
            const Int32 FLD_PLOTADDRESS = 14;
            const Int32 FLD_PLOTMAPURL = 15;
            const Int32 FLD_AREA = 16;
            const Int32 FLD_DIMENSION = 17;
            const Int32 FLD_SPECIALFEATURES = 18;
            const Int32 FLD_STRUCTURE = 19;
            const Int32 FLD_RAJUKDETAILS = 20;
            const Int32 FLD_LEADGENERATEDBYEMPLOYEEID = 21;
            const Int32 FLD_LEADMANAGEDBYONEEMPLOYEEID = 22;
            const Int32 FLD_LEADMANAGEDBYTWOEMPLOYEEID = 23;
            const Int32 FLD_LEADCONVERSIONDATE = 24;
            const Int32 FLD_REFERREDBYEMPLOYEEID = 25;
            const Int32 FLD_LANDOWNEROFPROJECT = 26;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 27;
            const Int32 FLD_IP = 28;
            const Int32 FLD_CREATEDATE = 29;
            const Int32 FLD_CRMMDLANDOWNERTYPENAME = 30;
            const Int32 FLD_CRMMDLANDLOCATIONNAME = 31;
            const Int32 FLD_MDCITYNAME = 32;
            const Int32 FLD_AREAUNITNAME1 = 33;
            const Int32 FLD_AREAUNITNAME2 = 34;
            const Int32 FLD_LEADGENERATEDBYMEMBERFULLNAME = 35;
            const Int32 FLD_LEADMANAGEDBYONEMEMBERFULLNAME = 36;
            const Int32 FLD_LEADMANAGEDBYTWOMEMBERFULLNAME = 37;
            const Int32 FLD_REFERREDBYMEMBERFULLNAME = 38;
            const Int32 FLD_CREATEDBYMEMBERFULLNAME = 39;
            const Int32 FLD_BDPROJECTPROJECTNAME = 40;
            const Int32 FLD_ROWNUMBER = 41;

            CRMLandBasicInfo_DetailedEntity cRMLandBasicInfo_DetailedEntity = new CRMLandBasicInfo_DetailedEntity();

            cRMLandBasicInfo_DetailedEntity.LandBasicInfoID = reader.GetInt64(FLD_LANDBASICINFOID);
            cRMLandBasicInfo_DetailedEntity.LandOwnerTypeID = reader.GetInt64(FLD_LANDOWNERTYPEID);
            cRMLandBasicInfo_DetailedEntity.ContactFullName = reader.GetString(FLD_CONTACTFULLNAME);
            cRMLandBasicInfo_DetailedEntity.MobileNo = reader.GetString(FLD_MOBILENO);
            if (reader.IsDBNull(FLD_LANDPHONE)) { cRMLandBasicInfo_DetailedEntity.LandPhone = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.LandPhone = reader.GetString(FLD_LANDPHONE); }
            if (reader.IsDBNull(FLD_PRESENTADDRESS)) { cRMLandBasicInfo_DetailedEntity.PresentAddress = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.PresentAddress = reader.GetString(FLD_PRESENTADDRESS); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMLandBasicInfo_DetailedEntity.Email = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.Email = reader.GetString(FLD_EMAIL); }
            cRMLandBasicInfo_DetailedEntity.InterestedLandLocationID = reader.GetInt64(FLD_INTERESTEDLANDLOCATIONID);
            cRMLandBasicInfo_DetailedEntity.CityID = reader.GetInt64(FLD_CITYID);
            if (reader.IsDBNull(FLD_LANDAREA1)) { cRMLandBasicInfo_DetailedEntity.LandArea1 = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.LandArea1 = reader.GetString(FLD_LANDAREA1); }
            if (reader.IsDBNull(FLD_AREAUNITID1)) { cRMLandBasicInfo_DetailedEntity.AreaUnitID1 = null; } else { cRMLandBasicInfo_DetailedEntity.AreaUnitID1 = reader.GetInt64(FLD_AREAUNITID1); }
            if (reader.IsDBNull(FLD_LANDAREA2)) { cRMLandBasicInfo_DetailedEntity.LandArea2 = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.LandArea2 = reader.GetString(FLD_LANDAREA2); }
            if (reader.IsDBNull(FLD_AREAUNITID2)) { cRMLandBasicInfo_DetailedEntity.AreaUnitID2 = null; } else { cRMLandBasicInfo_DetailedEntity.AreaUnitID2 = reader.GetInt64(FLD_AREAUNITID2); }
            cRMLandBasicInfo_DetailedEntity.PlotNumber = reader.GetString(FLD_PLOTNUMBER);
            if (reader.IsDBNull(FLD_PLOTADDRESS)) { cRMLandBasicInfo_DetailedEntity.PlotAddress = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.PlotAddress = reader.GetString(FLD_PLOTADDRESS); }
            if (reader.IsDBNull(FLD_PLOTMAPURL)) { cRMLandBasicInfo_DetailedEntity.PlotMapUrl = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.PlotMapUrl = reader.GetString(FLD_PLOTMAPURL); }
            if (reader.IsDBNull(FLD_AREA)) { cRMLandBasicInfo_DetailedEntity.Area = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.Area = reader.GetString(FLD_AREA); }
            if (reader.IsDBNull(FLD_DIMENSION)) { cRMLandBasicInfo_DetailedEntity.Dimension = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.Dimension = reader.GetString(FLD_DIMENSION); }
            if (reader.IsDBNull(FLD_SPECIALFEATURES)) { cRMLandBasicInfo_DetailedEntity.SpecialFeatures = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.SpecialFeatures = reader.GetString(FLD_SPECIALFEATURES); }
            if (reader.IsDBNull(FLD_STRUCTURE)) { cRMLandBasicInfo_DetailedEntity.Structure = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.Structure = reader.GetString(FLD_STRUCTURE); }
            if (reader.IsDBNull(FLD_RAJUKDETAILS)) { cRMLandBasicInfo_DetailedEntity.RAJUKDetails = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.RAJUKDetails = reader.GetString(FLD_RAJUKDETAILS); }
            if (reader.IsDBNull(FLD_LEADGENERATEDBYEMPLOYEEID)) { cRMLandBasicInfo_DetailedEntity.LeadGeneratedByEmployeeID = null; } else { cRMLandBasicInfo_DetailedEntity.LeadGeneratedByEmployeeID = reader.GetInt64(FLD_LEADGENERATEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYONEEMPLOYEEID)) { cRMLandBasicInfo_DetailedEntity.LeadManagedByOneEmployeeID = null; } else { cRMLandBasicInfo_DetailedEntity.LeadManagedByOneEmployeeID = reader.GetInt64(FLD_LEADMANAGEDBYONEEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYTWOEMPLOYEEID)) { cRMLandBasicInfo_DetailedEntity.LeadManagedByTwoEmployeeID = null; } else { cRMLandBasicInfo_DetailedEntity.LeadManagedByTwoEmployeeID = reader.GetInt64(FLD_LEADMANAGEDBYTWOEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADCONVERSIONDATE)) { cRMLandBasicInfo_DetailedEntity.LeadConversionDate = null; } else { cRMLandBasicInfo_DetailedEntity.LeadConversionDate = reader.GetDateTime(FLD_LEADCONVERSIONDATE); }
            if (reader.IsDBNull(FLD_REFERREDBYEMPLOYEEID)) { cRMLandBasicInfo_DetailedEntity.ReferredByEmployeeID = null; } else { cRMLandBasicInfo_DetailedEntity.ReferredByEmployeeID = reader.GetInt64(FLD_REFERREDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LANDOWNEROFPROJECT)) { cRMLandBasicInfo_DetailedEntity.LandOwnerOfProject = null; } else { cRMLandBasicInfo_DetailedEntity.LandOwnerOfProject = reader.GetInt64(FLD_LANDOWNEROFPROJECT); }
            cRMLandBasicInfo_DetailedEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_IP)) { cRMLandBasicInfo_DetailedEntity.IP = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.IP = reader.GetString(FLD_IP); }
            cRMLandBasicInfo_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_CRMMDLANDOWNERTYPENAME)) { cRMLandBasicInfo_DetailedEntity.CRMMDLandOwnerTypeName = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.CRMMDLandOwnerTypeName = reader.GetString(FLD_CRMMDLANDOWNERTYPENAME); }
            if (reader.IsDBNull(FLD_CRMMDLANDLOCATIONNAME)) { cRMLandBasicInfo_DetailedEntity.CRMMDLandLocationName = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.CRMMDLandLocationName = reader.GetString(FLD_CRMMDLANDLOCATIONNAME); }
            if (reader.IsDBNull(FLD_MDCITYNAME)) { cRMLandBasicInfo_DetailedEntity.MDCityName = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.MDCityName = reader.GetString(FLD_MDCITYNAME); }
            if (reader.IsDBNull(FLD_AREAUNITNAME1)) { cRMLandBasicInfo_DetailedEntity.AreaUnitName1 = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.AreaUnitName1 = reader.GetString(FLD_AREAUNITNAME1); }
            if (reader.IsDBNull(FLD_AREAUNITNAME2)) { cRMLandBasicInfo_DetailedEntity.AreaUnitName2 = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.AreaUnitName2 = reader.GetString(FLD_AREAUNITNAME2); }
            if (reader.IsDBNull(FLD_LEADGENERATEDBYMEMBERFULLNAME)) { cRMLandBasicInfo_DetailedEntity.LeadGeneratedByMemberFullName = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.LeadGeneratedByMemberFullName = reader.GetString(FLD_LEADGENERATEDBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYONEMEMBERFULLNAME)) { cRMLandBasicInfo_DetailedEntity.LeadManagedByOneMemberFullName = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.LeadManagedByOneMemberFullName = reader.GetString(FLD_LEADMANAGEDBYONEMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYTWOMEMBERFULLNAME)) { cRMLandBasicInfo_DetailedEntity.LeadManagedByTwoMemberFullName = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.LeadManagedByTwoMemberFullName = reader.GetString(FLD_LEADMANAGEDBYTWOMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_REFERREDBYMEMBERFULLNAME)) { cRMLandBasicInfo_DetailedEntity.ReferredByMemberFullName = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.ReferredByMemberFullName = reader.GetString(FLD_REFERREDBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_CREATEDBYMEMBERFULLNAME)) { cRMLandBasicInfo_DetailedEntity.CreatedByMemberFullName = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.CreatedByMemberFullName = reader.GetString(FLD_CREATEDBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { cRMLandBasicInfo_DetailedEntity.BDProjectProjectName = String.Empty; } else { cRMLandBasicInfo_DetailedEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cRMLandBasicInfo_DetailedEntity.RowNumber = null; } else { cRMLandBasicInfo_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cRMLandBasicInfo_DetailedEntity;
        }
    }
}
