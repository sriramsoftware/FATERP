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
    internal sealed class HREmployeePhoneBillAdjustmentBuilder : IEntityBuilder<HREmployeePhoneBillAdjustmentEntity>
    {
        IList<HREmployeePhoneBillAdjustmentEntity> IEntityBuilder<HREmployeePhoneBillAdjustmentEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeePhoneBillAdjustmentEntity> HREmployeePhoneBillAdjustmentEntityList = new List<HREmployeePhoneBillAdjustmentEntity>();

            while (reader.Read())
            {
                HREmployeePhoneBillAdjustmentEntityList.Add(((IEntityBuilder<HREmployeePhoneBillAdjustmentEntity>)this).BuildEntity(reader));
            }

            return (HREmployeePhoneBillAdjustmentEntityList.Count > 0) ? HREmployeePhoneBillAdjustmentEntityList : null;
        }

        HREmployeePhoneBillAdjustmentEntity IEntityBuilder<HREmployeePhoneBillAdjustmentEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PHONEBILLADJUSTMENTID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_SALARYSESSIONID = 2;
            const Int32 FLD_PHONEBILLAMOUNT = 3;
            const Int32 FLD_PHONEBILLNOTE = 4;
            const Int32 FLD_ISREMOVED= 5;

            HREmployeePhoneBillAdjustmentEntity hREmployeePhoneBillAdjustmentEntity = new HREmployeePhoneBillAdjustmentEntity();

            hREmployeePhoneBillAdjustmentEntity.PhoneBillAdjustmentID = reader.GetInt64(FLD_PHONEBILLADJUSTMENTID);
            hREmployeePhoneBillAdjustmentEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeePhoneBillAdjustmentEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hREmployeePhoneBillAdjustmentEntity.PhoneBillAmount= reader.GetDecimal(FLD_PHONEBILLAMOUNT);
            if (reader.IsDBNull(FLD_PHONEBILLNOTE)) { hREmployeePhoneBillAdjustmentEntity.PhoneBillNote = String.Empty; } else { hREmployeePhoneBillAdjustmentEntity.PhoneBillNote = reader.GetString(FLD_PHONEBILLNOTE); }
            hREmployeePhoneBillAdjustmentEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return hREmployeePhoneBillAdjustmentEntity;
        }
    }
}
