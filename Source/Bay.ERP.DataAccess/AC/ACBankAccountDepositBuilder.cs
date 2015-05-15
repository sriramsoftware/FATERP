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
    internal sealed class ACBankAccountDepositBuilder : IEntityBuilder<ACBankAccountDepositEntity>
    {
        IList<ACBankAccountDepositEntity> IEntityBuilder<ACBankAccountDepositEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountDepositEntity> ACBankAccountDepositEntityList = new List<ACBankAccountDepositEntity>();

            while (reader.Read())
            {
                ACBankAccountDepositEntityList.Add(((IEntityBuilder<ACBankAccountDepositEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountDepositEntityList.Count > 0) ? ACBankAccountDepositEntityList : null;
        }

        ACBankAccountDepositEntity IEntityBuilder<ACBankAccountDepositEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTDEPOSITID = 0;
            const Int32 FLD_DEPOSITDATE = 1;
            const Int32 FLD_PAIDFROMID = 2;
            const Int32 FLD_REFERENCEID = 3;
            const Int32 FLD_BANKACCOUNTID = 4;
            const Int32 FLD_REFERENCE = 5;
            const Int32 FLD_NAME = 6;
            const Int32 FLD_MEMO = 7;
            const Int32 FLD_BANKACCOUNTDEPOSITAPPROVALSTATUSID = 8;
            const Int32 FLD_PREPAREDBYEMPLOYEEID = 9;

            ACBankAccountDepositEntity aCBankAccountDepositEntity = new ACBankAccountDepositEntity();

            aCBankAccountDepositEntity.BankAccountDepositID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITID);
            aCBankAccountDepositEntity.DepositDate = reader.GetDateTime(FLD_DEPOSITDATE);
            aCBankAccountDepositEntity.PaidFromID = reader.GetInt64(FLD_PAIDFROMID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { aCBankAccountDepositEntity.ReferenceID = null; } else { aCBankAccountDepositEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            aCBankAccountDepositEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID);
            if (reader.IsDBNull(FLD_REFERENCE)) { aCBankAccountDepositEntity.Reference = String.Empty; } else { aCBankAccountDepositEntity.Reference = reader.GetString(FLD_REFERENCE); }
            if (reader.IsDBNull(FLD_NAME)) { aCBankAccountDepositEntity.Name = String.Empty; } else { aCBankAccountDepositEntity.Name = reader.GetString(FLD_NAME); }
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountDepositEntity.Memo = String.Empty; } else { aCBankAccountDepositEntity.Memo = reader.GetString(FLD_MEMO); }
            aCBankAccountDepositEntity.BankAccountDepositApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITAPPROVALSTATUSID);
            aCBankAccountDepositEntity.PreparedByEmployeeID = reader.GetInt64(FLD_PREPAREDBYEMPLOYEEID);

            return aCBankAccountDepositEntity;
        }
    }
}
