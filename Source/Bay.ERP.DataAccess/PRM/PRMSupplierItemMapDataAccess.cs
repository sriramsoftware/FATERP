// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




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
    internal sealed partial class PRMSupplierItemMapDataAccess : BaseDataAccess, IPRMSupplierItemMapDataAccess
    {
        #region Constructors

        public PRMSupplierItemMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMSupplierItemMapEntity> CreateEntityBuilder<PRMSupplierItemMapEntity>()
        {
            return (new PRMSupplierItemMapBuilder()) as IEntityBuilder<PRMSupplierItemMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMSupplierItemMapDataAccess.Add(PRMSupplierItemMapEntity pRMSupplierItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMSupplierItemMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMSupplierItemMapEntity, option);
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

        private Int64 Add(PRMSupplierItemMapEntity pRMSupplierItemMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "SupplierItemMapID");

                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierItemMapEntity.SupplierID);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMSupplierItemMapEntity.BrandID);	
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMSupplierItemMapEntity.ItemID);	
                Database.AddInParameter(cmd, "@OriginRegionID", DbType.Int64, pRMSupplierItemMapEntity.OriginRegionID);	
                Database.AddInParameter(cmd, "@OriginCountryID", DbType.Int64, pRMSupplierItemMapEntity.OriginCountryID);	
                Database.AddInParameter(cmd, "@ActualPrice", DbType.Decimal, pRMSupplierItemMapEntity.ActualPrice);	
                Database.AddInParameter(cmd, "@DiscountPercentage", DbType.Decimal, pRMSupplierItemMapEntity.DiscountPercentage);	
                Database.AddInParameter(cmd, "@Price", DbType.Decimal, pRMSupplierItemMapEntity.Price);	
                Database.AddInParameter(cmd, "@Model", DbType.String, pRMSupplierItemMapEntity.Model);	
                Database.AddInParameter(cmd, "@WarrantyPeriod", DbType.Int64, pRMSupplierItemMapEntity.WarrantyPeriod);	
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMSupplierItemMapEntity.EntryDate);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMSupplierItemMapEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMSupplierItemMapEntity already exists. Please specify another PRMSupplierItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierItemMapEntity already exists. Please specify another PRMSupplierItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMSupplierItemMapEntity pRMSupplierItemMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "SupplierItemMapID", db);

                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierItemMapEntity.SupplierID);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMSupplierItemMapEntity.BrandID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMSupplierItemMapEntity.ItemID);
                db.AddInParameter(cmd, "@OriginRegionID", DbType.Int64, pRMSupplierItemMapEntity.OriginRegionID);
                db.AddInParameter(cmd, "@OriginCountryID", DbType.Int64, pRMSupplierItemMapEntity.OriginCountryID);
                db.AddInParameter(cmd, "@ActualPrice", DbType.Decimal, pRMSupplierItemMapEntity.ActualPrice);
                db.AddInParameter(cmd, "@DiscountPercentage", DbType.Decimal, pRMSupplierItemMapEntity.DiscountPercentage);
                db.AddInParameter(cmd, "@Price", DbType.Decimal, pRMSupplierItemMapEntity.Price);
                db.AddInParameter(cmd, "@Model", DbType.String, pRMSupplierItemMapEntity.Model);
                db.AddInParameter(cmd, "@WarrantyPeriod", DbType.Int64, pRMSupplierItemMapEntity.WarrantyPeriod);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMSupplierItemMapEntity.EntryDate);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMSupplierItemMapEntity.IsRemoved);

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

        IList<Int64> IPRMSupplierItemMapDataAccess.Add(IList<PRMSupplierItemMapEntity> pRMSupplierItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMSupplierItemMapEntity pRMSupplierItemMapEntity in pRMSupplierItemMapEntityList)
            {
                returnCode = (this as IPRMSupplierItemMapDataAccess).Add(pRMSupplierItemMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMSupplierItemMapDataAccess.Update(PRMSupplierItemMapEntity pRMSupplierItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMSupplierItemMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMSupplierItemMapEntity, filterExpression, option);
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

        private Int64 Update(PRMSupplierItemMapEntity pRMSupplierItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@SupplierItemMapID", DbType.Int64, pRMSupplierItemMapEntity.SupplierItemMapID);
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierItemMapEntity.SupplierID);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMSupplierItemMapEntity.BrandID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMSupplierItemMapEntity.ItemID);
                Database.AddInParameter(cmd, "@OriginRegionID", DbType.Int64, pRMSupplierItemMapEntity.OriginRegionID);
                Database.AddInParameter(cmd, "@OriginCountryID", DbType.Int64, pRMSupplierItemMapEntity.OriginCountryID);
                Database.AddInParameter(cmd, "@ActualPrice", DbType.Decimal, pRMSupplierItemMapEntity.ActualPrice);
                Database.AddInParameter(cmd, "@DiscountPercentage", DbType.Decimal, pRMSupplierItemMapEntity.DiscountPercentage);
                Database.AddInParameter(cmd, "@Price", DbType.Decimal, pRMSupplierItemMapEntity.Price);
                Database.AddInParameter(cmd, "@Model", DbType.String, pRMSupplierItemMapEntity.Model);
                Database.AddInParameter(cmd, "@WarrantyPeriod", DbType.Int64, pRMSupplierItemMapEntity.WarrantyPeriod);
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMSupplierItemMapEntity.EntryDate);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMSupplierItemMapEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMSupplierItemMapEntity already exists. Please specify another PRMSupplierItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierItemMapEntity already exists. Please specify another PRMSupplierItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMSupplierItemMapEntity pRMSupplierItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@SupplierItemMapID", DbType.Int64, pRMSupplierItemMapEntity.SupplierItemMapID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierItemMapEntity.SupplierID);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMSupplierItemMapEntity.BrandID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMSupplierItemMapEntity.ItemID);
                db.AddInParameter(cmd, "@OriginRegionID", DbType.Int64, pRMSupplierItemMapEntity.OriginRegionID);
                db.AddInParameter(cmd, "@OriginCountryID", DbType.Int64, pRMSupplierItemMapEntity.OriginCountryID);
                db.AddInParameter(cmd, "@ActualPrice", DbType.Decimal, pRMSupplierItemMapEntity.ActualPrice);
                db.AddInParameter(cmd, "@DiscountPercentage", DbType.Decimal, pRMSupplierItemMapEntity.DiscountPercentage);
                db.AddInParameter(cmd, "@Price", DbType.Decimal, pRMSupplierItemMapEntity.Price);
                db.AddInParameter(cmd, "@Model", DbType.String, pRMSupplierItemMapEntity.Model);
                db.AddInParameter(cmd, "@WarrantyPeriod", DbType.Int64, pRMSupplierItemMapEntity.WarrantyPeriod);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMSupplierItemMapEntity.EntryDate);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMSupplierItemMapEntity.IsRemoved);

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

        IList<Int64> IPRMSupplierItemMapDataAccess.Update(IList<PRMSupplierItemMapEntity> pRMSupplierItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMSupplierItemMapEntity pRMSupplierItemMapEntity in pRMSupplierItemMapEntityList)
            {
                returnCode = (this as IPRMSupplierItemMapDataAccess).Update(pRMSupplierItemMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMSupplierItemMapDataAccess.Delete(PRMSupplierItemMapEntity pRMSupplierItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMSupplierItemMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMSupplierItemMapEntity, filterExpression, option);
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

        private Int64 Delete(PRMSupplierItemMapEntity pRMSupplierItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemMap_SET";

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
                                throw new ArgumentException("PRMSupplierItemMapEntity already exists. Please specify another PRMSupplierItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierItemMapEntity already exists. Please specify another PRMSupplierItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMSupplierItemMapEntity pRMSupplierItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemMap_SET";

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

        IList<Int64> IPRMSupplierItemMapDataAccess.Delete(IList<PRMSupplierItemMapEntity> pRMSupplierItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMSupplierItemMapEntity pRMSupplierItemMapEntity in pRMSupplierItemMapEntityList)
            {
                returnCode = (this as IPRMSupplierItemMapDataAccess).Delete(pRMSupplierItemMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMSupplierItemMapEntity> IPRMSupplierItemMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMSupplierItemMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMSupplierItemMapEntity> list = CreateEntityBuilder<PRMSupplierItemMapEntity>().BuildEntities(reader);

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

        DataTable IPRMSupplierItemMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMSupplierItemMap_GET";

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
