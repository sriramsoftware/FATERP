// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Aug-2013, 05:21:45




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
    internal sealed partial class PRMWorkOrderItemFloorDetailDataAccess : BaseDataAccess, IPRMWorkOrderItemFloorDetailDataAccess
    {
        #region Constructors

        public PRMWorkOrderItemFloorDetailDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMWorkOrderItemFloorDetailEntity> CreateEntityBuilder<PRMWorkOrderItemFloorDetailEntity>()
        {
            return (new PRMWorkOrderItemFloorDetailBuilder()) as IEntityBuilder<PRMWorkOrderItemFloorDetailEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMWorkOrderItemFloorDetailDataAccess.Add(PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMWorkOrderItemFloorDetailEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMWorkOrderItemFloorDetailEntity, option);
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

        private Int64 Add(PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemFloorDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "WorkOrderItemFloorDetailID");

                Database.AddInParameter(cmd, "@WorkOrderItemMapID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.WorkOrderItemMapID);	
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.WorkOrderID);	
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.RequisitionItemID);	
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.ProjectFloorID);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.ProjectFloorUnitID);	
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMWorkOrderItemFloorDetailEntity.Qty);	
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMWorkOrderItemFloorDetailEntity.Rate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMWorkOrderItemFloorDetailEntity.Remarks);	
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMWorkOrderItemFloorDetailEntity.EntryDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMWorkOrderItemFloorDetailEntity already exists. Please specify another PRMWorkOrderItemFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemFloorDetailEntity already exists. Please specify another PRMWorkOrderItemFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemFloorDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "WorkOrderItemFloorDetailID", db);

                db.AddInParameter(cmd, "@WorkOrderItemMapID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.WorkOrderItemMapID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.WorkOrderID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.RequisitionID);
                db.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.RequisitionItemID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMWorkOrderItemFloorDetailEntity.Qty);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMWorkOrderItemFloorDetailEntity.Rate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMWorkOrderItemFloorDetailEntity.Remarks);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMWorkOrderItemFloorDetailEntity.EntryDate);

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

        IList<Int64> IPRMWorkOrderItemFloorDetailDataAccess.Add(IList<PRMWorkOrderItemFloorDetailEntity> pRMWorkOrderItemFloorDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity in pRMWorkOrderItemFloorDetailEntityList)
            {
                returnCode = (this as IPRMWorkOrderItemFloorDetailDataAccess).Add(pRMWorkOrderItemFloorDetailEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMWorkOrderItemFloorDetailDataAccess.Update(PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMWorkOrderItemFloorDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMWorkOrderItemFloorDetailEntity, filterExpression, option);
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

        private Int64 Update(PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemFloorDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@WorkOrderItemFloorDetailID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.WorkOrderItemFloorDetailID);
                Database.AddInParameter(cmd, "@WorkOrderItemMapID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.WorkOrderItemMapID);
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.RequisitionID);
                Database.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.RequisitionItemID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.ProjectFloorUnitID);
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMWorkOrderItemFloorDetailEntity.Qty);
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMWorkOrderItemFloorDetailEntity.Rate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMWorkOrderItemFloorDetailEntity.Remarks);
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMWorkOrderItemFloorDetailEntity.EntryDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMWorkOrderItemFloorDetailEntity already exists. Please specify another PRMWorkOrderItemFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemFloorDetailEntity already exists. Please specify another PRMWorkOrderItemFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemFloorDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@WorkOrderItemFloorDetailID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.WorkOrderItemFloorDetailID);
                db.AddInParameter(cmd, "@WorkOrderItemMapID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.WorkOrderItemMapID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.WorkOrderID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.RequisitionID);
                db.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.RequisitionItemID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, pRMWorkOrderItemFloorDetailEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMWorkOrderItemFloorDetailEntity.Qty);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMWorkOrderItemFloorDetailEntity.Rate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMWorkOrderItemFloorDetailEntity.Remarks);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMWorkOrderItemFloorDetailEntity.EntryDate);

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

        IList<Int64> IPRMWorkOrderItemFloorDetailDataAccess.Update(IList<PRMWorkOrderItemFloorDetailEntity> pRMWorkOrderItemFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity in pRMWorkOrderItemFloorDetailEntityList)
            {
                returnCode = (this as IPRMWorkOrderItemFloorDetailDataAccess).Update(pRMWorkOrderItemFloorDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMWorkOrderItemFloorDetailDataAccess.Delete(PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMWorkOrderItemFloorDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMWorkOrderItemFloorDetailEntity, filterExpression, option);
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

        private Int64 Delete(PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemFloorDetail_SET";

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
                                throw new ArgumentException("PRMWorkOrderItemFloorDetailEntity already exists. Please specify another PRMWorkOrderItemFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemFloorDetailEntity already exists. Please specify another PRMWorkOrderItemFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemFloorDetail_SET";

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

        IList<Int64> IPRMWorkOrderItemFloorDetailDataAccess.Delete(IList<PRMWorkOrderItemFloorDetailEntity> pRMWorkOrderItemFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity in pRMWorkOrderItemFloorDetailEntityList)
            {
                returnCode = (this as IPRMWorkOrderItemFloorDetailDataAccess).Delete(pRMWorkOrderItemFloorDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMWorkOrderItemFloorDetailEntity> IPRMWorkOrderItemFloorDetailDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderItemFloorDetail_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMWorkOrderItemFloorDetailEntity> list = CreateEntityBuilder<PRMWorkOrderItemFloorDetailEntity>().BuildEntities(reader);

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

        DataTable IPRMWorkOrderItemFloorDetailDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderItemFloorDetail_GET";

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
