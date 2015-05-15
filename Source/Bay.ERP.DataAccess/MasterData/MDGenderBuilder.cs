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
    internal sealed class MDGenderBuilder : IEntityBuilder<MDGenderEntity>
    {
        IList<MDGenderEntity> IEntityBuilder<MDGenderEntity>.BuildEntities(IDataReader reader)
        {
            List<MDGenderEntity> MDGenderEntityList = new List<MDGenderEntity>();

            while (reader.Read())
            {
                MDGenderEntityList.Add(((IEntityBuilder<MDGenderEntity>)this).BuildEntity(reader));
            }

            return (MDGenderEntityList.Count > 0) ? MDGenderEntityList : null;
        }

        MDGenderEntity IEntityBuilder<MDGenderEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_GENDERID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDGenderEntity mDGenderEntity = new MDGenderEntity();

            mDGenderEntity.GenderID = reader.GetInt64(FLD_GENDERID);
            mDGenderEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REMARKS)) { mDGenderEntity.Remarks = String.Empty; } else { mDGenderEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDGenderEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDGenderEntity;
        }
    }
}
