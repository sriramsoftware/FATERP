// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Aug-2013, 02:00:59




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderItemFloorDetail_RPTBuilder : IEntityBuilder<PRMWorkOrderItemFloorDetail_RPTEntity>
    {
        IList<PRMWorkOrderItemFloorDetail_RPTEntity> IEntityBuilder<PRMWorkOrderItemFloorDetail_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderItemFloorDetail_RPTEntity> PRMWorkOrderItemFloorDetail_RPTEntityList = new List<PRMWorkOrderItemFloorDetail_RPTEntity>();

            while (reader.Read())
            {
                PRMWorkOrderItemFloorDetail_RPTEntityList.Add(((IEntityBuilder<PRMWorkOrderItemFloorDetail_RPTEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderItemFloorDetail_RPTEntityList.Count > 0) ? PRMWorkOrderItemFloorDetail_RPTEntityList : null;
        }

        PRMWorkOrderItemFloorDetail_RPTEntity IEntityBuilder<PRMWorkOrderItemFloorDetail_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERITEMFLOORDETAILID = 0;
            const Int32 FLD_WORKORDERITEMMAPID = 1;
            const Int32 FLD_REQUISITIONID = 2;
            const Int32 FLD_REQUISITIONITEMID = 3;
            const Int32 FLD_PROJECTFLOORID = 4;
            const Int32 FLD_PROJECTFLOORUNITID = 5;
            const Int32 FLD_QTY = 6;
            const Int32 FLD_RATE = 7;
            const Int32 FLD_REMARKS = 8;
            const Int32 FLD_ENTRYDATE = 9;
            const Int32 FLD_REQUISITIONNO = 10;
            const Int32 FLD_PROJECTCODE = 11;
            const Int32 FLD_PROJECTNAME = 12;
            const Int32 FLD_BDPROJECTFLOORNAME = 13;
            const Int32 FLD_PROJECTFLOORUNITNAME = 14;
            const Int32 FLD_ITEMNAME = 15;
            const Int32 FLD_ITEMID = 16;
            const Int32 FLD_WORKORDERID = 17;
            const Int32 FLD_WORKORDERNO = 18;

            PRMWorkOrderItemFloorDetail_RPTEntity pRMWorkOrderItemFloorDetail_RPTEntity = new PRMWorkOrderItemFloorDetail_RPTEntity();

            pRMWorkOrderItemFloorDetail_RPTEntity.WorkOrderItemFloorDetailID = reader.GetInt64(FLD_WORKORDERITEMFLOORDETAILID);
            pRMWorkOrderItemFloorDetail_RPTEntity.WorkOrderItemMapID = reader.GetInt64(FLD_WORKORDERITEMMAPID);
            pRMWorkOrderItemFloorDetail_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            pRMWorkOrderItemFloorDetail_RPTEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            pRMWorkOrderItemFloorDetail_RPTEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { pRMWorkOrderItemFloorDetail_RPTEntity.ProjectFloorUnitID = null; } else { pRMWorkOrderItemFloorDetail_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_QTY)) { pRMWorkOrderItemFloorDetail_RPTEntity.Qty = null; } else { pRMWorkOrderItemFloorDetail_RPTEntity.Qty = reader.GetDecimal(FLD_QTY); }
            if (reader.IsDBNull(FLD_RATE)) { pRMWorkOrderItemFloorDetail_RPTEntity.Rate = null; } else { pRMWorkOrderItemFloorDetail_RPTEntity.Rate = reader.GetDecimal(FLD_RATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { pRMWorkOrderItemFloorDetail_RPTEntity.Remarks = String.Empty; } else { pRMWorkOrderItemFloorDetail_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMWorkOrderItemFloorDetail_RPTEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { pRMWorkOrderItemFloorDetail_RPTEntity.RequisitionNo = String.Empty; } else { pRMWorkOrderItemFloorDetail_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { pRMWorkOrderItemFloorDetail_RPTEntity.ProjectCode = String.Empty; } else { pRMWorkOrderItemFloorDetail_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { pRMWorkOrderItemFloorDetail_RPTEntity.ProjectName = String.Empty; } else { pRMWorkOrderItemFloorDetail_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_BDPROJECTFLOORNAME)) { pRMWorkOrderItemFloorDetail_RPTEntity.BDProjectFloorName = String.Empty; } else { pRMWorkOrderItemFloorDetail_RPTEntity.BDProjectFloorName = reader.GetString(FLD_BDPROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { pRMWorkOrderItemFloorDetail_RPTEntity.ProjectFloorUnitName = String.Empty; } else { pRMWorkOrderItemFloorDetail_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { pRMWorkOrderItemFloorDetail_RPTEntity.ItemName = String.Empty; } else { pRMWorkOrderItemFloorDetail_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_ITEMID)) { pRMWorkOrderItemFloorDetail_RPTEntity.ItemID = null; } else { pRMWorkOrderItemFloorDetail_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { pRMWorkOrderItemFloorDetail_RPTEntity.WorkOrderID = null; } else { pRMWorkOrderItemFloorDetail_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { pRMWorkOrderItemFloorDetail_RPTEntity.WorkOrderNo = String.Empty; } else { pRMWorkOrderItemFloorDetail_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }

            return pRMWorkOrderItemFloorDetail_RPTEntity;
        }
    }
}
