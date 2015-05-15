// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2013, 03:37:43




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMBuyerBasicInfoBuilder : IEntityBuilder<CRMBuyerBasicInfoEntity>
    {
        IList<CRMBuyerBasicInfoEntity> IEntityBuilder<CRMBuyerBasicInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMBuyerBasicInfoEntity> CRMBuyerBasicInfoEntityList = new List<CRMBuyerBasicInfoEntity>();

            while (reader.Read())
            {
                CRMBuyerBasicInfoEntityList.Add(((IEntityBuilder<CRMBuyerBasicInfoEntity>)this).BuildEntity(reader));
            }

            return (CRMBuyerBasicInfoEntityList.Count > 0) ? CRMBuyerBasicInfoEntityList : null;
        }

        CRMBuyerBasicInfoEntity IEntityBuilder<CRMBuyerBasicInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUYERBASICINFOID = 0;
            const Int32 FLD_BUYERTYPEID = 1;
            const Int32 FLD_CONTACTFULLNAME = 2;
            const Int32 FLD_COMPANYNAME = 3;
            const Int32 FLD_DESIGNATION = 4;
            const Int32 FLD_INTERESTEDPROJECTCATEGORYID = 5;
            const Int32 FLD_MOBILENO = 6;
            const Int32 FLD_MOBILENO2 = 7;
            const Int32 FLD_LANDPHONE = 8;
            const Int32 FLD_LANDPHONEOFFICE = 9;
            const Int32 FLD_FAXNUMBER = 10;
            const Int32 FLD_PRESENTADDRESS = 11;
            const Int32 FLD_PRESENTADDRESSOFFICE = 12;
            const Int32 FLD_EMAIL = 13;
            const Int32 FLD_EMAIL2 = 14;
            const Int32 FLD_DOB = 15;
            const Int32 FLD_NOOFCHILDREN = 16;
            const Int32 FLD_INTERESTEDLANDLOCATIONID = 17;
            const Int32 FLD_CITYID = 18;
            const Int32 FLD_AREANEEDEDFROM = 19;
            const Int32 FLD_AREANEEDEDTO = 20;
            const Int32 FLD_PARKINGNEEDED = 21;
            const Int32 FLD_AREAUNITID = 22;
            const Int32 FLD_TOILETNEEDED = 23;
            const Int32 FLD_UNITNEEDED = 24;
            const Int32 FLD_ADVERTISEWAYID = 25;
            const Int32 FLD_LEADGENERATEDBYEMPLOYEEID = 26;
            const Int32 FLD_LEADMANAGEDBYONEEMPLOYEEID = 27;
            const Int32 FLD_LEADMANAGEDBYTWOEMPLOYEEID = 28;
            const Int32 FLD_LEADCONVERSIONDATE = 29;
            const Int32 FLD_PROSPECTFORPROJECT = 30;
            const Int32 FLD_REMARKS = 31;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 32;
            const Int32 FLD_IP = 33;
            const Int32 FLD_CREATEDATE = 34;
            const Int32 FLD_IMAGEURL = 35;

            CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity = new CRMBuyerBasicInfoEntity();

            cRMBuyerBasicInfoEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            cRMBuyerBasicInfoEntity.BuyerTypeID = reader.GetInt64(FLD_BUYERTYPEID);
            cRMBuyerBasicInfoEntity.ContactFullName = reader.GetString(FLD_CONTACTFULLNAME);
            cRMBuyerBasicInfoEntity.CompanyName = reader.GetString(FLD_COMPANYNAME);
            if (reader.IsDBNull(FLD_DESIGNATION)) { cRMBuyerBasicInfoEntity.Designation = String.Empty; } else { cRMBuyerBasicInfoEntity.Designation = reader.GetString(FLD_DESIGNATION); }
            cRMBuyerBasicInfoEntity.InterestedProjectCategoryID = reader.GetInt64(FLD_INTERESTEDPROJECTCATEGORYID);
            cRMBuyerBasicInfoEntity.MobileNo = reader.GetString(FLD_MOBILENO);
            if (reader.IsDBNull(FLD_MOBILENO2)) { cRMBuyerBasicInfoEntity.MobileNo2 = String.Empty; } else { cRMBuyerBasicInfoEntity.MobileNo2 = reader.GetString(FLD_MOBILENO2); }
            if (reader.IsDBNull(FLD_LANDPHONE)) { cRMBuyerBasicInfoEntity.LandPhone = String.Empty; } else { cRMBuyerBasicInfoEntity.LandPhone = reader.GetString(FLD_LANDPHONE); }
            if (reader.IsDBNull(FLD_LANDPHONEOFFICE)) { cRMBuyerBasicInfoEntity.LandPhoneOffice = String.Empty; } else { cRMBuyerBasicInfoEntity.LandPhoneOffice = reader.GetString(FLD_LANDPHONEOFFICE); }
            if (reader.IsDBNull(FLD_FAXNUMBER)) { cRMBuyerBasicInfoEntity.FaxNumber = String.Empty; } else { cRMBuyerBasicInfoEntity.FaxNumber = reader.GetString(FLD_FAXNUMBER); }
            if (reader.IsDBNull(FLD_PRESENTADDRESS)) { cRMBuyerBasicInfoEntity.PresentAddress = String.Empty; } else { cRMBuyerBasicInfoEntity.PresentAddress = reader.GetString(FLD_PRESENTADDRESS); }
            if (reader.IsDBNull(FLD_PRESENTADDRESSOFFICE)) { cRMBuyerBasicInfoEntity.PresentAddressOffice = String.Empty; } else { cRMBuyerBasicInfoEntity.PresentAddressOffice = reader.GetString(FLD_PRESENTADDRESSOFFICE); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMBuyerBasicInfoEntity.Email = String.Empty; } else { cRMBuyerBasicInfoEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_EMAIL2)) { cRMBuyerBasicInfoEntity.Email2 = String.Empty; } else { cRMBuyerBasicInfoEntity.Email2 = reader.GetString(FLD_EMAIL2); }
            if (reader.IsDBNull(FLD_DOB)) { cRMBuyerBasicInfoEntity.DOB = null; } else { cRMBuyerBasicInfoEntity.DOB = reader.GetDateTime(FLD_DOB); }
            if (reader.IsDBNull(FLD_NOOFCHILDREN)) { cRMBuyerBasicInfoEntity.NoOfChildren = null; } else { cRMBuyerBasicInfoEntity.NoOfChildren = reader.GetDecimal(FLD_NOOFCHILDREN); }
            if (reader.IsDBNull(FLD_INTERESTEDLANDLOCATIONID)) { cRMBuyerBasicInfoEntity.InterestedLandLocationID = null; } else { cRMBuyerBasicInfoEntity.InterestedLandLocationID = reader.GetInt64(FLD_INTERESTEDLANDLOCATIONID); }
            if (reader.IsDBNull(FLD_CITYID)) { cRMBuyerBasicInfoEntity.CityID = null; } else { cRMBuyerBasicInfoEntity.CityID = reader.GetInt64(FLD_CITYID); }
            if (reader.IsDBNull(FLD_AREANEEDEDFROM)) { cRMBuyerBasicInfoEntity.AreaNeededFrom = null; } else { cRMBuyerBasicInfoEntity.AreaNeededFrom = reader.GetDecimal(FLD_AREANEEDEDFROM); }
            if (reader.IsDBNull(FLD_AREANEEDEDTO)) { cRMBuyerBasicInfoEntity.AreaNeededTo = null; } else { cRMBuyerBasicInfoEntity.AreaNeededTo = reader.GetDecimal(FLD_AREANEEDEDTO); }
            if (reader.IsDBNull(FLD_PARKINGNEEDED)) { cRMBuyerBasicInfoEntity.ParkingNeeded = null; } else { cRMBuyerBasicInfoEntity.ParkingNeeded = reader.GetDecimal(FLD_PARKINGNEEDED); }
            if (reader.IsDBNull(FLD_AREAUNITID)) { cRMBuyerBasicInfoEntity.AreaUnitID = null; } else { cRMBuyerBasicInfoEntity.AreaUnitID = reader.GetInt64(FLD_AREAUNITID); }
            if (reader.IsDBNull(FLD_TOILETNEEDED)) { cRMBuyerBasicInfoEntity.ToiletNeeded = null; } else { cRMBuyerBasicInfoEntity.ToiletNeeded = reader.GetDecimal(FLD_TOILETNEEDED); }
            if (reader.IsDBNull(FLD_UNITNEEDED)) { cRMBuyerBasicInfoEntity.UnitNeeded = null; } else { cRMBuyerBasicInfoEntity.UnitNeeded = reader.GetDecimal(FLD_UNITNEEDED); }
            if (reader.IsDBNull(FLD_ADVERTISEWAYID)) { cRMBuyerBasicInfoEntity.AdvertiseWayID = null; } else { cRMBuyerBasicInfoEntity.AdvertiseWayID = reader.GetInt64(FLD_ADVERTISEWAYID); }
            if (reader.IsDBNull(FLD_LEADGENERATEDBYEMPLOYEEID)) { cRMBuyerBasicInfoEntity.LeadGeneratedByEmployeeID = null; } else { cRMBuyerBasicInfoEntity.LeadGeneratedByEmployeeID = reader.GetInt64(FLD_LEADGENERATEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYONEEMPLOYEEID)) { cRMBuyerBasicInfoEntity.LeadManagedByOneEmployeeID = null; } else { cRMBuyerBasicInfoEntity.LeadManagedByOneEmployeeID = reader.GetInt64(FLD_LEADMANAGEDBYONEEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYTWOEMPLOYEEID)) { cRMBuyerBasicInfoEntity.LeadManagedByTwoEmployeeID = null; } else { cRMBuyerBasicInfoEntity.LeadManagedByTwoEmployeeID = reader.GetInt64(FLD_LEADMANAGEDBYTWOEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADCONVERSIONDATE)) { cRMBuyerBasicInfoEntity.LeadConversionDate = null; } else { cRMBuyerBasicInfoEntity.LeadConversionDate = reader.GetDateTime(FLD_LEADCONVERSIONDATE); }
            if (reader.IsDBNull(FLD_PROSPECTFORPROJECT)) { cRMBuyerBasicInfoEntity.ProspectForProject = null; } else { cRMBuyerBasicInfoEntity.ProspectForProject = reader.GetInt64(FLD_PROSPECTFORPROJECT); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMBuyerBasicInfoEntity.Remarks = String.Empty; } else { cRMBuyerBasicInfoEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMBuyerBasicInfoEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_IP)) { cRMBuyerBasicInfoEntity.IP = String.Empty; } else { cRMBuyerBasicInfoEntity.IP = reader.GetString(FLD_IP); }
            cRMBuyerBasicInfoEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_IMAGEURL)) { cRMBuyerBasicInfoEntity.ImageUrl = String.Empty; } else { cRMBuyerBasicInfoEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }

            return cRMBuyerBasicInfoEntity;
        }
    }
}
