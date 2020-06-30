/*
               File: wwpbaseobjects.type_SdtUserCustomizations
        Description: User Custom
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:34.96
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs.wwpbaseobjects {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "UserCustomizations" )]
   [XmlType(TypeName =  "UserCustomizations" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtUserCustomizations : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtUserCustomizations( )
      {
      }

      public SdtUserCustomizations( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( int AV16UserCustomizationsId ,
                        String AV17UserCustomizationsKey )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV16UserCustomizationsId,(String)AV17UserCustomizationsKey});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"UserCustomizationsId", typeof(int)}, new Object[]{"UserCustomizationsKey", typeof(String)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "WWPBaseObjects\\UserCustomizations");
         metadata.Set("BT", "UserCustomizations");
         metadata.Set("PK", "[ \"UserCustomizationsId\",\"UserCustomizationsKey\" ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Usercustomizationsid_Z");
         state.Add("gxTpr_Usercustomizationskey_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations sdt ;
         sdt = (GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations)(source);
         gxTv_SdtUserCustomizations_Usercustomizationsid = sdt.gxTv_SdtUserCustomizations_Usercustomizationsid ;
         gxTv_SdtUserCustomizations_Usercustomizationskey = sdt.gxTv_SdtUserCustomizations_Usercustomizationskey ;
         gxTv_SdtUserCustomizations_Usercustomizationsvalue = sdt.gxTv_SdtUserCustomizations_Usercustomizationsvalue ;
         gxTv_SdtUserCustomizations_Mode = sdt.gxTv_SdtUserCustomizations_Mode ;
         gxTv_SdtUserCustomizations_Initialized = sdt.gxTv_SdtUserCustomizations_Initialized ;
         gxTv_SdtUserCustomizations_Usercustomizationsid_Z = sdt.gxTv_SdtUserCustomizations_Usercustomizationsid_Z ;
         gxTv_SdtUserCustomizations_Usercustomizationskey_Z = sdt.gxTv_SdtUserCustomizations_Usercustomizationskey_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("UserCustomizationsId", gxTv_SdtUserCustomizations_Usercustomizationsid, false);
         AddObjectProperty("UserCustomizationsKey", gxTv_SdtUserCustomizations_Usercustomizationskey, false);
         AddObjectProperty("UserCustomizationsValue", gxTv_SdtUserCustomizations_Usercustomizationsvalue, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtUserCustomizations_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtUserCustomizations_Initialized, false);
            AddObjectProperty("UserCustomizationsId_Z", gxTv_SdtUserCustomizations_Usercustomizationsid_Z, false);
            AddObjectProperty("UserCustomizationsKey_Z", gxTv_SdtUserCustomizations_Usercustomizationskey_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations sdt )
      {
         if ( sdt.IsDirty("UserCustomizationsId") )
         {
            gxTv_SdtUserCustomizations_Usercustomizationsid = sdt.gxTv_SdtUserCustomizations_Usercustomizationsid ;
         }
         if ( sdt.IsDirty("UserCustomizationsKey") )
         {
            gxTv_SdtUserCustomizations_Usercustomizationskey = sdt.gxTv_SdtUserCustomizations_Usercustomizationskey ;
         }
         if ( sdt.IsDirty("UserCustomizationsValue") )
         {
            gxTv_SdtUserCustomizations_Usercustomizationsvalue = sdt.gxTv_SdtUserCustomizations_Usercustomizationsvalue ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "UserCustomizationsId" )]
      [  XmlElement( ElementName = "UserCustomizationsId"   )]
      public int gxTpr_Usercustomizationsid
      {
         get {
            return gxTv_SdtUserCustomizations_Usercustomizationsid ;
         }

         set {
            if ( gxTv_SdtUserCustomizations_Usercustomizationsid != value )
            {
               gxTv_SdtUserCustomizations_Mode = "INS";
               this.gxTv_SdtUserCustomizations_Usercustomizationsid_Z_SetNull( );
               this.gxTv_SdtUserCustomizations_Usercustomizationskey_Z_SetNull( );
            }
            gxTv_SdtUserCustomizations_Usercustomizationsid = value;
            SetDirty("Usercustomizationsid");
         }

      }

      [  SoapElement( ElementName = "UserCustomizationsKey" )]
      [  XmlElement( ElementName = "UserCustomizationsKey"   )]
      public String gxTpr_Usercustomizationskey
      {
         get {
            return gxTv_SdtUserCustomizations_Usercustomizationskey ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtUserCustomizations_Usercustomizationskey, value) != 0 )
            {
               gxTv_SdtUserCustomizations_Mode = "INS";
               this.gxTv_SdtUserCustomizations_Usercustomizationsid_Z_SetNull( );
               this.gxTv_SdtUserCustomizations_Usercustomizationskey_Z_SetNull( );
            }
            gxTv_SdtUserCustomizations_Usercustomizationskey = value;
            SetDirty("Usercustomizationskey");
         }

      }

      [  SoapElement( ElementName = "UserCustomizationsValue" )]
      [  XmlElement( ElementName = "UserCustomizationsValue"   )]
      public String gxTpr_Usercustomizationsvalue
      {
         get {
            return gxTv_SdtUserCustomizations_Usercustomizationsvalue ;
         }

         set {
            gxTv_SdtUserCustomizations_Usercustomizationsvalue = value;
            SetDirty("Usercustomizationsvalue");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtUserCustomizations_Mode ;
         }

         set {
            gxTv_SdtUserCustomizations_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtUserCustomizations_Mode_SetNull( )
      {
         gxTv_SdtUserCustomizations_Mode = "";
         return  ;
      }

      public bool gxTv_SdtUserCustomizations_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtUserCustomizations_Initialized ;
         }

         set {
            gxTv_SdtUserCustomizations_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtUserCustomizations_Initialized_SetNull( )
      {
         gxTv_SdtUserCustomizations_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtUserCustomizations_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UserCustomizationsId_Z" )]
      [  XmlElement( ElementName = "UserCustomizationsId_Z"   )]
      public int gxTpr_Usercustomizationsid_Z
      {
         get {
            return gxTv_SdtUserCustomizations_Usercustomizationsid_Z ;
         }

         set {
            gxTv_SdtUserCustomizations_Usercustomizationsid_Z = value;
            SetDirty("Usercustomizationsid_Z");
         }

      }

      public void gxTv_SdtUserCustomizations_Usercustomizationsid_Z_SetNull( )
      {
         gxTv_SdtUserCustomizations_Usercustomizationsid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUserCustomizations_Usercustomizationsid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UserCustomizationsKey_Z" )]
      [  XmlElement( ElementName = "UserCustomizationsKey_Z"   )]
      public String gxTpr_Usercustomizationskey_Z
      {
         get {
            return gxTv_SdtUserCustomizations_Usercustomizationskey_Z ;
         }

         set {
            gxTv_SdtUserCustomizations_Usercustomizationskey_Z = value;
            SetDirty("Usercustomizationskey_Z");
         }

      }

      public void gxTv_SdtUserCustomizations_Usercustomizationskey_Z_SetNull( )
      {
         gxTv_SdtUserCustomizations_Usercustomizationskey_Z = "";
         return  ;
      }

      public bool gxTv_SdtUserCustomizations_Usercustomizationskey_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtUserCustomizations_Usercustomizationskey = "";
         gxTv_SdtUserCustomizations_Usercustomizationsvalue = "";
         gxTv_SdtUserCustomizations_Mode = "";
         gxTv_SdtUserCustomizations_Usercustomizationskey_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "usercustomizations", "GeneXus.Programs.wwpbaseobjects.usercustomizations_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtUserCustomizations_Initialized ;
      private int gxTv_SdtUserCustomizations_Usercustomizationsid ;
      private int gxTv_SdtUserCustomizations_Usercustomizationsid_Z ;
      private String gxTv_SdtUserCustomizations_Mode ;
      private String gxTv_SdtUserCustomizations_Usercustomizationsvalue ;
      private String gxTv_SdtUserCustomizations_Usercustomizationskey ;
      private String gxTv_SdtUserCustomizations_Usercustomizationskey_Z ;
   }

   [DataContract(Name = @"WWPBaseObjects\UserCustomizations", Namespace = "DataAnalysisPlatform")]
   public class SdtUserCustomizations_RESTInterface : GxGenericCollectionItem<GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtUserCustomizations_RESTInterface( ) : base()
      {
      }

      public SdtUserCustomizations_RESTInterface( GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UserCustomizationsId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<int> gxTpr_Usercustomizationsid
      {
         get {
            return sdt.gxTpr_Usercustomizationsid ;
         }

         set {
            sdt.gxTpr_Usercustomizationsid = (int)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "UserCustomizationsKey" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Usercustomizationskey
      {
         get {
            return sdt.gxTpr_Usercustomizationskey ;
         }

         set {
            sdt.gxTpr_Usercustomizationskey = value;
         }

      }

      [DataMember( Name = "UserCustomizationsValue" , Order = 2 )]
      public String gxTpr_Usercustomizationsvalue
      {
         get {
            return sdt.gxTpr_Usercustomizationsvalue ;
         }

         set {
            sdt.gxTpr_Usercustomizationsvalue = value;
         }

      }

      public GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations sdt
      {
         get {
            return (GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 3 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
