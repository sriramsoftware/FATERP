// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Dec-2013, 10:00:46




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVStoreIssueNoteItemMap_RPTBuilder : IEntityBuilder<INVStoreIssueNoteItemMap_RPTEntity>
    {
        IList<INVStoreIssueNoteItemMap_RPTEntity> IEntityBuilder<INVStoreIssueNoteItemMap_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<INVStoreIssueNoteItemMap_RPTEntity> INVStoreIssueNoteItemMap_RPTEntityList = new List<INVStoreIssueNoteItemMap_RPTEntity>();

            while (reader.Read())
            {
                INVStoreIssueNoteItemMap_RPTEntityList.Add(((IEntityBuilder<INVStoreIssueNoteItemMap_RPTEntity>)this).BuildEntity(reader));
            }

            return (INVStoreIssueNoteItemMap_RPTEntityList.Count > 0) ? INVStoreIssueNoteItemMap_RPTEntityList : null;
        }

        INVStoreIssueNoteItemMap_RPTEntity IEntityBuilder<INVStoreIssueNoteItemMap_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMID = 0;
            const Int32 FLD_ISSUEDFROMSTOREID = 1;
            const Int32 FLD_ISSUEDFROMSTOREUNITID = 2;
            const Int32 FLD_ISSUEDQTY = 3;
            const Int32 FLD_REQUESTEDBYEMPLOYEEID = 4;
            const Int32 FLD_PROJECTID = 5;
            const Int32 FLD_REQUESTEDQTY = 6;
            const Int32 FLD_PROJECTCODE = 7;
            const Int32 FLD_PROJECTNAME = 8;
            const Int32 FLD_STORENAME = 9;
            const Int32 FLD_RETURNEDQTY = 10;
            const Int32 FLD_ACTUALISSUEDQTY = 11;
            const Int32 FLD_ITEMNAME = 12;
            const Int32 FLD_UNITNAME = 13;

            INVStoreIssueNoteItemMap_RPTEntity iNVStoreIssueNoteItemMap_RPTEntity = new INVStoreIssueNoteItemMap_RPTEntity();

            iNVStoreIssueNoteItemMap_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            if (reader.IsDBNull(FLD_ISSUEDFROMSTOREID)) { iNVStoreIssueNoteItemMap_RPTEntity.IssuedFromStoreID = null; } else { iNVStoreIssueNoteItemMap_RPTEntity.IssuedFromStoreID = reader.GetInt64(FLD_ISSUEDFROMSTOREID); }
            iNVStoreIssueNoteItemMap_RPTEntity.IssuedFromStoreUnitID = reader.GetInt64(FLD_ISSUEDFROMSTOREUNITID);
            if (reader.IsDBNull(FLD_ISSUEDQTY)) { iNVStoreIssueNoteItemMap_RPTEntity.IssuedQty = null; } else { iNVStoreIssueNoteItemMap_RPTEntity.IssuedQty = reader.GetDecimal(FLD_ISSUEDQTY); }
            iNVStoreIssueNoteItemMap_RPTEntity.RequestedByEmployeeID = reader.GetInt64(FLD_REQUESTEDBYEMPLOYEEID);
            iNVStoreIssueNoteItemMap_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_REQUESTEDQTY)) { iNVStoreIssueNoteItemMap_RPTEntity.RequestedQty = null; } else { iNVStoreIssueNoteItemMap_RPTEntity.RequestedQty = reader.GetDecimal(FLD_REQUESTEDQTY); }
            iNVStoreIssueNoteItemMap_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            iNVStoreIssueNoteItemMap_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            iNVStoreIssueNoteItemMap_RPTEntity.StoreName = reader.GetString(FLD_STORENAME);
            if (reader.IsDBNull(FLD_RETURNEDQTY)) { iNVStoreIssueNoteItemMap_RPTEntity.ReturnedQty = null; } else { iNVStoreIssueNoteItemMap_RPTEntity.ReturnedQty = reader.GetDecimal(FLD_RETURNEDQTY); }
            if (reader.IsDBNull(FLD_ACTUALISSUEDQTY)) { iNVStoreIssueNoteItemMap_RPTEntity.ActualIssuedQty = null; } else { iNVStoreIssueNoteItemMap_RPTEntity.ActualIssuedQty = reader.GetDecimal(FLD_ACTUALISSUEDQTY); }
            iNVStoreIssueNoteItemMap_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            iNVStoreIssueNoteItemMap_RPTEntity.UnitName = reader.GetString(FLD_UNITNAME);

            return iNVStoreIssueNoteItemMap_RPTEntity;
        }
    }
}
