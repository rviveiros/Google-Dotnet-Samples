﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 2017-09-26
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Sqladmin v1beta4 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and configures Cloud SQL instances, which provide fully-managed MySQL databases.
// API Documentation Link https://cloud.google.com/sql/docs/reference/latest
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Sqladmin/v1beta4/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Sqladmin.v1beta4/ 
// Install Command: PM>  Install-Package Google.Apis.Sqladmin.v1beta4
//
//------------------------------------------------------------------------------  
using Google.Apis.Sqladmin.v1beta4;
using Google.Apis.Sqladmin.v1beta4.Data;
using System;

namespace GoogleSamplecSharpSample.Sqladminv1beta4.Methods
{
  
    public static class SslCertsSample
    {


        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key and signed by a private key specific to the target instance. Users may use the certificate to authenticate as themselves when connecting to the database. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/sslCerts/createEphemeral
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the Cloud SQL project.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>SslCertResponse</returns>
        public static SslCert CreateEphemeral(SqladminService service, string project, string instance, SslCertsCreateEphemeralRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.SslCerts.CreateEphemeral(body, project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SslCerts.CreateEphemeral failed.", ex);
            }
        }

        /// <summary>
        /// Deletes the SSL certificate. The change will not take effect until the instance is restarted. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/sslCerts/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance to be deleted.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="sha1Fingerprint">Sha1 FingerPrint.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(SqladminService service, string project, string instance, string sha1Fingerprint)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);
                if (sha1Fingerprint == null)
                    throw new ArgumentNullException(sha1Fingerprint);

                // Make the request.
                return service.SslCerts.Delete(project, instance, sha1Fingerprint).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SslCerts.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves a particular SSL certificate. Does not include the private key (required for usage). The private key must be saved from the response to initial creation. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/sslCerts/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="sha1Fingerprint">Sha1 FingerPrint.</param>
        /// <returns>SslCertResponse</returns>
        public static SslCert Get(SqladminService service, string project, string instance, string sha1Fingerprint)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);
                if (sha1Fingerprint == null)
                    throw new ArgumentNullException(sha1Fingerprint);

                // Make the request.
                return service.SslCerts.Get(project, instance, sha1Fingerprint).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SslCerts.Get failed.", ex);
            }
        }

        /// <summary>
        /// Creates an SSL certificate and returns it along with the private key and server certificate authority. The new certificate will not be usable until the instance is restarted. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/sslCerts/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project to which the newly created Cloud SQL instances should belong.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>SslCertsInsertResponseResponse</returns>
        public static SslCertsInsertResponse Insert(SqladminService service, string project, string instance, SslCertsInsertRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.SslCerts.Insert(body, project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SslCerts.Insert failed.", ex);
            }
        }

        /// <summary>
        /// Lists all of the current SSL certificates for the instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/sslCerts/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project for which to list Cloud SQL instances.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <returns>SslCertsListResponseResponse</returns>
        public static SslCertsListResponse List(SqladminService service, string project, string instance)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.SslCerts.List(project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SslCerts.List failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}