// gShell is licensed under the GNU GENERAL PUBLIC LICENSE, Version 3
//
// http://www.gnu.org/licenses/gpl-3.0.en.html
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//
// gShell is based upon https://github.com/google/google-api-dotnet-client, which is licensed under the Apache 2.0
// license: https://github.com/google/google-api-dotnet-client/blob/master/LICENSE
//
// gShell is reliant upon the Google Apis. Please see the specific API pages for specific licensing information.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a fork of google-apis-code-generator:
//       https://github.com/squid808/apis-client-generator
//
//     How neat is that? Pretty neat.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using gShell.Cmdlets.Utilities.OAuth2;

namespace gShell.Cmdlets.Adminsettings{

    using System;
    using System.Collections.Generic;
    using System.Management.Automation;

    using Google.Apis.Auth.OAuth2;
    using Google.Apis.Services;
    using adminsettings_v1 = Google.Apis.admin.Adminsettings.adminsettings_v1;
    using Data = Google.Apis.admin.Adminsettings.adminsettings_v1.Data;

    using gShell.dotNet.Utilities;
    using gShell.dotNet.Utilities.OAuth2;
    using gAdminsettings = gShell.dotNet.Adminsettings;

    /// <summary>
    /// A PowerShell-ready wrapper for the Adminsettings api, as well as the resources and methods therein.
    /// </summary>
    public abstract class AdminsettingsBase : AuthenticatedCmdletBase
    {

        #region Properties

        /// <summary>The gShell dotNet class wrapper base.</summary>
        protected static gAdminsettings mainBase { get; set; }


        /// <summary>An instance of the AdminSecondaryEmail gShell dotNet resource.</summary>
        public AdminSecondaryEmail adminSecondaryEmail { get; set; }

        /// <summary>An instance of the CountryCode gShell dotNet resource.</summary>
        public CountryCode countryCode { get; set; }

        /// <summary>An instance of the CreationTime gShell dotNet resource.</summary>
        public CreationTime creationTime { get; set; }

        /// <summary>An instance of the CurrentUsers gShell dotNet resource.</summary>
        public CurrentUsers currentUsers { get; set; }

        /// <summary>An instance of the CustomLogo gShell dotNet resource.</summary>
        public CustomLogo customLogo { get; set; }

        /// <summary>An instance of the CustomerPin gShell dotNet resource.</summary>
        public CustomerPin customerPin { get; set; }

        /// <summary>An instance of the DefaultLanguage gShell dotNet resource.</summary>
        public DefaultLanguage defaultLanguage { get; set; }

        /// <summary>An instance of the EmailGateway gShell dotNet resource.</summary>
        public EmailGateway emailGateway { get; set; }

        /// <summary>An instance of the EmailRouting gShell dotNet resource.</summary>
        public EmailRouting emailRouting { get; set; }

        /// <summary>An instance of the MaximumUsers gShell dotNet resource.</summary>
        public MaximumUsers maximumUsers { get; set; }

        /// <summary>An instance of the MxVerificationStatus gShell dotNet resource.</summary>
        public MxVerificationStatus mxVerificationStatus { get; set; }

        /// <summary>An instance of the OrganizationName gShell dotNet resource.</summary>
        public OrganizationName organizationName { get; set; }

        /// <summary>An instance of the ProductVersion gShell dotNet resource.</summary>
        public ProductVersion productVersion { get; set; }

        /// <summary>An instance of the SsoSettings gShell dotNet resource.</summary>
        public SsoSettings ssoSettings { get; set; }

        /// <summary>An instance of the SsoSigningKey gShell dotNet resource.</summary>
        public SsoSigningKey ssoSigningKey { get; set; }

        /// <summary>A collection of scopes for the Adminsettings api.</summary>
        protected HashSet<string> Scopes = new HashSet<string> {
            "https://apps-apis.google.com/a/feeds/domain/",
        };

        /// <summary>
        /// Required to be able to store and retrieve the mainBase from the ServiceWrapperDictionary
        /// </summary>
        protected override Type mainBaseType { get { return typeof(gAdminsettings); } }

        #endregion

