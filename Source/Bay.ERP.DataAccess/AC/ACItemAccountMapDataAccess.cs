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
    internal sealed partial class ACItemAccountMapDataAccess : BaseDataAccess, IACItemAccountMapDataAccess
    {
        #region Constructors

        public ACItemAccountMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACItemAccountMapEntity> CreateEntityBuilder<ACItemAccountMapEntity>()
        {
            return (new ACItemAccountMapBuilder()) as IEntityBuilder<ACItemAccountMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACItemAccountMapDataAccess.Add(ACItemAccountMapEntity aCItemAccountMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCItemAccountMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCItemAccountMapEntity, option);
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

        private Int64 Add(ACItemAccountMapEntity aCItemAccountMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACItemAccountMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ItemAccountMapID");

                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, aCItemAccountMapEntity.ItemID);	
                Database.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCItemAccountMapEntity.DimensionID);	
                Database.AddInParameter(cmd, "@SalesAccountID", DbType.Int64, aCItemAccountMapEntity.SalesAccountID);	
                Database.AddInParameter(cmd, "@InventoryAccountID", DbType.Int64, aCItemAccountMapEntity.InventoryAccountID);	
                Database.AddInParameter(cmd, "@COGSAccountID", DbType.Int64, aCItemAccountMapEntity.COGSAccountID);	
                Database.AddInParameter(cmd, "@InventoryAdjustmentsAccountID", DbType.Int64, aCItemAccountMapEntity.InventoryAdjustmentsAccountID);	
                Database.AddInParameter(cmd, "@AssetType", DbType.String, aCItemAccountMapEntity.AssetType);	
                Database.AddInParameter(cmd, "@PurchaseDate", DbType.DateTime, aCItemAccountMapEntity.PurchaseDate);	
                Database.AddInParameter(cmd, "@PurchasePrice", DbType.Decimal, aCItemAccountMapEntity.PurchasePrice);	
                Database.AddInParameter(cmd, "@DepreciationRate", DbType.Decimal, aCItemAccountMapEntity.DepreciationRate);	
                Database.AddInParameter(cmd, "@DepreciationMethodID", DbType.Int64, aCItemAccountMapEntity.DepreciationMethodID);	
                Database.AddInParameter(cmd, "@DepreciationAccountID", DbType.Int64, aCItemAccountMapEntity.DepreciationAccountID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACItemAccountMapEntity already exists. Please specify another ACItemAccountMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACItemAccountMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACItemAccountMapEntity already exists. Please specify another ACItemAccountMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACItemAccountMapEntity aCItemAccountMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACItemAccountMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ItemAccountMapID", db);

                db.AddInParameter(cmd, "@ItemID", DbType.Int64, aCItemAccountMapEntity.ItemID);
                db.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCItemAccountMapEntity.DimensionID);
                db.AddInParameter(cmd, "@SalesAccountID", DbType.Int64, aCItemAccountMapEntity.SalesAccountID);
                db.AddInParameter(cmd, "@InventoryAccountID", DbType.Int64, aCItemAccountMapEntity.InventoryAccountID);
                db.AddInParameter(cmd, "@COGSAccountID", DbType.Int64, aCItemAccountMapEntity.COGSAccountID);
                db.AddInParameter(cmd, "@InventoryAdjustmentsAccountID", DbType.Int64, aCItemAccountMapEntity.InventoryAdjustmentsAccountID);
                db.AddInParameter(cmd, "@AssetType", DbType.String, aCItemAccountMapEntity.AssetType);
                db.AddInParameter(cmd, "@PurchaseDate", DbType.DateTime, aCItemAccountMapEntity.PurchaseDate);
                db.AddInParameter(cmd, "@PurchasePrice", DbType.Decimal, aCItemAccountMapEntity.PurchasePrice);
                db.AddInParameter(cmd, "@DepreciationRate", DbType.Decimal, aCItemAccountMapEntity.DepreciationRate);
                db.AddInParameter(cmd, "@DepreciationMethodID", DbType.Int64, aCItemAccountMapEntity.DepreciationMethodID);
                db.AddInParameter(cmd, "@DepreciationAccountID", DbType.Int64, aCItemAccountMapEntity.DepreciationAccountID);

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

        IList<Int64> IACItemAccountMapDataAccess.Add(IList<ACItemAccountMapEntity> aCItemAccountMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACItemAccountMapEntity aCItemAccountMapEntity in aCItemAccountMapEntityList)
            {
                returnCode = (this as IACItemAccountMapDataAccess).Add(aCItemAccountMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACItemAccountMapDataAccess.Update(ACItemAccountMapEntity aCItemAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCItemAccountMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCItemAccountMapEntity, filterExpression, option);
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

        private Int64 Update(ACItemAccountMapEntity aCItemAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACItemAccountMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ItemAccountMapID", DbType.Int64, aCItemAccountMapEntity.ItemAccountMapID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, aCItemAccountMapEntity.ItemID);
                Database.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCItemAccountMapEntity.DimensionID);
                Database.AddInParameter(cmd, "@SalesAccountID", DbType.Int64, aCItemAccountMapEntity.SalesAccountID);
                Database.AddInParameter(cmd, "@InventoryAccountID", DbType.Int64, aCItemAccountMapEntity.InventoryAccountID);
                Database.AddInParameter(cmd, "@COGSAccountID", DbType.Int64, aCItemAccountMapEntity.COGSAccountID);
                Database.AddInParameter(cmd, "@InventoryAdjustmentsAccountID", DbType.Int64, aCItemAccountMapEntity.InventoryAdjustmentsAccountID);
                Database.AddInParameter(cmd, "@AssetType", DbType.String, aCItemAccountMapEntity.AssetType);
                Database.AddInParameter(cmd, "@PurchaseDate", DbType.DateTime, aCItemAccountMapEntity.PurchaseDate);
                Database.AddInParameter(cmd, "@PurchasePrice", DbType.Decimal, aCItemAccountMapEntity.PurchasePrice);
                Database.AddInParameter(cmd, "@DepreciationRate", DbType.Decimal, aCItemAccountMapEntity.DepreciationRate);
                Database.AddInParameter(cmd, "@DepreciationMethodID", DbType.Int64, aCItemAccountMapEntity.DepreciationMethodID);
                Database.AddInParameter(cmd, "@DepreciationAccountID", DbType.Int64, aCItemAccountMapEntity.DepreciationAccountID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACItemAccountMapEntity already exists. Please specify another ACItemAccountMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACItemAccountMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACItemAccountMapEntity already exists. Please specify another ACItemAccountMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACItemAccountMapEntity aCItemAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACItemAccountMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ItemAccountMapID", DbType.Int64, aCItemAccountMapEntity.ItemAccountMapID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, aCItemAccountMapEntity.ItemID);
                db.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCItemAccountMapEntity.DimensionID);
                db.AddInParameter(cmd, "@SalesAccountID", DbType.Int64, aCItemAccountMapEntity.SalesAccountID);
                db.AddInParameter(cmd, "@InventoryAccountID", DbType.Int64, aCItemAccountMapEntity.InventoryAccountID);
                db.AddInParameter(cmd, "@COGSAccountID", DbType.Int64, aCItemAccountMapEntity.COGSAccountID);
                db.AddInParameter(cmd, "@InventoryAdjustmentsAccountID", DbType.Int64, aCItemAccountMapEntity.InventoryAdjustmentsAccountID);
                db.AddInParameter(cmd, "@AssetType", DbType.String, aCItemAccountMapEntity.AssetType);
                db.AddInParameter(cmd, "@PurchaseDate", DbType.DateTime, aCItemAccountMapEntity.PurchaseDate);
                db.AddInParameter(cmd, "@PurchasePrice", DbType.Decimal, aCItemAccountMapEntity.PurchasePrice);
                db.AddInParameter(cmd, "@DepreciationRate", DbType.Decimal, aCItemAccountMapEntity.DepreciationRate);
                db.AddInParameter(cmd, "@DepreciationMethodID", DbType.Int64, aCItemAccountMapEntity.DepreciationMethodID);
                db.AddInParameter(cmd, "@DepreciationAccountID", DbType.Int64, aCItemAccountMapEntity.DepreciationAccountID);

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

        IList<Int64> IACItemAccountMapDataAccess.Update(IList<ACItemAccountMapEntity> aCItemAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACItemAccountMapEntity aCItemAccountMapEntity in aCItemAccountMapEntityList)
            {
                returnCode = (this as IACItemAccountMapDataAccess).Update(aCItemAccountMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACItemAccountMapDataAccess.Delete(ACItemAccountMapEntity aCItemAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCItemAccountMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCItemAccountMapEntity, filterExpression, option);
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

        private Int64 Delete(ACItemAccountMapEntity aCItemAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACItemAccountMap_SET";

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
                                throw new ArgumentException("ACItemAccountMapEntity already exists. Please specify another ACItemAccountMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACItemAccountMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACItemAccountMapEntity already exists. Please specify another ACItemAccountMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACItemAccountMapEntity aCItemAccountMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACItemAccountMap_SET";

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

        IList<Int64> IACItemAccountMapDataAccess.Delete(IList<ACItemAccountMapEntity> aCItemAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACItemAccountMapEntity aCItemAccountMapEntity in aCItemAccountMapEntityList)
            {
                returnCode = (this as IACItemAccountMapDataAccess).Delete(aCItemAccountMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACItemAccountMapEntity> IACItemAccountMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACItemAccountMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACItemAccountMapEntity> list = CreateEntityBuilder<ACItemAccountMapEntity>().BuildEntities(reader);

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

        DataTable IACItemAccountMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACItemAccountMap_GET";

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
