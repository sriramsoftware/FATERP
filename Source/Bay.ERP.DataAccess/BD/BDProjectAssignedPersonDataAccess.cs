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
    internal sealed partial class BDProjectAssignedPersonDataAccess : BaseDataAccess, IBDProjectAssignedPersonDataAccess
    {
        #region Constructors

        public BDProjectAssignedPersonDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectAssignedPersonEntity> CreateEntityBuilder<BDProjectAssignedPersonEntity>()
        {
            return (new BDProjectAssignedPersonBuilder()) as IEntityBuilder<BDProjectAssignedPersonEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectAssignedPersonDataAccess.Add(BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectAssignedPersonEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectAssignedPersonEntity, option);
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

        private Int64 Add(BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAssignedPerson_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectAssignedPersonID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectAssignedPersonEntity.ProjectID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, bDProjectAssignedPersonEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@ProjectAssignedPersonTeamRoleID", DbType.Int64, bDProjectAssignedPersonEntity.ProjectAssignedPersonTeamRoleID);	
                Database.AddInParameter(cmd, "@Description", DbType.String, bDProjectAssignedPersonEntity.Description);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectAssignedPersonEntity already exists. Please specify another BDProjectAssignedPersonEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectAssignedPersonEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectAssignedPersonEntity already exists. Please specify another BDProjectAssignedPersonEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAssignedPerson_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectAssignedPersonID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectAssignedPersonEntity.ProjectID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, bDProjectAssignedPersonEntity.EmployeeID);
                db.AddInParameter(cmd, "@ProjectAssignedPersonTeamRoleID", DbType.Int64, bDProjectAssignedPersonEntity.ProjectAssignedPersonTeamRoleID);
                db.AddInParameter(cmd, "@Description", DbType.String, bDProjectAssignedPersonEntity.Description);

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

        IList<Int64> IBDProjectAssignedPersonDataAccess.Add(IList<BDProjectAssignedPersonEntity> bDProjectAssignedPersonEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity in bDProjectAssignedPersonEntityList)
            {
                returnCode = (this as IBDProjectAssignedPersonDataAccess).Add(bDProjectAssignedPersonEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectAssignedPersonDataAccess.Update(BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectAssignedPersonEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectAssignedPersonEntity, filterExpression, option);
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

        private Int64 Update(BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAssignedPerson_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectAssignedPersonID", DbType.Int64, bDProjectAssignedPersonEntity.ProjectAssignedPersonID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectAssignedPersonEntity.ProjectID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, bDProjectAssignedPersonEntity.EmployeeID);
                Database.AddInParameter(cmd, "@ProjectAssignedPersonTeamRoleID", DbType.Int64, bDProjectAssignedPersonEntity.ProjectAssignedPersonTeamRoleID);
                Database.AddInParameter(cmd, "@Description", DbType.String, bDProjectAssignedPersonEntity.Description);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectAssignedPersonEntity already exists. Please specify another BDProjectAssignedPersonEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectAssignedPersonEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectAssignedPersonEntity already exists. Please specify another BDProjectAssignedPersonEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAssignedPerson_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectAssignedPersonID", DbType.Int64, bDProjectAssignedPersonEntity.ProjectAssignedPersonID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectAssignedPersonEntity.ProjectID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, bDProjectAssignedPersonEntity.EmployeeID);
                db.AddInParameter(cmd, "@ProjectAssignedPersonTeamRoleID", DbType.Int64, bDProjectAssignedPersonEntity.ProjectAssignedPersonTeamRoleID);
                db.AddInParameter(cmd, "@Description", DbType.String, bDProjectAssignedPersonEntity.Description);

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

        IList<Int64> IBDProjectAssignedPersonDataAccess.Update(IList<BDProjectAssignedPersonEntity> bDProjectAssignedPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity in bDProjectAssignedPersonEntityList)
            {
                returnCode = (this as IBDProjectAssignedPersonDataAccess).Update(bDProjectAssignedPersonEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectAssignedPersonDataAccess.Delete(BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectAssignedPersonEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectAssignedPersonEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAssignedPerson_SET";

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
                                throw new ArgumentException("BDProjectAssignedPersonEntity already exists. Please specify another BDProjectAssignedPersonEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectAssignedPersonEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectAssignedPersonEntity already exists. Please specify another BDProjectAssignedPersonEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAssignedPerson_SET";

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

        IList<Int64> IBDProjectAssignedPersonDataAccess.Delete(IList<BDProjectAssignedPersonEntity> bDProjectAssignedPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity in bDProjectAssignedPersonEntityList)
            {
                returnCode = (this as IBDProjectAssignedPersonDataAccess).Delete(bDProjectAssignedPersonEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectAssignedPersonEntity> IBDProjectAssignedPersonDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectAssignedPerson_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectAssignedPersonEntity> list = CreateEntityBuilder<BDProjectAssignedPersonEntity>().BuildEntities(reader);

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

        DataTable IBDProjectAssignedPersonDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectAssignedPerson_GET";

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
