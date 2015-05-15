// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Sep-2012, 04:31:29




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderItemDetail_DetailedBuilder : IEntityBuilder<PRMWorkOrderItemDetail_DetailedEntity>
    {
        IList<PRMWorkOrderItemDetail_DetailedEntity> IEntityBuilder<PRMWorkOrderItemDetail_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderItemDetail_DetailedEntity> PRMWorkOrderItemDetail_DetailedEntityList = new List<PRMWorkOrderItemDetail_DetailedEntity>();

            while (reader.Read())
            {
                PRMWorkOrderItemDetail_DetailedEntityList.Add(((IEntityBuilder<PRMWorkOrderItemDetail_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderItemDetail_DetailedEntityList.Count > 0) ? PRMWorkOrderItemDetail_DetailedEntityList : null;
        }

        PRMWorkOrderItemDetail_DetailedEntity IEntityBuilder<PRMWorkOrderItemDetail_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERITEMDETAILID = 0;
            const Int32 FLD_WORKORDERITEMMAPID = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_UNITID = 3;
            const Int32 FLD_RATE = 4;
            const Int32 FLD_QTY = 5;
            const Int32 FLD_PRMWORKORDERITEMMAPWORKORDERID = 6;
            const Int32 FLD_UNITNAME = 7;
            const Int32 FLD_ROWNUMBER = 8;

            PRMWorkOrderItemDetail_DetailedEntity pRMWorkOrderItemDetail_DetailedEntity = new PRMWorkOrderItemDetail_DetailedEntity();

            pRMWorkOrderItemDetail_DetailedEntity.WorkOrderItemDetailID = reader.GetInt64(FLD_WORKORDERITEMDETAILID);
            pRMWorkOrderItemDetail_DetailedEntity.WorkOrderItemMapID = reader.GetInt64(FLD_WORKORDERITEMMAPID);
            pRMWorkOrderItemDetail_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION);
            if (reader.IsDBNull(FLD_UNITID)) { pRMWorkOrderItemDetail_DetailedEntity.UnitID = null; } else { pRMWorkOrderItemDetail_DetailedEntity.UnitID = reader.GetInt64(FLD_UNITID); }
            pRMWorkOrderItemDetail_DetailedEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMWorkOrderItemDetail_DetailedEntity.Qty = reader.GetDecimal(FLD_QTY);
            if (reader.IsDBNull(FLD_PRMWORKORDERITEMMAPWORKORDERID)) { pRMWorkOrderItemDetail_DetailedEntity.PRMWorkOrderItemMapWorkOrderID = null; } else { pRMWorkOrderItemDetail_DetailedEntity.PRMWorkOrderItemMapWorkOrderID = reader.GetInt64(FLD_PRMWORKORDERITEMMAPWORKORDERID); }
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMWorkOrderItemDetail_DetailedEntity.UnitName = String.Empty; } else { pRMWorkOrderItemDetail_DetailedEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMWorkOrderItemDetail_DetailedEntity.RowNumber = null; } else { pRMWorkOrderItemDetail_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMWorkOrderItemDetail_DetailedEntity;
        }
    }
}
