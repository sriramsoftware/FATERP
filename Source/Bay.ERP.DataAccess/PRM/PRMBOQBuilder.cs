// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMBOQBuilder : IEntityBuilder<PRMBOQEntity>
    {
        IList<PRMBOQEntity> IEntityBuilder<PRMBOQEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMBOQEntity> PRMBOQEntityList = new List<PRMBOQEntity>();

            while (reader.Read())
            {
                PRMBOQEntityList.Add(((IEntityBuilder<PRMBOQEntity>)this).BuildEntity(reader));
            }

            return (PRMBOQEntityList.Count > 0) ? PRMBOQEntityList : null;
        }

        PRMBOQEntity IEntityBuilder<PRMBOQEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOQID = 0;
            const Int32 FLD_PREBOQID = 1;
            const Int32 FLD_PROJECTID = 2;
            const Int32 FLD_STARTDATE = 3;
            const Int32 FLD_PREPAREDBYMEMBERID = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_BOQSTATUSID = 6;
            const Int32 FLD_ISREMOVED = 7;

            PRMBOQEntity pRMBOQEntity = new PRMBOQEntity();

            pRMBOQEntity.BOQID = reader.GetInt64(FLD_BOQID);
            pRMBOQEntity.PreBOQID = reader.GetInt64(FLD_PREBOQID);
            pRMBOQEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_STARTDATE)) { pRMBOQEntity.StartDate = null; } else { pRMBOQEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }
            pRMBOQEntity.PreparedByMemberID = reader.GetInt64(FLD_PREPAREDBYMEMBERID);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMBOQEntity.Remarks = String.Empty; } else { pRMBOQEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_BOQSTATUSID)) { pRMBOQEntity.BOQStatusID = null; } else { pRMBOQEntity.BOQStatusID = reader.GetInt64(FLD_BOQSTATUSID); }
            pRMBOQEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return pRMBOQEntity;
        }
    }
}
