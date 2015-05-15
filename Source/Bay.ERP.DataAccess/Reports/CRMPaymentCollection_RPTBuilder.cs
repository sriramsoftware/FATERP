// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-May-2013, 01:17:08




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMPaymentCollection_RPTBuilder : IEntityBuilder<CRMPaymentCollection_RPTEntity>
    {
        IList<CRMPaymentCollection_RPTEntity> IEntityBuilder<CRMPaymentCollection_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMPaymentCollection_RPTEntity> CRMPaymentCollection_RPTEntityList = new List<CRMPaymentCollection_RPTEntity>();

            while (reader.Read())
            {
                CRMPaymentCollection_RPTEntityList.Add(((IEntityBuilder<CRMPaymentCollection_RPTEntity>)this).BuildEntity(reader));
            }

            return (CRMPaymentCollection_RPTEntityList.Count > 0) ? CRMPaymentCollection_RPTEntityList : null;
        }

        CRMPaymentCollection_RPTEntity IEntityBuilder<CRMPaymentCollection_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_IP = 32;
            const Int32 FLD_INSTALLMENTNAME = 33;
            const Int32 FLD_INSTALLMENTDUEDATE = 34;
            const Int32 FLD_AGREEMENTAAMOUNT = 35;
            const Int32 FLD_AGREEMENTBAMOUNT = 36;
            const Int32 FLD_AGREEMENTCAMOUNT = 37;
            const Int32 FLD_AGREEMENTTYPENAME = 38;
            const Int32 FLD_PROJECTCODE = 39;
            const Int32 FLD_PROJECTNAME = 40;
            const Int32 FLD_AGREEMENTDATE = 41;
            const Int32 FLD_PROJECTFLOORUNITNAME = 42;
            const Int32 FLD_CREATEDBYMEMBERFULLNAME = 43;
            const Int32 FLD_CONTACTFULLNAME = 44;
            const Int32 FLD_COMPANYNAME = 45;
            const Int32 FLD_DESIGNATION = 46;

            CRMPaymentCollection_RPTEntity cRMPaymentCollection_RPTEntity = new CRMPaymentCollection_RPTEntity();

            cRMPaymentCollection_RPTEntity.PaymentCollectionID = reader.GetInt64(FLD_PAYMENTCOLLECTIONID);
            cRMPaymentCollection_RPTEntity.PaymentScheduleMapID = reader.GetInt64(FLD_PAYMENTSCHEDULEMAPID);
            cRMPaymentCollection_RPTEntity.PaymentScheduleID = reader.GetInt64(FLD_PAYMENTSCHEDULEID);
            cRMPaymentCollection_RPTEntity.AgreementTypeID = reader.GetInt64(FLD_AGREEMENTTYPEID);
            cRMPaymentCollection_RPTEntity.MoneyReceiptNo = reader.GetDecimal(FLD_MONEYRECEIPTNO);
            if (reader.IsDBNull(FLD_ACTUALPAYMENTDATE)) { cRMPaymentCollection_RPTEntity.ActualPaymentDate = null; } else { cRMPaymentCollection_RPTEntity.ActualPaymentDate = reader.GetDateTime(FLD_ACTUALPAYMENTDATE); }
            if (reader.IsDBNull(FLD_PAYMENTDESCRIPTION)) { cRMPaymentCollection_RPTEntity.PaymentDescription = String.Empty; } else { cRMPaymentCollection_RPTEntity.PaymentDescription = reader.GetString(FLD_PAYMENTDESCRIPTION); }
            if (reader.IsDBNull(FLD_INSTALLMENTPAYMENTAMOUNT)) { cRMPaymentCollection_RPTEntity.InstallmentPaymentAmount = null; } else { cRMPaymentCollection_RPTEntity.InstallmentPaymentAmount = reader.GetDecimal(FLD_INSTALLMENTPAYMENTAMOUNT); }
            cRMPaymentCollection_RPTEntity.InstallmentPaymentInWord = reader.GetString(FLD_INSTALLMENTPAYMENTINWORD);
            if (reader.IsDBNull(FLD_INITIALAMOUNTINAGREEMENT)) { cRMPaymentCollection_RPTEntity.InitialAmountInAgreement = null; } else { cRMPaymentCollection_RPTEntity.InitialAmountInAgreement = reader.GetDecimal(FLD_INITIALAMOUNTINAGREEMENT); }
            if (reader.IsDBNull(FLD_OVERDUEAMOUNT)) { cRMPaymentCollection_RPTEntity.OverDueAmount = null; } else { cRMPaymentCollection_RPTEntity.OverDueAmount = reader.GetDecimal(FLD_OVERDUEAMOUNT); }
            if (reader.IsDBNull(FLD_DELAYDAYONPAYMENT)) { cRMPaymentCollection_RPTEntity.DelayDayOnPayment = null; } else { cRMPaymentCollection_RPTEntity.DelayDayOnPayment = reader.GetDecimal(FLD_DELAYDAYONPAYMENT); }
            if (reader.IsDBNull(FLD_DELAYDAYONOVERDUE)) { cRMPaymentCollection_RPTEntity.DelayDayOnOverDue = null; } else { cRMPaymentCollection_RPTEntity.DelayDayOnOverDue = reader.GetDecimal(FLD_DELAYDAYONOVERDUE); }
            if (reader.IsDBNull(FLD_PAYMENTRECEIVEDINBANK)) { cRMPaymentCollection_RPTEntity.PaymentReceivedInBank = null; } else { cRMPaymentCollection_RPTEntity.PaymentReceivedInBank = reader.GetDecimal(FLD_PAYMENTRECEIVEDINBANK); }
            if (reader.IsDBNull(FLD_PAYMENTNOTRECEIVEDNOTE)) { cRMPaymentCollection_RPTEntity.PaymentNotReceivedNote = String.Empty; } else { cRMPaymentCollection_RPTEntity.PaymentNotReceivedNote = reader.GetString(FLD_PAYMENTNOTRECEIVEDNOTE); }
            cRMPaymentCollection_RPTEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID);
            cRMPaymentCollection_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cRMPaymentCollection_RPTEntity.ReverseEntry = reader.GetBoolean(FLD_REVERSEENTRY);
            cRMPaymentCollection_RPTEntity.LastPayment = reader.GetBoolean(FLD_LASTPAYMENT);
            if (reader.IsDBNull(FLD_DISCOUNTAMOUNT)) { cRMPaymentCollection_RPTEntity.DiscountAmount = null; } else { cRMPaymentCollection_RPTEntity.DiscountAmount = reader.GetDecimal(FLD_DISCOUNTAMOUNT); }
            if (reader.IsDBNull(FLD_VAT)) { cRMPaymentCollection_RPTEntity.Vat = null; } else { cRMPaymentCollection_RPTEntity.Vat = reader.GetDecimal(FLD_VAT); }
            if (reader.IsDBNull(FLD_TAX)) { cRMPaymentCollection_RPTEntity.Tax = null; } else { cRMPaymentCollection_RPTEntity.Tax = reader.GetDecimal(FLD_TAX); }
            if (reader.IsDBNull(FLD_SERVICECHARGE)) { cRMPaymentCollection_RPTEntity.ServiceCharge = null; } else { cRMPaymentCollection_RPTEntity.ServiceCharge = reader.GetDecimal(FLD_SERVICECHARGE); }
            if (reader.IsDBNull(FLD_ADDITIONALFEE)) { cRMPaymentCollection_RPTEntity.AdditionalFee = null; } else { cRMPaymentCollection_RPTEntity.AdditionalFee = reader.GetDecimal(FLD_ADDITIONALFEE); }
            if (reader.IsDBNull(FLD_GROSSAMOUNT)) { cRMPaymentCollection_RPTEntity.GrossAmount = null; } else { cRMPaymentCollection_RPTEntity.GrossAmount = reader.GetDecimal(FLD_GROSSAMOUNT); }
            if (reader.IsDBNull(FLD_NETAMOUNT)) { cRMPaymentCollection_RPTEntity.NetAmount = null; } else { cRMPaymentCollection_RPTEntity.NetAmount = reader.GetDecimal(FLD_NETAMOUNT); }
            cRMPaymentCollection_RPTEntity.PaymentApprovalStatusID = reader.GetInt64(FLD_PAYMENTAPPROVALSTATUSID);
            cRMPaymentCollection_RPTEntity.PaymentCategoryID = reader.GetInt64(FLD_PAYMENTCATEGORYID);
            if (reader.IsDBNull(FLD_EXTRAFIELD)) { cRMPaymentCollection_RPTEntity.ExtraField = String.Empty; } else { cRMPaymentCollection_RPTEntity.ExtraField = reader.GetString(FLD_EXTRAFIELD); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMPaymentCollection_RPTEntity.Remarks = String.Empty; } else { cRMPaymentCollection_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMPaymentCollection_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMPaymentCollection_RPTEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            cRMPaymentCollection_RPTEntity.IP = reader.GetString(FLD_IP);
            cRMPaymentCollection_RPTEntity.InstallmentName = reader.GetString(FLD_INSTALLMENTNAME);
            cRMPaymentCollection_RPTEntity.InstallmentDueDate = reader.GetDateTime(FLD_INSTALLMENTDUEDATE);
            if (reader.IsDBNull(FLD_AGREEMENTAAMOUNT)) { cRMPaymentCollection_RPTEntity.AgreementAAmount = null; } else { cRMPaymentCollection_RPTEntity.AgreementAAmount = reader.GetDecimal(FLD_AGREEMENTAAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTBAMOUNT)) { cRMPaymentCollection_RPTEntity.AgreementBAmount = null; } else { cRMPaymentCollection_RPTEntity.AgreementBAmount = reader.GetDecimal(FLD_AGREEMENTBAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTCAMOUNT)) { cRMPaymentCollection_RPTEntity.AgreementCAmount = null; } else { cRMPaymentCollection_RPTEntity.AgreementCAmount = reader.GetDecimal(FLD_AGREEMENTCAMOUNT); }
            cRMPaymentCollection_RPTEntity.AgreementTypeName = reader.GetString(FLD_AGREEMENTTYPENAME);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { cRMPaymentCollection_RPTEntity.ProjectCode = String.Empty; } else { cRMPaymentCollection_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { cRMPaymentCollection_RPTEntity.ProjectName = String.Empty; } else { cRMPaymentCollection_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_AGREEMENTDATE)) { cRMPaymentCollection_RPTEntity.AgreementDate = null; } else { cRMPaymentCollection_RPTEntity.AgreementDate = reader.GetDateTime(FLD_AGREEMENTDATE); }
            cRMPaymentCollection_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME);
            if (reader.IsDBNull(FLD_CREATEDBYMEMBERFULLNAME)) { cRMPaymentCollection_RPTEntity.CreatedByMemberFullName = String.Empty; } else { cRMPaymentCollection_RPTEntity.CreatedByMemberFullName = reader.GetString(FLD_CREATEDBYMEMBERFULLNAME); }
            cRMPaymentCollection_RPTEntity.ContactFullName = reader.GetString(FLD_CONTACTFULLNAME);
            cRMPaymentCollection_RPTEntity.CompanyName = reader.GetString(FLD_COMPANYNAME);
            if (reader.IsDBNull(FLD_DESIGNATION)) { cRMPaymentCollection_RPTEntity.Designation = String.Empty; } else { cRMPaymentCollection_RPTEntity.Designation = reader.GetString(FLD_DESIGNATION); }

            return cRMPaymentCollection_RPTEntity;
        }
    }
}
