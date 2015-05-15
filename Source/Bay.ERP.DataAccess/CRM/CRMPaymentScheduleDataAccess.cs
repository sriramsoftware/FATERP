// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2013, 08:24:37




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
    internal sealed partial class CRMPaymentScheduleDataAccess : BaseDataAccess, ICRMPaymentScheduleDataAccess
    {
        #region Constructors

        public CRMPaymentScheduleDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMPaymentScheduleEntity> CreateEntityBuilder<CRMPaymentScheduleEntity>()
        {
            return (new CRMPaymentScheduleBuilder()) as IEntityBuilder<CRMPaymentScheduleEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMPaymentScheduleDataAccess.Add(CRMPaymentScheduleEntity cRMPaymentScheduleEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMPaymentScheduleEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMPaymentScheduleEntity, option);
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

        private Int64 Add(CRMPaymentScheduleEntity cRMPaymentScheduleEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentSchedule_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "PaymentScheduleID");

                Database.AddInParameter(cmd, "@BuyerBookSpaceID", DbType.Int64, cRMPaymentScheduleEntity.BuyerBookSpaceID);	
                Database.AddInParameter(cmd, "@HandoverDate", DbType.DateTime, cRMPaymentScheduleEntity.HandoverDate);	
                Database.AddInParameter(cmd, "@ActualHandoverDate", DbType.DateTime, cRMPaymentScheduleEntity.ActualHandoverDate);	
                Database.AddInParameter(cmd, "@ProjectCode", DbType.String, cRMPaymentScheduleEntity.ProjectCode);	
                Database.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMPaymentScheduleEntity.BuyerBasicInfoID);	
                Database.AddInParameter(cmd, "@TotalAgreementAmount", DbType.Decimal, cRMPaymentScheduleEntity.TotalAgreementAmount);	
                Database.AddInParameter(cmd, "@EarnestMoney", DbType.Decimal, cRMPaymentScheduleEntity.EarnestMoney);	
                Database.AddInParameter(cmd, "@Reservation", DbType.Decimal, cRMPaymentScheduleEntity.Reservation);	
                Database.AddInParameter(cmd, "@CommonService", DbType.Decimal, cRMPaymentScheduleEntity.CommonService);	
                Database.AddInParameter(cmd, "@UtilityConnectionCost", DbType.Decimal, cRMPaymentScheduleEntity.UtilityConnectionCost);	
                Database.AddInParameter(cmd, "@ReservedFund", DbType.Decimal, cRMPaymentScheduleEntity.ReservedFund);	
                Database.AddInParameter(cmd, "@TotalInstallment", DbType.Decimal, cRMPaymentScheduleEntity.TotalInstallment);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMPaymentScheduleEntity.Remarks);	
                Database.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMPaymentScheduleEntity.CreateByEmployeeID);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMPaymentScheduleEntity.IP);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMPaymentScheduleEntity.CreateDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMPaymentScheduleEntity already exists. Please specify another CRMPaymentScheduleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMPaymentScheduleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMPaymentScheduleEntity already exists. Please specify another CRMPaymentScheduleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMPaymentScheduleEntity cRMPaymentScheduleEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentSchedule_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "PaymentScheduleID", db);

                db.AddInParameter(cmd, "@BuyerBookSpaceID", DbType.Int64, cRMPaymentScheduleEntity.BuyerBookSpaceID);
                db.AddInParameter(cmd, "@HandoverDate", DbType.DateTime, cRMPaymentScheduleEntity.HandoverDate);
                db.AddInParameter(cmd, "@ActualHandoverDate", DbType.DateTime, cRMPaymentScheduleEntity.ActualHandoverDate);
                db.AddInParameter(cmd, "@ProjectCode", DbType.String, cRMPaymentScheduleEntity.ProjectCode);
                db.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMPaymentScheduleEntity.BuyerBasicInfoID);
                db.AddInParameter(cmd, "@TotalAgreementAmount", DbType.Decimal, cRMPaymentScheduleEntity.TotalAgreementAmount);
                db.AddInParameter(cmd, "@EarnestMoney", DbType.Decimal, cRMPaymentScheduleEntity.EarnestMoney);
                db.AddInParameter(cmd, "@Reservation", DbType.Decimal, cRMPaymentScheduleEntity.Reservation);
                db.AddInParameter(cmd, "@CommonService", DbType.Decimal, cRMPaymentScheduleEntity.CommonService);
                db.AddInParameter(cmd, "@UtilityConnectionCost", DbType.Decimal, cRMPaymentScheduleEntity.UtilityConnectionCost);
                db.AddInParameter(cmd, "@ReservedFund", DbType.Decimal, cRMPaymentScheduleEntity.ReservedFund);
                db.AddInParameter(cmd, "@TotalInstallment", DbType.Decimal, cRMPaymentScheduleEntity.TotalInstallment);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMPaymentScheduleEntity.Remarks);
                db.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMPaymentScheduleEntity.CreateByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMPaymentScheduleEntity.IP);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMPaymentScheduleEntity.CreateDate);

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

        IList<Int64> ICRMPaymentScheduleDataAccess.Add(IList<CRMPaymentScheduleEntity> cRMPaymentScheduleEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMPaymentScheduleEntity cRMPaymentScheduleEntity in cRMPaymentScheduleEntityList)
            {
                returnCode = (this as ICRMPaymentScheduleDataAccess).Add(cRMPaymentScheduleEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMPaymentScheduleDataAccess.Update(CRMPaymentScheduleEntity cRMPaymentScheduleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMPaymentScheduleEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMPaymentScheduleEntity, filterExpression, option);
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

        private Int64 Update(CRMPaymentScheduleEntity cRMPaymentScheduleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentSchedule_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMPaymentScheduleEntity.PaymentScheduleID);
                Database.AddInParameter(cmd, "@BuyerBookSpaceID", DbType.Int64, cRMPaymentScheduleEntity.BuyerBookSpaceID);
                Database.AddInParameter(cmd, "@HandoverDate", DbType.DateTime, cRMPaymentScheduleEntity.HandoverDate);
                Database.AddInParameter(cmd, "@ActualHandoverDate", DbType.DateTime, cRMPaymentScheduleEntity.ActualHandoverDate);
                Database.AddInParameter(cmd, "@ProjectCode", DbType.String, cRMPaymentScheduleEntity.ProjectCode);
                Database.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMPaymentScheduleEntity.BuyerBasicInfoID);
                Database.AddInParameter(cmd, "@TotalAgreementAmount", DbType.Decimal, cRMPaymentScheduleEntity.TotalAgreementAmount);
                Database.AddInParameter(cmd, "@EarnestMoney", DbType.Decimal, cRMPaymentScheduleEntity.EarnestMoney);
                Database.AddInParameter(cmd, "@Reservation", DbType.Decimal, cRMPaymentScheduleEntity.Reservation);
                Database.AddInParameter(cmd, "@CommonService", DbType.Decimal, cRMPaymentScheduleEntity.CommonService);
                Database.AddInParameter(cmd, "@UtilityConnectionCost", DbType.Decimal, cRMPaymentScheduleEntity.UtilityConnectionCost);
                Database.AddInParameter(cmd, "@ReservedFund", DbType.Decimal, cRMPaymentScheduleEntity.ReservedFund);
                Database.AddInParameter(cmd, "@TotalInstallment", DbType.Decimal, cRMPaymentScheduleEntity.TotalInstallment);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMPaymentScheduleEntity.Remarks);
                Database.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMPaymentScheduleEntity.CreateByEmployeeID);
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMPaymentScheduleEntity.IP);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMPaymentScheduleEntity.CreateDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMPaymentScheduleEntity already exists. Please specify another CRMPaymentScheduleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMPaymentScheduleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMPaymentScheduleEntity already exists. Please specify another CRMPaymentScheduleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMPaymentScheduleEntity cRMPaymentScheduleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentSchedule_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMPaymentScheduleEntity.PaymentScheduleID);
                db.AddInParameter(cmd, "@BuyerBookSpaceID", DbType.Int64, cRMPaymentScheduleEntity.BuyerBookSpaceID);
                db.AddInParameter(cmd, "@HandoverDate", DbType.DateTime, cRMPaymentScheduleEntity.HandoverDate);
                db.AddInParameter(cmd, "@ActualHandoverDate", DbType.DateTime, cRMPaymentScheduleEntity.ActualHandoverDate);
                db.AddInParameter(cmd, "@ProjectCode", DbType.String, cRMPaymentScheduleEntity.ProjectCode);
                db.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMPaymentScheduleEntity.BuyerBasicInfoID);
                db.AddInParameter(cmd, "@TotalAgreementAmount", DbType.Decimal, cRMPaymentScheduleEntity.TotalAgreementAmount);
                db.AddInParameter(cmd, "@EarnestMoney", DbType.Decimal, cRMPaymentScheduleEntity.EarnestMoney);
                db.AddInParameter(cmd, "@Reservation", DbType.Decimal, cRMPaymentScheduleEntity.Reservation);
                db.AddInParameter(cmd, "@CommonService", DbType.Decimal, cRMPaymentScheduleEntity.CommonService);
                db.AddInParameter(cmd, "@UtilityConnectionCost", DbType.Decimal, cRMPaymentScheduleEntity.UtilityConnectionCost);
                db.AddInParameter(cmd, "@ReservedFund", DbType.Decimal, cRMPaymentScheduleEntity.ReservedFund);
                db.AddInParameter(cmd, "@TotalInstallment", DbType.Decimal, cRMPaymentScheduleEntity.TotalInstallment);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMPaymentScheduleEntity.Remarks);
                db.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMPaymentScheduleEntity.CreateByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMPaymentScheduleEntity.IP);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMPaymentScheduleEntity.CreateDate);

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

        IList<Int64> ICRMPaymentScheduleDataAccess.Update(IList<CRMPaymentScheduleEntity> cRMPaymentScheduleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMPaymentScheduleEntity cRMPaymentScheduleEntity in cRMPaymentScheduleEntityList)
            {
                returnCode = (this as ICRMPaymentScheduleDataAccess).Update(cRMPaymentScheduleEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMPaymentScheduleDataAccess.Delete(CRMPaymentScheduleEntity cRMPaymentScheduleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMPaymentScheduleEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMPaymentScheduleEntity, filterExpression, option);
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

        private Int64 Delete(CRMPaymentScheduleEntity cRMPaymentScheduleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentSchedule_SET";

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
                                throw new ArgumentException("CRMPaymentScheduleEntity already exists. Please specify another CRMPaymentScheduleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMPaymentScheduleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMPaymentScheduleEntity already exists. Please specify another CRMPaymentScheduleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMPaymentScheduleEntity cRMPaymentScheduleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMPaymentSchedule_SET";

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

        IList<Int64> ICRMPaymentScheduleDataAccess.Delete(IList<CRMPaymentScheduleEntity> cRMPaymentScheduleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMPaymentScheduleEntity cRMPaymentScheduleEntity in cRMPaymentScheduleEntityList)
            {
                returnCode = (this as ICRMPaymentScheduleDataAccess).Delete(cRMPaymentScheduleEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMPaymentScheduleEntity> ICRMPaymentScheduleDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMPaymentSchedule_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMPaymentScheduleEntity> list = CreateEntityBuilder<CRMPaymentScheduleEntity>().BuildEntities(reader);

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

        DataTable ICRMPaymentScheduleDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMPaymentSchedule_GET";

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
