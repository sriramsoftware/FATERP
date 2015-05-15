// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2012, 04:57:13




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderItemDetailBuilder : IEntityBuilder<PRMWorkOrderItemDetailEntity>
    {
        IList<PRMWorkOrderItemDetailEntity> IEntityBuilder<PRMWorkOrderItemDetailEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderItemDetailEntity> PRMWorkOrderItemDetailEntityList = new List<PRMWorkOrderItemDetailEntity>();

            while (reader.Read())
            {
                PRMWorkOrderItemDetailEntityList.Add(((IEntityBuilder<PRMWorkOrderItemDetailEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderItemDetailEntityList.Count > 0) ? PRMWorkOrderItemDetailEntityList : null;
        }

        PRMWorkOrderItemDetailEntity IEntityBuilder<PRMWorkOrderItemDetailEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERITEMDETAILID = 0;
            const Int32 FLD_WORKORDERITEMMAPID = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_UNITID = 3;
            const Int32 FLD_RATE = 4;
            const Int32 FLD_QTY = 5;

            PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();

            pRMWorkOrderItemDetailEntity.WorkOrderItemDetailID = reader.GetInt64(FLD_WORKORDERITEMDETAILID);
            pRMWorkOrderItemDetailEntity.WorkOrderItemMapID = reader.GetInt64(FLD_WORKORDERITEMMAPID);
            pRMWorkOrderItemDetailEntity.Description = reader.GetString(FLD_DESCRIPTION);
            if (reader.IsDBNull(FLD_UNITID)) { pRMWorkOrderItemDetailEntity.UnitID = null; } else { pRMWorkOrderItemDetailEntity.UnitID = reader.GetInt64(FLD_UNITID); }
            pRMWorkOrderItemDetailEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMWorkOrderItemDetailEntity.Qty = reader.GetDecimal(FLD_QTY);

            return pRMWorkOrderItemDetailEntity;
        }
    }
}
