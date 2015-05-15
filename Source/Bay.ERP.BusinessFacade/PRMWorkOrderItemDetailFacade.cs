// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2012, 04:57:13




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
    public sealed partial class PRMWorkOrderItemDetailFacade : IPRMWorkOrderItemDetailFacade
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

        public PRMWorkOrderItemDetailFacade()
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

        ~PRMWorkOrderItemDetailFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMWorkOrderItemDetailFacade.Add(PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemDetailDataAccess().Add(pRMWorkOrderItemDetailEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMWorkOrderItemDetailFacade.Update(PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemDetailDataAccess().Update(pRMWorkOrderItemDetailEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMWorkOrderItemDetailFacade.Delete(PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemDetailDataAccess().Delete(pRMWorkOrderItemDetailEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMWorkOrderItemDetailFacade.Add(IList<PRMWorkOrderItemDetailEntity> pRMWorkOrderItemDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemDetailDataAccess().Add(pRMWorkOrderItemDetailEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMWorkOrderItemDetailFacade.Update(IList<PRMWorkOrderItemDetailEntity> pRMWorkOrderItemDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemDetailDataAccess().Update(pRMWorkOrderItemDetailEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMWorkOrderItemDetailFacade.Delete(IList<PRMWorkOrderItemDetailEntity> pRMWorkOrderItemDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemDetailDataAccess().Delete(pRMWorkOrderItemDetailEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMWorkOrderItemDetailEntity> IPRMWorkOrderItemDetailFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemDetailDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMWorkOrderItemDetailFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemDetailDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMWorkOrderItemDetailEntity IPRMWorkOrderItemDetailFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemDetailEntity.FLD_NAME_WorkOrderItemDetailID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMWorkOrderItemDetailDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
