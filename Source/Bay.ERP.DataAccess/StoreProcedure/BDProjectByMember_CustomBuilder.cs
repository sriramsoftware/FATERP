// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jul-2012, 02:14:35




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectByMember_CustomBuilder : IEntityBuilder<BDProjectByMember_CustomEntity>
    {
        IList<BDProjectByMember_CustomEntity> IEntityBuilder<BDProjectByMember_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectByMember_CustomEntity> BDProjectByMember_CustomEntityList = new List<BDProjectByMember_CustomEntity>();

            while (reader.Read())
            {
                BDProjectByMember_CustomEntityList.Add(((IEntityBuilder<BDProjectByMember_CustomEntity>)this).BuildEntity(reader));
            }

            return (BDProjectByMember_CustomEntityList.Count > 0) ? BDProjectByMember_CustomEntityList : null;
        }

        BDProjectByMember_CustomEntity IEntityBuilder<BDProjectByMember_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTID = 0;
            const Int32 FLD_PROJECTNAME = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_MEMBERID = 3;

            BDProjectByMember_CustomEntity bDProjectByMember_CustomEntity = new BDProjectByMember_CustomEntity();

            bDProjectByMember_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectByMember_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            bDProjectByMember_CustomEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            bDProjectByMember_CustomEntity.MemberID = reader.GetInt64(FLD_MEMBERID);

            return bDProjectByMember_CustomEntity;
        }
    }
}
