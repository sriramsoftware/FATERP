// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2013, 02:31:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderSingleClickFromRequisition_CustomBuilder : IEntityBuilder<PRMWorkOrderSingleClickFromRequisition_CustomEntity>
    {
        IList<PRMWorkOrderSingleClickFromRequisition_CustomEntity> IEntityBuilder<PRMWorkOrderSingleClickFromRequisition_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderSingleClickFromRequisition_CustomEntity> PRMWorkOrderSingleClickFromRequisition_CustomEntityList = new List<PRMWorkOrderSingleClickFromRequisition_CustomEntity>();

            while (reader.Read())
            {
                PRMWorkOrderSingleClickFromRequisition_CustomEntityList.Add(((IEntityBuilder<PRMWorkOrderSingleClickFromRequisition_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderSingleClickFromRequisition_CustomEntityList.Count > 0) ? PRMWorkOrderSingleClickFromRequisition_CustomEntityList : null;
        }

        PRMWorkOrderSingleClickFromRequisition_CustomEntity IEntityBuilder<PRMWorkOrderSingleClickFromRequisition_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERID = 0;

            PRMWorkOrderSingleClickFromRequisition_CustomEntity pRMWorkOrderSingleClickFromRequisition_CustomEntity = new PRMWorkOrderSingleClickFromRequisition_CustomEntity();

            if (reader.IsDBNull(FLD_WORKORDERID)) { pRMWorkOrderSingleClickFromRequisition_CustomEntity.WorkOrderID = null; } else { pRMWorkOrderSingleClickFromRequisition_CustomEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }

            return pRMWorkOrderSingleClickFromRequisition_CustomEntity;
        }
    }
}
