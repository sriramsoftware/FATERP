// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:43:44




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVStoreUnitBuilder : IEntityBuilder<INVStoreUnitEntity>
    {
        IList<INVStoreUnitEntity> IEntityBuilder<INVStoreUnitEntity>.BuildEntities(IDataReader reader)
        {
            List<INVStoreUnitEntity> INVStoreUnitEntityList = new List<INVStoreUnitEntity>();

            while (reader.Read())
            {
                INVStoreUnitEntityList.Add(((IEntityBuilder<INVStoreUnitEntity>)this).BuildEntity(reader));
            }

            return (INVStoreUnitEntityList.Count > 0) ? INVStoreUnitEntityList : null;
        }

        INVStoreUnitEntity IEntityBuilder<INVStoreUnitEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_STOREUNITID = 0;
            const Int32 FLD_STOREID = 1;
            const Int32 FLD_INVENTORYSTOREUNITTYPEID = 2;
            const Int32 FLD_UNITTRACKNUMBER = 3;
            const Int32 FLD_LOCATION = 4;
            const Int32 FLD_DESCRIPTION = 5;
            const Int32 FLD_CREATEDATE = 6;
            const Int32 FLD_ISREMOVED = 7;
            const Int32 FLD_PARENTSTOREUNITID = 8;
            const Int32 FLD_ISDEFAULT = 9;

            INVStoreUnitEntity iNVStoreUnitEntity = new INVStoreUnitEntity();

            iNVStoreUnitEntity.StoreUnitID = reader.GetInt64(FLD_STOREUNITID);
            iNVStoreUnitEntity.StoreID = reader.GetInt64(FLD_STOREID);
            iNVStoreUnitEntity.InventoryStoreUnitTypeID = reader.GetInt64(FLD_INVENTORYSTOREUNITTYPEID);
            if (reader.IsDBNull(FLD_UNITTRACKNUMBER)) { iNVStoreUnitEntity.UnitTrackNumber = String.Empty; } else { iNVStoreUnitEntity.UnitTrackNumber = reader.GetString(FLD_UNITTRACKNUMBER); }
            if (reader.IsDBNull(FLD_LOCATION)) { iNVStoreUnitEntity.Location = String.Empty; } else { iNVStoreUnitEntity.Location = reader.GetString(FLD_LOCATION); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { iNVStoreUnitEntity.Description = String.Empty; } else { iNVStoreUnitEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            iNVStoreUnitEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            iNVStoreUnitEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_PARENTSTOREUNITID)) { iNVStoreUnitEntity.ParentStoreUnitID = null; } else { iNVStoreUnitEntity.ParentStoreUnitID = reader.GetInt64(FLD_PARENTSTOREUNITID); }
            iNVStoreUnitEntity.IsDefault = reader.GetBoolean(FLD_ISDEFAULT);

            return iNVStoreUnitEntity;
        }
    }
}
