// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jun-2013, 04:42:43




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class REQRequisitionDashboard_CustomBuilder : IEntityBuilder<REQRequisitionDashboard_CustomEntity>
    {
        IList<REQRequisitionDashboard_CustomEntity> IEntityBuilder<REQRequisitionDashboard_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisitionDashboard_CustomEntity> REQRequisitionDashboard_CustomEntityList = new List<REQRequisitionDashboard_CustomEntity>();

            while (reader.Read())
            {
                REQRequisitionDashboard_CustomEntityList.Add(((IEntityBuilder<REQRequisitionDashboard_CustomEntity>)this).BuildEntity(reader));
            }

            return (REQRequisitionDashboard_CustomEntityList.Count > 0) ? REQRequisitionDashboard_CustomEntityList : null;
        }

        REQRequisitionDashboard_CustomEntity IEntityBuilder<REQRequisitionDashboard_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_REQUISITIONNO = 2;
            const Int32 FLD_REQUISITIONDATE = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_REQUISITIONSTATUSID = 5;
            const Int32 FLD_ISCASHPAYMENT = 6;
            const Int32 FLD_ISACCOUNTSMADEPAYMENT = 7;
            const Int32 FLD_PROJECTNAME = 8;
            const Int32 FLD_PROJECTCODE = 9;
            const Int32 FLD_REQUISITIONSTATUSNAME = 10;
            const Int32 FLD_ROWNUMBER = 11;

            REQRequisitionDashboard_CustomEntity rEQRequisitionDashboard_CustomEntity = new REQRequisitionDashboard_CustomEntity();

            rEQRequisitionDashboard_CustomEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            rEQRequisitionDashboard_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            rEQRequisitionDashboard_CustomEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);
            rEQRequisitionDashboard_CustomEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { rEQRequisitionDashboard_CustomEntity.Remarks = String.Empty; } else { rEQRequisitionDashboard_CustomEntity.Remarks = reader.GetString(FLD_REMARKS); }
            rEQRequisitionDashboard_CustomEntity.RequisitionStatusID = reader.GetInt64(FLD_REQUISITIONSTATUSID);
            rEQRequisitionDashboard_CustomEntity.IsCashPayment = reader.GetBoolean(FLD_ISCASHPAYMENT);
            rEQRequisitionDashboard_CustomEntity.IsAccountsMadePayment = reader.GetBoolean(FLD_ISACCOUNTSMADEPAYMENT);
            if (reader.IsDBNull(FLD_PROJECTNAME)) { rEQRequisitionDashboard_CustomEntity.ProjectName = String.Empty; } else { rEQRequisitionDashboard_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { rEQRequisitionDashboard_CustomEntity.ProjectCode = String.Empty; } else { rEQRequisitionDashboard_CustomEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_REQUISITIONSTATUSNAME)) { rEQRequisitionDashboard_CustomEntity.RequisitionStatusName = String.Empty; } else { rEQRequisitionDashboard_CustomEntity.RequisitionStatusName = reader.GetString(FLD_REQUISITIONSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { rEQRequisitionDashboard_CustomEntity.RowNumber = null; } else { rEQRequisitionDashboard_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return rEQRequisitionDashboard_CustomEntity;
        }
    }
}
