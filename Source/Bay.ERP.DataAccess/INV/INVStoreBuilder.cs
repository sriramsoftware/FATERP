// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVStoreBuilder : IEntityBuilder<INVStoreEntity>
    {
        IList<INVStoreEntity> IEntityBuilder<INVStoreEntity>.BuildEntities(IDataReader reader)
        {
            List<INVStoreEntity> INVStoreEntityList = new List<INVStoreEntity>();

            while (reader.Read())
            {
                INVStoreEntityList.Add(((IEntityBuilder<INVStoreEntity>)this).BuildEntity(reader));
            }

            return (INVStoreEntityList.Count > 0) ? INVStoreEntityList : null;
        }

        INVStoreEntity IEntityBuilder<INVStoreEntity>.BuildEntity(IDataReader reader)
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

            INVStoreEntity iNVStoreEntity = new INVStoreEntity();

            iNVStoreEntity.StoreID = reader.GetInt64(FLD_STOREID);
            iNVStoreEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            iNVStoreEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            iNVStoreEntity.StoreInChargeEmployeeID = reader.GetInt64(FLD_STOREINCHARGEEMPLOYEEID);
            iNVStoreEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_STORETRACKNUMBER)) { iNVStoreEntity.StoreTrackNumber = String.Empty; } else { iNVStoreEntity.StoreTrackNumber = reader.GetString(FLD_STORETRACKNUMBER); }
            if (reader.IsDBNull(FLD_LOCATION)) { iNVStoreEntity.Location = String.Empty; } else { iNVStoreEntity.Location = reader.GetString(FLD_LOCATION); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { iNVStoreEntity.Description = String.Empty; } else { iNVStoreEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            iNVStoreEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            iNVStoreEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            iNVStoreEntity.IsDefault = reader.GetBoolean(FLD_ISDEFAULT);

            return iNVStoreEntity;
        }
    }
}
