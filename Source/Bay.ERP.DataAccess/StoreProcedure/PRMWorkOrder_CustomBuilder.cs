// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Aug-2013, 02:50:27




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrder_CustomBuilder : IEntityBuilder<PRMWorkOrder_CustomEntity>
    {
        IList<PRMWorkOrder_CustomEntity> IEntityBuilder<PRMWorkOrder_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrder_CustomEntity> PRMWorkOrder_CustomEntityList = new List<PRMWorkOrder_CustomEntity>();

            while (reader.Read())
            {
                PRMWorkOrder_CustomEntityList.Add(((IEntityBuilder<PRMWorkOrder_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrder_CustomEntityList.Count > 0) ? PRMWorkOrder_CustomEntityList : null;
        }

        PRMWorkOrder_CustomEntity IEntityBuilder<PRMWorkOrder_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERID = 0;
            const Int32 FLD_WORKORDERNO = 1;
            const Int32 FLD_PREPAREDBYID = 2;
            const Int32 FLD_SUPPLIERID = 3;
            const Int32 FLD_WORKORDERITEMMAPID = 4;
            const Int32 FLD_WORKORDERSTATUSID = 5;
            const Int32 FLD_REQUISITIONITEMID = 6;
            const Int32 FLD_REQUISITIONID = 7;
            const Int32 FLD_REQUIREDQTY = 8;
            const Int32 FLD_RATE = 9;
            const Int32 FLD_PROJECTID = 10;
            const Int32 FLD_SUPPLIERNAME = 11;
            const Int32 FLD_PROJECTNAME = 12;
            const Int32 FLD_REQUISITIONNO = 13;
            const Int32 FLD_REQUISITIONQTY = 14;
            const Int32 FLD_RECEIVEDQTY = 15;
            const Int32 FLD_MATERIALRECEIVEPROJECTID = 16;
            const Int32 FLD_ORIGINBRANDNAME = 17;
            const Int32 FLD_ORIGINSUPPLIERNAME = 18;
            const Int32 FLD_ORIGINREGIONNAME = 19;
            const Int32 FLD_ORIGINCOUNTRYNAME = 20;
            const Int32 FLD_ITEMID = 21;
            const Int32 FLD_ITEMNAME = 22;
            const Int32 FLD_UNITNAME = 23;
            const Int32 FLD_ROWNUMBER = 24;

            PRMWorkOrder_CustomEntity pRMWorkOrder_CustomEntity = new PRMWorkOrder_CustomEntity();

            pRMWorkOrder_CustomEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMWorkOrder_CustomEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO);
            pRMWorkOrder_CustomEntity.PreparedByID = reader.GetInt64(FLD_PREPAREDBYID);
            pRMWorkOrder_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMWorkOrder_CustomEntity.WorkOrderItemMapID = reader.GetInt64(FLD_WORKORDERITEMMAPID);
            pRMWorkOrder_CustomEntity.WorkOrderStatusID = reader.GetInt64(FLD_WORKORDERSTATUSID);
            pRMWorkOrder_CustomEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            pRMWorkOrder_CustomEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            pRMWorkOrder_CustomEntity.RequiredQty = reader.GetDecimal(FLD_REQUIREDQTY);
            pRMWorkOrder_CustomEntity.Rate = reader.GetDecimal(FLD_RATE);
            if (reader.IsDBNull(FLD_PROJECTID)) { pRMWorkOrder_CustomEntity.ProjectID = null; } else { pRMWorkOrder_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { pRMWorkOrder_CustomEntity.SupplierName = String.Empty; } else { pRMWorkOrder_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { pRMWorkOrder_CustomEntity.ProjectName = String.Empty; } else { pRMWorkOrder_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { pRMWorkOrder_CustomEntity.RequisitionNo = String.Empty; } else { pRMWorkOrder_CustomEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_REQUISITIONQTY)) { pRMWorkOrder_CustomEntity.RequisitionQty = null; } else { pRMWorkOrder_CustomEntity.RequisitionQty = reader.GetDecimal(FLD_REQUISITIONQTY); }
            if (reader.IsDBNull(FLD_RECEIVEDQTY)) { pRMWorkOrder_CustomEntity.ReceivedQty = null; } else { pRMWorkOrder_CustomEntity.ReceivedQty = reader.GetDecimal(FLD_RECEIVEDQTY); }
            if (reader.IsDBNull(FLD_MATERIALRECEIVEPROJECTID)) { pRMWorkOrder_CustomEntity.MaterialReceiveProjectID = null; } else { pRMWorkOrder_CustomEntity.MaterialReceiveProjectID = reader.GetInt64(FLD_MATERIALRECEIVEPROJECTID); }
            if (reader.IsDBNull(FLD_ORIGINBRANDNAME)) { pRMWorkOrder_CustomEntity.OriginBrandName = String.Empty; } else { pRMWorkOrder_CustomEntity.OriginBrandName = reader.GetString(FLD_ORIGINBRANDNAME); }
            if (reader.IsDBNull(FLD_ORIGINSUPPLIERNAME)) { pRMWorkOrder_CustomEntity.OriginSupplierName = String.Empty; } else { pRMWorkOrder_CustomEntity.OriginSupplierName = reader.GetString(FLD_ORIGINSUPPLIERNAME); }
            if (reader.IsDBNull(FLD_ORIGINREGIONNAME)) { pRMWorkOrder_CustomEntity.OriginRegionName = String.Empty; } else { pRMWorkOrder_CustomEntity.OriginRegionName = reader.GetString(FLD_ORIGINREGIONNAME); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRYNAME)) { pRMWorkOrder_CustomEntity.OriginCountryName = String.Empty; } else { pRMWorkOrder_CustomEntity.OriginCountryName = reader.GetString(FLD_ORIGINCOUNTRYNAME); }
            if (reader.IsDBNull(FLD_ITEMID)) { pRMWorkOrder_CustomEntity.ItemID = null; } else { pRMWorkOrder_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { pRMWorkOrder_CustomEntity.ItemName = String.Empty; } else { pRMWorkOrder_CustomEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMWorkOrder_CustomEntity.UnitName = String.Empty; } else { pRMWorkOrder_CustomEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMWorkOrder_CustomEntity.RowNumber = null; } else { pRMWorkOrder_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMWorkOrder_CustomEntity;
        }
    }
}
