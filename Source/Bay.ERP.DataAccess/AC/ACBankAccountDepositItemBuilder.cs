// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2013, 11:20:53




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBankAccountDepositItemBuilder : IEntityBuilder<ACBankAccountDepositItemEntity>
    {
        IList<ACBankAccountDepositItemEntity> IEntityBuilder<ACBankAccountDepositItemEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountDepositItemEntity> ACBankAccountDepositItemEntityList = new List<ACBankAccountDepositItemEntity>();

            while (reader.Read())
            {
                ACBankAccountDepositItemEntityList.Add(((IEntityBuilder<ACBankAccountDepositItemEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountDepositItemEntityList.Count > 0) ? ACBankAccountDepositItemEntityList : null;
        }

        ACBankAccountDepositItemEntity IEntityBuilder<ACBankAccountDepositItemEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTDEPOSITITEMID = 0;
            const Int32 FLD_BANKACCOUNTDEPOSITID = 1;
            const Int32 FLD_ACCOUNTID = 2;
            const Int32 FLD_DIMENSIONID = 3;
            const Int32 FLD_ITEMID = 4;
            const Int32 FLD_AMOUNT = 5;
            const Int32 FLD_MEMO = 6;
            const Int32 FLD_PROJECTID = 7;
            const Int32 FLD_REQUISITIONID = 8;
            const Int32 FLD_WORKORDERID = 9;
            const Int32 FLD_BILLID = 10;
            const Int32 FLD_PROJECTFLOORID = 11;
            const Int32 FLD_PROJECTFLOORUNITID = 12;

            ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity = new ACBankAccountDepositItemEntity();

            aCBankAccountDepositItemEntity.BankAccountDepositItemID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITITEMID);
            aCBankAccountDepositItemEntity.BankAccountDepositID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITID);
            aCBankAccountDepositItemEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            if (reader.IsDBNull(FLD_DIMENSIONID)) { aCBankAccountDepositItemEntity.DimensionID = null; } else { aCBankAccountDepositItemEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCBankAccountDepositItemEntity.ItemID = null; } else { aCBankAccountDepositItemEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            aCBankAccountDepositItemEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountDepositItemEntity.Memo = String.Empty; } else { aCBankAccountDepositItemEntity.Memo = reader.GetString(FLD_MEMO); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCBankAccountDepositItemEntity.ProjectID = null; } else { aCBankAccountDepositItemEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCBankAccountDepositItemEntity.RequisitionID = null; } else { aCBankAccountDepositItemEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCBankAccountDepositItemEntity.WorkOrderID = null; } else { aCBankAccountDepositItemEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCBankAccountDepositItemEntity.BillID = null; } else { aCBankAccountDepositItemEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCBankAccountDepositItemEntity.ProjectFloorID = null; } else { aCBankAccountDepositItemEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCBankAccountDepositItemEntity.ProjectFloorUnitID = null; } else { aCBankAccountDepositItemEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }

            return aCBankAccountDepositItemEntity;
        }
    }
}
