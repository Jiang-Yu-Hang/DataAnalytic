/*
               File: type_SdtSYS_TenantUserRole
        Description: SYS_Tenant User Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:0.35
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
   [XmlRoot(ElementName = "SYS_TenantUserRole" )]
   [XmlType(TypeName =  "SYS_TenantUserRole" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_TenantUserRole : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_TenantUserRole( )
      {
      }

      public SdtSYS_TenantUserRole( IGxContext context )
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

      public void Load( Guid AV370SYS_TenantUserRoleUserRoleID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(Guid)AV370SYS_TenantUserRoleUserRoleID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SYS_TenantUserRoleUserRoleID", typeof(Guid)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_TenantUserRole");
         metadata.Set("BT", "SYS_TENANTUSERROLE");
         metadata.Set("PK", "[ \"SYS_TenantUserRoleUserRoleID\" ]");
         metadata.Set("PKAssigned", "[ \"SYS_TenantUserRoleUserRoleID\" ]");
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
         state.Add("gxTpr_Sys_tenantuserroleuserroleid_Z");
         state.Add("gxTpr_Sys_tenantuserroleuserid_Z");
         state.Add("gxTpr_Sys_tenantuserroletenantcode_Z");
         state.Add("gxTpr_Sys_tenantuserroleroleid_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_TenantUserRole sdt ;
         sdt = (SdtSYS_TenantUserRole)(source);
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid = sdt.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid ;
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid = sdt.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid ;
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode = sdt.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode ;
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid = sdt.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid ;
         gxTv_SdtSYS_TenantUserRole_Mode = sdt.gxTv_SdtSYS_TenantUserRole_Mode ;
         gxTv_SdtSYS_TenantUserRole_Initialized = sdt.gxTv_SdtSYS_TenantUserRole_Initialized ;
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid_Z = sdt.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid_Z ;
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid_Z = sdt.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid_Z ;
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode_Z = sdt.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode_Z ;
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid_Z = sdt.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SYS_TenantUserRoleUserRoleID", gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid, false);
         AddObjectProperty("SYS_TenantUserRoleUserID", gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid, false);
         AddObjectProperty("SYS_TenantUserRoleTenantCode", gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode, false);
         AddObjectProperty("SYS_TenantUserRoleRoleID", gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_TenantUserRole_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_TenantUserRole_Initialized, false);
            AddObjectProperty("SYS_TenantUserRoleUserRoleID_Z", gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid_Z, false);
            AddObjectProperty("SYS_TenantUserRoleUserID_Z", gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid_Z, false);
            AddObjectProperty("SYS_TenantUserRoleTenantCode_Z", gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode_Z, false);
            AddObjectProperty("SYS_TenantUserRoleRoleID_Z", gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_TenantUserRole sdt )
      {
         if ( sdt.IsDirty("SYS_TenantUserRoleUserRoleID") )
         {
            gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid = sdt.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid ;
         }
         if ( sdt.IsDirty("SYS_TenantUserRoleUserID") )
         {
            gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid = sdt.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid ;
         }
         if ( sdt.IsDirty("SYS_TenantUserRoleTenantCode") )
         {
            gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode = sdt.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode ;
         }
         if ( sdt.IsDirty("SYS_TenantUserRoleRoleID") )
         {
            gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid = sdt.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SYS_TenantUserRoleUserRoleID" )]
      [  XmlElement( ElementName = "SYS_TenantUserRoleUserRoleID"   )]
      public Guid gxTpr_Sys_tenantuserroleuserroleid
      {
         get {
            return gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid ;
         }

         set {
            if ( gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid != value )
            {
               gxTv_SdtSYS_TenantUserRole_Mode = "INS";
               this.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid_Z_SetNull( );
               this.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid_Z_SetNull( );
               this.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode_Z_SetNull( );
               this.gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid_Z_SetNull( );
            }
            gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid = (Guid)(value);
            SetDirty("Sys_tenantuserroleuserroleid");
         }

      }

      [  SoapElement( ElementName = "SYS_TenantUserRoleUserID" )]
      [  XmlElement( ElementName = "SYS_TenantUserRoleUserID"   )]
      public Guid gxTpr_Sys_tenantuserroleuserid
      {
         get {
            return gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid ;
         }

         set {
            gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid = (Guid)(value);
            SetDirty("Sys_tenantuserroleuserid");
         }

      }

      [  SoapElement( ElementName = "SYS_TenantUserRoleTenantCode" )]
      [  XmlElement( ElementName = "SYS_TenantUserRoleTenantCode"   )]
      public String gxTpr_Sys_tenantuserroletenantcode
      {
         get {
            return gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode ;
         }

         set {
            gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode = value;
            SetDirty("Sys_tenantuserroletenantcode");
         }

      }

      [  SoapElement( ElementName = "SYS_TenantUserRoleRoleID" )]
      [  XmlElement( ElementName = "SYS_TenantUserRoleRoleID"   )]
      public Guid gxTpr_Sys_tenantuserroleroleid
      {
         get {
            return gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid ;
         }

         set {
            gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid = (Guid)(value);
            SetDirty("Sys_tenantuserroleroleid");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_TenantUserRole_Mode ;
         }

         set {
            gxTv_SdtSYS_TenantUserRole_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_TenantUserRole_Mode_SetNull( )
      {
         gxTv_SdtSYS_TenantUserRole_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUserRole_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_TenantUserRole_Initialized ;
         }

         set {
            gxTv_SdtSYS_TenantUserRole_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_TenantUserRole_Initialized_SetNull( )
      {
         gxTv_SdtSYS_TenantUserRole_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUserRole_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_TenantUserRoleUserRoleID_Z" )]
      [  XmlElement( ElementName = "SYS_TenantUserRoleUserRoleID_Z"   )]
      public Guid gxTpr_Sys_tenantuserroleuserroleid_Z
      {
         get {
            return gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid_Z ;
         }

         set {
            gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid_Z = (Guid)(value);
            SetDirty("Sys_tenantuserroleuserroleid_Z");
         }

      }

      public void gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid_Z_SetNull( )
      {
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_TenantUserRoleUserID_Z" )]
      [  XmlElement( ElementName = "SYS_TenantUserRoleUserID_Z"   )]
      public Guid gxTpr_Sys_tenantuserroleuserid_Z
      {
         get {
            return gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid_Z ;
         }

         set {
            gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid_Z = (Guid)(value);
            SetDirty("Sys_tenantuserroleuserid_Z");
         }

      }

      public void gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid_Z_SetNull( )
      {
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_TenantUserRoleTenantCode_Z" )]
      [  XmlElement( ElementName = "SYS_TenantUserRoleTenantCode_Z"   )]
      public String gxTpr_Sys_tenantuserroletenantcode_Z
      {
         get {
            return gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode_Z ;
         }

         set {
            gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode_Z = value;
            SetDirty("Sys_tenantuserroletenantcode_Z");
         }

      }

      public void gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode_Z_SetNull( )
      {
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_TenantUserRoleRoleID_Z" )]
      [  XmlElement( ElementName = "SYS_TenantUserRoleRoleID_Z"   )]
      public Guid gxTpr_Sys_tenantuserroleroleid_Z
      {
         get {
            return gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid_Z ;
         }

         set {
            gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid_Z = (Guid)(value);
            SetDirty("Sys_tenantuserroleroleid_Z");
         }

      }

      public void gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid_Z_SetNull( )
      {
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode = "";
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_TenantUserRole_Mode = "";
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid_Z = (Guid)(Guid.Empty);
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid_Z = (Guid)(Guid.Empty);
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode_Z = "";
         gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid_Z = (Guid)(Guid.Empty);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_tenantuserrole", "GeneXus.Programs.sys_tenantuserrole_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_TenantUserRole_Initialized ;
      private String gxTv_SdtSYS_TenantUserRole_Mode ;
      private String gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode ;
      private String gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroletenantcode_Z ;
      private Guid gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid ;
      private Guid gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid ;
      private Guid gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid ;
      private Guid gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserroleid_Z ;
      private Guid gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleuserid_Z ;
      private Guid gxTv_SdtSYS_TenantUserRole_Sys_tenantuserroleroleid_Z ;
   }

   [DataContract(Name = @"SYS_TenantUserRole", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_TenantUserRole_RESTInterface : GxGenericCollectionItem<SdtSYS_TenantUserRole>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_TenantUserRole_RESTInterface( ) : base()
      {
      }

      public SdtSYS_TenantUserRole_RESTInterface( SdtSYS_TenantUserRole psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SYS_TenantUserRoleUserRoleID" , Order = 0 )]
      [GxSeudo()]
      public Guid gxTpr_Sys_tenantuserroleuserroleid
      {
         get {
            return sdt.gxTpr_Sys_tenantuserroleuserroleid ;
         }

         set {
            sdt.gxTpr_Sys_tenantuserroleuserroleid = (Guid)(value);
         }

      }

      [DataMember( Name = "SYS_TenantUserRoleUserID" , Order = 1 )]
      [GxSeudo()]
      public Guid gxTpr_Sys_tenantuserroleuserid
      {
         get {
            return sdt.gxTpr_Sys_tenantuserroleuserid ;
         }

         set {
            sdt.gxTpr_Sys_tenantuserroleuserid = (Guid)(value);
         }

      }

      [DataMember( Name = "SYS_TenantUserRoleTenantCode" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Sys_tenantuserroletenantcode
      {
         get {
            return sdt.gxTpr_Sys_tenantuserroletenantcode ;
         }

         set {
            sdt.gxTpr_Sys_tenantuserroletenantcode = value;
         }

      }

      [DataMember( Name = "SYS_TenantUserRoleRoleID" , Order = 3 )]
      [GxSeudo()]
      public Guid gxTpr_Sys_tenantuserroleroleid
      {
         get {
            return sdt.gxTpr_Sys_tenantuserroleroleid ;
         }

         set {
            sdt.gxTpr_Sys_tenantuserroleroleid = (Guid)(value);
         }

      }

      public SdtSYS_TenantUserRole sdt
      {
         get {
            return (SdtSYS_TenantUserRole)Sdt ;
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
            sdt = new SdtSYS_TenantUserRole() ;
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
