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
    internal sealed class BDMDTaskBuilder : IEntityBuilder<BDMDTaskEntity>
    {
        IList<BDMDTaskEntity> IEntityBuilder<BDMDTaskEntity>.BuildEntities(IDataReader reader)
        {
            List<BDMDTaskEntity> BDMDTaskEntityList = new List<BDMDTaskEntity>();

            while (reader.Read())
            {
                BDMDTaskEntityList.Add(((IEntityBuilder<BDMDTaskEntity>)this).BuildEntity(reader));
            }

            return (BDMDTaskEntityList.Count > 0) ? BDMDTaskEntityList : null;
        }

        BDMDTaskEntity IEntityBuilder<BDMDTaskEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TASKID = 0;
            const Int32 FLD_TASKCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_REQUIREDSTANDARDTIME = 3;
            const Int32 FLD_REMINDERTIME = 4;
            const Int32 FLD_ISREPEAT = 5;
            const Int32 FLD_REMARKS = 6;
            const Int32 FLD_ISREMOVED = 7;

            BDMDTaskEntity bDMDTaskEntity = new BDMDTaskEntity();

            bDMDTaskEntity.TaskID = reader.GetInt64(FLD_TASKID);
            bDMDTaskEntity.TaskCategoryID = reader.GetInt64(FLD_TASKCATEGORYID);
            bDMDTaskEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REQUIREDSTANDARDTIME)) { bDMDTaskEntity.RequiredStandardTime = null; } else { bDMDTaskEntity.RequiredStandardTime = reader.GetInt32(FLD_REQUIREDSTANDARDTIME); }
            if (reader.IsDBNull(FLD_REMINDERTIME)) { bDMDTaskEntity.ReminderTime = null; } else { bDMDTaskEntity.ReminderTime = reader.GetInt32(FLD_REMINDERTIME); }
            bDMDTaskEntity.IsRepeat = reader.GetBoolean(FLD_ISREPEAT);
            if (reader.IsDBNull(FLD_REMARKS)) { bDMDTaskEntity.Remarks = String.Empty; } else { bDMDTaskEntity.Remarks = reader.GetString(FLD_REMARKS); }
            bDMDTaskEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return bDMDTaskEntity;
        }
    }
}
