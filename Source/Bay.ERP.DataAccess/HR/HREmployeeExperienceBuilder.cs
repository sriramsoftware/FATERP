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
    internal sealed class HREmployeeExperienceBuilder : IEntityBuilder<HREmployeeExperienceEntity>
    {
        IList<HREmployeeExperienceEntity> IEntityBuilder<HREmployeeExperienceEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeExperienceEntity> HREmployeeExperienceEntityList = new List<HREmployeeExperienceEntity>();

            while (reader.Read())
            {
                HREmployeeExperienceEntityList.Add(((IEntityBuilder<HREmployeeExperienceEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeExperienceEntityList.Count > 0) ? HREmployeeExperienceEntityList : null;
        }

        HREmployeeExperienceEntity IEntityBuilder<HREmployeeExperienceEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEEXPERIENCEID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_COMPANYCOUNTRYID = 2;
            const Int32 FLD_COMPANYNAME = 3;
            const Int32 FLD_ADDRESS = 4;
            const Int32 FLD_EMPLOYEEJOBTYPEID = 5;
            const Int32 FLD_JOBENDDATE = 6;
            const Int32 FLD_JOBSTARTDATE = 7;
            const Int32 FLD_CONTACTNO = 8;
            const Int32 FLD_WEBLINK = 9;
            const Int32 FLD_ISLASTCOMPANY = 10;
            const Int32 FLD_DESIGNATION = 11;
			const Int32 FLD_RESPONSIBILITY = 12;
			const Int32 FLD_SUPERVISORNAME = 13;
			const Int32 FLD_SALARYORBENEFITS = 14;

            HREmployeeExperienceEntity hREmployeeExperienceEntity = new HREmployeeExperienceEntity();

            hREmployeeExperienceEntity.EmployeeExperienceID = reader.GetInt64(FLD_EMPLOYEEEXPERIENCEID);
            hREmployeeExperienceEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeExperienceEntity.CompanyCountryID = reader.GetInt64(FLD_COMPANYCOUNTRYID);
            hREmployeeExperienceEntity.CompanyName = reader.GetString(FLD_COMPANYNAME);
            if (reader.IsDBNull(FLD_ADDRESS)) { hREmployeeExperienceEntity.Address = String.Empty; } else { hREmployeeExperienceEntity.Address = reader.GetString(FLD_ADDRESS); }
            hREmployeeExperienceEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_JOBENDDATE)) { hREmployeeExperienceEntity.JobEndDate = null; } else { hREmployeeExperienceEntity.JobEndDate = reader.GetDateTime(FLD_JOBENDDATE); }
            hREmployeeExperienceEntity.JobStartDate = reader.GetDateTime(FLD_JOBSTARTDATE);
            if (reader.IsDBNull(FLD_CONTACTNO)) { hREmployeeExperienceEntity.ContactNo = String.Empty; } else { hREmployeeExperienceEntity.ContactNo = reader.GetString(FLD_CONTACTNO); }
            if (reader.IsDBNull(FLD_WEBLINK)) { hREmployeeExperienceEntity.WebLink = String.Empty; } else { hREmployeeExperienceEntity.WebLink = reader.GetString(FLD_WEBLINK); }
            hREmployeeExperienceEntity.IsLastCompany = reader.GetBoolean(FLD_ISLASTCOMPANY);
            if (reader.IsDBNull(FLD_DESIGNATION)) { hREmployeeExperienceEntity.Designation = String.Empty; } else { hREmployeeExperienceEntity.Designation = reader.GetString(FLD_DESIGNATION); }
            if (reader.IsDBNull(FLD_RESPONSIBILITY)) { hREmployeeExperienceEntity.Responsibility = String.Empty; } else { hREmployeeExperienceEntity.Responsibility = reader.GetString(FLD_RESPONSIBILITY); }
            if (reader.IsDBNull(FLD_SUPERVISORNAME)) { hREmployeeExperienceEntity.SupervisorName = String.Empty; } else { hREmployeeExperienceEntity.SupervisorName = reader.GetString(FLD_SUPERVISORNAME); }
            if (reader.IsDBNull(FLD_SALARYORBENEFITS)) { hREmployeeExperienceEntity.SalaryOrBenefits = String.Empty; } else { hREmployeeExperienceEntity.SalaryOrBenefits = reader.GetString(FLD_SALARYORBENEFITS); }

            return hREmployeeExperienceEntity;
        }
    }
}
