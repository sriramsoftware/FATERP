// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2013, 03:32:47




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
    internal sealed partial class BDProjectFloorUnitDataAccess : BaseDataAccess, IBDProjectFloorUnitDataAccess
    {
        #region Constructors

        public BDProjectFloorUnitDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectFloorUnitEntity> CreateEntityBuilder<BDProjectFloorUnitEntity>()
        {
            return (new BDProjectFloorUnitBuilder()) as IEntityBuilder<BDProjectFloorUnitEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectFloorUnitDataAccess.Add(BDProjectFloorUnitEntity bDProjectFloorUnitEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectFloorUnitEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectFloorUnitEntity, option);
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

        private Int64 Add(BDProjectFloorUnitEntity bDProjectFloorUnitEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectFloorUnit_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectFloorUnitID");

                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorID);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitTypeID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorUnitTypeID);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitName", DbType.String, bDProjectFloorUnitEntity.ProjectFloorUnitName);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitStatusID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorUnitStatusID);	
                Database.AddInParameter(cmd, "@UnitArea", DbType.Decimal, bDProjectFloorUnitEntity.UnitArea);	
                Database.AddInParameter(cmd, "@TotalArea", DbType.Decimal, bDProjectFloorUnitEntity.TotalArea);	
                Database.AddInParameter(cmd, "@RegisteredArea", DbType.Decimal, bDProjectFloorUnitEntity.RegisteredArea);	
                Database.AddInParameter(cmd, "@Facing", DbType.String, bDProjectFloorUnitEntity.Facing);	
                Database.AddInParameter(cmd, "@Toilet", DbType.Decimal, bDProjectFloorUnitEntity.Toilet);	
                Database.AddInParameter(cmd, "@Kitchen", DbType.Decimal, bDProjectFloorUnitEntity.Kitchen);	
                Database.AddInParameter(cmd, "@Parking", DbType.Decimal, bDProjectFloorUnitEntity.Parking);	
                Database.AddInParameter(cmd, "@BathRoom", DbType.Decimal, bDProjectFloorUnitEntity.BathRoom);	
                Database.AddInParameter(cmd, "@BedRoom", DbType.Decimal, bDProjectFloorUnitEntity.BedRoom);	
                Database.AddInParameter(cmd, "@ServantBed", DbType.Decimal, bDProjectFloorUnitEntity.ServantBed);	
                Database.AddInParameter(cmd, "@ServantToilet", DbType.Decimal, bDProjectFloorUnitEntity.ServantToilet);	
                Database.AddInParameter(cmd, "@Corridor", DbType.Decimal, bDProjectFloorUnitEntity.Corridor);	
                Database.AddInParameter(cmd, "@TapasGarden", DbType.Decimal, bDProjectFloorUnitEntity.TapasGarden);	
                Database.AddInParameter(cmd, "@SwimmingPool", DbType.Decimal, bDProjectFloorUnitEntity.SwimmingPool);	
                Database.AddInParameter(cmd, "@IsIDServiceAvailable", DbType.Boolean, bDProjectFloorUnitEntity.IsIDServiceAvailable);	
                Database.AddInParameter(cmd, "@ElectricityService", DbType.Boolean, bDProjectFloorUnitEntity.ElectricityService);	
                Database.AddInParameter(cmd, "@CommonGenerator", DbType.Boolean, bDProjectFloorUnitEntity.CommonGenerator);	
                Database.AddInParameter(cmd, "@PricePerSft", DbType.Decimal, bDProjectFloorUnitEntity.PricePerSft);	
                Database.AddInParameter(cmd, "@AreaPrice", DbType.Decimal, bDProjectFloorUnitEntity.AreaPrice);	
                Database.AddInParameter(cmd, "@IDPrice", DbType.Decimal, bDProjectFloorUnitEntity.IDPrice);	
                Database.AddInParameter(cmd, "@AdditionalCharges", DbType.Decimal, bDProjectFloorUnitEntity.AdditionalCharges);	
                Database.AddInParameter(cmd, "@Features", DbType.String, bDProjectFloorUnitEntity.Features);	
                Database.AddInParameter(cmd, "@CivilDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.CivilDrawingImageUrl);	
                Database.AddInParameter(cmd, "@ElectricalDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.ElectricalDrawingImageUrl);	
                Database.AddInParameter(cmd, "@InteriorDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.InteriorDrawingImageUrl);	
                Database.AddInParameter(cmd, "@MechanicalDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.MechanicalDrawingImageUrl);	
                Database.AddInParameter(cmd, "@PlumbingDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.PlumbingDrawingImageUrl);	
                Database.AddInParameter(cmd, "@OthersDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.OthersDrawingImageUrl);
                Database.AddInParameter(cmd, "@Foyer", DbType.Decimal, bDProjectFloorUnitEntity.Foyer);
                Database.AddInParameter(cmd, "@SittingRoom", DbType.Decimal, bDProjectFloorUnitEntity.SittingRoom);
                Database.AddInParameter(cmd, "@DiningRoom", DbType.Decimal, bDProjectFloorUnitEntity.DiningRoom);
                Database.AddInParameter(cmd, "@Pantry", DbType.Decimal, bDProjectFloorUnitEntity.Pantry);
                Database.AddInParameter(cmd, "@BreakfastCorner", DbType.Decimal, bDProjectFloorUnitEntity.BreakfastCorner);
                Database.AddInParameter(cmd, "@StudyRoom", DbType.Decimal, bDProjectFloorUnitEntity.StudyRoom);
                Database.AddInParameter(cmd, "@Study", DbType.Decimal, bDProjectFloorUnitEntity.Study);
                Database.AddInParameter(cmd, "@Verandah", DbType.Decimal, bDProjectFloorUnitEntity.Verandah);
                Database.AddInParameter(cmd, "@WaterSupplyAvailable", DbType.Boolean, bDProjectFloorUnitEntity.WaterSupplyAvailable);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDProjectFloorUnitEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectFloorUnitEntity already exists. Please specify another BDProjectFloorUnitEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectFloorUnitEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectFloorUnitEntity already exists. Please specify another BDProjectFloorUnitEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectFloorUnitEntity bDProjectFloorUnitEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectFloorUnit_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectFloorUnitID", db);

                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitTypeID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorUnitTypeID);
                db.AddInParameter(cmd, "@ProjectFloorUnitName", DbType.String, bDProjectFloorUnitEntity.ProjectFloorUnitName);
                db.AddInParameter(cmd, "@ProjectFloorUnitStatusID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorUnitStatusID);
                db.AddInParameter(cmd, "@UnitArea", DbType.Decimal, bDProjectFloorUnitEntity.UnitArea);
                db.AddInParameter(cmd, "@TotalArea", DbType.Decimal, bDProjectFloorUnitEntity.TotalArea);
                db.AddInParameter(cmd, "@RegisteredArea", DbType.Decimal, bDProjectFloorUnitEntity.RegisteredArea);
                db.AddInParameter(cmd, "@Facing", DbType.String, bDProjectFloorUnitEntity.Facing);
                db.AddInParameter(cmd, "@Toilet", DbType.Decimal, bDProjectFloorUnitEntity.Toilet);
                db.AddInParameter(cmd, "@Kitchen", DbType.Decimal, bDProjectFloorUnitEntity.Kitchen);
                db.AddInParameter(cmd, "@Parking", DbType.Decimal, bDProjectFloorUnitEntity.Parking);
                db.AddInParameter(cmd, "@BathRoom", DbType.Decimal, bDProjectFloorUnitEntity.BathRoom);
                db.AddInParameter(cmd, "@BedRoom", DbType.Decimal, bDProjectFloorUnitEntity.BedRoom);
                db.AddInParameter(cmd, "@ServantBed", DbType.Decimal, bDProjectFloorUnitEntity.ServantBed);
                db.AddInParameter(cmd, "@ServantToilet", DbType.Decimal, bDProjectFloorUnitEntity.ServantToilet);
                db.AddInParameter(cmd, "@Corridor", DbType.Decimal, bDProjectFloorUnitEntity.Corridor);
                db.AddInParameter(cmd, "@TapasGarden", DbType.Decimal, bDProjectFloorUnitEntity.TapasGarden);
                db.AddInParameter(cmd, "@SwimmingPool", DbType.Decimal, bDProjectFloorUnitEntity.SwimmingPool);
                db.AddInParameter(cmd, "@IsIDServiceAvailable", DbType.Boolean, bDProjectFloorUnitEntity.IsIDServiceAvailable);
                db.AddInParameter(cmd, "@ElectricityService", DbType.Boolean, bDProjectFloorUnitEntity.ElectricityService);
                db.AddInParameter(cmd, "@CommonGenerator", DbType.Boolean, bDProjectFloorUnitEntity.CommonGenerator);
                db.AddInParameter(cmd, "@PricePerSft", DbType.Decimal, bDProjectFloorUnitEntity.PricePerSft);
                db.AddInParameter(cmd, "@AreaPrice", DbType.Decimal, bDProjectFloorUnitEntity.AreaPrice);
                db.AddInParameter(cmd, "@IDPrice", DbType.Decimal, bDProjectFloorUnitEntity.IDPrice);
                db.AddInParameter(cmd, "@AdditionalCharges", DbType.Decimal, bDProjectFloorUnitEntity.AdditionalCharges);
                db.AddInParameter(cmd, "@Features", DbType.String, bDProjectFloorUnitEntity.Features);
                db.AddInParameter(cmd, "@CivilDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.CivilDrawingImageUrl);
                db.AddInParameter(cmd, "@ElectricalDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.ElectricalDrawingImageUrl);
                db.AddInParameter(cmd, "@InteriorDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.InteriorDrawingImageUrl);
                db.AddInParameter(cmd, "@MechanicalDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.MechanicalDrawingImageUrl);
                db.AddInParameter(cmd, "@PlumbingDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.PlumbingDrawingImageUrl);
                db.AddInParameter(cmd, "@OthersDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.OthersDrawingImageUrl);
                db.AddInParameter(cmd, "@Foyer", DbType.Decimal, bDProjectFloorUnitEntity.Foyer);
                db.AddInParameter(cmd, "@SittingRoom", DbType.Decimal, bDProjectFloorUnitEntity.SittingRoom);
                db.AddInParameter(cmd, "@DiningRoom", DbType.Decimal, bDProjectFloorUnitEntity.DiningRoom);
                db.AddInParameter(cmd, "@Pantry", DbType.Decimal, bDProjectFloorUnitEntity.Pantry);
                db.AddInParameter(cmd, "@BreakfastCorner", DbType.Decimal, bDProjectFloorUnitEntity.BreakfastCorner);
                db.AddInParameter(cmd, "@StudyRoom", DbType.Decimal, bDProjectFloorUnitEntity.StudyRoom);
                db.AddInParameter(cmd, "@Study", DbType.Decimal, bDProjectFloorUnitEntity.Study);
                db.AddInParameter(cmd, "@Verandah", DbType.Decimal, bDProjectFloorUnitEntity.Verandah);
                db.AddInParameter(cmd, "@WaterSupplyAvailable", DbType.Boolean, bDProjectFloorUnitEntity.WaterSupplyAvailable);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDProjectFloorUnitEntity.IsRemoved);	

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

        IList<Int64> IBDProjectFloorUnitDataAccess.Add(IList<BDProjectFloorUnitEntity> bDProjectFloorUnitEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectFloorUnitEntity bDProjectFloorUnitEntity in bDProjectFloorUnitEntityList)
            {
                returnCode = (this as IBDProjectFloorUnitDataAccess).Add(bDProjectFloorUnitEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectFloorUnitDataAccess.Update(BDProjectFloorUnitEntity bDProjectFloorUnitEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectFloorUnitEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectFloorUnitEntity, filterExpression, option);
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

        private Int64 Update(BDProjectFloorUnitEntity bDProjectFloorUnitEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectFloorUnit_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorUnitID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitTypeID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorUnitTypeID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitName", DbType.String, bDProjectFloorUnitEntity.ProjectFloorUnitName);
                Database.AddInParameter(cmd, "@ProjectFloorUnitStatusID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorUnitStatusID);
                Database.AddInParameter(cmd, "@UnitArea", DbType.Decimal, bDProjectFloorUnitEntity.UnitArea);
                Database.AddInParameter(cmd, "@TotalArea", DbType.Decimal, bDProjectFloorUnitEntity.TotalArea);
                Database.AddInParameter(cmd, "@RegisteredArea", DbType.Decimal, bDProjectFloorUnitEntity.RegisteredArea);
                Database.AddInParameter(cmd, "@Facing", DbType.String, bDProjectFloorUnitEntity.Facing);
                Database.AddInParameter(cmd, "@Toilet", DbType.Decimal, bDProjectFloorUnitEntity.Toilet);
                Database.AddInParameter(cmd, "@Kitchen", DbType.Decimal, bDProjectFloorUnitEntity.Kitchen);
                Database.AddInParameter(cmd, "@Parking", DbType.Decimal, bDProjectFloorUnitEntity.Parking);
                Database.AddInParameter(cmd, "@BathRoom", DbType.Decimal, bDProjectFloorUnitEntity.BathRoom);
                Database.AddInParameter(cmd, "@BedRoom", DbType.Decimal, bDProjectFloorUnitEntity.BedRoom);
                Database.AddInParameter(cmd, "@ServantBed", DbType.Decimal, bDProjectFloorUnitEntity.ServantBed);
                Database.AddInParameter(cmd, "@ServantToilet", DbType.Decimal, bDProjectFloorUnitEntity.ServantToilet);
                Database.AddInParameter(cmd, "@Corridor", DbType.Decimal, bDProjectFloorUnitEntity.Corridor);
                Database.AddInParameter(cmd, "@TapasGarden", DbType.Decimal, bDProjectFloorUnitEntity.TapasGarden);
                Database.AddInParameter(cmd, "@SwimmingPool", DbType.Decimal, bDProjectFloorUnitEntity.SwimmingPool);
                Database.AddInParameter(cmd, "@IsIDServiceAvailable", DbType.Boolean, bDProjectFloorUnitEntity.IsIDServiceAvailable);
                Database.AddInParameter(cmd, "@ElectricityService", DbType.Boolean, bDProjectFloorUnitEntity.ElectricityService);
                Database.AddInParameter(cmd, "@CommonGenerator", DbType.Boolean, bDProjectFloorUnitEntity.CommonGenerator);
                Database.AddInParameter(cmd, "@PricePerSft", DbType.Decimal, bDProjectFloorUnitEntity.PricePerSft);
                Database.AddInParameter(cmd, "@AreaPrice", DbType.Decimal, bDProjectFloorUnitEntity.AreaPrice);
                Database.AddInParameter(cmd, "@IDPrice", DbType.Decimal, bDProjectFloorUnitEntity.IDPrice);
                Database.AddInParameter(cmd, "@AdditionalCharges", DbType.Decimal, bDProjectFloorUnitEntity.AdditionalCharges);
                Database.AddInParameter(cmd, "@Features", DbType.String, bDProjectFloorUnitEntity.Features);
                Database.AddInParameter(cmd, "@CivilDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.CivilDrawingImageUrl);
                Database.AddInParameter(cmd, "@ElectricalDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.ElectricalDrawingImageUrl);
                Database.AddInParameter(cmd, "@InteriorDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.InteriorDrawingImageUrl);
                Database.AddInParameter(cmd, "@MechanicalDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.MechanicalDrawingImageUrl);
                Database.AddInParameter(cmd, "@PlumbingDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.PlumbingDrawingImageUrl);
                Database.AddInParameter(cmd, "@OthersDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.OthersDrawingImageUrl);
                Database.AddInParameter(cmd, "@Foyer", DbType.Decimal, bDProjectFloorUnitEntity.Foyer);
                Database.AddInParameter(cmd, "@SittingRoom", DbType.Decimal, bDProjectFloorUnitEntity.SittingRoom);
                Database.AddInParameter(cmd, "@DiningRoom", DbType.Decimal, bDProjectFloorUnitEntity.DiningRoom);
                Database.AddInParameter(cmd, "@Pantry", DbType.Decimal, bDProjectFloorUnitEntity.Pantry);
                Database.AddInParameter(cmd, "@BreakfastCorner", DbType.Decimal, bDProjectFloorUnitEntity.BreakfastCorner);
                Database.AddInParameter(cmd, "@StudyRoom", DbType.Decimal, bDProjectFloorUnitEntity.StudyRoom);
                Database.AddInParameter(cmd, "@Study", DbType.Decimal, bDProjectFloorUnitEntity.Study);
                Database.AddInParameter(cmd, "@Verandah", DbType.Decimal, bDProjectFloorUnitEntity.Verandah);
                Database.AddInParameter(cmd, "@WaterSupplyAvailable", DbType.Boolean, bDProjectFloorUnitEntity.WaterSupplyAvailable);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDProjectFloorUnitEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectFloorUnitEntity already exists. Please specify another BDProjectFloorUnitEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectFloorUnitEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectFloorUnitEntity already exists. Please specify another BDProjectFloorUnitEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectFloorUnitEntity bDProjectFloorUnitEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectFloorUnit_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitTypeID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorUnitTypeID);
                db.AddInParameter(cmd, "@ProjectFloorUnitName", DbType.String, bDProjectFloorUnitEntity.ProjectFloorUnitName);
                db.AddInParameter(cmd, "@ProjectFloorUnitStatusID", DbType.Int64, bDProjectFloorUnitEntity.ProjectFloorUnitStatusID);
                db.AddInParameter(cmd, "@UnitArea", DbType.Decimal, bDProjectFloorUnitEntity.UnitArea);
                db.AddInParameter(cmd, "@TotalArea", DbType.Decimal, bDProjectFloorUnitEntity.TotalArea);
                db.AddInParameter(cmd, "@RegisteredArea", DbType.Decimal, bDProjectFloorUnitEntity.RegisteredArea);
                db.AddInParameter(cmd, "@Facing", DbType.String, bDProjectFloorUnitEntity.Facing);
                db.AddInParameter(cmd, "@Toilet", DbType.Decimal, bDProjectFloorUnitEntity.Toilet);
                db.AddInParameter(cmd, "@Kitchen", DbType.Decimal, bDProjectFloorUnitEntity.Kitchen);
                db.AddInParameter(cmd, "@Parking", DbType.Decimal, bDProjectFloorUnitEntity.Parking);
                db.AddInParameter(cmd, "@BathRoom", DbType.Decimal, bDProjectFloorUnitEntity.BathRoom);
                db.AddInParameter(cmd, "@BedRoom", DbType.Decimal, bDProjectFloorUnitEntity.BedRoom);
                db.AddInParameter(cmd, "@ServantBed", DbType.Decimal, bDProjectFloorUnitEntity.ServantBed);
                db.AddInParameter(cmd, "@ServantToilet", DbType.Decimal, bDProjectFloorUnitEntity.ServantToilet);
                db.AddInParameter(cmd, "@Corridor", DbType.Decimal, bDProjectFloorUnitEntity.Corridor);
                db.AddInParameter(cmd, "@TapasGarden", DbType.Decimal, bDProjectFloorUnitEntity.TapasGarden);
                db.AddInParameter(cmd, "@SwimmingPool", DbType.Decimal, bDProjectFloorUnitEntity.SwimmingPool);
                db.AddInParameter(cmd, "@IsIDServiceAvailable", DbType.Boolean, bDProjectFloorUnitEntity.IsIDServiceAvailable);
                db.AddInParameter(cmd, "@ElectricityService", DbType.Boolean, bDProjectFloorUnitEntity.ElectricityService);
                db.AddInParameter(cmd, "@CommonGenerator", DbType.Boolean, bDProjectFloorUnitEntity.CommonGenerator);
                db.AddInParameter(cmd, "@PricePerSft", DbType.Decimal, bDProjectFloorUnitEntity.PricePerSft);
                db.AddInParameter(cmd, "@AreaPrice", DbType.Decimal, bDProjectFloorUnitEntity.AreaPrice);
                db.AddInParameter(cmd, "@IDPrice", DbType.Decimal, bDProjectFloorUnitEntity.IDPrice);
                db.AddInParameter(cmd, "@AdditionalCharges", DbType.Decimal, bDProjectFloorUnitEntity.AdditionalCharges);
                db.AddInParameter(cmd, "@Features", DbType.String, bDProjectFloorUnitEntity.Features);
                db.AddInParameter(cmd, "@CivilDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.CivilDrawingImageUrl);
                db.AddInParameter(cmd, "@ElectricalDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.ElectricalDrawingImageUrl);
                db.AddInParameter(cmd, "@InteriorDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.InteriorDrawingImageUrl);
                db.AddInParameter(cmd, "@MechanicalDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.MechanicalDrawingImageUrl);
                db.AddInParameter(cmd, "@PlumbingDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.PlumbingDrawingImageUrl);
                db.AddInParameter(cmd, "@OthersDrawingImageUrl", DbType.String, bDProjectFloorUnitEntity.OthersDrawingImageUrl);
                db.AddInParameter(cmd, "@Foyer", DbType.Decimal, bDProjectFloorUnitEntity.Foyer);
                db.AddInParameter(cmd, "@SittingRoom", DbType.Decimal, bDProjectFloorUnitEntity.SittingRoom);
                db.AddInParameter(cmd, "@DiningRoom", DbType.Decimal, bDProjectFloorUnitEntity.DiningRoom);
                db.AddInParameter(cmd, "@Pantry", DbType.Decimal, bDProjectFloorUnitEntity.Pantry);
                db.AddInParameter(cmd, "@BreakfastCorner", DbType.Decimal, bDProjectFloorUnitEntity.BreakfastCorner);
                db.AddInParameter(cmd, "@StudyRoom", DbType.Decimal, bDProjectFloorUnitEntity.StudyRoom);
                db.AddInParameter(cmd, "@Study", DbType.Decimal, bDProjectFloorUnitEntity.Study);
                db.AddInParameter(cmd, "@Verandah", DbType.Decimal, bDProjectFloorUnitEntity.Verandah);
                db.AddInParameter(cmd, "@WaterSupplyAvailable", DbType.Boolean, bDProjectFloorUnitEntity.WaterSupplyAvailable);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDProjectFloorUnitEntity.IsRemoved);

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

        IList<Int64> IBDProjectFloorUnitDataAccess.Update(IList<BDProjectFloorUnitEntity> bDProjectFloorUnitEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectFloorUnitEntity bDProjectFloorUnitEntity in bDProjectFloorUnitEntityList)
            {
                returnCode = (this as IBDProjectFloorUnitDataAccess).Update(bDProjectFloorUnitEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectFloorUnitDataAccess.Delete(BDProjectFloorUnitEntity bDProjectFloorUnitEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectFloorUnitEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectFloorUnitEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectFloorUnitEntity bDProjectFloorUnitEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectFloorUnit_SET";

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
                                throw new ArgumentException("BDProjectFloorUnitEntity already exists. Please specify another BDProjectFloorUnitEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectFloorUnitEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectFloorUnitEntity already exists. Please specify another BDProjectFloorUnitEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectFloorUnitEntity bDProjectFloorUnitEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectFloorUnit_SET";

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

        IList<Int64> IBDProjectFloorUnitDataAccess.Delete(IList<BDProjectFloorUnitEntity> bDProjectFloorUnitEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectFloorUnitEntity bDProjectFloorUnitEntity in bDProjectFloorUnitEntityList)
            {
                returnCode = (this as IBDProjectFloorUnitDataAccess).Delete(bDProjectFloorUnitEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectFloorUnitEntity> IBDProjectFloorUnitDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectFloorUnit_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectFloorUnitEntity> list = CreateEntityBuilder<BDProjectFloorUnitEntity>().BuildEntities(reader);

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

        DataTable IBDProjectFloorUnitDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectFloorUnit_GET";

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
