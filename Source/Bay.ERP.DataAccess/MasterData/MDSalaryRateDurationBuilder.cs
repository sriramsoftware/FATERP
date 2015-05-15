// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDSalaryRateDurationBuilder : IEntityBuilder<MDSalaryRateDurationEntity>
    {
        IList<MDSalaryRateDurationEntity> IEntityBuilder<MDSalaryRateDurationEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSalaryRateDurationEntity> MDSalaryRateDurationEntityList = new List<MDSalaryRateDurationEntity>();

            while (reader.Read())
            {
                MDSalaryRateDurationEntityList.Add(((IEntityBuilder<MDSalaryRateDurationEntity>)this).BuildEntity(reader));
            }

            return (MDSalaryRateDurationEntityList.Count > 0) ? MDSalaryRateDurationEntityList : null;
        }

        MDSalaryRateDurationEntity IEntityBuilder<MDSalaryRateDurationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SALARYRATEDURATIONID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDSalaryRateDurationEntity mDSalaryRateDurationEntity = new MDSalaryRateDurationEntity();

            mDSalaryRateDurationEntity.SalaryRateDurationID = reader.GetInt64(FLD_SALARYRATEDURATIONID);
            mDSalaryRateDurationEntity.Name = reader.GetString(FLD_NAME);
            mDSalaryRateDurationEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSalaryRateDurationEntity;
        }
    }
}
