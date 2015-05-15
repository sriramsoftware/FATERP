// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Dec-2013, 03:16:13




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeEvaluationReportForAllEmployee_RPTBuilder : IEntityBuilder<HREmployeeEvaluationReportForAllEmployee_RPTEntity>
    {
        IList<HREmployeeEvaluationReportForAllEmployee_RPTEntity> IEntityBuilder<HREmployeeEvaluationReportForAllEmployee_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeEvaluationReportForAllEmployee_RPTEntity> HREmployeeEvaluationReportForAllEmployee_RPTEntityList = new List<HREmployeeEvaluationReportForAllEmployee_RPTEntity>();

            while (reader.Read())
            {
                HREmployeeEvaluationReportForAllEmployee_RPTEntityList.Add(((IEntityBuilder<HREmployeeEvaluationReportForAllEmployee_RPTEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeEvaluationReportForAllEmployee_RPTEntityList.Count > 0) ? HREmployeeEvaluationReportForAllEmployee_RPTEntityList : null;
        }

        HREmployeeEvaluationReportForAllEmployee_RPTEntity IEntityBuilder<HREmployeeEvaluationReportForAllEmployee_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_EMPLOYEECODE = 38;
            const Int32 FLD_EMPLOYEEFULLNAME = 39;
            const Int32 FLD_JOINDATE = 40;
            const Int32 FLD_DEPARTMENTCODE = 41;
            const Int32 FLD_SERVICEAGEMONTH = 42;
            const Int32 FLD_MARKSOUTOF = 43;
            const Int32 FLD_RESULT = 44;
            const Int32 FLD_SALARYLEVEL = 45;

            HREmployeeEvaluationReportForAllEmployee_RPTEntity hREmployeeEvaluationReportForAllEmployee_RPTEntity = new HREmployeeEvaluationReportForAllEmployee_RPTEntity();

            hREmployeeEvaluationReportForAllEmployee_RPTEntity.EmployeeEvaluationReportID = reader.GetInt64(FLD_EMPLOYEEEVALUATIONREPORTID);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.SessionID = reader.GetInt64(FLD_SESSIONID);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title1 = reader.GetString(FLD_TITLE1);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title1Column1 = reader.GetString(FLD_TITLE1COLUMN1);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title1Column2 = reader.GetString(FLD_TITLE1COLUMN2);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title1Category1 = reader.GetString(FLD_TITLE1CATEGORY1);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title1Category1Column1Value = reader.GetString(FLD_TITLE1CATEGORY1COLUMN1VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title1Category1Column2Value = reader.GetString(FLD_TITLE1CATEGORY1COLUMN2VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title1Category2 = reader.GetString(FLD_TITLE1CATEGORY2);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title1Category2Column1Value = reader.GetString(FLD_TITLE1CATEGORY2COLUMN1VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title1Category2Column2Value = reader.GetString(FLD_TITLE1CATEGORY2COLUMN2VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title2 = reader.GetString(FLD_TITLE2);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title2Column1 = reader.GetString(FLD_TITLE2COLUMN1);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title2Category1 = reader.GetString(FLD_TITLE2CATEGORY1);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title2Category1Column1Value = reader.GetString(FLD_TITLE2CATEGORY1COLUMN1VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title2Category1Column2Value = reader.GetString(FLD_TITLE2CATEGORY1COLUMN2VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title2Category2 = reader.GetString(FLD_TITLE2CATEGORY2);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title2Category2Column1Value = reader.GetString(FLD_TITLE2CATEGORY2COLUMN1VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title2Category2Column2Value = reader.GetString(FLD_TITLE2CATEGORY2COLUMN2VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title3 = reader.GetString(FLD_TITLE3);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title3Column1 = reader.GetString(FLD_TITLE3COLUMN1);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title3Category1 = reader.GetString(FLD_TITLE3CATEGORY1);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title3Category1Column1Value = reader.GetString(FLD_TITLE3CATEGORY1COLUMN1VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title3Category1Column2Value = reader.GetString(FLD_TITLE3CATEGORY1COLUMN2VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title3Category2 = reader.GetString(FLD_TITLE3CATEGORY2);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title3Category2Column1Value = reader.GetString(FLD_TITLE3CATEGORY2COLUMN1VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title3Category2Column2Value = reader.GetString(FLD_TITLE3CATEGORY2COLUMN2VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.HRReportQuestion1Title = reader.GetString(FLD_HRREPORTQUESTION1TITLE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.HRReportQuestion1TitleValue = reader.GetString(FLD_HRREPORTQUESTION1TITLEVALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.SupervisorNumberValue = reader.GetDecimal(FLD_SUPERVISORNUMBERVALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.ScoreValue = reader.GetDecimal(FLD_SCOREVALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.DeducationValue = reader.GetDecimal(FLD_DEDUCATIONVALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.ActualScoreValue = reader.GetDecimal(FLD_ACTUALSCOREVALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title4 = reader.GetString(FLD_TITLE4);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.Title4Column1Value = reader.GetDecimal(FLD_TITLE4COLUMN1VALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.HRReportQuestion2Title = reader.GetString(FLD_HRREPORTQUESTION2TITLE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.HRReportQuestion2TitleValue = reader.GetString(FLD_HRREPORTQUESTION2TITLEVALUE);
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeEvaluationReportForAllEmployee_RPTEntity.EmployeeFullName = String.Empty; } else { hREmployeeEvaluationReportForAllEmployee_RPTEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_JOINDATE)) { hREmployeeEvaluationReportForAllEmployee_RPTEntity.JoinDate = null; } else { hREmployeeEvaluationReportForAllEmployee_RPTEntity.JoinDate = reader.GetDateTime(FLD_JOINDATE); }
            if (reader.IsDBNull(FLD_DEPARTMENTCODE)) { hREmployeeEvaluationReportForAllEmployee_RPTEntity.DepartmentCode = String.Empty; } else { hREmployeeEvaluationReportForAllEmployee_RPTEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE); }
            if (reader.IsDBNull(FLD_SERVICEAGEMONTH)) { hREmployeeEvaluationReportForAllEmployee_RPTEntity.ServiceAgeMonth = null; } else { hREmployeeEvaluationReportForAllEmployee_RPTEntity.ServiceAgeMonth = reader.GetInt32(FLD_SERVICEAGEMONTH); }
            if (reader.IsDBNull(FLD_MARKSOUTOF)) { hREmployeeEvaluationReportForAllEmployee_RPTEntity.MarksOutOf = null; } else { hREmployeeEvaluationReportForAllEmployee_RPTEntity.MarksOutOf = reader.GetInt32(FLD_MARKSOUTOF); }
            if (reader.IsDBNull(FLD_RESULT)) { hREmployeeEvaluationReportForAllEmployee_RPTEntity.Result = null; } else { hREmployeeEvaluationReportForAllEmployee_RPTEntity.Result = reader.GetInt32(FLD_RESULT); }
            hREmployeeEvaluationReportForAllEmployee_RPTEntity.SalaryLevel = reader.GetInt64(FLD_SALARYLEVEL);

            return hREmployeeEvaluationReportForAllEmployee_RPTEntity;
        }
    }
}
