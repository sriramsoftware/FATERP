// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




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
    internal sealed partial class ASUserPermissionExcludedDataAccess : BaseDataAccess, IASUserPermissionExcludedDataAccess
    {
        #region Constructors

        public ASUserPermissionExcludedDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ASUserPermissionExcludedEntity> CreateEntityBuilder<ASUserPermissionExcludedEntity>()
        {
            return (new ASUserPermissionExcludedBuilder()) as IEntityBuilder<ASUserPermissionExcludedEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IASUserPermissionExcludedDataAccess.Add(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aSUserPermissionExcludedEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aSUserPermissionExcludedEntity, option);
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

        private Int64 Add(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASUserPermissionExcluded_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ASUserPermissionExcludedID");

                Database.AddInParameter(cmd, "@ASUserName", DbType.String, aSUserPermissionExcludedEntity.ASUserName);	
                Database.AddInParameter(cmd, "@PermissionKey", DbType.String, aSUserPermissionExcludedEntity.PermissionKey);	
                Database.AddInParameter(cmd, "@Ts", DbType.Int64, aSUserPermissionExcludedEntity.Ts);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ASUserPermissionExcludedEntity already exists. Please specify another ASUserPermissionExcludedEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ASUserPermissionExcludedEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ASUserPermissionExcludedEntity already exists. Please specify another ASUserPermissionExcludedEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASUserPermissionExcluded_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ASUserPermissionExcludedID", db);

                db.AddInParameter(cmd, "@ASUserName", DbType.String, aSUserPermissionExcludedEntity.ASUserName);
                db.AddInParameter(cmd, "@PermissionKey", DbType.String, aSUserPermissionExcludedEntity.PermissionKey);
                db.AddInParameter(cmd, "@Ts", DbType.Int64, aSUserPermissionExcludedEntity.Ts);

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

        IList<Int64> IASUserPermissionExcludedDataAccess.Add(IList<ASUserPermissionExcludedEntity> aSUserPermissionExcludedEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity in aSUserPermissionExcludedEntityList)
            {
                returnCode = (this as IASUserPermissionExcludedDataAccess).Add(aSUserPermissionExcludedEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IASUserPermissionExcludedDataAccess.Update(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aSUserPermissionExcludedEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aSUserPermissionExcludedEntity, filterExpression, option);
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

        private Int64 Update(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASUserPermissionExcluded_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ASUserPermissionExcludedID", DbType.Int64, aSUserPermissionExcludedEntity.ASUserPermissionExcludedID);
                Database.AddInParameter(cmd, "@ASUserName", DbType.String, aSUserPermissionExcludedEntity.ASUserName);
                Database.AddInParameter(cmd, "@PermissionKey", DbType.String, aSUserPermissionExcludedEntity.PermissionKey);
                Database.AddInParameter(cmd, "@Ts", DbType.Int64, aSUserPermissionExcludedEntity.Ts);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ASUserPermissionExcludedEntity already exists. Please specify another ASUserPermissionExcludedEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ASUserPermissionExcludedEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ASUserPermissionExcludedEntity already exists. Please specify another ASUserPermissionExcludedEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASUserPermissionExcluded_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ASUserPermissionExcludedID", DbType.Int64, aSUserPermissionExcludedEntity.ASUserPermissionExcludedID);
                db.AddInParameter(cmd, "@ASUserName", DbType.String, aSUserPermissionExcludedEntity.ASUserName);
                db.AddInParameter(cmd, "@PermissionKey", DbType.String, aSUserPermissionExcludedEntity.PermissionKey);
                db.AddInParameter(cmd, "@Ts", DbType.Int64, aSUserPermissionExcludedEntity.Ts);

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

        IList<Int64> IASUserPermissionExcludedDataAccess.Update(IList<ASUserPermissionExcludedEntity> aSUserPermissionExcludedEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity in aSUserPermissionExcludedEntityList)
            {
                returnCode = (this as IASUserPermissionExcludedDataAccess).Update(aSUserPermissionExcludedEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IASUserPermissionExcludedDataAccess.Delete(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aSUserPermissionExcludedEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aSUserPermissionExcludedEntity, filterExpression, option);
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

        private Int64 Delete(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASUserPermissionExcluded_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@Ts", DbType.Int64, aSUserPermissionExcludedEntity.Ts);	

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ASUserPermissionExcludedEntity already exists. Please specify another ASUserPermissionExcludedEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ASUserPermissionExcludedEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ASUserPermissionExcludedEntity already exists. Please specify another ASUserPermissionExcludedEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ASUserPermissionExcluded_SET";

            Database db = DatabaseFactory.CreateDatabase();


            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd, db);
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@Ts", DbType.Int64, aSUserPermissionExcludedEntity.Ts); 

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

        IList<Int64> IASUserPermissionExcludedDataAccess.Delete(IList<ASUserPermissionExcludedEntity> aSUserPermissionExcludedEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity in aSUserPermissionExcludedEntityList)
            {
                returnCode = (this as IASUserPermissionExcludedDataAccess).Delete(aSUserPermissionExcludedEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ASUserPermissionExcludedEntity> IASUserPermissionExcludedDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ASUserPermissionExcluded_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ASUserPermissionExcludedEntity> list = CreateEntityBuilder<ASUserPermissionExcludedEntity>().BuildEntities(reader);

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

        DataTable IASUserPermissionExcludedDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ASUserPermissionExcluded_GET";

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
