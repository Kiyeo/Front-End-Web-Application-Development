﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UoA.Museum
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/UoA.Museum")]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DescriptionField;
        
        private string ItemIdField;
        
        private string TitleField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemId
        {
            get
            {
                return this.ItemIdField;
            }
            set
            {
                this.ItemIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RSSItem", Namespace="http://schemas.datacontract.org/2004/07/UoA.Museum")]
    public partial class RSSItem : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string descriptionFieldField;
        
        private UoA.Museum.EnclosureType enclosureFieldField;
        
        private string guidFieldField;
        
        private string linkFieldField;
        
        private string pubDateFieldField;
        
        private string titleFieldField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string descriptionField
        {
            get
            {
                return this.descriptionFieldField;
            }
            set
            {
                this.descriptionFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public UoA.Museum.EnclosureType enclosureField
        {
            get
            {
                return this.enclosureFieldField;
            }
            set
            {
                this.enclosureFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string guidField
        {
            get
            {
                return this.guidFieldField;
            }
            set
            {
                this.guidFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string linkField
        {
            get
            {
                return this.linkFieldField;
            }
            set
            {
                this.linkFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string pubDateField
        {
            get
            {
                return this.pubDateFieldField;
            }
            set
            {
                this.pubDateFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string titleField
        {
            get
            {
                return this.titleFieldField;
            }
            set
            {
                this.titleFieldField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EnclosureType", Namespace="http://schemas.datacontract.org/2004/07/UoA.Museum")]
    public partial class EnclosureType : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string lengthFieldField;
        
        private string typeFieldField;
        
        private string urlFieldField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string lengthField
        {
            get
            {
                return this.lengthFieldField;
            }
            set
            {
                this.lengthFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string typeField
        {
            get
            {
                return this.typeFieldField;
            }
            set
            {
                this.typeFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string urlField
        {
            get
            {
                return this.urlFieldField;
            }
            set
            {
                this.urlFieldField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/UoA.Museum")]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AddressField;
        
        private string NameField;
        
        private string PasswordField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://www.site.org/Samples", ConfigurationName="IMuseumService")]
public interface IMuseumService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/ServiceID", ReplyAction="http://www.site.org/Samples/IMuseumService/ServiceIDResponse")]
    string ServiceID();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/ServiceID", ReplyAction="http://www.site.org/Samples/IMuseumService/ServiceIDResponse")]
    System.Threading.Tasks.Task<string> ServiceIDAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/Version", ReplyAction="http://www.site.org/Samples/IMuseumService/VersionResponse")]
    string Version();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/Version", ReplyAction="http://www.site.org/Samples/IMuseumService/VersionResponse")]
    System.Threading.Tasks.Task<string> VersionAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/UserId", ReplyAction="http://www.site.org/Samples/IMuseumService/UserIdResponse")]
    string UserId();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/UserId", ReplyAction="http://www.site.org/Samples/IMuseumService/UserIdResponse")]
    System.Threading.Tasks.Task<string> UserIdAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/GetItems", ReplyAction="http://www.site.org/Samples/IMuseumService/GetItemsResponse")]
    UoA.Museum.Item[] GetItems();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/GetItems", ReplyAction="http://www.site.org/Samples/IMuseumService/GetItemsResponse")]
    System.Threading.Tasks.Task<UoA.Museum.Item[]> GetItemsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/ItemSearch", ReplyAction="http://www.site.org/Samples/IMuseumService/ItemSearchResponse")]
    UoA.Museum.Item[] ItemSearch(string term);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/ItemSearch", ReplyAction="http://www.site.org/Samples/IMuseumService/ItemSearchResponse")]
    System.Threading.Tasks.Task<UoA.Museum.Item[]> ItemSearchAsync(string term);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/ItemImage", ReplyAction="http://www.site.org/Samples/IMuseumService/ItemImageResponse")]
    System.IO.Stream ItemImage(string id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/ItemImage", ReplyAction="http://www.site.org/Samples/IMuseumService/ItemImageResponse")]
    System.Threading.Tasks.Task<System.IO.Stream> ItemImageAsync(string id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/ShopSearch", ReplyAction="http://www.site.org/Samples/IMuseumService/ShopSearchResponse")]
    UoA.Museum.Item[] ShopSearch(string term);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/ShopSearch", ReplyAction="http://www.site.org/Samples/IMuseumService/ShopSearchResponse")]
    System.Threading.Tasks.Task<UoA.Museum.Item[]> ShopSearchAsync(string term);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/ShopItemImage", ReplyAction="http://www.site.org/Samples/IMuseumService/ShopItemImageResponse")]
    System.IO.Stream ShopItemImage(string id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/ShopItemImage", ReplyAction="http://www.site.org/Samples/IMuseumService/ShopItemImageResponse")]
    System.Threading.Tasks.Task<System.IO.Stream> ShopItemImageAsync(string id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/GetNews", ReplyAction="http://www.site.org/Samples/IMuseumService/GetNewsResponse")]
    UoA.Museum.RSSItem[] GetNews();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/GetNews", ReplyAction="http://www.site.org/Samples/IMuseumService/GetNewsResponse")]
    System.Threading.Tasks.Task<UoA.Museum.RSSItem[]> GetNewsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/RegisterUser", ReplyAction="http://www.site.org/Samples/IMuseumService/RegisterUserResponse")]
    string RegisterUser(UoA.Museum.User user);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/RegisterUser", ReplyAction="http://www.site.org/Samples/IMuseumService/RegisterUserResponse")]
    System.Threading.Tasks.Task<string> RegisterUserAsync(UoA.Museum.User user);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/HtmlComments", ReplyAction="http://www.site.org/Samples/IMuseumService/HtmlCommentsResponse")]
    System.IO.Stream HtmlComments();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/HtmlComments", ReplyAction="http://www.site.org/Samples/IMuseumService/HtmlCommentsResponse")]
    System.Threading.Tasks.Task<System.IO.Stream> HtmlCommentsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/GetOptions", ReplyAction="http://www.site.org/Samples/IMuseumService/GetOptionsResponse")]
    void GetOptions();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/GetOptions", ReplyAction="http://www.site.org/Samples/IMuseumService/GetOptionsResponse")]
    System.Threading.Tasks.Task GetOptionsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/PostComment", ReplyAction="http://www.site.org/Samples/IMuseumService/PostCommentResponse")]
    string PostComment(string name, string comment);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.site.org/Samples/IMuseumService/PostComment", ReplyAction="http://www.site.org/Samples/IMuseumService/PostCommentResponse")]
    System.Threading.Tasks.Task<string> PostCommentAsync(string name, string comment);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMuseumServiceChannel : IMuseumService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MuseumServiceClient : System.ServiceModel.ClientBase<IMuseumService>, IMuseumService
{
    
    public MuseumServiceClient()
    {
    }
    
    public MuseumServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public MuseumServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MuseumServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MuseumServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string ServiceID()
    {
        return base.Channel.ServiceID();
    }
    
    public System.Threading.Tasks.Task<string> ServiceIDAsync()
    {
        return base.Channel.ServiceIDAsync();
    }
    
    public string Version()
    {
        return base.Channel.Version();
    }
    
    public System.Threading.Tasks.Task<string> VersionAsync()
    {
        return base.Channel.VersionAsync();
    }
    
    public string UserId()
    {
        return base.Channel.UserId();
    }
    
    public System.Threading.Tasks.Task<string> UserIdAsync()
    {
        return base.Channel.UserIdAsync();
    }
    
    public UoA.Museum.Item[] GetItems()
    {
        return base.Channel.GetItems();
    }
    
    public System.Threading.Tasks.Task<UoA.Museum.Item[]> GetItemsAsync()
    {
        return base.Channel.GetItemsAsync();
    }
    
    public UoA.Museum.Item[] ItemSearch(string term)
    {
        return base.Channel.ItemSearch(term);
    }
    
    public System.Threading.Tasks.Task<UoA.Museum.Item[]> ItemSearchAsync(string term)
    {
        return base.Channel.ItemSearchAsync(term);
    }
    
    public System.IO.Stream ItemImage(string id)
    {
        return base.Channel.ItemImage(id);
    }
    
    public System.Threading.Tasks.Task<System.IO.Stream> ItemImageAsync(string id)
    {
        return base.Channel.ItemImageAsync(id);
    }
    
    public UoA.Museum.Item[] ShopSearch(string term)
    {
        return base.Channel.ShopSearch(term);
    }
    
    public System.Threading.Tasks.Task<UoA.Museum.Item[]> ShopSearchAsync(string term)
    {
        return base.Channel.ShopSearchAsync(term);
    }
    
    public System.IO.Stream ShopItemImage(string id)
    {
        return base.Channel.ShopItemImage(id);
    }
    
    public System.Threading.Tasks.Task<System.IO.Stream> ShopItemImageAsync(string id)
    {
        return base.Channel.ShopItemImageAsync(id);
    }
    
    public UoA.Museum.RSSItem[] GetNews()
    {
        return base.Channel.GetNews();
    }
    
    public System.Threading.Tasks.Task<UoA.Museum.RSSItem[]> GetNewsAsync()
    {
        return base.Channel.GetNewsAsync();
    }
    
    public string RegisterUser(UoA.Museum.User user)
    {
        return base.Channel.RegisterUser(user);
    }
    
    public System.Threading.Tasks.Task<string> RegisterUserAsync(UoA.Museum.User user)
    {
        return base.Channel.RegisterUserAsync(user);
    }
    
    public System.IO.Stream HtmlComments()
    {
        return base.Channel.HtmlComments();
    }
    
    public System.Threading.Tasks.Task<System.IO.Stream> HtmlCommentsAsync()
    {
        return base.Channel.HtmlCommentsAsync();
    }
    
    public void GetOptions()
    {
        base.Channel.GetOptions();
    }
    
    public System.Threading.Tasks.Task GetOptionsAsync()
    {
        return base.Channel.GetOptionsAsync();
    }
    
    public string PostComment(string name, string comment)
    {
        return base.Channel.PostComment(name, comment);
    }
    
    public System.Threading.Tasks.Task<string> PostCommentAsync(string name, string comment)
    {
        return base.Channel.PostCommentAsync(name, comment);
    }
}
