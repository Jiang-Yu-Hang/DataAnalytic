/*
               File: type_SdtJC_ProviderSecUser
        Description: 医院账号关系表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:21.72
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
   [XmlRoot(ElementName = "JC_ProviderSecUser" )]
   [XmlType(TypeName =  "JC_ProviderSecUser" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtJC_ProviderSecUser : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtJC_ProviderSecUser( )
      {
      }

      public SdtJC_ProviderSecUser( IGxContext context )
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

      public void Load( short AV6SecUserId ,
                        long AV87JC_ProviderID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV6SecUserId,(long)AV87JC_ProviderID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SecUserId", typeof(short)}, new Object[]{"JC_ProviderID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "JC_ProviderSecUser");
         metadata.Set("BT", "JC_ProviderSecUser");
         metadata.Set("PK", "[ \"SecUserId\",\"JC_ProviderID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"JC_ProviderID\" ],\"FKMap\":[  ] },{ \"FK\":[ \"SecUserId\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Secuserid_Z");
         state.Add("gxTpr_Jc_providerid_Z");
         state.Add("gxTpr_Secusername_Z");
         state.Add("gxTpr_Jc_providername_Z");
         state.Add("gxTpr_Jc_providername_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtJC_ProviderSecUser sdt ;
         sdt = (SdtJC_ProviderSecUser)(source);
         gxTv_SdtJC_ProviderSecUser_Secuserid = sdt.gxTv_SdtJC_ProviderSecUser_Secuserid ;
         gxTv_SdtJC_ProviderSecUser_Jc_providerid = sdt.gxTv_SdtJC_ProviderSecUser_Jc_providerid ;
         gxTv_SdtJC_ProviderSecUser_Secusername = sdt.gxTv_SdtJC_ProviderSecUser_Secusername ;
         gxTv_SdtJC_ProviderSecUser_Jc_providername = sdt.gxTv_SdtJC_ProviderSecUser_Jc_providername ;
         gxTv_SdtJC_ProviderSecUser_Mode = sdt.gxTv_SdtJC_ProviderSecUser_Mode ;
         gxTv_SdtJC_ProviderSecUser_Initialized = sdt.gxTv_SdtJC_ProviderSecUser_Initialized ;
         gxTv_SdtJC_ProviderSecUser_Secuserid_Z = sdt.gxTv_SdtJC_ProviderSecUser_Secuserid_Z ;
         gxTv_SdtJC_ProviderSecUser_Jc_providerid_Z = sdt.gxTv_SdtJC_ProviderSecUser_Jc_providerid_Z ;
         gxTv_SdtJC_ProviderSecUser_Secusername_Z = sdt.gxTv_SdtJC_ProviderSecUser_Secusername_Z ;
         gxTv_SdtJC_ProviderSecUser_Jc_providername_Z = sdt.gxTv_SdtJC_ProviderSecUser_Jc_providername_Z ;
         gxTv_SdtJC_ProviderSecUser_Jc_providername_N = sdt.gxTv_SdtJC_ProviderSecUser_Jc_providername_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SecUserId", gxTv_SdtJC_ProviderSecUser_Secuserid, false);
         AddObjectProperty("JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtJC_ProviderSecUser_Jc_providerid), 18, 0)), false);
         AddObjectProperty("SecUserName", gxTv_SdtJC_ProviderSecUser_Secusername, false);
         AddObjectProperty("JC_ProviderName", gxTv_SdtJC_ProviderSecUser_Jc_providername, false);
         AddObjectProperty("JC_ProviderName_N", gxTv_SdtJC_ProviderSecUser_Jc_providername_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtJC_ProviderSecUser_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtJC_ProviderSecUser_Initialized, false);
            AddObjectProperty("SecUserId_Z", gxTv_SdtJC_ProviderSecUser_Secuserid_Z, false);
            AddObjectProperty("JC_ProviderID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtJC_ProviderSecUser_Jc_providerid_Z), 18, 0)), false);
            AddObjectProperty("SecUserName_Z", gxTv_SdtJC_ProviderSecUser_Secusername_Z, false);
            AddObjectProperty("JC_ProviderName_Z", gxTv_SdtJC_ProviderSecUser_Jc_providername_Z, false);
            AddObjectProperty("JC_ProviderName_N", gxTv_SdtJC_ProviderSecUser_Jc_providername_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtJC_ProviderSecUser sdt )
      {
         if ( sdt.IsDirty("SecUserId") )
         {
            gxTv_SdtJC_ProviderSecUser_Secuserid = sdt.gxTv_SdtJC_ProviderSecUser_Secuserid ;
         }
         if ( sdt.IsDirty("JC_ProviderID") )
         {
            gxTv_SdtJC_ProviderSecUser_Jc_providerid = sdt.gxTv_SdtJC_ProviderSecUser_Jc_providerid ;
         }
         if ( sdt.IsDirty("SecUserName") )
         {
            gxTv_SdtJC_ProviderSecUser_Secusername = sdt.gxTv_SdtJC_ProviderSecUser_Secusername ;
         }
         if ( sdt.IsDirty("JC_ProviderName") )
         {
            gxTv_SdtJC_ProviderSecUser_Jc_providername = sdt.gxTv_SdtJC_ProviderSecUser_Jc_providername ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SecUserId" )]
      [  XmlElement( ElementName = "SecUserId"   )]
      public short gxTpr_Secuserid
      {
         get {
            return gxTv_SdtJC_ProviderSecUser_Secuserid ;
         }

         set {
            if ( gxTv_SdtJC_ProviderSecUser_Secuserid != value )
            {
               gxTv_SdtJC_ProviderSecUser_Mode = "INS";
               this.gxTv_SdtJC_ProviderSecUser_Secuserid_Z_SetNull( );
               this.gxTv_SdtJC_ProviderSecUser_Jc_providerid_Z_SetNull( );
               this.gxTv_SdtJC_ProviderSecUser_Secusername_Z_SetNull( );
               this.gxTv_SdtJC_ProviderSecUser_Jc_providername_Z_SetNull( );
            }
            gxTv_SdtJC_ProviderSecUser_Secuserid = value;
            SetDirty("Secuserid");
         }

      }

      [  SoapElement( ElementName = "JC_ProviderID" )]
      [  XmlElement( ElementName = "JC_ProviderID"   )]
      public long gxTpr_Jc_providerid
      {
         get {
            return gxTv_SdtJC_ProviderSecUser_Jc_providerid ;
         }

         set {
            if ( gxTv_SdtJC_ProviderSecUser_Jc_providerid != value )
            {
               gxTv_SdtJC_ProviderSecUser_Mode = "INS";
               this.gxTv_SdtJC_ProviderSecUser_Secuserid_Z_SetNull( );
               this.gxTv_SdtJC_ProviderSecUser_Jc_providerid_Z_SetNull( );
               this.gxTv_SdtJC_ProviderSecUser_Secusername_Z_SetNull( );
               this.gxTv_SdtJC_ProviderSecUser_Jc_providername_Z_SetNull( );
            }
            gxTv_SdtJC_ProviderSecUser_Jc_providerid = value;
            SetDirty("Jc_providerid");
         }

      }

      [  SoapElement( ElementName = "SecUserName" )]
      [  XmlElement( ElementName = "SecUserName"   )]
      public String gxTpr_Secusername
      {
         get {
            return gxTv_SdtJC_ProviderSecUser_Secusername ;
         }

         set {
            gxTv_SdtJC_ProviderSecUser_Secusername = value;
            SetDirty("Secusername");
         }

      }

      [  SoapElement( ElementName = "JC_ProviderName" )]
      [  XmlElement( ElementName = "JC_ProviderName"   )]
      public String gxTpr_Jc_providername
      {
         get {
            return gxTv_SdtJC_ProviderSecUser_Jc_providername ;
         }

         set {
            gxTv_SdtJC_ProviderSecUser_Jc_providername_N = 0;
            gxTv_SdtJC_ProviderSecUser_Jc_providername = value;
            SetDirty("Jc_providername");
         }

      }

      public void gxTv_SdtJC_ProviderSecUser_Jc_providername_SetNull( )
      {
         gxTv_SdtJC_ProviderSecUser_Jc_providername_N = 1;
         gxTv_SdtJC_ProviderSecUser_Jc_providername = "";
         return  ;
      }

      public bool gxTv_SdtJC_ProviderSecUser_Jc_providername_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtJC_ProviderSecUser_Mode ;
         }

         set {
            gxTv_SdtJC_ProviderSecUser_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtJC_ProviderSecUser_Mode_SetNull( )
      {
         gxTv_SdtJC_ProviderSecUser_Mode = "";
         return  ;
      }

      public bool gxTv_SdtJC_ProviderSecUser_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtJC_ProviderSecUser_Initialized ;
         }

         set {
            gxTv_SdtJC_ProviderSecUser_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtJC_ProviderSecUser_Initialized_SetNull( )
      {
         gxTv_SdtJC_ProviderSecUser_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtJC_ProviderSecUser_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserId_Z" )]
      [  XmlElement( ElementName = "SecUserId_Z"   )]
      public short gxTpr_Secuserid_Z
      {
         get {
            return gxTv_SdtJC_ProviderSecUser_Secuserid_Z ;
         }

         set {
            gxTv_SdtJC_ProviderSecUser_Secuserid_Z = value;
            SetDirty("Secuserid_Z");
         }

      }

      public void gxTv_SdtJC_ProviderSecUser_Secuserid_Z_SetNull( )
      {
         gxTv_SdtJC_ProviderSecUser_Secuserid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtJC_ProviderSecUser_Secuserid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderID_Z" )]
      [  XmlElement( ElementName = "JC_ProviderID_Z"   )]
      public long gxTpr_Jc_providerid_Z
      {
         get {
            return gxTv_SdtJC_ProviderSecUser_Jc_providerid_Z ;
         }

         set {
            gxTv_SdtJC_ProviderSecUser_Jc_providerid_Z = value;
            SetDirty("Jc_providerid_Z");
         }

      }

      public void gxTv_SdtJC_ProviderSecUser_Jc_providerid_Z_SetNull( )
      {
         gxTv_SdtJC_ProviderSecUser_Jc_providerid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtJC_ProviderSecUser_Jc_providerid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserName_Z" )]
      [  XmlElement( ElementName = "SecUserName_Z"   )]
      public String gxTpr_Secusername_Z
      {
         get {
            return gxTv_SdtJC_ProviderSecUser_Secusername_Z ;
         }

         set {
            gxTv_SdtJC_ProviderSecUser_Secusername_Z = value;
            SetDirty("Secusername_Z");
         }

      }

      public void gxTv_SdtJC_ProviderSecUser_Secusername_Z_SetNull( )
      {
         gxTv_SdtJC_ProviderSecUser_Secusername_Z = "";
         return  ;
      }

      public bool gxTv_SdtJC_ProviderSecUser_Secusername_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderName_Z" )]
      [  XmlElement( ElementName = "JC_ProviderName_Z"   )]
      public String gxTpr_Jc_providername_Z
      {
         get {
            return gxTv_SdtJC_ProviderSecUser_Jc_providername_Z ;
         }

         set {
            gxTv_SdtJC_ProviderSecUser_Jc_providername_Z = value;
            SetDirty("Jc_providername_Z");
         }

      }

      public void gxTv_SdtJC_ProviderSecUser_Jc_providername_Z_SetNull( )
      {
         gxTv_SdtJC_ProviderSecUser_Jc_providername_Z = "";
         return  ;
      }

      public bool gxTv_SdtJC_ProviderSecUser_Jc_providername_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderName_N" )]
      [  XmlElement( ElementName = "JC_ProviderName_N"   )]
      public short gxTpr_Jc_providername_N
      {
         get {
            return gxTv_SdtJC_ProviderSecUser_Jc_providername_N ;
         }

         set {
            gxTv_SdtJC_ProviderSecUser_Jc_providername_N = value;
            SetDirty("Jc_providername_N");
         }

      }

      public void gxTv_SdtJC_ProviderSecUser_Jc_providername_N_SetNull( )
      {
         gxTv_SdtJC_ProviderSecUser_Jc_providername_N = 0;
         return  ;
      }

      public bool gxTv_SdtJC_ProviderSecUser_Jc_providername_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtJC_ProviderSecUser_Secusername = "";
         gxTv_SdtJC_ProviderSecUser_Jc_providername = "";
         gxTv_SdtJC_ProviderSecUser_Mode = "";
         gxTv_SdtJC_ProviderSecUser_Secusername_Z = "";
         gxTv_SdtJC_ProviderSecUser_Jc_providername_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "jc_providersecuser", "GeneXus.Programs.jc_providersecuser_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtJC_ProviderSecUser_Secuserid ;
      private short gxTv_SdtJC_ProviderSecUser_Initialized ;
      private short gxTv_SdtJC_ProviderSecUser_Secuserid_Z ;
      private short gxTv_SdtJC_ProviderSecUser_Jc_providername_N ;
      private long gxTv_SdtJC_ProviderSecUser_Jc_providerid ;
      private long gxTv_SdtJC_ProviderSecUser_Jc_providerid_Z ;
      private String gxTv_SdtJC_ProviderSecUser_Mode ;
      private String gxTv_SdtJC_ProviderSecUser_Secusername ;
      private String gxTv_SdtJC_ProviderSecUser_Jc_providername ;
      private String gxTv_SdtJC_ProviderSecUser_Secusername_Z ;
      private String gxTv_SdtJC_ProviderSecUser_Jc_providername_Z ;
   }

   [DataContract(Name = @"JC_ProviderSecUser", Namespace = "DataAnalysisPlatform")]
   public class SdtJC_ProviderSecUser_RESTInterface : GxGenericCollectionItem<SdtJC_ProviderSecUser>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtJC_ProviderSecUser_RESTInterface( ) : base()
      {
      }

      public SdtJC_ProviderSecUser_RESTInterface( SdtJC_ProviderSecUser psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SecUserId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Secuserid
      {
         get {
            return sdt.gxTpr_Secuserid ;
         }

         set {
            sdt.gxTpr_Secuserid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "JC_ProviderID" , Order = 1 )]
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

      [DataMember( Name = "SecUserName" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Secusername
      {
         get {
            return sdt.gxTpr_Secusername ;
         }

         set {
            sdt.gxTpr_Secusername = value;
         }

      }

      [DataMember( Name = "JC_ProviderName" , Order = 3 )]
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

      public SdtJC_ProviderSecUser sdt
      {
         get {
            return (SdtJC_ProviderSecUser)Sdt ;
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
            sdt = new SdtJC_ProviderSecUser() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 4 )]
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
