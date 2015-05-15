// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-May-2012, 02:36:46




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProject_DetailedBuilder : IEntityBuilder<BDProject_DetailedEntity>
    {
        IList<BDProject_DetailedEntity> IEntityBuilder<BDProject_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProject_DetailedEntity> BDProject_DetailedEntityList = new List<BDProject_DetailedEntity>();

            while (reader.Read())
            {
                BDProject_DetailedEntityList.Add(((IEntityBuilder<BDProject_DetailedEntity>)this).BuildEntity(reader));
            }

            return (BDProject_DetailedEntityList.Count > 0) ? BDProject_DetailedEntityList : null;
        }

        BDProject_DetailedEntity IEntityBuilder<BDProject_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_ROWNUMBER = 15;

            BDProject_DetailedEntity bDProject_DetailedEntity = new BDProject_DetailedEntity();

            bDProject_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProject_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            bDProject_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_LANDAREAKATHA)) { bDProject_DetailedEntity.LandAreaKatha = null; } else { bDProject_DetailedEntity.LandAreaKatha = reader.GetDecimal(FLD_LANDAREAKATHA); }
            if (reader.IsDBNull(FLD_LANDAREASFT)) { bDProject_DetailedEntity.LandAreaSft = null; } else { bDProject_DetailedEntity.LandAreaSft = reader.GetDecimal(FLD_LANDAREASFT); }
            if (reader.IsDBNull(FLD_NOOFSTORIED)) { bDProject_DetailedEntity.NoOfStoried = null; } else { bDProject_DetailedEntity.NoOfStoried = reader.GetInt32(FLD_NOOFSTORIED); }
            if (reader.IsDBNull(FLD_NOOFBASEMENT)) { bDProject_DetailedEntity.NoOfBasement = null; } else { bDProject_DetailedEntity.NoOfBasement = reader.GetInt32(FLD_NOOFBASEMENT); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDProject_DetailedEntity.Description = String.Empty; } else { bDProject_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_CLIENTPERCENTAGE)) { bDProject_DetailedEntity.ClientPercentage = null; } else { bDProject_DetailedEntity.ClientPercentage = reader.GetDecimal(FLD_CLIENTPERCENTAGE); }
            if (reader.IsDBNull(FLD_COMPANYPERCENTAGE)) { bDProject_DetailedEntity.CompanyPercentage = null; } else { bDProject_DetailedEntity.CompanyPercentage = reader.GetDecimal(FLD_COMPANYPERCENTAGE); }
            bDProject_DetailedEntity.ProjectCategoryID = reader.GetInt64(FLD_PROJECTCATEGORYID);
            bDProject_DetailedEntity.ProjectStatusID = reader.GetInt64(FLD_PROJECTSTATUSID);
            bDProject_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_PROJECTSTATUSNAME)) { bDProject_DetailedEntity.ProjectStatusName = String.Empty; } else { bDProject_DetailedEntity.ProjectStatusName = reader.GetString(FLD_PROJECTSTATUSNAME); }
            if (reader.IsDBNull(FLD_PROJECTCATEGORYNAME)) { bDProject_DetailedEntity.ProjectCategoryName = String.Empty; } else { bDProject_DetailedEntity.ProjectCategoryName = reader.GetString(FLD_PROJECTCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { bDProject_DetailedEntity.RowNumber = null; } else { bDProject_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return bDProject_DetailedEntity;
        }
    }
}
