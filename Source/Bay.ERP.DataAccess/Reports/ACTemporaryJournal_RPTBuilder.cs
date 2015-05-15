// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Feb-2013, 11:43:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACTemporaryJournal_RPTBuilder : IEntityBuilder<ACTemporaryJournal_RPTEntity>
    {
        IList<ACTemporaryJournal_RPTEntity> IEntityBuilder<ACTemporaryJournal_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACTemporaryJournal_RPTEntity> ACTemporaryJournal_RPTEntityList = new List<ACTemporaryJournal_RPTEntity>();

            while (reader.Read())
            {
                ACTemporaryJournal_RPTEntityList.Add(((IEntityBuilder<ACTemporaryJournal_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACTemporaryJournal_RPTEntityList.Count > 0) ? ACTemporaryJournal_RPTEntityList : null;
        }

        ACTemporaryJournal_RPTEntity IEntityBuilder<ACTemporaryJournal_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_PROJECTID = 13;
            const Int32 FLD_FISCALYEARID = 14;
            const Int32 FLD_ISREVERSETRANSACTION = 15;
            const Int32 FLD_ACCOUNTCODE = 16;
            const Int32 FLD_ACCOUNTNAME = 17;
            const Int32 FLD_ACCOUNTGROUPNAME = 18;
            const Int32 FLD_DIMENSIONNAME = 19;
            const Int32 FLD_PROJECTCODE = 20;
            const Int32 FLD_PROJECTNAME = 21;

            ACTemporaryJournal_RPTEntity aCTemporaryJournal_RPTEntity = new ACTemporaryJournal_RPTEntity();

            aCTemporaryJournal_RPTEntity.TemporaryJournalID = reader.GetInt64(FLD_TEMPORARYJOURNALID);
            aCTemporaryJournal_RPTEntity.TemporaryJournalMasterID = reader.GetInt64(FLD_TEMPORARYJOURNALMASTERID);
            aCTemporaryJournal_RPTEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCTemporaryJournal_RPTEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID);
            aCTemporaryJournal_RPTEntity.ClassID = reader.GetInt64(FLD_CLASSID);
            aCTemporaryJournal_RPTEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID);
            aCTemporaryJournal_RPTEntity.TransactionDateTime = reader.GetDateTime(FLD_TRANSACTIONDATETIME);
            aCTemporaryJournal_RPTEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            aCTemporaryJournal_RPTEntity.EnteredByEmployeeID = reader.GetInt64(FLD_ENTEREDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_REFERENCEORMEMOORID)) { aCTemporaryJournal_RPTEntity.ReferenceOrMemoOrID = String.Empty; } else { aCTemporaryJournal_RPTEntity.ReferenceOrMemoOrID = reader.GetString(FLD_REFERENCEORMEMOORID); }
            if (reader.IsDBNull(FLD_NOTE)) { aCTemporaryJournal_RPTEntity.Note = String.Empty; } else { aCTemporaryJournal_RPTEntity.Note = reader.GetString(FLD_NOTE); }
            aCTemporaryJournal_RPTEntity.MDDebitCreditID = reader.GetInt64(FLD_MDDEBITCREDITID);
            if (reader.IsDBNull(FLD_DIMENSIONID)) { aCTemporaryJournal_RPTEntity.DimensionID = null; } else { aCTemporaryJournal_RPTEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCTemporaryJournal_RPTEntity.ProjectID = null; } else { aCTemporaryJournal_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            aCTemporaryJournal_RPTEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            if (reader.IsDBNull(FLD_ISREVERSETRANSACTION)) { aCTemporaryJournal_RPTEntity.IsReverseTransaction = false; } else { aCTemporaryJournal_RPTEntity.IsReverseTransaction = reader.GetBoolean(FLD_ISREVERSETRANSACTION); }
            aCTemporaryJournal_RPTEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE);
            aCTemporaryJournal_RPTEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME);
            aCTemporaryJournal_RPTEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME);
            aCTemporaryJournal_RPTEntity.DimensionName = reader.GetString(FLD_DIMENSIONNAME);
            aCTemporaryJournal_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            aCTemporaryJournal_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);

            return aCTemporaryJournal_RPTEntity;
        }
    }
}
