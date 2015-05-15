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
    internal sealed class MDMaritalStatusBuilder : IEntityBuilder<MDMaritalStatusEntity>
    {
        IList<MDMaritalStatusEntity> IEntityBuilder<MDMaritalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDMaritalStatusEntity> MDMaritalStatusEntityList = new List<MDMaritalStatusEntity>();

            while (reader.Read())
            {
                MDMaritalStatusEntityList.Add(((IEntityBuilder<MDMaritalStatusEntity>)this).BuildEntity(reader));
            }

            return (MDMaritalStatusEntityList.Count > 0) ? MDMaritalStatusEntityList : null;
        }

        MDMaritalStatusEntity IEntityBuilder<MDMaritalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MARITALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDMaritalStatusEntity mDMaritalStatusEntity = new MDMaritalStatusEntity();

            mDMaritalStatusEntity.MaritalStatusID = reader.GetInt64(FLD_MARITALSTATUSID);
            mDMaritalStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REMARKS)) { mDMaritalStatusEntity.Remarks = String.Empty; } else { mDMaritalStatusEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDMaritalStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDMaritalStatusEntity;
        }
    }
}
