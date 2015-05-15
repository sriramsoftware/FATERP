// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMMDCommunicationStatusBuilder : IEntityBuilder<CRMMDCommunicationStatusEntity>
    {
        IList<CRMMDCommunicationStatusEntity> IEntityBuilder<CRMMDCommunicationStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDCommunicationStatusEntity> CRMMDCommunicationStatusEntityList = new List<CRMMDCommunicationStatusEntity>();

            while (reader.Read())
            {
                CRMMDCommunicationStatusEntityList.Add(((IEntityBuilder<CRMMDCommunicationStatusEntity>)this).BuildEntity(reader));
            }

            return (CRMMDCommunicationStatusEntityList.Count > 0) ? CRMMDCommunicationStatusEntityList : null;
        }

        CRMMDCommunicationStatusEntity IEntityBuilder<CRMMDCommunicationStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_COMMUNICATIONSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDCommunicationStatusEntity cRMMDCommunicationStatusEntity = new CRMMDCommunicationStatusEntity();

            cRMMDCommunicationStatusEntity.CommunicationStatusID = reader.GetInt64(FLD_COMMUNICATIONSTATUSID);
            cRMMDCommunicationStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDCommunicationStatusEntity.Description = String.Empty; } else { cRMMDCommunicationStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDCommunicationStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDCommunicationStatusEntity;
        }
    }
}
