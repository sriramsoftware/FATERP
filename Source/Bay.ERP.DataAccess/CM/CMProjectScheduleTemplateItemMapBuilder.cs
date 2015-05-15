// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMProjectScheduleTemplateItemMapBuilder : IEntityBuilder<CMProjectScheduleTemplateItemMapEntity>
    {
        IList<CMProjectScheduleTemplateItemMapEntity> IEntityBuilder<CMProjectScheduleTemplateItemMapEntity>.BuildEntities(IDataReader reader)
        {
            List<CMProjectScheduleTemplateItemMapEntity> CMProjectScheduleTemplateItemMapEntityList = new List<CMProjectScheduleTemplateItemMapEntity>();

            while (reader.Read())
            {
                CMProjectScheduleTemplateItemMapEntityList.Add(((IEntityBuilder<CMProjectScheduleTemplateItemMapEntity>)this).BuildEntity(reader));
            }

            return (CMProjectScheduleTemplateItemMapEntityList.Count > 0) ? CMProjectScheduleTemplateItemMapEntityList : null;
        }

        CMProjectScheduleTemplateItemMapEntity IEntityBuilder<CMProjectScheduleTemplateItemMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTSCHEDULETEMPLATEITEMMAPID = 0;
            const Int32 FLD_PROJECTSCHEDULETEMPLATEID = 1;
            const Int32 FLD_PROJECTSCHEDULEITEMID = 2;
            const Int32 FLD_NOTIFYBEFOREMIN = 3;
            const Int32 FLD_ISSUEPRIORITYID = 4;
            const Int32 FLD_DURATION = 5;

            CMProjectScheduleTemplateItemMapEntity cMProjectScheduleTemplateItemMapEntity = new CMProjectScheduleTemplateItemMapEntity();

            cMProjectScheduleTemplateItemMapEntity.ProjectScheduleTemplateItemMapID = reader.GetInt64(FLD_PROJECTSCHEDULETEMPLATEITEMMAPID);
            cMProjectScheduleTemplateItemMapEntity.ProjectScheduleTemplateID = reader.GetInt64(FLD_PROJECTSCHEDULETEMPLATEID);
            cMProjectScheduleTemplateItemMapEntity.ProjectScheduleItemID = reader.GetInt64(FLD_PROJECTSCHEDULEITEMID);
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { cMProjectScheduleTemplateItemMapEntity.NotifyBeforeMin = null; } else { cMProjectScheduleTemplateItemMapEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            cMProjectScheduleTemplateItemMapEntity.IssuePriorityID = reader.GetInt64(FLD_ISSUEPRIORITYID);
            if (reader.IsDBNull(FLD_DURATION)) { cMProjectScheduleTemplateItemMapEntity.Duration = null; } else { cMProjectScheduleTemplateItemMapEntity.Duration = reader.GetDecimal(FLD_DURATION); }

            return cMProjectScheduleTemplateItemMapEntity;
        }
    }
}
