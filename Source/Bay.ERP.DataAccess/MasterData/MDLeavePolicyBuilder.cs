// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Nov-2013, 09:51:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDLeavePolicyBuilder : IEntityBuilder<MDLeavePolicyEntity>
    {
        IList<MDLeavePolicyEntity> IEntityBuilder<MDLeavePolicyEntity>.BuildEntities(IDataReader reader)
        {
            List<MDLeavePolicyEntity> MDLeavePolicyEntityList = new List<MDLeavePolicyEntity>();

            while (reader.Read())
            {
                MDLeavePolicyEntityList.Add(((IEntityBuilder<MDLeavePolicyEntity>)this).BuildEntity(reader));
            }

            return (MDLeavePolicyEntityList.Count > 0) ? MDLeavePolicyEntityList : null;
        }

        MDLeavePolicyEntity IEntityBuilder<MDLeavePolicyEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_LEAVEPOLICYID= 0;
            const Int32 FLD_FISCALYEARID = 1;
            const Int32 FLD_EMPLOYEEJOBTYPEID = 2;
            const Int32 FLD_LEAVECATEGORYID = 3;
            const Int32 FLD_LEAVEINDAYS = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_ISREMOVED = 6;
            const Int32 FLD_EXTRAFIELD1 = 7;
            const Int32 FLD_EXTRAFIELD2 = 8;
            MDLeavePolicyEntity mDLeavePolicyEntity = new MDLeavePolicyEntity();

            mDLeavePolicyEntity.LeavePolicyID = reader.GetInt64(FLD_LEAVEPOLICYID);
            mDLeavePolicyEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            mDLeavePolicyEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            mDLeavePolicyEntity.LeaveCategoryID = reader.GetInt64(FLD_LEAVECATEGORYID);
            mDLeavePolicyEntity.LeaveInDays = reader.GetDecimal(FLD_LEAVEINDAYS);
            if (reader.IsDBNull(FLD_REMARKS)) { mDLeavePolicyEntity.Remarks = String.Empty; } else { mDLeavePolicyEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDLeavePolicyEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_EXTRAFIELD1)) { mDLeavePolicyEntity.ExtraField1 = String.Empty; } else { mDLeavePolicyEntity.ExtraField1 = reader.GetString(FLD_EXTRAFIELD1); }
            if (reader.IsDBNull(FLD_EXTRAFIELD2)) { mDLeavePolicyEntity.ExtraField2 = String.Empty; } else { mDLeavePolicyEntity.ExtraField2 = reader.GetString(FLD_EXTRAFIELD2); }

            return mDLeavePolicyEntity;
        }
    }
}
