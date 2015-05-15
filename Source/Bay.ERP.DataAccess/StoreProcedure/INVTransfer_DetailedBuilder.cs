// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2012, 03:31:40




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVTransfer_DetailedBuilder : IEntityBuilder<INVTransfer_DetailedEntity>
    {
        IList<INVTransfer_DetailedEntity> IEntityBuilder<INVTransfer_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<INVTransfer_DetailedEntity> INVTransfer_DetailedEntityList = new List<INVTransfer_DetailedEntity>();

            while (reader.Read())
            {
                INVTransfer_DetailedEntityList.Add(((IEntityBuilder<INVTransfer_DetailedEntity>)this).BuildEntity(reader));
            }

            return (INVTransfer_DetailedEntityList.Count > 0) ? INVTransfer_DetailedEntityList : null;
        }

        INVTransfer_DetailedEntity IEntityBuilder<INVTransfer_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TRANSFERID = 0;
            const Int32 FLD_TRFNO = 1;
            const Int32 FLD_REQUESTEDBYEMPLOYEEID = 2;
            const Int32 FLD_REQUESTDATE = 3;
            const Int32 FLD_TRANSFERFROMSTOREID = 4;
            const Int32 FLD_TRANSFERFROMSTOREUNITID = 5;
            const Int32 FLD_TRANSFERTOSTOREID = 6;
            const Int32 FLD_TRANSFERTOSTOREUNITID = 7;
            const Int32 FLD_REMARKS = 8;
            const Int32 FLD_INVENTORYTRANSFERSTATUSID = 9;
            const Int32 FLD_HREMPLOYEEMEMBERID = 10;
            const Int32 FLD_TRANSFERFROMSTORE = 11;
            const Int32 FLD_TRANSFERFROMSTOREUNIT = 12;
            const Int32 FLD_TRANSFERTOSTORENAME = 13;
            const Int32 FLD_TRANSFERTOUNIT = 14;
            const Int32 FLD_MDINVENTORYTRANSFERSTATUSNAME = 15;
            const Int32 FLD_ROWNUMBER = 16;

            INVTransfer_DetailedEntity iNVTransfer_DetailedEntity = new INVTransfer_DetailedEntity();

            iNVTransfer_DetailedEntity.TransferID = reader.GetInt64(FLD_TRANSFERID);
            iNVTransfer_DetailedEntity.TRFNo = reader.GetString(FLD_TRFNO);
            iNVTransfer_DetailedEntity.RequestedByEmployeeID = reader.GetInt64(FLD_REQUESTEDBYEMPLOYEEID);
            iNVTransfer_DetailedEntity.RequestDate = reader.GetDateTime(FLD_REQUESTDATE);
            iNVTransfer_DetailedEntity.TransferFromStoreID = reader.GetInt64(FLD_TRANSFERFROMSTOREID);
            iNVTransfer_DetailedEntity.TransferFromStoreUnitID = reader.GetInt64(FLD_TRANSFERFROMSTOREUNITID);
            iNVTransfer_DetailedEntity.TransferToStoreID = reader.GetInt64(FLD_TRANSFERTOSTOREID);
            iNVTransfer_DetailedEntity.TransferToStoreUnitID = reader.GetInt64(FLD_TRANSFERTOSTOREUNITID);
            if (reader.IsDBNull(FLD_REMARKS)) { iNVTransfer_DetailedEntity.Remarks = String.Empty; } else { iNVTransfer_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            iNVTransfer_DetailedEntity.InventoryTransferStatusID = reader.GetInt64(FLD_INVENTORYTRANSFERSTATUSID);
            if (reader.IsDBNull(FLD_HREMPLOYEEMEMBERID)) { iNVTransfer_DetailedEntity.HREmployeeMemberID = null; } else { iNVTransfer_DetailedEntity.HREmployeeMemberID = reader.GetInt64(FLD_HREMPLOYEEMEMBERID); }
            if (reader.IsDBNull(FLD_TRANSFERFROMSTORE)) { iNVTransfer_DetailedEntity.TransferFromStore = String.Empty; } else { iNVTransfer_DetailedEntity.TransferFromStore = reader.GetString(FLD_TRANSFERFROMSTORE); }
            if (reader.IsDBNull(FLD_TRANSFERFROMSTOREUNIT)) { iNVTransfer_DetailedEntity.TransferFromStoreUnit = String.Empty; } else { iNVTransfer_DetailedEntity.TransferFromStoreUnit = reader.GetString(FLD_TRANSFERFROMSTOREUNIT); }
            if (reader.IsDBNull(FLD_TRANSFERTOSTORENAME)) { iNVTransfer_DetailedEntity.TransferToStoreName = String.Empty; } else { iNVTransfer_DetailedEntity.TransferToStoreName = reader.GetString(FLD_TRANSFERTOSTORENAME); }
            if (reader.IsDBNull(FLD_TRANSFERTOUNIT)) { iNVTransfer_DetailedEntity.TransferToUnit = String.Empty; } else { iNVTransfer_DetailedEntity.TransferToUnit = reader.GetString(FLD_TRANSFERTOUNIT); }
            if (reader.IsDBNull(FLD_MDINVENTORYTRANSFERSTATUSNAME)) { iNVTransfer_DetailedEntity.MDInventoryTransferStatusName = String.Empty; } else { iNVTransfer_DetailedEntity.MDInventoryTransferStatusName = reader.GetString(FLD_MDINVENTORYTRANSFERSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { iNVTransfer_DetailedEntity.RowNumber = null; } else { iNVTransfer_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return iNVTransfer_DetailedEntity;
        }
    }
}
