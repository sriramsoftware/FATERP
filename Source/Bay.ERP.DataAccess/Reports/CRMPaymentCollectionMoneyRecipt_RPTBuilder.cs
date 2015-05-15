// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-May-2013, 02:23:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMPaymentCollectionMoneyRecipt_RPTBuilder : IEntityBuilder<CRMPaymentCollectionMoneyRecipt_RPTEntity>
    {
        IList<CRMPaymentCollectionMoneyRecipt_RPTEntity> IEntityBuilder<CRMPaymentCollectionMoneyRecipt_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMPaymentCollectionMoneyRecipt_RPTEntity> CRMPaymentCollectionMoneyRecipt_RPTEntityList = new List<CRMPaymentCollectionMoneyRecipt_RPTEntity>();

            while (reader.Read())
            {
                CRMPaymentCollectionMoneyRecipt_RPTEntityList.Add(((IEntityBuilder<CRMPaymentCollectionMoneyRecipt_RPTEntity>)this).BuildEntity(reader));
            }

            return (CRMPaymentCollectionMoneyRecipt_RPTEntityList.Count > 0) ? CRMPaymentCollectionMoneyRecipt_RPTEntityList : null;
        }

        CRMPaymentCollectionMoneyRecipt_RPTEntity IEntityBuilder<CRMPaymentCollectionMoneyRecipt_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_REMARKS = 29;
            const Int32 FLD_CREATEDATE = 30;
            const Int32 FLD_CREATEBYEMPLOYEEID = 31;
            const Int32 FLD_CASHORCHEQUENO = 32;
            const Int32 FLD_CASHORCHEQUEDATE = 33;
            const Int32 FLD_BANKNAME = 34;
            const Int32 FLD_BRANCHNAME = 35;
            const Int32 FLD_IP = 36;
            const Int32 FLD_INSTALLMENTNAME = 37;
            const Int32 FLD_INSTALLMENTDUEDATE = 38;
            const Int32 FLD_AGREEMENTAAMOUNT = 39;
            const Int32 FLD_AGREEMENTBAMOUNT = 40;
            const Int32 FLD_AGREEMENTCAMOUNT = 41;
            const Int32 FLD_AGREEMENTTYPENAME = 42;
            const Int32 FLD_PROJECTCODE = 43;
            const Int32 FLD_PROJECTNAME = 44;
            const Int32 FLD_AGREEMENTDATE = 45;
            const Int32 FLD_PROJECTFLOORUNITNAME = 46;
            const Int32 FLD_CREATEDBYMEMBERFULLNAME = 47;
            const Int32 FLD_CONTACTFULLNAME = 48;
            const Int32 FLD_COMPANYNAME = 49;
            const Int32 FLD_DESIGNATION = 50;

            CRMPaymentCollectionMoneyRecipt_RPTEntity cRMPaymentCollectionMoneyRecipt_RPTEntity = new CRMPaymentCollectionMoneyRecipt_RPTEntity();

            cRMPaymentCollectionMoneyRecipt_RPTEntity.PaymentCollectionID = reader.GetInt64(FLD_PAYMENTCOLLECTIONID);
            cRMPaymentCollectionMoneyRecipt_RPTEntity.PaymentScheduleMapID = reader.GetInt64(FLD_PAYMENTSCHEDULEMAPID);
            cRMPaymentCollectionMoneyRecipt_RPTEntity.PaymentScheduleID = reader.GetInt64(FLD_PAYMENTSCHEDULEID);
            cRMPaymentCollectionMoneyRecipt_RPTEntity.AgreementTypeID = reader.GetInt64(FLD_AGREEMENTTYPEID);
            cRMPaymentCollectionMoneyRecipt_RPTEntity.MoneyReceiptNo = reader.GetDecimal(FLD_MONEYRECEIPTNO);
            if (reader.IsDBNull(FLD_ACTUALPAYMENTDATE)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.ActualPaymentDate = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.ActualPaymentDate = reader.GetDateTime(FLD_ACTUALPAYMENTDATE); }
            if (reader.IsDBNull(FLD_PAYMENTDESCRIPTION)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.PaymentDescription = String.Empty; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.PaymentDescription = reader.GetString(FLD_PAYMENTDESCRIPTION); }
            if (reader.IsDBNull(FLD_INSTALLMENTPAYMENTAMOUNT)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.InstallmentPaymentAmount = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.InstallmentPaymentAmount = reader.GetDecimal(FLD_INSTALLMENTPAYMENTAMOUNT); }
            cRMPaymentCollectionMoneyRecipt_RPTEntity.InstallmentPaymentInWord = reader.GetString(FLD_INSTALLMENTPAYMENTINWORD);
            if (reader.IsDBNull(FLD_INITIALAMOUNTINAGREEMENT)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.InitialAmountInAgreement = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.InitialAmountInAgreement = reader.GetDecimal(FLD_INITIALAMOUNTINAGREEMENT); }
            if (reader.IsDBNull(FLD_OVERDUEAMOUNT)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.OverDueAmount = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.OverDueAmount = reader.GetDecimal(FLD_OVERDUEAMOUNT); }
            if (reader.IsDBNull(FLD_DELAYDAYONPAYMENT)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.DelayDayOnPayment = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.DelayDayOnPayment = reader.GetDecimal(FLD_DELAYDAYONPAYMENT); }
            if (reader.IsDBNull(FLD_DELAYDAYONOVERDUE)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.DelayDayOnOverDue = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.DelayDayOnOverDue = reader.GetDecimal(FLD_DELAYDAYONOVERDUE); }
            if (reader.IsDBNull(FLD_PAYMENTRECEIVEDINBANK)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.PaymentReceivedInBank = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.PaymentReceivedInBank = reader.GetDecimal(FLD_PAYMENTRECEIVEDINBANK); }
            if (reader.IsDBNull(FLD_PAYMENTNOTRECEIVEDNOTE)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.PaymentNotReceivedNote = String.Empty; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.PaymentNotReceivedNote = reader.GetString(FLD_PAYMENTNOTRECEIVEDNOTE); }
            cRMPaymentCollectionMoneyRecipt_RPTEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID);
            cRMPaymentCollectionMoneyRecipt_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cRMPaymentCollectionMoneyRecipt_RPTEntity.ReverseEntry = reader.GetBoolean(FLD_REVERSEENTRY);
            cRMPaymentCollectionMoneyRecipt_RPTEntity.LastPayment = reader.GetBoolean(FLD_LASTPAYMENT);
            if (reader.IsDBNull(FLD_DISCOUNTAMOUNT)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.DiscountAmount = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.DiscountAmount = reader.GetDecimal(FLD_DISCOUNTAMOUNT); }
            if (reader.IsDBNull(FLD_VAT)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.Vat = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.Vat = reader.GetDecimal(FLD_VAT); }
            if (reader.IsDBNull(FLD_TAX)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.Tax = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.Tax = reader.GetDecimal(FLD_TAX); }
            if (reader.IsDBNull(FLD_SERVICECHARGE)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.ServiceCharge = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.ServiceCharge = reader.GetDecimal(FLD_SERVICECHARGE); }
            if (reader.IsDBNull(FLD_ADDITIONALFEE)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.AdditionalFee = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.AdditionalFee = reader.GetDecimal(FLD_ADDITIONALFEE); }
            if (reader.IsDBNull(FLD_GROSSAMOUNT)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.GrossAmount = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.GrossAmount = reader.GetDecimal(FLD_GROSSAMOUNT); }
            if (reader.IsDBNull(FLD_NETAMOUNT)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.NetAmount = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.NetAmount = reader.GetDecimal(FLD_NETAMOUNT); }
            cRMPaymentCollectionMoneyRecipt_RPTEntity.PaymentApprovalStatusID = reader.GetInt64(FLD_PAYMENTAPPROVALSTATUSID);
            cRMPaymentCollectionMoneyRecipt_RPTEntity.PaymentCategoryID = reader.GetInt64(FLD_PAYMENTCATEGORYID);
            if (reader.IsDBNull(FLD_EXTRAFIELD)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.ExtraField = String.Empty; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.ExtraField = reader.GetString(FLD_EXTRAFIELD); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.Remarks = String.Empty; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMPaymentCollectionMoneyRecipt_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMPaymentCollectionMoneyRecipt_RPTEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_CASHORCHEQUENO)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.CashOrChequeNo = String.Empty; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.CashOrChequeNo = reader.GetString(FLD_CASHORCHEQUENO); }
            if (reader.IsDBNull(FLD_CASHORCHEQUEDATE)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.CashOrChequeDate = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.CashOrChequeDate = reader.GetDateTime(FLD_CASHORCHEQUEDATE); }
            if (reader.IsDBNull(FLD_BANKNAME)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.BankName = String.Empty; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.BankName = reader.GetString(FLD_BANKNAME); }
            if (reader.IsDBNull(FLD_BRANCHNAME)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.BranchName = String.Empty; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.BranchName = reader.GetString(FLD_BRANCHNAME); }
            cRMPaymentCollectionMoneyRecipt_RPTEntity.IP = reader.GetString(FLD_IP);
            cRMPaymentCollectionMoneyRecipt_RPTEntity.InstallmentName = reader.GetString(FLD_INSTALLMENTNAME);
            cRMPaymentCollectionMoneyRecipt_RPTEntity.InstallmentDueDate = reader.GetDateTime(FLD_INSTALLMENTDUEDATE);
            if (reader.IsDBNull(FLD_AGREEMENTAAMOUNT)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.AgreementAAmount = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.AgreementAAmount = reader.GetDecimal(FLD_AGREEMENTAAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTBAMOUNT)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.AgreementBAmount = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.AgreementBAmount = reader.GetDecimal(FLD_AGREEMENTBAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTCAMOUNT)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.AgreementCAmount = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.AgreementCAmount = reader.GetDecimal(FLD_AGREEMENTCAMOUNT); }
            cRMPaymentCollectionMoneyRecipt_RPTEntity.AgreementTypeName = reader.GetString(FLD_AGREEMENTTYPENAME);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.ProjectCode = String.Empty; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.ProjectName = String.Empty; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_AGREEMENTDATE)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.AgreementDate = null; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.AgreementDate = reader.GetDateTime(FLD_AGREEMENTDATE); }
            cRMPaymentCollectionMoneyRecipt_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME);
            if (reader.IsDBNull(FLD_CREATEDBYMEMBERFULLNAME)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.CreatedByMemberFullName = String.Empty; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.CreatedByMemberFullName = reader.GetString(FLD_CREATEDBYMEMBERFULLNAME); }
            cRMPaymentCollectionMoneyRecipt_RPTEntity.ContactFullName = reader.GetString(FLD_CONTACTFULLNAME);
            cRMPaymentCollectionMoneyRecipt_RPTEntity.CompanyName = reader.GetString(FLD_COMPANYNAME);
            if (reader.IsDBNull(FLD_DESIGNATION)) { cRMPaymentCollectionMoneyRecipt_RPTEntity.Designation = String.Empty; } else { cRMPaymentCollectionMoneyRecipt_RPTEntity.Designation = reader.GetString(FLD_DESIGNATION); }

            return cRMPaymentCollectionMoneyRecipt_RPTEntity;
        }
    }
}
