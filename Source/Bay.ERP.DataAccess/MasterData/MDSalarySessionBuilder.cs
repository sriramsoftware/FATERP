// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDSalarySessionBuilder : IEntityBuilder<MDSalarySessionEntity>
    {
        IList<MDSalarySessionEntity> IEntityBuilder<MDSalarySessionEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSalarySessionEntity> MDSalarySessionEntityList = new List<MDSalarySessionEntity>();

            while (reader.Read())
            {
                MDSalarySessionEntityList.Add(((IEntityBuilder<MDSalarySessionEntity>)this).BuildEntity(reader));
            }

            return (MDSalarySessionEntityList.Count > 0) ? MDSalarySessionEntityList : null;
        }

        MDSalarySessionEntity IEntityBuilder<MDSalarySessionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SALARYSESSIONID = 0;
            const Int32 FLD_FISCALYEARID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_SESSIONSTARTDATE = 3;
            const Int32 FLD_SESSIONENDDATE = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_SALARYSESSIONSTATUSID = 6;
            const Int32 FLD_ISCURRENTSESSION = 7;

            MDSalarySessionEntity mDSalarySessionEntity = new MDSalarySessionEntity();

            mDSalarySessionEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            mDSalarySessionEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            mDSalarySessionEntity.Name = reader.GetString(FLD_NAME);
            mDSalarySessionEntity.SessionStartDate = reader.GetDateTime(FLD_SESSIONSTARTDATE);
            mDSalarySessionEntity.SessionEndDate = reader.GetDateTime(FLD_SESSIONENDDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { mDSalarySessionEntity.Remarks = String.Empty; } else { mDSalarySessionEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDSalarySessionEntity.SalarySessionStatusID = reader.GetInt64(FLD_SALARYSESSIONSTATUSID);
            mDSalarySessionEntity.IsCurrentSession = reader.GetBoolean(FLD_ISCURRENTSESSION);

            return mDSalarySessionEntity;
        }
    }
}
