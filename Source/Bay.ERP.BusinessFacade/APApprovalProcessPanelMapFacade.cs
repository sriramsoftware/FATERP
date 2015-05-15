// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jun-2013, 05:57:56




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
using Bay.ERP.Common.Helper;

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class APApprovalProcessPanelMapFacade : IAPApprovalProcessPanelMapFacade
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

        public APApprovalProcessPanelMapFacade()
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

        ~APApprovalProcessPanelMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IAPApprovalProcessPanelMapFacade.Add(APApprovalProcessPanelMapEntity aPApprovalProcessPanelMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPApprovalProcessPanelMapDataAccess().Add(aPApprovalProcessPanelMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IAPApprovalProcessPanelMapFacade.Update(APApprovalProcessPanelMapEntity aPApprovalProcessPanelMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPApprovalProcessPanelMapDataAccess().Update(aPApprovalProcessPanelMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IAPApprovalProcessPanelMapFacade.Delete(APApprovalProcessPanelMapEntity aPApprovalProcessPanelMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPApprovalProcessPanelMapDataAccess().Delete(aPApprovalProcessPanelMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IAPApprovalProcessPanelMapFacade.Add(IList<APApprovalProcessPanelMapEntity> aPApprovalProcessPanelMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPApprovalProcessPanelMapDataAccess().Add(aPApprovalProcessPanelMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IAPApprovalProcessPanelMapFacade.Update(IList<APApprovalProcessPanelMapEntity> aPApprovalProcessPanelMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPApprovalProcessPanelMapDataAccess().Update(aPApprovalProcessPanelMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IAPApprovalProcessPanelMapFacade.Delete(IList<APApprovalProcessPanelMapEntity> aPApprovalProcessPanelMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPApprovalProcessPanelMapDataAccess().Delete(aPApprovalProcessPanelMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<APApprovalProcessPanelMapEntity> IAPApprovalProcessPanelMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateAPApprovalProcessPanelMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IAPApprovalProcessPanelMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateAPApprovalProcessPanelMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        APApprovalProcessPanelMapEntity IAPApprovalProcessPanelMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessPanelMapEntity.FLD_NAME_ApprovalProcessPanelMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateAPApprovalProcessPanelMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
