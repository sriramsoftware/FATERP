// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRSalaryAdjustment_DetailedBuilder : IEntityBuilder<HRSalaryAdjustment_DetailedEntity>
    {
        IList<HRSalaryAdjustment_DetailedEntity> IEntityBuilder<HRSalaryAdjustment_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HRSalaryAdjustment_DetailedEntity> HRSalaryAdjustment_DetailedEntityList = new List<HRSalaryAdjustment_DetailedEntity>();

            while (reader.Read())
            {
                HRSalaryAdjustment_DetailedEntityList.Add(((IEntityBuilder<HRSalaryAdjustment_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HRSalaryAdjustment_DetailedEntityList.Count > 0) ? HRSalaryAdjustment_DetailedEntityList : null;
        }

        HRSalaryAdjustment_DetailedEntity IEntityBuilder<HRSalaryAdjustment_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_EMPLOYEEFULLNAME = 10;
            const Int32 FLD_BEGINDATE = 11;
            const Int32 FLD_ENDDATE = 12;
            const Int32 FLD_SESSIONSTARTDATE = 13;
            const Int32 FLD_SESSIONENDDATE = 14;
            const Int32 FLD_DESIGNATIONNAME = 15;
            const Int32 FLD_EMPLOYEEJOBTYPENAME = 16;

            HRSalaryAdjustment_DetailedEntity hRSalaryAdjustment_DetailedEntity = new HRSalaryAdjustment_DetailedEntity();

            hRSalaryAdjustment_DetailedEntity.SalaryAdjustmentID = reader.GetInt64(FLD_SALARYADJUSTMENTID);
            hRSalaryAdjustment_DetailedEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hRSalaryAdjustment_DetailedEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hRSalaryAdjustment_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hRSalaryAdjustment_DetailedEntity.SalaryLevel = null; } else { hRSalaryAdjustment_DetailedEntity.SalaryLevel = reader.GetInt32(FLD_SALARYLEVEL); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hRSalaryAdjustment_DetailedEntity.DesignationID = null; } else { hRSalaryAdjustment_DetailedEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hRSalaryAdjustment_DetailedEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            hRSalaryAdjustment_DetailedEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            hRSalaryAdjustment_DetailedEntity.AdjustmentAmount = reader.GetDecimal(FLD_ADJUSTMENTAMOUNT);
            if (reader.IsDBNull(FLD_REMARKS)) { hRSalaryAdjustment_DetailedEntity.Remarks = String.Empty; } else { hRSalaryAdjustment_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hRSalaryAdjustment_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME);
            hRSalaryAdjustment_DetailedEntity.BeginDate = reader.GetDateTime(FLD_BEGINDATE);
            hRSalaryAdjustment_DetailedEntity.EndDate = reader.GetDateTime(FLD_ENDDATE);
            hRSalaryAdjustment_DetailedEntity.SessionStartDate = reader.GetDateTime(FLD_SESSIONSTARTDATE);
            hRSalaryAdjustment_DetailedEntity.SessionEndDate = reader.GetDateTime(FLD_SESSIONENDDATE);
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { hRSalaryAdjustment_DetailedEntity.DesignationName = String.Empty; } else { hRSalaryAdjustment_DetailedEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            hRSalaryAdjustment_DetailedEntity.EmployeeJobTypeName = reader.GetString(FLD_EMPLOYEEJOBTYPENAME);

            return hRSalaryAdjustment_DetailedEntity;
        }
    }
}
