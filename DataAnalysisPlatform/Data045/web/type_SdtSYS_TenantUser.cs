/*
               File: type_SdtSYS_TenantUser
        Description: SYS_Tenant User
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:49.92
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
   [XmlRoot(ElementName = "SYS_TenantUser" )]
   [XmlType(TypeName =  "SYS_TenantUser" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_TenantUser : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_TenantUser( )
      {
      }

      public SdtSYS_TenantUser( IGxContext context )
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

      public void Load( String AV360BAS_TenantTenantCode ,
                        Guid AV359UserID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(String)AV360BAS_TenantTenantCode,(Guid)AV359UserID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BAS_TenantTenantCode", typeof(String)}, new Object[]{"UserID", typeof(Guid)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_TenantUser");
         metadata.Set("BT", "SYS_TENANTUSER");
         metadata.Set("PK", "[ \"BAS_TenantTenantCode\",\"UserID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BAS_TenantTenantCode\" ],\"FKMap\":[  ] },{ \"FK\":[ \"UserID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Bas_tenanttenantcode_Z");
         state.Add("gxTpr_Userid_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_TenantUser sdt ;
         sdt = (SdtSYS_TenantUser)(source);
         gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode = sdt.gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode ;
         gxTv_SdtSYS_TenantUser_Userid = sdt.gxTv_SdtSYS_TenantUser_Userid ;
         gxTv_SdtSYS_TenantUser_Mode = sdt.gxTv_SdtSYS_TenantUser_Mode ;
         gxTv_SdtSYS_TenantUser_Initialized = sdt.gxTv_SdtSYS_TenantUser_Initialized ;
         gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode_Z = sdt.gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode_Z ;
         gxTv_SdtSYS_TenantUser_Userid_Z = sdt.gxTv_SdtSYS_TenantUser_Userid_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BAS_TenantTenantCode", gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode, false);
         AddObjectProperty("UserID", gxTv_SdtSYS_TenantUser_Userid, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_TenantUser_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_TenantUser_Initialized, false);
            AddObjectProperty("BAS_TenantTenantCode_Z", gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode_Z, false);
            AddObjectProperty("UserID_Z", gxTv_SdtSYS_TenantUser_Userid_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_TenantUser sdt )
      {
         if ( sdt.IsDirty("BAS_TenantTenantCode") )
         {
            gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode = sdt.gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode ;
         }
         if ( sdt.IsDirty("UserID") )
         {
            gxTv_SdtSYS_TenantUser_Userid = sdt.gxTv_SdtSYS_TenantUser_Userid ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BAS_TenantTenantCode" )]
      [  XmlElement( ElementName = "BAS_TenantTenantCode"   )]
      public String gxTpr_Bas_tenanttenantcode
      {
         get {
            return gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode, value) != 0 )
            {
               gxTv_SdtSYS_TenantUser_Mode = "INS";
               this.gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode_Z_SetNull( );
               this.gxTv_SdtSYS_TenantUser_Userid_Z_SetNull( );
            }
            gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode = value;
            SetDirty("Bas_tenanttenantcode");
         }

      }

      [  SoapElement( ElementName = "UserID" )]
      [  XmlElement( ElementName = "UserID"   )]
      public Guid gxTpr_Userid
      {
         get {
            return gxTv_SdtSYS_TenantUser_Userid ;
         }

         set {
            if ( gxTv_SdtSYS_TenantUser_Userid != value )
            {
               gxTv_SdtSYS_TenantUser_Mode = "INS";
               this.gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode_Z_SetNull( );
               this.gxTv_SdtSYS_TenantUser_Userid_Z_SetNull( );
            }
            gxTv_SdtSYS_TenantUser_Userid = (Guid)(value);
            SetDirty("Userid");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_TenantUser_Mode ;
         }

         set {
            gxTv_SdtSYS_TenantUser_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_TenantUser_Mode_SetNull( )
      {
         gxTv_SdtSYS_TenantUser_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUser_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_TenantUser_Initialized ;
         }

         set {
            gxTv_SdtSYS_TenantUser_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_TenantUser_Initialized_SetNull( )
      {
         gxTv_SdtSYS_TenantUser_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUser_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantTenantCode_Z" )]
      [  XmlElement( ElementName = "BAS_TenantTenantCode_Z"   )]
      public String gxTpr_Bas_tenanttenantcode_Z
      {
         get {
            return gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode_Z ;
         }

         set {
            gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode_Z = value;
            SetDirty("Bas_tenanttenantcode_Z");
         }

      }

      public void gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode_Z_SetNull( )
      {
         gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UserID_Z" )]
      [  XmlElement( ElementName = "UserID_Z"   )]
      public Guid gxTpr_Userid_Z
      {
         get {
            return gxTv_SdtSYS_TenantUser_Userid_Z ;
         }

         set {
            gxTv_SdtSYS_TenantUser_Userid_Z = (Guid)(value);
            SetDirty("Userid_Z");
         }

      }

      public void gxTv_SdtSYS_TenantUser_Userid_Z_SetNull( )
      {
         gxTv_SdtSYS_TenantUser_Userid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUser_Userid_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode = "";
         gxTv_SdtSYS_TenantUser_Userid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_TenantUser_Mode = "";
         gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode_Z = "";
         gxTv_SdtSYS_TenantUser_Userid_Z = (Guid)(Guid.Empty);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_tenantuser", "GeneXus.Programs.sys_tenantuser_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_TenantUser_Initialized ;
      private String gxTv_SdtSYS_TenantUser_Mode ;
      private String gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode ;
      private String gxTv_SdtSYS_TenantUser_Bas_tenanttenantcode_Z ;
      private Guid gxTv_SdtSYS_TenantUser_Userid ;
      private Guid gxTv_SdtSYS_TenantUser_Userid_Z ;
   }

   [DataContract(Name = @"SYS_TenantUser", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_TenantUser_RESTInterface : GxGenericCollectionItem<SdtSYS_TenantUser>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_TenantUser_RESTInterface( ) : base()
      {
      }

      public SdtSYS_TenantUser_RESTInterface( SdtSYS_TenantUser psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BAS_TenantTenantCode" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Bas_tenanttenantcode
      {
         get {
            return sdt.gxTpr_Bas_tenanttenantcode ;
         }

         set {
            sdt.gxTpr_Bas_tenanttenantcode = value;
         }

      }

      [DataMember( Name = "UserID" , Order = 1 )]
      [GxSeudo()]
      public Guid gxTpr_Userid
      {
         get {
            return sdt.gxTpr_Userid ;
         }

         set {
            sdt.gxTpr_Userid = (Guid)(value);
         }

      }

      public SdtSYS_TenantUser sdt
      {
         get {
            return (SdtSYS_TenantUser)Sdt ;
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
            sdt = new SdtSYS_TenantUser() ;
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
