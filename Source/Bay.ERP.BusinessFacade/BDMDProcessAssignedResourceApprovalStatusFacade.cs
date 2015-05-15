// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




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
    public sealed partial class BDMDProcessAssignedResourceApprovalStatusFacade : IBDMDProcessAssignedResourceApprovalStatusFacade
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

        public BDMDProcessAssignedResourceApprovalStatusFacade()
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

        ~BDMDProcessAssignedResourceApprovalStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDMDProcessAssignedResourceApprovalStatusFacade.Add(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDProcessAssignedResourceApprovalStatusDataAccess().Add(bDMDProcessAssignedResourceApprovalStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDMDProcessAssignedResourceApprovalStatusFacade.Update(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDProcessAssignedResourceApprovalStatusDataAccess().Update(bDMDProcessAssignedResourceApprovalStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDMDProcessAssignedResourceApprovalStatusFacade.Delete(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDProcessAssignedResourceApprovalStatusDataAccess().Delete(bDMDProcessAssignedResourceApprovalStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDMDProcessAssignedResourceApprovalStatusFacade.Add(IList<BDMDProcessAssignedResourceApprovalStatusEntity> bDMDProcessAssignedResourceApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDProcessAssignedResourceApprovalStatusDataAccess().Add(bDMDProcessAssignedResourceApprovalStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDMDProcessAssignedResourceApprovalStatusFacade.Update(IList<BDMDProcessAssignedResourceApprovalStatusEntity> bDMDProcessAssignedResourceApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDProcessAssignedResourceApprovalStatusDataAccess().Update(bDMDProcessAssignedResourceApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDMDProcessAssignedResourceApprovalStatusFacade.Delete(IList<BDMDProcessAssignedResourceApprovalStatusEntity> bDMDProcessAssignedResourceApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDProcessAssignedResourceApprovalStatusDataAccess().Delete(bDMDProcessAssignedResourceApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDMDProcessAssignedResourceApprovalStatusEntity> IBDMDProcessAssignedResourceApprovalStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDMDProcessAssignedResourceApprovalStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDMDProcessAssignedResourceApprovalStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDMDProcessAssignedResourceApprovalStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDMDProcessAssignedResourceApprovalStatusEntity IBDMDProcessAssignedResourceApprovalStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDMDProcessAssignedResourceApprovalStatusEntity.FLD_NAME_ProcessAssignedResourceApprovalStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDMDProcessAssignedResourceApprovalStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
