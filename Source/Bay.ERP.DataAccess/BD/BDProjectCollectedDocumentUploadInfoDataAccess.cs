// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




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
    internal sealed partial class BDProjectCollectedDocumentUploadInfoDataAccess : BaseDataAccess, IBDProjectCollectedDocumentUploadInfoDataAccess
    {
        #region Constructors

        public BDProjectCollectedDocumentUploadInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectCollectedDocumentUploadInfoEntity> CreateEntityBuilder<BDProjectCollectedDocumentUploadInfoEntity>()
        {
            return (new BDProjectCollectedDocumentUploadInfoBuilder()) as IEntityBuilder<BDProjectCollectedDocumentUploadInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectCollectedDocumentUploadInfoDataAccess.Add(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectCollectedDocumentUploadInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectCollectedDocumentUploadInfoEntity, option);
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

        private Int64 Add(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectCollectedDocumentUploadInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectCollectedDocumentUploadInfoID");

                Database.AddInParameter(cmd, "@ProjectCollectedDocumentInfoID", DbType.Int64, bDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentInfoID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.Remarks);	
                Database.AddInParameter(cmd, "@Path", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.Path);	
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.OriginalFileName);	
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.CurrentFileName);	
                Database.AddInParameter(cmd, "@FileType", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.FileType);	
                Database.AddInParameter(cmd, "@Extension", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.Extension);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentUploadInfoEntity already exists. Please specify another BDProjectCollectedDocumentUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentUploadInfoEntity already exists. Please specify another BDProjectCollectedDocumentUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectCollectedDocumentUploadInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectCollectedDocumentUploadInfoID", db);

                db.AddInParameter(cmd, "@ProjectCollectedDocumentInfoID", DbType.Int64, bDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentInfoID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.FileType);
                db.AddInParameter(cmd, "@Extension", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.Extension);

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

        IList<Int64> IBDProjectCollectedDocumentUploadInfoDataAccess.Add(IList<BDProjectCollectedDocumentUploadInfoEntity> bDProjectCollectedDocumentUploadInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity in bDProjectCollectedDocumentUploadInfoEntityList)
            {
                returnCode = (this as IBDProjectCollectedDocumentUploadInfoDataAccess).Add(bDProjectCollectedDocumentUploadInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectCollectedDocumentUploadInfoDataAccess.Update(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectCollectedDocumentUploadInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectCollectedDocumentUploadInfoEntity, filterExpression, option);
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

        private Int64 Update(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectCollectedDocumentUploadInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectCollectedDocumentUploadInfoID", DbType.Int64, bDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentUploadInfoID);
                Database.AddInParameter(cmd, "@ProjectCollectedDocumentInfoID", DbType.Int64, bDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentInfoID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.Remarks);
                Database.AddInParameter(cmd, "@Path", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.Path);
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.OriginalFileName);
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.CurrentFileName);
                Database.AddInParameter(cmd, "@FileType", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.FileType);
                Database.AddInParameter(cmd, "@Extension", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.Extension);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentUploadInfoEntity already exists. Please specify another BDProjectCollectedDocumentUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentUploadInfoEntity already exists. Please specify another BDProjectCollectedDocumentUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectCollectedDocumentUploadInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectCollectedDocumentUploadInfoID", DbType.Int64, bDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentUploadInfoID);
                db.AddInParameter(cmd, "@ProjectCollectedDocumentInfoID", DbType.Int64, bDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentInfoID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.FileType);
                db.AddInParameter(cmd, "@Extension", DbType.String, bDProjectCollectedDocumentUploadInfoEntity.Extension);

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

        IList<Int64> IBDProjectCollectedDocumentUploadInfoDataAccess.Update(IList<BDProjectCollectedDocumentUploadInfoEntity> bDProjectCollectedDocumentUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity in bDProjectCollectedDocumentUploadInfoEntityList)
            {
                returnCode = (this as IBDProjectCollectedDocumentUploadInfoDataAccess).Update(bDProjectCollectedDocumentUploadInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectCollectedDocumentUploadInfoDataAccess.Delete(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectCollectedDocumentUploadInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectCollectedDocumentUploadInfoEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectCollectedDocumentUploadInfo_SET";

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
                                throw new ArgumentException("BDProjectCollectedDocumentUploadInfoEntity already exists. Please specify another BDProjectCollectedDocumentUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentUploadInfoEntity already exists. Please specify another BDProjectCollectedDocumentUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectCollectedDocumentUploadInfo_SET";

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

        IList<Int64> IBDProjectCollectedDocumentUploadInfoDataAccess.Delete(IList<BDProjectCollectedDocumentUploadInfoEntity> bDProjectCollectedDocumentUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity in bDProjectCollectedDocumentUploadInfoEntityList)
            {
                returnCode = (this as IBDProjectCollectedDocumentUploadInfoDataAccess).Delete(bDProjectCollectedDocumentUploadInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectCollectedDocumentUploadInfoEntity> IBDProjectCollectedDocumentUploadInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectCollectedDocumentUploadInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectCollectedDocumentUploadInfoEntity> list = CreateEntityBuilder<BDProjectCollectedDocumentUploadInfoEntity>().BuildEntities(reader);

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

        DataTable IBDProjectCollectedDocumentUploadInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectCollectedDocumentUploadInfo_GET";

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
