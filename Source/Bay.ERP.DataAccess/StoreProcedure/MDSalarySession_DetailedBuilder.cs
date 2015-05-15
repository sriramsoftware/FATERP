// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDSalarySession_DetailedBuilder : IEntityBuilder<MDSalarySession_DetailedEntity>
    {
        IList<MDSalarySession_DetailedEntity> IEntityBuilder<MDSalarySession_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSalarySession_DetailedEntity> MDSalarySession_DetailedEntityList = new List<MDSalarySession_DetailedEntity>();

            while (reader.Read())
            {
                MDSalarySession_DetailedEntityList.Add(((IEntityBuilder<MDSalarySession_DetailedEntity>)this).BuildEntity(reader));
            }

            return (MDSalarySession_DetailedEntityList.Count > 0) ? MDSalarySession_DetailedEntityList : null;
        }

        MDSalarySession_DetailedEntity IEntityBuilder<MDSalarySession_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SALARYSESSIONID = 0;
            const Int32 FLD_FISCALYEARID = 1;
            const Int32 FLD_SALARYSESSIONNAME = 2;
            const Int32 FLD_SESSIONSTARTDATE = 3;
            const Int32 FLD_SESSIONENDDATE = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_SALARYSESSIONSTATUSID = 6;
            const Int32 FLD_ISCURRENTSESSION = 7;
            const Int32 FLD_SALARYSESSIONSTATUSNAME = 8;
            const Int32 FLD_FISCALYEARBEGINDATE = 9;
            const Int32 FLD_FISCALYEARENDDATE = 10;
            const Int32 FLD_ROWNUMBER = 11;

            MDSalarySession_DetailedEntity mDSalarySession_DetailedEntity = new MDSalarySession_DetailedEntity();

            mDSalarySession_DetailedEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            mDSalarySession_DetailedEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            mDSalarySession_DetailedEntity.SalarySessionName = reader.GetString(FLD_SALARYSESSIONNAME);
            mDSalarySession_DetailedEntity.SessionStartDate = reader.GetDateTime(FLD_SESSIONSTARTDATE);
            mDSalarySession_DetailedEntity.SessionEndDate = reader.GetDateTime(FLD_SESSIONENDDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { mDSalarySession_DetailedEntity.Remarks = String.Empty; } else { mDSalarySession_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDSalarySession_DetailedEntity.SalarySessionStatusID = reader.GetInt64(FLD_SALARYSESSIONSTATUSID);
            mDSalarySession_DetailedEntity.IsCurrentSession = reader.GetBoolean(FLD_ISCURRENTSESSION);
            mDSalarySession_DetailedEntity.SalarySessionStatusName = reader.GetString(FLD_SALARYSESSIONSTATUSNAME);
            mDSalarySession_DetailedEntity.FiscalYearBeginDate = reader.GetDateTime(FLD_FISCALYEARBEGINDATE);
            mDSalarySession_DetailedEntity.FiscalYearEndDate = reader.GetDateTime(FLD_FISCALYEARENDDATE);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { mDSalarySession_DetailedEntity.RowNumber = null; } else { mDSalarySession_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return mDSalarySession_DetailedEntity;
        }
    }
}
