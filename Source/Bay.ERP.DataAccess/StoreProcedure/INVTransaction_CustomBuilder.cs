// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Sep-2013, 04:06:30




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVTransaction_CustomBuilder : IEntityBuilder<INVTransaction_CustomEntity>
    {
        IList<INVTransaction_CustomEntity> IEntityBuilder<INVTransaction_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<INVTransaction_CustomEntity> INVTransaction_CustomEntityList = new List<INVTransaction_CustomEntity>();

            while (reader.Read())
            {
                INVTransaction_CustomEntityList.Add(((IEntityBuilder<INVTransaction_CustomEntity>)this).BuildEntity(reader));
            }

            return (INVTransaction_CustomEntityList.Count > 0) ? INVTransaction_CustomEntityList : null;
        }

        INVTransaction_CustomEntity IEntityBuilder<INVTransaction_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TRANSFERID = 0;
            const Int32 FLD_TRFNO = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_TRANSFERFROMSTOREID = 3;
            const Int32 FLD_TRANSFERTOSTOREID = 4;
            const Int32 FLD_FROMPROJECTNAME = 5;
            const Int32 FLD_FROMSTORENAME = 6;
            const Int32 FLD_TOPROJECTNAME = 7;
            const Int32 FLD_TOSTORENAME = 8;
            const Int32 FLD_ITEMNAME = 9;
            const Int32 FLD_UNITNAME = 10;
            const Int32 FLD_REQUESTDATE = 11;
            const Int32 FLD_REQUESTQTY = 12;
            const Int32 FLD_SINREQUESTEDQTY = 13;
            const Int32 FLD_SINISSUEQTY = 14;
            const Int32 FLD_SINTRANSFERID = 15;
            const Int32 FLD_SINITEMID = 16;
            const Int32 FLD_SINFROMSTOREID = 17;
            const Int32 FLD_SINTOSTOREID = 18;

            INVTransaction_CustomEntity iNVTransaction_CustomEntity = new INVTransaction_CustomEntity();

            iNVTransaction_CustomEntity.TransferID = reader.GetInt64(FLD_TRANSFERID);
            iNVTransaction_CustomEntity.TRFNo = reader.GetString(FLD_TRFNO);
            iNVTransaction_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            iNVTransaction_CustomEntity.TransferFromStoreID = reader.GetInt64(FLD_TRANSFERFROMSTOREID);
            iNVTransaction_CustomEntity.TransferToStoreID = reader.GetInt64(FLD_TRANSFERTOSTOREID);
            iNVTransaction_CustomEntity.FromProjectName = reader.GetString(FLD_FROMPROJECTNAME);
            iNVTransaction_CustomEntity.FromStoreName = reader.GetString(FLD_FROMSTORENAME);
            iNVTransaction_CustomEntity.ToProjectName = reader.GetString(FLD_TOPROJECTNAME);
            iNVTransaction_CustomEntity.ToStoreName = reader.GetString(FLD_TOSTORENAME);
            iNVTransaction_CustomEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            if (reader.IsDBNull(FLD_UNITNAME)) { iNVTransaction_CustomEntity.UnitName = String.Empty; } else { iNVTransaction_CustomEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            iNVTransaction_CustomEntity.RequestDate = reader.GetDateTime(FLD_REQUESTDATE);
            if (reader.IsDBNull(FLD_REQUESTQTY)) { iNVTransaction_CustomEntity.RequestQty = null; } else { iNVTransaction_CustomEntity.RequestQty = reader.GetDecimal(FLD_REQUESTQTY); }
            if (reader.IsDBNull(FLD_SINREQUESTEDQTY)) { iNVTransaction_CustomEntity.SINRequestedQty = null; } else { iNVTransaction_CustomEntity.SINRequestedQty = reader.GetDecimal(FLD_SINREQUESTEDQTY); }
            if (reader.IsDBNull(FLD_SINISSUEQTY)) { iNVTransaction_CustomEntity.SINIssueQty = null; } else { iNVTransaction_CustomEntity.SINIssueQty = reader.GetDecimal(FLD_SINISSUEQTY); }
            if (reader.IsDBNull(FLD_SINTRANSFERID)) { iNVTransaction_CustomEntity.SINTransferID = null; } else { iNVTransaction_CustomEntity.SINTransferID = reader.GetInt64(FLD_SINTRANSFERID); }
            if (reader.IsDBNull(FLD_SINITEMID)) { iNVTransaction_CustomEntity.SINItemID = null; } else { iNVTransaction_CustomEntity.SINItemID = reader.GetInt64(FLD_SINITEMID); }
            if (reader.IsDBNull(FLD_SINFROMSTOREID)) { iNVTransaction_CustomEntity.SINFromStoreID = null; } else { iNVTransaction_CustomEntity.SINFromStoreID = reader.GetInt64(FLD_SINFROMSTOREID); }
            if (reader.IsDBNull(FLD_SINTOSTOREID)) { iNVTransaction_CustomEntity.SINToStoreID = null; } else { iNVTransaction_CustomEntity.SINToStoreID = reader.GetInt64(FLD_SINTOSTOREID); }

            return iNVTransaction_CustomEntity;
        }
    }
}
