// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 02:30:30




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMPaymentCollectionBuilder : IEntityBuilder<CRMPaymentCollectionEntity>
    {
        IList<CRMPaymentCollectionEntity> IEntityBuilder<CRMPaymentCollectionEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMPaymentCollectionEntity> CRMPaymentCollectionEntityList = new List<CRMPaymentCollectionEntity>();

            while (reader.Read())
            {
                CRMPaymentCollectionEntityList.Add(((IEntityBuilder<CRMPaymentCollectionEntity>)this).BuildEntity(reader));
            }

            return (CRMPaymentCollectionEntityList.Count > 0) ? CRMPaymentCollectionEntityList : null;
        }

        CRMPaymentCollectionEntity IEntityBuilder<CRMPaymentCollectionEntity>.BuildEntity(IDataReader reader)
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

            CRMPaymentCollectionEntity cRMPaymentCollectionEntity = new CRMPaymentCollectionEntity();

            cRMPaymentCollectionEntity.PaymentCollectionID = reader.GetInt64(FLD_PAYMENTCOLLECTIONID);
            cRMPaymentCollectionEntity.PaymentScheduleMapID = reader.GetInt64(FLD_PAYMENTSCHEDULEMAPID);
            cRMPaymentCollectionEntity.PaymentScheduleID = reader.GetInt64(FLD_PAYMENTSCHEDULEID);
            cRMPaymentCollectionEntity.AgreementTypeID = reader.GetInt64(FLD_AGREEMENTTYPEID);
            cRMPaymentCollectionEntity.MoneyReceiptNo = reader.GetDecimal(FLD_MONEYRECEIPTNO);
            if (reader.IsDBNull(FLD_ACTUALPAYMENTDATE)) { cRMPaymentCollectionEntity.ActualPaymentDate = null; } else { cRMPaymentCollectionEntity.ActualPaymentDate = reader.GetDateTime(FLD_ACTUALPAYMENTDATE); }
            if (reader.IsDBNull(FLD_PAYMENTDESCRIPTION)) { cRMPaymentCollectionEntity.PaymentDescription = String.Empty; } else { cRMPaymentCollectionEntity.PaymentDescription = reader.GetString(FLD_PAYMENTDESCRIPTION); }
            if (reader.IsDBNull(FLD_INSTALLMENTPAYMENTAMOUNT)) { cRMPaymentCollectionEntity.InstallmentPaymentAmount = null; } else { cRMPaymentCollectionEntity.InstallmentPaymentAmount = reader.GetDecimal(FLD_INSTALLMENTPAYMENTAMOUNT); }
            cRMPaymentCollectionEntity.InstallmentPaymentInWord = reader.GetString(FLD_INSTALLMENTPAYMENTINWORD);
            if (reader.IsDBNull(FLD_INITIALAMOUNTINAGREEMENT)) { cRMPaymentCollectionEntity.InitialAmountInAgreement = null; } else { cRMPaymentCollectionEntity.InitialAmountInAgreement = reader.GetDecimal(FLD_INITIALAMOUNTINAGREEMENT); }
            if (reader.IsDBNull(FLD_OVERDUEAMOUNT)) { cRMPaymentCollectionEntity.OverDueAmount = null; } else { cRMPaymentCollectionEntity.OverDueAmount = reader.GetDecimal(FLD_OVERDUEAMOUNT); }
            if (reader.IsDBNull(FLD_DELAYDAYONPAYMENT)) { cRMPaymentCollectionEntity.DelayDayOnPayment = null; } else { cRMPaymentCollectionEntity.DelayDayOnPayment = reader.GetDecimal(FLD_DELAYDAYONPAYMENT); }
            if (reader.IsDBNull(FLD_DELAYDAYONOVERDUE)) { cRMPaymentCollectionEntity.DelayDayOnOverDue = null; } else { cRMPaymentCollectionEntity.DelayDayOnOverDue = reader.GetDecimal(FLD_DELAYDAYONOVERDUE); }
            if (reader.IsDBNull(FLD_PAYMENTRECEIVEDINBANK)) { cRMPaymentCollectionEntity.PaymentReceivedInBank = null; } else { cRMPaymentCollectionEntity.PaymentReceivedInBank = reader.GetDecimal(FLD_PAYMENTRECEIVEDINBANK); }
            if (reader.IsDBNull(FLD_PAYMENTNOTRECEIVEDNOTE)) { cRMPaymentCollectionEntity.PaymentNotReceivedNote = String.Empty; } else { cRMPaymentCollectionEntity.PaymentNotReceivedNote = reader.GetString(FLD_PAYMENTNOTRECEIVEDNOTE); }
            cRMPaymentCollectionEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID);
            cRMPaymentCollectionEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cRMPaymentCollectionEntity.ReverseEntry = reader.GetBoolean(FLD_REVERSEENTRY);
            cRMPaymentCollectionEntity.LastPayment = reader.GetBoolean(FLD_LASTPAYMENT);
            if (reader.IsDBNull(FLD_DISCOUNTAMOUNT)) { cRMPaymentCollectionEntity.DiscountAmount = null; } else { cRMPaymentCollectionEntity.DiscountAmount = reader.GetDecimal(FLD_DISCOUNTAMOUNT); }
            if (reader.IsDBNull(FLD_VAT)) { cRMPaymentCollectionEntity.Vat = null; } else { cRMPaymentCollectionEntity.Vat = reader.GetDecimal(FLD_VAT); }
            if (reader.IsDBNull(FLD_TAX)) { cRMPaymentCollectionEntity.Tax = null; } else { cRMPaymentCollectionEntity.Tax = reader.GetDecimal(FLD_TAX); }
            if (reader.IsDBNull(FLD_SERVICECHARGE)) { cRMPaymentCollectionEntity.ServiceCharge = null; } else { cRMPaymentCollectionEntity.ServiceCharge = reader.GetDecimal(FLD_SERVICECHARGE); }
            if (reader.IsDBNull(FLD_ADDITIONALFEE)) { cRMPaymentCollectionEntity.AdditionalFee = null; } else { cRMPaymentCollectionEntity.AdditionalFee = reader.GetDecimal(FLD_ADDITIONALFEE); }
            if (reader.IsDBNull(FLD_GROSSAMOUNT)) { cRMPaymentCollectionEntity.GrossAmount = null; } else { cRMPaymentCollectionEntity.GrossAmount = reader.GetDecimal(FLD_GROSSAMOUNT); }
            if (reader.IsDBNull(FLD_NETAMOUNT)) { cRMPaymentCollectionEntity.NetAmount = null; } else { cRMPaymentCollectionEntity.NetAmount = reader.GetDecimal(FLD_NETAMOUNT); }
            cRMPaymentCollectionEntity.PaymentApprovalStatusID = reader.GetInt64(FLD_PAYMENTAPPROVALSTATUSID);
            cRMPaymentCollectionEntity.PaymentCategoryID = reader.GetInt64(FLD_PAYMENTCATEGORYID);
            if (reader.IsDBNull(FLD_EXTRAFIELD)) { cRMPaymentCollectionEntity.ExtraField = String.Empty; } else { cRMPaymentCollectionEntity.ExtraField = reader.GetString(FLD_EXTRAFIELD); }
            if (reader.IsDBNull(FLD_CASHORCHEQUENO)) { cRMPaymentCollectionEntity.CashOrChequeNo = String.Empty; } else { cRMPaymentCollectionEntity.CashOrChequeNo = reader.GetString(FLD_CASHORCHEQUENO); }
            if (reader.IsDBNull(FLD_CASHORCHEQUEDATE)) { cRMPaymentCollectionEntity.CashOrChequeDate = null; } else { cRMPaymentCollectionEntity.CashOrChequeDate = reader.GetDateTime(FLD_CASHORCHEQUEDATE); }
            if (reader.IsDBNull(FLD_BANKNAME)) { cRMPaymentCollectionEntity.BankName = String.Empty; } else { cRMPaymentCollectionEntity.BankName = reader.GetString(FLD_BANKNAME); }
            if (reader.IsDBNull(FLD_BRANCHNAME)) { cRMPaymentCollectionEntity.BranchName = String.Empty; } else { cRMPaymentCollectionEntity.BranchName = reader.GetString(FLD_BRANCHNAME); }
            cRMPaymentCollectionEntity.ChequeInCashConfirmation = reader.GetBoolean(FLD_CHEQUEINCASHCONFIRMATION);
            if (reader.IsDBNull(FLD_REMARKS)) { cRMPaymentCollectionEntity.Remarks = String.Empty; } else { cRMPaymentCollectionEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMPaymentCollectionEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMPaymentCollectionEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            cRMPaymentCollectionEntity.IP = reader.GetString(FLD_IP);

            return cRMPaymentCollectionEntity;
        }
    }
}
