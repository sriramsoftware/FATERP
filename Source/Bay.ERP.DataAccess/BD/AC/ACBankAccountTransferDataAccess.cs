// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 09:29:16




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
    internal sealed partial class ACBankAccountTransferDataAccess : BaseDataAccess, IACBankAccountTransferDataAccess
    {
        #region Constructors

        public ACBankAccountTransferDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACBankAccountTransferEntity> CreateEntityBuilder<ACBankAccountTransferEntity>()
        {
            return (new ACBankAccountTransferBuilder()) as IEntityBuilder<ACBankAccountTransferEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACBankAccountTransferDataAccess.Add(ACBankAccountTransferEntity aCBankAccountTransferEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCBankAccountTransferEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCBankAccountTransferEntity, option);
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

        private Int64 Add(ACBankAccountTransferEntity aCBankAccountTransferEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountTransfer_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BankAccountTransferID");

                Database.AddInParameter(cmd, "@FromBankAccountID", DbType.Int64, aCBankAccountTransferEntity.FromBankAccountID);	
                Database.AddInParameter(cmd, "@ToBankAccountID", DbType.Int64, aCBankAccountTransferEntity.ToBankAccountID);	
                Database.AddInParameter(cmd, "@TransferDate", DbType.DateTime, aCBankAccountTransferEntity.TransferDate);	
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, aCBankAccountTransferEntity.Amount);	
                Database.AddInParameter(cmd, "@BankCharge", DbType.Decimal, aCBankAccountTransferEntity.BankCharge);	
                Database.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountTransferEntity.Memo);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCBankAccountTransferEntity.Remarks);	
                Database.AddInParameter(cmd, "@BankAccountTransferApprovalStatusID", DbType.Int64, aCBankAccountTransferEntity.BankAccountTransferApprovalStatusID);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, aCBankAccountTransferEntity.CreatedByEmployeeID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountTransferEntity already exists. Please specify another ACBankAccountTransferEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountTransferEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountTransferEntity already exists. Please specify another ACBankAccountTransferEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACBankAccountTransferEntity aCBankAccountTransferEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountTransfer_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BankAccountTransferID", db);

                db.AddInParameter(cmd, "@FromBankAccountID", DbType.Int64, aCBankAccountTransferEntity.FromBankAccountID);
                db.AddInParameter(cmd, "@ToBankAccountID", DbType.Int64, aCBankAccountTransferEntity.ToBankAccountID);
                db.AddInParameter(cmd, "@TransferDate", DbType.DateTime, aCBankAccountTransferEntity.TransferDate);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, aCBankAccountTransferEntity.Amount);
                db.AddInParameter(cmd, "@BankCharge", DbType.Decimal, aCBankAccountTransferEntity.BankCharge);
                db.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountTransferEntity.Memo);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCBankAccountTransferEntity.Remarks);
                db.AddInParameter(cmd, "@BankAccountTransferApprovalStatusID", DbType.Int64, aCBankAccountTransferEntity.BankAccountTransferApprovalStatusID);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, aCBankAccountTransferEntity.CreatedByEmployeeID);

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

        IList<Int64> IACBankAccountTransferDataAccess.Add(IList<ACBankAccountTransferEntity> aCBankAccountTransferEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACBankAccountTransferEntity aCBankAccountTransferEntity in aCBankAccountTransferEntityList)
            {
                returnCode = (this as IACBankAccountTransferDataAccess).Add(aCBankAccountTransferEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACBankAccountTransferDataAccess.Update(ACBankAccountTransferEntity aCBankAccountTransferEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCBankAccountTransferEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCBankAccountTransferEntity, filterExpression, option);
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

        private Int64 Update(ACBankAccountTransferEntity aCBankAccountTransferEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountTransfer_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BankAccountTransferID", DbType.Int64, aCBankAccountTransferEntity.BankAccountTransferID);
                Database.AddInParameter(cmd, "@FromBankAccountID", DbType.Int64, aCBankAccountTransferEntity.FromBankAccountID);
                Database.AddInParameter(cmd, "@ToBankAccountID", DbType.Int64, aCBankAccountTransferEntity.ToBankAccountID);
                Database.AddInParameter(cmd, "@TransferDate", DbType.DateTime, aCBankAccountTransferEntity.TransferDate);
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, aCBankAccountTransferEntity.Amount);
                Database.AddInParameter(cmd, "@BankCharge", DbType.Decimal, aCBankAccountTransferEntity.BankCharge);
                Database.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountTransferEntity.Memo);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCBankAccountTransferEntity.Remarks);
                Database.AddInParameter(cmd, "@BankAccountTransferApprovalStatusID", DbType.Int64, aCBankAccountTransferEntity.BankAccountTransferApprovalStatusID);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, aCBankAccountTransferEntity.CreatedByEmployeeID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountTransferEntity already exists. Please specify another ACBankAccountTransferEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountTransferEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountTransferEntity already exists. Please specify another ACBankAccountTransferEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACBankAccountTransferEntity aCBankAccountTransferEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountTransfer_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BankAccountTransferID", DbType.Int64, aCBankAccountTransferEntity.BankAccountTransferID);
                db.AddInParameter(cmd, "@FromBankAccountID", DbType.Int64, aCBankAccountTransferEntity.FromBankAccountID);
                db.AddInParameter(cmd, "@ToBankAccountID", DbType.Int64, aCBankAccountTransferEntity.ToBankAccountID);
                db.AddInParameter(cmd, "@TransferDate", DbType.DateTime, aCBankAccountTransferEntity.TransferDate);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, aCBankAccountTransferEntity.Amount);
                db.AddInParameter(cmd, "@BankCharge", DbType.Decimal, aCBankAccountTransferEntity.BankCharge);
                db.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountTransferEntity.Memo);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCBankAccountTransferEntity.Remarks);
                db.AddInParameter(cmd, "@BankAccountTransferApprovalStatusID", DbType.Int64, aCBankAccountTransferEntity.BankAccountTransferApprovalStatusID);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, aCBankAccountTransferEntity.CreatedByEmployeeID);

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

        IList<Int64> IACBankAccountTransferDataAccess.Update(IList<ACBankAccountTransferEntity> aCBankAccountTransferEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACBankAccountTransferEntity aCBankAccountTransferEntity in aCBankAccountTransferEntityList)
            {
                returnCode = (this as IACBankAccountTransferDataAccess).Update(aCBankAccountTransferEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACBankAccountTransferDataAccess.Delete(ACBankAccountTransferEntity aCBankAccountTransferEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCBankAccountTransferEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCBankAccountTransferEntity, filterExpression, option);
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

        private Int64 Delete(ACBankAccountTransferEntity aCBankAccountTransferEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountTransfer_SET";

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
                                throw new ArgumentException("ACBankAccountTransferEntity already exists. Please specify another ACBankAccountTransferEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountTransferEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountTransferEntity already exists. Please specify another ACBankAccountTransferEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACBankAccountTransferEntity aCBankAccountTransferEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountTransfer_SET";

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

        IList<Int64> IACBankAccountTransferDataAccess.Delete(IList<ACBankAccountTransferEntity> aCBankAccountTransferEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACBankAccountTransferEntity aCBankAccountTransferEntity in aCBankAccountTransferEntityList)
            {
                returnCode = (this as IACBankAccountTransferDataAccess).Delete(aCBankAccountTransferEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACBankAccountTransferEntity> IACBankAccountTransferDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACBankAccountTransfer_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACBankAccountTransferEntity> list = CreateEntityBuilder<ACBankAccountTransferEntity>().BuildEntities(reader);

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

        DataTable IACBankAccountTransferDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACBankAccountTransfer_GET";

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
