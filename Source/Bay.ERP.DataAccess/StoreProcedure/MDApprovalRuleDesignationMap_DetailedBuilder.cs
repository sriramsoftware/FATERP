// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-May-2012, 02:13:26




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDApprovalRuleDesignationMap_DetailedBuilder : IEntityBuilder<MDApprovalRuleDesignationMap_DetailedEntity>
    {
        IList<MDApprovalRuleDesignationMap_DetailedEntity> IEntityBuilder<MDApprovalRuleDesignationMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<MDApprovalRuleDesignationMap_DetailedEntity> MDApprovalRuleDesignationMap_DetailedEntityList = new List<MDApprovalRuleDesignationMap_DetailedEntity>();

            while (reader.Read())
            {
                MDApprovalRuleDesignationMap_DetailedEntityList.Add(((IEntityBuilder<MDApprovalRuleDesignationMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (MDApprovalRuleDesignationMap_DetailedEntityList.Count > 0) ? MDApprovalRuleDesignationMap_DetailedEntityList : null;
        }

        MDApprovalRuleDesignationMap_DetailedEntity IEntityBuilder<MDApprovalRuleDesignationMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPROVALRULEDESIGNATIONMAPID = 0;
            const Int32 FLD_APPROVALRULEID = 1;
            const Int32 FLD_DESIGNATIONID = 2;
            const Int32 FLD_SEQUEENCENO = 3;
            const Int32 FLD_APPROVALRULENAME = 4;
            const Int32 FLD_MDDESIGNATIONNAME = 5;
            const Int32 FLD_ROWNUMBER = 6;

            MDApprovalRuleDesignationMap_DetailedEntity mDApprovalRuleDesignationMap_DetailedEntity = new MDApprovalRuleDesignationMap_DetailedEntity();

            mDApprovalRuleDesignationMap_DetailedEntity.ApprovalRuleDesignationMapID = reader.GetInt64(FLD_APPROVALRULEDESIGNATIONMAPID);
            mDApprovalRuleDesignationMap_DetailedEntity.ApprovalRuleID = reader.GetInt64(FLD_APPROVALRULEID);
            mDApprovalRuleDesignationMap_DetailedEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID);
            mDApprovalRuleDesignationMap_DetailedEntity.SequeenceNo = reader.GetInt32(FLD_SEQUEENCENO);
            if (reader.IsDBNull(FLD_APPROVALRULENAME)) { mDApprovalRuleDesignationMap_DetailedEntity.ApprovalRuleName = String.Empty; } else { mDApprovalRuleDesignationMap_DetailedEntity.ApprovalRuleName = reader.GetString(FLD_APPROVALRULENAME); }
            if (reader.IsDBNull(FLD_MDDESIGNATIONNAME)) { mDApprovalRuleDesignationMap_DetailedEntity.MDDesignationName = String.Empty; } else { mDApprovalRuleDesignationMap_DetailedEntity.MDDesignationName = reader.GetString(FLD_MDDESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { mDApprovalRuleDesignationMap_DetailedEntity.RowNumber = null; } else { mDApprovalRuleDesignationMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return mDApprovalRuleDesignationMap_DetailedEntity;
        }
    }
}
