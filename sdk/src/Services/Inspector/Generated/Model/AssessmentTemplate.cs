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
    /// Contains information about an Inspector assessment template. This data type is used
    /// as the response element in the <a>DescribeAssessmentTemplates</a> action.
    /// </summary>
    public partial class AssessmentTemplate
    {
        private string _arn;
        private string _assessmentTargetArn;
        private DateTime? _createdAt;
        private int? _durationInSeconds;
        private string _name;
        private List<string> _rulesPackageArns = new List<string>();
        private List<Attribute> _userAttributesForFindings = new List<Attribute>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the assessment template.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentTargetArn. 
        /// <para>
        /// The ARN of the assessment target that corresponds to this assessment template.
        /// </para>
        /// </summary>
        public string AssessmentTargetArn
        {
            get { return this._assessmentTargetArn; }
            set { this._assessmentTargetArn = value; }
        }

        // Check to see if AssessmentTargetArn property is set
        internal bool IsSetAssessmentTargetArn()
        {
            return this._assessmentTargetArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the assessment template is created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The duration in seconds specified for this assessment tempate. The default value is
        /// 3600 seconds (one hour). The maximum value is 86400 seconds (one day).
        /// </para>
        /// </summary>
        public int DurationInSeconds
        {
            get { return this._durationInSeconds.GetValueOrDefault(); }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the assessment template.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// Rules packages specified for this assessment template.
        /// </para>
        /// </summary>
        public List<string> RulesPackageArns
        {
            get { return this._rulesPackageArns; }
            set { this._rulesPackageArns = value; }
        }

        // Check to see if RulesPackageArns property is set
        internal bool IsSetRulesPackageArns()
        {
            return this._rulesPackageArns != null && this._rulesPackageArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserAttributesForFindings. 
        /// <para>
        /// The user-defined attributes that are assigned to every generated finding from the
        /// assessment run that uses this assessment template.
        /// </para>
        /// </summary>
        public List<Attribute> UserAttributesForFindings
        {
            get { return this._userAttributesForFindings; }
            set { this._userAttributesForFindings = value; }
        }

        // Check to see if UserAttributesForFindings property is set
        internal bool IsSetUserAttributesForFindings()
        {
            return this._userAttributesForFindings != null && this._userAttributesForFindings.Count > 0; 
        }

    }
}