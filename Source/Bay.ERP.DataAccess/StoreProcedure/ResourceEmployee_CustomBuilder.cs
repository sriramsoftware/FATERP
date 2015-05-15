// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jan-2013, 02:02:12




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ResourceEmployee_CustomBuilder : IEntityBuilder<ResourceEmployee_CustomEntity>
    {
        IList<ResourceEmployee_CustomEntity> IEntityBuilder<ResourceEmployee_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ResourceEmployee_CustomEntity> ResourceEmployee_CustomEntityList = new List<ResourceEmployee_CustomEntity>();

            while (reader.Read())
            {
                ResourceEmployee_CustomEntityList.Add(((IEntityBuilder<ResourceEmployee_CustomEntity>)this).BuildEntity(reader));
            }

            return (ResourceEmployee_CustomEntityList.Count > 0) ? ResourceEmployee_CustomEntityList : null;
        }

        ResourceEmployee_CustomEntity IEntityBuilder<ResourceEmployee_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESOURCEID = 0;
            const Int32 FLD_REFERENCEID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_EMPLOYEECODE = 3;
            const Int32 FLD_DESIGNATIONID = 4;
            const Int32 FLD_DOB = 5;
            const Int32 FLD_JOINDATE = 6;
            const Int32 FLD_CONFIRMDATE = 7;
            const Int32 FLD_BLOODGROUPID = 8;
            const Int32 FLD_EMPLOYEEJOBTYPEID = 9;
            const Int32 FLD_PRIMARYEMAIL = 10;
            const Int32 FLD_SECONDARYEMAIL = 11;
            const Int32 FLD_RESOURCECATEGORYNAME = 12;
            const Int32 FLD_MEMBERFULLNAME = 13;
            const Int32 FLD_DESIGNATIONNAME = 14;
            const Int32 FLD_DEPARTMENTNAME = 15;
            const Int32 FLD_BLOODGROUPNAME = 16;
            const Int32 FLD_EMPLOYEEJOBTYPENAME = 17;

            ResourceEmployee_CustomEntity resourceEmployee_CustomEntity = new ResourceEmployee_CustomEntity();

            resourceEmployee_CustomEntity.ResourceID = reader.GetInt64(FLD_RESOURCEID);
            resourceEmployee_CustomEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            resourceEmployee_CustomEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            resourceEmployee_CustomEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { resourceEmployee_CustomEntity.DesignationID = null; } else { resourceEmployee_CustomEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            if (reader.IsDBNull(FLD_DOB)) { resourceEmployee_CustomEntity.DOB = null; } else { resourceEmployee_CustomEntity.DOB = reader.GetDateTime(FLD_DOB); }
            if (reader.IsDBNull(FLD_JOINDATE)) { resourceEmployee_CustomEntity.JoinDate = null; } else { resourceEmployee_CustomEntity.JoinDate = reader.GetDateTime(FLD_JOINDATE); }
            if (reader.IsDBNull(FLD_CONFIRMDATE)) { resourceEmployee_CustomEntity.ConfirmDate = null; } else { resourceEmployee_CustomEntity.ConfirmDate = reader.GetDateTime(FLD_CONFIRMDATE); }
            if (reader.IsDBNull(FLD_BLOODGROUPID)) { resourceEmployee_CustomEntity.BloodGroupID = null; } else { resourceEmployee_CustomEntity.BloodGroupID = reader.GetInt64(FLD_BLOODGROUPID); }
            resourceEmployee_CustomEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_PRIMARYEMAIL)) { resourceEmployee_CustomEntity.PrimaryEmail = String.Empty; } else { resourceEmployee_CustomEntity.PrimaryEmail = reader.GetString(FLD_PRIMARYEMAIL); }
            if (reader.IsDBNull(FLD_SECONDARYEMAIL)) { resourceEmployee_CustomEntity.SecondaryEmail = String.Empty; } else { resourceEmployee_CustomEntity.SecondaryEmail = reader.GetString(FLD_SECONDARYEMAIL); }
            resourceEmployee_CustomEntity.ResourceCategoryName = reader.GetString(FLD_RESOURCECATEGORYNAME);
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { resourceEmployee_CustomEntity.MemberFullName = String.Empty; } else { resourceEmployee_CustomEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { resourceEmployee_CustomEntity.DesignationName = String.Empty; } else { resourceEmployee_CustomEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTNAME)) { resourceEmployee_CustomEntity.DepartmentName = String.Empty; } else { resourceEmployee_CustomEntity.DepartmentName = reader.GetString(FLD_DEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_BLOODGROUPNAME)) { resourceEmployee_CustomEntity.BloodGroupName = String.Empty; } else { resourceEmployee_CustomEntity.BloodGroupName = reader.GetString(FLD_BLOODGROUPNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEEJOBTYPENAME)) { resourceEmployee_CustomEntity.EmployeeJobTypeName = String.Empty; } else { resourceEmployee_CustomEntity.EmployeeJobTypeName = reader.GetString(FLD_EMPLOYEEJOBTYPENAME); }

            return resourceEmployee_CustomEntity;
        }
    }
}
