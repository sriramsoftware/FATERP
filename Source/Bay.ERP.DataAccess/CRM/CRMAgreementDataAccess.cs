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
    internal sealed partial class CRMAgreementDataAccess : BaseDataAccess, ICRMAgreementDataAccess
    {
        #region Constructors

        public CRMAgreementDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMAgreementEntity> CreateEntityBuilder<CRMAgreementEntity>()
        {
            return (new CRMAgreementBuilder()) as IEntityBuilder<CRMAgreementEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMAgreementDataAccess.Add(CRMAgreementEntity cRMAgreementEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMAgreementEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMAgreementEntity, option);
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

        private Int64 Add(CRMAgreementEntity cRMAgreementEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreement_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "AgreementID");

                Database.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMAgreementEntity.PaymentScheduleID);	
                Database.AddInParameter(cmd, "@AgreementTypeID", DbType.Int64, cRMAgreementEntity.AgreementTypeID);	
                Database.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMAgreementEntity.BuyerBasicInfoID);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, cRMAgreementEntity.ProjectID);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, cRMAgreementEntity.ProjectFloorUnitID);	
                Database.AddInParameter(cmd, "@Text", DbType.String, cRMAgreementEntity.Text);	
                Database.AddInParameter(cmd, "@AgreementDate", DbType.DateTime, cRMAgreementEntity.AgreementDate);	
                Database.AddInParameter(cmd, "@SignDate", DbType.DateTime, cRMAgreementEntity.SignDate);	
                Database.AddInParameter(cmd, "@ExecuteDate", DbType.DateTime, cRMAgreementEntity.ExecuteDate);	
                Database.AddInParameter(cmd, "@Field1", DbType.String, cRMAgreementEntity.Field1);	
                Database.AddInParameter(cmd, "@Field2", DbType.String, cRMAgreementEntity.Field2);	
                Database.AddInParameter(cmd, "@Field3", DbType.String, cRMAgreementEntity.Field3);	
                Database.AddInParameter(cmd, "@Field4", DbType.String, cRMAgreementEntity.Field4);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementEntity.Remarks);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMAgreementEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMAgreementEntity.CreateDate);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMAgreementEntity.IP);	
                Database.AddInParameter(cmd, "@AgreementApprovalStatusID", DbType.Int64, cRMAgreementEntity.AgreementApprovalStatusID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMAgreementEntity already exists. Please specify another CRMAgreementEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMAgreementEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMAgreementEntity already exists. Please specify another CRMAgreementEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMAgreementEntity cRMAgreementEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreement_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "AgreementID", db);

                db.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMAgreementEntity.PaymentScheduleID);
                db.AddInParameter(cmd, "@AgreementTypeID", DbType.Int64, cRMAgreementEntity.AgreementTypeID);
                db.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMAgreementEntity.BuyerBasicInfoID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, cRMAgreementEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, cRMAgreementEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@Text", DbType.String, cRMAgreementEntity.Text);
                db.AddInParameter(cmd, "@AgreementDate", DbType.DateTime, cRMAgreementEntity.AgreementDate);
                db.AddInParameter(cmd, "@SignDate", DbType.DateTime, cRMAgreementEntity.SignDate);
                db.AddInParameter(cmd, "@ExecuteDate", DbType.DateTime, cRMAgreementEntity.ExecuteDate);
                db.AddInParameter(cmd, "@Field1", DbType.String, cRMAgreementEntity.Field1);
                db.AddInParameter(cmd, "@Field2", DbType.String, cRMAgreementEntity.Field2);
                db.AddInParameter(cmd, "@Field3", DbType.String, cRMAgreementEntity.Field3);
                db.AddInParameter(cmd, "@Field4", DbType.String, cRMAgreementEntity.Field4);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementEntity.Remarks);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMAgreementEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMAgreementEntity.CreateDate);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMAgreementEntity.IP);
                db.AddInParameter(cmd, "@AgreementApprovalStatusID", DbType.Int64, cRMAgreementEntity.AgreementApprovalStatusID);

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

        IList<Int64> ICRMAgreementDataAccess.Add(IList<CRMAgreementEntity> cRMAgreementEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMAgreementEntity cRMAgreementEntity in cRMAgreementEntityList)
            {
                returnCode = (this as ICRMAgreementDataAccess).Add(cRMAgreementEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMAgreementDataAccess.Update(CRMAgreementEntity cRMAgreementEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMAgreementEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMAgreementEntity, filterExpression, option);
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

        private Int64 Update(CRMAgreementEntity cRMAgreementEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreement_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMAgreementEntity.AgreementID);
                Database.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMAgreementEntity.PaymentScheduleID);
                Database.AddInParameter(cmd, "@AgreementTypeID", DbType.Int64, cRMAgreementEntity.AgreementTypeID);
                Database.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMAgreementEntity.BuyerBasicInfoID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, cRMAgreementEntity.ProjectID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, cRMAgreementEntity.ProjectFloorUnitID);
                Database.AddInParameter(cmd, "@Text", DbType.String, cRMAgreementEntity.Text);
                Database.AddInParameter(cmd, "@AgreementDate", DbType.DateTime, cRMAgreementEntity.AgreementDate);
                Database.AddInParameter(cmd, "@SignDate", DbType.DateTime, cRMAgreementEntity.SignDate);
                Database.AddInParameter(cmd, "@ExecuteDate", DbType.DateTime, cRMAgreementEntity.ExecuteDate);
                Database.AddInParameter(cmd, "@Field1", DbType.String, cRMAgreementEntity.Field1);
                Database.AddInParameter(cmd, "@Field2", DbType.String, cRMAgreementEntity.Field2);
                Database.AddInParameter(cmd, "@Field3", DbType.String, cRMAgreementEntity.Field3);
                Database.AddInParameter(cmd, "@Field4", DbType.String, cRMAgreementEntity.Field4);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementEntity.Remarks);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMAgreementEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMAgreementEntity.CreateDate);
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMAgreementEntity.IP);
                Database.AddInParameter(cmd, "@AgreementApprovalStatusID", DbType.Int64, cRMAgreementEntity.AgreementApprovalStatusID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMAgreementEntity already exists. Please specify another CRMAgreementEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMAgreementEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMAgreementEntity already exists. Please specify another CRMAgreementEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMAgreementEntity cRMAgreementEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreement_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMAgreementEntity.AgreementID);
                db.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, cRMAgreementEntity.PaymentScheduleID);
                db.AddInParameter(cmd, "@AgreementTypeID", DbType.Int64, cRMAgreementEntity.AgreementTypeID);
                db.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMAgreementEntity.BuyerBasicInfoID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, cRMAgreementEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, cRMAgreementEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@Text", DbType.String, cRMAgreementEntity.Text);
                db.AddInParameter(cmd, "@AgreementDate", DbType.DateTime, cRMAgreementEntity.AgreementDate);
                db.AddInParameter(cmd, "@SignDate", DbType.DateTime, cRMAgreementEntity.SignDate);
                db.AddInParameter(cmd, "@ExecuteDate", DbType.DateTime, cRMAgreementEntity.ExecuteDate);
                db.AddInParameter(cmd, "@Field1", DbType.String, cRMAgreementEntity.Field1);
                db.AddInParameter(cmd, "@Field2", DbType.String, cRMAgreementEntity.Field2);
                db.AddInParameter(cmd, "@Field3", DbType.String, cRMAgreementEntity.Field3);
                db.AddInParameter(cmd, "@Field4", DbType.String, cRMAgreementEntity.Field4);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementEntity.Remarks);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMAgreementEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMAgreementEntity.CreateDate);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMAgreementEntity.IP);
                db.AddInParameter(cmd, "@AgreementApprovalStatusID", DbType.Int64, cRMAgreementEntity.AgreementApprovalStatusID);

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

        IList<Int64> ICRMAgreementDataAccess.Update(IList<CRMAgreementEntity> cRMAgreementEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMAgreementEntity cRMAgreementEntity in cRMAgreementEntityList)
            {
                returnCode = (this as ICRMAgreementDataAccess).Update(cRMAgreementEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMAgreementDataAccess.Delete(CRMAgreementEntity cRMAgreementEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMAgreementEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMAgreementEntity, filterExpression, option);
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

        private Int64 Delete(CRMAgreementEntity cRMAgreementEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreement_SET";

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
                                throw new ArgumentException("CRMAgreementEntity already exists. Please specify another CRMAgreementEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMAgreementEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMAgreementEntity already exists. Please specify another CRMAgreementEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMAgreementEntity cRMAgreementEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreement_SET";

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

        IList<Int64> ICRMAgreementDataAccess.Delete(IList<CRMAgreementEntity> cRMAgreementEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMAgreementEntity cRMAgreementEntity in cRMAgreementEntityList)
            {
                returnCode = (this as ICRMAgreementDataAccess).Delete(cRMAgreementEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMAgreementEntity> ICRMAgreementDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMAgreement_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMAgreementEntity> list = CreateEntityBuilder<CRMAgreementEntity>().BuildEntities(reader);

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

        DataTable ICRMAgreementDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMAgreement_GET";

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
