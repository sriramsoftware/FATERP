// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jul-2013, 02:08:47




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACJournal_DetailedBuilder : IEntityBuilder<ACJournal_DetailedEntity>
    {
        IList<ACJournal_DetailedEntity> IEntityBuilder<ACJournal_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACJournal_DetailedEntity> ACJournal_DetailedEntityList = new List<ACJournal_DetailedEntity>();

            while (reader.Read())
            {
                ACJournal_DetailedEntityList.Add(((IEntityBuilder<ACJournal_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACJournal_DetailedEntityList.Count > 0) ? ACJournal_DetailedEntityList : null;
        }

        ACJournal_DetailedEntity IEntityBuilder<ACJournal_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_PROJECTID = 12;
            const Int32 FLD_FISCALYEARID = 13;
            const Int32 FLD_ISREVERSETRANSACTION = 14;
            const Int32 FLD_REVERSETRANSACTIONJOURNALID = 15;
            const Int32 FLD_VOUCHERTYPE = 16;
            const Int32 FLD_ACCOUNTCODE = 17;
            const Int32 FLD_ACACCOUNTACCOUNTNAME = 18;
            const Int32 FLD_ACACCOUNTGROUPNAME = 19;
            const Int32 FLD_ACCLASSNAME = 20;
            const Int32 FLD_ACCLASSTYPENAME = 21;
            const Int32 FLD_HREMPLOYEEMEMBERID = 22;
            const Int32 FLD_ACMDDEBITCREDITNAME = 23;
            const Int32 FLD_ACDIMENSIONNAME = 24;
            const Int32 FLD_BDPROJECTPROJECTNAME = 25;
            const Int32 FLD_ACFISCALYEAR = 26;
            const Int32 FLD_MEMBERFULLNAME = 27;
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

            ACJournal_DetailedEntity aCJournal_DetailedEntity = new ACJournal_DetailedEntity();

            aCJournal_DetailedEntity.JournalID = reader.GetInt64(FLD_JOURNALID);
            aCJournal_DetailedEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCJournal_DetailedEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID);
            aCJournal_DetailedEntity.ClassID = reader.GetInt64(FLD_CLASSID);
            aCJournal_DetailedEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID);
            aCJournal_DetailedEntity.TransactionDateTime = reader.GetDateTime(FLD_TRANSACTIONDATETIME);
            aCJournal_DetailedEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            aCJournal_DetailedEntity.EnteredByEmployeeID = reader.GetInt64(FLD_ENTEREDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_REFERENCEORMEMOORID)) { aCJournal_DetailedEntity.ReferenceOrMemoOrID = String.Empty; } else { aCJournal_DetailedEntity.ReferenceOrMemoOrID = reader.GetString(FLD_REFERENCEORMEMOORID); }
            if (reader.IsDBNull(FLD_NOTE)) { aCJournal_DetailedEntity.Note = String.Empty; } else { aCJournal_DetailedEntity.Note = reader.GetString(FLD_NOTE); }
            aCJournal_DetailedEntity.MDDebitCreditID = reader.GetInt64(FLD_MDDEBITCREDITID);
            if (reader.IsDBNull(FLD_DIMENSIONID)) { aCJournal_DetailedEntity.DimensionID = null; } else { aCJournal_DetailedEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCJournal_DetailedEntity.ProjectID = null; } else { aCJournal_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            aCJournal_DetailedEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            if (reader.IsDBNull(FLD_ISREVERSETRANSACTION)) { aCJournal_DetailedEntity.IsReverseTransaction = false; } else { aCJournal_DetailedEntity.IsReverseTransaction = reader.GetBoolean(FLD_ISREVERSETRANSACTION); }
            if (reader.IsDBNull(FLD_REVERSETRANSACTIONJOURNALID)) { aCJournal_DetailedEntity.ReverseTransactionJournalID = null; } else { aCJournal_DetailedEntity.ReverseTransactionJournalID = reader.GetInt64(FLD_REVERSETRANSACTIONJOURNALID); }
            if (reader.IsDBNull(FLD_VOUCHERTYPE)) { aCJournal_DetailedEntity.VoucherType = String.Empty; } else { aCJournal_DetailedEntity.VoucherType = reader.GetString(FLD_VOUCHERTYPE); }
            if (reader.IsDBNull(FLD_ACCOUNTCODE)) { aCJournal_DetailedEntity.AccountCode = String.Empty; } else { aCJournal_DetailedEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE); }
            if (reader.IsDBNull(FLD_ACACCOUNTACCOUNTNAME)) { aCJournal_DetailedEntity.ACAccountAccountName = String.Empty; } else { aCJournal_DetailedEntity.ACAccountAccountName = reader.GetString(FLD_ACACCOUNTACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACACCOUNTGROUPNAME)) { aCJournal_DetailedEntity.ACAccountGroupName = String.Empty; } else { aCJournal_DetailedEntity.ACAccountGroupName = reader.GetString(FLD_ACACCOUNTGROUPNAME); }
            if (reader.IsDBNull(FLD_ACCLASSNAME)) { aCJournal_DetailedEntity.ACClassName = String.Empty; } else { aCJournal_DetailedEntity.ACClassName = reader.GetString(FLD_ACCLASSNAME); }
            if (reader.IsDBNull(FLD_ACCLASSTYPENAME)) { aCJournal_DetailedEntity.ACClassTypeName = String.Empty; } else { aCJournal_DetailedEntity.ACClassTypeName = reader.GetString(FLD_ACCLASSTYPENAME); }
            if (reader.IsDBNull(FLD_HREMPLOYEEMEMBERID)) { aCJournal_DetailedEntity.HREmployeeMemberID = null; } else { aCJournal_DetailedEntity.HREmployeeMemberID = reader.GetInt64(FLD_HREMPLOYEEMEMBERID); }
            if (reader.IsDBNull(FLD_ACMDDEBITCREDITNAME)) { aCJournal_DetailedEntity.ACMDDebitCreditName = String.Empty; } else { aCJournal_DetailedEntity.ACMDDebitCreditName = reader.GetString(FLD_ACMDDEBITCREDITNAME); }
            if (reader.IsDBNull(FLD_ACDIMENSIONNAME)) { aCJournal_DetailedEntity.ACDimensionName = String.Empty; } else { aCJournal_DetailedEntity.ACDimensionName = reader.GetString(FLD_ACDIMENSIONNAME); }
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { aCJournal_DetailedEntity.BDProjectProjectName = String.Empty; } else { aCJournal_DetailedEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_ACFISCALYEAR)) { aCJournal_DetailedEntity.ACFiscalYear = String.Empty; } else { aCJournal_DetailedEntity.ACFiscalYear = reader.GetString(FLD_ACFISCALYEAR); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCJournal_DetailedEntity.MemberFullName = String.Empty; } else { aCJournal_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCJournal_DetailedEntity.WorkOrderID = null; } else { aCJournal_DetailedEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCJournal_DetailedEntity.BillID = null; } else { aCJournal_DetailedEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCJournal_DetailedEntity.ProjectFloorID = null; } else { aCJournal_DetailedEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCJournal_DetailedEntity.ProjectFloorUnitID = null; } else { aCJournal_DetailedEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCJournal_DetailedEntity.BillNo = String.Empty; } else { aCJournal_DetailedEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCJournal_DetailedEntity.RequisitionNo = String.Empty; } else { aCJournal_DetailedEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { aCJournal_DetailedEntity.ProjectFloorName = String.Empty; } else { aCJournal_DetailedEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCJournal_DetailedEntity.WorkOrderNo = String.Empty; } else { aCJournal_DetailedEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { aCJournal_DetailedEntity.ProjectFloorUnitName = String.Empty; } else { aCJournal_DetailedEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCJournal_DetailedEntity.ItemID = null; } else { aCJournal_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { aCJournal_DetailedEntity.ItemName = String.Empty; } else { aCJournal_DetailedEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCJournal_DetailedEntity.RowNumber = null; } else { aCJournal_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCJournal_DetailedEntity;
        }
    }
}
