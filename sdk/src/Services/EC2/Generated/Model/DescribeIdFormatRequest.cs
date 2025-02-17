/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeIdFormat operation.
    /// Describes the ID format settings for your resources on a per-region basis, for example,
    /// to view which resource types are enabled for longer IDs. This request only returns
    /// information about resource types whose ID formats can be modified; it does not return
    /// information about other resource types. 
    /// 
    ///  
    /// <para>
    /// The following resource types support longer IDs: <code>instance</code> | <code>reservation</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// These settings apply to the IAM user who makes the request; they do not apply to the
    /// entire AWS account. By default, an IAM user defaults to the same settings as the root
    /// user, unless they explicitly override the settings by running the <a>ModifyIdFormat</a>
    /// command. Resources created with longer IDs are visible to all IAM users, regardless
    /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
    /// command for the resource type.
    /// </para>
    /// </summary>
    public partial class DescribeIdFormatRequest : AmazonEC2Request
    {
        private string _resource;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The type of resource.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}