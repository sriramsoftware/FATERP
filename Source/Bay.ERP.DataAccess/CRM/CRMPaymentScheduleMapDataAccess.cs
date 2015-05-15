// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-May-2013, 10:12:36




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
    internal sealed partial class CRMPaymentScheduleMapDataAccess : BaseDataAccess, ICRMPaymentScheduleMapDataAccess
    {
        #region Constructors

        public CRMPaymentScheduleMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMPaymentScheduleMapEntity> CreateEntityBuilder<CRMPaymentScheduleMapEntity>()
        {
            return (new CRMPaymentScheduleMapBuilder()) as IEntityBuilder<CRMPaymentScheduleMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMPaymentScheduleMapDataAccess.Add(CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMPaymentScheduleMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMPaymentScheduleMapEntity, option);
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

        private Int64 Add(CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentScheduleMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "PaymentScheduleMapID");

                Database.AddInParameter(cmd, "@LinkPaymentScheduleMapID", DbType.Int64, cRMPaymentScheduleMapEntity.LinkPaymentScheduleMapID);	
                Database.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMPaymentScheduleMapEntity.PaymentScheduleID);	
                Database.AddInParameter(cmd, "@InstallmentName", DbType.String, cRMPaymentScheduleMapEntity.InstallmentName);	
                Database.AddInParameter(cmd, "@InstallmentDueDate", DbType.DateTime, cRMPaymentScheduleMapEntity.InstallmentDueDate);	
                Database.AddInParameter(cmd, "@InstallmentDueDateNew", DbType.DateTime, cRMPaymentScheduleMapEntity.InstallmentDueDateNew);	
                Database.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMPaymentScheduleMapEntity.AgreementID);	
                Database.AddInParameter(cmd, "@AgreementAAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementAAmount);	
                Database.AddInParameter(cmd, "@AgreementBAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementBAmount);	
                Database.AddInParameter(cmd, "@AgreementCAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementCAmount);	
                Database.AddInParameter(cmd, "@AgreementDAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementDAmount);	
                Database.AddInParameter(cmd, "@AgreementEAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementEAmount);	
                Database.AddInParameter(cmd, "@PaymentDueDate", DbType.DateTime, cRMPaymentScheduleMapEntity.PaymentDueDate);	
                Database.AddInParameter(cmd, "@FinalPayment", DbType.Boolean, cRMPaymentScheduleMapEntity.FinalPayment);	
                Database.AddInParameter(cmd, "@Revised", DbType.Boolean, cRMPaymentScheduleMapEntity.Revised);	
                Database.AddInParameter(cmd, "@RevisedIP", DbType.String, cRMPaymentScheduleMapEntity.RevisedIP);	
                Database.AddInParameter(cmd, "@LastRevisedByEmployeeID", DbType.Int64, cRMPaymentScheduleMapEntity.LastRevisedByEmployeeID);	
                Database.AddInParameter(cmd, "@LastRevisedDate", DbType.DateTime, cRMPaymentScheduleMapEntity.LastRevisedDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMPaymentScheduleMapEntity.Remarks);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMPaymentScheduleMapEntity.CreateDate);	
                Database.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMPaymentScheduleMapEntity.CreateByEmployeeID);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMPaymentScheduleMapEntity.IP);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMPaymentScheduleMapEntity already exists. Please specify another CRMPaymentScheduleMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMPaymentScheduleMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMPaymentScheduleMapEntity already exists. Please specify another CRMPaymentScheduleMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentScheduleMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "PaymentScheduleMapID", db);

                db.AddInParameter(cmd, "@LinkPaymentScheduleMapID", DbType.Int64, cRMPaymentScheduleMapEntity.LinkPaymentScheduleMapID);
                db.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMPaymentScheduleMapEntity.PaymentScheduleID);
                db.AddInParameter(cmd, "@InstallmentName", DbType.String, cRMPaymentScheduleMapEntity.InstallmentName);
                db.AddInParameter(cmd, "@InstallmentDueDate", DbType.DateTime, cRMPaymentScheduleMapEntity.InstallmentDueDate);
                db.AddInParameter(cmd, "@InstallmentDueDateNew", DbType.DateTime, cRMPaymentScheduleMapEntity.InstallmentDueDateNew);
                db.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMPaymentScheduleMapEntity.AgreementID);
                db.AddInParameter(cmd, "@AgreementAAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementAAmount);
                db.AddInParameter(cmd, "@AgreementBAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementBAmount);
                db.AddInParameter(cmd, "@AgreementCAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementCAmount);
                db.AddInParameter(cmd, "@AgreementDAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementDAmount);
                db.AddInParameter(cmd, "@AgreementEAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementEAmount);
                db.AddInParameter(cmd, "@PaymentDueDate", DbType.DateTime, cRMPaymentScheduleMapEntity.PaymentDueDate);
                db.AddInParameter(cmd, "@FinalPayment", DbType.Boolean, cRMPaymentScheduleMapEntity.FinalPayment);
                db.AddInParameter(cmd, "@Revised", DbType.Boolean, cRMPaymentScheduleMapEntity.Revised);
                db.AddInParameter(cmd, "@RevisedIP", DbType.String, cRMPaymentScheduleMapEntity.RevisedIP);
                db.AddInParameter(cmd, "@LastRevisedByEmployeeID", DbType.Int64, cRMPaymentScheduleMapEntity.LastRevisedByEmployeeID);
                db.AddInParameter(cmd, "@LastRevisedDate", DbType.DateTime, cRMPaymentScheduleMapEntity.LastRevisedDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMPaymentScheduleMapEntity.Remarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMPaymentScheduleMapEntity.CreateDate);
                db.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMPaymentScheduleMapEntity.CreateByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMPaymentScheduleMapEntity.IP);

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

        IList<Int64> ICRMPaymentScheduleMapDataAccess.Add(IList<CRMPaymentScheduleMapEntity> cRMPaymentScheduleMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity in cRMPaymentScheduleMapEntityList)
            {
                returnCode = (this as ICRMPaymentScheduleMapDataAccess).Add(cRMPaymentScheduleMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMPaymentScheduleMapDataAccess.Update(CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMPaymentScheduleMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMPaymentScheduleMapEntity, filterExpression, option);
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

        private Int64 Update(CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentScheduleMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@PaymentScheduleMapID", DbType.Int64, cRMPaymentScheduleMapEntity.PaymentScheduleMapID);
                Database.AddInParameter(cmd, "@LinkPaymentScheduleMapID", DbType.Int64, cRMPaymentScheduleMapEntity.LinkPaymentScheduleMapID);
                Database.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMPaymentScheduleMapEntity.PaymentScheduleID);
                Database.AddInParameter(cmd, "@InstallmentName", DbType.String, cRMPaymentScheduleMapEntity.InstallmentName);
                Database.AddInParameter(cmd, "@InstallmentDueDate", DbType.DateTime, cRMPaymentScheduleMapEntity.InstallmentDueDate);
                Database.AddInParameter(cmd, "@InstallmentDueDateNew", DbType.DateTime, cRMPaymentScheduleMapEntity.InstallmentDueDateNew);
                Database.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMPaymentScheduleMapEntity.AgreementID);
                Database.AddInParameter(cmd, "@AgreementAAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementAAmount);
                Database.AddInParameter(cmd, "@AgreementBAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementBAmount);
                Database.AddInParameter(cmd, "@AgreementCAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementCAmount);
                Database.AddInParameter(cmd, "@AgreementDAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementDAmount);
                Database.AddInParameter(cmd, "@AgreementEAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementEAmount);
                Database.AddInParameter(cmd, "@PaymentDueDate", DbType.DateTime, cRMPaymentScheduleMapEntity.PaymentDueDate);
                Database.AddInParameter(cmd, "@FinalPayment", DbType.Boolean, cRMPaymentScheduleMapEntity.FinalPayment);
                Database.AddInParameter(cmd, "@Revised", DbType.Boolean, cRMPaymentScheduleMapEntity.Revised);
                Database.AddInParameter(cmd, "@RevisedIP", DbType.String, cRMPaymentScheduleMapEntity.RevisedIP);
                Database.AddInParameter(cmd, "@LastRevisedByEmployeeID", DbType.Int64, cRMPaymentScheduleMapEntity.LastRevisedByEmployeeID);
                Database.AddInParameter(cmd, "@LastRevisedDate", DbType.DateTime, cRMPaymentScheduleMapEntity.LastRevisedDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMPaymentScheduleMapEntity.Remarks);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMPaymentScheduleMapEntity.CreateDate);
                Database.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMPaymentScheduleMapEntity.CreateByEmployeeID);
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMPaymentScheduleMapEntity.IP);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMPaymentScheduleMapEntity already exists. Please specify another CRMPaymentScheduleMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMPaymentScheduleMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMPaymentScheduleMapEntity already exists. Please specify another CRMPaymentScheduleMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentScheduleMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@PaymentScheduleMapID", DbType.Int64, cRMPaymentScheduleMapEntity.PaymentScheduleMapID);
                db.AddInParameter(cmd, "@LinkPaymentScheduleMapID", DbType.Int64, cRMPaymentScheduleMapEntity.LinkPaymentScheduleMapID);
                db.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMPaymentScheduleMapEntity.PaymentScheduleID);
                db.AddInParameter(cmd, "@InstallmentName", DbType.String, cRMPaymentScheduleMapEntity.InstallmentName);
                db.AddInParameter(cmd, "@InstallmentDueDate", DbType.DateTime, cRMPaymentScheduleMapEntity.InstallmentDueDate);
                db.AddInParameter(cmd, "@InstallmentDueDateNew", DbType.DateTime, cRMPaymentScheduleMapEntity.InstallmentDueDateNew);
                db.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMPaymentScheduleMapEntity.AgreementID);
                db.AddInParameter(cmd, "@AgreementAAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementAAmount);
                db.AddInParameter(cmd, "@AgreementBAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementBAmount);
                db.AddInParameter(cmd, "@AgreementCAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementCAmount);
                db.AddInParameter(cmd, "@AgreementDAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementDAmount);
                db.AddInParameter(cmd, "@AgreementEAmount", DbType.Decimal, cRMPaymentScheduleMapEntity.AgreementEAmount);
                db.AddInParameter(cmd, "@PaymentDueDate", DbType.DateTime, cRMPaymentScheduleMapEntity.PaymentDueDate);
                db.AddInParameter(cmd, "@FinalPayment", DbType.Boolean, cRMPaymentScheduleMapEntity.FinalPayment);
                db.AddInParameter(cmd, "@Revised", DbType.Boolean, cRMPaymentScheduleMapEntity.Revised);
                db.AddInParameter(cmd, "@RevisedIP", DbType.String, cRMPaymentScheduleMapEntity.RevisedIP);
                db.AddInParameter(cmd, "@LastRevisedByEmployeeID", DbType.Int64, cRMPaymentScheduleMapEntity.LastRevisedByEmployeeID);
                db.AddInParameter(cmd, "@LastRevisedDate", DbType.DateTime, cRMPaymentScheduleMapEntity.LastRevisedDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMPaymentScheduleMapEntity.Remarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMPaymentScheduleMapEntity.CreateDate);
                db.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMPaymentScheduleMapEntity.CreateByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMPaymentScheduleMapEntity.IP);

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

        IList<Int64> ICRMPaymentScheduleMapDataAccess.Update(IList<CRMPaymentScheduleMapEntity> cRMPaymentScheduleMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity in cRMPaymentScheduleMapEntityList)
            {
                returnCode = (this as ICRMPaymentScheduleMapDataAccess).Update(cRMPaymentScheduleMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMPaymentScheduleMapDataAccess.Delete(CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMPaymentScheduleMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMPaymentScheduleMapEntity, filterExpression, option);
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

        private Int64 Delete(CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentScheduleMap_SET";

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
                                throw new ArgumentException("CRMPaymentScheduleMapEntity already exists. Please specify another CRMPaymentScheduleMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMPaymentScheduleMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMPaymentScheduleMapEntity already exists. Please specify another CRMPaymentScheduleMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentScheduleMap_SET";

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

        IList<Int64> ICRMPaymentScheduleMapDataAccess.Delete(IList<CRMPaymentScheduleMapEntity> cRMPaymentScheduleMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity in cRMPaymentScheduleMapEntityList)
            {
                returnCode = (this as ICRMPaymentScheduleMapDataAccess).Delete(cRMPaymentScheduleMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMPaymentScheduleMapEntity> ICRMPaymentScheduleMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMPaymentScheduleMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMPaymentScheduleMapEntity> list = CreateEntityBuilder<CRMPaymentScheduleMapEntity>().BuildEntities(reader);

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

        DataTable ICRMPaymentScheduleMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMPaymentScheduleMap_GET";

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
