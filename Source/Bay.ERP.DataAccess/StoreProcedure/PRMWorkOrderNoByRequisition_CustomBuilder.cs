// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Dec-2012, 10:27:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderNoByRequisition_CustomBuilder : IEntityBuilder<PRMWorkOrderNoByRequisition_CustomEntity>
    {
        IList<PRMWorkOrderNoByRequisition_CustomEntity> IEntityBuilder<PRMWorkOrderNoByRequisition_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderNoByRequisition_CustomEntity> PRMWorkOrderNoByRequisition_CustomEntityList = new List<PRMWorkOrderNoByRequisition_CustomEntity>();

            while (reader.Read())
            {
                PRMWorkOrderNoByRequisition_CustomEntityList.Add(((IEntityBuilder<PRMWorkOrderNoByRequisition_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderNoByRequisition_CustomEntityList.Count > 0) ? PRMWorkOrderNoByRequisition_CustomEntityList : null;
        }

        PRMWorkOrderNoByRequisition_CustomEntity IEntityBuilder<PRMWorkOrderNoByRequisition_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONID = 0;
            const Int32 FLD_WORKORDERNO = 1;
            const Int32 FLD_REQUISITIONNO = 2;

            PRMWorkOrderNoByRequisition_CustomEntity pRMWorkOrderNoByRequisition_CustomEntity = new PRMWorkOrderNoByRequisition_CustomEntity();

            pRMWorkOrderNoByRequisition_CustomEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            if (reader.IsDBNull(FLD_WORKORDERNO)) { pRMWorkOrderNoByRequisition_CustomEntity.WorkOrderNo = null; } else { pRMWorkOrderNoByRequisition_CustomEntity.WorkOrderNo = reader.GetInt32(FLD_WORKORDERNO); }
            pRMWorkOrderNoByRequisition_CustomEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);

            return pRMWorkOrderNoByRequisition_CustomEntity;
        }
    }
}
