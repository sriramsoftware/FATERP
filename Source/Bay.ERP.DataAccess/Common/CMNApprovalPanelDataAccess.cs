// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




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
    internal sealed partial class CMNApprovalPanelDataAccess : BaseDataAccess, ICMNApprovalPanelDataAccess
    {
        #region Constructors

        public CMNApprovalPanelDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMNApprovalPanelEntity> CreateEntityBuilder<CMNApprovalPanelEntity>()
        {
            return (new CMNApprovalPanelBuilder()) as IEntityBuilder<CMNApprovalPanelEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMNApprovalPanelDataAccess.Add(CMNApprovalPanelEntity cMNApprovalPanelEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMNApprovalPanelEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMNApprovalPanelEntity, option);
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

        private Int64 Add(CMNApprovalPanelEntity cMNApprovalPanelEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNApprovalPanel_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ApprovalPanelID");

                Database.AddInParameter(cmd, "@ApprovalProcessID", DbType.Int64, cMNApprovalPanelEntity.ApprovalProcessID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, cMNApprovalPanelEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@SequeenceNo", DbType.Int32, cMNApprovalPanelEntity.SequeenceNo);	
                Database.AddInParameter(cmd, "@ApprovalPanelStatusID", DbType.Int64, cMNApprovalPanelEntity.ApprovalPanelStatusID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMNApprovalPanelEntity.Remarks);	
                Database.AddInParameter(cmd, "@RequestDate", DbType.DateTime, cMNApprovalPanelEntity.RequestDate);	
                Database.AddInParameter(cmd, "@ResponseDate", DbType.DateTime, cMNApprovalPanelEntity.ResponseDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNApprovalPanelEntity already exists. Please specify another CMNApprovalPanelEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNApprovalPanelEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNApprovalPanelEntity already exists. Please specify another CMNApprovalPanelEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMNApprovalPanelEntity cMNApprovalPanelEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNApprovalPanel_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ApprovalPanelID", db);

                db.AddInParameter(cmd, "@ApprovalProcessID", DbType.Int64, cMNApprovalPanelEntity.ApprovalProcessID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, cMNApprovalPanelEntity.EmployeeID);
                db.AddInParameter(cmd, "@SequeenceNo", DbType.Int32, cMNApprovalPanelEntity.SequeenceNo);
                db.AddInParameter(cmd, "@ApprovalPanelStatusID", DbType.Int64, cMNApprovalPanelEntity.ApprovalPanelStatusID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMNApprovalPanelEntity.Remarks);
                db.AddInParameter(cmd, "@RequestDate", DbType.DateTime, cMNApprovalPanelEntity.RequestDate);
                db.AddInParameter(cmd, "@ResponseDate", DbType.DateTime, cMNApprovalPanelEntity.ResponseDate);

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

        IList<Int64> ICMNApprovalPanelDataAccess.Add(IList<CMNApprovalPanelEntity> cMNApprovalPanelEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMNApprovalPanelEntity cMNApprovalPanelEntity in cMNApprovalPanelEntityList)
            {
                returnCode = (this as ICMNApprovalPanelDataAccess).Add(cMNApprovalPanelEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMNApprovalPanelDataAccess.Update(CMNApprovalPanelEntity cMNApprovalPanelEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMNApprovalPanelEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMNApprovalPanelEntity, filterExpression, option);
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

        private Int64 Update(CMNApprovalPanelEntity cMNApprovalPanelEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNApprovalPanel_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ApprovalPanelID", DbType.Int64, cMNApprovalPanelEntity.ApprovalPanelID);
                Database.AddInParameter(cmd, "@ApprovalProcessID", DbType.Int64, cMNApprovalPanelEntity.ApprovalProcessID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, cMNApprovalPanelEntity.EmployeeID);
                Database.AddInParameter(cmd, "@SequeenceNo", DbType.Int32, cMNApprovalPanelEntity.SequeenceNo);
                Database.AddInParameter(cmd, "@ApprovalPanelStatusID", DbType.Int64, cMNApprovalPanelEntity.ApprovalPanelStatusID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMNApprovalPanelEntity.Remarks);
                Database.AddInParameter(cmd, "@RequestDate", DbType.DateTime, cMNApprovalPanelEntity.RequestDate);
                Database.AddInParameter(cmd, "@ResponseDate", DbType.DateTime, cMNApprovalPanelEntity.ResponseDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNApprovalPanelEntity already exists. Please specify another CMNApprovalPanelEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNApprovalPanelEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNApprovalPanelEntity already exists. Please specify another CMNApprovalPanelEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMNApprovalPanelEntity cMNApprovalPanelEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNApprovalPanel_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ApprovalPanelID", DbType.Int64, cMNApprovalPanelEntity.ApprovalPanelID);
                db.AddInParameter(cmd, "@ApprovalProcessID", DbType.Int64, cMNApprovalPanelEntity.ApprovalProcessID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, cMNApprovalPanelEntity.EmployeeID);
                db.AddInParameter(cmd, "@SequeenceNo", DbType.Int32, cMNApprovalPanelEntity.SequeenceNo);
                db.AddInParameter(cmd, "@ApprovalPanelStatusID", DbType.Int64, cMNApprovalPanelEntity.ApprovalPanelStatusID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMNApprovalPanelEntity.Remarks);
                db.AddInParameter(cmd, "@RequestDate", DbType.DateTime, cMNApprovalPanelEntity.RequestDate);
                db.AddInParameter(cmd, "@ResponseDate", DbType.DateTime, cMNApprovalPanelEntity.ResponseDate);

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

        IList<Int64> ICMNApprovalPanelDataAccess.Update(IList<CMNApprovalPanelEntity> cMNApprovalPanelEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMNApprovalPanelEntity cMNApprovalPanelEntity in cMNApprovalPanelEntityList)
            {
                returnCode = (this as ICMNApprovalPanelDataAccess).Update(cMNApprovalPanelEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMNApprovalPanelDataAccess.Delete(CMNApprovalPanelEntity cMNApprovalPanelEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMNApprovalPanelEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMNApprovalPanelEntity, filterExpression, option);
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

        private Int64 Delete(CMNApprovalPanelEntity cMNApprovalPanelEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNApprovalPanel_SET";

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
                                throw new ArgumentException("CMNApprovalPanelEntity already exists. Please specify another CMNApprovalPanelEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNApprovalPanelEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNApprovalPanelEntity already exists. Please specify another CMNApprovalPanelEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMNApprovalPanelEntity cMNApprovalPanelEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNApprovalPanel_SET";

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

        IList<Int64> ICMNApprovalPanelDataAccess.Delete(IList<CMNApprovalPanelEntity> cMNApprovalPanelEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMNApprovalPanelEntity cMNApprovalPanelEntity in cMNApprovalPanelEntityList)
            {
                returnCode = (this as ICMNApprovalPanelDataAccess).Delete(cMNApprovalPanelEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMNApprovalPanelEntity> ICMNApprovalPanelDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNApprovalPanel_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMNApprovalPanelEntity> list = CreateEntityBuilder<CMNApprovalPanelEntity>().BuildEntities(reader);

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

        DataTable ICMNApprovalPanelDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNApprovalPanel_GET";

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
