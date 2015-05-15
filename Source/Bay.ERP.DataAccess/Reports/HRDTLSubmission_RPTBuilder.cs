// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Sep-2013, 12:52:44




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRDTLSubmission_RPTBuilder : IEntityBuilder<HRDTLSubmission_RPTEntity>
    {
        IList<HRDTLSubmission_RPTEntity> IEntityBuilder<HRDTLSubmission_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HRDTLSubmission_RPTEntity> HRDTLSubmission_RPTEntityList = new List<HRDTLSubmission_RPTEntity>();

            while (reader.Read())
            {
                HRDTLSubmission_RPTEntityList.Add(((IEntityBuilder<HRDTLSubmission_RPTEntity>)this).BuildEntity(reader));
            }

            return (HRDTLSubmission_RPTEntityList.Count > 0) ? HRDTLSubmission_RPTEntityList : null;
        }

        HRDTLSubmission_RPTEntity IEntityBuilder<HRDTLSubmission_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASSIGNEDTOEMPLOYEEID = 0;
            const Int32 FLD_TOTALSUBMITED = 1;
            const Int32 FLD_TOTALHOURSWORKED = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_EMPLOYEECODE = 4;
            const Int32 FLD_DEPARTMENTNAME = 5;
            const Int32 FLD_MEMBERFULLNAME = 6;
            const Int32 FLD_SALARYLEVEL = 7;
            const Int32 FLD_DESIGNAITONNAME = 8;

            HRDTLSubmission_RPTEntity hRDTLSubmission_RPTEntity = new HRDTLSubmission_RPTEntity();

            hRDTLSubmission_RPTEntity.AssignedToEmployeeID = reader.GetInt64(FLD_ASSIGNEDTOEMPLOYEEID);
            if (reader.IsDBNull(FLD_TOTALSUBMITED)) { hRDTLSubmission_RPTEntity.TotalSubmited = null; } else { hRDTLSubmission_RPTEntity.TotalSubmited = reader.GetInt32(FLD_TOTALSUBMITED); }
            if (reader.IsDBNull(FLD_TOTALHOURSWORKED)) { hRDTLSubmission_RPTEntity.TotalHoursWorked = null; } else { hRDTLSubmission_RPTEntity.TotalHoursWorked = reader.GetDecimal(FLD_TOTALHOURSWORKED); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hRDTLSubmission_RPTEntity.Description = String.Empty; } else { hRDTLSubmission_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            hRDTLSubmission_RPTEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            hRDTLSubmission_RPTEntity.DepartmentName = reader.GetString(FLD_DEPARTMENTNAME);
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { hRDTLSubmission_RPTEntity.MemberFullName = String.Empty; } else { hRDTLSubmission_RPTEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hRDTLSubmission_RPTEntity.SalaryLevel = null; } else { hRDTLSubmission_RPTEntity.SalaryLevel = reader.GetInt32(FLD_SALARYLEVEL); }
            hRDTLSubmission_RPTEntity.DesignaitonName = reader.GetString(FLD_DESIGNAITONNAME);

            return hRDTLSubmission_RPTEntity;
        }
    }
}
