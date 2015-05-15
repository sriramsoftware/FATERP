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
    internal sealed partial class CMNERPCommentDataAccess : BaseDataAccess, ICMNERPCommentDataAccess
    {
        #region Constructors

        public CMNERPCommentDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMNERPCommentEntity> CreateEntityBuilder<CMNERPCommentEntity>()
        {
            return (new CMNERPCommentBuilder()) as IEntityBuilder<CMNERPCommentEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMNERPCommentDataAccess.Add(CMNERPCommentEntity cMNERPCommentEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMNERPCommentEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMNERPCommentEntity, option);
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

        private Int64 Add(CMNERPCommentEntity cMNERPCommentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNERPComment_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "CommentID");

                Database.AddInParameter(cmd, "@ProcessCategoryID", DbType.Int64, cMNERPCommentEntity.ProcessCategoryID);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cMNERPCommentEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@Comment", DbType.String, cMNERPCommentEntity.Comment);	
                Database.AddInParameter(cmd, "@CommentDate", DbType.DateTime, cMNERPCommentEntity.CommentDate);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, cMNERPCommentEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cMNERPCommentEntity.IP);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNERPCommentEntity already exists. Please specify another CMNERPCommentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNERPCommentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNERPCommentEntity already exists. Please specify another CMNERPCommentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMNERPCommentEntity cMNERPCommentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNERPComment_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "CommentID", db);

                db.AddInParameter(cmd, "@ProcessCategoryID", DbType.Int64, cMNERPCommentEntity.ProcessCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cMNERPCommentEntity.ReferenceID);
                db.AddInParameter(cmd, "@Comment", DbType.String, cMNERPCommentEntity.Comment);
                db.AddInParameter(cmd, "@CommentDate", DbType.DateTime, cMNERPCommentEntity.CommentDate);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, cMNERPCommentEntity.EmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cMNERPCommentEntity.IP);

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

        IList<Int64> ICMNERPCommentDataAccess.Add(IList<CMNERPCommentEntity> cMNERPCommentEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMNERPCommentEntity cMNERPCommentEntity in cMNERPCommentEntityList)
            {
                returnCode = (this as ICMNERPCommentDataAccess).Add(cMNERPCommentEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMNERPCommentDataAccess.Update(CMNERPCommentEntity cMNERPCommentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMNERPCommentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMNERPCommentEntity, filterExpression, option);
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

        private Int64 Update(CMNERPCommentEntity cMNERPCommentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNERPComment_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@CommentID", DbType.Int64, cMNERPCommentEntity.CommentID);
                Database.AddInParameter(cmd, "@ProcessCategoryID", DbType.Int64, cMNERPCommentEntity.ProcessCategoryID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cMNERPCommentEntity.ReferenceID);
                Database.AddInParameter(cmd, "@Comment", DbType.String, cMNERPCommentEntity.Comment);
                Database.AddInParameter(cmd, "@CommentDate", DbType.DateTime, cMNERPCommentEntity.CommentDate);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, cMNERPCommentEntity.EmployeeID);
                Database.AddInParameter(cmd, "@IP", DbType.String, cMNERPCommentEntity.IP);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNERPCommentEntity already exists. Please specify another CMNERPCommentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNERPCommentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNERPCommentEntity already exists. Please specify another CMNERPCommentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMNERPCommentEntity cMNERPCommentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNERPComment_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@CommentID", DbType.Int64, cMNERPCommentEntity.CommentID);
                db.AddInParameter(cmd, "@ProcessCategoryID", DbType.Int64, cMNERPCommentEntity.ProcessCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cMNERPCommentEntity.ReferenceID);
                db.AddInParameter(cmd, "@Comment", DbType.String, cMNERPCommentEntity.Comment);
                db.AddInParameter(cmd, "@CommentDate", DbType.DateTime, cMNERPCommentEntity.CommentDate);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, cMNERPCommentEntity.EmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cMNERPCommentEntity.IP);

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

        IList<Int64> ICMNERPCommentDataAccess.Update(IList<CMNERPCommentEntity> cMNERPCommentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMNERPCommentEntity cMNERPCommentEntity in cMNERPCommentEntityList)
            {
                returnCode = (this as ICMNERPCommentDataAccess).Update(cMNERPCommentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMNERPCommentDataAccess.Delete(CMNERPCommentEntity cMNERPCommentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMNERPCommentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMNERPCommentEntity, filterExpression, option);
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

        private Int64 Delete(CMNERPCommentEntity cMNERPCommentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNERPComment_SET";

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
                                throw new ArgumentException("CMNERPCommentEntity already exists. Please specify another CMNERPCommentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNERPCommentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNERPCommentEntity already exists. Please specify another CMNERPCommentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMNERPCommentEntity cMNERPCommentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNERPComment_SET";

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

        IList<Int64> ICMNERPCommentDataAccess.Delete(IList<CMNERPCommentEntity> cMNERPCommentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMNERPCommentEntity cMNERPCommentEntity in cMNERPCommentEntityList)
            {
                returnCode = (this as ICMNERPCommentDataAccess).Delete(cMNERPCommentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMNERPCommentEntity> ICMNERPCommentDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNERPComment_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMNERPCommentEntity> list = CreateEntityBuilder<CMNERPCommentEntity>().BuildEntities(reader);

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

        DataTable ICMNERPCommentDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNERPComment_GET";

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
