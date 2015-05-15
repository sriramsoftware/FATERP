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
    internal sealed partial class ACTemporaryJournalDataAccess : BaseDataAccess, IACTemporaryJournalDataAccess
    {
        #region Constructors

        public ACTemporaryJournalDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACTemporaryJournalEntity> CreateEntityBuilder<ACTemporaryJournalEntity>()
        {
            return (new ACTemporaryJournalBuilder()) as IEntityBuilder<ACTemporaryJournalEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACTemporaryJournalDataAccess.Add(ACTemporaryJournalEntity aCTemporaryJournalEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCTemporaryJournalEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCTemporaryJournalEntity, option);
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

        private Int64 Add(ACTemporaryJournalEntity aCTemporaryJournalEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTemporaryJournal_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "TemporaryJournalID");

                Database.AddInParameter(cmd, "@TemporaryJournalMasterID", DbType.Int64, aCTemporaryJournalEntity.TemporaryJournalMasterID);	
                Database.AddInParameter(cmd, "@AccountID", DbType.Int64, aCTemporaryJournalEntity.AccountID);	
                Database.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCTemporaryJournalEntity.AccountGroupID);	
                Database.AddInParameter(cmd, "@ClassID", DbType.Int64, aCTemporaryJournalEntity.ClassID);	
                Database.AddInParameter(cmd, "@ClassTypeID", DbType.Int64, aCTemporaryJournalEntity.ClassTypeID);	
                Database.AddInParameter(cmd, "@TransactionDateTime", DbType.DateTime, aCTemporaryJournalEntity.TransactionDateTime);	
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, aCTemporaryJournalEntity.Amount);	
                Database.AddInParameter(cmd, "@EnteredByEmployeeID", DbType.Int64, aCTemporaryJournalEntity.EnteredByEmployeeID);	
                Database.AddInParameter(cmd, "@ReferenceOrMemoOrID", DbType.String, aCTemporaryJournalEntity.ReferenceOrMemoOrID);	
                Database.AddInParameter(cmd, "@Note", DbType.String, aCTemporaryJournalEntity.Note);	
                Database.AddInParameter(cmd, "@MDDebitCreditID", DbType.Int64, aCTemporaryJournalEntity.MDDebitCreditID);	
                Database.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCTemporaryJournalEntity.DimensionID);	
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, aCTemporaryJournalEntity.ItemID);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCTemporaryJournalEntity.ProjectID);	
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, aCTemporaryJournalEntity.FiscalYearID);	
                Database.AddInParameter(cmd, "@IsReverseTransaction", DbType.Boolean, aCTemporaryJournalEntity.IsReverseTransaction);	
                Database.AddInParameter(cmd, "@ReverseTransactionJournalID", DbType.Int64, aCTemporaryJournalEntity.ReverseTransactionJournalID);	
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCTemporaryJournalEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCTemporaryJournalEntity.WorkOrderID);	
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, aCTemporaryJournalEntity.BillID);	
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCTemporaryJournalEntity.ProjectFloorID);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCTemporaryJournalEntity.ProjectFloorUnitID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACTemporaryJournalEntity already exists. Please specify another ACTemporaryJournalEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTemporaryJournalEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTemporaryJournalEntity already exists. Please specify another ACTemporaryJournalEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACTemporaryJournalEntity aCTemporaryJournalEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTemporaryJournal_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "TemporaryJournalID", db);

                db.AddInParameter(cmd, "@TemporaryJournalMasterID", DbType.Int64, aCTemporaryJournalEntity.TemporaryJournalMasterID);
                db.AddInParameter(cmd, "@AccountID", DbType.Int64, aCTemporaryJournalEntity.AccountID);
                db.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCTemporaryJournalEntity.AccountGroupID);
                db.AddInParameter(cmd, "@ClassID", DbType.Int64, aCTemporaryJournalEntity.ClassID);
                db.AddInParameter(cmd, "@ClassTypeID", DbType.Int64, aCTemporaryJournalEntity.ClassTypeID);
                db.AddInParameter(cmd, "@TransactionDateTime", DbType.DateTime, aCTemporaryJournalEntity.TransactionDateTime);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, aCTemporaryJournalEntity.Amount);
                db.AddInParameter(cmd, "@EnteredByEmployeeID", DbType.Int64, aCTemporaryJournalEntity.EnteredByEmployeeID);
                db.AddInParameter(cmd, "@ReferenceOrMemoOrID", DbType.String, aCTemporaryJournalEntity.ReferenceOrMemoOrID);
                db.AddInParameter(cmd, "@Note", DbType.String, aCTemporaryJournalEntity.Note);
                db.AddInParameter(cmd, "@MDDebitCreditID", DbType.Int64, aCTemporaryJournalEntity.MDDebitCreditID);
                db.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCTemporaryJournalEntity.DimensionID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, aCTemporaryJournalEntity.ItemID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCTemporaryJournalEntity.ProjectID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, aCTemporaryJournalEntity.FiscalYearID);
                db.AddInParameter(cmd, "@IsReverseTransaction", DbType.Boolean, aCTemporaryJournalEntity.IsReverseTransaction);
                db.AddInParameter(cmd, "@ReverseTransactionJournalID", DbType.Int64, aCTemporaryJournalEntity.ReverseTransactionJournalID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCTemporaryJournalEntity.RequisitionID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCTemporaryJournalEntity.WorkOrderID);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, aCTemporaryJournalEntity.BillID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCTemporaryJournalEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCTemporaryJournalEntity.ProjectFloorUnitID);

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

        IList<Int64> IACTemporaryJournalDataAccess.Add(IList<ACTemporaryJournalEntity> aCTemporaryJournalEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACTemporaryJournalEntity aCTemporaryJournalEntity in aCTemporaryJournalEntityList)
            {
                returnCode = (this as IACTemporaryJournalDataAccess).Add(aCTemporaryJournalEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACTemporaryJournalDataAccess.Update(ACTemporaryJournalEntity aCTemporaryJournalEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCTemporaryJournalEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCTemporaryJournalEntity, filterExpression, option);
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

        private Int64 Update(ACTemporaryJournalEntity aCTemporaryJournalEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTemporaryJournal_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@TemporaryJournalID", DbType.Int64, aCTemporaryJournalEntity.TemporaryJournalID);
                Database.AddInParameter(cmd, "@TemporaryJournalMasterID", DbType.Int64, aCTemporaryJournalEntity.TemporaryJournalMasterID);
                Database.AddInParameter(cmd, "@AccountID", DbType.Int64, aCTemporaryJournalEntity.AccountID);
                Database.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCTemporaryJournalEntity.AccountGroupID);
                Database.AddInParameter(cmd, "@ClassID", DbType.Int64, aCTemporaryJournalEntity.ClassID);
                Database.AddInParameter(cmd, "@ClassTypeID", DbType.Int64, aCTemporaryJournalEntity.ClassTypeID);
                Database.AddInParameter(cmd, "@TransactionDateTime", DbType.DateTime, aCTemporaryJournalEntity.TransactionDateTime);
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, aCTemporaryJournalEntity.Amount);
                Database.AddInParameter(cmd, "@EnteredByEmployeeID", DbType.Int64, aCTemporaryJournalEntity.EnteredByEmployeeID);
                Database.AddInParameter(cmd, "@ReferenceOrMemoOrID", DbType.String, aCTemporaryJournalEntity.ReferenceOrMemoOrID);
                Database.AddInParameter(cmd, "@Note", DbType.String, aCTemporaryJournalEntity.Note);
                Database.AddInParameter(cmd, "@MDDebitCreditID", DbType.Int64, aCTemporaryJournalEntity.MDDebitCreditID);
                Database.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCTemporaryJournalEntity.DimensionID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, aCTemporaryJournalEntity.ItemID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCTemporaryJournalEntity.ProjectID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, aCTemporaryJournalEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@IsReverseTransaction", DbType.Boolean, aCTemporaryJournalEntity.IsReverseTransaction);
                Database.AddInParameter(cmd, "@ReverseTransactionJournalID", DbType.Int64, aCTemporaryJournalEntity.ReverseTransactionJournalID);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCTemporaryJournalEntity.RequisitionID);
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCTemporaryJournalEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, aCTemporaryJournalEntity.BillID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCTemporaryJournalEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCTemporaryJournalEntity.ProjectFloorUnitID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACTemporaryJournalEntity already exists. Please specify another ACTemporaryJournalEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTemporaryJournalEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTemporaryJournalEntity already exists. Please specify another ACTemporaryJournalEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACTemporaryJournalEntity aCTemporaryJournalEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTemporaryJournal_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@TemporaryJournalID", DbType.Int64, aCTemporaryJournalEntity.TemporaryJournalID);
                db.AddInParameter(cmd, "@TemporaryJournalMasterID", DbType.Int64, aCTemporaryJournalEntity.TemporaryJournalMasterID);
                db.AddInParameter(cmd, "@AccountID", DbType.Int64, aCTemporaryJournalEntity.AccountID);
                db.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCTemporaryJournalEntity.AccountGroupID);
                db.AddInParameter(cmd, "@ClassID", DbType.Int64, aCTemporaryJournalEntity.ClassID);
                db.AddInParameter(cmd, "@ClassTypeID", DbType.Int64, aCTemporaryJournalEntity.ClassTypeID);
                db.AddInParameter(cmd, "@TransactionDateTime", DbType.DateTime, aCTemporaryJournalEntity.TransactionDateTime);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, aCTemporaryJournalEntity.Amount);
                db.AddInParameter(cmd, "@EnteredByEmployeeID", DbType.Int64, aCTemporaryJournalEntity.EnteredByEmployeeID);
                db.AddInParameter(cmd, "@ReferenceOrMemoOrID", DbType.String, aCTemporaryJournalEntity.ReferenceOrMemoOrID);
                db.AddInParameter(cmd, "@Note", DbType.String, aCTemporaryJournalEntity.Note);
                db.AddInParameter(cmd, "@MDDebitCreditID", DbType.Int64, aCTemporaryJournalEntity.MDDebitCreditID);
                db.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCTemporaryJournalEntity.DimensionID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, aCTemporaryJournalEntity.ItemID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCTemporaryJournalEntity.ProjectID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, aCTemporaryJournalEntity.FiscalYearID);
                db.AddInParameter(cmd, "@IsReverseTransaction", DbType.Boolean, aCTemporaryJournalEntity.IsReverseTransaction);
                db.AddInParameter(cmd, "@ReverseTransactionJournalID", DbType.Int64, aCTemporaryJournalEntity.ReverseTransactionJournalID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCTemporaryJournalEntity.RequisitionID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCTemporaryJournalEntity.WorkOrderID);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, aCTemporaryJournalEntity.BillID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCTemporaryJournalEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCTemporaryJournalEntity.ProjectFloorUnitID);

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

        IList<Int64> IACTemporaryJournalDataAccess.Update(IList<ACTemporaryJournalEntity> aCTemporaryJournalEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACTemporaryJournalEntity aCTemporaryJournalEntity in aCTemporaryJournalEntityList)
            {
                returnCode = (this as IACTemporaryJournalDataAccess).Update(aCTemporaryJournalEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACTemporaryJournalDataAccess.Delete(ACTemporaryJournalEntity aCTemporaryJournalEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCTemporaryJournalEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCTemporaryJournalEntity, filterExpression, option);
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

        private Int64 Delete(ACTemporaryJournalEntity aCTemporaryJournalEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTemporaryJournal_SET";

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
                                throw new ArgumentException("ACTemporaryJournalEntity already exists. Please specify another ACTemporaryJournalEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTemporaryJournalEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTemporaryJournalEntity already exists. Please specify another ACTemporaryJournalEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACTemporaryJournalEntity aCTemporaryJournalEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTemporaryJournal_SET";

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

        IList<Int64> IACTemporaryJournalDataAccess.Delete(IList<ACTemporaryJournalEntity> aCTemporaryJournalEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACTemporaryJournalEntity aCTemporaryJournalEntity in aCTemporaryJournalEntityList)
            {
                returnCode = (this as IACTemporaryJournalDataAccess).Delete(aCTemporaryJournalEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACTemporaryJournalEntity> IACTemporaryJournalDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACTemporaryJournal_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACTemporaryJournalEntity> list = CreateEntityBuilder<ACTemporaryJournalEntity>().BuildEntities(reader);

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

        DataTable IACTemporaryJournalDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACTemporaryJournal_GET";

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
