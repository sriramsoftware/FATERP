// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jun-2013, 05:57:56




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APApprovalProcessPanelMapBuilder : IEntityBuilder<APApprovalProcessPanelMapEntity>
    {
        IList<APApprovalProcessPanelMapEntity> IEntityBuilder<APApprovalProcessPanelMapEntity>.BuildEntities(IDataReader reader)
        {
            List<APApprovalProcessPanelMapEntity> APApprovalProcessPanelMapEntityList = new List<APApprovalProcessPanelMapEntity>();

            while (reader.Read())
            {
                APApprovalProcessPanelMapEntityList.Add(((IEntityBuilder<APApprovalProcessPanelMapEntity>)this).BuildEntity(reader));
            }

            return (APApprovalProcessPanelMapEntityList.Count > 0) ? APApprovalProcessPanelMapEntityList : null;
        }

        APApprovalProcessPanelMapEntity IEntityBuilder<APApprovalProcessPanelMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPROVALPROCESSPANELMAPID = 0;
            const Int32 FLD_APAPPROVALPROCESSID = 1;
            const Int32 FLD_APPANELID = 2;
            const Int32 FLD_REMARKS = 3;

            APApprovalProcessPanelMapEntity aPApprovalProcessPanelMapEntity = new APApprovalProcessPanelMapEntity();

            aPApprovalProcessPanelMapEntity.ApprovalProcessPanelMapID = reader.GetInt64(FLD_APPROVALPROCESSPANELMAPID);
            aPApprovalProcessPanelMapEntity.APApprovalProcessID = reader.GetInt64(FLD_APAPPROVALPROCESSID);
            aPApprovalProcessPanelMapEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            if (reader.IsDBNull(FLD_REMARKS)) { aPApprovalProcessPanelMapEntity.Remarks = String.Empty; } else { aPApprovalProcessPanelMapEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return aPApprovalProcessPanelMapEntity;
        }
    }
}
