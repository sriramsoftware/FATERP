// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 12:46:09




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDDMSOwnerTypeBuilder : IEntityBuilder<MDDMSOwnerTypeEntity>
    {
        IList<MDDMSOwnerTypeEntity> IEntityBuilder<MDDMSOwnerTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDDMSOwnerTypeEntity> MDDMSOwnerTypeEntityList = new List<MDDMSOwnerTypeEntity>();

            while (reader.Read())
            {
                MDDMSOwnerTypeEntityList.Add(((IEntityBuilder<MDDMSOwnerTypeEntity>)this).BuildEntity(reader));
            }

            return (MDDMSOwnerTypeEntityList.Count > 0) ? MDDMSOwnerTypeEntityList : null;
        }

        MDDMSOwnerTypeEntity IEntityBuilder<MDDMSOwnerTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_OWNERTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDDMSOwnerTypeEntity mDDMSOwnerTypeEntity = new MDDMSOwnerTypeEntity();

            mDDMSOwnerTypeEntity.OwnerTypeID = reader.GetInt64(FLD_OWNERTYPEID);
            mDDMSOwnerTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDDMSOwnerTypeEntity.Description = String.Empty; } else { mDDMSOwnerTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDDMSOwnerTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDDMSOwnerTypeEntity;
        }
    }
}
