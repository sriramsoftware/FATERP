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
    internal sealed class ACBankAccountPaymentItemBuilder : IEntityBuilder<ACBankAccountPaymentItemEntity>
    {
        IList<ACBankAccountPaymentItemEntity> IEntityBuilder<ACBankAccountPaymentItemEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountPaymentItemEntity> ACBankAccountPaymentItemEntityList = new List<ACBankAccountPaymentItemEntity>();

            while (reader.Read())
            {
                ACBankAccountPaymentItemEntityList.Add(((IEntityBuilder<ACBankAccountPaymentItemEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountPaymentItemEntityList.Count > 0) ? ACBankAccountPaymentItemEntityList : null;
        }

        ACBankAccountPaymentItemEntity IEntityBuilder<ACBankAccountPaymentItemEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTPAYMENTITEMID = 0;
            const Int32 FLD_BANKACCOUNTPAYMENTID = 1;
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

            ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity = new ACBankAccountPaymentItemEntity();

            aCBankAccountPaymentItemEntity.BankAccountPaymentItemID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTITEMID);
            aCBankAccountPaymentItemEntity.BankAccountPaymentID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTID);
            aCBankAccountPaymentItemEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            if (reader.IsDBNull(FLD_DIMENSIONID)) { aCBankAccountPaymentItemEntity.DimensionID = null; } else { aCBankAccountPaymentItemEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCBankAccountPaymentItemEntity.ItemID = null; } else { aCBankAccountPaymentItemEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            aCBankAccountPaymentItemEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountPaymentItemEntity.Memo = String.Empty; } else { aCBankAccountPaymentItemEntity.Memo = reader.GetString(FLD_MEMO); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCBankAccountPaymentItemEntity.ProjectID = null; } else { aCBankAccountPaymentItemEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCBankAccountPaymentItemEntity.RequisitionID = null; } else { aCBankAccountPaymentItemEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCBankAccountPaymentItemEntity.WorkOrderID = null; } else { aCBankAccountPaymentItemEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCBankAccountPaymentItemEntity.BillID = null; } else { aCBankAccountPaymentItemEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCBankAccountPaymentItemEntity.ProjectFloorID = null; } else { aCBankAccountPaymentItemEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCBankAccountPaymentItemEntity.ProjectFloorUnitID = null; } else { aCBankAccountPaymentItemEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }

            return aCBankAccountPaymentItemEntity;
        }
    }
}
