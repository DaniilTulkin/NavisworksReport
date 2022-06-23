namespace NavisworksReport
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class exchange
    {

        private exchangeBatchtest batchtestField;

        private string unitsField;

        private string filenameField;

        private string filepathField;

        /// <remarks/>
        public exchangeBatchtest batchtest
        {
            get
            {
                return this.batchtestField;
            }
            set
            {
                this.batchtestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filepath
        {
            get
            {
                return this.filepathField;
            }
            set
            {
                this.filepathField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtest
    {

        private exchangeBatchtestClashtest[] clashtestsField;

        private object selectionsetsField;

        private string nameField;

        private string internal_nameField;

        private string unitsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("clashtest", IsNullable = false)]
        public exchangeBatchtestClashtest[] clashtests
        {
            get
            {
                return this.clashtestsField;
            }
            set
            {
                this.clashtestsField = value;
            }
        }

        /// <remarks/>
        public object selectionsets
        {
            get
            {
                return this.selectionsetsField;
            }
            set
            {
                this.selectionsetsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internal_name
        {
            get
            {
                return this.internal_nameField;
            }
            set
            {
                this.internal_nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtest
    {

        private exchangeBatchtestClashtestLinkage linkageField;

        private object rulesField;

        private exchangeBatchtestClashtestSummary summaryField;

        private exchangeBatchtestClashtestClashresults clashresultsField;

        private string nameField;

        private string test_typeField;

        private string statusField;

        private decimal toleranceField;

        private byte merge_compositesField;

        /// <remarks/>
        public exchangeBatchtestClashtestLinkage linkage
        {
            get
            {
                return this.linkageField;
            }
            set
            {
                this.linkageField = value;
            }
        }

        /// <remarks/>
        public object rules
        {
            get
            {
                return this.rulesField;
            }
            set
            {
                this.rulesField = value;
            }
        }

        /// <remarks/>
        public exchangeBatchtestClashtestSummary summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }

        /// <remarks/>
        public exchangeBatchtestClashtestClashresults clashresults
        {
            get
            {
                return this.clashresultsField;
            }
            set
            {
                this.clashresultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string test_type
        {
            get
            {
                return this.test_typeField;
            }
            set
            {
                this.test_typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tolerance
        {
            get
            {
                return this.toleranceField;
            }
            set
            {
                this.toleranceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte merge_composites
        {
            get
            {
                return this.merge_compositesField;
            }
            set
            {
                this.merge_compositesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestLinkage
    {

        private string modeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestSummary
    {

        private string testtypeField;

        private string teststatusField;

        private int totalField;

        private int newField;

        private int activeField;

        private int reviewedField;

        private int approvedField;

        private int resolvedField;

        /// <remarks/>
        public string testtype
        {
            get
            {
                return this.testtypeField;
            }
            set
            {
                this.testtypeField = value;
            }
        }

        /// <remarks/>
        public string teststatus
        {
            get
            {
                return this.teststatusField;
            }
            set
            {
                this.teststatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int @new
        {
            get
            {
                return this.newField;
            }
            set
            {
                this.newField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int reviewed
        {
            get
            {
                return this.reviewedField;
            }
            set
            {
                this.reviewedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int approved
        {
            get
            {
                return this.approvedField;
            }
            set
            {
                this.approvedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int resolved
        {
            get
            {
                return this.resolvedField;
            }
            set
            {
                this.resolvedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresults
    {

        private exchangeBatchtestClashtestClashresultsClashgroup[] clashgroupField;

        private exchangeBatchtestClashtestClashresultsClashresult[] clashresultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clashgroup")]
        public exchangeBatchtestClashtestClashresultsClashgroup[] clashgroup
        {
            get
            {
                return this.clashgroupField;
            }
            set
            {
                this.clashgroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clashresult")]
        public exchangeBatchtestClashtestClashresultsClashresult[] clashresult
        {
            get
            {
                return this.clashresultField;
            }
            set
            {
                this.clashresultField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroup
    {

        private string descriptionField;

        private string resultstatusField;

        private exchangeBatchtestClashtestClashresultsClashgroupClashpoint clashpointField;

        private exchangeBatchtestClashtestClashresultsClashgroupCreateddate createddateField;

        private exchangeBatchtestClashtestClashresultsClashgroupApproveddate approveddateField;

        private string approvedbyField;

        private string assignedtoField;

        private exchangeBatchtestClashtestClashresultsClashgroupClashobject[] clashobjectsField;

        private exchangeBatchtestClashtestClashresultsClashgroupComment[] commentsField;

        private string nameField;

        private string guidField;

        private string hrefField;

        private string statusField;

        private decimal distanceField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string resultstatus
        {
            get
            {
                return this.resultstatusField;
            }
            set
            {
                this.resultstatusField = value;
            }
        }

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashgroupClashpoint clashpoint
        {
            get
            {
                return this.clashpointField;
            }
            set
            {
                this.clashpointField = value;
            }
        }

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashgroupCreateddate createddate
        {
            get
            {
                return this.createddateField;
            }
            set
            {
                this.createddateField = value;
            }
        }

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashgroupApproveddate approveddate
        {
            get
            {
                return this.approveddateField;
            }
            set
            {
                this.approveddateField = value;
            }
        }

        /// <remarks/>
        public string approvedby
        {
            get
            {
                return this.approvedbyField;
            }
            set
            {
                this.approvedbyField = value;
            }
        }

        /// <remarks/>
        public string assignedto
        {
            get
            {
                return this.assignedtoField;
            }
            set
            {
                this.assignedtoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("clashobject", IsNullable = false)]
        public exchangeBatchtestClashtestClashresultsClashgroupClashobject[] clashobjects
        {
            get
            {
                return this.clashobjectsField;
            }
            set
            {
                this.clashobjectsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("comment", IsNullable = false)]
        public exchangeBatchtestClashtestClashresultsClashgroupComment[] comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroupClashpoint
    {

        private exchangeBatchtestClashtestClashresultsClashgroupClashpointPos3f pos3fField;

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashgroupClashpointPos3f pos3f
        {
            get
            {
                return this.pos3fField;
            }
            set
            {
                this.pos3fField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroupClashpointPos3f
    {

        private double xField;

        private double yField;

        private double zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroupCreateddate
    {

        private exchangeBatchtestClashtestClashresultsClashgroupCreateddateDate dateField;

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashgroupCreateddateDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroupCreateddateDate
    {

        private int yearField;

        private int monthField;

        private int dayField;

        private int hourField;

        private int minuteField;

        private int secondField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int second
        {
            get
            {
                return this.secondField;
            }
            set
            {
                this.secondField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroupApproveddate
    {

        private exchangeBatchtestClashtestClashresultsClashgroupApproveddateDate dateField;

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashgroupApproveddateDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroupApproveddateDate
    {

        private int yearField;

        private int monthField;

        private int dayField;

        private int hourField;

        private int minuteField;

        private int secondField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int second
        {
            get
            {
                return this.secondField;
            }
            set
            {
                this.secondField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroupClashobject
    {

        private exchangeBatchtestClashtestClashresultsClashgroupClashobjectObjectattribute objectattributeField;

        private string layerField;

        private string[] pathlinkField;

        private exchangeBatchtestClashtestClashresultsClashgroupClashobjectSmarttag[] smarttagsField;

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashgroupClashobjectObjectattribute objectattribute
        {
            get
            {
                return this.objectattributeField;
            }
            set
            {
                this.objectattributeField = value;
            }
        }

        /// <remarks/>
        public string layer
        {
            get
            {
                return this.layerField;
            }
            set
            {
                this.layerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("node", IsNullable = false)]
        public string[] pathlink
        {
            get
            {
                return this.pathlinkField;
            }
            set
            {
                this.pathlinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("smarttag", IsNullable = false)]
        public exchangeBatchtestClashtestClashresultsClashgroupClashobjectSmarttag[] smarttags
        {
            get
            {
                return this.smarttagsField;
            }
            set
            {
                this.smarttagsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroupClashobjectObjectattribute
    {

        private string nameField;

        private uint valueField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public uint value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroupClashobjectSmarttag
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroupComment
    {

        private string userField;

        private string bodyField;

        private exchangeBatchtestClashtestClashresultsClashgroupCommentCreateddate createddateField;

        private int idField;

        private string statusField;

        /// <remarks/>
        public string user
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }

        /// <remarks/>
        public string body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashgroupCommentCreateddate createddate
        {
            get
            {
                return this.createddateField;
            }
            set
            {
                this.createddateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroupCommentCreateddate
    {

        private exchangeBatchtestClashtestClashresultsClashgroupCommentCreateddateDate dateField;

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashgroupCommentCreateddateDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashgroupCommentCreateddateDate
    {

        private int yearField;

        private int monthField;

        private int dayField;

        private int hourField;

        private int minuteField;

        private int secondField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int second
        {
            get
            {
                return this.secondField;
            }
            set
            {
                this.secondField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresult
    {

        private string descriptionField;

        private string resultstatusField;

        private exchangeBatchtestClashtestClashresultsClashresultClashpoint clashpointField;

        private exchangeBatchtestClashtestClashresultsClashresultCreateddate createddateField;

        private exchangeBatchtestClashtestClashresultsClashresultApproveddate approveddateField;

        private string approvedbyField;

        private string assignedtoField;

        private exchangeBatchtestClashtestClashresultsClashresultClashobject[] clashobjectsField;

        private exchangeBatchtestClashtestClashresultsClashresultComment[] commentsField;

        private string nameField;

        private string guidField;

        private string hrefField;

        private string statusField;

        private decimal distanceField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string resultstatus
        {
            get
            {
                return this.resultstatusField;
            }
            set
            {
                this.resultstatusField = value;
            }
        }

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashresultClashpoint clashpoint
        {
            get
            {
                return this.clashpointField;
            }
            set
            {
                this.clashpointField = value;
            }
        }

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashresultCreateddate createddate
        {
            get
            {
                return this.createddateField;
            }
            set
            {
                this.createddateField = value;
            }
        }

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashresultApproveddate approveddate
        {
            get
            {
                return this.approveddateField;
            }
            set
            {
                this.approveddateField = value;
            }
        }

        /// <remarks/>
        public string approvedby
        {
            get
            {
                return this.approvedbyField;
            }
            set
            {
                this.approvedbyField = value;
            }
        }

        /// <remarks/>
        public string assignedto
        {
            get
            {
                return this.assignedtoField;
            }
            set
            {
                this.assignedtoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("clashobject", IsNullable = false)]
        public exchangeBatchtestClashtestClashresultsClashresultClashobject[] clashobjects
        {
            get
            {
                return this.clashobjectsField;
            }
            set
            {
                this.clashobjectsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("comment", IsNullable = false)]
        public exchangeBatchtestClashtestClashresultsClashresultComment[] comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresultClashpoint
    {

        private exchangeBatchtestClashtestClashresultsClashresultClashpointPos3f pos3fField;

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashresultClashpointPos3f pos3f
        {
            get
            {
                return this.pos3fField;
            }
            set
            {
                this.pos3fField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresultClashpointPos3f
    {

        private double xField;

        private double yField;

        private double zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresultCreateddate
    {

        private exchangeBatchtestClashtestClashresultsClashresultCreateddateDate dateField;

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashresultCreateddateDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresultCreateddateDate
    {

        private int yearField;

        private int monthField;

        private int dayField;

        private int hourField;

        private int minuteField;

        private int secondField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int second
        {
            get
            {
                return this.secondField;
            }
            set
            {
                this.secondField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresultApproveddate
    {

        private exchangeBatchtestClashtestClashresultsClashresultApproveddateDate dateField;

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashresultApproveddateDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresultApproveddateDate
    {

        private int yearField;

        private int monthField;

        private int dayField;

        private int hourField;

        private int minuteField;

        private int secondField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int second
        {
            get
            {
                return this.secondField;
            }
            set
            {
                this.secondField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresultClashobject
    {

        private exchangeBatchtestClashtestClashresultsClashresultClashobjectObjectattribute objectattributeField;

        private string layerField;

        private string[] pathlinkField;

        private exchangeBatchtestClashtestClashresultsClashresultClashobjectSmarttag[] smarttagsField;

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashresultClashobjectObjectattribute objectattribute
        {
            get
            {
                return this.objectattributeField;
            }
            set
            {
                this.objectattributeField = value;
            }
        }

        /// <remarks/>
        public string layer
        {
            get
            {
                return this.layerField;
            }
            set
            {
                this.layerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("node", IsNullable = false)]
        public string[] pathlink
        {
            get
            {
                return this.pathlinkField;
            }
            set
            {
                this.pathlinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("smarttag", IsNullable = false)]
        public exchangeBatchtestClashtestClashresultsClashresultClashobjectSmarttag[] smarttags
        {
            get
            {
                return this.smarttagsField;
            }
            set
            {
                this.smarttagsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresultClashobjectObjectattribute
    {

        private string nameField;

        private uint valueField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public uint value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresultClashobjectSmarttag
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresultComment
    {

        private string userField;

        private string bodyField;

        private exchangeBatchtestClashtestClashresultsClashresultCommentCreateddate createddateField;

        private int idField;

        private string statusField;

        /// <remarks/>
        public string user
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }

        /// <remarks/>
        public string body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashresultCommentCreateddate createddate
        {
            get
            {
                return this.createddateField;
            }
            set
            {
                this.createddateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresultCommentCreateddate
    {

        private exchangeBatchtestClashtestClashresultsClashresultCommentCreateddateDate dateField;

        /// <remarks/>
        public exchangeBatchtestClashtestClashresultsClashresultCommentCreateddateDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class exchangeBatchtestClashtestClashresultsClashresultCommentCreateddateDate
    {

        private int yearField;

        private int monthField;

        private int dayField;

        private int hourField;

        private int minuteField;

        private int secondField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int second
        {
            get
            {
                return this.secondField;
            }
            set
            {
                this.secondField = value;
            }
        }
    }


}