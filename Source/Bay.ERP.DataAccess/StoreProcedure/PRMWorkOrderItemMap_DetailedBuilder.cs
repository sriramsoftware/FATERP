// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Sep-2013, 02:13:02




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderItemMap_DetailedBuilder : IEntityBuilder<PRMWorkOrderItemMap_DetailedEntity>
    {
        IList<PRMWorkOrderItemMap_DetailedEntity> IEntityBuilder<PRMWorkOrderItemMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderItemMap_DetailedEntity> PRMWorkOrderItemMap_DetailedEntityList = new List<PRMWorkOrderItemMap_DetailedEntity>();

            while (reader.Read())
            {
                PRMWorkOrderItemMap_DetailedEntityList.Add(((IEntityBuilder<PRMWorkOrderItemMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderItemMap_DetailedEntityList.Count > 0) ? PRMWorkOrderItemMap_DetailedEntityList : null;
        }

        PRMWorkOrderItemMap_DetailedEntity IEntityBuilder<PRMWorkOrderItemMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERITEMMAPID = 0;
            const Int32 FLD_WORKORDERID = 1;
            const Int32 FLD_REQUISITIONID = 2;
            const Int32 FLD_REQUISITIONITEMID = 3;
            const Int32 FLD_REQUIREDQTY = 4;
            const Int32 FLD_RATE = 5;
            const Int32 FLD_DELIVERYADDRESS = 6;
            const Int32 FLD_WORKORDERSTATUSID = 7;
            const Int32 FLD_WORKORDERNO = 8;
            const Int32 FLD_REQUISITIONNO = 9;
            const Int32 FLD_PROJECTID = 10;
            const Int32 FLD_ITEMID = 11;
            const Int32 FLD_ITEMNAME = 12;
            const Int32 FLD_UNITNAME = 13;
            const Int32 FLD_MDWORKORDERSTATUSNAME = 14;
            const Int32 FLD_ROWNUMBER = 15;

            PRMWorkOrderItemMap_DetailedEntity pRMWorkOrderItemMap_DetailedEntity = new PRMWorkOrderItemMap_DetailedEntity();

            pRMWorkOrderItemMap_DetailedEntity.WorkOrderItemMapID = reader.GetInt64(FLD_WORKORDERITEMMAPID);
            pRMWorkOrderItemMap_DetailedEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMWorkOrderItemMap_DetailedEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            pRMWorkOrderItemMap_DetailedEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            pRMWorkOrderItemMap_DetailedEntity.RequiredQty = reader.GetDecimal(FLD_REQUIREDQTY);
            pRMWorkOrderItemMap_DetailedEntity.Rate = reader.GetDecimal(FLD_RATE);
            if (reader.IsDBNull(FLD_DELIVERYADDRESS)) { pRMWorkOrderItemMap_DetailedEntity.DeliveryAddress = String.Empty; } else { pRMWorkOrderItemMap_DetailedEntity.DeliveryAddress = reader.GetString(FLD_DELIVERYADDRESS); }
            pRMWorkOrderItemMap_DetailedEntity.WorkOrderStatusID = reader.GetInt64(FLD_WORKORDERSTATUSID);
            if (reader.IsDBNull(FLD_WORKORDERNO)) { pRMWorkOrderItemMap_DetailedEntity.WorkOrderNo = String.Empty; } else { pRMWorkOrderItemMap_DetailedEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { pRMWorkOrderItemMap_DetailedEntity.RequisitionNo = String.Empty; } else { pRMWorkOrderItemMap_DetailedEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_PROJECTID)) { pRMWorkOrderItemMap_DetailedEntity.ProjectID = null; } else { pRMWorkOrderItemMap_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_ITEMID)) { pRMWorkOrderItemMap_DetailedEntity.ItemID = null; } else { pRMWorkOrderItemMap_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { pRMWorkOrderItemMap_DetailedEntity.ItemName = String.Empty; } else { pRMWorkOrderItemMap_DetailedEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMWorkOrderItemMap_DetailedEntity.UnitName = String.Empty; } else { pRMWorkOrderItemMap_DetailedEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_MDWORKORDERSTATUSNAME)) { pRMWorkOrderItemMap_DetailedEntity.MDWorkOrderStatusName = String.Empty; } else { pRMWorkOrderItemMap_DetailedEntity.MDWorkOrderStatusName = reader.GetString(FLD_MDWORKORDERSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMWorkOrderItemMap_DetailedEntity.RowNumber = null; } else { pRMWorkOrderItemMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMWorkOrderItemMap_DetailedEntity;
        }
    }
}
