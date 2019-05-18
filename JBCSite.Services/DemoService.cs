using JBCSite.Domain.Models;
using JBCSite.Infrastructure.Repository;
using JBCSite.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;

namespace JBCSite.Services
{
    /// <summary>
    /// A class for dealing with demo (and related) objects
    /// </summary>
    public class DemoService : IDisposable, IDemoService
    {
        private bool _disposed;
        private IRepository<DemoSummary> _summaryRepo;
        private IRepository<DemoObject> _demoObjectRepo;
        private IUnitOfWork<JBCSiteDbFactory> _unitOfWork;

        public DemoService()
        {
            _unitOfWork = new UnitOfWork<JBCSiteDbFactory>();
            _summaryRepo = _unitOfWork.GetRepository<DemoSummary>();
            _demoObjectRepo = _unitOfWork.GetRepository<DemoObject>();
        }

        public IEnumerable<DemoSummary> GetSummaries()
        {
            return _summaryRepo.GetAll();
        }

        public DemoSummary GetSummary(int id)
        {
            return _summaryRepo.FindById(id);
        }

        public IEnumerable<DemoObject> GetDemos()
        {
            return _demoObjectRepo.GetAll();
        }

        public DemoObject GetDemo(int id)
        {
            return _demoObjectRepo.FindById(id);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _unitOfWork.Dispose();
                }

                _disposed = true;
            }
        }
    }
}
