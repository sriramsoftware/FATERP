// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jun-2013, 03:54:41




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
    internal sealed partial class ACAccountResourceAccountMapDataAccess : BaseDataAccess, IACAccountResourceAccountMapDataAccess
    {
        #region Constructors

        public ACAccountResourceAccountMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACAccountResourceAccountMapEntity> CreateEntityBuilder<ACAccountResourceAccountMapEntity>()
        {
            return (new ACAccountResourceAccountMapBuilder()) as IEntityBuilder<ACAccountResourceAccountMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACAccountResourceAccountMapDataAccess.Add(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCAccountResourceAccountMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCAccountResourceAccountMapEntity, option);
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

        private Int64 Add(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccountResourceAccountMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ResourceAccountMapID");

                Database.AddInParameter(cmd, "@AccountID", DbType.Int64, aCAccountResourceAccountMapEntity.AccountID);	
                Database.AddInParameter(cmd, "@AccountResourceCategoryID", DbType.Int64, aCAccountResourceAccountMapEntity.AccountResourceCategoryID);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCAccountResourceAccountMapEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCAccountResourceAccountMapEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACAccountResourceAccountMapEntity already exists. Please specify another ACAccountResourceAccountMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACAccountResourceAccountMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACAccountResourceAccountMapEntity already exists. Please specify another ACAccountResourceAccountMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccountResourceAccountMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ResourceAccountMapID", db);

                db.AddInParameter(cmd, "@AccountID", DbType.Int64, aCAccountResourceAccountMapEntity.AccountID);
                db.AddInParameter(cmd, "@AccountResourceCategoryID", DbType.Int64, aCAccountResourceAccountMapEntity.AccountResourceCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCAccountResourceAccountMapEntity.ReferenceID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCAccountResourceAccountMapEntity.Remarks);

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

        IList<Int64> IACAccountResourceAccountMapDataAccess.Add(IList<ACAccountResourceAccountMapEntity> aCAccountResourceAccountMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity in aCAccountResourceAccountMapEntityList)
            {
                returnCode = (this as IACAccountResourceAccountMapDataAccess).Add(aCAccountResourceAccountMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACAccountResourceAccountMapDataAccess.Update(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCAccountResourceAccountMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCAccountResourceAccountMapEntity, filterExpression, option);
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

        private Int64 Update(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccountResourceAccountMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ResourceAccountMapID", DbType.Int64, aCAccountResourceAccountMapEntity.ResourceAccountMapID);
                Database.AddInParameter(cmd, "@AccountID", DbType.Int64, aCAccountResourceAccountMapEntity.AccountID);
                Database.AddInParameter(cmd, "@AccountResourceCategoryID", DbType.Int64, aCAccountResourceAccountMapEntity.AccountResourceCategoryID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCAccountResourceAccountMapEntity.ReferenceID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCAccountResourceAccountMapEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACAccountResourceAccountMapEntity already exists. Please specify another ACAccountResourceAccountMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACAccountResourceAccountMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACAccountResourceAccountMapEntity already exists. Please specify another ACAccountResourceAccountMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccountResourceAccountMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ResourceAccountMapID", DbType.Int64, aCAccountResourceAccountMapEntity.ResourceAccountMapID);
                db.AddInParameter(cmd, "@AccountID", DbType.Int64, aCAccountResourceAccountMapEntity.AccountID);
                db.AddInParameter(cmd, "@AccountResourceCategoryID", DbType.Int64, aCAccountResourceAccountMapEntity.AccountResourceCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCAccountResourceAccountMapEntity.ReferenceID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCAccountResourceAccountMapEntity.Remarks);

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

        IList<Int64> IACAccountResourceAccountMapDataAccess.Update(IList<ACAccountResourceAccountMapEntity> aCAccountResourceAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity in aCAccountResourceAccountMapEntityList)
            {
                returnCode = (this as IACAccountResourceAccountMapDataAccess).Update(aCAccountResourceAccountMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACAccountResourceAccountMapDataAccess.Delete(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCAccountResourceAccountMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCAccountResourceAccountMapEntity, filterExpression, option);
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

        private Int64 Delete(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccountResourceAccountMap_SET";

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
                                throw new ArgumentException("ACAccountResourceAccountMapEntity already exists. Please specify another ACAccountResourceAccountMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACAccountResourceAccountMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACAccountResourceAccountMapEntity already exists. Please specify another ACAccountResourceAccountMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccountResourceAccountMap_SET";

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

        IList<Int64> IACAccountResourceAccountMapDataAccess.Delete(IList<ACAccountResourceAccountMapEntity> aCAccountResourceAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity in aCAccountResourceAccountMapEntityList)
            {
                returnCode = (this as IACAccountResourceAccountMapDataAccess).Delete(aCAccountResourceAccountMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACAccountResourceAccountMapEntity> IACAccountResourceAccountMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACAccountResourceAccountMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACAccountResourceAccountMapEntity> list = CreateEntityBuilder<ACAccountResourceAccountMapEntity>().BuildEntities(reader);

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

        DataTable IACAccountResourceAccountMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACAccountResourceAccountMap_GET";

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
