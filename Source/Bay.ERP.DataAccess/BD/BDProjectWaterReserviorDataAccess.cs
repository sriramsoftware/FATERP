// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




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
    internal sealed partial class BDProjectWaterReserviorDataAccess : BaseDataAccess, IBDProjectWaterReserviorDataAccess
    {
        #region Constructors

        public BDProjectWaterReserviorDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectWaterReserviorEntity> CreateEntityBuilder<BDProjectWaterReserviorEntity>()
        {
            return (new BDProjectWaterReserviorBuilder()) as IEntityBuilder<BDProjectWaterReserviorEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectWaterReserviorDataAccess.Add(BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectWaterReserviorEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectWaterReserviorEntity, option);
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

        private Int64 Add(BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectWaterReservior_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectWaterReserviorID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectWaterReserviorEntity.ProjectID);
                Database.AddInParameter(cmd, "@CapacityOfUndergroundReservior", DbType.Decimal, bDProjectWaterReserviorEntity.CapacityOfUndergroundReservior);
                Database.AddInParameter(cmd, "@UndergroundReserviorUnitID", DbType.Int64, bDProjectWaterReserviorEntity.UndergroundReserviorUnitID);
                Database.AddInParameter(cmd, "@CapacityOfOverheadReservior", DbType.Decimal, bDProjectWaterReserviorEntity.CapacityOfOverheadReservior);
                Database.AddInParameter(cmd, "@OverheadReserviorUnitID", DbType.Int64, bDProjectWaterReserviorEntity.OverheadReserviorUnitID);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectWaterReserviorEntity already exists. Please specify another BDProjectLiftEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectWaterReserviorEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectWaterReserviorEntity already exists. Please specify another BDProjectLiftEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectWaterReservior_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectWaterReserviorID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectWaterReserviorEntity.ProjectID);
                db.AddInParameter(cmd, "@CapacityOfUndergroundReservior", DbType.Decimal, bDProjectWaterReserviorEntity.CapacityOfUndergroundReservior);
                db.AddInParameter(cmd, "@UndergroundReserviorUnitID", DbType.Int64, bDProjectWaterReserviorEntity.UndergroundReserviorUnitID);
                db.AddInParameter(cmd, "@CapacityOfOverheadReservior", DbType.Decimal, bDProjectWaterReserviorEntity.CapacityOfOverheadReservior);
                db.AddInParameter(cmd, "@OverheadReserviorUnitID", DbType.Int64, bDProjectWaterReserviorEntity.OverheadReserviorUnitID);

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

        IList<Int64> IBDProjectWaterReserviorDataAccess.Add(IList<BDProjectWaterReserviorEntity> bDProjectWaterReserviorEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity in bDProjectWaterReserviorEntityList)
            {
                returnCode = (this as IBDProjectWaterReserviorDataAccess).Add(bDProjectWaterReserviorEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectWaterReserviorDataAccess.Update(BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectWaterReserviorEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectWaterReserviorEntity, filterExpression, option);
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

        private Int64 Update(BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectWaterReservior_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectWaterReserviorID", DbType.Int64, bDProjectWaterReserviorEntity.ProjectWaterReserviorID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectWaterReserviorEntity.ProjectID);
                Database.AddInParameter(cmd, "@CapacityOfUndergroundReservior", DbType.Decimal, bDProjectWaterReserviorEntity.CapacityOfUndergroundReservior);
                Database.AddInParameter(cmd, "@UndergroundReserviorUnitID", DbType.Int64, bDProjectWaterReserviorEntity.UndergroundReserviorUnitID);
                Database.AddInParameter(cmd, "@CapacityOfOverheadReservior", DbType.Decimal, bDProjectWaterReserviorEntity.CapacityOfOverheadReservior);
                Database.AddInParameter(cmd, "@OverheadReserviorUnitID", DbType.Int64, bDProjectWaterReserviorEntity.OverheadReserviorUnitID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectWaterReserviorEntity already exists. Please specify another BDProjectLiftEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectWaterReserviorEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectWaterReserviorEntity already exists. Please specify another BDProjectLiftEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectWaterReservior_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectWaterReserviorID", DbType.Int64, bDProjectWaterReserviorEntity.ProjectWaterReserviorID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectWaterReserviorEntity.ProjectID);
                db.AddInParameter(cmd, "@CapacityOfUndergroundReservior", DbType.Decimal, bDProjectWaterReserviorEntity.CapacityOfUndergroundReservior);
                db.AddInParameter(cmd, "@UndergroundReserviorUnitID", DbType.Int64, bDProjectWaterReserviorEntity.UndergroundReserviorUnitID);
                db.AddInParameter(cmd, "@CapacityOfOverheadReservior", DbType.Decimal, bDProjectWaterReserviorEntity.CapacityOfOverheadReservior);
                db.AddInParameter(cmd, "@OverheadReserviorUnitID", DbType.Int64, bDProjectWaterReserviorEntity.OverheadReserviorUnitID);

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

        IList<Int64> IBDProjectWaterReserviorDataAccess.Update(IList<BDProjectWaterReserviorEntity> bDProjectWaterReserviorEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity in bDProjectWaterReserviorEntityList)
            {
                returnCode = (this as IBDProjectWaterReserviorDataAccess).Update(bDProjectWaterReserviorEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectWaterReserviorDataAccess.Delete(BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectWaterReserviorEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectWaterReserviorEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectWaterReservior_SET";

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
                                throw new ArgumentException("BDProjectWaterReserviorEntity already exists. Please specify another BDProjectLiftEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectWaterReserviorEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectWaterReserviorEntity already exists. Please specify another BDProjectLiftEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectWaterReservior_SET";

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

        IList<Int64> IBDProjectWaterReserviorDataAccess.Delete(IList<BDProjectWaterReserviorEntity> bDProjectWaterReserviorEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity in bDProjectWaterReserviorEntityList)
            {
                returnCode = (this as IBDProjectWaterReserviorDataAccess).Delete(bDProjectWaterReserviorEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectWaterReserviorEntity> IBDProjectWaterReserviorDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectWaterReservior_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectWaterReserviorEntity> list = CreateEntityBuilder<BDProjectWaterReserviorEntity>().BuildEntities(reader);

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

        DataTable IBDProjectWaterReserviorDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectWaterReservior_GET";

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
