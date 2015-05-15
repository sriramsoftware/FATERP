// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-May-2012, 04:25:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectStatusDistinct_CustomBuilder : IEntityBuilder<BDProjectStatusDistinct_CustomEntity>
    {
        IList<BDProjectStatusDistinct_CustomEntity> IEntityBuilder<BDProjectStatusDistinct_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectStatusDistinct_CustomEntity> BDProjectStatusDistinct_CustomEntityList = new List<BDProjectStatusDistinct_CustomEntity>();

            while (reader.Read())
            {
                BDProjectStatusDistinct_CustomEntityList.Add(((IEntityBuilder<BDProjectStatusDistinct_CustomEntity>)this).BuildEntity(reader));
            }

            return (BDProjectStatusDistinct_CustomEntityList.Count > 0) ? BDProjectStatusDistinct_CustomEntityList : null;
        }

        BDProjectStatusDistinct_CustomEntity IEntityBuilder<BDProjectStatusDistinct_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTSTATUSID = 0;
            const Int32 FLD_PROJECTCATEGORYID = 1;
            const Int32 FLD_PROJECTSTATUSNAME = 2;
            const Int32 FLD_PROJECTCATEGORYNAME = 3;

            BDProjectStatusDistinct_CustomEntity bDProjectStatusDistinct_CustomEntity = new BDProjectStatusDistinct_CustomEntity();

            bDProjectStatusDistinct_CustomEntity.ProjectStatusID = reader.GetInt64(FLD_PROJECTSTATUSID);
            bDProjectStatusDistinct_CustomEntity.ProjectCategoryID = reader.GetInt64(FLD_PROJECTCATEGORYID);
            if (reader.IsDBNull(FLD_PROJECTSTATUSNAME)) { bDProjectStatusDistinct_CustomEntity.ProjectStatusName = String.Empty; } else { bDProjectStatusDistinct_CustomEntity.ProjectStatusName = reader.GetString(FLD_PROJECTSTATUSNAME); }
            if (reader.IsDBNull(FLD_PROJECTCATEGORYNAME)) { bDProjectStatusDistinct_CustomEntity.ProjectCategoryName = String.Empty; } else { bDProjectStatusDistinct_CustomEntity.ProjectCategoryName = reader.GetString(FLD_PROJECTCATEGORYNAME); }

            return bDProjectStatusDistinct_CustomEntity;
        }
    }
}
