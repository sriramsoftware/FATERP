// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 05:27:25




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNMDEventStatusBuilder : IEntityBuilder<CMNMDEventStatusEntity>
    {
        IList<CMNMDEventStatusEntity> IEntityBuilder<CMNMDEventStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNMDEventStatusEntity> CMNMDEventStatusEntityList = new List<CMNMDEventStatusEntity>();

            while (reader.Read())
            {
                CMNMDEventStatusEntityList.Add(((IEntityBuilder<CMNMDEventStatusEntity>)this).BuildEntity(reader));
            }

            return (CMNMDEventStatusEntityList.Count > 0) ? CMNMDEventStatusEntityList : null;
        }

        CMNMDEventStatusEntity IEntityBuilder<CMNMDEventStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EVENTSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CMNMDEventStatusEntity cMNMDEventStatusEntity = new CMNMDEventStatusEntity();

            cMNMDEventStatusEntity.EventStatusID = reader.GetInt64(FLD_EVENTSTATUSID);
            cMNMDEventStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cMNMDEventStatusEntity.Description = String.Empty; } else { cMNMDEventStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cMNMDEventStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMNMDEventStatusEntity;
        }
    }
}
