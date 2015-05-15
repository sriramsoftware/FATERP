// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDProjectCategoryBuilder : IEntityBuilder<MDProjectCategoryEntity>
    {
        IList<MDProjectCategoryEntity> IEntityBuilder<MDProjectCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDProjectCategoryEntity> MDProjectCategoryEntityList = new List<MDProjectCategoryEntity>();

            while (reader.Read())
            {
                MDProjectCategoryEntityList.Add(((IEntityBuilder<MDProjectCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDProjectCategoryEntityList.Count > 0) ? MDProjectCategoryEntityList : null;
        }

        MDProjectCategoryEntity IEntityBuilder<MDProjectCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDProjectCategoryEntity mDProjectCategoryEntity = new MDProjectCategoryEntity();

            mDProjectCategoryEntity.ProjectCategoryID = reader.GetInt64(FLD_PROJECTCATEGORYID);
            mDProjectCategoryEntity.Name = reader.GetString(FLD_NAME);
            mDProjectCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDProjectCategoryEntity;
        }
    }
}
