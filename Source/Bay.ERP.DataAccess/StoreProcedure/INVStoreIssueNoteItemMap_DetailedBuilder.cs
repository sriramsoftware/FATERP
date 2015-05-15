// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 11:36:43




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVStoreIssueNoteItemMap_DetailedBuilder : IEntityBuilder<INVStoreIssueNoteItemMap_DetailedEntity>
    {
        IList<INVStoreIssueNoteItemMap_DetailedEntity> IEntityBuilder<INVStoreIssueNoteItemMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<INVStoreIssueNoteItemMap_DetailedEntity> INVStoreIssueNoteItemMap_DetailedEntityList = new List<INVStoreIssueNoteItemMap_DetailedEntity>();

            while (reader.Read())
            {
                INVStoreIssueNoteItemMap_DetailedEntityList.Add(((IEntityBuilder<INVStoreIssueNoteItemMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (INVStoreIssueNoteItemMap_DetailedEntityList.Count > 0) ? INVStoreIssueNoteItemMap_DetailedEntityList : null;
        }

        INVStoreIssueNoteItemMap_DetailedEntity IEntityBuilder<INVStoreIssueNoteItemMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_STOREISSUENOTEITEMMAPID = 0;
            const Int32 FLD_STOREISSUENOTEID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_FOLIONO = 3;
            const Int32 FLD_REQUESTQTY = 4;
            const Int32 FLD_ISSUEQTY = 5;
            const Int32 FLD_ISSUEDFROMSTOREID = 6;
            const Int32 FLD_ISSUEDFROMSTOREUNITID = 7;
            const Int32 FLD_RECEIVEDDATE = 8;
            const Int32 FLD_RECEIVEDBYEMPLOYEEID = 9;
            const Int32 FLD_RETURNQTY = 10;
            const Int32 FLD_RETURNDATE = 11;
            const Int32 FLD_RETURNTOSTOREID = 12;
            const Int32 FLD_RETURNTOSTOREUNITID = 13;
            const Int32 FLD_RETURNEDBYEMPLOYEEID = 14;
            const Int32 FLD_ACTUALUSE = 15;
            const Int32 FLD_AMOUNT = 16;
            const Int32 FLD_PURPOSEOFWORKS = 17;
            const Int32 FLD_INVSTOREISSUENOTEPROJECTID = 18;
            const Int32 FLD_MDITEMITEMNAME = 19;
            const Int32 FLD_INVSTORENAME = 20;
            const Int32 FLD_INVSTOREUNITSTOREID = 21;
            const Int32 FLD_RECEIVEDBYMEMBERFULLNAME = 22;
            const Int32 FLD_RETURNEDBYMEMBERFULLNAME = 23;
            const Int32 FLD_ROWNUMBER = 24;

            INVStoreIssueNoteItemMap_DetailedEntity iNVStoreIssueNoteItemMap_DetailedEntity = new INVStoreIssueNoteItemMap_DetailedEntity();

            iNVStoreIssueNoteItemMap_DetailedEntity.StoreIssueNoteItemMapID = reader.GetInt64(FLD_STOREISSUENOTEITEMMAPID);
            iNVStoreIssueNoteItemMap_DetailedEntity.StoreIssueNoteID = reader.GetInt64(FLD_STOREISSUENOTEID);
            iNVStoreIssueNoteItemMap_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            if (reader.IsDBNull(FLD_FOLIONO)) { iNVStoreIssueNoteItemMap_DetailedEntity.FolioNo = String.Empty; } else { iNVStoreIssueNoteItemMap_DetailedEntity.FolioNo = reader.GetString(FLD_FOLIONO); }
            iNVStoreIssueNoteItemMap_DetailedEntity.RequestQty = reader.GetDecimal(FLD_REQUESTQTY);
            if (reader.IsDBNull(FLD_ISSUEQTY)) { iNVStoreIssueNoteItemMap_DetailedEntity.IssueQty = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.IssueQty = reader.GetDecimal(FLD_ISSUEQTY); }
            if (reader.IsDBNull(FLD_ISSUEDFROMSTOREID)) { iNVStoreIssueNoteItemMap_DetailedEntity.IssuedFromStoreID = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.IssuedFromStoreID = reader.GetInt64(FLD_ISSUEDFROMSTOREID); }
            iNVStoreIssueNoteItemMap_DetailedEntity.IssuedFromStoreUnitID = reader.GetInt64(FLD_ISSUEDFROMSTOREUNITID);
            if (reader.IsDBNull(FLD_RECEIVEDDATE)) { iNVStoreIssueNoteItemMap_DetailedEntity.ReceivedDate = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.ReceivedDate = reader.GetDateTime(FLD_RECEIVEDDATE); }
            if (reader.IsDBNull(FLD_RECEIVEDBYEMPLOYEEID)) { iNVStoreIssueNoteItemMap_DetailedEntity.ReceivedByEmployeeID = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.ReceivedByEmployeeID = reader.GetInt64(FLD_RECEIVEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_RETURNQTY)) { iNVStoreIssueNoteItemMap_DetailedEntity.ReturnQty = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.ReturnQty = reader.GetDecimal(FLD_RETURNQTY); }
            if (reader.IsDBNull(FLD_RETURNDATE)) { iNVStoreIssueNoteItemMap_DetailedEntity.ReturnDate = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.ReturnDate = reader.GetDateTime(FLD_RETURNDATE); }
            if (reader.IsDBNull(FLD_RETURNTOSTOREID)) { iNVStoreIssueNoteItemMap_DetailedEntity.ReturnToStoreID = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.ReturnToStoreID = reader.GetInt64(FLD_RETURNTOSTOREID); }
            if (reader.IsDBNull(FLD_RETURNTOSTOREUNITID)) { iNVStoreIssueNoteItemMap_DetailedEntity.ReturnToStoreUnitID = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.ReturnToStoreUnitID = reader.GetInt64(FLD_RETURNTOSTOREUNITID); }
            if (reader.IsDBNull(FLD_RETURNEDBYEMPLOYEEID)) { iNVStoreIssueNoteItemMap_DetailedEntity.ReturnedByEmployeeID = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.ReturnedByEmployeeID = reader.GetInt64(FLD_RETURNEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_ACTUALUSE)) { iNVStoreIssueNoteItemMap_DetailedEntity.ActualUse = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.ActualUse = reader.GetDecimal(FLD_ACTUALUSE); }
            if (reader.IsDBNull(FLD_AMOUNT)) { iNVStoreIssueNoteItemMap_DetailedEntity.Amount = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.Amount = reader.GetDecimal(FLD_AMOUNT); }
            if (reader.IsDBNull(FLD_PURPOSEOFWORKS)) { iNVStoreIssueNoteItemMap_DetailedEntity.PurposeOfWorks = String.Empty; } else { iNVStoreIssueNoteItemMap_DetailedEntity.PurposeOfWorks = reader.GetString(FLD_PURPOSEOFWORKS); }
            if (reader.IsDBNull(FLD_INVSTOREISSUENOTEPROJECTID)) { iNVStoreIssueNoteItemMap_DetailedEntity.INVStoreIssueNoteProjectID = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.INVStoreIssueNoteProjectID = reader.GetInt64(FLD_INVSTOREISSUENOTEPROJECTID); }
            if (reader.IsDBNull(FLD_MDITEMITEMNAME)) { iNVStoreIssueNoteItemMap_DetailedEntity.MDItemItemName = String.Empty; } else { iNVStoreIssueNoteItemMap_DetailedEntity.MDItemItemName = reader.GetString(FLD_MDITEMITEMNAME); }
            if (reader.IsDBNull(FLD_INVSTORENAME)) { iNVStoreIssueNoteItemMap_DetailedEntity.INVStoreName = String.Empty; } else { iNVStoreIssueNoteItemMap_DetailedEntity.INVStoreName = reader.GetString(FLD_INVSTORENAME); }
            if (reader.IsDBNull(FLD_INVSTOREUNITSTOREID)) { iNVStoreIssueNoteItemMap_DetailedEntity.INVStoreUnitStoreID = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.INVStoreUnitStoreID = reader.GetInt64(FLD_INVSTOREUNITSTOREID); }
            if (reader.IsDBNull(FLD_RECEIVEDBYMEMBERFULLNAME)) { iNVStoreIssueNoteItemMap_DetailedEntity.ReceivedByMemberFullName = String.Empty; } else { iNVStoreIssueNoteItemMap_DetailedEntity.ReceivedByMemberFullName = reader.GetString(FLD_RECEIVEDBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_RETURNEDBYMEMBERFULLNAME)) { iNVStoreIssueNoteItemMap_DetailedEntity.ReturnedByMemberFullName = String.Empty; } else { iNVStoreIssueNoteItemMap_DetailedEntity.ReturnedByMemberFullName = reader.GetString(FLD_RETURNEDBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { iNVStoreIssueNoteItemMap_DetailedEntity.RowNumber = null; } else { iNVStoreIssueNoteItemMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return iNVStoreIssueNoteItemMap_DetailedEntity;
        }
    }
}
