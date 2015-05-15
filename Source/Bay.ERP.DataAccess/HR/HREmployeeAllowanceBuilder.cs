// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 12:08:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeAllowanceBuilder : IEntityBuilder<HREmployeeAllowanceEntity>
    {
        IList<HREmployeeAllowanceEntity> IEntityBuilder<HREmployeeAllowanceEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeAllowanceEntity> HREmployeeAllowanceEntityList = new List<HREmployeeAllowanceEntity>();

            while (reader.Read())
            {
                HREmployeeAllowanceEntityList.Add(((IEntityBuilder<HREmployeeAllowanceEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeAllowanceEntityList.Count > 0) ? HREmployeeAllowanceEntityList : null;
        }

        HREmployeeAllowanceEntity IEntityBuilder<HREmployeeAllowanceEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEALLOWANCEID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_FISCALYEARID = 2;
            const Int32 FLD_ALLOWANCECATEGORYID = 3;
            const Int32 FLD_AMOUNT = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_CREATEDATE = 6;

            HREmployeeAllowanceEntity hREmployeeAllowanceEntity = new HREmployeeAllowanceEntity();

            hREmployeeAllowanceEntity.EmployeeAllowanceID = reader.GetInt64(FLD_EMPLOYEEALLOWANCEID);
            hREmployeeAllowanceEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeAllowanceEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hREmployeeAllowanceEntity.AllowanceCategoryID = reader.GetInt64(FLD_ALLOWANCECATEGORYID);
            hREmployeeAllowanceEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeAllowanceEntity.Remarks = String.Empty; } else { hREmployeeAllowanceEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hREmployeeAllowanceEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);

            return hREmployeeAllowanceEntity;
        }
    }
}
