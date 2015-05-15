// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Aug-2013, 05:21:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderItemFloorDetailBuilder : IEntityBuilder<PRMWorkOrderItemFloorDetailEntity>
    {
        IList<PRMWorkOrderItemFloorDetailEntity> IEntityBuilder<PRMWorkOrderItemFloorDetailEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderItemFloorDetailEntity> PRMWorkOrderItemFloorDetailEntityList = new List<PRMWorkOrderItemFloorDetailEntity>();

            while (reader.Read())
            {
                PRMWorkOrderItemFloorDetailEntityList.Add(((IEntityBuilder<PRMWorkOrderItemFloorDetailEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderItemFloorDetailEntityList.Count > 0) ? PRMWorkOrderItemFloorDetailEntityList : null;
        }

        PRMWorkOrderItemFloorDetailEntity IEntityBuilder<PRMWorkOrderItemFloorDetailEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERITEMFLOORDETAILID = 0;
            const Int32 FLD_WORKORDERITEMMAPID = 1;
            const Int32 FLD_WORKORDERID = 2;
            const Int32 FLD_REQUISITIONID = 3;
            const Int32 FLD_REQUISITIONITEMID = 4;
            const Int32 FLD_PROJECTFLOORID = 5;
            const Int32 FLD_PROJECTFLOORUNITID = 6;
            const Int32 FLD_QTY = 7;
            const Int32 FLD_RATE = 8;
            const Int32 FLD_REMARKS = 9;
            const Int32 FLD_ENTRYDATE = 10;

            PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity = new PRMWorkOrderItemFloorDetailEntity();

            pRMWorkOrderItemFloorDetailEntity.WorkOrderItemFloorDetailID = reader.GetInt64(FLD_WORKORDERITEMFLOORDETAILID);
            pRMWorkOrderItemFloorDetailEntity.WorkOrderItemMapID = reader.GetInt64(FLD_WORKORDERITEMMAPID);
            pRMWorkOrderItemFloorDetailEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMWorkOrderItemFloorDetailEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            pRMWorkOrderItemFloorDetailEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            pRMWorkOrderItemFloorDetailEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { pRMWorkOrderItemFloorDetailEntity.ProjectFloorUnitID = null; } else { pRMWorkOrderItemFloorDetailEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_QTY)) { pRMWorkOrderItemFloorDetailEntity.Qty = null; } else { pRMWorkOrderItemFloorDetailEntity.Qty = reader.GetDecimal(FLD_QTY); }
            if (reader.IsDBNull(FLD_RATE)) { pRMWorkOrderItemFloorDetailEntity.Rate = null; } else { pRMWorkOrderItemFloorDetailEntity.Rate = reader.GetDecimal(FLD_RATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { pRMWorkOrderItemFloorDetailEntity.Remarks = String.Empty; } else { pRMWorkOrderItemFloorDetailEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMWorkOrderItemFloorDetailEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);

            return pRMWorkOrderItemFloorDetailEntity;
        }
    }
}
