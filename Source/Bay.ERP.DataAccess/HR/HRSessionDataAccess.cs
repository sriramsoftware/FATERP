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
    internal sealed partial class HRSessionDataAccess : BaseDataAccess, IHRSessionDataAccess
    {
        #region Constructors

        public HRSessionDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HRSessionEntity> CreateEntityBuilder<HRSessionEntity>()
        {
            return (new HRSessionBuilder()) as IEntityBuilder<HRSessionEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHRSessionDataAccess.Add(HRSessionEntity hRSessionEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hRSessionEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hRSessionEntity, option);
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

        private Int64 Add(HRSessionEntity hRSessionEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRSession_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "SessionID");

                Database.AddInParameter(cmd, "@SessionCategoryID", DbType.Int64, hRSessionEntity.SessionCategoryID);	
                Database.AddInParameter(cmd, "@SessionName", DbType.String, hRSessionEntity.SessionName);	
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, hRSessionEntity.StartDate);	
                Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, hRSessionEntity.EndDate);	
                Database.AddInParameter(cmd, "@DeadlineDate", DbType.DateTime, hRSessionEntity.DeadlineDate);	
                Database.AddInParameter(cmd, "@EvaluationSessionStatusID", DbType.Int64, hRSessionEntity.EvaluationSessionStatusID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hRSessionEntity.Remarks);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, hRSessionEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hRSessionEntity.CreateDate);	
                Database.AddInParameter(cmd, "@IP", DbType.String, hRSessionEntity.IP);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRSessionEntity already exists. Please specify another HRSessionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRSessionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRSessionEntity already exists. Please specify another HRSessionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HRSessionEntity hRSessionEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRSession_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "SessionID", db);

                db.AddInParameter(cmd, "@SessionCategoryID", DbType.Int64, hRSessionEntity.SessionCategoryID);
                db.AddInParameter(cmd, "@SessionName", DbType.String, hRSessionEntity.SessionName);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, hRSessionEntity.StartDate);
                db.AddInParameter(cmd, "@EndDate", DbType.DateTime, hRSessionEntity.EndDate);
                db.AddInParameter(cmd, "@DeadlineDate", DbType.DateTime, hRSessionEntity.DeadlineDate);
                db.AddInParameter(cmd, "@EvaluationSessionStatusID", DbType.Int64, hRSessionEntity.EvaluationSessionStatusID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hRSessionEntity.Remarks);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, hRSessionEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hRSessionEntity.CreateDate);
                db.AddInParameter(cmd, "@IP", DbType.String, hRSessionEntity.IP);

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

        IList<Int64> IHRSessionDataAccess.Add(IList<HRSessionEntity> hRSessionEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HRSessionEntity hRSessionEntity in hRSessionEntityList)
            {
                returnCode = (this as IHRSessionDataAccess).Add(hRSessionEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHRSessionDataAccess.Update(HRSessionEntity hRSessionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hRSessionEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hRSessionEntity, filterExpression, option);
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

        private Int64 Update(HRSessionEntity hRSessionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRSession_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@SessionID", DbType.Int64, hRSessionEntity.SessionID);
                Database.AddInParameter(cmd, "@SessionCategoryID", DbType.Int64, hRSessionEntity.SessionCategoryID);
                Database.AddInParameter(cmd, "@SessionName", DbType.String, hRSessionEntity.SessionName);
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, hRSessionEntity.StartDate);
                Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, hRSessionEntity.EndDate);
                Database.AddInParameter(cmd, "@DeadlineDate", DbType.DateTime, hRSessionEntity.DeadlineDate);
                Database.AddInParameter(cmd, "@EvaluationSessionStatusID", DbType.Int64, hRSessionEntity.EvaluationSessionStatusID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hRSessionEntity.Remarks);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, hRSessionEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hRSessionEntity.CreateDate);
                Database.AddInParameter(cmd, "@IP", DbType.String, hRSessionEntity.IP);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRSessionEntity already exists. Please specify another HRSessionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRSessionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRSessionEntity already exists. Please specify another HRSessionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HRSessionEntity hRSessionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRSession_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@SessionID", DbType.Int64, hRSessionEntity.SessionID);
                db.AddInParameter(cmd, "@SessionCategoryID", DbType.Int64, hRSessionEntity.SessionCategoryID);
                db.AddInParameter(cmd, "@SessionName", DbType.String, hRSessionEntity.SessionName);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, hRSessionEntity.StartDate);
                db.AddInParameter(cmd, "@EndDate", DbType.DateTime, hRSessionEntity.EndDate);
                db.AddInParameter(cmd, "@DeadlineDate", DbType.DateTime, hRSessionEntity.DeadlineDate);
                db.AddInParameter(cmd, "@EvaluationSessionStatusID", DbType.Int64, hRSessionEntity.EvaluationSessionStatusID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hRSessionEntity.Remarks);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, hRSessionEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hRSessionEntity.CreateDate);
                db.AddInParameter(cmd, "@IP", DbType.String, hRSessionEntity.IP);

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

        IList<Int64> IHRSessionDataAccess.Update(IList<HRSessionEntity> hRSessionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HRSessionEntity hRSessionEntity in hRSessionEntityList)
            {
                returnCode = (this as IHRSessionDataAccess).Update(hRSessionEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHRSessionDataAccess.Delete(HRSessionEntity hRSessionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hRSessionEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hRSessionEntity, filterExpression, option);
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

        private Int64 Delete(HRSessionEntity hRSessionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRSession_SET";

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
                                throw new ArgumentException("HRSessionEntity already exists. Please specify another HRSessionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRSessionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRSessionEntity already exists. Please specify another HRSessionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HRSessionEntity hRSessionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRSession_SET";

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

        IList<Int64> IHRSessionDataAccess.Delete(IList<HRSessionEntity> hRSessionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HRSessionEntity hRSessionEntity in hRSessionEntityList)
            {
                returnCode = (this as IHRSessionDataAccess).Delete(hRSessionEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HRSessionEntity> IHRSessionDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRSession_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HRSessionEntity> list = CreateEntityBuilder<HRSessionEntity>().BuildEntities(reader);

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

        DataTable IHRSessionDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRSession_GET";

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
