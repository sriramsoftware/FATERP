// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2011, 02:42:27




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMPreBOQ_DetailedBuilder : IEntityBuilder<PRMPreBOQ_DetailedEntity>
    {
        IList<PRMPreBOQ_DetailedEntity> IEntityBuilder<PRMPreBOQ_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQ_DetailedEntity> PRMPreBOQ_DetailedEntityList = new List<PRMPreBOQ_DetailedEntity>();

            while (reader.Read())
            {
                PRMPreBOQ_DetailedEntityList.Add(((IEntityBuilder<PRMPreBOQ_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQ_DetailedEntityList.Count > 0) ? PRMPreBOQ_DetailedEntityList : null;
        }

        PRMPreBOQ_DetailedEntity IEntityBuilder<PRMPreBOQ_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREBOQID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_STARTDATE = 2;
            const Int32 FLD_PREPAREDBYMEMBERID = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_PREBOQSTATUSID = 5;
            const Int32 FLD_ISREMOVED = 6;
            const Int32 FLD_BDPROJECTPROJECTNAME = 7;
            const Int32 FLD_HRMEMBERFIRSTNAME = 8;
            const Int32 FLD_MDPREBOQSTATUSNAME = 9;
            const Int32 FLD_ROWNUMBER = 10;

            PRMPreBOQ_DetailedEntity pRMPreBOQ_DetailedEntity = new PRMPreBOQ_DetailedEntity();

            pRMPreBOQ_DetailedEntity.PreBOQID = reader.GetInt64(FLD_PREBOQID);
            pRMPreBOQ_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            pRMPreBOQ_DetailedEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            pRMPreBOQ_DetailedEntity.PreparedByMemberID = reader.GetInt64(FLD_PREPAREDBYMEMBERID);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMPreBOQ_DetailedEntity.Remarks = String.Empty; } else { pRMPreBOQ_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMPreBOQ_DetailedEntity.PreBOQStatusID = reader.GetInt64(FLD_PREBOQSTATUSID);
            pRMPreBOQ_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { pRMPreBOQ_DetailedEntity.BDProjectProjectName = String.Empty; } else { pRMPreBOQ_DetailedEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_HRMEMBERFIRSTNAME)) { pRMPreBOQ_DetailedEntity.HRMemberFirstName = String.Empty; } else { pRMPreBOQ_DetailedEntity.HRMemberFirstName = reader.GetString(FLD_HRMEMBERFIRSTNAME); }
            if (reader.IsDBNull(FLD_MDPREBOQSTATUSNAME)) { pRMPreBOQ_DetailedEntity.MDPreBOQStatusName = String.Empty; } else { pRMPreBOQ_DetailedEntity.MDPreBOQStatusName = reader.GetString(FLD_MDPREBOQSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMPreBOQ_DetailedEntity.RowNumber = null; } else { pRMPreBOQ_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMPreBOQ_DetailedEntity;
        }
    }
}
