// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




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
    internal sealed partial class MDEvaluationCriteriaCategoryDataAccess : BaseDataAccess, IMDEvaluationCriteriaCategoryDataAccess
    {
        #region Constructors

        public MDEvaluationCriteriaCategoryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDEvaluationCriteriaCategoryEntity> CreateEntityBuilder<MDEvaluationCriteriaCategoryEntity>()
        {
            return (new MDEvaluationCriteriaCategoryBuilder()) as IEntityBuilder<MDEvaluationCriteriaCategoryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDEvaluationCriteriaCategoryDataAccess.Add(MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDEvaluationCriteriaCategoryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDEvaluationCriteriaCategoryEntity, option);
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

        private Int64 Add(MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEvaluationCriteriaCategory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EvaluationCriteriaCategoryID");

                Database.AddInParameter(cmd, "@Name", DbType.String, mDEvaluationCriteriaCategoryEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDEvaluationCriteriaCategoryEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEvaluationCriteriaCategoryEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaCategoryEntity already exists. Please specify another MDEvaluationCriteriaCategoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaCategoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaCategoryEntity already exists. Please specify another MDEvaluationCriteriaCategoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEvaluationCriteriaCategory_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EvaluationCriteriaCategoryID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, mDEvaluationCriteriaCategoryEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDEvaluationCriteriaCategoryEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEvaluationCriteriaCategoryEntity.IsRemoved);

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

        IList<Int64> IMDEvaluationCriteriaCategoryDataAccess.Add(IList<MDEvaluationCriteriaCategoryEntity> mDEvaluationCriteriaCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity in mDEvaluationCriteriaCategoryEntityList)
            {
                returnCode = (this as IMDEvaluationCriteriaCategoryDataAccess).Add(mDEvaluationCriteriaCategoryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDEvaluationCriteriaCategoryDataAccess.Update(MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDEvaluationCriteriaCategoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDEvaluationCriteriaCategoryEntity, filterExpression, option);
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

        private Int64 Update(MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEvaluationCriteriaCategory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EvaluationCriteriaCategoryID", DbType.Int64, mDEvaluationCriteriaCategoryEntity.EvaluationCriteriaCategoryID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDEvaluationCriteriaCategoryEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDEvaluationCriteriaCategoryEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEvaluationCriteriaCategoryEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaCategoryEntity already exists. Please specify another MDEvaluationCriteriaCategoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaCategoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaCategoryEntity already exists. Please specify another MDEvaluationCriteriaCategoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEvaluationCriteriaCategory_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EvaluationCriteriaCategoryID", DbType.Int64, mDEvaluationCriteriaCategoryEntity.EvaluationCriteriaCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDEvaluationCriteriaCategoryEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDEvaluationCriteriaCategoryEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEvaluationCriteriaCategoryEntity.IsRemoved);

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

        IList<Int64> IMDEvaluationCriteriaCategoryDataAccess.Update(IList<MDEvaluationCriteriaCategoryEntity> mDEvaluationCriteriaCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity in mDEvaluationCriteriaCategoryEntityList)
            {
                returnCode = (this as IMDEvaluationCriteriaCategoryDataAccess).Update(mDEvaluationCriteriaCategoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDEvaluationCriteriaCategoryDataAccess.Delete(MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDEvaluationCriteriaCategoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDEvaluationCriteriaCategoryEntity, filterExpression, option);
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

        private Int64 Delete(MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEvaluationCriteriaCategory_SET";

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
                                throw new ArgumentException("MDEvaluationCriteriaCategoryEntity already exists. Please specify another MDEvaluationCriteriaCategoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaCategoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaCategoryEntity already exists. Please specify another MDEvaluationCriteriaCategoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEvaluationCriteriaCategory_SET";

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

        IList<Int64> IMDEvaluationCriteriaCategoryDataAccess.Delete(IList<MDEvaluationCriteriaCategoryEntity> mDEvaluationCriteriaCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity in mDEvaluationCriteriaCategoryEntityList)
            {
                returnCode = (this as IMDEvaluationCriteriaCategoryDataAccess).Delete(mDEvaluationCriteriaCategoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDEvaluationCriteriaCategoryEntity> IMDEvaluationCriteriaCategoryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDEvaluationCriteriaCategory_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDEvaluationCriteriaCategoryEntity> list = CreateEntityBuilder<MDEvaluationCriteriaCategoryEntity>().BuildEntities(reader);

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

        DataTable IMDEvaluationCriteriaCategoryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDEvaluationCriteriaCategory_GET";

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
