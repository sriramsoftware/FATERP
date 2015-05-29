// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-May-2015, 10:52:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectBuilder : IEntityBuilder<BDProjectEntity>
    {
        IList<BDProjectEntity> IEntityBuilder<BDProjectEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectEntity> BDProjectEntityList = new List<BDProjectEntity>();

            while (reader.Read())
            {
                BDProjectEntityList.Add(((IEntityBuilder<BDProjectEntity>)this).BuildEntity(reader));
            }

            return (BDProjectEntityList.Count > 0) ? BDProjectEntityList : null;
        }

        BDProjectEntity IEntityBuilder<BDProjectEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTID = 0;
            const Int32 FLD_OPERATORID = 1;
            const Int32 FLD_ZONEID = 2;
            const Int32 FLD_PROJECTCODE = 3;
            const Int32 FLD_PROJECTNAME = 4;
            const Int32 FLD_LANDAREAKATHA = 5;
            const Int32 FLD_LANDAREASFT = 6;
            const Int32 FLD_ROADWIDTH = 7;
            const Int32 FLD_ROADWIDTHUNITID = 8;
            const Int32 FLD_NOOFSTORIED = 9;
            const Int32 FLD_NOOFBASEMENT = 10;
            const Int32 FLD_DESCRIPTION = 11;
            const Int32 FLD_BSC = 12;
            const Int32 FLD_CLIENTPERCENTAGE = 13;
            const Int32 FLD_COMPANYPERCENTAGE = 14;
            const Int32 FLD_PROJECTCATEGORYID = 15;
            const Int32 FLD_PROJECTSTATUSID = 16;
            const Int32 FLD_ISREMOVED = 17;

            BDProjectEntity bDProjectEntity = new BDProjectEntity();

            bDProjectEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectEntity.OperatorID = reader.GetInt64(FLD_OPERATORID);
            bDProjectEntity.ZoneID = reader.GetInt64(FLD_ZONEID);
            bDProjectEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            bDProjectEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_LANDAREAKATHA)) { bDProjectEntity.LandAreaKatha = null; } else { bDProjectEntity.LandAreaKatha = reader.GetDecimal(FLD_LANDAREAKATHA); }
            if (reader.IsDBNull(FLD_LANDAREASFT)) { bDProjectEntity.LandAreaSft = null; } else { bDProjectEntity.LandAreaSft = reader.GetDecimal(FLD_LANDAREASFT); }
            if (reader.IsDBNull(FLD_ROADWIDTH)) { bDProjectEntity.RoadWidth = null; } else { bDProjectEntity.RoadWidth = reader.GetDecimal(FLD_ROADWIDTH); }
            if (reader.IsDBNull(FLD_ROADWIDTHUNITID)) { bDProjectEntity.RoadWidthUnitID = null; } else { bDProjectEntity.RoadWidthUnitID = reader.GetInt64(FLD_ROADWIDTHUNITID); }
            if (reader.IsDBNull(FLD_NOOFSTORIED)) { bDProjectEntity.NoOfStoried = null; } else { bDProjectEntity.NoOfStoried = reader.GetInt32(FLD_NOOFSTORIED); }
            if (reader.IsDBNull(FLD_NOOFBASEMENT)) { bDProjectEntity.NoOfBasement = null; } else { bDProjectEntity.NoOfBasement = reader.GetInt32(FLD_NOOFBASEMENT); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDProjectEntity.Description = String.Empty; } else { bDProjectEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_BSC)) { bDProjectEntity.BSC = String.Empty; } else { bDProjectEntity.BSC = reader.GetString(FLD_BSC); }
            if (reader.IsDBNull(FLD_CLIENTPERCENTAGE)) { bDProjectEntity.ClientPercentage = null; } else { bDProjectEntity.ClientPercentage = reader.GetDecimal(FLD_CLIENTPERCENTAGE); }
            if (reader.IsDBNull(FLD_COMPANYPERCENTAGE)) { bDProjectEntity.CompanyPercentage = null; } else { bDProjectEntity.CompanyPercentage = reader.GetDecimal(FLD_COMPANYPERCENTAGE); }
            bDProjectEntity.ProjectCategoryID = reader.GetInt64(FLD_PROJECTCATEGORYID);
            bDProjectEntity.ProjectStatusID = reader.GetInt64(FLD_PROJECTSTATUSID);
            bDProjectEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return bDProjectEntity;
        }
    }
}
