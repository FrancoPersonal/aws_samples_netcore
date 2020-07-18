namespace Tools.Configuration
{
    using Microsoft.Extensions.Configuration;
    using System;

    /// <summary>
    /// Defines the <see cref="ConfigurationManager" />.
    /// </summary>
    public class ConfigurationManager : IConfigurationManager
    {
        /// <summary>
        /// Defines the defaultEnvironmentKey.
        /// </summary>
        internal const string defaultEnvironmentKey = "Hosting:Environment";

        /// <summary>
        /// Defines the defaultFileNameConfig.
        /// </summary>
        internal const string defaultFileNameConfig = "appsettings";

        /// <summary>
        /// The BuildConfig.
        /// </summary>
        /// <returns>The <see cref="IConfiguration"/>.</returns>
        public IConfiguration BuildConfig()
        {
            return BuildConfig(defaultFileNameConfig, defaultEnvironmentKey);
        }

        /// <summary>
        /// The BuildConfig.
        /// </summary>
        /// <param name="filename">The filename<see cref="string"/>.</param>
        /// <returns>The <see cref="IConfiguration"/>.</returns>
        public IConfiguration BuildConfig(string filename)
        {
            return BuildConfig(filename, defaultEnvironmentKey);
        }

        /// <summary>
        /// The BuildConfig.
        /// </summary>
        /// <param name="filename">The filename<see cref="string"/>.</param>
        /// <param name="EnvironmentKey">The EnvironmentKey<see cref="string"/>.</param>
        /// <returns>The <see cref="IConfiguration"/>.</returns>
        public IConfiguration BuildConfig(string filename, string EnvironmentKey)
        {
            var environmentName = Environment.GetEnvironmentVariable("Hosting:Environment");

            var config = new ConfigurationBuilder()
                .AddJsonFile($"{filename}.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"{filename}.{environmentName}.json", optional: true)
                .AddEnvironmentVariables();
            return config.Build();
        }
    }
}
