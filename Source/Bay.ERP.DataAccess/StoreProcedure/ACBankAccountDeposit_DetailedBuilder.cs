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
    internal sealed class ACBankAccountDeposit_DetailedBuilder : IEntityBuilder<ACBankAccountDeposit_DetailedEntity>
    {
        IList<ACBankAccountDeposit_DetailedEntity> IEntityBuilder<ACBankAccountDeposit_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountDeposit_DetailedEntity> ACBankAccountDeposit_DetailedEntityList = new List<ACBankAccountDeposit_DetailedEntity>();

            while (reader.Read())
            {
                ACBankAccountDeposit_DetailedEntityList.Add(((IEntityBuilder<ACBankAccountDeposit_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountDeposit_DetailedEntityList.Count > 0) ? ACBankAccountDeposit_DetailedEntityList : null;
        }

        ACBankAccountDeposit_DetailedEntity IEntityBuilder<ACBankAccountDeposit_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_MEMBERFULLNAME = 10;
            const Int32 FLD_PAIDFROMNAME = 11;
            const Int32 FLD_BANKACCOUNTNAME = 12;
            const Int32 FLD_BANKACCOUNTDEPOSITAPPROVALSTATUSNAME = 13;
            const Int32 FLD_ROWNUMBER = 14;
            const Int32 FLD_BANKACCOUNTNUMBER = 15;

            ACBankAccountDeposit_DetailedEntity aCBankAccountDeposit_DetailedEntity = new ACBankAccountDeposit_DetailedEntity();

            aCBankAccountDeposit_DetailedEntity.BankAccountDepositID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITID);
            aCBankAccountDeposit_DetailedEntity.DepositDate = reader.GetDateTime(FLD_DEPOSITDATE);
            aCBankAccountDeposit_DetailedEntity.PaidFromID = reader.GetInt64(FLD_PAIDFROMID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { aCBankAccountDeposit_DetailedEntity.ReferenceID = null; } else { aCBankAccountDeposit_DetailedEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            aCBankAccountDeposit_DetailedEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID);
            if (reader.IsDBNull(FLD_REFERENCE)) { aCBankAccountDeposit_DetailedEntity.Reference = String.Empty; } else { aCBankAccountDeposit_DetailedEntity.Reference = reader.GetString(FLD_REFERENCE); }
            if (reader.IsDBNull(FLD_NAME)) { aCBankAccountDeposit_DetailedEntity.Name = String.Empty; } else { aCBankAccountDeposit_DetailedEntity.Name = reader.GetString(FLD_NAME); }
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountDeposit_DetailedEntity.Memo = String.Empty; } else { aCBankAccountDeposit_DetailedEntity.Memo = reader.GetString(FLD_MEMO); }
            aCBankAccountDeposit_DetailedEntity.BankAccountDepositApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITAPPROVALSTATUSID);
            aCBankAccountDeposit_DetailedEntity.PreparedByEmployeeID = reader.GetInt64(FLD_PREPAREDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCBankAccountDeposit_DetailedEntity.MemberFullName = String.Empty; } else { aCBankAccountDeposit_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_PAIDFROMNAME)) { aCBankAccountDeposit_DetailedEntity.PaidFromName = String.Empty; } else { aCBankAccountDeposit_DetailedEntity.PaidFromName = reader.GetString(FLD_PAIDFROMNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNAME)) { aCBankAccountDeposit_DetailedEntity.BankAccountName = String.Empty; } else { aCBankAccountDeposit_DetailedEntity.BankAccountName = reader.GetString(FLD_BANKACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITAPPROVALSTATUSNAME)) { aCBankAccountDeposit_DetailedEntity.BankAccountDepositApprovalStatusName = String.Empty; } else { aCBankAccountDeposit_DetailedEntity.BankAccountDepositApprovalStatusName = reader.GetString(FLD_BANKACCOUNTDEPOSITAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCBankAccountDeposit_DetailedEntity.RowNumber = null; } else { aCBankAccountDeposit_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNUMBER)) { aCBankAccountDeposit_DetailedEntity.BankAccountNumber = String.Empty; } else { aCBankAccountDeposit_DetailedEntity.BankAccountNumber = reader.GetString(FLD_BANKACCOUNTNUMBER); }

            return aCBankAccountDeposit_DetailedEntity;
        }
    }
}
