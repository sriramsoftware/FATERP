// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-May-2013, 12:02:45




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
    internal sealed partial class ACAccountGroupDataAccess : BaseDataAccess, IACAccountGroupDataAccess
    {
        #region Constructors

        public ACAccountGroupDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACAccountGroupEntity> CreateEntityBuilder<ACAccountGroupEntity>()
        {
            return (new ACAccountGroupBuilder()) as IEntityBuilder<ACAccountGroupEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACAccountGroupDataAccess.Add(ACAccountGroupEntity aCAccountGroupEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCAccountGroupEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCAccountGroupEntity, option);
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

        private Int64 Add(ACAccountGroupEntity aCAccountGroupEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccountGroup_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "AccountGroupID");

                Database.AddInParameter(cmd, "@ParentAccountGroupID", DbType.Int64, aCAccountGroupEntity.ParentAccountGroupID);	
                Database.AddInParameter(cmd, "@ClassID", DbType.Int64, aCAccountGroupEntity.ClassID);	
                Database.AddInParameter(cmd, "@AccountGroupCode", DbType.String, aCAccountGroupEntity.AccountGroupCode);	
                Database.AddInParameter(cmd, "@Name", DbType.String, aCAccountGroupEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, aCAccountGroupEntity.Description);	
                Database.AddInParameter(cmd, "@IsInActive", DbType.Boolean, aCAccountGroupEntity.IsInActive);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCAccountGroupEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACAccountGroupEntity already exists. Please specify another ACAccountGroupEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACAccountGroupEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACAccountGroupEntity already exists. Please specify another ACAccountGroupEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACAccountGroupEntity aCAccountGroupEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccountGroup_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "AccountGroupID", db);

                db.AddInParameter(cmd, "@ParentAccountGroupID", DbType.Int64, aCAccountGroupEntity.ParentAccountGroupID);
                db.AddInParameter(cmd, "@ClassID", DbType.Int64, aCAccountGroupEntity.ClassID);
                db.AddInParameter(cmd, "@AccountGroupCode", DbType.String, aCAccountGroupEntity.AccountGroupCode);
                db.AddInParameter(cmd, "@Name", DbType.String, aCAccountGroupEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, aCAccountGroupEntity.Description);
                db.AddInParameter(cmd, "@IsInActive", DbType.Boolean, aCAccountGroupEntity.IsInActive);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCAccountGroupEntity.IsRemoved);

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

        IList<Int64> IACAccountGroupDataAccess.Add(IList<ACAccountGroupEntity> aCAccountGroupEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACAccountGroupEntity aCAccountGroupEntity in aCAccountGroupEntityList)
            {
                returnCode = (this as IACAccountGroupDataAccess).Add(aCAccountGroupEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACAccountGroupDataAccess.Update(ACAccountGroupEntity aCAccountGroupEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCAccountGroupEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCAccountGroupEntity, filterExpression, option);
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

        private Int64 Update(ACAccountGroupEntity aCAccountGroupEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccountGroup_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCAccountGroupEntity.AccountGroupID);
                Database.AddInParameter(cmd, "@ParentAccountGroupID", DbType.Int64, aCAccountGroupEntity.ParentAccountGroupID);
                Database.AddInParameter(cmd, "@ClassID", DbType.Int64, aCAccountGroupEntity.ClassID);
                Database.AddInParameter(cmd, "@AccountGroupCode", DbType.String, aCAccountGroupEntity.AccountGroupCode);
                Database.AddInParameter(cmd, "@Name", DbType.String, aCAccountGroupEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, aCAccountGroupEntity.Description);
                Database.AddInParameter(cmd, "@IsInActive", DbType.Boolean, aCAccountGroupEntity.IsInActive);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCAccountGroupEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACAccountGroupEntity already exists. Please specify another ACAccountGroupEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACAccountGroupEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACAccountGroupEntity already exists. Please specify another ACAccountGroupEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACAccountGroupEntity aCAccountGroupEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccountGroup_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, aCAccountGroupEntity.AccountGroupID);
                db.AddInParameter(cmd, "@ParentAccountGroupID", DbType.Int64, aCAccountGroupEntity.ParentAccountGroupID);
                db.AddInParameter(cmd, "@ClassID", DbType.Int64, aCAccountGroupEntity.ClassID);
                db.AddInParameter(cmd, "@AccountGroupCode", DbType.String, aCAccountGroupEntity.AccountGroupCode);
                db.AddInParameter(cmd, "@Name", DbType.String, aCAccountGroupEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, aCAccountGroupEntity.Description);
                db.AddInParameter(cmd, "@IsInActive", DbType.Boolean, aCAccountGroupEntity.IsInActive);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCAccountGroupEntity.IsRemoved);

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

        IList<Int64> IACAccountGroupDataAccess.Update(IList<ACAccountGroupEntity> aCAccountGroupEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACAccountGroupEntity aCAccountGroupEntity in aCAccountGroupEntityList)
            {
                returnCode = (this as IACAccountGroupDataAccess).Update(aCAccountGroupEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACAccountGroupDataAccess.Delete(ACAccountGroupEntity aCAccountGroupEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCAccountGroupEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCAccountGroupEntity, filterExpression, option);
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

        private Int64 Delete(ACAccountGroupEntity aCAccountGroupEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccountGroup_SET";

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
                                throw new ArgumentException("ACAccountGroupEntity already exists. Please specify another ACAccountGroupEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACAccountGroupEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACAccountGroupEntity already exists. Please specify another ACAccountGroupEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACAccountGroupEntity aCAccountGroupEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACAccountGroup_SET";

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

        IList<Int64> IACAccountGroupDataAccess.Delete(IList<ACAccountGroupEntity> aCAccountGroupEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACAccountGroupEntity aCAccountGroupEntity in aCAccountGroupEntityList)
            {
                returnCode = (this as IACAccountGroupDataAccess).Delete(aCAccountGroupEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACAccountGroupEntity> IACAccountGroupDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACAccountGroup_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACAccountGroupEntity> list = CreateEntityBuilder<ACAccountGroupEntity>().BuildEntities(reader);

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

        DataTable IACAccountGroupDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACAccountGroup_GET";

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
