// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




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
    public sealed partial class PRMPreBOQFloorDetailFacade : IPRMPreBOQFloorDetailFacade
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

        public PRMPreBOQFloorDetailFacade()
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

        ~PRMPreBOQFloorDetailFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMPreBOQFloorDetailFacade.Add(PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQFloorDetailDataAccess().Add(pRMPreBOQFloorDetailEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMPreBOQFloorDetailFacade.Update(PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQFloorDetailDataAccess().Update(pRMPreBOQFloorDetailEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMPreBOQFloorDetailFacade.Delete(PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQFloorDetailDataAccess().Delete(pRMPreBOQFloorDetailEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMPreBOQFloorDetailFacade.Add(IList<PRMPreBOQFloorDetailEntity> pRMPreBOQFloorDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQFloorDetailDataAccess().Add(pRMPreBOQFloorDetailEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMPreBOQFloorDetailFacade.Update(IList<PRMPreBOQFloorDetailEntity> pRMPreBOQFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQFloorDetailDataAccess().Update(pRMPreBOQFloorDetailEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMPreBOQFloorDetailFacade.Delete(IList<PRMPreBOQFloorDetailEntity> pRMPreBOQFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQFloorDetailDataAccess().Delete(pRMPreBOQFloorDetailEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMPreBOQFloorDetailEntity> IPRMPreBOQFloorDetailFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMPreBOQFloorDetailDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMPreBOQFloorDetailFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMPreBOQFloorDetailDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMPreBOQFloorDetailEntity IPRMPreBOQFloorDetailFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQFloorDetailID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMPreBOQFloorDetailDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
