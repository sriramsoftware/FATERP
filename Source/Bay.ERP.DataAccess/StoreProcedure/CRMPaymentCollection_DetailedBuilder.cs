// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2013, 01:34:06




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMPaymentCollection_DetailedBuilder : IEntityBuilder<CRMPaymentCollection_DetailedEntity>
    {
        IList<CRMPaymentCollection_DetailedEntity> IEntityBuilder<CRMPaymentCollection_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMPaymentCollection_DetailedEntity> CRMPaymentCollection_DetailedEntityList = new List<CRMPaymentCollection_DetailedEntity>();

            while (reader.Read())
            {
                CRMPaymentCollection_DetailedEntityList.Add(((IEntityBuilder<CRMPaymentCollection_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CRMPaymentCollection_DetailedEntityList.Count > 0) ? CRMPaymentCollection_DetailedEntityList : null;
        }

        CRMPaymentCollection_DetailedEntity IEntityBuilder<CRMPaymentCollection_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYMENTCOLLECTIONID = 0;
            const Int32 FLD_CHEQUEINCASHCONFIRMATION = 1;
            const Int32 FLD_PAYMENTSCHEDULEMAPID = 2;
            const Int32 FLD_PAYMENTSCHEDULEID = 3;
            const Int32 FLD_AGREEMENTTYPEID = 4;
            const Int32 FLD_MONEYRECEIPTNO = 5;
            const Int32 FLD_ACTUALPAYMENTDATE = 6;
            const Int32 FLD_PAYMENTDESCRIPTION = 7;
            const Int32 FLD_INSTALLMENTPAYMENTAMOUNT = 8;
            const Int32 FLD_INSTALLMENTPAYMENTINWORD = 9;
            const Int32 FLD_INITIALAMOUNTINAGREEMENT = 10;
            const Int32 FLD_OVERDUEAMOUNT = 11;
            const Int32 FLD_DELAYDAYONPAYMENT = 12;
            const Int32 FLD_DELAYDAYONOVERDUE = 13;
            const Int32 FLD_PAYMENTRECEIVEDINBANK = 14;
            const Int32 FLD_PAYMENTNOTRECEIVEDNOTE = 15;
            const Int32 FLD_AGREEMENTID = 16;
            const Int32 FLD_PROJECTID = 17;
            const Int32 FLD_REVERSEENTRY = 18;
            const Int32 FLD_LASTPAYMENT = 19;
            const Int32 FLD_DISCOUNTAMOUNT = 20;
            const Int32 FLD_VAT = 21;
            const Int32 FLD_TAX = 22;
            const Int32 FLD_SERVICECHARGE = 23;
            const Int32 FLD_ADDITIONALFEE = 24;
            const Int32 FLD_GROSSAMOUNT = 25;
            const Int32 FLD_NETAMOUNT = 26;
            const Int32 FLD_PAYMENTAPPROVALSTATUSID = 27;
            const Int32 FLD_PAYMENTCATEGORYID = 28;
            const Int32 FLD_EXTRAFIELD = 29;
            const Int32 FLD_REMARKS = 30;
            const Int32 FLD_CREATEDATE = 31;
            const Int32 FLD_CREATEBYEMPLOYEEID = 32;
            const Int32 FLD_IP = 33;
            const Int32 FLD_PAYMENTSCHEDULEMAPINSTALLMENTNAME = 34;
            const Int32 FLD_INSTALLMENTDUEDATE = 35;
            const Int32 FLD_AGREEMENTTYPENAME = 36;
            const Int32 FLD_AGREEMENTTEXT = 37;
            const Int32 FLD_PROJECTNAME = 38;
            const Int32 FLD_PAYMENTAPPROVALSTATUSNAME = 39;
            const Int32 FLD_CRMMDPAYMENTCATEGORYNAME = 40;
            const Int32 FLD_MEMBERFULLNAME = 41;
            const Int32 FLD_ROWNUMBER = 42;

            CRMPaymentCollection_DetailedEntity cRMPaymentCollection_DetailedEntity = new CRMPaymentCollection_DetailedEntity();

            cRMPaymentCollection_DetailedEntity.PaymentCollectionID = reader.GetInt64(FLD_PAYMENTCOLLECTIONID);
            cRMPaymentCollection_DetailedEntity.ChequeInCashConfirmation = reader.GetBoolean(FLD_CHEQUEINCASHCONFIRMATION);
            cRMPaymentCollection_DetailedEntity.PaymentScheduleMapID = reader.GetInt64(FLD_PAYMENTSCHEDULEMAPID);
            cRMPaymentCollection_DetailedEntity.PaymentScheduleID = reader.GetInt64(FLD_PAYMENTSCHEDULEID);
            cRMPaymentCollection_DetailedEntity.AgreementTypeID = reader.GetInt64(FLD_AGREEMENTTYPEID);
            cRMPaymentCollection_DetailedEntity.MoneyReceiptNo = reader.GetDecimal(FLD_MONEYRECEIPTNO);
            if (reader.IsDBNull(FLD_ACTUALPAYMENTDATE)) { cRMPaymentCollection_DetailedEntity.ActualPaymentDate = null; } else { cRMPaymentCollection_DetailedEntity.ActualPaymentDate = reader.GetDateTime(FLD_ACTUALPAYMENTDATE); }
            if (reader.IsDBNull(FLD_PAYMENTDESCRIPTION)) { cRMPaymentCollection_DetailedEntity.PaymentDescription = String.Empty; } else { cRMPaymentCollection_DetailedEntity.PaymentDescription = reader.GetString(FLD_PAYMENTDESCRIPTION); }
            if (reader.IsDBNull(FLD_INSTALLMENTPAYMENTAMOUNT)) { cRMPaymentCollection_DetailedEntity.InstallmentPaymentAmount = null; } else { cRMPaymentCollection_DetailedEntity.InstallmentPaymentAmount = reader.GetDecimal(FLD_INSTALLMENTPAYMENTAMOUNT); }
            cRMPaymentCollection_DetailedEntity.InstallmentPaymentInWord = reader.GetString(FLD_INSTALLMENTPAYMENTINWORD);
            if (reader.IsDBNull(FLD_INITIALAMOUNTINAGREEMENT)) { cRMPaymentCollection_DetailedEntity.InitialAmountInAgreement = null; } else { cRMPaymentCollection_DetailedEntity.InitialAmountInAgreement = reader.GetDecimal(FLD_INITIALAMOUNTINAGREEMENT); }
            if (reader.IsDBNull(FLD_OVERDUEAMOUNT)) { cRMPaymentCollection_DetailedEntity.OverDueAmount = null; } else { cRMPaymentCollection_DetailedEntity.OverDueAmount = reader.GetDecimal(FLD_OVERDUEAMOUNT); }
            if (reader.IsDBNull(FLD_DELAYDAYONPAYMENT)) { cRMPaymentCollection_DetailedEntity.DelayDayOnPayment = null; } else { cRMPaymentCollection_DetailedEntity.DelayDayOnPayment = reader.GetDecimal(FLD_DELAYDAYONPAYMENT); }
            if (reader.IsDBNull(FLD_DELAYDAYONOVERDUE)) { cRMPaymentCollection_DetailedEntity.DelayDayOnOverDue = null; } else { cRMPaymentCollection_DetailedEntity.DelayDayOnOverDue = reader.GetDecimal(FLD_DELAYDAYONOVERDUE); }
            if (reader.IsDBNull(FLD_PAYMENTRECEIVEDINBANK)) { cRMPaymentCollection_DetailedEntity.PaymentReceivedInBank = null; } else { cRMPaymentCollection_DetailedEntity.PaymentReceivedInBank = reader.GetDecimal(FLD_PAYMENTRECEIVEDINBANK); }
            if (reader.IsDBNull(FLD_PAYMENTNOTRECEIVEDNOTE)) { cRMPaymentCollection_DetailedEntity.PaymentNotReceivedNote = String.Empty; } else { cRMPaymentCollection_DetailedEntity.PaymentNotReceivedNote = reader.GetString(FLD_PAYMENTNOTRECEIVEDNOTE); }
            cRMPaymentCollection_DetailedEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID);
            cRMPaymentCollection_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cRMPaymentCollection_DetailedEntity.ReverseEntry = reader.GetBoolean(FLD_REVERSEENTRY);
            cRMPaymentCollection_DetailedEntity.LastPayment = reader.GetBoolean(FLD_LASTPAYMENT);
            if (reader.IsDBNull(FLD_DISCOUNTAMOUNT)) { cRMPaymentCollection_DetailedEntity.DiscountAmount = null; } else { cRMPaymentCollection_DetailedEntity.DiscountAmount = reader.GetDecimal(FLD_DISCOUNTAMOUNT); }
            if (reader.IsDBNull(FLD_VAT)) { cRMPaymentCollection_DetailedEntity.Vat = null; } else { cRMPaymentCollection_DetailedEntity.Vat = reader.GetDecimal(FLD_VAT); }
            if (reader.IsDBNull(FLD_TAX)) { cRMPaymentCollection_DetailedEntity.Tax = null; } else { cRMPaymentCollection_DetailedEntity.Tax = reader.GetDecimal(FLD_TAX); }
            if (reader.IsDBNull(FLD_SERVICECHARGE)) { cRMPaymentCollection_DetailedEntity.ServiceCharge = null; } else { cRMPaymentCollection_DetailedEntity.ServiceCharge = reader.GetDecimal(FLD_SERVICECHARGE); }
            if (reader.IsDBNull(FLD_ADDITIONALFEE)) { cRMPaymentCollection_DetailedEntity.AdditionalFee = null; } else { cRMPaymentCollection_DetailedEntity.AdditionalFee = reader.GetDecimal(FLD_ADDITIONALFEE); }
            if (reader.IsDBNull(FLD_GROSSAMOUNT)) { cRMPaymentCollection_DetailedEntity.GrossAmount = null; } else { cRMPaymentCollection_DetailedEntity.GrossAmount = reader.GetDecimal(FLD_GROSSAMOUNT); }
            if (reader.IsDBNull(FLD_NETAMOUNT)) { cRMPaymentCollection_DetailedEntity.NetAmount = null; } else { cRMPaymentCollection_DetailedEntity.NetAmount = reader.GetDecimal(FLD_NETAMOUNT); }
            cRMPaymentCollection_DetailedEntity.PaymentApprovalStatusID = reader.GetInt64(FLD_PAYMENTAPPROVALSTATUSID);
            cRMPaymentCollection_DetailedEntity.PaymentCategoryID = reader.GetInt64(FLD_PAYMENTCATEGORYID);
            if (reader.IsDBNull(FLD_EXTRAFIELD)) { cRMPaymentCollection_DetailedEntity.ExtraField = String.Empty; } else { cRMPaymentCollection_DetailedEntity.ExtraField = reader.GetString(FLD_EXTRAFIELD); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMPaymentCollection_DetailedEntity.Remarks = String.Empty; } else { cRMPaymentCollection_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMPaymentCollection_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMPaymentCollection_DetailedEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            cRMPaymentCollection_DetailedEntity.IP = reader.GetString(FLD_IP);
            if (reader.IsDBNull(FLD_PAYMENTSCHEDULEMAPINSTALLMENTNAME)) { cRMPaymentCollection_DetailedEntity.PaymentScheduleMapInstallmentName = String.Empty; } else { cRMPaymentCollection_DetailedEntity.PaymentScheduleMapInstallmentName = reader.GetString(FLD_PAYMENTSCHEDULEMAPINSTALLMENTNAME); }
            if (reader.IsDBNull(FLD_INSTALLMENTDUEDATE)) { cRMPaymentCollection_DetailedEntity.InstallmentDueDate = null; } else { cRMPaymentCollection_DetailedEntity.InstallmentDueDate = reader.GetDateTime(FLD_INSTALLMENTDUEDATE); }
            if (reader.IsDBNull(FLD_AGREEMENTTYPENAME)) { cRMPaymentCollection_DetailedEntity.AgreementTypeName = String.Empty; } else { cRMPaymentCollection_DetailedEntity.AgreementTypeName = reader.GetString(FLD_AGREEMENTTYPENAME); }
            if (reader.IsDBNull(FLD_AGREEMENTTEXT)) { cRMPaymentCollection_DetailedEntity.AgreementText = String.Empty; } else { cRMPaymentCollection_DetailedEntity.AgreementText = reader.GetString(FLD_AGREEMENTTEXT); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { cRMPaymentCollection_DetailedEntity.ProjectName = String.Empty; } else { cRMPaymentCollection_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PAYMENTAPPROVALSTATUSNAME)) { cRMPaymentCollection_DetailedEntity.PaymentApprovalStatusName = String.Empty; } else { cRMPaymentCollection_DetailedEntity.PaymentApprovalStatusName = reader.GetString(FLD_PAYMENTAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_CRMMDPAYMENTCATEGORYNAME)) { cRMPaymentCollection_DetailedEntity.CRMMDPaymentCategoryName = String.Empty; } else { cRMPaymentCollection_DetailedEntity.CRMMDPaymentCategoryName = reader.GetString(FLD_CRMMDPAYMENTCATEGORYNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { cRMPaymentCollection_DetailedEntity.MemberFullName = String.Empty; } else { cRMPaymentCollection_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cRMPaymentCollection_DetailedEntity.RowNumber = null; } else { cRMPaymentCollection_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cRMPaymentCollection_DetailedEntity;
        }
    }
}