        #region Constructors
        protected AdminsettingsBase()
        {
            mainBase = new gAdminsettings();

            ServiceWrapperDictionary[mainBaseType] = mainBase;

            adminSecondaryEmail = new AdminSecondaryEmail();
            countryCode = new CountryCode();
            creationTime = new CreationTime();
            currentUsers = new CurrentUsers();
            customLogo = new CustomLogo();
            customerPin = new CustomerPin();
            defaultLanguage = new DefaultLanguage();
            emailGateway = new EmailGateway();
            emailRouting = new EmailRouting();
            maximumUsers = new MaximumUsers();
            mxVerificationStatus = new MxVerificationStatus();
            organizationName = new OrganizationName();
            productVersion = new ProductVersion();
            ssoSettings = new SsoSettings();
            ssoSigningKey = new SsoSigningKey();
        }
        #endregion

        #region Wrapped Methods



        #region AdminSecondaryEmail

        /// <summary>A wrapper class for the AdminSecondaryEmail resource.</summary>
        public class AdminSecondaryEmail
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.AdminSecondaryEmail Get (string Domain)
            {

                return mainBase.adminSecondaryEmail.Get(Domain);
            }




            /// <param name="AdminSecondaryEmailBody">The body of the request.</param>
            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.AdminSecondaryEmail Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.AdminSecondaryEmail AdminSecondaryEmailBody, string Domain)
            {

                return mainBase.adminSecondaryEmail.Update(AdminSecondaryEmailBody, Domain);
            }


        }
        #endregion



        #region CountryCode

        /// <summary>A wrapper class for the CountryCode resource.</summary>
        public class CountryCode
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.CountryCode Get (string Domain)
            {

                return mainBase.countryCode.Get(Domain);
            }


        }
        #endregion



        #region CreationTime

        /// <summary>A wrapper class for the CreationTime resource.</summary>
        public class CreationTime
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.CreationTime Get (string Domain)
            {

                return mainBase.creationTime.Get(Domain);
            }


        }
        #endregion



        #region CurrentUsers

        /// <summary>A wrapper class for the CurrentUsers resource.</summary>
        public class CurrentUsers
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.CurrentNumberOfUsers Get (string Domain)
            {

                return mainBase.currentUsers.Get(Domain);
            }


        }
        #endregion



        #region CustomLogo

        /// <summary>A wrapper class for the CustomLogo resource.</summary>
        public class CustomLogo
        {





            /// <param name="CustomLogoBody">The body of the request.</param>
            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.CustomLogo Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.CustomLogo CustomLogoBody, string Domain)
            {

                return mainBase.customLogo.Update(CustomLogoBody, Domain);
            }


        }
        #endregion



        #region CustomerPin

        /// <summary>A wrapper class for the CustomerPin resource.</summary>
        public class CustomerPin
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.CustomerPin Get (string Domain)
            {

                return mainBase.customerPin.Get(Domain);
            }


        }
        #endregion



        #region DefaultLanguage

        /// <summary>A wrapper class for the DefaultLanguage resource.</summary>
        public class DefaultLanguage
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.DefaultLanguage Get (string Domain)
            {

                return mainBase.defaultLanguage.Get(Domain);
            }




            /// <param name="DefaultLanguageBody">The body of the request.</param>
            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.DefaultLanguage Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.DefaultLanguage DefaultLanguageBody, string Domain)
            {

                return mainBase.defaultLanguage.Update(DefaultLanguageBody, Domain);
            }


        }
        #endregion



        #region EmailGateway

        /// <summary>A wrapper class for the EmailGateway resource.</summary>
        public class EmailGateway
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.Gateway Get (string Domain)
            {

                return mainBase.emailGateway.Get(Domain);
            }




            /// <param name="GatewayBody">The body of the request.</param>
            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.Gateway Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.Gateway GatewayBody, string Domain)
            {

                return mainBase.emailGateway.Update(GatewayBody, Domain);
            }


        }
        #endregion



        #region EmailRouting

        /// <summary>A wrapper class for the EmailRouting resource.</summary>
        public class EmailRouting
        {





            /// <param name="RoutingBody">The body of the request.</param>
            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.Routing Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.Routing RoutingBody, string Domain)
            {

                return mainBase.emailRouting.Update(RoutingBody, Domain);
            }


        }
        #endregion



        #region MaximumUsers

        /// <summary>A wrapper class for the MaximumUsers resource.</summary>
        public class MaximumUsers
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.MaximumNumberOfUsers Get (string Domain)
            {

                return mainBase.maximumUsers.Get(Domain);
            }


        }
        #endregion



        #region MxVerificationStatus

        /// <summary>A wrapper class for the MxVerificationStatus resource.</summary>
        public class MxVerificationStatus
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.MXVerificationStatus Get (string Domain)
            {

                return mainBase.mxVerificationStatus.Get(Domain);
            }




            /// <param name="MXVerificationStatusBody">The body of the request.</param>
            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.MXVerificationStatus Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.MXVerificationStatus MXVerificationStatusBody, string Domain)
            {

                return mainBase.mxVerificationStatus.Update(MXVerificationStatusBody, Domain);
            }


        }
        #endregion



        #region OrganizationName

        /// <summary>A wrapper class for the OrganizationName resource.</summary>
        public class OrganizationName
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.OrganizationName Get (string Domain)
            {

                return mainBase.organizationName.Get(Domain);
            }




            /// <param name="OrganizationNameBody">The body of the request.</param>
            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.OrganizationName Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.OrganizationName OrganizationNameBody, string Domain)
            {

                return mainBase.organizationName.Update(OrganizationNameBody, Domain);
            }


        }
        #endregion



        #region ProductVersion

        /// <summary>A wrapper class for the ProductVersion resource.</summary>
        public class ProductVersion
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.Edition Get (string Domain)
            {

                return mainBase.productVersion.Get(Domain);
            }


        }
        #endregion



        #region SsoSettings

        /// <summary>A wrapper class for the SsoSettings resource.</summary>
        public class SsoSettings
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.SsoSettings Get (string Domain)
            {

                return mainBase.ssoSettings.Get(Domain);
            }




            /// <param name="SsoSettingsBody">The body of the request.</param>
            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.SsoSettings Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.SsoSettings SsoSettingsBody, string Domain)
            {

                return mainBase.ssoSettings.Update(SsoSettingsBody, Domain);
            }


        }
        #endregion



        #region SsoSigningKey

        /// <summary>A wrapper class for the SsoSigningKey resource.</summary>
        public class SsoSigningKey
        {





            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.SsoSigningKey Get (string Domain)
            {

                return mainBase.ssoSigningKey.Get(Domain);
            }




            /// <param name="SsoSigningKeyBody">The body of the request.</param>
            /// <param name="Domain"></param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.SsoSigningKey Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.SsoSigningKey SsoSigningKeyBody, string Domain)
            {

                return mainBase.ssoSigningKey.Update(SsoSigningKeyBody, Domain);
            }


        }
        #endregion

        #endregion

    }
}



