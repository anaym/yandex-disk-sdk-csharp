﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disk.SDK.Utils {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class WebdavResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WebdavResources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Disk.SDK.Utils.WebdavResources", typeof(WebdavResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на https://webdav.yandex.ru/.
        /// </summary>
        internal static string ApiUrl {
            get {
                return ResourceManager.GetString("ApiUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на https://oauth.yandex.ru/authorize?response_type=token&amp;client_id={0}&amp;display=popup.
        /// </summary>
        internal static string AuthBrowserUrlFormat {
            get {
                return ResourceManager.GetString("AuthBrowserUrlFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на grant_type=password&amp;username={0}&amp;password={1}&amp;client_id={2}&amp;client_secret={3}.
        /// </summary>
        internal static string AuthParamsFormat {
            get {
                return ResourceManager.GetString("AuthParamsFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на https://oauth.yandex.ru/token.
        /// </summary>
        internal static string AuthUrl {
            get {
                return ResourceManager.GetString("AuthUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Incorrect parameters - provide correct data and try again.
        /// </summary>
        internal static string BadParameterErrorMesage {
            get {
                return ResourceManager.GetString("BadParameterErrorMesage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Incorrect request - provide correct data and try again.
        /// </summary>
        internal static string BadRequestErrorMessage {
            get {
                return ResourceManager.GetString("BadRequestErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;propfind xmlns=&quot;DAV:&quot;&gt;
        ///  &lt;prop&gt;
        ///    &lt;public_url xmlns=&quot;urn:yandex:disk:meta&quot;/&gt;
        ///  &lt;/prop&gt;
        ///&lt;/propfind&gt;.
        /// </summary>
        internal static string CheckPublishingBody {
            get {
                return ResourceManager.GetString("CheckPublishingBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на COPY.
        /// </summary>
        internal static string CopyMethod {
            get {
                return ResourceManager.GetString("CopyMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на DELETE.
        /// </summary>
        internal static string DeleteMethod {
            get {
                return ResourceManager.GetString("DeleteMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на GET.
        /// </summary>
        internal static string GetMethod {
            get {
                return ResourceManager.GetString("GetMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;propfind xmlns=&quot;DAV:&quot;&gt;
        ///  &lt;prop&gt;
        ///    &lt;public_url xmlns=&quot;urn:yandex:disk:meta&quot; /&gt;
        ///    &lt;creationdate  /&gt;
        ///    &lt;getlastmodified/&gt;
        ///    &lt;displayname/&gt;
        ///    &lt;getcontentlength/&gt;
        ///    &lt;getcontenttype/&gt;
        ///    &lt;getetag/&gt;
        ///    &lt;resourcetype/&gt;
        ///  &lt;/prop&gt;
        ///&lt;/propfind&gt;.
        /// </summary>
        internal static string ItemDetailsBody {
            get {
                return ResourceManager.GetString("ItemDetailsBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на MKCOL.
        /// </summary>
        internal static string MakedirMethod {
            get {
                return ResourceManager.GetString("MakedirMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на MOVE.
        /// </summary>
        internal static string MoveMethod {
            get {
                return ResourceManager.GetString("MoveMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на You must be logged in before starting to work with SDK, try to call AuthorizeAsync(...) at first.
        /// </summary>
        internal static string NotAuthorizedErrorMessage {
            get {
                return ResourceManager.GetString("NotAuthorizedErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The file is too large for uploading.
        /// </summary>
        internal static string OutOfMemoryErrorMessage {
            get {
                return ResourceManager.GetString("OutOfMemoryErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на POST.
        /// </summary>
        internal static string PostMethod {
            get {
                return ResourceManager.GetString("PostMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на PROPFIND.
        /// </summary>
        internal static string PropfindMethod {
            get {
                return ResourceManager.GetString("PropfindMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на PROPPATCH.
        /// </summary>
        internal static string ProppatchMethod {
            get {
                return ResourceManager.GetString("ProppatchMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Can&apos;t load SDK provider assembly. Add reference to the platform specific assembly &apos;Disk.SDK.Provider (platform)&apos; and try again..
        /// </summary>
        internal static string ProviderErrorMessage {
            get {
                return ResourceManager.GetString("ProviderErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;propertyupdate xmlns=&quot;DAV:&quot;&gt;
        ///  &lt;set&gt;
        ///    &lt;prop&gt;
        ///      &lt;public_url xmlns=&quot;urn:yandex:disk:meta&quot;&gt;true&lt;/public_url&gt;
        ///    &lt;/prop&gt;
        ///  &lt;/set&gt;
        ///&lt;/propertyupdate&gt;.
        /// </summary>
        internal static string PublishBody {
            get {
                return ResourceManager.GetString("PublishBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на PUT.
        /// </summary>
        internal static string PutMethod {
            get {
                return ResourceManager.GetString("PutMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на ([a-zA-Z0-9]){39}.
        /// </summary>
        internal static string TokenRegexPattern {
            get {
                return ResourceManager.GetString("TokenRegexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;propertyupdate xmlns=&quot;DAV:&quot;&gt;
        ///  &lt;remove&gt;
        ///    &lt;prop&gt;
        ///      &lt;public_url xmlns=&quot;urn:yandex:disk:meta&quot; /&gt;
        ///    &lt;/prop&gt;
        ///  &lt;/remove&gt;
        ///&lt;/propertyupdate&gt;.
        /// </summary>
        internal static string UnpublishBody {
            get {
                return ResourceManager.GetString("UnpublishBody", resourceCulture);
            }
        }
    }
}
