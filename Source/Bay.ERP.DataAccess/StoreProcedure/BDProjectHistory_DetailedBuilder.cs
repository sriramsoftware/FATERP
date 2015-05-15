// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 03:03:39




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectHistory_DetailedBuilder : IEntityBuilder<BDProjectHistory_DetailedEntity>
    {
        IList<BDProjectHistory_DetailedEntity> IEntityBuilder<BDProjectHistory_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectHistory_DetailedEntity> BDProjectHistory_DetailedEntityList = new List<BDProjectHistory_DetailedEntity>();

            while (reader.Read())
            {
                BDProjectHistory_DetailedEntityList.Add(((IEntityBuilder<BDProjectHistory_DetailedEntity>)this).BuildEntity(reader));
            }

            return (BDProjectHistory_DetailedEntityList.Count > 0) ? BDProjectHistory_DetailedEntityList : null;
        }

        BDProjectHistory_DetailedEntity IEntityBuilder<BDProjectHistory_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTHISTORYID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_HISTORYDATE = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_ENTRYDATE = 5;
            const Int32 FLD_ISREMOVED = 6;
            const Int32 FLD_PROJECTNAME = 7;
            const Int32 FLD_ROWNUMBER = 8;

            BDProjectHistory_DetailedEntity bDProjectHistory_DetailedEntity = new BDProjectHistory_DetailedEntity();

            bDProjectHistory_DetailedEntity.ProjectHistoryID = reader.GetInt64(FLD_PROJECTHISTORYID);
            bDProjectHistory_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectHistory_DetailedEntity.HistoryDate = reader.GetDateTime(FLD_HISTORYDATE);
            bDProjectHistory_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION);
            if (reader.IsDBNull(FLD_REMARKS)) { bDProjectHistory_DetailedEntity.Remarks = String.Empty; } else { bDProjectHistory_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            bDProjectHistory_DetailedEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            bDProjectHistory_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_PROJECTNAME)) { bDProjectHistory_DetailedEntity.ProjectName = String.Empty; } else { bDProjectHistory_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { bDProjectHistory_DetailedEntity.RowNumber = null; } else { bDProjectHistory_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return bDProjectHistory_DetailedEntity;
        }
    }
}
