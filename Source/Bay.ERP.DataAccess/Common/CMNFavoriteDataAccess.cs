// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Mar-2013, 05:31:27




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
    internal sealed partial class CMNFavoriteDataAccess : BaseDataAccess, ICMNFavoriteDataAccess
    {
        #region Constructors

        public CMNFavoriteDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMNFavoriteEntity> CreateEntityBuilder<CMNFavoriteEntity>()
        {
            return (new CMNFavoriteBuilder()) as IEntityBuilder<CMNFavoriteEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMNFavoriteDataAccess.Add(CMNFavoriteEntity cMNFavoriteEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMNFavoriteEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMNFavoriteEntity, option);
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

        private Int64 Add(CMNFavoriteEntity cMNFavoriteEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNFavorite_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "FavoriteID");

                Database.AddInParameter(cmd, "@ProcessCategoryID", DbType.Int64, cMNFavoriteEntity.ProcessCategoryID);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cMNFavoriteEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMNFavoriteEntity.Remarks);	
                Database.AddInParameter(cmd, "@FavoriteDate", DbType.DateTime, cMNFavoriteEntity.FavoriteDate);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, cMNFavoriteEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNFavoriteEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNFavoriteEntity already exists. Please specify another CMNFavoriteEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNFavoriteEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNFavoriteEntity already exists. Please specify another CMNFavoriteEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMNFavoriteEntity cMNFavoriteEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNFavorite_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "FavoriteID", db);

                db.AddInParameter(cmd, "@ProcessCategoryID", DbType.Int64, cMNFavoriteEntity.ProcessCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cMNFavoriteEntity.ReferenceID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMNFavoriteEntity.Remarks);
                db.AddInParameter(cmd, "@FavoriteDate", DbType.DateTime, cMNFavoriteEntity.FavoriteDate);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, cMNFavoriteEntity.EmployeeID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNFavoriteEntity.IsRemoved);

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

        IList<Int64> ICMNFavoriteDataAccess.Add(IList<CMNFavoriteEntity> cMNFavoriteEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMNFavoriteEntity cMNFavoriteEntity in cMNFavoriteEntityList)
            {
                returnCode = (this as ICMNFavoriteDataAccess).Add(cMNFavoriteEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMNFavoriteDataAccess.Update(CMNFavoriteEntity cMNFavoriteEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMNFavoriteEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMNFavoriteEntity, filterExpression, option);
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

        private Int64 Update(CMNFavoriteEntity cMNFavoriteEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNFavorite_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@FavoriteID", DbType.Int64, cMNFavoriteEntity.FavoriteID);
                Database.AddInParameter(cmd, "@ProcessCategoryID", DbType.Int64, cMNFavoriteEntity.ProcessCategoryID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cMNFavoriteEntity.ReferenceID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMNFavoriteEntity.Remarks);
                Database.AddInParameter(cmd, "@FavoriteDate", DbType.DateTime, cMNFavoriteEntity.FavoriteDate);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, cMNFavoriteEntity.EmployeeID);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNFavoriteEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNFavoriteEntity already exists. Please specify another CMNFavoriteEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNFavoriteEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNFavoriteEntity already exists. Please specify another CMNFavoriteEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMNFavoriteEntity cMNFavoriteEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNFavorite_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@FavoriteID", DbType.Int64, cMNFavoriteEntity.FavoriteID);
                db.AddInParameter(cmd, "@ProcessCategoryID", DbType.Int64, cMNFavoriteEntity.ProcessCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cMNFavoriteEntity.ReferenceID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMNFavoriteEntity.Remarks);
                db.AddInParameter(cmd, "@FavoriteDate", DbType.DateTime, cMNFavoriteEntity.FavoriteDate);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, cMNFavoriteEntity.EmployeeID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNFavoriteEntity.IsRemoved);

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

        IList<Int64> ICMNFavoriteDataAccess.Update(IList<CMNFavoriteEntity> cMNFavoriteEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMNFavoriteEntity cMNFavoriteEntity in cMNFavoriteEntityList)
            {
                returnCode = (this as ICMNFavoriteDataAccess).Update(cMNFavoriteEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMNFavoriteDataAccess.Delete(CMNFavoriteEntity cMNFavoriteEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMNFavoriteEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMNFavoriteEntity, filterExpression, option);
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

        private Int64 Delete(CMNFavoriteEntity cMNFavoriteEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNFavorite_SET";

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
                                throw new ArgumentException("CMNFavoriteEntity already exists. Please specify another CMNFavoriteEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNFavoriteEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNFavoriteEntity already exists. Please specify another CMNFavoriteEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMNFavoriteEntity cMNFavoriteEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNFavorite_SET";

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

        IList<Int64> ICMNFavoriteDataAccess.Delete(IList<CMNFavoriteEntity> cMNFavoriteEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMNFavoriteEntity cMNFavoriteEntity in cMNFavoriteEntityList)
            {
                returnCode = (this as ICMNFavoriteDataAccess).Delete(cMNFavoriteEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMNFavoriteEntity> ICMNFavoriteDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNFavorite_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMNFavoriteEntity> list = CreateEntityBuilder<CMNFavoriteEntity>().BuildEntities(reader);

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

        DataTable ICMNFavoriteDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNFavorite_GET";

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
