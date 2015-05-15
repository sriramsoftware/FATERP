// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jan-2013, 03:06:02




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVStoreIssueNoteItemMapBuilder : IEntityBuilder<INVStoreIssueNoteItemMapEntity>
    {
        IList<INVStoreIssueNoteItemMapEntity> IEntityBuilder<INVStoreIssueNoteItemMapEntity>.BuildEntities(IDataReader reader)
        {
            List<INVStoreIssueNoteItemMapEntity> INVStoreIssueNoteItemMapEntityList = new List<INVStoreIssueNoteItemMapEntity>();

            while (reader.Read())
            {
                INVStoreIssueNoteItemMapEntityList.Add(((IEntityBuilder<INVStoreIssueNoteItemMapEntity>)this).BuildEntity(reader));
            }

            return (INVStoreIssueNoteItemMapEntityList.Count > 0) ? INVStoreIssueNoteItemMapEntityList : null;
        }

        INVStoreIssueNoteItemMapEntity IEntityBuilder<INVStoreIssueNoteItemMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_STOREISSUENOTEITEMMAPID = 0;
            const Int32 FLD_STOREISSUENOTEID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_FOLIONO = 3;
            const Int32 FLD_REQUESTQTY = 4;
            const Int32 FLD_BATCHNO = 5;
            const Int32 FLD_ISSUEQTY = 6;
            const Int32 FLD_ISSUEDFROMSTOREID = 7;
            const Int32 FLD_ISSUEDFROMSTOREUNITID = 8;
            const Int32 FLD_RECEIVEDDATE = 9;
            const Int32 FLD_RECEIVEDBYEMPLOYEEID = 10;
            const Int32 FLD_RETURNQTY = 11;
            const Int32 FLD_RETURNDATE = 12;
            const Int32 FLD_RETURNTOSTOREID = 13;
            const Int32 FLD_RETURNTOSTOREUNITID = 14;
            const Int32 FLD_RETURNEDBYEMPLOYEEID = 15;
            const Int32 FLD_ACTUALUSE = 16;
            const Int32 FLD_AMOUNT = 17;
            const Int32 FLD_PURPOSEOFWORKS = 18;

            INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity = new INVStoreIssueNoteItemMapEntity();

            iNVStoreIssueNoteItemMapEntity.StoreIssueNoteItemMapID = reader.GetInt64(FLD_STOREISSUENOTEITEMMAPID);
            iNVStoreIssueNoteItemMapEntity.StoreIssueNoteID = reader.GetInt64(FLD_STOREISSUENOTEID);
            iNVStoreIssueNoteItemMapEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            if (reader.IsDBNull(FLD_FOLIONO)) { iNVStoreIssueNoteItemMapEntity.FolioNo = String.Empty; } else { iNVStoreIssueNoteItemMapEntity.FolioNo = reader.GetString(FLD_FOLIONO); }
            iNVStoreIssueNoteItemMapEntity.RequestQty = reader.GetDecimal(FLD_REQUESTQTY);
            if (reader.IsDBNull(FLD_BATCHNO)) { iNVStoreIssueNoteItemMapEntity.BatchNo = String.Empty; } else { iNVStoreIssueNoteItemMapEntity.BatchNo = reader.GetString(FLD_BATCHNO); }
            if (reader.IsDBNull(FLD_ISSUEQTY)) { iNVStoreIssueNoteItemMapEntity.IssueQty = null; } else { iNVStoreIssueNoteItemMapEntity.IssueQty = reader.GetDecimal(FLD_ISSUEQTY); }
            if (reader.IsDBNull(FLD_ISSUEDFROMSTOREID)) { iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID = null; } else { iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID = reader.GetInt64(FLD_ISSUEDFROMSTOREID); }
            iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID = reader.GetInt64(FLD_ISSUEDFROMSTOREUNITID);
            if (reader.IsDBNull(FLD_RECEIVEDDATE)) { iNVStoreIssueNoteItemMapEntity.ReceivedDate = null; } else { iNVStoreIssueNoteItemMapEntity.ReceivedDate = reader.GetDateTime(FLD_RECEIVEDDATE); }
            if (reader.IsDBNull(FLD_RECEIVEDBYEMPLOYEEID)) { iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID = null; } else { iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID = reader.GetInt64(FLD_RECEIVEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_RETURNQTY)) { iNVStoreIssueNoteItemMapEntity.ReturnQty = null; } else { iNVStoreIssueNoteItemMapEntity.ReturnQty = reader.GetDecimal(FLD_RETURNQTY); }
            if (reader.IsDBNull(FLD_RETURNDATE)) { iNVStoreIssueNoteItemMapEntity.ReturnDate = null; } else { iNVStoreIssueNoteItemMapEntity.ReturnDate = reader.GetDateTime(FLD_RETURNDATE); }
            if (reader.IsDBNull(FLD_RETURNTOSTOREID)) { iNVStoreIssueNoteItemMapEntity.ReturnToStoreID = null; } else { iNVStoreIssueNoteItemMapEntity.ReturnToStoreID = reader.GetInt64(FLD_RETURNTOSTOREID); }
            if (reader.IsDBNull(FLD_RETURNTOSTOREUNITID)) { iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID = null; } else { iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID = reader.GetInt64(FLD_RETURNTOSTOREUNITID); }
            if (reader.IsDBNull(FLD_RETURNEDBYEMPLOYEEID)) { iNVStoreIssueNoteItemMapEntity.ReturnedByEmployeeID = null; } else { iNVStoreIssueNoteItemMapEntity.ReturnedByEmployeeID = reader.GetInt64(FLD_RETURNEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_ACTUALUSE)) { iNVStoreIssueNoteItemMapEntity.ActualUse = null; } else { iNVStoreIssueNoteItemMapEntity.ActualUse = reader.GetDecimal(FLD_ACTUALUSE); }
            if (reader.IsDBNull(FLD_AMOUNT)) { iNVStoreIssueNoteItemMapEntity.Amount = null; } else { iNVStoreIssueNoteItemMapEntity.Amount = reader.GetDecimal(FLD_AMOUNT); }
            if (reader.IsDBNull(FLD_PURPOSEOFWORKS)) { iNVStoreIssueNoteItemMapEntity.PurposeOfWorks = String.Empty; } else { iNVStoreIssueNoteItemMapEntity.PurposeOfWorks = reader.GetString(FLD_PURPOSEOFWORKS); }

            return iNVStoreIssueNoteItemMapEntity;
        }
    }
}
