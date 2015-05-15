// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:18:05




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDInventoryStoreUnitTypeBuilder : IEntityBuilder<MDInventoryStoreUnitTypeEntity>
    {
        IList<MDInventoryStoreUnitTypeEntity> IEntityBuilder<MDInventoryStoreUnitTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDInventoryStoreUnitTypeEntity> MDInventoryStoreUnitTypeEntityList = new List<MDInventoryStoreUnitTypeEntity>();

            while (reader.Read())
            {
                MDInventoryStoreUnitTypeEntityList.Add(((IEntityBuilder<MDInventoryStoreUnitTypeEntity>)this).BuildEntity(reader));
            }

            return (MDInventoryStoreUnitTypeEntityList.Count > 0) ? MDInventoryStoreUnitTypeEntityList : null;
        }

        MDInventoryStoreUnitTypeEntity IEntityBuilder<MDInventoryStoreUnitTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_INVENTORYSTOREUNITTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ICONPATH = 3;
            const Int32 FLD_ISREMOVED = 4;

            MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity = new MDInventoryStoreUnitTypeEntity();

            mDInventoryStoreUnitTypeEntity.InventoryStoreUnitTypeID = reader.GetInt64(FLD_INVENTORYSTOREUNITTYPEID);
            mDInventoryStoreUnitTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDInventoryStoreUnitTypeEntity.Description = String.Empty; } else { mDInventoryStoreUnitTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_ICONPATH)) { mDInventoryStoreUnitTypeEntity.IconPath = String.Empty; } else { mDInventoryStoreUnitTypeEntity.IconPath = reader.GetString(FLD_ICONPATH); }
            mDInventoryStoreUnitTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDInventoryStoreUnitTypeEntity;
        }
    }
}
