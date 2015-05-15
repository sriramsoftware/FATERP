// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDTaskTemplateItemMapBuilder : IEntityBuilder<BDTaskTemplateItemMapEntity>
    {
        IList<BDTaskTemplateItemMapEntity> IEntityBuilder<BDTaskTemplateItemMapEntity>.BuildEntities(IDataReader reader)
        {
            List<BDTaskTemplateItemMapEntity> BDTaskTemplateItemMapEntityList = new List<BDTaskTemplateItemMapEntity>();

            while (reader.Read())
            {
                BDTaskTemplateItemMapEntityList.Add(((IEntityBuilder<BDTaskTemplateItemMapEntity>)this).BuildEntity(reader));
            }

            return (BDTaskTemplateItemMapEntityList.Count > 0) ? BDTaskTemplateItemMapEntityList : null;
        }

        BDTaskTemplateItemMapEntity IEntityBuilder<BDTaskTemplateItemMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TASKTEMPLATEITEMMAP = 0;
            const Int32 FLD_TASKTEMPLATEID = 1;
            const Int32 FLD_TASKID = 2;

            BDTaskTemplateItemMapEntity bDTaskTemplateItemMapEntity = new BDTaskTemplateItemMapEntity();

            bDTaskTemplateItemMapEntity.TaskTemplateItemMap = reader.GetInt64(FLD_TASKTEMPLATEITEMMAP);
            bDTaskTemplateItemMapEntity.TaskTemplateID = reader.GetInt64(FLD_TASKTEMPLATEID);
            bDTaskTemplateItemMapEntity.TaskID = reader.GetInt64(FLD_TASKID);

            return bDTaskTemplateItemMapEntity;
        }
    }
}
