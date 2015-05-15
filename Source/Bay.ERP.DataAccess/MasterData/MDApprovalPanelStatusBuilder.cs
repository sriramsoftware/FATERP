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
    internal sealed class MDApprovalPanelStatusBuilder : IEntityBuilder<MDApprovalPanelStatusEntity>
    {
        IList<MDApprovalPanelStatusEntity> IEntityBuilder<MDApprovalPanelStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDApprovalPanelStatusEntity> MDApprovalPanelStatusEntityList = new List<MDApprovalPanelStatusEntity>();

            while (reader.Read())
            {
                MDApprovalPanelStatusEntityList.Add(((IEntityBuilder<MDApprovalPanelStatusEntity>)this).BuildEntity(reader));
            }

            return (MDApprovalPanelStatusEntityList.Count > 0) ? MDApprovalPanelStatusEntityList : null;
        }

        MDApprovalPanelStatusEntity IEntityBuilder<MDApprovalPanelStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPROVALPANELSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDApprovalPanelStatusEntity mDApprovalPanelStatusEntity = new MDApprovalPanelStatusEntity();

            mDApprovalPanelStatusEntity.ApprovalPanelStatusID = reader.GetInt64(FLD_APPROVALPANELSTATUSID);
            mDApprovalPanelStatusEntity.Name = reader.GetString(FLD_NAME);
            mDApprovalPanelStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDApprovalPanelStatusEntity;
        }
    }
}
