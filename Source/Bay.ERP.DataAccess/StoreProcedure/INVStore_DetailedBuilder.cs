// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 10:49:09




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVStore_DetailedBuilder : IEntityBuilder<INVStore_DetailedEntity>
    {
        IList<INVStore_DetailedEntity> IEntityBuilder<INVStore_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<INVStore_DetailedEntity> INVStore_DetailedEntityList = new List<INVStore_DetailedEntity>();

            while (reader.Read())
            {
                INVStore_DetailedEntityList.Add(((IEntityBuilder<INVStore_DetailedEntity>)this).BuildEntity(reader));
            }

            return (INVStore_DetailedEntityList.Count > 0) ? INVStore_DetailedEntityList : null;
        }

        INVStore_DetailedEntity IEntityBuilder<INVStore_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_STOREID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_DEPARTMENTID = 2;
            const Int32 FLD_STOREINCHARGEEMPLOYEEID = 3;
            const Int32 FLD_NAME = 4;
            const Int32 FLD_STORETRACKNUMBER = 5;
            const Int32 FLD_LOCATION = 6;
            const Int32 FLD_DESCRIPTION = 7;
            const Int32 FLD_CREATEDATE = 8;
            const Int32 FLD_ISREMOVED = 9;
            const Int32 FLD_ISDEFAULT = 10;
            const Int32 FLD_PROJECTNAME = 11;
            const Int32 FLD_DEPARTMENTNAME = 12;
            const Int32 FLD_MEMBERFULLNAME = 13;
            const Int32 FLD_ROWNUMBER = 14;

            INVStore_DetailedEntity iNVStore_DetailedEntity = new INVStore_DetailedEntity();

            iNVStore_DetailedEntity.StoreID = reader.GetInt64(FLD_STOREID);
            iNVStore_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            iNVStore_DetailedEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            iNVStore_DetailedEntity.StoreInChargeEmployeeID = reader.GetInt64(FLD_STOREINCHARGEEMPLOYEEID);
            iNVStore_DetailedEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_STORETRACKNUMBER)) { iNVStore_DetailedEntity.StoreTrackNumber = String.Empty; } else { iNVStore_DetailedEntity.StoreTrackNumber = reader.GetString(FLD_STORETRACKNUMBER); }
            if (reader.IsDBNull(FLD_LOCATION)) { iNVStore_DetailedEntity.Location = String.Empty; } else { iNVStore_DetailedEntity.Location = reader.GetString(FLD_LOCATION); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { iNVStore_DetailedEntity.Description = String.Empty; } else { iNVStore_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            iNVStore_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            iNVStore_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            iNVStore_DetailedEntity.IsDefault = reader.GetBoolean(FLD_ISDEFAULT);
            if (reader.IsDBNull(FLD_PROJECTNAME)) { iNVStore_DetailedEntity.ProjectName = String.Empty; } else { iNVStore_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTNAME)) { iNVStore_DetailedEntity.DepartmentName = String.Empty; } else { iNVStore_DetailedEntity.DepartmentName = reader.GetString(FLD_DEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { iNVStore_DetailedEntity.MemberFullName = String.Empty; } else { iNVStore_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { iNVStore_DetailedEntity.RowNumber = null; } else { iNVStore_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return iNVStore_DetailedEntity;
        }
    }
}
