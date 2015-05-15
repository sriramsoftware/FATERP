// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2012, 02:56:29




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVTransferItemBuilder : IEntityBuilder<INVTransferItemEntity>
    {
        IList<INVTransferItemEntity> IEntityBuilder<INVTransferItemEntity>.BuildEntities(IDataReader reader)
        {
            List<INVTransferItemEntity> INVTransferItemEntityList = new List<INVTransferItemEntity>();

            while (reader.Read())
            {
                INVTransferItemEntityList.Add(((IEntityBuilder<INVTransferItemEntity>)this).BuildEntity(reader));
            }

            return (INVTransferItemEntityList.Count > 0) ? INVTransferItemEntityList : null;
        }

        INVTransferItemEntity IEntityBuilder<INVTransferItemEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TRANSFERITEMID = 0;
            const Int32 FLD_TRANSFERID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_BRANDID = 3;
            const Int32 FLD_REGIONID = 4;
            const Int32 FLD_COUNTRYID = 5;
            const Int32 FLD_REQUESTQTY = 6;
            const Int32 FLD_REMARKS = 7;

            INVTransferItemEntity iNVTransferItemEntity = new INVTransferItemEntity();

            iNVTransferItemEntity.TransferItemID = reader.GetInt64(FLD_TRANSFERITEMID);
            iNVTransferItemEntity.TransferID = reader.GetInt64(FLD_TRANSFERID);
            iNVTransferItemEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            iNVTransferItemEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            iNVTransferItemEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            iNVTransferItemEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            iNVTransferItemEntity.RequestQty = reader.GetDecimal(FLD_REQUESTQTY);
            if (reader.IsDBNull(FLD_REMARKS)) { iNVTransferItemEntity.Remarks = String.Empty; } else { iNVTransferItemEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return iNVTransferItemEntity;
        }
    }
}
