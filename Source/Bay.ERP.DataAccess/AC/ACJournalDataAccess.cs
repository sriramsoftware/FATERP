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
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;
using Bay.ERP.DataAccess;

namespace Bay.ERP.DataAccess
{
    internal sealed partial class ACJournalDataAccess : BaseDataAccess, IACJournalDataAccess
    {
        #region Constructors

        public ACJournalDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACJournalEntity> CreateEntityBuilder<ACJournalEntity>()
        {
            return (new ACJournalBuilder()) as IEntityBuilder<ACJournalEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACJournalDataAccess.Add(ACJournalEntity aCJournalEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCJournalEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCJournalEntity, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Add(ACJournalEntity aCJournalEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACJournal_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "JournalID");

                Database.AddInParameter(cmd, "@AccountID", DbType.Int64, aCJournalEntity.AccountID);	
                Database.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCJournalEntity.AccountGroupID);	
                Database.AddInParameter(cmd, "@ClassID", DbType.Int64, aCJournalEntity.ClassID);	
                Database.AddInParameter(cmd, "@ClassTypeID", DbType.Int64, aCJournalEntity.ClassTypeID);	
                Database.AddInParameter(cmd, "@TransactionDateTime", DbType.DateTime, aCJournalEntity.TransactionDateTime);	
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, aCJournalEntity.Amount);	
                Database.AddInParameter(cmd, "@EnteredByEmployeeID", DbType.Int64, aCJournalEntity.EnteredByEmployeeID);	
                Database.AddInParameter(cmd, "@ReferenceOrMemoOrID", DbType.String, aCJournalEntity.ReferenceOrMemoOrID);	
                Database.AddInParameter(cmd, "@Note", DbType.String, aCJournalEntity.Note);	
                Database.AddInParameter(cmd, "@MDDebitCreditID", DbType.Int64, aCJournalEntity.MDDebitCreditID);	
                Database.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCJournalEntity.DimensionID);	
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, aCJournalEntity.ItemID);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCJournalEntity.ProjectID);	
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, aCJournalEntity.FiscalYearID);	
                Database.AddInParameter(cmd, "@IsReverseTransaction", DbType.Boolean, aCJournalEntity.IsReverseTransaction);	
                Database.AddInParameter(cmd, "@ReverseTransactionJournalID", DbType.Int64, aCJournalEntity.ReverseTransactionJournalID);	
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCJournalEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCJournalEntity.WorkOrderID);	
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, aCJournalEntity.BillID);	
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCJournalEntity.ProjectFloorID);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCJournalEntity.ProjectFloorUnitID);	
                Database.AddInParameter(cmd, "@VoucherType", DbType.String, aCJournalEntity.VoucherType);	
                Database.AddInParameter(cmd, "@rayan1", DbType.String, aCJournalEntity.rayan1);	
                Database.AddInParameter(cmd, "@rayan2", DbType.String, aCJournalEntity.rayan2);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACJournalEntity already exists. Please specify another ACJournalEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACJournalEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACJournalEntity already exists. Please specify another ACJournalEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACJournalEntity aCJournalEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACJournal_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "JournalID", db);

                db.AddInParameter(cmd, "@AccountID", DbType.Int64, aCJournalEntity.AccountID);
                db.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCJournalEntity.AccountGroupID);
                db.AddInParameter(cmd, "@ClassID", DbType.Int64, aCJournalEntity.ClassID);
                db.AddInParameter(cmd, "@ClassTypeID", DbType.Int64, aCJournalEntity.ClassTypeID);
                db.AddInParameter(cmd, "@TransactionDateTime", DbType.DateTime, aCJournalEntity.TransactionDateTime);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, aCJournalEntity.Amount);
                db.AddInParameter(cmd, "@EnteredByEmployeeID", DbType.Int64, aCJournalEntity.EnteredByEmployeeID);
                db.AddInParameter(cmd, "@ReferenceOrMemoOrID", DbType.String, aCJournalEntity.ReferenceOrMemoOrID);
                db.AddInParameter(cmd, "@Note", DbType.String, aCJournalEntity.Note);
                db.AddInParameter(cmd, "@MDDebitCreditID", DbType.Int64, aCJournalEntity.MDDebitCreditID);
                db.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCJournalEntity.DimensionID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, aCJournalEntity.ItemID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCJournalEntity.ProjectID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, aCJournalEntity.FiscalYearID);
                db.AddInParameter(cmd, "@IsReverseTransaction", DbType.Boolean, aCJournalEntity.IsReverseTransaction);
                db.AddInParameter(cmd, "@ReverseTransactionJournalID", DbType.Int64, aCJournalEntity.ReverseTransactionJournalID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCJournalEntity.RequisitionID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCJournalEntity.WorkOrderID);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, aCJournalEntity.BillID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCJournalEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCJournalEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@VoucherType", DbType.String, aCJournalEntity.VoucherType);
                db.AddInParameter(cmd, "@rayan1", DbType.String, aCJournalEntity.rayan1);
                db.AddInParameter(cmd, "@rayan2", DbType.String, aCJournalEntity.rayan2);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    returnCode = db.ExecuteNonQuery(cmd, transaction);

                    returnCode = GetReturnCodeFromParameter(cmd, db);

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Add Operation

        #region Add List Operation

        IList<Int64> IACJournalDataAccess.Add(IList<ACJournalEntity> aCJournalEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACJournalEntity aCJournalEntity in aCJournalEntityList)
            {
                returnCode = (this as IACJournalDataAccess).Add(aCJournalEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACJournalDataAccess.Update(ACJournalEntity aCJournalEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCJournalEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCJournalEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Update(ACJournalEntity aCJournalEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACJournal_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@JournalID", DbType.Int64, aCJournalEntity.JournalID);
                Database.AddInParameter(cmd, "@AccountID", DbType.Int64, aCJournalEntity.AccountID);
                Database.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCJournalEntity.AccountGroupID);
                Database.AddInParameter(cmd, "@ClassID", DbType.Int64, aCJournalEntity.ClassID);
                Database.AddInParameter(cmd, "@ClassTypeID", DbType.Int64, aCJournalEntity.ClassTypeID);
                Database.AddInParameter(cmd, "@TransactionDateTime", DbType.DateTime, aCJournalEntity.TransactionDateTime);
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, aCJournalEntity.Amount);
                Database.AddInParameter(cmd, "@EnteredByEmployeeID", DbType.Int64, aCJournalEntity.EnteredByEmployeeID);
                Database.AddInParameter(cmd, "@ReferenceOrMemoOrID", DbType.String, aCJournalEntity.ReferenceOrMemoOrID);
                Database.AddInParameter(cmd, "@Note", DbType.String, aCJournalEntity.Note);
                Database.AddInParameter(cmd, "@MDDebitCreditID", DbType.Int64, aCJournalEntity.MDDebitCreditID);
                Database.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCJournalEntity.DimensionID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, aCJournalEntity.ItemID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCJournalEntity.ProjectID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, aCJournalEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@IsReverseTransaction", DbType.Boolean, aCJournalEntity.IsReverseTransaction);
                Database.AddInParameter(cmd, "@ReverseTransactionJournalID", DbType.Int64, aCJournalEntity.ReverseTransactionJournalID);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCJournalEntity.RequisitionID);
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCJournalEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, aCJournalEntity.BillID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCJournalEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCJournalEntity.ProjectFloorUnitID);
                Database.AddInParameter(cmd, "@VoucherType", DbType.String, aCJournalEntity.VoucherType);
                Database.AddInParameter(cmd, "@rayan1", DbType.String, aCJournalEntity.rayan1);
                Database.AddInParameter(cmd, "@rayan2", DbType.String, aCJournalEntity.rayan2);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACJournalEntity already exists. Please specify another ACJournalEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACJournalEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACJournalEntity already exists. Please specify another ACJournalEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACJournalEntity aCJournalEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACJournal_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@JournalID", DbType.Int64, aCJournalEntity.JournalID);
                db.AddInParameter(cmd, "@AccountID", DbType.Int64, aCJournalEntity.AccountID);
                db.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCJournalEntity.AccountGroupID);
                db.AddInParameter(cmd, "@ClassID", DbType.Int64, aCJournalEntity.ClassID);
                db.AddInParameter(cmd, "@ClassTypeID", DbType.Int64, aCJournalEntity.ClassTypeID);
                db.AddInParameter(cmd, "@TransactionDateTime", DbType.DateTime, aCJournalEntity.TransactionDateTime);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, aCJournalEntity.Amount);
                db.AddInParameter(cmd, "@EnteredByEmployeeID", DbType.Int64, aCJournalEntity.EnteredByEmployeeID);
                db.AddInParameter(cmd, "@ReferenceOrMemoOrID", DbType.String, aCJournalEntity.ReferenceOrMemoOrID);
                db.AddInParameter(cmd, "@Note", DbType.String, aCJournalEntity.Note);
                db.AddInParameter(cmd, "@MDDebitCreditID", DbType.Int64, aCJournalEntity.MDDebitCreditID);
                db.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCJournalEntity.DimensionID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, aCJournalEntity.ItemID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCJournalEntity.ProjectID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, aCJournalEntity.FiscalYearID);
                db.AddInParameter(cmd, "@IsReverseTransaction", DbType.Boolean, aCJournalEntity.IsReverseTransaction);
                db.AddInParameter(cmd, "@ReverseTransactionJournalID", DbType.Int64, aCJournalEntity.ReverseTransactionJournalID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCJournalEntity.RequisitionID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCJournalEntity.WorkOrderID);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, aCJournalEntity.BillID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCJournalEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCJournalEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@VoucherType", DbType.String, aCJournalEntity.VoucherType);
                db.AddInParameter(cmd, "@rayan1", DbType.String, aCJournalEntity.rayan1);
                db.AddInParameter(cmd, "@rayan2", DbType.String, aCJournalEntity.rayan2);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }                    

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Update Operation

        #region Update List Operation

        IList<Int64> IACJournalDataAccess.Update(IList<ACJournalEntity> aCJournalEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACJournalEntity aCJournalEntity in aCJournalEntityList)
            {
                returnCode = (this as IACJournalDataAccess).Update(aCJournalEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACJournalDataAccess.Delete(ACJournalEntity aCJournalEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCJournalEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCJournalEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Delete(ACJournalEntity aCJournalEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACJournal_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);


                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACJournalEntity already exists. Please specify another ACJournalEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACJournalEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACJournalEntity already exists. Please specify another ACJournalEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACJournalEntity aCJournalEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACJournal_SET";

            Database db = DatabaseFactory.CreateDatabase();


            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd, db);
                AddFilterExpressionParameter(cmd, filterExpression, db);


                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }

                    if (returnCode >= 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Delete Operation

        #region Delete List Operation

        IList<Int64> IACJournalDataAccess.Delete(IList<ACJournalEntity> aCJournalEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACJournalEntity aCJournalEntity in aCJournalEntityList)
            {
                returnCode = (this as IACJournalDataAccess).Delete(aCJournalEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACJournalEntity> IACJournalDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACJournal_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACJournalEntity> list = CreateEntityBuilder<ACJournalEntity>().BuildEntities(reader);

                        if (list != null && list.Count > 0)
                        {
                            if ((reader.NextResult()) && (reader.Read()))
                            {
                                list[0].TotalRowCount = reader.GetInt32(0);
                            }
                        }

                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        DataTable IACJournalDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACJournal_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddCurrentPageParameter(cmd, currentPage);
                    AddPageSizeParameter(cmd, pageSize);
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    DataSet ds = new DataSet();
                    ds = Database.ExecuteDataSet(cmd);

                    if (ds.Tables.Count > 0)
                    {
                        return (ds.Tables[0]);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
