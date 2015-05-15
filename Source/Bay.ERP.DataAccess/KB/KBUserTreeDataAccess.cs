// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Mar-2013, 04:24:50




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
    internal sealed partial class KBUserTreeDataAccess : BaseDataAccess, IKBUserTreeDataAccess
    {
        #region Constructors

        public KBUserTreeDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<KBUserTreeEntity> CreateEntityBuilder<KBUserTreeEntity>()
        {
            return (new KBUserTreeBuilder()) as IEntityBuilder<KBUserTreeEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IKBUserTreeDataAccess.Add(KBUserTreeEntity kBUserTreeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(kBUserTreeEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(kBUserTreeEntity, option);
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

        private Int64 Add(KBUserTreeEntity kBUserTreeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTree_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "UserTreeID");

                Database.AddInParameter(cmd, "@ParentUserTreeID", DbType.Int64, kBUserTreeEntity.ParentUserTreeID);	
                Database.AddInParameter(cmd, "@IsDocumentNodeType", DbType.Boolean, kBUserTreeEntity.IsDocumentNodeType);	
                Database.AddInParameter(cmd, "@Title", DbType.String, kBUserTreeEntity.Title);	
                Database.AddInParameter(cmd, "@Description", DbType.String, kBUserTreeEntity.Description);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, kBUserTreeEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@TagKeyword", DbType.String, kBUserTreeEntity.TagKeyword);	
                Database.AddInParameter(cmd, "@IsStarred", DbType.Boolean, kBUserTreeEntity.IsStarred);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, kBUserTreeEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, kBUserTreeEntity.CreateDate);	
                Database.AddInParameter(cmd, "@OwnerEmployeeID", DbType.Int64, kBUserTreeEntity.OwnerEmployeeID);	
                Database.AddInParameter(cmd, "@DocumentSize", DbType.Decimal, kBUserTreeEntity.DocumentSize);	
                Database.AddInParameter(cmd, "@LastModifiedDate", DbType.DateTime, kBUserTreeEntity.LastModifiedDate);	
                Database.AddInParameter(cmd, "@IP", DbType.String, kBUserTreeEntity.IP);	
                Database.AddInParameter(cmd, "@UserTreeStatusID", DbType.Int64, kBUserTreeEntity.UserTreeStatusID);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, kBUserTreeEntity.IsRemoved);	
                Database.AddInParameter(cmd, "@CountViewState", DbType.Int64, kBUserTreeEntity.CountViewState);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("KBUserTreeEntity already exists. Please specify another KBUserTreeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("KBUserTreeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("KBUserTreeEntity already exists. Please specify another KBUserTreeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(KBUserTreeEntity kBUserTreeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTree_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "UserTreeID", db);

                db.AddInParameter(cmd, "@ParentUserTreeID", DbType.Int64, kBUserTreeEntity.ParentUserTreeID);
                db.AddInParameter(cmd, "@IsDocumentNodeType", DbType.Boolean, kBUserTreeEntity.IsDocumentNodeType);
                db.AddInParameter(cmd, "@Title", DbType.String, kBUserTreeEntity.Title);
                db.AddInParameter(cmd, "@Description", DbType.String, kBUserTreeEntity.Description);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, kBUserTreeEntity.ReferenceID);
                db.AddInParameter(cmd, "@TagKeyword", DbType.String, kBUserTreeEntity.TagKeyword);
                db.AddInParameter(cmd, "@IsStarred", DbType.Boolean, kBUserTreeEntity.IsStarred);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, kBUserTreeEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, kBUserTreeEntity.CreateDate);
                db.AddInParameter(cmd, "@OwnerEmployeeID", DbType.Int64, kBUserTreeEntity.OwnerEmployeeID);
                db.AddInParameter(cmd, "@DocumentSize", DbType.Decimal, kBUserTreeEntity.DocumentSize);
                db.AddInParameter(cmd, "@LastModifiedDate", DbType.DateTime, kBUserTreeEntity.LastModifiedDate);
                db.AddInParameter(cmd, "@IP", DbType.String, kBUserTreeEntity.IP);
                db.AddInParameter(cmd, "@UserTreeStatusID", DbType.Int64, kBUserTreeEntity.UserTreeStatusID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, kBUserTreeEntity.IsRemoved);
                db.AddInParameter(cmd, "@CountViewState", DbType.Int64, kBUserTreeEntity.CountViewState);

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

        IList<Int64> IKBUserTreeDataAccess.Add(IList<KBUserTreeEntity> kBUserTreeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (KBUserTreeEntity kBUserTreeEntity in kBUserTreeEntityList)
            {
                returnCode = (this as IKBUserTreeDataAccess).Add(kBUserTreeEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IKBUserTreeDataAccess.Update(KBUserTreeEntity kBUserTreeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(kBUserTreeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(kBUserTreeEntity, filterExpression, option);
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

        private Int64 Update(KBUserTreeEntity kBUserTreeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTree_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeEntity.UserTreeID);
                Database.AddInParameter(cmd, "@ParentUserTreeID", DbType.Int64, kBUserTreeEntity.ParentUserTreeID);
                Database.AddInParameter(cmd, "@IsDocumentNodeType", DbType.Boolean, kBUserTreeEntity.IsDocumentNodeType);
                Database.AddInParameter(cmd, "@Title", DbType.String, kBUserTreeEntity.Title);
                Database.AddInParameter(cmd, "@Description", DbType.String, kBUserTreeEntity.Description);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, kBUserTreeEntity.ReferenceID);
                Database.AddInParameter(cmd, "@TagKeyword", DbType.String, kBUserTreeEntity.TagKeyword);
                Database.AddInParameter(cmd, "@IsStarred", DbType.Boolean, kBUserTreeEntity.IsStarred);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, kBUserTreeEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, kBUserTreeEntity.CreateDate);
                Database.AddInParameter(cmd, "@OwnerEmployeeID", DbType.Int64, kBUserTreeEntity.OwnerEmployeeID);
                Database.AddInParameter(cmd, "@DocumentSize", DbType.Decimal, kBUserTreeEntity.DocumentSize);
                Database.AddInParameter(cmd, "@LastModifiedDate", DbType.DateTime, kBUserTreeEntity.LastModifiedDate);
                Database.AddInParameter(cmd, "@IP", DbType.String, kBUserTreeEntity.IP);
                Database.AddInParameter(cmd, "@UserTreeStatusID", DbType.Int64, kBUserTreeEntity.UserTreeStatusID);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, kBUserTreeEntity.IsRemoved);
                Database.AddInParameter(cmd, "@CountViewState", DbType.Int64, kBUserTreeEntity.CountViewState);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("KBUserTreeEntity already exists. Please specify another KBUserTreeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("KBUserTreeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("KBUserTreeEntity already exists. Please specify another KBUserTreeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(KBUserTreeEntity kBUserTreeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTree_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeEntity.UserTreeID);
                db.AddInParameter(cmd, "@ParentUserTreeID", DbType.Int64, kBUserTreeEntity.ParentUserTreeID);
                db.AddInParameter(cmd, "@IsDocumentNodeType", DbType.Boolean, kBUserTreeEntity.IsDocumentNodeType);
                db.AddInParameter(cmd, "@Title", DbType.String, kBUserTreeEntity.Title);
                db.AddInParameter(cmd, "@Description", DbType.String, kBUserTreeEntity.Description);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, kBUserTreeEntity.ReferenceID);
                db.AddInParameter(cmd, "@TagKeyword", DbType.String, kBUserTreeEntity.TagKeyword);
                db.AddInParameter(cmd, "@IsStarred", DbType.Boolean, kBUserTreeEntity.IsStarred);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, kBUserTreeEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, kBUserTreeEntity.CreateDate);
                db.AddInParameter(cmd, "@OwnerEmployeeID", DbType.Int64, kBUserTreeEntity.OwnerEmployeeID);
                db.AddInParameter(cmd, "@DocumentSize", DbType.Decimal, kBUserTreeEntity.DocumentSize);
                db.AddInParameter(cmd, "@LastModifiedDate", DbType.DateTime, kBUserTreeEntity.LastModifiedDate);
                db.AddInParameter(cmd, "@IP", DbType.String, kBUserTreeEntity.IP);
                db.AddInParameter(cmd, "@UserTreeStatusID", DbType.Int64, kBUserTreeEntity.UserTreeStatusID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, kBUserTreeEntity.IsRemoved);
                db.AddInParameter(cmd, "@CountViewState", DbType.Int64, kBUserTreeEntity.CountViewState);

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

        IList<Int64> IKBUserTreeDataAccess.Update(IList<KBUserTreeEntity> kBUserTreeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (KBUserTreeEntity kBUserTreeEntity in kBUserTreeEntityList)
            {
                returnCode = (this as IKBUserTreeDataAccess).Update(kBUserTreeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IKBUserTreeDataAccess.Delete(KBUserTreeEntity kBUserTreeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(kBUserTreeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(kBUserTreeEntity, filterExpression, option);
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

        private Int64 Delete(KBUserTreeEntity kBUserTreeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTree_SET";

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
                                throw new ArgumentException("KBUserTreeEntity already exists. Please specify another KBUserTreeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("KBUserTreeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("KBUserTreeEntity already exists. Please specify another KBUserTreeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(KBUserTreeEntity kBUserTreeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTree_SET";

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

        IList<Int64> IKBUserTreeDataAccess.Delete(IList<KBUserTreeEntity> kBUserTreeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (KBUserTreeEntity kBUserTreeEntity in kBUserTreeEntityList)
            {
                returnCode = (this as IKBUserTreeDataAccess).Delete(kBUserTreeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<KBUserTreeEntity> IKBUserTreeDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.KBUserTree_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<KBUserTreeEntity> list = CreateEntityBuilder<KBUserTreeEntity>().BuildEntities(reader);

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

        DataTable IKBUserTreeDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.KBUserTree_GET";

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
