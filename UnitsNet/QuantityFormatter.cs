﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <summary>
    /// The QuantityFormatter class is responsible for formatting a quantity using the given format string.
    /// </summary>
    public class QuantityFormatter
    {
        /// <summary>
        /// Formats the given quantity using the given format string. Uses the <see cref="CultureInfo.CurrentUICulture" />.
        /// </summary>
        /// <typeparam name="TUnitType">The quantity's unit type, for example <see cref="LengthUnit"/>.</typeparam>
        /// <param name="quantity">The quantity to format.</param>
        /// <param name="format">The format string.</param>
        /// <remarks>
        /// The valid format strings are as follows:
        /// Any of the standard numeric format strings for double values except for "G" or "g" ("C" or "c", "E" or "e", "F" or "f", "N" or "n", "P" or "p", "R" or "r").
        /// "G" or "g": The value with 2 significant digits after the radix followed by the unit abbreviation, such as "1.23 m".
        /// "A" or "a": The default unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />, such as "m".
        /// "a0", "a1", ..., "aN": The Nth unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />. "a0" is the same as "a".
        /// A <see cref="FormatException"/> will be thrown if the requested abbreviation index does not exist.
        /// "V" or "v": String representation of <see cref="IQuantity.Value" />.
        /// "U" or "u": The enum name of <see cref="IQuantity{TUnitType}.Unit" />, such as "Meter".
        /// "Q" or "q": The quantity name, such as "Length".
        /// "s1", "s2", ..., "sN": The value with N significant digits after the radix followed by the unit abbreviation. For example,
        /// "s4" would return "1.2345 m" if <see cref="IQuantity.Value" /> is 1.2345678. Trailing zeros are omitted.
        /// </remarks>
        /// <returns>The string representation.</returns>
        public static string Format<TUnitType>(IQuantity<TUnitType> quantity, string format)
            where TUnitType : Enum
        {
            return Format(quantity, format, CultureInfo.CurrentUICulture);
        }

        /// <summary>
        /// Formats the given quantity using the given format string and format provider.
        /// </summary>
        /// <typeparam name="TUnitType">The quantity's unit type, for example <see cref="LengthUnit"/>.</typeparam>
        /// <param name="quantity">The quantity to format.</param>
        /// <param name="format">The format string.</param>
        /// <param name="formatProvider">The format provider to use for localization and number formatting. Defaults to
        /// <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <remarks>
        /// The valid format strings are as follows:
        /// Any of the standard numeric format strings for double values except for "G" or "g" ("C" or "c", "E" or "e", "F" or "f", "N" or "n", "P" or "p", "R" or "r").
        /// "G" or "g": The value with 2 significant digits after the radix followed by the unit abbreviation, such as "1.23 m".
        /// "A" or "a": The default unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />, such as "m".
        /// "a0", "a1", ..., "aN": The Nth unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />. "a0" is the same as "a".
        /// A <see cref="FormatException"/> will be thrown if the requested abbreviation index does not exist.
        /// "V" or "v": String representation of <see cref="IQuantity.Value" />.
        /// "U" or "u": The enum name of <see cref="IQuantity{TUnitType}.Unit" />, such as "Meter".
        /// "Q" or "q": The quantity name, such as "Length".
        /// "s1", "s2", ..., "sN": The value with N significant digits after the radix followed by the unit abbreviation. For example,
        /// "s4" would return "1.2345 m" if <see cref="IQuantity.Value" /> is 1.2345678. Trailing zeros are omitted.
        /// </remarks>
        /// <returns>The string representation.</returns>
        public static string Format<TUnitType>(IQuantity<TUnitType> quantity, string format, IFormatProvider formatProvider)
            where TUnitType : Enum
        {
            formatProvider ??= CultureInfo.CurrentUICulture;

            if(string.IsNullOrEmpty(format))
                format = "g";

            int precisionSpecifier = 0;
            char formatSpecifier = format[0];

            switch(formatSpecifier)
            {
                case 'A':
                case 'a':
                case 'S':
                case 's':
                    if(format.Length > 1 && !int.TryParse(format.Substring(1), out precisionSpecifier))
                        throw new FormatException($"The {format} format string is not supported.");
                    break;
            }

            switch(formatSpecifier)
            {
                // Standard numeric format specifiers
                case 'C':
                case 'c':
                case 'E':
                case 'e':
                case 'F':
                case 'f':
                case 'N':
                case 'n':
                case 'P':
                case 'p':
                case 'R':
                case 'r':
                    return quantity.Value.ToString(format, formatProvider);

                // UnitsNet custom format specifiers
                case 'G':
                case 'g':
                    return ToStringWithSignificantDigitsAfterRadix(quantity, formatProvider, 2);
                case 'A':
                case 'a':
                    var abbreviations = UnitAbbreviationsCache.Default.GetUnitAbbreviations(quantity.Unit, formatProvider);

                    if(precisionSpecifier >= abbreviations.Length)
                        throw new FormatException($"The {format} format string is invalid because the abbreviation index does not exist.");

                    return abbreviations[precisionSpecifier];
                case 'V':
                case 'v':
                    return quantity.Value.ToString(formatProvider);
                case 'U':
                case 'u':
                    return quantity.Unit.ToString();
                case 'Q':
                case 'q':
                    return quantity.QuantityInfo.Name;
                case 'S':
                case 's':
                    return ToStringWithSignificantDigitsAfterRadix(quantity, formatProvider, precisionSpecifier);
                default:
                    throw new FormatException($"The {format} format string is not supported.");
            }
        }

        private static string ToStringWithSignificantDigitsAfterRadix<TUnitType>(IQuantity<TUnitType> quantity, IFormatProvider formatProvider, int number) where TUnitType : Enum
        {
            string formatForSignificantDigits = UnitFormatter.GetFormat(quantity.Value, number);
            object[] formatArgs = UnitFormatter.GetFormatArgs(quantity.Unit, quantity.Value, formatProvider, Enumerable.Empty<object>());
            return string.Format(formatProvider, formatForSignificantDigits, formatArgs);
        }
    }
}
