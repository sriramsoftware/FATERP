// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-May-2012, 04:19:57




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMPreBOQBuilder : IEntityBuilder<PRMPreBOQEntity>
    {
        IList<PRMPreBOQEntity> IEntityBuilder<PRMPreBOQEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQEntity> PRMPreBOQEntityList = new List<PRMPreBOQEntity>();

            while (reader.Read())
            {
                PRMPreBOQEntityList.Add(((IEntityBuilder<PRMPreBOQEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQEntityList.Count > 0) ? PRMPreBOQEntityList : null;
        }

        PRMPreBOQEntity IEntityBuilder<PRMPreBOQEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREBOQID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_STARTDATE = 2;
            const Int32 FLD_PREPAREDBYMEMBERID = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_PREBOQSTATUSID = 5;
            const Int32 FLD_ISREMOVED = 6;
            const Int32 FLD_ISLOCKED = 7;

            PRMPreBOQEntity pRMPreBOQEntity = new PRMPreBOQEntity();

            pRMPreBOQEntity.PreBOQID = reader.GetInt64(FLD_PREBOQID);
            pRMPreBOQEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_STARTDATE)) { pRMPreBOQEntity.StartDate = null; } else { pRMPreBOQEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }
            pRMPreBOQEntity.PreparedByMemberID = reader.GetInt64(FLD_PREPAREDBYMEMBERID);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMPreBOQEntity.Remarks = String.Empty; } else { pRMPreBOQEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_PREBOQSTATUSID)) { pRMPreBOQEntity.PreBOQStatusID = null; } else { pRMPreBOQEntity.PreBOQStatusID = reader.GetInt64(FLD_PREBOQSTATUSID); }
            pRMPreBOQEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            pRMPreBOQEntity.IsLocked = reader.GetBoolean(FLD_ISLOCKED);

            return pRMPreBOQEntity;
        }
    }
}
