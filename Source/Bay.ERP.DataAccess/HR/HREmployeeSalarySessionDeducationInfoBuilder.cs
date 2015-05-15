// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeSalarySessionDeducationInfoBuilder : IEntityBuilder<HREmployeeSalarySessionDeducationInfoEntity>
    {
        IList<HREmployeeSalarySessionDeducationInfoEntity> IEntityBuilder<HREmployeeSalarySessionDeducationInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSalarySessionDeducationInfoEntity> HREmployeeSalarySessionDeducationInfoEntityList = new List<HREmployeeSalarySessionDeducationInfoEntity>();

            while (reader.Read())
            {
                HREmployeeSalarySessionDeducationInfoEntityList.Add(((IEntityBuilder<HREmployeeSalarySessionDeducationInfoEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSalarySessionDeducationInfoEntityList.Count > 0) ? HREmployeeSalarySessionDeducationInfoEntityList : null;
        }

        HREmployeeSalarySessionDeducationInfoEntity IEntityBuilder<HREmployeeSalarySessionDeducationInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESALARYSESSIONDEDUCATIONINFOID = 0;
            const Int32 FLD_SALARYSESSIONID = 1;
            const Int32 FLD_DEDUCTIONAMOUNT = 2;
            const Int32 FLD_NOTE = 3;

            HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity = new HREmployeeSalarySessionDeducationInfoEntity();

            hREmployeeSalarySessionDeducationInfoEntity.EmployeeSalarySessionDeducationInfoID = reader.GetInt64(FLD_EMPLOYEESALARYSESSIONDEDUCATIONINFOID);
            hREmployeeSalarySessionDeducationInfoEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            if (reader.IsDBNull(FLD_DEDUCTIONAMOUNT)) { hREmployeeSalarySessionDeducationInfoEntity.DeductionAmount = null; } else { hREmployeeSalarySessionDeducationInfoEntity.DeductionAmount = reader.GetDecimal(FLD_DEDUCTIONAMOUNT); }
            if (reader.IsDBNull(FLD_NOTE)) { hREmployeeSalarySessionDeducationInfoEntity.Note = String.Empty; } else { hREmployeeSalarySessionDeducationInfoEntity.Note = reader.GetString(FLD_NOTE); }

            return hREmployeeSalarySessionDeducationInfoEntity;
        }
    }
}
