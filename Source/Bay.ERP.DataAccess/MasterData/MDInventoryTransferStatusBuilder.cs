// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 01:46:09




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDInventoryTransferStatusBuilder : IEntityBuilder<MDInventoryTransferStatusEntity>
    {
        IList<MDInventoryTransferStatusEntity> IEntityBuilder<MDInventoryTransferStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDInventoryTransferStatusEntity> MDInventoryTransferStatusEntityList = new List<MDInventoryTransferStatusEntity>();

            while (reader.Read())
            {
                MDInventoryTransferStatusEntityList.Add(((IEntityBuilder<MDInventoryTransferStatusEntity>)this).BuildEntity(reader));
            }

            return (MDInventoryTransferStatusEntityList.Count > 0) ? MDInventoryTransferStatusEntityList : null;
        }

        MDInventoryTransferStatusEntity IEntityBuilder<MDInventoryTransferStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_INVENTORYTRANSFERSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDInventoryTransferStatusEntity mDInventoryTransferStatusEntity = new MDInventoryTransferStatusEntity();

            mDInventoryTransferStatusEntity.InventoryTransferStatusID = reader.GetInt64(FLD_INVENTORYTRANSFERSTATUSID);
            mDInventoryTransferStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDInventoryTransferStatusEntity.Description = String.Empty; } else { mDInventoryTransferStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDInventoryTransferStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDInventoryTransferStatusEntity;
        }
    }
}
