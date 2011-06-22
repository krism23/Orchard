﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Orchard.ContentManagement.Metadata.Models {
    public class ContentTypeDefinition {
        public ContentTypeDefinition(string name, string displayName, IEnumerable<ContentTypePartDefinition> parts, SettingsDictionary settings) {
            Name = name;
            DisplayName = displayName;
            Parts = new ReadOnlyCollection<ContentTypePartDefinition>(parts.ToList());
            Settings = settings;
        }

        public ContentTypeDefinition(string name, string displayName) {
            Name = name;
            DisplayName = displayName;
            Parts = Enumerable.Empty<ContentTypePartDefinition>();
            Settings = new SettingsDictionary();
        }

        [StringLength(128)]
        public string Name { get; private set; }
        [Required, StringLength(1024)]
        public string DisplayName { get; private set; }
        public IEnumerable<ContentTypePartDefinition> Parts { get; private set; }
        public SettingsDictionary Settings { get; private set; }
    }
}
