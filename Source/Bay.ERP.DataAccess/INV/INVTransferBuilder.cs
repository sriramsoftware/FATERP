// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jun-2013, 01:46:16




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVTransferBuilder : IEntityBuilder<INVTransferEntity>
    {
        IList<INVTransferEntity> IEntityBuilder<INVTransferEntity>.BuildEntities(IDataReader reader)
        {
            List<INVTransferEntity> INVTransferEntityList = new List<INVTransferEntity>();

            while (reader.Read())
            {
                INVTransferEntityList.Add(((IEntityBuilder<INVTransferEntity>)this).BuildEntity(reader));
            }

            return (INVTransferEntityList.Count > 0) ? INVTransferEntityList : null;
        }

        INVTransferEntity IEntityBuilder<INVTransferEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TRANSFERID = 0;
            const Int32 FLD_TRFNO = 1;
            const Int32 FLD_REQUESTEDBYEMPLOYEEID = 2;
            const Int32 FLD_REQUESTDATE = 3;
            const Int32 FLD_TRANSFERFROMSTOREID = 4;
            const Int32 FLD_TRANSFERFROMSTOREUNITID = 5;
            const Int32 FLD_TRANSFERTOSTOREID = 6;
            const Int32 FLD_TRANSFERTOSTOREUNITID = 7;
            const Int32 FLD_REQUISITIONID = 8;
            const Int32 FLD_REMARKS = 9;
            const Int32 FLD_INVENTORYTRANSFERSTATUSID = 10;

            INVTransferEntity iNVTransferEntity = new INVTransferEntity();

            iNVTransferEntity.TransferID = reader.GetInt64(FLD_TRANSFERID);
            iNVTransferEntity.TRFNo = reader.GetString(FLD_TRFNO);
            iNVTransferEntity.RequestedByEmployeeID = reader.GetInt64(FLD_REQUESTEDBYEMPLOYEEID);
            iNVTransferEntity.RequestDate = reader.GetDateTime(FLD_REQUESTDATE);
            iNVTransferEntity.TransferFromStoreID = reader.GetInt64(FLD_TRANSFERFROMSTOREID);
            iNVTransferEntity.TransferFromStoreUnitID = reader.GetInt64(FLD_TRANSFERFROMSTOREUNITID);
            iNVTransferEntity.TransferToStoreID = reader.GetInt64(FLD_TRANSFERTOSTOREID);
            iNVTransferEntity.TransferToStoreUnitID = reader.GetInt64(FLD_TRANSFERTOSTOREUNITID);
            if (reader.IsDBNull(FLD_REQUISITIONID)) { iNVTransferEntity.RequisitionID = null; } else { iNVTransferEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_REMARKS)) { iNVTransferEntity.Remarks = String.Empty; } else { iNVTransferEntity.Remarks = reader.GetString(FLD_REMARKS); }
            iNVTransferEntity.InventoryTransferStatusID = reader.GetInt64(FLD_INVENTORYTRANSFERSTATUSID);

            return iNVTransferEntity;
        }
    }
}
