// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2013, 02:31:14




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
    public sealed partial class PRMWorkOrderSingleClickFromRequisition_CustomFacade : IPRMWorkOrderSingleClickFromRequisition_CustomFacade
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

        public PRMWorkOrderSingleClickFromRequisition_CustomFacade()
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

        ~PRMWorkOrderSingleClickFromRequisition_CustomFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Get

        [OperationContract]
        IList<PRMWorkOrderSingleClickFromRequisition_CustomEntity> IPRMWorkOrderSingleClickFromRequisition_CustomFacade.GetIL(Int64 requisitionID, Int64 preparedByMemberID)
        {
            return DataAccessFactory.CreatePRMWorkOrderSingleClickFromRequisition_CustomDataAccess().GetIL(requisitionID, preparedByMemberID);
        }

        [OperationContract]
        DataTable IPRMWorkOrderSingleClickFromRequisition_CustomFacade.GetDT(Int64 requisitionID, Int64 preparedByMemberID)
        {
            return DataAccessFactory.CreatePRMWorkOrderSingleClickFromRequisition_CustomDataAccess().GetDT(requisitionID, preparedByMemberID);
        }

        #endregion Get


        #endregion
    }
}
