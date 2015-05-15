// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDPreBOQStatusBuilder : IEntityBuilder<MDPreBOQStatusEntity>
    {
        IList<MDPreBOQStatusEntity> IEntityBuilder<MDPreBOQStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDPreBOQStatusEntity> MDPreBOQStatusEntityList = new List<MDPreBOQStatusEntity>();

            while (reader.Read())
            {
                MDPreBOQStatusEntityList.Add(((IEntityBuilder<MDPreBOQStatusEntity>)this).BuildEntity(reader));
            }

            return (MDPreBOQStatusEntityList.Count > 0) ? MDPreBOQStatusEntityList : null;
        }

        MDPreBOQStatusEntity IEntityBuilder<MDPreBOQStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREBOQSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDPreBOQStatusEntity mDPreBOQStatusEntity = new MDPreBOQStatusEntity();

            mDPreBOQStatusEntity.PreBOQStatusID = reader.GetInt64(FLD_PREBOQSTATUSID);
            mDPreBOQStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDPreBOQStatusEntity.Description = String.Empty; } else { mDPreBOQStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDPreBOQStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDPreBOQStatusEntity;
        }
    }
}
