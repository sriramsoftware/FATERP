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
    internal sealed class HREmployeeLeaveStatus_DetailedBuilder : IEntityBuilder<HREmployeeLeaveStatus_DetailedEntity>
    {
        IList<HREmployeeLeaveStatus_DetailedEntity> IEntityBuilder<HREmployeeLeaveStatus_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeLeaveStatus_DetailedEntity> HREmployeeLeaveStatus_DetailedEntityList = new List<HREmployeeLeaveStatus_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeLeaveStatus_DetailedEntityList.Add(((IEntityBuilder<HREmployeeLeaveStatus_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeLeaveStatus_DetailedEntityList.Count > 0) ? HREmployeeLeaveStatus_DetailedEntityList : null;
        }

        HREmployeeLeaveStatus_DetailedEntity IEntityBuilder<HREmployeeLeaveStatus_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            //const Int32 FLD_EMPLOYEELEAVEAPPLICATIONID = 0;
            //const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_CASUALLEAVEEARNED = 0;
            const Int32 FLD_MEDICALLEAVEEARNED = 1;
            const Int32 FLD_EARNLEAVEEARNED = 2;
            const Int32 FLD_LWPLEAVEEARNED = 3;
            const Int32 FLD_CASUALLEAVEENJOYED = 4;
            const Int32 FLD_MEDICALLEAVEENJOYED = 5;
            const Int32 FLD_EARNLEAVEENJOYED = 6;
            const Int32 FLD_LWPLEAVEENJOYED = 7;
            //const Int32 FLD_ROWNUMBER = 8;

            HREmployeeLeaveStatus_DetailedEntity hREmployeeLeaveStatus_DetailedEntity = new HREmployeeLeaveStatus_DetailedEntity();

            //hREmployeeLeaveStatus_DetailedEntity.EmployeeLeaveApplicationID = reader.GetInt64(FLD_EMPLOYEELEAVEAPPLICATIONID);
            //hREmployeeLeaveStatus_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            if (reader.IsDBNull(FLD_CASUALLEAVEEARNED)) { hREmployeeLeaveStatus_DetailedEntity.CasualLeaveEarned = null; } else { hREmployeeLeaveStatus_DetailedEntity.CasualLeaveEarned = reader.GetDecimal(FLD_CASUALLEAVEEARNED); }
            if (reader.IsDBNull(FLD_MEDICALLEAVEEARNED)) { hREmployeeLeaveStatus_DetailedEntity.MedicalLeaveEarned = null; } else { hREmployeeLeaveStatus_DetailedEntity.MedicalLeaveEarned = reader.GetDecimal(FLD_MEDICALLEAVEEARNED); }
            if (reader.IsDBNull(FLD_EARNLEAVEEARNED)) { hREmployeeLeaveStatus_DetailedEntity.EarnLeaveEarned = null; } else { hREmployeeLeaveStatus_DetailedEntity.EarnLeaveEarned = reader.GetDecimal(FLD_EARNLEAVEEARNED); }
            if (reader.IsDBNull(FLD_LWPLEAVEEARNED)) { hREmployeeLeaveStatus_DetailedEntity.LWPLeaveEarned = null; } else { hREmployeeLeaveStatus_DetailedEntity.LWPLeaveEarned = reader.GetDecimal(FLD_LWPLEAVEEARNED); }
            if (reader.IsDBNull(FLD_CASUALLEAVEENJOYED)) { hREmployeeLeaveStatus_DetailedEntity.CasualLeaveEnjoyed = null; } else { hREmployeeLeaveStatus_DetailedEntity.CasualLeaveEnjoyed = reader.GetDecimal(FLD_CASUALLEAVEENJOYED); }
            if (reader.IsDBNull(FLD_MEDICALLEAVEENJOYED)) { hREmployeeLeaveStatus_DetailedEntity.MedicalLeaveEnjoyed = null; } else { hREmployeeLeaveStatus_DetailedEntity.MedicalLeaveEnjoyed = reader.GetDecimal(FLD_MEDICALLEAVEENJOYED); }
            if (reader.IsDBNull(FLD_EARNLEAVEENJOYED)) { hREmployeeLeaveStatus_DetailedEntity.EarnLeaveEnjoyed = null; } else { hREmployeeLeaveStatus_DetailedEntity.EarnLeaveEnjoyed = reader.GetDecimal(FLD_EARNLEAVEENJOYED); }
            if (reader.IsDBNull(FLD_LWPLEAVEENJOYED)) { hREmployeeLeaveStatus_DetailedEntity.LWPLeaveEnjoyed = null; } else { hREmployeeLeaveStatus_DetailedEntity.LWPLeaveEnjoyed = reader.GetDecimal(FLD_LWPLEAVEENJOYED); }
            //hREmployeeLeaveStatus_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER);

            return hREmployeeLeaveStatus_DetailedEntity;
        }
    }
}
