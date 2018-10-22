
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
public partial class Envelope
{

    private object headerField;

    private EnvelopeBody bodyField;

    /// <remarks/>
    public object Header
    {
        get
        {
            return this.headerField;
        }
        set
        {
            this.headerField = value;
        }
    }

    /// <remarks/>
    public EnvelopeBody Body
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public partial class EnvelopeBody
{

    private AddPatient addPatientField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://tempuri.org/")]
    public AddPatient AddPatient
    {
        get
        {
            return this.addPatientField;
        }
        set
        {
            this.addPatientField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/", IsNullable = false)]
public partial class AddPatient
{

    private string guidField;

    private string idLPUField;

    private AddPatientPatient patientField;

    /// <remarks/>
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
    public string idLPU
    {
        get
        {
            return this.idLPUField;
        }
        set
        {
            this.idLPUField = value;
        }
    }

    /// <remarks/>
    public AddPatientPatient patient
    {
        get
        {
            return this.patientField;
        }
        set
        {
            this.patientField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/")]
public partial class AddPatientPatient
{

    private Documents documentsField;

    private Addresses addressesField;

    private BirthPlace birthPlaceField;

    private ContactPerson contactPersonField;

    private Contacts contactsField;

    private string birthDateField;

    private string familyNameField;

    private string givenNameField;

    private string idPatientMISField;

    private byte sexField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
    public Documents Documents
    {
        get
        {
            return this.documentsField;
        }
        set
        {
            this.documentsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
    public Addresses Addresses
    {
        get
        {
            return this.addressesField;
        }
        set
        {
            this.addressesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
    public BirthPlace BirthPlace
    {
        get
        {
            return this.birthPlaceField;
        }
        set
        {
            this.birthPlaceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
    public ContactPerson ContactPerson
    {
        get
        {
            return this.contactPersonField;
        }
        set
        {
            this.contactPersonField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
    public Contacts Contacts
    {
        get
        {
            return this.contactsField;
        }
        set
        {
            this.contactsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
    public string BirthDate
    {
        get
        {
            return this.birthDateField;
        }
        set
        {
            this.birthDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
    public string FamilyName
    {
        get
        {
            return this.familyNameField;
        }
        set
        {
            this.familyNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
    public string GivenName
    {
        get
        {
            return this.givenNameField;
        }
        set
        {
            this.givenNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
    public string IdPatientMIS
    {
        get
        {
            return this.idPatientMISField;
        }
        set
        {
            this.idPatientMISField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
    public byte Sex
    {
        get
        {
            return this.sexField;
        }
        set
        {
            this.sexField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto", IsNullable = false)]
public partial class Documents
{

    private DocumentsDocumentDto documentDtoField;

    /// <remarks/>
    public DocumentsDocumentDto DocumentDto
    {
        get
        {
            return this.documentDtoField;
        }
        set
        {
            this.documentDtoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
public partial class DocumentsDocumentDto
{

    private uint docNField;

    private ushort docSField;

    private byte idDocumentTypeField;

    private string providerNameField;

    private byte regionCodeField;

    /// <remarks/>
    public uint DocN
    {
        get
        {
            return this.docNField;
        }
        set
        {
            this.docNField = value;
        }
    }

    /// <remarks/>
    public ushort DocS
    {
        get
        {
            return this.docSField;
        }
        set
        {
            this.docSField = value;
        }
    }

    /// <remarks/>
    public byte IdDocumentType
    {
        get
        {
            return this.idDocumentTypeField;
        }
        set
        {
            this.idDocumentTypeField = value;
        }
    }

    /// <remarks/>
    public string ProviderName
    {
        get
        {
            return this.providerNameField;
        }
        set
        {
            this.providerNameField = value;
        }
    }

    /// <remarks/>
    public byte RegionCode
    {
        get
        {
            return this.regionCodeField;
        }
        set
        {
            this.regionCodeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto", IsNullable = false)]
public partial class Addresses
{

    private AddressesAddressDto addressDtoField;

    /// <remarks/>
    public AddressesAddressDto AddressDto
    {
        get
        {
            return this.addressDtoField;
        }
        set
        {
            this.addressDtoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
public partial class AddressesAddressDto
{

    private string cityField;

    private byte idAddressTypeField;

    private string stringAddressField;

    /// <remarks/>
    public string City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public byte IdAddressType
    {
        get
        {
            return this.idAddressTypeField;
        }
        set
        {
            this.idAddressTypeField = value;
        }
    }

    /// <remarks/>
    public string StringAddress
    {
        get
        {
            return this.stringAddressField;
        }
        set
        {
            this.stringAddressField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto", IsNullable = false)]
public partial class BirthPlace
{

    private string cityField;

    private string countryField;

    private string regionField;

    /// <remarks/>
    public string City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public string Country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    /// <remarks/>
    public string Region
    {
        get
        {
            return this.regionField;
        }
        set
        {
            this.regionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto", IsNullable = false)]
public partial class ContactPerson
{

    private ContactPersonContactList contactListField;

    private string familyNameField;

    private string givenNameField;

    private string idPersonMisField;

    /// <remarks/>
    public ContactPersonContactList ContactList
    {
        get
        {
            return this.contactListField;
        }
        set
        {
            this.contactListField = value;
        }
    }

    /// <remarks/>
    public string FamilyName
    {
        get
        {
            return this.familyNameField;
        }
        set
        {
            this.familyNameField = value;
        }
    }

    /// <remarks/>
    public string GivenName
    {
        get
        {
            return this.givenNameField;
        }
        set
        {
            this.givenNameField = value;
        }
    }

    /// <remarks/>
    public string IdPersonMis
    {
        get
        {
            return this.idPersonMisField;
        }
        set
        {
            this.idPersonMisField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
public partial class ContactPersonContactList
{

    private ContactPersonContactListContactDto contactDtoField;

    /// <remarks/>
    public ContactPersonContactListContactDto ContactDto
    {
        get
        {
            return this.contactDtoField;
        }
        set
        {
            this.contactDtoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
public partial class ContactPersonContactListContactDto
{

    private string contactValueField;

    private ushort idContactTypeField;

    /// <remarks/>
    public string ContactValue
    {
        get
        {
            return this.contactValueField;
        }
        set
        {
            this.contactValueField = value;
        }
    }

    /// <remarks/>
    public ushort IdContactType
    {
        get
        {
            return this.idContactTypeField;
        }
        set
        {
            this.idContactTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto", IsNullable = false)]
public partial class Contacts
{

    private ContactsContactDto contactDtoField;

    /// <remarks/>
    public ContactsContactDto ContactDto
    {
        get
        {
            return this.contactDtoField;
        }
        set
        {
            this.contactDtoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
public partial class ContactsContactDto
{

    private string contactValueField;

    private ushort idContactTypeField;

    /// <remarks/>
    public string ContactValue
    {
        get
        {
            return this.contactValueField;
        }
        set
        {
            this.contactValueField = value;
        }
    }

    /// <remarks/>
    public ushort IdContactType
    {
        get
        {
            return this.idContactTypeField;
        }
        set
        {
            this.idContactTypeField = value;
        }
    }
}

