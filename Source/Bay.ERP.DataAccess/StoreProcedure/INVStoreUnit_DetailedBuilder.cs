// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 10:49:09




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVStoreUnit_DetailedBuilder : IEntityBuilder<INVStoreUnit_DetailedEntity>
    {
        IList<INVStoreUnit_DetailedEntity> IEntityBuilder<INVStoreUnit_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<INVStoreUnit_DetailedEntity> INVStoreUnit_DetailedEntityList = new List<INVStoreUnit_DetailedEntity>();

            while (reader.Read())
            {
                INVStoreUnit_DetailedEntityList.Add(((IEntityBuilder<INVStoreUnit_DetailedEntity>)this).BuildEntity(reader));
            }

            return (INVStoreUnit_DetailedEntityList.Count > 0) ? INVStoreUnit_DetailedEntityList : null;
        }

        INVStoreUnit_DetailedEntity IEntityBuilder<INVStoreUnit_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_STOREUNITID = 0;
            const Int32 FLD_STOREID = 1;
            const Int32 FLD_INVENTORYSTOREUNITTYPEID = 2;
            const Int32 FLD_UNITTRACKNUMBER = 3;
            const Int32 FLD_STOREUNITLOCATION = 4;
            const Int32 FLD_DESCRIPTION = 5;
            const Int32 FLD_CREATEDATE = 6;
            const Int32 FLD_ISREMOVED = 7;
            const Int32 FLD_ISDEFAULT = 8;
            const Int32 FLD_PARENTSTOREUNITID = 9;
            const Int32 FLD_STORENAME = 10;
            const Int32 FLD_STORETRACKNUMBER = 11;
            const Int32 FLD_STORELOCATION = 12;
            const Int32 FLD_PROJECTNAME = 13;
            const Int32 FLD_DEPARTMENTNAME = 14;
            const Int32 FLD_MEMBERFULLNAME = 15;
            const Int32 FLD_MDINVENTORYSTOREUNITNAME = 16;
            const Int32 FLD_INVSTOREUNITSTOREID = 17;
            const Int32 FLD_ROWNUMBER = 18;

            INVStoreUnit_DetailedEntity iNVStoreUnit_DetailedEntity = new INVStoreUnit_DetailedEntity();

            iNVStoreUnit_DetailedEntity.StoreUnitID = reader.GetInt64(FLD_STOREUNITID);
            iNVStoreUnit_DetailedEntity.StoreID = reader.GetInt64(FLD_STOREID);
            iNVStoreUnit_DetailedEntity.InventoryStoreUnitTypeID = reader.GetInt64(FLD_INVENTORYSTOREUNITTYPEID);
            if (reader.IsDBNull(FLD_UNITTRACKNUMBER)) { iNVStoreUnit_DetailedEntity.UnitTrackNumber = String.Empty; } else { iNVStoreUnit_DetailedEntity.UnitTrackNumber = reader.GetString(FLD_UNITTRACKNUMBER); }
            if (reader.IsDBNull(FLD_STOREUNITLOCATION)) { iNVStoreUnit_DetailedEntity.StoreUnitLocation = String.Empty; } else { iNVStoreUnit_DetailedEntity.StoreUnitLocation = reader.GetString(FLD_STOREUNITLOCATION); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { iNVStoreUnit_DetailedEntity.Description = String.Empty; } else { iNVStoreUnit_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            iNVStoreUnit_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            iNVStoreUnit_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            iNVStoreUnit_DetailedEntity.IsDefault = reader.GetBoolean(FLD_ISDEFAULT);
            if (reader.IsDBNull(FLD_PARENTSTOREUNITID)) { iNVStoreUnit_DetailedEntity.ParentStoreUnitID = null; } else { iNVStoreUnit_DetailedEntity.ParentStoreUnitID = reader.GetInt64(FLD_PARENTSTOREUNITID); }
            if (reader.IsDBNull(FLD_STORENAME)) { iNVStoreUnit_DetailedEntity.StoreName = String.Empty; } else { iNVStoreUnit_DetailedEntity.StoreName = reader.GetString(FLD_STORENAME); }
            if (reader.IsDBNull(FLD_STORETRACKNUMBER)) { iNVStoreUnit_DetailedEntity.StoreTrackNumber = String.Empty; } else { iNVStoreUnit_DetailedEntity.StoreTrackNumber = reader.GetString(FLD_STORETRACKNUMBER); }
            if (reader.IsDBNull(FLD_STORELOCATION)) { iNVStoreUnit_DetailedEntity.StoreLocation = String.Empty; } else { iNVStoreUnit_DetailedEntity.StoreLocation = reader.GetString(FLD_STORELOCATION); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { iNVStoreUnit_DetailedEntity.ProjectName = String.Empty; } else { iNVStoreUnit_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTNAME)) { iNVStoreUnit_DetailedEntity.DepartmentName = String.Empty; } else { iNVStoreUnit_DetailedEntity.DepartmentName = reader.GetString(FLD_DEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { iNVStoreUnit_DetailedEntity.MemberFullName = String.Empty; } else { iNVStoreUnit_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_MDINVENTORYSTOREUNITNAME)) { iNVStoreUnit_DetailedEntity.MDInventoryStoreUnitName = String.Empty; } else { iNVStoreUnit_DetailedEntity.MDInventoryStoreUnitName = reader.GetString(FLD_MDINVENTORYSTOREUNITNAME); }
            iNVStoreUnit_DetailedEntity.INVStoreUnitStoreID = reader.GetInt64(FLD_INVSTOREUNITSTOREID);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { iNVStoreUnit_DetailedEntity.RowNumber = null; } else { iNVStoreUnit_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return iNVStoreUnit_DetailedEntity;
        }
    }
}
