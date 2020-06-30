/*
               File: type_SdtJC_Provider
        Description: 医院
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:56:49.58
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
   [XmlRoot(ElementName = "JC_Provider" )]
   [XmlType(TypeName =  "JC_Provider" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtJC_Provider : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtJC_Provider( )
      {
      }

      public SdtJC_Provider( IGxContext context )
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

      public void Load( long AV87JC_ProviderID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV87JC_ProviderID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"JC_ProviderID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "JC_Provider");
         metadata.Set("BT", "JC_Provider");
         metadata.Set("PK", "[ \"JC_ProviderID\" ]");
         metadata.Set("PKAssigned", "[ \"JC_ProviderID\" ]");
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
         state.Add("gxTpr_Jc_providerid_Z");
         state.Add("gxTpr_Jc_providername_Z");
         state.Add("gxTpr_Jc_providershortname_Z");
         state.Add("gxTpr_Jc_provideraddresss_Z");
         state.Add("gxTpr_Jc_providerphone_Z");
         state.Add("gxTpr_Jc_provideruser_Z");
         state.Add("gxTpr_Jc_providername_N");
         state.Add("gxTpr_Jc_providershortname_N");
         state.Add("gxTpr_Jc_provideraddresss_N");
         state.Add("gxTpr_Jc_providerphone_N");
         state.Add("gxTpr_Jc_provideruser_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtJC_Provider sdt ;
         sdt = (SdtJC_Provider)(source);
         gxTv_SdtJC_Provider_Jc_providerid = sdt.gxTv_SdtJC_Provider_Jc_providerid ;
         gxTv_SdtJC_Provider_Jc_providername = sdt.gxTv_SdtJC_Provider_Jc_providername ;
         gxTv_SdtJC_Provider_Jc_providershortname = sdt.gxTv_SdtJC_Provider_Jc_providershortname ;
         gxTv_SdtJC_Provider_Jc_provideraddresss = sdt.gxTv_SdtJC_Provider_Jc_provideraddresss ;
         gxTv_SdtJC_Provider_Jc_providerphone = sdt.gxTv_SdtJC_Provider_Jc_providerphone ;
         gxTv_SdtJC_Provider_Jc_provideruser = sdt.gxTv_SdtJC_Provider_Jc_provideruser ;
         gxTv_SdtJC_Provider_Mode = sdt.gxTv_SdtJC_Provider_Mode ;
         gxTv_SdtJC_Provider_Initialized = sdt.gxTv_SdtJC_Provider_Initialized ;
         gxTv_SdtJC_Provider_Jc_providerid_Z = sdt.gxTv_SdtJC_Provider_Jc_providerid_Z ;
         gxTv_SdtJC_Provider_Jc_providername_Z = sdt.gxTv_SdtJC_Provider_Jc_providername_Z ;
         gxTv_SdtJC_Provider_Jc_providershortname_Z = sdt.gxTv_SdtJC_Provider_Jc_providershortname_Z ;
         gxTv_SdtJC_Provider_Jc_provideraddresss_Z = sdt.gxTv_SdtJC_Provider_Jc_provideraddresss_Z ;
         gxTv_SdtJC_Provider_Jc_providerphone_Z = sdt.gxTv_SdtJC_Provider_Jc_providerphone_Z ;
         gxTv_SdtJC_Provider_Jc_provideruser_Z = sdt.gxTv_SdtJC_Provider_Jc_provideruser_Z ;
         gxTv_SdtJC_Provider_Jc_providername_N = sdt.gxTv_SdtJC_Provider_Jc_providername_N ;
         gxTv_SdtJC_Provider_Jc_providershortname_N = sdt.gxTv_SdtJC_Provider_Jc_providershortname_N ;
         gxTv_SdtJC_Provider_Jc_provideraddresss_N = sdt.gxTv_SdtJC_Provider_Jc_provideraddresss_N ;
         gxTv_SdtJC_Provider_Jc_providerphone_N = sdt.gxTv_SdtJC_Provider_Jc_providerphone_N ;
         gxTv_SdtJC_Provider_Jc_provideruser_N = sdt.gxTv_SdtJC_Provider_Jc_provideruser_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtJC_Provider_Jc_providerid), 18, 0)), false);
         AddObjectProperty("JC_ProviderName", gxTv_SdtJC_Provider_Jc_providername, false);
         AddObjectProperty("JC_ProviderName_N", gxTv_SdtJC_Provider_Jc_providername_N, false);
         AddObjectProperty("JC_ProviderShortName", gxTv_SdtJC_Provider_Jc_providershortname, false);
         AddObjectProperty("JC_ProviderShortName_N", gxTv_SdtJC_Provider_Jc_providershortname_N, false);
         AddObjectProperty("JC_ProviderAddresss", gxTv_SdtJC_Provider_Jc_provideraddresss, false);
         AddObjectProperty("JC_ProviderAddresss_N", gxTv_SdtJC_Provider_Jc_provideraddresss_N, false);
         AddObjectProperty("JC_ProviderPhone", gxTv_SdtJC_Provider_Jc_providerphone, false);
         AddObjectProperty("JC_ProviderPhone_N", gxTv_SdtJC_Provider_Jc_providerphone_N, false);
         AddObjectProperty("JC_ProviderUser", gxTv_SdtJC_Provider_Jc_provideruser, false);
         AddObjectProperty("JC_ProviderUser_N", gxTv_SdtJC_Provider_Jc_provideruser_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtJC_Provider_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtJC_Provider_Initialized, false);
            AddObjectProperty("JC_ProviderID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtJC_Provider_Jc_providerid_Z), 18, 0)), false);
            AddObjectProperty("JC_ProviderName_Z", gxTv_SdtJC_Provider_Jc_providername_Z, false);
            AddObjectProperty("JC_ProviderShortName_Z", gxTv_SdtJC_Provider_Jc_providershortname_Z, false);
            AddObjectProperty("JC_ProviderAddresss_Z", gxTv_SdtJC_Provider_Jc_provideraddresss_Z, false);
            AddObjectProperty("JC_ProviderPhone_Z", gxTv_SdtJC_Provider_Jc_providerphone_Z, false);
            AddObjectProperty("JC_ProviderUser_Z", gxTv_SdtJC_Provider_Jc_provideruser_Z, false);
            AddObjectProperty("JC_ProviderName_N", gxTv_SdtJC_Provider_Jc_providername_N, false);
            AddObjectProperty("JC_ProviderShortName_N", gxTv_SdtJC_Provider_Jc_providershortname_N, false);
            AddObjectProperty("JC_ProviderAddresss_N", gxTv_SdtJC_Provider_Jc_provideraddresss_N, false);
            AddObjectProperty("JC_ProviderPhone_N", gxTv_SdtJC_Provider_Jc_providerphone_N, false);
            AddObjectProperty("JC_ProviderUser_N", gxTv_SdtJC_Provider_Jc_provideruser_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtJC_Provider sdt )
      {
         if ( sdt.IsDirty("JC_ProviderID") )
         {
            gxTv_SdtJC_Provider_Jc_providerid = sdt.gxTv_SdtJC_Provider_Jc_providerid ;
         }
         if ( sdt.IsDirty("JC_ProviderName") )
         {
            gxTv_SdtJC_Provider_Jc_providername = sdt.gxTv_SdtJC_Provider_Jc_providername ;
         }
         if ( sdt.IsDirty("JC_ProviderShortName") )
         {
            gxTv_SdtJC_Provider_Jc_providershortname = sdt.gxTv_SdtJC_Provider_Jc_providershortname ;
         }
         if ( sdt.IsDirty("JC_ProviderAddresss") )
         {
            gxTv_SdtJC_Provider_Jc_provideraddresss = sdt.gxTv_SdtJC_Provider_Jc_provideraddresss ;
         }
         if ( sdt.IsDirty("JC_ProviderPhone") )
         {
            gxTv_SdtJC_Provider_Jc_providerphone = sdt.gxTv_SdtJC_Provider_Jc_providerphone ;
         }
         if ( sdt.IsDirty("JC_ProviderUser") )
         {
            gxTv_SdtJC_Provider_Jc_provideruser = sdt.gxTv_SdtJC_Provider_Jc_provideruser ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "JC_ProviderID" )]
      [  XmlElement( ElementName = "JC_ProviderID"   )]
      public long gxTpr_Jc_providerid
      {
         get {
            return gxTv_SdtJC_Provider_Jc_providerid ;
         }

         set {
            if ( gxTv_SdtJC_Provider_Jc_providerid != value )
            {
               gxTv_SdtJC_Provider_Mode = "INS";
               this.gxTv_SdtJC_Provider_Jc_providerid_Z_SetNull( );
               this.gxTv_SdtJC_Provider_Jc_providername_Z_SetNull( );
               this.gxTv_SdtJC_Provider_Jc_providershortname_Z_SetNull( );
               this.gxTv_SdtJC_Provider_Jc_provideraddresss_Z_SetNull( );
               this.gxTv_SdtJC_Provider_Jc_providerphone_Z_SetNull( );
               this.gxTv_SdtJC_Provider_Jc_provideruser_Z_SetNull( );
            }
            gxTv_SdtJC_Provider_Jc_providerid = value;
            SetDirty("Jc_providerid");
         }

      }

      [  SoapElement( ElementName = "JC_ProviderName" )]
      [  XmlElement( ElementName = "JC_ProviderName"   )]
      public String gxTpr_Jc_providername
      {
         get {
            return gxTv_SdtJC_Provider_Jc_providername ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_providername_N = 0;
            gxTv_SdtJC_Provider_Jc_providername = value;
            SetDirty("Jc_providername");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_providername_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_providername_N = 1;
         gxTv_SdtJC_Provider_Jc_providername = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_providername_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderShortName" )]
      [  XmlElement( ElementName = "JC_ProviderShortName"   )]
      public String gxTpr_Jc_providershortname
      {
         get {
            return gxTv_SdtJC_Provider_Jc_providershortname ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_providershortname_N = 0;
            gxTv_SdtJC_Provider_Jc_providershortname = value;
            SetDirty("Jc_providershortname");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_providershortname_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_providershortname_N = 1;
         gxTv_SdtJC_Provider_Jc_providershortname = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_providershortname_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderAddresss" )]
      [  XmlElement( ElementName = "JC_ProviderAddresss"   )]
      public String gxTpr_Jc_provideraddresss
      {
         get {
            return gxTv_SdtJC_Provider_Jc_provideraddresss ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_provideraddresss_N = 0;
            gxTv_SdtJC_Provider_Jc_provideraddresss = value;
            SetDirty("Jc_provideraddresss");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_provideraddresss_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_provideraddresss_N = 1;
         gxTv_SdtJC_Provider_Jc_provideraddresss = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_provideraddresss_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderPhone" )]
      [  XmlElement( ElementName = "JC_ProviderPhone"   )]
      public String gxTpr_Jc_providerphone
      {
         get {
            return gxTv_SdtJC_Provider_Jc_providerphone ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_providerphone_N = 0;
            gxTv_SdtJC_Provider_Jc_providerphone = value;
            SetDirty("Jc_providerphone");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_providerphone_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_providerphone_N = 1;
         gxTv_SdtJC_Provider_Jc_providerphone = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_providerphone_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderUser" )]
      [  XmlElement( ElementName = "JC_ProviderUser"   )]
      public String gxTpr_Jc_provideruser
      {
         get {
            return gxTv_SdtJC_Provider_Jc_provideruser ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_provideruser_N = 0;
            gxTv_SdtJC_Provider_Jc_provideruser = value;
            SetDirty("Jc_provideruser");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_provideruser_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_provideruser_N = 1;
         gxTv_SdtJC_Provider_Jc_provideruser = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_provideruser_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtJC_Provider_Mode ;
         }

         set {
            gxTv_SdtJC_Provider_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtJC_Provider_Mode_SetNull( )
      {
         gxTv_SdtJC_Provider_Mode = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtJC_Provider_Initialized ;
         }

         set {
            gxTv_SdtJC_Provider_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtJC_Provider_Initialized_SetNull( )
      {
         gxTv_SdtJC_Provider_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderID_Z" )]
      [  XmlElement( ElementName = "JC_ProviderID_Z"   )]
      public long gxTpr_Jc_providerid_Z
      {
         get {
            return gxTv_SdtJC_Provider_Jc_providerid_Z ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_providerid_Z = value;
            SetDirty("Jc_providerid_Z");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_providerid_Z_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_providerid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_providerid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderName_Z" )]
      [  XmlElement( ElementName = "JC_ProviderName_Z"   )]
      public String gxTpr_Jc_providername_Z
      {
         get {
            return gxTv_SdtJC_Provider_Jc_providername_Z ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_providername_Z = value;
            SetDirty("Jc_providername_Z");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_providername_Z_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_providername_Z = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_providername_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderShortName_Z" )]
      [  XmlElement( ElementName = "JC_ProviderShortName_Z"   )]
      public String gxTpr_Jc_providershortname_Z
      {
         get {
            return gxTv_SdtJC_Provider_Jc_providershortname_Z ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_providershortname_Z = value;
            SetDirty("Jc_providershortname_Z");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_providershortname_Z_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_providershortname_Z = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_providershortname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderAddresss_Z" )]
      [  XmlElement( ElementName = "JC_ProviderAddresss_Z"   )]
      public String gxTpr_Jc_provideraddresss_Z
      {
         get {
            return gxTv_SdtJC_Provider_Jc_provideraddresss_Z ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_provideraddresss_Z = value;
            SetDirty("Jc_provideraddresss_Z");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_provideraddresss_Z_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_provideraddresss_Z = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_provideraddresss_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderPhone_Z" )]
      [  XmlElement( ElementName = "JC_ProviderPhone_Z"   )]
      public String gxTpr_Jc_providerphone_Z
      {
         get {
            return gxTv_SdtJC_Provider_Jc_providerphone_Z ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_providerphone_Z = value;
            SetDirty("Jc_providerphone_Z");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_providerphone_Z_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_providerphone_Z = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_providerphone_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderUser_Z" )]
      [  XmlElement( ElementName = "JC_ProviderUser_Z"   )]
      public String gxTpr_Jc_provideruser_Z
      {
         get {
            return gxTv_SdtJC_Provider_Jc_provideruser_Z ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_provideruser_Z = value;
            SetDirty("Jc_provideruser_Z");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_provideruser_Z_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_provideruser_Z = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_provideruser_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderName_N" )]
      [  XmlElement( ElementName = "JC_ProviderName_N"   )]
      public short gxTpr_Jc_providername_N
      {
         get {
            return gxTv_SdtJC_Provider_Jc_providername_N ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_providername_N = value;
            SetDirty("Jc_providername_N");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_providername_N_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_providername_N = 0;
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_providername_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderShortName_N" )]
      [  XmlElement( ElementName = "JC_ProviderShortName_N"   )]
      public short gxTpr_Jc_providershortname_N
      {
         get {
            return gxTv_SdtJC_Provider_Jc_providershortname_N ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_providershortname_N = value;
            SetDirty("Jc_providershortname_N");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_providershortname_N_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_providershortname_N = 0;
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_providershortname_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderAddresss_N" )]
      [  XmlElement( ElementName = "JC_ProviderAddresss_N"   )]
      public short gxTpr_Jc_provideraddresss_N
      {
         get {
            return gxTv_SdtJC_Provider_Jc_provideraddresss_N ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_provideraddresss_N = value;
            SetDirty("Jc_provideraddresss_N");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_provideraddresss_N_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_provideraddresss_N = 0;
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_provideraddresss_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderPhone_N" )]
      [  XmlElement( ElementName = "JC_ProviderPhone_N"   )]
      public short gxTpr_Jc_providerphone_N
      {
         get {
            return gxTv_SdtJC_Provider_Jc_providerphone_N ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_providerphone_N = value;
            SetDirty("Jc_providerphone_N");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_providerphone_N_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_providerphone_N = 0;
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_providerphone_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderUser_N" )]
      [  XmlElement( ElementName = "JC_ProviderUser_N"   )]
      public short gxTpr_Jc_provideruser_N
      {
         get {
            return gxTv_SdtJC_Provider_Jc_provideruser_N ;
         }

         set {
            gxTv_SdtJC_Provider_Jc_provideruser_N = value;
            SetDirty("Jc_provideruser_N");
         }

      }

      public void gxTv_SdtJC_Provider_Jc_provideruser_N_SetNull( )
      {
         gxTv_SdtJC_Provider_Jc_provideruser_N = 0;
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Jc_provideruser_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtJC_Provider_Jc_providername = "";
         gxTv_SdtJC_Provider_Jc_providershortname = "";
         gxTv_SdtJC_Provider_Jc_provideraddresss = "";
         gxTv_SdtJC_Provider_Jc_providerphone = "";
         gxTv_SdtJC_Provider_Jc_provideruser = "";
         gxTv_SdtJC_Provider_Mode = "";
         gxTv_SdtJC_Provider_Jc_providername_Z = "";
         gxTv_SdtJC_Provider_Jc_providershortname_Z = "";
         gxTv_SdtJC_Provider_Jc_provideraddresss_Z = "";
         gxTv_SdtJC_Provider_Jc_providerphone_Z = "";
         gxTv_SdtJC_Provider_Jc_provideruser_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "jc_provider", "GeneXus.Programs.jc_provider_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtJC_Provider_Initialized ;
      private short gxTv_SdtJC_Provider_Jc_providername_N ;
      private short gxTv_SdtJC_Provider_Jc_providershortname_N ;
      private short gxTv_SdtJC_Provider_Jc_provideraddresss_N ;
      private short gxTv_SdtJC_Provider_Jc_providerphone_N ;
      private short gxTv_SdtJC_Provider_Jc_provideruser_N ;
      private long gxTv_SdtJC_Provider_Jc_providerid ;
      private long gxTv_SdtJC_Provider_Jc_providerid_Z ;
      private String gxTv_SdtJC_Provider_Jc_providerphone ;
      private String gxTv_SdtJC_Provider_Mode ;
      private String gxTv_SdtJC_Provider_Jc_providerphone_Z ;
      private String gxTv_SdtJC_Provider_Jc_providername ;
      private String gxTv_SdtJC_Provider_Jc_providershortname ;
      private String gxTv_SdtJC_Provider_Jc_provideraddresss ;
      private String gxTv_SdtJC_Provider_Jc_provideruser ;
      private String gxTv_SdtJC_Provider_Jc_providername_Z ;
      private String gxTv_SdtJC_Provider_Jc_providershortname_Z ;
      private String gxTv_SdtJC_Provider_Jc_provideraddresss_Z ;
      private String gxTv_SdtJC_Provider_Jc_provideruser_Z ;
   }

   [DataContract(Name = @"JC_Provider", Namespace = "DataAnalysisPlatform")]
   public class SdtJC_Provider_RESTInterface : GxGenericCollectionItem<SdtJC_Provider>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtJC_Provider_RESTInterface( ) : base()
      {
      }

      public SdtJC_Provider_RESTInterface( SdtJC_Provider psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "JC_ProviderID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Jc_providerid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Jc_providerid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Jc_providerid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "JC_ProviderName" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Jc_providername
      {
         get {
            return sdt.gxTpr_Jc_providername ;
         }

         set {
            sdt.gxTpr_Jc_providername = value;
         }

      }

      [DataMember( Name = "JC_ProviderShortName" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Jc_providershortname
      {
         get {
            return sdt.gxTpr_Jc_providershortname ;
         }

         set {
            sdt.gxTpr_Jc_providershortname = value;
         }

      }

      [DataMember( Name = "JC_ProviderAddresss" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Jc_provideraddresss
      {
         get {
            return sdt.gxTpr_Jc_provideraddresss ;
         }

         set {
            sdt.gxTpr_Jc_provideraddresss = value;
         }

      }

      [DataMember( Name = "JC_ProviderPhone" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Jc_providerphone
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Jc_providerphone) ;
         }

         set {
            sdt.gxTpr_Jc_providerphone = value;
         }

      }

      [DataMember( Name = "JC_ProviderUser" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Jc_provideruser
      {
         get {
            return sdt.gxTpr_Jc_provideruser ;
         }

         set {
            sdt.gxTpr_Jc_provideruser = value;
         }

      }

      public SdtJC_Provider sdt
      {
         get {
            return (SdtJC_Provider)Sdt ;
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
            sdt = new SdtJC_Provider() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 6 )]
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
