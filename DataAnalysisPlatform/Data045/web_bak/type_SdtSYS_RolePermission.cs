/*
               File: type_SdtSYS_RolePermission
        Description: SYS_Role Permission
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:0.78
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
   [XmlRoot(ElementName = "SYS_RolePermission" )]
   [XmlType(TypeName =  "SYS_RolePermission" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_RolePermission : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_RolePermission( )
      {
      }

      public SdtSYS_RolePermission( IGxContext context )
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

      public void Load( Guid AV444SYS_RolePermissionRoleID ,
                        String AV445SYS_RolePermissionPermissionCode )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(Guid)AV444SYS_RolePermissionRoleID,(String)AV445SYS_RolePermissionPermissionCode});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SYS_RolePermissionRoleID", typeof(Guid)}, new Object[]{"SYS_RolePermissionPermissionCode", typeof(String)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_RolePermission");
         metadata.Set("BT", "SYS_ROLEPERMISSION");
         metadata.Set("PK", "[ \"SYS_RolePermissionRoleID\",\"SYS_RolePermissionPermissionCode\" ]");
         metadata.Set("PKAssigned", "[ \"SYS_RolePermissionRoleID\" ]");
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
         state.Add("gxTpr_Sys_rolepermissionroleid_Z");
         state.Add("gxTpr_Sys_rolepermissionpermissioncode_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_RolePermission sdt ;
         sdt = (SdtSYS_RolePermission)(source);
         gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid = sdt.gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid ;
         gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode = sdt.gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode ;
         gxTv_SdtSYS_RolePermission_Mode = sdt.gxTv_SdtSYS_RolePermission_Mode ;
         gxTv_SdtSYS_RolePermission_Initialized = sdt.gxTv_SdtSYS_RolePermission_Initialized ;
         gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid_Z = sdt.gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid_Z ;
         gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode_Z = sdt.gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SYS_RolePermissionRoleID", gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid, false);
         AddObjectProperty("SYS_RolePermissionPermissionCode", gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_RolePermission_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_RolePermission_Initialized, false);
            AddObjectProperty("SYS_RolePermissionRoleID_Z", gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid_Z, false);
            AddObjectProperty("SYS_RolePermissionPermissionCode_Z", gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_RolePermission sdt )
      {
         if ( sdt.IsDirty("SYS_RolePermissionRoleID") )
         {
            gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid = sdt.gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid ;
         }
         if ( sdt.IsDirty("SYS_RolePermissionPermissionCode") )
         {
            gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode = sdt.gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SYS_RolePermissionRoleID" )]
      [  XmlElement( ElementName = "SYS_RolePermissionRoleID"   )]
      public Guid gxTpr_Sys_rolepermissionroleid
      {
         get {
            return gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid ;
         }

         set {
            if ( gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid != value )
            {
               gxTv_SdtSYS_RolePermission_Mode = "INS";
               this.gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid_Z_SetNull( );
               this.gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode_Z_SetNull( );
            }
            gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid = (Guid)(value);
            SetDirty("Sys_rolepermissionroleid");
         }

      }

      [  SoapElement( ElementName = "SYS_RolePermissionPermissionCode" )]
      [  XmlElement( ElementName = "SYS_RolePermissionPermissionCode"   )]
      public String gxTpr_Sys_rolepermissionpermissioncode
      {
         get {
            return gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode, value) != 0 )
            {
               gxTv_SdtSYS_RolePermission_Mode = "INS";
               this.gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid_Z_SetNull( );
               this.gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode_Z_SetNull( );
            }
            gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode = value;
            SetDirty("Sys_rolepermissionpermissioncode");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_RolePermission_Mode ;
         }

         set {
            gxTv_SdtSYS_RolePermission_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_RolePermission_Mode_SetNull( )
      {
         gxTv_SdtSYS_RolePermission_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_RolePermission_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_RolePermission_Initialized ;
         }

         set {
            gxTv_SdtSYS_RolePermission_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_RolePermission_Initialized_SetNull( )
      {
         gxTv_SdtSYS_RolePermission_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_RolePermission_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RolePermissionRoleID_Z" )]
      [  XmlElement( ElementName = "SYS_RolePermissionRoleID_Z"   )]
      public Guid gxTpr_Sys_rolepermissionroleid_Z
      {
         get {
            return gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid_Z ;
         }

         set {
            gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid_Z = (Guid)(value);
            SetDirty("Sys_rolepermissionroleid_Z");
         }

      }

      public void gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid_Z_SetNull( )
      {
         gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RolePermissionPermissionCode_Z" )]
      [  XmlElement( ElementName = "SYS_RolePermissionPermissionCode_Z"   )]
      public String gxTpr_Sys_rolepermissionpermissioncode_Z
      {
         get {
            return gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode_Z ;
         }

         set {
            gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode_Z = value;
            SetDirty("Sys_rolepermissionpermissioncode_Z");
         }

      }

      public void gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode_Z_SetNull( )
      {
         gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode = "";
         gxTv_SdtSYS_RolePermission_Mode = "";
         gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid_Z = (Guid)(Guid.Empty);
         gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_rolepermission", "GeneXus.Programs.sys_rolepermission_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_RolePermission_Initialized ;
      private String gxTv_SdtSYS_RolePermission_Mode ;
      private String gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode ;
      private String gxTv_SdtSYS_RolePermission_Sys_rolepermissionpermissioncode_Z ;
      private Guid gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid ;
      private Guid gxTv_SdtSYS_RolePermission_Sys_rolepermissionroleid_Z ;
   }

   [DataContract(Name = @"SYS_RolePermission", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_RolePermission_RESTInterface : GxGenericCollectionItem<SdtSYS_RolePermission>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_RolePermission_RESTInterface( ) : base()
      {
      }

      public SdtSYS_RolePermission_RESTInterface( SdtSYS_RolePermission psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SYS_RolePermissionRoleID" , Order = 0 )]
      [GxSeudo()]
      public Guid gxTpr_Sys_rolepermissionroleid
      {
         get {
            return sdt.gxTpr_Sys_rolepermissionroleid ;
         }

         set {
            sdt.gxTpr_Sys_rolepermissionroleid = (Guid)(value);
         }

      }

      [DataMember( Name = "SYS_RolePermissionPermissionCode" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Sys_rolepermissionpermissioncode
      {
         get {
            return sdt.gxTpr_Sys_rolepermissionpermissioncode ;
         }

         set {
            sdt.gxTpr_Sys_rolepermissionpermissioncode = value;
         }

      }

      public SdtSYS_RolePermission sdt
      {
         get {
            return (SdtSYS_RolePermission)Sdt ;
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
            sdt = new SdtSYS_RolePermission() ;
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
