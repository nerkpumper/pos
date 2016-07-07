using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace NerkSoft.Pos.Entities
{
    public class clsConfiguracion
    {
        public class clsVariablesConfiguraciones
        {
            public const string SERVER = "SERVERDB";
            public const string BD = "BDDB";
            public const string USER = "USERDB";
            public const string PWD = "PWDDB";
        }


        /// <summary>
        /// Obtiene la configuración del Servidor
        /// </summary>
        /// <returns></returns>
        public static string getConfigurationServer()
        {
            return clsConfiguracion.GetConfiguration(clsVariablesConfiguraciones.SERVER);
        }

        /// <summary>
        /// Obtiene la configuración de la base de datos
        /// </summary>
        /// <returns></returns>
        public static string getConfigurationDB()
        {
            return clsConfiguracion.GetConfiguration(clsVariablesConfiguraciones.BD);
        }

        /// <summary>
        /// Obtiene la configuración del usuario de la db
        /// </summary>
        /// <returns></returns>
        public static string getConfigurationUsuario()
        {
            return clsConfiguracion.GetConfiguration(clsVariablesConfiguraciones.USER);
        }

        /// <summary>
        /// Obtiene la configuración del pwd del server
        /// </summary>
        /// <returns></returns>
        public static string getConfigurationPassword()
        {
            return clsConfiguracion.GetConfiguration(clsVariablesConfiguraciones.PWD);
        }


        /// <summary>
        /// Establece la configuración del Servidor
        /// </summary>
        /// <param name="valor"></param>
        public static void setConfigurationServer(string valor)
        {
            SaveConfiguration(clsVariablesConfiguraciones.SERVER, valor);
        }

        /// <summary>
        /// Establece la configuración de la db
        /// </summary>
        /// <param name="valor"></param>
        public static void setConfigurationDB(string valor)
        {
            SaveConfiguration(clsVariablesConfiguraciones.BD, valor);
        }

        /// <summary>
        /// Establece la configuración del usuario
        /// </summary>
        /// <param name="valor"></param>
        public static void setConfigurationUsuario(string valor)
        {
            SaveConfiguration(clsVariablesConfiguraciones.USER, valor);
        }

        /// <summary>
        /// Establece la configuración del password
        /// </summary>
        /// <param name="valor"></param>
        public static void setConfigurationPassword(string valor)
        {
            SaveConfiguration(clsVariablesConfiguraciones.PWD, valor);
        }

        public static string GetConfiguration(string conf)
        {
            string result = "";
            RegistryKey registry = Registry.CurrentUser;

            registry = registry.OpenSubKey(@"Software", true);
            registry.CreateSubKey("NerkSoft");
            registry = registry.OpenSubKey("NerkSoft", true);
            registry.CreateSubKey("POS");
            registry = registry.OpenSubKey("POS", true);

            result = registry.GetValue(conf, "").ToString();

            try
            {
                result = clsCryptex.Desencriptar(result);
            }
            catch (Exception ex)
            {
                
                
            }

            registry.Dispose();
            registry = null;

            return result;
        }

        public static void SaveConfiguration(string conf, string value)
        {
            RegistryKey registry = Registry.CurrentUser;

            registry = registry.OpenSubKey(@"Software", true);
            registry.CreateSubKey("NerkSoft");
            registry = registry.OpenSubKey("NerkSoft", true);
            registry.CreateSubKey("POS");
            registry = registry.OpenSubKey("POS", true);

            try
            {
                value= clsCryptex.Desencriptar(value);
            }
            catch (Exception ex)
            {


            }


            registry.SetValue(conf, value);

            registry.Dispose();
            registry = null;
        }

    }
}
