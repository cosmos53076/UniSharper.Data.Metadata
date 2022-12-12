﻿// Copyright (c) Jerry Lee. All rights reserved. Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace UniSharperEditor.Data.Metadata.PropertyTypeConverters
{
    internal class NumberTypeConverter<T> : PropertyTypeConverter
    {
        public override object Parse(char arrayElementSeparator, string value, params object[] parameters) => ParseNumber<T>(value);
    }
}