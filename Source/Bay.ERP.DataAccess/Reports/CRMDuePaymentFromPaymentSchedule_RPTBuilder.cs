// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2013, 01:09:58




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMDuePaymentFromPaymentSchedule_RPTBuilder : IEntityBuilder<CRMDuePaymentFromPaymentSchedule_RPTEntity>
    {
        IList<CRMDuePaymentFromPaymentSchedule_RPTEntity> IEntityBuilder<CRMDuePaymentFromPaymentSchedule_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMDuePaymentFromPaymentSchedule_RPTEntity> CRMDuePaymentFromPaymentSchedule_RPTEntityList = new List<CRMDuePaymentFromPaymentSchedule_RPTEntity>();

            while (reader.Read())
            {
                CRMDuePaymentFromPaymentSchedule_RPTEntityList.Add(((IEntityBuilder<CRMDuePaymentFromPaymentSchedule_RPTEntity>)this).BuildEntity(reader));
            }

            return (CRMDuePaymentFromPaymentSchedule_RPTEntityList.Count > 0) ? CRMDuePaymentFromPaymentSchedule_RPTEntityList : null;
        }

        CRMDuePaymentFromPaymentSchedule_RPTEntity IEntityBuilder<CRMDuePaymentFromPaymentSchedule_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYMENTSCHEDULEMAPID = 0;
            const Int32 FLD_INSTALLMENTNAME = 1;
            const Int32 FLD_AGREEMENTAAMOUNT = 2;
            const Int32 FLD_AGREEMENTBAMOUNT = 3;
            const Int32 FLD_AGREEMENTCAMOUNT = 4;
            const Int32 FLD_INSTALLMENTDUEDATE = 5;
            const Int32 FLD_PAYMENTCOLLECTIONID = 6;
            const Int32 FLD_PAYMENTSCHEDULEID = 7;
            const Int32 FLD_AGREEMENTTYPEID = 8;
            const Int32 FLD_MONEYRECEIPTNO = 9;
            const Int32 FLD_ACTUALPAYMENTDATE = 10;
            const Int32 FLD_PAYMENTDESCRIPTION = 11;
            const Int32 FLD_INSTALLMENTPAYMENTAMOUNT = 12;
            const Int32 FLD_INSTALLMENTPAYMENTINWORD = 13;
            const Int32 FLD_INITIALAMOUNTINAGREEMENT = 14;
            const Int32 FLD_OVERDUEAMOUNT = 15;
            const Int32 FLD_DELAYDAYONPAYMENT = 16;
            const Int32 FLD_DELAYDAYONOVERDUE = 17;
            const Int32 FLD_PAYMENTRECEIVEDINBANK = 18;
            const Int32 FLD_PAYMENTNOTRECEIVEDNOTE = 19;
            const Int32 FLD_AGREEMENTID = 20;
            const Int32 FLD_PROJECTID = 21;
            const Int32 FLD_REVERSEENTRY = 22;
            const Int32 FLD_LASTPAYMENT = 23;
            const Int32 FLD_DISCOUNTAMOUNT = 24;
            const Int32 FLD_VAT = 25;
            const Int32 FLD_TAX = 26;
            const Int32 FLD_SERVICECHARGE = 27;
            const Int32 FLD_ADDITIONALFEE = 28;
            const Int32 FLD_GROSSAMOUNT = 29;
            const Int32 FLD_NETAMOUNT = 30;
            const Int32 FLD_PAYMENTAPPROVALSTATUSID = 31;
            const Int32 FLD_PAYMENTCATEGORYID = 32;
            const Int32 FLD_EXTRAFIELD = 33;
            const Int32 FLD_REMARKS = 34;
            const Int32 FLD_CREATEDATE = 35;
            const Int32 FLD_CREATEBYEMPLOYEEID = 36;
            const Int32 FLD_IP = 37;
            const Int32 FLD_AGREEMENTTYPENAME = 38;
            const Int32 FLD_PROJECTCODE = 39;
            const Int32 FLD_PROJECTNAME = 40;
            const Int32 FLD_AGREEMENTDATE = 41;
            const Int32 FLD_PROJECTFLOORUNITNAME = 42;
            const Int32 FLD_CREATEDBYMEMBERFULLNAME = 43;
            const Int32 FLD_CONTACTFULLNAME = 44;
            const Int32 FLD_COMPANYNAME = 45;
            const Int32 FLD_DESIGNATION = 46;

            CRMDuePaymentFromPaymentSchedule_RPTEntity cRMDuePaymentFromPaymentSchedule_RPTEntity = new CRMDuePaymentFromPaymentSchedule_RPTEntity();

            cRMDuePaymentFromPaymentSchedule_RPTEntity.PaymentScheduleMapID = reader.GetInt64(FLD_PAYMENTSCHEDULEMAPID);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.InstallmentName = reader.GetString(FLD_INSTALLMENTNAME);
            if (reader.IsDBNull(FLD_AGREEMENTAAMOUNT)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.AgreementAAmount = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.AgreementAAmount = reader.GetDecimal(FLD_AGREEMENTAAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTBAMOUNT)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.AgreementBAmount = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.AgreementBAmount = reader.GetDecimal(FLD_AGREEMENTBAMOUNT); }
            if (reader.IsDBNull(FLD_AGREEMENTCAMOUNT)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.AgreementCAmount = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.AgreementCAmount = reader.GetDecimal(FLD_AGREEMENTCAMOUNT); }
            cRMDuePaymentFromPaymentSchedule_RPTEntity.InstallmentDueDate = reader.GetDateTime(FLD_INSTALLMENTDUEDATE);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.PaymentCollectionID = reader.GetInt64(FLD_PAYMENTCOLLECTIONID);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.PaymentScheduleID = reader.GetInt64(FLD_PAYMENTSCHEDULEID);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.AgreementTypeID = reader.GetInt64(FLD_AGREEMENTTYPEID);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.MoneyReceiptNo = reader.GetDecimal(FLD_MONEYRECEIPTNO);
            if (reader.IsDBNull(FLD_ACTUALPAYMENTDATE)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.ActualPaymentDate = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.ActualPaymentDate = reader.GetDateTime(FLD_ACTUALPAYMENTDATE); }
            if (reader.IsDBNull(FLD_PAYMENTDESCRIPTION)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.PaymentDescription = String.Empty; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.PaymentDescription = reader.GetString(FLD_PAYMENTDESCRIPTION); }
            if (reader.IsDBNull(FLD_INSTALLMENTPAYMENTAMOUNT)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.InstallmentPaymentAmount = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.InstallmentPaymentAmount = reader.GetDecimal(FLD_INSTALLMENTPAYMENTAMOUNT); }
            cRMDuePaymentFromPaymentSchedule_RPTEntity.InstallmentPaymentInWord = reader.GetString(FLD_INSTALLMENTPAYMENTINWORD);
            if (reader.IsDBNull(FLD_INITIALAMOUNTINAGREEMENT)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.InitialAmountInAgreement = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.InitialAmountInAgreement = reader.GetDecimal(FLD_INITIALAMOUNTINAGREEMENT); }
            if (reader.IsDBNull(FLD_OVERDUEAMOUNT)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.OverDueAmount = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.OverDueAmount = reader.GetDecimal(FLD_OVERDUEAMOUNT); }
            if (reader.IsDBNull(FLD_DELAYDAYONPAYMENT)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.DelayDayOnPayment = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.DelayDayOnPayment = reader.GetDecimal(FLD_DELAYDAYONPAYMENT); }
            if (reader.IsDBNull(FLD_DELAYDAYONOVERDUE)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.DelayDayOnOverDue = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.DelayDayOnOverDue = reader.GetDecimal(FLD_DELAYDAYONOVERDUE); }
            if (reader.IsDBNull(FLD_PAYMENTRECEIVEDINBANK)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.PaymentReceivedInBank = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.PaymentReceivedInBank = reader.GetDecimal(FLD_PAYMENTRECEIVEDINBANK); }
            if (reader.IsDBNull(FLD_PAYMENTNOTRECEIVEDNOTE)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.PaymentNotReceivedNote = String.Empty; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.PaymentNotReceivedNote = reader.GetString(FLD_PAYMENTNOTRECEIVEDNOTE); }
            cRMDuePaymentFromPaymentSchedule_RPTEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.ReverseEntry = reader.GetBoolean(FLD_REVERSEENTRY);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.LastPayment = reader.GetBoolean(FLD_LASTPAYMENT);
            if (reader.IsDBNull(FLD_DISCOUNTAMOUNT)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.DiscountAmount = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.DiscountAmount = reader.GetDecimal(FLD_DISCOUNTAMOUNT); }
            if (reader.IsDBNull(FLD_VAT)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.Vat = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.Vat = reader.GetDecimal(FLD_VAT); }
            if (reader.IsDBNull(FLD_TAX)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.Tax = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.Tax = reader.GetDecimal(FLD_TAX); }
            if (reader.IsDBNull(FLD_SERVICECHARGE)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.ServiceCharge = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.ServiceCharge = reader.GetDecimal(FLD_SERVICECHARGE); }
            if (reader.IsDBNull(FLD_ADDITIONALFEE)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.AdditionalFee = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.AdditionalFee = reader.GetDecimal(FLD_ADDITIONALFEE); }
            if (reader.IsDBNull(FLD_GROSSAMOUNT)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.GrossAmount = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.GrossAmount = reader.GetDecimal(FLD_GROSSAMOUNT); }
            if (reader.IsDBNull(FLD_NETAMOUNT)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.NetAmount = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.NetAmount = reader.GetDecimal(FLD_NETAMOUNT); }
            cRMDuePaymentFromPaymentSchedule_RPTEntity.PaymentApprovalStatusID = reader.GetInt64(FLD_PAYMENTAPPROVALSTATUSID);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.PaymentCategoryID = reader.GetInt64(FLD_PAYMENTCATEGORYID);
            if (reader.IsDBNull(FLD_EXTRAFIELD)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.ExtraField = String.Empty; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.ExtraField = reader.GetString(FLD_EXTRAFIELD); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.Remarks = String.Empty; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMDuePaymentFromPaymentSchedule_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.IP = reader.GetString(FLD_IP);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.AgreementTypeName = reader.GetString(FLD_AGREEMENTTYPENAME);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.ProjectCode = String.Empty; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.ProjectName = String.Empty; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_AGREEMENTDATE)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.AgreementDate = null; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.AgreementDate = reader.GetDateTime(FLD_AGREEMENTDATE); }
            cRMDuePaymentFromPaymentSchedule_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME);
            if (reader.IsDBNull(FLD_CREATEDBYMEMBERFULLNAME)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.CreatedByMemberFullName = String.Empty; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.CreatedByMemberFullName = reader.GetString(FLD_CREATEDBYMEMBERFULLNAME); }
            cRMDuePaymentFromPaymentSchedule_RPTEntity.ContactFullName = reader.GetString(FLD_CONTACTFULLNAME);
            cRMDuePaymentFromPaymentSchedule_RPTEntity.CompanyName = reader.GetString(FLD_COMPANYNAME);
            if (reader.IsDBNull(FLD_DESIGNATION)) { cRMDuePaymentFromPaymentSchedule_RPTEntity.Designation = String.Empty; } else { cRMDuePaymentFromPaymentSchedule_RPTEntity.Designation = reader.GetString(FLD_DESIGNATION); }

            return cRMDuePaymentFromPaymentSchedule_RPTEntity;
        }
    }
}
