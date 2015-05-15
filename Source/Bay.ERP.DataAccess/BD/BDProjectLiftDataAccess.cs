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
    internal sealed partial class BDProjectLiftDataAccess : BaseDataAccess, IBDProjectLiftDataAccess
    {
        #region Constructors

        public BDProjectLiftDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectLiftEntity> CreateEntityBuilder<BDProjectLiftEntity>()
        {
            return (new BDProjectLiftBuilder()) as IEntityBuilder<BDProjectLiftEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectLiftDataAccess.Add(BDProjectLiftEntity bDProjectLiftEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectLiftEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectLiftEntity, option);
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

        private Int64 Add(BDProjectLiftEntity bDProjectLiftEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectLift_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectLiftID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectLiftEntity.ProjectID);	
                Database.AddInParameter(cmd, "@NumberOfLift", DbType.Decimal, bDProjectLiftEntity.NumberOfLift);
                Database.AddInParameter(cmd, "@LiftBrandID", DbType.Int64, bDProjectLiftEntity.LiftBrandID);
                Database.AddInParameter(cmd, "@LiftBrandSupplierID", DbType.Int64, bDProjectLiftEntity.LiftBrandSupplierID);
                Database.AddInParameter(cmd, "@NumberOfPassengerLift", DbType.Decimal, bDProjectLiftEntity.NumberOfPassengerLift);
                Database.AddInParameter(cmd, "@PassengerLiftBrandID", DbType.Int64, bDProjectLiftEntity.PassengerLiftBrandID);
                Database.AddInParameter(cmd, "@PassengerLiftBrandSupplierID", DbType.Int64, bDProjectLiftEntity.PassengerLiftBrandSupplierID);
                Database.AddInParameter(cmd, "@CapacityOfPassengerLift", DbType.Decimal, bDProjectLiftEntity.CapacityOfPassengerLift);	
                Database.AddInParameter(cmd, "@NumberOfServiceLift", DbType.Decimal, bDProjectLiftEntity.NumberOfServiceLift);
                Database.AddInParameter(cmd, "@ServiceLiftBrandID", DbType.Decimal, bDProjectLiftEntity.ServiceLiftBrandID);
                Database.AddInParameter(cmd, "@ServiceLiftBrandSupplierID", DbType.Decimal, bDProjectLiftEntity.ServiceLiftBrandSupplierID);
                Database.AddInParameter(cmd, "@CapacityOfServiceLift", DbType.Decimal, bDProjectLiftEntity.CapacityOfServiceLift);	
                Database.AddInParameter(cmd, "@NumberOfFireFighterLift", DbType.Decimal, bDProjectLiftEntity.NumberOfFireFighterLift);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, bDProjectLiftEntity.BrandID);
                Database.AddInParameter(cmd, "@BrandSupplierID", DbType.Int64, bDProjectLiftEntity.BrandSupplierID);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectLiftEntity already exists. Please specify another BDProjectLiftEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectLiftEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectLiftEntity already exists. Please specify another BDProjectLiftEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectLiftEntity bDProjectLiftEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectLift_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectLiftID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectLiftEntity.ProjectID);
                db.AddInParameter(cmd, "@NumberOfLift", DbType.Decimal, bDProjectLiftEntity.NumberOfLift);
                db.AddInParameter(cmd, "@LiftBrandID", DbType.Int64, bDProjectLiftEntity.LiftBrandID);
                db.AddInParameter(cmd, "@LiftBrandSupplierID", DbType.Int64, bDProjectLiftEntity.LiftBrandSupplierID);
                db.AddInParameter(cmd, "@NumberOfPassengerLift", DbType.Decimal, bDProjectLiftEntity.NumberOfPassengerLift);
                db.AddInParameter(cmd, "@PassengerLiftBrandID", DbType.Int64, bDProjectLiftEntity.PassengerLiftBrandID);
                db.AddInParameter(cmd, "@PassengerLiftBrandSupplierID", DbType.Int64, bDProjectLiftEntity.PassengerLiftBrandSupplierID);
                db.AddInParameter(cmd, "@CapacityOfPassengerLift", DbType.Decimal, bDProjectLiftEntity.CapacityOfPassengerLift);
                db.AddInParameter(cmd, "@NumberOfServiceLift", DbType.Decimal, bDProjectLiftEntity.NumberOfServiceLift);
                db.AddInParameter(cmd, "@ServiceLiftBrandID", DbType.Decimal, bDProjectLiftEntity.ServiceLiftBrandID);
                db.AddInParameter(cmd, "@ServiceLiftBrandSupplierID", DbType.Decimal, bDProjectLiftEntity.ServiceLiftBrandSupplierID);
                db.AddInParameter(cmd, "@CapacityOfServiceLift", DbType.Decimal, bDProjectLiftEntity.CapacityOfServiceLift);
                db.AddInParameter(cmd, "@NumberOfFireFighterLift", DbType.Decimal, bDProjectLiftEntity.NumberOfFireFighterLift);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, bDProjectLiftEntity.BrandID);
                db.AddInParameter(cmd, "@BrandSupplierID", DbType.Int64, bDProjectLiftEntity.BrandSupplierID);

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

        IList<Int64> IBDProjectLiftDataAccess.Add(IList<BDProjectLiftEntity> bDProjectLiftEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectLiftEntity bDProjectLiftEntity in bDProjectLiftEntityList)
            {
                returnCode = (this as IBDProjectLiftDataAccess).Add(bDProjectLiftEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectLiftDataAccess.Update(BDProjectLiftEntity bDProjectLiftEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectLiftEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectLiftEntity, filterExpression, option);
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

        private Int64 Update(BDProjectLiftEntity bDProjectLiftEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectLift_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectLiftID", DbType.Int64, bDProjectLiftEntity.ProjectLiftID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectLiftEntity.ProjectID);
                Database.AddInParameter(cmd, "@NumberOfLift", DbType.Decimal, bDProjectLiftEntity.NumberOfLift);
                Database.AddInParameter(cmd, "@LiftBrandID", DbType.Int64, bDProjectLiftEntity.LiftBrandID);
                Database.AddInParameter(cmd, "@LiftBrandSupplierID", DbType.Int64, bDProjectLiftEntity.LiftBrandSupplierID);
                Database.AddInParameter(cmd, "@NumberOfPassengerLift", DbType.Decimal, bDProjectLiftEntity.NumberOfPassengerLift);
                Database.AddInParameter(cmd, "@PassengerLiftBrandID", DbType.Int64, bDProjectLiftEntity.PassengerLiftBrandID);
                Database.AddInParameter(cmd, "@PassengerLiftBrandSupplierID", DbType.Int64, bDProjectLiftEntity.PassengerLiftBrandSupplierID);
                Database.AddInParameter(cmd, "@CapacityOfPassengerLift", DbType.Decimal, bDProjectLiftEntity.CapacityOfPassengerLift);
                Database.AddInParameter(cmd, "@NumberOfServiceLift", DbType.Decimal, bDProjectLiftEntity.NumberOfServiceLift);
                Database.AddInParameter(cmd, "@ServiceLiftBrandID", DbType.Int64, bDProjectLiftEntity.ServiceLiftBrandID);
                Database.AddInParameter(cmd, "@ServiceLiftBrandSupplierID", DbType.Int64, bDProjectLiftEntity.ServiceLiftBrandSupplierID);
                Database.AddInParameter(cmd, "@CapacityOfServiceLift", DbType.Decimal, bDProjectLiftEntity.CapacityOfServiceLift);
                Database.AddInParameter(cmd, "@NumberOfFireFighterLift", DbType.Decimal, bDProjectLiftEntity.NumberOfFireFighterLift);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, bDProjectLiftEntity.BrandID);
                Database.AddInParameter(cmd, "@BrandSupplierID", DbType.Int64, bDProjectLiftEntity.BrandSupplierID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectLiftEntity already exists. Please specify another BDProjectLiftEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectLiftEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectLiftEntity already exists. Please specify another BDProjectLiftEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectLiftEntity bDProjectLiftEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectLift_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectLiftID", DbType.Int64, bDProjectLiftEntity.ProjectLiftID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectLiftEntity.ProjectID);
                db.AddInParameter(cmd, "@NumberOfLift", DbType.Decimal, bDProjectLiftEntity.NumberOfLift);
                db.AddInParameter(cmd, "@LiftBrandID", DbType.Int64, bDProjectLiftEntity.LiftBrandID);
                db.AddInParameter(cmd, "@LiftBrandSupplierID", DbType.Int64, bDProjectLiftEntity.LiftBrandSupplierID);
                db.AddInParameter(cmd, "@NumberOfPassengerLift", DbType.Decimal, bDProjectLiftEntity.NumberOfPassengerLift);
                db.AddInParameter(cmd, "@PassengerLiftBrandID", DbType.Int64, bDProjectLiftEntity.PassengerLiftBrandID);
                db.AddInParameter(cmd, "@PassengerLiftBrandSupplierID", DbType.Int64, bDProjectLiftEntity.PassengerLiftBrandSupplierID);
                db.AddInParameter(cmd, "@CapacityOfPassengerLift", DbType.Decimal, bDProjectLiftEntity.CapacityOfPassengerLift);
                db.AddInParameter(cmd, "@NumberOfServiceLift", DbType.Decimal, bDProjectLiftEntity.NumberOfServiceLift);
                db.AddInParameter(cmd, "@ServiceLiftBrandID", DbType.Decimal, bDProjectLiftEntity.ServiceLiftBrandID);
                db.AddInParameter(cmd, "@ServiceLiftBrandSupplierID", DbType.Decimal, bDProjectLiftEntity.ServiceLiftBrandSupplierID);
                db.AddInParameter(cmd, "@CapacityOfServiceLift", DbType.Decimal, bDProjectLiftEntity.CapacityOfServiceLift);
                db.AddInParameter(cmd, "@NumberOfFireFighterLift", DbType.Decimal, bDProjectLiftEntity.NumberOfFireFighterLift);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, bDProjectLiftEntity.BrandID);
                db.AddInParameter(cmd, "@BrandSupplierID", DbType.Int64, bDProjectLiftEntity.BrandSupplierID);

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

        IList<Int64> IBDProjectLiftDataAccess.Update(IList<BDProjectLiftEntity> bDProjectLiftEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectLiftEntity bDProjectLiftEntity in bDProjectLiftEntityList)
            {
                returnCode = (this as IBDProjectLiftDataAccess).Update(bDProjectLiftEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectLiftDataAccess.Delete(BDProjectLiftEntity bDProjectLiftEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectLiftEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectLiftEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectLiftEntity bDProjectLiftEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectLift_SET";

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
                                throw new ArgumentException("BDProjectLiftEntity already exists. Please specify another BDProjectLiftEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectLiftEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectLiftEntity already exists. Please specify another BDProjectLiftEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectLiftEntity bDProjectLiftEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectLift_SET";

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

        IList<Int64> IBDProjectLiftDataAccess.Delete(IList<BDProjectLiftEntity> bDProjectLiftEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectLiftEntity bDProjectLiftEntity in bDProjectLiftEntityList)
            {
                returnCode = (this as IBDProjectLiftDataAccess).Delete(bDProjectLiftEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectLiftEntity> IBDProjectLiftDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectLift_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectLiftEntity> list = CreateEntityBuilder<BDProjectLiftEntity>().BuildEntities(reader);

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

        DataTable IBDProjectLiftDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectLift_GET";

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
