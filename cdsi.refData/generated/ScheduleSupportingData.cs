﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace cdsi.refData {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class scheduleSupportingData {
        
        private scheduleSupportingDataLiveVirusConflict[] liveVirusConflictsField;
        
        private scheduleSupportingDataVaccineGroup[] vaccineGroupsField;
        
        private scheduleSupportingDataVaccineGroupMap[] vaccineGroupToAntigenMapField;
        
        private scheduleSupportingDataCvxMap[] cvxToAntigenMapField;
        
        private scheduleSupportingDataObservation[] observationsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("liveVirusConflict", IsNullable=false)]
        public scheduleSupportingDataLiveVirusConflict[] liveVirusConflicts {
            get {
                return this.liveVirusConflictsField;
            }
            set {
                this.liveVirusConflictsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("vaccineGroup", IsNullable=false)]
        public scheduleSupportingDataVaccineGroup[] vaccineGroups {
            get {
                return this.vaccineGroupsField;
            }
            set {
                this.vaccineGroupsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("vaccineGroupMap", IsNullable=false)]
        public scheduleSupportingDataVaccineGroupMap[] vaccineGroupToAntigenMap {
            get {
                return this.vaccineGroupToAntigenMapField;
            }
            set {
                this.vaccineGroupToAntigenMapField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("cvxMap", IsNullable=false)]
        public scheduleSupportingDataCvxMap[] cvxToAntigenMap {
            get {
                return this.cvxToAntigenMapField;
            }
            set {
                this.cvxToAntigenMapField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("observation", IsNullable=false)]
        public scheduleSupportingDataObservation[] observations {
            get {
                return this.observationsField;
            }
            set {
                this.observationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class scheduleSupportingDataLiveVirusConflict {
        
        private scheduleSupportingDataLiveVirusConflictPrevious previousField;
        
        private scheduleSupportingDataLiveVirusConflictCurrent currentField;
        
        private string conflictBeginIntervalField;
        
        private string minConflictEndIntervalField;
        
        private string conflictEndIntervalField;
        
        /// <remarks/>
        public scheduleSupportingDataLiveVirusConflictPrevious previous {
            get {
                return this.previousField;
            }
            set {
                this.previousField = value;
            }
        }
        
        /// <remarks/>
        public scheduleSupportingDataLiveVirusConflictCurrent current {
            get {
                return this.currentField;
            }
            set {
                this.currentField = value;
            }
        }
        
        /// <remarks/>
        public string conflictBeginInterval {
            get {
                return this.conflictBeginIntervalField;
            }
            set {
                this.conflictBeginIntervalField = value;
            }
        }
        
        /// <remarks/>
        public string minConflictEndInterval {
            get {
                return this.minConflictEndIntervalField;
            }
            set {
                this.minConflictEndIntervalField = value;
            }
        }
        
        /// <remarks/>
        public string conflictEndInterval {
            get {
                return this.conflictEndIntervalField;
            }
            set {
                this.conflictEndIntervalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class scheduleSupportingDataLiveVirusConflictPrevious {
        
        private string vaccineTypeField;
        
        private string cvxField;
        
        /// <remarks/>
        public string vaccineType {
            get {
                return this.vaccineTypeField;
            }
            set {
                this.vaccineTypeField = value;
            }
        }
        
        /// <remarks/>
        public string cvx {
            get {
                return this.cvxField;
            }
            set {
                this.cvxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class scheduleSupportingDataLiveVirusConflictCurrent {
        
        private string vaccineTypeField;
        
        private string cvxField;
        
        /// <remarks/>
        public string vaccineType {
            get {
                return this.vaccineTypeField;
            }
            set {
                this.vaccineTypeField = value;
            }
        }
        
        /// <remarks/>
        public string cvx {
            get {
                return this.cvxField;
            }
            set {
                this.cvxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class scheduleSupportingDataVaccineGroup {
        
        private string nameField;
        
        private string administerFullVaccineGroupField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string administerFullVaccineGroup {
            get {
                return this.administerFullVaccineGroupField;
            }
            set {
                this.administerFullVaccineGroupField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class scheduleSupportingDataVaccineGroupMap {
        
        private string nameField;
        
        private string[] antigenField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("antigen")]
        public string[] antigen {
            get {
                return this.antigenField;
            }
            set {
                this.antigenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class scheduleSupportingDataCvxMap {
        
        private string cvxField;
        
        private string shortDescriptionField;
        
        private scheduleSupportingDataCvxMapAssociation[] associationField;
        
        /// <remarks/>
        public string cvx {
            get {
                return this.cvxField;
            }
            set {
                this.cvxField = value;
            }
        }
        
        /// <remarks/>
        public string shortDescription {
            get {
                return this.shortDescriptionField;
            }
            set {
                this.shortDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("association")]
        public scheduleSupportingDataCvxMapAssociation[] association {
            get {
                return this.associationField;
            }
            set {
                this.associationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class scheduleSupportingDataCvxMapAssociation {
        
        private string antigenField;
        
        private string associationBeginAgeField;
        
        private string associationEndAgeField;
        
        /// <remarks/>
        public string antigen {
            get {
                return this.antigenField;
            }
            set {
                this.antigenField = value;
            }
        }
        
        /// <remarks/>
        public string associationBeginAge {
            get {
                return this.associationBeginAgeField;
            }
            set {
                this.associationBeginAgeField = value;
            }
        }
        
        /// <remarks/>
        public string associationEndAge {
            get {
                return this.associationEndAgeField;
            }
            set {
                this.associationEndAgeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class scheduleSupportingDataObservation {
        
        private string observationCodeField;
        
        private string observationTitleField;
        
        private string groupField;
        
        private string indicationTextField;
        
        private string contraindicationTextField;
        
        private string clarifyingTextField;
        
        private scheduleSupportingDataObservationCodedValuesCodedValue[] codedValuesField;
        
        /// <remarks/>
        public string observationCode {
            get {
                return this.observationCodeField;
            }
            set {
                this.observationCodeField = value;
            }
        }
        
        /// <remarks/>
        public string observationTitle {
            get {
                return this.observationTitleField;
            }
            set {
                this.observationTitleField = value;
            }
        }
        
        /// <remarks/>
        public string group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        
        /// <remarks/>
        public string indicationText {
            get {
                return this.indicationTextField;
            }
            set {
                this.indicationTextField = value;
            }
        }
        
        /// <remarks/>
        public string contraindicationText {
            get {
                return this.contraindicationTextField;
            }
            set {
                this.contraindicationTextField = value;
            }
        }
        
        /// <remarks/>
        public string clarifyingText {
            get {
                return this.clarifyingTextField;
            }
            set {
                this.clarifyingTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("codedValue", typeof(scheduleSupportingDataObservationCodedValuesCodedValue), IsNullable=false)]
        public scheduleSupportingDataObservationCodedValuesCodedValue[] codedValues {
            get {
                return this.codedValuesField;
            }
            set {
                this.codedValuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class scheduleSupportingDataObservationCodedValuesCodedValue {
        
        private string codeField;
        
        private string codeSystemField;
        
        private string textField;
        
        /// <remarks/>
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string codeSystem {
            get {
                return this.codeSystemField;
            }
            set {
                this.codeSystemField = value;
            }
        }
        
        /// <remarks/>
        public string text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
}
