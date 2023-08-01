using Newtonsoft.Json;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class GameInfo : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameInfo"/> class.
        /// </summary>
        /// <param name="gameInfoEntity">The game information entity.</param>
        public GameInfo(GameInfoEntity gameInfoEntity)
        {
            this.Id = gameInfoEntity.Id;
            this.Email = gameInfoEntity.Email;
            this.GameScore = gameInfoEntity.GameScore;
            this.Name = gameInfoEntity.Name;
            this.SurName = gameInfoEntity.SurName;
            this.Language = gameInfoEntity.Language;
        }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the sur.
        /// </summary>
        /// <value>
        /// The name of the sur.
        /// </value>
        [JsonProperty("surname")]
        public string SurName { get; set; }

        /// <summary>
        /// Gets or sets the game score.
        /// </summary>
        /// <value>
        /// The game score.
        /// </value>
        [JsonProperty("game_score")]
        public decimal? GameScore { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        [JsonProperty("language")] 
        public string Language { get; set; }
    }
}
