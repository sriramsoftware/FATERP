// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jan-2012, 09:58:11




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectHistory_RPTBuilder : IEntityBuilder<BDProjectHistory_RPTEntity>
    {
        IList<BDProjectHistory_RPTEntity> IEntityBuilder<BDProjectHistory_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectHistory_RPTEntity> BDProjectHistory_RPTEntityList = new List<BDProjectHistory_RPTEntity>();

            while (reader.Read())
            {
                BDProjectHistory_RPTEntityList.Add(((IEntityBuilder<BDProjectHistory_RPTEntity>)this).BuildEntity(reader));
            }

            return (BDProjectHistory_RPTEntityList.Count > 0) ? BDProjectHistory_RPTEntityList : null;
        }

        BDProjectHistory_RPTEntity IEntityBuilder<BDProjectHistory_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTID = 0;
            const Int32 FLD_PROJECTCODE = 1;
            const Int32 FLD_PROJECTNAME = 2;
            const Int32 FLD_LANDAREAKATHA = 3;
            const Int32 FLD_LANDAREASFT = 4;
            const Int32 FLD_PROJECTHISTORYID = 5;
            const Int32 FLD_HISTORYDATE = 6;
            const Int32 FLD_DESCRIPTION = 7;
            const Int32 FLD_REMARKS = 8;
            const Int32 FLD_ENTRYDATE = 9;

            BDProjectHistory_RPTEntity bDProjectHistory_RPTEntity = new BDProjectHistory_RPTEntity();

            bDProjectHistory_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectHistory_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            bDProjectHistory_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_LANDAREAKATHA)) { bDProjectHistory_RPTEntity.LandAreaKatha = null; } else { bDProjectHistory_RPTEntity.LandAreaKatha = reader.GetDecimal(FLD_LANDAREAKATHA); }
            if (reader.IsDBNull(FLD_LANDAREASFT)) { bDProjectHistory_RPTEntity.LandAreaSft = null; } else { bDProjectHistory_RPTEntity.LandAreaSft = reader.GetDecimal(FLD_LANDAREASFT); }
            bDProjectHistory_RPTEntity.ProjectHistoryID = reader.GetInt64(FLD_PROJECTHISTORYID);
            bDProjectHistory_RPTEntity.HistoryDate = reader.GetDateTime(FLD_HISTORYDATE);
            bDProjectHistory_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION);
            if (reader.IsDBNull(FLD_REMARKS)) { bDProjectHistory_RPTEntity.Remarks = String.Empty; } else { bDProjectHistory_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            bDProjectHistory_RPTEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);

            return bDProjectHistory_RPTEntity;
        }
    }
}
