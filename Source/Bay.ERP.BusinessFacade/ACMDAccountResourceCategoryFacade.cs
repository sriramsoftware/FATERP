// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




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
    public sealed partial class ACMDAccountResourceCategoryFacade : IACMDAccountResourceCategoryFacade
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

        public ACMDAccountResourceCategoryFacade()
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

        ~ACMDAccountResourceCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACMDAccountResourceCategoryFacade.Add(ACMDAccountResourceCategoryEntity aCMDAccountResourceCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDAccountResourceCategoryDataAccess().Add(aCMDAccountResourceCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDAccountResourceCategoryFacade.Update(ACMDAccountResourceCategoryEntity aCMDAccountResourceCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDAccountResourceCategoryDataAccess().Update(aCMDAccountResourceCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDAccountResourceCategoryFacade.Delete(ACMDAccountResourceCategoryEntity aCMDAccountResourceCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDAccountResourceCategoryDataAccess().Delete(aCMDAccountResourceCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACMDAccountResourceCategoryFacade.Add(IList<ACMDAccountResourceCategoryEntity> aCMDAccountResourceCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDAccountResourceCategoryDataAccess().Add(aCMDAccountResourceCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDAccountResourceCategoryFacade.Update(IList<ACMDAccountResourceCategoryEntity> aCMDAccountResourceCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDAccountResourceCategoryDataAccess().Update(aCMDAccountResourceCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDAccountResourceCategoryFacade.Delete(IList<ACMDAccountResourceCategoryEntity> aCMDAccountResourceCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDAccountResourceCategoryDataAccess().Delete(aCMDAccountResourceCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACMDAccountResourceCategoryEntity> IACMDAccountResourceCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDAccountResourceCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACMDAccountResourceCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDAccountResourceCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACMDAccountResourceCategoryEntity IACMDAccountResourceCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDAccountResourceCategoryEntity.FLD_NAME_AccountResourceCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACMDAccountResourceCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
