// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2013, 02:22:23




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
    public sealed partial class HREmployeeSalaryDisbursementBank_RPTFacade : IHREmployeeSalaryDisbursementBank_RPTFacade
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

        public HREmployeeSalaryDisbursementBank_RPTFacade()
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

        ~HREmployeeSalaryDisbursementBank_RPTFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Get

        [OperationContract]
        IList<HREmployeeSalaryDisbursementBank_RPTEntity> IHREmployeeSalaryDisbursementBank_RPTFacade.GetIL(Int64 salarySessionID, Int64 fromLevel, Int64 toLevel)
        {
            return DataAccessFactory.CreateHREmployeeSalaryDisbursementBank_RPTDataAccess().GetIL(salarySessionID, fromLevel, toLevel);
        }

        [OperationContract]
        DataTable IHREmployeeSalaryDisbursementBank_RPTFacade.GetDT(Int64 salarySessionID, Int64 fromLevel, Int64 toLevel)
        {
            return DataAccessFactory.CreateHREmployeeSalaryDisbursementBank_RPTDataAccess().GetDT(salarySessionID, fromLevel, toLevel);
        }

        #endregion Get


        #endregion
    }
}
