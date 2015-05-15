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
    internal sealed class MDApprovalRuleDesignationMapBuilder : IEntityBuilder<MDApprovalRuleDesignationMapEntity>
    {
        IList<MDApprovalRuleDesignationMapEntity> IEntityBuilder<MDApprovalRuleDesignationMapEntity>.BuildEntities(IDataReader reader)
        {
            List<MDApprovalRuleDesignationMapEntity> MDApprovalRuleDesignationMapEntityList = new List<MDApprovalRuleDesignationMapEntity>();

            while (reader.Read())
            {
                MDApprovalRuleDesignationMapEntityList.Add(((IEntityBuilder<MDApprovalRuleDesignationMapEntity>)this).BuildEntity(reader));
            }

            return (MDApprovalRuleDesignationMapEntityList.Count > 0) ? MDApprovalRuleDesignationMapEntityList : null;
        }

        MDApprovalRuleDesignationMapEntity IEntityBuilder<MDApprovalRuleDesignationMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPROVALRULEDESIGNATIONMAPID = 0;
            const Int32 FLD_APPROVALRULEID = 1;
            const Int32 FLD_DESIGNATIONID = 2;
            const Int32 FLD_SEQUEENCENO = 3;

            MDApprovalRuleDesignationMapEntity mDApprovalRuleDesignationMapEntity = new MDApprovalRuleDesignationMapEntity();

            mDApprovalRuleDesignationMapEntity.ApprovalRuleDesignationMapID = reader.GetInt64(FLD_APPROVALRULEDESIGNATIONMAPID);
            mDApprovalRuleDesignationMapEntity.ApprovalRuleID = reader.GetInt64(FLD_APPROVALRULEID);
            mDApprovalRuleDesignationMapEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID);
            mDApprovalRuleDesignationMapEntity.SequeenceNo = reader.GetInt32(FLD_SEQUEENCENO);

            return mDApprovalRuleDesignationMapEntity;
        }
    }
}