namespace gShell.dotNet
{
    using System;
    using System.Collections.Generic;

    using gShell.dotNet;
    using gShell.dotNet.Utilities.OAuth2;

    using adminsettings_v1 = Google.Apis.admin.Adminsettings.adminsettings_v1;
    using Data = Google.Apis.admin.Adminsettings.adminsettings_v1.Data;

    /// <summary>The dotNet gShell version of the admin api.</summary>
    public class Adminsettings : ServiceWrapper<adminsettings_v1.AdminsettingsService>, IServiceWrapper<Google.Apis.Services.IClientService>
    {

        protected override bool worksWithGmail { get { return false; } }

        /// <summary>Creates a new adminsettings_v1.Adminsettings service.</summary>
        /// <param name="domain">The domain to which this service will be authenticated.</param>
        /// <param name="authInfo">The authenticated AuthInfo for this user and domain.</param>
        /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>

        protected override adminsettings_v1.AdminsettingsService CreateNewService(string domain, AuthenticatedUserInfo authInfo, string serviceAccountUser = null)
        {
            return new adminsettings_v1.AdminsettingsService(OAuth2Base.GetGdataInitializer(domain, authInfo));
        }

        /// <summary>Returns the api name and version in {name}:{version} format.</summary>
        public override string apiNameAndVersion { get { return "admin:adminsettings_v1"; } }


        /// <summary>Gets or sets the adminSecondaryEmail resource class.</summary>
        public AdminSecondaryEmail adminSecondaryEmail{ get; set; }

