// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRSession_DetailedBuilder : IEntityBuilder<HRSession_DetailedEntity>
    {
        IList<HRSession_DetailedEntity> IEntityBuilder<HRSession_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HRSession_DetailedEntity> HRSession_DetailedEntityList = new List<HRSession_DetailedEntity>();

            while (reader.Read())
            {
                HRSession_DetailedEntityList.Add(((IEntityBuilder<HRSession_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HRSession_DetailedEntityList.Count > 0) ? HRSession_DetailedEntityList : null;
        }

        HRSession_DetailedEntity IEntityBuilder<HRSession_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_EVALUATIONSESSIONCATEGORYNAME = 11;
            const Int32 FLD_EVALUATIONSESSIONSTATUSNAME = 12;
            const Int32 FLD_EMPLOYEEFULLNAME = 13;
            const Int32 FLD_EMPLOYEECODE = 14;
            const Int32 FLD_ROWNUMBER = 15;

            HRSession_DetailedEntity hRSession_DetailedEntity = new HRSession_DetailedEntity();

            hRSession_DetailedEntity.SessionID = reader.GetInt64(FLD_SESSIONID);
            hRSession_DetailedEntity.SessionCategoryID = reader.GetInt64(FLD_SESSIONCATEGORYID);
            hRSession_DetailedEntity.SessionName = reader.GetString(FLD_SESSIONNAME);
            hRSession_DetailedEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            hRSession_DetailedEntity.EndDate = reader.GetDateTime(FLD_ENDDATE);
            hRSession_DetailedEntity.DeadlineDate = reader.GetDateTime(FLD_DEADLINEDATE);
            hRSession_DetailedEntity.EvaluationSessionStatusID = reader.GetInt64(FLD_EVALUATIONSESSIONSTATUSID);
            if (reader.IsDBNull(FLD_REMARKS)) { hRSession_DetailedEntity.Remarks = String.Empty; } else { hRSession_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hRSession_DetailedEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            hRSession_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_IP)) { hRSession_DetailedEntity.IP = String.Empty; } else { hRSession_DetailedEntity.IP = reader.GetString(FLD_IP); }
            if (reader.IsDBNull(FLD_EVALUATIONSESSIONCATEGORYNAME)) { hRSession_DetailedEntity.EvaluationSessionCategoryName = String.Empty; } else { hRSession_DetailedEntity.EvaluationSessionCategoryName = reader.GetString(FLD_EVALUATIONSESSIONCATEGORYNAME); }
            if (reader.IsDBNull(FLD_EVALUATIONSESSIONSTATUSNAME)) { hRSession_DetailedEntity.EvaluationSessionStatusName = String.Empty; } else { hRSession_DetailedEntity.EvaluationSessionStatusName = reader.GetString(FLD_EVALUATIONSESSIONSTATUSNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hRSession_DetailedEntity.EmployeeFullName = String.Empty; } else { hRSession_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEECODE)) { hRSession_DetailedEntity.EmployeeCode = String.Empty; } else { hRSession_DetailedEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hRSession_DetailedEntity.RowNumber = null; } else { hRSession_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hRSession_DetailedEntity;
        }
    }
}
