// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Oct-2012, 06:49:23




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APPanelForwardMember_DetailedBuilder : IEntityBuilder<APPanelForwardMember_DetailedEntity>
    {
        IList<APPanelForwardMember_DetailedEntity> IEntityBuilder<APPanelForwardMember_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<APPanelForwardMember_DetailedEntity> APPanelForwardMember_DetailedEntityList = new List<APPanelForwardMember_DetailedEntity>();

            while (reader.Read())
            {
                APPanelForwardMember_DetailedEntityList.Add(((IEntityBuilder<APPanelForwardMember_DetailedEntity>)this).BuildEntity(reader));
            }

            return (APPanelForwardMember_DetailedEntityList.Count > 0) ? APPanelForwardMember_DetailedEntityList : null;
        }

        APPanelForwardMember_DetailedEntity IEntityBuilder<APPanelForwardMember_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPANELFORWARDMEMBERID = 0;
            const Int32 FLD_APPANELID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_DEPARTMENTID = 3;
            const Int32 FLD_APPANELNAME = 4;
            const Int32 FLD_HREMPLOYEEMEMBERID = 5;
            const Int32 FLD_MEMBERFULLNAME = 6;
            const Int32 FLD_MDDEPARTMENTNAME = 7;
            const Int32 FLD_ROWNUMBER = 8;

            APPanelForwardMember_DetailedEntity aPPanelForwardMember_DetailedEntity = new APPanelForwardMember_DetailedEntity();

            aPPanelForwardMember_DetailedEntity.APPanelForwardMemberID = reader.GetInt64(FLD_APPANELFORWARDMEMBERID);
            aPPanelForwardMember_DetailedEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            aPPanelForwardMember_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            aPPanelForwardMember_DetailedEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            if (reader.IsDBNull(FLD_APPANELNAME)) { aPPanelForwardMember_DetailedEntity.APPanelName = String.Empty; } else { aPPanelForwardMember_DetailedEntity.APPanelName = reader.GetString(FLD_APPANELNAME); }
            if (reader.IsDBNull(FLD_HREMPLOYEEMEMBERID)) { aPPanelForwardMember_DetailedEntity.HREmployeeMemberID = null; } else { aPPanelForwardMember_DetailedEntity.HREmployeeMemberID = reader.GetInt64(FLD_HREMPLOYEEMEMBERID); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aPPanelForwardMember_DetailedEntity.MemberFullName = String.Empty; } else { aPPanelForwardMember_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_MDDEPARTMENTNAME)) { aPPanelForwardMember_DetailedEntity.MDDepartmentName = String.Empty; } else { aPPanelForwardMember_DetailedEntity.MDDepartmentName = reader.GetString(FLD_MDDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aPPanelForwardMember_DetailedEntity.RowNumber = null; } else { aPPanelForwardMember_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aPPanelForwardMember_DetailedEntity;
        }
    }
}
