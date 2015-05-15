// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDMDTaskCategoryBuilder : IEntityBuilder<BDMDTaskCategoryEntity>
    {
        IList<BDMDTaskCategoryEntity> IEntityBuilder<BDMDTaskCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<BDMDTaskCategoryEntity> BDMDTaskCategoryEntityList = new List<BDMDTaskCategoryEntity>();

            while (reader.Read())
            {
                BDMDTaskCategoryEntityList.Add(((IEntityBuilder<BDMDTaskCategoryEntity>)this).BuildEntity(reader));
            }

            return (BDMDTaskCategoryEntityList.Count > 0) ? BDMDTaskCategoryEntityList : null;
        }

        BDMDTaskCategoryEntity IEntityBuilder<BDMDTaskCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TASKCATEGORYID = 0;
            const Int32 FLD_PARENTTASKCATEGORYID = 1;
            const Int32 FLD_DEPARTMENTID = 2;
            const Int32 FLD_NAME = 3;
            const Int32 FLD_ISREMOVED = 4;

            BDMDTaskCategoryEntity bDMDTaskCategoryEntity = new BDMDTaskCategoryEntity();

            bDMDTaskCategoryEntity.TaskCategoryID = reader.GetInt64(FLD_TASKCATEGORYID);
            if (reader.IsDBNull(FLD_PARENTTASKCATEGORYID)) { bDMDTaskCategoryEntity.ParentTaskCategoryID = null; } else { bDMDTaskCategoryEntity.ParentTaskCategoryID = reader.GetInt64(FLD_PARENTTASKCATEGORYID); }
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { bDMDTaskCategoryEntity.DepartmentID = null; } else { bDMDTaskCategoryEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }
            bDMDTaskCategoryEntity.Name = reader.GetString(FLD_NAME);
            bDMDTaskCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return bDMDTaskCategoryEntity;
        }
    }
}
