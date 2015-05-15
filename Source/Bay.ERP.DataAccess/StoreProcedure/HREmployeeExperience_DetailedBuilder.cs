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
    internal sealed class HREmployeeExperience_DetailedBuilder : IEntityBuilder<HREmployeeExperience_DetailedEntity>
    {
        IList<HREmployeeExperience_DetailedEntity> IEntityBuilder<HREmployeeExperience_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeExperience_DetailedEntity> HREmployeeExperience_DetailedEntityList = new List<HREmployeeExperience_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeExperience_DetailedEntityList.Add(((IEntityBuilder<HREmployeeExperience_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeExperience_DetailedEntityList.Count > 0) ? HREmployeeExperience_DetailedEntityList : null;
        }

        HREmployeeExperience_DetailedEntity IEntityBuilder<HREmployeeExperience_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_EMPLOYEEFULLNAME = 11;
            const Int32 FLD_COUNTRYNAME = 12;
            const Int32 FLD_EMPLOYEEJOBTYPENAME = 13;
            const Int32 FLD_ROWNUMBER = 14;

            HREmployeeExperience_DetailedEntity hREmployeeExperience_DetailedEntity = new HREmployeeExperience_DetailedEntity();

            hREmployeeExperience_DetailedEntity.EmployeeExperienceID = reader.GetInt64(FLD_EMPLOYEEEXPERIENCEID);
            hREmployeeExperience_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeExperience_DetailedEntity.CompanyCountryID = reader.GetInt64(FLD_COMPANYCOUNTRYID);
            hREmployeeExperience_DetailedEntity.CompanyName = reader.GetString(FLD_COMPANYNAME);
            if (reader.IsDBNull(FLD_ADDRESS)) { hREmployeeExperience_DetailedEntity.Address = String.Empty; } else { hREmployeeExperience_DetailedEntity.Address = reader.GetString(FLD_ADDRESS); }
            hREmployeeExperience_DetailedEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_JOBENDDATE)) { hREmployeeExperience_DetailedEntity.JobEndDate = null; } else { hREmployeeExperience_DetailedEntity.JobEndDate = reader.GetDateTime(FLD_JOBENDDATE); }
            hREmployeeExperience_DetailedEntity.JobStartDate = reader.GetDateTime(FLD_JOBSTARTDATE);
            if (reader.IsDBNull(FLD_CONTACTNO)) { hREmployeeExperience_DetailedEntity.ContactNo = String.Empty; } else { hREmployeeExperience_DetailedEntity.ContactNo = reader.GetString(FLD_CONTACTNO); }
            if (reader.IsDBNull(FLD_WEBLINK)) { hREmployeeExperience_DetailedEntity.WebLink = String.Empty; } else { hREmployeeExperience_DetailedEntity.WebLink = reader.GetString(FLD_WEBLINK); }
            hREmployeeExperience_DetailedEntity.IsLastCompany = reader.GetBoolean(FLD_ISLASTCOMPANY);
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeExperience_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeExperience_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { hREmployeeExperience_DetailedEntity.CountryName = String.Empty; } else { hREmployeeExperience_DetailedEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEEJOBTYPENAME)) { hREmployeeExperience_DetailedEntity.EmployeeJobTypeName = String.Empty; } else { hREmployeeExperience_DetailedEntity.EmployeeJobTypeName = reader.GetString(FLD_EMPLOYEEJOBTYPENAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployeeExperience_DetailedEntity.RowNumber = null; } else { hREmployeeExperience_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hREmployeeExperience_DetailedEntity;
        }
    }
}
