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
    internal sealed partial class BDProjectAdditionalInfoDataAccess : BaseDataAccess, IBDProjectAdditionalInfoDataAccess
    {
        #region Constructors

        public BDProjectAdditionalInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectAdditionalInfoEntity> CreateEntityBuilder<BDProjectAdditionalInfoEntity>()
        {
            return (new BDProjectAdditionalInfoBuilder()) as IEntityBuilder<BDProjectAdditionalInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectAdditionalInfoDataAccess.Add(BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectAdditionalInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectAdditionalInfoEntity, option);
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

        private Int64 Add(BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAdditionalInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectAdditionalInfoID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectAdditionalInfoEntity.ProjectID);	
                Database.AddInParameter(cmd, "@NumberOfStorey", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfStorey);	
                Database.AddInParameter(cmd, "@NumberOfBlock", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfBlock);	
                Database.AddInParameter(cmd, "@TypicalFloorArea", DbType.Decimal, bDProjectAdditionalInfoEntity.TypicalFloorArea);	
                Database.AddInParameter(cmd, "@TypicalFloorAreaUnitID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorAreaUnitID);	
                Database.AddInParameter(cmd, "@GCArchieved", DbType.Decimal, bDProjectAdditionalInfoEntity.GCArchieved);	
                Database.AddInParameter(cmd, "@NumberOfBasement", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfBasement);	
                Database.AddInParameter(cmd, "@NumberOfResidentialFloor", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfResidentialFloor);	
                Database.AddInParameter(cmd, "@NumberOfCommercialFloor", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfCommercialFloor);	
                Database.AddInParameter(cmd, "@NoOfResidentialUnitPerFloor", DbType.Decimal, bDProjectAdditionalInfoEntity.NoOfResidentialUnitPerFloor);	
                Database.AddInParameter(cmd, "@Facing", DbType.String, bDProjectAdditionalInfoEntity.Facing);	
                Database.AddInParameter(cmd, "@TotalNumberOfUnit", DbType.Decimal, bDProjectAdditionalInfoEntity.TotalNumberOfUnit);	
                Database.AddInParameter(cmd, "@NumberOfPenthouse", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfPenthouse);	
                Database.AddInParameter(cmd, "@NumberOfStair", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfStair);	
                Database.AddInParameter(cmd, "@PositionAtBuilding", DbType.String, bDProjectAdditionalInfoEntity.PositionAtBuilding);	
                Database.AddInParameter(cmd, "@CoolingSystem", DbType.String, bDProjectAdditionalInfoEntity.CoolingSystem);	
                Database.AddInParameter(cmd, "@GeyserSystem", DbType.String, bDProjectAdditionalInfoEntity.GeyserSystem);	
                Database.AddInParameter(cmd, "@FacilitiesAtMezzanineFloor", DbType.String, bDProjectAdditionalInfoEntity.FacilitiesAtMezzanineFloor);	
                Database.AddInParameter(cmd, "@FacilitiesAtRoofFloor", DbType.String, bDProjectAdditionalInfoEntity.FacilitiesAtRoofFloor);	
                Database.AddInParameter(cmd, "@ApprovalRequired", DbType.String, bDProjectAdditionalInfoEntity.ApprovalRequired);
                Database.AddInParameter(cmd, "@PositionAtBuildingForCommercial", DbType.String, bDProjectAdditionalInfoEntity.PositionAtBuildingForCommercial);
                Database.AddInParameter(cmd, "@GroundFloorHeight", DbType.Decimal, bDProjectAdditionalInfoEntity.GroundFloorHeight);
                Database.AddInParameter(cmd, "@TypicalFloorHeight", DbType.Decimal, bDProjectAdditionalInfoEntity.TypicalFloorHeight);
                Database.AddInParameter(cmd, "@GroundFloorHeightUnitInFeetID", DbType.Int64, bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInFeetID);
                Database.AddInParameter(cmd, "@TypicalFloorHeightUnitInchID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitInchID);
                Database.AddInParameter(cmd, "@GroundFloorHeightInch", DbType.Decimal, bDProjectAdditionalInfoEntity.GroundFloorHeightInch);
                Database.AddInParameter(cmd, "@GroundFloorHeightUnitInInchID", DbType.Int64, bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInInchID);
                Database.AddInParameter(cmd, "@TypicalFloorHeightFeet", DbType.Decimal, bDProjectAdditionalInfoEntity.TypicalFloorHeightFeet);
                Database.AddInParameter(cmd, "@TypicalFloorHeightUnitFeetID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitFeetID);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectAdditionalInfoEntity already exists. Please specify another BDProjectAdditionalInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectAdditionalInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectAdditionalInfoEntity already exists. Please specify another BDProjectAdditionalInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAdditionalInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectAdditionalInfoID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectAdditionalInfoEntity.ProjectID);
                db.AddInParameter(cmd, "@NumberOfStorey", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfStorey);
                db.AddInParameter(cmd, "@NumberOfBlock", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfBlock);
                db.AddInParameter(cmd, "@TypicalFloorArea", DbType.Decimal, bDProjectAdditionalInfoEntity.TypicalFloorArea);
                db.AddInParameter(cmd, "@TypicalFloorAreaUnitID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorAreaUnitID);
                db.AddInParameter(cmd, "@GCArchieved", DbType.Decimal, bDProjectAdditionalInfoEntity.GCArchieved);
                db.AddInParameter(cmd, "@NumberOfBasement", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfBasement);
                db.AddInParameter(cmd, "@NumberOfResidentialFloor", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfResidentialFloor);
                db.AddInParameter(cmd, "@NumberOfCommercialFloor", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfCommercialFloor);
                db.AddInParameter(cmd, "@NoOfResidentialUnitPerFloor", DbType.Decimal, bDProjectAdditionalInfoEntity.NoOfResidentialUnitPerFloor);
                db.AddInParameter(cmd, "@Facing", DbType.String, bDProjectAdditionalInfoEntity.Facing);
                db.AddInParameter(cmd, "@TotalNumberOfUnit", DbType.Decimal, bDProjectAdditionalInfoEntity.TotalNumberOfUnit);
                db.AddInParameter(cmd, "@NumberOfPenthouse", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfPenthouse);
                db.AddInParameter(cmd, "@NumberOfStair", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfStair);
                db.AddInParameter(cmd, "@PositionAtBuilding", DbType.String, bDProjectAdditionalInfoEntity.PositionAtBuilding);
                db.AddInParameter(cmd, "@CoolingSystem", DbType.String, bDProjectAdditionalInfoEntity.CoolingSystem);
                db.AddInParameter(cmd, "@GeyserSystem", DbType.String, bDProjectAdditionalInfoEntity.GeyserSystem);
                db.AddInParameter(cmd, "@FacilitiesAtMezzanineFloor", DbType.String, bDProjectAdditionalInfoEntity.FacilitiesAtMezzanineFloor);
                db.AddInParameter(cmd, "@FacilitiesAtRoofFloor", DbType.String, bDProjectAdditionalInfoEntity.FacilitiesAtRoofFloor);
                db.AddInParameter(cmd, "@ApprovalRequired", DbType.String, bDProjectAdditionalInfoEntity.ApprovalRequired);
                db.AddInParameter(cmd, "@PositionAtBuildingForCommercial", DbType.String, bDProjectAdditionalInfoEntity.PositionAtBuildingForCommercial);
                db.AddInParameter(cmd, "@GroundFloorHeight", DbType.Decimal, bDProjectAdditionalInfoEntity.GroundFloorHeight);
                db.AddInParameter(cmd, "@TypicalFloorHeight", DbType.Decimal, bDProjectAdditionalInfoEntity.TypicalFloorHeight);
                db.AddInParameter(cmd, "@GroundFloorHeightUnitInFeetID", DbType.Int64, bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInFeetID);
                db.AddInParameter(cmd, "@TypicalFloorHeightUnitInchID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitInchID);
                db.AddInParameter(cmd, "@GroundFloorHeightInch", DbType.Decimal, bDProjectAdditionalInfoEntity.GroundFloorHeightInch);
                db.AddInParameter(cmd, "@GroundFloorHeightUnitInInchID", DbType.Int64, bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInInchID);
                db.AddInParameter(cmd, "@TypicalFloorHeightFeet", DbType.Decimal, bDProjectAdditionalInfoEntity.TypicalFloorHeightFeet);
                db.AddInParameter(cmd, "@TypicalFloorHeightUnitFeetID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitFeetID);

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

        IList<Int64> IBDProjectAdditionalInfoDataAccess.Add(IList<BDProjectAdditionalInfoEntity> bDProjectAdditionalInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity in bDProjectAdditionalInfoEntityList)
            {
                returnCode = (this as IBDProjectAdditionalInfoDataAccess).Add(bDProjectAdditionalInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectAdditionalInfoDataAccess.Update(BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectAdditionalInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectAdditionalInfoEntity, filterExpression, option);
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

        private Int64 Update(BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAdditionalInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectAdditionalInfoID", DbType.Int64, bDProjectAdditionalInfoEntity.ProjectAdditionalInfoID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectAdditionalInfoEntity.ProjectID);
                Database.AddInParameter(cmd, "@NumberOfStorey", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfStorey);
                Database.AddInParameter(cmd, "@NumberOfBlock", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfBlock);
                Database.AddInParameter(cmd, "@TypicalFloorArea", DbType.Decimal, bDProjectAdditionalInfoEntity.TypicalFloorArea);
                Database.AddInParameter(cmd, "@TypicalFloorAreaUnitID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorAreaUnitID);
                Database.AddInParameter(cmd, "@GCArchieved", DbType.Decimal, bDProjectAdditionalInfoEntity.GCArchieved);
                Database.AddInParameter(cmd, "@NumberOfBasement", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfBasement);
                Database.AddInParameter(cmd, "@NumberOfResidentialFloor", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfResidentialFloor);
                Database.AddInParameter(cmd, "@NumberOfCommercialFloor", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfCommercialFloor);
                Database.AddInParameter(cmd, "@NoOfResidentialUnitPerFloor", DbType.Decimal, bDProjectAdditionalInfoEntity.NoOfResidentialUnitPerFloor);
                Database.AddInParameter(cmd, "@Facing", DbType.String, bDProjectAdditionalInfoEntity.Facing);
                Database.AddInParameter(cmd, "@TotalNumberOfUnit", DbType.Decimal, bDProjectAdditionalInfoEntity.TotalNumberOfUnit);
                Database.AddInParameter(cmd, "@NumberOfPenthouse", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfPenthouse);
                Database.AddInParameter(cmd, "@NumberOfStair", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfStair);
                Database.AddInParameter(cmd, "@PositionAtBuilding", DbType.String, bDProjectAdditionalInfoEntity.PositionAtBuilding);
                Database.AddInParameter(cmd, "@CoolingSystem", DbType.String, bDProjectAdditionalInfoEntity.CoolingSystem);
                Database.AddInParameter(cmd, "@GeyserSystem", DbType.String, bDProjectAdditionalInfoEntity.GeyserSystem);
                Database.AddInParameter(cmd, "@FacilitiesAtMezzanineFloor", DbType.String, bDProjectAdditionalInfoEntity.FacilitiesAtMezzanineFloor);
                Database.AddInParameter(cmd, "@FacilitiesAtRoofFloor", DbType.String, bDProjectAdditionalInfoEntity.FacilitiesAtRoofFloor);
                Database.AddInParameter(cmd, "@ApprovalRequired", DbType.String, bDProjectAdditionalInfoEntity.ApprovalRequired);
                Database.AddInParameter(cmd, "@PositionAtBuildingForCommercial", DbType.String, bDProjectAdditionalInfoEntity.PositionAtBuildingForCommercial);
                Database.AddInParameter(cmd, "@GroundFloorHeight", DbType.Decimal, bDProjectAdditionalInfoEntity.GroundFloorHeight);
                Database.AddInParameter(cmd, "@TypicalFloorHeight", DbType.Decimal, bDProjectAdditionalInfoEntity.TypicalFloorHeight);
                Database.AddInParameter(cmd, "@GroundFloorHeightUnitInFeetID", DbType.Int64, bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInFeetID);
                Database.AddInParameter(cmd, "@TypicalFloorHeightUnitInchID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitInchID);
                Database.AddInParameter(cmd, "@GroundFloorHeightInch", DbType.Decimal, bDProjectAdditionalInfoEntity.GroundFloorHeightInch);
                Database.AddInParameter(cmd, "@GroundFloorHeightUnitInInchID", DbType.Int64, bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInInchID);
                Database.AddInParameter(cmd, "@TypicalFloorHeightFeet", DbType.Decimal, bDProjectAdditionalInfoEntity.TypicalFloorHeightFeet);
                Database.AddInParameter(cmd, "@TypicalFloorHeightUnitFeetID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitFeetID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectAdditionalInfoEntity already exists. Please specify another BDProjectAdditionalInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectAdditionalInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectAdditionalInfoEntity already exists. Please specify another BDProjectAdditionalInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAdditionalInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectAdditionalInfoID", DbType.Int64, bDProjectAdditionalInfoEntity.ProjectAdditionalInfoID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectAdditionalInfoEntity.ProjectID);
                db.AddInParameter(cmd, "@NumberOfStorey", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfStorey);
                db.AddInParameter(cmd, "@NumberOfBlock", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfBlock);
                db.AddInParameter(cmd, "@TypicalFloorArea", DbType.Decimal, bDProjectAdditionalInfoEntity.TypicalFloorArea);
                db.AddInParameter(cmd, "@TypicalFloorAreaUnitID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorAreaUnitID);
                db.AddInParameter(cmd, "@GCArchieved", DbType.Decimal, bDProjectAdditionalInfoEntity.GCArchieved);
                db.AddInParameter(cmd, "@NumberOfBasement", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfBasement);
                db.AddInParameter(cmd, "@NumberOfResidentialFloor", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfResidentialFloor);
                db.AddInParameter(cmd, "@NumberOfCommercialFloor", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfCommercialFloor);
                db.AddInParameter(cmd, "@NoOfResidentialUnitPerFloor", DbType.Decimal, bDProjectAdditionalInfoEntity.NoOfResidentialUnitPerFloor);
                db.AddInParameter(cmd, "@Facing", DbType.String, bDProjectAdditionalInfoEntity.Facing);
                db.AddInParameter(cmd, "@TotalNumberOfUnit", DbType.Decimal, bDProjectAdditionalInfoEntity.TotalNumberOfUnit);
                db.AddInParameter(cmd, "@NumberOfPenthouse", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfPenthouse);
                db.AddInParameter(cmd, "@NumberOfStair", DbType.Decimal, bDProjectAdditionalInfoEntity.NumberOfStair);
                db.AddInParameter(cmd, "@PositionAtBuilding", DbType.String, bDProjectAdditionalInfoEntity.PositionAtBuilding);
                db.AddInParameter(cmd, "@CoolingSystem", DbType.String, bDProjectAdditionalInfoEntity.CoolingSystem);
                db.AddInParameter(cmd, "@GeyserSystem", DbType.String, bDProjectAdditionalInfoEntity.GeyserSystem);
                db.AddInParameter(cmd, "@FacilitiesAtMezzanineFloor", DbType.String, bDProjectAdditionalInfoEntity.FacilitiesAtMezzanineFloor);
                db.AddInParameter(cmd, "@FacilitiesAtRoofFloor", DbType.String, bDProjectAdditionalInfoEntity.FacilitiesAtRoofFloor);
                db.AddInParameter(cmd, "@ApprovalRequired", DbType.String, bDProjectAdditionalInfoEntity.ApprovalRequired);
                db.AddInParameter(cmd, "@PositionAtBuildingForCommercial", DbType.String, bDProjectAdditionalInfoEntity.PositionAtBuildingForCommercial);
                db.AddInParameter(cmd, "@GroundFloorHeight", DbType.Decimal, bDProjectAdditionalInfoEntity.GroundFloorHeight);
                db.AddInParameter(cmd, "@TypicalFloorHeight", DbType.Decimal, bDProjectAdditionalInfoEntity.TypicalFloorHeight);
                db.AddInParameter(cmd, "@GroundFloorHeightUnitInFeetID", DbType.Int64, bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInFeetID);
                db.AddInParameter(cmd, "@TypicalFloorHeightUnitInchID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitInchID);
                db.AddInParameter(cmd, "@TypicalFloorHeightUnitInchID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitInchID);
                db.AddInParameter(cmd, "@GroundFloorHeightInch", DbType.Decimal, bDProjectAdditionalInfoEntity.GroundFloorHeightInch);
                db.AddInParameter(cmd, "@GroundFloorHeightUnitInInchID", DbType.Int64, bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInInchID);
                db.AddInParameter(cmd, "@TypicalFloorHeightFeet", DbType.Decimal, bDProjectAdditionalInfoEntity.TypicalFloorHeightFeet);
                db.AddInParameter(cmd, "@TypicalFloorHeightUnitFeetID", DbType.Int64, bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitFeetID);

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

        IList<Int64> IBDProjectAdditionalInfoDataAccess.Update(IList<BDProjectAdditionalInfoEntity> bDProjectAdditionalInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity in bDProjectAdditionalInfoEntityList)
            {
                returnCode = (this as IBDProjectAdditionalInfoDataAccess).Update(bDProjectAdditionalInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectAdditionalInfoDataAccess.Delete(BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectAdditionalInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectAdditionalInfoEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAdditionalInfo_SET";

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
                                throw new ArgumentException("BDProjectAdditionalInfoEntity already exists. Please specify another BDProjectAdditionalInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectAdditionalInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectAdditionalInfoEntity already exists. Please specify another BDProjectAdditionalInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAdditionalInfo_SET";

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

        IList<Int64> IBDProjectAdditionalInfoDataAccess.Delete(IList<BDProjectAdditionalInfoEntity> bDProjectAdditionalInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity in bDProjectAdditionalInfoEntityList)
            {
                returnCode = (this as IBDProjectAdditionalInfoDataAccess).Delete(bDProjectAdditionalInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectAdditionalInfoEntity> IBDProjectAdditionalInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectAdditionalInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectAdditionalInfoEntity> list = CreateEntityBuilder<BDProjectAdditionalInfoEntity>().BuildEntities(reader);

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

        DataTable IBDProjectAdditionalInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectAdditionalInfo_GET";

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
