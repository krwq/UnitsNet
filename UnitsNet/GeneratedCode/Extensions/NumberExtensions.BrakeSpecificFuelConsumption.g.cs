﻿// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

#if !WINDOWS_UWP
// Extension methods/overloads not supported in Universal Windows Platform (WinRT Components)
namespace UnitsNet.Extensions
{
    public static partial class NumberExtensions
    {
        #region GramPerKiloWattHour

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(double)"/>
        public static BrakeSpecificFuelConsumption GramsPerKiloWattHour(this int value) => BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(double?)"/>
        public static BrakeSpecificFuelConsumption? GramsPerKiloWattHour(this int? value) => BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(double)"/>
        public static BrakeSpecificFuelConsumption GramsPerKiloWattHour(this long value) => BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(double?)"/>
        public static BrakeSpecificFuelConsumption? GramsPerKiloWattHour(this long? value) => BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(double)"/>
        public static BrakeSpecificFuelConsumption GramsPerKiloWattHour(this double value) => BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(double?)"/>
        public static BrakeSpecificFuelConsumption? GramsPerKiloWattHour(this double? value) => BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(double)"/>
        public static BrakeSpecificFuelConsumption GramsPerKiloWattHour(this float value) => BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(double?)"/>
        public static BrakeSpecificFuelConsumption? GramsPerKiloWattHour(this float? value) => BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(double)"/>
        public static BrakeSpecificFuelConsumption GramsPerKiloWattHour(this decimal value) => BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(Convert.ToDouble(value));

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(double?)"/>
        public static BrakeSpecificFuelConsumption? GramsPerKiloWattHour(this decimal? value) => BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramPerJoule

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double)"/>
        public static BrakeSpecificFuelConsumption KilogramsPerJoule(this int value) => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double?)"/>
        public static BrakeSpecificFuelConsumption? KilogramsPerJoule(this int? value) => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double)"/>
        public static BrakeSpecificFuelConsumption KilogramsPerJoule(this long value) => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double?)"/>
        public static BrakeSpecificFuelConsumption? KilogramsPerJoule(this long? value) => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double)"/>
        public static BrakeSpecificFuelConsumption KilogramsPerJoule(this double value) => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double?)"/>
        public static BrakeSpecificFuelConsumption? KilogramsPerJoule(this double? value) => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double)"/>
        public static BrakeSpecificFuelConsumption KilogramsPerJoule(this float value) => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double?)"/>
        public static BrakeSpecificFuelConsumption? KilogramsPerJoule(this float? value) => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double)"/>
        public static BrakeSpecificFuelConsumption KilogramsPerJoule(this decimal value) => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(Convert.ToDouble(value));

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double?)"/>
        public static BrakeSpecificFuelConsumption? KilogramsPerJoule(this decimal? value) => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundPerMechanicalHorsepowerHour

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(double)"/>
        public static BrakeSpecificFuelConsumption PoundsPerMechanicalHorsepowerHour(this int value) => BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(double?)"/>
        public static BrakeSpecificFuelConsumption? PoundsPerMechanicalHorsepowerHour(this int? value) => BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(double)"/>
        public static BrakeSpecificFuelConsumption PoundsPerMechanicalHorsepowerHour(this long value) => BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(double?)"/>
        public static BrakeSpecificFuelConsumption? PoundsPerMechanicalHorsepowerHour(this long? value) => BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(double)"/>
        public static BrakeSpecificFuelConsumption PoundsPerMechanicalHorsepowerHour(this double value) => BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(double?)"/>
        public static BrakeSpecificFuelConsumption? PoundsPerMechanicalHorsepowerHour(this double? value) => BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(double)"/>
        public static BrakeSpecificFuelConsumption PoundsPerMechanicalHorsepowerHour(this float value) => BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(double?)"/>
        public static BrakeSpecificFuelConsumption? PoundsPerMechanicalHorsepowerHour(this float? value) => BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(value);

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(double)"/>
        public static BrakeSpecificFuelConsumption PoundsPerMechanicalHorsepowerHour(this decimal value) => BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(double?)"/>
        public static BrakeSpecificFuelConsumption? PoundsPerMechanicalHorsepowerHour(this decimal? value) => BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif