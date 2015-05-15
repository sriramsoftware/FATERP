// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Jul-2013, 04:33:39




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDItem_CustomBuilder : IEntityBuilder<MDItem_CustomEntity>
    {
        IList<MDItem_CustomEntity> IEntityBuilder<MDItem_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<MDItem_CustomEntity> MDItem_CustomEntityList = new List<MDItem_CustomEntity>();

            while (reader.Read())
            {
                MDItem_CustomEntityList.Add(((IEntityBuilder<MDItem_CustomEntity>)this).BuildEntity(reader));
            }

            return (MDItem_CustomEntityList.Count > 0) ? MDItem_CustomEntityList : null;
        }

        MDItem_CustomEntity IEntityBuilder<MDItem_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMID = 0;
            const Int32 FLD_PARENTCATEGORYNAME = 1;
            const Int32 FLD_CATEGORYNAME = 2;
            const Int32 FLD_ITEMNAME = 3;
            const Int32 FLD_UNITNAME = 4;
            const Int32 FLD_DESCRIPTION = 5;
            const Int32 FLD_ISREMOVED = 6;
            const Int32 FLD_UNITID = 7;
            const Int32 FLD_PARENTITEMCATEGORYID = 8;
            const Int32 FLD_ITEMCATEGORYID = 9;
            const Int32 FLD_ROWNUMBER = 10;

            MDItem_CustomEntity mDItem_CustomEntity = new MDItem_CustomEntity();

            mDItem_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            if (reader.IsDBNull(FLD_PARENTCATEGORYNAME)) { mDItem_CustomEntity.ParentCategoryName = String.Empty; } else { mDItem_CustomEntity.ParentCategoryName = reader.GetString(FLD_PARENTCATEGORYNAME); }
            if (reader.IsDBNull(FLD_CATEGORYNAME)) { mDItem_CustomEntity.CategoryName = String.Empty; } else { mDItem_CustomEntity.CategoryName = reader.GetString(FLD_CATEGORYNAME); }
            mDItem_CustomEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            if (reader.IsDBNull(FLD_UNITNAME)) { mDItem_CustomEntity.UnitName = String.Empty; } else { mDItem_CustomEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDItem_CustomEntity.Description = String.Empty; } else { mDItem_CustomEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDItem_CustomEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_UNITID)) { mDItem_CustomEntity.UnitID = null; } else { mDItem_CustomEntity.UnitID = reader.GetInt64(FLD_UNITID); }
            if (reader.IsDBNull(FLD_PARENTITEMCATEGORYID)) { mDItem_CustomEntity.ParentItemCategoryID = null; } else { mDItem_CustomEntity.ParentItemCategoryID = reader.GetInt64(FLD_PARENTITEMCATEGORYID); }
            mDItem_CustomEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { mDItem_CustomEntity.RowNumber = null; } else { mDItem_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return mDItem_CustomEntity;
        }
    }
}
