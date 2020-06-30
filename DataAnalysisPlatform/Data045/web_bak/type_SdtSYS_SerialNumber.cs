/*
               File: type_SdtSYS_SerialNumber
        Description: SYS_Serial Number
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:46.82
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
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "SYS_SerialNumber" )]
   [XmlType(TypeName =  "SYS_SerialNumber" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_SerialNumber : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_SerialNumber( )
      {
      }

      public SdtSYS_SerialNumber( IGxContext context )
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

      public void Load( String AV357SerialKey )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(String)AV357SerialKey});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SerialKey", typeof(String)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_SerialNumber");
         metadata.Set("BT", "SYS_SERIALNUMBER");
         metadata.Set("PK", "[ \"SerialKey\" ]");
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
         state.Add("gxTpr_Serialkey_Z");
         state.Add("gxTpr_Currentvalue_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_SerialNumber sdt ;
         sdt = (SdtSYS_SerialNumber)(source);
         gxTv_SdtSYS_SerialNumber_Serialkey = sdt.gxTv_SdtSYS_SerialNumber_Serialkey ;
         gxTv_SdtSYS_SerialNumber_Currentvalue = sdt.gxTv_SdtSYS_SerialNumber_Currentvalue ;
         gxTv_SdtSYS_SerialNumber_Mode = sdt.gxTv_SdtSYS_SerialNumber_Mode ;
         gxTv_SdtSYS_SerialNumber_Initialized = sdt.gxTv_SdtSYS_SerialNumber_Initialized ;
         gxTv_SdtSYS_SerialNumber_Serialkey_Z = sdt.gxTv_SdtSYS_SerialNumber_Serialkey_Z ;
         gxTv_SdtSYS_SerialNumber_Currentvalue_Z = sdt.gxTv_SdtSYS_SerialNumber_Currentvalue_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SerialKey", gxTv_SdtSYS_SerialNumber_Serialkey, false);
         AddObjectProperty("CurrentValue", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSYS_SerialNumber_Currentvalue), 18, 0)), false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_SerialNumber_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_SerialNumber_Initialized, false);
            AddObjectProperty("SerialKey_Z", gxTv_SdtSYS_SerialNumber_Serialkey_Z, false);
            AddObjectProperty("CurrentValue_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSYS_SerialNumber_Currentvalue_Z), 18, 0)), false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_SerialNumber sdt )
      {
         if ( sdt.IsDirty("SerialKey") )
         {
            gxTv_SdtSYS_SerialNumber_Serialkey = sdt.gxTv_SdtSYS_SerialNumber_Serialkey ;
         }
         if ( sdt.IsDirty("CurrentValue") )
         {
            gxTv_SdtSYS_SerialNumber_Currentvalue = sdt.gxTv_SdtSYS_SerialNumber_Currentvalue ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SerialKey" )]
      [  XmlElement( ElementName = "SerialKey"   )]
      public String gxTpr_Serialkey
      {
         get {
            return gxTv_SdtSYS_SerialNumber_Serialkey ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtSYS_SerialNumber_Serialkey, value) != 0 )
            {
               gxTv_SdtSYS_SerialNumber_Mode = "INS";
               this.gxTv_SdtSYS_SerialNumber_Serialkey_Z_SetNull( );
               this.gxTv_SdtSYS_SerialNumber_Currentvalue_Z_SetNull( );
            }
            gxTv_SdtSYS_SerialNumber_Serialkey = value;
            SetDirty("Serialkey");
         }

      }

      [  SoapElement( ElementName = "CurrentValue" )]
      [  XmlElement( ElementName = "CurrentValue"   )]
      public long gxTpr_Currentvalue
      {
         get {
            return gxTv_SdtSYS_SerialNumber_Currentvalue ;
         }

         set {
            gxTv_SdtSYS_SerialNumber_Currentvalue = value;
            SetDirty("Currentvalue");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_SerialNumber_Mode ;
         }

         set {
            gxTv_SdtSYS_SerialNumber_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_SerialNumber_Mode_SetNull( )
      {
         gxTv_SdtSYS_SerialNumber_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_SerialNumber_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_SerialNumber_Initialized ;
         }

         set {
            gxTv_SdtSYS_SerialNumber_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_SerialNumber_Initialized_SetNull( )
      {
         gxTv_SdtSYS_SerialNumber_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_SerialNumber_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SerialKey_Z" )]
      [  XmlElement( ElementName = "SerialKey_Z"   )]
      public String gxTpr_Serialkey_Z
      {
         get {
            return gxTv_SdtSYS_SerialNumber_Serialkey_Z ;
         }

         set {
            gxTv_SdtSYS_SerialNumber_Serialkey_Z = value;
            SetDirty("Serialkey_Z");
         }

      }

      public void gxTv_SdtSYS_SerialNumber_Serialkey_Z_SetNull( )
      {
         gxTv_SdtSYS_SerialNumber_Serialkey_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_SerialNumber_Serialkey_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CurrentValue_Z" )]
      [  XmlElement( ElementName = "CurrentValue_Z"   )]
      public long gxTpr_Currentvalue_Z
      {
         get {
            return gxTv_SdtSYS_SerialNumber_Currentvalue_Z ;
         }

         set {
            gxTv_SdtSYS_SerialNumber_Currentvalue_Z = value;
            SetDirty("Currentvalue_Z");
         }

      }

      public void gxTv_SdtSYS_SerialNumber_Currentvalue_Z_SetNull( )
      {
         gxTv_SdtSYS_SerialNumber_Currentvalue_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_SerialNumber_Currentvalue_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_SerialNumber_Serialkey = "";
         gxTv_SdtSYS_SerialNumber_Mode = "";
         gxTv_SdtSYS_SerialNumber_Serialkey_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_serialnumber", "GeneXus.Programs.sys_serialnumber_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_SerialNumber_Initialized ;
      private long gxTv_SdtSYS_SerialNumber_Currentvalue ;
      private long gxTv_SdtSYS_SerialNumber_Currentvalue_Z ;
      private String gxTv_SdtSYS_SerialNumber_Mode ;
      private String gxTv_SdtSYS_SerialNumber_Serialkey ;
      private String gxTv_SdtSYS_SerialNumber_Serialkey_Z ;
   }

   [DataContract(Name = @"SYS_SerialNumber", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_SerialNumber_RESTInterface : GxGenericCollectionItem<SdtSYS_SerialNumber>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_SerialNumber_RESTInterface( ) : base()
      {
      }

      public SdtSYS_SerialNumber_RESTInterface( SdtSYS_SerialNumber psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SerialKey" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Serialkey
      {
         get {
            return sdt.gxTpr_Serialkey ;
         }

         set {
            sdt.gxTpr_Serialkey = value;
         }

      }

      [DataMember( Name = "CurrentValue" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Currentvalue
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Currentvalue), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Currentvalue = (long)(NumberUtil.Val( value, "."));
         }

      }

      public SdtSYS_SerialNumber sdt
      {
         get {
            return (SdtSYS_SerialNumber)Sdt ;
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
            sdt = new SdtSYS_SerialNumber() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 2 )]
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
