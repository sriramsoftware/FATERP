// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APApprovalProcessBuilder : IEntityBuilder<APApprovalProcessEntity>
    {
        IList<APApprovalProcessEntity> IEntityBuilder<APApprovalProcessEntity>.BuildEntities(IDataReader reader)
        {
            List<APApprovalProcessEntity> APApprovalProcessEntityList = new List<APApprovalProcessEntity>();

            while (reader.Read())
            {
                APApprovalProcessEntityList.Add(((IEntityBuilder<APApprovalProcessEntity>)this).BuildEntity(reader));
            }

            return (APApprovalProcessEntityList.Count > 0) ? APApprovalProcessEntityList : null;
        }

        APApprovalProcessEntity IEntityBuilder<APApprovalProcessEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APAPPROVALPROCESSID = 0;
            const Int32 FLD_APTYPEID = 1;
            const Int32 FLD_REFERENCEID = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_TITLE = 4;
            const Int32 FLD_CREATEDATE = 5;
            const Int32 FLD_APSTATUSID = 6;

            APApprovalProcessEntity aPApprovalProcessEntity = new APApprovalProcessEntity();

            aPApprovalProcessEntity.APApprovalProcessID = reader.GetInt64(FLD_APAPPROVALPROCESSID);
            aPApprovalProcessEntity.APTypeID = reader.GetInt64(FLD_APTYPEID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { aPApprovalProcessEntity.ReferenceID = null; } else { aPApprovalProcessEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aPApprovalProcessEntity.Description = String.Empty; } else { aPApprovalProcessEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_TITLE)) { aPApprovalProcessEntity.Title = String.Empty; } else { aPApprovalProcessEntity.Title = reader.GetString(FLD_TITLE); }
            aPApprovalProcessEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            aPApprovalProcessEntity.APStatusID = reader.GetInt64(FLD_APSTATUSID);

            return aPApprovalProcessEntity;
        }
    }
}
