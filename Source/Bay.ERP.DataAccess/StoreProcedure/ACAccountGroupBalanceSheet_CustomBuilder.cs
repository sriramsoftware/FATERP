// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Feb-2013, 02:55:23




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACAccountGroupBalanceSheet_CustomBuilder : IEntityBuilder<ACAccountGroupBalanceSheet_CustomEntity>
    {
        IList<ACAccountGroupBalanceSheet_CustomEntity> IEntityBuilder<ACAccountGroupBalanceSheet_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACAccountGroupBalanceSheet_CustomEntity> ACAccountGroupBalanceSheet_CustomEntityList = new List<ACAccountGroupBalanceSheet_CustomEntity>();

            while (reader.Read())
            {
                ACAccountGroupBalanceSheet_CustomEntityList.Add(((IEntityBuilder<ACAccountGroupBalanceSheet_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACAccountGroupBalanceSheet_CustomEntityList.Count > 0) ? ACAccountGroupBalanceSheet_CustomEntityList : null;
        }

        ACAccountGroupBalanceSheet_CustomEntity IEntityBuilder<ACAccountGroupBalanceSheet_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTGROUPID = 0;
            const Int32 FLD_DEBITAMOUNT = 1;
            const Int32 FLD_CREDITAMOUNT = 2;
            const Int32 FLD_BALANCE = 3;
            const Int32 FLD_ACCOUNTGROUP = 4;

            ACAccountGroupBalanceSheet_CustomEntity aCAccountGroupBalanceSheet_CustomEntity = new ACAccountGroupBalanceSheet_CustomEntity();

            if (reader.IsDBNull(FLD_ACCOUNTGROUPID)) { aCAccountGroupBalanceSheet_CustomEntity.AccountGroupID = null; } else { aCAccountGroupBalanceSheet_CustomEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID); }
            aCAccountGroupBalanceSheet_CustomEntity.DebitAmount = reader.GetDecimal(FLD_DEBITAMOUNT);
            aCAccountGroupBalanceSheet_CustomEntity.CreditAmount = reader.GetDecimal(FLD_CREDITAMOUNT);
            if (reader.IsDBNull(FLD_BALANCE)) { aCAccountGroupBalanceSheet_CustomEntity.Balance = null; } else { aCAccountGroupBalanceSheet_CustomEntity.Balance = reader.GetDecimal(FLD_BALANCE); }
            if (reader.IsDBNull(FLD_ACCOUNTGROUP)) { aCAccountGroupBalanceSheet_CustomEntity.AccountGroup = String.Empty; } else { aCAccountGroupBalanceSheet_CustomEntity.AccountGroup = reader.GetString(FLD_ACCOUNTGROUP); }

            return aCAccountGroupBalanceSheet_CustomEntity;
        }
    }
}
