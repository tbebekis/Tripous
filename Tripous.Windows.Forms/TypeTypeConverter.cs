/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;


namespace Tripous.Windows.Forms
{
    /// <summary>
    /// A TypeConverter intended for objects of type "Type", for example the PropertyType property
    /// <para>Taken from the http://www.codeproject.com/KB/database/DataGridEdtAlmostAnythin.aspx, 
    /// special thanks to the author, Declan Brennan, for his code.</para>
    /// </summary>
    public class TypeTypeConverter : TypeConverter
    {
        /// <summary>
        /// Returns whether this converter can convert an object of one type to the type of this converter.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that provides a format context.</param>
        /// <param name="sourceType">A Type that represents the type you want to convert from.</param>
        /// <returns>true if the conversion is possible</returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            return base.CanConvertFrom(context, sourceType);
        }

        /// <summary>
        /// Returns whether this converter can convert the object to the specified type.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that provides a format context.</param>
        /// <param name="destinationType">A Type that represents the type you want to convert to.</param>
        /// <returns></returns>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
                return true;
            return base.CanConvertTo(context, destinationType);
        }

        /// <summary>
        /// Converts the given object to the type of this converter, using the specified context and culture information
        /// This overrides the base method to handle the conversion from a string representing a type name to a Type
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that provides a format context.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="value">The Object to convert.</param>
        /// <returns>An Object that represents the converted value.</returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                System.ComponentModel.Design.ITypeResolutionService typeResolver = (System.ComponentModel.Design.ITypeResolutionService)context.GetService(typeof(System.ComponentModel.Design.ITypeResolutionService));
                Type t = null;
                string typeName = (string)value;
                if (typeResolver != null)
                    t = typeResolver.GetType(typeName);
                else
                {
                    // In the unlikely case that this property is bound to another PropertyEditor
                    // so it can be changed at runtime, ITypeResolutionService won't be available
                    // so we resort to GetType instead.
                    t = Type.GetType(typeName);
                    // Hard Code System.Drawing in as an additional assembly to search
                    if (t == null)
                        t = typeof(System.Drawing.Color).Assembly.GetType(typeName);
                }
                return t;
            }
            return base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// Converts the given value object to the specified type, using the specified context and culture information.
        /// This overrides the base method to add functionality to handle InstanceDescriptors used to output code to the InitComponents method
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that provides a format context.</param>
        /// <param name="culture">The CultureInfo to use as the current culture.</param>
        /// <param name="value">The Object to convert.</param>
        /// <param name="destinationType">The Type to convert the value parameter to. </param>
        /// <returns>An Object that represents the converted value.</returns>
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
                return value.ToString();
            else if (destinationType == typeof(InstanceDescriptor))
            {
                return new InstanceDescriptor(typeof(Type).GetConstructor(new Type[1] { typeof(string) }), new object[] { value.ToString() });
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
