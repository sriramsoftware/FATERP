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
    internal sealed class HREmployeeAllowance_DetailedBuilder : IEntityBuilder<HREmployeeAllowance_DetailedEntity>
    {
        IList<HREmployeeAllowance_DetailedEntity> IEntityBuilder<HREmployeeAllowance_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeAllowance_DetailedEntity> HREmployeeAllowance_DetailedEntityList = new List<HREmployeeAllowance_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeAllowance_DetailedEntityList.Add(((IEntityBuilder<HREmployeeAllowance_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeAllowance_DetailedEntityList.Count > 0) ? HREmployeeAllowance_DetailedEntityList : null;
        }

        HREmployeeAllowance_DetailedEntity IEntityBuilder<HREmployeeAllowance_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEALLOWANCEID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_FISCALYEARID = 2;
            const Int32 FLD_ALLOWANCECATEGORYID = 3;
            const Int32 FLD_AMOUNT = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_CREATEDATE = 6;
            const Int32 FLD_EMPLOYEEFULLNAME = 7;
            const Int32 FLD_FISCALYEARBEGINDATE = 8;
            const Int32 FLD_FISCALYEARENDDATE = 9;
            const Int32 FLD_ALLOWANCECATEGORYNAME = 10;
            const Int32 FLD_EMPLOYEECODE= 11;

            HREmployeeAllowance_DetailedEntity hREmployeeAllowance_DetailedEntity = new HREmployeeAllowance_DetailedEntity();

            hREmployeeAllowance_DetailedEntity.EmployeeAllowanceID = reader.GetInt64(FLD_EMPLOYEEALLOWANCEID);
            hREmployeeAllowance_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeAllowance_DetailedEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hREmployeeAllowance_DetailedEntity.AllowanceCategoryID = reader.GetInt64(FLD_ALLOWANCECATEGORYID);
            hREmployeeAllowance_DetailedEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeAllowance_DetailedEntity.Remarks = String.Empty; } else { hREmployeeAllowance_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hREmployeeAllowance_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            hREmployeeAllowance_DetailedEntity.FiscalYearBeginDate = reader.GetDateTime(FLD_FISCALYEARBEGINDATE);
            hREmployeeAllowance_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME);
            hREmployeeAllowance_DetailedEntity.FiscalYearEndDate = reader.GetDateTime(FLD_FISCALYEARENDDATE);
            hREmployeeAllowance_DetailedEntity.AllowanceCategoryName = reader.GetString(FLD_ALLOWANCECATEGORYNAME);
            hREmployeeAllowance_DetailedEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);

            return hREmployeeAllowance_DetailedEntity;
        }
    }
}
