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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents a condition to be compared with an attribute value. This condition can
    /// be used with <i>DeleteItem</i>, <i>PutItem</i> or <i>UpdateItem</i> operations; if
    /// the comparison evaluates to true, the operation succeeds; if not, the operation fails.
    /// You can use <i>ExpectedAttributeValue</i> in one of two different ways:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Use <i>AttributeValueList</i> to specify one or more values to compare against an
    /// attribute. Use <i>ComparisonOperator</i> to specify how you want to perform the comparison.
    /// If the comparison evaluates to true, then the conditional operation succeeds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <i>Value</i> to specify a value that DynamoDB will compare against an attribute.
    /// If the values match, then <i>ExpectedAttributeValue</i> evaluates to true and the
    /// conditional operation succeeds. Optionally, you can also set <i>Exists</i> to false,
    /// indicating that you <i>do not</i> expect to find the attribute value in the table.
    /// In this case, the conditional operation succeeds only if the comparison evaluates
    /// to false.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// <i>Value</i> and <i>Exists</i> are incompatible with <i>AttributeValueList</i> and
    /// <i>ComparisonOperator</i>. Note that if you use both sets of parameters at once, DynamoDB
    /// will return a <i>ValidationException</i> exception.
    /// </para>
    /// </summary>
    public partial class ExpectedAttributeValue
    {
        private List<AttributeValue> _attributeValueList = new List<AttributeValue>();
        private ComparisonOperator _comparisonOperator;
        private bool? _exists;
        private AttributeValue _value;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ExpectedAttributeValue() { }

        /// <summary>
        /// Instantiates ExpectedAttributeValue with the parameterized properties
        /// </summary>
        /// <param name="value">Sets the ExpectedAttributeValue Value property</param>
        public ExpectedAttributeValue(AttributeValue value)
        {
            _value = value;
        }

        /// <summary>
        /// Instantiates ExpectedAttributeValue with the parameterized properties
        /// </summary>
        /// <param name="exists">Causes DynamoDB to evaluate the value before attempting a conditional operation: <ul> <li> If <i>Exists</i> is <code>true</code>, DynamoDB will check to see if that attribute value already exists in the table. If it is found, then the operation succeeds. If it is not found, the operation fails with a <i>ConditionalCheckFailedException</i>. </li> <li> If <i>Exists</i> is <code>false</code>, DynamoDB assumes that the attribute value does not exist in the table. If in fact the value does not exist, then the assumption is valid and the operation succeeds. If the value is found, despite the assumption that it does not exist, the operation fails with a <i>ConditionalCheckFailedException</i>. </li> </ul> The default setting for <i>Exists</i> is <code>true</code>. If you supply a <i>Value</i> all by itself, DynamoDB assumes the attribute exists: You don&#39;t have to set <i>Exists</i> to <code>true</code>, because it is implied. DynamoDB returns a <i>ValidationException</i> if: <ul> <li> <i>Exists</i> is <code>true</code> but there is no <i>Value</i> to check. (You expect a value to exist, but don&#39;t specify what that value is.) </li> <li> <i>Exists</i> is <code>false</code> but you also provide a <i>Value</i>. (You cannot expect an attribute to have a value, while also expecting it not to exist.) </li> </ul></param>
        public ExpectedAttributeValue(bool exists)
        {
            _exists = exists;
        }

        /// <summary>
        /// Gets and sets the property AttributeValueList. 
        /// <para>
        /// One or more values to evaluate against the supplied attribute. The number of values
        /// in the list depends on the <i>ComparisonOperator</i> being used.
        /// </para>
        ///  
        /// <para>
        /// For type Number, value comparisons are numeric.
        /// </para>
        ///  
        /// <para>
        /// String value comparisons for greater than, equals, or less than are based on ASCII
        /// character code values. For example, <code>a</code> is greater than <code>A</code>,
        /// and <code>a</code> is greater than <code>B</code>. For a list of code values, see
        /// <a href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>.
        /// </para>
        ///  
        /// <para>
        /// For Binary, DynamoDB treats each byte of the binary data as unsigned when it compares
        /// binary values.
        /// </para>
        ///  
        /// <para>
        /// For information on specifying data types in JSON, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataFormat.html">JSON
        /// Data Format</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<AttributeValue> AttributeValueList
        {
            get { return this._attributeValueList; }
            set { this._attributeValueList = value; }
        }

        // Check to see if AttributeValueList property is set
        internal bool IsSetAttributeValueList()
        {
            return this._attributeValueList != null && this._attributeValueList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// A comparator for evaluating attributes in the <i>AttributeValueList</i>. For example,
        /// equals, greater than, less than, etc.
        /// </para>
        ///  
        /// <para>
        /// The following comparison operators are available:
        /// </para>
        ///  
        /// <para>
        /// <code>EQ | NE | LE | LT | GE | GT | NOT_NULL | NULL | CONTAINS | NOT_CONTAINS | BEGINS_WITH
        /// | IN | BETWEEN</code>
        /// </para>
        ///  
        /// <para>
        /// The following are descriptions of each comparison operator.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>EQ</code> : Equal. <code>EQ</code> is supported for all datatypes, including
        /// lists and maps.
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, Binary, String Set, Number Set, or Binary Set. If an item contains
        /// an <i>AttributeValue</i> element of a different type than the one provided in the
        /// request, the value does not match. For example, <code>{"S":"6"}</code> does not equal
        /// <code>{"N":"6"}</code>. Also, <code>{"N":"6"}</code> does not equal <code>{"NS":["6",
        /// "2", "1"]}</code>.
        /// </para>
        ///   </li> <li> 
        /// <para>
        /// <code>NE</code> : Not equal. <code>NE</code> is supported for all datatypes, including
        /// lists and maps.
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        /// Number, Binary, String Set, Number Set, or Binary Set. If an item contains an <i>AttributeValue</i>
        /// of a different type than the one provided in the request, the value does not match.
        /// For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>. Also, <code>{"N":"6"}</code>
        /// does not equal <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///   </li> <li> 
        /// <para>
        /// <code>LE</code> : Less than or equal. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i>
        /// element of a different type than the one provided in the request, the value does not
        /// match. For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also, <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///   </li> <li> 
        /// <para>
        /// <code>LT</code> : Less than. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        /// Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i> element
        /// of a different type than the one provided in the request, the value does not match.
        /// For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>. Also, <code>{"N":"6"}</code>
        /// does not compare to <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///   </li> <li> 
        /// <para>
        /// <code>GE</code> : Greater than or equal. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i>
        /// element of a different type than the one provided in the request, the value does not
        /// match. For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also, <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///   </li> <li> 
        /// <para>
        /// <code>GT</code> : Greater than. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i>
        /// element of a different type than the one provided in the request, the value does not
        /// match. For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also, <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///   </li> <li> 
        /// <para>
        /// <code>NOT_NULL</code> : The attribute exists. <code>NOT_NULL</code> is supported for
        /// all datatypes, including lists and maps.
        /// </para>
        ///  <note>
        /// <para>
        /// This operator tests for the existence of an attribute, not its data type. If the data
        /// type of attribute "<code>a</code>" is null, and you evaluate it using <code>NOT_NULL</code>,
        /// the result is a Boolean <i>true</i>. This result is because the attribute "<code>a</code>"
        /// exists; its data type is not relevant to the <code>NOT_NULL</code> comparison operator.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// <code>NULL</code> : The attribute does not exist. <code>NULL</code> is supported for
        /// all datatypes, including lists and maps.
        /// </para>
        ///  <note>
        /// <para>
        /// This operator tests for the nonexistence of an attribute, not its data type. If the
        /// data type of attribute "<code>a</code>" is null, and you evaluate it using <code>NULL</code>,
        /// the result is a Boolean <i>false</i>. This is because the attribute "<code>a</code>"
        /// exists; its data type is not relevant to the <code>NULL</code> comparison operator.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// <code>CONTAINS</code> : Checks for a subsequence, or value in a set.
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If the target attribute of the comparison
        /// is of type String, then the operator checks for a substring match. If the target attribute
        /// of the comparison is of type Binary, then the operator looks for a subsequence of
        /// the target that matches the input. If the target attribute of the comparison is a
        /// set ("<code>SS</code>", "<code>NS</code>", or "<code>BS</code>"), then the operator
        /// evaluates to true if it finds an exact match with any member of the set.
        /// </para>
        ///  
        /// <para>
        /// CONTAINS is supported for lists: When evaluating "<code>a CONTAINS b</code>", "<code>a</code>"
        /// can be a list; however, "<code>b</code>" cannot be a set, a map, or a list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>NOT_CONTAINS</code> : Checks for absence of a subsequence, or absence of a value
        /// in a set.
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If the target attribute of the comparison
        /// is a String, then the operator checks for the absence of a substring match. If the
        /// target attribute of the comparison is Binary, then the operator checks for the absence
        /// of a subsequence of the target that matches the input. If the target attribute of
        /// the comparison is a set ("<code>SS</code>", "<code>NS</code>", or "<code>BS</code>"),
        /// then the operator evaluates to true if it <i>does not</i> find an exact match with
        /// any member of the set.
        /// </para>
        ///  
        /// <para>
        /// NOT_CONTAINS is supported for lists: When evaluating "<code>a NOT CONTAINS b</code>",
        /// "<code>a</code>" can be a list; however, "<code>b</code>" cannot be a set, a map,
        /// or a list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>BEGINS_WITH</code> : Checks for a prefix. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String
        /// or Binary (not a Number or a set type). The target attribute of the comparison must
        /// be of type String or Binary (not a Number or a set type).
        /// </para>
        ///   </li> <li> 
        /// <para>
        /// <code>IN</code> : Checks for matching elements within two sets.
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain one or more <i>AttributeValue</i> elements of
        /// type String, Number, or Binary (not a set type). These attributes are compared against
        /// an existing set type attribute of an item. If any elements of the input set are present
        /// in the item attribute, the expression evaluates to true.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>BETWEEN</code> : Greater than or equal to the first value, and less than or
        /// equal to the second value. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> must contain two <i>AttributeValue</i> elements of the same
        /// type, either String, Number, or Binary (not a set type). A target attribute matches
        /// if the target value is greater than, or equal to, the first element and less than,
        /// or equal to, the second element. If an item contains an <i>AttributeValue</i> element
        /// of a different type than the one provided in the request, the value does not match.
        /// For example, <code>{"S":"6"}</code> does not compare to <code>{"N":"6"}</code>. Also,
        /// <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2", "1"]}</code>
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ComparisonOperator ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property Exists. 
        /// <para>
        /// Causes DynamoDB to evaluate the value before attempting a conditional operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <i>Exists</i> is <code>true</code>, DynamoDB will check to see if that attribute
        /// value already exists in the table. If it is found, then the operation succeeds. If
        /// it is not found, the operation fails with a <i>ConditionalCheckFailedException</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <i>Exists</i> is <code>false</code>, DynamoDB assumes that the attribute value
        /// does not exist in the table. If in fact the value does not exist, then the assumption
        /// is valid and the operation succeeds. If the value is found, despite the assumption
        /// that it does not exist, the operation fails with a <i>ConditionalCheckFailedException</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default setting for <i>Exists</i> is <code>true</code>. If you supply a <i>Value</i>
        /// all by itself, DynamoDB assumes the attribute exists: You don&#39;t have to set <i>Exists</i>
        /// to <code>true</code>, because it is implied.
        /// </para>
        ///  
        /// <para>
        /// DynamoDB returns a <i>ValidationException</i> if:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <i>Exists</i> is <code>true</code> but there is no <i>Value</i> to check. (You expect
        /// a value to exist, but don&#39;t specify what that value is.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <i>Exists</i> is <code>false</code> but you also provide a <i>Value</i>. (You cannot
        /// expect an attribute to have a value, while also expecting it not to exist.)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool Exists
        {
            get { return this._exists.GetValueOrDefault(); }
            set { this._exists = value; }
        }

        // Check to see if Exists property is set
        internal bool IsSetExists()
        {
            return this._exists.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value.
        /// </summary>
        public AttributeValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}