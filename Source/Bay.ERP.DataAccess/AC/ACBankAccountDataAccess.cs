// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




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
    internal sealed partial class ACBankAccountDataAccess : BaseDataAccess, IACBankAccountDataAccess
    {
        #region Constructors

        public ACBankAccountDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACBankAccountEntity> CreateEntityBuilder<ACBankAccountEntity>()
        {
            return (new ACBankAccountBuilder()) as IEntityBuilder<ACBankAccountEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACBankAccountDataAccess.Add(ACBankAccountEntity aCBankAccountEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCBankAccountEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCBankAccountEntity, option);
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

        private Int64 Add(ACBankAccountEntity aCBankAccountEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccount_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BankAccountID");

                Database.AddInParameter(cmd, "@ACCAccountID", DbType.Int64, aCBankAccountEntity.ACCAccountID);	
                Database.AddInParameter(cmd, "@BankAccountName", DbType.String, aCBankAccountEntity.BankAccountName);	
                Database.AddInParameter(cmd, "@BankAccountNumber", DbType.String, aCBankAccountEntity.BankAccountNumber);	
                Database.AddInParameter(cmd, "@BankAccountTypeID", DbType.Int64, aCBankAccountEntity.BankAccountTypeID);	
                Database.AddInParameter(cmd, "@CurrencyID", DbType.Int64, aCBankAccountEntity.CurrencyID);	
                Database.AddInParameter(cmd, "@IsDefaultCurrencyAccount", DbType.Boolean, aCBankAccountEntity.IsDefaultCurrencyAccount);	
                Database.AddInParameter(cmd, "@BankName", DbType.String, aCBankAccountEntity.BankName);	
                Database.AddInParameter(cmd, "@BankAddress", DbType.String, aCBankAccountEntity.BankAddress);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountEntity already exists. Please specify another ACBankAccountEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountEntity already exists. Please specify another ACBankAccountEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACBankAccountEntity aCBankAccountEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccount_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BankAccountID", db);

                db.AddInParameter(cmd, "@ACCAccountID", DbType.Int64, aCBankAccountEntity.ACCAccountID);
                db.AddInParameter(cmd, "@BankAccountName", DbType.String, aCBankAccountEntity.BankAccountName);
                db.AddInParameter(cmd, "@BankAccountNumber", DbType.String, aCBankAccountEntity.BankAccountNumber);
                db.AddInParameter(cmd, "@BankAccountTypeID", DbType.Int64, aCBankAccountEntity.BankAccountTypeID);
                db.AddInParameter(cmd, "@CurrencyID", DbType.Int64, aCBankAccountEntity.CurrencyID);
                db.AddInParameter(cmd, "@IsDefaultCurrencyAccount", DbType.Boolean, aCBankAccountEntity.IsDefaultCurrencyAccount);
                db.AddInParameter(cmd, "@BankName", DbType.String, aCBankAccountEntity.BankName);
                db.AddInParameter(cmd, "@BankAddress", DbType.String, aCBankAccountEntity.BankAddress);

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

        IList<Int64> IACBankAccountDataAccess.Add(IList<ACBankAccountEntity> aCBankAccountEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACBankAccountEntity aCBankAccountEntity in aCBankAccountEntityList)
            {
                returnCode = (this as IACBankAccountDataAccess).Add(aCBankAccountEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACBankAccountDataAccess.Update(ACBankAccountEntity aCBankAccountEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCBankAccountEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCBankAccountEntity, filterExpression, option);
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

        private Int64 Update(ACBankAccountEntity aCBankAccountEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccount_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BankAccountID", DbType.Int64, aCBankAccountEntity.BankAccountID);
                Database.AddInParameter(cmd, "@ACCAccountID", DbType.Int64, aCBankAccountEntity.ACCAccountID);
                Database.AddInParameter(cmd, "@BankAccountName", DbType.String, aCBankAccountEntity.BankAccountName);
                Database.AddInParameter(cmd, "@BankAccountNumber", DbType.String, aCBankAccountEntity.BankAccountNumber);
                Database.AddInParameter(cmd, "@BankAccountTypeID", DbType.Int64, aCBankAccountEntity.BankAccountTypeID);
                Database.AddInParameter(cmd, "@CurrencyID", DbType.Int64, aCBankAccountEntity.CurrencyID);
                Database.AddInParameter(cmd, "@IsDefaultCurrencyAccount", DbType.Boolean, aCBankAccountEntity.IsDefaultCurrencyAccount);
                Database.AddInParameter(cmd, "@BankName", DbType.String, aCBankAccountEntity.BankName);
                Database.AddInParameter(cmd, "@BankAddress", DbType.String, aCBankAccountEntity.BankAddress);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountEntity already exists. Please specify another ACBankAccountEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountEntity already exists. Please specify another ACBankAccountEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACBankAccountEntity aCBankAccountEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccount_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BankAccountID", DbType.Int64, aCBankAccountEntity.BankAccountID);
                db.AddInParameter(cmd, "@ACCAccountID", DbType.Int64, aCBankAccountEntity.ACCAccountID);
                db.AddInParameter(cmd, "@BankAccountName", DbType.String, aCBankAccountEntity.BankAccountName);
                db.AddInParameter(cmd, "@BankAccountNumber", DbType.String, aCBankAccountEntity.BankAccountNumber);
                db.AddInParameter(cmd, "@BankAccountTypeID", DbType.Int64, aCBankAccountEntity.BankAccountTypeID);
                db.AddInParameter(cmd, "@CurrencyID", DbType.Int64, aCBankAccountEntity.CurrencyID);
                db.AddInParameter(cmd, "@IsDefaultCurrencyAccount", DbType.Boolean, aCBankAccountEntity.IsDefaultCurrencyAccount);
                db.AddInParameter(cmd, "@BankName", DbType.String, aCBankAccountEntity.BankName);
                db.AddInParameter(cmd, "@BankAddress", DbType.String, aCBankAccountEntity.BankAddress);

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

        IList<Int64> IACBankAccountDataAccess.Update(IList<ACBankAccountEntity> aCBankAccountEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACBankAccountEntity aCBankAccountEntity in aCBankAccountEntityList)
            {
                returnCode = (this as IACBankAccountDataAccess).Update(aCBankAccountEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACBankAccountDataAccess.Delete(ACBankAccountEntity aCBankAccountEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCBankAccountEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCBankAccountEntity, filterExpression, option);
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

        private Int64 Delete(ACBankAccountEntity aCBankAccountEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccount_SET";

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
                                throw new ArgumentException("ACBankAccountEntity already exists. Please specify another ACBankAccountEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountEntity already exists. Please specify another ACBankAccountEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACBankAccountEntity aCBankAccountEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccount_SET";

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

        IList<Int64> IACBankAccountDataAccess.Delete(IList<ACBankAccountEntity> aCBankAccountEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACBankAccountEntity aCBankAccountEntity in aCBankAccountEntityList)
            {
                returnCode = (this as IACBankAccountDataAccess).Delete(aCBankAccountEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACBankAccountEntity> IACBankAccountDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACBankAccount_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACBankAccountEntity> list = CreateEntityBuilder<ACBankAccountEntity>().BuildEntities(reader);

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

        DataTable IACBankAccountDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACBankAccount_GET";

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
