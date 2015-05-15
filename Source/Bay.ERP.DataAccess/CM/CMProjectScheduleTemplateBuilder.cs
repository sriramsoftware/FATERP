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
    internal sealed class CMProjectScheduleTemplateBuilder : IEntityBuilder<CMProjectScheduleTemplateEntity>
    {
        IList<CMProjectScheduleTemplateEntity> IEntityBuilder<CMProjectScheduleTemplateEntity>.BuildEntities(IDataReader reader)
        {
            List<CMProjectScheduleTemplateEntity> CMProjectScheduleTemplateEntityList = new List<CMProjectScheduleTemplateEntity>();

            while (reader.Read())
            {
                CMProjectScheduleTemplateEntityList.Add(((IEntityBuilder<CMProjectScheduleTemplateEntity>)this).BuildEntity(reader));
            }

            return (CMProjectScheduleTemplateEntityList.Count > 0) ? CMProjectScheduleTemplateEntityList : null;
        }

        CMProjectScheduleTemplateEntity IEntityBuilder<CMProjectScheduleTemplateEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTSCHEDULETEMPLATEID = 0;
            const Int32 FLD_TEMPLATENAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity = new CMProjectScheduleTemplateEntity();

            cMProjectScheduleTemplateEntity.ProjectScheduleTemplateID = reader.GetInt64(FLD_PROJECTSCHEDULETEMPLATEID);
            cMProjectScheduleTemplateEntity.TemplateName = reader.GetString(FLD_TEMPLATENAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cMProjectScheduleTemplateEntity.Description = String.Empty; } else { cMProjectScheduleTemplateEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cMProjectScheduleTemplateEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMProjectScheduleTemplateEntity;
        }
    }
}
