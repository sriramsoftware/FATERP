// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jan-2012, 04:26:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMProjectMilestone_DetailedBuilder : IEntityBuilder<CMProjectMilestone_DetailedEntity>
    {
        IList<CMProjectMilestone_DetailedEntity> IEntityBuilder<CMProjectMilestone_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMProjectMilestone_DetailedEntity> CMProjectMilestone_DetailedEntityList = new List<CMProjectMilestone_DetailedEntity>();

            while (reader.Read())
            {
                CMProjectMilestone_DetailedEntityList.Add(((IEntityBuilder<CMProjectMilestone_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMProjectMilestone_DetailedEntityList.Count > 0) ? CMProjectMilestone_DetailedEntityList : null;
        }

        CMProjectMilestone_DetailedEntity IEntityBuilder<CMProjectMilestone_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTMILESTONEID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_ISSUEID = 2;
            const Int32 FLD_PROJECTNAME = 3;
            const Int32 FLD_TITLE = 4;
            const Int32 FLD_ROWNUMBER = 5;

            CMProjectMilestone_DetailedEntity cMProjectMilestone_DetailedEntity = new CMProjectMilestone_DetailedEntity();

            cMProjectMilestone_DetailedEntity.ProjectMilestoneID = reader.GetInt64(FLD_PROJECTMILESTONEID);
            cMProjectMilestone_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMProjectMilestone_DetailedEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            if (reader.IsDBNull(FLD_PROJECTNAME)) { cMProjectMilestone_DetailedEntity.ProjectName = String.Empty; } else { cMProjectMilestone_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_TITLE)) { cMProjectMilestone_DetailedEntity.Title = String.Empty; } else { cMProjectMilestone_DetailedEntity.Title = reader.GetString(FLD_TITLE); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMProjectMilestone_DetailedEntity.RowNumber = null; } else { cMProjectMilestone_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMProjectMilestone_DetailedEntity;
        }
    }
}
