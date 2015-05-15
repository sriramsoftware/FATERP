// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDSupplierStatusBuilder : IEntityBuilder<MDSupplierStatusEntity>
    {
        IList<MDSupplierStatusEntity> IEntityBuilder<MDSupplierStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSupplierStatusEntity> MDSupplierStatusEntityList = new List<MDSupplierStatusEntity>();

            while (reader.Read())
            {
                MDSupplierStatusEntityList.Add(((IEntityBuilder<MDSupplierStatusEntity>)this).BuildEntity(reader));
            }

            return (MDSupplierStatusEntityList.Count > 0) ? MDSupplierStatusEntityList : null;
        }

        MDSupplierStatusEntity IEntityBuilder<MDSupplierStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDSupplierStatusEntity mDSupplierStatusEntity = new MDSupplierStatusEntity();

            mDSupplierStatusEntity.SupplierStatusID = reader.GetInt64(FLD_SUPPLIERSTATUSID);
            mDSupplierStatusEntity.Name = reader.GetString(FLD_NAME);
            mDSupplierStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSupplierStatusEntity;
        }
    }
}
