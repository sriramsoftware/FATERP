// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2013, 11:20:53




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBankAccountPaymentBuilder : IEntityBuilder<ACBankAccountPaymentEntity>
    {
        IList<ACBankAccountPaymentEntity> IEntityBuilder<ACBankAccountPaymentEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountPaymentEntity> ACBankAccountPaymentEntityList = new List<ACBankAccountPaymentEntity>();

            while (reader.Read())
            {
                ACBankAccountPaymentEntityList.Add(((IEntityBuilder<ACBankAccountPaymentEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountPaymentEntityList.Count > 0) ? ACBankAccountPaymentEntityList : null;
        }

        ACBankAccountPaymentEntity IEntityBuilder<ACBankAccountPaymentEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTPAYMENTID = 0;
            const Int32 FLD_PAYMENTDATE = 1;
            const Int32 FLD_PAYTOID = 2;
            const Int32 FLD_REFERENCEID = 3;
            const Int32 FLD_BANKACCOUNTID = 4;
            const Int32 FLD_REFERENCE = 5;
            const Int32 FLD_NAME = 6;
            const Int32 FLD_MEMO = 7;
            const Int32 FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSID = 8;
            const Int32 FLD_PREPAREDBYEMPLOYEEID = 9;

            ACBankAccountPaymentEntity aCBankAccountPaymentEntity = new ACBankAccountPaymentEntity();

            aCBankAccountPaymentEntity.BankAccountPaymentID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTID);
            aCBankAccountPaymentEntity.PaymentDate = reader.GetDateTime(FLD_PAYMENTDATE);
            aCBankAccountPaymentEntity.PayToID = reader.GetInt64(FLD_PAYTOID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { aCBankAccountPaymentEntity.ReferenceID = null; } else { aCBankAccountPaymentEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            aCBankAccountPaymentEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID);
            if (reader.IsDBNull(FLD_REFERENCE)) { aCBankAccountPaymentEntity.Reference = String.Empty; } else { aCBankAccountPaymentEntity.Reference = reader.GetString(FLD_REFERENCE); }
            if (reader.IsDBNull(FLD_NAME)) { aCBankAccountPaymentEntity.Name = String.Empty; } else { aCBankAccountPaymentEntity.Name = reader.GetString(FLD_NAME); }
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountPaymentEntity.Memo = String.Empty; } else { aCBankAccountPaymentEntity.Memo = reader.GetString(FLD_MEMO); }
            aCBankAccountPaymentEntity.BankAccountPaymentApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSID);
            aCBankAccountPaymentEntity.PreparedByEmployeeID = reader.GetInt64(FLD_PREPAREDBYEMPLOYEEID);

            return aCBankAccountPaymentEntity;
        }
    }
}
