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
    internal sealed partial class INVStoreIssueNoteDataAccess : BaseDataAccess, IINVStoreIssueNoteDataAccess
    {
        #region Constructors

        public INVStoreIssueNoteDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<INVStoreIssueNoteEntity> CreateEntityBuilder<INVStoreIssueNoteEntity>()
        {
            return (new INVStoreIssueNoteBuilder()) as IEntityBuilder<INVStoreIssueNoteEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IINVStoreIssueNoteDataAccess.Add(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(iNVStoreIssueNoteEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(iNVStoreIssueNoteEntity, option);
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

        private Int64 Add(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreIssueNote_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "StoreIssueNoteID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, iNVStoreIssueNoteEntity.ProjectID);	
                Database.AddInParameter(cmd, "@StoreIssueNoteNo", DbType.String, iNVStoreIssueNoteEntity.StoreIssueNoteNo);	
                Database.AddInParameter(cmd, "@SRFNo", DbType.String, iNVStoreIssueNoteEntity.SRFNo);	
                Database.AddInParameter(cmd, "@RequestedByEmployeeID", DbType.Int64, iNVStoreIssueNoteEntity.RequestedByEmployeeID);	
                Database.AddInParameter(cmd, "@RequestDate", DbType.DateTime, iNVStoreIssueNoteEntity.RequestDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, iNVStoreIssueNoteEntity.Remarks);	
                Database.AddInParameter(cmd, "@StoreIssueNoteApprovalStatusID", DbType.Int64, iNVStoreIssueNoteEntity.StoreIssueNoteApprovalStatusID);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVStoreIssueNoteEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVStoreIssueNoteEntity already exists. Please specify another INVStoreIssueNoteEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVStoreIssueNoteEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVStoreIssueNoteEntity already exists. Please specify another INVStoreIssueNoteEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreIssueNote_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "StoreIssueNoteID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, iNVStoreIssueNoteEntity.ProjectID);
                db.AddInParameter(cmd, "@StoreIssueNoteNo", DbType.String, iNVStoreIssueNoteEntity.StoreIssueNoteNo);
                db.AddInParameter(cmd, "@SRFNo", DbType.String, iNVStoreIssueNoteEntity.SRFNo);
                db.AddInParameter(cmd, "@RequestedByEmployeeID", DbType.Int64, iNVStoreIssueNoteEntity.RequestedByEmployeeID);
                db.AddInParameter(cmd, "@RequestDate", DbType.DateTime, iNVStoreIssueNoteEntity.RequestDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, iNVStoreIssueNoteEntity.Remarks);
                db.AddInParameter(cmd, "@StoreIssueNoteApprovalStatusID", DbType.Int64, iNVStoreIssueNoteEntity.StoreIssueNoteApprovalStatusID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVStoreIssueNoteEntity.IsRemoved);

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

        IList<Int64> IINVStoreIssueNoteDataAccess.Add(IList<INVStoreIssueNoteEntity> iNVStoreIssueNoteEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (INVStoreIssueNoteEntity iNVStoreIssueNoteEntity in iNVStoreIssueNoteEntityList)
            {
                returnCode = (this as IINVStoreIssueNoteDataAccess).Add(iNVStoreIssueNoteEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IINVStoreIssueNoteDataAccess.Update(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(iNVStoreIssueNoteEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(iNVStoreIssueNoteEntity, filterExpression, option);
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

        private Int64 Update(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreIssueNote_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@StoreIssueNoteID", DbType.Int64, iNVStoreIssueNoteEntity.StoreIssueNoteID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, iNVStoreIssueNoteEntity.ProjectID);
                Database.AddInParameter(cmd, "@StoreIssueNoteNo", DbType.String, iNVStoreIssueNoteEntity.StoreIssueNoteNo);
                Database.AddInParameter(cmd, "@SRFNo", DbType.String, iNVStoreIssueNoteEntity.SRFNo);
                Database.AddInParameter(cmd, "@RequestedByEmployeeID", DbType.Int64, iNVStoreIssueNoteEntity.RequestedByEmployeeID);
                Database.AddInParameter(cmd, "@RequestDate", DbType.DateTime, iNVStoreIssueNoteEntity.RequestDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, iNVStoreIssueNoteEntity.Remarks);
                Database.AddInParameter(cmd, "@StoreIssueNoteApprovalStatusID", DbType.Int64, iNVStoreIssueNoteEntity.StoreIssueNoteApprovalStatusID);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVStoreIssueNoteEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVStoreIssueNoteEntity already exists. Please specify another INVStoreIssueNoteEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVStoreIssueNoteEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVStoreIssueNoteEntity already exists. Please specify another INVStoreIssueNoteEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreIssueNote_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@StoreIssueNoteID", DbType.Int64, iNVStoreIssueNoteEntity.StoreIssueNoteID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, iNVStoreIssueNoteEntity.ProjectID);
                db.AddInParameter(cmd, "@StoreIssueNoteNo", DbType.String, iNVStoreIssueNoteEntity.StoreIssueNoteNo);
                db.AddInParameter(cmd, "@SRFNo", DbType.String, iNVStoreIssueNoteEntity.SRFNo);
                db.AddInParameter(cmd, "@RequestedByEmployeeID", DbType.Int64, iNVStoreIssueNoteEntity.RequestedByEmployeeID);
                db.AddInParameter(cmd, "@RequestDate", DbType.DateTime, iNVStoreIssueNoteEntity.RequestDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, iNVStoreIssueNoteEntity.Remarks);
                db.AddInParameter(cmd, "@StoreIssueNoteApprovalStatusID", DbType.Int64, iNVStoreIssueNoteEntity.StoreIssueNoteApprovalStatusID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVStoreIssueNoteEntity.IsRemoved);

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

        IList<Int64> IINVStoreIssueNoteDataAccess.Update(IList<INVStoreIssueNoteEntity> iNVStoreIssueNoteEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (INVStoreIssueNoteEntity iNVStoreIssueNoteEntity in iNVStoreIssueNoteEntityList)
            {
                returnCode = (this as IINVStoreIssueNoteDataAccess).Update(iNVStoreIssueNoteEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IINVStoreIssueNoteDataAccess.Delete(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(iNVStoreIssueNoteEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(iNVStoreIssueNoteEntity, filterExpression, option);
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

        private Int64 Delete(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreIssueNote_SET";

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
                                throw new ArgumentException("INVStoreIssueNoteEntity already exists. Please specify another INVStoreIssueNoteEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVStoreIssueNoteEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVStoreIssueNoteEntity already exists. Please specify another INVStoreIssueNoteEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreIssueNote_SET";

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

        IList<Int64> IINVStoreIssueNoteDataAccess.Delete(IList<INVStoreIssueNoteEntity> iNVStoreIssueNoteEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (INVStoreIssueNoteEntity iNVStoreIssueNoteEntity in iNVStoreIssueNoteEntityList)
            {
                returnCode = (this as IINVStoreIssueNoteDataAccess).Delete(iNVStoreIssueNoteEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<INVStoreIssueNoteEntity> IINVStoreIssueNoteDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVStoreIssueNote_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<INVStoreIssueNoteEntity> list = CreateEntityBuilder<INVStoreIssueNoteEntity>().BuildEntities(reader);

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

        DataTable IINVStoreIssueNoteDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVStoreIssueNote_GET";

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
