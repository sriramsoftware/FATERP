// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACDebitCreditRuleElementBuilder : IEntityBuilder<ACDebitCreditRuleElementEntity>
    {
        IList<ACDebitCreditRuleElementEntity> IEntityBuilder<ACDebitCreditRuleElementEntity>.BuildEntities(IDataReader reader)
        {
            List<ACDebitCreditRuleElementEntity> ACDebitCreditRuleElementEntityList = new List<ACDebitCreditRuleElementEntity>();

            while (reader.Read())
            {
                ACDebitCreditRuleElementEntityList.Add(((IEntityBuilder<ACDebitCreditRuleElementEntity>)this).BuildEntity(reader));
            }

            return (ACDebitCreditRuleElementEntityList.Count > 0) ? ACDebitCreditRuleElementEntityList : null;
        }

        ACDebitCreditRuleElementEntity IEntityBuilder<ACDebitCreditRuleElementEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DEBITCREDITRULEELEMENTID = 0;
            const Int32 FLD_ACTION = 1;

            ACDebitCreditRuleElementEntity aCDebitCreditRuleElementEntity = new ACDebitCreditRuleElementEntity();

            aCDebitCreditRuleElementEntity.DebitCreditRuleElementID = reader.GetInt64(FLD_DEBITCREDITRULEELEMENTID);
            aCDebitCreditRuleElementEntity.Action = reader.GetString(FLD_ACTION);

            return aCDebitCreditRuleElementEntity;
        }
    }
}
