// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectOtherInfoBuilder : IEntityBuilder<BDProjectOtherInfoEntity>
    {
        IList<BDProjectOtherInfoEntity> IEntityBuilder<BDProjectOtherInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectOtherInfoEntity> BDProjectOtherInfoEntityList = new List<BDProjectOtherInfoEntity>();

            while (reader.Read())
            {
                BDProjectOtherInfoEntityList.Add(((IEntityBuilder<BDProjectOtherInfoEntity>)this).BuildEntity(reader));
            }

            return (BDProjectOtherInfoEntityList.Count > 0) ? BDProjectOtherInfoEntityList : null;
        }

        BDProjectOtherInfoEntity IEntityBuilder<BDProjectOtherInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTOTHERINFOID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_TBA = 2;
            const Int32 FLD_TBAUNITID = 3;
            const Int32 FLD_FAR = 4;
            const Int32 FLD_FARBONUS = 5;
            const Int32 FLD_FIA = 6;
            const Int32 FLD_FIAUNITID = 7;
            const Int32 FLD_FIAACHIEVED = 8;
            const Int32 FLD_FIAACHIEVEDUNITID = 9;
            const Int32 FLD_GSA = 10;
            const Int32 FLD_GSAUNITID = 11;
            const Int32 FLD_MGCPERCENTAGES = 12;
            const Int32 FLD_MGCAREA = 13;
            const Int32 FLD_MGCAREAUNITID = 14;
            const Int32 FLD_GROUNDCOVERAGE = 15;
            const Int32 FLD_DATEOFAGREEMENT = 16;
            const Int32 FLD_DATEOFHANDOVER = 17;
            const Int32 FLD_DELAYCLAUSE = 18;

            BDProjectOtherInfoEntity bDProjectOtherInfoEntity = new BDProjectOtherInfoEntity();

            bDProjectOtherInfoEntity.ProjectOtherInfoID = reader.GetInt64(FLD_PROJECTOTHERINFOID);
            bDProjectOtherInfoEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_TBA)) { bDProjectOtherInfoEntity.TBA = null; } else { bDProjectOtherInfoEntity.TBA = reader.GetDecimal(FLD_TBA); }
            if (reader.IsDBNull(FLD_TBAUNITID)) { bDProjectOtherInfoEntity.TBAUnitID = null; } else { bDProjectOtherInfoEntity.TBAUnitID = reader.GetInt64(FLD_TBAUNITID); }
            if (reader.IsDBNull(FLD_FAR)) { bDProjectOtherInfoEntity.FAR = null; } else { bDProjectOtherInfoEntity.FAR = reader.GetDecimal(FLD_FAR); }
            if (reader.IsDBNull(FLD_FARBONUS)) { bDProjectOtherInfoEntity.FARBonus = null; } else { bDProjectOtherInfoEntity.FARBonus = reader.GetDecimal(FLD_FARBONUS); }
            if (reader.IsDBNull(FLD_FIA)) { bDProjectOtherInfoEntity.FIA = null; } else { bDProjectOtherInfoEntity.FIA = reader.GetDecimal(FLD_FIA); }
            if (reader.IsDBNull(FLD_FIAUNITID)) { bDProjectOtherInfoEntity.FIAUnitID = null; } else { bDProjectOtherInfoEntity.FIAUnitID = reader.GetInt64(FLD_FIAUNITID); }
            if (reader.IsDBNull(FLD_FIAACHIEVED)) { bDProjectOtherInfoEntity.FIAAchieved = null; } else { bDProjectOtherInfoEntity.FIAAchieved = reader.GetDecimal(FLD_FIAACHIEVED); }
            if (reader.IsDBNull(FLD_FIAACHIEVEDUNITID)) { bDProjectOtherInfoEntity.FIAAchievedUnitID = null; } else { bDProjectOtherInfoEntity.FIAAchievedUnitID = reader.GetInt64(FLD_FIAACHIEVEDUNITID); }
            if (reader.IsDBNull(FLD_GSA)) { bDProjectOtherInfoEntity.GSA = null; } else { bDProjectOtherInfoEntity.GSA = reader.GetDecimal(FLD_GSA); }
            if (reader.IsDBNull(FLD_GSAUNITID)) { bDProjectOtherInfoEntity.GSAUnitID = null; } else { bDProjectOtherInfoEntity.GSAUnitID = reader.GetInt64(FLD_GSAUNITID); }
            if (reader.IsDBNull(FLD_MGCPERCENTAGES)) { bDProjectOtherInfoEntity.MGCPercentages = null; } else { bDProjectOtherInfoEntity.MGCPercentages = reader.GetDecimal(FLD_MGCPERCENTAGES); }
            if (reader.IsDBNull(FLD_MGCAREA)) { bDProjectOtherInfoEntity.MGCArea = null; } else { bDProjectOtherInfoEntity.MGCArea = reader.GetDecimal(FLD_MGCAREA); }
            if (reader.IsDBNull(FLD_MGCAREAUNITID)) { bDProjectOtherInfoEntity.MGCAreaUnitID = null; } else { bDProjectOtherInfoEntity.MGCAreaUnitID = reader.GetInt64(FLD_MGCAREAUNITID); }
            if (reader.IsDBNull(FLD_GROUNDCOVERAGE)) { bDProjectOtherInfoEntity.GroundCoverage = String.Empty; } else { bDProjectOtherInfoEntity.GroundCoverage = reader.GetString(FLD_GROUNDCOVERAGE); }
            if (reader.IsDBNull(FLD_DATEOFAGREEMENT)) { bDProjectOtherInfoEntity.DateOfAgreement = null; } else { bDProjectOtherInfoEntity.DateOfAgreement = reader.GetDateTime(FLD_DATEOFAGREEMENT); }
            if (reader.IsDBNull(FLD_DATEOFHANDOVER)) { bDProjectOtherInfoEntity.DateOfHandover = null; } else { bDProjectOtherInfoEntity.DateOfHandover = reader.GetDateTime(FLD_DATEOFHANDOVER); }
            if (reader.IsDBNull(FLD_DELAYCLAUSE)) { bDProjectOtherInfoEntity.DelayClause = String.Empty; } else { bDProjectOtherInfoEntity.DelayClause = reader.GetString(FLD_DELAYCLAUSE); }

            return bDProjectOtherInfoEntity;
        }
    }
}
