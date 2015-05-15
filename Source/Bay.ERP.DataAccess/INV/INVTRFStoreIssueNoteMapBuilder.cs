// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Jan-2013, 04:16:20




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVTRFStoreIssueNoteMapBuilder : IEntityBuilder<INVTRFStoreIssueNoteMapEntity>
    {
        IList<INVTRFStoreIssueNoteMapEntity> IEntityBuilder<INVTRFStoreIssueNoteMapEntity>.BuildEntities(IDataReader reader)
        {
            List<INVTRFStoreIssueNoteMapEntity> INVTRFStoreIssueNoteMapEntityList = new List<INVTRFStoreIssueNoteMapEntity>();

            while (reader.Read())
            {
                INVTRFStoreIssueNoteMapEntityList.Add(((IEntityBuilder<INVTRFStoreIssueNoteMapEntity>)this).BuildEntity(reader));
            }

            return (INVTRFStoreIssueNoteMapEntityList.Count > 0) ? INVTRFStoreIssueNoteMapEntityList : null;
        }

        INVTRFStoreIssueNoteMapEntity IEntityBuilder<INVTRFStoreIssueNoteMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TRFSTOREISSUENOTEMAPID = 0;
            const Int32 FLD_STOREISSUENOTEID = 1;
            const Int32 FLD_TRANSFERID = 2;
            const Int32 FLD_REMARKS = 3;
            const Int32 FLD_ISREMOVED = 4;

            INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity = new INVTRFStoreIssueNoteMapEntity();

            iNVTRFStoreIssueNoteMapEntity.TRFStoreIssueNoteMapID = reader.GetInt64(FLD_TRFSTOREISSUENOTEMAPID);
            iNVTRFStoreIssueNoteMapEntity.StoreIssueNoteID = reader.GetInt64(FLD_STOREISSUENOTEID);
            iNVTRFStoreIssueNoteMapEntity.TransferID = reader.GetInt64(FLD_TRANSFERID);
            if (reader.IsDBNull(FLD_REMARKS)) { iNVTRFStoreIssueNoteMapEntity.Remarks = String.Empty; } else { iNVTRFStoreIssueNoteMapEntity.Remarks = reader.GetString(FLD_REMARKS); }
            iNVTRFStoreIssueNoteMapEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return iNVTRFStoreIssueNoteMapEntity;
        }
    }
}
