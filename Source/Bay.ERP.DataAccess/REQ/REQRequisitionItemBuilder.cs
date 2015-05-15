// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jun-2012, 11:52:40




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class REQRequisitionItemBuilder : IEntityBuilder<REQRequisitionItemEntity>
    {
        IList<REQRequisitionItemEntity> IEntityBuilder<REQRequisitionItemEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisitionItemEntity> REQRequisitionItemEntityList = new List<REQRequisitionItemEntity>();

            while (reader.Read())
            {
                REQRequisitionItemEntityList.Add(((IEntityBuilder<REQRequisitionItemEntity>)this).BuildEntity(reader));
            }

            return (REQRequisitionItemEntityList.Count > 0) ? REQRequisitionItemEntityList : null;
        }

        REQRequisitionItemEntity IEntityBuilder<REQRequisitionItemEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONITEMID = 0;
            const Int32 FLD_REQUISITIONID = 1;
            const Int32 FLD_ACCOUNTSCODE = 2;
            const Int32 FLD_ITEMID = 3;
            const Int32 FLD_BRANDID = 4;
            const Int32 FLD_SUPPLIERID = 5;
            const Int32 FLD_REGIONID = 6;
            const Int32 FLD_COUNTRYID = 7;
            const Int32 FLD_RATE = 8;
            const Int32 FLD_TOTALREQUIREDQTY = 9;
            const Int32 FLD_PURCHASEDQTYTILLTODATE = 10;
            const Int32 FLD_PRESENTREQUIREDQTY = 11;
            const Int32 FLD_REQUIREDDATE = 12;
            const Int32 FLD_REMARKS = 13;

            REQRequisitionItemEntity rEQRequisitionItemEntity = new REQRequisitionItemEntity();

            rEQRequisitionItemEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            rEQRequisitionItemEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            rEQRequisitionItemEntity.AccountsCode = reader.GetString(FLD_ACCOUNTSCODE);
            rEQRequisitionItemEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            rEQRequisitionItemEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            rEQRequisitionItemEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            rEQRequisitionItemEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            rEQRequisitionItemEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            rEQRequisitionItemEntity.Rate = reader.GetDecimal(FLD_RATE);
            rEQRequisitionItemEntity.TotalRequiredQty = reader.GetDecimal(FLD_TOTALREQUIREDQTY);
            if (reader.IsDBNull(FLD_PURCHASEDQTYTILLTODATE)) { rEQRequisitionItemEntity.PurchasedQtyTillToDate = null; } else { rEQRequisitionItemEntity.PurchasedQtyTillToDate = reader.GetDecimal(FLD_PURCHASEDQTYTILLTODATE); }
            rEQRequisitionItemEntity.PresentRequiredQty = reader.GetDecimal(FLD_PRESENTREQUIREDQTY);
            rEQRequisitionItemEntity.RequiredDate = reader.GetDateTime(FLD_REQUIREDDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { rEQRequisitionItemEntity.Remarks = String.Empty; } else { rEQRequisitionItemEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return rEQRequisitionItemEntity;
        }
    }
}
