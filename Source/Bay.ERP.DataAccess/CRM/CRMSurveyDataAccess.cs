// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




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
    internal sealed partial class CRMSurveyDataAccess : BaseDataAccess, ICRMSurveyDataAccess
    {
        #region Constructors

        public CRMSurveyDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMSurveyEntity> CreateEntityBuilder<CRMSurveyEntity>()
        {
            return (new CRMSurveyBuilder()) as IEntityBuilder<CRMSurveyEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMSurveyDataAccess.Add(CRMSurveyEntity cRMSurveyEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMSurveyEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMSurveyEntity, option);
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

        private Int64 Add(CRMSurveyEntity cRMSurveyEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurvey_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "SurveyID");

                Database.AddInParameter(cmd, "@SurveyMasterID", DbType.Int64, cRMSurveyEntity.SurveyMasterID);
                Database.AddInParameter(cmd, "@SurveyOwnerID", DbType.Int64, cRMSurveyEntity.SurveyOwnerID);
                Database.AddInParameter(cmd, "@AreaID", DbType.Int64, cRMSurveyEntity.AreaID);
                Database.AddInParameter(cmd, "@Description", DbType.String, cRMSurveyEntity.Description);	
                Database.AddInParameter(cmd, "@PlotAddress", DbType.String, cRMSurveyEntity.PlotAddress);	
                Database.AddInParameter(cmd, "@ApproximatePlotSize", DbType.Decimal, cRMSurveyEntity.ApproximatePlotSize);	
                Database.AddInParameter(cmd, "@AreaUnitID", DbType.Int64, cRMSurveyEntity.AreaUnitID);	
                Database.AddInParameter(cmd, "@ApproximateFloorSizeSft", DbType.Decimal, cRMSurveyEntity.ApproximateFloorSizeSft);	
                Database.AddInParameter(cmd, "@Floors", DbType.Decimal, cRMSurveyEntity.Floors);	
                Database.AddInParameter(cmd, "@ApproximateTotalSpaceSft", DbType.Decimal, cRMSurveyEntity.ApproximateTotalSpaceSft);	
                Database.AddInParameter(cmd, "@Basements", DbType.String, cRMSurveyEntity.Basements);	
                Database.AddInParameter(cmd, "@NoOfCarParking", DbType.String, cRMSurveyEntity.NoOfCarParking);	
                Database.AddInParameter(cmd, "@ACSystem", DbType.String, cRMSurveyEntity.ACSystem);	
                Database.AddInParameter(cmd, "@GeneratorBackup", DbType.String, cRMSurveyEntity.GeneratorBackup);	
                Database.AddInParameter(cmd, "@LiftsCapacity", DbType.String, cRMSurveyEntity.LiftsCapacity);	
                Database.AddInParameter(cmd, "@ToiletsPerFloor", DbType.String, cRMSurveyEntity.ToiletsPerFloor);	
                Database.AddInParameter(cmd, "@AvailableFloorSft", DbType.String, cRMSurveyEntity.AvailableFloorSft);	
                Database.AddInParameter(cmd, "@AvailableForOccupancy", DbType.String, cRMSurveyEntity.AvailableForOccupancy);	
                Database.AddInParameter(cmd, "@RentalRateBDTPerSft", DbType.String, cRMSurveyEntity.RentalRateBDTPerSft);	
                Database.AddInParameter(cmd, "@SellingRateBDTPerSft", DbType.String, cRMSurveyEntity.SellingRateBDTPerSft);	
                Database.AddInParameter(cmd, "@HandoverTime", DbType.String, cRMSurveyEntity.HandoverTime);	
                Database.AddInParameter(cmd, "@SurveyBuildingStatusID", DbType.Int64, cRMSurveyEntity.SurveyBuildingStatusID);	
                Database.AddInParameter(cmd, "@SurveySourceInformationID", DbType.Int64, cRMSurveyEntity.SurveySourceInformationID);	
                Database.AddInParameter(cmd, "@SourcePersonInformation", DbType.String, cRMSurveyEntity.SourcePersonInformation);	
                Database.AddInParameter(cmd, "@ContactInfo", DbType.String, cRMSurveyEntity.ContactInfo);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMSurveyEntity.Remarks);	
                Database.AddInParameter(cmd, "@AdditionalRemarks", DbType.String, cRMSurveyEntity.AdditionalRemarks);	
                Database.AddInParameter(cmd, "@OthersRemarks", DbType.String, cRMSurveyEntity.OthersRemarks);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMSurveyEntity.CreateDate);	
                Database.AddInParameter(cmd, "@SurveyDate", DbType.DateTime, cRMSurveyEntity.SurveyDate);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMSurveyEntity.IP);	
                Database.AddInParameter(cmd, "@SurveyByEmployeeID", DbType.Int64, cRMSurveyEntity.SurveyByEmployeeID);	
                Database.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMSurveyEntity.CreateByEmployeeID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMSurveyEntity already exists. Please specify another CRMSurveyEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMSurveyEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMSurveyEntity already exists. Please specify another CRMSurveyEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMSurveyEntity cRMSurveyEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurvey_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "SurveyID", db);

                db.AddInParameter(cmd, "@SurveyMasterID", DbType.Int64, cRMSurveyEntity.SurveyMasterID);
                db.AddInParameter(cmd, "@SurveyOwnerID", DbType.Int64, cRMSurveyEntity.SurveyOwnerID);
                db.AddInParameter(cmd, "@AreaID", DbType.Int64, cRMSurveyEntity.AreaID);
                db.AddInParameter(cmd, "@Description", DbType.String, cRMSurveyEntity.Description);
                db.AddInParameter(cmd, "@PlotAddress", DbType.String, cRMSurveyEntity.PlotAddress);
                db.AddInParameter(cmd, "@ApproximatePlotSize", DbType.Decimal, cRMSurveyEntity.ApproximatePlotSize);
                db.AddInParameter(cmd, "@AreaUnitID", DbType.Int64, cRMSurveyEntity.AreaUnitID);
                db.AddInParameter(cmd, "@ApproximateFloorSizeSft", DbType.Decimal, cRMSurveyEntity.ApproximateFloorSizeSft);
                db.AddInParameter(cmd, "@Floors", DbType.Decimal, cRMSurveyEntity.Floors);
                db.AddInParameter(cmd, "@ApproximateTotalSpaceSft", DbType.Decimal, cRMSurveyEntity.ApproximateTotalSpaceSft);
                db.AddInParameter(cmd, "@Basements", DbType.String, cRMSurveyEntity.Basements);
                db.AddInParameter(cmd, "@NoOfCarParking", DbType.String, cRMSurveyEntity.NoOfCarParking);
                db.AddInParameter(cmd, "@ACSystem", DbType.String, cRMSurveyEntity.ACSystem);
                db.AddInParameter(cmd, "@GeneratorBackup", DbType.String, cRMSurveyEntity.GeneratorBackup);
                db.AddInParameter(cmd, "@LiftsCapacity", DbType.String, cRMSurveyEntity.LiftsCapacity);
                db.AddInParameter(cmd, "@ToiletsPerFloor", DbType.String, cRMSurveyEntity.ToiletsPerFloor);
                db.AddInParameter(cmd, "@AvailableFloorSft", DbType.String, cRMSurveyEntity.AvailableFloorSft);
                db.AddInParameter(cmd, "@AvailableForOccupancy", DbType.String, cRMSurveyEntity.AvailableForOccupancy);
                db.AddInParameter(cmd, "@RentalRateBDTPerSft", DbType.String, cRMSurveyEntity.RentalRateBDTPerSft);
                db.AddInParameter(cmd, "@SellingRateBDTPerSft", DbType.String, cRMSurveyEntity.SellingRateBDTPerSft);
                db.AddInParameter(cmd, "@HandoverTime", DbType.String, cRMSurveyEntity.HandoverTime);
                db.AddInParameter(cmd, "@SurveyBuildingStatusID", DbType.Int64, cRMSurveyEntity.SurveyBuildingStatusID);
                db.AddInParameter(cmd, "@SurveySourceInformationID", DbType.Int64, cRMSurveyEntity.SurveySourceInformationID);
                db.AddInParameter(cmd, "@SourcePersonInformation", DbType.String, cRMSurveyEntity.SourcePersonInformation);
                db.AddInParameter(cmd, "@ContactInfo", DbType.String, cRMSurveyEntity.ContactInfo);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMSurveyEntity.Remarks);
                db.AddInParameter(cmd, "@AdditionalRemarks", DbType.String, cRMSurveyEntity.AdditionalRemarks);
                db.AddInParameter(cmd, "@OthersRemarks", DbType.String, cRMSurveyEntity.OthersRemarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMSurveyEntity.CreateDate);
                db.AddInParameter(cmd, "@SurveyDate", DbType.DateTime, cRMSurveyEntity.SurveyDate);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMSurveyEntity.IP);
                db.AddInParameter(cmd, "@SurveyByEmployeeID", DbType.Int64, cRMSurveyEntity.SurveyByEmployeeID);
                db.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMSurveyEntity.CreateByEmployeeID);

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

        IList<Int64> ICRMSurveyDataAccess.Add(IList<CRMSurveyEntity> cRMSurveyEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMSurveyEntity cRMSurveyEntity in cRMSurveyEntityList)
            {
                returnCode = (this as ICRMSurveyDataAccess).Add(cRMSurveyEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMSurveyDataAccess.Update(CRMSurveyEntity cRMSurveyEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMSurveyEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMSurveyEntity, filterExpression, option);
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

        private Int64 Update(CRMSurveyEntity cRMSurveyEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurvey_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@SurveyID", DbType.Int64, cRMSurveyEntity.SurveyID);
                Database.AddInParameter(cmd, "@SurveyMasterID", DbType.Int64, cRMSurveyEntity.SurveyMasterID);
                Database.AddInParameter(cmd, "@SurveyOwnerID", DbType.Int64, cRMSurveyEntity.SurveyOwnerID);
                Database.AddInParameter(cmd, "@AreaID", DbType.Int64, cRMSurveyEntity.AreaID);
                Database.AddInParameter(cmd, "@Description", DbType.String, cRMSurveyEntity.Description);
                Database.AddInParameter(cmd, "@PlotAddress", DbType.String, cRMSurveyEntity.PlotAddress);
                Database.AddInParameter(cmd, "@ApproximatePlotSize", DbType.Decimal, cRMSurveyEntity.ApproximatePlotSize);
                Database.AddInParameter(cmd, "@AreaUnitID", DbType.Int64, cRMSurveyEntity.AreaUnitID);
                Database.AddInParameter(cmd, "@ApproximateFloorSizeSft", DbType.Decimal, cRMSurveyEntity.ApproximateFloorSizeSft);
                Database.AddInParameter(cmd, "@Floors", DbType.Decimal, cRMSurveyEntity.Floors);
                Database.AddInParameter(cmd, "@ApproximateTotalSpaceSft", DbType.Decimal, cRMSurveyEntity.ApproximateTotalSpaceSft);
                Database.AddInParameter(cmd, "@Basements", DbType.String, cRMSurveyEntity.Basements);
                Database.AddInParameter(cmd, "@NoOfCarParking", DbType.String, cRMSurveyEntity.NoOfCarParking);
                Database.AddInParameter(cmd, "@ACSystem", DbType.String, cRMSurveyEntity.ACSystem);
                Database.AddInParameter(cmd, "@GeneratorBackup", DbType.String, cRMSurveyEntity.GeneratorBackup);
                Database.AddInParameter(cmd, "@LiftsCapacity", DbType.String, cRMSurveyEntity.LiftsCapacity);
                Database.AddInParameter(cmd, "@ToiletsPerFloor", DbType.String, cRMSurveyEntity.ToiletsPerFloor);
                Database.AddInParameter(cmd, "@AvailableFloorSft", DbType.String, cRMSurveyEntity.AvailableFloorSft);
                Database.AddInParameter(cmd, "@AvailableForOccupancy", DbType.String, cRMSurveyEntity.AvailableForOccupancy);
                Database.AddInParameter(cmd, "@RentalRateBDTPerSft", DbType.String, cRMSurveyEntity.RentalRateBDTPerSft);
                Database.AddInParameter(cmd, "@SellingRateBDTPerSft", DbType.String, cRMSurveyEntity.SellingRateBDTPerSft);
                Database.AddInParameter(cmd, "@HandoverTime", DbType.String, cRMSurveyEntity.HandoverTime);
                Database.AddInParameter(cmd, "@SurveyBuildingStatusID", DbType.Int64, cRMSurveyEntity.SurveyBuildingStatusID);
                Database.AddInParameter(cmd, "@SurveySourceInformationID", DbType.Int64, cRMSurveyEntity.SurveySourceInformationID);
                Database.AddInParameter(cmd, "@SourcePersonInformation", DbType.String, cRMSurveyEntity.SourcePersonInformation);
                Database.AddInParameter(cmd, "@ContactInfo", DbType.String, cRMSurveyEntity.ContactInfo);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMSurveyEntity.Remarks);
                Database.AddInParameter(cmd, "@AdditionalRemarks", DbType.String, cRMSurveyEntity.AdditionalRemarks);
                Database.AddInParameter(cmd, "@OthersRemarks", DbType.String, cRMSurveyEntity.OthersRemarks);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMSurveyEntity.CreateDate);
                Database.AddInParameter(cmd, "@SurveyDate", DbType.DateTime, cRMSurveyEntity.SurveyDate);
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMSurveyEntity.IP);
                Database.AddInParameter(cmd, "@SurveyByEmployeeID", DbType.Int64, cRMSurveyEntity.SurveyByEmployeeID);
                Database.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMSurveyEntity.CreateByEmployeeID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMSurveyEntity already exists. Please specify another CRMSurveyEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMSurveyEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMSurveyEntity already exists. Please specify another CRMSurveyEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMSurveyEntity cRMSurveyEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurvey_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@SurveyID", DbType.Int64, cRMSurveyEntity.SurveyID);
                db.AddInParameter(cmd, "@SurveyMasterID", DbType.Int64, cRMSurveyEntity.SurveyMasterID);
                db.AddInParameter(cmd, "@SurveyOwnerID", DbType.Int64, cRMSurveyEntity.SurveyOwnerID);
                db.AddInParameter(cmd, "@AreaID", DbType.Int64, cRMSurveyEntity.AreaID);
                db.AddInParameter(cmd, "@Description", DbType.String, cRMSurveyEntity.Description);
                db.AddInParameter(cmd, "@PlotAddress", DbType.String, cRMSurveyEntity.PlotAddress);
                db.AddInParameter(cmd, "@ApproximatePlotSize", DbType.Decimal, cRMSurveyEntity.ApproximatePlotSize);
                db.AddInParameter(cmd, "@AreaUnitID", DbType.Int64, cRMSurveyEntity.AreaUnitID);
                db.AddInParameter(cmd, "@ApproximateFloorSizeSft", DbType.Decimal, cRMSurveyEntity.ApproximateFloorSizeSft);
                db.AddInParameter(cmd, "@Floors", DbType.Decimal, cRMSurveyEntity.Floors);
                db.AddInParameter(cmd, "@ApproximateTotalSpaceSft", DbType.Decimal, cRMSurveyEntity.ApproximateTotalSpaceSft);
                db.AddInParameter(cmd, "@Basements", DbType.String, cRMSurveyEntity.Basements);
                db.AddInParameter(cmd, "@NoOfCarParking", DbType.String, cRMSurveyEntity.NoOfCarParking);
                db.AddInParameter(cmd, "@ACSystem", DbType.String, cRMSurveyEntity.ACSystem);
                db.AddInParameter(cmd, "@GeneratorBackup", DbType.String, cRMSurveyEntity.GeneratorBackup);
                db.AddInParameter(cmd, "@LiftsCapacity", DbType.String, cRMSurveyEntity.LiftsCapacity);
                db.AddInParameter(cmd, "@ToiletsPerFloor", DbType.String, cRMSurveyEntity.ToiletsPerFloor);
                db.AddInParameter(cmd, "@AvailableFloorSft", DbType.String, cRMSurveyEntity.AvailableFloorSft);
                db.AddInParameter(cmd, "@AvailableForOccupancy", DbType.String, cRMSurveyEntity.AvailableForOccupancy);
                db.AddInParameter(cmd, "@RentalRateBDTPerSft", DbType.String, cRMSurveyEntity.RentalRateBDTPerSft);
                db.AddInParameter(cmd, "@SellingRateBDTPerSft", DbType.String, cRMSurveyEntity.SellingRateBDTPerSft);
                db.AddInParameter(cmd, "@HandoverTime", DbType.String, cRMSurveyEntity.HandoverTime);
                db.AddInParameter(cmd, "@SurveyBuildingStatusID", DbType.Int64, cRMSurveyEntity.SurveyBuildingStatusID);
                db.AddInParameter(cmd, "@SurveySourceInformationID", DbType.Int64, cRMSurveyEntity.SurveySourceInformationID);
                db.AddInParameter(cmd, "@SourcePersonInformation", DbType.String, cRMSurveyEntity.SourcePersonInformation);
                db.AddInParameter(cmd, "@ContactInfo", DbType.String, cRMSurveyEntity.ContactInfo);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMSurveyEntity.Remarks);
                db.AddInParameter(cmd, "@AdditionalRemarks", DbType.String, cRMSurveyEntity.AdditionalRemarks);
                db.AddInParameter(cmd, "@OthersRemarks", DbType.String, cRMSurveyEntity.OthersRemarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMSurveyEntity.CreateDate);
                db.AddInParameter(cmd, "@SurveyDate", DbType.DateTime, cRMSurveyEntity.SurveyDate);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMSurveyEntity.IP);
                db.AddInParameter(cmd, "@SurveyByEmployeeID", DbType.Int64, cRMSurveyEntity.SurveyByEmployeeID);
                db.AddInParameter(cmd, "@CreateByEmployeeID", DbType.Int64, cRMSurveyEntity.CreateByEmployeeID);

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

        IList<Int64> ICRMSurveyDataAccess.Update(IList<CRMSurveyEntity> cRMSurveyEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMSurveyEntity cRMSurveyEntity in cRMSurveyEntityList)
            {
                returnCode = (this as ICRMSurveyDataAccess).Update(cRMSurveyEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMSurveyDataAccess.Delete(CRMSurveyEntity cRMSurveyEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMSurveyEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMSurveyEntity, filterExpression, option);
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

        private Int64 Delete(CRMSurveyEntity cRMSurveyEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurvey_SET";

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
                                throw new ArgumentException("CRMSurveyEntity already exists. Please specify another CRMSurveyEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMSurveyEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMSurveyEntity already exists. Please specify another CRMSurveyEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMSurveyEntity cRMSurveyEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurvey_SET";

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

        IList<Int64> ICRMSurveyDataAccess.Delete(IList<CRMSurveyEntity> cRMSurveyEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMSurveyEntity cRMSurveyEntity in cRMSurveyEntityList)
            {
                returnCode = (this as ICRMSurveyDataAccess).Delete(cRMSurveyEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMSurveyEntity> ICRMSurveyDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMSurvey_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMSurveyEntity> list = CreateEntityBuilder<CRMSurveyEntity>().BuildEntities(reader);

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

        DataTable ICRMSurveyDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMSurvey_GET";

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
