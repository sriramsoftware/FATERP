// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-May-2012, 03:43:24




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProject_CustomBuilder : IEntityBuilder<BDProject_CustomEntity>
    {
        IList<BDProject_CustomEntity> IEntityBuilder<BDProject_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProject_CustomEntity> BDProject_CustomEntityList = new List<BDProject_CustomEntity>();

            while (reader.Read())
            {
                BDProject_CustomEntityList.Add(((IEntityBuilder<BDProject_CustomEntity>)this).BuildEntity(reader));
            }

            return (BDProject_CustomEntityList.Count > 0) ? BDProject_CustomEntityList : null;
        }

        BDProject_CustomEntity IEntityBuilder<BDProject_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTID = 0;
            const Int32 FLD_PROJECTCODE = 1;
            const Int32 FLD_PROJECTNAME = 2;
            const Int32 FLD_LANDAREAKATHA = 3;
            const Int32 FLD_LANDAREASFT = 4;
            const Int32 FLD_NOOFSTORIED = 5;
            const Int32 FLD_NOOFBASEMENT = 6;
            const Int32 FLD_DESCRIPTION = 7;
            const Int32 FLD_CLIENTPERCENTAGE = 8;
            const Int32 FLD_COMPANYPERCENTAGE = 9;
            const Int32 FLD_PROJECTCATEGORYID = 10;
            const Int32 FLD_PROJECTSTATUSID = 11;
            const Int32 FLD_ISREMOVED = 12;
            const Int32 FLD_PROJECTSTATUSNAME = 13;
            const Int32 FLD_PROJECTCATEGORYNAME = 14;

            BDProject_CustomEntity bDProject_CustomEntity = new BDProject_CustomEntity();

            bDProject_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProject_CustomEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            bDProject_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_LANDAREAKATHA)) { bDProject_CustomEntity.LandAreaKatha = null; } else { bDProject_CustomEntity.LandAreaKatha = reader.GetDecimal(FLD_LANDAREAKATHA); }
            if (reader.IsDBNull(FLD_LANDAREASFT)) { bDProject_CustomEntity.LandAreaSft = null; } else { bDProject_CustomEntity.LandAreaSft = reader.GetDecimal(FLD_LANDAREASFT); }
            if (reader.IsDBNull(FLD_NOOFSTORIED)) { bDProject_CustomEntity.NoOfStoried = null; } else { bDProject_CustomEntity.NoOfStoried = reader.GetInt32(FLD_NOOFSTORIED); }
            if (reader.IsDBNull(FLD_NOOFBASEMENT)) { bDProject_CustomEntity.NoOfBasement = null; } else { bDProject_CustomEntity.NoOfBasement = reader.GetInt32(FLD_NOOFBASEMENT); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDProject_CustomEntity.Description = String.Empty; } else { bDProject_CustomEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_CLIENTPERCENTAGE)) { bDProject_CustomEntity.ClientPercentage = null; } else { bDProject_CustomEntity.ClientPercentage = reader.GetDecimal(FLD_CLIENTPERCENTAGE); }
            if (reader.IsDBNull(FLD_COMPANYPERCENTAGE)) { bDProject_CustomEntity.CompanyPercentage = null; } else { bDProject_CustomEntity.CompanyPercentage = reader.GetDecimal(FLD_COMPANYPERCENTAGE); }
            bDProject_CustomEntity.ProjectCategoryID = reader.GetInt64(FLD_PROJECTCATEGORYID);
            bDProject_CustomEntity.ProjectStatusID = reader.GetInt64(FLD_PROJECTSTATUSID);
            bDProject_CustomEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_PROJECTSTATUSNAME)) { bDProject_CustomEntity.ProjectStatusName = String.Empty; } else { bDProject_CustomEntity.ProjectStatusName = reader.GetString(FLD_PROJECTSTATUSNAME); }
            if (reader.IsDBNull(FLD_PROJECTCATEGORYNAME)) { bDProject_CustomEntity.ProjectCategoryName = String.Empty; } else { bDProject_CustomEntity.ProjectCategoryName = reader.GetString(FLD_PROJECTCATEGORYNAME); }

            return bDProject_CustomEntity;
        }
    }
}
