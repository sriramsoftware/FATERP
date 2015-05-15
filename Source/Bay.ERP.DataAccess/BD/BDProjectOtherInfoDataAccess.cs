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
    internal sealed partial class BDProjectOtherInfoDataAccess : BaseDataAccess, IBDProjectOtherInfoDataAccess
    {
        #region Constructors

        public BDProjectOtherInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectOtherInfoEntity> CreateEntityBuilder<BDProjectOtherInfoEntity>()
        {
            return (new BDProjectOtherInfoBuilder()) as IEntityBuilder<BDProjectOtherInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectOtherInfoDataAccess.Add(BDProjectOtherInfoEntity bDProjectOtherInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectOtherInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectOtherInfoEntity, option);
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

        private Int64 Add(BDProjectOtherInfoEntity bDProjectOtherInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectOtherInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectOtherInfoID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectOtherInfoEntity.ProjectID);	
                Database.AddInParameter(cmd, "@TBA", DbType.Decimal, bDProjectOtherInfoEntity.TBA);	
                Database.AddInParameter(cmd, "@TBAUnitID", DbType.Int64, bDProjectOtherInfoEntity.TBAUnitID);	
                Database.AddInParameter(cmd, "@FAR", DbType.Decimal, bDProjectOtherInfoEntity.FAR);	
                Database.AddInParameter(cmd, "@FARBonus", DbType.Decimal, bDProjectOtherInfoEntity.FARBonus);	
                Database.AddInParameter(cmd, "@FIA", DbType.Decimal, bDProjectOtherInfoEntity.FIA);	
                Database.AddInParameter(cmd, "@FIAUnitID", DbType.Int64, bDProjectOtherInfoEntity.FIAUnitID);	
                Database.AddInParameter(cmd, "@FIAAchieved", DbType.Decimal, bDProjectOtherInfoEntity.FIAAchieved);	
                Database.AddInParameter(cmd, "@FIAAchievedUnitID", DbType.Int64, bDProjectOtherInfoEntity.FIAAchievedUnitID);	
                Database.AddInParameter(cmd, "@GSA", DbType.Decimal, bDProjectOtherInfoEntity.GSA);	
                Database.AddInParameter(cmd, "@GSAUnitID", DbType.Int64, bDProjectOtherInfoEntity.GSAUnitID);	
                Database.AddInParameter(cmd, "@MGCPercentages", DbType.Decimal, bDProjectOtherInfoEntity.MGCPercentages);	
                Database.AddInParameter(cmd, "@MGCArea", DbType.Decimal, bDProjectOtherInfoEntity.MGCArea);	
                Database.AddInParameter(cmd, "@MGCAreaUnitID", DbType.Int64, bDProjectOtherInfoEntity.MGCAreaUnitID);	
                Database.AddInParameter(cmd, "@GroundCoverage", DbType.String, bDProjectOtherInfoEntity.GroundCoverage);	
                Database.AddInParameter(cmd, "@DateOfAgreement", DbType.DateTime, bDProjectOtherInfoEntity.DateOfAgreement);	
                Database.AddInParameter(cmd, "@DateOfHandover", DbType.DateTime, bDProjectOtherInfoEntity.DateOfHandover);	
                Database.AddInParameter(cmd, "@DelayClause", DbType.String, bDProjectOtherInfoEntity.DelayClause);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectOtherInfoEntity already exists. Please specify another BDProjectOtherInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectOtherInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectOtherInfoEntity already exists. Please specify another BDProjectOtherInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectOtherInfoEntity bDProjectOtherInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectOtherInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectOtherInfoID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectOtherInfoEntity.ProjectID);
                db.AddInParameter(cmd, "@TBA", DbType.Decimal, bDProjectOtherInfoEntity.TBA);
                db.AddInParameter(cmd, "@TBAUnitID", DbType.Int64, bDProjectOtherInfoEntity.TBAUnitID);
                db.AddInParameter(cmd, "@FAR", DbType.Decimal, bDProjectOtherInfoEntity.FAR);
                db.AddInParameter(cmd, "@FARBonus", DbType.Decimal, bDProjectOtherInfoEntity.FARBonus);
                db.AddInParameter(cmd, "@FIA", DbType.Decimal, bDProjectOtherInfoEntity.FIA);
                db.AddInParameter(cmd, "@FIAUnitID", DbType.Int64, bDProjectOtherInfoEntity.FIAUnitID);
                db.AddInParameter(cmd, "@FIAAchieved", DbType.Decimal, bDProjectOtherInfoEntity.FIAAchieved);
                db.AddInParameter(cmd, "@FIAAchievedUnitID", DbType.Int64, bDProjectOtherInfoEntity.FIAAchievedUnitID);
                db.AddInParameter(cmd, "@GSA", DbType.Decimal, bDProjectOtherInfoEntity.GSA);
                db.AddInParameter(cmd, "@GSAUnitID", DbType.Int64, bDProjectOtherInfoEntity.GSAUnitID);
                db.AddInParameter(cmd, "@MGCPercentages", DbType.Decimal, bDProjectOtherInfoEntity.MGCPercentages);
                db.AddInParameter(cmd, "@MGCArea", DbType.Decimal, bDProjectOtherInfoEntity.MGCArea);
                db.AddInParameter(cmd, "@MGCAreaUnitID", DbType.Int64, bDProjectOtherInfoEntity.MGCAreaUnitID);
                db.AddInParameter(cmd, "@GroundCoverage", DbType.String, bDProjectOtherInfoEntity.GroundCoverage);
                db.AddInParameter(cmd, "@DateOfAgreement", DbType.DateTime, bDProjectOtherInfoEntity.DateOfAgreement);
                db.AddInParameter(cmd, "@DateOfHandover", DbType.DateTime, bDProjectOtherInfoEntity.DateOfHandover);
                db.AddInParameter(cmd, "@DelayClause", DbType.String, bDProjectOtherInfoEntity.DelayClause);

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

        IList<Int64> IBDProjectOtherInfoDataAccess.Add(IList<BDProjectOtherInfoEntity> bDProjectOtherInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectOtherInfoEntity bDProjectOtherInfoEntity in bDProjectOtherInfoEntityList)
            {
                returnCode = (this as IBDProjectOtherInfoDataAccess).Add(bDProjectOtherInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectOtherInfoDataAccess.Update(BDProjectOtherInfoEntity bDProjectOtherInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectOtherInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectOtherInfoEntity, filterExpression, option);
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

        private Int64 Update(BDProjectOtherInfoEntity bDProjectOtherInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectOtherInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectOtherInfoID", DbType.Int64, bDProjectOtherInfoEntity.ProjectOtherInfoID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectOtherInfoEntity.ProjectID);
                Database.AddInParameter(cmd, "@TBA", DbType.Decimal, bDProjectOtherInfoEntity.TBA);
                Database.AddInParameter(cmd, "@TBAUnitID", DbType.Int64, bDProjectOtherInfoEntity.TBAUnitID);
                Database.AddInParameter(cmd, "@FAR", DbType.Decimal, bDProjectOtherInfoEntity.FAR);
                Database.AddInParameter(cmd, "@FARBonus", DbType.Decimal, bDProjectOtherInfoEntity.FARBonus);
                Database.AddInParameter(cmd, "@FIA", DbType.Decimal, bDProjectOtherInfoEntity.FIA);
                Database.AddInParameter(cmd, "@FIAUnitID", DbType.Int64, bDProjectOtherInfoEntity.FIAUnitID);
                Database.AddInParameter(cmd, "@FIAAchieved", DbType.Decimal, bDProjectOtherInfoEntity.FIAAchieved);
                Database.AddInParameter(cmd, "@FIAAchievedUnitID", DbType.Int64, bDProjectOtherInfoEntity.FIAAchievedUnitID);
                Database.AddInParameter(cmd, "@GSA", DbType.Decimal, bDProjectOtherInfoEntity.GSA);
                Database.AddInParameter(cmd, "@GSAUnitID", DbType.Int64, bDProjectOtherInfoEntity.GSAUnitID);
                Database.AddInParameter(cmd, "@MGCPercentages", DbType.Decimal, bDProjectOtherInfoEntity.MGCPercentages);
                Database.AddInParameter(cmd, "@MGCArea", DbType.Decimal, bDProjectOtherInfoEntity.MGCArea);
                Database.AddInParameter(cmd, "@MGCAreaUnitID", DbType.Int64, bDProjectOtherInfoEntity.MGCAreaUnitID);
                Database.AddInParameter(cmd, "@GroundCoverage", DbType.String, bDProjectOtherInfoEntity.GroundCoverage);
                Database.AddInParameter(cmd, "@DateOfAgreement", DbType.DateTime, bDProjectOtherInfoEntity.DateOfAgreement);
                Database.AddInParameter(cmd, "@DateOfHandover", DbType.DateTime, bDProjectOtherInfoEntity.DateOfHandover);
                Database.AddInParameter(cmd, "@DelayClause", DbType.String, bDProjectOtherInfoEntity.DelayClause);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectOtherInfoEntity already exists. Please specify another BDProjectOtherInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectOtherInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectOtherInfoEntity already exists. Please specify another BDProjectOtherInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectOtherInfoEntity bDProjectOtherInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectOtherInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectOtherInfoID", DbType.Int64, bDProjectOtherInfoEntity.ProjectOtherInfoID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectOtherInfoEntity.ProjectID);
                db.AddInParameter(cmd, "@TBA", DbType.Decimal, bDProjectOtherInfoEntity.TBA);
                db.AddInParameter(cmd, "@TBAUnitID", DbType.Int64, bDProjectOtherInfoEntity.TBAUnitID);
                db.AddInParameter(cmd, "@FAR", DbType.Decimal, bDProjectOtherInfoEntity.FAR);
                db.AddInParameter(cmd, "@FARBonus", DbType.Decimal, bDProjectOtherInfoEntity.FARBonus);
                db.AddInParameter(cmd, "@FIA", DbType.Decimal, bDProjectOtherInfoEntity.FIA);
                db.AddInParameter(cmd, "@FIAUnitID", DbType.Int64, bDProjectOtherInfoEntity.FIAUnitID);
                db.AddInParameter(cmd, "@FIAAchieved", DbType.Decimal, bDProjectOtherInfoEntity.FIAAchieved);
                db.AddInParameter(cmd, "@FIAAchievedUnitID", DbType.Int64, bDProjectOtherInfoEntity.FIAAchievedUnitID);
                db.AddInParameter(cmd, "@GSA", DbType.Decimal, bDProjectOtherInfoEntity.GSA);
                db.AddInParameter(cmd, "@GSAUnitID", DbType.Int64, bDProjectOtherInfoEntity.GSAUnitID);
                db.AddInParameter(cmd, "@MGCPercentages", DbType.Decimal, bDProjectOtherInfoEntity.MGCPercentages);
                db.AddInParameter(cmd, "@MGCArea", DbType.Decimal, bDProjectOtherInfoEntity.MGCArea);
                db.AddInParameter(cmd, "@MGCAreaUnitID", DbType.Int64, bDProjectOtherInfoEntity.MGCAreaUnitID);
                db.AddInParameter(cmd, "@GroundCoverage", DbType.String, bDProjectOtherInfoEntity.GroundCoverage);
                db.AddInParameter(cmd, "@DateOfAgreement", DbType.DateTime, bDProjectOtherInfoEntity.DateOfAgreement);
                db.AddInParameter(cmd, "@DateOfHandover", DbType.DateTime, bDProjectOtherInfoEntity.DateOfHandover);
                db.AddInParameter(cmd, "@DelayClause", DbType.String, bDProjectOtherInfoEntity.DelayClause);

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

        IList<Int64> IBDProjectOtherInfoDataAccess.Update(IList<BDProjectOtherInfoEntity> bDProjectOtherInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectOtherInfoEntity bDProjectOtherInfoEntity in bDProjectOtherInfoEntityList)
            {
                returnCode = (this as IBDProjectOtherInfoDataAccess).Update(bDProjectOtherInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectOtherInfoDataAccess.Delete(BDProjectOtherInfoEntity bDProjectOtherInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectOtherInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectOtherInfoEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectOtherInfoEntity bDProjectOtherInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectOtherInfo_SET";

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
                                throw new ArgumentException("BDProjectOtherInfoEntity already exists. Please specify another BDProjectOtherInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectOtherInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectOtherInfoEntity already exists. Please specify another BDProjectOtherInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectOtherInfoEntity bDProjectOtherInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectOtherInfo_SET";

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

        IList<Int64> IBDProjectOtherInfoDataAccess.Delete(IList<BDProjectOtherInfoEntity> bDProjectOtherInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectOtherInfoEntity bDProjectOtherInfoEntity in bDProjectOtherInfoEntityList)
            {
                returnCode = (this as IBDProjectOtherInfoDataAccess).Delete(bDProjectOtherInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectOtherInfoEntity> IBDProjectOtherInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectOtherInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectOtherInfoEntity> list = CreateEntityBuilder<BDProjectOtherInfoEntity>().BuildEntities(reader);

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

        DataTable IBDProjectOtherInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectOtherInfo_GET";

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
