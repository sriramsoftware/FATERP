// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Aug-2013, 05:21:45




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
    public sealed partial class PRMWorkOrderItemFloorDetailFacade : IPRMWorkOrderItemFloorDetailFacade
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

        public PRMWorkOrderItemFloorDetailFacade()
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

        ~PRMWorkOrderItemFloorDetailFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMWorkOrderItemFloorDetailFacade.Add(PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemFloorDetailDataAccess().Add(pRMWorkOrderItemFloorDetailEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMWorkOrderItemFloorDetailFacade.Update(PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemFloorDetailDataAccess().Update(pRMWorkOrderItemFloorDetailEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMWorkOrderItemFloorDetailFacade.Delete(PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemFloorDetailDataAccess().Delete(pRMWorkOrderItemFloorDetailEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMWorkOrderItemFloorDetailFacade.Add(IList<PRMWorkOrderItemFloorDetailEntity> pRMWorkOrderItemFloorDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemFloorDetailDataAccess().Add(pRMWorkOrderItemFloorDetailEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMWorkOrderItemFloorDetailFacade.Update(IList<PRMWorkOrderItemFloorDetailEntity> pRMWorkOrderItemFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemFloorDetailDataAccess().Update(pRMWorkOrderItemFloorDetailEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMWorkOrderItemFloorDetailFacade.Delete(IList<PRMWorkOrderItemFloorDetailEntity> pRMWorkOrderItemFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemFloorDetailDataAccess().Delete(pRMWorkOrderItemFloorDetailEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMWorkOrderItemFloorDetailEntity> IPRMWorkOrderItemFloorDetailFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemFloorDetailDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMWorkOrderItemFloorDetailFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemFloorDetailDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMWorkOrderItemFloorDetailEntity IPRMWorkOrderItemFloorDetailFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemFloorDetailEntity.FLD_NAME_WorkOrderItemFloorDetailID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMWorkOrderItemFloorDetailDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
