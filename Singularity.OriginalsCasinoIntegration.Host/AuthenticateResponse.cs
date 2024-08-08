namespace Singularity.OriginalsCasinoIntegration.Host
{
    public class AuthenticateResponse
    {
        /// <summary>
        /// The player account country. Find more information about ISO 31666 codes.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// The player wallet currency. Find more information about ISO 4217 codes.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The identifier of the player on the Operator’s platform.
        /// </summary>
        public string PlayerId { get; set; }

        public AuthenticateResponse()
        {
            CountryCode = string.Empty;
            CurrencyCode = string.Empty;
            PlayerId = string.Empty;
        }
    }
}
