// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-May-2013, 02:02:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMPaymentEncashed_RPTBuilder : IEntityBuilder<CRMPaymentEncashed_RPTEntity>
    {
        IList<CRMPaymentEncashed_RPTEntity> IEntityBuilder<CRMPaymentEncashed_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMPaymentEncashed_RPTEntity> CRMPaymentEncashed_RPTEntityList = new List<CRMPaymentEncashed_RPTEntity>();

            while (reader.Read())
            {
                CRMPaymentEncashed_RPTEntityList.Add(((IEntityBuilder<CRMPaymentEncashed_RPTEntity>)this).BuildEntity(reader));
            }

            return (CRMPaymentEncashed_RPTEntityList.Count > 0) ? CRMPaymentEncashed_RPTEntityList : null;
        }

        CRMPaymentEncashed_RPTEntity IEntityBuilder<CRMPaymentEncashed_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYMENTCOLLECTIONID = 0;
            const Int32 FLD_PAYMENTSCHEDULEMAPID = 1;
            const Int32 FLD_PAYMENTSCHEDULEID = 2;
            const Int32 FLD_AGREEMENTTYPEID = 3;
            const Int32 FLD_MONEYRECEIPTNO = 4;
            const Int32 FLD_ACTUALPAYMENTDATE = 5;
            const Int32 FLD_PAYMENTDESCRIPTION = 6;
            const Int32 FLD_INSTALLMENTPAYMENTAMOUNT = 7;
            const Int32 FLD_INSTALLMENTPAYMENTINWORD = 8;
            const Int32 FLD_INITIALAMOUNTINAGREEMENT = 9;
            const Int32 FLD_OVERDUEAMOUNT = 10;
            const Int32 FLD_DELAYDAYONPAYMENT = 11;
            const Int32 FLD_DELAYDAYONOVERDUE = 12;
            const Int32 FLD_PAYMENTRECEIVEDINBANK = 13;
            const Int32 FLD_PAYMENTNOTRECEIVEDNOTE = 14;
            const Int32 FLD_AGREEMENTID = 15;
            const Int32 FLD_PROJECTID = 16;
            const Int32 FLD_REVERSEENTRY = 17;
            const Int32 FLD_LASTPAYMENT = 18;
            const Int32 FLD_DISCOUNTAMOUNT = 19;
            const Int32 FLD_VAT = 20;
            const Int32 FLD_TAX = 21;
            const Int32 FLD_SERVICECHARGE = 22;
            const Int32 FLD_ADDITIONALFEE = 23;
            const Int32 FLD_GROSSAMOUNT = 24;
            const Int32 FLD_NETAMOUNT = 25;
            const Int32 FLD_PAYMENTAPPROVALSTATUSID = 26;
            const Int32 FLD_PAYMENTCATEGORYID = 27;
            const Int32 FLD_EXTRAFIELD = 28;
            const Int32 FLD_CASHORCHEQUENO = 29;
            const Int32 FLD_CASHORCHEQUEDATE = 30;
            const Int32 FLD_BANKNAME = 31;
            const Int32 FLD_BRANCHNAME = 32;
            const Int32 FLD_CHEQUEINCASHCONFIRMATION = 33;
            const Int32 FLD_REMARKS = 34;
            const Int32 FLD_CREATEDATE = 35;
            const Int32 FLD_CREATEBYEMPLOYEEID = 36;
            const Int32 FLD_IP = 37;
            const Int32 FLD_INSTALLMENTNAME = 38;
            const Int32 FLD_INSTALLMENTDUEDATE = 39;
            const Int32 FLD_PROJECTCODE = 40;
            const Int32 FLD_PROJECTNAME = 41;
            const Int32 FLD_CONTACTFULLNAME = 42;
            const Int32 FLD_COMPANYNAME = 43;
            const Int32 FLD_DESIGNATION = 44;
            const Int32 FLD_PROJECTFLOORUNITNAME = 45;
            const Int32 FLD_AGREEMENTAAMOUNT = 46;
            const Int32 FLD_AGREEMENTBAMOUNT = 47;
            const Int32 FLD_AGREEMENTCAMOUNT = 48;
            const Int32 FLD_MEMBERFULLNAME = 49;

            CRMPaymentEncashed_RPTEntity cRMPaymentEncashed_RPTEntity = new CRMPaymentEncashed_RPTEntity();

            cRMPaymentEncashed_RPTEntity.PaymentCollectionID = reader.GetInt64(FLD_PAYMENTCOLLECTIONID);
            cRMPaymentEncashed_RPTEntity.PaymentScheduleMapID = reader.GetInt64(FLD_PAYMENTSCHEDULEMAPID);
            cRMPaymentEncashed_RPTEntity.PaymentScheduleID = reader.GetInt64(FLD_PAYMENTSCHEDULEID);
            cRMPaymentEncashed_RPTEntity.AgreementTypeID = reader.GetInt64(FLD_AGREEMENTTYPEID);
            cRMPaymentEncashed_RPTEntity.MoneyReceiptNo = reader.GetDecimal(FLD_MONEYRECEIPTNO);
            if (reader.IsDBNull(FLD_ACTUALPAYMENTDATE)) { cRMPaymentEncashed_RPTEntity.ActualPaymentDate = null; } else { cRMPaymentEncashed_RPTEntity.ActualPaymentDate = reader.GetDateTime(FLD_ACTUALPAYMENTDATE); }
            if (reader.IsDBNull(FLD_PAYMENTDESCRIPTION)) { cRMPaymentEncashed_RPTEntity.PaymentDescription = String.Empty; } else { cRMPaymentEncashed_RPTEntity.PaymentDescription = reader.GetString(FLD_PAYMENTDESCRIPTION); }
            if (reader.IsDBNull(FLD_INSTALLMENTPAYMENTAMOUNT)) { cRMPaymentEncashed_RPTEntity.InstallmentPaymentAmount = null; } else { cRMPaymentEncashed_RPTEntity.InstallmentPaymentAmount = reader.GetDecimal(FLD_INSTALLMENTPAYMENTAMOUNT); }
            cRMPaymentEncashed_RPTEntity.InstallmentPaymentInWord = reader.GetString(FLD_INSTALLMENTPAYMENTINWORD);
            if (reader.IsDBNull(FLD_INITIALAMOUNTINAGREEMENT)) { cRMPaymentEncashed_RPTEntity.InitialAmountInAgreement = null; } else { cRMPaymentEncashed_RPTEntity.InitialAmountInAgreement = reader.GetDecimal(FLD_INITIALAMOUNTINAGREEMENT); }
            if (reader.IsDBNull(FLD_OVERDUEAMOUNT)) { cRMPaymentEncashed_RPTEntity.OverDueAmount = null; } else { cRMPaymentEncashed_RPTEntity.OverDueAmount = reader.GetDecimal(FLD_OVERDUEAMOUNT); }
            if (reader.IsDBNull(FLD_DELAYDAYONPAYMENT)) { cRMPaymentEncashed_RPTEntity.DelayDayOnPayment = null; } else { cRMPaymentEncashed_RPTEntity.DelayDayOnPayment = reader.GetDecimal(FLD_DELAYDAYONPAYMENT); }
            if (reader.IsDBNull(FLD_DELAYDAYONOVERDUE)) { cRMPaymentEncashed_RPTEntity.DelayDayOnOverDue = null; } else { cRMPaymentEncashed_RPTEntity.DelayDayOnOverDue = reader.GetDecimal(FLD_DELAYDAYONOVERDUE); }
            if (reader.IsDBNull(FLD_PAYMENTRECEIVEDINBANK)) { cRMPaymentEncashed_RPTEntity.PaymentReceivedInBank = null; } else { cRMPaymentEncashed_RPTEntity.PaymentReceivedInBank = reader.GetDecimal(FLD_PAYMENTRECEIVEDINBANK); }
            if (reader.IsDBNull(FLD_PAYMENTNOTRECEIVEDNOTE)) { cRMPaymentEncashed_RPTEntity.PaymentNotReceivedNote = String.Empty; } else { cRMPaymentEncashed_RPTEntity.PaymentNotReceivedNote = reader.GetString(FLD_PAYMENTNOTRECEIVEDNOTE); }
            cRMPaymentEncashed_RPTEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID);
            cRMPaymentEncashed_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cRMPaymentEncashed_RPTEntity.ReverseEntry = reader.GetBoolean(FLD_REVERSEENTRY);
            cRMPaymentEncashed_RPTEntity.LastPayment = reader.GetBoolean(FLD_LASTPAYMENT);
            if (reader.IsDBNull(FLD_DISCOUNTAMOUNT)) { cRMPaymentEncashed_RPTEntity.DiscountAmount = null; } else { cRMPaymentEncashed_RPTEntity.DiscountAmount = reader.GetDecimal(FLD_DISCOUNTAMOUNT); }
            if (reader.IsDBNull(FLD_VAT)) { cRMPaymentEncashed_RPTEntity.Vat = null; } else { cRMPaymentEncashed_RPTEntity.Vat = reader.GetDecimal(FLD_VAT); }
            if (reader.IsDBNull(FLD_TAX)) { cRMPaymentEncashed_RPTEntity.Tax = null; } else { cRMPaymentEncashed_RPTEntity.Tax = reader.GetDecimal(FLD_TAX); }
            if (reader.IsDBNull(FLD_SERVICECHARGE)) { cRMPaymentEncashed_RPTEntity.ServiceCharge = null; } else { cRMPaymentEncashed_RPTEntity.ServiceCharge = reader.GetDecimal(FLD_SERVICECHARGE); }
            if (reader.IsDBNull(FLD_ADDITIONALFEE)) { cRMPaymentEncashed_RPTEntity.AdditionalFee = null; } else { cRMPaymentEncashed_RPTEntity.AdditionalFee = reader.GetDecimal(FLD_ADDITIONALFEE); }
            if (reader.IsDBNull(FLD_GROSSAMOUNT)) { cRMPaymentEncashed_RPTEntity.GrossAmount = null; } else { cRMPaymentEncashed_RPTEntity.GrossAmount = reader.GetDecimal(FLD_GROSSAMOUNT); }
            if (reader.IsDBNull(FLD_NETAMOUNT)) { cRMPaymentEncashed_RPTEntity.NetAmount = null; } else { cRMPaymentEncashed_RPTEntity.NetAmount = reader.GetDecimal(FLD_NETAMOUNT); }
            cRMPaymentEncashed_RPTEntity.PaymentApprovalStatusID = reader.GetInt64(FLD_PAYMENTAPPROVALSTATUSID);
            cRMPaymentEncashed_RPTEntity.PaymentCategoryID = reader.GetInt64(FLD_PAYMENTCATEGORYID);
            if (reader.IsDBNull(FLD_EXTRAFIELD)) { cRMPaymentEncashed_RPTEntity.ExtraField = String.Empty; } else { cRMPaymentEncashed_RPTEntity.ExtraField = reader.GetString(FLD_EXTRAFIELD); }
            if (reader.IsDBNull(FLD_CASHORCHEQUENO)) { cRMPaymentEncashed_RPTEntity.CashOrChequeNo = String.Empty; } else { cRMPaymentEncashed_RPTEntity.CashOrChequeNo = reader.GetString(FLD_CASHORCHEQUENO); }
            if (reader.IsDBNull(FLD_CASHORCHEQUEDATE)) { cRMPaymentEncashed_RPTEntity.CashOrChequeDate = null; } else { cRMPaymentEncashed_RPTEntity.CashOrChequeDate = reader.GetDateTime(FLD_CASHORCHEQUEDATE); }
            if (reader.IsDBNull(FLD_BANKNAME)) { cRMPaymentEncashed_RPTEntity.BankName = String.Empty; } else { cRMPaymentEncashed_RPTEntity.BankName = reader.GetString(FLD_BANKNAME); }
            if (reader.IsDBNull(FLD_BRANCHNAME)) { cRMPaymentEncashed_RPTEntity.BranchName = String.Empty; } else { cRMPaymentEncashed_RPTEntity.BranchName = reader.GetString(FLD_BRANCHNAME); }
            cRMPaymentEncashed_RPTEntity.ChequeInCashConfirmation = reader.GetBoolean(FLD_CHEQUEINCASHCONFIRMATION);
            if (reader.IsDBNull(FLD_REMARKS)) { cRMPaymentEncashed_RPTEntity.Remarks = String.Empty; } else { cRMPaymentEncashed_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMPaymentEncashed_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMPaymentEncashed_RPTEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            cRMPaymentEncashed_RPTEntity.IP = reader.GetString(FLD_IP);
            cRMPaymentEncashed_RPTEntity.InstallmentName = reader.GetString(FLD_INSTALLMENTNAME);
            cRMPaymentEncashed_RPTEntity.InstallmentDueDate = reader.GetDateTime(FLD_INSTALLMENTDUEDATE);
            cRMPaymentEncashed_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            cRMPaymentEncashed_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            cRMPaymentEncashed_RPTEntity.ContactFullName = reader.GetString(FLD_CONTACTFULLNAME);
            cRMPaymentEncashed_RPTEntity.CompanyName = reader.GetString(FLD_COMPANYNAME);
            if (reader.IsDBNull(FLD_DESIGNATION)) { cRMPaymentEncashed_RPTEntity.Designation = String.Empty; } else { cRMPaymentEncashed_RPTEntity.Designation = reader.GetString(FLD_DESIGNATION); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { cRMPaymentEncashed_RPTEntity.ProjectFloorUnitName = String.Empty; } else { cRMPaymentEncashed_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_AGREEMENTAAMOUNT)) { cRMPaymentEncashed_RPTEntity.AgreementAAmount = null; } else { cRMPaymentEncashed_RPTEntity.AgreementAAmount = reader.GetDecimal(FLD_AGREEMENTAAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTBAMOUNT)) { cRMPaymentEncashed_RPTEntity.AgreementBAmount = null; } else { cRMPaymentEncashed_RPTEntity.AgreementBAmount = reader.GetDecimal(FLD_AGREEMENTBAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTCAMOUNT)) { cRMPaymentEncashed_RPTEntity.AgreementCAmount = null; } else { cRMPaymentEncashed_RPTEntity.AgreementCAmount = reader.GetDecimal(FLD_AGREEMENTCAMOUNT); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { cRMPaymentEncashed_RPTEntity.MemberFullName = String.Empty; } else { cRMPaymentEncashed_RPTEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }

            return cRMPaymentEncashed_RPTEntity;
        }
    }
}
