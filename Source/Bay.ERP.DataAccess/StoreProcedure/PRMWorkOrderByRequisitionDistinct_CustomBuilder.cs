// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jul-2012, 03:56:56




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderByRequisitionDistinct_CustomBuilder : IEntityBuilder<PRMWorkOrderByRequisitionDistinct_CustomEntity>
    {
        IList<PRMWorkOrderByRequisitionDistinct_CustomEntity> IEntityBuilder<PRMWorkOrderByRequisitionDistinct_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderByRequisitionDistinct_CustomEntity> PRMWorkOrderByRequisitionDistinct_CustomEntityList = new List<PRMWorkOrderByRequisitionDistinct_CustomEntity>();

            while (reader.Read())
            {
                PRMWorkOrderByRequisitionDistinct_CustomEntityList.Add(((IEntityBuilder<PRMWorkOrderByRequisitionDistinct_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderByRequisitionDistinct_CustomEntityList.Count > 0) ? PRMWorkOrderByRequisitionDistinct_CustomEntityList : null;
        }

        PRMWorkOrderByRequisitionDistinct_CustomEntity IEntityBuilder<PRMWorkOrderByRequisitionDistinct_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERID = 0;
            const Int32 FLD_WORKORDERNO = 1;
            const Int32 FLD_REQUISITIONID = 2;

            PRMWorkOrderByRequisitionDistinct_CustomEntity pRMWorkOrderByRequisitionDistinct_CustomEntity = new PRMWorkOrderByRequisitionDistinct_CustomEntity();

            pRMWorkOrderByRequisitionDistinct_CustomEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMWorkOrderByRequisitionDistinct_CustomEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO);
            pRMWorkOrderByRequisitionDistinct_CustomEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);

            return pRMWorkOrderByRequisitionDistinct_CustomEntity;
        }
    }
}
