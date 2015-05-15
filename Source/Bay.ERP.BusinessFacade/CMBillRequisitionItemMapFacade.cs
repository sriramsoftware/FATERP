// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Jan-2013, 11:55:33




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
    public sealed partial class CMBillRequisitionItemMapFacade : ICMBillRequisitionItemMapFacade
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

        public CMBillRequisitionItemMapFacade()
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

        ~CMBillRequisitionItemMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMBillRequisitionItemMapFacade.Add(CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillRequisitionItemMapDataAccess().Add(cMBillRequisitionItemMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMBillRequisitionItemMapFacade.Update(CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillRequisitionItemMapDataAccess().Update(cMBillRequisitionItemMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMBillRequisitionItemMapFacade.Delete(CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillRequisitionItemMapDataAccess().Delete(cMBillRequisitionItemMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMBillRequisitionItemMapFacade.Add(IList<CMBillRequisitionItemMapEntity> cMBillRequisitionItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillRequisitionItemMapDataAccess().Add(cMBillRequisitionItemMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMBillRequisitionItemMapFacade.Update(IList<CMBillRequisitionItemMapEntity> cMBillRequisitionItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillRequisitionItemMapDataAccess().Update(cMBillRequisitionItemMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMBillRequisitionItemMapFacade.Delete(IList<CMBillRequisitionItemMapEntity> cMBillRequisitionItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillRequisitionItemMapDataAccess().Delete(cMBillRequisitionItemMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMBillRequisitionItemMapEntity> ICMBillRequisitionItemMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMBillRequisitionItemMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMBillRequisitionItemMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMBillRequisitionItemMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMBillRequisitionItemMapEntity ICMBillRequisitionItemMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillRequisitionItemMapEntity.FLD_NAME_BillRequisitionItemMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMBillRequisitionItemMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
