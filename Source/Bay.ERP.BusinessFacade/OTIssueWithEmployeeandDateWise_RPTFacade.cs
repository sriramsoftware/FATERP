// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Sep-2013, 04:16:48




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
    public sealed partial class OTIssueWithEmployeeandDateWise_RPTFacade : IOTIssueWithEmployeeandDateWise_RPTFacade
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

        public OTIssueWithEmployeeandDateWise_RPTFacade()
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

        ~OTIssueWithEmployeeandDateWise_RPTFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Get

        [OperationContract]
        IList<OTIssueWithEmployeeandDateWise_RPTEntity> IOTIssueWithEmployeeandDateWise_RPTFacade.GetIL(DateTime fromDate, DateTime toDate, Int64 employeeID)
        {
            return DataAccessFactory.CreateOTIssueWithEmployeeandDateWise_RPTDataAccess().GetIL(fromDate, toDate, employeeID);
        }

        [OperationContract]
        DataTable IOTIssueWithEmployeeandDateWise_RPTFacade.GetDT(DateTime fromDate, DateTime toDate, Int64 employeeID)
        {
            return DataAccessFactory.CreateOTIssueWithEmployeeandDateWise_RPTDataAccess().GetDT(fromDate, toDate, employeeID);
        }

        #endregion Get


        #endregion
    }
}
