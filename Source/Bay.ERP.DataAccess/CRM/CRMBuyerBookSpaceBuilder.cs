// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Apr-2013, 03:35:56




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMBuyerBookSpaceBuilder : IEntityBuilder<CRMBuyerBookSpaceEntity>
    {
        IList<CRMBuyerBookSpaceEntity> IEntityBuilder<CRMBuyerBookSpaceEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMBuyerBookSpaceEntity> CRMBuyerBookSpaceEntityList = new List<CRMBuyerBookSpaceEntity>();

            while (reader.Read())
            {
                CRMBuyerBookSpaceEntityList.Add(((IEntityBuilder<CRMBuyerBookSpaceEntity>)this).BuildEntity(reader));
            }

            return (CRMBuyerBookSpaceEntityList.Count > 0) ? CRMBuyerBookSpaceEntityList : null;
        }

        CRMBuyerBookSpaceEntity IEntityBuilder<CRMBuyerBookSpaceEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_IMAGEURL = 11;

            CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity = new CRMBuyerBookSpaceEntity();

            cRMBuyerBookSpaceEntity.BuyerBookSpaceID = reader.GetInt64(FLD_BUYERBOOKSPACEID);
            cRMBuyerBookSpaceEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            cRMBuyerBookSpaceEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cRMBuyerBookSpaceEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID);
            if (reader.IsDBNull(FLD_BOOKINGNOTE)) { cRMBuyerBookSpaceEntity.BookingNote = String.Empty; } else { cRMBuyerBookSpaceEntity.BookingNote = reader.GetString(FLD_BOOKINGNOTE); }
            cRMBuyerBookSpaceEntity.IsLandOwner = reader.GetBoolean(FLD_ISLANDOWNER);
            cRMBuyerBookSpaceEntity.IsApprovedByManagement = reader.GetBoolean(FLD_ISAPPROVEDBYMANAGEMENT);
            cRMBuyerBookSpaceEntity.BookingStatusID = reader.GetInt64(FLD_BOOKINGSTATUSID);
            cRMBuyerBookSpaceEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_IP)) { cRMBuyerBookSpaceEntity.IP = String.Empty; } else { cRMBuyerBookSpaceEntity.IP = reader.GetString(FLD_IP); }
            cRMBuyerBookSpaceEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_IMAGEURL)) { cRMBuyerBookSpaceEntity.ImageUrl = String.Empty; } else { cRMBuyerBookSpaceEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }

            return cRMBuyerBookSpaceEntity;
        }
    }
}
