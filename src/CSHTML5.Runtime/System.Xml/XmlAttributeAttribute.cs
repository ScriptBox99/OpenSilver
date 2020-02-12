﻿
//===============================================================================
//
//  IMPORTANT NOTICE, PLEASE READ CAREFULLY:
//
//  => This code is licensed under the GNU General Public License (GPL v3). A copy of the license is available at:
//        https://www.gnu.org/licenses/gpl.txt
//
//  => As stated in the license text linked above, "The GNU General Public License does not permit incorporating your program into proprietary programs". It also does not permit incorporating this code into non-GPL-licensed code (such as MIT-licensed code) in such a way that results in a non-GPL-licensed work (please refer to the license text for the precise terms).
//
//  => Licenses that permit proprietary use are available at:
//        http://www.cshtml5.com
//
//  => Copyright 2019 Userware/CSHTML5. This code is part of the CSHTML5 product (cshtml5.com).
//
//===============================================================================



namespace System.Xml.Serialization
{

    using System;
    using System.Xml.Schema;
    /// <summary>
    /// Specifies that the System.Xml.Serialization.XmlSerializer must serialize
    /// the class member as an XML attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    public partial class XmlAttributeAttribute : System.Attribute
    {
        string attributeName;
        Type type;
        string ns;
        string dataType;
        XmlSchemaForm form = XmlSchemaForm.None;

        /// <summary>
        /// Initializes a new instance of the System.Xml.Serialization.XmlAttributeAttribute
        /// class.
        /// </summary>
        public XmlAttributeAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the System.Xml.Serialization.XmlAttributeAttribute
        /// class and specifies the name of the generated XML attribute.
        /// </summary>
        /// <param name="attributeName">
        /// The name of the XML attribute that the System.Xml.Serialization.XmlSerializer
        /// generates.
        /// </param>
        public XmlAttributeAttribute(string attributeName)
        {
            this.attributeName = attributeName;
        }

        /// <summary>
        /// Initializes a new instance of the System.Xml.Serialization.XmlAttributeAttribute
        /// class.
        /// </summary>
        /// <param name="type">The System.Type used to store the attribute.</param>
        public XmlAttributeAttribute(Type type)
        {
            this.type = type;
        }

        /// <summary>
        /// Initializes a new instance of the System.Xml.Serialization.XmlAttributeAttribute
        /// class.
        /// </summary>
        /// <param name="attributeName">The name of the XML attribute that is generated.</param>
        /// <param name="type">The System.Type used to store the attribute.</param>
        public XmlAttributeAttribute(string attributeName, Type type)
        {
            this.attributeName = attributeName;
            this.type = type;
        }

        /// <summary>
        /// Gets or sets the complex type of the XML attribute.
        /// </summary>
        public Type Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// Gets or sets the name of the XML attribute.
        /// </summary>
        public string AttributeName
        {
            get { return attributeName == null ? string.Empty : attributeName; }
            set { attributeName = value; }
        }

        /// <summary>
        /// Gets or sets the XML namespace of the XML attribute.
        /// </summary>
        public string Namespace
        {
            get { return ns; }
            set { ns = value; }
        }

        /// <summary>
        /// Gets or sets the XSD data type of the XML attribute generated by the System.Xml.Serialization.XmlSerializer.
        /// </summary>
        public string DataType
        {
            get { return dataType == null ? string.Empty : dataType; }
            set { dataType = value; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the XML attribute name generated
        /// by the System.Xml.Serialization.XmlSerializer is qualified.
        /// </summary>
        public XmlSchemaForm Form
        {
            get { return form; }
            set { form = value; }
        }
    }
}