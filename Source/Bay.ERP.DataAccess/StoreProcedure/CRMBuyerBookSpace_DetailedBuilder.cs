// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Apr-2013, 09:47:50




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMBuyerBookSpace_DetailedBuilder : IEntityBuilder<CRMBuyerBookSpace_DetailedEntity>
    {
        IList<CRMBuyerBookSpace_DetailedEntity> IEntityBuilder<CRMBuyerBookSpace_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMBuyerBookSpace_DetailedEntity> CRMBuyerBookSpace_DetailedEntityList = new List<CRMBuyerBookSpace_DetailedEntity>();

            while (reader.Read())
            {
                CRMBuyerBookSpace_DetailedEntityList.Add(((IEntityBuilder<CRMBuyerBookSpace_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CRMBuyerBookSpace_DetailedEntityList.Count > 0) ? CRMBuyerBookSpace_DetailedEntityList : null;
        }

        CRMBuyerBookSpace_DetailedEntity IEntityBuilder<CRMBuyerBookSpace_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUYERBOOKSPACEID = 0;
            const Int32 FLD_REFERENCEID = 1;
            const Int32 FLD_PROJECTID = 2;
            const Int32 FLD_PROJECTFLOORUNITID = 3;
            const Int32 FLD_BOOKINGNOTE = 4;
            const Int32 FLD_ISLANDOWNER = 5;
            const Int32 FLD_ISAPPROVEDBYMANAGEMENT = 6;
            const Int32 FLD_BOOKINGSTATUSID = 7;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 8;
            const Int32 FLD_IP = 9;
            const Int32 FLD_CREATEDATE = 10;
            const Int32 FLD_CONTACTFULLNAME = 11;
            const Int32 FLD_PROJECTNAME = 12;
            const Int32 FLD_BDPROJECTFLOORUNITPROJECTFLOORUNITNAME = 13;
            const Int32 FLD_BOOKINGSTATUSNAME = 14;
            const Int32 FLD_CREATEDBYMEMBERFULLNAME = 15;
            const Int32 FLD_IMAGEURL = 16;
            const Int32 FLD_ROWNUMBER = 17;

            CRMBuyerBookSpace_DetailedEntity cRMBuyerBookSpace_DetailedEntity = new CRMBuyerBookSpace_DetailedEntity();

            cRMBuyerBookSpace_DetailedEntity.BuyerBookSpaceID = reader.GetInt64(FLD_BUYERBOOKSPACEID);
            cRMBuyerBookSpace_DetailedEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            cRMBuyerBookSpace_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cRMBuyerBookSpace_DetailedEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID);
            if (reader.IsDBNull(FLD_BOOKINGNOTE)) { cRMBuyerBookSpace_DetailedEntity.BookingNote = String.Empty; } else { cRMBuyerBookSpace_DetailedEntity.BookingNote = reader.GetString(FLD_BOOKINGNOTE); }
            cRMBuyerBookSpace_DetailedEntity.IsLandOwner = reader.GetBoolean(FLD_ISLANDOWNER);
            cRMBuyerBookSpace_DetailedEntity.IsApprovedByManagement = reader.GetBoolean(FLD_ISAPPROVEDBYMANAGEMENT);
            cRMBuyerBookSpace_DetailedEntity.BookingStatusID = reader.GetInt64(FLD_BOOKINGSTATUSID);
            cRMBuyerBookSpace_DetailedEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_IP)) { cRMBuyerBookSpace_DetailedEntity.IP = String.Empty; } else { cRMBuyerBookSpace_DetailedEntity.IP = reader.GetString(FLD_IP); }
            cRMBuyerBookSpace_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMBuyerBookSpace_DetailedEntity.ContactFullName = reader.GetString(FLD_CONTACTFULLNAME);
            if (reader.IsDBNull(FLD_PROJECTNAME)) { cRMBuyerBookSpace_DetailedEntity.ProjectName = String.Empty; } else { cRMBuyerBookSpace_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_BDPROJECTFLOORUNITPROJECTFLOORUNITNAME)) { cRMBuyerBookSpace_DetailedEntity.BDProjectFloorUnitProjectFloorUnitName = String.Empty; } else { cRMBuyerBookSpace_DetailedEntity.BDProjectFloorUnitProjectFloorUnitName = reader.GetString(FLD_BDPROJECTFLOORUNITPROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_BOOKINGSTATUSNAME)) { cRMBuyerBookSpace_DetailedEntity.BookingStatusName = String.Empty; } else { cRMBuyerBookSpace_DetailedEntity.BookingStatusName = reader.GetString(FLD_BOOKINGSTATUSNAME); }
            if (reader.IsDBNull(FLD_CREATEDBYMEMBERFULLNAME)) { cRMBuyerBookSpace_DetailedEntity.CreatedByMemberFullName = String.Empty; } else { cRMBuyerBookSpace_DetailedEntity.CreatedByMemberFullName = reader.GetString(FLD_CREATEDBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_IMAGEURL)) { cRMBuyerBookSpace_DetailedEntity.ImageUrl = null; } else { cRMBuyerBookSpace_DetailedEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cRMBuyerBookSpace_DetailedEntity.RowNumber = null; } else { cRMBuyerBookSpace_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cRMBuyerBookSpace_DetailedEntity;
        }
    }
}
