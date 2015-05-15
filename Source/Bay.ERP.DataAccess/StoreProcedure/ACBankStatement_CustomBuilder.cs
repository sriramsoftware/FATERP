// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jul-2013, 03:00:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBankStatement_CustomBuilder : IEntityBuilder<ACBankStatement_CustomEntity>
    {
        IList<ACBankStatement_CustomEntity> IEntityBuilder<ACBankStatement_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankStatement_CustomEntity> ACBankStatement_CustomEntityList = new List<ACBankStatement_CustomEntity>();

            while (reader.Read())
            {
                ACBankStatement_CustomEntityList.Add(((IEntityBuilder<ACBankStatement_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACBankStatement_CustomEntityList.Count > 0) ? ACBankStatement_CustomEntityList : null;
        }

        ACBankStatement_CustomEntity IEntityBuilder<ACBankStatement_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_JOURNALID = 0;
            const Int32 FLD_ACCOUNTID = 1;
            const Int32 FLD_TRANSACTIONDATETIME = 2;
            const Int32 FLD_AMOUNT = 3;
            const Int32 FLD_ENTEREDBYEMPLOYEEID = 4;
            const Int32 FLD_REFERENCEORMEMOORID = 5;
            const Int32 FLD_NOTE = 6;
            const Int32 FLD_MDDEBITCREDITID = 7;
            const Int32 FLD_FISCALYEARID = 8;
            const Int32 FLD_VOUCHERTYPE = 9;
            const Int32 FLD_ACACCOUNTACCOUNTNAME = 10;
            const Int32 FLD_ACMDDEBITCREDITNAME = 11;
            const Int32 FLD_ACFISCALYEAR = 12;
            const Int32 FLD_MEMBERFULLNAME = 13;
            const Int32 FLD_ROWNUMBER = 14;

            ACBankStatement_CustomEntity aCBankStatement_CustomEntity = new ACBankStatement_CustomEntity();

            aCBankStatement_CustomEntity.JournalID = reader.GetInt64(FLD_JOURNALID);
            aCBankStatement_CustomEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCBankStatement_CustomEntity.TransactionDateTime = reader.GetDateTime(FLD_TRANSACTIONDATETIME);
            aCBankStatement_CustomEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            aCBankStatement_CustomEntity.EnteredByEmployeeID = reader.GetInt64(FLD_ENTEREDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_REFERENCEORMEMOORID)) { aCBankStatement_CustomEntity.ReferenceOrMemoOrID = String.Empty; } else { aCBankStatement_CustomEntity.ReferenceOrMemoOrID = reader.GetString(FLD_REFERENCEORMEMOORID); }
            if (reader.IsDBNull(FLD_NOTE)) { aCBankStatement_CustomEntity.Note = String.Empty; } else { aCBankStatement_CustomEntity.Note = reader.GetString(FLD_NOTE); }
            aCBankStatement_CustomEntity.MDDebitCreditID = reader.GetInt64(FLD_MDDEBITCREDITID);
            aCBankStatement_CustomEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            if (reader.IsDBNull(FLD_VOUCHERTYPE)) { aCBankStatement_CustomEntity.VoucherType = String.Empty; } else { aCBankStatement_CustomEntity.VoucherType = reader.GetString(FLD_VOUCHERTYPE); }
            if (reader.IsDBNull(FLD_ACACCOUNTACCOUNTNAME)) { aCBankStatement_CustomEntity.ACAccountAccountName = String.Empty; } else { aCBankStatement_CustomEntity.ACAccountAccountName = reader.GetString(FLD_ACACCOUNTACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACMDDEBITCREDITNAME)) { aCBankStatement_CustomEntity.ACMDDebitCreditName = String.Empty; } else { aCBankStatement_CustomEntity.ACMDDebitCreditName = reader.GetString(FLD_ACMDDEBITCREDITNAME); }
            if (reader.IsDBNull(FLD_ACFISCALYEAR)) { aCBankStatement_CustomEntity.ACFiscalYear = String.Empty; } else { aCBankStatement_CustomEntity.ACFiscalYear = reader.GetString(FLD_ACFISCALYEAR); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCBankStatement_CustomEntity.MemberFullName = String.Empty; } else { aCBankStatement_CustomEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCBankStatement_CustomEntity.RowNumber = null; } else { aCBankStatement_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCBankStatement_CustomEntity;
        }
    }
}
