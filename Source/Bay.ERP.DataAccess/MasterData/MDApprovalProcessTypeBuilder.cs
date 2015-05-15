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
    internal sealed class MDApprovalProcessTypeBuilder : IEntityBuilder<MDApprovalProcessTypeEntity>
    {
        IList<MDApprovalProcessTypeEntity> IEntityBuilder<MDApprovalProcessTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDApprovalProcessTypeEntity> MDApprovalProcessTypeEntityList = new List<MDApprovalProcessTypeEntity>();

            while (reader.Read())
            {
                MDApprovalProcessTypeEntityList.Add(((IEntityBuilder<MDApprovalProcessTypeEntity>)this).BuildEntity(reader));
            }

            return (MDApprovalProcessTypeEntityList.Count > 0) ? MDApprovalProcessTypeEntityList : null;
        }

        MDApprovalProcessTypeEntity IEntityBuilder<MDApprovalProcessTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPROVALPROCESSTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDApprovalProcessTypeEntity mDApprovalProcessTypeEntity = new MDApprovalProcessTypeEntity();

            mDApprovalProcessTypeEntity.ApprovalProcessTypeID = reader.GetInt64(FLD_APPROVALPROCESSTYPEID);
            mDApprovalProcessTypeEntity.Name = reader.GetString(FLD_NAME);
            mDApprovalProcessTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDApprovalProcessTypeEntity;
        }
    }
}
