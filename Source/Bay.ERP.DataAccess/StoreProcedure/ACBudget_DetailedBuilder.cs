// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 04:44:22




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBudget_DetailedBuilder : IEntityBuilder<ACBudget_DetailedEntity>
    {
        IList<ACBudget_DetailedEntity> IEntityBuilder<ACBudget_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBudget_DetailedEntity> ACBudget_DetailedEntityList = new List<ACBudget_DetailedEntity>();

            while (reader.Read())
            {
                ACBudget_DetailedEntityList.Add(((IEntityBuilder<ACBudget_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACBudget_DetailedEntityList.Count > 0) ? ACBudget_DetailedEntityList : null;
        }

        ACBudget_DetailedEntity IEntityBuilder<ACBudget_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUDGETID = 0;
            const Int32 FLD_FISCALYEARID = 1;
            const Int32 FLD_ACCOUNTID = 2;
            const Int32 FLD_PERIOD = 3;
            const Int32 FLD_AMOUNT = 4;
            const Int32 FLD_BEGINDATE = 5;
            const Int32 FLD_ENDDATE = 6;
            const Int32 FLD_ACFISCALYEAR = 7;
            const Int32 FLD_ACCOUNTNAME = 8;
            const Int32 FLD_ROWNUMBER = 9;

            ACBudget_DetailedEntity aCBudget_DetailedEntity = new ACBudget_DetailedEntity();

            aCBudget_DetailedEntity.BudgetID = reader.GetInt64(FLD_BUDGETID);
            aCBudget_DetailedEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            aCBudget_DetailedEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCBudget_DetailedEntity.Period = reader.GetDateTime(FLD_PERIOD);
            aCBudget_DetailedEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            if (reader.IsDBNull(FLD_BEGINDATE)) { aCBudget_DetailedEntity.BeginDate = null; } else { aCBudget_DetailedEntity.BeginDate = reader.GetDateTime(FLD_BEGINDATE); }
            if (reader.IsDBNull(FLD_ENDDATE)) { aCBudget_DetailedEntity.EndDate = null; } else { aCBudget_DetailedEntity.EndDate = reader.GetDateTime(FLD_ENDDATE); }
            if (reader.IsDBNull(FLD_ACFISCALYEAR)) { aCBudget_DetailedEntity.ACFiscalYear = null; } else { aCBudget_DetailedEntity.ACFiscalYear = reader.GetDateTime(FLD_ACFISCALYEAR); }
            if (reader.IsDBNull(FLD_ACCOUNTNAME)) { aCBudget_DetailedEntity.AccountName = String.Empty; } else { aCBudget_DetailedEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCBudget_DetailedEntity.RowNumber = null; } else { aCBudget_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCBudget_DetailedEntity;
        }
    }
}
