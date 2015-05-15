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
    public sealed partial class BDTaskTemplateItemMapFacade : IBDTaskTemplateItemMapFacade
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

        public BDTaskTemplateItemMapFacade()
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

        ~BDTaskTemplateItemMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDTaskTemplateItemMapFacade.Add(BDTaskTemplateItemMapEntity bDTaskTemplateItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDTaskTemplateItemMapDataAccess().Add(bDTaskTemplateItemMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDTaskTemplateItemMapFacade.Update(BDTaskTemplateItemMapEntity bDTaskTemplateItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDTaskTemplateItemMapDataAccess().Update(bDTaskTemplateItemMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDTaskTemplateItemMapFacade.Delete(BDTaskTemplateItemMapEntity bDTaskTemplateItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDTaskTemplateItemMapDataAccess().Delete(bDTaskTemplateItemMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDTaskTemplateItemMapFacade.Add(IList<BDTaskTemplateItemMapEntity> bDTaskTemplateItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDTaskTemplateItemMapDataAccess().Add(bDTaskTemplateItemMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDTaskTemplateItemMapFacade.Update(IList<BDTaskTemplateItemMapEntity> bDTaskTemplateItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDTaskTemplateItemMapDataAccess().Update(bDTaskTemplateItemMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDTaskTemplateItemMapFacade.Delete(IList<BDTaskTemplateItemMapEntity> bDTaskTemplateItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDTaskTemplateItemMapDataAccess().Delete(bDTaskTemplateItemMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDTaskTemplateItemMapEntity> IBDTaskTemplateItemMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDTaskTemplateItemMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDTaskTemplateItemMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDTaskTemplateItemMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDTaskTemplateItemMapEntity IBDTaskTemplateItemMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDTaskTemplateItemMapEntity.FLD_NAME_TaskTemplateItemMap, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDTaskTemplateItemMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
