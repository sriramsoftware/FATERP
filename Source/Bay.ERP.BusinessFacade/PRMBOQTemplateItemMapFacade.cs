// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    public sealed partial class PRMBOQTemplateItemMapFacade : IPRMBOQTemplateItemMapFacade
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

        public PRMBOQTemplateItemMapFacade()
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

        ~PRMBOQTemplateItemMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMBOQTemplateItemMapFacade.Add(PRMBOQTemplateItemMapEntity pRMBOQTemplateItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMBOQTemplateItemMapDataAccess().Add(pRMBOQTemplateItemMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMBOQTemplateItemMapFacade.Update(PRMBOQTemplateItemMapEntity pRMBOQTemplateItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMBOQTemplateItemMapDataAccess().Update(pRMBOQTemplateItemMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMBOQTemplateItemMapFacade.Delete(PRMBOQTemplateItemMapEntity pRMBOQTemplateItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMBOQTemplateItemMapDataAccess().Delete(pRMBOQTemplateItemMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMBOQTemplateItemMapFacade.Add(IList<PRMBOQTemplateItemMapEntity> pRMBOQTemplateItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMBOQTemplateItemMapDataAccess().Add(pRMBOQTemplateItemMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMBOQTemplateItemMapFacade.Update(IList<PRMBOQTemplateItemMapEntity> pRMBOQTemplateItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMBOQTemplateItemMapDataAccess().Update(pRMBOQTemplateItemMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMBOQTemplateItemMapFacade.Delete(IList<PRMBOQTemplateItemMapEntity> pRMBOQTemplateItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMBOQTemplateItemMapDataAccess().Delete(pRMBOQTemplateItemMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMBOQTemplateItemMapEntity> IPRMBOQTemplateItemMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMBOQTemplateItemMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMBOQTemplateItemMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMBOQTemplateItemMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMBOQTemplateItemMapEntity IPRMBOQTemplateItemMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQTemplateItemMapEntity.FLD_NAME_BOQTemplateItemMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMBOQTemplateItemMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
