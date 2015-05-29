// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jul-2013, 02:28:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACTemporaryJournalBuilder : IEntityBuilder<ACTemporaryJournalEntity>
    {
        IList<ACTemporaryJournalEntity> IEntityBuilder<ACTemporaryJournalEntity>.BuildEntities(IDataReader reader)
        {
            List<ACTemporaryJournalEntity> ACTemporaryJournalEntityList = new List<ACTemporaryJournalEntity>();

            while (reader.Read())
            {
                ACTemporaryJournalEntityList.Add(((IEntityBuilder<ACTemporaryJournalEntity>)this).BuildEntity(reader));
            }

            return (ACTemporaryJournalEntityList.Count > 0) ? ACTemporaryJournalEntityList : null;
        }

        ACTemporaryJournalEntity IEntityBuilder<ACTemporaryJournalEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TEMPORARYJOURNALID = 0;
            const Int32 FLD_TEMPORARYJOURNALMASTERID = 1;
            const Int32 FLD_ACCOUNTID = 2;
            const Int32 FLD_ACCOUNTGROUPID = 3;
            const Int32 FLD_CLASSID = 4;
            const Int32 FLD_CLASSTYPEID = 5;
            const Int32 FLD_TRANSACTIONDATETIME = 6;
            const Int32 FLD_AMOUNT = 7;
            const Int32 FLD_ENTEREDBYEMPLOYEEID = 8;
            const Int32 FLD_REFERENCEORMEMOORID = 9;
            const Int32 FLD_NOTE = 10;
            const Int32 FLD_MDDEBITCREDITID = 11;
            const Int32 FLD_DIMENSIONID = 12;
            const Int32 FLD_ITEMID = 13;
            const Int32 FLD_PROJECTID = 14;
            const Int32 FLD_FISCALYEARID = 15;
            const Int32 FLD_ISREVERSETRANSACTION = 16;
            const Int32 FLD_REVERSETRANSACTIONJOURNALID = 17;
            const Int32 FLD_REQUISITIONID = 18;
            const Int32 FLD_WORKORDERID = 19;
            const Int32 FLD_BILLID = 20;
            const Int32 FLD_PROJECTFLOORID = 21;
            const Int32 FLD_PROJECTFLOORUNITID = 22;

            ACTemporaryJournalEntity aCTemporaryJournalEntity = new ACTemporaryJournalEntity();

            aCTemporaryJournalEntity.TemporaryJournalID = reader.GetInt64(FLD_TEMPORARYJOURNALID);
            aCTemporaryJournalEntity.TemporaryJournalMasterID = reader.GetInt64(FLD_TEMPORARYJOURNALMASTERID);
            aCTemporaryJournalEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCTemporaryJournalEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID);
            aCTemporaryJournalEntity.ClassID = reader.GetInt64(FLD_CLASSID);
            aCTemporaryJournalEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID);
            aCTemporaryJournalEntity.TransactionDateTime = reader.GetDateTime(FLD_TRANSACTIONDATETIME);
            aCTemporaryJournalEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            aCTemporaryJournalEntity.EnteredByEmployeeID = reader.GetInt64(FLD_ENTEREDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_REFERENCEORMEMOORID)) { aCTemporaryJournalEntity.ReferenceOrMemoOrID = String.Empty; } else { aCTemporaryJournalEntity.ReferenceOrMemoOrID = reader.GetString(FLD_REFERENCEORMEMOORID); }
            if (reader.IsDBNull(FLD_NOTE)) { aCTemporaryJournalEntity.Note = String.Empty; } else { aCTemporaryJournalEntity.Note = reader.GetString(FLD_NOTE); }
            aCTemporaryJournalEntity.MDDebitCreditID = reader.GetInt64(FLD_MDDEBITCREDITID);
            if (reader.IsDBNull(FLD_DIMENSIONID)) { aCTemporaryJournalEntity.DimensionID = null; } else { aCTemporaryJournalEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCTemporaryJournalEntity.ItemID = null; } else { aCTemporaryJournalEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCTemporaryJournalEntity.ProjectID = null; } else { aCTemporaryJournalEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            aCTemporaryJournalEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            if (reader.IsDBNull(FLD_ISREVERSETRANSACTION)) { aCTemporaryJournalEntity.IsReverseTransaction = false; } else { aCTemporaryJournalEntity.IsReverseTransaction = reader.GetBoolean(FLD_ISREVERSETRANSACTION); }
            if (reader.IsDBNull(FLD_REVERSETRANSACTIONJOURNALID)) { aCTemporaryJournalEntity.ReverseTransactionJournalID = null; } else { aCTemporaryJournalEntity.ReverseTransactionJournalID = reader.GetInt64(FLD_REVERSETRANSACTIONJOURNALID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCTemporaryJournalEntity.RequisitionID = null; } else { aCTemporaryJournalEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCTemporaryJournalEntity.WorkOrderID = null; } else { aCTemporaryJournalEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCTemporaryJournalEntity.BillID = null; } else { aCTemporaryJournalEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCTemporaryJournalEntity.ProjectFloorID = null; } else { aCTemporaryJournalEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCTemporaryJournalEntity.ProjectFloorUnitID = null; } else { aCTemporaryJournalEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }

            return aCTemporaryJournalEntity;
        }
    }
}
