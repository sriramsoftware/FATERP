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
    internal sealed partial class KBUserTreeModifiedHistoryDataAccess : BaseDataAccess, IKBUserTreeModifiedHistoryDataAccess
    {
        #region Constructors

        public KBUserTreeModifiedHistoryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<KBUserTreeModifiedHistoryEntity> CreateEntityBuilder<KBUserTreeModifiedHistoryEntity>()
        {
            return (new KBUserTreeModifiedHistoryBuilder()) as IEntityBuilder<KBUserTreeModifiedHistoryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IKBUserTreeModifiedHistoryDataAccess.Add(KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(kBUserTreeModifiedHistoryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(kBUserTreeModifiedHistoryEntity, option);
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

        private Int64 Add(KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeModifiedHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "UserTreeHistoryID");

                Database.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.UserTreeID);	
                Database.AddInParameter(cmd, "@IsDocumentNodeType", DbType.Boolean, kBUserTreeModifiedHistoryEntity.IsDocumentNodeType);	
                Database.AddInParameter(cmd, "@Title", DbType.String, kBUserTreeModifiedHistoryEntity.Title);	
                Database.AddInParameter(cmd, "@Description", DbType.String, kBUserTreeModifiedHistoryEntity.Description);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, kBUserTreeModifiedHistoryEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@TagKeyword", DbType.String, kBUserTreeModifiedHistoryEntity.TagKeyword);	
                Database.AddInParameter(cmd, "@IsStarred", DbType.Boolean, kBUserTreeModifiedHistoryEntity.IsStarred);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, kBUserTreeModifiedHistoryEntity.CreateDate);	
                Database.AddInParameter(cmd, "@OwnerEmployeeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.OwnerEmployeeID);	
                Database.AddInParameter(cmd, "@DocumentSize", DbType.Decimal, kBUserTreeModifiedHistoryEntity.DocumentSize);	
                Database.AddInParameter(cmd, "@LastModifiedDate", DbType.DateTime, kBUserTreeModifiedHistoryEntity.LastModifiedDate);	
                Database.AddInParameter(cmd, "@UserTreeStatusID", DbType.Int64, kBUserTreeModifiedHistoryEntity.UserTreeStatusID);	
                Database.AddInParameter(cmd, "@CountViewState", DbType.Int64, kBUserTreeModifiedHistoryEntity.CountViewState);	
                Database.AddInParameter(cmd, "@ModifiedDate", DbType.DateTime, kBUserTreeModifiedHistoryEntity.ModifiedDate);	
                Database.AddInParameter(cmd, "@ModifiedEmployeeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.ModifiedEmployeeID);	
                Database.AddInParameter(cmd, "@IP", DbType.String, kBUserTreeModifiedHistoryEntity.IP);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("KBUserTreeModifiedHistoryEntity already exists. Please specify another KBUserTreeModifiedHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("KBUserTreeModifiedHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("KBUserTreeModifiedHistoryEntity already exists. Please specify another KBUserTreeModifiedHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeModifiedHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "UserTreeHistoryID", db);

                db.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.UserTreeID);
                db.AddInParameter(cmd, "@IsDocumentNodeType", DbType.Boolean, kBUserTreeModifiedHistoryEntity.IsDocumentNodeType);
                db.AddInParameter(cmd, "@Title", DbType.String, kBUserTreeModifiedHistoryEntity.Title);
                db.AddInParameter(cmd, "@Description", DbType.String, kBUserTreeModifiedHistoryEntity.Description);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, kBUserTreeModifiedHistoryEntity.ReferenceID);
                db.AddInParameter(cmd, "@TagKeyword", DbType.String, kBUserTreeModifiedHistoryEntity.TagKeyword);
                db.AddInParameter(cmd, "@IsStarred", DbType.Boolean, kBUserTreeModifiedHistoryEntity.IsStarred);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, kBUserTreeModifiedHistoryEntity.CreateDate);
                db.AddInParameter(cmd, "@OwnerEmployeeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.OwnerEmployeeID);
                db.AddInParameter(cmd, "@DocumentSize", DbType.Decimal, kBUserTreeModifiedHistoryEntity.DocumentSize);
                db.AddInParameter(cmd, "@LastModifiedDate", DbType.DateTime, kBUserTreeModifiedHistoryEntity.LastModifiedDate);
                db.AddInParameter(cmd, "@UserTreeStatusID", DbType.Int64, kBUserTreeModifiedHistoryEntity.UserTreeStatusID);
                db.AddInParameter(cmd, "@CountViewState", DbType.Int64, kBUserTreeModifiedHistoryEntity.CountViewState);
                db.AddInParameter(cmd, "@ModifiedDate", DbType.DateTime, kBUserTreeModifiedHistoryEntity.ModifiedDate);
                db.AddInParameter(cmd, "@ModifiedEmployeeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.ModifiedEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, kBUserTreeModifiedHistoryEntity.IP);

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

        IList<Int64> IKBUserTreeModifiedHistoryDataAccess.Add(IList<KBUserTreeModifiedHistoryEntity> kBUserTreeModifiedHistoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity in kBUserTreeModifiedHistoryEntityList)
            {
                returnCode = (this as IKBUserTreeModifiedHistoryDataAccess).Add(kBUserTreeModifiedHistoryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IKBUserTreeModifiedHistoryDataAccess.Update(KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(kBUserTreeModifiedHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(kBUserTreeModifiedHistoryEntity, filterExpression, option);
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

        private Int64 Update(KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeModifiedHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@UserTreeHistoryID", DbType.Int64, kBUserTreeModifiedHistoryEntity.UserTreeHistoryID);
                Database.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.UserTreeID);
                Database.AddInParameter(cmd, "@IsDocumentNodeType", DbType.Boolean, kBUserTreeModifiedHistoryEntity.IsDocumentNodeType);
                Database.AddInParameter(cmd, "@Title", DbType.String, kBUserTreeModifiedHistoryEntity.Title);
                Database.AddInParameter(cmd, "@Description", DbType.String, kBUserTreeModifiedHistoryEntity.Description);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, kBUserTreeModifiedHistoryEntity.ReferenceID);
                Database.AddInParameter(cmd, "@TagKeyword", DbType.String, kBUserTreeModifiedHistoryEntity.TagKeyword);
                Database.AddInParameter(cmd, "@IsStarred", DbType.Boolean, kBUserTreeModifiedHistoryEntity.IsStarred);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, kBUserTreeModifiedHistoryEntity.CreateDate);
                Database.AddInParameter(cmd, "@OwnerEmployeeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.OwnerEmployeeID);
                Database.AddInParameter(cmd, "@DocumentSize", DbType.Decimal, kBUserTreeModifiedHistoryEntity.DocumentSize);
                Database.AddInParameter(cmd, "@LastModifiedDate", DbType.DateTime, kBUserTreeModifiedHistoryEntity.LastModifiedDate);
                Database.AddInParameter(cmd, "@UserTreeStatusID", DbType.Int64, kBUserTreeModifiedHistoryEntity.UserTreeStatusID);
                Database.AddInParameter(cmd, "@CountViewState", DbType.Int64, kBUserTreeModifiedHistoryEntity.CountViewState);
                Database.AddInParameter(cmd, "@ModifiedDate", DbType.DateTime, kBUserTreeModifiedHistoryEntity.ModifiedDate);
                Database.AddInParameter(cmd, "@ModifiedEmployeeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.ModifiedEmployeeID);
                Database.AddInParameter(cmd, "@IP", DbType.String, kBUserTreeModifiedHistoryEntity.IP);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("KBUserTreeModifiedHistoryEntity already exists. Please specify another KBUserTreeModifiedHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("KBUserTreeModifiedHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("KBUserTreeModifiedHistoryEntity already exists. Please specify another KBUserTreeModifiedHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeModifiedHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@UserTreeHistoryID", DbType.Int64, kBUserTreeModifiedHistoryEntity.UserTreeHistoryID);
                db.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.UserTreeID);
                db.AddInParameter(cmd, "@IsDocumentNodeType", DbType.Boolean, kBUserTreeModifiedHistoryEntity.IsDocumentNodeType);
                db.AddInParameter(cmd, "@Title", DbType.String, kBUserTreeModifiedHistoryEntity.Title);
                db.AddInParameter(cmd, "@Description", DbType.String, kBUserTreeModifiedHistoryEntity.Description);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, kBUserTreeModifiedHistoryEntity.ReferenceID);
                db.AddInParameter(cmd, "@TagKeyword", DbType.String, kBUserTreeModifiedHistoryEntity.TagKeyword);
                db.AddInParameter(cmd, "@IsStarred", DbType.Boolean, kBUserTreeModifiedHistoryEntity.IsStarred);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, kBUserTreeModifiedHistoryEntity.CreateDate);
                db.AddInParameter(cmd, "@OwnerEmployeeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.OwnerEmployeeID);
                db.AddInParameter(cmd, "@DocumentSize", DbType.Decimal, kBUserTreeModifiedHistoryEntity.DocumentSize);
                db.AddInParameter(cmd, "@LastModifiedDate", DbType.DateTime, kBUserTreeModifiedHistoryEntity.LastModifiedDate);
                db.AddInParameter(cmd, "@UserTreeStatusID", DbType.Int64, kBUserTreeModifiedHistoryEntity.UserTreeStatusID);
                db.AddInParameter(cmd, "@CountViewState", DbType.Int64, kBUserTreeModifiedHistoryEntity.CountViewState);
                db.AddInParameter(cmd, "@ModifiedDate", DbType.DateTime, kBUserTreeModifiedHistoryEntity.ModifiedDate);
                db.AddInParameter(cmd, "@ModifiedEmployeeID", DbType.Int64, kBUserTreeModifiedHistoryEntity.ModifiedEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, kBUserTreeModifiedHistoryEntity.IP);

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

        IList<Int64> IKBUserTreeModifiedHistoryDataAccess.Update(IList<KBUserTreeModifiedHistoryEntity> kBUserTreeModifiedHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity in kBUserTreeModifiedHistoryEntityList)
            {
                returnCode = (this as IKBUserTreeModifiedHistoryDataAccess).Update(kBUserTreeModifiedHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IKBUserTreeModifiedHistoryDataAccess.Delete(KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(kBUserTreeModifiedHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(kBUserTreeModifiedHistoryEntity, filterExpression, option);
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

        private Int64 Delete(KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeModifiedHistory_SET";

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
                                throw new ArgumentException("KBUserTreeModifiedHistoryEntity already exists. Please specify another KBUserTreeModifiedHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("KBUserTreeModifiedHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("KBUserTreeModifiedHistoryEntity already exists. Please specify another KBUserTreeModifiedHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeModifiedHistory_SET";

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

        IList<Int64> IKBUserTreeModifiedHistoryDataAccess.Delete(IList<KBUserTreeModifiedHistoryEntity> kBUserTreeModifiedHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity in kBUserTreeModifiedHistoryEntityList)
            {
                returnCode = (this as IKBUserTreeModifiedHistoryDataAccess).Delete(kBUserTreeModifiedHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<KBUserTreeModifiedHistoryEntity> IKBUserTreeModifiedHistoryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.KBUserTreeModifiedHistory_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<KBUserTreeModifiedHistoryEntity> list = CreateEntityBuilder<KBUserTreeModifiedHistoryEntity>().BuildEntities(reader);

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

        DataTable IKBUserTreeModifiedHistoryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.KBUserTreeModifiedHistory_GET";

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
