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
    internal sealed class MDDocumentStorageTypeBuilder : IEntityBuilder<MDDocumentStorageTypeEntity>
    {
        IList<MDDocumentStorageTypeEntity> IEntityBuilder<MDDocumentStorageTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDDocumentStorageTypeEntity> MDDocumentStorageTypeEntityList = new List<MDDocumentStorageTypeEntity>();

            while (reader.Read())
            {
                MDDocumentStorageTypeEntityList.Add(((IEntityBuilder<MDDocumentStorageTypeEntity>)this).BuildEntity(reader));
            }

            return (MDDocumentStorageTypeEntityList.Count > 0) ? MDDocumentStorageTypeEntityList : null;
        }

        MDDocumentStorageTypeEntity IEntityBuilder<MDDocumentStorageTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DOCUMENTSTORAGETYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDDocumentStorageTypeEntity mDDocumentStorageTypeEntity = new MDDocumentStorageTypeEntity();

            mDDocumentStorageTypeEntity.DocumentStorageTypeID = reader.GetInt64(FLD_DOCUMENTSTORAGETYPEID);
            mDDocumentStorageTypeEntity.Name = reader.GetString(FLD_NAME);
            mDDocumentStorageTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDDocumentStorageTypeEntity;
        }
    }
}
