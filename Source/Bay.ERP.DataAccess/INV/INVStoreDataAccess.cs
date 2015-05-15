// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




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
    internal sealed partial class INVStoreDataAccess : BaseDataAccess, IINVStoreDataAccess
    {
        #region Constructors

        public INVStoreDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<INVStoreEntity> CreateEntityBuilder<INVStoreEntity>()
        {
            return (new INVStoreBuilder()) as IEntityBuilder<INVStoreEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IINVStoreDataAccess.Add(INVStoreEntity iNVStoreEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(iNVStoreEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(iNVStoreEntity, option);
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

        private Int64 Add(INVStoreEntity iNVStoreEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStore_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "StoreID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, iNVStoreEntity.ProjectID);	
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, iNVStoreEntity.DepartmentID);	
                Database.AddInParameter(cmd, "@StoreInChargeEmployeeID", DbType.Int64, iNVStoreEntity.StoreInChargeEmployeeID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, iNVStoreEntity.Name);	
                Database.AddInParameter(cmd, "@StoreTrackNumber", DbType.String, iNVStoreEntity.StoreTrackNumber);	
                Database.AddInParameter(cmd, "@Location", DbType.String, iNVStoreEntity.Location);	
                Database.AddInParameter(cmd, "@Description", DbType.String, iNVStoreEntity.Description);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, iNVStoreEntity.CreateDate);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVStoreEntity.IsRemoved);	
                Database.AddInParameter(cmd, "@IsDefault", DbType.Boolean, iNVStoreEntity.IsDefault);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVStoreEntity already exists. Please specify another INVStoreEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVStoreEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVStoreEntity already exists. Please specify another INVStoreEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(INVStoreEntity iNVStoreEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStore_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "StoreID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, iNVStoreEntity.ProjectID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, iNVStoreEntity.DepartmentID);
                db.AddInParameter(cmd, "@StoreInChargeEmployeeID", DbType.Int64, iNVStoreEntity.StoreInChargeEmployeeID);
                db.AddInParameter(cmd, "@Name", DbType.String, iNVStoreEntity.Name);
                db.AddInParameter(cmd, "@StoreTrackNumber", DbType.String, iNVStoreEntity.StoreTrackNumber);
                db.AddInParameter(cmd, "@Location", DbType.String, iNVStoreEntity.Location);
                db.AddInParameter(cmd, "@Description", DbType.String, iNVStoreEntity.Description);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, iNVStoreEntity.CreateDate);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVStoreEntity.IsRemoved);
                db.AddInParameter(cmd, "@IsDefault", DbType.Boolean, iNVStoreEntity.IsDefault);

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

        IList<Int64> IINVStoreDataAccess.Add(IList<INVStoreEntity> iNVStoreEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (INVStoreEntity iNVStoreEntity in iNVStoreEntityList)
            {
                returnCode = (this as IINVStoreDataAccess).Add(iNVStoreEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IINVStoreDataAccess.Update(INVStoreEntity iNVStoreEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(iNVStoreEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(iNVStoreEntity, filterExpression, option);
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

        private Int64 Update(INVStoreEntity iNVStoreEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStore_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@StoreID", DbType.Int64, iNVStoreEntity.StoreID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, iNVStoreEntity.ProjectID);
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, iNVStoreEntity.DepartmentID);
                Database.AddInParameter(cmd, "@StoreInChargeEmployeeID", DbType.Int64, iNVStoreEntity.StoreInChargeEmployeeID);
                Database.AddInParameter(cmd, "@Name", DbType.String, iNVStoreEntity.Name);
                Database.AddInParameter(cmd, "@StoreTrackNumber", DbType.String, iNVStoreEntity.StoreTrackNumber);
                Database.AddInParameter(cmd, "@Location", DbType.String, iNVStoreEntity.Location);
                Database.AddInParameter(cmd, "@Description", DbType.String, iNVStoreEntity.Description);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, iNVStoreEntity.CreateDate);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVStoreEntity.IsRemoved);
                Database.AddInParameter(cmd, "@IsDefault", DbType.Boolean, iNVStoreEntity.IsDefault);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVStoreEntity already exists. Please specify another INVStoreEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVStoreEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVStoreEntity already exists. Please specify another INVStoreEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(INVStoreEntity iNVStoreEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStore_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@StoreID", DbType.Int64, iNVStoreEntity.StoreID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, iNVStoreEntity.ProjectID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, iNVStoreEntity.DepartmentID);
                db.AddInParameter(cmd, "@StoreInChargeEmployeeID", DbType.Int64, iNVStoreEntity.StoreInChargeEmployeeID);
                db.AddInParameter(cmd, "@Name", DbType.String, iNVStoreEntity.Name);
                db.AddInParameter(cmd, "@StoreTrackNumber", DbType.String, iNVStoreEntity.StoreTrackNumber);
                db.AddInParameter(cmd, "@Location", DbType.String, iNVStoreEntity.Location);
                db.AddInParameter(cmd, "@Description", DbType.String, iNVStoreEntity.Description);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, iNVStoreEntity.CreateDate);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVStoreEntity.IsRemoved);
                db.AddInParameter(cmd, "@IsDefault", DbType.Boolean, iNVStoreEntity.IsDefault);

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

        IList<Int64> IINVStoreDataAccess.Update(IList<INVStoreEntity> iNVStoreEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (INVStoreEntity iNVStoreEntity in iNVStoreEntityList)
            {
                returnCode = (this as IINVStoreDataAccess).Update(iNVStoreEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IINVStoreDataAccess.Delete(INVStoreEntity iNVStoreEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(iNVStoreEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(iNVStoreEntity, filterExpression, option);
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

        private Int64 Delete(INVStoreEntity iNVStoreEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStore_SET";

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
                                throw new ArgumentException("INVStoreEntity already exists. Please specify another INVStoreEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVStoreEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVStoreEntity already exists. Please specify another INVStoreEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(INVStoreEntity iNVStoreEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStore_SET";

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

        IList<Int64> IINVStoreDataAccess.Delete(IList<INVStoreEntity> iNVStoreEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (INVStoreEntity iNVStoreEntity in iNVStoreEntityList)
            {
                returnCode = (this as IINVStoreDataAccess).Delete(iNVStoreEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<INVStoreEntity> IINVStoreDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVStore_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<INVStoreEntity> list = CreateEntityBuilder<INVStoreEntity>().BuildEntities(reader);

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

        DataTable IINVStoreDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVStore_GET";

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
