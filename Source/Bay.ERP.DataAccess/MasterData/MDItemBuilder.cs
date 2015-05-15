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
    internal sealed class MDItemBuilder : IEntityBuilder<MDItemEntity>
    {
        IList<MDItemEntity> IEntityBuilder<MDItemEntity>.BuildEntities(IDataReader reader)
        {
            List<MDItemEntity> MDItemEntityList = new List<MDItemEntity>();

            while (reader.Read())
            {
                MDItemEntityList.Add(((IEntityBuilder<MDItemEntity>)this).BuildEntity(reader));
            }

            return (MDItemEntityList.Count > 0) ? MDItemEntityList : null;
        }

        MDItemEntity IEntityBuilder<MDItemEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMID = 0;
            const Int32 FLD_ITEMCATEGORYID = 1;
            const Int32 FLD_ITEMNAME = 2;
            const Int32 FLD_UNITID = 3;
            const Int32 FLD_DESCRIPTION = 4;
            const Int32 FLD_ISREMOVED = 5;

            MDItemEntity mDItemEntity = new MDItemEntity();

            mDItemEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            mDItemEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID);
            mDItemEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            if (reader.IsDBNull(FLD_UNITID)) { mDItemEntity.UnitID = null; } else { mDItemEntity.UnitID = reader.GetInt64(FLD_UNITID); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDItemEntity.Description = String.Empty; } else { mDItemEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDItemEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDItemEntity;
        }
    }
}
