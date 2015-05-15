// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jul-2012, 05:23:43




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
    internal sealed partial class MDProjectAssignedPersonTeamRoleDataAccess : BaseDataAccess, IMDProjectAssignedPersonTeamRoleDataAccess
    {
        #region Constructors

        public MDProjectAssignedPersonTeamRoleDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDProjectAssignedPersonTeamRoleEntity> CreateEntityBuilder<MDProjectAssignedPersonTeamRoleEntity>()
        {
            return (new MDProjectAssignedPersonTeamRoleBuilder()) as IEntityBuilder<MDProjectAssignedPersonTeamRoleEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDProjectAssignedPersonTeamRoleDataAccess.Add(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDProjectAssignedPersonTeamRoleEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDProjectAssignedPersonTeamRoleEntity, option);
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

        private Int64 Add(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectAssignedPersonTeamRole_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectAssignedPersonTeamRoleID");

                Database.AddInParameter(cmd, "@Name", DbType.String, mDProjectAssignedPersonTeamRoleEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDProjectAssignedPersonTeamRoleEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectAssignedPersonTeamRoleEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDProjectAssignedPersonTeamRoleEntity already exists. Please specify another MDProjectAssignedPersonTeamRoleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectAssignedPersonTeamRoleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectAssignedPersonTeamRoleEntity already exists. Please specify another MDProjectAssignedPersonTeamRoleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectAssignedPersonTeamRole_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectAssignedPersonTeamRoleID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, mDProjectAssignedPersonTeamRoleEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDProjectAssignedPersonTeamRoleEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectAssignedPersonTeamRoleEntity.IsRemoved);

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

        IList<Int64> IMDProjectAssignedPersonTeamRoleDataAccess.Add(IList<MDProjectAssignedPersonTeamRoleEntity> mDProjectAssignedPersonTeamRoleEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity in mDProjectAssignedPersonTeamRoleEntityList)
            {
                returnCode = (this as IMDProjectAssignedPersonTeamRoleDataAccess).Add(mDProjectAssignedPersonTeamRoleEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDProjectAssignedPersonTeamRoleDataAccess.Update(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDProjectAssignedPersonTeamRoleEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDProjectAssignedPersonTeamRoleEntity, filterExpression, option);
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

        private Int64 Update(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectAssignedPersonTeamRole_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectAssignedPersonTeamRoleID", DbType.Int64, mDProjectAssignedPersonTeamRoleEntity.ProjectAssignedPersonTeamRoleID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDProjectAssignedPersonTeamRoleEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDProjectAssignedPersonTeamRoleEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectAssignedPersonTeamRoleEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDProjectAssignedPersonTeamRoleEntity already exists. Please specify another MDProjectAssignedPersonTeamRoleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectAssignedPersonTeamRoleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectAssignedPersonTeamRoleEntity already exists. Please specify another MDProjectAssignedPersonTeamRoleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectAssignedPersonTeamRole_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectAssignedPersonTeamRoleID", DbType.Int64, mDProjectAssignedPersonTeamRoleEntity.ProjectAssignedPersonTeamRoleID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDProjectAssignedPersonTeamRoleEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDProjectAssignedPersonTeamRoleEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDProjectAssignedPersonTeamRoleEntity.IsRemoved);

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

        IList<Int64> IMDProjectAssignedPersonTeamRoleDataAccess.Update(IList<MDProjectAssignedPersonTeamRoleEntity> mDProjectAssignedPersonTeamRoleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity in mDProjectAssignedPersonTeamRoleEntityList)
            {
                returnCode = (this as IMDProjectAssignedPersonTeamRoleDataAccess).Update(mDProjectAssignedPersonTeamRoleEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDProjectAssignedPersonTeamRoleDataAccess.Delete(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDProjectAssignedPersonTeamRoleEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDProjectAssignedPersonTeamRoleEntity, filterExpression, option);
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

        private Int64 Delete(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectAssignedPersonTeamRole_SET";

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
                                throw new ArgumentException("MDProjectAssignedPersonTeamRoleEntity already exists. Please specify another MDProjectAssignedPersonTeamRoleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDProjectAssignedPersonTeamRoleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDProjectAssignedPersonTeamRoleEntity already exists. Please specify another MDProjectAssignedPersonTeamRoleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDProjectAssignedPersonTeamRole_SET";

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

        IList<Int64> IMDProjectAssignedPersonTeamRoleDataAccess.Delete(IList<MDProjectAssignedPersonTeamRoleEntity> mDProjectAssignedPersonTeamRoleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity in mDProjectAssignedPersonTeamRoleEntityList)
            {
                returnCode = (this as IMDProjectAssignedPersonTeamRoleDataAccess).Delete(mDProjectAssignedPersonTeamRoleEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDProjectAssignedPersonTeamRoleEntity> IMDProjectAssignedPersonTeamRoleDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDProjectAssignedPersonTeamRole_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDProjectAssignedPersonTeamRoleEntity> list = CreateEntityBuilder<MDProjectAssignedPersonTeamRoleEntity>().BuildEntities(reader);

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

        DataTable IMDProjectAssignedPersonTeamRoleDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDProjectAssignedPersonTeamRole_GET";

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
