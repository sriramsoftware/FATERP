// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Dec-2013, 10:37:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMPaymentSchedule_DetailedBuilder : IEntityBuilder<CRMPaymentSchedule_DetailedEntity>
    {
        IList<CRMPaymentSchedule_DetailedEntity> IEntityBuilder<CRMPaymentSchedule_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMPaymentSchedule_DetailedEntity> CRMPaymentSchedule_DetailedEntityList = new List<CRMPaymentSchedule_DetailedEntity>();

            while (reader.Read())
            {
                CRMPaymentSchedule_DetailedEntityList.Add(((IEntityBuilder<CRMPaymentSchedule_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CRMPaymentSchedule_DetailedEntityList.Count > 0) ? CRMPaymentSchedule_DetailedEntityList : null;
        }

        CRMPaymentSchedule_DetailedEntity IEntityBuilder<CRMPaymentSchedule_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYMENTSCHEDULEID = 0;
            const Int32 FLD_HANDOVERDATE = 1;
            const Int32 FLD_ACTUALHANDOVERDATE = 2;
            const Int32 FLD_BDPROJECTCODE = 3;
            const Int32 FLD_BUYERBASICINFOID = 4;
            const Int32 FLD_COMMONSERVICE = 5;
            const Int32 FLD_UTILITYCONNECTIONCOST = 6;
            const Int32 FLD_RESERVEDFUND = 7;
            const Int32 FLD_TOTALINSTALLMENT = 8;
            const Int32 FLD_REMARKS = 9;
            const Int32 FLD_CREATEBYEMPLOYEEID = 10;
            const Int32 FLD_IP = 11;
            const Int32 FLD_CREATEDATE = 12;
            const Int32 FLD_BUYERBASICINFOCONTACTFULLNAME = 13;
            const Int32 FLD_PROJECTCODE = 14;
            const Int32 FLD_PROJECTNAME = 15;
            const Int32 FLD_BOOKINGNOTE = 16;
            const Int32 FLD_PROJECTFLOORUNITID = 17;
            const Int32 FLD_PROJECTFLOORUNITNAME = 18;
            const Int32 FLD_IMAGEURL = 19;
            const Int32 FLD_MEMBERFULLNAME = 20;
            const Int32 FLD_ROWNUMBER = 21;

            CRMPaymentSchedule_DetailedEntity cRMPaymentSchedule_DetailedEntity = new CRMPaymentSchedule_DetailedEntity();

            cRMPaymentSchedule_DetailedEntity.PaymentScheduleID = reader.GetInt64(FLD_PAYMENTSCHEDULEID);
            cRMPaymentSchedule_DetailedEntity.HandoverDate = reader.GetDateTime(FLD_HANDOVERDATE);
            if (reader.IsDBNull(FLD_ACTUALHANDOVERDATE)) { cRMPaymentSchedule_DetailedEntity.ActualHandoverDate = null; } else { cRMPaymentSchedule_DetailedEntity.ActualHandoverDate = reader.GetDateTime(FLD_ACTUALHANDOVERDATE); }
            cRMPaymentSchedule_DetailedEntity.BDProjectCode = reader.GetString(FLD_BDPROJECTCODE);
            cRMPaymentSchedule_DetailedEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            if (reader.IsDBNull(FLD_COMMONSERVICE)) { cRMPaymentSchedule_DetailedEntity.CommonService = null; } else { cRMPaymentSchedule_DetailedEntity.CommonService = reader.GetDecimal(FLD_COMMONSERVICE); }
            if (reader.IsDBNull(FLD_UTILITYCONNECTIONCOST)) { cRMPaymentSchedule_DetailedEntity.UtilityConnectionCost = null; } else { cRMPaymentSchedule_DetailedEntity.UtilityConnectionCost = reader.GetDecimal(FLD_UTILITYCONNECTIONCOST); }
            if (reader.IsDBNull(FLD_RESERVEDFUND)) { cRMPaymentSchedule_DetailedEntity.ReservedFund = null; } else { cRMPaymentSchedule_DetailedEntity.ReservedFund = reader.GetDecimal(FLD_RESERVEDFUND); }
            if (reader.IsDBNull(FLD_TOTALINSTALLMENT)) { cRMPaymentSchedule_DetailedEntity.TotalInstallment = null; } else { cRMPaymentSchedule_DetailedEntity.TotalInstallment = reader.GetDecimal(FLD_TOTALINSTALLMENT); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMPaymentSchedule_DetailedEntity.Remarks = String.Empty; } else { cRMPaymentSchedule_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMPaymentSchedule_DetailedEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            cRMPaymentSchedule_DetailedEntity.IP = reader.GetString(FLD_IP);
            cRMPaymentSchedule_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_BUYERBASICINFOCONTACTFULLNAME)) { cRMPaymentSchedule_DetailedEntity.BuyerBasicInfoContactFullName = String.Empty; } else { cRMPaymentSchedule_DetailedEntity.BuyerBasicInfoContactFullName = reader.GetString(FLD_BUYERBASICINFOCONTACTFULLNAME); }
            cRMPaymentSchedule_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            cRMPaymentSchedule_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_BOOKINGNOTE)) { cRMPaymentSchedule_DetailedEntity.BookingNote = String.Empty; } else { cRMPaymentSchedule_DetailedEntity.BookingNote = reader.GetString(FLD_BOOKINGNOTE); }
            cRMPaymentSchedule_DetailedEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID);
            cRMPaymentSchedule_DetailedEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME);
            if (reader.IsDBNull(FLD_IMAGEURL)) { cRMPaymentSchedule_DetailedEntity.ImageUrl = String.Empty; } else { cRMPaymentSchedule_DetailedEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { cRMPaymentSchedule_DetailedEntity.MemberFullName = String.Empty; } else { cRMPaymentSchedule_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cRMPaymentSchedule_DetailedEntity.RowNumber = null; } else { cRMPaymentSchedule_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cRMPaymentSchedule_DetailedEntity;
        }
    }
}
