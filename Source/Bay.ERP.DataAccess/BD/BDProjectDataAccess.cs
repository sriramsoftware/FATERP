// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-May-2015, 10:52:28




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
    internal sealed partial class BDProjectDataAccess : BaseDataAccess, IBDProjectDataAccess
    {
        #region Constructors

        public BDProjectDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectEntity> CreateEntityBuilder<BDProjectEntity>()
        {
            return (new BDProjectBuilder()) as IEntityBuilder<BDProjectEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectDataAccess.Add(BDProjectEntity bDProjectEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectEntity, option);
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

        private Int64 Add(BDProjectEntity bDProjectEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProject_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectID");

                Database.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDProjectEntity.OperatorID);	
                Database.AddInParameter(cmd, "@ZoneID", DbType.Int64, bDProjectEntity.ZoneID);	
                Database.AddInParameter(cmd, "@ProjectCode", DbType.String, bDProjectEntity.ProjectCode);	
                Database.AddInParameter(cmd, "@ProjectName", DbType.String, bDProjectEntity.ProjectName);	
                Database.AddInParameter(cmd, "@LandAreaKatha", DbType.Decimal, bDProjectEntity.LandAreaKatha);	
                Database.AddInParameter(cmd, "@LandAreaSft", DbType.Decimal, bDProjectEntity.LandAreaSft);	
                Database.AddInParameter(cmd, "@RoadWidth", DbType.Decimal, bDProjectEntity.RoadWidth);	
                Database.AddInParameter(cmd, "@RoadWidthUnitID", DbType.Int64, bDProjectEntity.RoadWidthUnitID);	
                Database.AddInParameter(cmd, "@NoOfStoried", DbType.Int32, bDProjectEntity.NoOfStoried);	
                Database.AddInParameter(cmd, "@NoOfBasement", DbType.Int32, bDProjectEntity.NoOfBasement);	
                Database.AddInParameter(cmd, "@Description", DbType.String, bDProjectEntity.Description);	
                Database.AddInParameter(cmd, "@BSC", DbType.String, bDProjectEntity.BSC);	
                Database.AddInParameter(cmd, "@ClientPercentage", DbType.Decimal, bDProjectEntity.ClientPercentage);	
                Database.AddInParameter(cmd, "@CompanyPercentage", DbType.Decimal, bDProjectEntity.CompanyPercentage);	
                Database.AddInParameter(cmd, "@ProjectCategoryID", DbType.Int64, bDProjectEntity.ProjectCategoryID);	
                Database.AddInParameter(cmd, "@ProjectStatusID", DbType.Int64, bDProjectEntity.ProjectStatusID);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDProjectEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectEntity already exists. Please specify another BDProjectEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectEntity already exists. Please specify another BDProjectEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectEntity bDProjectEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProject_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectID", db);

                db.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDProjectEntity.OperatorID);
                db.AddInParameter(cmd, "@ZoneID", DbType.Int64, bDProjectEntity.ZoneID);
                db.AddInParameter(cmd, "@ProjectCode", DbType.String, bDProjectEntity.ProjectCode);
                db.AddInParameter(cmd, "@ProjectName", DbType.String, bDProjectEntity.ProjectName);
                db.AddInParameter(cmd, "@LandAreaKatha", DbType.Decimal, bDProjectEntity.LandAreaKatha);
                db.AddInParameter(cmd, "@LandAreaSft", DbType.Decimal, bDProjectEntity.LandAreaSft);
                db.AddInParameter(cmd, "@RoadWidth", DbType.Decimal, bDProjectEntity.RoadWidth);
                db.AddInParameter(cmd, "@RoadWidthUnitID", DbType.Int64, bDProjectEntity.RoadWidthUnitID);
                db.AddInParameter(cmd, "@NoOfStoried", DbType.Int32, bDProjectEntity.NoOfStoried);
                db.AddInParameter(cmd, "@NoOfBasement", DbType.Int32, bDProjectEntity.NoOfBasement);
                db.AddInParameter(cmd, "@Description", DbType.String, bDProjectEntity.Description);
                db.AddInParameter(cmd, "@BSC", DbType.String, bDProjectEntity.BSC);
                db.AddInParameter(cmd, "@ClientPercentage", DbType.Decimal, bDProjectEntity.ClientPercentage);
                db.AddInParameter(cmd, "@CompanyPercentage", DbType.Decimal, bDProjectEntity.CompanyPercentage);
                db.AddInParameter(cmd, "@ProjectCategoryID", DbType.Int64, bDProjectEntity.ProjectCategoryID);
                db.AddInParameter(cmd, "@ProjectStatusID", DbType.Int64, bDProjectEntity.ProjectStatusID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDProjectEntity.IsRemoved);

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

        IList<Int64> IBDProjectDataAccess.Add(IList<BDProjectEntity> bDProjectEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectEntity bDProjectEntity in bDProjectEntityList)
            {
                returnCode = (this as IBDProjectDataAccess).Add(bDProjectEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectDataAccess.Update(BDProjectEntity bDProjectEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectEntity, filterExpression, option);
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

        private Int64 Update(BDProjectEntity bDProjectEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProject_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectEntity.ProjectID);
                Database.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDProjectEntity.OperatorID);
                Database.AddInParameter(cmd, "@ZoneID", DbType.Int64, bDProjectEntity.ZoneID);
                Database.AddInParameter(cmd, "@ProjectCode", DbType.String, bDProjectEntity.ProjectCode);
                Database.AddInParameter(cmd, "@ProjectName", DbType.String, bDProjectEntity.ProjectName);
                Database.AddInParameter(cmd, "@LandAreaKatha", DbType.Decimal, bDProjectEntity.LandAreaKatha);
                Database.AddInParameter(cmd, "@LandAreaSft", DbType.Decimal, bDProjectEntity.LandAreaSft);
                Database.AddInParameter(cmd, "@RoadWidth", DbType.Decimal, bDProjectEntity.RoadWidth);
                Database.AddInParameter(cmd, "@RoadWidthUnitID", DbType.Int64, bDProjectEntity.RoadWidthUnitID);
                Database.AddInParameter(cmd, "@NoOfStoried", DbType.Int32, bDProjectEntity.NoOfStoried);
                Database.AddInParameter(cmd, "@NoOfBasement", DbType.Int32, bDProjectEntity.NoOfBasement);
                Database.AddInParameter(cmd, "@Description", DbType.String, bDProjectEntity.Description);
                Database.AddInParameter(cmd, "@BSC", DbType.String, bDProjectEntity.BSC);
                Database.AddInParameter(cmd, "@ClientPercentage", DbType.Decimal, bDProjectEntity.ClientPercentage);
                Database.AddInParameter(cmd, "@CompanyPercentage", DbType.Decimal, bDProjectEntity.CompanyPercentage);
                Database.AddInParameter(cmd, "@ProjectCategoryID", DbType.Int64, bDProjectEntity.ProjectCategoryID);
                Database.AddInParameter(cmd, "@ProjectStatusID", DbType.Int64, bDProjectEntity.ProjectStatusID);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDProjectEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectEntity already exists. Please specify another BDProjectEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectEntity already exists. Please specify another BDProjectEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectEntity bDProjectEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProject_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectEntity.ProjectID);
                db.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDProjectEntity.OperatorID);
                db.AddInParameter(cmd, "@ZoneID", DbType.Int64, bDProjectEntity.ZoneID);
                db.AddInParameter(cmd, "@ProjectCode", DbType.String, bDProjectEntity.ProjectCode);
                db.AddInParameter(cmd, "@ProjectName", DbType.String, bDProjectEntity.ProjectName);
                db.AddInParameter(cmd, "@LandAreaKatha", DbType.Decimal, bDProjectEntity.LandAreaKatha);
                db.AddInParameter(cmd, "@LandAreaSft", DbType.Decimal, bDProjectEntity.LandAreaSft);
                db.AddInParameter(cmd, "@RoadWidth", DbType.Decimal, bDProjectEntity.RoadWidth);
                db.AddInParameter(cmd, "@RoadWidthUnitID", DbType.Int64, bDProjectEntity.RoadWidthUnitID);
                db.AddInParameter(cmd, "@NoOfStoried", DbType.Int32, bDProjectEntity.NoOfStoried);
                db.AddInParameter(cmd, "@NoOfBasement", DbType.Int32, bDProjectEntity.NoOfBasement);
                db.AddInParameter(cmd, "@Description", DbType.String, bDProjectEntity.Description);
                db.AddInParameter(cmd, "@BSC", DbType.String, bDProjectEntity.BSC);
                db.AddInParameter(cmd, "@ClientPercentage", DbType.Decimal, bDProjectEntity.ClientPercentage);
                db.AddInParameter(cmd, "@CompanyPercentage", DbType.Decimal, bDProjectEntity.CompanyPercentage);
                db.AddInParameter(cmd, "@ProjectCategoryID", DbType.Int64, bDProjectEntity.ProjectCategoryID);
                db.AddInParameter(cmd, "@ProjectStatusID", DbType.Int64, bDProjectEntity.ProjectStatusID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDProjectEntity.IsRemoved);

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

        IList<Int64> IBDProjectDataAccess.Update(IList<BDProjectEntity> bDProjectEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectEntity bDProjectEntity in bDProjectEntityList)
            {
                returnCode = (this as IBDProjectDataAccess).Update(bDProjectEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectDataAccess.Delete(BDProjectEntity bDProjectEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectEntity bDProjectEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProject_SET";

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
                                throw new ArgumentException("BDProjectEntity already exists. Please specify another BDProjectEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectEntity already exists. Please specify another BDProjectEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectEntity bDProjectEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProject_SET";

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

        IList<Int64> IBDProjectDataAccess.Delete(IList<BDProjectEntity> bDProjectEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectEntity bDProjectEntity in bDProjectEntityList)
            {
                returnCode = (this as IBDProjectDataAccess).Delete(bDProjectEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectEntity> IBDProjectDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProject_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectEntity> list = CreateEntityBuilder<BDProjectEntity>().BuildEntities(reader);

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

        DataTable IBDProjectDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProject_GET";

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
