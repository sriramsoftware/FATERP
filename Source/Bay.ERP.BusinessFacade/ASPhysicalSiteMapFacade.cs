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
    public sealed partial class ASPhysicalSiteMapFacade : IASPhysicalSiteMapFacade
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

        public ASPhysicalSiteMapFacade()
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

        ~ASPhysicalSiteMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IASPhysicalSiteMapFacade.Add(ASPhysicalSiteMapEntity aSPhysicalSiteMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapDataAccess().Add(aSPhysicalSiteMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IASPhysicalSiteMapFacade.Update(ASPhysicalSiteMapEntity aSPhysicalSiteMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapDataAccess().Update(aSPhysicalSiteMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IASPhysicalSiteMapFacade.Delete(ASPhysicalSiteMapEntity aSPhysicalSiteMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapDataAccess().Delete(aSPhysicalSiteMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IASPhysicalSiteMapFacade.Add(IList<ASPhysicalSiteMapEntity> aSPhysicalSiteMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapDataAccess().Add(aSPhysicalSiteMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IASPhysicalSiteMapFacade.Update(IList<ASPhysicalSiteMapEntity> aSPhysicalSiteMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapDataAccess().Update(aSPhysicalSiteMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IASPhysicalSiteMapFacade.Delete(IList<ASPhysicalSiteMapEntity> aSPhysicalSiteMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapDataAccess().Delete(aSPhysicalSiteMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ASPhysicalSiteMapEntity> IASPhysicalSiteMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IASPhysicalSiteMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateASPhysicalSiteMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ASPhysicalSiteMapEntity IASPhysicalSiteMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ASPhysicalSiteMapEntity.FLD_NAME_ASPhysicalSiteMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateASPhysicalSiteMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
