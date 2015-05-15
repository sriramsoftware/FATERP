// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jan-2012, 12:40:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDItem_RPTBuilder : IEntityBuilder<MDItem_RPTEntity>
    {
        IList<MDItem_RPTEntity> IEntityBuilder<MDItem_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<MDItem_RPTEntity> MDItem_RPTEntityList = new List<MDItem_RPTEntity>();

            while (reader.Read())
            {
                MDItem_RPTEntityList.Add(((IEntityBuilder<MDItem_RPTEntity>)this).BuildEntity(reader));
            }

            return (MDItem_RPTEntityList.Count > 0) ? MDItem_RPTEntityList : null;
        }

        MDItem_RPTEntity IEntityBuilder<MDItem_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PARENTITEMCATEGORYID = 0;
            const Int32 FLD_SUBCATEGORYID = 1;
            const Int32 FLD_PARENTCATEGORYNAME = 2;
            const Int32 FLD_SUBCATEGORY = 3;
            const Int32 FLD_ITEMNAME = 4;
            const Int32 FLD_UNITNAME = 5;
            const Int32 FLD_DESCRIPTION = 6;
            const Int32 FLD_ITEMID = 7;

            MDItem_RPTEntity mDItem_RPTEntity = new MDItem_RPTEntity();

            mDItem_RPTEntity.ParentItemCategoryID = reader.GetInt64(FLD_PARENTITEMCATEGORYID);
            mDItem_RPTEntity.SubCategoryID = reader.GetInt64(FLD_SUBCATEGORYID);
            mDItem_RPTEntity.ParentCategoryName = reader.GetString(FLD_PARENTCATEGORYNAME);
            mDItem_RPTEntity.SubCategory = reader.GetString(FLD_SUBCATEGORY);
            mDItem_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            if (reader.IsDBNull(FLD_UNITNAME)) { mDItem_RPTEntity.UnitName = String.Empty; } else { mDItem_RPTEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDItem_RPTEntity.Description = String.Empty; } else { mDItem_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDItem_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID);

            return mDItem_RPTEntity;
        }
    }
}
