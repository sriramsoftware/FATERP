// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    internal sealed partial class MDEmployeeCompetencyLevelDataAccess : BaseDataAccess, IMDEmployeeCompetencyLevelDataAccess
    {
        #region Constructors

        public MDEmployeeCompetencyLevelDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDEmployeeCompetencyLevelEntity> CreateEntityBuilder<MDEmployeeCompetencyLevelEntity>()
        {
            return (new MDEmployeeCompetencyLevelBuilder()) as IEntityBuilder<MDEmployeeCompetencyLevelEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDEmployeeCompetencyLevelDataAccess.Add(MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDEmployeeCompetencyLevelEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDEmployeeCompetencyLevelEntity, option);
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

        private Int64 Add(MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEmployeeCompetencyLevel_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeCompetencyLevelID");

                Database.AddInParameter(cmd, "@Name", DbType.String, mDEmployeeCompetencyLevelEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDEmployeeCompetencyLevelEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEmployeeCompetencyLevelEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDEmployeeCompetencyLevelEntity already exists. Please specify another MDEmployeeCompetencyLevelEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDEmployeeCompetencyLevelEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDEmployeeCompetencyLevelEntity already exists. Please specify another MDEmployeeCompetencyLevelEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEmployeeCompetencyLevel_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeCompetencyLevelID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, mDEmployeeCompetencyLevelEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDEmployeeCompetencyLevelEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEmployeeCompetencyLevelEntity.IsRemoved);

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

        IList<Int64> IMDEmployeeCompetencyLevelDataAccess.Add(IList<MDEmployeeCompetencyLevelEntity> mDEmployeeCompetencyLevelEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity in mDEmployeeCompetencyLevelEntityList)
            {
                returnCode = (this as IMDEmployeeCompetencyLevelDataAccess).Add(mDEmployeeCompetencyLevelEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDEmployeeCompetencyLevelDataAccess.Update(MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDEmployeeCompetencyLevelEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDEmployeeCompetencyLevelEntity, filterExpression, option);
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

        private Int64 Update(MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEmployeeCompetencyLevel_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeCompetencyLevelID", DbType.Int64, mDEmployeeCompetencyLevelEntity.EmployeeCompetencyLevelID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDEmployeeCompetencyLevelEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDEmployeeCompetencyLevelEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEmployeeCompetencyLevelEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDEmployeeCompetencyLevelEntity already exists. Please specify another MDEmployeeCompetencyLevelEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDEmployeeCompetencyLevelEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDEmployeeCompetencyLevelEntity already exists. Please specify another MDEmployeeCompetencyLevelEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEmployeeCompetencyLevel_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeCompetencyLevelID", DbType.Int64, mDEmployeeCompetencyLevelEntity.EmployeeCompetencyLevelID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDEmployeeCompetencyLevelEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDEmployeeCompetencyLevelEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEmployeeCompetencyLevelEntity.IsRemoved);

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

        IList<Int64> IMDEmployeeCompetencyLevelDataAccess.Update(IList<MDEmployeeCompetencyLevelEntity> mDEmployeeCompetencyLevelEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity in mDEmployeeCompetencyLevelEntityList)
            {
                returnCode = (this as IMDEmployeeCompetencyLevelDataAccess).Update(mDEmployeeCompetencyLevelEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDEmployeeCompetencyLevelDataAccess.Delete(MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDEmployeeCompetencyLevelEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDEmployeeCompetencyLevelEntity, filterExpression, option);
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

        private Int64 Delete(MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEmployeeCompetencyLevel_SET";

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
                                throw new ArgumentException("MDEmployeeCompetencyLevelEntity already exists. Please specify another MDEmployeeCompetencyLevelEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDEmployeeCompetencyLevelEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDEmployeeCompetencyLevelEntity already exists. Please specify another MDEmployeeCompetencyLevelEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEmployeeCompetencyLevel_SET";

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

        IList<Int64> IMDEmployeeCompetencyLevelDataAccess.Delete(IList<MDEmployeeCompetencyLevelEntity> mDEmployeeCompetencyLevelEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity in mDEmployeeCompetencyLevelEntityList)
            {
                returnCode = (this as IMDEmployeeCompetencyLevelDataAccess).Delete(mDEmployeeCompetencyLevelEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDEmployeeCompetencyLevelEntity> IMDEmployeeCompetencyLevelDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDEmployeeCompetencyLevel_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDEmployeeCompetencyLevelEntity> list = CreateEntityBuilder<MDEmployeeCompetencyLevelEntity>().BuildEntities(reader);

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

        DataTable IMDEmployeeCompetencyLevelDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDEmployeeCompetencyLevel_GET";

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
