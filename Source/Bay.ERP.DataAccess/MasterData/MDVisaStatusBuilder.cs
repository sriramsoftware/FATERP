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
    internal sealed class MDVisaStatusBuilder : IEntityBuilder<MDVisaStatusEntity>
    {
        IList<MDVisaStatusEntity> IEntityBuilder<MDVisaStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDVisaStatusEntity> MDVisaStatusEntityList = new List<MDVisaStatusEntity>();

            while (reader.Read())
            {
                MDVisaStatusEntityList.Add(((IEntityBuilder<MDVisaStatusEntity>)this).BuildEntity(reader));
            }

            return (MDVisaStatusEntityList.Count > 0) ? MDVisaStatusEntityList : null;
        }

        MDVisaStatusEntity IEntityBuilder<MDVisaStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_VISASTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDVisaStatusEntity mDVisaStatusEntity = new MDVisaStatusEntity();

            mDVisaStatusEntity.VisaStatusID = reader.GetInt64(FLD_VISASTATUSID);
            mDVisaStatusEntity.Name = reader.GetString(FLD_NAME);
            mDVisaStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDVisaStatusEntity;
        }
    }
}
