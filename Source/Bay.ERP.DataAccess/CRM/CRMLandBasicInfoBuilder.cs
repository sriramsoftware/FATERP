// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Apr-2013, 03:04:35




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMLandBasicInfoBuilder : IEntityBuilder<CRMLandBasicInfoEntity>
    {
        IList<CRMLandBasicInfoEntity> IEntityBuilder<CRMLandBasicInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMLandBasicInfoEntity> CRMLandBasicInfoEntityList = new List<CRMLandBasicInfoEntity>();

            while (reader.Read())
            {
                CRMLandBasicInfoEntityList.Add(((IEntityBuilder<CRMLandBasicInfoEntity>)this).BuildEntity(reader));
            }

            return (CRMLandBasicInfoEntityList.Count > 0) ? CRMLandBasicInfoEntityList : null;
        }

        CRMLandBasicInfoEntity IEntityBuilder<CRMLandBasicInfoEntity>.BuildEntity(IDataReader reader)
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

            CRMLandBasicInfoEntity cRMLandBasicInfoEntity = new CRMLandBasicInfoEntity();

            cRMLandBasicInfoEntity.LandBasicInfoID = reader.GetInt64(FLD_LANDBASICINFOID);
            cRMLandBasicInfoEntity.LandOwnerTypeID = reader.GetInt64(FLD_LANDOWNERTYPEID);
            cRMLandBasicInfoEntity.ContactFullName = reader.GetString(FLD_CONTACTFULLNAME);
            cRMLandBasicInfoEntity.MobileNo = reader.GetString(FLD_MOBILENO);
            if (reader.IsDBNull(FLD_LANDPHONE)) { cRMLandBasicInfoEntity.LandPhone = String.Empty; } else { cRMLandBasicInfoEntity.LandPhone = reader.GetString(FLD_LANDPHONE); }
            if (reader.IsDBNull(FLD_PRESENTADDRESS)) { cRMLandBasicInfoEntity.PresentAddress = String.Empty; } else { cRMLandBasicInfoEntity.PresentAddress = reader.GetString(FLD_PRESENTADDRESS); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMLandBasicInfoEntity.Email = String.Empty; } else { cRMLandBasicInfoEntity.Email = reader.GetString(FLD_EMAIL); }
            cRMLandBasicInfoEntity.InterestedLandLocationID = reader.GetInt64(FLD_INTERESTEDLANDLOCATIONID);
            cRMLandBasicInfoEntity.CityID = reader.GetInt64(FLD_CITYID);
            if (reader.IsDBNull(FLD_LANDAREA1)) { cRMLandBasicInfoEntity.LandArea1 = String.Empty; } else { cRMLandBasicInfoEntity.LandArea1 = reader.GetString(FLD_LANDAREA1); }
            if (reader.IsDBNull(FLD_AREAUNITID1)) { cRMLandBasicInfoEntity.AreaUnitID1 = null; } else { cRMLandBasicInfoEntity.AreaUnitID1 = reader.GetInt64(FLD_AREAUNITID1); }
            if (reader.IsDBNull(FLD_LANDAREA2)) { cRMLandBasicInfoEntity.LandArea2 = String.Empty; } else { cRMLandBasicInfoEntity.LandArea2 = reader.GetString(FLD_LANDAREA2); }
            if (reader.IsDBNull(FLD_AREAUNITID2)) { cRMLandBasicInfoEntity.AreaUnitID2 = null; } else { cRMLandBasicInfoEntity.AreaUnitID2 = reader.GetInt64(FLD_AREAUNITID2); }
            cRMLandBasicInfoEntity.PlotNumber = reader.GetString(FLD_PLOTNUMBER);
            if (reader.IsDBNull(FLD_PLOTADDRESS)) { cRMLandBasicInfoEntity.PlotAddress = String.Empty; } else { cRMLandBasicInfoEntity.PlotAddress = reader.GetString(FLD_PLOTADDRESS); }
            if (reader.IsDBNull(FLD_PLOTMAPURL)) { cRMLandBasicInfoEntity.PlotMapUrl = String.Empty; } else { cRMLandBasicInfoEntity.PlotMapUrl = reader.GetString(FLD_PLOTMAPURL); }
            if (reader.IsDBNull(FLD_AREA)) { cRMLandBasicInfoEntity.Area = String.Empty; } else { cRMLandBasicInfoEntity.Area = reader.GetString(FLD_AREA); }
            if (reader.IsDBNull(FLD_DIMENSION)) { cRMLandBasicInfoEntity.Dimension = String.Empty; } else { cRMLandBasicInfoEntity.Dimension = reader.GetString(FLD_DIMENSION); }
            if (reader.IsDBNull(FLD_SPECIALFEATURES)) { cRMLandBasicInfoEntity.SpecialFeatures = String.Empty; } else { cRMLandBasicInfoEntity.SpecialFeatures = reader.GetString(FLD_SPECIALFEATURES); }
            if (reader.IsDBNull(FLD_STRUCTURE)) { cRMLandBasicInfoEntity.Structure = String.Empty; } else { cRMLandBasicInfoEntity.Structure = reader.GetString(FLD_STRUCTURE); }
            if (reader.IsDBNull(FLD_RAJUKDETAILS)) { cRMLandBasicInfoEntity.RAJUKDetails = String.Empty; } else { cRMLandBasicInfoEntity.RAJUKDetails = reader.GetString(FLD_RAJUKDETAILS); }
            if (reader.IsDBNull(FLD_LEADGENERATEDBYEMPLOYEEID)) { cRMLandBasicInfoEntity.LeadGeneratedByEmployeeID = null; } else { cRMLandBasicInfoEntity.LeadGeneratedByEmployeeID = reader.GetInt64(FLD_LEADGENERATEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYONEEMPLOYEEID)) { cRMLandBasicInfoEntity.LeadManagedByOneEmployeeID = null; } else { cRMLandBasicInfoEntity.LeadManagedByOneEmployeeID = reader.GetInt64(FLD_LEADMANAGEDBYONEEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYTWOEMPLOYEEID)) { cRMLandBasicInfoEntity.LeadManagedByTwoEmployeeID = null; } else { cRMLandBasicInfoEntity.LeadManagedByTwoEmployeeID = reader.GetInt64(FLD_LEADMANAGEDBYTWOEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADCONVERSIONDATE)) { cRMLandBasicInfoEntity.LeadConversionDate = null; } else { cRMLandBasicInfoEntity.LeadConversionDate = reader.GetDateTime(FLD_LEADCONVERSIONDATE); }
            if (reader.IsDBNull(FLD_REFERREDBYEMPLOYEEID)) { cRMLandBasicInfoEntity.ReferredByEmployeeID = null; } else { cRMLandBasicInfoEntity.ReferredByEmployeeID = reader.GetInt64(FLD_REFERREDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LANDOWNEROFPROJECT)) { cRMLandBasicInfoEntity.LandOwnerOfProject = null; } else { cRMLandBasicInfoEntity.LandOwnerOfProject = reader.GetInt64(FLD_LANDOWNEROFPROJECT); }
            cRMLandBasicInfoEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_IP)) { cRMLandBasicInfoEntity.IP = String.Empty; } else { cRMLandBasicInfoEntity.IP = reader.GetString(FLD_IP); }
            cRMLandBasicInfoEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);

            return cRMLandBasicInfoEntity;
        }
    }
}
