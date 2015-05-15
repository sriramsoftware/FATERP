// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2013, 03:32:47




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
    public sealed partial class MDFloorUnitLocationCategoryFacade : IMDFloorUnitLocationCategoryFacade
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

        public MDFloorUnitLocationCategoryFacade()
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

        ~MDFloorUnitLocationCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDFloorUnitLocationCategoryFacade.Add(MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDFloorUnitLocationCategoryDataAccess().Add(mDFloorUnitLocationCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDFloorUnitLocationCategoryFacade.Update(MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDFloorUnitLocationCategoryDataAccess().Update(mDFloorUnitLocationCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDFloorUnitLocationCategoryFacade.Delete(MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDFloorUnitLocationCategoryDataAccess().Delete(mDFloorUnitLocationCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDFloorUnitLocationCategoryFacade.Add(IList<MDFloorUnitLocationCategoryEntity> mDFloorUnitLocationCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDFloorUnitLocationCategoryDataAccess().Add(mDFloorUnitLocationCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDFloorUnitLocationCategoryFacade.Update(IList<MDFloorUnitLocationCategoryEntity> mDFloorUnitLocationCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDFloorUnitLocationCategoryDataAccess().Update(mDFloorUnitLocationCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDFloorUnitLocationCategoryFacade.Delete(IList<MDFloorUnitLocationCategoryEntity> mDFloorUnitLocationCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDFloorUnitLocationCategoryDataAccess().Delete(mDFloorUnitLocationCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDFloorUnitLocationCategoryEntity> IMDFloorUnitLocationCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDFloorUnitLocationCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDFloorUnitLocationCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDFloorUnitLocationCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDFloorUnitLocationCategoryEntity IMDFloorUnitLocationCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDFloorUnitLocationCategoryEntity.FLD_NAME_FloorUnitLocationCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDFloorUnitLocationCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
