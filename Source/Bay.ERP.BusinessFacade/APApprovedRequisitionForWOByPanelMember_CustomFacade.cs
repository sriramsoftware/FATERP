// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jan-2013, 11:24:12




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
    public sealed partial class APApprovedRequisitionForWOByPanelMember_CustomFacade : IAPApprovedRequisitionForWOByPanelMember_CustomFacade
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

        public APApprovedRequisitionForWOByPanelMember_CustomFacade()
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

        ~APApprovedRequisitionForWOByPanelMember_CustomFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Get

        [OperationContract]
        IList<APApprovedRequisitionForWOByPanelMember_CustomEntity> IAPApprovedRequisitionForWOByPanelMember_CustomFacade.GetIL(Int64 employeeID)
        {
            return DataAccessFactory.CreateAPApprovedRequisitionForWOByPanelMember_CustomDataAccess().GetIL(employeeID);
        }

        [OperationContract]
        DataTable IAPApprovedRequisitionForWOByPanelMember_CustomFacade.GetDT(Int64 employeeID)
        {
            return DataAccessFactory.CreateAPApprovedRequisitionForWOByPanelMember_CustomDataAccess().GetDT(employeeID);
        }

        #endregion Get


        #endregion
    }
}
