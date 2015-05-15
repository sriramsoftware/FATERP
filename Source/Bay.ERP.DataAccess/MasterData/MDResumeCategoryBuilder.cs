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
    internal sealed class MDResumeCategoryBuilder : IEntityBuilder<MDResumeCategoryEntity>
    {
        IList<MDResumeCategoryEntity> IEntityBuilder<MDResumeCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDResumeCategoryEntity> MDResumeCategoryEntityList = new List<MDResumeCategoryEntity>();

            while (reader.Read())
            {
                MDResumeCategoryEntityList.Add(((IEntityBuilder<MDResumeCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDResumeCategoryEntityList.Count > 0) ? MDResumeCategoryEntityList : null;
        }

        MDResumeCategoryEntity IEntityBuilder<MDResumeCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESUMECATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDResumeCategoryEntity mDResumeCategoryEntity = new MDResumeCategoryEntity();

            mDResumeCategoryEntity.ResumeCategoryID = reader.GetInt64(FLD_RESUMECATEGORYID);
            mDResumeCategoryEntity.Name = reader.GetString(FLD_NAME);
            mDResumeCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDResumeCategoryEntity;
        }
    }
}
