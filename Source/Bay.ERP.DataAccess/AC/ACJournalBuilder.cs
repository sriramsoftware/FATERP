// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jul-2013, 09:46:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACJournalBuilder : IEntityBuilder<ACJournalEntity>
    {
        IList<ACJournalEntity> IEntityBuilder<ACJournalEntity>.BuildEntities(IDataReader reader)
        {
            List<ACJournalEntity> ACJournalEntityList = new List<ACJournalEntity>();

            while (reader.Read())
            {
                ACJournalEntityList.Add(((IEntityBuilder<ACJournalEntity>)this).BuildEntity(reader));
            }

            return (ACJournalEntityList.Count > 0) ? ACJournalEntityList : null;
        }

        ACJournalEntity IEntityBuilder<ACJournalEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_JOURNALID = 0;
            const Int32 FLD_ACCOUNTID = 1;
            const Int32 FLD_ACCOUNTGROUPID = 2;
            const Int32 FLD_CLASSID = 3;
            const Int32 FLD_CLASSTYPEID = 4;
            const Int32 FLD_TRANSACTIONDATETIME = 5;
            const Int32 FLD_AMOUNT = 6;
            const Int32 FLD_ENTEREDBYEMPLOYEEID = 7;
            const Int32 FLD_REFERENCEORMEMOORID = 8;
            const Int32 FLD_NOTE = 9;
            const Int32 FLD_MDDEBITCREDITID = 10;
            const Int32 FLD_DIMENSIONID = 11;
            const Int32 FLD_ITEMID = 12;
            const Int32 FLD_PROJECTID = 13;
            const Int32 FLD_FISCALYEARID = 14;
            const Int32 FLD_ISREVERSETRANSACTION = 15;
            const Int32 FLD_REVERSETRANSACTIONJOURNALID = 16;
            const Int32 FLD_REQUISITIONID = 17;
            const Int32 FLD_WORKORDERID = 18;
            const Int32 FLD_BILLID = 19;
            const Int32 FLD_PROJECTFLOORID = 20;
            const Int32 FLD_PROJECTFLOORUNITID = 21;
            const Int32 FLD_VOUCHERTYPE = 22;
            const Int32 FLD_RAYAN1 = 23;
            const Int32 FLD_RAYAN2 = 24;

            ACJournalEntity aCJournalEntity = new ACJournalEntity();

            aCJournalEntity.JournalID = reader.GetInt64(FLD_JOURNALID);
            aCJournalEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCJournalEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID);
            aCJournalEntity.ClassID = reader.GetInt64(FLD_CLASSID);
            aCJournalEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID);
            aCJournalEntity.TransactionDateTime = reader.GetDateTime(FLD_TRANSACTIONDATETIME);
            aCJournalEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            aCJournalEntity.EnteredByEmployeeID = reader.GetInt64(FLD_ENTEREDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_REFERENCEORMEMOORID)) { aCJournalEntity.ReferenceOrMemoOrID = String.Empty; } else { aCJournalEntity.ReferenceOrMemoOrID = reader.GetString(FLD_REFERENCEORMEMOORID); }
            if (reader.IsDBNull(FLD_NOTE)) { aCJournalEntity.Note = String.Empty; } else { aCJournalEntity.Note = reader.GetString(FLD_NOTE); }
            aCJournalEntity.MDDebitCreditID = reader.GetInt64(FLD_MDDEBITCREDITID);
            if (reader.IsDBNull(FLD_DIMENSIONID)) { aCJournalEntity.DimensionID = null; } else { aCJournalEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCJournalEntity.ItemID = null; } else { aCJournalEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCJournalEntity.ProjectID = null; } else { aCJournalEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            aCJournalEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            if (reader.IsDBNull(FLD_ISREVERSETRANSACTION)) { aCJournalEntity.IsReverseTransaction = false; } else { aCJournalEntity.IsReverseTransaction = reader.GetBoolean(FLD_ISREVERSETRANSACTION); }
            if (reader.IsDBNull(FLD_REVERSETRANSACTIONJOURNALID)) { aCJournalEntity.ReverseTransactionJournalID = null; } else { aCJournalEntity.ReverseTransactionJournalID = reader.GetInt64(FLD_REVERSETRANSACTIONJOURNALID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCJournalEntity.RequisitionID = null; } else { aCJournalEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCJournalEntity.WorkOrderID = null; } else { aCJournalEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCJournalEntity.BillID = null; } else { aCJournalEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCJournalEntity.ProjectFloorID = null; } else { aCJournalEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCJournalEntity.ProjectFloorUnitID = null; } else { aCJournalEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_VOUCHERTYPE)) { aCJournalEntity.VoucherType = String.Empty; } else { aCJournalEntity.VoucherType = reader.GetString(FLD_VOUCHERTYPE); }
            if (reader.IsDBNull(FLD_RAYAN1)) { aCJournalEntity.rayan1 = String.Empty; } else { aCJournalEntity.rayan1 = reader.GetString(FLD_RAYAN1); }
            if (reader.IsDBNull(FLD_RAYAN2)) { aCJournalEntity.rayan2 = String.Empty; } else { aCJournalEntity.rayan2 = reader.GetString(FLD_RAYAN2); }

            return aCJournalEntity;
        }
    }
}
