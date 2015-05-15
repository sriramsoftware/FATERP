// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Dec-2013, 10:06:11




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeEvaluationReport_RPTBuilder : IEntityBuilder<HREmployeeEvaluationReport_RPTEntity>
    {
        IList<HREmployeeEvaluationReport_RPTEntity> IEntityBuilder<HREmployeeEvaluationReport_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeEvaluationReport_RPTEntity> HREmployeeEvaluationReport_RPTEntityList = new List<HREmployeeEvaluationReport_RPTEntity>();

            while (reader.Read())
            {
                HREmployeeEvaluationReport_RPTEntityList.Add(((IEntityBuilder<HREmployeeEvaluationReport_RPTEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeEvaluationReport_RPTEntityList.Count > 0) ? HREmployeeEvaluationReport_RPTEntityList : null;
        }

        HREmployeeEvaluationReport_RPTEntity IEntityBuilder<HREmployeeEvaluationReport_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_EMPLOYEECODE = 43;
            const Int32 FLD_EMPLOYEEFULLNAME = 44;
            const Int32 FLD_DEPARTMENTCODE = 45;

            HREmployeeEvaluationReport_RPTEntity hREmployeeEvaluationReport_RPTEntity = new HREmployeeEvaluationReport_RPTEntity();

            hREmployeeEvaluationReport_RPTEntity.EmployeeEvaluationReportID = reader.GetInt64(FLD_EMPLOYEEEVALUATIONREPORTID);
            hREmployeeEvaluationReport_RPTEntity.SessionID = reader.GetInt64(FLD_SESSIONID);
            hREmployeeEvaluationReport_RPTEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeEvaluationReport_RPTEntity.Title1 = reader.GetString(FLD_TITLE1);
            hREmployeeEvaluationReport_RPTEntity.Title1Column1 = reader.GetString(FLD_TITLE1COLUMN1);
            hREmployeeEvaluationReport_RPTEntity.Title1Column2 = reader.GetString(FLD_TITLE1COLUMN2);
            hREmployeeEvaluationReport_RPTEntity.Title1Category1 = reader.GetString(FLD_TITLE1CATEGORY1);
            hREmployeeEvaluationReport_RPTEntity.Title1Category1Column1Value = reader.GetString(FLD_TITLE1CATEGORY1COLUMN1VALUE);
            hREmployeeEvaluationReport_RPTEntity.Title1Category1Column2Value = reader.GetString(FLD_TITLE1CATEGORY1COLUMN2VALUE);
            hREmployeeEvaluationReport_RPTEntity.Title1Category2 = reader.GetString(FLD_TITLE1CATEGORY2);
            hREmployeeEvaluationReport_RPTEntity.Title1Category2Column1Value = reader.GetString(FLD_TITLE1CATEGORY2COLUMN1VALUE);
            hREmployeeEvaluationReport_RPTEntity.Title1Category2Column2Value = reader.GetString(FLD_TITLE1CATEGORY2COLUMN2VALUE);
            hREmployeeEvaluationReport_RPTEntity.Title2 = reader.GetString(FLD_TITLE2);
            hREmployeeEvaluationReport_RPTEntity.Title2Column1 = reader.GetString(FLD_TITLE2COLUMN1);
            hREmployeeEvaluationReport_RPTEntity.Title2Category1 = reader.GetString(FLD_TITLE2CATEGORY1);
            hREmployeeEvaluationReport_RPTEntity.Title2Category1Column1Value = reader.GetString(FLD_TITLE2CATEGORY1COLUMN1VALUE);
            hREmployeeEvaluationReport_RPTEntity.Title2Category1Column2Value = reader.GetString(FLD_TITLE2CATEGORY1COLUMN2VALUE);
            hREmployeeEvaluationReport_RPTEntity.Title2Category2 = reader.GetString(FLD_TITLE2CATEGORY2);
            hREmployeeEvaluationReport_RPTEntity.Title2Category2Column1Value = reader.GetString(FLD_TITLE2CATEGORY2COLUMN1VALUE);
            hREmployeeEvaluationReport_RPTEntity.Title2Category2Column2Value = reader.GetString(FLD_TITLE2CATEGORY2COLUMN2VALUE);
            hREmployeeEvaluationReport_RPTEntity.Title3 = reader.GetString(FLD_TITLE3);
            hREmployeeEvaluationReport_RPTEntity.Title3Column1 = reader.GetString(FLD_TITLE3COLUMN1);
            hREmployeeEvaluationReport_RPTEntity.Title3Category1 = reader.GetString(FLD_TITLE3CATEGORY1);
            hREmployeeEvaluationReport_RPTEntity.Title3Category1Column1Value = reader.GetString(FLD_TITLE3CATEGORY1COLUMN1VALUE);
            hREmployeeEvaluationReport_RPTEntity.Title3Category1Column2Value = reader.GetString(FLD_TITLE3CATEGORY1COLUMN2VALUE);
            hREmployeeEvaluationReport_RPTEntity.Title3Category2 = reader.GetString(FLD_TITLE3CATEGORY2);
            hREmployeeEvaluationReport_RPTEntity.Title3Category2Column1Value = reader.GetString(FLD_TITLE3CATEGORY2COLUMN1VALUE);
            hREmployeeEvaluationReport_RPTEntity.Title3Category2Column2Value = reader.GetString(FLD_TITLE3CATEGORY2COLUMN2VALUE);
            hREmployeeEvaluationReport_RPTEntity.HRReportQuestion1Title = reader.GetString(FLD_HRREPORTQUESTION1TITLE);
            hREmployeeEvaluationReport_RPTEntity.HRReportQuestion1TitleValue = reader.GetString(FLD_HRREPORTQUESTION1TITLEVALUE);
            hREmployeeEvaluationReport_RPTEntity.SupervisorNumberValue = reader.GetDecimal(FLD_SUPERVISORNUMBERVALUE);
            hREmployeeEvaluationReport_RPTEntity.ScoreValue = reader.GetDecimal(FLD_SCOREVALUE);
            hREmployeeEvaluationReport_RPTEntity.DeducationValue = reader.GetDecimal(FLD_DEDUCATIONVALUE);
            hREmployeeEvaluationReport_RPTEntity.ActualScoreValue = reader.GetDecimal(FLD_ACTUALSCOREVALUE);
            hREmployeeEvaluationReport_RPTEntity.Title4 = reader.GetString(FLD_TITLE4);
            hREmployeeEvaluationReport_RPTEntity.Title4Column1Value = reader.GetDecimal(FLD_TITLE4COLUMN1VALUE);
            hREmployeeEvaluationReport_RPTEntity.HRReportQuestion2Title = reader.GetString(FLD_HRREPORTQUESTION2TITLE);
            hREmployeeEvaluationReport_RPTEntity.HRReportQuestion2TitleValue = reader.GetString(FLD_HRREPORTQUESTION2TITLEVALUE);
            if (reader.IsDBNull(FLD_EXTRA1)) { hREmployeeEvaluationReport_RPTEntity.Extra1 = String.Empty; } else { hREmployeeEvaluationReport_RPTEntity.Extra1 = reader.GetString(FLD_EXTRA1); }
            if (reader.IsDBNull(FLD_EXTRA2)) { hREmployeeEvaluationReport_RPTEntity.Extra2 = null; } else { hREmployeeEvaluationReport_RPTEntity.Extra2 = reader.GetDecimal(FLD_EXTRA2); }
            if (reader.IsDBNull(FLD_EXTRA3)) { hREmployeeEvaluationReport_RPTEntity.Extra3 = String.Empty; } else { hREmployeeEvaluationReport_RPTEntity.Extra3 = reader.GetString(FLD_EXTRA3); }
            if (reader.IsDBNull(FLD_EXTRA4)) { hREmployeeEvaluationReport_RPTEntity.Extra4 = null; } else { hREmployeeEvaluationReport_RPTEntity.Extra4 = reader.GetDecimal(FLD_EXTRA4); }
            if (reader.IsDBNull(FLD_EXTRA5)) { hREmployeeEvaluationReport_RPTEntity.Extra5 = String.Empty; } else { hREmployeeEvaluationReport_RPTEntity.Extra5 = reader.GetString(FLD_EXTRA5); }
            hREmployeeEvaluationReport_RPTEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeEvaluationReport_RPTEntity.EmployeeFullName = String.Empty; } else { hREmployeeEvaluationReport_RPTEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTCODE)) { hREmployeeEvaluationReport_RPTEntity.DepartmentCode = String.Empty; } else { hREmployeeEvaluationReport_RPTEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE); }

            return hREmployeeEvaluationReport_RPTEntity;
        }
    }
}
