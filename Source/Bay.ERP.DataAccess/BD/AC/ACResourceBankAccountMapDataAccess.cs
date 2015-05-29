// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Jun-2013, 05:04:04




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
    internal sealed partial class ACResourceBankAccountMapDataAccess : BaseDataAccess, IACResourceBankAccountMapDataAccess
    {
        #region Constructors

        public ACResourceBankAccountMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACResourceBankAccountMapEntity> CreateEntityBuilder<ACResourceBankAccountMapEntity>()
        {
            return (new ACResourceBankAccountMapBuilder()) as IEntityBuilder<ACResourceBankAccountMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACResourceBankAccountMapDataAccess.Add(ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCResourceBankAccountMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCResourceBankAccountMapEntity, option);
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

        private Int64 Add(ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACResourceBankAccountMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ResourceBankAccountMapID");

                Database.AddInParameter(cmd, "@AccountResourceCategoryID", DbType.Int64, aCResourceBankAccountMapEntity.AccountResourceCategoryID);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCResourceBankAccountMapEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@BankAccountName", DbType.String, aCResourceBankAccountMapEntity.BankAccountName);	
                Database.AddInParameter(cmd, "@BankAccountNumber", DbType.String, aCResourceBankAccountMapEntity.BankAccountNumber);	
                Database.AddInParameter(cmd, "@IsDefaultCurrencyAccount", DbType.Boolean, aCResourceBankAccountMapEntity.IsDefaultCurrencyAccount);	
                Database.AddInParameter(cmd, "@BankName", DbType.String, aCResourceBankAccountMapEntity.BankName);	
                Database.AddInParameter(cmd, "@BankAddress", DbType.String, aCResourceBankAccountMapEntity.BankAddress);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCResourceBankAccountMapEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACResourceBankAccountMapEntity already exists. Please specify another ACResourceBankAccountMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACResourceBankAccountMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACResourceBankAccountMapEntity already exists. Please specify another ACResourceBankAccountMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACResourceBankAccountMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ResourceBankAccountMapID", db);

                db.AddInParameter(cmd, "@AccountResourceCategoryID", DbType.Int64, aCResourceBankAccountMapEntity.AccountResourceCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCResourceBankAccountMapEntity.ReferenceID);
                db.AddInParameter(cmd, "@BankAccountName", DbType.String, aCResourceBankAccountMapEntity.BankAccountName);
                db.AddInParameter(cmd, "@BankAccountNumber", DbType.String, aCResourceBankAccountMapEntity.BankAccountNumber);
                db.AddInParameter(cmd, "@IsDefaultCurrencyAccount", DbType.Boolean, aCResourceBankAccountMapEntity.IsDefaultCurrencyAccount);
                db.AddInParameter(cmd, "@BankName", DbType.String, aCResourceBankAccountMapEntity.BankName);
                db.AddInParameter(cmd, "@BankAddress", DbType.String, aCResourceBankAccountMapEntity.BankAddress);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCResourceBankAccountMapEntity.Remarks);

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

        IList<Int64> IACResourceBankAccountMapDataAccess.Add(IList<ACResourceBankAccountMapEntity> aCResourceBankAccountMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity in aCResourceBankAccountMapEntityList)
            {
                returnCode = (this as IACResourceBankAccountMapDataAccess).Add(aCResourceBankAccountMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACResourceBankAccountMapDataAccess.Update(ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCResourceBankAccountMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCResourceBankAccountMapEntity, filterExpression, option);
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

        private Int64 Update(ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACResourceBankAccountMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ResourceBankAccountMapID", DbType.Int64, aCResourceBankAccountMapEntity.ResourceBankAccountMapID);
                Database.AddInParameter(cmd, "@AccountResourceCategoryID", DbType.Int64, aCResourceBankAccountMapEntity.AccountResourceCategoryID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCResourceBankAccountMapEntity.ReferenceID);
                Database.AddInParameter(cmd, "@BankAccountName", DbType.String, aCResourceBankAccountMapEntity.BankAccountName);
                Database.AddInParameter(cmd, "@BankAccountNumber", DbType.String, aCResourceBankAccountMapEntity.BankAccountNumber);
                Database.AddInParameter(cmd, "@IsDefaultCurrencyAccount", DbType.Boolean, aCResourceBankAccountMapEntity.IsDefaultCurrencyAccount);
                Database.AddInParameter(cmd, "@BankName", DbType.String, aCResourceBankAccountMapEntity.BankName);
                Database.AddInParameter(cmd, "@BankAddress", DbType.String, aCResourceBankAccountMapEntity.BankAddress);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCResourceBankAccountMapEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACResourceBankAccountMapEntity already exists. Please specify another ACResourceBankAccountMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACResourceBankAccountMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACResourceBankAccountMapEntity already exists. Please specify another ACResourceBankAccountMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACResourceBankAccountMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ResourceBankAccountMapID", DbType.Int64, aCResourceBankAccountMapEntity.ResourceBankAccountMapID);
                db.AddInParameter(cmd, "@AccountResourceCategoryID", DbType.Int64, aCResourceBankAccountMapEntity.AccountResourceCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCResourceBankAccountMapEntity.ReferenceID);
                db.AddInParameter(cmd, "@BankAccountName", DbType.String, aCResourceBankAccountMapEntity.BankAccountName);
                db.AddInParameter(cmd, "@BankAccountNumber", DbType.String, aCResourceBankAccountMapEntity.BankAccountNumber);
                db.AddInParameter(cmd, "@IsDefaultCurrencyAccount", DbType.Boolean, aCResourceBankAccountMapEntity.IsDefaultCurrencyAccount);
                db.AddInParameter(cmd, "@BankName", DbType.String, aCResourceBankAccountMapEntity.BankName);
                db.AddInParameter(cmd, "@BankAddress", DbType.String, aCResourceBankAccountMapEntity.BankAddress);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCResourceBankAccountMapEntity.Remarks);

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

        IList<Int64> IACResourceBankAccountMapDataAccess.Update(IList<ACResourceBankAccountMapEntity> aCResourceBankAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity in aCResourceBankAccountMapEntityList)
            {
                returnCode = (this as IACResourceBankAccountMapDataAccess).Update(aCResourceBankAccountMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACResourceBankAccountMapDataAccess.Delete(ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCResourceBankAccountMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCResourceBankAccountMapEntity, filterExpression, option);
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

        private Int64 Delete(ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACResourceBankAccountMap_SET";

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
                                throw new ArgumentException("ACResourceBankAccountMapEntity already exists. Please specify another ACResourceBankAccountMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACResourceBankAccountMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACResourceBankAccountMapEntity already exists. Please specify another ACResourceBankAccountMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACResourceBankAccountMap_SET";

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

        IList<Int64> IACResourceBankAccountMapDataAccess.Delete(IList<ACResourceBankAccountMapEntity> aCResourceBankAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity in aCResourceBankAccountMapEntityList)
            {
                returnCode = (this as IACResourceBankAccountMapDataAccess).Delete(aCResourceBankAccountMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACResourceBankAccountMapEntity> IACResourceBankAccountMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACResourceBankAccountMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACResourceBankAccountMapEntity> list = CreateEntityBuilder<ACResourceBankAccountMapEntity>().BuildEntities(reader);

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

        DataTable IACResourceBankAccountMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACResourceBankAccountMap_GET";

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
