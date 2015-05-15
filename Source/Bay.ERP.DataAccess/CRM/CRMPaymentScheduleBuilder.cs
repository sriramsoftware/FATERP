// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2013, 08:24:37




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMPaymentScheduleBuilder : IEntityBuilder<CRMPaymentScheduleEntity>
    {
        IList<CRMPaymentScheduleEntity> IEntityBuilder<CRMPaymentScheduleEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMPaymentScheduleEntity> CRMPaymentScheduleEntityList = new List<CRMPaymentScheduleEntity>();

            while (reader.Read())
            {
                CRMPaymentScheduleEntityList.Add(((IEntityBuilder<CRMPaymentScheduleEntity>)this).BuildEntity(reader));
            }

            return (CRMPaymentScheduleEntityList.Count > 0) ? CRMPaymentScheduleEntityList : null;
        }

        CRMPaymentScheduleEntity IEntityBuilder<CRMPaymentScheduleEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYMENTSCHEDULEID = 0;
            const Int32 FLD_BUYERBOOKSPACEID = 1;
            const Int32 FLD_HANDOVERDATE = 2;
            const Int32 FLD_ACTUALHANDOVERDATE = 3;
            const Int32 FLD_PROJECTCODE = 4;
            const Int32 FLD_BUYERBASICINFOID = 5;
            const Int32 FLD_TOTALAGREEMENTAMOUNT = 6;
            const Int32 FLD_EARNESTMONEY = 7;
            const Int32 FLD_RESERVATION = 8;
            const Int32 FLD_COMMONSERVICE = 9;
            const Int32 FLD_UTILITYCONNECTIONCOST = 10;
            const Int32 FLD_RESERVEDFUND = 11;
            const Int32 FLD_TOTALINSTALLMENT = 12;
            const Int32 FLD_REMARKS = 13;
            const Int32 FLD_CREATEBYEMPLOYEEID = 14;
            const Int32 FLD_IP = 15;
            const Int32 FLD_CREATEDATE = 16;

            CRMPaymentScheduleEntity cRMPaymentScheduleEntity = new CRMPaymentScheduleEntity();

            cRMPaymentScheduleEntity.PaymentScheduleID = reader.GetInt64(FLD_PAYMENTSCHEDULEID);
            cRMPaymentScheduleEntity.BuyerBookSpaceID = reader.GetInt64(FLD_BUYERBOOKSPACEID);
            cRMPaymentScheduleEntity.HandoverDate = reader.GetDateTime(FLD_HANDOVERDATE);
            if (reader.IsDBNull(FLD_ACTUALHANDOVERDATE)) { cRMPaymentScheduleEntity.ActualHandoverDate = null; } else { cRMPaymentScheduleEntity.ActualHandoverDate = reader.GetDateTime(FLD_ACTUALHANDOVERDATE); }
            cRMPaymentScheduleEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            cRMPaymentScheduleEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            if (reader.IsDBNull(FLD_TOTALAGREEMENTAMOUNT)) { cRMPaymentScheduleEntity.TotalAgreementAmount = null; } else { cRMPaymentScheduleEntity.TotalAgreementAmount = reader.GetDecimal(FLD_TOTALAGREEMENTAMOUNT); }
            if (reader.IsDBNull(FLD_EARNESTMONEY)) { cRMPaymentScheduleEntity.EarnestMoney = null; } else { cRMPaymentScheduleEntity.EarnestMoney = reader.GetDecimal(FLD_EARNESTMONEY); }
            if (reader.IsDBNull(FLD_RESERVATION)) { cRMPaymentScheduleEntity.Reservation = null; } else { cRMPaymentScheduleEntity.Reservation = reader.GetDecimal(FLD_RESERVATION); }
            if (reader.IsDBNull(FLD_COMMONSERVICE)) { cRMPaymentScheduleEntity.CommonService = null; } else { cRMPaymentScheduleEntity.CommonService = reader.GetDecimal(FLD_COMMONSERVICE); }
            if (reader.IsDBNull(FLD_UTILITYCONNECTIONCOST)) { cRMPaymentScheduleEntity.UtilityConnectionCost = null; } else { cRMPaymentScheduleEntity.UtilityConnectionCost = reader.GetDecimal(FLD_UTILITYCONNECTIONCOST); }
            if (reader.IsDBNull(FLD_RESERVEDFUND)) { cRMPaymentScheduleEntity.ReservedFund = null; } else { cRMPaymentScheduleEntity.ReservedFund = reader.GetDecimal(FLD_RESERVEDFUND); }
            if (reader.IsDBNull(FLD_TOTALINSTALLMENT)) { cRMPaymentScheduleEntity.TotalInstallment = null; } else { cRMPaymentScheduleEntity.TotalInstallment = reader.GetDecimal(FLD_TOTALINSTALLMENT); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMPaymentScheduleEntity.Remarks = String.Empty; } else { cRMPaymentScheduleEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMPaymentScheduleEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            cRMPaymentScheduleEntity.IP = reader.GetString(FLD_IP);
            cRMPaymentScheduleEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);

            return cRMPaymentScheduleEntity;
        }
    }
}
