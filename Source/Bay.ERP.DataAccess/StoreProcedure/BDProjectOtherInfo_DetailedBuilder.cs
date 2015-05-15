// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Dec-2011, 02:17:33




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectOtherInfo_DetailedBuilder : IEntityBuilder<BDProjectOtherInfo_DetailedEntity>
    {
        IList<BDProjectOtherInfo_DetailedEntity> IEntityBuilder<BDProjectOtherInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectOtherInfo_DetailedEntity> BDProjectOtherInfo_DetailedEntityList = new List<BDProjectOtherInfo_DetailedEntity>();

            while (reader.Read())
            {
                BDProjectOtherInfo_DetailedEntityList.Add(((IEntityBuilder<BDProjectOtherInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (BDProjectOtherInfo_DetailedEntityList.Count > 0) ? BDProjectOtherInfo_DetailedEntityList : null;
        }

        BDProjectOtherInfo_DetailedEntity IEntityBuilder<BDProjectOtherInfo_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTOTHERINFOID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_TBA = 2;
            const Int32 FLD_TBAUNITID = 3;
            const Int32 FLD_FAR = 4;
            const Int32 FLD_FIA = 5;
            const Int32 FLD_FIAUNITID = 6;
            const Int32 FLD_GSA = 7;
            const Int32 FLD_GSAUNITID = 8;
            const Int32 FLD_GROUNDCOVERAGE = 9;
            const Int32 FLD_DATEOFAGREEMENT = 10;
            const Int32 FLD_DATEOFHANDOVER = 11;
            const Int32 FLD_DELAYCLAUSE = 12;
            const Int32 FLD_PROJECTNAME = 13;
            const Int32 FLD_TBAUNITNAME = 14;
            const Int32 FLD_FIAUNITNAME = 15;
            const Int32 FLD_GSAUNITNAME = 16;
            const Int32 FLD_ROWNUMBER = 17;

            BDProjectOtherInfo_DetailedEntity bDProjectOtherInfo_DetailedEntity = new BDProjectOtherInfo_DetailedEntity();

            bDProjectOtherInfo_DetailedEntity.ProjectOtherInfoID = reader.GetInt64(FLD_PROJECTOTHERINFOID);
            bDProjectOtherInfo_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_TBA)) { bDProjectOtherInfo_DetailedEntity.TBA = null; } else { bDProjectOtherInfo_DetailedEntity.TBA = reader.GetDecimal(FLD_TBA); }
            if (reader.IsDBNull(FLD_TBAUNITID)) { bDProjectOtherInfo_DetailedEntity.TBAUnitID = null; } else { bDProjectOtherInfo_DetailedEntity.TBAUnitID = reader.GetInt64(FLD_TBAUNITID); }
            if (reader.IsDBNull(FLD_FAR)) { bDProjectOtherInfo_DetailedEntity.FAR = null; } else { bDProjectOtherInfo_DetailedEntity.FAR = reader.GetDecimal(FLD_FAR); }
            if (reader.IsDBNull(FLD_FIA)) { bDProjectOtherInfo_DetailedEntity.FIA = null; } else { bDProjectOtherInfo_DetailedEntity.FIA = reader.GetDecimal(FLD_FIA); }
            if (reader.IsDBNull(FLD_FIAUNITID)) { bDProjectOtherInfo_DetailedEntity.FIAUnitID = null; } else { bDProjectOtherInfo_DetailedEntity.FIAUnitID = reader.GetInt64(FLD_FIAUNITID); }
            if (reader.IsDBNull(FLD_GSA)) { bDProjectOtherInfo_DetailedEntity.GSA = null; } else { bDProjectOtherInfo_DetailedEntity.GSA = reader.GetDecimal(FLD_GSA); }
            if (reader.IsDBNull(FLD_GSAUNITID)) { bDProjectOtherInfo_DetailedEntity.GSAUnitID = null; } else { bDProjectOtherInfo_DetailedEntity.GSAUnitID = reader.GetInt64(FLD_GSAUNITID); }
            if (reader.IsDBNull(FLD_GROUNDCOVERAGE)) { bDProjectOtherInfo_DetailedEntity.GroundCoverage = String.Empty; } else { bDProjectOtherInfo_DetailedEntity.GroundCoverage = reader.GetString(FLD_GROUNDCOVERAGE); }
            if (reader.IsDBNull(FLD_DATEOFAGREEMENT)) { bDProjectOtherInfo_DetailedEntity.DateOfAgreement = null; } else { bDProjectOtherInfo_DetailedEntity.DateOfAgreement = reader.GetDateTime(FLD_DATEOFAGREEMENT); }
            if (reader.IsDBNull(FLD_DATEOFHANDOVER)) { bDProjectOtherInfo_DetailedEntity.DateOfHandover = null; } else { bDProjectOtherInfo_DetailedEntity.DateOfHandover = reader.GetDateTime(FLD_DATEOFHANDOVER); }
            if (reader.IsDBNull(FLD_DELAYCLAUSE)) { bDProjectOtherInfo_DetailedEntity.DelayClause = String.Empty; } else { bDProjectOtherInfo_DetailedEntity.DelayClause = reader.GetString(FLD_DELAYCLAUSE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { bDProjectOtherInfo_DetailedEntity.ProjectName = String.Empty; } else { bDProjectOtherInfo_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_TBAUNITNAME)) { bDProjectOtherInfo_DetailedEntity.TBAUnitName = String.Empty; } else { bDProjectOtherInfo_DetailedEntity.TBAUnitName = reader.GetString(FLD_TBAUNITNAME); }
            if (reader.IsDBNull(FLD_FIAUNITNAME)) { bDProjectOtherInfo_DetailedEntity.FIAUnitName = String.Empty; } else { bDProjectOtherInfo_DetailedEntity.FIAUnitName = reader.GetString(FLD_FIAUNITNAME); }
            if (reader.IsDBNull(FLD_GSAUNITNAME)) { bDProjectOtherInfo_DetailedEntity.GSAUnitName = String.Empty; } else { bDProjectOtherInfo_DetailedEntity.GSAUnitName = reader.GetString(FLD_GSAUNITNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { bDProjectOtherInfo_DetailedEntity.RowNumber = null; } else { bDProjectOtherInfo_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return bDProjectOtherInfo_DetailedEntity;
        }
    }
}
