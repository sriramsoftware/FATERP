// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jan-2012, 04:09:33




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMProjectMilestoneBuilder : IEntityBuilder<CMProjectMilestoneEntity>
    {
        IList<CMProjectMilestoneEntity> IEntityBuilder<CMProjectMilestoneEntity>.BuildEntities(IDataReader reader)
        {
            List<CMProjectMilestoneEntity> CMProjectMilestoneEntityList = new List<CMProjectMilestoneEntity>();

            while (reader.Read())
            {
                CMProjectMilestoneEntityList.Add(((IEntityBuilder<CMProjectMilestoneEntity>)this).BuildEntity(reader));
            }

            return (CMProjectMilestoneEntityList.Count > 0) ? CMProjectMilestoneEntityList : null;
        }

        CMProjectMilestoneEntity IEntityBuilder<CMProjectMilestoneEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTMILESTONEID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_ISSUEID = 2;

            CMProjectMilestoneEntity cMProjectMilestoneEntity = new CMProjectMilestoneEntity();

            cMProjectMilestoneEntity.ProjectMilestoneID = reader.GetInt64(FLD_PROJECTMILESTONEID);
            cMProjectMilestoneEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMProjectMilestoneEntity.IssueID = reader.GetInt64(FLD_ISSUEID);

            return cMProjectMilestoneEntity;
        }
    }
}
