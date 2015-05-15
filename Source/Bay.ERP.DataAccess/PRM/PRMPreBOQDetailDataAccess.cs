// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    internal sealed partial class PRMPreBOQDetailDataAccess : BaseDataAccess, IPRMPreBOQDetailDataAccess
    {
        #region Constructors

        public PRMPreBOQDetailDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMPreBOQDetailEntity> CreateEntityBuilder<PRMPreBOQDetailEntity>()
        {
            return (new PRMPreBOQDetailBuilder()) as IEntityBuilder<PRMPreBOQDetailEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMPreBOQDetailDataAccess.Add(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMPreBOQDetailEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMPreBOQDetailEntity, option);
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

        private Int64 Add(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "PreBOQDetailID");

                Database.AddInParameter(cmd, "@PreBOQID", DbType.Int64, pRMPreBOQDetailEntity.PreBOQID);	
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMPreBOQDetailEntity.ItemID);	
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMPreBOQDetailEntity.Rate);	
                Database.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMPreBOQDetailEntity.TotalQty);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMPreBOQDetailEntity.Remarks);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMPreBOQDetailEntity.IsRemoved);	
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMPreBOQDetailEntity.EntryDate);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMPreBOQDetailEntity.BrandID);	
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMPreBOQDetailEntity.SupplierID);	
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMPreBOQDetailEntity.RegionID);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMPreBOQDetailEntity.CountryID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMPreBOQDetailEntity already exists. Please specify another PRMPreBOQDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQDetailEntity already exists. Please specify another PRMPreBOQDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "PreBOQDetailID", db);

                db.AddInParameter(cmd, "@PreBOQID", DbType.Int64, pRMPreBOQDetailEntity.PreBOQID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMPreBOQDetailEntity.ItemID);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMPreBOQDetailEntity.Rate);
                db.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMPreBOQDetailEntity.TotalQty);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMPreBOQDetailEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMPreBOQDetailEntity.IsRemoved);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMPreBOQDetailEntity.EntryDate);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMPreBOQDetailEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMPreBOQDetailEntity.SupplierID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMPreBOQDetailEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMPreBOQDetailEntity.CountryID);

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

        IList<Int64> IPRMPreBOQDetailDataAccess.Add(IList<PRMPreBOQDetailEntity> pRMPreBOQDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMPreBOQDetailEntity pRMPreBOQDetailEntity in pRMPreBOQDetailEntityList)
            {
                returnCode = (this as IPRMPreBOQDetailDataAccess).Add(pRMPreBOQDetailEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMPreBOQDetailDataAccess.Update(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMPreBOQDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMPreBOQDetailEntity, filterExpression, option);
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

        private Int64 Update(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@PreBOQDetailID", DbType.Int64, pRMPreBOQDetailEntity.PreBOQDetailID);
                Database.AddInParameter(cmd, "@PreBOQID", DbType.Int64, pRMPreBOQDetailEntity.PreBOQID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMPreBOQDetailEntity.ItemID);
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMPreBOQDetailEntity.Rate);
                Database.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMPreBOQDetailEntity.TotalQty);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMPreBOQDetailEntity.Remarks);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMPreBOQDetailEntity.IsRemoved);
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMPreBOQDetailEntity.EntryDate);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMPreBOQDetailEntity.BrandID);
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMPreBOQDetailEntity.SupplierID);
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMPreBOQDetailEntity.RegionID);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMPreBOQDetailEntity.CountryID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMPreBOQDetailEntity already exists. Please specify another PRMPreBOQDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQDetailEntity already exists. Please specify another PRMPreBOQDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@PreBOQDetailID", DbType.Int64, pRMPreBOQDetailEntity.PreBOQDetailID);
                db.AddInParameter(cmd, "@PreBOQID", DbType.Int64, pRMPreBOQDetailEntity.PreBOQID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMPreBOQDetailEntity.ItemID);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMPreBOQDetailEntity.Rate);
                db.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMPreBOQDetailEntity.TotalQty);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMPreBOQDetailEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMPreBOQDetailEntity.IsRemoved);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMPreBOQDetailEntity.EntryDate);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMPreBOQDetailEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMPreBOQDetailEntity.SupplierID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMPreBOQDetailEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMPreBOQDetailEntity.CountryID);

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

        IList<Int64> IPRMPreBOQDetailDataAccess.Update(IList<PRMPreBOQDetailEntity> pRMPreBOQDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMPreBOQDetailEntity pRMPreBOQDetailEntity in pRMPreBOQDetailEntityList)
            {
                returnCode = (this as IPRMPreBOQDetailDataAccess).Update(pRMPreBOQDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMPreBOQDetailDataAccess.Delete(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMPreBOQDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMPreBOQDetailEntity, filterExpression, option);
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

        private Int64 Delete(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQDetail_SET";

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
                                throw new ArgumentException("PRMPreBOQDetailEntity already exists. Please specify another PRMPreBOQDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQDetailEntity already exists. Please specify another PRMPreBOQDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQDetail_SET";

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

        IList<Int64> IPRMPreBOQDetailDataAccess.Delete(IList<PRMPreBOQDetailEntity> pRMPreBOQDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMPreBOQDetailEntity pRMPreBOQDetailEntity in pRMPreBOQDetailEntityList)
            {
                returnCode = (this as IPRMPreBOQDetailDataAccess).Delete(pRMPreBOQDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMPreBOQDetailEntity> IPRMPreBOQDetailDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQDetail_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMPreBOQDetailEntity> list = CreateEntityBuilder<PRMPreBOQDetailEntity>().BuildEntities(reader);

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

        DataTable IPRMPreBOQDetailDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQDetail_GET";

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
