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
    internal sealed class HREmployeeEducation_DetailedBuilder : IEntityBuilder<HREmployeeEducation_DetailedEntity>
    {
        IList<HREmployeeEducation_DetailedEntity> IEntityBuilder<HREmployeeEducation_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeEducation_DetailedEntity> HREmployeeEducation_DetailedEntityList = new List<HREmployeeEducation_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeEducation_DetailedEntityList.Add(((IEntityBuilder<HREmployeeEducation_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeEducation_DetailedEntityList.Count > 0) ? HREmployeeEducation_DetailedEntityList : null;
        }

        HREmployeeEducation_DetailedEntity IEntityBuilder<HREmployeeEducation_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_EMPLOYEEFULLNAME = 10;
            const Int32 FLD_EDUCATIONALDEGREENAME = 11;
            const Int32 FLD_ROWNUMBER = 12;

            HREmployeeEducation_DetailedEntity hREmployeeEducation_DetailedEntity = new HREmployeeEducation_DetailedEntity();

            hREmployeeEducation_DetailedEntity.EmployeeEducationID = reader.GetInt64(FLD_EMPLOYEEEDUCATIONID);
            hREmployeeEducation_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeEducation_DetailedEntity.EducationalDegreeID = reader.GetInt64(FLD_EDUCATIONALDEGREEID);
            if (reader.IsDBNull(FLD_PASSEDYEAR)) { hREmployeeEducation_DetailedEntity.PassedYear = null; } else { hREmployeeEducation_DetailedEntity.PassedYear = reader.GetInt32(FLD_PASSEDYEAR); }
            if (reader.IsDBNull(FLD_SESSION)) { hREmployeeEducation_DetailedEntity.Session = String.Empty; } else { hREmployeeEducation_DetailedEntity.Session = reader.GetString(FLD_SESSION); }
            hREmployeeEducation_DetailedEntity.Result = reader.GetString(FLD_RESULT);
            if (reader.IsDBNull(FLD_RESULTOUTOF)) { hREmployeeEducation_DetailedEntity.ResultOutOf = String.Empty; } else { hREmployeeEducation_DetailedEntity.ResultOutOf = reader.GetString(FLD_RESULTOUTOF); }
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeEducation_DetailedEntity.Remarks = String.Empty; } else { hREmployeeEducation_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hREmployeeEducation_DetailedEntity.IsCompleted = reader.GetBoolean(FLD_ISCOMPLETED);
            hREmployeeEducation_DetailedEntity.IsLastAcquired = reader.GetBoolean(FLD_ISLASTACQUIRED);
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeEducation_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeEducation_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_EDUCATIONALDEGREENAME)) { hREmployeeEducation_DetailedEntity.EducationalDegreeName = String.Empty; } else { hREmployeeEducation_DetailedEntity.EducationalDegreeName = reader.GetString(FLD_EDUCATIONALDEGREENAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployeeEducation_DetailedEntity.RowNumber = null; } else { hREmployeeEducation_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hREmployeeEducation_DetailedEntity;
        }
    }
}
