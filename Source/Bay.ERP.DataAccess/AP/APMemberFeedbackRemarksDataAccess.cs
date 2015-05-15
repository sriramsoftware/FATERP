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
    internal sealed partial class APMemberFeedbackRemarksDataAccess : BaseDataAccess, IAPMemberFeedbackRemarksDataAccess
    {
        #region Constructors

        public APMemberFeedbackRemarksDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<APMemberFeedbackRemarksEntity> CreateEntityBuilder<APMemberFeedbackRemarksEntity>()
        {
            return (new APMemberFeedbackRemarksBuilder()) as IEntityBuilder<APMemberFeedbackRemarksEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IAPMemberFeedbackRemarksDataAccess.Add(APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aPMemberFeedbackRemarksEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aPMemberFeedbackRemarksEntity, option);
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

        private Int64 Add(APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APMemberFeedbackRemarks_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "APMemberFeedbackRemarksID");

                Database.AddInParameter(cmd, "@APApprovalProcessID", DbType.Int64, aPMemberFeedbackRemarksEntity.APApprovalProcessID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aPMemberFeedbackRemarksEntity.Remarks);	
                Database.AddInParameter(cmd, "@RemarksDateTime", DbType.DateTime, aPMemberFeedbackRemarksEntity.RemarksDateTime);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPMemberFeedbackRemarksEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@APFeedbackID", DbType.Int64, aPMemberFeedbackRemarksEntity.APFeedbackID);	
                Database.AddInParameter(cmd, "@ProxyEmployeeID", DbType.Int64, aPMemberFeedbackRemarksEntity.ProxyEmployeeID);	
                Database.AddInParameter(cmd, "@IsProxyEmployeeRemarks", DbType.Boolean, aPMemberFeedbackRemarksEntity.IsProxyEmployeeRemarks);	
                Database.AddInParameter(cmd, "@ProxyEmployeeRemarks", DbType.String, aPMemberFeedbackRemarksEntity.ProxyEmployeeRemarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("APMemberFeedbackRemarksEntity already exists. Please specify another APMemberFeedbackRemarksEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APMemberFeedbackRemarksEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APMemberFeedbackRemarksEntity already exists. Please specify another APMemberFeedbackRemarksEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APMemberFeedbackRemarks_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "APMemberFeedbackRemarksID", db);

                db.AddInParameter(cmd, "@APApprovalProcessID", DbType.Int64, aPMemberFeedbackRemarksEntity.APApprovalProcessID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aPMemberFeedbackRemarksEntity.Remarks);
                db.AddInParameter(cmd, "@RemarksDateTime", DbType.DateTime, aPMemberFeedbackRemarksEntity.RemarksDateTime);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPMemberFeedbackRemarksEntity.EmployeeID);
                db.AddInParameter(cmd, "@APFeedbackID", DbType.Int64, aPMemberFeedbackRemarksEntity.APFeedbackID);
                db.AddInParameter(cmd, "@ProxyEmployeeID", DbType.Int64, aPMemberFeedbackRemarksEntity.ProxyEmployeeID);
                db.AddInParameter(cmd, "@IsProxyEmployeeRemarks", DbType.Boolean, aPMemberFeedbackRemarksEntity.IsProxyEmployeeRemarks);
                db.AddInParameter(cmd, "@ProxyEmployeeRemarks", DbType.String, aPMemberFeedbackRemarksEntity.ProxyEmployeeRemarks);

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

        IList<Int64> IAPMemberFeedbackRemarksDataAccess.Add(IList<APMemberFeedbackRemarksEntity> aPMemberFeedbackRemarksEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity in aPMemberFeedbackRemarksEntityList)
            {
                returnCode = (this as IAPMemberFeedbackRemarksDataAccess).Add(aPMemberFeedbackRemarksEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IAPMemberFeedbackRemarksDataAccess.Update(APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aPMemberFeedbackRemarksEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aPMemberFeedbackRemarksEntity, filterExpression, option);
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

        private Int64 Update(APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APMemberFeedbackRemarks_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@APMemberFeedbackRemarksID", DbType.Int64, aPMemberFeedbackRemarksEntity.APMemberFeedbackRemarksID);
                Database.AddInParameter(cmd, "@APApprovalProcessID", DbType.Int64, aPMemberFeedbackRemarksEntity.APApprovalProcessID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aPMemberFeedbackRemarksEntity.Remarks);
                Database.AddInParameter(cmd, "@RemarksDateTime", DbType.DateTime, aPMemberFeedbackRemarksEntity.RemarksDateTime);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPMemberFeedbackRemarksEntity.EmployeeID);
                Database.AddInParameter(cmd, "@APFeedbackID", DbType.Int64, aPMemberFeedbackRemarksEntity.APFeedbackID);
                Database.AddInParameter(cmd, "@ProxyEmployeeID", DbType.Int64, aPMemberFeedbackRemarksEntity.ProxyEmployeeID);
                Database.AddInParameter(cmd, "@IsProxyEmployeeRemarks", DbType.Boolean, aPMemberFeedbackRemarksEntity.IsProxyEmployeeRemarks);
                Database.AddInParameter(cmd, "@ProxyEmployeeRemarks", DbType.String, aPMemberFeedbackRemarksEntity.ProxyEmployeeRemarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("APMemberFeedbackRemarksEntity already exists. Please specify another APMemberFeedbackRemarksEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APMemberFeedbackRemarksEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APMemberFeedbackRemarksEntity already exists. Please specify another APMemberFeedbackRemarksEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APMemberFeedbackRemarks_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@APMemberFeedbackRemarksID", DbType.Int64, aPMemberFeedbackRemarksEntity.APMemberFeedbackRemarksID);
                db.AddInParameter(cmd, "@APApprovalProcessID", DbType.Int64, aPMemberFeedbackRemarksEntity.APApprovalProcessID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aPMemberFeedbackRemarksEntity.Remarks);
                db.AddInParameter(cmd, "@RemarksDateTime", DbType.DateTime, aPMemberFeedbackRemarksEntity.RemarksDateTime);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPMemberFeedbackRemarksEntity.EmployeeID);
                db.AddInParameter(cmd, "@APFeedbackID", DbType.Int64, aPMemberFeedbackRemarksEntity.APFeedbackID);
                db.AddInParameter(cmd, "@ProxyEmployeeID", DbType.Int64, aPMemberFeedbackRemarksEntity.ProxyEmployeeID);
                db.AddInParameter(cmd, "@IsProxyEmployeeRemarks", DbType.Boolean, aPMemberFeedbackRemarksEntity.IsProxyEmployeeRemarks);
                db.AddInParameter(cmd, "@ProxyEmployeeRemarks", DbType.String, aPMemberFeedbackRemarksEntity.ProxyEmployeeRemarks);

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

        IList<Int64> IAPMemberFeedbackRemarksDataAccess.Update(IList<APMemberFeedbackRemarksEntity> aPMemberFeedbackRemarksEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity in aPMemberFeedbackRemarksEntityList)
            {
                returnCode = (this as IAPMemberFeedbackRemarksDataAccess).Update(aPMemberFeedbackRemarksEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IAPMemberFeedbackRemarksDataAccess.Delete(APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aPMemberFeedbackRemarksEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aPMemberFeedbackRemarksEntity, filterExpression, option);
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

        private Int64 Delete(APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APMemberFeedbackRemarks_SET";

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
                                throw new ArgumentException("APMemberFeedbackRemarksEntity already exists. Please specify another APMemberFeedbackRemarksEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APMemberFeedbackRemarksEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APMemberFeedbackRemarksEntity already exists. Please specify another APMemberFeedbackRemarksEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APMemberFeedbackRemarks_SET";

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

        IList<Int64> IAPMemberFeedbackRemarksDataAccess.Delete(IList<APMemberFeedbackRemarksEntity> aPMemberFeedbackRemarksEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity in aPMemberFeedbackRemarksEntityList)
            {
                returnCode = (this as IAPMemberFeedbackRemarksDataAccess).Delete(aPMemberFeedbackRemarksEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<APMemberFeedbackRemarksEntity> IAPMemberFeedbackRemarksDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.APMemberFeedbackRemarks_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<APMemberFeedbackRemarksEntity> list = CreateEntityBuilder<APMemberFeedbackRemarksEntity>().BuildEntities(reader);

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

        DataTable IAPMemberFeedbackRemarksDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.APMemberFeedbackRemarks_GET";

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
