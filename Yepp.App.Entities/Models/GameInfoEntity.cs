using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   The Game Info Entity
    /// </summary>

    public class GameInfoEntity : BaseEntity
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Column("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the sur.
        /// </summary>
        /// <value>
        /// The name of the sur.
        /// </value>
        [Column("surname")]
        public string SurName { get; set; }

        /// <summary>
        /// Gets or sets the game score.
        /// </summary>
        /// <value>
        /// The game score.
        /// </value>
        [Column("game_score",TypeName ="decimal(18,3)")]
        public decimal? GameScore { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        [Column("language")]
        public string Language { get; set; }

    }
}
