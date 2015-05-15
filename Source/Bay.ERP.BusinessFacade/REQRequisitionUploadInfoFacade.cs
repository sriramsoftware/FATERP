// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Nov-2013, 09:51:38




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
    public sealed partial class REQRequisitionUploadInfoFacade : IREQRequisitionUploadInfoFacade
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

        public REQRequisitionUploadInfoFacade()
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

        ~REQRequisitionUploadInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IREQRequisitionUploadInfoFacade.Add(REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionUploadInfoDataAccess().Add(rEQRequisitionUploadInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IREQRequisitionUploadInfoFacade.Update(REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionUploadInfoDataAccess().Update(rEQRequisitionUploadInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IREQRequisitionUploadInfoFacade.Delete(REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionUploadInfoDataAccess().Delete(rEQRequisitionUploadInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IREQRequisitionUploadInfoFacade.Add(IList<REQRequisitionUploadInfoEntity> rEQRequisitionUploadInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionUploadInfoDataAccess().Add(rEQRequisitionUploadInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IREQRequisitionUploadInfoFacade.Update(IList<REQRequisitionUploadInfoEntity> rEQRequisitionUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionUploadInfoDataAccess().Update(rEQRequisitionUploadInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IREQRequisitionUploadInfoFacade.Delete(IList<REQRequisitionUploadInfoEntity> rEQRequisitionUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionUploadInfoDataAccess().Delete(rEQRequisitionUploadInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<REQRequisitionUploadInfoEntity> IREQRequisitionUploadInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateREQRequisitionUploadInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IREQRequisitionUploadInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateREQRequisitionUploadInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        REQRequisitionUploadInfoEntity IREQRequisitionUploadInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionUploadInfoEntity.FLD_NAME_RequisitionUploadInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateREQRequisitionUploadInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
