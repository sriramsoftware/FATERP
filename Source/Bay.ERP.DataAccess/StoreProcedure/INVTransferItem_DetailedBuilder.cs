// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jan-2013, 02:54:50




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVTransferItem_DetailedBuilder : IEntityBuilder<INVTransferItem_DetailedEntity>
    {
        IList<INVTransferItem_DetailedEntity> IEntityBuilder<INVTransferItem_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<INVTransferItem_DetailedEntity> INVTransferItem_DetailedEntityList = new List<INVTransferItem_DetailedEntity>();

            while (reader.Read())
            {
                INVTransferItem_DetailedEntityList.Add(((IEntityBuilder<INVTransferItem_DetailedEntity>)this).BuildEntity(reader));
            }

            return (INVTransferItem_DetailedEntityList.Count > 0) ? INVTransferItem_DetailedEntityList : null;
        }

        INVTransferItem_DetailedEntity IEntityBuilder<INVTransferItem_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TRANSFERITEMID = 0;
            const Int32 FLD_TRANSFERID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_BRANDID = 3;
            const Int32 FLD_REGIONID = 4;
            const Int32 FLD_COUNTRYID = 5;
            const Int32 FLD_REQUESTQTY = 6;
            const Int32 FLD_REMARKS = 7;
            const Int32 FLD_INVTRANSFERTRFNO = 8;
            const Int32 FLD_MDITEMITEMNAME = 9;
            const Int32 FLD_MDBRANDBRANDNAME = 10;
            const Int32 FLD_MDREGIONNAME = 11;
            const Int32 FLD_MDCOUNTRYNAME = 12;
            const Int32 FLD_UNITNAME = 13;
            const Int32 FLD_ROWNUMBER = 14;

            INVTransferItem_DetailedEntity iNVTransferItem_DetailedEntity = new INVTransferItem_DetailedEntity();

            iNVTransferItem_DetailedEntity.TransferItemID = reader.GetInt64(FLD_TRANSFERITEMID);
            iNVTransferItem_DetailedEntity.TransferID = reader.GetInt64(FLD_TRANSFERID);
            iNVTransferItem_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            iNVTransferItem_DetailedEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            iNVTransferItem_DetailedEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            iNVTransferItem_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            iNVTransferItem_DetailedEntity.RequestQty = reader.GetDecimal(FLD_REQUESTQTY);
            if (reader.IsDBNull(FLD_REMARKS)) { iNVTransferItem_DetailedEntity.Remarks = String.Empty; } else { iNVTransferItem_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_INVTRANSFERTRFNO)) { iNVTransferItem_DetailedEntity.INVTransferTRFNo = String.Empty; } else { iNVTransferItem_DetailedEntity.INVTransferTRFNo = reader.GetString(FLD_INVTRANSFERTRFNO); }
            if (reader.IsDBNull(FLD_MDITEMITEMNAME)) { iNVTransferItem_DetailedEntity.MDItemItemName = String.Empty; } else { iNVTransferItem_DetailedEntity.MDItemItemName = reader.GetString(FLD_MDITEMITEMNAME); }
            if (reader.IsDBNull(FLD_MDBRANDBRANDNAME)) { iNVTransferItem_DetailedEntity.MDBrandBrandName = String.Empty; } else { iNVTransferItem_DetailedEntity.MDBrandBrandName = reader.GetString(FLD_MDBRANDBRANDNAME); }
            if (reader.IsDBNull(FLD_MDREGIONNAME)) { iNVTransferItem_DetailedEntity.MDRegionName = String.Empty; } else { iNVTransferItem_DetailedEntity.MDRegionName = reader.GetString(FLD_MDREGIONNAME); }
            if (reader.IsDBNull(FLD_MDCOUNTRYNAME)) { iNVTransferItem_DetailedEntity.MDCountryName = String.Empty; } else { iNVTransferItem_DetailedEntity.MDCountryName = reader.GetString(FLD_MDCOUNTRYNAME); }
            if (reader.IsDBNull(FLD_UNITNAME)) { iNVTransferItem_DetailedEntity.UnitName = String.Empty; } else { iNVTransferItem_DetailedEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { iNVTransferItem_DetailedEntity.RowNumber = null; } else { iNVTransferItem_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return iNVTransferItem_DetailedEntity;
        }
    }
}
