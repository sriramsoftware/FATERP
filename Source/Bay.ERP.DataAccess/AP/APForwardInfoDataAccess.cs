// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Oct-2012, 04:39:52




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
    internal sealed partial class APForwardInfoDataAccess : BaseDataAccess, IAPForwardInfoDataAccess
    {
        #region Constructors

        public APForwardInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<APForwardInfoEntity> CreateEntityBuilder<APForwardInfoEntity>()
        {
            return (new APForwardInfoBuilder()) as IEntityBuilder<APForwardInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IAPForwardInfoDataAccess.Add(APForwardInfoEntity aPForwardInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aPForwardInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aPForwardInfoEntity, option);
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

        private Int64 Add(APForwardInfoEntity aPForwardInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APForwardInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "APForwardInfoID");

                Database.AddInParameter(cmd, "@APMemberFeedbackID", DbType.Int64, aPForwardInfoEntity.APMemberFeedbackID);	
                Database.AddInParameter(cmd, "@APApprovalProcessID", DbType.Int64, aPForwardInfoEntity.APApprovalProcessID);	
                Database.AddInParameter(cmd, "@APMemberFeedbackRemarksID", DbType.Int64, aPForwardInfoEntity.APMemberFeedbackRemarksID);	
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, aPForwardInfoEntity.DepartmentID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPForwardInfoEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@CommentRequestDate", DbType.DateTime, aPForwardInfoEntity.CommentRequestDate);	
                Database.AddInParameter(cmd, "@CommentSubmitDate", DbType.DateTime, aPForwardInfoEntity.CommentSubmitDate);	
                Database.AddInParameter(cmd, "@APMemberComment", DbType.String, aPForwardInfoEntity.APMemberComment);	
                Database.AddInParameter(cmd, "@APForwardMemberComment", DbType.String, aPForwardInfoEntity.APForwardMemberComment);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("APForwardInfoEntity already exists. Please specify another APForwardInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APForwardInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APForwardInfoEntity already exists. Please specify another APForwardInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(APForwardInfoEntity aPForwardInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APForwardInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "APForwardInfoID", db);

                db.AddInParameter(cmd, "@APMemberFeedbackID", DbType.Int64, aPForwardInfoEntity.APMemberFeedbackID);
                db.AddInParameter(cmd, "@APApprovalProcessID", DbType.Int64, aPForwardInfoEntity.APApprovalProcessID);
                db.AddInParameter(cmd, "@APMemberFeedbackRemarksID", DbType.Int64, aPForwardInfoEntity.APMemberFeedbackRemarksID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, aPForwardInfoEntity.DepartmentID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPForwardInfoEntity.EmployeeID);
                db.AddInParameter(cmd, "@CommentRequestDate", DbType.DateTime, aPForwardInfoEntity.CommentRequestDate);
                db.AddInParameter(cmd, "@CommentSubmitDate", DbType.DateTime, aPForwardInfoEntity.CommentSubmitDate);
                db.AddInParameter(cmd, "@APMemberComment", DbType.String, aPForwardInfoEntity.APMemberComment);
                db.AddInParameter(cmd, "@APForwardMemberComment", DbType.String, aPForwardInfoEntity.APForwardMemberComment);

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

        IList<Int64> IAPForwardInfoDataAccess.Add(IList<APForwardInfoEntity> aPForwardInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (APForwardInfoEntity aPForwardInfoEntity in aPForwardInfoEntityList)
            {
                returnCode = (this as IAPForwardInfoDataAccess).Add(aPForwardInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IAPForwardInfoDataAccess.Update(APForwardInfoEntity aPForwardInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aPForwardInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aPForwardInfoEntity, filterExpression, option);
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

        private Int64 Update(APForwardInfoEntity aPForwardInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APForwardInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@APForwardInfoID", DbType.Int64, aPForwardInfoEntity.APForwardInfoID);
                Database.AddInParameter(cmd, "@APMemberFeedbackID", DbType.Int64, aPForwardInfoEntity.APMemberFeedbackID);
                Database.AddInParameter(cmd, "@APApprovalProcessID", DbType.Int64, aPForwardInfoEntity.APApprovalProcessID);
                Database.AddInParameter(cmd, "@APMemberFeedbackRemarksID", DbType.Int64, aPForwardInfoEntity.APMemberFeedbackRemarksID);
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, aPForwardInfoEntity.DepartmentID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPForwardInfoEntity.EmployeeID);
                Database.AddInParameter(cmd, "@CommentRequestDate", DbType.DateTime, aPForwardInfoEntity.CommentRequestDate);
                Database.AddInParameter(cmd, "@CommentSubmitDate", DbType.DateTime, aPForwardInfoEntity.CommentSubmitDate);
                Database.AddInParameter(cmd, "@APMemberComment", DbType.String, aPForwardInfoEntity.APMemberComment);
                Database.AddInParameter(cmd, "@APForwardMemberComment", DbType.String, aPForwardInfoEntity.APForwardMemberComment);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("APForwardInfoEntity already exists. Please specify another APForwardInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APForwardInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APForwardInfoEntity already exists. Please specify another APForwardInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(APForwardInfoEntity aPForwardInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APForwardInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@APForwardInfoID", DbType.Int64, aPForwardInfoEntity.APForwardInfoID);
                db.AddInParameter(cmd, "@APMemberFeedbackID", DbType.Int64, aPForwardInfoEntity.APMemberFeedbackID);
                db.AddInParameter(cmd, "@APApprovalProcessID", DbType.Int64, aPForwardInfoEntity.APApprovalProcessID);
                db.AddInParameter(cmd, "@APMemberFeedbackRemarksID", DbType.Int64, aPForwardInfoEntity.APMemberFeedbackRemarksID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, aPForwardInfoEntity.DepartmentID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPForwardInfoEntity.EmployeeID);
                db.AddInParameter(cmd, "@CommentRequestDate", DbType.DateTime, aPForwardInfoEntity.CommentRequestDate);
                db.AddInParameter(cmd, "@CommentSubmitDate", DbType.DateTime, aPForwardInfoEntity.CommentSubmitDate);
                db.AddInParameter(cmd, "@APMemberComment", DbType.String, aPForwardInfoEntity.APMemberComment);
                db.AddInParameter(cmd, "@APForwardMemberComment", DbType.String, aPForwardInfoEntity.APForwardMemberComment);

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

        IList<Int64> IAPForwardInfoDataAccess.Update(IList<APForwardInfoEntity> aPForwardInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (APForwardInfoEntity aPForwardInfoEntity in aPForwardInfoEntityList)
            {
                returnCode = (this as IAPForwardInfoDataAccess).Update(aPForwardInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IAPForwardInfoDataAccess.Delete(APForwardInfoEntity aPForwardInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aPForwardInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aPForwardInfoEntity, filterExpression, option);
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

        private Int64 Delete(APForwardInfoEntity aPForwardInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APForwardInfo_SET";

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
                                throw new ArgumentException("APForwardInfoEntity already exists. Please specify another APForwardInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APForwardInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APForwardInfoEntity already exists. Please specify another APForwardInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(APForwardInfoEntity aPForwardInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APForwardInfo_SET";

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

        IList<Int64> IAPForwardInfoDataAccess.Delete(IList<APForwardInfoEntity> aPForwardInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (APForwardInfoEntity aPForwardInfoEntity in aPForwardInfoEntityList)
            {
                returnCode = (this as IAPForwardInfoDataAccess).Delete(aPForwardInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<APForwardInfoEntity> IAPForwardInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.APForwardInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<APForwardInfoEntity> list = CreateEntityBuilder<APForwardInfoEntity>().BuildEntities(reader);

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

        DataTable IAPForwardInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.APForwardInfo_GET";

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
