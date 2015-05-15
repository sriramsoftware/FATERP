// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Dec-2013, 01:17:51




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeEvaluationReportBuilder : IEntityBuilder<HREmployeeEvaluationReportEntity>
    {
        IList<HREmployeeEvaluationReportEntity> IEntityBuilder<HREmployeeEvaluationReportEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeEvaluationReportEntity> HREmployeeEvaluationReportEntityList = new List<HREmployeeEvaluationReportEntity>();

            while (reader.Read())
            {
                HREmployeeEvaluationReportEntityList.Add(((IEntityBuilder<HREmployeeEvaluationReportEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeEvaluationReportEntityList.Count > 0) ? HREmployeeEvaluationReportEntityList : null;
        }

        HREmployeeEvaluationReportEntity IEntityBuilder<HREmployeeEvaluationReportEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEEVALUATIONREPORTID = 0;
            const Int32 FLD_SESSIONID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_TITLE1 = 3;
            const Int32 FLD_TITLE1COLUMN1 = 4;
            const Int32 FLD_TITLE1COLUMN2 = 5;
            const Int32 FLD_TITLE1CATEGORY1 = 6;
            const Int32 FLD_TITLE1CATEGORY1COLUMN1VALUE = 7;
            const Int32 FLD_TITLE1CATEGORY1COLUMN2VALUE = 8;
            const Int32 FLD_TITLE1CATEGORY2 = 9;
            const Int32 FLD_TITLE1CATEGORY2COLUMN1VALUE = 10;
            const Int32 FLD_TITLE1CATEGORY2COLUMN2VALUE = 11;
            const Int32 FLD_TITLE2 = 12;
            const Int32 FLD_TITLE2COLUMN1 = 13;
            const Int32 FLD_TITLE2CATEGORY1 = 14;
            const Int32 FLD_TITLE2CATEGORY1COLUMN1VALUE = 15;
            const Int32 FLD_TITLE2CATEGORY1COLUMN2VALUE = 16;
            const Int32 FLD_TITLE2CATEGORY2 = 17;
            const Int32 FLD_TITLE2CATEGORY2COLUMN1VALUE = 18;
            const Int32 FLD_TITLE2CATEGORY2COLUMN2VALUE = 19;
            const Int32 FLD_TITLE3 = 20;
            const Int32 FLD_TITLE3COLUMN1 = 21;
            const Int32 FLD_TITLE3CATEGORY1 = 22;
            const Int32 FLD_TITLE3CATEGORY1COLUMN1VALUE = 23;
            const Int32 FLD_TITLE3CATEGORY1COLUMN2VALUE = 24;
            const Int32 FLD_TITLE3CATEGORY2 = 25;
            const Int32 FLD_TITLE3CATEGORY2COLUMN1VALUE = 26;
            const Int32 FLD_TITLE3CATEGORY2COLUMN2VALUE = 27;
            const Int32 FLD_HRREPORTQUESTION1TITLE = 28;
            const Int32 FLD_HRREPORTQUESTION1TITLEVALUE = 29;
            const Int32 FLD_SUPERVISORNUMBERVALUE = 30;
            const Int32 FLD_SCOREVALUE = 31;
            const Int32 FLD_DEDUCATIONVALUE = 32;
            const Int32 FLD_ACTUALSCOREVALUE = 33;
            const Int32 FLD_TITLE4 = 34;
            const Int32 FLD_TITLE4COLUMN1VALUE = 35;
            const Int32 FLD_HRREPORTQUESTION2TITLE = 36;
            const Int32 FLD_HRREPORTQUESTION2TITLEVALUE = 37;
            const Int32 FLD_EXTRA1 = 38;
            const Int32 FLD_EXTRA2 = 39;
            const Int32 FLD_EXTRA3 = 40;
            const Int32 FLD_EXTRA4 = 41;
            const Int32 FLD_EXTRA5 = 42;

            HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity = new HREmployeeEvaluationReportEntity();

            hREmployeeEvaluationReportEntity.EmployeeEvaluationReportID = reader.GetInt64(FLD_EMPLOYEEEVALUATIONREPORTID);
            hREmployeeEvaluationReportEntity.SessionID = reader.GetInt64(FLD_SESSIONID);
            hREmployeeEvaluationReportEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeEvaluationReportEntity.Title1 = reader.GetString(FLD_TITLE1);
            hREmployeeEvaluationReportEntity.Title1Column1 = reader.GetString(FLD_TITLE1COLUMN1);
            hREmployeeEvaluationReportEntity.Title1Column2 = reader.GetString(FLD_TITLE1COLUMN2);
            hREmployeeEvaluationReportEntity.Title1Category1 = reader.GetString(FLD_TITLE1CATEGORY1);
            hREmployeeEvaluationReportEntity.Title1Category1Column1Value = reader.GetString(FLD_TITLE1CATEGORY1COLUMN1VALUE);
            hREmployeeEvaluationReportEntity.Title1Category1Column2Value = reader.GetString(FLD_TITLE1CATEGORY1COLUMN2VALUE);
            hREmployeeEvaluationReportEntity.Title1Category2 = reader.GetString(FLD_TITLE1CATEGORY2);
            hREmployeeEvaluationReportEntity.Title1Category2Column1Value = reader.GetString(FLD_TITLE1CATEGORY2COLUMN1VALUE);
            hREmployeeEvaluationReportEntity.Title1Category2Column2Value = reader.GetString(FLD_TITLE1CATEGORY2COLUMN2VALUE);
            hREmployeeEvaluationReportEntity.Title2 = reader.GetString(FLD_TITLE2);
            hREmployeeEvaluationReportEntity.Title2Column1 = reader.GetString(FLD_TITLE2COLUMN1);
            hREmployeeEvaluationReportEntity.Title2Category1 = reader.GetString(FLD_TITLE2CATEGORY1);
            hREmployeeEvaluationReportEntity.Title2Category1Column1Value = reader.GetString(FLD_TITLE2CATEGORY1COLUMN1VALUE);
            hREmployeeEvaluationReportEntity.Title2Category1Column2Value = reader.GetString(FLD_TITLE2CATEGORY1COLUMN2VALUE);
            hREmployeeEvaluationReportEntity.Title2Category2 = reader.GetString(FLD_TITLE2CATEGORY2);
            hREmployeeEvaluationReportEntity.Title2Category2Column1Value = reader.GetString(FLD_TITLE2CATEGORY2COLUMN1VALUE);
            hREmployeeEvaluationReportEntity.Title2Category2Column2Value = reader.GetString(FLD_TITLE2CATEGORY2COLUMN2VALUE);
            hREmployeeEvaluationReportEntity.Title3 = reader.GetString(FLD_TITLE3);
            hREmployeeEvaluationReportEntity.Title3Column1 = reader.GetString(FLD_TITLE3COLUMN1);
            hREmployeeEvaluationReportEntity.Title3Category1 = reader.GetString(FLD_TITLE3CATEGORY1);
            hREmployeeEvaluationReportEntity.Title3Category1Column1Value = reader.GetString(FLD_TITLE3CATEGORY1COLUMN1VALUE);
            hREmployeeEvaluationReportEntity.Title3Category1Column2Value = reader.GetString(FLD_TITLE3CATEGORY1COLUMN2VALUE);
            hREmployeeEvaluationReportEntity.Title3Category2 = reader.GetString(FLD_TITLE3CATEGORY2);
            hREmployeeEvaluationReportEntity.Title3Category2Column1Value = reader.GetString(FLD_TITLE3CATEGORY2COLUMN1VALUE);
            hREmployeeEvaluationReportEntity.Title3Category2Column2Value = reader.GetString(FLD_TITLE3CATEGORY2COLUMN2VALUE);
            hREmployeeEvaluationReportEntity.HRReportQuestion1Title = reader.GetString(FLD_HRREPORTQUESTION1TITLE);
            hREmployeeEvaluationReportEntity.HRReportQuestion1TitleValue = reader.GetString(FLD_HRREPORTQUESTION1TITLEVALUE);
            hREmployeeEvaluationReportEntity.SupervisorNumberValue = reader.GetDecimal(FLD_SUPERVISORNUMBERVALUE);
            hREmployeeEvaluationReportEntity.ScoreValue = reader.GetDecimal(FLD_SCOREVALUE);
            hREmployeeEvaluationReportEntity.DeducationValue = reader.GetDecimal(FLD_DEDUCATIONVALUE);
            hREmployeeEvaluationReportEntity.ActualScoreValue = reader.GetDecimal(FLD_ACTUALSCOREVALUE);
            hREmployeeEvaluationReportEntity.Title4 = reader.GetString(FLD_TITLE4);
            hREmployeeEvaluationReportEntity.Title4Column1Value = reader.GetDecimal(FLD_TITLE4COLUMN1VALUE);
            hREmployeeEvaluationReportEntity.HRReportQuestion2Title = reader.GetString(FLD_HRREPORTQUESTION2TITLE);
            hREmployeeEvaluationReportEntity.HRReportQuestion2TitleValue = reader.GetString(FLD_HRREPORTQUESTION2TITLEVALUE);
            if (reader.IsDBNull(FLD_EXTRA1)) { hREmployeeEvaluationReportEntity.Extra1 = String.Empty; } else { hREmployeeEvaluationReportEntity.Extra1 = reader.GetString(FLD_EXTRA1); }
            if (reader.IsDBNull(FLD_EXTRA2)) { hREmployeeEvaluationReportEntity.Extra2 = null; } else { hREmployeeEvaluationReportEntity.Extra2 = reader.GetDecimal(FLD_EXTRA2); }
            if (reader.IsDBNull(FLD_EXTRA3)) { hREmployeeEvaluationReportEntity.Extra3 = String.Empty; } else { hREmployeeEvaluationReportEntity.Extra3 = reader.GetString(FLD_EXTRA3); }
            if (reader.IsDBNull(FLD_EXTRA4)) { hREmployeeEvaluationReportEntity.Extra4 = null; } else { hREmployeeEvaluationReportEntity.Extra4 = reader.GetDecimal(FLD_EXTRA4); }
            if (reader.IsDBNull(FLD_EXTRA5)) { hREmployeeEvaluationReportEntity.Extra5 = String.Empty; } else { hREmployeeEvaluationReportEntity.Extra5 = reader.GetString(FLD_EXTRA5); }

            return hREmployeeEvaluationReportEntity;
        }
    }
}
