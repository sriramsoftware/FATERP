// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




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
    internal sealed partial class ACAccountDataAccess : BaseDataAccess, IACAccountDataAccess
    {
        #region Constructors

        public ACAccountDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACAccountEntity> CreateEntityBuilder<ACAccountEntity>()
        {
            return (new ACAccountBuilder()) as IEntityBuilder<ACAccountEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACAccountDataAccess.Add(ACAccountEntity aCAccountEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCAccountEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCAccountEntity, option);
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

        private Int64 Add(ACAccountEntity aCAccountEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccount_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "AccountID");

                Database.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCAccountEntity.AccountGroupID);	
                Database.AddInParameter(cmd, "@AccountCode", DbType.String, aCAccountEntity.AccountCode);	
                Database.AddInParameter(cmd, "@AccountCode2", DbType.String, aCAccountEntity.AccountCode2);	
                Database.AddInParameter(cmd, "@AccountName", DbType.String, aCAccountEntity.AccountName);	
                Database.AddInParameter(cmd, "@Description", DbType.String, aCAccountEntity.Description);	
                Database.AddInParameter(cmd, "@AccountStatusID", DbType.Int64, aCAccountEntity.AccountStatusID);	
                Database.AddInParameter(cmd, "@TaxTypeID", DbType.Int64, aCAccountEntity.TaxTypeID);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCAccountEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACAccountEntity already exists. Please specify another ACAccountEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACAccountEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACAccountEntity already exists. Please specify another ACAccountEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACAccountEntity aCAccountEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccount_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "AccountID", db);

                db.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCAccountEntity.AccountGroupID);
                db.AddInParameter(cmd, "@AccountCode", DbType.String, aCAccountEntity.AccountCode);
                db.AddInParameter(cmd, "@AccountCode2", DbType.String, aCAccountEntity.AccountCode2);
                db.AddInParameter(cmd, "@AccountName", DbType.String, aCAccountEntity.AccountName);
                db.AddInParameter(cmd, "@Description", DbType.String, aCAccountEntity.Description);
                db.AddInParameter(cmd, "@AccountStatusID", DbType.Int64, aCAccountEntity.AccountStatusID);
                db.AddInParameter(cmd, "@TaxTypeID", DbType.Int64, aCAccountEntity.TaxTypeID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCAccountEntity.IsRemoved);

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

        IList<Int64> IACAccountDataAccess.Add(IList<ACAccountEntity> aCAccountEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACAccountEntity aCAccountEntity in aCAccountEntityList)
            {
                returnCode = (this as IACAccountDataAccess).Add(aCAccountEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACAccountDataAccess.Update(ACAccountEntity aCAccountEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCAccountEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCAccountEntity, filterExpression, option);
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

        private Int64 Update(ACAccountEntity aCAccountEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccount_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@AccountID", DbType.Int64, aCAccountEntity.AccountID);
                Database.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCAccountEntity.AccountGroupID);
                Database.AddInParameter(cmd, "@AccountCode", DbType.String, aCAccountEntity.AccountCode);
                Database.AddInParameter(cmd, "@AccountCode2", DbType.String, aCAccountEntity.AccountCode2);
                Database.AddInParameter(cmd, "@AccountName", DbType.String, aCAccountEntity.AccountName);
                Database.AddInParameter(cmd, "@Description", DbType.String, aCAccountEntity.Description);
                Database.AddInParameter(cmd, "@AccountStatusID", DbType.Int64, aCAccountEntity.AccountStatusID);
                Database.AddInParameter(cmd, "@TaxTypeID", DbType.Int64, aCAccountEntity.TaxTypeID);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCAccountEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACAccountEntity already exists. Please specify another ACAccountEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACAccountEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACAccountEntity already exists. Please specify another ACAccountEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACAccountEntity aCAccountEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccount_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@AccountID", DbType.Int64, aCAccountEntity.AccountID);
                db.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCAccountEntity.AccountGroupID);
                db.AddInParameter(cmd, "@AccountCode", DbType.String, aCAccountEntity.AccountCode);
                db.AddInParameter(cmd, "@AccountCode2", DbType.String, aCAccountEntity.AccountCode2);
                db.AddInParameter(cmd, "@AccountName", DbType.String, aCAccountEntity.AccountName);
                db.AddInParameter(cmd, "@Description", DbType.String, aCAccountEntity.Description);
                db.AddInParameter(cmd, "@AccountStatusID", DbType.Int64, aCAccountEntity.AccountStatusID);
                db.AddInParameter(cmd, "@TaxTypeID", DbType.Int64, aCAccountEntity.TaxTypeID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCAccountEntity.IsRemoved);

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

        IList<Int64> IACAccountDataAccess.Update(IList<ACAccountEntity> aCAccountEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACAccountEntity aCAccountEntity in aCAccountEntityList)
            {
                returnCode = (this as IACAccountDataAccess).Update(aCAccountEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACAccountDataAccess.Delete(ACAccountEntity aCAccountEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCAccountEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCAccountEntity, filterExpression, option);
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

        private Int64 Delete(ACAccountEntity aCAccountEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccount_SET";

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
                                throw new ArgumentException("ACAccountEntity already exists. Please specify another ACAccountEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACAccountEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACAccountEntity already exists. Please specify another ACAccountEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACAccountEntity aCAccountEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccount_SET";

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

        IList<Int64> IACAccountDataAccess.Delete(IList<ACAccountEntity> aCAccountEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACAccountEntity aCAccountEntity in aCAccountEntityList)
            {
                returnCode = (this as IACAccountDataAccess).Delete(aCAccountEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACAccountEntity> IACAccountDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACAccount_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACAccountEntity> list = CreateEntityBuilder<ACAccountEntity>().BuildEntities(reader);

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

        DataTable IACAccountDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACAccount_GET";

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
