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
    internal sealed class MDLeavePolicy_DetailedBuilder : IEntityBuilder<MDLeavePolicy_DetailedEntity>
    {
        IList<MDLeavePolicy_DetailedEntity> IEntityBuilder<MDLeavePolicy_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<MDLeavePolicy_DetailedEntity> MDLeavePolicy_DetailedEntityList = new List<MDLeavePolicy_DetailedEntity>();

            while (reader.Read())
            {
                MDLeavePolicy_DetailedEntityList.Add(((IEntityBuilder<MDLeavePolicy_DetailedEntity>)this).BuildEntity(reader));
            }

            return (MDLeavePolicy_DetailedEntityList.Count > 0) ? MDLeavePolicy_DetailedEntityList : null;
        }

        MDLeavePolicy_DetailedEntity IEntityBuilder<MDLeavePolicy_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_LEAVEPOLICYID = 0;
            const Int32 FLD_FISCALYEARID = 1;
            const Int32 FLD_EMPLOYEEJOBTYPEID = 2;
            const Int32 FLD_LEAVECATEGORYID = 3;
            const Int32 FLD_LEAVEINDAYS = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_ISREMOVED = 6;
            const Int32 FLD_EXTRAFIELD1 = 7;
            const Int32 FLD_EXTRAFIELD2 = 8;
            const Int32 FLD_FISCALYEARBEGINDATE = 9;
            const Int32 FLD_FISCALYEARENDDATE = 10;
            const Int32 FLD_EMPLOYEEJOBTYPENAME = 11;
            const Int32 FLD_LEAVECATEGORYNAME = 12;
            const Int32 FLD_ROWNUMBER = 13;

            MDLeavePolicy_DetailedEntity mDLeavePolicy_DetailedEntity = new MDLeavePolicy_DetailedEntity();

            mDLeavePolicy_DetailedEntity.LeavePolicyID = reader.GetInt64(FLD_LEAVEPOLICYID);
            mDLeavePolicy_DetailedEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            mDLeavePolicy_DetailedEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            mDLeavePolicy_DetailedEntity.LeaveCategoryID = reader.GetInt64(FLD_LEAVECATEGORYID);
            mDLeavePolicy_DetailedEntity.LeaveInDays = reader.GetDecimal(FLD_LEAVEINDAYS);
            if (reader.IsDBNull(FLD_REMARKS)) { mDLeavePolicy_DetailedEntity.Remarks = String.Empty; } else { mDLeavePolicy_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDLeavePolicy_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_EXTRAFIELD1)) { mDLeavePolicy_DetailedEntity.ExtraField1 = String.Empty; } else { mDLeavePolicy_DetailedEntity.ExtraField1 = reader.GetString(FLD_EXTRAFIELD1); }
            if (reader.IsDBNull(FLD_EXTRAFIELD2)) { mDLeavePolicy_DetailedEntity.ExtraField2 = String.Empty; } else { mDLeavePolicy_DetailedEntity.ExtraField2 = reader.GetString(FLD_EXTRAFIELD2); }
            mDLeavePolicy_DetailedEntity.FiscalYearBeginDate = reader.GetDateTime(FLD_FISCALYEARBEGINDATE);
            mDLeavePolicy_DetailedEntity.FiscalYearEndDate = reader.GetDateTime(FLD_FISCALYEARENDDATE);
            mDLeavePolicy_DetailedEntity.EmployeeJobTypeName = reader.GetString(FLD_EMPLOYEEJOBTYPENAME);
            mDLeavePolicy_DetailedEntity.LeaveCategoryName = reader.GetString(FLD_LEAVECATEGORYNAME);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { mDLeavePolicy_DetailedEntity.RowNumber = null; } else { mDLeavePolicy_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return mDLeavePolicy_DetailedEntity;
        }
    }
}
