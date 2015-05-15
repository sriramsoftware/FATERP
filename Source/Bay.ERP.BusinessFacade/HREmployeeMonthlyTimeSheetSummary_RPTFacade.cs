// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2014, 01:58:57




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Diagnostics;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.DataAccess;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class HREmployeeMonthlyTimeSheetSummary_RPTFacade : IHREmployeeMonthlyTimeSheetSummary_RPTFacade
    {

        #region Instance Variables

        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public HREmployeeMonthlyTimeSheetSummary_RPTFacade()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~HREmployeeMonthlyTimeSheetSummary_RPTFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Get

        [OperationContract]
        IList<HREmployeeMonthlyTimeSheetSummary_RPTEntity> IHREmployeeMonthlyTimeSheetSummary_RPTFacade.GetIL(Int64 salarySessionID, Int64 from, Int64 to, Int64 other)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetSummary_RPTDataAccess().GetIL(salarySessionID, from, to, other);
        }

        [OperationContract]
        DataTable IHREmployeeMonthlyTimeSheetSummary_RPTFacade.GetDT(Int64 salarySessionID, Int64 from, Int64 to, Int64 other)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetSummary_RPTDataAccess().GetDT(salarySessionID, from, to, other);
        }

        #endregion Get


        #endregion
    }
}
