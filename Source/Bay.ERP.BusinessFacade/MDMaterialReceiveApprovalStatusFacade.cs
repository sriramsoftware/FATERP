// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 11:12:01




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
    public sealed partial class MDMaterialReceiveApprovalStatusFacade : IMDMaterialReceiveApprovalStatusFacade
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

        public MDMaterialReceiveApprovalStatusFacade()
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

        ~MDMaterialReceiveApprovalStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDMaterialReceiveApprovalStatusFacade.Add(MDMaterialReceiveApprovalStatusEntity mDMaterialReceiveApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDMaterialReceiveApprovalStatusDataAccess().Add(mDMaterialReceiveApprovalStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDMaterialReceiveApprovalStatusFacade.Update(MDMaterialReceiveApprovalStatusEntity mDMaterialReceiveApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDMaterialReceiveApprovalStatusDataAccess().Update(mDMaterialReceiveApprovalStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDMaterialReceiveApprovalStatusFacade.Delete(MDMaterialReceiveApprovalStatusEntity mDMaterialReceiveApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDMaterialReceiveApprovalStatusDataAccess().Delete(mDMaterialReceiveApprovalStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDMaterialReceiveApprovalStatusFacade.Add(IList<MDMaterialReceiveApprovalStatusEntity> mDMaterialReceiveApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDMaterialReceiveApprovalStatusDataAccess().Add(mDMaterialReceiveApprovalStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDMaterialReceiveApprovalStatusFacade.Update(IList<MDMaterialReceiveApprovalStatusEntity> mDMaterialReceiveApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDMaterialReceiveApprovalStatusDataAccess().Update(mDMaterialReceiveApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDMaterialReceiveApprovalStatusFacade.Delete(IList<MDMaterialReceiveApprovalStatusEntity> mDMaterialReceiveApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDMaterialReceiveApprovalStatusDataAccess().Delete(mDMaterialReceiveApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDMaterialReceiveApprovalStatusEntity> IMDMaterialReceiveApprovalStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDMaterialReceiveApprovalStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDMaterialReceiveApprovalStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDMaterialReceiveApprovalStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDMaterialReceiveApprovalStatusEntity IMDMaterialReceiveApprovalStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDMaterialReceiveApprovalStatusEntity.FLD_NAME_MaterialReceiveApprovalStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDMaterialReceiveApprovalStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
