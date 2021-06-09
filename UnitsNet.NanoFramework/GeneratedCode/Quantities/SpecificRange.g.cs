﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     The range of the aircraft per unit of fuel.
    /// </summary>
    public struct  SpecificRange
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly SpecificRangeUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public SpecificRangeUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public SpecificRange(double value, SpecificRangeUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static SpecificRangeUnit BaseUnit { get; } = SpecificRangeUnit.MeterPerKilogramForce;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static SpecificRange MaxValue { get; } = new SpecificRange(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static SpecificRange MinValue { get; } = new SpecificRange(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static SpecificRange Zero { get; } = new SpecificRange(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get SpecificRange in CentimetersPerKilogramForce.
        /// </summary>
        public double CentimetersPerKilogramForce => As(SpecificRangeUnit.CentimeterPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange in CentimetersPerNewton.
        /// </summary>
        public double CentimetersPerNewton => As(SpecificRangeUnit.CentimeterPerNewton);

        /// <summary>
        ///     Get SpecificRange in DecametersPerKilogramForce.
        /// </summary>
        public double DecametersPerKilogramForce => As(SpecificRangeUnit.DecameterPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange in DecametersPerNewton.
        /// </summary>
        public double DecametersPerNewton => As(SpecificRangeUnit.DecameterPerNewton);

        /// <summary>
        ///     Get SpecificRange in DecimetersPerKilogramForce.
        /// </summary>
        public double DecimetersPerKilogramForce => As(SpecificRangeUnit.DecimeterPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange in DecimetersPerNewton.
        /// </summary>
        public double DecimetersPerNewton => As(SpecificRangeUnit.DecimeterPerNewton);

        /// <summary>
        ///     Get SpecificRange in KilometersPerKilogramForce.
        /// </summary>
        public double KilometersPerKilogramForce => As(SpecificRangeUnit.KilometerPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange in KilometersPerNewton.
        /// </summary>
        public double KilometersPerNewton => As(SpecificRangeUnit.KilometerPerNewton);

        /// <summary>
        ///     Get SpecificRange in MegametersPerKilogramForce.
        /// </summary>
        public double MegametersPerKilogramForce => As(SpecificRangeUnit.MegameterPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange in MegametersPerNewton.
        /// </summary>
        public double MegametersPerNewton => As(SpecificRangeUnit.MegameterPerNewton);

        /// <summary>
        ///     Get SpecificRange in MetersPerKilogramForce.
        /// </summary>
        public double MetersPerKilogramForce => As(SpecificRangeUnit.MeterPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange in MetersPerNewton.
        /// </summary>
        public double MetersPerNewton => As(SpecificRangeUnit.MeterPerNewton);

        /// <summary>
        ///     Get SpecificRange in MicrometersPerKilogramForce.
        /// </summary>
        public double MicrometersPerKilogramForce => As(SpecificRangeUnit.MicrometerPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange in MicrometersPerNewton.
        /// </summary>
        public double MicrometersPerNewton => As(SpecificRangeUnit.MicrometerPerNewton);

        /// <summary>
        ///     Get SpecificRange in MillimetersPerKilogramForce.
        /// </summary>
        public double MillimetersPerKilogramForce => As(SpecificRangeUnit.MillimeterPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange in MillimetersPerNewton.
        /// </summary>
        public double MillimetersPerNewton => As(SpecificRangeUnit.MillimeterPerNewton);

        /// <summary>
        ///     Get SpecificRange in NanometersPerKilogramForce.
        /// </summary>
        public double NanometersPerKilogramForce => As(SpecificRangeUnit.NanometerPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange in NanometersPerNewton.
        /// </summary>
        public double NanometersPerNewton => As(SpecificRangeUnit.NanometerPerNewton);

        /// <summary>
        ///     Get SpecificRange in NauticalMilesPerPoundForce.
        /// </summary>
        public double NauticalMilesPerPoundForce => As(SpecificRangeUnit.NauticalMilePerPoundForce);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get SpecificRange from CentimetersPerKilogramForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromCentimetersPerKilogramForce(double centimetersperkilogramforce) => new SpecificRange(centimetersperkilogramforce, SpecificRangeUnit.CentimeterPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange from CentimetersPerNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromCentimetersPerNewton(double centimeterspernewton) => new SpecificRange(centimeterspernewton, SpecificRangeUnit.CentimeterPerNewton);

        /// <summary>
        ///     Get SpecificRange from DecametersPerKilogramForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromDecametersPerKilogramForce(double decametersperkilogramforce) => new SpecificRange(decametersperkilogramforce, SpecificRangeUnit.DecameterPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange from DecametersPerNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromDecametersPerNewton(double decameterspernewton) => new SpecificRange(decameterspernewton, SpecificRangeUnit.DecameterPerNewton);

        /// <summary>
        ///     Get SpecificRange from DecimetersPerKilogramForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromDecimetersPerKilogramForce(double decimetersperkilogramforce) => new SpecificRange(decimetersperkilogramforce, SpecificRangeUnit.DecimeterPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange from DecimetersPerNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromDecimetersPerNewton(double decimeterspernewton) => new SpecificRange(decimeterspernewton, SpecificRangeUnit.DecimeterPerNewton);

        /// <summary>
        ///     Get SpecificRange from KilometersPerKilogramForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromKilometersPerKilogramForce(double kilometersperkilogramforce) => new SpecificRange(kilometersperkilogramforce, SpecificRangeUnit.KilometerPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange from KilometersPerNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromKilometersPerNewton(double kilometerspernewton) => new SpecificRange(kilometerspernewton, SpecificRangeUnit.KilometerPerNewton);

        /// <summary>
        ///     Get SpecificRange from MegametersPerKilogramForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromMegametersPerKilogramForce(double megametersperkilogramforce) => new SpecificRange(megametersperkilogramforce, SpecificRangeUnit.MegameterPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange from MegametersPerNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromMegametersPerNewton(double megameterspernewton) => new SpecificRange(megameterspernewton, SpecificRangeUnit.MegameterPerNewton);

        /// <summary>
        ///     Get SpecificRange from MetersPerKilogramForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromMetersPerKilogramForce(double metersperkilogramforce) => new SpecificRange(metersperkilogramforce, SpecificRangeUnit.MeterPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange from MetersPerNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromMetersPerNewton(double meterspernewton) => new SpecificRange(meterspernewton, SpecificRangeUnit.MeterPerNewton);

        /// <summary>
        ///     Get SpecificRange from MicrometersPerKilogramForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromMicrometersPerKilogramForce(double micrometersperkilogramforce) => new SpecificRange(micrometersperkilogramforce, SpecificRangeUnit.MicrometerPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange from MicrometersPerNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromMicrometersPerNewton(double micrometerspernewton) => new SpecificRange(micrometerspernewton, SpecificRangeUnit.MicrometerPerNewton);

        /// <summary>
        ///     Get SpecificRange from MillimetersPerKilogramForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromMillimetersPerKilogramForce(double millimetersperkilogramforce) => new SpecificRange(millimetersperkilogramforce, SpecificRangeUnit.MillimeterPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange from MillimetersPerNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromMillimetersPerNewton(double millimeterspernewton) => new SpecificRange(millimeterspernewton, SpecificRangeUnit.MillimeterPerNewton);

        /// <summary>
        ///     Get SpecificRange from NanometersPerKilogramForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromNanometersPerKilogramForce(double nanometersperkilogramforce) => new SpecificRange(nanometersperkilogramforce, SpecificRangeUnit.NanometerPerKilogramForce);

        /// <summary>
        ///     Get SpecificRange from NanometersPerNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromNanometersPerNewton(double nanometerspernewton) => new SpecificRange(nanometerspernewton, SpecificRangeUnit.NanometerPerNewton);

        /// <summary>
        ///     Get SpecificRange from NauticalMilesPerPoundForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificRange FromNauticalMilesPerPoundForce(double nauticalmilesperpoundforce) => new SpecificRange(nauticalmilesperpoundforce, SpecificRangeUnit.NauticalMilePerPoundForce);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="SpecificRangeUnit" /> to <see cref="SpecificRange" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>SpecificRange unit value.</returns>
        public static SpecificRange From(double value, SpecificRangeUnit fromUnit)
        {
            return new SpecificRange(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(SpecificRangeUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public SpecificRange ToUnit(SpecificRangeUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new SpecificRange(convertedValue, unit);
        }


        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case SpecificRangeUnit.CentimeterPerKilogramForce: return (_value) * 1e-2d;
                case SpecificRangeUnit.CentimeterPerNewton: return (_value/0.101972) * 1e-2d;
                case SpecificRangeUnit.DecameterPerKilogramForce: return (_value) * 1e1d;
                case SpecificRangeUnit.DecameterPerNewton: return (_value/0.101972) * 1e1d;
                case SpecificRangeUnit.DecimeterPerKilogramForce: return (_value) * 1e-1d;
                case SpecificRangeUnit.DecimeterPerNewton: return (_value/0.101972) * 1e-1d;
                case SpecificRangeUnit.KilometerPerKilogramForce: return (_value) * 1e3d;
                case SpecificRangeUnit.KilometerPerNewton: return (_value/0.101972) * 1e3d;
                case SpecificRangeUnit.MegameterPerKilogramForce: return (_value) * 1e6d;
                case SpecificRangeUnit.MegameterPerNewton: return (_value/0.101972) * 1e6d;
                case SpecificRangeUnit.MeterPerKilogramForce: return _value;
                case SpecificRangeUnit.MeterPerNewton: return _value/0.101972;
                case SpecificRangeUnit.MicrometerPerKilogramForce: return (_value) * 1e-6d;
                case SpecificRangeUnit.MicrometerPerNewton: return (_value/0.101972) * 1e-6d;
                case SpecificRangeUnit.MillimeterPerKilogramForce: return (_value) * 1e-3d;
                case SpecificRangeUnit.MillimeterPerNewton: return (_value/0.101972) * 1e-3d;
                case SpecificRangeUnit.NanometerPerKilogramForce: return (_value) * 1e-9d;
                case SpecificRangeUnit.NanometerPerNewton: return (_value/0.101972) * 1e-9d;
                case SpecificRangeUnit.NauticalMilePerPoundForce: return _value/0.00024492;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(SpecificRangeUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case SpecificRangeUnit.CentimeterPerKilogramForce: return (baseUnitValue) / 1e-2d;
                case SpecificRangeUnit.CentimeterPerNewton: return (baseUnitValue*0.101972) / 1e-2d;
                case SpecificRangeUnit.DecameterPerKilogramForce: return (baseUnitValue) / 1e1d;
                case SpecificRangeUnit.DecameterPerNewton: return (baseUnitValue*0.101972) / 1e1d;
                case SpecificRangeUnit.DecimeterPerKilogramForce: return (baseUnitValue) / 1e-1d;
                case SpecificRangeUnit.DecimeterPerNewton: return (baseUnitValue*0.101972) / 1e-1d;
                case SpecificRangeUnit.KilometerPerKilogramForce: return (baseUnitValue) / 1e3d;
                case SpecificRangeUnit.KilometerPerNewton: return (baseUnitValue*0.101972) / 1e3d;
                case SpecificRangeUnit.MegameterPerKilogramForce: return (baseUnitValue) / 1e6d;
                case SpecificRangeUnit.MegameterPerNewton: return (baseUnitValue*0.101972) / 1e6d;
                case SpecificRangeUnit.MeterPerKilogramForce: return baseUnitValue;
                case SpecificRangeUnit.MeterPerNewton: return baseUnitValue*0.101972;
                case SpecificRangeUnit.MicrometerPerKilogramForce: return (baseUnitValue) / 1e-6d;
                case SpecificRangeUnit.MicrometerPerNewton: return (baseUnitValue*0.101972) / 1e-6d;
                case SpecificRangeUnit.MillimeterPerKilogramForce: return (baseUnitValue) / 1e-3d;
                case SpecificRangeUnit.MillimeterPerNewton: return (baseUnitValue*0.101972) / 1e-3d;
                case SpecificRangeUnit.NanometerPerKilogramForce: return (baseUnitValue) / 1e-9d;
                case SpecificRangeUnit.NanometerPerNewton: return (baseUnitValue*0.101972) / 1e-9d;
                case SpecificRangeUnit.NauticalMilePerPoundForce: return baseUnitValue*0.00024492;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}
