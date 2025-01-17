﻿// Copyright (c) Jerry Lee. All rights reserved. Licensed under the MIT License.
// See LICENSE in the project root for license information.

using System;

// ReSharper disable RedundantExplicitArrayCreation
// ReSharper disable UseNegatedPatternMatching

namespace UniSharperEditor.Data.Metadata.PropertyTypeConverters
{
    internal class NumberArrayTypeConverter<T> : ArrayTypeConverter
    {
        public override object Parse(char arrayElementSeparator, string value, params object[] parameters)
        {
            var array = base.Parse(arrayElementSeparator, value) as string[];
            if (array == null)
                return null;

            var result = new T[array.Length];
            for (var i = 0; i < result.Length; i++)
            {
                result[i] = ParseNumber<T>(array[i]);
            }
            return result;
        }
    }
    
    internal class BooleanArrayTypeConverter : ArrayTypeConverter
    {
        public override object Parse(char arrayElementSeparator, string value, params object[] parameters)
        {
            var array = base.Parse(arrayElementSeparator, value) as string[];
            if (array == null)
                return null;

            var result = new bool[array.Length];
            for (var i = 0; i < result.Length; i++)
            {
                result[i] = ParseBoolean(array[i]);
            }
            return result;
        }
    }
    
    internal class ArrayTypeConverter : PropertyTypeConverter
    {
        public override object Parse(char arrayElementSeparator, string value, params object[] parameters) => 
            string.IsNullOrEmpty(value) ? new string[] { } : value.Split(new char[] { arrayElementSeparator }, StringSplitOptions.RemoveEmptyEntries);
    }
}