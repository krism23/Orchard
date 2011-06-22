﻿using System.Linq;
using Orchard.ContentManagement.Metadata.Models;

namespace Orchard.ContentManagement.Metadata.Builders {
    public abstract class ContentPartFieldDefinitionBuilder {
        protected readonly SettingsDictionary _settings;

        protected ContentPartFieldDefinitionBuilder(ContentPartFieldDefinition field) {
            _settings = new SettingsDictionary(field.Settings.ToDictionary(kv => kv.Key, kv => kv.Value));
        }

        public ContentPartFieldDefinitionBuilder WithSetting(string name, string value) {
            _settings[name] = value;
            return this;
        }

        public abstract string Name { get; }
        public abstract string FieldType { get; }

        public abstract ContentPartFieldDefinitionBuilder OfType(ContentFieldDefinition fieldDefinition);
        public abstract ContentPartFieldDefinitionBuilder OfType(string fieldType);
    }
}