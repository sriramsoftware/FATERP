// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDDepartmentBuilder : IEntityBuilder<MDDepartmentEntity>
    {
        IList<MDDepartmentEntity> IEntityBuilder<MDDepartmentEntity>.BuildEntities(IDataReader reader)
        {
            List<MDDepartmentEntity> MDDepartmentEntityList = new List<MDDepartmentEntity>();

            while (reader.Read())
            {
                MDDepartmentEntityList.Add(((IEntityBuilder<MDDepartmentEntity>)this).BuildEntity(reader));
            }

            return (MDDepartmentEntityList.Count > 0) ? MDDepartmentEntityList : null;
        }

        MDDepartmentEntity IEntityBuilder<MDDepartmentEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DEPARTMENTID = 0;
            const Int32 FLD_PARENTDEPARTMENTID = 1;
            const Int32 FLD_DEPARTMENTCODE = 2;
            const Int32 FLD_NAME = 3;
            const Int32 FLD_LOCATION = 4;
            const Int32 FLD_HODEMPLOYEEID = 5;
            const Int32 FLD_ISREMOVED = 6;

            MDDepartmentEntity mDDepartmentEntity = new MDDepartmentEntity();

            mDDepartmentEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            if (reader.IsDBNull(FLD_PARENTDEPARTMENTID)) { mDDepartmentEntity.ParentDepartmentID = null; } else { mDDepartmentEntity.ParentDepartmentID = reader.GetInt64(FLD_PARENTDEPARTMENTID); }
            mDDepartmentEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE);
            mDDepartmentEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_LOCATION)) { mDDepartmentEntity.Location = String.Empty; } else { mDDepartmentEntity.Location = reader.GetString(FLD_LOCATION); }
            if (reader.IsDBNull(FLD_HODEMPLOYEEID)) { mDDepartmentEntity.HODEmployeeID = null; } else { mDDepartmentEntity.HODEmployeeID = reader.GetInt64(FLD_HODEMPLOYEEID); }
            mDDepartmentEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDDepartmentEntity;
        }
    }
}
