// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC.Version1_6.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Graph;
    using Microsoft.Azure.Graph.RBAC;
    using Microsoft.Azure.Graph.RBAC.Version1_6;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Active Directory Key Credential information.
    /// </summary>
    public partial class KeyCredential
    {
        /// <summary>
        /// Initializes a new instance of the KeyCredential class.
        /// </summary>
        public KeyCredential()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyCredential class.
        /// </summary>
        /// <param name="startDate">Start date.</param>
        /// <param name="endDate">End date.</param>
        /// <param name="value">Key value.</param>
        /// <param name="keyId">Key ID.</param>
        /// <param name="usage">Usage. Acceptable values are 'Verify' and
        /// 'Sign'.</param>
        /// <param name="type">Type. Acceptable values are 'AsymmetricX509Cert'
        /// and 'Symmetric'.</param>
        public KeyCredential(System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), string value = default(string), string keyId = default(string), string usage = default(string), string type = default(string))
        {
            StartDate = startDate;
            EndDate = endDate;
            Value = value;
            KeyId = keyId;
            Usage = usage;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets start date.
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets end date.
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets key value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets key ID.
        /// </summary>
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }

        /// <summary>
        /// Gets or sets usage. Acceptable values are 'Verify' and 'Sign'.
        /// </summary>
        [JsonProperty(PropertyName = "usage")]
        public string Usage { get; set; }

        /// <summary>
        /// Gets or sets type. Acceptable values are 'AsymmetricX509Cert' and
        /// 'Symmetric'.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
