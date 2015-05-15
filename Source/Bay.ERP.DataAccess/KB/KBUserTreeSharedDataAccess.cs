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
    internal sealed partial class KBUserTreeSharedDataAccess : BaseDataAccess, IKBUserTreeSharedDataAccess
    {
        #region Constructors

        public KBUserTreeSharedDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<KBUserTreeSharedEntity> CreateEntityBuilder<KBUserTreeSharedEntity>()
        {
            return (new KBUserTreeSharedBuilder()) as IEntityBuilder<KBUserTreeSharedEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IKBUserTreeSharedDataAccess.Add(KBUserTreeSharedEntity kBUserTreeSharedEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(kBUserTreeSharedEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(kBUserTreeSharedEntity, option);
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

        private Int64 Add(KBUserTreeSharedEntity kBUserTreeSharedEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeShared_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "UserTreeSharedID");

                Database.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeSharedEntity.UserTreeID);	
                Database.AddInParameter(cmd, "@UserTreeSettingID", DbType.Int64, kBUserTreeSharedEntity.UserTreeSettingID);	
                Database.AddInParameter(cmd, "@Message", DbType.String, kBUserTreeSharedEntity.Message);	
                Database.AddInParameter(cmd, "@SharedGivenByEmployeeID", DbType.Int64, kBUserTreeSharedEntity.SharedGivenByEmployeeID);	
                Database.AddInParameter(cmd, "@SharedDateTime", DbType.DateTime, kBUserTreeSharedEntity.SharedDateTime);	
                Database.AddInParameter(cmd, "@SharedGivenToEmployeeID", DbType.Int64, kBUserTreeSharedEntity.SharedGivenToEmployeeID);	
                Database.AddInParameter(cmd, "@IP", DbType.String, kBUserTreeSharedEntity.IP);	
                Database.AddInParameter(cmd, "@UserTreePermissionID", DbType.Int64, kBUserTreeSharedEntity.UserTreePermissionID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("KBUserTreeSharedEntity already exists. Please specify another KBUserTreeSharedEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("KBUserTreeSharedEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("KBUserTreeSharedEntity already exists. Please specify another KBUserTreeSharedEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(KBUserTreeSharedEntity kBUserTreeSharedEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeShared_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "UserTreeSharedID", db);

                db.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeSharedEntity.UserTreeID);
                db.AddInParameter(cmd, "@UserTreeSettingID", DbType.Int64, kBUserTreeSharedEntity.UserTreeSettingID);
                db.AddInParameter(cmd, "@Message", DbType.String, kBUserTreeSharedEntity.Message);
                db.AddInParameter(cmd, "@SharedGivenByEmployeeID", DbType.Int64, kBUserTreeSharedEntity.SharedGivenByEmployeeID);
                db.AddInParameter(cmd, "@SharedDateTime", DbType.DateTime, kBUserTreeSharedEntity.SharedDateTime);
                db.AddInParameter(cmd, "@SharedGivenToEmployeeID", DbType.Int64, kBUserTreeSharedEntity.SharedGivenToEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, kBUserTreeSharedEntity.IP);
                db.AddInParameter(cmd, "@UserTreePermissionID", DbType.Int64, kBUserTreeSharedEntity.UserTreePermissionID);

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

        IList<Int64> IKBUserTreeSharedDataAccess.Add(IList<KBUserTreeSharedEntity> kBUserTreeSharedEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (KBUserTreeSharedEntity kBUserTreeSharedEntity in kBUserTreeSharedEntityList)
            {
                returnCode = (this as IKBUserTreeSharedDataAccess).Add(kBUserTreeSharedEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IKBUserTreeSharedDataAccess.Update(KBUserTreeSharedEntity kBUserTreeSharedEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(kBUserTreeSharedEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(kBUserTreeSharedEntity, filterExpression, option);
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

        private Int64 Update(KBUserTreeSharedEntity kBUserTreeSharedEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeShared_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@UserTreeSharedID", DbType.Int64, kBUserTreeSharedEntity.UserTreeSharedID);
                Database.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeSharedEntity.UserTreeID);
                Database.AddInParameter(cmd, "@UserTreeSettingID", DbType.Int64, kBUserTreeSharedEntity.UserTreeSettingID);
                Database.AddInParameter(cmd, "@Message", DbType.String, kBUserTreeSharedEntity.Message);
                Database.AddInParameter(cmd, "@SharedGivenByEmployeeID", DbType.Int64, kBUserTreeSharedEntity.SharedGivenByEmployeeID);
                Database.AddInParameter(cmd, "@SharedDateTime", DbType.DateTime, kBUserTreeSharedEntity.SharedDateTime);
                Database.AddInParameter(cmd, "@SharedGivenToEmployeeID", DbType.Int64, kBUserTreeSharedEntity.SharedGivenToEmployeeID);
                Database.AddInParameter(cmd, "@IP", DbType.String, kBUserTreeSharedEntity.IP);
                Database.AddInParameter(cmd, "@UserTreePermissionID", DbType.Int64, kBUserTreeSharedEntity.UserTreePermissionID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("KBUserTreeSharedEntity already exists. Please specify another KBUserTreeSharedEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("KBUserTreeSharedEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("KBUserTreeSharedEntity already exists. Please specify another KBUserTreeSharedEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(KBUserTreeSharedEntity kBUserTreeSharedEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeShared_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@UserTreeSharedID", DbType.Int64, kBUserTreeSharedEntity.UserTreeSharedID);
                db.AddInParameter(cmd, "@UserTreeID", DbType.Int64, kBUserTreeSharedEntity.UserTreeID);
                db.AddInParameter(cmd, "@UserTreeSettingID", DbType.Int64, kBUserTreeSharedEntity.UserTreeSettingID);
                db.AddInParameter(cmd, "@Message", DbType.String, kBUserTreeSharedEntity.Message);
                db.AddInParameter(cmd, "@SharedGivenByEmployeeID", DbType.Int64, kBUserTreeSharedEntity.SharedGivenByEmployeeID);
                db.AddInParameter(cmd, "@SharedDateTime", DbType.DateTime, kBUserTreeSharedEntity.SharedDateTime);
                db.AddInParameter(cmd, "@SharedGivenToEmployeeID", DbType.Int64, kBUserTreeSharedEntity.SharedGivenToEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, kBUserTreeSharedEntity.IP);
                db.AddInParameter(cmd, "@UserTreePermissionID", DbType.Int64, kBUserTreeSharedEntity.UserTreePermissionID);

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

        IList<Int64> IKBUserTreeSharedDataAccess.Update(IList<KBUserTreeSharedEntity> kBUserTreeSharedEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (KBUserTreeSharedEntity kBUserTreeSharedEntity in kBUserTreeSharedEntityList)
            {
                returnCode = (this as IKBUserTreeSharedDataAccess).Update(kBUserTreeSharedEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IKBUserTreeSharedDataAccess.Delete(KBUserTreeSharedEntity kBUserTreeSharedEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(kBUserTreeSharedEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(kBUserTreeSharedEntity, filterExpression, option);
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

        private Int64 Delete(KBUserTreeSharedEntity kBUserTreeSharedEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeShared_SET";

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
                                throw new ArgumentException("KBUserTreeSharedEntity already exists. Please specify another KBUserTreeSharedEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("KBUserTreeSharedEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("KBUserTreeSharedEntity already exists. Please specify another KBUserTreeSharedEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(KBUserTreeSharedEntity kBUserTreeSharedEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.KBUserTreeShared_SET";

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

        IList<Int64> IKBUserTreeSharedDataAccess.Delete(IList<KBUserTreeSharedEntity> kBUserTreeSharedEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (KBUserTreeSharedEntity kBUserTreeSharedEntity in kBUserTreeSharedEntityList)
            {
                returnCode = (this as IKBUserTreeSharedDataAccess).Delete(kBUserTreeSharedEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<KBUserTreeSharedEntity> IKBUserTreeSharedDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.KBUserTreeShared_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<KBUserTreeSharedEntity> list = CreateEntityBuilder<KBUserTreeSharedEntity>().BuildEntities(reader);

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

        DataTable IKBUserTreeSharedDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.KBUserTreeShared_GET";

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
