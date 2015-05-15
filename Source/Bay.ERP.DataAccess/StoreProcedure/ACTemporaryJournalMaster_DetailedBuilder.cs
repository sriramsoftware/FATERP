// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Feb-2013, 01:42:07




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACTemporaryJournalMaster_DetailedBuilder : IEntityBuilder<ACTemporaryJournalMaster_DetailedEntity>
    {
        IList<ACTemporaryJournalMaster_DetailedEntity> IEntityBuilder<ACTemporaryJournalMaster_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACTemporaryJournalMaster_DetailedEntity> ACTemporaryJournalMaster_DetailedEntityList = new List<ACTemporaryJournalMaster_DetailedEntity>();

            while (reader.Read())
            {
                ACTemporaryJournalMaster_DetailedEntityList.Add(((IEntityBuilder<ACTemporaryJournalMaster_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACTemporaryJournalMaster_DetailedEntityList.Count > 0) ? ACTemporaryJournalMaster_DetailedEntityList : null;
        }

        ACTemporaryJournalMaster_DetailedEntity IEntityBuilder<ACTemporaryJournalMaster_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TEMPORARYJOURNALMASTERID = 0;
            const Int32 FLD_REMARKS = 1;
            const Int32 FLD_CREATEDATE = 2;
            const Int32 FLD_TEMPORYJOURNALAPPROVALSTATUSID = 3;
            const Int32 FLD_TEMPORARYJOURNALAPPROVALSTATUSNAME = 4;
            const Int32 FLD_ROWNUMBER = 5;

            ACTemporaryJournalMaster_DetailedEntity aCTemporaryJournalMaster_DetailedEntity = new ACTemporaryJournalMaster_DetailedEntity();

            aCTemporaryJournalMaster_DetailedEntity.TemporaryJournalMasterID = reader.GetInt64(FLD_TEMPORARYJOURNALMASTERID);
            aCTemporaryJournalMaster_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS);
            aCTemporaryJournalMaster_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            aCTemporaryJournalMaster_DetailedEntity.TemporyJournalApprovalStatusID = reader.GetInt64(FLD_TEMPORYJOURNALAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_TEMPORARYJOURNALAPPROVALSTATUSNAME)) { aCTemporaryJournalMaster_DetailedEntity.TemporaryJournalApprovalStatusName = String.Empty; } else { aCTemporaryJournalMaster_DetailedEntity.TemporaryJournalApprovalStatusName = reader.GetString(FLD_TEMPORARYJOURNALAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCTemporaryJournalMaster_DetailedEntity.RowNumber = null; } else { aCTemporaryJournalMaster_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCTemporaryJournalMaster_DetailedEntity;
        }
    }
}
