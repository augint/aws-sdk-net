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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the DecodeAuthorizationMessage operation.
    /// Decodes additional information about the authorization status of a request from an
    /// encoded message returned in response to an AWS request. 
    /// 
    ///  
    /// <para>
    /// For example, if a user is not authorized to perform an action that he or she has requested,
    /// the request returns a <code>Client.UnauthorizedOperation</code> response (an HTTP
    /// 403 response). Some AWS actions additionally return an encoded message that can provide
    /// details about this authorization failure. 
    /// </para>
    ///  <note> Only certain AWS actions return an encoded authorization message. The documentation
    /// for an individual action indicates whether that action returns an encoded message
    /// in addition to returning an HTTP code. </note> 
    /// <para>
    /// The message is encoded because the details of the authorization status can constitute
    /// privileged information that the user who requested the action should not see. To decode
    /// an authorization status message, a user must be granted permissions via an IAM policy
    /// to request the <code>DecodeAuthorizationMessage</code> (<code>sts:DecodeAuthorizationMessage</code>)
    /// action. 
    /// </para>
    ///  
    /// <para>
    /// The decoded message includes the following type of information: 
    /// </para>
    ///  <ul> <li>Whether the request was denied due to an explicit deny or due to the absence
    /// of an explicit allow. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-denyallow">Determining
    /// Whether a Request is Allowed or Denied</a> in the <i>IAM User Guide</i>. </li> <li>The
    /// principal who made the request.</li> <li>The requested action.</li> <li>The requested
    /// resource.</li> <li>The values of condition keys in the context of the user's request.</li>
    /// </ul>
    /// </summary>
    public partial class DecodeAuthorizationMessageRequest : AmazonSecurityTokenServiceRequest
    {
        private string _encodedMessage;

        /// <summary>
        /// Gets and sets the property EncodedMessage. 
        /// <para>
        /// The encoded message that was returned with the response.
        /// </para>
        /// </summary>
        public string EncodedMessage
        {
            get { return this._encodedMessage; }
            set { this._encodedMessage = value; }
        }

        // Check to see if EncodedMessage property is set
        internal bool IsSetEncodedMessage()
        {
            return this._encodedMessage != null;
        }

    }
}