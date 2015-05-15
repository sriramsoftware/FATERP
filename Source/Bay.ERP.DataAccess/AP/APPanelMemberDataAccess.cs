// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




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
    internal sealed partial class APPanelMemberDataAccess : BaseDataAccess, IAPPanelMemberDataAccess
    {
        #region Constructors

        public APPanelMemberDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<APPanelMemberEntity> CreateEntityBuilder<APPanelMemberEntity>()
        {
            return (new APPanelMemberBuilder()) as IEntityBuilder<APPanelMemberEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IAPPanelMemberDataAccess.Add(APPanelMemberEntity aPPanelMemberEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aPPanelMemberEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aPPanelMemberEntity, option);
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

        private Int64 Add(APPanelMemberEntity aPPanelMemberEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APPanelMember_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "APPanelMemberID");

                Database.AddInParameter(cmd, "@APPanelID", DbType.Int64, aPPanelMemberEntity.APPanelID);	
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, aPPanelMemberEntity.DepartmentID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPPanelMemberEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@SequenceNo", DbType.Int32, aPPanelMemberEntity.SequenceNo);	
                Database.AddInParameter(cmd, "@ProxyEmployeeID", DbType.Int64, aPPanelMemberEntity.ProxyEmployeeID);	
                Database.AddInParameter(cmd, "@IsProxyEmployeeEnabled", DbType.Boolean, aPPanelMemberEntity.IsProxyEmployeeEnabled);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("APPanelMemberEntity already exists. Please specify another APPanelMemberEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APPanelMemberEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APPanelMemberEntity already exists. Please specify another APPanelMemberEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(APPanelMemberEntity aPPanelMemberEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APPanelMember_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "APPanelMemberID", db);

                db.AddInParameter(cmd, "@APPanelID", DbType.Int64, aPPanelMemberEntity.APPanelID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, aPPanelMemberEntity.DepartmentID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPPanelMemberEntity.EmployeeID);
                db.AddInParameter(cmd, "@SequenceNo", DbType.Int32, aPPanelMemberEntity.SequenceNo);
                db.AddInParameter(cmd, "@ProxyEmployeeID", DbType.Int64, aPPanelMemberEntity.ProxyEmployeeID);
                db.AddInParameter(cmd, "@IsProxyEmployeeEnabled", DbType.Boolean, aPPanelMemberEntity.IsProxyEmployeeEnabled);

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

        IList<Int64> IAPPanelMemberDataAccess.Add(IList<APPanelMemberEntity> aPPanelMemberEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (APPanelMemberEntity aPPanelMemberEntity in aPPanelMemberEntityList)
            {
                returnCode = (this as IAPPanelMemberDataAccess).Add(aPPanelMemberEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IAPPanelMemberDataAccess.Update(APPanelMemberEntity aPPanelMemberEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aPPanelMemberEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aPPanelMemberEntity, filterExpression, option);
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

        private Int64 Update(APPanelMemberEntity aPPanelMemberEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APPanelMember_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@APPanelMemberID", DbType.Int64, aPPanelMemberEntity.APPanelMemberID);
                Database.AddInParameter(cmd, "@APPanelID", DbType.Int64, aPPanelMemberEntity.APPanelID);
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, aPPanelMemberEntity.DepartmentID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPPanelMemberEntity.EmployeeID);
                Database.AddInParameter(cmd, "@SequenceNo", DbType.Int32, aPPanelMemberEntity.SequenceNo);
                Database.AddInParameter(cmd, "@ProxyEmployeeID", DbType.Int64, aPPanelMemberEntity.ProxyEmployeeID);
                Database.AddInParameter(cmd, "@IsProxyEmployeeEnabled", DbType.Boolean, aPPanelMemberEntity.IsProxyEmployeeEnabled);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("APPanelMemberEntity already exists. Please specify another APPanelMemberEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APPanelMemberEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APPanelMemberEntity already exists. Please specify another APPanelMemberEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(APPanelMemberEntity aPPanelMemberEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APPanelMember_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@APPanelMemberID", DbType.Int64, aPPanelMemberEntity.APPanelMemberID);
                db.AddInParameter(cmd, "@APPanelID", DbType.Int64, aPPanelMemberEntity.APPanelID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, aPPanelMemberEntity.DepartmentID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPPanelMemberEntity.EmployeeID);
                db.AddInParameter(cmd, "@SequenceNo", DbType.Int32, aPPanelMemberEntity.SequenceNo);
                db.AddInParameter(cmd, "@ProxyEmployeeID", DbType.Int64, aPPanelMemberEntity.ProxyEmployeeID);
                db.AddInParameter(cmd, "@IsProxyEmployeeEnabled", DbType.Boolean, aPPanelMemberEntity.IsProxyEmployeeEnabled);

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

        IList<Int64> IAPPanelMemberDataAccess.Update(IList<APPanelMemberEntity> aPPanelMemberEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (APPanelMemberEntity aPPanelMemberEntity in aPPanelMemberEntityList)
            {
                returnCode = (this as IAPPanelMemberDataAccess).Update(aPPanelMemberEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IAPPanelMemberDataAccess.Delete(APPanelMemberEntity aPPanelMemberEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aPPanelMemberEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aPPanelMemberEntity, filterExpression, option);
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

        private Int64 Delete(APPanelMemberEntity aPPanelMemberEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APPanelMember_SET";

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
                                throw new ArgumentException("APPanelMemberEntity already exists. Please specify another APPanelMemberEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APPanelMemberEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APPanelMemberEntity already exists. Please specify another APPanelMemberEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(APPanelMemberEntity aPPanelMemberEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APPanelMember_SET";

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

        IList<Int64> IAPPanelMemberDataAccess.Delete(IList<APPanelMemberEntity> aPPanelMemberEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (APPanelMemberEntity aPPanelMemberEntity in aPPanelMemberEntityList)
            {
                returnCode = (this as IAPPanelMemberDataAccess).Delete(aPPanelMemberEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<APPanelMemberEntity> IAPPanelMemberDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.APPanelMember_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<APPanelMemberEntity> list = CreateEntityBuilder<APPanelMemberEntity>().BuildEntities(reader);

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

        DataTable IAPPanelMemberDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.APPanelMember_GET";

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
