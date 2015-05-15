// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Mar-2012, 03:28:59




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectCollectedDocumentInfoBuilder : IEntityBuilder<BDProjectCollectedDocumentInfoEntity>
    {
        IList<BDProjectCollectedDocumentInfoEntity> IEntityBuilder<BDProjectCollectedDocumentInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectCollectedDocumentInfoEntity> BDProjectCollectedDocumentInfoEntityList = new List<BDProjectCollectedDocumentInfoEntity>();

            while (reader.Read())
            {
                BDProjectCollectedDocumentInfoEntityList.Add(((IEntityBuilder<BDProjectCollectedDocumentInfoEntity>)this).BuildEntity(reader));
            }

            return (BDProjectCollectedDocumentInfoEntityList.Count > 0) ? BDProjectCollectedDocumentInfoEntityList : null;
        }

        BDProjectCollectedDocumentInfoEntity IEntityBuilder<BDProjectCollectedDocumentInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTCOLLECTEDDOCUMENTINFOID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_PROJECTDOCUMENTID = 2;
            const Int32 FLD_STARTDATE = 3;
            const Int32 FLD_REQUIREDTIME = 4;
            const Int32 FLD_REQUIREDTIMESTANDARDTIMEUNITID = 5;
            const Int32 FLD_REMINDERBEFORE = 6;
            const Int32 FLD_REMINDERBEFORESTANDARDTIMEUNITID = 7;
            const Int32 FLD_PROJECTCOLLECTEDDOCUMENTSTATUSID = 8;
            const Int32 FLD_REMARKS = 9;

            BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity = new BDProjectCollectedDocumentInfoEntity();

            bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentInfoID = reader.GetInt64(FLD_PROJECTCOLLECTEDDOCUMENTINFOID);
            bDProjectCollectedDocumentInfoEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectCollectedDocumentInfoEntity.ProjectDocumentID = reader.GetInt64(FLD_PROJECTDOCUMENTID);
            if (reader.IsDBNull(FLD_STARTDATE)) { bDProjectCollectedDocumentInfoEntity.StartDate = null; } else { bDProjectCollectedDocumentInfoEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }
            if (reader.IsDBNull(FLD_REQUIREDTIME)) { bDProjectCollectedDocumentInfoEntity.RequiredTime = null; } else { bDProjectCollectedDocumentInfoEntity.RequiredTime = reader.GetInt32(FLD_REQUIREDTIME); }
            if (reader.IsDBNull(FLD_REQUIREDTIMESTANDARDTIMEUNITID)) { bDProjectCollectedDocumentInfoEntity.RequiredTimeStandardTimeUnitID = null; } else { bDProjectCollectedDocumentInfoEntity.RequiredTimeStandardTimeUnitID = reader.GetInt64(FLD_REQUIREDTIMESTANDARDTIMEUNITID); }
            if (reader.IsDBNull(FLD_REMINDERBEFORE)) { bDProjectCollectedDocumentInfoEntity.ReminderBefore = null; } else { bDProjectCollectedDocumentInfoEntity.ReminderBefore = reader.GetInt32(FLD_REMINDERBEFORE); }
            if (reader.IsDBNull(FLD_REMINDERBEFORESTANDARDTIMEUNITID)) { bDProjectCollectedDocumentInfoEntity.ReminderBeforeStandardTimeUnitID = null; } else { bDProjectCollectedDocumentInfoEntity.ReminderBeforeStandardTimeUnitID = reader.GetInt64(FLD_REMINDERBEFORESTANDARDTIMEUNITID); }
            if (reader.IsDBNull(FLD_PROJECTCOLLECTEDDOCUMENTSTATUSID)) { bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentStatusID = null; } else { bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentStatusID = reader.GetInt64(FLD_PROJECTCOLLECTEDDOCUMENTSTATUSID); }
            if (reader.IsDBNull(FLD_REMARKS)) { bDProjectCollectedDocumentInfoEntity.Remarks = String.Empty; } else { bDProjectCollectedDocumentInfoEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return bDProjectCollectedDocumentInfoEntity;
        }
    }
}
