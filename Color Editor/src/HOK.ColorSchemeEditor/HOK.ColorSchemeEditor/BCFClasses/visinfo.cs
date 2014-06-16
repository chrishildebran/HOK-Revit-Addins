﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class VisualizationInfo {

    private Component[] componentsField;
    
    private OrthogonalCamera orthogonalCameraField;
    
    private PerspectiveCamera perspectiveCameraField;
    
    private Line[] linesField;
    
    private ClippingPlane[] clippingPlanesField;
    
    private VisualizationInfoBitmap bitmapField;


    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public Component[] Components {
        get {
            return this.componentsField;
        }
        set {
            this.componentsField = value;
        }
    }
    
    /// <remarks/>
    public OrthogonalCamera OrthogonalCamera {
        get {
            return this.orthogonalCameraField;
        }
        set {
            this.orthogonalCameraField = value;
        }
    }
    
    /// <remarks/>
    public PerspectiveCamera PerspectiveCamera {
        get {
            return this.perspectiveCameraField;
        }
        set {
            this.perspectiveCameraField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public Line[] Lines {
        get {
            return this.linesField;
        }
        set {
            this.linesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public ClippingPlane[] ClippingPlanes {
        get {
            return this.clippingPlanesField;
        }
        set {
            this.clippingPlanesField = value;
        }
    }
    
    /// <remarks/>
    public VisualizationInfoBitmap Bitmap {
        get {
            return this.bitmapField;
        }
        set {
            this.bitmapField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Component {
    
    private string originatingSystemField;
    
    private string authoringToolIdField;
    
    private string ifcGuidField;
    
    private bool selectedField;
    
    private bool selectedFieldSpecified;
    
    private bool visibleField;
    
    private byte[] colorField;
    
    public Component() {
        this.visibleField = true;
    }
    
    /// <remarks/>
    public string OriginatingSystem {
        get {
            return this.originatingSystemField;
        }
        set {
            this.originatingSystemField = value;
        }
    }
    
    /// <remarks/>
    public string AuthoringToolId {
        get {
            return this.authoringToolIdField;
        }
        set {
            this.authoringToolIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
    public string IfcGuid {
        get {
            return this.ifcGuidField;
        }
        set {
            this.ifcGuidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Selected {
        get {
            return this.selectedField;
        }
        set {
            this.selectedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SelectedSpecified {
        get {
            return this.selectedFieldSpecified;
        }
        set {
            this.selectedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Visible {
        get {
            return this.visibleField;
        }
        set {
            this.visibleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="hexBinary")]
    public byte[] Color {
        get {
            return this.colorField;
        }
        set {
            this.colorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ClippingPlane {
    
    private Point locationField;
    
    private Direction directionField;
    
    /// <remarks/>
    public Point Location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    public Direction Direction {
        get {
            return this.directionField;
        }
        set {
            this.directionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Point {
    
    private double xField;
    
    private double yField;
    
    private double zField;
    
    /// <remarks/>
    public double X {
        get {
            return this.xField;
        }
        set {
            this.xField = value;
        }
    }
    
    /// <remarks/>
    public double Y {
        get {
            return this.yField;
        }
        set {
            this.yField = value;
        }
    }
    
    /// <remarks/>
    public double Z {
        get {
            return this.zField;
        }
        set {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Direction {
    
    private double xField;
    
    private double yField;
    
    private double zField;
    
    /// <remarks/>
    public double X {
        get {
            return this.xField;
        }
        set {
            this.xField = value;
        }
    }
    
    /// <remarks/>
    public double Y {
        get {
            return this.yField;
        }
        set {
            this.yField = value;
        }
    }
    
    /// <remarks/>
    public double Z {
        get {
            return this.zField;
        }
        set {
            this.zField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Line {
    
    private Point startPointField;
    
    private Point endPointField;
    
    /// <remarks/>
    public Point StartPoint {
        get {
            return this.startPointField;
        }
        set {
            this.startPointField = value;
        }
    }
    
    /// <remarks/>
    public Point EndPoint {
        get {
            return this.endPointField;
        }
        set {
            this.endPointField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class PerspectiveCamera {
    
    private Point cameraViewPointField;
    
    private Direction cameraDirectionField;
    
    private Direction cameraUpVectorField;
    
    private double fieldOfViewField;
    
    /// <remarks/>
    public Point CameraViewPoint {
        get {
            return this.cameraViewPointField;
        }
        set {
            this.cameraViewPointField = value;
        }
    }
    
    /// <remarks/>
    public Direction CameraDirection {
        get {
            return this.cameraDirectionField;
        }
        set {
            this.cameraDirectionField = value;
        }
    }
    
    /// <remarks/>
    public Direction CameraUpVector {
        get {
            return this.cameraUpVectorField;
        }
        set {
            this.cameraUpVectorField = value;
        }
    }
    
    /// <remarks/>
    public double FieldOfView {
        get {
            return this.fieldOfViewField;
        }
        set {
            this.fieldOfViewField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class OrthogonalCamera {
    
    private Point cameraViewPointField;
    
    private Direction cameraDirectionField;
    
    private Direction cameraUpVectorField;
    
    private double viewToWorldScaleField;
    
    /// <remarks/>
    public Point CameraViewPoint {
        get {
            return this.cameraViewPointField;
        }
        set {
            this.cameraViewPointField = value;
        }
    }
    
    /// <remarks/>
    public Direction CameraDirection {
        get {
            return this.cameraDirectionField;
        }
        set {
            this.cameraDirectionField = value;
        }
    }
    
    /// <remarks/>
    public Direction CameraUpVector {
        get {
            return this.cameraUpVectorField;
        }
        set {
            this.cameraUpVectorField = value;
        }
    }
    
    /// <remarks/>
    public double ViewToWorldScale {
        get {
            return this.viewToWorldScaleField;
        }
        set {
            this.viewToWorldScaleField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class VisualizationInfoBitmap {
    
    private BitmapFormat bitmapField;
    
    private string referenceField;
    
    private Point locationField;
    
    private Direction normalField;
    
    private Direction upField;
    
    private double heightField;
    
    /// <remarks/>
    public BitmapFormat Bitmap {
        get {
            return this.bitmapField;
        }
        set {
            this.bitmapField = value;
        }
    }
    
    /// <remarks/>
    public string Reference {
        get {
            return this.referenceField;
        }
        set {
            this.referenceField = value;
        }
    }
    
    /// <remarks/>
    public Point Location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    public Direction Normal {
        get {
            return this.normalField;
        }
        set {
            this.normalField = value;
        }
    }
    
    /// <remarks/>
    public Direction Up {
        get {
            return this.upField;
        }
        set {
            this.upField = value;
        }
    }
    
    /// <remarks/>
    public double Height {
        get {
            return this.heightField;
        }
        set {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
public enum BitmapFormat {
    
    /// <remarks/>
    PNG,
    
    /// <remarks/>
    JPG,
}