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
    internal sealed class MDItemCategoryBuilder : IEntityBuilder<MDItemCategoryEntity>
    {
        IList<MDItemCategoryEntity> IEntityBuilder<MDItemCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDItemCategoryEntity> MDItemCategoryEntityList = new List<MDItemCategoryEntity>();

            while (reader.Read())
            {
                MDItemCategoryEntityList.Add(((IEntityBuilder<MDItemCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDItemCategoryEntityList.Count > 0) ? MDItemCategoryEntityList : null;
        }

        MDItemCategoryEntity IEntityBuilder<MDItemCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMCATEGORYID = 0;
            const Int32 FLD_PARENTITEMCATEGORYID = 1;
            const Int32 FLD_CATEGORYNAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISREMOVED = 4;

            MDItemCategoryEntity mDItemCategoryEntity = new MDItemCategoryEntity();

            mDItemCategoryEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID);
            if (reader.IsDBNull(FLD_PARENTITEMCATEGORYID)) { mDItemCategoryEntity.ParentItemCategoryID = null; } else { mDItemCategoryEntity.ParentItemCategoryID = reader.GetInt64(FLD_PARENTITEMCATEGORYID); }
            mDItemCategoryEntity.CategoryName = reader.GetString(FLD_CATEGORYNAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDItemCategoryEntity.Description = String.Empty; } else { mDItemCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDItemCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDItemCategoryEntity;
        }
    }
}
