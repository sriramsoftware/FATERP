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
    public sealed partial class CMMDBillFloorDetailCategoryFacade : ICMMDBillFloorDetailCategoryFacade
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

        public CMMDBillFloorDetailCategoryFacade()
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

        ~CMMDBillFloorDetailCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMMDBillFloorDetailCategoryFacade.Add(CMMDBillFloorDetailCategoryEntity cMMDBillFloorDetailCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMMDBillFloorDetailCategoryDataAccess().Add(cMMDBillFloorDetailCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMMDBillFloorDetailCategoryFacade.Update(CMMDBillFloorDetailCategoryEntity cMMDBillFloorDetailCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMMDBillFloorDetailCategoryDataAccess().Update(cMMDBillFloorDetailCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMMDBillFloorDetailCategoryFacade.Delete(CMMDBillFloorDetailCategoryEntity cMMDBillFloorDetailCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMMDBillFloorDetailCategoryDataAccess().Delete(cMMDBillFloorDetailCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMMDBillFloorDetailCategoryFacade.Add(IList<CMMDBillFloorDetailCategoryEntity> cMMDBillFloorDetailCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMMDBillFloorDetailCategoryDataAccess().Add(cMMDBillFloorDetailCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMMDBillFloorDetailCategoryFacade.Update(IList<CMMDBillFloorDetailCategoryEntity> cMMDBillFloorDetailCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMMDBillFloorDetailCategoryDataAccess().Update(cMMDBillFloorDetailCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMMDBillFloorDetailCategoryFacade.Delete(IList<CMMDBillFloorDetailCategoryEntity> cMMDBillFloorDetailCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMMDBillFloorDetailCategoryDataAccess().Delete(cMMDBillFloorDetailCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMMDBillFloorDetailCategoryEntity> ICMMDBillFloorDetailCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMMDBillFloorDetailCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMMDBillFloorDetailCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMMDBillFloorDetailCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMMDBillFloorDetailCategoryEntity ICMMDBillFloorDetailCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMMDBillFloorDetailCategoryEntity.FLD_NAME_BillFloorDetailCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMMDBillFloorDetailCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
