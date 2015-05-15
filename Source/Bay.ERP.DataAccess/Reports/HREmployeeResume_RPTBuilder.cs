// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 06:16:34




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeResume_RPTBuilder : IEntityBuilder<HREmployeeResume_RPTEntity>
    {
        IList<HREmployeeResume_RPTEntity> IEntityBuilder<HREmployeeResume_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeResume_RPTEntity> HREmployeeResume_RPTEntityList = new List<HREmployeeResume_RPTEntity>();

            while (reader.Read())
            {
                HREmployeeResume_RPTEntityList.Add(((IEntityBuilder<HREmployeeResume_RPTEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeResume_RPTEntityList.Count > 0) ? HREmployeeResume_RPTEntityList : null;
        }

        HREmployeeResume_RPTEntity IEntityBuilder<HREmployeeResume_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEERESUMEID = 0;
            const Int32 FLD_EMPLOYEERESUME = 1;


            HREmployeeResume_RPTEntity hREmployeeResume_RPTEntity = new HREmployeeResume_RPTEntity();

            hREmployeeResume_RPTEntity.EmployeeResumeID = reader.GetInt64(FLD_EMPLOYEERESUMEID);
            hREmployeeResume_RPTEntity.EmployeeResume = reader.GetString(FLD_EMPLOYEERESUME);


            return hREmployeeResume_RPTEntity;
        }
    }
}
