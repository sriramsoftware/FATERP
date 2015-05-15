// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 10:33:07




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMPaymentScheduleMap_DetailedBuilder : IEntityBuilder<CRMPaymentScheduleMap_DetailedEntity>
    {
        IList<CRMPaymentScheduleMap_DetailedEntity> IEntityBuilder<CRMPaymentScheduleMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMPaymentScheduleMap_DetailedEntity> CRMPaymentScheduleMap_DetailedEntityList = new List<CRMPaymentScheduleMap_DetailedEntity>();

            while (reader.Read())
            {
                CRMPaymentScheduleMap_DetailedEntityList.Add(((IEntityBuilder<CRMPaymentScheduleMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CRMPaymentScheduleMap_DetailedEntityList.Count > 0) ? CRMPaymentScheduleMap_DetailedEntityList : null;
        }

        CRMPaymentScheduleMap_DetailedEntity IEntityBuilder<CRMPaymentScheduleMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYMENTSCHEDULEMAPID = 0;
            const Int32 FLD_LINKPAYMENTSCHEDULEMAPID = 1;
            const Int32 FLD_PAYMENTSCHEDULEID = 2;
            const Int32 FLD_INSTALLMENTNAME = 3;
            const Int32 FLD_INSTALLMENTDUEDATE = 4;
            const Int32 FLD_INSTALLMENTDUEDATENEW = 5;
            const Int32 FLD_AGREEMENTAAMOUNT = 6;
            const Int32 FLD_AGREEMENTBAMOUNT = 7;
            const Int32 FLD_AGREEMENTCAMOUNT = 8;
            const Int32 FLD_AGREEMENTDAMOUNT = 9;
            const Int32 FLD_AGREEMENTEAMOUNT = 10;
            const Int32 FLD_PAYMENTDUEDATE = 11;
            const Int32 FLD_FINALPAYMENT = 12;
            const Int32 FLD_REVISED = 13;
            const Int32 FLD_REVISEDIP = 14;
            const Int32 FLD_LASTREVISEDBYEMPLOYEEID = 15;
            const Int32 FLD_LASTREVISEDDATE = 16;
            const Int32 FLD_REMARKS = 17;
            const Int32 FLD_CREATEDATE = 18;
            const Int32 FLD_CREATEBYEMPLOYEEID = 19;
            const Int32 FLD_IP = 20;
            const Int32 FLD_AGREEMENTID = 21;
            const Int32 FLD_AGREEMENTDATE = 22;
            const Int32 FLD_TOTALAGREEMENTAMOUNT = 23;
            const Int32 FLD_EARNESTMONEY = 24;
            const Int32 FLD_RESERVATION = 25;
            const Int32 FLD_COMMONSERVICE = 26;
            const Int32 FLD_UTILITYCONNECTIONCOST = 27;
            const Int32 FLD_ROWNUMBER = 28;

            CRMPaymentScheduleMap_DetailedEntity cRMPaymentScheduleMap_DetailedEntity = new CRMPaymentScheduleMap_DetailedEntity();

            cRMPaymentScheduleMap_DetailedEntity.PaymentScheduleMapID = reader.GetInt64(FLD_PAYMENTSCHEDULEMAPID);
            if (reader.IsDBNull(FLD_LINKPAYMENTSCHEDULEMAPID)) { cRMPaymentScheduleMap_DetailedEntity.LinkPaymentScheduleMapID = null; } else { cRMPaymentScheduleMap_DetailedEntity.LinkPaymentScheduleMapID = reader.GetInt64(FLD_LINKPAYMENTSCHEDULEMAPID); }
            cRMPaymentScheduleMap_DetailedEntity.PaymentScheduleID = reader.GetInt64(FLD_PAYMENTSCHEDULEID);
            cRMPaymentScheduleMap_DetailedEntity.InstallmentName = reader.GetString(FLD_INSTALLMENTNAME);
            cRMPaymentScheduleMap_DetailedEntity.InstallmentDueDate = reader.GetDateTime(FLD_INSTALLMENTDUEDATE);
            if (reader.IsDBNull(FLD_INSTALLMENTDUEDATENEW)) { cRMPaymentScheduleMap_DetailedEntity.InstallmentDueDateNew = null; } else { cRMPaymentScheduleMap_DetailedEntity.InstallmentDueDateNew = reader.GetDateTime(FLD_INSTALLMENTDUEDATENEW); }
            if (reader.IsDBNull(FLD_AGREEMENTAAMOUNT)) { cRMPaymentScheduleMap_DetailedEntity.AgreementAAmount = null; } else { cRMPaymentScheduleMap_DetailedEntity.AgreementAAmount = reader.GetDecimal(FLD_AGREEMENTAAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTBAMOUNT)) { cRMPaymentScheduleMap_DetailedEntity.AgreementBAmount = null; } else { cRMPaymentScheduleMap_DetailedEntity.AgreementBAmount = reader.GetDecimal(FLD_AGREEMENTBAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTCAMOUNT)) { cRMPaymentScheduleMap_DetailedEntity.AgreementCAmount = null; } else { cRMPaymentScheduleMap_DetailedEntity.AgreementCAmount = reader.GetDecimal(FLD_AGREEMENTCAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTDAMOUNT)) { cRMPaymentScheduleMap_DetailedEntity.AgreementDAmount = null; } else { cRMPaymentScheduleMap_DetailedEntity.AgreementDAmount = reader.GetDecimal(FLD_AGREEMENTDAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTEAMOUNT)) { cRMPaymentScheduleMap_DetailedEntity.AgreementEAmount = null; } else { cRMPaymentScheduleMap_DetailedEntity.AgreementEAmount = reader.GetDecimal(FLD_AGREEMENTEAMOUNT); }
            if (reader.IsDBNull(FLD_PAYMENTDUEDATE)) { cRMPaymentScheduleMap_DetailedEntity.PaymentDueDate = null; } else { cRMPaymentScheduleMap_DetailedEntity.PaymentDueDate = reader.GetDateTime(FLD_PAYMENTDUEDATE); }
            cRMPaymentScheduleMap_DetailedEntity.FinalPayment = reader.GetBoolean(FLD_FINALPAYMENT);
            cRMPaymentScheduleMap_DetailedEntity.Revised = reader.GetBoolean(FLD_REVISED);
            if (reader.IsDBNull(FLD_REVISEDIP)) { cRMPaymentScheduleMap_DetailedEntity.RevisedIP = String.Empty; } else { cRMPaymentScheduleMap_DetailedEntity.RevisedIP = reader.GetString(FLD_REVISEDIP); }
            if (reader.IsDBNull(FLD_LASTREVISEDBYEMPLOYEEID)) { cRMPaymentScheduleMap_DetailedEntity.LastRevisedByEmployeeID = null; } else { cRMPaymentScheduleMap_DetailedEntity.LastRevisedByEmployeeID = reader.GetInt64(FLD_LASTREVISEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LASTREVISEDDATE)) { cRMPaymentScheduleMap_DetailedEntity.LastRevisedDate = null; } else { cRMPaymentScheduleMap_DetailedEntity.LastRevisedDate = reader.GetDateTime(FLD_LASTREVISEDDATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMPaymentScheduleMap_DetailedEntity.Remarks = String.Empty; } else { cRMPaymentScheduleMap_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMPaymentScheduleMap_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMPaymentScheduleMap_DetailedEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            cRMPaymentScheduleMap_DetailedEntity.IP = reader.GetString(FLD_IP);
            cRMPaymentScheduleMap_DetailedEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID);
            if (reader.IsDBNull(FLD_AGREEMENTDATE)) { cRMPaymentScheduleMap_DetailedEntity.AgreementDate = null; } else { cRMPaymentScheduleMap_DetailedEntity.AgreementDate = reader.GetDateTime(FLD_AGREEMENTDATE); }
            if (reader.IsDBNull(FLD_TOTALAGREEMENTAMOUNT)) { cRMPaymentScheduleMap_DetailedEntity.TotalAgreementAmount = null; } else { cRMPaymentScheduleMap_DetailedEntity.TotalAgreementAmount = reader.GetDecimal(FLD_TOTALAGREEMENTAMOUNT); }
            if (reader.IsDBNull(FLD_EARNESTMONEY)) { cRMPaymentScheduleMap_DetailedEntity.EarnestMoney = null; } else { cRMPaymentScheduleMap_DetailedEntity.EarnestMoney = reader.GetDecimal(FLD_EARNESTMONEY); }
            if (reader.IsDBNull(FLD_RESERVATION)) { cRMPaymentScheduleMap_DetailedEntity.Reservation = null; } else { cRMPaymentScheduleMap_DetailedEntity.Reservation = reader.GetDecimal(FLD_RESERVATION); }
            if (reader.IsDBNull(FLD_COMMONSERVICE)) { cRMPaymentScheduleMap_DetailedEntity.CommonService = null; } else { cRMPaymentScheduleMap_DetailedEntity.CommonService = reader.GetDecimal(FLD_COMMONSERVICE); }
            if (reader.IsDBNull(FLD_UTILITYCONNECTIONCOST)) { cRMPaymentScheduleMap_DetailedEntity.UtilityConnectionCost = null; } else { cRMPaymentScheduleMap_DetailedEntity.UtilityConnectionCost = reader.GetDecimal(FLD_UTILITYCONNECTIONCOST); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cRMPaymentScheduleMap_DetailedEntity.RowNumber = null; } else { cRMPaymentScheduleMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cRMPaymentScheduleMap_DetailedEntity;
        }
    }
}
