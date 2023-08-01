using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Yepp.App.Services.Enums;
using Yepp.App.WebCrawler.Attributes;

namespace Yepp.App.WebCrawler.Processor
{
    /// <summary>
    ///
    /// </summary>
    public class ReflectionHelper
    {
        /// <summary>
        /// Gets the entity expression.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns></returns>
        /// <exception cref="System.Exception">This entity should be xpath</exception>
        internal static string GetEntityExpression<TEntity>()
        {
            var entityAttribute = (typeof(TEntity)).GetCustomAttribute<CrawlerEntityAttribute>();
            if (entityAttribute == null || string.IsNullOrWhiteSpace(entityAttribute.XPath))
                throw new Exception("This entity should be xpath");

            return entityAttribute.XPath;
        }

        /// <summary>
        /// Gets the property attributes.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns></returns>
        public static Dictionary<string, Tuple<CrowlerSelectorTypeEnum, string>> GetPropertyAttributes<TEntity>()
        {
            var attributeDictionary = new Dictionary<string, Tuple<CrowlerSelectorTypeEnum, string>>();

            PropertyInfo[] props = typeof(TEntity).GetProperties();
            var propList = props.Where(p => p.CustomAttributes.Count() > 0);

            foreach (PropertyInfo prop in propList)
            {
                var attr = prop.GetCustomAttribute<CrawlerFieldAttribute>();
                if (attr != null)
                {
                    attributeDictionary.Add(prop.Name, Tuple.Create(attr.SelectorType, attr.Expression));
                }
            }
            return attributeDictionary;
        }

        /// <summary>
        /// Creates the new entity.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns></returns>
        internal static object CreateNewEntity<TEntity>()
        {
            object instance = Activator.CreateInstance(typeof(TEntity));
            return instance;
        }

        /// <summary>
        /// Tries the set property.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="property">The property.</param>
        /// <param name="value">The value.</param>
        internal static void TrySetProperty(object obj, string property, object value)
        {
            var prop = obj.GetType().GetProperty(property, BindingFlags.Public | BindingFlags.Instance);
            if (prop != null && prop.CanWrite)
                prop.SetValue(obj, value, null);
        }
    }
}