// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNApprovalPanelBuilder : IEntityBuilder<CMNApprovalPanelEntity>
    {
        IList<CMNApprovalPanelEntity> IEntityBuilder<CMNApprovalPanelEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNApprovalPanelEntity> CMNApprovalPanelEntityList = new List<CMNApprovalPanelEntity>();

            while (reader.Read())
            {
                CMNApprovalPanelEntityList.Add(((IEntityBuilder<CMNApprovalPanelEntity>)this).BuildEntity(reader));
            }

            return (CMNApprovalPanelEntityList.Count > 0) ? CMNApprovalPanelEntityList : null;
        }

        CMNApprovalPanelEntity IEntityBuilder<CMNApprovalPanelEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPROVALPANELID = 0;
            const Int32 FLD_APPROVALPROCESSID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_SEQUEENCENO = 3;
            const Int32 FLD_APPROVALPANELSTATUSID = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_REQUESTDATE = 6;
            const Int32 FLD_RESPONSEDATE = 7;

            CMNApprovalPanelEntity cMNApprovalPanelEntity = new CMNApprovalPanelEntity();

            cMNApprovalPanelEntity.ApprovalPanelID = reader.GetInt64(FLD_APPROVALPANELID);
            cMNApprovalPanelEntity.ApprovalProcessID = reader.GetInt64(FLD_APPROVALPROCESSID);
            cMNApprovalPanelEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            cMNApprovalPanelEntity.SequeenceNo = reader.GetInt32(FLD_SEQUEENCENO);
            cMNApprovalPanelEntity.ApprovalPanelStatusID = reader.GetInt64(FLD_APPROVALPANELSTATUSID);
            if (reader.IsDBNull(FLD_REMARKS)) { cMNApprovalPanelEntity.Remarks = String.Empty; } else { cMNApprovalPanelEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMNApprovalPanelEntity.RequestDate = reader.GetDateTime(FLD_REQUESTDATE);
            if (reader.IsDBNull(FLD_RESPONSEDATE)) { cMNApprovalPanelEntity.ResponseDate = null; } else { cMNApprovalPanelEntity.ResponseDate = reader.GetDateTime(FLD_RESPONSEDATE); }

            return cMNApprovalPanelEntity;
        }
    }
}
