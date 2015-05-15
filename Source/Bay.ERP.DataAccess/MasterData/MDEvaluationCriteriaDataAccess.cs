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
    internal sealed partial class MDEvaluationCriteriaDataAccess : BaseDataAccess, IMDEvaluationCriteriaDataAccess
    {
        #region Constructors

        public MDEvaluationCriteriaDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDEvaluationCriteriaEntity> CreateEntityBuilder<MDEvaluationCriteriaEntity>()
        {
            return (new MDEvaluationCriteriaBuilder()) as IEntityBuilder<MDEvaluationCriteriaEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDEvaluationCriteriaDataAccess.Add(MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDEvaluationCriteriaEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDEvaluationCriteriaEntity, option);
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

        private Int64 Add(MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEvaluationCriteria_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EvaluationCriteriaID");

                Database.AddInParameter(cmd, "@EvaluationCriteriaCategoryID", DbType.Int64, mDEvaluationCriteriaEntity.EvaluationCriteriaCategoryID);	
                Database.AddInParameter(cmd, "@SupervisorTypeID", DbType.Int64, mDEvaluationCriteriaEntity.SupervisorTypeID);	
                Database.AddInParameter(cmd, "@EvaluationSessionCategoryID", DbType.Int64, mDEvaluationCriteriaEntity.EvaluationSessionCategoryID);	
                Database.AddInParameter(cmd, "@Question", DbType.String, mDEvaluationCriteriaEntity.Question);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDEvaluationCriteriaEntity.Description);	
                Database.AddInParameter(cmd, "@CorrectAnswerIfAny", DbType.String, mDEvaluationCriteriaEntity.CorrectAnswerIfAny);	
                Database.AddInParameter(cmd, "@CorrectAnswerMarkOrPoint", DbType.Int32, mDEvaluationCriteriaEntity.CorrectAnswerMarkOrPoint);	
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, mDEvaluationCriteriaEntity.ImageUrl);	
                Database.AddInParameter(cmd, "@QuestionOrderInDisplay", DbType.Int32, mDEvaluationCriteriaEntity.QuestionOrderInDisplay);	
                Database.AddInParameter(cmd, "@SupervisorWillAnswer", DbType.Boolean, mDEvaluationCriteriaEntity.SupervisorWillAnswer);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEvaluationCriteriaEntity.IsRemoved);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, mDEvaluationCriteriaEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, mDEvaluationCriteriaEntity.CreateDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaEntity already exists. Please specify another MDEvaluationCriteriaEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaEntity already exists. Please specify another MDEvaluationCriteriaEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEvaluationCriteria_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EvaluationCriteriaID", db);

                db.AddInParameter(cmd, "@EvaluationCriteriaCategoryID", DbType.Int64, mDEvaluationCriteriaEntity.EvaluationCriteriaCategoryID);
                db.AddInParameter(cmd, "@SupervisorTypeID", DbType.Int64, mDEvaluationCriteriaEntity.SupervisorTypeID);
                db.AddInParameter(cmd, "@EvaluationSessionCategoryID", DbType.Int64, mDEvaluationCriteriaEntity.EvaluationSessionCategoryID);
                db.AddInParameter(cmd, "@Question", DbType.String, mDEvaluationCriteriaEntity.Question);
                db.AddInParameter(cmd, "@Description", DbType.String, mDEvaluationCriteriaEntity.Description);
                db.AddInParameter(cmd, "@CorrectAnswerIfAny", DbType.String, mDEvaluationCriteriaEntity.CorrectAnswerIfAny);
                db.AddInParameter(cmd, "@CorrectAnswerMarkOrPoint", DbType.Int32, mDEvaluationCriteriaEntity.CorrectAnswerMarkOrPoint);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, mDEvaluationCriteriaEntity.ImageUrl);
                db.AddInParameter(cmd, "@QuestionOrderInDisplay", DbType.Int32, mDEvaluationCriteriaEntity.QuestionOrderInDisplay);
                db.AddInParameter(cmd, "@SupervisorWillAnswer", DbType.Boolean, mDEvaluationCriteriaEntity.SupervisorWillAnswer);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEvaluationCriteriaEntity.IsRemoved);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, mDEvaluationCriteriaEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, mDEvaluationCriteriaEntity.CreateDate);

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

        IList<Int64> IMDEvaluationCriteriaDataAccess.Add(IList<MDEvaluationCriteriaEntity> mDEvaluationCriteriaEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity in mDEvaluationCriteriaEntityList)
            {
                returnCode = (this as IMDEvaluationCriteriaDataAccess).Add(mDEvaluationCriteriaEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDEvaluationCriteriaDataAccess.Update(MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDEvaluationCriteriaEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDEvaluationCriteriaEntity, filterExpression, option);
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

        private Int64 Update(MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEvaluationCriteria_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EvaluationCriteriaID", DbType.Int64, mDEvaluationCriteriaEntity.EvaluationCriteriaID);
                Database.AddInParameter(cmd, "@EvaluationCriteriaCategoryID", DbType.Int64, mDEvaluationCriteriaEntity.EvaluationCriteriaCategoryID);
                Database.AddInParameter(cmd, "@SupervisorTypeID", DbType.Int64, mDEvaluationCriteriaEntity.SupervisorTypeID);
                Database.AddInParameter(cmd, "@EvaluationSessionCategoryID", DbType.Int64, mDEvaluationCriteriaEntity.EvaluationSessionCategoryID);
                Database.AddInParameter(cmd, "@Question", DbType.String, mDEvaluationCriteriaEntity.Question);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDEvaluationCriteriaEntity.Description);
                Database.AddInParameter(cmd, "@CorrectAnswerIfAny", DbType.String, mDEvaluationCriteriaEntity.CorrectAnswerIfAny);
                Database.AddInParameter(cmd, "@CorrectAnswerMarkOrPoint", DbType.Int32, mDEvaluationCriteriaEntity.CorrectAnswerMarkOrPoint);
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, mDEvaluationCriteriaEntity.ImageUrl);
                Database.AddInParameter(cmd, "@QuestionOrderInDisplay", DbType.Int32, mDEvaluationCriteriaEntity.QuestionOrderInDisplay);
                Database.AddInParameter(cmd, "@SupervisorWillAnswer", DbType.Boolean, mDEvaluationCriteriaEntity.SupervisorWillAnswer);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEvaluationCriteriaEntity.IsRemoved);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, mDEvaluationCriteriaEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, mDEvaluationCriteriaEntity.CreateDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaEntity already exists. Please specify another MDEvaluationCriteriaEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaEntity already exists. Please specify another MDEvaluationCriteriaEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEvaluationCriteria_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EvaluationCriteriaID", DbType.Int64, mDEvaluationCriteriaEntity.EvaluationCriteriaID);
                db.AddInParameter(cmd, "@EvaluationCriteriaCategoryID", DbType.Int64, mDEvaluationCriteriaEntity.EvaluationCriteriaCategoryID);
                db.AddInParameter(cmd, "@SupervisorTypeID", DbType.Int64, mDEvaluationCriteriaEntity.SupervisorTypeID);
                db.AddInParameter(cmd, "@EvaluationSessionCategoryID", DbType.Int64, mDEvaluationCriteriaEntity.EvaluationSessionCategoryID);
                db.AddInParameter(cmd, "@Question", DbType.String, mDEvaluationCriteriaEntity.Question);
                db.AddInParameter(cmd, "@Description", DbType.String, mDEvaluationCriteriaEntity.Description);
                db.AddInParameter(cmd, "@CorrectAnswerIfAny", DbType.String, mDEvaluationCriteriaEntity.CorrectAnswerIfAny);
                db.AddInParameter(cmd, "@CorrectAnswerMarkOrPoint", DbType.Int32, mDEvaluationCriteriaEntity.CorrectAnswerMarkOrPoint);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, mDEvaluationCriteriaEntity.ImageUrl);
                db.AddInParameter(cmd, "@QuestionOrderInDisplay", DbType.Int32, mDEvaluationCriteriaEntity.QuestionOrderInDisplay);
                db.AddInParameter(cmd, "@SupervisorWillAnswer", DbType.Boolean, mDEvaluationCriteriaEntity.SupervisorWillAnswer);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEvaluationCriteriaEntity.IsRemoved);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, mDEvaluationCriteriaEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, mDEvaluationCriteriaEntity.CreateDate);

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

        IList<Int64> IMDEvaluationCriteriaDataAccess.Update(IList<MDEvaluationCriteriaEntity> mDEvaluationCriteriaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity in mDEvaluationCriteriaEntityList)
            {
                returnCode = (this as IMDEvaluationCriteriaDataAccess).Update(mDEvaluationCriteriaEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDEvaluationCriteriaDataAccess.Delete(MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDEvaluationCriteriaEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDEvaluationCriteriaEntity, filterExpression, option);
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

        private Int64 Delete(MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEvaluationCriteria_SET";

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
                                throw new ArgumentException("MDEvaluationCriteriaEntity already exists. Please specify another MDEvaluationCriteriaEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDEvaluationCriteriaEntity already exists. Please specify another MDEvaluationCriteriaEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEvaluationCriteria_SET";

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

        IList<Int64> IMDEvaluationCriteriaDataAccess.Delete(IList<MDEvaluationCriteriaEntity> mDEvaluationCriteriaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity in mDEvaluationCriteriaEntityList)
            {
                returnCode = (this as IMDEvaluationCriteriaDataAccess).Delete(mDEvaluationCriteriaEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDEvaluationCriteriaEntity> IMDEvaluationCriteriaDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDEvaluationCriteria_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDEvaluationCriteriaEntity> list = CreateEntityBuilder<MDEvaluationCriteriaEntity>().BuildEntities(reader);

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

        DataTable IMDEvaluationCriteriaDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDEvaluationCriteria_GET";

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
