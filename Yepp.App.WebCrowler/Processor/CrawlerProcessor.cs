using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Yepp.App.Services.Enums;

namespace Yepp.App.WebCrawler.Processor
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <seealso cref="Yepp.App.WebCrawler.Processor.ICrawlerProcessor{TEntity}" />
    public class CrawlerProcessor<TEntity> : ICrawlerProcessor<TEntity> where TEntity : class
    {
        /// <summary>
        /// Processes the specified document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<IEnumerable<TEntity>> Sahibinden(HtmlDocument document)
        {
            var columnNameValueDictionary = new Dictionary<string, object>();

            var entityExpression = ReflectionHelper.GetEntityExpression<TEntity>();
            var propertyExpressions = ReflectionHelper.GetPropertyAttributes<TEntity>();
            var entityNode = document.DocumentNode.SelectSingleNode(entityExpression);

            foreach (var expression in propertyExpressions)
            {
                var columnName = expression.Key;
                object columnValue = null;
                var fieldExpression = expression.Value.Item2;
                switch (expression.Value.Item1)
                {
                    case CrowlerSelectorTypeEnum.XPath:
                        var node = entityNode.SelectSingleNode(fieldExpression);

                        if (columnName.Contains("ImagePath"))
                        {
                            columnValue = node.Attributes[@"src"].Value;
                            break;
                        }

                        if (node != null)

                            columnValue = Regex.Replace(node.InnerText, @"\t|\n|\r", "").Replace(" ", "");
                        columnValue = Regex.Match(columnValue.ToString(), @"\d+.+\d").Value;
                        break;

                    case CrowlerSelectorTypeEnum.CssSelector:
                        var nodeCss = entityNode.QuerySelector(fieldExpression);
                        if (nodeCss != null)
                            columnValue = nodeCss.InnerText;
                        break;

                    case CrowlerSelectorTypeEnum.FixedValue:
                        if (Int32.TryParse(fieldExpression, out var result))
                        {
                            columnValue = result;
                        }
                        break;

                    default:
                        break;
                }
                columnNameValueDictionary.Add(columnName, columnValue);
            }

            var processorEntity = ReflectionHelper.CreateNewEntity<TEntity>();
            foreach (var pair in columnNameValueDictionary)
            {
                ReflectionHelper.TrySetProperty(processorEntity, pair.Key, pair.Value);
            }

            return new List<TEntity>
            {
                processorEntity as TEntity
            };
        }

        public Task<IEnumerable<TEntity>> Grupanya(HtmlDocument document)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> N11(HtmlDocument document)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> AmazonTr(HtmlDocument document)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> CicekSepeti(HtmlDocument document)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GittiGidiyor(HtmlDocument document)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> Shopfy(HtmlDocument document)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> EBebek(HtmlDocument document)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> HepsiBurada(HtmlDocument document)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> EtsTur(HtmlDocument document)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> TrendYol(HtmlDocument document)
        {
            throw new NotImplementedException();
        }
    }
}