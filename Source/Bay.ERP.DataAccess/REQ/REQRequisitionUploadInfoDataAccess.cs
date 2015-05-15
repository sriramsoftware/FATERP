// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Nov-2013, 09:51:38




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
    internal sealed partial class REQRequisitionUploadInfoDataAccess : BaseDataAccess, IREQRequisitionUploadInfoDataAccess
    {
        #region Constructors

        public REQRequisitionUploadInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<REQRequisitionUploadInfoEntity> CreateEntityBuilder<REQRequisitionUploadInfoEntity>()
        {
            return (new REQRequisitionUploadInfoBuilder()) as IEntityBuilder<REQRequisitionUploadInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IREQRequisitionUploadInfoDataAccess.Add(REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(rEQRequisitionUploadInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(rEQRequisitionUploadInfoEntity, option);
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

        private Int64 Add(REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionUploadInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "RequisitionUploadInfoID");

                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionUploadInfoEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@Extension", DbType.String, rEQRequisitionUploadInfoEntity.Extension);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionUploadInfoEntity.Remarks);	
                Database.AddInParameter(cmd, "@Path", DbType.String, rEQRequisitionUploadInfoEntity.Path);	
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, rEQRequisitionUploadInfoEntity.OriginalFileName);	
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, rEQRequisitionUploadInfoEntity.CurrentFileName);	
                Database.AddInParameter(cmd, "@FileType", DbType.String, rEQRequisitionUploadInfoEntity.FileType);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("REQRequisitionUploadInfoEntity already exists. Please specify another REQRequisitionUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("REQRequisitionUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("REQRequisitionUploadInfoEntity already exists. Please specify another REQRequisitionUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionUploadInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "RequisitionUploadInfoID", db);

                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionUploadInfoEntity.RequisitionID);
                db.AddInParameter(cmd, "@Extension", DbType.String, rEQRequisitionUploadInfoEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionUploadInfoEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, rEQRequisitionUploadInfoEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, rEQRequisitionUploadInfoEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, rEQRequisitionUploadInfoEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, rEQRequisitionUploadInfoEntity.FileType);

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

        IList<Int64> IREQRequisitionUploadInfoDataAccess.Add(IList<REQRequisitionUploadInfoEntity> rEQRequisitionUploadInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity in rEQRequisitionUploadInfoEntityList)
            {
                returnCode = (this as IREQRequisitionUploadInfoDataAccess).Add(rEQRequisitionUploadInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IREQRequisitionUploadInfoDataAccess.Update(REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(rEQRequisitionUploadInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(rEQRequisitionUploadInfoEntity, filterExpression, option);
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

        private Int64 Update(REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionUploadInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@RequisitionUploadInfoID", DbType.Int64, rEQRequisitionUploadInfoEntity.RequisitionUploadInfoID);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionUploadInfoEntity.RequisitionID);
                Database.AddInParameter(cmd, "@Extension", DbType.String, rEQRequisitionUploadInfoEntity.Extension);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionUploadInfoEntity.Remarks);
                Database.AddInParameter(cmd, "@Path", DbType.String, rEQRequisitionUploadInfoEntity.Path);
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, rEQRequisitionUploadInfoEntity.OriginalFileName);
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, rEQRequisitionUploadInfoEntity.CurrentFileName);
                Database.AddInParameter(cmd, "@FileType", DbType.String, rEQRequisitionUploadInfoEntity.FileType);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("REQRequisitionUploadInfoEntity already exists. Please specify another REQRequisitionUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("REQRequisitionUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("REQRequisitionUploadInfoEntity already exists. Please specify another REQRequisitionUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionUploadInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@RequisitionUploadInfoID", DbType.Int64, rEQRequisitionUploadInfoEntity.RequisitionUploadInfoID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionUploadInfoEntity.RequisitionID);
                db.AddInParameter(cmd, "@Extension", DbType.String, rEQRequisitionUploadInfoEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionUploadInfoEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, rEQRequisitionUploadInfoEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, rEQRequisitionUploadInfoEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, rEQRequisitionUploadInfoEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, rEQRequisitionUploadInfoEntity.FileType);

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

        IList<Int64> IREQRequisitionUploadInfoDataAccess.Update(IList<REQRequisitionUploadInfoEntity> rEQRequisitionUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity in rEQRequisitionUploadInfoEntityList)
            {
                returnCode = (this as IREQRequisitionUploadInfoDataAccess).Update(rEQRequisitionUploadInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IREQRequisitionUploadInfoDataAccess.Delete(REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(rEQRequisitionUploadInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(rEQRequisitionUploadInfoEntity, filterExpression, option);
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

        private Int64 Delete(REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionUploadInfo_SET";

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
                                throw new ArgumentException("REQRequisitionUploadInfoEntity already exists. Please specify another REQRequisitionUploadInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("REQRequisitionUploadInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("REQRequisitionUploadInfoEntity already exists. Please specify another REQRequisitionUploadInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionUploadInfo_SET";

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

        IList<Int64> IREQRequisitionUploadInfoDataAccess.Delete(IList<REQRequisitionUploadInfoEntity> rEQRequisitionUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity in rEQRequisitionUploadInfoEntityList)
            {
                returnCode = (this as IREQRequisitionUploadInfoDataAccess).Delete(rEQRequisitionUploadInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<REQRequisitionUploadInfoEntity> IREQRequisitionUploadInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.REQRequisitionUploadInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<REQRequisitionUploadInfoEntity> list = CreateEntityBuilder<REQRequisitionUploadInfoEntity>().BuildEntities(reader);

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

        DataTable IREQRequisitionUploadInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.REQRequisitionUploadInfo_GET";

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
