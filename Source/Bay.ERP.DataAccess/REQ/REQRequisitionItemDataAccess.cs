// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jun-2012, 11:52:40




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
    internal sealed partial class REQRequisitionItemDataAccess : BaseDataAccess, IREQRequisitionItemDataAccess
    {
        #region Constructors

        public REQRequisitionItemDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<REQRequisitionItemEntity> CreateEntityBuilder<REQRequisitionItemEntity>()
        {
            return (new REQRequisitionItemBuilder()) as IEntityBuilder<REQRequisitionItemEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IREQRequisitionItemDataAccess.Add(REQRequisitionItemEntity rEQRequisitionItemEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(rEQRequisitionItemEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(rEQRequisitionItemEntity, option);
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

        private Int64 Add(REQRequisitionItemEntity rEQRequisitionItemEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionItem_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "RequisitionItemID");

                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionItemEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@AccountsCode", DbType.String, rEQRequisitionItemEntity.AccountsCode);	
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, rEQRequisitionItemEntity.ItemID);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, rEQRequisitionItemEntity.BrandID);	
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, rEQRequisitionItemEntity.SupplierID);	
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, rEQRequisitionItemEntity.RegionID);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, rEQRequisitionItemEntity.CountryID);	
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, rEQRequisitionItemEntity.Rate);	
                Database.AddInParameter(cmd, "@TotalRequiredQty", DbType.Decimal, rEQRequisitionItemEntity.TotalRequiredQty);	
                Database.AddInParameter(cmd, "@PurchasedQtyTillToDate", DbType.Decimal, rEQRequisitionItemEntity.PurchasedQtyTillToDate);	
                Database.AddInParameter(cmd, "@PresentRequiredQty", DbType.Decimal, rEQRequisitionItemEntity.PresentRequiredQty);	
                Database.AddInParameter(cmd, "@RequiredDate", DbType.DateTime, rEQRequisitionItemEntity.RequiredDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionItemEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("REQRequisitionItemEntity already exists. Please specify another REQRequisitionItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("REQRequisitionItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("REQRequisitionItemEntity already exists. Please specify another REQRequisitionItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(REQRequisitionItemEntity rEQRequisitionItemEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionItem_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "RequisitionItemID", db);

                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionItemEntity.RequisitionID);
                db.AddInParameter(cmd, "@AccountsCode", DbType.String, rEQRequisitionItemEntity.AccountsCode);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, rEQRequisitionItemEntity.ItemID);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, rEQRequisitionItemEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, rEQRequisitionItemEntity.SupplierID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, rEQRequisitionItemEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, rEQRequisitionItemEntity.CountryID);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, rEQRequisitionItemEntity.Rate);
                db.AddInParameter(cmd, "@TotalRequiredQty", DbType.Decimal, rEQRequisitionItemEntity.TotalRequiredQty);
                db.AddInParameter(cmd, "@PurchasedQtyTillToDate", DbType.Decimal, rEQRequisitionItemEntity.PurchasedQtyTillToDate);
                db.AddInParameter(cmd, "@PresentRequiredQty", DbType.Decimal, rEQRequisitionItemEntity.PresentRequiredQty);
                db.AddInParameter(cmd, "@RequiredDate", DbType.DateTime, rEQRequisitionItemEntity.RequiredDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionItemEntity.Remarks);

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

        IList<Int64> IREQRequisitionItemDataAccess.Add(IList<REQRequisitionItemEntity> rEQRequisitionItemEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (REQRequisitionItemEntity rEQRequisitionItemEntity in rEQRequisitionItemEntityList)
            {
                returnCode = (this as IREQRequisitionItemDataAccess).Add(rEQRequisitionItemEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IREQRequisitionItemDataAccess.Update(REQRequisitionItemEntity rEQRequisitionItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(rEQRequisitionItemEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(rEQRequisitionItemEntity, filterExpression, option);
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

        private Int64 Update(REQRequisitionItemEntity rEQRequisitionItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionItem_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, rEQRequisitionItemEntity.RequisitionItemID);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionItemEntity.RequisitionID);
                Database.AddInParameter(cmd, "@AccountsCode", DbType.String, rEQRequisitionItemEntity.AccountsCode);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, rEQRequisitionItemEntity.ItemID);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, rEQRequisitionItemEntity.BrandID);
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, rEQRequisitionItemEntity.SupplierID);
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, rEQRequisitionItemEntity.RegionID);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, rEQRequisitionItemEntity.CountryID);
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, rEQRequisitionItemEntity.Rate);
                Database.AddInParameter(cmd, "@TotalRequiredQty", DbType.Decimal, rEQRequisitionItemEntity.TotalRequiredQty);
                Database.AddInParameter(cmd, "@PurchasedQtyTillToDate", DbType.Decimal, rEQRequisitionItemEntity.PurchasedQtyTillToDate);
                Database.AddInParameter(cmd, "@PresentRequiredQty", DbType.Decimal, rEQRequisitionItemEntity.PresentRequiredQty);
                Database.AddInParameter(cmd, "@RequiredDate", DbType.DateTime, rEQRequisitionItemEntity.RequiredDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionItemEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("REQRequisitionItemEntity already exists. Please specify another REQRequisitionItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("REQRequisitionItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("REQRequisitionItemEntity already exists. Please specify another REQRequisitionItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(REQRequisitionItemEntity rEQRequisitionItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionItem_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, rEQRequisitionItemEntity.RequisitionItemID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionItemEntity.RequisitionID);
                db.AddInParameter(cmd, "@AccountsCode", DbType.String, rEQRequisitionItemEntity.AccountsCode);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, rEQRequisitionItemEntity.ItemID);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, rEQRequisitionItemEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, rEQRequisitionItemEntity.SupplierID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, rEQRequisitionItemEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, rEQRequisitionItemEntity.CountryID);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, rEQRequisitionItemEntity.Rate);
                db.AddInParameter(cmd, "@TotalRequiredQty", DbType.Decimal, rEQRequisitionItemEntity.TotalRequiredQty);
                db.AddInParameter(cmd, "@PurchasedQtyTillToDate", DbType.Decimal, rEQRequisitionItemEntity.PurchasedQtyTillToDate);
                db.AddInParameter(cmd, "@PresentRequiredQty", DbType.Decimal, rEQRequisitionItemEntity.PresentRequiredQty);
                db.AddInParameter(cmd, "@RequiredDate", DbType.DateTime, rEQRequisitionItemEntity.RequiredDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionItemEntity.Remarks);

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

        IList<Int64> IREQRequisitionItemDataAccess.Update(IList<REQRequisitionItemEntity> rEQRequisitionItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (REQRequisitionItemEntity rEQRequisitionItemEntity in rEQRequisitionItemEntityList)
            {
                returnCode = (this as IREQRequisitionItemDataAccess).Update(rEQRequisitionItemEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IREQRequisitionItemDataAccess.Delete(REQRequisitionItemEntity rEQRequisitionItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(rEQRequisitionItemEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(rEQRequisitionItemEntity, filterExpression, option);
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

        private Int64 Delete(REQRequisitionItemEntity rEQRequisitionItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionItem_SET";

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
                                throw new ArgumentException("REQRequisitionItemEntity already exists. Please specify another REQRequisitionItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("REQRequisitionItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("REQRequisitionItemEntity already exists. Please specify another REQRequisitionItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(REQRequisitionItemEntity rEQRequisitionItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionItem_SET";

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

        IList<Int64> IREQRequisitionItemDataAccess.Delete(IList<REQRequisitionItemEntity> rEQRequisitionItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (REQRequisitionItemEntity rEQRequisitionItemEntity in rEQRequisitionItemEntityList)
            {
                returnCode = (this as IREQRequisitionItemDataAccess).Delete(rEQRequisitionItemEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<REQRequisitionItemEntity> IREQRequisitionItemDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.REQRequisitionItem_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<REQRequisitionItemEntity> list = CreateEntityBuilder<REQRequisitionItemEntity>().BuildEntities(reader);

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

        DataTable IREQRequisitionItemDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.REQRequisitionItem_GET";

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
