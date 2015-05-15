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
    public sealed partial class CMBillFloorDetailFacade : ICMBillFloorDetailFacade
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

        public CMBillFloorDetailFacade()
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

        ~CMBillFloorDetailFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMBillFloorDetailFacade.Add(CMBillFloorDetailEntity cMBillFloorDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillFloorDetailDataAccess().Add(cMBillFloorDetailEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMBillFloorDetailFacade.Update(CMBillFloorDetailEntity cMBillFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillFloorDetailDataAccess().Update(cMBillFloorDetailEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMBillFloorDetailFacade.Delete(CMBillFloorDetailEntity cMBillFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillFloorDetailDataAccess().Delete(cMBillFloorDetailEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMBillFloorDetailFacade.Add(IList<CMBillFloorDetailEntity> cMBillFloorDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillFloorDetailDataAccess().Add(cMBillFloorDetailEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMBillFloorDetailFacade.Update(IList<CMBillFloorDetailEntity> cMBillFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillFloorDetailDataAccess().Update(cMBillFloorDetailEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMBillFloorDetailFacade.Delete(IList<CMBillFloorDetailEntity> cMBillFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillFloorDetailDataAccess().Delete(cMBillFloorDetailEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMBillFloorDetailEntity> ICMBillFloorDetailFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMBillFloorDetailDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMBillFloorDetailFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMBillFloorDetailDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMBillFloorDetailEntity ICMBillFloorDetailFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillFloorDetailEntity.FLD_NAME_BillFloorDetailID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMBillFloorDetailDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
