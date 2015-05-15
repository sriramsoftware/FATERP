// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-May-2013, 10:12:36




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMPaymentScheduleMapBuilder : IEntityBuilder<CRMPaymentScheduleMapEntity>
    {
        IList<CRMPaymentScheduleMapEntity> IEntityBuilder<CRMPaymentScheduleMapEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMPaymentScheduleMapEntity> CRMPaymentScheduleMapEntityList = new List<CRMPaymentScheduleMapEntity>();

            while (reader.Read())
            {
                CRMPaymentScheduleMapEntityList.Add(((IEntityBuilder<CRMPaymentScheduleMapEntity>)this).BuildEntity(reader));
            }

            return (CRMPaymentScheduleMapEntityList.Count > 0) ? CRMPaymentScheduleMapEntityList : null;
        }

        CRMPaymentScheduleMapEntity IEntityBuilder<CRMPaymentScheduleMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYMENTSCHEDULEMAPID = 0;
            const Int32 FLD_LINKPAYMENTSCHEDULEMAPID = 1;
            const Int32 FLD_PAYMENTSCHEDULEID = 2;
            const Int32 FLD_INSTALLMENTNAME = 3;
            const Int32 FLD_INSTALLMENTDUEDATE = 4;
            const Int32 FLD_INSTALLMENTDUEDATENEW = 5;
            const Int32 FLD_AGREEMENTID = 6;
            const Int32 FLD_AGREEMENTAAMOUNT = 7;
            const Int32 FLD_AGREEMENTBAMOUNT = 8;
            const Int32 FLD_AGREEMENTCAMOUNT = 9;
            const Int32 FLD_AGREEMENTDAMOUNT = 10;
            const Int32 FLD_AGREEMENTEAMOUNT = 11;
            const Int32 FLD_PAYMENTDUEDATE = 12;
            const Int32 FLD_FINALPAYMENT = 13;
            const Int32 FLD_REVISED = 14;
            const Int32 FLD_REVISEDIP = 15;
            const Int32 FLD_LASTREVISEDBYEMPLOYEEID = 16;
            const Int32 FLD_LASTREVISEDDATE = 17;
            const Int32 FLD_REMARKS = 18;
            const Int32 FLD_CREATEDATE = 19;
            const Int32 FLD_CREATEBYEMPLOYEEID = 20;
            const Int32 FLD_IP = 21;

            CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = new CRMPaymentScheduleMapEntity();

            cRMPaymentScheduleMapEntity.PaymentScheduleMapID = reader.GetInt64(FLD_PAYMENTSCHEDULEMAPID);
            if (reader.IsDBNull(FLD_LINKPAYMENTSCHEDULEMAPID)) { cRMPaymentScheduleMapEntity.LinkPaymentScheduleMapID = null; } else { cRMPaymentScheduleMapEntity.LinkPaymentScheduleMapID = reader.GetInt64(FLD_LINKPAYMENTSCHEDULEMAPID); }
            cRMPaymentScheduleMapEntity.PaymentScheduleID = reader.GetInt64(FLD_PAYMENTSCHEDULEID);
            cRMPaymentScheduleMapEntity.InstallmentName = reader.GetString(FLD_INSTALLMENTNAME);
            cRMPaymentScheduleMapEntity.InstallmentDueDate = reader.GetDateTime(FLD_INSTALLMENTDUEDATE);
            if (reader.IsDBNull(FLD_INSTALLMENTDUEDATENEW)) { cRMPaymentScheduleMapEntity.InstallmentDueDateNew = null; } else { cRMPaymentScheduleMapEntity.InstallmentDueDateNew = reader.GetDateTime(FLD_INSTALLMENTDUEDATENEW); }
            if (reader.IsDBNull(FLD_AGREEMENTID)) { cRMPaymentScheduleMapEntity.AgreementID = null; } else { cRMPaymentScheduleMapEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID); }
            if (reader.IsDBNull(FLD_AGREEMENTAAMOUNT)) { cRMPaymentScheduleMapEntity.AgreementAAmount = null; } else { cRMPaymentScheduleMapEntity.AgreementAAmount = reader.GetDecimal(FLD_AGREEMENTAAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTBAMOUNT)) { cRMPaymentScheduleMapEntity.AgreementBAmount = null; } else { cRMPaymentScheduleMapEntity.AgreementBAmount = reader.GetDecimal(FLD_AGREEMENTBAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTCAMOUNT)) { cRMPaymentScheduleMapEntity.AgreementCAmount = null; } else { cRMPaymentScheduleMapEntity.AgreementCAmount = reader.GetDecimal(FLD_AGREEMENTCAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTDAMOUNT)) { cRMPaymentScheduleMapEntity.AgreementDAmount = null; } else { cRMPaymentScheduleMapEntity.AgreementDAmount = reader.GetDecimal(FLD_AGREEMENTDAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTEAMOUNT)) { cRMPaymentScheduleMapEntity.AgreementEAmount = null; } else { cRMPaymentScheduleMapEntity.AgreementEAmount = reader.GetDecimal(FLD_AGREEMENTEAMOUNT); }
            if (reader.IsDBNull(FLD_PAYMENTDUEDATE)) { cRMPaymentScheduleMapEntity.PaymentDueDate = null; } else { cRMPaymentScheduleMapEntity.PaymentDueDate = reader.GetDateTime(FLD_PAYMENTDUEDATE); }
            cRMPaymentScheduleMapEntity.FinalPayment = reader.GetBoolean(FLD_FINALPAYMENT);
            cRMPaymentScheduleMapEntity.Revised = reader.GetBoolean(FLD_REVISED);
            if (reader.IsDBNull(FLD_REVISEDIP)) { cRMPaymentScheduleMapEntity.RevisedIP = String.Empty; } else { cRMPaymentScheduleMapEntity.RevisedIP = reader.GetString(FLD_REVISEDIP); }
            if (reader.IsDBNull(FLD_LASTREVISEDBYEMPLOYEEID)) { cRMPaymentScheduleMapEntity.LastRevisedByEmployeeID = null; } else { cRMPaymentScheduleMapEntity.LastRevisedByEmployeeID = reader.GetInt64(FLD_LASTREVISEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_LASTREVISEDDATE)) { cRMPaymentScheduleMapEntity.LastRevisedDate = null; } else { cRMPaymentScheduleMapEntity.LastRevisedDate = reader.GetDateTime(FLD_LASTREVISEDDATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMPaymentScheduleMapEntity.Remarks = String.Empty; } else { cRMPaymentScheduleMapEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMPaymentScheduleMapEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMPaymentScheduleMapEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            cRMPaymentScheduleMapEntity.IP = reader.GetString(FLD_IP);

            return cRMPaymentScheduleMapEntity;
        }
    }
}
