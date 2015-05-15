// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Nov-2013, 09:51:38




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
    internal sealed partial class MDAssetDataAccess : BaseDataAccess, IMDAssetDataAccess
    {
        #region Constructors

        public MDAssetDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDAssetEntity> CreateEntityBuilder<MDAssetEntity>()
        {
            return (new MDAssetBuilder()) as IEntityBuilder<MDAssetEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDAssetDataAccess.Add(MDAssetEntity mDAssetEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDAssetEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDAssetEntity, option);
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

        private Int64 Add(MDAssetEntity mDAssetEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDAsset_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "AssetID");

                Database.AddInParameter(cmd, "@AssetCateogryID", DbType.Int64, mDAssetEntity.AssetCateogryID);	
                Database.AddInParameter(cmd, "@AssetCode", DbType.String, mDAssetEntity.AssetCode);	
                Database.AddInParameter(cmd, "@AssetName", DbType.String, mDAssetEntity.AssetName);	
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, mDAssetEntity.ImageUrl);	
                Database.AddInParameter(cmd, "@UnitID", DbType.Int64, mDAssetEntity.UnitID);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDAssetEntity.Description);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, mDAssetEntity.BrandID);	
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, mDAssetEntity.SupplierID);	
                Database.AddInParameter(cmd, "@NextMaintananceDate", DbType.DateTime, mDAssetEntity.NextMaintananceDate);	
                Database.AddInParameter(cmd, "@UsedOrHandeledBy", DbType.String, mDAssetEntity.UsedOrHandeledBy);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, mDAssetEntity.ProjectFloorUnitID);	
                Database.AddInParameter(cmd, "@ProjectUnitLocationID", DbType.Int64, mDAssetEntity.ProjectUnitLocationID);	
                Database.AddInParameter(cmd, "@AssetOwnerTypeID", DbType.Int64, mDAssetEntity.AssetOwnerTypeID);	
                Database.AddInParameter(cmd, "@OwnerReferenceID", DbType.Int64, mDAssetEntity.OwnerReferenceID);	
                Database.AddInParameter(cmd, "@CurrentLocationProjectID", DbType.Int64, mDAssetEntity.CurrentLocationProjectID);	
                Database.AddInParameter(cmd, "@InsuranceInformation", DbType.String, mDAssetEntity.InsuranceInformation);	
                Database.AddInParameter(cmd, "@ServiceContractInformation", DbType.String, mDAssetEntity.ServiceContractInformation);	
                Database.AddInParameter(cmd, "@Price", DbType.Decimal, mDAssetEntity.Price);	
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, mDAssetEntity.WorkOrderID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, mDAssetEntity.Remarks);	
                Database.AddInParameter(cmd, "@AssetConditionID", DbType.Int64, mDAssetEntity.AssetConditionID);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDAssetEntity.IsRemoved);
                Database.AddInParameter(cmd, "@Medium", DbType.String, mDAssetEntity.Medium);
                Database.AddInParameter(cmd, "@Width", DbType.Decimal, mDAssetEntity.Width);
                Database.AddInParameter(cmd, "@Height", DbType.Decimal, mDAssetEntity.Height);
                Database.AddInParameter(cmd, "@PresentBookValue", DbType.Decimal, mDAssetEntity.PresentBookValue);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDAssetEntity already exists. Please specify another MDAssetEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDAssetEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDAssetEntity already exists. Please specify another MDAssetEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDAssetEntity mDAssetEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDAsset_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "AssetID", db);

                db.AddInParameter(cmd, "@AssetCateogryID", DbType.Int64, mDAssetEntity.AssetCateogryID);
                db.AddInParameter(cmd, "@AssetCode", DbType.String, mDAssetEntity.AssetCode);
                db.AddInParameter(cmd, "@AssetName", DbType.String, mDAssetEntity.AssetName);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, mDAssetEntity.ImageUrl);
                db.AddInParameter(cmd, "@UnitID", DbType.Int64, mDAssetEntity.UnitID);
                db.AddInParameter(cmd, "@Description", DbType.String, mDAssetEntity.Description);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, mDAssetEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, mDAssetEntity.SupplierID);
                db.AddInParameter(cmd, "@NextMaintananceDate", DbType.DateTime, mDAssetEntity.NextMaintananceDate);
                db.AddInParameter(cmd, "@UsedOrHandeledBy", DbType.String, mDAssetEntity.UsedOrHandeledBy);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, mDAssetEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@ProjectUnitLocationID", DbType.Int64, mDAssetEntity.ProjectUnitLocationID);
                db.AddInParameter(cmd, "@AssetOwnerTypeID", DbType.Int64, mDAssetEntity.AssetOwnerTypeID);
                db.AddInParameter(cmd, "@OwnerReferenceID", DbType.Int64, mDAssetEntity.OwnerReferenceID);
                db.AddInParameter(cmd, "@CurrentLocationProjectID", DbType.Int64, mDAssetEntity.CurrentLocationProjectID);
                db.AddInParameter(cmd, "@InsuranceInformation", DbType.String, mDAssetEntity.InsuranceInformation);
                db.AddInParameter(cmd, "@ServiceContractInformation", DbType.String, mDAssetEntity.ServiceContractInformation);
                db.AddInParameter(cmd, "@Price", DbType.Decimal, mDAssetEntity.Price);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, mDAssetEntity.WorkOrderID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, mDAssetEntity.Remarks);
                db.AddInParameter(cmd, "@AssetConditionID", DbType.Int64, mDAssetEntity.AssetConditionID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDAssetEntity.IsRemoved);
                db.AddInParameter(cmd, "@Medium", DbType.String, mDAssetEntity.Medium);
                db.AddInParameter(cmd, "@Width", DbType.Decimal, mDAssetEntity.Width);
                db.AddInParameter(cmd, "@Height", DbType.Decimal, mDAssetEntity.Height);
                db.AddInParameter(cmd, "@PresentBookValue", DbType.Decimal, mDAssetEntity.PresentBookValue);

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

        IList<Int64> IMDAssetDataAccess.Add(IList<MDAssetEntity> mDAssetEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDAssetEntity mDAssetEntity in mDAssetEntityList)
            {
                returnCode = (this as IMDAssetDataAccess).Add(mDAssetEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDAssetDataAccess.Update(MDAssetEntity mDAssetEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDAssetEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDAssetEntity, filterExpression, option);
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

        private Int64 Update(MDAssetEntity mDAssetEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDAsset_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@AssetID", DbType.Int64, mDAssetEntity.AssetID);
                Database.AddInParameter(cmd, "@AssetCateogryID", DbType.Int64, mDAssetEntity.AssetCateogryID);
                Database.AddInParameter(cmd, "@AssetCode", DbType.String, mDAssetEntity.AssetCode);
                Database.AddInParameter(cmd, "@AssetName", DbType.String, mDAssetEntity.AssetName);
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, mDAssetEntity.ImageUrl);
                Database.AddInParameter(cmd, "@UnitID", DbType.Int64, mDAssetEntity.UnitID);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDAssetEntity.Description);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, mDAssetEntity.BrandID);
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, mDAssetEntity.SupplierID);
                Database.AddInParameter(cmd, "@NextMaintananceDate", DbType.DateTime, mDAssetEntity.NextMaintananceDate);
                Database.AddInParameter(cmd, "@UsedOrHandeledBy", DbType.String, mDAssetEntity.UsedOrHandeledBy);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, mDAssetEntity.ProjectFloorUnitID);
                Database.AddInParameter(cmd, "@ProjectUnitLocationID", DbType.Int64, mDAssetEntity.ProjectUnitLocationID);
                Database.AddInParameter(cmd, "@AssetOwnerTypeID", DbType.Int64, mDAssetEntity.AssetOwnerTypeID);
                Database.AddInParameter(cmd, "@OwnerReferenceID", DbType.Int64, mDAssetEntity.OwnerReferenceID);
                Database.AddInParameter(cmd, "@CurrentLocationProjectID", DbType.Int64, mDAssetEntity.CurrentLocationProjectID);
                Database.AddInParameter(cmd, "@InsuranceInformation", DbType.String, mDAssetEntity.InsuranceInformation);
                Database.AddInParameter(cmd, "@ServiceContractInformation", DbType.String, mDAssetEntity.ServiceContractInformation);
                Database.AddInParameter(cmd, "@Price", DbType.Decimal, mDAssetEntity.Price);
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, mDAssetEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, mDAssetEntity.Remarks);
                Database.AddInParameter(cmd, "@AssetConditionID", DbType.Int64, mDAssetEntity.AssetConditionID);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDAssetEntity.IsRemoved);
                Database.AddInParameter(cmd, "@Medium", DbType.String, mDAssetEntity.Medium);
                Database.AddInParameter(cmd, "@Width", DbType.Decimal, mDAssetEntity.Width);
                Database.AddInParameter(cmd, "@Height", DbType.Decimal, mDAssetEntity.Height);
                Database.AddInParameter(cmd, "@PresentBookValue", DbType.Decimal, mDAssetEntity.PresentBookValue);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDAssetEntity already exists. Please specify another MDAssetEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDAssetEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDAssetEntity already exists. Please specify another MDAssetEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDAssetEntity mDAssetEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDAsset_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@AssetID", DbType.Int64, mDAssetEntity.AssetID);
                db.AddInParameter(cmd, "@AssetCateogryID", DbType.Int64, mDAssetEntity.AssetCateogryID);
                db.AddInParameter(cmd, "@AssetCode", DbType.String, mDAssetEntity.AssetCode);
                db.AddInParameter(cmd, "@AssetName", DbType.String, mDAssetEntity.AssetName);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, mDAssetEntity.ImageUrl);
                db.AddInParameter(cmd, "@UnitID", DbType.Int64, mDAssetEntity.UnitID);
                db.AddInParameter(cmd, "@Description", DbType.String, mDAssetEntity.Description);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, mDAssetEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, mDAssetEntity.SupplierID);
                db.AddInParameter(cmd, "@NextMaintananceDate", DbType.DateTime, mDAssetEntity.NextMaintananceDate);
                db.AddInParameter(cmd, "@UsedOrHandeledBy", DbType.String, mDAssetEntity.UsedOrHandeledBy);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, mDAssetEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@ProjectUnitLocationID", DbType.Int64, mDAssetEntity.ProjectUnitLocationID);
                db.AddInParameter(cmd, "@AssetOwnerTypeID", DbType.Int64, mDAssetEntity.AssetOwnerTypeID);
                db.AddInParameter(cmd, "@OwnerReferenceID", DbType.Int64, mDAssetEntity.OwnerReferenceID);
                db.AddInParameter(cmd, "@CurrentLocationProjectID", DbType.Int64, mDAssetEntity.CurrentLocationProjectID);
                db.AddInParameter(cmd, "@InsuranceInformation", DbType.String, mDAssetEntity.InsuranceInformation);
                db.AddInParameter(cmd, "@ServiceContractInformation", DbType.String, mDAssetEntity.ServiceContractInformation);
                db.AddInParameter(cmd, "@Price", DbType.Decimal, mDAssetEntity.Price);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, mDAssetEntity.WorkOrderID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, mDAssetEntity.Remarks);
                db.AddInParameter(cmd, "@AssetConditionID", DbType.Int64, mDAssetEntity.AssetConditionID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDAssetEntity.IsRemoved);
                db.AddInParameter(cmd, "@Medium", DbType.String, mDAssetEntity.Medium);
                db.AddInParameter(cmd, "@Width", DbType.Decimal, mDAssetEntity.Width);
                db.AddInParameter(cmd, "@Height", DbType.Decimal, mDAssetEntity.Height);
                db.AddInParameter(cmd, "@PresentBookValue", DbType.Decimal, mDAssetEntity.PresentBookValue);

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

        IList<Int64> IMDAssetDataAccess.Update(IList<MDAssetEntity> mDAssetEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDAssetEntity mDAssetEntity in mDAssetEntityList)
            {
                returnCode = (this as IMDAssetDataAccess).Update(mDAssetEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDAssetDataAccess.Delete(MDAssetEntity mDAssetEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDAssetEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDAssetEntity, filterExpression, option);
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

        private Int64 Delete(MDAssetEntity mDAssetEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDAsset_SET";

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
                                throw new ArgumentException("MDAssetEntity already exists. Please specify another MDAssetEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDAssetEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDAssetEntity already exists. Please specify another MDAssetEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDAssetEntity mDAssetEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDAsset_SET";

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

        IList<Int64> IMDAssetDataAccess.Delete(IList<MDAssetEntity> mDAssetEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDAssetEntity mDAssetEntity in mDAssetEntityList)
            {
                returnCode = (this as IMDAssetDataAccess).Delete(mDAssetEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDAssetEntity> IMDAssetDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDAsset_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDAssetEntity> list = CreateEntityBuilder<MDAssetEntity>().BuildEntities(reader);

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

        DataTable IMDAssetDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDAsset_GET";

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
