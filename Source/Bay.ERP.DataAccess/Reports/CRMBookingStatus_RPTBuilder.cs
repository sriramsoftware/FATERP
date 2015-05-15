// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 04:56:23




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMBookingStatus_RPTBuilder : IEntityBuilder<CRMBookingStatus_RPTEntity>
    {
        IList<CRMBookingStatus_RPTEntity> IEntityBuilder<CRMBookingStatus_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMBookingStatus_RPTEntity> CRMBookingStatus_RPTEntityList = new List<CRMBookingStatus_RPTEntity>();

            while (reader.Read())
            {
                CRMBookingStatus_RPTEntityList.Add(((IEntityBuilder<CRMBookingStatus_RPTEntity>)this).BuildEntity(reader));
            }

            return (CRMBookingStatus_RPTEntityList.Count > 0) ? CRMBookingStatus_RPTEntityList : null;
        }

        CRMBookingStatus_RPTEntity IEntityBuilder<CRMBookingStatus_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_DESIGNATION = 12;
            const Int32 FLD_MOBILENO = 13;
            const Int32 FLD_EMAIL = 14;
            const Int32 FLD_PRESENTADDRESS = 15;
            const Int32 FLD_LEADGENERATEDBYEMPLOYEEID = 16;
            const Int32 FLD_LEADMANAGEDBYONEEMPLOYEEID = 17;
            const Int32 FLD_LEADMANAGEDBYTWOEMPLOYEEID = 18;
            const Int32 FLD_LEADCONVERSIONDATE = 19;
            const Int32 FLD_PROJECTCODE = 20;
            const Int32 FLD_PROJECTNAME = 21;
            const Int32 FLD_PROJECTFLOORUNITNAME = 22;
            const Int32 FLD_BOOKINGSTATUS = 23;

            CRMBookingStatus_RPTEntity cRMBookingStatus_RPTEntity = new CRMBookingStatus_RPTEntity();

            cRMBookingStatus_RPTEntity.BuyerBookSpaceID = reader.GetInt64(FLD_BUYERBOOKSPACEID);
            cRMBookingStatus_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            cRMBookingStatus_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cRMBookingStatus_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID);
            if (reader.IsDBNull(FLD_BOOKINGNOTE)) { cRMBookingStatus_RPTEntity.BookingNote = String.Empty; } else { cRMBookingStatus_RPTEntity.BookingNote = reader.GetString(FLD_BOOKINGNOTE); }
            cRMBookingStatus_RPTEntity.IsLandOwner = reader.GetBoolean(FLD_ISLANDOWNER);
            cRMBookingStatus_RPTEntity.IsApprovedByManagement = reader.GetBoolean(FLD_ISAPPROVEDBYMANAGEMENT);
            cRMBookingStatus_RPTEntity.BookingStatusID = reader.GetInt64(FLD_BOOKINGSTATUSID);
            cRMBookingStatus_RPTEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_IP)) { cRMBookingStatus_RPTEntity.IP = String.Empty; } else { cRMBookingStatus_RPTEntity.IP = reader.GetString(FLD_IP); }
            cRMBookingStatus_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMBookingStatus_RPTEntity.ContactFullName = reader.GetString(FLD_CONTACTFULLNAME);
            if (reader.IsDBNull(FLD_DESIGNATION)) { cRMBookingStatus_RPTEntity.Designation = String.Empty; } else { cRMBookingStatus_RPTEntity.Designation = reader.GetString(FLD_DESIGNATION); }
            if (reader.IsDBNull(FLD_MOBILENO)) { cRMBookingStatus_RPTEntity.MobileNo = String.Empty; } else { cRMBookingStatus_RPTEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMBookingStatus_RPTEntity.Email = String.Empty; } else { cRMBookingStatus_RPTEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_PRESENTADDRESS)) { cRMBookingStatus_RPTEntity.PresentAddress = String.Empty; } else { cRMBookingStatus_RPTEntity.PresentAddress = reader.GetString(FLD_PRESENTADDRESS); }
            if (reader.IsDBNull(FLD_LEADGENERATEDBYEMPLOYEEID)) { cRMBookingStatus_RPTEntity.LeadGeneratedByEmployeeID = null; } else { cRMBookingStatus_RPTEntity.LeadGeneratedByEmployeeID = reader.GetInt64(FLD_LEADGENERATEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYONEEMPLOYEEID)) { cRMBookingStatus_RPTEntity.LeadManagedByOneEmployeeID = null; } else { cRMBookingStatus_RPTEntity.LeadManagedByOneEmployeeID = reader.GetInt64(FLD_LEADMANAGEDBYONEEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADMANAGEDBYTWOEMPLOYEEID)) { cRMBookingStatus_RPTEntity.LeadManagedByTwoEmployeeID = null; } else { cRMBookingStatus_RPTEntity.LeadManagedByTwoEmployeeID = reader.GetInt64(FLD_LEADMANAGEDBYTWOEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LEADCONVERSIONDATE)) { cRMBookingStatus_RPTEntity.LeadConversionDate = null; } else { cRMBookingStatus_RPTEntity.LeadConversionDate = reader.GetDateTime(FLD_LEADCONVERSIONDATE); }
            cRMBookingStatus_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            cRMBookingStatus_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            cRMBookingStatus_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME);
            cRMBookingStatus_RPTEntity.BookingStatus = reader.GetString(FLD_BOOKINGSTATUS);

            return cRMBookingStatus_RPTEntity;
        }
    }
}
