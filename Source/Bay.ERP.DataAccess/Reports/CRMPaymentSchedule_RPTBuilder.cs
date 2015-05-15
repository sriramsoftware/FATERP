// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Dec-2013, 03:44:05




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMPaymentSchedule_RPTBuilder : IEntityBuilder<CRMPaymentSchedule_RPTEntity>
    {
        IList<CRMPaymentSchedule_RPTEntity> IEntityBuilder<CRMPaymentSchedule_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMPaymentSchedule_RPTEntity> CRMPaymentSchedule_RPTEntityList = new List<CRMPaymentSchedule_RPTEntity>();

            while (reader.Read())
            {
                CRMPaymentSchedule_RPTEntityList.Add(((IEntityBuilder<CRMPaymentSchedule_RPTEntity>)this).BuildEntity(reader));
            }

            return (CRMPaymentSchedule_RPTEntityList.Count > 0) ? CRMPaymentSchedule_RPTEntityList : null;
        }

        CRMPaymentSchedule_RPTEntity IEntityBuilder<CRMPaymentSchedule_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_CREATEDATE = 15;
            const Int32 FLD_PROJECTID = 16;
            const Int32 FLD_PROJECTFLOORUNITID = 17;
            const Int32 FLD_BOOKINGNOTE = 18;
            const Int32 FLD_IMAGEURL = 19;
            const Int32 FLD_BDPROJECTCODE = 20;
            const Int32 FLD_PROJECTNAME = 21;
            const Int32 FLD_PROJECTFLOORUNITNAME = 22;
            const Int32 FLD_LINKPAYMENTSCHEDULEMAPID = 23;
            const Int32 FLD_INSTALLMENTNAME = 24;
            const Int32 FLD_INSTALLMENTDUEDATE = 25;
            const Int32 FLD_INSTALLMENTDUEDATENEW = 26;
            const Int32 FLD_AGREEMENTAAMOUNT = 27;
            const Int32 FLD_AGREEMENTBAMOUNT = 28;
            const Int32 FLD_AGREEMENTCAMOUNT = 29;
            const Int32 FLD_AGREEMENTDAMOUNT = 30;
            const Int32 FLD_AGREEMENTEAMOUNT = 31;
            const Int32 FLD_PAYMENTDUEDATE = 32;
            const Int32 FLD_FINALPAYMENT = 33;
            const Int32 FLD_PAYMENTSCHEDULEMAPCREATEDATE = 34;
            const Int32 FLD_CONTACTFULLNAME = 35;

            CRMPaymentSchedule_RPTEntity cRMPaymentSchedule_RPTEntity = new CRMPaymentSchedule_RPTEntity();

            cRMPaymentSchedule_RPTEntity.PaymentScheduleID = reader.GetInt64(FLD_PAYMENTSCHEDULEID);
            cRMPaymentSchedule_RPTEntity.BuyerBookSpaceID = reader.GetInt64(FLD_BUYERBOOKSPACEID);
            cRMPaymentSchedule_RPTEntity.HandoverDate = reader.GetDateTime(FLD_HANDOVERDATE);
            if (reader.IsDBNull(FLD_ACTUALHANDOVERDATE)) { cRMPaymentSchedule_RPTEntity.ActualHandoverDate = null; } else { cRMPaymentSchedule_RPTEntity.ActualHandoverDate = reader.GetDateTime(FLD_ACTUALHANDOVERDATE); }
            cRMPaymentSchedule_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            cRMPaymentSchedule_RPTEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            if (reader.IsDBNull(FLD_TOTALAGREEMENTAMOUNT)) { cRMPaymentSchedule_RPTEntity.TotalAgreementAmount = null; } else { cRMPaymentSchedule_RPTEntity.TotalAgreementAmount = reader.GetDecimal(FLD_TOTALAGREEMENTAMOUNT); }
            if (reader.IsDBNull(FLD_EARNESTMONEY)) { cRMPaymentSchedule_RPTEntity.EarnestMoney = null; } else { cRMPaymentSchedule_RPTEntity.EarnestMoney = reader.GetDecimal(FLD_EARNESTMONEY); }
            if (reader.IsDBNull(FLD_RESERVATION)) { cRMPaymentSchedule_RPTEntity.Reservation = null; } else { cRMPaymentSchedule_RPTEntity.Reservation = reader.GetDecimal(FLD_RESERVATION); }
            if (reader.IsDBNull(FLD_COMMONSERVICE)) { cRMPaymentSchedule_RPTEntity.CommonService = null; } else { cRMPaymentSchedule_RPTEntity.CommonService = reader.GetDecimal(FLD_COMMONSERVICE); }
            if (reader.IsDBNull(FLD_UTILITYCONNECTIONCOST)) { cRMPaymentSchedule_RPTEntity.UtilityConnectionCost = null; } else { cRMPaymentSchedule_RPTEntity.UtilityConnectionCost = reader.GetDecimal(FLD_UTILITYCONNECTIONCOST); }
            if (reader.IsDBNull(FLD_RESERVEDFUND)) { cRMPaymentSchedule_RPTEntity.ReservedFund = null; } else { cRMPaymentSchedule_RPTEntity.ReservedFund = reader.GetDecimal(FLD_RESERVEDFUND); }
            if (reader.IsDBNull(FLD_TOTALINSTALLMENT)) { cRMPaymentSchedule_RPTEntity.TotalInstallment = null; } else { cRMPaymentSchedule_RPTEntity.TotalInstallment = reader.GetDecimal(FLD_TOTALINSTALLMENT); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMPaymentSchedule_RPTEntity.Remarks = String.Empty; } else { cRMPaymentSchedule_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMPaymentSchedule_RPTEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            cRMPaymentSchedule_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_PROJECTID)) { cRMPaymentSchedule_RPTEntity.ProjectID = null; } else { cRMPaymentSchedule_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            cRMPaymentSchedule_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID);
            //if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { cRMPaymentSchedule_RPTEntity.ProjectFloorUnitID = null; } else { cRMPaymentSchedule_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_BOOKINGNOTE)) { cRMPaymentSchedule_RPTEntity.BookingNote = String.Empty; } else { cRMPaymentSchedule_RPTEntity.BookingNote = reader.GetString(FLD_BOOKINGNOTE); }
            if (reader.IsDBNull(FLD_IMAGEURL)) { cRMPaymentSchedule_RPTEntity.ImageUrl = String.Empty; } else { cRMPaymentSchedule_RPTEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }
            cRMPaymentSchedule_RPTEntity.BDProjectCode = reader.GetString(FLD_BDPROJECTCODE);
            cRMPaymentSchedule_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            cRMPaymentSchedule_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME);
            if (reader.IsDBNull(FLD_LINKPAYMENTSCHEDULEMAPID)) { cRMPaymentSchedule_RPTEntity.LinkPaymentScheduleMapID = null; } else { cRMPaymentSchedule_RPTEntity.LinkPaymentScheduleMapID = reader.GetInt64(FLD_LINKPAYMENTSCHEDULEMAPID); }
            if (reader.IsDBNull(FLD_INSTALLMENTNAME)) { cRMPaymentSchedule_RPTEntity.InstallmentName = String.Empty; } else { cRMPaymentSchedule_RPTEntity.InstallmentName = reader.GetString(FLD_INSTALLMENTNAME); }
            if (reader.IsDBNull(FLD_INSTALLMENTDUEDATE)) { cRMPaymentSchedule_RPTEntity.InstallmentDueDate = null; } else { cRMPaymentSchedule_RPTEntity.InstallmentDueDate = reader.GetDateTime(FLD_INSTALLMENTDUEDATE); }
            if (reader.IsDBNull(FLD_INSTALLMENTDUEDATENEW)) { cRMPaymentSchedule_RPTEntity.InstallmentDueDateNew = null; } else { cRMPaymentSchedule_RPTEntity.InstallmentDueDateNew = reader.GetDateTime(FLD_INSTALLMENTDUEDATENEW); }
            if (reader.IsDBNull(FLD_AGREEMENTAAMOUNT)) { cRMPaymentSchedule_RPTEntity.AgreementAAmount = null; } else { cRMPaymentSchedule_RPTEntity.AgreementAAmount = reader.GetDecimal(FLD_AGREEMENTAAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTBAMOUNT)) { cRMPaymentSchedule_RPTEntity.AgreementBAmount = null; } else { cRMPaymentSchedule_RPTEntity.AgreementBAmount = reader.GetDecimal(FLD_AGREEMENTBAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTCAMOUNT)) { cRMPaymentSchedule_RPTEntity.AgreementCAmount = null; } else { cRMPaymentSchedule_RPTEntity.AgreementCAmount = reader.GetDecimal(FLD_AGREEMENTCAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTDAMOUNT)) { cRMPaymentSchedule_RPTEntity.AgreementDAmount = null; } else { cRMPaymentSchedule_RPTEntity.AgreementDAmount = reader.GetDecimal(FLD_AGREEMENTDAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTEAMOUNT)) { cRMPaymentSchedule_RPTEntity.AgreementEAmount = null; } else { cRMPaymentSchedule_RPTEntity.AgreementEAmount = reader.GetDecimal(FLD_AGREEMENTEAMOUNT); }
            if (reader.IsDBNull(FLD_PAYMENTDUEDATE)) { cRMPaymentSchedule_RPTEntity.PaymentDueDate = null; } else { cRMPaymentSchedule_RPTEntity.PaymentDueDate = reader.GetDateTime(FLD_PAYMENTDUEDATE); }
            if (reader.IsDBNull(FLD_FINALPAYMENT)) { cRMPaymentSchedule_RPTEntity.FinalPayment = false; } else { cRMPaymentSchedule_RPTEntity.FinalPayment = reader.GetBoolean(FLD_FINALPAYMENT); }
            if (reader.IsDBNull(FLD_PAYMENTSCHEDULEMAPCREATEDATE)) { cRMPaymentSchedule_RPTEntity.PaymentScheduleMapCreateDate = null; } else { cRMPaymentSchedule_RPTEntity.PaymentScheduleMapCreateDate = reader.GetDateTime(FLD_PAYMENTSCHEDULEMAPCREATEDATE); }
            if (reader.IsDBNull(FLD_CONTACTFULLNAME)) { cRMPaymentSchedule_RPTEntity.ContactFullName = String.Empty; } else { cRMPaymentSchedule_RPTEntity.ContactFullName = reader.GetString(FLD_CONTACTFULLNAME); }

            return cRMPaymentSchedule_RPTEntity;
        }
    }
}
