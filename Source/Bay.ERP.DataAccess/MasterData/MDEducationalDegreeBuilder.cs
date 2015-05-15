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
    internal sealed class MDEducationalDegreeBuilder : IEntityBuilder<MDEducationalDegreeEntity>
    {
        IList<MDEducationalDegreeEntity> IEntityBuilder<MDEducationalDegreeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEducationalDegreeEntity> MDEducationalDegreeEntityList = new List<MDEducationalDegreeEntity>();

            while (reader.Read())
            {
                MDEducationalDegreeEntityList.Add(((IEntityBuilder<MDEducationalDegreeEntity>)this).BuildEntity(reader));
            }

            return (MDEducationalDegreeEntityList.Count > 0) ? MDEducationalDegreeEntityList : null;
        }

        MDEducationalDegreeEntity IEntityBuilder<MDEducationalDegreeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EDUCATIONALDEGREEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDEducationalDegreeEntity mDEducationalDegreeEntity = new MDEducationalDegreeEntity();

            mDEducationalDegreeEntity.EducationalDegreeID = reader.GetInt64(FLD_EDUCATIONALDEGREEID);
            mDEducationalDegreeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEducationalDegreeEntity.Description = String.Empty; } else { mDEducationalDegreeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDEducationalDegreeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEducationalDegreeEntity;
        }
    }
}
