// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Nov-2012, 01:32:58




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
    internal sealed partial class PRMWorkOrderItemMapDataAccess : BaseDataAccess, IPRMWorkOrderItemMapDataAccess
    {
        #region Constructors

        public PRMWorkOrderItemMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMWorkOrderItemMapEntity> CreateEntityBuilder<PRMWorkOrderItemMapEntity>()
        {
            return (new PRMWorkOrderItemMapBuilder()) as IEntityBuilder<PRMWorkOrderItemMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMWorkOrderItemMapDataAccess.Add(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMWorkOrderItemMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMWorkOrderItemMapEntity, option);
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

        private Int64 Add(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "WorkOrderItemMapID");

                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderItemMapEntity.WorkOrderID);	
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, pRMWorkOrderItemMapEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, pRMWorkOrderItemMapEntity.RequisitionItemID);	
                Database.AddInParameter(cmd, "@RequiredQty", DbType.Decimal, pRMWorkOrderItemMapEntity.RequiredQty);	
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMWorkOrderItemMapEntity.Rate);	
                Database.AddInParameter(cmd, "@DeliveryAddress", DbType.String, pRMWorkOrderItemMapEntity.DeliveryAddress);	
                Database.AddInParameter(cmd, "@Description", DbType.String, pRMWorkOrderItemMapEntity.Description);	
                Database.AddInParameter(cmd, "@WorkOrderStatusID", DbType.Int64, pRMWorkOrderItemMapEntity.WorkOrderStatusID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMWorkOrderItemMapEntity already exists. Please specify another PRMWorkOrderItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemMapEntity already exists. Please specify another PRMWorkOrderItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "WorkOrderItemMapID", db);

                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderItemMapEntity.WorkOrderID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, pRMWorkOrderItemMapEntity.RequisitionID);
                db.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, pRMWorkOrderItemMapEntity.RequisitionItemID);
                db.AddInParameter(cmd, "@RequiredQty", DbType.Decimal, pRMWorkOrderItemMapEntity.RequiredQty);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMWorkOrderItemMapEntity.Rate);
                db.AddInParameter(cmd, "@DeliveryAddress", DbType.String, pRMWorkOrderItemMapEntity.DeliveryAddress);
                db.AddInParameter(cmd, "@Description", DbType.String, pRMWorkOrderItemMapEntity.Description);
                db.AddInParameter(cmd, "@WorkOrderStatusID", DbType.Int64, pRMWorkOrderItemMapEntity.WorkOrderStatusID);

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

        IList<Int64> IPRMWorkOrderItemMapDataAccess.Add(IList<PRMWorkOrderItemMapEntity> pRMWorkOrderItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity in pRMWorkOrderItemMapEntityList)
            {
                returnCode = (this as IPRMWorkOrderItemMapDataAccess).Add(pRMWorkOrderItemMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMWorkOrderItemMapDataAccess.Update(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMWorkOrderItemMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMWorkOrderItemMapEntity, filterExpression, option);
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

        private Int64 Update(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@WorkOrderItemMapID", DbType.Int64, pRMWorkOrderItemMapEntity.WorkOrderItemMapID);
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderItemMapEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, pRMWorkOrderItemMapEntity.RequisitionID);
                Database.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, pRMWorkOrderItemMapEntity.RequisitionItemID);
                Database.AddInParameter(cmd, "@RequiredQty", DbType.Decimal, pRMWorkOrderItemMapEntity.RequiredQty);
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMWorkOrderItemMapEntity.Rate);
                Database.AddInParameter(cmd, "@DeliveryAddress", DbType.String, pRMWorkOrderItemMapEntity.DeliveryAddress);
                Database.AddInParameter(cmd, "@Description", DbType.String, pRMWorkOrderItemMapEntity.Description);
                Database.AddInParameter(cmd, "@WorkOrderStatusID", DbType.Int64, pRMWorkOrderItemMapEntity.WorkOrderStatusID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMWorkOrderItemMapEntity already exists. Please specify another PRMWorkOrderItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemMapEntity already exists. Please specify another PRMWorkOrderItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@WorkOrderItemMapID", DbType.Int64, pRMWorkOrderItemMapEntity.WorkOrderItemMapID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderItemMapEntity.WorkOrderID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, pRMWorkOrderItemMapEntity.RequisitionID);
                db.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, pRMWorkOrderItemMapEntity.RequisitionItemID);
                db.AddInParameter(cmd, "@RequiredQty", DbType.Decimal, pRMWorkOrderItemMapEntity.RequiredQty);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMWorkOrderItemMapEntity.Rate);
                db.AddInParameter(cmd, "@DeliveryAddress", DbType.String, pRMWorkOrderItemMapEntity.DeliveryAddress);
                db.AddInParameter(cmd, "@Description", DbType.String, pRMWorkOrderItemMapEntity.Description);
                db.AddInParameter(cmd, "@WorkOrderStatusID", DbType.Int64, pRMWorkOrderItemMapEntity.WorkOrderStatusID);

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

        IList<Int64> IPRMWorkOrderItemMapDataAccess.Update(IList<PRMWorkOrderItemMapEntity> pRMWorkOrderItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity in pRMWorkOrderItemMapEntityList)
            {
                returnCode = (this as IPRMWorkOrderItemMapDataAccess).Update(pRMWorkOrderItemMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMWorkOrderItemMapDataAccess.Delete(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMWorkOrderItemMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMWorkOrderItemMapEntity, filterExpression, option);
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

        private Int64 Delete(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemMap_SET";

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
                                throw new ArgumentException("PRMWorkOrderItemMapEntity already exists. Please specify another PRMWorkOrderItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemMapEntity already exists. Please specify another PRMWorkOrderItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemMap_SET";

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

        IList<Int64> IPRMWorkOrderItemMapDataAccess.Delete(IList<PRMWorkOrderItemMapEntity> pRMWorkOrderItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity in pRMWorkOrderItemMapEntityList)
            {
                returnCode = (this as IPRMWorkOrderItemMapDataAccess).Delete(pRMWorkOrderItemMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMWorkOrderItemMapEntity> IPRMWorkOrderItemMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderItemMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMWorkOrderItemMapEntity> list = CreateEntityBuilder<PRMWorkOrderItemMapEntity>().BuildEntities(reader);

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

        DataTable IPRMWorkOrderItemMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderItemMap_GET";

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
