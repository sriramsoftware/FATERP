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
    internal sealed class APPanelForwardMemberBuilder : IEntityBuilder<APPanelForwardMemberEntity>
    {
        IList<APPanelForwardMemberEntity> IEntityBuilder<APPanelForwardMemberEntity>.BuildEntities(IDataReader reader)
        {
            List<APPanelForwardMemberEntity> APPanelForwardMemberEntityList = new List<APPanelForwardMemberEntity>();

            while (reader.Read())
            {
                APPanelForwardMemberEntityList.Add(((IEntityBuilder<APPanelForwardMemberEntity>)this).BuildEntity(reader));
            }

            return (APPanelForwardMemberEntityList.Count > 0) ? APPanelForwardMemberEntityList : null;
        }

        APPanelForwardMemberEntity IEntityBuilder<APPanelForwardMemberEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPANELFORWARDMEMBERID = 0;
            const Int32 FLD_APPANELID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_DEPARTMENTID = 3;

            APPanelForwardMemberEntity aPPanelForwardMemberEntity = new APPanelForwardMemberEntity();

            aPPanelForwardMemberEntity.APPanelForwardMemberID = reader.GetInt64(FLD_APPANELFORWARDMEMBERID);
            aPPanelForwardMemberEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            aPPanelForwardMemberEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            aPPanelForwardMemberEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);

            return aPPanelForwardMemberEntity;
        }
    }
}
