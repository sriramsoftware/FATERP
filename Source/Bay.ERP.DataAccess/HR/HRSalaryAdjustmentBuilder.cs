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
    internal sealed class HRSalaryAdjustmentBuilder : IEntityBuilder<HRSalaryAdjustmentEntity>
    {
        IList<HRSalaryAdjustmentEntity> IEntityBuilder<HRSalaryAdjustmentEntity>.BuildEntities(IDataReader reader)
        {
            List<HRSalaryAdjustmentEntity> HRSalaryAdjustmentEntityList = new List<HRSalaryAdjustmentEntity>();

            while (reader.Read())
            {
                HRSalaryAdjustmentEntityList.Add(((IEntityBuilder<HRSalaryAdjustmentEntity>)this).BuildEntity(reader));
            }

            return (HRSalaryAdjustmentEntityList.Count > 0) ? HRSalaryAdjustmentEntityList : null;
        }

        HRSalaryAdjustmentEntity IEntityBuilder<HRSalaryAdjustmentEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SALARYADJUSTMENTID = 0;
            const Int32 FLD_FISCALYEARID = 1;
            const Int32 FLD_SALARYSESSIONID = 2;
            const Int32 FLD_EMPLOYEEID = 3;
            const Int32 FLD_SALARYLEVEL = 4;
            const Int32 FLD_DESIGNATIONID = 5;
            const Int32 FLD_EMPLOYEECODE = 6;
            const Int32 FLD_EMPLOYEEJOBTYPEID = 7;
            const Int32 FLD_ADJUSTMENTAMOUNT = 8;
            const Int32 FLD_REMARKS = 9;

            HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity = new HRSalaryAdjustmentEntity();

            hRSalaryAdjustmentEntity.SalaryAdjustmentID = reader.GetInt64(FLD_SALARYADJUSTMENTID);
            hRSalaryAdjustmentEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hRSalaryAdjustmentEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hRSalaryAdjustmentEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hRSalaryAdjustmentEntity.SalaryLevel = null; } else { hRSalaryAdjustmentEntity.SalaryLevel = reader.GetInt32(FLD_SALARYLEVEL); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hRSalaryAdjustmentEntity.DesignationID = null; } else { hRSalaryAdjustmentEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hRSalaryAdjustmentEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            hRSalaryAdjustmentEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            hRSalaryAdjustmentEntity.AdjustmentAmount = reader.GetDecimal(FLD_ADJUSTMENTAMOUNT);
            if (reader.IsDBNull(FLD_REMARKS)) { hRSalaryAdjustmentEntity.Remarks = String.Empty; } else { hRSalaryAdjustmentEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return hRSalaryAdjustmentEntity;
        }
    }
}
