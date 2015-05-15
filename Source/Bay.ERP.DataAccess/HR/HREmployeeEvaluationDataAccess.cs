// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Sep-2013, 01:42:20




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
    internal sealed partial class HREmployeeEvaluationDataAccess : BaseDataAccess, IHREmployeeEvaluationDataAccess
    {
        #region Constructors

        public HREmployeeEvaluationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeEvaluationEntity> CreateEntityBuilder<HREmployeeEvaluationEntity>()
        {
            return (new HREmployeeEvaluationBuilder()) as IEntityBuilder<HREmployeeEvaluationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeEvaluationDataAccess.Add(HREmployeeEvaluationEntity hREmployeeEvaluationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeEvaluationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeEvaluationEntity, option);
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

        private Int64 Add(HREmployeeEvaluationEntity hREmployeeEvaluationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEvaluation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeEvaluationID");

                Database.AddInParameter(cmd, "@SessionID", DbType.Int64, hREmployeeEvaluationEntity.SessionID);	
                Database.AddInParameter(cmd, "@EvaluationName", DbType.String, hREmployeeEvaluationEntity.EvaluationName);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEvaluationEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@EmployeeFullName", DbType.String, hREmployeeEvaluationEntity.EmployeeFullName);	
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeEvaluationEntity.EmployeeCode);	
                Database.AddInParameter(cmd, "@EmployeeDepartmentName", DbType.String, hREmployeeEvaluationEntity.EmployeeDepartmentName);	
                Database.AddInParameter(cmd, "@EmployeeLevel", DbType.String, hREmployeeEvaluationEntity.EmployeeLevel);	
                Database.AddInParameter(cmd, "@SupervisorEmployeeID", DbType.Int64, hREmployeeEvaluationEntity.SupervisorEmployeeID);	
                Database.AddInParameter(cmd, "@SupervisorFullName", DbType.String, hREmployeeEvaluationEntity.SupervisorFullName);	
                Database.AddInParameter(cmd, "@SupervisorEmployeeCode", DbType.String, hREmployeeEvaluationEntity.SupervisorEmployeeCode);	
                Database.AddInParameter(cmd, "@SupervisorEmployeeDepartmentName", DbType.String, hREmployeeEvaluationEntity.SupervisorEmployeeDepartmentName);	
                Database.AddInParameter(cmd, "@SupervisorEmployeeLevel", DbType.String, hREmployeeEvaluationEntity.SupervisorEmployeeLevel);	
                Database.AddInParameter(cmd, "@EmployeeSubmitDate", DbType.DateTime, hREmployeeEvaluationEntity.EmployeeSubmitDate);	
                Database.AddInParameter(cmd, "@SupervisorSubmitDate", DbType.DateTime, hREmployeeEvaluationEntity.SupervisorSubmitDate);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeEvaluationEntity.CreateDate);	
                Database.AddInParameter(cmd, "@EvaluatedByID", DbType.Int64, hREmployeeEvaluationEntity.EvaluatedByID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeEvaluationEntity.Remarks);	
                Database.AddInParameter(cmd, "@Extra", DbType.String, hREmployeeEvaluationEntity.Extra);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeEvaluationEntity already exists. Please specify another HREmployeeEvaluationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEvaluationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEvaluationEntity already exists. Please specify another HREmployeeEvaluationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeEvaluationEntity hREmployeeEvaluationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEvaluation_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeEvaluationID", db);

                db.AddInParameter(cmd, "@SessionID", DbType.Int64, hREmployeeEvaluationEntity.SessionID);
                db.AddInParameter(cmd, "@EvaluationName", DbType.String, hREmployeeEvaluationEntity.EvaluationName);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEvaluationEntity.EmployeeID);
                db.AddInParameter(cmd, "@EmployeeFullName", DbType.String, hREmployeeEvaluationEntity.EmployeeFullName);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeEvaluationEntity.EmployeeCode);
                db.AddInParameter(cmd, "@EmployeeDepartmentName", DbType.String, hREmployeeEvaluationEntity.EmployeeDepartmentName);
                db.AddInParameter(cmd, "@EmployeeLevel", DbType.String, hREmployeeEvaluationEntity.EmployeeLevel);
                db.AddInParameter(cmd, "@SupervisorEmployeeID", DbType.Int64, hREmployeeEvaluationEntity.SupervisorEmployeeID);
                db.AddInParameter(cmd, "@SupervisorFullName", DbType.String, hREmployeeEvaluationEntity.SupervisorFullName);
                db.AddInParameter(cmd, "@SupervisorEmployeeCode", DbType.String, hREmployeeEvaluationEntity.SupervisorEmployeeCode);
                db.AddInParameter(cmd, "@SupervisorEmployeeDepartmentName", DbType.String, hREmployeeEvaluationEntity.SupervisorEmployeeDepartmentName);
                db.AddInParameter(cmd, "@SupervisorEmployeeLevel", DbType.String, hREmployeeEvaluationEntity.SupervisorEmployeeLevel);
                db.AddInParameter(cmd, "@EmployeeSubmitDate", DbType.DateTime, hREmployeeEvaluationEntity.EmployeeSubmitDate);
                db.AddInParameter(cmd, "@SupervisorSubmitDate", DbType.DateTime, hREmployeeEvaluationEntity.SupervisorSubmitDate);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeEvaluationEntity.CreateDate);
                db.AddInParameter(cmd, "@EvaluatedByID", DbType.Int64, hREmployeeEvaluationEntity.EvaluatedByID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeEvaluationEntity.Remarks);
                db.AddInParameter(cmd, "@Extra", DbType.String, hREmployeeEvaluationEntity.Extra);

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

        IList<Int64> IHREmployeeEvaluationDataAccess.Add(IList<HREmployeeEvaluationEntity> hREmployeeEvaluationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeEvaluationEntity hREmployeeEvaluationEntity in hREmployeeEvaluationEntityList)
            {
                returnCode = (this as IHREmployeeEvaluationDataAccess).Add(hREmployeeEvaluationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeEvaluationDataAccess.Update(HREmployeeEvaluationEntity hREmployeeEvaluationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeEvaluationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeEvaluationEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeEvaluationEntity hREmployeeEvaluationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEvaluation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeEvaluationID", DbType.Int64, hREmployeeEvaluationEntity.EmployeeEvaluationID);
                Database.AddInParameter(cmd, "@SessionID", DbType.Int64, hREmployeeEvaluationEntity.SessionID);
                Database.AddInParameter(cmd, "@EvaluationName", DbType.String, hREmployeeEvaluationEntity.EvaluationName);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEvaluationEntity.EmployeeID);
                Database.AddInParameter(cmd, "@EmployeeFullName", DbType.String, hREmployeeEvaluationEntity.EmployeeFullName);
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeEvaluationEntity.EmployeeCode);
                Database.AddInParameter(cmd, "@EmployeeDepartmentName", DbType.String, hREmployeeEvaluationEntity.EmployeeDepartmentName);
                Database.AddInParameter(cmd, "@EmployeeLevel", DbType.String, hREmployeeEvaluationEntity.EmployeeLevel);
                Database.AddInParameter(cmd, "@SupervisorEmployeeID", DbType.Int64, hREmployeeEvaluationEntity.SupervisorEmployeeID);
                Database.AddInParameter(cmd, "@SupervisorFullName", DbType.String, hREmployeeEvaluationEntity.SupervisorFullName);
                Database.AddInParameter(cmd, "@SupervisorEmployeeCode", DbType.String, hREmployeeEvaluationEntity.SupervisorEmployeeCode);
                Database.AddInParameter(cmd, "@SupervisorEmployeeDepartmentName", DbType.String, hREmployeeEvaluationEntity.SupervisorEmployeeDepartmentName);
                Database.AddInParameter(cmd, "@SupervisorEmployeeLevel", DbType.String, hREmployeeEvaluationEntity.SupervisorEmployeeLevel);
                Database.AddInParameter(cmd, "@EmployeeSubmitDate", DbType.DateTime, hREmployeeEvaluationEntity.EmployeeSubmitDate);
                Database.AddInParameter(cmd, "@SupervisorSubmitDate", DbType.DateTime, hREmployeeEvaluationEntity.SupervisorSubmitDate);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeEvaluationEntity.CreateDate);
                Database.AddInParameter(cmd, "@EvaluatedByID", DbType.Int64, hREmployeeEvaluationEntity.EvaluatedByID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeEvaluationEntity.Remarks);
                Database.AddInParameter(cmd, "@Extra", DbType.String, hREmployeeEvaluationEntity.Extra);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeEvaluationEntity already exists. Please specify another HREmployeeEvaluationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEvaluationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEvaluationEntity already exists. Please specify another HREmployeeEvaluationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeEvaluationEntity hREmployeeEvaluationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEvaluation_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeEvaluationID", DbType.Int64, hREmployeeEvaluationEntity.EmployeeEvaluationID);
                db.AddInParameter(cmd, "@SessionID", DbType.Int64, hREmployeeEvaluationEntity.SessionID);
                db.AddInParameter(cmd, "@EvaluationName", DbType.String, hREmployeeEvaluationEntity.EvaluationName);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEvaluationEntity.EmployeeID);
                db.AddInParameter(cmd, "@EmployeeFullName", DbType.String, hREmployeeEvaluationEntity.EmployeeFullName);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeEvaluationEntity.EmployeeCode);
                db.AddInParameter(cmd, "@EmployeeDepartmentName", DbType.String, hREmployeeEvaluationEntity.EmployeeDepartmentName);
                db.AddInParameter(cmd, "@EmployeeLevel", DbType.String, hREmployeeEvaluationEntity.EmployeeLevel);
                db.AddInParameter(cmd, "@SupervisorEmployeeID", DbType.Int64, hREmployeeEvaluationEntity.SupervisorEmployeeID);
                db.AddInParameter(cmd, "@SupervisorFullName", DbType.String, hREmployeeEvaluationEntity.SupervisorFullName);
                db.AddInParameter(cmd, "@SupervisorEmployeeCode", DbType.String, hREmployeeEvaluationEntity.SupervisorEmployeeCode);
                db.AddInParameter(cmd, "@SupervisorEmployeeDepartmentName", DbType.String, hREmployeeEvaluationEntity.SupervisorEmployeeDepartmentName);
                db.AddInParameter(cmd, "@SupervisorEmployeeLevel", DbType.String, hREmployeeEvaluationEntity.SupervisorEmployeeLevel);
                db.AddInParameter(cmd, "@EmployeeSubmitDate", DbType.DateTime, hREmployeeEvaluationEntity.EmployeeSubmitDate);
                db.AddInParameter(cmd, "@SupervisorSubmitDate", DbType.DateTime, hREmployeeEvaluationEntity.SupervisorSubmitDate);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeEvaluationEntity.CreateDate);
                db.AddInParameter(cmd, "@EvaluatedByID", DbType.Int64, hREmployeeEvaluationEntity.EvaluatedByID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeEvaluationEntity.Remarks);
                db.AddInParameter(cmd, "@Extra", DbType.String, hREmployeeEvaluationEntity.Extra);

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

        IList<Int64> IHREmployeeEvaluationDataAccess.Update(IList<HREmployeeEvaluationEntity> hREmployeeEvaluationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeEvaluationEntity hREmployeeEvaluationEntity in hREmployeeEvaluationEntityList)
            {
                returnCode = (this as IHREmployeeEvaluationDataAccess).Update(hREmployeeEvaluationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeEvaluationDataAccess.Delete(HREmployeeEvaluationEntity hREmployeeEvaluationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeEvaluationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeEvaluationEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeEvaluationEntity hREmployeeEvaluationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEvaluation_SET";

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
                                throw new ArgumentException("HREmployeeEvaluationEntity already exists. Please specify another HREmployeeEvaluationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEvaluationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEvaluationEntity already exists. Please specify another HREmployeeEvaluationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeEvaluationEntity hREmployeeEvaluationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEvaluation_SET";

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

        IList<Int64> IHREmployeeEvaluationDataAccess.Delete(IList<HREmployeeEvaluationEntity> hREmployeeEvaluationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeEvaluationEntity hREmployeeEvaluationEntity in hREmployeeEvaluationEntityList)
            {
                returnCode = (this as IHREmployeeEvaluationDataAccess).Delete(hREmployeeEvaluationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeEvaluationEntity> IHREmployeeEvaluationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeEvaluation_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeEvaluationEntity> list = CreateEntityBuilder<HREmployeeEvaluationEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeEvaluationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeEvaluation_GET";

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
