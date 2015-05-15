// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2012, 11:26:30




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
    internal sealed partial class CMBillUploadInfoDataAccess : BaseDataAccess, ICMBillUploadInfoDataAccess
    {
        #region Constructors

        public CMBillUploadInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMBillUploadInfoEntity> CreateEntityBuilder<CMBillUploadInfoEntity>()
        {
            return (new CMBillUploadInfoBuilder()) as IEntityBuilder<CMBillUploadInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMBillUploadInfoDataAccess.Add(CMBillUploadInfoEntity cMBillUploadInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMBillUploadInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMBillUploadInfoEntity, option);
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

        private Int64 Add(CMBillUploadInfoEntity cMBillUploadInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillUploadInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BillUploadInfoID");

                Database.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillUploadInfoEntity.BillID);	
                Database.AddInParameter(cmd, "@Extension", DbType.String, cMBillUploadInfoEntity.Extension);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMBillUploadInfoEntity.Remarks);	
                Database.AddInParameter(cmd, "@Path", DbType.String, cMBillUploadInfoEntity.Path);	
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, cMBillUploadInfoEntity.OriginalFileName);	
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, cMBillUploadInfoEntity.CurrentFileName);	
                Database.AddInParameter(cmd, "@FileType", DbType.String, cMBillUploadInfoEntity.FileType);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMBillUploadInfoEntity already exists. Please specify another CMBillUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillUploadInfoEntity already exists. Please specify another CMBillUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMBillUploadInfoEntity cMBillUploadInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillUploadInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BillUploadInfoID", db);

                db.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillUploadInfoEntity.BillID);
                db.AddInParameter(cmd, "@Extension", DbType.String, cMBillUploadInfoEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMBillUploadInfoEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, cMBillUploadInfoEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, cMBillUploadInfoEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, cMBillUploadInfoEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, cMBillUploadInfoEntity.FileType);

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

        IList<Int64> ICMBillUploadInfoDataAccess.Add(IList<CMBillUploadInfoEntity> cMBillUploadInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMBillUploadInfoEntity cMBillUploadInfoEntity in cMBillUploadInfoEntityList)
            {
                returnCode = (this as ICMBillUploadInfoDataAccess).Add(cMBillUploadInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMBillUploadInfoDataAccess.Update(CMBillUploadInfoEntity cMBillUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMBillUploadInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMBillUploadInfoEntity, filterExpression, option);
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

        private Int64 Update(CMBillUploadInfoEntity cMBillUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillUploadInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BillUploadInfoID", DbType.Int64, cMBillUploadInfoEntity.BillUploadInfoID);
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillUploadInfoEntity.BillID);
                Database.AddInParameter(cmd, "@Extension", DbType.String, cMBillUploadInfoEntity.Extension);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMBillUploadInfoEntity.Remarks);
                Database.AddInParameter(cmd, "@Path", DbType.String, cMBillUploadInfoEntity.Path);
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, cMBillUploadInfoEntity.OriginalFileName);
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, cMBillUploadInfoEntity.CurrentFileName);
                Database.AddInParameter(cmd, "@FileType", DbType.String, cMBillUploadInfoEntity.FileType);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMBillUploadInfoEntity already exists. Please specify another CMBillUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillUploadInfoEntity already exists. Please specify another CMBillUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMBillUploadInfoEntity cMBillUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillUploadInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BillUploadInfoID", DbType.Int64, cMBillUploadInfoEntity.BillUploadInfoID);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillUploadInfoEntity.BillID);
                db.AddInParameter(cmd, "@Extension", DbType.String, cMBillUploadInfoEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMBillUploadInfoEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, cMBillUploadInfoEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, cMBillUploadInfoEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, cMBillUploadInfoEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, cMBillUploadInfoEntity.FileType);

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

        IList<Int64> ICMBillUploadInfoDataAccess.Update(IList<CMBillUploadInfoEntity> cMBillUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMBillUploadInfoEntity cMBillUploadInfoEntity in cMBillUploadInfoEntityList)
            {
                returnCode = (this as ICMBillUploadInfoDataAccess).Update(cMBillUploadInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMBillUploadInfoDataAccess.Delete(CMBillUploadInfoEntity cMBillUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMBillUploadInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMBillUploadInfoEntity, filterExpression, option);
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

        private Int64 Delete(CMBillUploadInfoEntity cMBillUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillUploadInfo_SET";

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
                                throw new ArgumentException("CMBillUploadInfoEntity already exists. Please specify another CMBillUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillUploadInfoEntity already exists. Please specify another CMBillUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMBillUploadInfoEntity cMBillUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillUploadInfo_SET";

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

        IList<Int64> ICMBillUploadInfoDataAccess.Delete(IList<CMBillUploadInfoEntity> cMBillUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMBillUploadInfoEntity cMBillUploadInfoEntity in cMBillUploadInfoEntityList)
            {
                returnCode = (this as ICMBillUploadInfoDataAccess).Delete(cMBillUploadInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMBillUploadInfoEntity> ICMBillUploadInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMBillUploadInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMBillUploadInfoEntity> list = CreateEntityBuilder<CMBillUploadInfoEntity>().BuildEntities(reader);

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

        DataTable ICMBillUploadInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMBillUploadInfo_GET";

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
