// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Feb-2013, 04:16:42




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
    internal sealed partial class CMBillDataAccess : BaseDataAccess, ICMBillDataAccess
    {
        #region Constructors

        public CMBillDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMBillEntity> CreateEntityBuilder<CMBillEntity>()
        {
            return (new CMBillBuilder()) as IEntityBuilder<CMBillEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMBillDataAccess.Add(CMBillEntity cMBillEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMBillEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMBillEntity, option);
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

        private Int64 Add(CMBillEntity cMBillEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBill_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BillID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, cMBillEntity.ProjectID);	
                Database.AddInParameter(cmd, "@BillNo", DbType.String, cMBillEntity.BillNo);	
                Database.AddInParameter(cmd, "@VendorCategory", DbType.Int64, cMBillEntity.VendorCategory);	
                Database.AddInParameter(cmd, "@Vendor", DbType.Int64, cMBillEntity.Vendor);	
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, cMBillEntity.WorkOrderID);	
                Database.AddInParameter(cmd, "@DiscountAddition", DbType.Decimal, cMBillEntity.DiscountAddition);	
                Database.AddInParameter(cmd, "@Vat", DbType.Decimal, cMBillEntity.Vat);	
                Database.AddInParameter(cmd, "@Tax", DbType.Decimal, cMBillEntity.Tax);	
                Database.AddInParameter(cmd, "@CarryingCharge", DbType.Decimal, cMBillEntity.CarryingCharge);	
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, cMBillEntity.Amount);	
                Database.AddInParameter(cmd, "@AdditionRemarks", DbType.String, cMBillEntity.AdditionRemarks);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cMBillEntity.CreateDate);	
                Database.AddInParameter(cmd, "@BillDate", DbType.DateTime, cMBillEntity.BillDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMBillEntity.Remarks);	
                Database.AddInParameter(cmd, "@BillStatusID", DbType.Int64, cMBillEntity.BillStatusID);	
                Database.AddInParameter(cmd, "@BillApprovalStatusID", DbType.Int64, cMBillEntity.BillApprovalStatusID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMBillEntity already exists. Please specify another CMBillEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillEntity already exists. Please specify another CMBillEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMBillEntity cMBillEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBill_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BillID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, cMBillEntity.ProjectID);
                db.AddInParameter(cmd, "@BillNo", DbType.String, cMBillEntity.BillNo);
                db.AddInParameter(cmd, "@VendorCategory", DbType.Int64, cMBillEntity.VendorCategory);
                db.AddInParameter(cmd, "@Vendor", DbType.Int64, cMBillEntity.Vendor);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, cMBillEntity.WorkOrderID);
                db.AddInParameter(cmd, "@DiscountAddition", DbType.Decimal, cMBillEntity.DiscountAddition);
                db.AddInParameter(cmd, "@Vat", DbType.Decimal, cMBillEntity.Vat);
                db.AddInParameter(cmd, "@Tax", DbType.Decimal, cMBillEntity.Tax);
                db.AddInParameter(cmd, "@CarryingCharge", DbType.Decimal, cMBillEntity.CarryingCharge);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, cMBillEntity.Amount);
                db.AddInParameter(cmd, "@AdditionRemarks", DbType.String, cMBillEntity.AdditionRemarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cMBillEntity.CreateDate);
                db.AddInParameter(cmd, "@BillDate", DbType.DateTime, cMBillEntity.BillDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMBillEntity.Remarks);
                db.AddInParameter(cmd, "@BillStatusID", DbType.Int64, cMBillEntity.BillStatusID);
                db.AddInParameter(cmd, "@BillApprovalStatusID", DbType.Int64, cMBillEntity.BillApprovalStatusID);

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

        IList<Int64> ICMBillDataAccess.Add(IList<CMBillEntity> cMBillEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMBillEntity cMBillEntity in cMBillEntityList)
            {
                returnCode = (this as ICMBillDataAccess).Add(cMBillEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMBillDataAccess.Update(CMBillEntity cMBillEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMBillEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMBillEntity, filterExpression, option);
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

        private Int64 Update(CMBillEntity cMBillEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBill_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillEntity.BillID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, cMBillEntity.ProjectID);
                Database.AddInParameter(cmd, "@BillNo", DbType.String, cMBillEntity.BillNo);
                Database.AddInParameter(cmd, "@VendorCategory", DbType.Int64, cMBillEntity.VendorCategory);
                Database.AddInParameter(cmd, "@Vendor", DbType.Int64, cMBillEntity.Vendor);
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, cMBillEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@DiscountAddition", DbType.Decimal, cMBillEntity.DiscountAddition);
                Database.AddInParameter(cmd, "@Vat", DbType.Decimal, cMBillEntity.Vat);
                Database.AddInParameter(cmd, "@Tax", DbType.Decimal, cMBillEntity.Tax);
                Database.AddInParameter(cmd, "@CarryingCharge", DbType.Decimal, cMBillEntity.CarryingCharge);
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, cMBillEntity.Amount);
                Database.AddInParameter(cmd, "@AdditionRemarks", DbType.String, cMBillEntity.AdditionRemarks);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cMBillEntity.CreateDate);
                Database.AddInParameter(cmd, "@BillDate", DbType.DateTime, cMBillEntity.BillDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMBillEntity.Remarks);
                Database.AddInParameter(cmd, "@BillStatusID", DbType.Int64, cMBillEntity.BillStatusID);
                Database.AddInParameter(cmd, "@BillApprovalStatusID", DbType.Int64, cMBillEntity.BillApprovalStatusID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMBillEntity already exists. Please specify another CMBillEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillEntity already exists. Please specify another CMBillEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMBillEntity cMBillEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBill_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillEntity.BillID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, cMBillEntity.ProjectID);
                db.AddInParameter(cmd, "@BillNo", DbType.String, cMBillEntity.BillNo);
                db.AddInParameter(cmd, "@VendorCategory", DbType.Int64, cMBillEntity.VendorCategory);
                db.AddInParameter(cmd, "@Vendor", DbType.Int64, cMBillEntity.Vendor);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, cMBillEntity.WorkOrderID);
                db.AddInParameter(cmd, "@DiscountAddition", DbType.Decimal, cMBillEntity.DiscountAddition);
                db.AddInParameter(cmd, "@Vat", DbType.Decimal, cMBillEntity.Vat);
                db.AddInParameter(cmd, "@Tax", DbType.Decimal, cMBillEntity.Tax);
                db.AddInParameter(cmd, "@CarryingCharge", DbType.Decimal, cMBillEntity.CarryingCharge);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, cMBillEntity.Amount);
                db.AddInParameter(cmd, "@AdditionRemarks", DbType.String, cMBillEntity.AdditionRemarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cMBillEntity.CreateDate);
                db.AddInParameter(cmd, "@BillDate", DbType.DateTime, cMBillEntity.BillDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMBillEntity.Remarks);
                db.AddInParameter(cmd, "@BillStatusID", DbType.Int64, cMBillEntity.BillStatusID);
                db.AddInParameter(cmd, "@BillApprovalStatusID", DbType.Int64, cMBillEntity.BillApprovalStatusID);

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

        IList<Int64> ICMBillDataAccess.Update(IList<CMBillEntity> cMBillEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMBillEntity cMBillEntity in cMBillEntityList)
            {
                returnCode = (this as ICMBillDataAccess).Update(cMBillEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMBillDataAccess.Delete(CMBillEntity cMBillEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMBillEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMBillEntity, filterExpression, option);
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

        private Int64 Delete(CMBillEntity cMBillEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBill_SET";

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
                                throw new ArgumentException("CMBillEntity already exists. Please specify another CMBillEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillEntity already exists. Please specify another CMBillEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMBillEntity cMBillEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBill_SET";

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

        IList<Int64> ICMBillDataAccess.Delete(IList<CMBillEntity> cMBillEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMBillEntity cMBillEntity in cMBillEntityList)
            {
                returnCode = (this as ICMBillDataAccess).Delete(cMBillEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMBillEntity> ICMBillDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMBill_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMBillEntity> list = CreateEntityBuilder<CMBillEntity>().BuildEntities(reader);

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

        DataTable ICMBillDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMBill_GET";

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
