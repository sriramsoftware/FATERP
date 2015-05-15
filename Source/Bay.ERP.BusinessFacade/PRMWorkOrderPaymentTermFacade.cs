// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




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
    public sealed partial class PRMWorkOrderPaymentTermFacade : IPRMWorkOrderPaymentTermFacade
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

        public PRMWorkOrderPaymentTermFacade()
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

        ~PRMWorkOrderPaymentTermFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMWorkOrderPaymentTermFacade.Add(PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderPaymentTermDataAccess().Add(pRMWorkOrderPaymentTermEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMWorkOrderPaymentTermFacade.Update(PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderPaymentTermDataAccess().Update(pRMWorkOrderPaymentTermEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMWorkOrderPaymentTermFacade.Delete(PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderPaymentTermDataAccess().Delete(pRMWorkOrderPaymentTermEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMWorkOrderPaymentTermFacade.Add(IList<PRMWorkOrderPaymentTermEntity> pRMWorkOrderPaymentTermEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderPaymentTermDataAccess().Add(pRMWorkOrderPaymentTermEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMWorkOrderPaymentTermFacade.Update(IList<PRMWorkOrderPaymentTermEntity> pRMWorkOrderPaymentTermEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderPaymentTermDataAccess().Update(pRMWorkOrderPaymentTermEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMWorkOrderPaymentTermFacade.Delete(IList<PRMWorkOrderPaymentTermEntity> pRMWorkOrderPaymentTermEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderPaymentTermDataAccess().Delete(pRMWorkOrderPaymentTermEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMWorkOrderPaymentTermEntity> IPRMWorkOrderPaymentTermFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMWorkOrderPaymentTermDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMWorkOrderPaymentTermFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMWorkOrderPaymentTermDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMWorkOrderPaymentTermEntity IPRMWorkOrderPaymentTermFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderPaymentTermEntity.FLD_NAME_WorkOrderPaymentTermID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMWorkOrderPaymentTermDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
