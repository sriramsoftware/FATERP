// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectHistoryBuilder : IEntityBuilder<BDProjectHistoryEntity>
    {
        IList<BDProjectHistoryEntity> IEntityBuilder<BDProjectHistoryEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectHistoryEntity> BDProjectHistoryEntityList = new List<BDProjectHistoryEntity>();

            while (reader.Read())
            {
                BDProjectHistoryEntityList.Add(((IEntityBuilder<BDProjectHistoryEntity>)this).BuildEntity(reader));
            }

            return (BDProjectHistoryEntityList.Count > 0) ? BDProjectHistoryEntityList : null;
        }

        BDProjectHistoryEntity IEntityBuilder<BDProjectHistoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTHISTORYID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_HISTORYDATE = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_ENTRYDATE = 5;
            const Int32 FLD_ISREMOVED = 6;

            BDProjectHistoryEntity bDProjectHistoryEntity = new BDProjectHistoryEntity();

            bDProjectHistoryEntity.ProjectHistoryID = reader.GetInt64(FLD_PROJECTHISTORYID);
            bDProjectHistoryEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectHistoryEntity.HistoryDate = reader.GetDateTime(FLD_HISTORYDATE);
            bDProjectHistoryEntity.Description = reader.GetString(FLD_DESCRIPTION);
            if (reader.IsDBNull(FLD_REMARKS)) { bDProjectHistoryEntity.Remarks = String.Empty; } else { bDProjectHistoryEntity.Remarks = reader.GetString(FLD_REMARKS); }
            bDProjectHistoryEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            bDProjectHistoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return bDProjectHistoryEntity;
        }
    }
}
