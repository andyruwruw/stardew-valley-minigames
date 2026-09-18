using MinigameFramework.Utilities;
using StardewModdingAPI;

namespace MinigameFramework
{
    /// <summary>
    /// Mod entry.
    /// </summary>
    public class ModEntry : Mod
    {
        /// <summary>
		/// Provides <see cref="IModHelper"/> to other classes and sets events.
		/// </summary>
		public override void Entry(IModHelper helper)
        {
            this.SetHelper();
        }

        /// <summary>
        /// Sets static references to helper.
        /// </summary>
        private void SetHelper()
        {
            Translations.SetHelper(Helper.Translation);
            Logger.SetMonitor(Monitor);
        }
    }
}
