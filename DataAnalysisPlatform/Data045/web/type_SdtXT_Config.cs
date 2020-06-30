/*
               File: type_SdtXT_Config
        Description: œµÕ≥≈‰÷√±Ì
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:7:49.88
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
   [XmlRoot(ElementName = "XT_Config" )]
   [XmlType(TypeName =  "XT_Config" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtXT_Config : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtXT_Config( )
      {
      }

      public SdtXT_Config( IGxContext context )
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

      public void Load( long AV195XT_ConfigID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV195XT_ConfigID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"XT_ConfigID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "XT_Config");
         metadata.Set("BT", "XT_Config");
         metadata.Set("PK", "[ \"XT_ConfigID\" ]");
         metadata.Set("PKAssigned", "[ \"XT_ConfigID\" ]");
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
         state.Add("gxTpr_Xt_configid_Z");
         state.Add("gxTpr_Xt_configkey_Z");
         state.Add("gxTpr_Xt_configvalue1_Z");
         state.Add("gxTpr_Xt_configvalue2_Z");
         state.Add("gxTpr_Xt_configvalue3_Z");
         state.Add("gxTpr_Xt_configvalue4_Z");
         state.Add("gxTpr_Xt_configvalue5_Z");
         state.Add("gxTpr_Xt_configkey_N");
         state.Add("gxTpr_Xt_configvalue1_N");
         state.Add("gxTpr_Xt_configvalue2_N");
         state.Add("gxTpr_Xt_configvalue3_N");
         state.Add("gxTpr_Xt_configvalue4_N");
         state.Add("gxTpr_Xt_configvalue5_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtXT_Config sdt ;
         sdt = (SdtXT_Config)(source);
         gxTv_SdtXT_Config_Xt_configid = sdt.gxTv_SdtXT_Config_Xt_configid ;
         gxTv_SdtXT_Config_Xt_configkey = sdt.gxTv_SdtXT_Config_Xt_configkey ;
         gxTv_SdtXT_Config_Xt_configvalue1 = sdt.gxTv_SdtXT_Config_Xt_configvalue1 ;
         gxTv_SdtXT_Config_Xt_configvalue2 = sdt.gxTv_SdtXT_Config_Xt_configvalue2 ;
         gxTv_SdtXT_Config_Xt_configvalue3 = sdt.gxTv_SdtXT_Config_Xt_configvalue3 ;
         gxTv_SdtXT_Config_Xt_configvalue4 = sdt.gxTv_SdtXT_Config_Xt_configvalue4 ;
         gxTv_SdtXT_Config_Xt_configvalue5 = sdt.gxTv_SdtXT_Config_Xt_configvalue5 ;
         gxTv_SdtXT_Config_Mode = sdt.gxTv_SdtXT_Config_Mode ;
         gxTv_SdtXT_Config_Initialized = sdt.gxTv_SdtXT_Config_Initialized ;
         gxTv_SdtXT_Config_Xt_configid_Z = sdt.gxTv_SdtXT_Config_Xt_configid_Z ;
         gxTv_SdtXT_Config_Xt_configkey_Z = sdt.gxTv_SdtXT_Config_Xt_configkey_Z ;
         gxTv_SdtXT_Config_Xt_configvalue1_Z = sdt.gxTv_SdtXT_Config_Xt_configvalue1_Z ;
         gxTv_SdtXT_Config_Xt_configvalue2_Z = sdt.gxTv_SdtXT_Config_Xt_configvalue2_Z ;
         gxTv_SdtXT_Config_Xt_configvalue3_Z = sdt.gxTv_SdtXT_Config_Xt_configvalue3_Z ;
         gxTv_SdtXT_Config_Xt_configvalue4_Z = sdt.gxTv_SdtXT_Config_Xt_configvalue4_Z ;
         gxTv_SdtXT_Config_Xt_configvalue5_Z = sdt.gxTv_SdtXT_Config_Xt_configvalue5_Z ;
         gxTv_SdtXT_Config_Xt_configkey_N = sdt.gxTv_SdtXT_Config_Xt_configkey_N ;
         gxTv_SdtXT_Config_Xt_configvalue1_N = sdt.gxTv_SdtXT_Config_Xt_configvalue1_N ;
         gxTv_SdtXT_Config_Xt_configvalue2_N = sdt.gxTv_SdtXT_Config_Xt_configvalue2_N ;
         gxTv_SdtXT_Config_Xt_configvalue3_N = sdt.gxTv_SdtXT_Config_Xt_configvalue3_N ;
         gxTv_SdtXT_Config_Xt_configvalue4_N = sdt.gxTv_SdtXT_Config_Xt_configvalue4_N ;
         gxTv_SdtXT_Config_Xt_configvalue5_N = sdt.gxTv_SdtXT_Config_Xt_configvalue5_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_Config_Xt_configid), 18, 0)), false);
         AddObjectProperty("XT_ConfigKey", gxTv_SdtXT_Config_Xt_configkey, false);
         AddObjectProperty("XT_ConfigKey_N", gxTv_SdtXT_Config_Xt_configkey_N, false);
         AddObjectProperty("XT_ConfigValue1", gxTv_SdtXT_Config_Xt_configvalue1, false);
         AddObjectProperty("XT_ConfigValue1_N", gxTv_SdtXT_Config_Xt_configvalue1_N, false);
         AddObjectProperty("XT_ConfigValue2", gxTv_SdtXT_Config_Xt_configvalue2, false);
         AddObjectProperty("XT_ConfigValue2_N", gxTv_SdtXT_Config_Xt_configvalue2_N, false);
         AddObjectProperty("XT_ConfigValue3", gxTv_SdtXT_Config_Xt_configvalue3, false);
         AddObjectProperty("XT_ConfigValue3_N", gxTv_SdtXT_Config_Xt_configvalue3_N, false);
         AddObjectProperty("XT_ConfigValue4", gxTv_SdtXT_Config_Xt_configvalue4, false);
         AddObjectProperty("XT_ConfigValue4_N", gxTv_SdtXT_Config_Xt_configvalue4_N, false);
         AddObjectProperty("XT_ConfigValue5", gxTv_SdtXT_Config_Xt_configvalue5, false);
         AddObjectProperty("XT_ConfigValue5_N", gxTv_SdtXT_Config_Xt_configvalue5_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtXT_Config_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtXT_Config_Initialized, false);
            AddObjectProperty("XT_ConfigID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtXT_Config_Xt_configid_Z), 18, 0)), false);
            AddObjectProperty("XT_ConfigKey_Z", gxTv_SdtXT_Config_Xt_configkey_Z, false);
            AddObjectProperty("XT_ConfigValue1_Z", gxTv_SdtXT_Config_Xt_configvalue1_Z, false);
            AddObjectProperty("XT_ConfigValue2_Z", gxTv_SdtXT_Config_Xt_configvalue2_Z, false);
            AddObjectProperty("XT_ConfigValue3_Z", gxTv_SdtXT_Config_Xt_configvalue3_Z, false);
            AddObjectProperty("XT_ConfigValue4_Z", gxTv_SdtXT_Config_Xt_configvalue4_Z, false);
            AddObjectProperty("XT_ConfigValue5_Z", gxTv_SdtXT_Config_Xt_configvalue5_Z, false);
            AddObjectProperty("XT_ConfigKey_N", gxTv_SdtXT_Config_Xt_configkey_N, false);
            AddObjectProperty("XT_ConfigValue1_N", gxTv_SdtXT_Config_Xt_configvalue1_N, false);
            AddObjectProperty("XT_ConfigValue2_N", gxTv_SdtXT_Config_Xt_configvalue2_N, false);
            AddObjectProperty("XT_ConfigValue3_N", gxTv_SdtXT_Config_Xt_configvalue3_N, false);
            AddObjectProperty("XT_ConfigValue4_N", gxTv_SdtXT_Config_Xt_configvalue4_N, false);
            AddObjectProperty("XT_ConfigValue5_N", gxTv_SdtXT_Config_Xt_configvalue5_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtXT_Config sdt )
      {
         if ( sdt.IsDirty("XT_ConfigID") )
         {
            gxTv_SdtXT_Config_Xt_configid = sdt.gxTv_SdtXT_Config_Xt_configid ;
         }
         if ( sdt.IsDirty("XT_ConfigKey") )
         {
            gxTv_SdtXT_Config_Xt_configkey = sdt.gxTv_SdtXT_Config_Xt_configkey ;
         }
         if ( sdt.IsDirty("XT_ConfigValue1") )
         {
            gxTv_SdtXT_Config_Xt_configvalue1 = sdt.gxTv_SdtXT_Config_Xt_configvalue1 ;
         }
         if ( sdt.IsDirty("XT_ConfigValue2") )
         {
            gxTv_SdtXT_Config_Xt_configvalue2 = sdt.gxTv_SdtXT_Config_Xt_configvalue2 ;
         }
         if ( sdt.IsDirty("XT_ConfigValue3") )
         {
            gxTv_SdtXT_Config_Xt_configvalue3 = sdt.gxTv_SdtXT_Config_Xt_configvalue3 ;
         }
         if ( sdt.IsDirty("XT_ConfigValue4") )
         {
            gxTv_SdtXT_Config_Xt_configvalue4 = sdt.gxTv_SdtXT_Config_Xt_configvalue4 ;
         }
         if ( sdt.IsDirty("XT_ConfigValue5") )
         {
            gxTv_SdtXT_Config_Xt_configvalue5 = sdt.gxTv_SdtXT_Config_Xt_configvalue5 ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "XT_ConfigID" )]
      [  XmlElement( ElementName = "XT_ConfigID"   )]
      public long gxTpr_Xt_configid
      {
         get {
            return gxTv_SdtXT_Config_Xt_configid ;
         }

         set {
            if ( gxTv_SdtXT_Config_Xt_configid != value )
            {
               gxTv_SdtXT_Config_Mode = "INS";
               this.gxTv_SdtXT_Config_Xt_configid_Z_SetNull( );
               this.gxTv_SdtXT_Config_Xt_configkey_Z_SetNull( );
               this.gxTv_SdtXT_Config_Xt_configvalue1_Z_SetNull( );
               this.gxTv_SdtXT_Config_Xt_configvalue2_Z_SetNull( );
               this.gxTv_SdtXT_Config_Xt_configvalue3_Z_SetNull( );
               this.gxTv_SdtXT_Config_Xt_configvalue4_Z_SetNull( );
               this.gxTv_SdtXT_Config_Xt_configvalue5_Z_SetNull( );
            }
            gxTv_SdtXT_Config_Xt_configid = value;
            SetDirty("Xt_configid");
         }

      }

      [  SoapElement( ElementName = "XT_ConfigKey" )]
      [  XmlElement( ElementName = "XT_ConfigKey"   )]
      public String gxTpr_Xt_configkey
      {
         get {
            return gxTv_SdtXT_Config_Xt_configkey ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configkey_N = 0;
            gxTv_SdtXT_Config_Xt_configkey = value;
            SetDirty("Xt_configkey");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configkey_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configkey_N = 1;
         gxTv_SdtXT_Config_Xt_configkey = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configkey_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue1" )]
      [  XmlElement( ElementName = "XT_ConfigValue1"   )]
      public String gxTpr_Xt_configvalue1
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue1 ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue1_N = 0;
            gxTv_SdtXT_Config_Xt_configvalue1 = value;
            SetDirty("Xt_configvalue1");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue1_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue1_N = 1;
         gxTv_SdtXT_Config_Xt_configvalue1 = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue1_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue2" )]
      [  XmlElement( ElementName = "XT_ConfigValue2"   )]
      public String gxTpr_Xt_configvalue2
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue2 ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue2_N = 0;
            gxTv_SdtXT_Config_Xt_configvalue2 = value;
            SetDirty("Xt_configvalue2");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue2_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue2_N = 1;
         gxTv_SdtXT_Config_Xt_configvalue2 = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue2_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue3" )]
      [  XmlElement( ElementName = "XT_ConfigValue3"   )]
      public String gxTpr_Xt_configvalue3
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue3 ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue3_N = 0;
            gxTv_SdtXT_Config_Xt_configvalue3 = value;
            SetDirty("Xt_configvalue3");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue3_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue3_N = 1;
         gxTv_SdtXT_Config_Xt_configvalue3 = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue3_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue4" )]
      [  XmlElement( ElementName = "XT_ConfigValue4"   )]
      public String gxTpr_Xt_configvalue4
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue4 ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue4_N = 0;
            gxTv_SdtXT_Config_Xt_configvalue4 = value;
            SetDirty("Xt_configvalue4");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue4_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue4_N = 1;
         gxTv_SdtXT_Config_Xt_configvalue4 = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue4_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue5" )]
      [  XmlElement( ElementName = "XT_ConfigValue5"   )]
      public String gxTpr_Xt_configvalue5
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue5 ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue5_N = 0;
            gxTv_SdtXT_Config_Xt_configvalue5 = value;
            SetDirty("Xt_configvalue5");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue5_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue5_N = 1;
         gxTv_SdtXT_Config_Xt_configvalue5 = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue5_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtXT_Config_Mode ;
         }

         set {
            gxTv_SdtXT_Config_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtXT_Config_Mode_SetNull( )
      {
         gxTv_SdtXT_Config_Mode = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtXT_Config_Initialized ;
         }

         set {
            gxTv_SdtXT_Config_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtXT_Config_Initialized_SetNull( )
      {
         gxTv_SdtXT_Config_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Config_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigID_Z" )]
      [  XmlElement( ElementName = "XT_ConfigID_Z"   )]
      public long gxTpr_Xt_configid_Z
      {
         get {
            return gxTv_SdtXT_Config_Xt_configid_Z ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configid_Z = value;
            SetDirty("Xt_configid_Z");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configid_Z_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigKey_Z" )]
      [  XmlElement( ElementName = "XT_ConfigKey_Z"   )]
      public String gxTpr_Xt_configkey_Z
      {
         get {
            return gxTv_SdtXT_Config_Xt_configkey_Z ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configkey_Z = value;
            SetDirty("Xt_configkey_Z");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configkey_Z_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configkey_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configkey_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue1_Z" )]
      [  XmlElement( ElementName = "XT_ConfigValue1_Z"   )]
      public String gxTpr_Xt_configvalue1_Z
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue1_Z ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue1_Z = value;
            SetDirty("Xt_configvalue1_Z");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue1_Z_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue1_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue1_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue2_Z" )]
      [  XmlElement( ElementName = "XT_ConfigValue2_Z"   )]
      public String gxTpr_Xt_configvalue2_Z
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue2_Z ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue2_Z = value;
            SetDirty("Xt_configvalue2_Z");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue2_Z_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue2_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue2_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue3_Z" )]
      [  XmlElement( ElementName = "XT_ConfigValue3_Z"   )]
      public String gxTpr_Xt_configvalue3_Z
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue3_Z ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue3_Z = value;
            SetDirty("Xt_configvalue3_Z");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue3_Z_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue3_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue3_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue4_Z" )]
      [  XmlElement( ElementName = "XT_ConfigValue4_Z"   )]
      public String gxTpr_Xt_configvalue4_Z
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue4_Z ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue4_Z = value;
            SetDirty("Xt_configvalue4_Z");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue4_Z_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue4_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue4_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue5_Z" )]
      [  XmlElement( ElementName = "XT_ConfigValue5_Z"   )]
      public String gxTpr_Xt_configvalue5_Z
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue5_Z ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue5_Z = value;
            SetDirty("Xt_configvalue5_Z");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue5_Z_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue5_Z = "";
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue5_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigKey_N" )]
      [  XmlElement( ElementName = "XT_ConfigKey_N"   )]
      public short gxTpr_Xt_configkey_N
      {
         get {
            return gxTv_SdtXT_Config_Xt_configkey_N ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configkey_N = value;
            SetDirty("Xt_configkey_N");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configkey_N_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configkey_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configkey_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue1_N" )]
      [  XmlElement( ElementName = "XT_ConfigValue1_N"   )]
      public short gxTpr_Xt_configvalue1_N
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue1_N ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue1_N = value;
            SetDirty("Xt_configvalue1_N");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue1_N_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue1_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue1_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue2_N" )]
      [  XmlElement( ElementName = "XT_ConfigValue2_N"   )]
      public short gxTpr_Xt_configvalue2_N
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue2_N ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue2_N = value;
            SetDirty("Xt_configvalue2_N");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue2_N_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue2_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue2_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue3_N" )]
      [  XmlElement( ElementName = "XT_ConfigValue3_N"   )]
      public short gxTpr_Xt_configvalue3_N
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue3_N ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue3_N = value;
            SetDirty("Xt_configvalue3_N");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue3_N_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue3_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue3_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue4_N" )]
      [  XmlElement( ElementName = "XT_ConfigValue4_N"   )]
      public short gxTpr_Xt_configvalue4_N
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue4_N ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue4_N = value;
            SetDirty("Xt_configvalue4_N");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue4_N_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue4_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue4_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "XT_ConfigValue5_N" )]
      [  XmlElement( ElementName = "XT_ConfigValue5_N"   )]
      public short gxTpr_Xt_configvalue5_N
      {
         get {
            return gxTv_SdtXT_Config_Xt_configvalue5_N ;
         }

         set {
            gxTv_SdtXT_Config_Xt_configvalue5_N = value;
            SetDirty("Xt_configvalue5_N");
         }

      }

      public void gxTv_SdtXT_Config_Xt_configvalue5_N_SetNull( )
      {
         gxTv_SdtXT_Config_Xt_configvalue5_N = 0;
         return  ;
      }

      public bool gxTv_SdtXT_Config_Xt_configvalue5_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtXT_Config_Xt_configkey = "";
         gxTv_SdtXT_Config_Xt_configvalue1 = "";
         gxTv_SdtXT_Config_Xt_configvalue2 = "";
         gxTv_SdtXT_Config_Xt_configvalue3 = "";
         gxTv_SdtXT_Config_Xt_configvalue4 = "";
         gxTv_SdtXT_Config_Xt_configvalue5 = "";
         gxTv_SdtXT_Config_Mode = "";
         gxTv_SdtXT_Config_Xt_configkey_Z = "";
         gxTv_SdtXT_Config_Xt_configvalue1_Z = "";
         gxTv_SdtXT_Config_Xt_configvalue2_Z = "";
         gxTv_SdtXT_Config_Xt_configvalue3_Z = "";
         gxTv_SdtXT_Config_Xt_configvalue4_Z = "";
         gxTv_SdtXT_Config_Xt_configvalue5_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "xt_config", "GeneXus.Programs.xt_config_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtXT_Config_Initialized ;
      private short gxTv_SdtXT_Config_Xt_configkey_N ;
      private short gxTv_SdtXT_Config_Xt_configvalue1_N ;
      private short gxTv_SdtXT_Config_Xt_configvalue2_N ;
      private short gxTv_SdtXT_Config_Xt_configvalue3_N ;
      private short gxTv_SdtXT_Config_Xt_configvalue4_N ;
      private short gxTv_SdtXT_Config_Xt_configvalue5_N ;
      private long gxTv_SdtXT_Config_Xt_configid ;
      private long gxTv_SdtXT_Config_Xt_configid_Z ;
      private String gxTv_SdtXT_Config_Mode ;
      private String gxTv_SdtXT_Config_Xt_configkey ;
      private String gxTv_SdtXT_Config_Xt_configvalue1 ;
      private String gxTv_SdtXT_Config_Xt_configvalue2 ;
      private String gxTv_SdtXT_Config_Xt_configvalue3 ;
      private String gxTv_SdtXT_Config_Xt_configvalue4 ;
      private String gxTv_SdtXT_Config_Xt_configvalue5 ;
      private String gxTv_SdtXT_Config_Xt_configkey_Z ;
      private String gxTv_SdtXT_Config_Xt_configvalue1_Z ;
      private String gxTv_SdtXT_Config_Xt_configvalue2_Z ;
      private String gxTv_SdtXT_Config_Xt_configvalue3_Z ;
      private String gxTv_SdtXT_Config_Xt_configvalue4_Z ;
      private String gxTv_SdtXT_Config_Xt_configvalue5_Z ;
   }

   [DataContract(Name = @"XT_Config", Namespace = "DataAnalysisPlatform")]
   public class SdtXT_Config_RESTInterface : GxGenericCollectionItem<SdtXT_Config>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtXT_Config_RESTInterface( ) : base()
      {
      }

      public SdtXT_Config_RESTInterface( SdtXT_Config psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "XT_ConfigID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Xt_configid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Xt_configid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Xt_configid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "XT_ConfigKey" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Xt_configkey
      {
         get {
            return sdt.gxTpr_Xt_configkey ;
         }

         set {
            sdt.gxTpr_Xt_configkey = value;
         }

      }

      [DataMember( Name = "XT_ConfigValue1" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Xt_configvalue1
      {
         get {
            return sdt.gxTpr_Xt_configvalue1 ;
         }

         set {
            sdt.gxTpr_Xt_configvalue1 = value;
         }

      }

      [DataMember( Name = "XT_ConfigValue2" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Xt_configvalue2
      {
         get {
            return sdt.gxTpr_Xt_configvalue2 ;
         }

         set {
            sdt.gxTpr_Xt_configvalue2 = value;
         }

      }

      [DataMember( Name = "XT_ConfigValue3" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Xt_configvalue3
      {
         get {
            return sdt.gxTpr_Xt_configvalue3 ;
         }

         set {
            sdt.gxTpr_Xt_configvalue3 = value;
         }

      }

      [DataMember( Name = "XT_ConfigValue4" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Xt_configvalue4
      {
         get {
            return sdt.gxTpr_Xt_configvalue4 ;
         }

         set {
            sdt.gxTpr_Xt_configvalue4 = value;
         }

      }

      [DataMember( Name = "XT_ConfigValue5" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Xt_configvalue5
      {
         get {
            return sdt.gxTpr_Xt_configvalue5 ;
         }

         set {
            sdt.gxTpr_Xt_configvalue5 = value;
         }

      }

      public SdtXT_Config sdt
      {
         get {
            return (SdtXT_Config)Sdt ;
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
            sdt = new SdtXT_Config() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 7 )]
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
