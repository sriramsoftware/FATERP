// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2014, 04:10:32




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeDetails_RPTBuilder : IEntityBuilder<HREmployeeDetails_RPTEntity>
    {
        IList<HREmployeeDetails_RPTEntity> IEntityBuilder<HREmployeeDetails_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeDetails_RPTEntity> HREmployeeDetails_RPTEntityList = new List<HREmployeeDetails_RPTEntity>();

            while (reader.Read())
            {
                HREmployeeDetails_RPTEntityList.Add(((IEntityBuilder<HREmployeeDetails_RPTEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeDetails_RPTEntityList.Count > 0) ? HREmployeeDetails_RPTEntityList : null;
        }

        HREmployeeDetails_RPTEntity IEntityBuilder<HREmployeeDetails_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEID = 0;
            const Int32 FLD_MEMBERID = 1;
            const Int32 FLD_PROJECTID = 2;
            const Int32 FLD_DESIGNATIONID = 3;
            const Int32 FLD_EMPLOYEECODE = 4;
            const Int32 FLD_EMPLOYEEJOBTYPEID = 5;
            const Int32 FLD_CONFIRMDATE = 6;
            const Int32 FLD_JOINDATE = 7;
            const Int32 FLD_SALARYLEVEL = 8;
            const Int32 FLD_OFFICIALEMAIL = 9;
            const Int32 FLD_DEPARTMENTID = 10;
            const Int32 FLD_EMPLOYMENTSTATUSID = 11;
            const Int32 FLD_INITIALS = 12;
            const Int32 FLD_SECONDARYEMAIL = 13;
            const Int32 FLD_EMPLOYEEFULLNAME = 14;
            const Int32 FLD_BLOODGROUPID = 15;
            const Int32 FLD_DOB = 16;
            const Int32 FLD_PROJECTCODE = 17;
            const Int32 FLD_PROJECTNAME = 18;
            const Int32 FLD_DEPARTMENTCODE = 19;
            const Int32 FLD_EMPLOYEEJOBTYPENAME = 20;
            const Int32 FLD_DESIGNATIONNAME = 21;
            const Int32 FLD_EMPLOYMENTSTATUSNAME = 22;
            const Int32 FLD_EMPLOYEEPHOTOID = 23;
            const Int32 FLD_CURRENTFILENAME = 24;
            const Int32 FLD_EXTENSION = 25;
            const Int32 FLD_REMARKS = 26;
            const Int32 FLD_PATH = 27;
            const Int32 FLD_ORIGINALFILENAME = 28;
            const Int32 FLD_FILETYPE = 29;
            const Int32 FLD_ISCURRENT = 30;
            const Int32 FLD_BLOODGROUP = 31;
            const Int32 FLD_CURRENTADDRESSLINE1 = 32;
            const Int32 FLD_CURRENTADDRESSLINE2 = 33;
            const Int32 FLD_PERMANENTADDRESSLINE1 = 34;
            const Int32 FLD_PERMANENTADDRESSLINE2 = 35;
            const Int32 FLD_BANKACCOUNTNO = 36;
            const Int32 FLD_MOBILE = 37;
            const Int32 FLD_OFFICIALPHONE = 38;
            const Int32 FLD_RESIDENCEPHONE = 39;
            const Int32 FLD_LASTEDUCATION = 40;

            HREmployeeDetails_RPTEntity hREmployeeDetails_RPTEntity = new HREmployeeDetails_RPTEntity();

            hREmployeeDetails_RPTEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeDetails_RPTEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            if (reader.IsDBNull(FLD_PROJECTID)) { hREmployeeDetails_RPTEntity.ProjectID = null; } else { hREmployeeDetails_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeDetails_RPTEntity.DesignationID = null; } else { hREmployeeDetails_RPTEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployeeDetails_RPTEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            hREmployeeDetails_RPTEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_CONFIRMDATE)) { hREmployeeDetails_RPTEntity.ConfirmDate = null; } else { hREmployeeDetails_RPTEntity.ConfirmDate = reader.GetDateTime(FLD_CONFIRMDATE); }
            if (reader.IsDBNull(FLD_JOINDATE)) { hREmployeeDetails_RPTEntity.JoinDate = null; } else { hREmployeeDetails_RPTEntity.JoinDate = reader.GetDateTime(FLD_JOINDATE); }
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hREmployeeDetails_RPTEntity.SalaryLevel = null; } else { hREmployeeDetails_RPTEntity.SalaryLevel = reader.GetInt32(FLD_SALARYLEVEL); }
            hREmployeeDetails_RPTEntity.OfficialEmail = reader.GetString(FLD_OFFICIALEMAIL);
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { hREmployeeDetails_RPTEntity.DepartmentID = null; } else { hREmployeeDetails_RPTEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }
            if (reader.IsDBNull(FLD_EMPLOYMENTSTATUSID)) { hREmployeeDetails_RPTEntity.EmploymentStatusID = null; } else { hREmployeeDetails_RPTEntity.EmploymentStatusID = reader.GetInt64(FLD_EMPLOYMENTSTATUSID); }
            if (reader.IsDBNull(FLD_INITIALS)) { hREmployeeDetails_RPTEntity.Initials = String.Empty; } else { hREmployeeDetails_RPTEntity.Initials = reader.GetString(FLD_INITIALS); }
            if (reader.IsDBNull(FLD_SECONDARYEMAIL)) { hREmployeeDetails_RPTEntity.SecondaryEmail = String.Empty; } else { hREmployeeDetails_RPTEntity.SecondaryEmail = reader.GetString(FLD_SECONDARYEMAIL); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeDetails_RPTEntity.EmployeeFullName = String.Empty; } else { hREmployeeDetails_RPTEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_BLOODGROUPID)) { hREmployeeDetails_RPTEntity.BloodGroupID = null; } else { hREmployeeDetails_RPTEntity.BloodGroupID = reader.GetInt64(FLD_BLOODGROUPID); }
            if (reader.IsDBNull(FLD_DOB)) { hREmployeeDetails_RPTEntity.DOB = null; } else { hREmployeeDetails_RPTEntity.DOB = reader.GetDateTime(FLD_DOB); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { hREmployeeDetails_RPTEntity.ProjectCode = String.Empty; } else { hREmployeeDetails_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { hREmployeeDetails_RPTEntity.ProjectName = String.Empty; } else { hREmployeeDetails_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTCODE)) { hREmployeeDetails_RPTEntity.DepartmentCode = String.Empty; } else { hREmployeeDetails_RPTEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE); }
            if (reader.IsDBNull(FLD_EMPLOYEEJOBTYPENAME)) { hREmployeeDetails_RPTEntity.EmployeeJobTypeName = String.Empty; } else { hREmployeeDetails_RPTEntity.EmployeeJobTypeName = reader.GetString(FLD_EMPLOYEEJOBTYPENAME); }
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { hREmployeeDetails_RPTEntity.DesignationName = String.Empty; } else { hREmployeeDetails_RPTEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_EMPLOYMENTSTATUSNAME)) { hREmployeeDetails_RPTEntity.EmploymentStatusName = String.Empty; } else { hREmployeeDetails_RPTEntity.EmploymentStatusName = reader.GetString(FLD_EMPLOYMENTSTATUSNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEEPHOTOID)) { hREmployeeDetails_RPTEntity.EmployeePhotoID = null; } else { hREmployeeDetails_RPTEntity.EmployeePhotoID = reader.GetInt64(FLD_EMPLOYEEPHOTOID); }
            if (reader.IsDBNull(FLD_CURRENTFILENAME)) { hREmployeeDetails_RPTEntity.CurrentFileName = String.Empty; } else { hREmployeeDetails_RPTEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME); }
            if (reader.IsDBNull(FLD_EXTENSION)) { hREmployeeDetails_RPTEntity.Extension = String.Empty; } else { hREmployeeDetails_RPTEntity.Extension = reader.GetString(FLD_EXTENSION); }
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeDetails_RPTEntity.Remarks = String.Empty; } else { hREmployeeDetails_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_PATH)) { hREmployeeDetails_RPTEntity.Path = String.Empty; } else { hREmployeeDetails_RPTEntity.Path = reader.GetString(FLD_PATH); }
            if (reader.IsDBNull(FLD_ORIGINALFILENAME)) { hREmployeeDetails_RPTEntity.OriginalFileName = String.Empty; } else { hREmployeeDetails_RPTEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME); }
            if (reader.IsDBNull(FLD_FILETYPE)) { hREmployeeDetails_RPTEntity.FileType = String.Empty; } else { hREmployeeDetails_RPTEntity.FileType = reader.GetString(FLD_FILETYPE); }
            if (reader.IsDBNull(FLD_ISCURRENT)) { hREmployeeDetails_RPTEntity.IsCurrent = false; } else { hREmployeeDetails_RPTEntity.IsCurrent = reader.GetBoolean(FLD_ISCURRENT); }
            if (reader.IsDBNull(FLD_BLOODGROUP)) { hREmployeeDetails_RPTEntity.BloodGroup = String.Empty; } else { hREmployeeDetails_RPTEntity.BloodGroup = reader.GetString(FLD_BLOODGROUP); }
            if (reader.IsDBNull(FLD_CURRENTADDRESSLINE1)) { hREmployeeDetails_RPTEntity.CurrentAddressLine1 = String.Empty; } else { hREmployeeDetails_RPTEntity.CurrentAddressLine1 = reader.GetString(FLD_CURRENTADDRESSLINE1); }
            if (reader.IsDBNull(FLD_CURRENTADDRESSLINE2)) { hREmployeeDetails_RPTEntity.CurrentAddressLine2 = String.Empty; } else { hREmployeeDetails_RPTEntity.CurrentAddressLine2 = reader.GetString(FLD_CURRENTADDRESSLINE2); }
            if (reader.IsDBNull(FLD_PERMANENTADDRESSLINE1)) { hREmployeeDetails_RPTEntity.PermanentAddressLine1 = String.Empty; } else { hREmployeeDetails_RPTEntity.PermanentAddressLine1 = reader.GetString(FLD_PERMANENTADDRESSLINE1); }
            if (reader.IsDBNull(FLD_PERMANENTADDRESSLINE2)) { hREmployeeDetails_RPTEntity.PermanentAddressLine2 = String.Empty; } else { hREmployeeDetails_RPTEntity.PermanentAddressLine2 = reader.GetString(FLD_PERMANENTADDRESSLINE2); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNO)) { hREmployeeDetails_RPTEntity.BankAccountNo = String.Empty; } else { hREmployeeDetails_RPTEntity.BankAccountNo = reader.GetString(FLD_BANKACCOUNTNO); }
            if (reader.IsDBNull(FLD_MOBILE)) { hREmployeeDetails_RPTEntity.Mobile = String.Empty; } else { hREmployeeDetails_RPTEntity.Mobile = reader.GetString(FLD_MOBILE); }
            if (reader.IsDBNull(FLD_OFFICIALPHONE)) { hREmployeeDetails_RPTEntity.OfficialPhone = String.Empty; } else { hREmployeeDetails_RPTEntity.OfficialPhone = reader.GetString(FLD_OFFICIALPHONE); }
            if (reader.IsDBNull(FLD_RESIDENCEPHONE)) { hREmployeeDetails_RPTEntity.ResidencePhone = String.Empty; } else { hREmployeeDetails_RPTEntity.ResidencePhone = reader.GetString(FLD_RESIDENCEPHONE); }
            if (reader.IsDBNull(FLD_LASTEDUCATION)) { hREmployeeDetails_RPTEntity.LastEducation = String.Empty; } else { hREmployeeDetails_RPTEntity.LastEducation = reader.GetString(FLD_LASTEDUCATION); }

            return hREmployeeDetails_RPTEntity;
        }
    }
}
