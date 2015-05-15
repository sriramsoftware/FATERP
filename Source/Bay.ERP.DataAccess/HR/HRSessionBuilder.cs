// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRSessionBuilder : IEntityBuilder<HRSessionEntity>
    {
        IList<HRSessionEntity> IEntityBuilder<HRSessionEntity>.BuildEntities(IDataReader reader)
        {
            List<HRSessionEntity> HRSessionEntityList = new List<HRSessionEntity>();

            while (reader.Read())
            {
                HRSessionEntityList.Add(((IEntityBuilder<HRSessionEntity>)this).BuildEntity(reader));
            }

            return (HRSessionEntityList.Count > 0) ? HRSessionEntityList : null;
        }

        HRSessionEntity IEntityBuilder<HRSessionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SESSIONID = 0;
            const Int32 FLD_SESSIONCATEGORYID = 1;
            const Int32 FLD_SESSIONNAME = 2;
            const Int32 FLD_STARTDATE = 3;
            const Int32 FLD_ENDDATE = 4;
            const Int32 FLD_DEADLINEDATE = 5;
            const Int32 FLD_EVALUATIONSESSIONSTATUSID = 6;
            const Int32 FLD_REMARKS = 7;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 8;
            const Int32 FLD_CREATEDATE = 9;
            const Int32 FLD_IP = 10;

            HRSessionEntity hRSessionEntity = new HRSessionEntity();

            hRSessionEntity.SessionID = reader.GetInt64(FLD_SESSIONID);
            hRSessionEntity.SessionCategoryID = reader.GetInt64(FLD_SESSIONCATEGORYID);
            hRSessionEntity.SessionName = reader.GetString(FLD_SESSIONNAME);
            hRSessionEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            hRSessionEntity.EndDate = reader.GetDateTime(FLD_ENDDATE);
            hRSessionEntity.DeadlineDate = reader.GetDateTime(FLD_DEADLINEDATE);
            hRSessionEntity.EvaluationSessionStatusID = reader.GetInt64(FLD_EVALUATIONSESSIONSTATUSID);
            if (reader.IsDBNull(FLD_REMARKS)) { hRSessionEntity.Remarks = String.Empty; } else { hRSessionEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hRSessionEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            hRSessionEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_IP)) { hRSessionEntity.IP = String.Empty; } else { hRSessionEntity.IP = reader.GetString(FLD_IP); }

            return hRSessionEntity;
        }
    }
}