        /// <summary>Gets or sets the countryCode resource class.</summary>
        public CountryCode countryCode{ get; set; }

        /// <summary>Gets or sets the creationTime resource class.</summary>
        public CreationTime creationTime{ get; set; }

        /// <summary>Gets or sets the currentUsers resource class.</summary>
        public CurrentUsers currentUsers{ get; set; }

        /// <summary>Gets or sets the customLogo resource class.</summary>
        public CustomLogo customLogo{ get; set; }

        /// <summary>Gets or sets the customerPin resource class.</summary>
        public CustomerPin customerPin{ get; set; }

        /// <summary>Gets or sets the defaultLanguage resource class.</summary>
        public DefaultLanguage defaultLanguage{ get; set; }

        /// <summary>Gets or sets the emailGateway resource class.</summary>
        public EmailGateway emailGateway{ get; set; }

        /// <summary>Gets or sets the emailRouting resource class.</summary>
        public EmailRouting emailRouting{ get; set; }

        /// <summary>Gets or sets the maximumUsers resource class.</summary>
        public MaximumUsers maximumUsers{ get; set; }

        /// <summary>Gets or sets the mxVerificationStatus resource class.</summary>
        public MxVerificationStatus mxVerificationStatus{ get; set; }

        /// <summary>Gets or sets the organizationName resource class.</summary>
        public OrganizationName organizationName{ get; set; }

        /// <summary>Gets or sets the productVersion resource class.</summary>
        public ProductVersion productVersion{ get; set; }

        /// <summary>Gets or sets the ssoSettings resource class.</summary>
        public SsoSettings ssoSettings{ get; set; }

        /// <summary>Gets or sets the ssoSigningKey resource class.</summary>
        public SsoSigningKey ssoSigningKey{ get; set; }

        public Adminsettings()
        {

            adminSecondaryEmail = new AdminSecondaryEmail();
            countryCode = new CountryCode();
            creationTime = new CreationTime();
            currentUsers = new CurrentUsers();
            customLogo = new CustomLogo();
            customerPin = new CustomerPin();
            defaultLanguage = new DefaultLanguage();
            emailGateway = new EmailGateway();
            emailRouting = new EmailRouting();
            maximumUsers = new MaximumUsers();
            mxVerificationStatus = new MxVerificationStatus();
            organizationName = new OrganizationName();
            productVersion = new ProductVersion();
            ssoSettings = new SsoSettings();
            ssoSigningKey = new SsoSigningKey();
        }



        /// <summary>The "adminSecondaryEmail" collection of methods.</summary>
        public class AdminSecondaryEmail
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.AdminSecondaryEmail Get (string Domain)
            {
                return GetService().AdminSecondaryEmail.Get(Domain).Execute();
            }


