﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.7.2046.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/CocukSchema.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/CocukSchema.xsd", IsNullable = false)]
public partial class CocukSchema
{

    private CocukSchemaCocuk[] cocukField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cocuk")]
    public CocukSchemaCocuk[] Cocuk
    {
        get
        {
            return this.cocukField;
        }
        set
        {
            this.cocukField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/CocukSchema.xsd")]
public partial class CocukSchemaCocuk
{
    private int idField;
    private string tcField;

    private string şifreField;

    private string cinsiyetField;

    private string adField;

    private string soyadField;

    private System.DateTime doğumTarihiField;

    private double kiloField;

    private double boyField;
    /// <remarks/>
    public int ID
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
    public string TC
    {
        get
        {
            return this.tcField;
        }
        set
        {
            this.tcField = value;
        }
    }

    /// <remarks/>
    public string Şifre
    {
        get
        {
            return this.şifreField;
        }
        set
        {
            this.şifreField = value;
        }
    }

    /// <remarks/>
    public string Cinsiyet
    {
        get
        {
            return this.cinsiyetField;
        }
        set
        {
            this.cinsiyetField = value;
        }
    }

    /// <remarks/>
    public string Ad
    {
        get
        {
            return this.adField;
        }
        set
        {
            this.adField = value;
        }
    }

    /// <remarks/>
    public string Soyad
    {
        get
        {
            return this.soyadField;
        }
        set
        {
            this.soyadField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DoğumTarihi
    {
        get
        {
            return this.doğumTarihiField;
        }
        set
        {
            this.doğumTarihiField = value;
        }
    }

    /// <remarks/>
    public double Kilo
    {
        get
        {
            return this.kiloField;
        }
        set
        {
            this.kiloField = value;
        }
    }

    /// <remarks/>
    public double Boy
    {
        get
        {
            return this.boyField;
        }
        set
        {
            this.boyField = value;
        }
    }
}
