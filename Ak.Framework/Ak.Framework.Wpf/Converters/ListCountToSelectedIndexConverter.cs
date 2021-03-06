﻿using System;
using System.Globalization;
using Ak.Framework.Core.Extensions;

namespace Ak.Framework.Wpf.Converters
{
    /// <summary>
    /// Конвертация количества элементов в списке в выбранный элемент
    /// </summary>
    /// <seealso cref="Ak.Framework.Wpf.Converters.ValueConverterBase" />
    public sealed class ListCountToSelectedIndexConverter : ValueConverterBase
    {
        /// <summary>
        /// Конвертация значений
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="targetType">Целевой тип</param>
        /// <param name="parameter">Параметр конвертации</param>
        /// <param name="culture">Локаль</param>
        /// <returns></returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToInt32() == 0 ? -1 : 0;
        }

        /// <summary>
        /// Обратная конвертация
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="targetType">Целевой тип</param>
        /// <param name="parameter">Параметр конвертации</param>
        /// <param name="culture">Локаль</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
