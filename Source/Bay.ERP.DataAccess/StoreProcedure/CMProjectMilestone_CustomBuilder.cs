// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Jan-2012, 02:37:47




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMProjectMilestone_CustomBuilder : IEntityBuilder<CMProjectMilestone_CustomEntity>
    {
        IList<CMProjectMilestone_CustomEntity> IEntityBuilder<CMProjectMilestone_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<CMProjectMilestone_CustomEntity> CMProjectMilestone_CustomEntityList = new List<CMProjectMilestone_CustomEntity>();

            while (reader.Read())
            {
                CMProjectMilestone_CustomEntityList.Add(((IEntityBuilder<CMProjectMilestone_CustomEntity>)this).BuildEntity(reader));
            }

            return (CMProjectMilestone_CustomEntityList.Count > 0) ? CMProjectMilestone_CustomEntityList : null;
        }

        CMProjectMilestone_CustomEntity IEntityBuilder<CMProjectMilestone_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTMILESTONEID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_TITLE = 2;
            const Int32 FLD_COMPLETIONPERCENTAGE = 3;
            const Int32 FLD_ISSUESTATUSNAME = 4;

            CMProjectMilestone_CustomEntity cMProjectMilestone_CustomEntity = new CMProjectMilestone_CustomEntity();

            cMProjectMilestone_CustomEntity.ProjectMilestoneID = reader.GetInt64(FLD_PROJECTMILESTONEID);
            cMProjectMilestone_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMProjectMilestone_CustomEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_COMPLETIONPERCENTAGE)) { cMProjectMilestone_CustomEntity.CompletionPercentage = null; } else { cMProjectMilestone_CustomEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE); }
            cMProjectMilestone_CustomEntity.IssueStatusName = reader.GetString(FLD_ISSUESTATUSNAME);

            return cMProjectMilestone_CustomEntity;
        }
    }
}
