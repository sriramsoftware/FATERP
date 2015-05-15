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
    internal sealed class BDTaskTemplateBuilder : IEntityBuilder<BDTaskTemplateEntity>
    {
        IList<BDTaskTemplateEntity> IEntityBuilder<BDTaskTemplateEntity>.BuildEntities(IDataReader reader)
        {
            List<BDTaskTemplateEntity> BDTaskTemplateEntityList = new List<BDTaskTemplateEntity>();

            while (reader.Read())
            {
                BDTaskTemplateEntityList.Add(((IEntityBuilder<BDTaskTemplateEntity>)this).BuildEntity(reader));
            }

            return (BDTaskTemplateEntityList.Count > 0) ? BDTaskTemplateEntityList : null;
        }

        BDTaskTemplateEntity IEntityBuilder<BDTaskTemplateEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TASKTEMPLATEID = 0;
            const Int32 FLD_TEMPLATENAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            BDTaskTemplateEntity bDTaskTemplateEntity = new BDTaskTemplateEntity();

            bDTaskTemplateEntity.TaskTemplateID = reader.GetInt64(FLD_TASKTEMPLATEID);
            bDTaskTemplateEntity.TemplateName = reader.GetString(FLD_TEMPLATENAME);
            if (reader.IsDBNull(FLD_REMARKS)) { bDTaskTemplateEntity.Remarks = String.Empty; } else { bDTaskTemplateEntity.Remarks = reader.GetString(FLD_REMARKS); }
            bDTaskTemplateEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return bDTaskTemplateEntity;
        }
    }
}
