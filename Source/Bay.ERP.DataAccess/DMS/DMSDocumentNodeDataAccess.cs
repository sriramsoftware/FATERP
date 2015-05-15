// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




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
    internal sealed partial class DMSDocumentNodeDataAccess : BaseDataAccess, IDMSDocumentNodeDataAccess
    {
        #region Constructors

        public DMSDocumentNodeDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<DMSDocumentNodeEntity> CreateEntityBuilder<DMSDocumentNodeEntity>()
        {
            return (new DMSDocumentNodeBuilder()) as IEntityBuilder<DMSDocumentNodeEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IDMSDocumentNodeDataAccess.Add(DMSDocumentNodeEntity dMSDocumentNodeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(dMSDocumentNodeEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(dMSDocumentNodeEntity, option);
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

        private Int64 Add(DMSDocumentNodeEntity dMSDocumentNodeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSDocumentNode_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "DocumentNodeID");

                Database.AddInParameter(cmd, "@ParentDocumentNodeID", DbType.Int64, dMSDocumentNodeEntity.ParentDocumentNodeID);	
                Database.AddInParameter(cmd, "@IsDocumentNodeType", DbType.Boolean, dMSDocumentNodeEntity.IsDocumentNodeType);	
                Database.AddInParameter(cmd, "@Name", DbType.String, dMSDocumentNodeEntity.Name);	
                Database.AddInParameter(cmd, "@DocumentStorageTypeID", DbType.Int64, dMSDocumentNodeEntity.DocumentStorageTypeID);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, dMSDocumentNodeEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@Extension", DbType.String, dMSDocumentNodeEntity.Extension);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, dMSDocumentNodeEntity.Remarks);	
                Database.AddInParameter(cmd, "@Path", DbType.String, dMSDocumentNodeEntity.Path);	
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, dMSDocumentNodeEntity.OriginalFileName);	
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, dMSDocumentNodeEntity.CurrentFileName);	
                Database.AddInParameter(cmd, "@FileType", DbType.String, dMSDocumentNodeEntity.FileType);	
                Database.AddInParameter(cmd, "@TagKeyword", DbType.String, dMSDocumentNodeEntity.TagKeyword);	
                Database.AddInParameter(cmd, "@IsStarred", DbType.Boolean, dMSDocumentNodeEntity.IsStarred);	
                Database.AddInParameter(cmd, "@IsArchived", DbType.Boolean, dMSDocumentNodeEntity.IsArchived);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, dMSDocumentNodeEntity.IsRemoved);	
                Database.AddInParameter(cmd, "@UploadedByMemberID", DbType.Int64, dMSDocumentNodeEntity.UploadedByMemberID);	
                Database.AddInParameter(cmd, "@OwnerTypeID", DbType.Int64, dMSDocumentNodeEntity.OwnerTypeID);	
                Database.AddInParameter(cmd, "@OwnerReferenceID", DbType.Int64, dMSDocumentNodeEntity.OwnerReferenceID);	
                Database.AddInParameter(cmd, "@QuotaUsed", DbType.Decimal, dMSDocumentNodeEntity.QuotaUsed);	
                Database.AddInParameter(cmd, "@LastModifiedDate", DbType.DateTime, dMSDocumentNodeEntity.LastModifiedDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("DMSDocumentNodeEntity already exists. Please specify another DMSDocumentNodeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("DMSDocumentNodeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("DMSDocumentNodeEntity already exists. Please specify another DMSDocumentNodeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(DMSDocumentNodeEntity dMSDocumentNodeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSDocumentNode_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "DocumentNodeID", db);

                db.AddInParameter(cmd, "@ParentDocumentNodeID", DbType.Int64, dMSDocumentNodeEntity.ParentDocumentNodeID);
                db.AddInParameter(cmd, "@IsDocumentNodeType", DbType.Boolean, dMSDocumentNodeEntity.IsDocumentNodeType);
                db.AddInParameter(cmd, "@Name", DbType.String, dMSDocumentNodeEntity.Name);
                db.AddInParameter(cmd, "@DocumentStorageTypeID", DbType.Int64, dMSDocumentNodeEntity.DocumentStorageTypeID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, dMSDocumentNodeEntity.ReferenceID);
                db.AddInParameter(cmd, "@Extension", DbType.String, dMSDocumentNodeEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, dMSDocumentNodeEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, dMSDocumentNodeEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, dMSDocumentNodeEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, dMSDocumentNodeEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, dMSDocumentNodeEntity.FileType);
                db.AddInParameter(cmd, "@TagKeyword", DbType.String, dMSDocumentNodeEntity.TagKeyword);
                db.AddInParameter(cmd, "@IsStarred", DbType.Boolean, dMSDocumentNodeEntity.IsStarred);
                db.AddInParameter(cmd, "@IsArchived", DbType.Boolean, dMSDocumentNodeEntity.IsArchived);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, dMSDocumentNodeEntity.IsRemoved);
                db.AddInParameter(cmd, "@UploadedByMemberID", DbType.Int64, dMSDocumentNodeEntity.UploadedByMemberID);
                db.AddInParameter(cmd, "@OwnerTypeID", DbType.Int64, dMSDocumentNodeEntity.OwnerTypeID);
                db.AddInParameter(cmd, "@OwnerReferenceID", DbType.Int64, dMSDocumentNodeEntity.OwnerReferenceID);
                db.AddInParameter(cmd, "@QuotaUsed", DbType.Decimal, dMSDocumentNodeEntity.QuotaUsed);
                db.AddInParameter(cmd, "@LastModifiedDate", DbType.DateTime, dMSDocumentNodeEntity.LastModifiedDate);

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

        IList<Int64> IDMSDocumentNodeDataAccess.Add(IList<DMSDocumentNodeEntity> dMSDocumentNodeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (DMSDocumentNodeEntity dMSDocumentNodeEntity in dMSDocumentNodeEntityList)
            {
                returnCode = (this as IDMSDocumentNodeDataAccess).Add(dMSDocumentNodeEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IDMSDocumentNodeDataAccess.Update(DMSDocumentNodeEntity dMSDocumentNodeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(dMSDocumentNodeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(dMSDocumentNodeEntity, filterExpression, option);
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

        private Int64 Update(DMSDocumentNodeEntity dMSDocumentNodeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSDocumentNode_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@DocumentNodeID", DbType.Int64, dMSDocumentNodeEntity.DocumentNodeID);
                Database.AddInParameter(cmd, "@ParentDocumentNodeID", DbType.Int64, dMSDocumentNodeEntity.ParentDocumentNodeID);
                Database.AddInParameter(cmd, "@IsDocumentNodeType", DbType.Boolean, dMSDocumentNodeEntity.IsDocumentNodeType);
                Database.AddInParameter(cmd, "@Name", DbType.String, dMSDocumentNodeEntity.Name);
                Database.AddInParameter(cmd, "@DocumentStorageTypeID", DbType.Int64, dMSDocumentNodeEntity.DocumentStorageTypeID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, dMSDocumentNodeEntity.ReferenceID);
                Database.AddInParameter(cmd, "@Extension", DbType.String, dMSDocumentNodeEntity.Extension);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, dMSDocumentNodeEntity.Remarks);
                Database.AddInParameter(cmd, "@Path", DbType.String, dMSDocumentNodeEntity.Path);
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, dMSDocumentNodeEntity.OriginalFileName);
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, dMSDocumentNodeEntity.CurrentFileName);
                Database.AddInParameter(cmd, "@FileType", DbType.String, dMSDocumentNodeEntity.FileType);
                Database.AddInParameter(cmd, "@TagKeyword", DbType.String, dMSDocumentNodeEntity.TagKeyword);
                Database.AddInParameter(cmd, "@IsStarred", DbType.Boolean, dMSDocumentNodeEntity.IsStarred);
                Database.AddInParameter(cmd, "@IsArchived", DbType.Boolean, dMSDocumentNodeEntity.IsArchived);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, dMSDocumentNodeEntity.IsRemoved);
                Database.AddInParameter(cmd, "@UploadedByMemberID", DbType.Int64, dMSDocumentNodeEntity.UploadedByMemberID);
                Database.AddInParameter(cmd, "@OwnerTypeID", DbType.Int64, dMSDocumentNodeEntity.OwnerTypeID);
                Database.AddInParameter(cmd, "@OwnerReferenceID", DbType.Int64, dMSDocumentNodeEntity.OwnerReferenceID);
                Database.AddInParameter(cmd, "@QuotaUsed", DbType.Decimal, dMSDocumentNodeEntity.QuotaUsed);
                Database.AddInParameter(cmd, "@LastModifiedDate", DbType.DateTime, dMSDocumentNodeEntity.LastModifiedDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("DMSDocumentNodeEntity already exists. Please specify another DMSDocumentNodeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("DMSDocumentNodeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("DMSDocumentNodeEntity already exists. Please specify another DMSDocumentNodeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(DMSDocumentNodeEntity dMSDocumentNodeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSDocumentNode_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@DocumentNodeID", DbType.Int64, dMSDocumentNodeEntity.DocumentNodeID);
                db.AddInParameter(cmd, "@ParentDocumentNodeID", DbType.Int64, dMSDocumentNodeEntity.ParentDocumentNodeID);
                db.AddInParameter(cmd, "@IsDocumentNodeType", DbType.Boolean, dMSDocumentNodeEntity.IsDocumentNodeType);
                db.AddInParameter(cmd, "@Name", DbType.String, dMSDocumentNodeEntity.Name);
                db.AddInParameter(cmd, "@DocumentStorageTypeID", DbType.Int64, dMSDocumentNodeEntity.DocumentStorageTypeID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, dMSDocumentNodeEntity.ReferenceID);
                db.AddInParameter(cmd, "@Extension", DbType.String, dMSDocumentNodeEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, dMSDocumentNodeEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, dMSDocumentNodeEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, dMSDocumentNodeEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, dMSDocumentNodeEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, dMSDocumentNodeEntity.FileType);
                db.AddInParameter(cmd, "@TagKeyword", DbType.String, dMSDocumentNodeEntity.TagKeyword);
                db.AddInParameter(cmd, "@IsStarred", DbType.Boolean, dMSDocumentNodeEntity.IsStarred);
                db.AddInParameter(cmd, "@IsArchived", DbType.Boolean, dMSDocumentNodeEntity.IsArchived);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, dMSDocumentNodeEntity.IsRemoved);
                db.AddInParameter(cmd, "@UploadedByMemberID", DbType.Int64, dMSDocumentNodeEntity.UploadedByMemberID);
                db.AddInParameter(cmd, "@OwnerTypeID", DbType.Int64, dMSDocumentNodeEntity.OwnerTypeID);
                db.AddInParameter(cmd, "@OwnerReferenceID", DbType.Int64, dMSDocumentNodeEntity.OwnerReferenceID);
                db.AddInParameter(cmd, "@QuotaUsed", DbType.Decimal, dMSDocumentNodeEntity.QuotaUsed);
                db.AddInParameter(cmd, "@LastModifiedDate", DbType.DateTime, dMSDocumentNodeEntity.LastModifiedDate);

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

        IList<Int64> IDMSDocumentNodeDataAccess.Update(IList<DMSDocumentNodeEntity> dMSDocumentNodeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (DMSDocumentNodeEntity dMSDocumentNodeEntity in dMSDocumentNodeEntityList)
            {
                returnCode = (this as IDMSDocumentNodeDataAccess).Update(dMSDocumentNodeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IDMSDocumentNodeDataAccess.Delete(DMSDocumentNodeEntity dMSDocumentNodeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(dMSDocumentNodeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(dMSDocumentNodeEntity, filterExpression, option);
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

        private Int64 Delete(DMSDocumentNodeEntity dMSDocumentNodeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSDocumentNode_SET";

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
                                throw new ArgumentException("DMSDocumentNodeEntity already exists. Please specify another DMSDocumentNodeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("DMSDocumentNodeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("DMSDocumentNodeEntity already exists. Please specify another DMSDocumentNodeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(DMSDocumentNodeEntity dMSDocumentNodeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSDocumentNode_SET";

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

        IList<Int64> IDMSDocumentNodeDataAccess.Delete(IList<DMSDocumentNodeEntity> dMSDocumentNodeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (DMSDocumentNodeEntity dMSDocumentNodeEntity in dMSDocumentNodeEntityList)
            {
                returnCode = (this as IDMSDocumentNodeDataAccess).Delete(dMSDocumentNodeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<DMSDocumentNodeEntity> IDMSDocumentNodeDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.DMSDocumentNode_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<DMSDocumentNodeEntity> list = CreateEntityBuilder<DMSDocumentNodeEntity>().BuildEntities(reader);

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

        DataTable IDMSDocumentNodeDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.DMSDocumentNode_GET";

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
