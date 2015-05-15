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
    internal sealed class INVCurrentStock_DetailedBuilder : IEntityBuilder<INVCurrentStock_DetailedEntity>
    {
        IList<INVCurrentStock_DetailedEntity> IEntityBuilder<INVCurrentStock_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<INVCurrentStock_DetailedEntity> INVCurrentStock_DetailedEntityList = new List<INVCurrentStock_DetailedEntity>();

            while (reader.Read())
            {
                INVCurrentStock_DetailedEntityList.Add(((IEntityBuilder<INVCurrentStock_DetailedEntity>)this).BuildEntity(reader));
            }

            return (INVCurrentStock_DetailedEntityList.Count > 0) ? INVCurrentStock_DetailedEntityList : null;
        }

        INVCurrentStock_DetailedEntity IEntityBuilder<INVCurrentStock_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CURRENTSTOCKID = 0;
            const Int32 FLD_ITEMID = 1;
            const Int32 FLD_BRANDID = 2;
            const Int32 FLD_REGIONID = 3;
            const Int32 FLD_COUNTRYID = 4;
            const Int32 FLD_UNITCURRENTSTOCK = 5;
            const Int32 FLD_MDITEMNAME = 6;
            const Int32 FLD_MDBRANDNAME = 7;
            const Int32 FLD_MDREGIONNAME = 8;
            const Int32 FLD_MDCOUNTRYNAME = 9;
            const Int32 FLD_UNITNAME = 10;
            const Int32 FLD_ROWNUMBER = 11;

            INVCurrentStock_DetailedEntity iNVCurrentStock_DetailedEntity = new INVCurrentStock_DetailedEntity();

            iNVCurrentStock_DetailedEntity.CurrentStockID = reader.GetInt64(FLD_CURRENTSTOCKID);
            iNVCurrentStock_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            iNVCurrentStock_DetailedEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            iNVCurrentStock_DetailedEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            iNVCurrentStock_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            iNVCurrentStock_DetailedEntity.UnitCurrentStock = reader.GetInt64(FLD_UNITCURRENTSTOCK);
            if (reader.IsDBNull(FLD_MDITEMNAME)) { iNVCurrentStock_DetailedEntity.MDItemName = String.Empty; } else { iNVCurrentStock_DetailedEntity.MDItemName = reader.GetString(FLD_MDITEMNAME); }
            if (reader.IsDBNull(FLD_MDBRANDNAME)) { iNVCurrentStock_DetailedEntity.MDBrandName = String.Empty; } else { iNVCurrentStock_DetailedEntity.MDBrandName = reader.GetString(FLD_MDBRANDNAME); }
            if (reader.IsDBNull(FLD_MDREGIONNAME)) { iNVCurrentStock_DetailedEntity.MDRegionName = String.Empty; } else { iNVCurrentStock_DetailedEntity.MDRegionName = reader.GetString(FLD_MDREGIONNAME); }
            if (reader.IsDBNull(FLD_MDCOUNTRYNAME)) { iNVCurrentStock_DetailedEntity.MDCountryName = String.Empty; } else { iNVCurrentStock_DetailedEntity.MDCountryName = reader.GetString(FLD_MDCOUNTRYNAME); }
            if (reader.IsDBNull(FLD_UNITNAME)) { iNVCurrentStock_DetailedEntity.UnitName = String.Empty; } else { iNVCurrentStock_DetailedEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { iNVCurrentStock_DetailedEntity.RowNumber = null; } else { iNVCurrentStock_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return iNVCurrentStock_DetailedEntity;
        }
    }
}
