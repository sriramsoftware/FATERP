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
    internal sealed class HREmployeeContactInfoBuilder : IEntityBuilder<HREmployeeContactInfoEntity>
    {
        IList<HREmployeeContactInfoEntity> IEntityBuilder<HREmployeeContactInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeContactInfoEntity> HREmployeeContactInfoEntityList = new List<HREmployeeContactInfoEntity>();

            while (reader.Read())
            {
                HREmployeeContactInfoEntityList.Add(((IEntityBuilder<HREmployeeContactInfoEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeContactInfoEntityList.Count > 0) ? HREmployeeContactInfoEntityList : null;
        }

        HREmployeeContactInfoEntity IEntityBuilder<HREmployeeContactInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEECONTACTINFOID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_EMPLOYEECONTACTTYPEID = 2;
            const Int32 FLD_CONTACTINFO = 3;
            const Int32 FLD_DESCRIPTION = 4;
            const Int32 FLD_REMARKS = 5;

            HREmployeeContactInfoEntity hREmployeeContactInfoEntity = new HREmployeeContactInfoEntity();

            hREmployeeContactInfoEntity.EmployeeContactInfoID = reader.GetInt64(FLD_EMPLOYEECONTACTINFOID);
            hREmployeeContactInfoEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeContactInfoEntity.EmployeeContactTypeID = reader.GetInt64(FLD_EMPLOYEECONTACTTYPEID);
            hREmployeeContactInfoEntity.ContactInfo = reader.GetString(FLD_CONTACTINFO);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hREmployeeContactInfoEntity.Description = String.Empty; } else { hREmployeeContactInfoEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeContactInfoEntity.Remarks = String.Empty; } else { hREmployeeContactInfoEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return hREmployeeContactInfoEntity;
        }
    }
}