            /// <param name="AdminSecondaryEmailBody">The body of the request.</param>
            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.AdminSecondaryEmail Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.AdminSecondaryEmail AdminSecondaryEmailBody, string Domain)
            {
                return GetService().AdminSecondaryEmail.Update(AdminSecondaryEmailBody, Domain).Execute();
            }

        }

        /// <summary>The "countryCode" collection of methods.</summary>
        public class CountryCode
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.CountryCode Get (string Domain)
            {
                return GetService().CountryCode.Get(Domain).Execute();
            }

        }

        /// <summary>The "creationTime" collection of methods.</summary>
        public class CreationTime
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.CreationTime Get (string Domain)
            {
                return GetService().CreationTime.Get(Domain).Execute();
            }

        }

        /// <summary>The "currentUsers" collection of methods.</summary>
        public class CurrentUsers
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.CurrentNumberOfUsers Get (string Domain)
            {
                return GetService().CurrentUsers.Get(Domain).Execute();
            }

        }

        /// <summary>The "customLogo" collection of methods.</summary>
        public class CustomLogo
        {





            /// <param name="CustomLogoBody">The body of the request.</param>
            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.CustomLogo Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.CustomLogo CustomLogoBody, string Domain)
            {
                return GetService().CustomLogo.Update(CustomLogoBody, Domain).Execute();
            }

        }

        /// <summary>The "customerPin" collection of methods.</summary>
        public class CustomerPin
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.CustomerPin Get (string Domain)
            {
                return GetService().CustomerPin.Get(Domain).Execute();
            }

        }

        /// <summary>The "defaultLanguage" collection of methods.</summary>
        public class DefaultLanguage
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.DefaultLanguage Get (string Domain)
            {
                return GetService().DefaultLanguage.Get(Domain).Execute();
            }


            /// <param name="DefaultLanguageBody">The body of the request.</param>
            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.DefaultLanguage Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.DefaultLanguage DefaultLanguageBody, string Domain)
            {
                return GetService().DefaultLanguage.Update(DefaultLanguageBody, Domain).Execute();
            }

        }

        /// <summary>The "emailGateway" collection of methods.</summary>
        public class EmailGateway
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.Gateway Get (string Domain)
            {
                return GetService().EmailGateway.Get(Domain).Execute();
            }


            /// <param name="GatewayBody">The body of the request.</param>
            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.Gateway Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.Gateway GatewayBody, string Domain)
            {
                return GetService().EmailGateway.Update(GatewayBody, Domain).Execute();
            }

        }

        /// <summary>The "emailRouting" collection of methods.</summary>
        public class EmailRouting
        {





            /// <param name="RoutingBody">The body of the request.</param>
            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.Routing Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.Routing RoutingBody, string Domain)
            {
                return GetService().EmailRouting.Update(RoutingBody, Domain).Execute();
            }

        }

        /// <summary>The "maximumUsers" collection of methods.</summary>
        public class MaximumUsers
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.MaximumNumberOfUsers Get (string Domain)
            {
                return GetService().MaximumUsers.Get(Domain).Execute();
            }

        }

        /// <summary>The "mxVerificationStatus" collection of methods.</summary>
        public class MxVerificationStatus
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.MXVerificationStatus Get (string Domain)
            {
                return GetService().MxVerificationStatus.Get(Domain).Execute();
            }


            /// <param name="MXVerificationStatusBody">The body of the request.</param>
            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.MXVerificationStatus Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.MXVerificationStatus MXVerificationStatusBody, string Domain)
            {
                return GetService().MxVerificationStatus.Update(MXVerificationStatusBody, Domain).Execute();
            }

        }

        /// <summary>The "organizationName" collection of methods.</summary>
        public class OrganizationName
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.OrganizationName Get (string Domain)
            {
                return GetService().OrganizationName.Get(Domain).Execute();
            }


            /// <param name="OrganizationNameBody">The body of the request.</param>
            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.OrganizationName Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.OrganizationName OrganizationNameBody, string Domain)
            {
                return GetService().OrganizationName.Update(OrganizationNameBody, Domain).Execute();
            }

        }

        /// <summary>The "productVersion" collection of methods.</summary>
        public class ProductVersion
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.Edition Get (string Domain)
            {
                return GetService().ProductVersion.Get(Domain).Execute();
            }

        }

        /// <summary>The "ssoSettings" collection of methods.</summary>
        public class SsoSettings
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.SsoSettings Get (string Domain)
            {
                return GetService().SsoSettings.Get(Domain).Execute();
            }


            /// <param name="SsoSettingsBody">The body of the request.</param>
            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.SsoSettings Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.SsoSettings SsoSettingsBody, string Domain)
            {
                return GetService().SsoSettings.Update(SsoSettingsBody, Domain).Execute();
            }

        }

        /// <summary>The "ssoSigningKey" collection of methods.</summary>
        public class SsoSigningKey
        {





            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.SsoSigningKey Get (string Domain)
            {
                return GetService().SsoSigningKey.Get(Domain).Execute();
            }


            /// <param name="SsoSigningKeyBody">The body of the request.</param>
            /// <param name="Domain"></param>
            /// <param name="gShellServiceAccount">The optional email address the service account should impersonate.</param>
            public Google.Apis.admin.Adminsettings.adminsettings_v1.Data.SsoSigningKey Update (Google.Apis.admin.Adminsettings.adminsettings_v1.Data.SsoSigningKey SsoSigningKeyBody, string Domain)
            {
                return GetService().SsoSigningKey.Update(SsoSigningKeyBody, Domain).Execute();
            }

        }

    }
}