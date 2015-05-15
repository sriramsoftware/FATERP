// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    internal sealed partial class OTIssueUploadInfoDataAccess : BaseDataAccess, IOTIssueUploadInfoDataAccess
    {
        #region Constructors

        public OTIssueUploadInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<OTIssueUploadInfoEntity> CreateEntityBuilder<OTIssueUploadInfoEntity>()
        {
            return (new OTIssueUploadInfoBuilder()) as IEntityBuilder<OTIssueUploadInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IOTIssueUploadInfoDataAccess.Add(OTIssueUploadInfoEntity oTIssueUploadInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(oTIssueUploadInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(oTIssueUploadInfoEntity, option);
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

        private Int64 Add(OTIssueUploadInfoEntity oTIssueUploadInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssueUploadInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "IssueUploadInfoID");

                Database.AddInParameter(cmd, "@IssueID", DbType.Int64, oTIssueUploadInfoEntity.IssueID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, oTIssueUploadInfoEntity.Remarks);	
                Database.AddInParameter(cmd, "@Path", DbType.String, oTIssueUploadInfoEntity.Path);	
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, oTIssueUploadInfoEntity.OriginalFileName);	
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, oTIssueUploadInfoEntity.CurrentFileName);	
                Database.AddInParameter(cmd, "@FileType", DbType.String, oTIssueUploadInfoEntity.FileType);	
                Database.AddInParameter(cmd, "@Extension", DbType.String, oTIssueUploadInfoEntity.Extension);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("OTIssueUploadInfoEntity already exists. Please specify another OTIssueUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("OTIssueUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("OTIssueUploadInfoEntity already exists. Please specify another OTIssueUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(OTIssueUploadInfoEntity oTIssueUploadInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssueUploadInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "IssueUploadInfoID", db);

                db.AddInParameter(cmd, "@IssueID", DbType.Int64, oTIssueUploadInfoEntity.IssueID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, oTIssueUploadInfoEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, oTIssueUploadInfoEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, oTIssueUploadInfoEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, oTIssueUploadInfoEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, oTIssueUploadInfoEntity.FileType);
                db.AddInParameter(cmd, "@Extension", DbType.String, oTIssueUploadInfoEntity.Extension);

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

        IList<Int64> IOTIssueUploadInfoDataAccess.Add(IList<OTIssueUploadInfoEntity> oTIssueUploadInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (OTIssueUploadInfoEntity oTIssueUploadInfoEntity in oTIssueUploadInfoEntityList)
            {
                returnCode = (this as IOTIssueUploadInfoDataAccess).Add(oTIssueUploadInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IOTIssueUploadInfoDataAccess.Update(OTIssueUploadInfoEntity oTIssueUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(oTIssueUploadInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(oTIssueUploadInfoEntity, filterExpression, option);
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

        private Int64 Update(OTIssueUploadInfoEntity oTIssueUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssueUploadInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@IssueUploadInfoID", DbType.Int64, oTIssueUploadInfoEntity.IssueUploadInfoID);
                Database.AddInParameter(cmd, "@IssueID", DbType.Int64, oTIssueUploadInfoEntity.IssueID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, oTIssueUploadInfoEntity.Remarks);
                Database.AddInParameter(cmd, "@Path", DbType.String, oTIssueUploadInfoEntity.Path);
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, oTIssueUploadInfoEntity.OriginalFileName);
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, oTIssueUploadInfoEntity.CurrentFileName);
                Database.AddInParameter(cmd, "@FileType", DbType.String, oTIssueUploadInfoEntity.FileType);
                Database.AddInParameter(cmd, "@Extension", DbType.String, oTIssueUploadInfoEntity.Extension);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("OTIssueUploadInfoEntity already exists. Please specify another OTIssueUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("OTIssueUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("OTIssueUploadInfoEntity already exists. Please specify another OTIssueUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(OTIssueUploadInfoEntity oTIssueUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssueUploadInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@IssueUploadInfoID", DbType.Int64, oTIssueUploadInfoEntity.IssueUploadInfoID);
                db.AddInParameter(cmd, "@IssueID", DbType.Int64, oTIssueUploadInfoEntity.IssueID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, oTIssueUploadInfoEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, oTIssueUploadInfoEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, oTIssueUploadInfoEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, oTIssueUploadInfoEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, oTIssueUploadInfoEntity.FileType);
                db.AddInParameter(cmd, "@Extension", DbType.String, oTIssueUploadInfoEntity.Extension);

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

        IList<Int64> IOTIssueUploadInfoDataAccess.Update(IList<OTIssueUploadInfoEntity> oTIssueUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (OTIssueUploadInfoEntity oTIssueUploadInfoEntity in oTIssueUploadInfoEntityList)
            {
                returnCode = (this as IOTIssueUploadInfoDataAccess).Update(oTIssueUploadInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IOTIssueUploadInfoDataAccess.Delete(OTIssueUploadInfoEntity oTIssueUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(oTIssueUploadInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(oTIssueUploadInfoEntity, filterExpression, option);
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

        private Int64 Delete(OTIssueUploadInfoEntity oTIssueUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssueUploadInfo_SET";

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
                                throw new ArgumentException("OTIssueUploadInfoEntity already exists. Please specify another OTIssueUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("OTIssueUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("OTIssueUploadInfoEntity already exists. Please specify another OTIssueUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(OTIssueUploadInfoEntity oTIssueUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssueUploadInfo_SET";

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

        IList<Int64> IOTIssueUploadInfoDataAccess.Delete(IList<OTIssueUploadInfoEntity> oTIssueUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (OTIssueUploadInfoEntity oTIssueUploadInfoEntity in oTIssueUploadInfoEntityList)
            {
                returnCode = (this as IOTIssueUploadInfoDataAccess).Delete(oTIssueUploadInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<OTIssueUploadInfoEntity> IOTIssueUploadInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.OTIssueUploadInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<OTIssueUploadInfoEntity> list = CreateEntityBuilder<OTIssueUploadInfoEntity>().BuildEntities(reader);

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

        DataTable IOTIssueUploadInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.OTIssueUploadInfo_GET";

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
