// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 11:02:33




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
    public sealed partial class PRMSupplierItemCategoryMapFacade : IPRMSupplierItemCategoryMapFacade
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

        public PRMSupplierItemCategoryMapFacade()
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

        ~PRMSupplierItemCategoryMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMSupplierItemCategoryMapFacade.Add(PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierItemCategoryMapDataAccess().Add(pRMSupplierItemCategoryMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMSupplierItemCategoryMapFacade.Update(PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierItemCategoryMapDataAccess().Update(pRMSupplierItemCategoryMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMSupplierItemCategoryMapFacade.Delete(PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierItemCategoryMapDataAccess().Delete(pRMSupplierItemCategoryMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMSupplierItemCategoryMapFacade.Add(IList<PRMSupplierItemCategoryMapEntity> pRMSupplierItemCategoryMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierItemCategoryMapDataAccess().Add(pRMSupplierItemCategoryMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMSupplierItemCategoryMapFacade.Update(IList<PRMSupplierItemCategoryMapEntity> pRMSupplierItemCategoryMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierItemCategoryMapDataAccess().Update(pRMSupplierItemCategoryMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMSupplierItemCategoryMapFacade.Delete(IList<PRMSupplierItemCategoryMapEntity> pRMSupplierItemCategoryMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierItemCategoryMapDataAccess().Delete(pRMSupplierItemCategoryMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMSupplierItemCategoryMapEntity> IPRMSupplierItemCategoryMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMSupplierItemCategoryMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMSupplierItemCategoryMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMSupplierItemCategoryMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMSupplierItemCategoryMapEntity IPRMSupplierItemCategoryMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemCategoryMapEntity.FLD_NAME_SupplierItemCategoryMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMSupplierItemCategoryMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
