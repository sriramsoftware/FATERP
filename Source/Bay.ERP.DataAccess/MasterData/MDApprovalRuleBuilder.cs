// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDApprovalRuleBuilder : IEntityBuilder<MDApprovalRuleEntity>
    {
        IList<MDApprovalRuleEntity> IEntityBuilder<MDApprovalRuleEntity>.BuildEntities(IDataReader reader)
        {
            List<MDApprovalRuleEntity> MDApprovalRuleEntityList = new List<MDApprovalRuleEntity>();

            while (reader.Read())
            {
                MDApprovalRuleEntityList.Add(((IEntityBuilder<MDApprovalRuleEntity>)this).BuildEntity(reader));
            }

            return (MDApprovalRuleEntityList.Count > 0) ? MDApprovalRuleEntityList : null;
        }

        MDApprovalRuleEntity IEntityBuilder<MDApprovalRuleEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPROVALRULEID = 0;
            const Int32 FLD_APPROVALRULENAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDApprovalRuleEntity mDApprovalRuleEntity = new MDApprovalRuleEntity();

            mDApprovalRuleEntity.ApprovalRuleID = reader.GetInt64(FLD_APPROVALRULEID);
            mDApprovalRuleEntity.ApprovalRuleName = reader.GetString(FLD_APPROVALRULENAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDApprovalRuleEntity.Description = String.Empty; } else { mDApprovalRuleEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDApprovalRuleEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDApprovalRuleEntity;
        }
    }
}
