// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jun-2012, 10:09:58




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class REQRequisitionItem_CustomBuilder : IEntityBuilder<REQRequisitionItem_CustomEntity>
    {
        IList<REQRequisitionItem_CustomEntity> IEntityBuilder<REQRequisitionItem_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisitionItem_CustomEntity> REQRequisitionItem_CustomEntityList = new List<REQRequisitionItem_CustomEntity>();

            while (reader.Read())
            {
                REQRequisitionItem_CustomEntityList.Add(((IEntityBuilder<REQRequisitionItem_CustomEntity>)this).BuildEntity(reader));
            }

            return (REQRequisitionItem_CustomEntityList.Count > 0) ? REQRequisitionItem_CustomEntityList : null;
        }

        REQRequisitionItem_CustomEntity IEntityBuilder<REQRequisitionItem_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_REQUISITIONNO = 2;
            const Int32 FLD_REQUISITIONDATE = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_REQUISITIONSTATUSID = 5;
            const Int32 FLD_REQUISITIONITEMID = 6;
            const Int32 FLD_ACCOUNTSCODE = 7;
            const Int32 FLD_ITEMID = 8;
            const Int32 FLD_BRANDID = 9;
            const Int32 FLD_SUPPLIERID = 10;
            const Int32 FLD_REGIONID = 11;
            const Int32 FLD_COUNTRYID = 12;
            const Int32 FLD_RATE = 13;
            const Int32 FLD_TOTALREQUIREDQTY = 14;
            const Int32 FLD_PURCHASEDQTYTILLTODATE = 15;
            const Int32 FLD_PRESENTREQUIREDQTY = 16;
            const Int32 FLD_REQUIREDDATE = 17;
            const Int32 FLD_ITEMNAME = 18;
            const Int32 FLD_UNITID = 19;
            const Int32 FLD_UNITNAME = 20;
            const Int32 FLD_PROJECTCODE = 21;
            const Int32 FLD_PROJECTNAME = 22;
            const Int32 FLD_BRANDNAME = 23;
            const Int32 FLD_SUPPLIERNAME = 24;
            const Int32 FLD_REGIONNAME = 25;
            const Int32 FLD_COUNTRYNAME = 26;

            REQRequisitionItem_CustomEntity rEQRequisitionItem_CustomEntity = new REQRequisitionItem_CustomEntity();

            rEQRequisitionItem_CustomEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            rEQRequisitionItem_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            rEQRequisitionItem_CustomEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);
            rEQRequisitionItem_CustomEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { rEQRequisitionItem_CustomEntity.Remarks = String.Empty; } else { rEQRequisitionItem_CustomEntity.Remarks = reader.GetString(FLD_REMARKS); }
            rEQRequisitionItem_CustomEntity.RequisitionStatusID = reader.GetInt64(FLD_REQUISITIONSTATUSID);
            rEQRequisitionItem_CustomEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            rEQRequisitionItem_CustomEntity.AccountsCode = reader.GetString(FLD_ACCOUNTSCODE);
            rEQRequisitionItem_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            rEQRequisitionItem_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            rEQRequisitionItem_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            rEQRequisitionItem_CustomEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            rEQRequisitionItem_CustomEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            rEQRequisitionItem_CustomEntity.Rate = reader.GetDecimal(FLD_RATE);
            rEQRequisitionItem_CustomEntity.TotalRequiredQty = reader.GetDecimal(FLD_TOTALREQUIREDQTY);
            if (reader.IsDBNull(FLD_PURCHASEDQTYTILLTODATE)) { rEQRequisitionItem_CustomEntity.PurchasedQtyTillToDate = null; } else { rEQRequisitionItem_CustomEntity.PurchasedQtyTillToDate = reader.GetDecimal(FLD_PURCHASEDQTYTILLTODATE); }
            rEQRequisitionItem_CustomEntity.PresentRequiredQty = reader.GetDecimal(FLD_PRESENTREQUIREDQTY);
            rEQRequisitionItem_CustomEntity.RequiredDate = reader.GetDateTime(FLD_REQUIREDDATE);
            rEQRequisitionItem_CustomEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            if (reader.IsDBNull(FLD_UNITID)) { rEQRequisitionItem_CustomEntity.UnitID = null; } else { rEQRequisitionItem_CustomEntity.UnitID = reader.GetInt64(FLD_UNITID); }
            if (reader.IsDBNull(FLD_UNITNAME)) { rEQRequisitionItem_CustomEntity.UnitName = String.Empty; } else { rEQRequisitionItem_CustomEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            rEQRequisitionItem_CustomEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            rEQRequisitionItem_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            rEQRequisitionItem_CustomEntity.BrandName = reader.GetString(FLD_BRANDNAME);
            rEQRequisitionItem_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            rEQRequisitionItem_CustomEntity.RegionName = reader.GetString(FLD_REGIONNAME);
            rEQRequisitionItem_CustomEntity.CountryName = reader.GetString(FLD_COUNTRYNAME);

            return rEQRequisitionItem_CustomEntity;
        }
    }
}
