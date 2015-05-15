// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 11:02:33




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDSupplierTypeBuilder : IEntityBuilder<MDSupplierTypeEntity>
    {
        IList<MDSupplierTypeEntity> IEntityBuilder<MDSupplierTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSupplierTypeEntity> MDSupplierTypeEntityList = new List<MDSupplierTypeEntity>();

            while (reader.Read())
            {
                MDSupplierTypeEntityList.Add(((IEntityBuilder<MDSupplierTypeEntity>)this).BuildEntity(reader));
            }

            return (MDSupplierTypeEntityList.Count > 0) ? MDSupplierTypeEntityList : null;
        }

        MDSupplierTypeEntity IEntityBuilder<MDSupplierTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDSupplierTypeEntity mDSupplierTypeEntity = new MDSupplierTypeEntity();

            mDSupplierTypeEntity.SupplierTypeID = reader.GetInt64(FLD_SUPPLIERTYPEID);
            mDSupplierTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDSupplierTypeEntity.Description = String.Empty; } else { mDSupplierTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDSupplierTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSupplierTypeEntity;
        }
    }
}
