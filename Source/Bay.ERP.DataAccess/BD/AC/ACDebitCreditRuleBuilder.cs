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
    internal sealed class ACDebitCreditRuleBuilder : IEntityBuilder<ACDebitCreditRuleEntity>
    {
        IList<ACDebitCreditRuleEntity> IEntityBuilder<ACDebitCreditRuleEntity>.BuildEntities(IDataReader reader)
        {
            List<ACDebitCreditRuleEntity> ACDebitCreditRuleEntityList = new List<ACDebitCreditRuleEntity>();

            while (reader.Read())
            {
                ACDebitCreditRuleEntityList.Add(((IEntityBuilder<ACDebitCreditRuleEntity>)this).BuildEntity(reader));
            }

            return (ACDebitCreditRuleEntityList.Count > 0) ? ACDebitCreditRuleEntityList : null;
        }

        ACDebitCreditRuleEntity IEntityBuilder<ACDebitCreditRuleEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACDEBITCREDITRULEID = 0;
            const Int32 FLD_DEBITCREDITACTIONID = 1;
            const Int32 FLD_ISUP = 2;
            const Int32 FLD_ISDOWN = 3;
            const Int32 FLD_MDDEBITCREDITID = 4;

            ACDebitCreditRuleEntity aCDebitCreditRuleEntity = new ACDebitCreditRuleEntity();

            aCDebitCreditRuleEntity.ACDebitCreditRuleID = reader.GetInt64(FLD_ACDEBITCREDITRULEID);
            aCDebitCreditRuleEntity.DebitCreditActionID = reader.GetInt64(FLD_DEBITCREDITACTIONID);
            aCDebitCreditRuleEntity.IsUp = reader.GetBoolean(FLD_ISUP);
            if (reader.IsDBNull(FLD_ISDOWN)) { aCDebitCreditRuleEntity.IsDown = false; } else { aCDebitCreditRuleEntity.IsDown = reader.GetBoolean(FLD_ISDOWN); }
            aCDebitCreditRuleEntity.MDDebitCreditID = reader.GetInt64(FLD_MDDEBITCREDITID);

            return aCDebitCreditRuleEntity;
        }
    }
}
