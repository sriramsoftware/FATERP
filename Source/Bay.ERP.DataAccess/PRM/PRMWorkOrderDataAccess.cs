// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




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
    internal sealed partial class PRMWorkOrderDataAccess : BaseDataAccess, IPRMWorkOrderDataAccess
    {
        #region Constructors

        public PRMWorkOrderDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMWorkOrderEntity> CreateEntityBuilder<PRMWorkOrderEntity>()
        {
            return (new PRMWorkOrderBuilder()) as IEntityBuilder<PRMWorkOrderEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMWorkOrderDataAccess.Add(PRMWorkOrderEntity pRMWorkOrderEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMWorkOrderEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMWorkOrderEntity, option);
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

        private Int64 Add(PRMWorkOrderEntity pRMWorkOrderEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrder_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "WorkOrderID");

                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMWorkOrderEntity.SupplierID);	
                Database.AddInParameter(cmd, "@WorkOrderNo", DbType.String, pRMWorkOrderEntity.WorkOrderNo);	
                Database.AddInParameter(cmd, "@AttentionID", DbType.Int64, pRMWorkOrderEntity.AttentionID);	
                Database.AddInParameter(cmd, "@OtherAttention", DbType.String, pRMWorkOrderEntity.OtherAttention);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, pRMWorkOrderEntity.CreateDate);	
                Database.AddInParameter(cmd, "@Subject", DbType.String, pRMWorkOrderEntity.Subject);	
                Database.AddInParameter(cmd, "@BodyTitle", DbType.String, pRMWorkOrderEntity.BodyTitle);	
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, pRMWorkOrderEntity.StartDate);	
                Database.AddInParameter(cmd, "@CompletionDate", DbType.DateTime, pRMWorkOrderEntity.CompletionDate);	
                Database.AddInParameter(cmd, "@Warranty", DbType.String, pRMWorkOrderEntity.Warranty);	
                Database.AddInParameter(cmd, "@DelayCharge", DbType.String, pRMWorkOrderEntity.DelayCharge);	
                Database.AddInParameter(cmd, "@AIT", DbType.Decimal, pRMWorkOrderEntity.AIT);	
                Database.AddInParameter(cmd, "@CarryingCharge", DbType.Decimal, pRMWorkOrderEntity.CarryingCharge);	
                Database.AddInParameter(cmd, "@Discount", DbType.Decimal, pRMWorkOrderEntity.Discount);	
                Database.AddInParameter(cmd, "@VAT", DbType.Decimal, pRMWorkOrderEntity.VAT);	
                Database.AddInParameter(cmd, "@Tax", DbType.Decimal, pRMWorkOrderEntity.Tax);	
                Database.AddInParameter(cmd, "@GrandTotal", DbType.Decimal, pRMWorkOrderEntity.GrandTotal);	
                Database.AddInParameter(cmd, "@RowText", DbType.String, pRMWorkOrderEntity.RowText);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMWorkOrderEntity.Remarks);	
                Database.AddInParameter(cmd, "@FootNote", DbType.String, pRMWorkOrderEntity.FootNote);	
                Database.AddInParameter(cmd, "@PreparedByID", DbType.Int64, pRMWorkOrderEntity.PreparedByID);	
                Database.AddInParameter(cmd, "@WorkOrderStatusID", DbType.Int64, pRMWorkOrderEntity.WorkOrderStatusID);	
                Database.AddInParameter(cmd, "@IsFinalBilled", DbType.Boolean, pRMWorkOrderEntity.IsFinalBilled);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMWorkOrderEntity already exists. Please specify another PRMWorkOrderEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderEntity already exists. Please specify another PRMWorkOrderEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMWorkOrderEntity pRMWorkOrderEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrder_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "WorkOrderID", db);

                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMWorkOrderEntity.SupplierID);
                db.AddInParameter(cmd, "@WorkOrderNo", DbType.String, pRMWorkOrderEntity.WorkOrderNo);
                db.AddInParameter(cmd, "@AttentionID", DbType.Int64, pRMWorkOrderEntity.AttentionID);
                db.AddInParameter(cmd, "@OtherAttention", DbType.String, pRMWorkOrderEntity.OtherAttention);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, pRMWorkOrderEntity.CreateDate);
                db.AddInParameter(cmd, "@Subject", DbType.String, pRMWorkOrderEntity.Subject);
                db.AddInParameter(cmd, "@BodyTitle", DbType.String, pRMWorkOrderEntity.BodyTitle);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, pRMWorkOrderEntity.StartDate);
                db.AddInParameter(cmd, "@CompletionDate", DbType.DateTime, pRMWorkOrderEntity.CompletionDate);
                db.AddInParameter(cmd, "@Warranty", DbType.String, pRMWorkOrderEntity.Warranty);
                db.AddInParameter(cmd, "@DelayCharge", DbType.String, pRMWorkOrderEntity.DelayCharge);
                db.AddInParameter(cmd, "@AIT", DbType.Decimal, pRMWorkOrderEntity.AIT);
                db.AddInParameter(cmd, "@CarryingCharge", DbType.Decimal, pRMWorkOrderEntity.CarryingCharge);
                db.AddInParameter(cmd, "@Discount", DbType.Decimal, pRMWorkOrderEntity.Discount);
                db.AddInParameter(cmd, "@VAT", DbType.Decimal, pRMWorkOrderEntity.VAT);
                db.AddInParameter(cmd, "@Tax", DbType.Decimal, pRMWorkOrderEntity.Tax);
                db.AddInParameter(cmd, "@GrandTotal", DbType.Decimal, pRMWorkOrderEntity.GrandTotal);
                db.AddInParameter(cmd, "@RowText", DbType.String, pRMWorkOrderEntity.RowText);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMWorkOrderEntity.Remarks);
                db.AddInParameter(cmd, "@FootNote", DbType.String, pRMWorkOrderEntity.FootNote);
                db.AddInParameter(cmd, "@PreparedByID", DbType.Int64, pRMWorkOrderEntity.PreparedByID);
                db.AddInParameter(cmd, "@WorkOrderStatusID", DbType.Int64, pRMWorkOrderEntity.WorkOrderStatusID);
                db.AddInParameter(cmd, "@IsFinalBilled", DbType.Boolean, pRMWorkOrderEntity.IsFinalBilled);

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

        IList<Int64> IPRMWorkOrderDataAccess.Add(IList<PRMWorkOrderEntity> pRMWorkOrderEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMWorkOrderEntity pRMWorkOrderEntity in pRMWorkOrderEntityList)
            {
                returnCode = (this as IPRMWorkOrderDataAccess).Add(pRMWorkOrderEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMWorkOrderDataAccess.Update(PRMWorkOrderEntity pRMWorkOrderEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMWorkOrderEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMWorkOrderEntity, filterExpression, option);
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

        private Int64 Update(PRMWorkOrderEntity pRMWorkOrderEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrder_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMWorkOrderEntity.SupplierID);
                Database.AddInParameter(cmd, "@WorkOrderNo", DbType.String, pRMWorkOrderEntity.WorkOrderNo);
                Database.AddInParameter(cmd, "@AttentionID", DbType.Int64, pRMWorkOrderEntity.AttentionID);
                Database.AddInParameter(cmd, "@OtherAttention", DbType.String, pRMWorkOrderEntity.OtherAttention);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, pRMWorkOrderEntity.CreateDate);
                Database.AddInParameter(cmd, "@Subject", DbType.String, pRMWorkOrderEntity.Subject);
                Database.AddInParameter(cmd, "@BodyTitle", DbType.String, pRMWorkOrderEntity.BodyTitle);
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, pRMWorkOrderEntity.StartDate);
                Database.AddInParameter(cmd, "@CompletionDate", DbType.DateTime, pRMWorkOrderEntity.CompletionDate);
                Database.AddInParameter(cmd, "@Warranty", DbType.String, pRMWorkOrderEntity.Warranty);
                Database.AddInParameter(cmd, "@DelayCharge", DbType.String, pRMWorkOrderEntity.DelayCharge);
                Database.AddInParameter(cmd, "@AIT", DbType.Decimal, pRMWorkOrderEntity.AIT);
                Database.AddInParameter(cmd, "@CarryingCharge", DbType.Decimal, pRMWorkOrderEntity.CarryingCharge);
                Database.AddInParameter(cmd, "@Discount", DbType.Decimal, pRMWorkOrderEntity.Discount);
                Database.AddInParameter(cmd, "@VAT", DbType.Decimal, pRMWorkOrderEntity.VAT);
                Database.AddInParameter(cmd, "@Tax", DbType.Decimal, pRMWorkOrderEntity.Tax);
                Database.AddInParameter(cmd, "@GrandTotal", DbType.Decimal, pRMWorkOrderEntity.GrandTotal);
                Database.AddInParameter(cmd, "@RowText", DbType.String, pRMWorkOrderEntity.RowText);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMWorkOrderEntity.Remarks);
                Database.AddInParameter(cmd, "@FootNote", DbType.String, pRMWorkOrderEntity.FootNote);
                Database.AddInParameter(cmd, "@PreparedByID", DbType.Int64, pRMWorkOrderEntity.PreparedByID);
                Database.AddInParameter(cmd, "@WorkOrderStatusID", DbType.Int64, pRMWorkOrderEntity.WorkOrderStatusID);
                Database.AddInParameter(cmd, "@IsFinalBilled", DbType.Boolean, pRMWorkOrderEntity.IsFinalBilled);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMWorkOrderEntity already exists. Please specify another PRMWorkOrderEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderEntity already exists. Please specify another PRMWorkOrderEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMWorkOrderEntity pRMWorkOrderEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrder_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderEntity.WorkOrderID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMWorkOrderEntity.SupplierID);
                db.AddInParameter(cmd, "@WorkOrderNo", DbType.String, pRMWorkOrderEntity.WorkOrderNo);
                db.AddInParameter(cmd, "@AttentionID", DbType.Int64, pRMWorkOrderEntity.AttentionID);
                db.AddInParameter(cmd, "@OtherAttention", DbType.String, pRMWorkOrderEntity.OtherAttention);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, pRMWorkOrderEntity.CreateDate);
                db.AddInParameter(cmd, "@Subject", DbType.String, pRMWorkOrderEntity.Subject);
                db.AddInParameter(cmd, "@BodyTitle", DbType.String, pRMWorkOrderEntity.BodyTitle);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, pRMWorkOrderEntity.StartDate);
                db.AddInParameter(cmd, "@CompletionDate", DbType.DateTime, pRMWorkOrderEntity.CompletionDate);
                db.AddInParameter(cmd, "@Warranty", DbType.String, pRMWorkOrderEntity.Warranty);
                db.AddInParameter(cmd, "@DelayCharge", DbType.String, pRMWorkOrderEntity.DelayCharge);
                db.AddInParameter(cmd, "@AIT", DbType.Decimal, pRMWorkOrderEntity.AIT);
                db.AddInParameter(cmd, "@CarryingCharge", DbType.Decimal, pRMWorkOrderEntity.CarryingCharge);
                db.AddInParameter(cmd, "@Discount", DbType.Decimal, pRMWorkOrderEntity.Discount);
                db.AddInParameter(cmd, "@VAT", DbType.Decimal, pRMWorkOrderEntity.VAT);
                db.AddInParameter(cmd, "@Tax", DbType.Decimal, pRMWorkOrderEntity.Tax);
                db.AddInParameter(cmd, "@GrandTotal", DbType.Decimal, pRMWorkOrderEntity.GrandTotal);
                db.AddInParameter(cmd, "@RowText", DbType.String, pRMWorkOrderEntity.RowText);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMWorkOrderEntity.Remarks);
                db.AddInParameter(cmd, "@FootNote", DbType.String, pRMWorkOrderEntity.FootNote);
                db.AddInParameter(cmd, "@PreparedByID", DbType.Int64, pRMWorkOrderEntity.PreparedByID);
                db.AddInParameter(cmd, "@WorkOrderStatusID", DbType.Int64, pRMWorkOrderEntity.WorkOrderStatusID);
                db.AddInParameter(cmd, "@IsFinalBilled", DbType.Boolean, pRMWorkOrderEntity.IsFinalBilled);

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

        IList<Int64> IPRMWorkOrderDataAccess.Update(IList<PRMWorkOrderEntity> pRMWorkOrderEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMWorkOrderEntity pRMWorkOrderEntity in pRMWorkOrderEntityList)
            {
                returnCode = (this as IPRMWorkOrderDataAccess).Update(pRMWorkOrderEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMWorkOrderDataAccess.Delete(PRMWorkOrderEntity pRMWorkOrderEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMWorkOrderEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMWorkOrderEntity, filterExpression, option);
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

        private Int64 Delete(PRMWorkOrderEntity pRMWorkOrderEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrder_SET";

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
                                throw new ArgumentException("PRMWorkOrderEntity already exists. Please specify another PRMWorkOrderEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderEntity already exists. Please specify another PRMWorkOrderEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMWorkOrderEntity pRMWorkOrderEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrder_SET";

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

        IList<Int64> IPRMWorkOrderDataAccess.Delete(IList<PRMWorkOrderEntity> pRMWorkOrderEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMWorkOrderEntity pRMWorkOrderEntity in pRMWorkOrderEntityList)
            {
                returnCode = (this as IPRMWorkOrderDataAccess).Delete(pRMWorkOrderEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMWorkOrderEntity> IPRMWorkOrderDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrder_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMWorkOrderEntity> list = CreateEntityBuilder<PRMWorkOrderEntity>().BuildEntities(reader);

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

        DataTable IPRMWorkOrderDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrder_GET";

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
