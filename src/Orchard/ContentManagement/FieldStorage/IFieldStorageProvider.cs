﻿using Orchard.ContentManagement.Metadata.Models;

namespace Orchard.ContentManagement.FieldStorage {
    public interface IFieldStorageProvider : IDependency {
        string ProviderName { get; }
        
        IFieldStorage BindStorage(
            ContentPart contentPart, 
            ContentPartFieldDefinition partFieldDefinition);
    }
}