using HtmlAgilityPack;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Yepp.App.WebCrawler.Processor
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface ICrawlerProcessor<TEntity> where TEntity : class
    {
        /// <summary>
        /// Sahibinden the specified document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> Sahibinden(HtmlDocument document);

        /// <summary>
        /// Grupanya the specified document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> Grupanya(HtmlDocument document);

        /// <summary>
        /// N11 the specified document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> N11(HtmlDocument document);

        /// <summary>
        /// Amazon  tr.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> AmazonTr(HtmlDocument document);

        /// <summary>
        /// Cicek sepeti.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> CicekSepeti(HtmlDocument document);

        /// <summary>
        /// Gittigidiyor.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GittiGidiyor(HtmlDocument document);

        /// <summary>
        /// Shopfy the specified document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> Shopfy(HtmlDocument document);

        /// <summary>
        /// Ebebek.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> EBebek(HtmlDocument document);

        /// <summary>
        /// Hepsiburada.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> HepsiBurada(HtmlDocument document);

        /// <summary>
        /// Etstur.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> EtsTur(HtmlDocument document);

        /// <summary>
        /// Trendyol.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> TrendYol(HtmlDocument document);
    }
}