// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Jan-2013, 04:16:20




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
    internal sealed partial class INVTRFStoreIssueNoteMapDataAccess : BaseDataAccess, IINVTRFStoreIssueNoteMapDataAccess
    {
        #region Constructors

        public INVTRFStoreIssueNoteMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<INVTRFStoreIssueNoteMapEntity> CreateEntityBuilder<INVTRFStoreIssueNoteMapEntity>()
        {
            return (new INVTRFStoreIssueNoteMapBuilder()) as IEntityBuilder<INVTRFStoreIssueNoteMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IINVTRFStoreIssueNoteMapDataAccess.Add(INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(iNVTRFStoreIssueNoteMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(iNVTRFStoreIssueNoteMapEntity, option);
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

        private Int64 Add(INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTRFStoreIssueNoteMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "TRFStoreIssueNoteMapID");

                Database.AddInParameter(cmd, "@StoreIssueNoteID", DbType.Int64, iNVTRFStoreIssueNoteMapEntity.StoreIssueNoteID);	
                Database.AddInParameter(cmd, "@TransferID", DbType.Int64, iNVTRFStoreIssueNoteMapEntity.TransferID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, iNVTRFStoreIssueNoteMapEntity.Remarks);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVTRFStoreIssueNoteMapEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVTRFStoreIssueNoteMapEntity already exists. Please specify another INVTRFStoreIssueNoteMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVTRFStoreIssueNoteMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVTRFStoreIssueNoteMapEntity already exists. Please specify another INVTRFStoreIssueNoteMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTRFStoreIssueNoteMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "TRFStoreIssueNoteMapID", db);

                db.AddInParameter(cmd, "@StoreIssueNoteID", DbType.Int64, iNVTRFStoreIssueNoteMapEntity.StoreIssueNoteID);
                db.AddInParameter(cmd, "@TransferID", DbType.Int64, iNVTRFStoreIssueNoteMapEntity.TransferID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, iNVTRFStoreIssueNoteMapEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVTRFStoreIssueNoteMapEntity.IsRemoved);

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

        IList<Int64> IINVTRFStoreIssueNoteMapDataAccess.Add(IList<INVTRFStoreIssueNoteMapEntity> iNVTRFStoreIssueNoteMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity in iNVTRFStoreIssueNoteMapEntityList)
            {
                returnCode = (this as IINVTRFStoreIssueNoteMapDataAccess).Add(iNVTRFStoreIssueNoteMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IINVTRFStoreIssueNoteMapDataAccess.Update(INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(iNVTRFStoreIssueNoteMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(iNVTRFStoreIssueNoteMapEntity, filterExpression, option);
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

        private Int64 Update(INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTRFStoreIssueNoteMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@TRFStoreIssueNoteMapID", DbType.Int64, iNVTRFStoreIssueNoteMapEntity.TRFStoreIssueNoteMapID);
                Database.AddInParameter(cmd, "@StoreIssueNoteID", DbType.Int64, iNVTRFStoreIssueNoteMapEntity.StoreIssueNoteID);
                Database.AddInParameter(cmd, "@TransferID", DbType.Int64, iNVTRFStoreIssueNoteMapEntity.TransferID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, iNVTRFStoreIssueNoteMapEntity.Remarks);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVTRFStoreIssueNoteMapEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVTRFStoreIssueNoteMapEntity already exists. Please specify another INVTRFStoreIssueNoteMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVTRFStoreIssueNoteMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVTRFStoreIssueNoteMapEntity already exists. Please specify another INVTRFStoreIssueNoteMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTRFStoreIssueNoteMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@TRFStoreIssueNoteMapID", DbType.Int64, iNVTRFStoreIssueNoteMapEntity.TRFStoreIssueNoteMapID);
                db.AddInParameter(cmd, "@StoreIssueNoteID", DbType.Int64, iNVTRFStoreIssueNoteMapEntity.StoreIssueNoteID);
                db.AddInParameter(cmd, "@TransferID", DbType.Int64, iNVTRFStoreIssueNoteMapEntity.TransferID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, iNVTRFStoreIssueNoteMapEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVTRFStoreIssueNoteMapEntity.IsRemoved);

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

        IList<Int64> IINVTRFStoreIssueNoteMapDataAccess.Update(IList<INVTRFStoreIssueNoteMapEntity> iNVTRFStoreIssueNoteMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity in iNVTRFStoreIssueNoteMapEntityList)
            {
                returnCode = (this as IINVTRFStoreIssueNoteMapDataAccess).Update(iNVTRFStoreIssueNoteMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IINVTRFStoreIssueNoteMapDataAccess.Delete(INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(iNVTRFStoreIssueNoteMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(iNVTRFStoreIssueNoteMapEntity, filterExpression, option);
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

        private Int64 Delete(INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTRFStoreIssueNoteMap_SET";

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
                                throw new ArgumentException("INVTRFStoreIssueNoteMapEntity already exists. Please specify another INVTRFStoreIssueNoteMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVTRFStoreIssueNoteMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVTRFStoreIssueNoteMapEntity already exists. Please specify another INVTRFStoreIssueNoteMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTRFStoreIssueNoteMap_SET";

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

        IList<Int64> IINVTRFStoreIssueNoteMapDataAccess.Delete(IList<INVTRFStoreIssueNoteMapEntity> iNVTRFStoreIssueNoteMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity in iNVTRFStoreIssueNoteMapEntityList)
            {
                returnCode = (this as IINVTRFStoreIssueNoteMapDataAccess).Delete(iNVTRFStoreIssueNoteMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<INVTRFStoreIssueNoteMapEntity> IINVTRFStoreIssueNoteMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVTRFStoreIssueNoteMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<INVTRFStoreIssueNoteMapEntity> list = CreateEntityBuilder<INVTRFStoreIssueNoteMapEntity>().BuildEntities(reader);

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

        DataTable IINVTRFStoreIssueNoteMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVTRFStoreIssueNoteMap_GET";

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
