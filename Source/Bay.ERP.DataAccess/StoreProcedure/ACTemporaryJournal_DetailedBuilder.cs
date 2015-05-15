// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jul-2013, 01:34:19




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACTemporaryJournal_DetailedBuilder : IEntityBuilder<ACTemporaryJournal_DetailedEntity>
    {
        IList<ACTemporaryJournal_DetailedEntity> IEntityBuilder<ACTemporaryJournal_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACTemporaryJournal_DetailedEntity> ACTemporaryJournal_DetailedEntityList = new List<ACTemporaryJournal_DetailedEntity>();

            while (reader.Read())
            {
                ACTemporaryJournal_DetailedEntityList.Add(((IEntityBuilder<ACTemporaryJournal_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACTemporaryJournal_DetailedEntityList.Count > 0) ? ACTemporaryJournal_DetailedEntityList : null;
        }

        ACTemporaryJournal_DetailedEntity IEntityBuilder<ACTemporaryJournal_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_REVERSETRANSACTIONJOURNALID = 16;
            const Int32 FLD_ACACCOUNTACCOUNTNAME = 17;
            const Int32 FLD_ACACCOUNTGROUPNAME = 18;
            const Int32 FLD_ACCLASSNAME = 19;
            const Int32 FLD_ACCLASSTYPENAME = 20;
            const Int32 FLD_HREMPLOYEEMEMBERID = 21;
            const Int32 FLD_ACMDDEBITCREDITNAME = 22;
            const Int32 FLD_ACDIMENSIONNAME = 23;
            const Int32 FLD_BDPROJECTPROJECTNAME = 24;
            const Int32 FLD_ACFISCALYEAR = 25;
            const Int32 FLD_MEMBERFULLNAME = 26;
            const Int32 FLD_REQUISITIONID = 27;
            const Int32 FLD_WORKORDERID = 28;
            const Int32 FLD_BILLID = 29;
            const Int32 FLD_PROJECTFLOORID = 30;
            const Int32 FLD_PROJECTFLOORUNITID = 31;
            const Int32 FLD_BILLNO = 32;
            const Int32 FLD_REQUISITIONNO = 33;
            const Int32 FLD_PROJECTFLOORNAME = 34;
            const Int32 FLD_WORKORDERNO = 35;
            const Int32 FLD_PROJECTFLOORUNITNAME = 36;
            const Int32 FLD_ITEMID = 37;
            const Int32 FLD_ITEMNAME = 38;
            const Int32 FLD_ROWNUMBER = 39;

            ACTemporaryJournal_DetailedEntity aCTemporaryJournal_DetailedEntity = new ACTemporaryJournal_DetailedEntity();

            aCTemporaryJournal_DetailedEntity.TemporaryJournalID = reader.GetInt64(FLD_TEMPORARYJOURNALID);
            aCTemporaryJournal_DetailedEntity.TemporaryJournalMasterID = reader.GetInt64(FLD_TEMPORARYJOURNALMASTERID);
            aCTemporaryJournal_DetailedEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCTemporaryJournal_DetailedEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID);
            aCTemporaryJournal_DetailedEntity.ClassID = reader.GetInt64(FLD_CLASSID);
            aCTemporaryJournal_DetailedEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID);
            aCTemporaryJournal_DetailedEntity.TransactionDateTime = reader.GetDateTime(FLD_TRANSACTIONDATETIME);
            aCTemporaryJournal_DetailedEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            aCTemporaryJournal_DetailedEntity.EnteredByEmployeeID = reader.GetInt64(FLD_ENTEREDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_REFERENCEORMEMOORID)) { aCTemporaryJournal_DetailedEntity.ReferenceOrMemoOrID = String.Empty; } else { aCTemporaryJournal_DetailedEntity.ReferenceOrMemoOrID = reader.GetString(FLD_REFERENCEORMEMOORID); }
            if (reader.IsDBNull(FLD_NOTE)) { aCTemporaryJournal_DetailedEntity.Note = String.Empty; } else { aCTemporaryJournal_DetailedEntity.Note = reader.GetString(FLD_NOTE); }
            aCTemporaryJournal_DetailedEntity.MDDebitCreditID = reader.GetInt64(FLD_MDDEBITCREDITID);
            if (reader.IsDBNull(FLD_DIMENSIONID)) { aCTemporaryJournal_DetailedEntity.DimensionID = null; } else { aCTemporaryJournal_DetailedEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCTemporaryJournal_DetailedEntity.ProjectID = null; } else { aCTemporaryJournal_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            aCTemporaryJournal_DetailedEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            if (reader.IsDBNull(FLD_ISREVERSETRANSACTION)) { aCTemporaryJournal_DetailedEntity.IsReverseTransaction = false; } else { aCTemporaryJournal_DetailedEntity.IsReverseTransaction = reader.GetBoolean(FLD_ISREVERSETRANSACTION); }
            if (reader.IsDBNull(FLD_REVERSETRANSACTIONJOURNALID)) { aCTemporaryJournal_DetailedEntity.ReverseTransactionJournalID = null; } else { aCTemporaryJournal_DetailedEntity.ReverseTransactionJournalID = reader.GetInt64(FLD_REVERSETRANSACTIONJOURNALID); }
            if (reader.IsDBNull(FLD_ACACCOUNTACCOUNTNAME)) { aCTemporaryJournal_DetailedEntity.ACAccountAccountName = String.Empty; } else { aCTemporaryJournal_DetailedEntity.ACAccountAccountName = reader.GetString(FLD_ACACCOUNTACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACACCOUNTGROUPNAME)) { aCTemporaryJournal_DetailedEntity.ACAccountGroupName = String.Empty; } else { aCTemporaryJournal_DetailedEntity.ACAccountGroupName = reader.GetString(FLD_ACACCOUNTGROUPNAME); }
            if (reader.IsDBNull(FLD_ACCLASSNAME)) { aCTemporaryJournal_DetailedEntity.ACClassName = String.Empty; } else { aCTemporaryJournal_DetailedEntity.ACClassName = reader.GetString(FLD_ACCLASSNAME); }
            if (reader.IsDBNull(FLD_ACCLASSTYPENAME)) { aCTemporaryJournal_DetailedEntity.ACClassTypeName = String.Empty; } else { aCTemporaryJournal_DetailedEntity.ACClassTypeName = reader.GetString(FLD_ACCLASSTYPENAME); }
            if (reader.IsDBNull(FLD_HREMPLOYEEMEMBERID)) { aCTemporaryJournal_DetailedEntity.HREmployeeMemberID = null; } else { aCTemporaryJournal_DetailedEntity.HREmployeeMemberID = reader.GetInt64(FLD_HREMPLOYEEMEMBERID); }
            if (reader.IsDBNull(FLD_ACMDDEBITCREDITNAME)) { aCTemporaryJournal_DetailedEntity.ACMDDebitCreditName = String.Empty; } else { aCTemporaryJournal_DetailedEntity.ACMDDebitCreditName = reader.GetString(FLD_ACMDDEBITCREDITNAME); }
            if (reader.IsDBNull(FLD_ACDIMENSIONNAME)) { aCTemporaryJournal_DetailedEntity.ACDimensionName = String.Empty; } else { aCTemporaryJournal_DetailedEntity.ACDimensionName = reader.GetString(FLD_ACDIMENSIONNAME); }
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { aCTemporaryJournal_DetailedEntity.BDProjectProjectName = String.Empty; } else { aCTemporaryJournal_DetailedEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_ACFISCALYEAR)) { aCTemporaryJournal_DetailedEntity.ACFiscalYear = String.Empty; } else { aCTemporaryJournal_DetailedEntity.ACFiscalYear = reader.GetString(FLD_ACFISCALYEAR); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCTemporaryJournal_DetailedEntity.MemberFullName = String.Empty; } else { aCTemporaryJournal_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCTemporaryJournal_DetailedEntity.RequisitionID = null; } else { aCTemporaryJournal_DetailedEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCTemporaryJournal_DetailedEntity.WorkOrderID = null; } else { aCTemporaryJournal_DetailedEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCTemporaryJournal_DetailedEntity.BillID = null; } else { aCTemporaryJournal_DetailedEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCTemporaryJournal_DetailedEntity.ProjectFloorID = null; } else { aCTemporaryJournal_DetailedEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCTemporaryJournal_DetailedEntity.ProjectFloorUnitID = null; } else { aCTemporaryJournal_DetailedEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCTemporaryJournal_DetailedEntity.BillNo = String.Empty; } else { aCTemporaryJournal_DetailedEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCTemporaryJournal_DetailedEntity.RequisitionNo = String.Empty; } else { aCTemporaryJournal_DetailedEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { aCTemporaryJournal_DetailedEntity.ProjectFloorName = String.Empty; } else { aCTemporaryJournal_DetailedEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCTemporaryJournal_DetailedEntity.WorkOrderNo = String.Empty; } else { aCTemporaryJournal_DetailedEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { aCTemporaryJournal_DetailedEntity.ProjectFloorUnitName = String.Empty; } else { aCTemporaryJournal_DetailedEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCTemporaryJournal_DetailedEntity.ItemID = null; } else { aCTemporaryJournal_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { aCTemporaryJournal_DetailedEntity.ItemName = String.Empty; } else { aCTemporaryJournal_DetailedEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCTemporaryJournal_DetailedEntity.RowNumber = null; } else { aCTemporaryJournal_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCTemporaryJournal_DetailedEntity;
        }
    }
}
