// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




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
    internal sealed partial class KBUserTreeUploadInfoDataAccess : BaseDataAccess, IKBUserTreeUploadInfoDataAccess
    {
        #region Constructors

        public KBUserTreeUploadInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<KBUserTreeUploadInfoEntity> CreateEntityBuilder<KBUserTreeUploadInfoEntity>()
        {
            return (new KBUserTreeUploadInfoBuilder()) as IEntityBuilder<KBUserTreeUploadInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IKBUserTreeUploadInfoDataAccess.Add(KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(kBUserTreeUploadInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(kBUserTreeUploadInfoEntity, option);
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

        private Int64 Add(KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeUploadInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "UserTreeUploadInfoID");

                Database.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeUploadInfoEntity.UserTreeID);	
                Database.AddInParameter(cmd, "@Extension", DbType.String, kBUserTreeUploadInfoEntity.Extension);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, kBUserTreeUploadInfoEntity.Remarks);	
                Database.AddInParameter(cmd, "@Path", DbType.String, kBUserTreeUploadInfoEntity.Path);	
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, kBUserTreeUploadInfoEntity.OriginalFileName);	
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, kBUserTreeUploadInfoEntity.CurrentFileName);	
                Database.AddInParameter(cmd, "@FileType", DbType.String, kBUserTreeUploadInfoEntity.FileType);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("KBUserTreeUploadInfoEntity already exists. Please specify another KBUserTreeUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("KBUserTreeUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("KBUserTreeUploadInfoEntity already exists. Please specify another KBUserTreeUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeUploadInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "UserTreeUploadInfoID", db);

                db.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeUploadInfoEntity.UserTreeID);
                db.AddInParameter(cmd, "@Extension", DbType.String, kBUserTreeUploadInfoEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, kBUserTreeUploadInfoEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, kBUserTreeUploadInfoEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, kBUserTreeUploadInfoEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, kBUserTreeUploadInfoEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, kBUserTreeUploadInfoEntity.FileType);

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

        IList<Int64> IKBUserTreeUploadInfoDataAccess.Add(IList<KBUserTreeUploadInfoEntity> kBUserTreeUploadInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity in kBUserTreeUploadInfoEntityList)
            {
                returnCode = (this as IKBUserTreeUploadInfoDataAccess).Add(kBUserTreeUploadInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IKBUserTreeUploadInfoDataAccess.Update(KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(kBUserTreeUploadInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(kBUserTreeUploadInfoEntity, filterExpression, option);
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

        private Int64 Update(KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeUploadInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@UserTreeUploadInfoID", DbType.Int64, kBUserTreeUploadInfoEntity.UserTreeUploadInfoID);
                Database.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeUploadInfoEntity.UserTreeID);
                Database.AddInParameter(cmd, "@Extension", DbType.String, kBUserTreeUploadInfoEntity.Extension);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, kBUserTreeUploadInfoEntity.Remarks);
                Database.AddInParameter(cmd, "@Path", DbType.String, kBUserTreeUploadInfoEntity.Path);
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, kBUserTreeUploadInfoEntity.OriginalFileName);
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, kBUserTreeUploadInfoEntity.CurrentFileName);
                Database.AddInParameter(cmd, "@FileType", DbType.String, kBUserTreeUploadInfoEntity.FileType);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("KBUserTreeUploadInfoEntity already exists. Please specify another KBUserTreeUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("KBUserTreeUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("KBUserTreeUploadInfoEntity already exists. Please specify another KBUserTreeUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeUploadInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@UserTreeUploadInfoID", DbType.Int64, kBUserTreeUploadInfoEntity.UserTreeUploadInfoID);
                db.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeUploadInfoEntity.UserTreeID);
                db.AddInParameter(cmd, "@Extension", DbType.String, kBUserTreeUploadInfoEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, kBUserTreeUploadInfoEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, kBUserTreeUploadInfoEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, kBUserTreeUploadInfoEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, kBUserTreeUploadInfoEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, kBUserTreeUploadInfoEntity.FileType);

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

        IList<Int64> IKBUserTreeUploadInfoDataAccess.Update(IList<KBUserTreeUploadInfoEntity> kBUserTreeUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity in kBUserTreeUploadInfoEntityList)
            {
                returnCode = (this as IKBUserTreeUploadInfoDataAccess).Update(kBUserTreeUploadInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IKBUserTreeUploadInfoDataAccess.Delete(KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(kBUserTreeUploadInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(kBUserTreeUploadInfoEntity, filterExpression, option);
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

        private Int64 Delete(KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeUploadInfo_SET";

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
                                throw new ArgumentException("KBUserTreeUploadInfoEntity already exists. Please specify another KBUserTreeUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("KBUserTreeUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("KBUserTreeUploadInfoEntity already exists. Please specify another KBUserTreeUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeUploadInfo_SET";

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

        IList<Int64> IKBUserTreeUploadInfoDataAccess.Delete(IList<KBUserTreeUploadInfoEntity> kBUserTreeUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity in kBUserTreeUploadInfoEntityList)
            {
                returnCode = (this as IKBUserTreeUploadInfoDataAccess).Delete(kBUserTreeUploadInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<KBUserTreeUploadInfoEntity> IKBUserTreeUploadInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.KBUserTreeUploadInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<KBUserTreeUploadInfoEntity> list = CreateEntityBuilder<KBUserTreeUploadInfoEntity>().BuildEntities(reader);

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

        DataTable IKBUserTreeUploadInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.KBUserTreeUploadInfo_GET";

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
