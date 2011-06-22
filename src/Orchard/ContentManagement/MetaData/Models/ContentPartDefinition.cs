﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Orchard.ContentManagement.Metadata.Models {
    public class ContentPartDefinition {
        public ContentPartDefinition(string name, IEnumerable<ContentPartFieldDefinition> fields, SettingsDictionary settings) {
            Name = name;
            Fields = new ReadOnlyCollection<ContentPartFieldDefinition>(fields.ToList());
            Settings = settings;
        }

        public ContentPartDefinition(string name) {
            Name = name;
            Fields = Enumerable.Empty<ContentPartFieldDefinition>();
            Settings = new SettingsDictionary();
        }

        public string Name { get; private set; }
        public IEnumerable<ContentPartFieldDefinition> Fields { get; private set; }
        public SettingsDictionary Settings { get; private set; }
    }
}
