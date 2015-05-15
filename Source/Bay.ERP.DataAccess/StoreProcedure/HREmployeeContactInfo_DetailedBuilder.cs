// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeContactInfo_DetailedBuilder : IEntityBuilder<HREmployeeContactInfo_DetailedEntity>
    {
        IList<HREmployeeContactInfo_DetailedEntity> IEntityBuilder<HREmployeeContactInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeContactInfo_DetailedEntity> HREmployeeContactInfo_DetailedEntityList = new List<HREmployeeContactInfo_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeContactInfo_DetailedEntityList.Add(((IEntityBuilder<HREmployeeContactInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeContactInfo_DetailedEntityList.Count > 0) ? HREmployeeContactInfo_DetailedEntityList : null;
        }

        HREmployeeContactInfo_DetailedEntity IEntityBuilder<HREmployeeContactInfo_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEECONTACTINFOID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_EMPLOYEECONTACTTYPEID = 2;
            const Int32 FLD_CONTACTINFO = 3;
            const Int32 FLD_DESCRIPTION = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_EMPLOYEEFULLNAME = 6;
            const Int32 FLD_EMPLOYEECONTACTTYPENAME = 7;
            const Int32 FLD_ROWNUMBER = 8;

            HREmployeeContactInfo_DetailedEntity hREmployeeContactInfo_DetailedEntity = new HREmployeeContactInfo_DetailedEntity();

            hREmployeeContactInfo_DetailedEntity.EmployeeContactInfoID = reader.GetInt64(FLD_EMPLOYEECONTACTINFOID);
            hREmployeeContactInfo_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeContactInfo_DetailedEntity.EmployeeContactTypeID = reader.GetInt64(FLD_EMPLOYEECONTACTTYPEID);
            hREmployeeContactInfo_DetailedEntity.ContactInfo = reader.GetString(FLD_CONTACTINFO);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hREmployeeContactInfo_DetailedEntity.Description = String.Empty; } else { hREmployeeContactInfo_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeContactInfo_DetailedEntity.Remarks = String.Empty; } else { hREmployeeContactInfo_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeContactInfo_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeContactInfo_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEECONTACTTYPENAME)) { hREmployeeContactInfo_DetailedEntity.EmployeeContactTypeName = String.Empty; } else { hREmployeeContactInfo_DetailedEntity.EmployeeContactTypeName = reader.GetString(FLD_EMPLOYEECONTACTTYPENAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployeeContactInfo_DetailedEntity.RowNumber = null; } else { hREmployeeContactInfo_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hREmployeeContactInfo_DetailedEntity;
        }
    }
}
