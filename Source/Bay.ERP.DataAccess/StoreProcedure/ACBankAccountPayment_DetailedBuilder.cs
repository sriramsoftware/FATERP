// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jul-2013, 11:50:30




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBankAccountPayment_DetailedBuilder : IEntityBuilder<ACBankAccountPayment_DetailedEntity>
    {
        IList<ACBankAccountPayment_DetailedEntity> IEntityBuilder<ACBankAccountPayment_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountPayment_DetailedEntity> ACBankAccountPayment_DetailedEntityList = new List<ACBankAccountPayment_DetailedEntity>();

            while (reader.Read())
            {
                ACBankAccountPayment_DetailedEntityList.Add(((IEntityBuilder<ACBankAccountPayment_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountPayment_DetailedEntityList.Count > 0) ? ACBankAccountPayment_DetailedEntityList : null;
        }

        ACBankAccountPayment_DetailedEntity IEntityBuilder<ACBankAccountPayment_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTPAYMENTID = 0;
            const Int32 FLD_PAYMENTDATE = 1;
            const Int32 FLD_PAYTOID = 2;
            const Int32 FLD_REFERENCEID = 3;
            const Int32 FLD_BANKACCOUNTID = 4;
            const Int32 FLD_REFERENCE = 5;
            const Int32 FLD_NAME = 6;
            const Int32 FLD_MEMO = 7;
            const Int32 FLD_PREPAREDBYEMPLOYEEID = 8;
            const Int32 FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSID = 9;
            const Int32 FLD_PAYTONAME = 10;
            const Int32 FLD_BANKACCOUNTNAME = 11;
            const Int32 FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSNAME = 12;
            const Int32 FLD_MEMBERFULLNAME = 13;
            const Int32 FLD_ROWNUMBER = 14;
            const Int32 FLD_BANKACCOUNTNUMBER = 15;

            ACBankAccountPayment_DetailedEntity aCBankAccountPayment_DetailedEntity = new ACBankAccountPayment_DetailedEntity();

            aCBankAccountPayment_DetailedEntity.BankAccountPaymentID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTID);
            aCBankAccountPayment_DetailedEntity.PaymentDate = reader.GetDateTime(FLD_PAYMENTDATE);
            aCBankAccountPayment_DetailedEntity.PayToID = reader.GetInt64(FLD_PAYTOID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { aCBankAccountPayment_DetailedEntity.ReferenceID = null; } else { aCBankAccountPayment_DetailedEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            aCBankAccountPayment_DetailedEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID);
            if (reader.IsDBNull(FLD_REFERENCE)) { aCBankAccountPayment_DetailedEntity.Reference = String.Empty; } else { aCBankAccountPayment_DetailedEntity.Reference = reader.GetString(FLD_REFERENCE); }
            if (reader.IsDBNull(FLD_NAME)) { aCBankAccountPayment_DetailedEntity.Name = String.Empty; } else { aCBankAccountPayment_DetailedEntity.Name = reader.GetString(FLD_NAME); }
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountPayment_DetailedEntity.Memo = String.Empty; } else { aCBankAccountPayment_DetailedEntity.Memo = reader.GetString(FLD_MEMO); }
            aCBankAccountPayment_DetailedEntity.PreparedByEmployeeID = reader.GetInt64(FLD_PREPAREDBYEMPLOYEEID);
            aCBankAccountPayment_DetailedEntity.BankAccountPaymentApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_PAYTONAME)) { aCBankAccountPayment_DetailedEntity.PayToName = String.Empty; } else { aCBankAccountPayment_DetailedEntity.PayToName = reader.GetString(FLD_PAYTONAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNAME)) { aCBankAccountPayment_DetailedEntity.BankAccountName = String.Empty; } else { aCBankAccountPayment_DetailedEntity.BankAccountName = reader.GetString(FLD_BANKACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSNAME)) { aCBankAccountPayment_DetailedEntity.BankAccountPaymentApprovalStatusName = String.Empty; } else { aCBankAccountPayment_DetailedEntity.BankAccountPaymentApprovalStatusName = reader.GetString(FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCBankAccountPayment_DetailedEntity.MemberFullName = String.Empty; } else { aCBankAccountPayment_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCBankAccountPayment_DetailedEntity.RowNumber = null; } else { aCBankAccountPayment_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNUMBER)) { aCBankAccountPayment_DetailedEntity.BankAccountNumber = String.Empty; } else { aCBankAccountPayment_DetailedEntity.BankAccountNumber = reader.GetString(FLD_BANKACCOUNTNUMBER); }

            return aCBankAccountPayment_DetailedEntity;
        }
    }
}
