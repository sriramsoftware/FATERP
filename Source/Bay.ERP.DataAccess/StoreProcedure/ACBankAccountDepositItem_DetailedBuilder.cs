// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jul-2013, 11:47:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBankAccountDepositItem_DetailedBuilder : IEntityBuilder<ACBankAccountDepositItem_DetailedEntity>
    {
        IList<ACBankAccountDepositItem_DetailedEntity> IEntityBuilder<ACBankAccountDepositItem_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountDepositItem_DetailedEntity> ACBankAccountDepositItem_DetailedEntityList = new List<ACBankAccountDepositItem_DetailedEntity>();

            while (reader.Read())
            {
                ACBankAccountDepositItem_DetailedEntityList.Add(((IEntityBuilder<ACBankAccountDepositItem_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountDepositItem_DetailedEntityList.Count > 0) ? ACBankAccountDepositItem_DetailedEntityList : null;
        }

        ACBankAccountDepositItem_DetailedEntity IEntityBuilder<ACBankAccountDepositItem_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTDEPOSITITEMID = 0;
            const Int32 FLD_BANKACCOUNTDEPOSITID = 1;
            const Int32 FLD_ACCOUNTID = 2;
            const Int32 FLD_DIMENSIONID = 3;
            const Int32 FLD_AMOUNT = 4;
            const Int32 FLD_MEMO = 5;
            const Int32 FLD_PROJECTID = 6;
            const Int32 FLD_REQUISITIONID = 7;
            const Int32 FLD_BILLID = 8;
            const Int32 FLD_WORKORDERID = 9;
            const Int32 FLD_PROJECTFLOORID = 10;
            const Int32 FLD_PROJECTFLOORUNITID = 11;
            const Int32 FLD_ITEMID = 12;
            const Int32 FLD_BANKACCOUNTDEPOSITNAME = 13;
            const Int32 FLD_ACCOUNTNAME = 14;
            const Int32 FLD_ACDIMENSIONNAME = 15;
            const Int32 FLD_WORKORDERNO = 16;
            const Int32 FLD_PROJECTCODE = 17;
            const Int32 FLD_PROJECTNAME = 18;
            const Int32 FLD_PROJECTFLOORUNITNAME = 19;
            const Int32 FLD_REQUISITIONNO = 20;
            const Int32 FLD_BILLNO = 21;
            const Int32 FLD_PROJECTFLOORNAME = 22;
            const Int32 FLD_ITEMNAME = 23;
            const Int32 FLD_ROWNUMBER = 24;

            ACBankAccountDepositItem_DetailedEntity aCBankAccountDepositItem_DetailedEntity = new ACBankAccountDepositItem_DetailedEntity();

            aCBankAccountDepositItem_DetailedEntity.BankAccountDepositItemID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITITEMID);
            aCBankAccountDepositItem_DetailedEntity.BankAccountDepositID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITID);
            aCBankAccountDepositItem_DetailedEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            if (reader.IsDBNull(FLD_DIMENSIONID)) { aCBankAccountDepositItem_DetailedEntity.DimensionID = null; } else { aCBankAccountDepositItem_DetailedEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID); }
            aCBankAccountDepositItem_DetailedEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountDepositItem_DetailedEntity.Memo = String.Empty; } else { aCBankAccountDepositItem_DetailedEntity.Memo = reader.GetString(FLD_MEMO); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCBankAccountDepositItem_DetailedEntity.ProjectID = null; } else { aCBankAccountDepositItem_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCBankAccountDepositItem_DetailedEntity.RequisitionID = null; } else { aCBankAccountDepositItem_DetailedEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCBankAccountDepositItem_DetailedEntity.BillID = null; } else { aCBankAccountDepositItem_DetailedEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCBankAccountDepositItem_DetailedEntity.WorkOrderID = null; } else { aCBankAccountDepositItem_DetailedEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCBankAccountDepositItem_DetailedEntity.ProjectFloorID = null; } else { aCBankAccountDepositItem_DetailedEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCBankAccountDepositItem_DetailedEntity.ProjectFloorUnitID = null; } else { aCBankAccountDepositItem_DetailedEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCBankAccountDepositItem_DetailedEntity.ItemID = null; } else { aCBankAccountDepositItem_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITNAME)) { aCBankAccountDepositItem_DetailedEntity.BankAccountDepositName = String.Empty; } else { aCBankAccountDepositItem_DetailedEntity.BankAccountDepositName = reader.GetString(FLD_BANKACCOUNTDEPOSITNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTNAME)) { aCBankAccountDepositItem_DetailedEntity.AccountName = String.Empty; } else { aCBankAccountDepositItem_DetailedEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACDIMENSIONNAME)) { aCBankAccountDepositItem_DetailedEntity.ACDimensionName = String.Empty; } else { aCBankAccountDepositItem_DetailedEntity.ACDimensionName = reader.GetString(FLD_ACDIMENSIONNAME); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCBankAccountDepositItem_DetailedEntity.WorkOrderNo = String.Empty; } else { aCBankAccountDepositItem_DetailedEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCBankAccountDepositItem_DetailedEntity.ProjectCode = String.Empty; } else { aCBankAccountDepositItem_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCBankAccountDepositItem_DetailedEntity.ProjectName = String.Empty; } else { aCBankAccountDepositItem_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { aCBankAccountDepositItem_DetailedEntity.ProjectFloorUnitName = String.Empty; } else { aCBankAccountDepositItem_DetailedEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCBankAccountDepositItem_DetailedEntity.RequisitionNo = String.Empty; } else { aCBankAccountDepositItem_DetailedEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCBankAccountDepositItem_DetailedEntity.BillNo = String.Empty; } else { aCBankAccountDepositItem_DetailedEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { aCBankAccountDepositItem_DetailedEntity.ProjectFloorName = String.Empty; } else { aCBankAccountDepositItem_DetailedEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { aCBankAccountDepositItem_DetailedEntity.ItemName = String.Empty; } else { aCBankAccountDepositItem_DetailedEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCBankAccountDepositItem_DetailedEntity.RowNumber = null; } else { aCBankAccountDepositItem_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCBankAccountDepositItem_DetailedEntity;
        }
    }
}
