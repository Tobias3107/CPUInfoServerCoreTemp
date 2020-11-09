using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CoreTemp.Plugin;

namespace CPUInfoServerCoreTemp
{
    public class CoreTempPlugin : IPlugin
    {
        private CoreTempPluginProxy coreTempPluginProxyReference;

        /// <summary>
        /// Gets or sets the core temp plugin proxy reference. You should not modify this value!
        /// </summary>
        /// <value>The core temp plugin proxy reference.</value>
        CoreTempPluginProxy IPlugin.CoreTempPluginProxyReference
        {
            get { return this.coreTempPluginProxyReference; }
            set { this.coreTempPluginProxyReference = value; }
        }

        /// <summary>
        /// Gets the description of this plugin.
        /// </summary>
        /// <value>The plugin description.</value>
        string IPlugin.Description
        {
            get { return "Put the Data in a File"; }
        }

        /// <summary>
        /// Gets the name of this plugin.
        /// </summary>
        /// <value>The plugin name.</value>
        string IPlugin.Name
        {
            get { return "CPUInfoServer"; }
        }

        /// <summary>
        /// Gets the version of this plugin.
        /// </summary>
        /// <value>The plugin version string.</value>
        string IPlugin.Version
        {
            get { return "1.0"; }
        }

        /// <summary>
        /// Configures this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:CoreTemp.Plugin.eConfigureStatus"/>, indicating whether the configuration option has been handled or is not supported by the plugin.
        /// </returns>
        eConfigureStatus IPlugin.Configure()
        {
            return eConfigureStatus.Unsupported;
        }

        /// <summary>
        /// Removes the specified path.
        /// </summary>
        /// <param name="Path">The path to the folder ctaining the plugin files.</param>
        void IPlugin.Remove(string Path)
        {
            // TODO: Implement your clean up code here.
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:CoreTemp.Plugin.eStartStatus"/> which describes the status of the plugin
        /// </returns>
        eStartStatus IPlugin.Start()
        {
            return eStartStatus.Success;
        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        void IPlugin.Stop()
        {
            // TODO: Handle call for stopping the plugin.
        }

        /// <summary>
        /// Updates the plugin with the data provided by Core Temp.
        /// </summary>
        /// <param name="Data">Core Temp's shared data.</param>
        void IPlugin.Update(CoreTempSharedData Data)
        {
            
            dataToJSON.transferToJSON(Data, "C:\\Program Files\\Core Temp\\Plugins\\localData.json");
        }
    }
}
