// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:49:00




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
    public sealed partial class APMemberFeedbackRemarks_DetailedFacade : IAPMemberFeedbackRemarks_DetailedFacade
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

        public APMemberFeedbackRemarks_DetailedFacade()
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

        ~APMemberFeedbackRemarks_DetailedFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Get

        [OperationContract]
        IList<APMemberFeedbackRemarks_DetailedEntity> IAPMemberFeedbackRemarks_DetailedFacade.GetIL(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression)
        {
            return DataAccessFactory.CreateAPMemberFeedbackRemarks_DetailedDataAccess().GetIL(pageSize, currentPage, sortExpression, filterExpression);
        }

        [OperationContract]
        DataTable IAPMemberFeedbackRemarks_DetailedFacade.GetDT(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression)
        {
            return DataAccessFactory.CreateAPMemberFeedbackRemarks_DetailedDataAccess().GetDT(pageSize, currentPage, sortExpression, filterExpression);
        }

        #endregion Get


        #endregion
    }
}
