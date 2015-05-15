// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




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
    public sealed partial class ASPhysicalSiteMapControlFacade : IASPhysicalSiteMapControlFacade
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

        public ASPhysicalSiteMapControlFacade()
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

        ~ASPhysicalSiteMapControlFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IASPhysicalSiteMapControlFacade.Add(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapControlDataAccess().Add(aSPhysicalSiteMapControlEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IASPhysicalSiteMapControlFacade.Update(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapControlDataAccess().Update(aSPhysicalSiteMapControlEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IASPhysicalSiteMapControlFacade.Delete(ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapControlDataAccess().Delete(aSPhysicalSiteMapControlEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IASPhysicalSiteMapControlFacade.Add(IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapControlDataAccess().Add(aSPhysicalSiteMapControlEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IASPhysicalSiteMapControlFacade.Update(IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapControlDataAccess().Update(aSPhysicalSiteMapControlEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IASPhysicalSiteMapControlFacade.Delete(IList<ASPhysicalSiteMapControlEntity> aSPhysicalSiteMapControlEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapControlDataAccess().Delete(aSPhysicalSiteMapControlEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ASPhysicalSiteMapControlEntity> IASPhysicalSiteMapControlFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapControlDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IASPhysicalSiteMapControlFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapControlDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ASPhysicalSiteMapControlEntity IASPhysicalSiteMapControlFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapControlEntity.FLD_NAME_ASPhysicalSiteMapControlID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateASPhysicalSiteMapControlDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
