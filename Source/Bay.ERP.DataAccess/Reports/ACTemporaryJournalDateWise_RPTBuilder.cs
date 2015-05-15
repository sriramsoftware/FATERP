// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2013, 11:29:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACTemporaryJournalDateWise_RPTBuilder : IEntityBuilder<ACTemporaryJournalDateWise_RPTEntity>
    {
        IList<ACTemporaryJournalDateWise_RPTEntity> IEntityBuilder<ACTemporaryJournalDateWise_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACTemporaryJournalDateWise_RPTEntity> ACTemporaryJournalDateWise_RPTEntityList = new List<ACTemporaryJournalDateWise_RPTEntity>();

            while (reader.Read())
            {
                ACTemporaryJournalDateWise_RPTEntityList.Add(((IEntityBuilder<ACTemporaryJournalDateWise_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACTemporaryJournalDateWise_RPTEntityList.Count > 0) ? ACTemporaryJournalDateWise_RPTEntityList : null;
        }

        ACTemporaryJournalDateWise_RPTEntity IEntityBuilder<ACTemporaryJournalDateWise_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_ITEMNAME = 20;
            const Int32 FLD_REQUISITIONNO = 21;
            const Int32 FLD_WORKORDERNO = 22;
            const Int32 FLD_BILLNO = 23;
            const Int32 FLD_PROJECTCODE = 24;
            const Int32 FLD_PROJECTNAME = 25;
            const Int32 FLD_PROJECTFLOORNAME = 26;
            const Int32 FLD_PROJECTFLOORUNITNAME = 27;
            const Int32 FLD_MEMBERFULLNAME = 28;

            ACTemporaryJournalDateWise_RPTEntity aCTemporaryJournalDateWise_RPTEntity = new ACTemporaryJournalDateWise_RPTEntity();

            aCTemporaryJournalDateWise_RPTEntity.TemporaryJournalID = reader.GetInt64(FLD_TEMPORARYJOURNALID);
            aCTemporaryJournalDateWise_RPTEntity.TemporaryJournalMasterID = reader.GetInt64(FLD_TEMPORARYJOURNALMASTERID);
            aCTemporaryJournalDateWise_RPTEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCTemporaryJournalDateWise_RPTEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID);
            aCTemporaryJournalDateWise_RPTEntity.ClassID = reader.GetInt64(FLD_CLASSID);
            aCTemporaryJournalDateWise_RPTEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID);
            aCTemporaryJournalDateWise_RPTEntity.TransactionDateTime = reader.GetDateTime(FLD_TRANSACTIONDATETIME);
            aCTemporaryJournalDateWise_RPTEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            aCTemporaryJournalDateWise_RPTEntity.EnteredByEmployeeID = reader.GetInt64(FLD_ENTEREDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_REFERENCEORMEMOORID)) { aCTemporaryJournalDateWise_RPTEntity.ReferenceOrMemoOrID = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.ReferenceOrMemoOrID = reader.GetString(FLD_REFERENCEORMEMOORID); }
            if (reader.IsDBNull(FLD_NOTE)) { aCTemporaryJournalDateWise_RPTEntity.Note = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.Note = reader.GetString(FLD_NOTE); }
            aCTemporaryJournalDateWise_RPTEntity.MDDebitCreditID = reader.GetInt64(FLD_MDDEBITCREDITID);
            if (reader.IsDBNull(FLD_DIMENSIONID)) { aCTemporaryJournalDateWise_RPTEntity.DimensionID = null; } else { aCTemporaryJournalDateWise_RPTEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCTemporaryJournalDateWise_RPTEntity.ProjectID = null; } else { aCTemporaryJournalDateWise_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            aCTemporaryJournalDateWise_RPTEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            if (reader.IsDBNull(FLD_ISREVERSETRANSACTION)) { aCTemporaryJournalDateWise_RPTEntity.IsReverseTransaction = false; } else { aCTemporaryJournalDateWise_RPTEntity.IsReverseTransaction = reader.GetBoolean(FLD_ISREVERSETRANSACTION); }
            if (reader.IsDBNull(FLD_ACCOUNTCODE)) { aCTemporaryJournalDateWise_RPTEntity.AccountCode = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE); }
            if (reader.IsDBNull(FLD_ACCOUNTNAME)) { aCTemporaryJournalDateWise_RPTEntity.AccountName = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTGROUPNAME)) { aCTemporaryJournalDateWise_RPTEntity.AccountGroupName = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME); }
            if (reader.IsDBNull(FLD_DIMENSIONNAME)) { aCTemporaryJournalDateWise_RPTEntity.DimensionName = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.DimensionName = reader.GetString(FLD_DIMENSIONNAME); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { aCTemporaryJournalDateWise_RPTEntity.ItemName = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCTemporaryJournalDateWise_RPTEntity.RequisitionNo = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCTemporaryJournalDateWise_RPTEntity.WorkOrderNo = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCTemporaryJournalDateWise_RPTEntity.BillNo = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCTemporaryJournalDateWise_RPTEntity.ProjectCode = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCTemporaryJournalDateWise_RPTEntity.ProjectName = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { aCTemporaryJournalDateWise_RPTEntity.ProjectFloorName = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { aCTemporaryJournalDateWise_RPTEntity.ProjectFloorUnitName = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCTemporaryJournalDateWise_RPTEntity.MemberFullName = String.Empty; } else { aCTemporaryJournalDateWise_RPTEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }

            return aCTemporaryJournalDateWise_RPTEntity;
        }
    }
}
