﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarkMpn.XmlSerializerAutoComplete
{
    public abstract class AutocompleteSuggestion
    {
    }

    public class AutocompleteElementSuggestion : AutocompleteSuggestion
    {
        public string Name { get; set; }
    }

    public class AutocompleteAttributeSuggestion : AutocompleteSuggestion
    {
        public string Name { get; set; }
    }
}