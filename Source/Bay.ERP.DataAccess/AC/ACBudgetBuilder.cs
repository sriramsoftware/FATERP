// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBudgetBuilder : IEntityBuilder<ACBudgetEntity>
    {
        IList<ACBudgetEntity> IEntityBuilder<ACBudgetEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBudgetEntity> ACBudgetEntityList = new List<ACBudgetEntity>();

            while (reader.Read())
            {
                ACBudgetEntityList.Add(((IEntityBuilder<ACBudgetEntity>)this).BuildEntity(reader));
            }

            return (ACBudgetEntityList.Count > 0) ? ACBudgetEntityList : null;
        }

        ACBudgetEntity IEntityBuilder<ACBudgetEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUDGETID = 0;
            const Int32 FLD_FISCALYEARID = 1;
            const Int32 FLD_ACCOUNTID = 2;
            const Int32 FLD_PERIOD = 3;
            const Int32 FLD_AMOUNT = 4;

            ACBudgetEntity aCBudgetEntity = new ACBudgetEntity();

            aCBudgetEntity.BudgetID = reader.GetInt64(FLD_BUDGETID);
            aCBudgetEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            aCBudgetEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCBudgetEntity.Period = reader.GetDateTime(FLD_PERIOD);
            aCBudgetEntity.Amount = reader.GetDecimal(FLD_AMOUNT);

            return aCBudgetEntity;
        }
    }
}
