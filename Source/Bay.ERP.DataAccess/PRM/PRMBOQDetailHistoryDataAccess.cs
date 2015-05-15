// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 11:06:52




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
    internal sealed partial class PRMBOQDetailHistoryDataAccess : BaseDataAccess, IPRMBOQDetailHistoryDataAccess
    {
        #region Constructors

        public PRMBOQDetailHistoryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMBOQDetailHistoryEntity> CreateEntityBuilder<PRMBOQDetailHistoryEntity>()
        {
            return (new PRMBOQDetailHistoryBuilder()) as IEntityBuilder<PRMBOQDetailHistoryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMBOQDetailHistoryDataAccess.Add(PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMBOQDetailHistoryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMBOQDetailHistoryEntity, option);
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

        private Int64 Add(PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQDetailHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BOQDetailHistoryID");

                Database.AddInParameter(cmd, "@BOQDetailID", DbType.Int64, pRMBOQDetailHistoryEntity.BOQDetailID);	
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMBOQDetailHistoryEntity.Rate);	
                Database.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMBOQDetailHistoryEntity.TotalQty);	
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMBOQDetailHistoryEntity.EntryDate);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMBOQDetailHistoryEntity.BrandID);	
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMBOQDetailHistoryEntity.SupplierID);	
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMBOQDetailHistoryEntity.RegionID);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMBOQDetailHistoryEntity.CountryID);	
                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, pRMBOQDetailHistoryEntity.MemberID);	
                Database.AddInParameter(cmd, "@UserPCIP", DbType.String, pRMBOQDetailHistoryEntity.UserPCIP);	
                Database.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, pRMBOQDetailHistoryEntity.UpdatedDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMBOQDetailHistoryEntity already exists. Please specify another PRMBOQDetailHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMBOQDetailHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMBOQDetailHistoryEntity already exists. Please specify another PRMBOQDetailHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQDetailHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BOQDetailHistoryID", db);

                db.AddInParameter(cmd, "@BOQDetailID", DbType.Int64, pRMBOQDetailHistoryEntity.BOQDetailID);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMBOQDetailHistoryEntity.Rate);
                db.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMBOQDetailHistoryEntity.TotalQty);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMBOQDetailHistoryEntity.EntryDate);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMBOQDetailHistoryEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMBOQDetailHistoryEntity.SupplierID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMBOQDetailHistoryEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMBOQDetailHistoryEntity.CountryID);
                db.AddInParameter(cmd, "@MemberID", DbType.Int64, pRMBOQDetailHistoryEntity.MemberID);
                db.AddInParameter(cmd, "@UserPCIP", DbType.String, pRMBOQDetailHistoryEntity.UserPCIP);
                db.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, pRMBOQDetailHistoryEntity.UpdatedDate);

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

        IList<Int64> IPRMBOQDetailHistoryDataAccess.Add(IList<PRMBOQDetailHistoryEntity> pRMBOQDetailHistoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity in pRMBOQDetailHistoryEntityList)
            {
                returnCode = (this as IPRMBOQDetailHistoryDataAccess).Add(pRMBOQDetailHistoryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMBOQDetailHistoryDataAccess.Update(PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMBOQDetailHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMBOQDetailHistoryEntity, filterExpression, option);
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

        private Int64 Update(PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQDetailHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BOQDetailHistoryID", DbType.Int64, pRMBOQDetailHistoryEntity.BOQDetailHistoryID);
                Database.AddInParameter(cmd, "@BOQDetailID", DbType.Int64, pRMBOQDetailHistoryEntity.BOQDetailID);
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMBOQDetailHistoryEntity.Rate);
                Database.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMBOQDetailHistoryEntity.TotalQty);
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMBOQDetailHistoryEntity.EntryDate);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMBOQDetailHistoryEntity.BrandID);
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMBOQDetailHistoryEntity.SupplierID);
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMBOQDetailHistoryEntity.RegionID);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMBOQDetailHistoryEntity.CountryID);
                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, pRMBOQDetailHistoryEntity.MemberID);
                Database.AddInParameter(cmd, "@UserPCIP", DbType.String, pRMBOQDetailHistoryEntity.UserPCIP);
                Database.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, pRMBOQDetailHistoryEntity.UpdatedDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMBOQDetailHistoryEntity already exists. Please specify another PRMBOQDetailHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMBOQDetailHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMBOQDetailHistoryEntity already exists. Please specify another PRMBOQDetailHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQDetailHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BOQDetailHistoryID", DbType.Int64, pRMBOQDetailHistoryEntity.BOQDetailHistoryID);
                db.AddInParameter(cmd, "@BOQDetailID", DbType.Int64, pRMBOQDetailHistoryEntity.BOQDetailID);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMBOQDetailHistoryEntity.Rate);
                db.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMBOQDetailHistoryEntity.TotalQty);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMBOQDetailHistoryEntity.EntryDate);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMBOQDetailHistoryEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMBOQDetailHistoryEntity.SupplierID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMBOQDetailHistoryEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMBOQDetailHistoryEntity.CountryID);
                db.AddInParameter(cmd, "@MemberID", DbType.Int64, pRMBOQDetailHistoryEntity.MemberID);
                db.AddInParameter(cmd, "@UserPCIP", DbType.String, pRMBOQDetailHistoryEntity.UserPCIP);
                db.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, pRMBOQDetailHistoryEntity.UpdatedDate);

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

        IList<Int64> IPRMBOQDetailHistoryDataAccess.Update(IList<PRMBOQDetailHistoryEntity> pRMBOQDetailHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity in pRMBOQDetailHistoryEntityList)
            {
                returnCode = (this as IPRMBOQDetailHistoryDataAccess).Update(pRMBOQDetailHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMBOQDetailHistoryDataAccess.Delete(PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMBOQDetailHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMBOQDetailHistoryEntity, filterExpression, option);
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

        private Int64 Delete(PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQDetailHistory_SET";

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
                                throw new ArgumentException("PRMBOQDetailHistoryEntity already exists. Please specify another PRMBOQDetailHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMBOQDetailHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMBOQDetailHistoryEntity already exists. Please specify another PRMBOQDetailHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQDetailHistory_SET";

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

        IList<Int64> IPRMBOQDetailHistoryDataAccess.Delete(IList<PRMBOQDetailHistoryEntity> pRMBOQDetailHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity in pRMBOQDetailHistoryEntityList)
            {
                returnCode = (this as IPRMBOQDetailHistoryDataAccess).Delete(pRMBOQDetailHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMBOQDetailHistoryEntity> IPRMBOQDetailHistoryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMBOQDetailHistory_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMBOQDetailHistoryEntity> list = CreateEntityBuilder<PRMBOQDetailHistoryEntity>().BuildEntities(reader);

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

        DataTable IPRMBOQDetailHistoryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMBOQDetailHistory_GET";

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
