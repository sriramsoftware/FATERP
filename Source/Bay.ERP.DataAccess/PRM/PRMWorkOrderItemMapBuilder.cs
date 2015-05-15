// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Nov-2012, 01:32:58




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderItemMapBuilder : IEntityBuilder<PRMWorkOrderItemMapEntity>
    {
        IList<PRMWorkOrderItemMapEntity> IEntityBuilder<PRMWorkOrderItemMapEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderItemMapEntity> PRMWorkOrderItemMapEntityList = new List<PRMWorkOrderItemMapEntity>();

            while (reader.Read())
            {
                PRMWorkOrderItemMapEntityList.Add(((IEntityBuilder<PRMWorkOrderItemMapEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderItemMapEntityList.Count > 0) ? PRMWorkOrderItemMapEntityList : null;
        }

        PRMWorkOrderItemMapEntity IEntityBuilder<PRMWorkOrderItemMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERITEMMAPID = 0;
            const Int32 FLD_WORKORDERID = 1;
            const Int32 FLD_REQUISITIONID = 2;
            const Int32 FLD_REQUISITIONITEMID = 3;
            const Int32 FLD_REQUIREDQTY = 4;
            const Int32 FLD_RATE = 5;
            const Int32 FLD_DELIVERYADDRESS = 6;
            const Int32 FLD_DESCRIPTION = 7;
            const Int32 FLD_WORKORDERSTATUSID = 8;

            PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity = new PRMWorkOrderItemMapEntity();

            pRMWorkOrderItemMapEntity.WorkOrderItemMapID = reader.GetInt64(FLD_WORKORDERITEMMAPID);
            pRMWorkOrderItemMapEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMWorkOrderItemMapEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            pRMWorkOrderItemMapEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            pRMWorkOrderItemMapEntity.RequiredQty = reader.GetDecimal(FLD_REQUIREDQTY);
            pRMWorkOrderItemMapEntity.Rate = reader.GetDecimal(FLD_RATE);
            if (reader.IsDBNull(FLD_DELIVERYADDRESS)) { pRMWorkOrderItemMapEntity.DeliveryAddress = String.Empty; } else { pRMWorkOrderItemMapEntity.DeliveryAddress = reader.GetString(FLD_DELIVERYADDRESS); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { pRMWorkOrderItemMapEntity.Description = String.Empty; } else { pRMWorkOrderItemMapEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            pRMWorkOrderItemMapEntity.WorkOrderStatusID = reader.GetInt64(FLD_WORKORDERSTATUSID);

            return pRMWorkOrderItemMapEntity;
        }
    }
}
