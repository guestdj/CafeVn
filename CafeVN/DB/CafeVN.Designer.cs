﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace CafeVN.DB
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CafeVNContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CafeVNContainer object using the connection string found in the 'CafeVNContainer' section of the application configuration file.
        /// </summary>
        public CafeVNContainer() : base("name=CafeVNContainer", "CafeVNContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CafeVNContainer object.
        /// </summary>
        public CafeVNContainer(string connectionString) : base(connectionString, "CafeVNContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CafeVNContainer object.
        /// </summary>
        public CafeVNContainer(EntityConnection connection) : base(connection, "CafeVNContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CoffeeBag> CoffeeBags
        {
            get
            {
                if ((_CoffeeBags == null))
                {
                    _CoffeeBags = base.CreateObjectSet<CoffeeBag>("CoffeeBags");
                }
                return _CoffeeBags;
            }
        }
        private ObjectSet<CoffeeBag> _CoffeeBags;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CoffeeBags EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCoffeeBags(CoffeeBag coffeeBag)
        {
            base.AddObject("CoffeeBags", coffeeBag);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CafeVN", Name="CoffeeBag")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CoffeeBag : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CoffeeBag object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="price">Initial value of the Price property.</param>
        /// <param name="imageSmall">Initial value of the ImageSmall property.</param>
        /// <param name="imageLarge">Initial value of the ImageLarge property.</param>
        public static CoffeeBag CreateCoffeeBag(global::System.Int32 id, global::System.String name, global::System.String description, global::System.Decimal price, global::System.String imageSmall, global::System.String imageLarge)
        {
            CoffeeBag coffeeBag = new CoffeeBag();
            coffeeBag.Id = id;
            coffeeBag.Name = name;
            coffeeBag.Description = description;
            coffeeBag.Price = price;
            coffeeBag.ImageSmall = imageSmall;
            coffeeBag.ImageLarge = imageLarge;
            return coffeeBag;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private global::System.Decimal _Price;
        partial void OnPriceChanging(global::System.Decimal value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ImageSmall
        {
            get
            {
                return _ImageSmall;
            }
            set
            {
                OnImageSmallChanging(value);
                ReportPropertyChanging("ImageSmall");
                _ImageSmall = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ImageSmall");
                OnImageSmallChanged();
            }
        }
        private global::System.String _ImageSmall;
        partial void OnImageSmallChanging(global::System.String value);
        partial void OnImageSmallChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ImageLarge
        {
            get
            {
                return _ImageLarge;
            }
            set
            {
                OnImageLargeChanging(value);
                ReportPropertyChanging("ImageLarge");
                _ImageLarge = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ImageLarge");
                OnImageLargeChanged();
            }
        }
        private global::System.String _ImageLarge;
        partial void OnImageLargeChanging(global::System.String value);
        partial void OnImageLargeChanged();

        #endregion
    
    }

    #endregion
    
}
