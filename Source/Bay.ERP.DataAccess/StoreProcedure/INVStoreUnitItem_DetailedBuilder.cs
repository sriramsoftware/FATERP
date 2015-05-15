// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2012, 12:03:10




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVStoreUnitItem_DetailedBuilder : IEntityBuilder<INVStoreUnitItem_DetailedEntity>
    {
        IList<INVStoreUnitItem_DetailedEntity> IEntityBuilder<INVStoreUnitItem_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<INVStoreUnitItem_DetailedEntity> INVStoreUnitItem_DetailedEntityList = new List<INVStoreUnitItem_DetailedEntity>();

            while (reader.Read())
            {
                INVStoreUnitItem_DetailedEntityList.Add(((IEntityBuilder<INVStoreUnitItem_DetailedEntity>)this).BuildEntity(reader));
            }

            return (INVStoreUnitItem_DetailedEntityList.Count > 0) ? INVStoreUnitItem_DetailedEntityList : null;
        }

        INVStoreUnitItem_DetailedEntity IEntityBuilder<INVStoreUnitItem_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_STOREUNITITEMID = 0;
            const Int32 FLD_STOREUNITID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_BRANDID = 3;
            const Int32 FLD_REGIONID = 4;
            const Int32 FLD_COUNTRYID = 5;
            const Int32 FLD_UNITCURRENTSTOCK = 6;
            const Int32 FLD_INVSTOREUNITSTOREID = 7;
            const Int32 FLD_UNITTRACKNUMBER = 8;
            const Int32 FLD_ISDEFAULT = 9;
            const Int32 FLD_STOREUNITLOCATION = 10;
            const Int32 FLD_STORENAME = 11;
            const Int32 FLD_STORETRACKNUMBER = 12;
            const Int32 FLD_PROJECTID = 13;
            const Int32 FLD_INVSTORELOCATION = 14;
            const Int32 FLD_PROJECTNAME = 15;
            const Int32 FLD_DEPARTMENTNAME = 16;
            const Int32 FLD_MEMBERFULLNAME = 17;
            const Int32 FLD_MDITEMITEMNAME = 18;
            const Int32 FLD_MDBRANDBRANDNAME = 19;
            const Int32 FLD_MDREGIONNAME = 20;
            const Int32 FLD_MDCOUNTRYNAME = 21;
            const Int32 FLD_UNITNAME = 22;
            const Int32 FLD_ROWNUMBER = 23;

            INVStoreUnitItem_DetailedEntity iNVStoreUnitItem_DetailedEntity = new INVStoreUnitItem_DetailedEntity();

            iNVStoreUnitItem_DetailedEntity.StoreUnitItemID = reader.GetInt64(FLD_STOREUNITITEMID);
            iNVStoreUnitItem_DetailedEntity.StoreUnitID = reader.GetInt64(FLD_STOREUNITID);
            iNVStoreUnitItem_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            iNVStoreUnitItem_DetailedEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            iNVStoreUnitItem_DetailedEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            iNVStoreUnitItem_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            iNVStoreUnitItem_DetailedEntity.UnitCurrentStock = reader.GetInt64(FLD_UNITCURRENTSTOCK);
            if (reader.IsDBNull(FLD_INVSTOREUNITSTOREID)) { iNVStoreUnitItem_DetailedEntity.INVStoreUnitStoreID = null; } else { iNVStoreUnitItem_DetailedEntity.INVStoreUnitStoreID = reader.GetInt64(FLD_INVSTOREUNITSTOREID); }
            if (reader.IsDBNull(FLD_UNITTRACKNUMBER)) { iNVStoreUnitItem_DetailedEntity.UnitTrackNumber = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.UnitTrackNumber = reader.GetString(FLD_UNITTRACKNUMBER); }
            if (reader.IsDBNull(FLD_ISDEFAULT)) { iNVStoreUnitItem_DetailedEntity.IsDefault = false; } else { iNVStoreUnitItem_DetailedEntity.IsDefault = reader.GetBoolean(FLD_ISDEFAULT); }
            if (reader.IsDBNull(FLD_STOREUNITLOCATION)) { iNVStoreUnitItem_DetailedEntity.StoreUnitLocation = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.StoreUnitLocation = reader.GetString(FLD_STOREUNITLOCATION); }
            if (reader.IsDBNull(FLD_STORENAME)) { iNVStoreUnitItem_DetailedEntity.StoreName = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.StoreName = reader.GetString(FLD_STORENAME); }
            if (reader.IsDBNull(FLD_STORETRACKNUMBER)) { iNVStoreUnitItem_DetailedEntity.StoreTrackNumber = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.StoreTrackNumber = reader.GetString(FLD_STORETRACKNUMBER); }
            if (reader.IsDBNull(FLD_PROJECTID)) { iNVStoreUnitItem_DetailedEntity.ProjectID = null; } else { iNVStoreUnitItem_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_INVSTORELOCATION)) { iNVStoreUnitItem_DetailedEntity.INVStoreLocation = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.INVStoreLocation = reader.GetString(FLD_INVSTORELOCATION); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { iNVStoreUnitItem_DetailedEntity.ProjectName = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTNAME)) { iNVStoreUnitItem_DetailedEntity.DepartmentName = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.DepartmentName = reader.GetString(FLD_DEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { iNVStoreUnitItem_DetailedEntity.MemberFullName = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_MDITEMITEMNAME)) { iNVStoreUnitItem_DetailedEntity.MDItemItemName = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.MDItemItemName = reader.GetString(FLD_MDITEMITEMNAME); }
            if (reader.IsDBNull(FLD_MDBRANDBRANDNAME)) { iNVStoreUnitItem_DetailedEntity.MDBrandBrandName = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.MDBrandBrandName = reader.GetString(FLD_MDBRANDBRANDNAME); }
            if (reader.IsDBNull(FLD_MDREGIONNAME)) { iNVStoreUnitItem_DetailedEntity.MDRegionName = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.MDRegionName = reader.GetString(FLD_MDREGIONNAME); }
            if (reader.IsDBNull(FLD_MDCOUNTRYNAME)) { iNVStoreUnitItem_DetailedEntity.MDCountryName = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.MDCountryName = reader.GetString(FLD_MDCOUNTRYNAME); }
            if (reader.IsDBNull(FLD_UNITNAME)) { iNVStoreUnitItem_DetailedEntity.UnitName = String.Empty; } else { iNVStoreUnitItem_DetailedEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { iNVStoreUnitItem_DetailedEntity.RowNumber = null; } else { iNVStoreUnitItem_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return iNVStoreUnitItem_DetailedEntity;
        }
    }
}
