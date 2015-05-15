// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




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
    internal sealed partial class ACItemGroupAccountMapDataAccess : BaseDataAccess, IACItemGroupAccountMapDataAccess
    {
        #region Constructors

        public ACItemGroupAccountMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACItemGroupAccountMapEntity> CreateEntityBuilder<ACItemGroupAccountMapEntity>()
        {
            return (new ACItemGroupAccountMapBuilder()) as IEntityBuilder<ACItemGroupAccountMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACItemGroupAccountMapDataAccess.Add(ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCItemGroupAccountMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCItemGroupAccountMapEntity, option);
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

        private Int64 Add(ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACItemGroupAccountMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ItemGroupAccountMapID");

                Database.AddInParameter(cmd, "@ItemCategoryID", DbType.Int64, aCItemGroupAccountMapEntity.ItemCategoryID);	
                Database.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCItemGroupAccountMapEntity.DimensionID);	
                Database.AddInParameter(cmd, "@SalesAccountID", DbType.Int64, aCItemGroupAccountMapEntity.SalesAccountID);	
                Database.AddInParameter(cmd, "@InventoryAccountID", DbType.Int64, aCItemGroupAccountMapEntity.InventoryAccountID);	
                Database.AddInParameter(cmd, "@COGSAccountID", DbType.Int64, aCItemGroupAccountMapEntity.COGSAccountID);	
                Database.AddInParameter(cmd, "@InventoryAdjustmentsAccountID", DbType.Int64, aCItemGroupAccountMapEntity.InventoryAdjustmentsAccountID);	
                Database.AddInParameter(cmd, "@AssetType", DbType.String, aCItemGroupAccountMapEntity.AssetType);	
                Database.AddInParameter(cmd, "@PurchaseDate", DbType.DateTime, aCItemGroupAccountMapEntity.PurchaseDate);	
                Database.AddInParameter(cmd, "@PurchasePrice", DbType.Decimal, aCItemGroupAccountMapEntity.PurchasePrice);	
                Database.AddInParameter(cmd, "@DepreciationRate", DbType.Decimal, aCItemGroupAccountMapEntity.DepreciationRate);	
                Database.AddInParameter(cmd, "@DepreciationMethodID", DbType.Int64, aCItemGroupAccountMapEntity.DepreciationMethodID);	
                Database.AddInParameter(cmd, "@DepreciationAccountID", DbType.Int64, aCItemGroupAccountMapEntity.DepreciationAccountID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACItemGroupAccountMapEntity already exists. Please specify another ACItemGroupAccountMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACItemGroupAccountMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACItemGroupAccountMapEntity already exists. Please specify another ACItemGroupAccountMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACItemGroupAccountMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ItemGroupAccountMapID", db);

                db.AddInParameter(cmd, "@ItemCategoryID", DbType.Int64, aCItemGroupAccountMapEntity.ItemCategoryID);
                db.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCItemGroupAccountMapEntity.DimensionID);
                db.AddInParameter(cmd, "@SalesAccountID", DbType.Int64, aCItemGroupAccountMapEntity.SalesAccountID);
                db.AddInParameter(cmd, "@InventoryAccountID", DbType.Int64, aCItemGroupAccountMapEntity.InventoryAccountID);
                db.AddInParameter(cmd, "@COGSAccountID", DbType.Int64, aCItemGroupAccountMapEntity.COGSAccountID);
                db.AddInParameter(cmd, "@InventoryAdjustmentsAccountID", DbType.Int64, aCItemGroupAccountMapEntity.InventoryAdjustmentsAccountID);
                db.AddInParameter(cmd, "@AssetType", DbType.String, aCItemGroupAccountMapEntity.AssetType);
                db.AddInParameter(cmd, "@PurchaseDate", DbType.DateTime, aCItemGroupAccountMapEntity.PurchaseDate);
                db.AddInParameter(cmd, "@PurchasePrice", DbType.Decimal, aCItemGroupAccountMapEntity.PurchasePrice);
                db.AddInParameter(cmd, "@DepreciationRate", DbType.Decimal, aCItemGroupAccountMapEntity.DepreciationRate);
                db.AddInParameter(cmd, "@DepreciationMethodID", DbType.Int64, aCItemGroupAccountMapEntity.DepreciationMethodID);
                db.AddInParameter(cmd, "@DepreciationAccountID", DbType.Int64, aCItemGroupAccountMapEntity.DepreciationAccountID);

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

        IList<Int64> IACItemGroupAccountMapDataAccess.Add(IList<ACItemGroupAccountMapEntity> aCItemGroupAccountMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity in aCItemGroupAccountMapEntityList)
            {
                returnCode = (this as IACItemGroupAccountMapDataAccess).Add(aCItemGroupAccountMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACItemGroupAccountMapDataAccess.Update(ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCItemGroupAccountMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCItemGroupAccountMapEntity, filterExpression, option);
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

        private Int64 Update(ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACItemGroupAccountMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ItemGroupAccountMapID", DbType.Int64, aCItemGroupAccountMapEntity.ItemGroupAccountMapID);
                Database.AddInParameter(cmd, "@ItemCategoryID", DbType.Int64, aCItemGroupAccountMapEntity.ItemCategoryID);
                Database.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCItemGroupAccountMapEntity.DimensionID);
                Database.AddInParameter(cmd, "@SalesAccountID", DbType.Int64, aCItemGroupAccountMapEntity.SalesAccountID);
                Database.AddInParameter(cmd, "@InventoryAccountID", DbType.Int64, aCItemGroupAccountMapEntity.InventoryAccountID);
                Database.AddInParameter(cmd, "@COGSAccountID", DbType.Int64, aCItemGroupAccountMapEntity.COGSAccountID);
                Database.AddInParameter(cmd, "@InventoryAdjustmentsAccountID", DbType.Int64, aCItemGroupAccountMapEntity.InventoryAdjustmentsAccountID);
                Database.AddInParameter(cmd, "@AssetType", DbType.String, aCItemGroupAccountMapEntity.AssetType);
                Database.AddInParameter(cmd, "@PurchaseDate", DbType.DateTime, aCItemGroupAccountMapEntity.PurchaseDate);
                Database.AddInParameter(cmd, "@PurchasePrice", DbType.Decimal, aCItemGroupAccountMapEntity.PurchasePrice);
                Database.AddInParameter(cmd, "@DepreciationRate", DbType.Decimal, aCItemGroupAccountMapEntity.DepreciationRate);
                Database.AddInParameter(cmd, "@DepreciationMethodID", DbType.Int64, aCItemGroupAccountMapEntity.DepreciationMethodID);
                Database.AddInParameter(cmd, "@DepreciationAccountID", DbType.Int64, aCItemGroupAccountMapEntity.DepreciationAccountID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACItemGroupAccountMapEntity already exists. Please specify another ACItemGroupAccountMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACItemGroupAccountMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACItemGroupAccountMapEntity already exists. Please specify another ACItemGroupAccountMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACItemGroupAccountMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ItemGroupAccountMapID", DbType.Int64, aCItemGroupAccountMapEntity.ItemGroupAccountMapID);
                db.AddInParameter(cmd, "@ItemCategoryID", DbType.Int64, aCItemGroupAccountMapEntity.ItemCategoryID);
                db.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCItemGroupAccountMapEntity.DimensionID);
                db.AddInParameter(cmd, "@SalesAccountID", DbType.Int64, aCItemGroupAccountMapEntity.SalesAccountID);
                db.AddInParameter(cmd, "@InventoryAccountID", DbType.Int64, aCItemGroupAccountMapEntity.InventoryAccountID);
                db.AddInParameter(cmd, "@COGSAccountID", DbType.Int64, aCItemGroupAccountMapEntity.COGSAccountID);
                db.AddInParameter(cmd, "@InventoryAdjustmentsAccountID", DbType.Int64, aCItemGroupAccountMapEntity.InventoryAdjustmentsAccountID);
                db.AddInParameter(cmd, "@AssetType", DbType.String, aCItemGroupAccountMapEntity.AssetType);
                db.AddInParameter(cmd, "@PurchaseDate", DbType.DateTime, aCItemGroupAccountMapEntity.PurchaseDate);
                db.AddInParameter(cmd, "@PurchasePrice", DbType.Decimal, aCItemGroupAccountMapEntity.PurchasePrice);
                db.AddInParameter(cmd, "@DepreciationRate", DbType.Decimal, aCItemGroupAccountMapEntity.DepreciationRate);
                db.AddInParameter(cmd, "@DepreciationMethodID", DbType.Int64, aCItemGroupAccountMapEntity.DepreciationMethodID);
                db.AddInParameter(cmd, "@DepreciationAccountID", DbType.Int64, aCItemGroupAccountMapEntity.DepreciationAccountID);

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

        IList<Int64> IACItemGroupAccountMapDataAccess.Update(IList<ACItemGroupAccountMapEntity> aCItemGroupAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity in aCItemGroupAccountMapEntityList)
            {
                returnCode = (this as IACItemGroupAccountMapDataAccess).Update(aCItemGroupAccountMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACItemGroupAccountMapDataAccess.Delete(ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCItemGroupAccountMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCItemGroupAccountMapEntity, filterExpression, option);
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

        private Int64 Delete(ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACItemGroupAccountMap_SET";

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
                                throw new ArgumentException("ACItemGroupAccountMapEntity already exists. Please specify another ACItemGroupAccountMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACItemGroupAccountMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACItemGroupAccountMapEntity already exists. Please specify another ACItemGroupAccountMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACItemGroupAccountMap_SET";

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

        IList<Int64> IACItemGroupAccountMapDataAccess.Delete(IList<ACItemGroupAccountMapEntity> aCItemGroupAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity in aCItemGroupAccountMapEntityList)
            {
                returnCode = (this as IACItemGroupAccountMapDataAccess).Delete(aCItemGroupAccountMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACItemGroupAccountMapEntity> IACItemGroupAccountMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACItemGroupAccountMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACItemGroupAccountMapEntity> list = CreateEntityBuilder<ACItemGroupAccountMapEntity>().BuildEntities(reader);

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

        DataTable IACItemGroupAccountMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACItemGroupAccountMap_GET";

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
