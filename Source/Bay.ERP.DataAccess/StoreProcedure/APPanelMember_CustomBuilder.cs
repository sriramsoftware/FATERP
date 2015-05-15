// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:49:00




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APPanelMember_CustomBuilder : IEntityBuilder<APPanelMember_CustomEntity>
    {
        IList<APPanelMember_CustomEntity> IEntityBuilder<APPanelMember_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<APPanelMember_CustomEntity> APPanelMember_CustomEntityList = new List<APPanelMember_CustomEntity>();

            while (reader.Read())
            {
                APPanelMember_CustomEntityList.Add(((IEntityBuilder<APPanelMember_CustomEntity>)this).BuildEntity(reader));
            }

            return (APPanelMember_CustomEntityList.Count > 0) ? APPanelMember_CustomEntityList : null;
        }

        APPanelMember_CustomEntity IEntityBuilder<APPanelMember_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPANELMEMBERID = 0;
            const Int32 FLD_APPANELID = 1;
            const Int32 FLD_DEPARTMENTID = 2;
            const Int32 FLD_EMPLOYEEID = 3;
            const Int32 FLD_SEQUENCENO = 4;
            const Int32 FLD_PROXYEMPLOYEEID = 5;
            const Int32 FLD_ISPROXYEMPLOYEEENABLED = 6;
            const Int32 FLD_PANELNAME = 7;
            const Int32 FLD_DEPARTMENTNAME = 8;
            const Int32 FLD_MEMBERFULLNAME = 9;
            const Int32 FLD_HREMPLOYEEMEMBERID = 10;
            const Int32 FLD_PROXYMEMBERFULLNAME = 11;
            const Int32 FLD_PROXYHREMPLOYEEMEMBERID = 12;
            const Int32 FLD_ROWNUMBER = 13;

            APPanelMember_CustomEntity aPPanelMember_CustomEntity = new APPanelMember_CustomEntity();

            aPPanelMember_CustomEntity.APPanelMemberID = reader.GetInt64(FLD_APPANELMEMBERID);
            aPPanelMember_CustomEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            aPPanelMember_CustomEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            aPPanelMember_CustomEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            aPPanelMember_CustomEntity.SequenceNo = reader.GetInt32(FLD_SEQUENCENO);
            if (reader.IsDBNull(FLD_PROXYEMPLOYEEID)) { aPPanelMember_CustomEntity.ProxyEmployeeID = null; } else { aPPanelMember_CustomEntity.ProxyEmployeeID = reader.GetInt64(FLD_PROXYEMPLOYEEID); }
            aPPanelMember_CustomEntity.IsProxyEmployeeEnabled = reader.GetBoolean(FLD_ISPROXYEMPLOYEEENABLED);
            if (reader.IsDBNull(FLD_PANELNAME)) { aPPanelMember_CustomEntity.PanelName = String.Empty; } else { aPPanelMember_CustomEntity.PanelName = reader.GetString(FLD_PANELNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTNAME)) { aPPanelMember_CustomEntity.DepartmentName = String.Empty; } else { aPPanelMember_CustomEntity.DepartmentName = reader.GetString(FLD_DEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aPPanelMember_CustomEntity.MemberFullName = String.Empty; } else { aPPanelMember_CustomEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_HREMPLOYEEMEMBERID)) { aPPanelMember_CustomEntity.HREmployeeMemberID = null; } else { aPPanelMember_CustomEntity.HREmployeeMemberID = reader.GetInt64(FLD_HREMPLOYEEMEMBERID); }
            if (reader.IsDBNull(FLD_PROXYMEMBERFULLNAME)) { aPPanelMember_CustomEntity.ProxyMemberFullName = String.Empty; } else { aPPanelMember_CustomEntity.ProxyMemberFullName = reader.GetString(FLD_PROXYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_PROXYHREMPLOYEEMEMBERID)) { aPPanelMember_CustomEntity.ProxyHREmployeeMemberID = null; } else { aPPanelMember_CustomEntity.ProxyHREmployeeMemberID = reader.GetInt64(FLD_PROXYHREMPLOYEEMEMBERID); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aPPanelMember_CustomEntity.RowNumber = null; } else { aPPanelMember_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aPPanelMember_CustomEntity;
        }
    }
}
