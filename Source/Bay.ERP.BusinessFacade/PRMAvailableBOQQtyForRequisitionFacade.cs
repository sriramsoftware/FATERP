// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Jul-2013, 05:44:25




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
    public sealed partial class PRMAvailableBOQQtyForRequisitionFacade : IPRMAvailableBOQQtyForRequisitionFacade
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

        public PRMAvailableBOQQtyForRequisitionFacade()
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

        ~PRMAvailableBOQQtyForRequisitionFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMAvailableBOQQtyForRequisitionFacade.Add(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMAvailableBOQQtyForRequisitionDataAccess().Add(pRMAvailableBOQQtyForRequisitionEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMAvailableBOQQtyForRequisitionFacade.Update(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMAvailableBOQQtyForRequisitionDataAccess().Update(pRMAvailableBOQQtyForRequisitionEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMAvailableBOQQtyForRequisitionFacade.Delete(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMAvailableBOQQtyForRequisitionDataAccess().Delete(pRMAvailableBOQQtyForRequisitionEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMAvailableBOQQtyForRequisitionFacade.Add(IList<PRMAvailableBOQQtyForRequisitionEntity> pRMAvailableBOQQtyForRequisitionEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMAvailableBOQQtyForRequisitionDataAccess().Add(pRMAvailableBOQQtyForRequisitionEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMAvailableBOQQtyForRequisitionFacade.Update(IList<PRMAvailableBOQQtyForRequisitionEntity> pRMAvailableBOQQtyForRequisitionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMAvailableBOQQtyForRequisitionDataAccess().Update(pRMAvailableBOQQtyForRequisitionEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMAvailableBOQQtyForRequisitionFacade.Delete(IList<PRMAvailableBOQQtyForRequisitionEntity> pRMAvailableBOQQtyForRequisitionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMAvailableBOQQtyForRequisitionDataAccess().Delete(pRMAvailableBOQQtyForRequisitionEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMAvailableBOQQtyForRequisitionEntity> IPRMAvailableBOQQtyForRequisitionFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMAvailableBOQQtyForRequisitionDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMAvailableBOQQtyForRequisitionFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMAvailableBOQQtyForRequisitionDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMAvailableBOQQtyForRequisitionEntity IPRMAvailableBOQQtyForRequisitionFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMAvailableBOQQtyForRequisitionEntity.FLD_NAME_AvailableBOQQtyForRequisitionID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMAvailableBOQQtyForRequisitionDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
