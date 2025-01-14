// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of RestorableDatabaseAccount and their operations over its parent. </summary>
    public partial class RestorableDatabaseAccountCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RestorableDatabaseAccountsRestOperations _restorableDatabaseAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorableDatabaseAccountCollection"/> class for mocking. </summary>
        protected RestorableDatabaseAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of RestorableDatabaseAccountCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RestorableDatabaseAccountCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restorableDatabaseAccountsRestClient = new RestorableDatabaseAccountsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Subscription.ResourceType;

        // Collection level operations.

        /// <summary> Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission. </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="instanceId"/> is null. </exception>
        public virtual Response<RestorableDatabaseAccount> Get(string location, string instanceId, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _restorableDatabaseAccountsRestClient.GetByLocation(Id.SubscriptionId, location, instanceId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDatabaseAccount(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission. </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<RestorableDatabaseAccount>> GetAsync(string location, string instanceId, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorableDatabaseAccountsRestClient.GetByLocationAsync(Id.SubscriptionId, location, instanceId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RestorableDatabaseAccount(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="instanceId"/> is null. </exception>
        public virtual Response<RestorableDatabaseAccount> GetIfExists(string location, string instanceId, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorableDatabaseAccountsRestClient.GetByLocation(Id.SubscriptionId, location, instanceId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<RestorableDatabaseAccount>(null, response.GetRawResponse())
                    : Response.FromValue(new RestorableDatabaseAccount(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<RestorableDatabaseAccount>> GetIfExistsAsync(string location, string instanceId, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _restorableDatabaseAccountsRestClient.GetByLocationAsync(Id.SubscriptionId, location, instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<RestorableDatabaseAccount>(null, response.GetRawResponse())
                    : Response.FromValue(new RestorableDatabaseAccount(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="instanceId"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string location, string instanceId, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(location, instanceId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string location, string instanceId, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(location, instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the restorable Azure Cosmos DB database accounts available under the subscription and in a region.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&apos; permission. </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableDatabaseAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableDatabaseAccount> GetAll(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Page<RestorableDatabaseAccount> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restorableDatabaseAccountsRestClient.ListByLocation(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDatabaseAccount(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists all the restorable Azure Cosmos DB database accounts available under the subscription and in a region.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&apos; permission. </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableDatabaseAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableDatabaseAccount> GetAllAsync(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            async Task<Page<RestorableDatabaseAccount>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restorableDatabaseAccountsRestClient.ListByLocationAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDatabaseAccount(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="RestorableDatabaseAccount" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(RestorableDatabaseAccount.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="RestorableDatabaseAccount" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(RestorableDatabaseAccount.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, RestorableDatabaseAccount, RestorableDatabaseAccountData> Construct() { }
    }
}
