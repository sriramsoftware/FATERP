// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 12:29:09




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBankAccountPaymentItem_DetailedBuilder : IEntityBuilder<ACBankAccountPaymentItem_DetailedEntity>
    {
        IList<ACBankAccountPaymentItem_DetailedEntity> IEntityBuilder<ACBankAccountPaymentItem_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountPaymentItem_DetailedEntity> ACBankAccountPaymentItem_DetailedEntityList = new List<ACBankAccountPaymentItem_DetailedEntity>();

            while (reader.Read())
            {
                ACBankAccountPaymentItem_DetailedEntityList.Add(((IEntityBuilder<ACBankAccountPaymentItem_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountPaymentItem_DetailedEntityList.Count > 0) ? ACBankAccountPaymentItem_DetailedEntityList : null;
        }

        ACBankAccountPaymentItem_DetailedEntity IEntityBuilder<ACBankAccountPaymentItem_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTPAYMENTITEMID = 0;
            const Int32 FLD_BANKACCOUNTPAYMENTID = 1;
            const Int32 FLD_ACCOUNTID = 2;
            const Int32 FLD_DIMENSIONID = 3;
            const Int32 FLD_AMOUNT = 4;
            const Int32 FLD_MEMO = 5;
            const Int32 FLD_PROJECTID = 6;
            const Int32 FLD_REQUISITIONID = 7;
            const Int32 FLD_WORKORDERID = 8;
            const Int32 FLD_BILLID = 9;
            const Int32 FLD_PROJECTFLOORID = 10;
            const Int32 FLD_PROJECTFLOORUNITID = 11;
            const Int32 FLD_ITEMID = 12;
            const Int32 FLD_BANKACCOUNTPAYMENTNAME = 13;
            const Int32 FLD_ACCOUNTNAME = 14;
            const Int32 FLD_DIMENSIONNAME = 15;
            const Int32 FLD_REFERENCE = 16;
            const Int32 FLD_REQUISITIONNO = 17;
            const Int32 FLD_WORKORDERNO = 18;
            const Int32 FLD_BILLNO = 19;
            const Int32 FLD_PROJECTCODE = 20;
            const Int32 FLD_PROJECTNAME = 21;
            const Int32 FLD_PROJECTFLOORUNITNAME = 22;
            const Int32 FLD_PROJECTFLOORNAME = 23;
            const Int32 FLD_ITEMNAME = 24;
            const Int32 FLD_ROWNUMBER = 25;

            ACBankAccountPaymentItem_DetailedEntity aCBankAccountPaymentItem_DetailedEntity = new ACBankAccountPaymentItem_DetailedEntity();

            aCBankAccountPaymentItem_DetailedEntity.BankAccountPaymentItemID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTITEMID);
            aCBankAccountPaymentItem_DetailedEntity.BankAccountPaymentID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTID);
            aCBankAccountPaymentItem_DetailedEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            if (reader.IsDBNull(FLD_DIMENSIONID)) { aCBankAccountPaymentItem_DetailedEntity.DimensionID = null; } else { aCBankAccountPaymentItem_DetailedEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID); }
            aCBankAccountPaymentItem_DetailedEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountPaymentItem_DetailedEntity.Memo = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.Memo = reader.GetString(FLD_MEMO); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCBankAccountPaymentItem_DetailedEntity.ProjectID = null; } else { aCBankAccountPaymentItem_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCBankAccountPaymentItem_DetailedEntity.RequisitionID = null; } else { aCBankAccountPaymentItem_DetailedEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCBankAccountPaymentItem_DetailedEntity.WorkOrderID = null; } else { aCBankAccountPaymentItem_DetailedEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCBankAccountPaymentItem_DetailedEntity.BillID = null; } else { aCBankAccountPaymentItem_DetailedEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCBankAccountPaymentItem_DetailedEntity.ProjectFloorID = null; } else { aCBankAccountPaymentItem_DetailedEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCBankAccountPaymentItem_DetailedEntity.ProjectFloorUnitID = null; } else { aCBankAccountPaymentItem_DetailedEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCBankAccountPaymentItem_DetailedEntity.ItemID = null; } else { aCBankAccountPaymentItem_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_BANKACCOUNTPAYMENTNAME)) { aCBankAccountPaymentItem_DetailedEntity.BankAccountPaymentName = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.BankAccountPaymentName = reader.GetString(FLD_BANKACCOUNTPAYMENTNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTNAME)) { aCBankAccountPaymentItem_DetailedEntity.AccountName = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME); }
            if (reader.IsDBNull(FLD_DIMENSIONNAME)) { aCBankAccountPaymentItem_DetailedEntity.DimensionName = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.DimensionName = reader.GetString(FLD_DIMENSIONNAME); }
            if (reader.IsDBNull(FLD_REFERENCE)) { aCBankAccountPaymentItem_DetailedEntity.Reference = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.Reference = reader.GetString(FLD_REFERENCE); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCBankAccountPaymentItem_DetailedEntity.RequisitionNo = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCBankAccountPaymentItem_DetailedEntity.WorkOrderNo = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCBankAccountPaymentItem_DetailedEntity.BillNo = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCBankAccountPaymentItem_DetailedEntity.ProjectCode = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCBankAccountPaymentItem_DetailedEntity.ProjectName = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { aCBankAccountPaymentItem_DetailedEntity.ProjectFloorUnitName = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { aCBankAccountPaymentItem_DetailedEntity.ProjectFloorName = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { aCBankAccountPaymentItem_DetailedEntity.ItemName = String.Empty; } else { aCBankAccountPaymentItem_DetailedEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCBankAccountPaymentItem_DetailedEntity.RowNumber = null; } else { aCBankAccountPaymentItem_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCBankAccountPaymentItem_DetailedEntity;
        }
    }
}
