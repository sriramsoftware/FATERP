// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jul-2012, 01:15:03




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRMember_CustomBuilder : IEntityBuilder<HRMember_CustomEntity>
    {
        IList<HRMember_CustomEntity> IEntityBuilder<HRMember_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<HRMember_CustomEntity> HRMember_CustomEntityList = new List<HRMember_CustomEntity>();

            while (reader.Read())
            {
                HRMember_CustomEntityList.Add(((IEntityBuilder<HRMember_CustomEntity>)this).BuildEntity(reader));
            }

            return (HRMember_CustomEntityList.Count > 0) ? HRMember_CustomEntityList : null;
        }

        HRMember_CustomEntity IEntityBuilder<HRMember_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MEMBERID = 0;
            const Int32 FLD_FIRSTNAME = 1;
            const Int32 FLD_MIDDLENAME = 2;
            const Int32 FLD_LASTNAME = 3;
            const Int32 FLD_MEMBERTYPEID = 4;
            const Int32 FLD_USERID = 5;
            const Int32 FLD_USERNAME = 6;
            const Int32 FLD_MEMBERTYPENAME = 7;
            const Int32 FLD_EMPLOYEECODE = 8;
            const Int32 FLD_USERROLE = 9;
            const Int32 FLD_ROWNUMBER = 10;

            HRMember_CustomEntity hRMember_CustomEntity = new HRMember_CustomEntity();

            hRMember_CustomEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            hRMember_CustomEntity.FirstName = reader.GetString(FLD_FIRSTNAME);
            if (reader.IsDBNull(FLD_MIDDLENAME)) { hRMember_CustomEntity.MiddleName = String.Empty; } else { hRMember_CustomEntity.MiddleName = reader.GetString(FLD_MIDDLENAME); }
            hRMember_CustomEntity.LastName = reader.GetString(FLD_LASTNAME);
            hRMember_CustomEntity.MemberTypeID = reader.GetInt64(FLD_MEMBERTYPEID);
            if (reader.IsDBNull(FLD_USERID)) { hRMember_CustomEntity.UserId = new Guid(); } else { hRMember_CustomEntity.UserId = reader.GetGuid(FLD_USERID); }
            if (reader.IsDBNull(FLD_USERNAME)) { hRMember_CustomEntity.UserName = String.Empty; } else { hRMember_CustomEntity.UserName = reader.GetString(FLD_USERNAME); }
            if (reader.IsDBNull(FLD_MEMBERTYPENAME)) { hRMember_CustomEntity.MemberTypeName = String.Empty; } else { hRMember_CustomEntity.MemberTypeName = reader.GetString(FLD_MEMBERTYPENAME); }
            if (reader.IsDBNull(FLD_EMPLOYEECODE)) { hRMember_CustomEntity.EmployeeCode = String.Empty; } else { hRMember_CustomEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE); }
            if (reader.IsDBNull(FLD_USERROLE)) { hRMember_CustomEntity.UserRole = String.Empty; } else { hRMember_CustomEntity.UserRole = reader.GetString(FLD_USERROLE); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hRMember_CustomEntity.RowNumber = null; } else { hRMember_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hRMember_CustomEntity;
        }
    }
}
