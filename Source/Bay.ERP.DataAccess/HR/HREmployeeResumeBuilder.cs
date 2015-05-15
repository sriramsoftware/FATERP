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
    internal sealed class HREmployeeResumeBuilder : IEntityBuilder<HREmployeeResumeEntity>
    {
        IList<HREmployeeResumeEntity> IEntityBuilder<HREmployeeResumeEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeResumeEntity> HREmployeeResumeEntityList = new List<HREmployeeResumeEntity>();

            while (reader.Read())
            {
                HREmployeeResumeEntityList.Add(((IEntityBuilder<HREmployeeResumeEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeResumeEntityList.Count > 0) ? HREmployeeResumeEntityList : null;
        }

        HREmployeeResumeEntity IEntityBuilder<HREmployeeResumeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEERESUMEID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_RESUMECATEGORYID = 2;
            const Int32 FLD_TEXT = 3;
            const Int32 FLD_REMARKS = 4;

            HREmployeeResumeEntity hREmployeeResumeEntity = new HREmployeeResumeEntity();

            hREmployeeResumeEntity.EmployeeResumeID = reader.GetInt64(FLD_EMPLOYEERESUMEID);
            hREmployeeResumeEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeResumeEntity.ResumeCategoryID = reader.GetInt64(FLD_RESUMECATEGORYID);
            hREmployeeResumeEntity.Text = reader.GetString(FLD_TEXT);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeResumeEntity.Remarks = String.Empty; } else { hREmployeeResumeEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return hREmployeeResumeEntity;
        }
    }
}
