namespace Tools.Configuration
{
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Defines the <see cref="IConfigurationManager" />.
    /// </summary>
    public interface IConfigurationManager
    {
        /// <summary>
        /// The BuildConfig.
        /// </summary>
        /// <returns>The <see cref="IConfiguration"/>.</returns>
        IConfiguration BuildConfig();

        /// <summary>
        /// The BuildConfig.
        /// </summary>
        /// <param name="filename">The filename<see cref="string"/>.</param>
        /// <returns>The <see cref="IConfiguration"/>.</returns>
        IConfiguration BuildConfig(string filename);

        /// <summary>
        /// The BuildConfig.
        /// </summary>
        /// <param name="filename">The filename<see cref="string"/>.</param>
        /// <param name="EnvironmentKey">The EnvironmentKey<see cref="string"/>.</param>
        /// <returns>The <see cref="IConfiguration"/>.</returns>
        IConfiguration BuildConfig(string filename, string EnvironmentKey);
    }
}
