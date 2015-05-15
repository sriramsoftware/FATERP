// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APPanelMemberBuilder : IEntityBuilder<APPanelMemberEntity>
    {
        IList<APPanelMemberEntity> IEntityBuilder<APPanelMemberEntity>.BuildEntities(IDataReader reader)
        {
            List<APPanelMemberEntity> APPanelMemberEntityList = new List<APPanelMemberEntity>();

            while (reader.Read())
            {
                APPanelMemberEntityList.Add(((IEntityBuilder<APPanelMemberEntity>)this).BuildEntity(reader));
            }

            return (APPanelMemberEntityList.Count > 0) ? APPanelMemberEntityList : null;
        }

        APPanelMemberEntity IEntityBuilder<APPanelMemberEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPANELMEMBERID = 0;
            const Int32 FLD_APPANELID = 1;
            const Int32 FLD_DEPARTMENTID = 2;
            const Int32 FLD_EMPLOYEEID = 3;
            const Int32 FLD_SEQUENCENO = 4;
            const Int32 FLD_PROXYEMPLOYEEID = 5;
            const Int32 FLD_ISPROXYEMPLOYEEENABLED = 6;

            APPanelMemberEntity aPPanelMemberEntity = new APPanelMemberEntity();

            aPPanelMemberEntity.APPanelMemberID = reader.GetInt64(FLD_APPANELMEMBERID);
            aPPanelMemberEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            aPPanelMemberEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            aPPanelMemberEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            aPPanelMemberEntity.SequenceNo = reader.GetInt32(FLD_SEQUENCENO);
            if (reader.IsDBNull(FLD_PROXYEMPLOYEEID)) { aPPanelMemberEntity.ProxyEmployeeID = null; } else { aPPanelMemberEntity.ProxyEmployeeID = reader.GetInt64(FLD_PROXYEMPLOYEEID); }
            aPPanelMemberEntity.IsProxyEmployeeEnabled = reader.GetBoolean(FLD_ISPROXYEMPLOYEEENABLED);

            return aPPanelMemberEntity;
        }
    }
}
