/*
               File: type_SdtSYS_TenantUserAccess
        Description: SYS_Tenant User Access
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:51.27
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
   [XmlRoot(ElementName = "SYS_TenantUserAccess" )]
   [XmlType(TypeName =  "SYS_TenantUserAccess" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_TenantUserAccess : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_TenantUserAccess( )
      {
      }

      public SdtSYS_TenantUserAccess( IGxContext context )
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

      public void Load( Guid AV437SYS_TenantUserAccessUserAccessID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(Guid)AV437SYS_TenantUserAccessUserAccessID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SYS_TenantUserAccessUserAccessID", typeof(Guid)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_TenantUserAccess");
         metadata.Set("BT", "SYS_TENANTUSERACCESS");
         metadata.Set("PK", "[ \"SYS_TenantUserAccessUserAccessID\" ]");
         metadata.Set("PKAssigned", "[ \"SYS_TenantUserAccessUserAccessID\" ]");
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
         state.Add("gxTpr_Sys_tenantuseraccessuseraccessid_Z");
         state.Add("gxTpr_Sys_tenantuseraccessuserid_Z");
         state.Add("gxTpr_Sys_tenantuseraccesstenantcode_Z");
         state.Add("gxTpr_Sys_tenantuseraccessdatapackage_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_TenantUserAccess sdt ;
         sdt = (SdtSYS_TenantUserAccess)(source);
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid = sdt.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid ;
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid = sdt.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid ;
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode = sdt.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode ;
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage = sdt.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage ;
         gxTv_SdtSYS_TenantUserAccess_Mode = sdt.gxTv_SdtSYS_TenantUserAccess_Mode ;
         gxTv_SdtSYS_TenantUserAccess_Initialized = sdt.gxTv_SdtSYS_TenantUserAccess_Initialized ;
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid_Z = sdt.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid_Z ;
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid_Z = sdt.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid_Z ;
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode_Z = sdt.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode_Z ;
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage_Z = sdt.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SYS_TenantUserAccessUserAccessID", gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid, false);
         AddObjectProperty("SYS_TenantUserAccessUserID", gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid, false);
         AddObjectProperty("SYS_TenantUserAccessTenantCode", gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode, false);
         AddObjectProperty("SYS_TenantUserAccessDataPackage", gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_TenantUserAccess_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_TenantUserAccess_Initialized, false);
            AddObjectProperty("SYS_TenantUserAccessUserAccessID_Z", gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid_Z, false);
            AddObjectProperty("SYS_TenantUserAccessUserID_Z", gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid_Z, false);
            AddObjectProperty("SYS_TenantUserAccessTenantCode_Z", gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode_Z, false);
            AddObjectProperty("SYS_TenantUserAccessDataPackage_Z", gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_TenantUserAccess sdt )
      {
         if ( sdt.IsDirty("SYS_TenantUserAccessUserAccessID") )
         {
            gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid = sdt.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid ;
         }
         if ( sdt.IsDirty("SYS_TenantUserAccessUserID") )
         {
            gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid = sdt.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid ;
         }
         if ( sdt.IsDirty("SYS_TenantUserAccessTenantCode") )
         {
            gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode = sdt.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode ;
         }
         if ( sdt.IsDirty("SYS_TenantUserAccessDataPackage") )
         {
            gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage = sdt.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SYS_TenantUserAccessUserAccessID" )]
      [  XmlElement( ElementName = "SYS_TenantUserAccessUserAccessID"   )]
      public Guid gxTpr_Sys_tenantuseraccessuseraccessid
      {
         get {
            return gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid ;
         }

         set {
            if ( gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid != value )
            {
               gxTv_SdtSYS_TenantUserAccess_Mode = "INS";
               this.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid_Z_SetNull( );
               this.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid_Z_SetNull( );
               this.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode_Z_SetNull( );
               this.gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage_Z_SetNull( );
            }
            gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid = (Guid)(value);
            SetDirty("Sys_tenantuseraccessuseraccessid");
         }

      }

      [  SoapElement( ElementName = "SYS_TenantUserAccessUserID" )]
      [  XmlElement( ElementName = "SYS_TenantUserAccessUserID"   )]
      public Guid gxTpr_Sys_tenantuseraccessuserid
      {
         get {
            return gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid ;
         }

         set {
            gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid = (Guid)(value);
            SetDirty("Sys_tenantuseraccessuserid");
         }

      }

      [  SoapElement( ElementName = "SYS_TenantUserAccessTenantCode" )]
      [  XmlElement( ElementName = "SYS_TenantUserAccessTenantCode"   )]
      public String gxTpr_Sys_tenantuseraccesstenantcode
      {
         get {
            return gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode ;
         }

         set {
            gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode = value;
            SetDirty("Sys_tenantuseraccesstenantcode");
         }

      }

      [  SoapElement( ElementName = "SYS_TenantUserAccessDataPackage" )]
      [  XmlElement( ElementName = "SYS_TenantUserAccessDataPackage"   )]
      public String gxTpr_Sys_tenantuseraccessdatapackage
      {
         get {
            return gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage ;
         }

         set {
            gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage = value;
            SetDirty("Sys_tenantuseraccessdatapackage");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_TenantUserAccess_Mode ;
         }

         set {
            gxTv_SdtSYS_TenantUserAccess_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_TenantUserAccess_Mode_SetNull( )
      {
         gxTv_SdtSYS_TenantUserAccess_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUserAccess_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_TenantUserAccess_Initialized ;
         }

         set {
            gxTv_SdtSYS_TenantUserAccess_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_TenantUserAccess_Initialized_SetNull( )
      {
         gxTv_SdtSYS_TenantUserAccess_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUserAccess_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_TenantUserAccessUserAccessID_Z" )]
      [  XmlElement( ElementName = "SYS_TenantUserAccessUserAccessID_Z"   )]
      public Guid gxTpr_Sys_tenantuseraccessuseraccessid_Z
      {
         get {
            return gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid_Z ;
         }

         set {
            gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid_Z = (Guid)(value);
            SetDirty("Sys_tenantuseraccessuseraccessid_Z");
         }

      }

      public void gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid_Z_SetNull( )
      {
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_TenantUserAccessUserID_Z" )]
      [  XmlElement( ElementName = "SYS_TenantUserAccessUserID_Z"   )]
      public Guid gxTpr_Sys_tenantuseraccessuserid_Z
      {
         get {
            return gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid_Z ;
         }

         set {
            gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid_Z = (Guid)(value);
            SetDirty("Sys_tenantuseraccessuserid_Z");
         }

      }

      public void gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid_Z_SetNull( )
      {
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_TenantUserAccessTenantCode_Z" )]
      [  XmlElement( ElementName = "SYS_TenantUserAccessTenantCode_Z"   )]
      public String gxTpr_Sys_tenantuseraccesstenantcode_Z
      {
         get {
            return gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode_Z ;
         }

         set {
            gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode_Z = value;
            SetDirty("Sys_tenantuseraccesstenantcode_Z");
         }

      }

      public void gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode_Z_SetNull( )
      {
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_TenantUserAccessDataPackage_Z" )]
      [  XmlElement( ElementName = "SYS_TenantUserAccessDataPackage_Z"   )]
      public String gxTpr_Sys_tenantuseraccessdatapackage_Z
      {
         get {
            return gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage_Z ;
         }

         set {
            gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage_Z = value;
            SetDirty("Sys_tenantuseraccessdatapackage_Z");
         }

      }

      public void gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage_Z_SetNull( )
      {
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode = "";
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage = "";
         gxTv_SdtSYS_TenantUserAccess_Mode = "";
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid_Z = (Guid)(Guid.Empty);
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid_Z = (Guid)(Guid.Empty);
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode_Z = "";
         gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_tenantuseraccess", "GeneXus.Programs.sys_tenantuseraccess_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_TenantUserAccess_Initialized ;
      private String gxTv_SdtSYS_TenantUserAccess_Mode ;
      private String gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode ;
      private String gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage ;
      private String gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccesstenantcode_Z ;
      private String gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessdatapackage_Z ;
      private Guid gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid ;
      private Guid gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid ;
      private Guid gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuseraccessid_Z ;
      private Guid gxTv_SdtSYS_TenantUserAccess_Sys_tenantuseraccessuserid_Z ;
   }

   [DataContract(Name = @"SYS_TenantUserAccess", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_TenantUserAccess_RESTInterface : GxGenericCollectionItem<SdtSYS_TenantUserAccess>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_TenantUserAccess_RESTInterface( ) : base()
      {
      }

      public SdtSYS_TenantUserAccess_RESTInterface( SdtSYS_TenantUserAccess psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SYS_TenantUserAccessUserAccessID" , Order = 0 )]
      [GxSeudo()]
      public Guid gxTpr_Sys_tenantuseraccessuseraccessid
      {
         get {
            return sdt.gxTpr_Sys_tenantuseraccessuseraccessid ;
         }

         set {
            sdt.gxTpr_Sys_tenantuseraccessuseraccessid = (Guid)(value);
         }

      }

      [DataMember( Name = "SYS_TenantUserAccessUserID" , Order = 1 )]
      [GxSeudo()]
      public Guid gxTpr_Sys_tenantuseraccessuserid
      {
         get {
            return sdt.gxTpr_Sys_tenantuseraccessuserid ;
         }

         set {
            sdt.gxTpr_Sys_tenantuseraccessuserid = (Guid)(value);
         }

      }

      [DataMember( Name = "SYS_TenantUserAccessTenantCode" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Sys_tenantuseraccesstenantcode
      {
         get {
            return sdt.gxTpr_Sys_tenantuseraccesstenantcode ;
         }

         set {
            sdt.gxTpr_Sys_tenantuseraccesstenantcode = value;
         }

      }

      [DataMember( Name = "SYS_TenantUserAccessDataPackage" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Sys_tenantuseraccessdatapackage
      {
         get {
            return sdt.gxTpr_Sys_tenantuseraccessdatapackage ;
         }

         set {
            sdt.gxTpr_Sys_tenantuseraccessdatapackage = value;
         }

      }

      public SdtSYS_TenantUserAccess sdt
      {
         get {
            return (SdtSYS_TenantUserAccess)Sdt ;
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
            sdt = new SdtSYS_TenantUserAccess() ;
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
