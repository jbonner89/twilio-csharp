/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// DeviceResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.DeployedDevices.Fleet 
{

    public class DeviceResource : Resource 
    {
        private static Request BuildFetchRequest(FetchDeviceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/DeployedDevices/Fleets/" + options.PathFleetSid + "/Devices/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Device parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Device </returns> 
        public static DeviceResource Fetch(FetchDeviceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Device parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Device </returns> 
        public static async System.Threading.Tasks.Task<DeviceResource> FetchAsync(FetchDeviceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="pathSid"> A string that uniquely identifies the Device. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Device </returns> 
        public static DeviceResource Fetch(string pathFleetSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchDeviceOptions(pathFleetSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="pathSid"> A string that uniquely identifies the Device. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Device </returns> 
        public static async System.Threading.Tasks.Task<DeviceResource> FetchAsync(string pathFleetSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchDeviceOptions(pathFleetSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteDeviceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Preview,
                "/DeployedDevices/Fleets/" + options.PathFleetSid + "/Devices/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete a specific Device from the Fleet, also removing it from associated Deployments.
        /// </summary>
        ///
        /// <param name="options"> Delete Device parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Device </returns> 
        public static bool Delete(DeleteDeviceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Device from the Fleet, also removing it from associated Deployments.
        /// </summary>
        ///
        /// <param name="options"> Delete Device parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Device </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteDeviceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a specific Device from the Fleet, also removing it from associated Deployments.
        /// </summary>
        ///
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="pathSid"> A string that uniquely identifies the Device. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Device </returns> 
        public static bool Delete(string pathFleetSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteDeviceOptions(pathFleetSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Device from the Fleet, also removing it from associated Deployments.
        /// </summary>
        ///
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="pathSid"> A string that uniquely identifies the Device. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Device </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathFleetSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteDeviceOptions(pathFleetSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateDeviceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/DeployedDevices/Fleets/" + options.PathFleetSid + "/Devices",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new Device in the Fleet, optionally giving it a unique name, friendly name, and assigning to a Deployment
        /// and/or human identity.
        /// </summary>
        ///
        /// <param name="options"> Create Device parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Device </returns> 
        public static DeviceResource Create(CreateDeviceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Device in the Fleet, optionally giving it a unique name, friendly name, and assigning to a Deployment
        /// and/or human identity.
        /// </summary>
        ///
        /// <param name="options"> Create Device parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Device </returns> 
        public static async System.Threading.Tasks.Task<DeviceResource> CreateAsync(CreateDeviceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Device in the Fleet, optionally giving it a unique name, friendly name, and assigning to a Deployment
        /// and/or human identity.
        /// </summary>
        ///
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="uniqueName"> A unique, addressable name of this Device. </param>
        /// <param name="friendlyName"> A human readable description for this Device. </param>
        /// <param name="identity"> An identifier of the Device user. </param>
        /// <param name="deploymentSid"> The unique SID of the Deployment group. </param>
        /// <param name="enabled"> The enabled </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Device </returns> 
        public static DeviceResource Create(string pathFleetSid, string uniqueName = null, string friendlyName = null, string identity = null, string deploymentSid = null, bool? enabled = null, ITwilioRestClient client = null)
        {
            var options = new CreateDeviceOptions(pathFleetSid){UniqueName = uniqueName, FriendlyName = friendlyName, Identity = identity, DeploymentSid = deploymentSid, Enabled = enabled};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Device in the Fleet, optionally giving it a unique name, friendly name, and assigning to a Deployment
        /// and/or human identity.
        /// </summary>
        ///
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="uniqueName"> A unique, addressable name of this Device. </param>
        /// <param name="friendlyName"> A human readable description for this Device. </param>
        /// <param name="identity"> An identifier of the Device user. </param>
        /// <param name="deploymentSid"> The unique SID of the Deployment group. </param>
        /// <param name="enabled"> The enabled </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Device </returns> 
        public static async System.Threading.Tasks.Task<DeviceResource> CreateAsync(string pathFleetSid, string uniqueName = null, string friendlyName = null, string identity = null, string deploymentSid = null, bool? enabled = null, ITwilioRestClient client = null)
        {
            var options = new CreateDeviceOptions(pathFleetSid){UniqueName = uniqueName, FriendlyName = friendlyName, Identity = identity, DeploymentSid = deploymentSid, Enabled = enabled};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadDeviceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/DeployedDevices/Fleets/" + options.PathFleetSid + "/Devices",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Devices belonging to the Fleet.
        /// </summary>
        ///
        /// <param name="options"> Read Device parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Device </returns> 
        public static ResourceSet<DeviceResource> Read(ReadDeviceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<DeviceResource>.FromJson("devices", response.Content);
            return new ResourceSet<DeviceResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Devices belonging to the Fleet.
        /// </summary>
        ///
        /// <param name="options"> Read Device parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Device </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<DeviceResource>> ReadAsync(ReadDeviceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<DeviceResource>.FromJson("devices", response.Content);
            return new ResourceSet<DeviceResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Devices belonging to the Fleet.
        /// </summary>
        ///
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="deploymentSid"> Find all Devices grouped under the specified Deployment. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Device </returns> 
        public static ResourceSet<DeviceResource> Read(string pathFleetSid, string deploymentSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadDeviceOptions(pathFleetSid){DeploymentSid = deploymentSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Devices belonging to the Fleet.
        /// </summary>
        ///
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="deploymentSid"> Find all Devices grouped under the specified Deployment. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Device </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<DeviceResource>> ReadAsync(string pathFleetSid, string deploymentSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadDeviceOptions(pathFleetSid){DeploymentSid = deploymentSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        ///
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<DeviceResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<DeviceResource>.FromJson("devices", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<DeviceResource> NextPage(Page<DeviceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<DeviceResource>.FromJson("devices", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<DeviceResource> PreviousPage(Page<DeviceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<DeviceResource>.FromJson("devices", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateDeviceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/DeployedDevices/Fleets/" + options.PathFleetSid + "/Devices/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update the given properties of a specific Device in the Fleet, giving it a friendly name, assigning to a Deployment,
        /// or a human identity.
        /// </summary>
        ///
        /// <param name="options"> Update Device parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Device </returns> 
        public static DeviceResource Update(UpdateDeviceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update the given properties of a specific Device in the Fleet, giving it a friendly name, assigning to a Deployment,
        /// or a human identity.
        /// </summary>
        ///
        /// <param name="options"> Update Device parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Device </returns> 
        public static async System.Threading.Tasks.Task<DeviceResource> UpdateAsync(UpdateDeviceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update the given properties of a specific Device in the Fleet, giving it a friendly name, assigning to a Deployment,
        /// or a human identity.
        /// </summary>
        ///
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="pathSid"> A string that uniquely identifies the Device. </param>
        /// <param name="friendlyName"> A human readable description for this Device. </param>
        /// <param name="identity"> An identifier of the Device user. </param>
        /// <param name="deploymentSid"> The unique SID of the Deployment group. </param>
        /// <param name="enabled"> The enabled </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Device </returns> 
        public static DeviceResource Update(string pathFleetSid, string pathSid, string friendlyName = null, string identity = null, string deploymentSid = null, bool? enabled = null, ITwilioRestClient client = null)
        {
            var options = new UpdateDeviceOptions(pathFleetSid, pathSid){FriendlyName = friendlyName, Identity = identity, DeploymentSid = deploymentSid, Enabled = enabled};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update the given properties of a specific Device in the Fleet, giving it a friendly name, assigning to a Deployment,
        /// or a human identity.
        /// </summary>
        ///
        /// <param name="pathFleetSid"> The fleet_sid </param>
        /// <param name="pathSid"> A string that uniquely identifies the Device. </param>
        /// <param name="friendlyName"> A human readable description for this Device. </param>
        /// <param name="identity"> An identifier of the Device user. </param>
        /// <param name="deploymentSid"> The unique SID of the Deployment group. </param>
        /// <param name="enabled"> The enabled </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Device </returns> 
        public static async System.Threading.Tasks.Task<DeviceResource> UpdateAsync(string pathFleetSid, string pathSid, string friendlyName = null, string identity = null, string deploymentSid = null, bool? enabled = null, ITwilioRestClient client = null)
        {
            var options = new UpdateDeviceOptions(pathFleetSid, pathSid){FriendlyName = friendlyName, Identity = identity, DeploymentSid = deploymentSid, Enabled = enabled};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a DeviceResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DeviceResource object represented by the provided JSON </returns> 
        public static DeviceResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<DeviceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Device.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// URL of this Device.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// A unique, addressable name of this Device.
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// A human readable description for this Device
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The unique identifier of the Fleet.
        /// </summary>
        [JsonProperty("fleet_sid")]
        public string FleetSid { get; private set; }
        /// <summary>
        /// Device enabled flag.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; private set; }
        /// <summary>
        /// The unique SID that identifies this Account.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// An identifier of the Device user.
        /// </summary>
        [JsonProperty("identity")]
        public string Identity { get; private set; }
        /// <summary>
        /// The unique SID of the Deployment group.
        /// </summary>
        [JsonProperty("deployment_sid")]
        public string DeploymentSid { get; private set; }
        /// <summary>
        /// The date this Device was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Device was updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The date this Device was authenticated.
        /// </summary>
        [JsonProperty("date_authenticated")]
        public DateTime? DateAuthenticated { get; private set; }

        private DeviceResource()
        {

        }
    }

}