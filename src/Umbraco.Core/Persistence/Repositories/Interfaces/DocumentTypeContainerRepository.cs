﻿using Umbraco.Core.Logging;
using Umbraco.Core.Persistence.Mappers;
using Umbraco.Core.Persistence.UnitOfWork;

namespace Umbraco.Core.Persistence.Repositories
{
    class DocumentTypeContainerRepository : EntityContainerRepository, IDocumentTypeContainerRepository
    {
        public DocumentTypeContainerRepository(IDatabaseUnitOfWork uow, CacheHelper cache, ILogger logger, IMappingResolver mappingResolver)
            : base(uow, cache, logger, mappingResolver, Constants.ObjectTypes.DocumentTypeContainerGuid)
        { }
    }
}