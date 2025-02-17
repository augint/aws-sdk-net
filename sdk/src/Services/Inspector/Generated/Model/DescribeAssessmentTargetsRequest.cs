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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAssessmentTargets operation.
    /// Describes the assessment target(s) specified by the assessment target ARN(s).
    /// </summary>
    public partial class DescribeAssessmentTargetsRequest : AmazonInspectorRequest
    {
        private List<string> _assessmentTargetArns = new List<string>();

        /// <summary>
        /// Gets and sets the property AssessmentTargetArns. 
        /// <para>
        /// The ARN(s) specifying the assessment target(s) that you want to describe.
        /// </para>
        /// </summary>
        public List<string> AssessmentTargetArns
        {
            get { return this._assessmentTargetArns; }
            set { this._assessmentTargetArns = value; }
        }

        // Check to see if AssessmentTargetArns property is set
        internal bool IsSetAssessmentTargetArns()
        {
            return this._assessmentTargetArns != null && this._assessmentTargetArns.Count > 0; 
        }

    }
}