// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 02:08:21




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACTemporaryJournalMasterBuilder : IEntityBuilder<ACTemporaryJournalMasterEntity>
    {
        IList<ACTemporaryJournalMasterEntity> IEntityBuilder<ACTemporaryJournalMasterEntity>.BuildEntities(IDataReader reader)
        {
            List<ACTemporaryJournalMasterEntity> ACTemporaryJournalMasterEntityList = new List<ACTemporaryJournalMasterEntity>();

            while (reader.Read())
            {
                ACTemporaryJournalMasterEntityList.Add(((IEntityBuilder<ACTemporaryJournalMasterEntity>)this).BuildEntity(reader));
            }

            return (ACTemporaryJournalMasterEntityList.Count > 0) ? ACTemporaryJournalMasterEntityList : null;
        }

        ACTemporaryJournalMasterEntity IEntityBuilder<ACTemporaryJournalMasterEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TEMPORARYJOURNALMASTERID = 0;
            const Int32 FLD_REMARKS = 1;
            const Int32 FLD_CREATEDATE = 2;
            const Int32 FLD_TEMPORYJOURNALAPPROVALSTATUSID = 3;

            ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity = new ACTemporaryJournalMasterEntity();

            aCTemporaryJournalMasterEntity.TemporaryJournalMasterID = reader.GetInt64(FLD_TEMPORARYJOURNALMASTERID);
            aCTemporaryJournalMasterEntity.Remarks = reader.GetString(FLD_REMARKS);
            aCTemporaryJournalMasterEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            aCTemporaryJournalMasterEntity.TemporyJournalApprovalStatusID = reader.GetInt64(FLD_TEMPORYJOURNALAPPROVALSTATUSID);

            return aCTemporaryJournalMasterEntity;
        }
    }
}
