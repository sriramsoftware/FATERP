// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 10:51:15




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class REQRequisitionWithWorkOrder_CustomBuilder : IEntityBuilder<REQRequisitionWithWorkOrder_CustomEntity>
    {
        IList<REQRequisitionWithWorkOrder_CustomEntity> IEntityBuilder<REQRequisitionWithWorkOrder_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisitionWithWorkOrder_CustomEntity> REQRequisitionWithWorkOrder_CustomEntityList = new List<REQRequisitionWithWorkOrder_CustomEntity>();

            while (reader.Read())
            {
                REQRequisitionWithWorkOrder_CustomEntityList.Add(((IEntityBuilder<REQRequisitionWithWorkOrder_CustomEntity>)this).BuildEntity(reader));
            }

            return (REQRequisitionWithWorkOrder_CustomEntityList.Count > 0) ? REQRequisitionWithWorkOrder_CustomEntityList : null;
        }

        REQRequisitionWithWorkOrder_CustomEntity IEntityBuilder<REQRequisitionWithWorkOrder_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_REQUISITIONNO = 2;
            const Int32 FLD_REQUISITIONDATE = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_REQUISITIONSTATUSID = 5;
            const Int32 FLD_PROJECTNAME = 6;
            const Int32 FLD_PROJECTCODE = 7;
            const Int32 FLD_REQUISITIONSTATUSNAME = 8;
            const Int32 FLD_WORKORDERID = 9;
            const Int32 FLD_ROWNUMBER = 10;

            REQRequisitionWithWorkOrder_CustomEntity rEQRequisitionWithWorkOrder_CustomEntity = new REQRequisitionWithWorkOrder_CustomEntity();

            rEQRequisitionWithWorkOrder_CustomEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            rEQRequisitionWithWorkOrder_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            rEQRequisitionWithWorkOrder_CustomEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);
            rEQRequisitionWithWorkOrder_CustomEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { rEQRequisitionWithWorkOrder_CustomEntity.Remarks = String.Empty; } else { rEQRequisitionWithWorkOrder_CustomEntity.Remarks = reader.GetString(FLD_REMARKS); }
            rEQRequisitionWithWorkOrder_CustomEntity.RequisitionStatusID = reader.GetInt64(FLD_REQUISITIONSTATUSID);
            if (reader.IsDBNull(FLD_PROJECTNAME)) { rEQRequisitionWithWorkOrder_CustomEntity.ProjectName = String.Empty; } else { rEQRequisitionWithWorkOrder_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { rEQRequisitionWithWorkOrder_CustomEntity.ProjectCode = String.Empty; } else { rEQRequisitionWithWorkOrder_CustomEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_REQUISITIONSTATUSNAME)) { rEQRequisitionWithWorkOrder_CustomEntity.RequisitionStatusName = String.Empty; } else { rEQRequisitionWithWorkOrder_CustomEntity.RequisitionStatusName = reader.GetString(FLD_REQUISITIONSTATUSNAME); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { rEQRequisitionWithWorkOrder_CustomEntity.WorkOrderID = null; } else { rEQRequisitionWithWorkOrder_CustomEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { rEQRequisitionWithWorkOrder_CustomEntity.RowNumber = null; } else { rEQRequisitionWithWorkOrder_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return rEQRequisitionWithWorkOrder_CustomEntity;
        }
    }
}
