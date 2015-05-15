// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Feb-2013, 06:05:18




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMMaterialRequisitionItem_CustomBuilder : IEntityBuilder<PRMMaterialRequisitionItem_CustomEntity>
    {
        IList<PRMMaterialRequisitionItem_CustomEntity> IEntityBuilder<PRMMaterialRequisitionItem_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMMaterialRequisitionItem_CustomEntity> PRMMaterialRequisitionItem_CustomEntityList = new List<PRMMaterialRequisitionItem_CustomEntity>();

            while (reader.Read())
            {
                PRMMaterialRequisitionItem_CustomEntityList.Add(((IEntityBuilder<PRMMaterialRequisitionItem_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMMaterialRequisitionItem_CustomEntityList.Count > 0) ? PRMMaterialRequisitionItem_CustomEntityList : null;
        }

        PRMMaterialRequisitionItem_CustomEntity IEntityBuilder<PRMMaterialRequisitionItem_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONID = 0;
            const Int32 FLD_REQUISITIONNO = 1;
            const Int32 FLD_ITEMNAME = 2;
            const Int32 FLD_ORIGINBRANDNAME = 3;
            const Int32 FLD_SUPPLIERID = 4;
            const Int32 FLD_BRANDID = 5;
            const Int32 FLD_REQUISITIONITEMID = 6;
            const Int32 FLD_REQUIREDQTY = 7;
            const Int32 FLD_COUNTRYID = 8;
            const Int32 FLD_REGIONID = 9;
            const Int32 FLD_ORIGINREGIONNAME = 10;
            const Int32 FLD_ORIGINCOUNTRYNAME = 11;
            const Int32 FLD_WORKORDERID = 12;
            const Int32 FLD_WORKORDERNO = 13;
            const Int32 FLD_PREPAREDBYID = 14;
            const Int32 FLD_WORKORDERITEMMAPID = 15;
            const Int32 FLD_WORKORDERSTATUSID = 16;
            const Int32 FLD_RATE = 17;
            const Int32 FLD_PROJECTNAME = 18;
            const Int32 FLD_PROJECTID = 19;
            const Int32 FLD_SUPPLIERNAME = 20;

            PRMMaterialRequisitionItem_CustomEntity pRMMaterialRequisitionItem_CustomEntity = new PRMMaterialRequisitionItem_CustomEntity();

            pRMMaterialRequisitionItem_CustomEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            pRMMaterialRequisitionItem_CustomEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);
            pRMMaterialRequisitionItem_CustomEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            pRMMaterialRequisitionItem_CustomEntity.OriginBrandName = reader.GetString(FLD_ORIGINBRANDNAME);
            pRMMaterialRequisitionItem_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMMaterialRequisitionItem_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMMaterialRequisitionItem_CustomEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            pRMMaterialRequisitionItem_CustomEntity.RequiredQty = reader.GetDecimal(FLD_REQUIREDQTY);
            pRMMaterialRequisitionItem_CustomEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            pRMMaterialRequisitionItem_CustomEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            pRMMaterialRequisitionItem_CustomEntity.OriginRegionName = reader.GetString(FLD_ORIGINREGIONNAME);
            pRMMaterialRequisitionItem_CustomEntity.OriginCountryName = reader.GetString(FLD_ORIGINCOUNTRYNAME);
            if (reader.IsDBNull(FLD_WORKORDERID)) { pRMMaterialRequisitionItem_CustomEntity.WorkOrderID = null; } else { pRMMaterialRequisitionItem_CustomEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { pRMMaterialRequisitionItem_CustomEntity.WorkOrderNo = String.Empty; } else { pRMMaterialRequisitionItem_CustomEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_PREPAREDBYID)) { pRMMaterialRequisitionItem_CustomEntity.PreparedByID = null; } else { pRMMaterialRequisitionItem_CustomEntity.PreparedByID = reader.GetInt64(FLD_PREPAREDBYID); }
            if (reader.IsDBNull(FLD_WORKORDERITEMMAPID)) { pRMMaterialRequisitionItem_CustomEntity.WorkOrderItemMapID = null; } else { pRMMaterialRequisitionItem_CustomEntity.WorkOrderItemMapID = reader.GetInt64(FLD_WORKORDERITEMMAPID); }
            if (reader.IsDBNull(FLD_WORKORDERSTATUSID)) { pRMMaterialRequisitionItem_CustomEntity.WorkOrderStatusID = null; } else { pRMMaterialRequisitionItem_CustomEntity.WorkOrderStatusID = reader.GetInt64(FLD_WORKORDERSTATUSID); }
            if (reader.IsDBNull(FLD_RATE)) { pRMMaterialRequisitionItem_CustomEntity.Rate = null; } else { pRMMaterialRequisitionItem_CustomEntity.Rate = reader.GetDecimal(FLD_RATE); }
            pRMMaterialRequisitionItem_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            pRMMaterialRequisitionItem_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            pRMMaterialRequisitionItem_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);

            return pRMMaterialRequisitionItem_CustomEntity;
        }
    }
}
