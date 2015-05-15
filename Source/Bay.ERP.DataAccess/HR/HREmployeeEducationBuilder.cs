// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeEducationBuilder : IEntityBuilder<HREmployeeEducationEntity>
    {
        IList<HREmployeeEducationEntity> IEntityBuilder<HREmployeeEducationEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeEducationEntity> HREmployeeEducationEntityList = new List<HREmployeeEducationEntity>();

            while (reader.Read())
            {
                HREmployeeEducationEntityList.Add(((IEntityBuilder<HREmployeeEducationEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeEducationEntityList.Count > 0) ? HREmployeeEducationEntityList : null;
        }

        HREmployeeEducationEntity IEntityBuilder<HREmployeeEducationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEEDUCATIONID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_EDUCATIONALDEGREEID = 2;
            const Int32 FLD_PASSEDYEAR = 3;
            const Int32 FLD_SESSION = 4;
            const Int32 FLD_RESULT = 5;
            const Int32 FLD_RESULTOUTOF = 6;
            const Int32 FLD_REMARKS = 7;
            const Int32 FLD_ISCOMPLETED = 8;
            const Int32 FLD_ISLASTACQUIRED = 9;

            HREmployeeEducationEntity hREmployeeEducationEntity = new HREmployeeEducationEntity();

            hREmployeeEducationEntity.EmployeeEducationID = reader.GetInt64(FLD_EMPLOYEEEDUCATIONID);
            hREmployeeEducationEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeEducationEntity.EducationalDegreeID = reader.GetInt64(FLD_EDUCATIONALDEGREEID);
            if (reader.IsDBNull(FLD_PASSEDYEAR)) { hREmployeeEducationEntity.PassedYear = null; } else { hREmployeeEducationEntity.PassedYear = reader.GetInt32(FLD_PASSEDYEAR); }
            if (reader.IsDBNull(FLD_SESSION)) { hREmployeeEducationEntity.Session = String.Empty; } else { hREmployeeEducationEntity.Session = reader.GetString(FLD_SESSION); }
            hREmployeeEducationEntity.Result = reader.GetString(FLD_RESULT);
            if (reader.IsDBNull(FLD_RESULTOUTOF)) { hREmployeeEducationEntity.ResultOutOf = String.Empty; } else { hREmployeeEducationEntity.ResultOutOf = reader.GetString(FLD_RESULTOUTOF); }
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeEducationEntity.Remarks = String.Empty; } else { hREmployeeEducationEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hREmployeeEducationEntity.IsCompleted = reader.GetBoolean(FLD_ISCOMPLETED);
            hREmployeeEducationEntity.IsLastAcquired = reader.GetBoolean(FLD_ISLASTACQUIRED);

            return hREmployeeEducationEntity;
        }
    }
}
